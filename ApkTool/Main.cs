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

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK || Ofd.ShowDialog() == DialogResult.Yes)
            {
                DecodeApk(Ofd.FileName);

            }
        }





        private void DecodeApk(string apkPath)
        {
            if (!File.Exists(apkPath))
                return;

            ApkDecoder apkDecoder = new ApkDecoder(apkPath);
            apkDecoder.InfoParsedEvent += new Action<ApkDecoder>(apkDecoder_InfoParsed);
            apkDecoder.AaptNotFoundEvent += new MethodInvoker(apkDecoder_AaptNotFound);
        }

        private void apkDecoder_InfoParsed(ApkDecoder apkDecoder)
        {
            this.Invoke(new Action<ApkDecoder>(SafeInfoParsed), apkDecoder);
        }

        private void apkDecoder_AaptNotFound()
        {
            this.Invoke(new MethodInvoker(ShowAaptNotFoundInfo));
        }

        private void ShowAaptNotFoundInfo()
        {
            MessageBox.Show(this, "解析apk文件所需要的组件aapt.exe遗失，请下载此程序完整组件然后再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void SafeInfoParsed(ApkDecoder apkDecoder)
        {
            txtApplication.Text = apkDecoder.AppName;
            txtVersion.Text = apkDecoder.AppVersion;
            txtVersionCode.Text = apkDecoder.AppVersionCode;
            txtPackage.Text = apkDecoder.PkgName;
            txtIconPath.Text = apkDecoder.IconPath;
            txtMinSdk.Text = apkDecoder.MinSdk;
            txtMinVersion.Text = apkDecoder.MinVersion;
            txtScreenSize.Text = apkDecoder.ScreenSupport;
            txtScreenSolution.Text = apkDecoder.ScreenSolutions;
            txtPermission.Text = apkDecoder.Permissions;
            txtFeature.Text = apkDecoder.Features;
            imgIcon.Image = (apkDecoder.AppIcon != null) ? apkDecoder.AppIcon : this.Icon.ToBitmap();

            txtApkPath.Text = apkDecoder.ApkPath;
            txtApkSize.Text = apkDecoder.ApkSize;

            this.btnPlayStore.Enabled = !string.IsNullOrEmpty(txtPackage.Text);
            this.btnQQStore.Enabled = !string.IsNullOrEmpty(txtPackage.Text);
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
