namespace INCUserver
{
    partial class frm_Server
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Server));
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("环境检查", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("常用小工具", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("办公小工具", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("安全环境检查");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("办公环境检查");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("办税环境检查");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("主机信息检查");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("注册表");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("组策略");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("IP配置");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("主机名称配置");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Windows密码设置");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("文件改扩展名");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("数据比对");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("万能查询");
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("办公应用", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("系统应用", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("网络应用", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("记录筛选");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("IP设置");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("注册表编辑器");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("网络检测");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("万能查询");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cnm_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.grb_Log = new System.Windows.Forms.GroupBox();
            this.ltv_Log = new System.Windows.Forms.ListView();
            this.col_Datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            this.cnm_notifyIcon.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.grb_Log.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Message});
            this.statusStrip1.Location = new System.Drawing.Point(4, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1178, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Message
            // 
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cnm_notifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ICanSeeYou服务端";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cnm_notifyIcon
            // 
            this.cnm_notifyIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnm_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem3,
            this.关于AToolStripMenuItem1,
            this.退出EToolStripMenuItem1});
            this.cnm_notifyIcon.Name = "cnm_notifyIcon";
            this.cnm_notifyIcon.Size = new System.Drawing.Size(137, 82);
            // 
            // 打开OToolStripMenuItem3
            // 
            this.打开OToolStripMenuItem3.Image = global::INCUserver.Properties.Resources.Ice;
            this.打开OToolStripMenuItem3.Name = "打开OToolStripMenuItem3";
            this.打开OToolStripMenuItem3.Size = new System.Drawing.Size(136, 26);
            this.打开OToolStripMenuItem3.Text = "打开(&O)";
            this.打开OToolStripMenuItem3.Click += new System.EventHandler(this.打开OToolStripMenuItem3_Click);
            // 
            // 关于AToolStripMenuItem1
            // 
            this.关于AToolStripMenuItem1.Image = global::INCUserver.Properties.Resources.info;
            this.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1";
            this.关于AToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.关于AToolStripMenuItem1.Text = "关于(&A)";
            this.关于AToolStripMenuItem1.Click += new System.EventHandler(this.关于AToolStripMenuItem1_Click);
            // 
            // 退出EToolStripMenuItem1
            // 
            this.退出EToolStripMenuItem1.Image = global::INCUserver.Properties.Resources.Exit;
            this.退出EToolStripMenuItem1.Name = "退出EToolStripMenuItem1";
            this.退出EToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.退出EToolStripMenuItem1.Text = "退出(&E)";
            this.退出EToolStripMenuItem1.Click += new System.EventHandler(this.退出EToolStripMenuItem1_Click);
            // 
            // skinTabControl1
            // 
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.skinTabControl1.Animation = animation1;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tabPage12);
            this.skinTabControl1.Controls.Add(this.tabPage13);
            this.skinTabControl1.Controls.Add(this.tabPage9);
            this.skinTabControl1.Controls.Add(this.tabPage15);
            this.skinTabControl1.Controls.Add(this.tabPage16);
            this.skinTabControl1.Controls.Add(this.tabPage17);
            this.skinTabControl1.Controls.Add(this.tabPage18);
            this.skinTabControl1.Controls.Add(this.tabPage19);
            this.skinTabControl1.Controls.Add(this.tabPage20);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.ImageList = this.imageList;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(48, 48);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(80, 75);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.PageTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(1178, 375);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.ImageIndex = 4;
            this.tabPage12.Location = new System.Drawing.Point(0, 75);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1178, 300);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "主机状态";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.grb_Log);
            this.tabPage13.ImageIndex = 8;
            this.tabPage13.Location = new System.Drawing.Point(0, 75);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1178, 300);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "远程消息";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // grb_Log
            // 
            this.grb_Log.Controls.Add(this.ltv_Log);
            this.grb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_Log.Location = new System.Drawing.Point(3, 3);
            this.grb_Log.Name = "grb_Log";
            this.grb_Log.Size = new System.Drawing.Size(1172, 294);
            this.grb_Log.TabIndex = 4;
            this.grb_Log.TabStop = false;
            this.grb_Log.Text = "操作记录";
            // 
            // ltv_Log
            // 
            this.ltv_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Datetime,
            this.col_IP,
            this.col_Event});
            this.ltv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltv_Log.Location = new System.Drawing.Point(3, 21);
            this.ltv_Log.Name = "ltv_Log";
            this.ltv_Log.Size = new System.Drawing.Size(1166, 270);
            this.ltv_Log.TabIndex = 1;
            this.ltv_Log.UseCompatibleStateImageBehavior = false;
            this.ltv_Log.View = System.Windows.Forms.View.Details;
            // 
            // col_Datetime
            // 
            this.col_Datetime.Text = "时间";
            this.col_Datetime.Width = 125;
            // 
            // col_IP
            // 
            this.col_IP.Text = "IP";
            this.col_IP.Width = 168;
            // 
            // col_Event
            // 
            this.col_Event.Text = "操作";
            this.col_Event.Width = 291;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tabControl2);
            this.tabPage9.ImageIndex = 9;
            this.tabPage9.Location = new System.Drawing.Point(0, 75);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1178, 300);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "我的应用";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage14);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1178, 300);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.listView2);
            this.tabPage10.Location = new System.Drawing.Point(4, 28);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1170, 268);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "内置应用";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "环境检查";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "常用小工具";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "办公小工具";
            listViewGroup3.Name = "listViewGroup3";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup2;
            listViewItem6.Group = listViewGroup2;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup2;
            listViewItem10.Group = listViewGroup3;
            listViewItem11.Group = listViewGroup3;
            listViewItem12.Group = listViewGroup3;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1164, 262);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "内置软件名称";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "说明";
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.listView1);
            this.tabPage14.Location = new System.Drawing.Point(4, 28);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1170, 268);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "外置应用";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup4.Header = "办公应用";
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup5.Header = "系统应用";
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "网络应用";
            listViewGroup6.Name = "网络应用";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            listViewItem13.Group = listViewGroup4;
            listViewItem14.Group = listViewGroup6;
            listViewItem15.Group = listViewGroup5;
            listViewItem16.Group = listViewGroup6;
            listViewItem17.Group = listViewGroup4;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1164, 262);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "命令路径";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "备注";
            // 
            // tabPage15
            // 
            this.tabPage15.ImageIndex = 11;
            this.tabPage15.Location = new System.Drawing.Point(0, 75);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1178, 300);
            this.tabPage15.TabIndex = 3;
            this.tabPage15.Text = "我的网盘";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.ImageIndex = 2;
            this.tabPage16.Location = new System.Drawing.Point(0, 75);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(200, 25);
            this.tabPage16.TabIndex = 4;
            this.tabPage16.Text = "我的共享";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.ImageIndex = 5;
            this.tabPage17.Location = new System.Drawing.Point(0, 75);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(200, 25);
            this.tabPage17.TabIndex = 5;
            this.tabPage17.Text = "内网资源";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.ImageIndex = 8;
            this.tabPage18.Location = new System.Drawing.Point(0, 75);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(200, 25);
            this.tabPage18.TabIndex = 6;
            this.tabPage18.Text = "一键登录";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // tabPage19
            // 
            this.tabPage19.ImageIndex = 10;
            this.tabPage19.Location = new System.Drawing.Point(0, 75);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(200, 25);
            this.tabPage19.TabIndex = 7;
            this.tabPage19.Text = "安全U盘";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // tabPage20
            // 
            this.tabPage20.ImageIndex = 7;
            this.tabPage20.Location = new System.Drawing.Point(0, 75);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(200, 25);
            this.tabPage20.TabIndex = 8;
            this.tabPage20.Text = "我的收藏";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "hover_360MobileMgr1.png");
            this.imageList.Images.SetKeyName(1, "ico_AdvTools.png");
            this.imageList.Images.SetKeyName(2, "ico_diannaomenzhen.png");
            this.imageList.Images.SetKeyName(3, "ico_dsmain.png");
            this.imageList.Images.SetKeyName(4, "ico_Examine.png");
            this.imageList.Images.SetKeyName(5, "ico_expert.png");
            this.imageList.Images.SetKeyName(6, "ico_rescue.png");
            this.imageList.Images.SetKeyName(7, "ico_softmgr.png");
            this.imageList.Images.SetKeyName(8, "ico_SpeedupOpt.png");
            this.imageList.Images.SetKeyName(9, "ico_SysRepair.png");
            this.imageList.Images.SetKeyName(10, "ico_TraceCleaner.png");
            this.imageList.Images.SetKeyName(11, "ico_VulRepair.png");
            // 
            // frm_Server
            // 
            this.ClientSize = new System.Drawing.Size(1186, 429);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Server";
            this.ShowInTaskbar = false;
            this.Text = "TaxToolsManagerServer - 税务小助手1.0         招远市地方税务局";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_server_FormClosing);
            this.Resize += new System.EventHandler(this.frm_server_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cnm_notifyIcon.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.grb_Log.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Message;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cnm_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.GroupBox grb_Log;
        private System.Windows.Forms.ListView ltv_Log;
        private System.Windows.Forms.ColumnHeader col_Datetime;
        private System.Windows.Forms.ColumnHeader col_IP;
        private System.Windows.Forms.ColumnHeader col_Event;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.ImageList imageList;
    }
}

