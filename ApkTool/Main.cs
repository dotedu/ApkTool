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
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Clear();
                dataGridView1.Rows.Clear();
                label14.Enabled = true;

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
                Program.api.OnGetResSuccess = () => {
                    RunInMainthread(() => {
                        label14.Visible = false;
                        if (Program.api.colorList.Count != 0)
                        {
                            foreach (var item in Program.api.colorList)
                            {
                                int index = this.dataGridView1.Rows.Add();
                                this.dataGridView1.Rows[index].Cells[0].Value = item.name;
                                this.dataGridView1.Rows[index].Cells[1].Value = item.value.Insert(0, "#");

                                var c = ToColor(item.value);

                                this.dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.FromArgb(c[0], c[1], c[2], c[3]);
                            }
                            dataGridView1.Refresh();
                        }

                    });
                };


                RunAsync(() => {

                    getResStr(Program.api.ApkPath);
                });


            }
        }

        private int[] ToColor(string hex)
        {
            int[] Argb= new int[4];
            Argb[0] = Convert.ToInt32(hex.Substring(0, 2), 16);
            Argb[1] = Convert.ToInt32(hex.Substring(2, 2), 16);
            Argb[2] = Convert.ToInt32(hex.Substring(4, 2), 16);
            Argb[3] = Convert.ToInt32(hex.Substring(6, 2), 16);

            return Argb;

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


        private void getResStr(string apkPath)
        {
            if (!File.Exists(apkPath))
                return;
            Program.api.GetResStr(Program.api.ApkPath);

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

                    Program.api.GetXMLTree(e.Node.FullPath);
                });

                Program.api.OnGetXMLTreeFail = () => {
                    RunInMainthread(() => {
                        textBox1.Text = Program.api.XmlTreeStr;
                        textBox1.Visible = true;
                    });
                };

                Program.api.OnGetXMLTreeSuccess = () => {
                    RunInMainthread(() => {
                        textBox1.Text = Program.api.XmlTreeStr;
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
            XmlTreeMenu.Visible = false;
            XmlStringsMenu.Visible = false;
            SourcecodeMenu.Visible = false;
            CovertXmlMenu.Visible = false;
            //AXML
            if (e.Button == MouseButtons.Right)//判断你点的是不是右键
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    treeView1.SelectedNode = CurrentNode;//选中这个节点
                    selectedpath = CurrentNode.FullPath;
                    var FileEx = Path.GetExtension(CurrentNode.FullPath);

                    CurrentNode.ContextMenuStrip = ListMenu;
                    switch (FileEx)
                    {
                        case ".xml":
                            if (CurrentNode.FullPath.Substring(0, 6) == "assets")
                            {
                                //XmlTreeMenu.Visible = true;
                                //XmlStringsMenu.Visible = true;
                                //CovertXmlMenu.Visible = true;
                                SourcecodeMenu.Visible = true;
                            }
                            else
                            {
                                XmlTreeMenu.Visible = true;
                                XmlStringsMenu.Visible = true;
                                CovertXmlMenu.Visible = true;
                                CovertXmlMenu.Enabled = false;
                                //SourcecodeMenu.Visible = true;
                            }
                            break;

                        case ".svg":
                            XmlTreeMenu.Visible = true;
                            XmlStringsMenu.Visible = true;
                            SourcecodeMenu.Visible = true;
                            break;
                        default:
                            break;
                    }
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



        private void SourcecodeMenu_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";


            RunAsync(() => {

                Program.api.GeSourceCode(selectedpath);
            });



            Program.api.OnGetSourcecodeSuccess = () => {
                RunInMainthread(() => {
                    textBox1.Text = Program.api.XmlSourcecodeStr;
                    textBox1.Visible = true;
                });
            };
        }

        private void XmlTreeMenu_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";


            RunAsync(() => {

                Program.api.GetXMLTree(selectedpath);
            });

            Program.api.OnGetXMLTreeFail = () => {
                RunInMainthread(() => {
                    textBox1.Text = Program.api.XmlTreeStr;
                    textBox1.Visible = true;
                });
            };


            Program.api.OnGetXMLTreeSuccess = () => {
                RunInMainthread(() => {
                    textBox1.Text = Program.api.XmlTreeStr;
                    textBox1.Visible = true;
                });
            };
        }

        private void XmlStringsMenu_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";


            RunAsync(() => {

                Program.api.GetXMLStrings(selectedpath);
            });

            Program.api.OnGetXMLStringsFail = () => {
                RunInMainthread(() => {
                    textBox1.Text = Program.api.XmlStringsStr;
                    textBox1.Visible = true;
                });
            };


            Program.api.OnGetXMLStringsSuccess = () => {
                RunInMainthread(() => {
                    textBox1.Text = Program.api.XmlStringsStr;
                    textBox1.Visible = true;
                });
            };
        }

        private void CovertXmlMenu_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                textBox.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        private void Control_ControlAdded(object sender, ControlEventArgs e)
        {
            //使“未来”生效
            e.Control.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Control_ControlAdded);
            //使“子孙”生效
            foreach (Control c in e.Control.Controls)
            {
                Control_ControlAdded(sender, new ControlEventArgs(c));
            }
            //使“过去”生效
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress += textBox1_KeyPress;
            }
        }

        private string ExportPath = "";
        private void ExportResBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ExportPath))
            {
                //设置此次默认目录为上一次选中目录  
                Fbd.SelectedPath = ExportPath;
            }

            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                ExportPath = Fbd.SelectedPath;
                RunAsync(() => {
                    Program.api.ExportResXml(ExportPath);

                });
            }


            Program.api.OnExportResSuccess = () => {
                RunInMainthread(() => {
                    MessageBox.Show("已导出！");
                });
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Program.api.ResFilter(textBox2.Text);
        }
    }
}
