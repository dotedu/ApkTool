namespace ApkTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPlayStore = new System.Windows.Forms.ToolStripButton();
            this.btnQQStore = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApkSize = new System.Windows.Forms.TextBox();
            this.txtApkPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinVersion = new System.Windows.Forms.TextBox();
            this.txtScreenSolution = new System.Windows.Forms.TextBox();
            this.txtScreenSize = new System.Windows.Forms.TextBox();
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.txtMinSdk = new System.Windows.Forms.TextBox();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.txtVersionCode = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelChaZhao = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImgRes = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PathText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.KeyWordStr = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ScBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ExportResBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.ListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SourcecodeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.XmlTreeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.XmlStringsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CovertXmlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportRes_Fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelChaZhao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRes)).BeginInit();
            this.PanelLeft.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBtn,
            this.toolStripSeparator1,
            this.btnPlayStore,
            this.btnQQStore});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolBar.Size = new System.Drawing.Size(1034, 25);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "toolStrip1";
            // 
            // OpenBtn
            // 
            this.OpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Margin = new System.Windows.Forms.Padding(1);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(23, 23);
            this.OpenBtn.ToolTipText = "打开文件";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPlayStore
            // 
            this.btnPlayStore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlayStore.Enabled = false;
            this.btnPlayStore.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayStore.Image")));
            this.btnPlayStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayStore.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlayStore.Name = "btnPlayStore";
            this.btnPlayStore.Size = new System.Drawing.Size(23, 23);
            this.btnPlayStore.Text = "谷歌商店";
            this.btnPlayStore.Click += new System.EventHandler(this.btnPlayStore_Click);
            // 
            // btnQQStore
            // 
            this.btnQQStore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQQStore.Enabled = false;
            this.btnQQStore.Image = ((System.Drawing.Image)(resources.GetObject("btnQQStore.Image")));
            this.btnQQStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQQStore.Margin = new System.Windows.Forms.Padding(1);
            this.btnQQStore.Name = "btnQQStore";
            this.btnQQStore.Size = new System.Drawing.Size(23, 23);
            this.btnQQStore.Text = "应用宝";
            this.btnQQStore.Click += new System.EventHandler(this.btnQQStore_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtApkSize);
            this.tabPage1.Controls.Add(this.txtApkPath);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtMinVersion);
            this.tabPage1.Controls.Add(this.txtScreenSolution);
            this.tabPage1.Controls.Add(this.txtScreenSize);
            this.tabPage1.Controls.Add(this.txtFeature);
            this.tabPage1.Controls.Add(this.txtPermission);
            this.tabPage1.Controls.Add(this.txtMinSdk);
            this.tabPage1.Controls.Add(this.txtIconPath);
            this.tabPage1.Controls.Add(this.txtPackage);
            this.tabPage1.Controls.Add(this.txtVersionCode);
            this.tabPage1.Controls.Add(this.txtVersion);
            this.tabPage1.Controls.Add(this.txtApplication);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.imgIcon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "APK信息";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(20, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1000, 2);
            this.label13.TabIndex = 48;
            // 
            // txtApkSize
            // 
            this.txtApkSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApkSize.Location = new System.Drawing.Point(89, 572);
            this.txtApkSize.Name = "txtApkSize";
            this.txtApkSize.ReadOnly = true;
            this.txtApkSize.Size = new System.Drawing.Size(931, 21);
            this.txtApkSize.TabIndex = 44;
            // 
            // txtApkPath
            // 
            this.txtApkPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApkPath.Location = new System.Drawing.Point(89, 547);
            this.txtApkPath.Name = "txtApkPath";
            this.txtApkPath.ReadOnly = true;
            this.txtApkPath.Size = new System.Drawing.Size(931, 21);
            this.txtApkPath.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 43;
            this.label11.Text = "大小：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "文件路径：";
            // 
            // txtMinVersion
            // 
            this.txtMinVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinVersion.Location = new System.Drawing.Point(125, 144);
            this.txtMinVersion.Name = "txtMinVersion";
            this.txtMinVersion.ReadOnly = true;
            this.txtMinVersion.Size = new System.Drawing.Size(895, 21);
            this.txtMinVersion.TabIndex = 32;
            // 
            // txtScreenSolution
            // 
            this.txtScreenSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenSolution.Location = new System.Drawing.Point(89, 194);
            this.txtScreenSolution.Name = "txtScreenSolution";
            this.txtScreenSolution.ReadOnly = true;
            this.txtScreenSolution.Size = new System.Drawing.Size(931, 21);
            this.txtScreenSolution.TabIndex = 35;
            // 
            // txtScreenSize
            // 
            this.txtScreenSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenSize.Location = new System.Drawing.Point(89, 169);
            this.txtScreenSize.Name = "txtScreenSize";
            this.txtScreenSize.ReadOnly = true;
            this.txtScreenSize.Size = new System.Drawing.Size(931, 21);
            this.txtScreenSize.TabIndex = 34;
            // 
            // txtFeature
            // 
            this.txtFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeature.Location = new System.Drawing.Point(89, 380);
            this.txtFeature.Multiline = true;
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.ReadOnly = true;
            this.txtFeature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeature.Size = new System.Drawing.Size(931, 150);
            this.txtFeature.TabIndex = 39;
            // 
            // txtPermission
            // 
            this.txtPermission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPermission.Location = new System.Drawing.Point(89, 219);
            this.txtPermission.Multiline = true;
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.ReadOnly = true;
            this.txtPermission.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPermission.Size = new System.Drawing.Size(931, 150);
            this.txtPermission.TabIndex = 38;
            // 
            // txtMinSdk
            // 
            this.txtMinSdk.Location = new System.Drawing.Point(89, 144);
            this.txtMinSdk.Name = "txtMinSdk";
            this.txtMinSdk.ReadOnly = true;
            this.txtMinSdk.Size = new System.Drawing.Size(32, 21);
            this.txtMinSdk.TabIndex = 30;
            // 
            // txtIconPath
            // 
            this.txtIconPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIconPath.Location = new System.Drawing.Point(89, 119);
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.ReadOnly = true;
            this.txtIconPath.Size = new System.Drawing.Size(931, 21);
            this.txtIconPath.TabIndex = 28;
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackage.Location = new System.Drawing.Point(89, 94);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.ReadOnly = true;
            this.txtPackage.Size = new System.Drawing.Size(829, 21);
            this.txtPackage.TabIndex = 27;
            // 
            // txtVersionCode
            // 
            this.txtVersionCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionCode.Location = new System.Drawing.Point(89, 69);
            this.txtVersionCode.Name = "txtVersionCode";
            this.txtVersionCode.ReadOnly = true;
            this.txtVersionCode.Size = new System.Drawing.Size(829, 21);
            this.txtVersionCode.TabIndex = 24;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.Location = new System.Drawing.Point(89, 44);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(829, 21);
            this.txtVersion.TabIndex = 22;
            // 
            // txtApplication
            // 
            this.txtApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplication.Location = new System.Drawing.Point(89, 19);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.ReadOnly = true;
            this.txtApplication.Size = new System.Drawing.Size(829, 21);
            this.txtApplication.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "特性支持：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "用户权限：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "分辨率：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "屏幕支持：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "系统要求：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "包名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "Icon路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "版本号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "版本：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "应用名称：";
            // 
            // imgIcon
            // 
            this.imgIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgIcon.ErrorImage")));
            this.imgIcon.InitialImage = null;
            this.imgIcon.Location = new System.Drawing.Point(922, 18);
            this.imgIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(96, 96);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 23;
            this.imgIcon.TabStop = false;
            this.imgIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgIcon_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.splitter1);
            this.tabPage2.Controls.Add(this.PanelLeft);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1026, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据解析";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelChaZhao);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ImgRes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 624);
            this.panel1.TabIndex = 11;
            // 
            // PanelChaZhao
            // 
            this.PanelChaZhao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelChaZhao.Controls.Add(this.SearchBtn);
            this.PanelChaZhao.Controls.Add(this.textBox2);
            this.PanelChaZhao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelChaZhao.Location = new System.Drawing.Point(0, 588);
            this.PanelChaZhao.Name = "PanelChaZhao";
            this.PanelChaZhao.Size = new System.Drawing.Size(823, 36);
            this.PanelChaZhao.TabIndex = 7;
            this.PanelChaZhao.Visible = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBtn.Location = new System.Drawing.Point(740, 8);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "查找";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(6, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(728, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(33, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(337, 93);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(33, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(33, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(823, 588);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // ImgRes
            // 
            this.ImgRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgRes.Location = new System.Drawing.Point(0, 0);
            this.ImgRes.Name = "ImgRes";
            this.ImgRes.Size = new System.Drawing.Size(823, 624);
            this.ImgRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgRes.TabIndex = 1;
            this.ImgRes.TabStop = false;
            this.ImgRes.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 624);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.treeView1);
            this.PanelLeft.Controls.Add(this.PathText);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.MinimumSize = new System.Drawing.Size(150, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(200, 624);
            this.PanelLeft.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 603);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // PathText
            // 
            this.PathText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PathText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathText.Location = new System.Drawing.Point(0, 0);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(200, 21);
            this.PathText.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.KeyWordStr);
            this.tabPage3.Controls.Add(this.ResetBtn);
            this.tabPage3.Controls.Add(this.ScBtn);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.ExportResBtn);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1026, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color资源";
            // 
            // KeyWordStr
            // 
            this.KeyWordStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KeyWordStr.Location = new System.Drawing.Point(42, 600);
            this.KeyWordStr.Name = "KeyWordStr";
            this.KeyWordStr.Size = new System.Drawing.Size(395, 21);
            this.KeyWordStr.TabIndex = 3;
            this.KeyWordStr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetBtn.Location = new System.Drawing.Point(642, 599);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "重置";
            this.toolTip1.SetToolTip(this.ResetBtn, "重置修改的属性");
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Visible = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ScBtn
            // 
            this.ScBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScBtn.Enabled = false;
            this.ScBtn.Location = new System.Drawing.Point(466, 599);
            this.ScBtn.Name = "ScBtn";
            this.ScBtn.Size = new System.Drawing.Size(75, 23);
            this.ScBtn.TabIndex = 5;
            this.ScBtn.Text = "查询";
            this.ScBtn.UseVisualStyleBackColor = true;
            this.ScBtn.Click += new System.EventHandler(this.ScBtn_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 604);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "查找: ";
            // 
            // ExportResBtn
            // 
            this.ExportResBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportResBtn.Enabled = false;
            this.ExportResBtn.Location = new System.Drawing.Point(554, 599);
            this.ExportResBtn.Name = "ExportResBtn";
            this.ExportResBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportResBtn.TabIndex = 2;
            this.ExportResBtn.Text = "导出";
            this.toolTip1.SetToolTip(this.ExportResBtn, "导出所选项为theme.xml！");
            this.ExportResBtn.UseVisualStyleBackColor = true;
            this.ExportResBtn.Click += new System.EventHandler(this.ExportResBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(40, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "正在解析数据。。";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 596);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Ofd
            // 
            this.Ofd.FileName = "打开文件";
            this.Ofd.Filter = "Apk文件(*.apk)|*.apk";
            this.Ofd.RestoreDirectory = true;
            // 
            // ListMenu
            // 
            this.ListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveItemMenu,
            this.SourcecodeMenu,
            this.XmlTreeMenu,
            this.XmlStringsMenu,
            this.CovertXmlMenu});
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.Size = new System.Drawing.Size(187, 114);
            // 
            // SaveItemMenu
            // 
            this.SaveItemMenu.Name = "SaveItemMenu";
            this.SaveItemMenu.Size = new System.Drawing.Size(186, 22);
            this.SaveItemMenu.Text = "导出";
            this.SaveItemMenu.Click += new System.EventHandler(this.SaveItemMenu_Click);
            // 
            // SourcecodeMenu
            // 
            this.SourcecodeMenu.Name = "SourcecodeMenu";
            this.SourcecodeMenu.Size = new System.Drawing.Size(186, 22);
            this.SourcecodeMenu.Text = "查看源码";
            this.SourcecodeMenu.Visible = false;
            this.SourcecodeMenu.Click += new System.EventHandler(this.SourcecodeMenu_Click);
            // 
            // XmlTreeMenu
            // 
            this.XmlTreeMenu.Name = "XmlTreeMenu";
            this.XmlTreeMenu.Size = new System.Drawing.Size(186, 22);
            this.XmlTreeMenu.Text = "解析（XmlTree）";
            this.XmlTreeMenu.Visible = false;
            this.XmlTreeMenu.Click += new System.EventHandler(this.XmlTreeMenu_Click);
            // 
            // XmlStringsMenu
            // 
            this.XmlStringsMenu.Name = "XmlStringsMenu";
            this.XmlStringsMenu.Size = new System.Drawing.Size(186, 22);
            this.XmlStringsMenu.Text = "解析（XmlStrings）";
            this.XmlStringsMenu.Visible = false;
            this.XmlStringsMenu.Click += new System.EventHandler(this.XmlStringsMenu_Click);
            // 
            // CovertXmlMenu
            // 
            this.CovertXmlMenu.Name = "CovertXmlMenu";
            this.CovertXmlMenu.Size = new System.Drawing.Size(186, 22);
            this.CovertXmlMenu.Text = "XML 格式化";
            this.CovertXmlMenu.Visible = false;
            this.CovertXmlMenu.Click += new System.EventHandler(this.CovertXmlMenu_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 681);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK资源解析工具 By 魚跃";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelChaZhao.ResumeLayout(false);
            this.PanelChaZhao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRes)).EndInit();
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton btnPlayStore;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripButton btnQQStore;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApkSize;
        private System.Windows.Forms.TextBox txtApkPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinVersion;
        private System.Windows.Forms.TextBox txtScreenSolution;
        private System.Windows.Forms.TextBox txtScreenSize;
        private System.Windows.Forms.TextBox txtFeature;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.TextBox txtMinSdk;
        private System.Windows.Forms.TextBox txtIconPath;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.TextBox txtVersionCode;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip ListMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveItemMenu;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.FolderBrowserDialog Fbd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem XmlTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem XmlStringsMenu;
        private System.Windows.Forms.ToolStripMenuItem SourcecodeMenu;
        private System.Windows.Forms.ToolStripMenuItem CovertXmlMenu;
        private System.Windows.Forms.Button ExportResBtn;
        private System.Windows.Forms.FolderBrowserDialog ExportRes_Fbd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox KeyWordStr;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel PanelChaZhao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ImgRes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ScBtn;
    }
}

