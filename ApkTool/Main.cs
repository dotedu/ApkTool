using System;
using System.Diagnostics;
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

        private void Main_Load(object sender, EventArgs e)
        {
            Program.api.FilesTable.Columns.Add("id", Type.GetType("System.Int32"));
            Program.api.FilesTable.Columns[0].AutoIncrement = true;
            Program.api.FilesTable.Columns[0].AutoIncrementSeed = 1;
            Program.api.FilesTable.Columns[0].AutoIncrementStep = 1;
            Program.api.FilesTable.Columns.Add("name", Type.GetType("System.String"));
            Program.api.FilesTable.Columns.Add("parentid", Type.GetType("System.Int32"));
            Program.api.FilesTable.Columns.Add("index", Type.GetType("System.Int32"));
            Program.api.FilesTable.Columns.Add("leve;", Type.GetType("System.Int32"));
        }
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK || Ofd.ShowDialog() == DialogResult.Yes)
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


    }
}
