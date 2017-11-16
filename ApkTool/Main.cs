using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ApkTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static Version ApplicationVersion = new Version(Application.ProductVersion);
        string AppVersion = ApplicationVersion.ToString();

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "APK 辅助解析工具 - " + AppVersion;
        }
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                Program.api.ApkPath = Ofd.FileName;

                Program.api.OnAAptMiss = () => {
                    RunInMainthread(() => {
                        MessageBox.Show(this, "解析apk文件所需要的组件aapt.exe遗失，请下载此程序完整组件然后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    });
                };

                Program.api.OnUzipMiss = () => {
                    RunInMainthread(() => {
                        MessageBox.Show(this, "解析apk文件所需要的组件Uzip.exe遗失，请下载此程序完整组件然后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    });
                };

                Program.api.OnDumpFail = () => {
                    RunInMainthread(() => {
                        //MessageBox.Show(this, "解析apk文件所需要的组件Uzip.exe遗失，请下载此程序完整组件然后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    });
                };

                Program.api.OnDumpSuccess = () => {
                    RunInMainthread(() => {
                        txtApplication.Text = Program.api.AppName;
                        txtVersion.Text = Program.api.AppVersion;
                        txtVersionCode.Text = Program.api.AppVersionCode;
                        txtPackage.Text = Program.api.PkgName;
                        txtIconPath.Text = Program.api.IconPath;
                        txtMinSdk.Text = Program.api.MinSdk;
                        txtMinVersion.Text = Program.api.MinVersion;
                        txtScreenSize.Text = Program.api.ScreenSupport;
                        txtScreenSolution.Text = Program.api.ScreenSolutions;
                        txtPermission.Text = Program.api.Permissions;
                        txtFeature.Text = Program.api.Features;
                        imgIcon.Image = (Program.api.AppIcon != null) ? Program.api.AppIcon : this.Icon.ToBitmap();

                        txtApkPath.Text = Program.api.ApkPath;
                        txtApkSize.Text = Program.api.ApkSize;

                        this.btnPlayStore.Enabled = !string.IsNullOrEmpty(txtPackage.Text);
                        this.btnQQStore.Enabled = !string.IsNullOrEmpty(txtPackage.Text);
                    });
                };



                RunAsync(() => {

                    Dump_Badging(Program.api.ApkPath);
                });


                Program.api.OnAddRootNode = () => {
                    RunInMainthread(() => {
                        foreach (var item in Program.api.rootnodes)
                        {
                            treeView1.Nodes.Add(item);
                        }

                    });
                };


                RunAsync(() => {

                    List_A(Program.api.ApkPath);
                });

            }
        }





        private void Dump_Badging(string apkPath)
        {
            if (!File.Exists(apkPath))
                return;
            Program.api.DumpBadging(apkPath);

        }

        private void List_A(string apkPath)
        {
            if (!File.Exists(apkPath))
                return;
            Program.api.ListContents(apkPath);

        }




        private void btnPlayStore_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://play.google.com/store/apps/details?id={0}", txtPackage.Text);
            Process.Start(url);

        }

        private void btnQQStore_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://android.myapp.com/myapp/detail.htm?apkName={0}", txtPackage.Text);
            Process.Start(url);

        }


        void RunAsync(Action action)
        {
            ((Action)(delegate () {
                action?.Invoke();
            })).BeginInvoke(null, null);
        }

        void RunInMainthread(Action action)
        {
            this.BeginInvoke((Action)(delegate () {
                action?.Invoke();
            }));
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PathText.Text = e.Node.FullPath.Replace('\\', '/'); ;
            e.Node.Expand(); // 展开选中的节点

            TreeNodeCollection c = (e.Node.Parent == null)
                ? this.treeView1.Nodes
                : e.Node.Parent.Nodes; // 获取选中节点同级的所有节点的集合。这里这所以要判断，因 e.Node.Parent == null 时表示最顶级的节点，这部分节点没有 Parent

            foreach (TreeNode node in c)
            {
                // 若是非选中且已展开的节点调用 Collapse 收缩。
                if (node == e.Node) continue;
                if (node.IsExpanded)
                    node.Collapse();
            }



        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Visible = false;
            ImgRes.Visible = false;
            var FileEx = Path.GetExtension(e.Node.FullPath);
            if (FileEx == ".xml")
            {
                textBox1.Text = "";

                // MessageBox.Show(e.Node.FullPath);

                RunAsync(() => {

                    Program.api.DecodeXml(e.Node.FullPath);
                });


                Program.api.OnDecodeXMLSuccess = () => {
                    RunInMainthread(() => {
                        textBox1.Text = Program.api.DecodeXML;
                        textBox1.Visible = true;
                    });
                };

            }
            else if (FileEx == ".png" || FileEx == ".jpg" || FileEx == ".gif")
            {
                RunAsync(() => {

                    Program.api.GetImage(e.Node.FullPath);
                });

                Program.api.OnGetImgSuccess = () => {
                    RunInMainthread(() => {
                        ImgRes.Image = Program.api.ImageRes;
                        ImgRes.Visible = true;
                    });
                };
            }
            else if (string.IsNullOrEmpty(FileEx))
            {
                RunAsync(() => {

                    Program.api.SearchCNode(e.Node.FullPath);
                });

                Program.api.OnAddSubNode = () => {
                    RunInMainthread(() => {
                        foreach (var item in Program.api.subnodes)
                        {
                            e.Node.Nodes.Add(item);
                        }

                    });
                };
            }

        }

        private string selectedpath;
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//判断你点的是不是右键
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    CurrentNode.ContextMenuStrip = ListMenu;
                    //switch (CurrentNode.Name)//根据不同节点显示不同的右键菜单，当然你可以让它显示一样的菜单
                    //{
                    //    case "errorUrl":
                    //        CurrentNode.ContextMenuStrip = ListMenu;
                    //        break;
                    //}
                    treeView1.SelectedNode = CurrentNode;//选中这个节点
                    selectedpath = CurrentNode.FullPath;
                }
            }
        }

        private void SaveItemMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Program.api.SavePath))
            {
                //设置此次默认目录为上一次选中目录  
                Fbd.SelectedPath = Program.api.SavePath;
            }

            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                Program.api.SavePath = Fbd.SelectedPath;
                RunAsync(() => {
                    Program.api.SaveSelect(selectedpath);

                });
            }


            Program.api.OnExtractSuccess = () => {
                RunInMainthread(() => {
                    MessageBox.Show("已导出！");
                });
            };


        }

        private void imgIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Program.api.AppIcon != null)//判断你点的是不是右键
            {
                if (Fbd.ShowDialog() == DialogResult.OK)
                {
                    //记录选中的目录  
                    Program.api.SavePath = Fbd.SelectedPath;
                    RunAsync(() => {
                        Program.api.SaveIcon(Program.api.IconPath);

                    });
                }
            }
        }
    }
}
