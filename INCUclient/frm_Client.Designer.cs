﻿namespace INCUclient
{
    partial class frm_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Client));
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("所有主机");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_USER");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("HKEY_USERS");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_CONFIG");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("远程注册表根目录", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.cnm_HostParentView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加主机NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除所有RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnm_HostView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重新连接RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.屏幕控制PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关机SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升级服务端UtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sts_Main = new System.Windows.Forms.StatusStrip();
            this.lbl_Display = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentIP_tSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.连接CtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定主机SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有主机AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程屏幕DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.屏幕发送速度SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慢SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tls_Main = new System.Windows.Forms.ToolStrip();
            this.tsb_Connect = new System.Windows.Forms.ToolStripButton();
            this.tsb_ConnectAll = new System.Windows.Forms.ToolStripButton();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ScreenOpen = new System.Windows.Forms.ToolStripButton();
            this.tsb_ScreenHoldOn = new System.Windows.Forms.ToolStripButton();
            this.tsb_ScreenStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_UpdateServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Context = new System.Windows.Forms.ToolStripButton();
            this.tsb_AboutINCU = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ExistApp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trv_HostView = new System.Windows.Forms.TreeView();
            this.iml_HostView = new System.Windows.Forms.ImageList(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_Speak = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rtb_Speak = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tab_Desktop = new System.Windows.Forms.TabPage();
            this.pic_Screen = new System.Windows.Forms.PictureBox();
            this.tab_FileView = new System.Windows.Forms.TabPage();
            this.spl_Explorer = new System.Windows.Forms.SplitContainer();
            this.pnl_bottom_hostexplorer = new System.Windows.Forms.Panel();
            this.ltv_hostexplorer = new System.Windows.Forms.ListView();
            this.ctm_HostExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.下载DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新RToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.远程执行toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iml_ExplorerImages = new System.Windows.Forms.ImageList(this.components);
            this.pnl_top_hostexplorer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_hostexplorer = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_hostexplorer = new System.Windows.Forms.Button();
            this.pnl_bottom_myexplorer = new System.Windows.Forms.Panel();
            this.ltv_myexplorer = new System.Windows.Forms.ListView();
            this.ctm_MyExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.上传UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新RtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_top_myexplorer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_myexplorer = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_myexplorer = new System.Windows.Forms.Button();
            this.tab_Log = new System.Windows.Forms.TabPage();
            this.ltv_Log = new System.Windows.Forms.ListView();
            this.col_Datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Info = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.computerInfo_rtb = new System.Windows.Forms.RichTextBox();
            this.WMISearchButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WMISearch_tB2 = new System.Windows.Forms.TextBox();
            this.WMISearch_tB1 = new System.Windows.Forms.TextBox();
            this.WMISearchButton = new System.Windows.Forms.Button();
            this.WMISearch_tB = new System.Windows.Forms.TextBox();
            this.computerInfoGet_bt = new System.Windows.Forms.Button();
            this.tab_Dos = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DosResult_rtb = new System.Windows.Forms.RichTextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.DosCommand_tB = new System.Windows.Forms.TextBox();
            this.DosCommand_bn = new System.Windows.Forms.Button();
            this.tab_Soft = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.Script_rtb = new System.Windows.Forms.RichTextBox();
            this.Script_IsWaiting_cB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Script_paramerer_tB = new System.Windows.Forms.TextBox();
            this.ScriptFileOpenButton = new System.Windows.Forms.Button();
            this.ScriptSendButton = new System.Windows.Forms.Button();
            this.Script_filepath_tB = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Script_bat = new System.Windows.Forms.TabPage();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.ScriptBatEdit_rtb = new System.Windows.Forms.RichTextBox();
            this.Script_bat_IsWaiting_cB = new System.Windows.Forms.CheckBox();
            this.ScriptBatClearButton = new System.Windows.Forms.Button();
            this.ScriptBatCheckButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Script_bat_paramerer_tB = new System.Windows.Forms.TextBox();
            this.ScriptBatSendButton = new System.Windows.Forms.Button();
            this.ScriptBatLocalTestButton = new System.Windows.Forms.Button();
            this.ScriptBatClipboardButton = new System.Windows.Forms.Button();
            this.Script_rar = new System.Windows.Forms.TabPage();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.ScriptRARLocalTestButton = new System.Windows.Forms.Button();
            this.ScriptRarSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScriptRAR_pamarerer_tB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ScriptRAR3_cB = new System.Windows.Forms.CheckBox();
            this.ScriptRAR2_cB = new System.Windows.Forms.CheckBox();
            this.ScriptRAR1_cB = new System.Windows.Forms.CheckBox();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ScriptRARFile1_dGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScriptRARFile2_dGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tab_process = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.PSS_rtb = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.process_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctm_process = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新进程toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.结束任务toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Service_lv = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctm_secvice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.启动toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.启动类型toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.自动toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.手动toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.禁止toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Startup_lv = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctm_startup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Regedit = new System.Windows.Forms.TabPage();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.Reg_tV = new System.Windows.Forms.TreeView();
            this.splitContainer13 = new System.Windows.Forms.SplitContainer();
            this.Reg_lV = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer14 = new System.Windows.Forms.SplitContainer();
            this.Reg_rTB = new CCWin.SkinControl.RtfRichTextBox();
            this.RegImportButton = new System.Windows.Forms.Button();
            this.RegDirDelButton = new System.Windows.Forms.Button();
            this.RegDirModiButton = new System.Windows.Forms.Button();
            this.RegDirAddButton = new System.Windows.Forms.Button();
            this.RegKeyDelButton = new System.Windows.Forms.Button();
            this.RegKeyAddButton = new System.Windows.Forms.Button();
            this.RegKeyModiButton = new System.Windows.Forms.Button();
            this.RegKeyOutportButton = new System.Windows.Forms.Button();
            this.tab_StatusScan = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatusOKButton = new System.Windows.Forms.Button();
            this.chkStatusButton = new System.Windows.Forms.Button();
            this.chkTax_cB = new System.Windows.Forms.CheckBox();
            this.chkOffice_cB = new System.Windows.Forms.CheckBox();
            this.chkSafe_cB = new System.Windows.Forms.CheckBox();
            this.chkInfo_cB = new System.Windows.Forms.CheckBox();
            this.chkStatus_rtb = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cnm_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭连接CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oFD_Script = new System.Windows.Forms.OpenFileDialog();
            this.cnm_HostParentView.SuspendLayout();
            this.cnm_HostView.SuspendLayout();
            this.sts_Main.SuspendLayout();
            this.mnu_Main.SuspendLayout();
            this.tls_Main.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tab_Speak.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_Desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Screen)).BeginInit();
            this.tab_FileView.SuspendLayout();
            this.spl_Explorer.Panel1.SuspendLayout();
            this.spl_Explorer.Panel2.SuspendLayout();
            this.spl_Explorer.SuspendLayout();
            this.pnl_bottom_hostexplorer.SuspendLayout();
            this.ctm_HostExplorer.SuspendLayout();
            this.pnl_top_hostexplorer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_bottom_myexplorer.SuspendLayout();
            this.ctm_MyExplorer.SuspendLayout();
            this.pnl_top_myexplorer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tab_Log.SuspendLayout();
            this.tab_Info.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tab_Dos.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tab_Soft.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Script_bat.SuspendLayout();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.Script_rar.SuspendLayout();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptRARFile1_dGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptRARFile2_dGV)).BeginInit();
            this.tab_process.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ctm_process.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ctm_secvice.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ctm_startup.SuspendLayout();
            this.tab_Regedit.SuspendLayout();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            this.splitContainer13.Panel1.SuspendLayout();
            this.splitContainer13.Panel2.SuspendLayout();
            this.splitContainer13.SuspendLayout();
            this.splitContainer14.Panel1.SuspendLayout();
            this.splitContainer14.Panel2.SuspendLayout();
            this.splitContainer14.SuspendLayout();
            this.tab_StatusScan.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.cnm_notifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnm_HostParentView
            // 
            this.cnm_HostParentView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnm_HostParentView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加主机NToolStripMenuItem,
            this.移除所有RToolStripMenuItem});
            this.cnm_HostParentView.Name = "cnm_HostParentView";
            this.cnm_HostParentView.Size = new System.Drawing.Size(167, 56);
            // 
            // 增加主机NToolStripMenuItem
            // 
            this.增加主机NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("增加主机NToolStripMenuItem.Image")));
            this.增加主机NToolStripMenuItem.Name = "增加主机NToolStripMenuItem";
            this.增加主机NToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.增加主机NToolStripMenuItem.Text = "增加主机(&N)";
            this.增加主机NToolStripMenuItem.Click += new System.EventHandler(this.增加主机NToolStripMenuItem_Click);
            // 
            // 移除所有RToolStripMenuItem
            // 
            this.移除所有RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("移除所有RToolStripMenuItem.Image")));
            this.移除所有RToolStripMenuItem.Name = "移除所有RToolStripMenuItem";
            this.移除所有RToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.移除所有RToolStripMenuItem.Text = "移除所有(&R)";
            this.移除所有RToolStripMenuItem.Click += new System.EventHandler(this.移除所有RToolStripMenuItem_Click);
            // 
            // cnm_HostView
            // 
            this.cnm_HostView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnm_HostView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新连接RToolStripMenuItem,
            this.屏幕控制PToolStripMenuItem,
            this.关机SToolStripMenuItem,
            this.升级服务端UtoolStripMenuItem,
            this.移除MToolStripMenuItem});
            this.cnm_HostView.Name = "contextMenuStrip1";
            this.cnm_HostView.Size = new System.Drawing.Size(165, 134);
            // 
            // 重新连接RToolStripMenuItem
            // 
            this.重新连接RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("重新连接RToolStripMenuItem.Image")));
            this.重新连接RToolStripMenuItem.Name = "重新连接RToolStripMenuItem";
            this.重新连接RToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.重新连接RToolStripMenuItem.Text = "重新连接(&R)";
            this.重新连接RToolStripMenuItem.Click += new System.EventHandler(this.重新连接RToolStripMenuItem_Click);
            // 
            // 屏幕控制PToolStripMenuItem
            // 
            this.屏幕控制PToolStripMenuItem.Image = global::INCUclient.Properties.Resources.ControlScreen;
            this.屏幕控制PToolStripMenuItem.Name = "屏幕控制PToolStripMenuItem";
            this.屏幕控制PToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.屏幕控制PToolStripMenuItem.Text = "屏幕控制(&P)";
            this.屏幕控制PToolStripMenuItem.Click += new System.EventHandler(this.屏幕控制PToolStripMenuItem_Click);
            // 
            // 关机SToolStripMenuItem
            // 
            this.关机SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关机SToolStripMenuItem.Image")));
            this.关机SToolStripMenuItem.Name = "关机SToolStripMenuItem";
            this.关机SToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.关机SToolStripMenuItem.Text = "关机(&S)";
            this.关机SToolStripMenuItem.Click += new System.EventHandler(this.关机SToolStripMenuItem_Click);
            // 
            // 升级服务端UtoolStripMenuItem
            // 
            this.升级服务端UtoolStripMenuItem.Image = global::INCUclient.Properties.Resources.update2;
            this.升级服务端UtoolStripMenuItem.Name = "升级服务端UtoolStripMenuItem";
            this.升级服务端UtoolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.升级服务端UtoolStripMenuItem.Text = "升级(&U)";
            this.升级服务端UtoolStripMenuItem.Click += new System.EventHandler(this.升级服务端UtoolStripMenuItem_Click);
            // 
            // 移除MToolStripMenuItem
            // 
            this.移除MToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("移除MToolStripMenuItem.Image")));
            this.移除MToolStripMenuItem.Name = "移除MToolStripMenuItem";
            this.移除MToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.移除MToolStripMenuItem.Text = "移除(&M)";
            this.移除MToolStripMenuItem.Click += new System.EventHandler(this.移除MToolStripMenuItem_Click);
            // 
            // sts_Main
            // 
            this.sts_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Display,
            this.toolStripStatusLabel1,
            this.CurrentIP_tSSL});
            this.sts_Main.Location = new System.Drawing.Point(0, 552);
            this.sts_Main.Name = "sts_Main";
            this.sts_Main.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sts_Main.Size = new System.Drawing.Size(1303, 26);
            this.sts_Main.TabIndex = 5;
            // 
            // lbl_Display
            // 
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(49, 21);
            this.lbl_Display.Text = "          ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 21);
            this.toolStripStatusLabel1.Text = "当前操作的主机：";
            // 
            // CurrentIP_tSSL
            // 
            this.CurrentIP_tSSL.AutoSize = false;
            this.CurrentIP_tSSL.Name = "CurrentIP_tSSL";
            this.CurrentIP_tSSL.Size = new System.Drawing.Size(100, 21);
            // 
            // mnu_Main
            // 
            this.mnu_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接CtoolStripMenuItem,
            this.远程屏幕DToolStripMenuItem,
            this.设置OToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnu_Main.Size = new System.Drawing.Size(1303, 28);
            this.mnu_Main.TabIndex = 7;
            this.mnu_Main.Text = "menuStrip1";
            // 
            // 连接CtoolStripMenuItem
            // 
            this.连接CtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.指定主机SToolStripMenuItem,
            this.所有主机AToolStripMenuItem,
            this.关闭连接ToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.连接CtoolStripMenuItem.Name = "连接CtoolStripMenuItem";
            this.连接CtoolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.连接CtoolStripMenuItem.Text = "连接(&C)";
            // 
            // 指定主机SToolStripMenuItem
            // 
            this.指定主机SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("指定主机SToolStripMenuItem.Image")));
            this.指定主机SToolStripMenuItem.Name = "指定主机SToolStripMenuItem";
            this.指定主机SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.指定主机SToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.指定主机SToolStripMenuItem.Text = "指定主机(&S)";
            this.指定主机SToolStripMenuItem.Click += new System.EventHandler(this.指定主机SToolStripMenuItem_Click);
            // 
            // 所有主机AToolStripMenuItem
            // 
            this.所有主机AToolStripMenuItem.AutoToolTip = true;
            this.所有主机AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("所有主机AToolStripMenuItem.Image")));
            this.所有主机AToolStripMenuItem.Name = "所有主机AToolStripMenuItem";
            this.所有主机AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.所有主机AToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.所有主机AToolStripMenuItem.Text = "所有主机(&A)";
            this.所有主机AToolStripMenuItem.ToolTipText = "连接局域网所有在线主机";
            this.所有主机AToolStripMenuItem.Click += new System.EventHandler(this.所有主机AToolStripMenuItem_Click);
            // 
            // 关闭连接ToolStripMenuItem
            // 
            this.关闭连接ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关闭连接ToolStripMenuItem.Image")));
            this.关闭连接ToolStripMenuItem.Name = "关闭连接ToolStripMenuItem";
            this.关闭连接ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.关闭连接ToolStripMenuItem.Text = "关闭连接(&C)";
            this.关闭连接ToolStripMenuItem.Click += new System.EventHandler(this.关闭连接ToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出EToolStripMenuItem.Image")));
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 远程屏幕DToolStripMenuItem
            // 
            this.远程屏幕DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.暂停PToolStripMenuItem,
            this.关闭CToolStripMenuItem});
            this.远程屏幕DToolStripMenuItem.Name = "远程屏幕DToolStripMenuItem";
            this.远程屏幕DToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.远程屏幕DToolStripMenuItem.Text = "远程屏幕(&D)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 暂停PToolStripMenuItem
            // 
            this.暂停PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("暂停PToolStripMenuItem.Image")));
            this.暂停PToolStripMenuItem.Name = "暂停PToolStripMenuItem";
            this.暂停PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.暂停PToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.暂停PToolStripMenuItem.Text = "暂停(&P)";
            this.暂停PToolStripMenuItem.Click += new System.EventHandler(this.暂停PToolStripMenuItem_Click);
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关闭CToolStripMenuItem.Image")));
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.关闭CToolStripMenuItem.Text = "关闭(&C)";
            this.关闭CToolStripMenuItem.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // 设置OToolStripMenuItem
            // 
            this.设置OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.屏幕发送速度SToolStripMenuItem,
            this.高级HToolStripMenuItem});
            this.设置OToolStripMenuItem.Name = "设置OToolStripMenuItem";
            this.设置OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.设置OToolStripMenuItem.Text = "设置(&O)";
            // 
            // 屏幕发送速度SToolStripMenuItem
            // 
            this.屏幕发送速度SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.快QToolStripMenuItem,
            this.中MToolStripMenuItem,
            this.慢SToolStripMenuItem});
            this.屏幕发送速度SToolStripMenuItem.Name = "屏幕发送速度SToolStripMenuItem";
            this.屏幕发送速度SToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.屏幕发送速度SToolStripMenuItem.Text = "屏幕发送速度(&S)";
            // 
            // 快QToolStripMenuItem
            // 
            this.快QToolStripMenuItem.Name = "快QToolStripMenuItem";
            this.快QToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.快QToolStripMenuItem.Text = "快(&Q)";
            this.快QToolStripMenuItem.Click += new System.EventHandler(this.快QToolStripMenuItem_Click);
            // 
            // 中MToolStripMenuItem
            // 
            this.中MToolStripMenuItem.Name = "中MToolStripMenuItem";
            this.中MToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.中MToolStripMenuItem.Text = "中(&M)";
            this.中MToolStripMenuItem.Click += new System.EventHandler(this.中MToolStripMenuItem_Click);
            // 
            // 慢SToolStripMenuItem
            // 
            this.慢SToolStripMenuItem.Name = "慢SToolStripMenuItem";
            this.慢SToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.慢SToolStripMenuItem.Text = "慢(&S)";
            this.慢SToolStripMenuItem.Click += new System.EventHandler(this.慢SToolStripMenuItem_Click);
            // 
            // 高级HToolStripMenuItem
            // 
            this.高级HToolStripMenuItem.Name = "高级HToolStripMenuItem";
            this.高级HToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.高级HToolStripMenuItem.Text = "高级(&H)";
            this.高级HToolStripMenuItem.Click += new System.EventHandler(this.高级HToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("内容CToolStripMenuItem.Image")));
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            this.内容CToolStripMenuItem.Click += new System.EventHandler(this.内容CToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于AToolStripMenuItem.Image")));
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // tls_Main
            // 
            this.tls_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tls_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Connect,
            this.tsb_ConnectAll,
            this.tsb_Exit,
            this.toolStripSeparator1,
            this.tsb_ScreenOpen,
            this.tsb_ScreenHoldOn,
            this.tsb_ScreenStop,
            this.toolStripSeparator4,
            this.tsb_UpdateServer,
            this.toolStripSeparator2,
            this.tsb_Context,
            this.tsb_AboutINCU,
            this.toolStripSeparator3,
            this.tsb_ExistApp});
            this.tls_Main.Location = new System.Drawing.Point(0, 28);
            this.tls_Main.Name = "tls_Main";
            this.tls_Main.Size = new System.Drawing.Size(1303, 27);
            this.tls_Main.TabIndex = 8;
            this.tls_Main.Text = "toolStrip1";
            // 
            // tsb_Connect
            // 
            this.tsb_Connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Connect.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Connect.Image")));
            this.tsb_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Connect.Name = "tsb_Connect";
            this.tsb_Connect.Size = new System.Drawing.Size(24, 24);
            this.tsb_Connect.Text = "指定主机";
            this.tsb_Connect.ToolTipText = "连接到指定主机";
            this.tsb_Connect.Click += new System.EventHandler(this.指定主机SToolStripMenuItem_Click);
            // 
            // tsb_ConnectAll
            // 
            this.tsb_ConnectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ConnectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ConnectAll.Image")));
            this.tsb_ConnectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ConnectAll.Name = "tsb_ConnectAll";
            this.tsb_ConnectAll.Size = new System.Drawing.Size(24, 24);
            this.tsb_ConnectAll.Text = "连接所有的主机";
            this.tsb_ConnectAll.Click += new System.EventHandler(this.所有主机AToolStripMenuItem_Click);
            // 
            // tsb_Exit
            // 
            this.tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Exit.Image")));
            this.tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exit.Name = "tsb_Exit";
            this.tsb_Exit.Size = new System.Drawing.Size(24, 24);
            this.tsb_Exit.Text = "关闭所有的连接";
            this.tsb_Exit.Click += new System.EventHandler(this.关闭连接ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_ScreenOpen
            // 
            this.tsb_ScreenOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ScreenOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ScreenOpen.Image")));
            this.tsb_ScreenOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ScreenOpen.Name = "tsb_ScreenOpen";
            this.tsb_ScreenOpen.Size = new System.Drawing.Size(24, 24);
            this.tsb_ScreenOpen.Text = "打开远程屏幕";
            this.tsb_ScreenOpen.ToolTipText = "打开远程屏幕";
            this.tsb_ScreenOpen.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // tsb_ScreenHoldOn
            // 
            this.tsb_ScreenHoldOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ScreenHoldOn.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ScreenHoldOn.Image")));
            this.tsb_ScreenHoldOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ScreenHoldOn.Name = "tsb_ScreenHoldOn";
            this.tsb_ScreenHoldOn.Size = new System.Drawing.Size(24, 24);
            this.tsb_ScreenHoldOn.Text = "暂停对远程屏幕截取";
            this.tsb_ScreenHoldOn.Click += new System.EventHandler(this.暂停PToolStripMenuItem_Click);
            // 
            // tsb_ScreenStop
            // 
            this.tsb_ScreenStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ScreenStop.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ScreenStop.Image")));
            this.tsb_ScreenStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ScreenStop.Name = "tsb_ScreenStop";
            this.tsb_ScreenStop.Size = new System.Drawing.Size(24, 24);
            this.tsb_ScreenStop.Text = "关闭远程屏幕截取";
            this.tsb_ScreenStop.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_UpdateServer
            // 
            this.tsb_UpdateServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_UpdateServer.Image = global::INCUclient.Properties.Resources.update2;
            this.tsb_UpdateServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_UpdateServer.Name = "tsb_UpdateServer";
            this.tsb_UpdateServer.Size = new System.Drawing.Size(24, 24);
            this.tsb_UpdateServer.Text = "更新服务端";
            this.tsb_UpdateServer.Click += new System.EventHandler(this.升级服务端UtoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Context
            // 
            this.tsb_Context.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Context.Image = global::INCUclient.Properties.Resources.Help;
            this.tsb_Context.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Context.Name = "tsb_Context";
            this.tsb_Context.Size = new System.Drawing.Size(24, 24);
            this.tsb_Context.Text = "帮助内容";
            this.tsb_Context.Click += new System.EventHandler(this.内容CToolStripMenuItem_Click);
            // 
            // tsb_AboutINCU
            // 
            this.tsb_AboutINCU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AboutINCU.Image = global::INCUclient.Properties.Resources.info;
            this.tsb_AboutINCU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AboutINCU.Name = "tsb_AboutINCU";
            this.tsb_AboutINCU.Size = new System.Drawing.Size(24, 24);
            this.tsb_AboutINCU.Text = "关于";
            this.tsb_AboutINCU.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_ExistApp
            // 
            this.tsb_ExistApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ExistApp.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ExistApp.Image")));
            this.tsb_ExistApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ExistApp.Name = "tsb_ExistApp";
            this.tsb_ExistApp.Size = new System.Drawing.Size(24, 24);
            this.tsb_ExistApp.Text = "退出程序";
            this.tsb_ExistApp.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trv_HostView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabs);
            this.splitContainer1.Size = new System.Drawing.Size(1303, 497);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 9;
            // 
            // trv_HostView
            // 
            this.trv_HostView.ContextMenuStrip = this.cnm_HostView;
            this.trv_HostView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_HostView.ImageIndex = 0;
            this.trv_HostView.ImageList = this.iml_HostView;
            this.trv_HostView.Location = new System.Drawing.Point(0, 0);
            this.trv_HostView.Margin = new System.Windows.Forms.Padding(4);
            this.trv_HostView.Name = "trv_HostView";
            treeNode8.ContextMenuStrip = this.cnm_HostParentView;
            treeNode8.Name = "nod_Root";
            treeNode8.Text = "所有主机";
            this.trv_HostView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.trv_HostView.SelectedImageIndex = 0;
            this.trv_HostView.ShowLines = false;
            this.trv_HostView.Size = new System.Drawing.Size(270, 497);
            this.trv_HostView.TabIndex = 0;
            this.trv_HostView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_HostView_AfterSelect);
            this.trv_HostView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trv_HostView_NodeMouseClick);
            this.trv_HostView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trv_HostView_NodeMouseDoubleClick);
            // 
            // iml_HostView
            // 
            this.iml_HostView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_HostView.ImageStream")));
            this.iml_HostView.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_HostView.Images.SetKeyName(0, "Host");
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_Speak);
            this.tabs.Controls.Add(this.tab_Desktop);
            this.tabs.Controls.Add(this.tab_FileView);
            this.tabs.Controls.Add(this.tab_Log);
            this.tabs.Controls.Add(this.tab_Info);
            this.tabs.Controls.Add(this.tab_Dos);
            this.tabs.Controls.Add(this.tab_Soft);
            this.tabs.Controls.Add(this.tab_process);
            this.tabs.Controls.Add(this.tab_Regedit);
            this.tabs.Controls.Add(this.tab_StatusScan);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.HotTrack = true;
            this.tabs.ImageList = this.iml_ExplorerImages;
            this.tabs.ItemSize = new System.Drawing.Size(55, 20);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1028, 497);
            this.tabs.TabIndex = 0;
            // 
            // tab_Speak
            // 
            this.tab_Speak.Controls.Add(this.panel3);
            this.tab_Speak.Controls.Add(this.panel2);
            this.tab_Speak.Location = new System.Drawing.Point(4, 24);
            this.tab_Speak.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Speak.Name = "tab_Speak";
            this.tab_Speak.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Speak.Size = new System.Drawing.Size(1020, 469);
            this.tab_Speak.TabIndex = 3;
            this.tab_Speak.Text = "对话";
            this.tab_Speak.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 421);
            this.panel3.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.rtb_Content);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1012, 265);
            this.panel11.TabIndex = 3;
            // 
            // rtb_Content
            // 
            this.rtb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Content.Location = new System.Drawing.Point(0, 0);
            this.rtb_Content.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.ReadOnly = true;
            this.rtb_Content.Size = new System.Drawing.Size(1012, 265);
            this.rtb_Content.TabIndex = 1;
            this.rtb_Content.Text = "";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.rtb_Speak);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 265);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1012, 156);
            this.panel10.TabIndex = 2;
            // 
            // rtb_Speak
            // 
            this.rtb_Speak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_Speak.Location = new System.Drawing.Point(0, 37);
            this.rtb_Speak.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_Speak.Name = "rtb_Speak";
            this.rtb_Speak.Size = new System.Drawing.Size(1012, 119);
            this.rtb_Speak.TabIndex = 0;
            this.rtb_Speak.Text = "";
            this.rtb_Speak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_Speak_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 425);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 40);
            this.panel2.TabIndex = 1;
            // 
            // btn_Send
            // 
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Send.Location = new System.Drawing.Point(912, 0);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 40);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = " 发 送(&S)";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tab_Desktop
            // 
            this.tab_Desktop.Controls.Add(this.pic_Screen);
            this.tab_Desktop.Location = new System.Drawing.Point(4, 24);
            this.tab_Desktop.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Desktop.Name = "tab_Desktop";
            this.tab_Desktop.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Desktop.Size = new System.Drawing.Size(1020, 470);
            this.tab_Desktop.TabIndex = 1;
            this.tab_Desktop.Text = "远程桌面";
            this.tab_Desktop.UseVisualStyleBackColor = true;
            // 
            // pic_Screen
            // 
            this.pic_Screen.BackColor = System.Drawing.SystemColors.ControlText;
            this.pic_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Screen.Location = new System.Drawing.Point(4, 4);
            this.pic_Screen.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Screen.Name = "pic_Screen";
            this.pic_Screen.Size = new System.Drawing.Size(1012, 462);
            this.pic_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Screen.TabIndex = 0;
            this.pic_Screen.TabStop = false;
            this.pic_Screen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pic_Screen_MouseDoubleClick);
            this.pic_Screen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Screen_MouseDown);
            this.pic_Screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Screen_MouseMove);
            this.pic_Screen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Screen_MouseUp);
            // 
            // tab_FileView
            // 
            this.tab_FileView.Controls.Add(this.spl_Explorer);
            this.tab_FileView.Location = new System.Drawing.Point(4, 24);
            this.tab_FileView.Margin = new System.Windows.Forms.Padding(4);
            this.tab_FileView.Name = "tab_FileView";
            this.tab_FileView.Padding = new System.Windows.Forms.Padding(4);
            this.tab_FileView.Size = new System.Drawing.Size(1020, 470);
            this.tab_FileView.TabIndex = 2;
            this.tab_FileView.Text = "文件浏览";
            this.tab_FileView.UseVisualStyleBackColor = true;
            // 
            // spl_Explorer
            // 
            this.spl_Explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_Explorer.Location = new System.Drawing.Point(4, 4);
            this.spl_Explorer.Margin = new System.Windows.Forms.Padding(4);
            this.spl_Explorer.Name = "spl_Explorer";
            this.spl_Explorer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl_Explorer.Panel1
            // 
            this.spl_Explorer.Panel1.Controls.Add(this.pnl_bottom_hostexplorer);
            this.spl_Explorer.Panel1.Controls.Add(this.pnl_top_hostexplorer);
            // 
            // spl_Explorer.Panel2
            // 
            this.spl_Explorer.Panel2.Controls.Add(this.pnl_bottom_myexplorer);
            this.spl_Explorer.Panel2.Controls.Add(this.pnl_top_myexplorer);
            this.spl_Explorer.Size = new System.Drawing.Size(1012, 462);
            this.spl_Explorer.SplitterDistance = 264;
            this.spl_Explorer.SplitterWidth = 5;
            this.spl_Explorer.TabIndex = 0;
            // 
            // pnl_bottom_hostexplorer
            // 
            this.pnl_bottom_hostexplorer.Controls.Add(this.ltv_hostexplorer);
            this.pnl_bottom_hostexplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bottom_hostexplorer.Location = new System.Drawing.Point(0, 34);
            this.pnl_bottom_hostexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_bottom_hostexplorer.Name = "pnl_bottom_hostexplorer";
            this.pnl_bottom_hostexplorer.Size = new System.Drawing.Size(1012, 230);
            this.pnl_bottom_hostexplorer.TabIndex = 5;
            // 
            // ltv_hostexplorer
            // 
            this.ltv_hostexplorer.AllowDrop = true;
            this.ltv_hostexplorer.ContextMenuStrip = this.ctm_HostExplorer;
            this.ltv_hostexplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltv_hostexplorer.LargeImageList = this.iml_ExplorerImages;
            this.ltv_hostexplorer.Location = new System.Drawing.Point(0, 0);
            this.ltv_hostexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.ltv_hostexplorer.Name = "ltv_hostexplorer";
            this.ltv_hostexplorer.Size = new System.Drawing.Size(1012, 230);
            this.ltv_hostexplorer.SmallImageList = this.iml_ExplorerImages;
            this.ltv_hostexplorer.TabIndex = 0;
            this.ltv_hostexplorer.UseCompatibleStateImageBehavior = false;
            this.ltv_hostexplorer.SelectedIndexChanged += new System.EventHandler(this.lvs_hostexplorer_SelectedIndexChanged);
            this.ltv_hostexplorer.DoubleClick += new System.EventHandler(this.lvs_hostexplorer_DoubleClick);
            // 
            // ctm_HostExplorer
            // 
            this.ctm_HostExplorer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm_HostExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem1,
            this.下载DToolStripMenuItem,
            this.刷新RToolStripMenuItem1,
            this.远程执行toolStripMenuItem1});
            this.ctm_HostExplorer.Name = "ctm_HostExplorer";
            this.ctm_HostExplorer.Size = new System.Drawing.Size(145, 108);
            // 
            // 打开OToolStripMenuItem1
            // 
            this.打开OToolStripMenuItem1.Image = global::INCUclient.Properties.Resources.Open;
            this.打开OToolStripMenuItem1.Name = "打开OToolStripMenuItem1";
            this.打开OToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.打开OToolStripMenuItem1.Text = "打开(&O)";
            this.打开OToolStripMenuItem1.Click += new System.EventHandler(this.打开OToolStripMenuItem1_Click);
            // 
            // 下载DToolStripMenuItem
            // 
            this.下载DToolStripMenuItem.Image = global::INCUclient.Properties.Resources.download;
            this.下载DToolStripMenuItem.Name = "下载DToolStripMenuItem";
            this.下载DToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.下载DToolStripMenuItem.Text = "下载(&D)";
            this.下载DToolStripMenuItem.Click += new System.EventHandler(this.下载DToolStripMenuItem_Click);
            // 
            // 刷新RToolStripMenuItem1
            // 
            this.刷新RToolStripMenuItem1.Image = global::INCUclient.Properties.Resources.Refrush;
            this.刷新RToolStripMenuItem1.Name = "刷新RToolStripMenuItem1";
            this.刷新RToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.刷新RToolStripMenuItem1.Text = "刷新(&R)";
            this.刷新RToolStripMenuItem1.Click += new System.EventHandler(this.刷新RToolStripMenuItem1_Click);
            // 
            // 远程执行toolStripMenuItem1
            // 
            this.远程执行toolStripMenuItem1.Name = "远程执行toolStripMenuItem1";
            this.远程执行toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.远程执行toolStripMenuItem1.Text = "远程执行";
            this.远程执行toolStripMenuItem1.Click += new System.EventHandler(this.远程执行toolStripMenuItem1_Click);
            // 
            // iml_ExplorerImages
            // 
            this.iml_ExplorerImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_ExplorerImages.ImageStream")));
            this.iml_ExplorerImages.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_ExplorerImages.Images.SetKeyName(0, "Disk");
            this.iml_ExplorerImages.Images.SetKeyName(1, "Directory");
            this.iml_ExplorerImages.Images.SetKeyName(2, "midi");
            this.iml_ExplorerImages.Images.SetKeyName(3, "txt");
            this.iml_ExplorerImages.Images.SetKeyName(4, "css");
            this.iml_ExplorerImages.Images.SetKeyName(5, "html");
            this.iml_ExplorerImages.Images.SetKeyName(6, "jpg");
            this.iml_ExplorerImages.Images.SetKeyName(7, "asa");
            this.iml_ExplorerImages.Images.SetKeyName(8, "asax");
            this.iml_ExplorerImages.Images.SetKeyName(9, "asp");
            this.iml_ExplorerImages.Images.SetKeyName(10, "aspx");
            this.iml_ExplorerImages.Images.SetKeyName(11, "avi");
            this.iml_ExplorerImages.Images.SetKeyName(12, "bat");
            this.iml_ExplorerImages.Images.SetKeyName(13, "bmp");
            this.iml_ExplorerImages.Images.SetKeyName(14, "c");
            this.iml_ExplorerImages.Images.SetKeyName(15, "doc");
            this.iml_ExplorerImages.Images.SetKeyName(16, "chm");
            this.iml_ExplorerImages.Images.SetKeyName(17, "class");
            this.iml_ExplorerImages.Images.SetKeyName(18, "config");
            this.iml_ExplorerImages.Images.SetKeyName(19, "cpp");
            this.iml_ExplorerImages.Images.SetKeyName(20, "cs");
            this.iml_ExplorerImages.Images.SetKeyName(21, "dll");
            this.iml_ExplorerImages.Images.SetKeyName(22, "h");
            this.iml_ExplorerImages.Images.SetKeyName(23, "dsw");
            this.iml_ExplorerImages.Images.SetKeyName(24, "dvd");
            this.iml_ExplorerImages.Images.SetKeyName(25, "exe");
            this.iml_ExplorerImages.Images.SetKeyName(26, "fon");
            this.iml_ExplorerImages.Images.SetKeyName(27, "gif");
            this.iml_ExplorerImages.Images.SetKeyName(28, "htm");
            this.iml_ExplorerImages.Images.SetKeyName(29, "hlp");
            this.iml_ExplorerImages.Images.SetKeyName(30, "hpp");
            this.iml_ExplorerImages.Images.SetKeyName(31, "ico");
            this.iml_ExplorerImages.Images.SetKeyName(32, "ima");
            this.iml_ExplorerImages.Images.SetKeyName(33, "iso");
            this.iml_ExplorerImages.Images.SetKeyName(34, "java");
            this.iml_ExplorerImages.Images.SetKeyName(35, "png");
            this.iml_ExplorerImages.Images.SetKeyName(36, "jpg");
            this.iml_ExplorerImages.Images.SetKeyName(37, "js");
            this.iml_ExplorerImages.Images.SetKeyName(38, "jsl");
            this.iml_ExplorerImages.Images.SetKeyName(39, "lnk");
            this.iml_ExplorerImages.Images.SetKeyName(40, "mdb");
            this.iml_ExplorerImages.Images.SetKeyName(41, "mdf");
            this.iml_ExplorerImages.Images.SetKeyName(42, "mht");
            this.iml_ExplorerImages.Images.SetKeyName(43, "mkv");
            this.iml_ExplorerImages.Images.SetKeyName(44, "mov");
            this.iml_ExplorerImages.Images.SetKeyName(45, "mp3");
            this.iml_ExplorerImages.Images.SetKeyName(46, "mp4");
            this.iml_ExplorerImages.Images.SetKeyName(47, "mpg");
            this.iml_ExplorerImages.Images.SetKeyName(48, "obj");
            this.iml_ExplorerImages.Images.SetKeyName(49, "ogm");
            this.iml_ExplorerImages.Images.SetKeyName(50, "png");
            this.iml_ExplorerImages.Images.SetKeyName(51, "user");
            this.iml_ExplorerImages.Images.SetKeyName(52, "ppt");
            this.iml_ExplorerImages.Images.SetKeyName(53, "psd");
            this.iml_ExplorerImages.Images.SetKeyName(54, "rar");
            this.iml_ExplorerImages.Images.SetKeyName(55, "rc");
            this.iml_ExplorerImages.Images.SetKeyName(56, "reg");
            this.iml_ExplorerImages.Images.SetKeyName(57, "res");
            this.iml_ExplorerImages.Images.SetKeyName(58, "rm");
            this.iml_ExplorerImages.Images.SetKeyName(59, "sln");
            this.iml_ExplorerImages.Images.SetKeyName(60, "sql");
            this.iml_ExplorerImages.Images.SetKeyName(61, "swf");
            this.iml_ExplorerImages.Images.SetKeyName(62, "tif");
            this.iml_ExplorerImages.Images.SetKeyName(63, "ttf");
            this.iml_ExplorerImages.Images.SetKeyName(64, "txt");
            this.iml_ExplorerImages.Images.SetKeyName(65, "url");
            this.iml_ExplorerImages.Images.SetKeyName(66, "user");
            this.iml_ExplorerImages.Images.SetKeyName(67, "vb");
            this.iml_ExplorerImages.Images.SetKeyName(68, "vbs");
            this.iml_ExplorerImages.Images.SetKeyName(69, "wav");
            this.iml_ExplorerImages.Images.SetKeyName(70, "wma");
            this.iml_ExplorerImages.Images.SetKeyName(71, "wmv");
            this.iml_ExplorerImages.Images.SetKeyName(72, "LastPath");
            this.iml_ExplorerImages.Images.SetKeyName(73, "xls");
            this.iml_ExplorerImages.Images.SetKeyName(74, "xml");
            this.iml_ExplorerImages.Images.SetKeyName(75, "Unknown");
            this.iml_ExplorerImages.Images.SetKeyName(76, "zip");
            // 
            // pnl_top_hostexplorer
            // 
            this.pnl_top_hostexplorer.Controls.Add(this.panel6);
            this.pnl_top_hostexplorer.Controls.Add(this.panel5);
            this.pnl_top_hostexplorer.Controls.Add(this.panel4);
            this.pnl_top_hostexplorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top_hostexplorer.Location = new System.Drawing.Point(0, 0);
            this.pnl_top_hostexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_top_hostexplorer.Name = "pnl_top_hostexplorer";
            this.pnl_top_hostexplorer.Size = new System.Drawing.Size(1012, 34);
            this.pnl_top_hostexplorer.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_hostexplorer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(89, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(802, 34);
            this.panel6.TabIndex = 6;
            // 
            // txt_hostexplorer
            // 
            this.txt_hostexplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_hostexplorer.Location = new System.Drawing.Point(0, 9);
            this.txt_hostexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hostexplorer.Name = "txt_hostexplorer";
            this.txt_hostexplorer.Size = new System.Drawing.Size(802, 25);
            this.txt_hostexplorer.TabIndex = 1;
            this.txt_hostexplorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_hostexplorer_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 34);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "远程主机:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_hostexplorer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 34);
            this.panel4.TabIndex = 4;
            // 
            // btn_hostexplorer
            // 
            this.btn_hostexplorer.Location = new System.Drawing.Point(17, 5);
            this.btn_hostexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hostexplorer.Name = "btn_hostexplorer";
            this.btn_hostexplorer.Size = new System.Drawing.Size(100, 29);
            this.btn_hostexplorer.TabIndex = 3;
            this.btn_hostexplorer.Text = "转到";
            this.btn_hostexplorer.UseVisualStyleBackColor = true;
            this.btn_hostexplorer.Click += new System.EventHandler(this.btn_hostexplorer_Click);
            // 
            // pnl_bottom_myexplorer
            // 
            this.pnl_bottom_myexplorer.Controls.Add(this.ltv_myexplorer);
            this.pnl_bottom_myexplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bottom_myexplorer.Location = new System.Drawing.Point(0, 34);
            this.pnl_bottom_myexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_bottom_myexplorer.Name = "pnl_bottom_myexplorer";
            this.pnl_bottom_myexplorer.Size = new System.Drawing.Size(1012, 159);
            this.pnl_bottom_myexplorer.TabIndex = 7;
            // 
            // ltv_myexplorer
            // 
            this.ltv_myexplorer.ContextMenuStrip = this.ctm_MyExplorer;
            this.ltv_myexplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltv_myexplorer.LargeImageList = this.iml_ExplorerImages;
            this.ltv_myexplorer.Location = new System.Drawing.Point(0, 0);
            this.ltv_myexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.ltv_myexplorer.Name = "ltv_myexplorer";
            this.ltv_myexplorer.Size = new System.Drawing.Size(1012, 159);
            this.ltv_myexplorer.SmallImageList = this.iml_ExplorerImages;
            this.ltv_myexplorer.TabIndex = 0;
            this.ltv_myexplorer.UseCompatibleStateImageBehavior = false;
            this.ltv_myexplorer.SelectedIndexChanged += new System.EventHandler(this.ltv_myexplorer_SelectedIndexChanged);
            this.ltv_myexplorer.DoubleClick += new System.EventHandler(this.ltv_myexplorer_DoubleClick);
            // 
            // ctm_MyExplorer
            // 
            this.ctm_MyExplorer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm_MyExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem2,
            this.上传UToolStripMenuItem,
            this.刷新RtoolStripMenuItem});
            this.ctm_MyExplorer.Name = "ctm_MyExplorer";
            this.ctm_MyExplorer.Size = new System.Drawing.Size(137, 82);
            // 
            // 打开OToolStripMenuItem2
            // 
            this.打开OToolStripMenuItem2.Image = global::INCUclient.Properties.Resources.Open;
            this.打开OToolStripMenuItem2.Name = "打开OToolStripMenuItem2";
            this.打开OToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.打开OToolStripMenuItem2.Text = "打开(&O)";
            this.打开OToolStripMenuItem2.Click += new System.EventHandler(this.打开OToolStripMenuItem2_Click);
            // 
            // 上传UToolStripMenuItem
            // 
            this.上传UToolStripMenuItem.Image = global::INCUclient.Properties.Resources.upload;
            this.上传UToolStripMenuItem.Name = "上传UToolStripMenuItem";
            this.上传UToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.上传UToolStripMenuItem.Text = "上传(&U)";
            this.上传UToolStripMenuItem.Click += new System.EventHandler(this.上传UToolStripMenuItem_Click);
            // 
            // 刷新RtoolStripMenuItem
            // 
            this.刷新RtoolStripMenuItem.Image = global::INCUclient.Properties.Resources.Refrush;
            this.刷新RtoolStripMenuItem.Name = "刷新RtoolStripMenuItem";
            this.刷新RtoolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.刷新RtoolStripMenuItem.Text = "刷新(&R)";
            this.刷新RtoolStripMenuItem.Click += new System.EventHandler(this.刷新RtoolStripMenuItem_Click);
            // 
            // pnl_top_myexplorer
            // 
            this.pnl_top_myexplorer.Controls.Add(this.panel7);
            this.pnl_top_myexplorer.Controls.Add(this.panel8);
            this.pnl_top_myexplorer.Controls.Add(this.panel9);
            this.pnl_top_myexplorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top_myexplorer.Location = new System.Drawing.Point(0, 0);
            this.pnl_top_myexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_top_myexplorer.Name = "pnl_top_myexplorer";
            this.pnl_top_myexplorer.Size = new System.Drawing.Size(1012, 34);
            this.pnl_top_myexplorer.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_myexplorer);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(89, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(802, 34);
            this.panel7.TabIndex = 6;
            // 
            // txt_myexplorer
            // 
            this.txt_myexplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_myexplorer.Location = new System.Drawing.Point(0, 9);
            this.txt_myexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_myexplorer.Name = "txt_myexplorer";
            this.txt_myexplorer.Size = new System.Drawing.Size(802, 25);
            this.txt_myexplorer.TabIndex = 1;
            this.txt_myexplorer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_myexplorer_KeyDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 34);
            this.panel8.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "我的电脑:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_myexplorer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(891, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(121, 34);
            this.panel9.TabIndex = 4;
            // 
            // btn_myexplorer
            // 
            this.btn_myexplorer.Location = new System.Drawing.Point(17, 5);
            this.btn_myexplorer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_myexplorer.Name = "btn_myexplorer";
            this.btn_myexplorer.Size = new System.Drawing.Size(100, 29);
            this.btn_myexplorer.TabIndex = 3;
            this.btn_myexplorer.Text = "转到";
            this.btn_myexplorer.UseVisualStyleBackColor = true;
            this.btn_myexplorer.Click += new System.EventHandler(this.btn_myexplorer_Click);
            // 
            // tab_Log
            // 
            this.tab_Log.Controls.Add(this.ltv_Log);
            this.tab_Log.Location = new System.Drawing.Point(4, 24);
            this.tab_Log.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Log.Name = "tab_Log";
            this.tab_Log.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Log.Size = new System.Drawing.Size(1020, 470);
            this.tab_Log.TabIndex = 4;
            this.tab_Log.Tag = "";
            this.tab_Log.Text = "日志";
            this.tab_Log.UseVisualStyleBackColor = true;
            // 
            // ltv_Log
            // 
            this.ltv_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Datetime,
            this.col_IP,
            this.col_Event});
            this.ltv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltv_Log.Location = new System.Drawing.Point(4, 4);
            this.ltv_Log.Margin = new System.Windows.Forms.Padding(4);
            this.ltv_Log.Name = "ltv_Log";
            this.ltv_Log.Size = new System.Drawing.Size(1012, 462);
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
            this.col_Event.Width = 225;
            // 
            // tab_Info
            // 
            this.tab_Info.Controls.Add(this.splitContainer5);
            this.tab_Info.Location = new System.Drawing.Point(4, 24);
            this.tab_Info.Name = "tab_Info";
            this.tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Info.Size = new System.Drawing.Size(1020, 470);
            this.tab_Info.TabIndex = 5;
            this.tab_Info.Text = "主机信息";
            this.tab_Info.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.computerInfo_rtb);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.WMISearchButton1);
            this.splitContainer5.Panel2.Controls.Add(this.label5);
            this.splitContainer5.Panel2.Controls.Add(this.label4);
            this.splitContainer5.Panel2.Controls.Add(this.label3);
            this.splitContainer5.Panel2.Controls.Add(this.WMISearch_tB2);
            this.splitContainer5.Panel2.Controls.Add(this.WMISearch_tB1);
            this.splitContainer5.Panel2.Controls.Add(this.WMISearchButton);
            this.splitContainer5.Panel2.Controls.Add(this.WMISearch_tB);
            this.splitContainer5.Panel2.Controls.Add(this.computerInfoGet_bt);
            this.splitContainer5.Size = new System.Drawing.Size(1014, 464);
            this.splitContainer5.SplitterDistance = 361;
            this.splitContainer5.TabIndex = 0;
            // 
            // computerInfo_rtb
            // 
            this.computerInfo_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerInfo_rtb.Location = new System.Drawing.Point(0, 0);
            this.computerInfo_rtb.Name = "computerInfo_rtb";
            this.computerInfo_rtb.Size = new System.Drawing.Size(1014, 361);
            this.computerInfo_rtb.TabIndex = 0;
            this.computerInfo_rtb.Text = "";
            // 
            // WMISearchButton1
            // 
            this.WMISearchButton1.Location = new System.Drawing.Point(584, 44);
            this.WMISearchButton1.Name = "WMISearchButton1";
            this.WMISearchButton1.Size = new System.Drawing.Size(104, 23);
            this.WMISearchButton1.TabIndex = 8;
            this.WMISearchButton1.Text = "WMI条件查询";
            this.WMISearchButton1.UseVisualStyleBackColor = true;
            this.WMISearchButton1.Click += new System.EventHandler(this.WMISearchButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "语句";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "语句";
            // 
            // WMISearch_tB2
            // 
            this.WMISearch_tB2.Location = new System.Drawing.Point(186, 42);
            this.WMISearch_tB2.Name = "WMISearch_tB2";
            this.WMISearch_tB2.Size = new System.Drawing.Size(392, 25);
            this.WMISearch_tB2.TabIndex = 4;
            // 
            // WMISearch_tB1
            // 
            this.WMISearch_tB1.Location = new System.Drawing.Point(26, 43);
            this.WMISearch_tB1.Name = "WMISearch_tB1";
            this.WMISearch_tB1.Size = new System.Drawing.Size(100, 25);
            this.WMISearch_tB1.TabIndex = 3;
            // 
            // WMISearchButton
            // 
            this.WMISearchButton.Location = new System.Drawing.Point(584, 13);
            this.WMISearchButton.Name = "WMISearchButton";
            this.WMISearchButton.Size = new System.Drawing.Size(104, 23);
            this.WMISearchButton.TabIndex = 2;
            this.WMISearchButton.Text = "WMI语句查询";
            this.WMISearchButton.UseVisualStyleBackColor = true;
            this.WMISearchButton.Click += new System.EventHandler(this.WMISearchButton_Click);
            // 
            // WMISearch_tB
            // 
            this.WMISearch_tB.Location = new System.Drawing.Point(186, 11);
            this.WMISearch_tB.Name = "WMISearch_tB";
            this.WMISearch_tB.Size = new System.Drawing.Size(392, 25);
            this.WMISearch_tB.TabIndex = 1;
            // 
            // computerInfoGet_bt
            // 
            this.computerInfoGet_bt.Location = new System.Drawing.Point(7, 14);
            this.computerInfoGet_bt.Name = "computerInfoGet_bt";
            this.computerInfoGet_bt.Size = new System.Drawing.Size(119, 23);
            this.computerInfoGet_bt.TabIndex = 0;
            this.computerInfoGet_bt.Text = "获取主机信息";
            this.computerInfoGet_bt.UseVisualStyleBackColor = true;
            this.computerInfoGet_bt.Click += new System.EventHandler(this.computerInfoGet_bt_Click);
            // 
            // tab_Dos
            // 
            this.tab_Dos.Controls.Add(this.splitContainer2);
            this.tab_Dos.Location = new System.Drawing.Point(4, 24);
            this.tab_Dos.Name = "tab_Dos";
            this.tab_Dos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Dos.Size = new System.Drawing.Size(1020, 470);
            this.tab_Dos.TabIndex = 6;
            this.tab_Dos.Text = "远程命令";
            this.tab_Dos.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DosResult_rtb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1014, 464);
            this.splitContainer2.SplitterDistance = 343;
            this.splitContainer2.TabIndex = 5;
            // 
            // DosResult_rtb
            // 
            this.DosResult_rtb.BackColor = System.Drawing.SystemColors.InfoText;
            this.DosResult_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DosResult_rtb.ForeColor = System.Drawing.Color.White;
            this.DosResult_rtb.Location = new System.Drawing.Point(0, 0);
            this.DosResult_rtb.Name = "DosResult_rtb";
            this.DosResult_rtb.Size = new System.Drawing.Size(1014, 343);
            this.DosResult_rtb.TabIndex = 4;
            this.DosResult_rtb.Text = "";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.DosCommand_tB);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.DosCommand_bn);
            this.splitContainer4.Size = new System.Drawing.Size(1014, 117);
            this.splitContainer4.SplitterDistance = 924;
            this.splitContainer4.TabIndex = 0;
            // 
            // DosCommand_tB
            // 
            this.DosCommand_tB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DosCommand_tB.Location = new System.Drawing.Point(0, 0);
            this.DosCommand_tB.Multiline = true;
            this.DosCommand_tB.Name = "DosCommand_tB";
            this.DosCommand_tB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DosCommand_tB.Size = new System.Drawing.Size(924, 117);
            this.DosCommand_tB.TabIndex = 2;
            // 
            // DosCommand_bn
            // 
            this.DosCommand_bn.Location = new System.Drawing.Point(3, 3);
            this.DosCommand_bn.Name = "DosCommand_bn";
            this.DosCommand_bn.Size = new System.Drawing.Size(75, 23);
            this.DosCommand_bn.TabIndex = 3;
            this.DosCommand_bn.Text = "执行";
            this.DosCommand_bn.UseVisualStyleBackColor = true;
            this.DosCommand_bn.Click += new System.EventHandler(this.DosCommand_bn_Click);
            // 
            // tab_Soft
            // 
            this.tab_Soft.Controls.Add(this.splitContainer3);
            this.tab_Soft.Location = new System.Drawing.Point(4, 24);
            this.tab_Soft.Name = "tab_Soft";
            this.tab_Soft.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Soft.Size = new System.Drawing.Size(1020, 470);
            this.tab_Soft.TabIndex = 7;
            this.tab_Soft.Text = "推送脚本";
            this.tab_Soft.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer3.Size = new System.Drawing.Size(1014, 464);
            this.splitContainer3.SplitterDistance = 378;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.Script_rtb);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.Script_IsWaiting_cB);
            this.splitContainer8.Panel2.Controls.Add(this.label6);
            this.splitContainer8.Panel2.Controls.Add(this.Script_paramerer_tB);
            this.splitContainer8.Panel2.Controls.Add(this.ScriptFileOpenButton);
            this.splitContainer8.Panel2.Controls.Add(this.ScriptSendButton);
            this.splitContainer8.Panel2.Controls.Add(this.Script_filepath_tB);
            this.splitContainer8.Size = new System.Drawing.Size(378, 464);
            this.splitContainer8.SplitterDistance = 400;
            this.splitContainer8.TabIndex = 0;
            // 
            // Script_rtb
            // 
            this.Script_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Script_rtb.Location = new System.Drawing.Point(0, 0);
            this.Script_rtb.Name = "Script_rtb";
            this.Script_rtb.Size = new System.Drawing.Size(378, 400);
            this.Script_rtb.TabIndex = 0;
            this.Script_rtb.Text = "";
            // 
            // Script_IsWaiting_cB
            // 
            this.Script_IsWaiting_cB.AutoSize = true;
            this.Script_IsWaiting_cB.Checked = true;
            this.Script_IsWaiting_cB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Script_IsWaiting_cB.Location = new System.Drawing.Point(175, 37);
            this.Script_IsWaiting_cB.Name = "Script_IsWaiting_cB";
            this.Script_IsWaiting_cB.Size = new System.Drawing.Size(119, 19);
            this.Script_IsWaiting_cB.TabIndex = 5;
            this.Script_IsWaiting_cB.Text = "等待执行结束";
            this.Script_IsWaiting_cB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "参数";
            // 
            // Script_paramerer_tB
            // 
            this.Script_paramerer_tB.Location = new System.Drawing.Point(46, 32);
            this.Script_paramerer_tB.Name = "Script_paramerer_tB";
            this.Script_paramerer_tB.Size = new System.Drawing.Size(112, 25);
            this.Script_paramerer_tB.TabIndex = 3;
            // 
            // ScriptFileOpenButton
            // 
            this.ScriptFileOpenButton.Location = new System.Drawing.Point(339, 6);
            this.ScriptFileOpenButton.Name = "ScriptFileOpenButton";
            this.ScriptFileOpenButton.Size = new System.Drawing.Size(33, 23);
            this.ScriptFileOpenButton.TabIndex = 2;
            this.ScriptFileOpenButton.Text = "...";
            this.ScriptFileOpenButton.UseVisualStyleBackColor = true;
            this.ScriptFileOpenButton.Click += new System.EventHandler(this.ScriptFileOpenButton_Click);
            // 
            // ScriptSendButton
            // 
            this.ScriptSendButton.Location = new System.Drawing.Point(300, 34);
            this.ScriptSendButton.Name = "ScriptSendButton";
            this.ScriptSendButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptSendButton.TabIndex = 1;
            this.ScriptSendButton.Text = "推送执行";
            this.ScriptSendButton.UseVisualStyleBackColor = true;
            this.ScriptSendButton.Click += new System.EventHandler(this.ScriptSendButton_Click);
            // 
            // Script_filepath_tB
            // 
            this.Script_filepath_tB.Location = new System.Drawing.Point(3, 4);
            this.Script_filepath_tB.Name = "Script_filepath_tB";
            this.Script_filepath_tB.Size = new System.Drawing.Size(330, 25);
            this.Script_filepath_tB.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Script_bat);
            this.tabControl2.Controls.Add(this.Script_rar);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(632, 464);
            this.tabControl2.TabIndex = 0;
            // 
            // Script_bat
            // 
            this.Script_bat.Controls.Add(this.splitContainer9);
            this.Script_bat.Location = new System.Drawing.Point(4, 25);
            this.Script_bat.Name = "Script_bat";
            this.Script_bat.Padding = new System.Windows.Forms.Padding(3);
            this.Script_bat.Size = new System.Drawing.Size(624, 435);
            this.Script_bat.TabIndex = 0;
            this.Script_bat.Text = "BAT脚本";
            this.Script_bat.UseVisualStyleBackColor = true;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer9.Location = new System.Drawing.Point(3, 3);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.ScriptBatEdit_rtb);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.Script_bat_IsWaiting_cB);
            this.splitContainer9.Panel2.Controls.Add(this.ScriptBatClearButton);
            this.splitContainer9.Panel2.Controls.Add(this.ScriptBatCheckButton);
            this.splitContainer9.Panel2.Controls.Add(this.label7);
            this.splitContainer9.Panel2.Controls.Add(this.Script_bat_paramerer_tB);
            this.splitContainer9.Panel2.Controls.Add(this.ScriptBatSendButton);
            this.splitContainer9.Panel2.Controls.Add(this.ScriptBatLocalTestButton);
            this.splitContainer9.Panel2.Controls.Add(this.ScriptBatClipboardButton);
            this.splitContainer9.Size = new System.Drawing.Size(618, 429);
            this.splitContainer9.SplitterDistance = 385;
            this.splitContainer9.TabIndex = 0;
            // 
            // ScriptBatEdit_rtb
            // 
            this.ScriptBatEdit_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptBatEdit_rtb.Location = new System.Drawing.Point(0, 0);
            this.ScriptBatEdit_rtb.Name = "ScriptBatEdit_rtb";
            this.ScriptBatEdit_rtb.Size = new System.Drawing.Size(618, 385);
            this.ScriptBatEdit_rtb.TabIndex = 0;
            this.ScriptBatEdit_rtb.Text = "";
            // 
            // Script_bat_IsWaiting_cB
            // 
            this.Script_bat_IsWaiting_cB.AutoSize = true;
            this.Script_bat_IsWaiting_cB.Checked = true;
            this.Script_bat_IsWaiting_cB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Script_bat_IsWaiting_cB.Location = new System.Drawing.Point(360, 11);
            this.Script_bat_IsWaiting_cB.Name = "Script_bat_IsWaiting_cB";
            this.Script_bat_IsWaiting_cB.Size = new System.Drawing.Size(89, 19);
            this.Script_bat_IsWaiting_cB.TabIndex = 6;
            this.Script_bat_IsWaiting_cB.Text = "等待结束";
            this.Script_bat_IsWaiting_cB.UseVisualStyleBackColor = true;
            // 
            // ScriptBatClearButton
            // 
            this.ScriptBatClearButton.Location = new System.Drawing.Point(65, 8);
            this.ScriptBatClearButton.Name = "ScriptBatClearButton";
            this.ScriptBatClearButton.Size = new System.Drawing.Size(59, 23);
            this.ScriptBatClearButton.TabIndex = 8;
            this.ScriptBatClearButton.Text = "清空";
            this.ScriptBatClearButton.UseVisualStyleBackColor = true;
            this.ScriptBatClearButton.Click += new System.EventHandler(this.ScriptBatClearButton_Click);
            // 
            // ScriptBatCheckButton
            // 
            this.ScriptBatCheckButton.Location = new System.Drawing.Point(130, 8);
            this.ScriptBatCheckButton.Name = "ScriptBatCheckButton";
            this.ScriptBatCheckButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptBatCheckButton.TabIndex = 7;
            this.ScriptBatCheckButton.Text = "语法检查";
            this.ScriptBatCheckButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "参数";
            // 
            // Script_bat_paramerer_tB
            // 
            this.Script_bat_paramerer_tB.Location = new System.Drawing.Point(242, 6);
            this.Script_bat_paramerer_tB.Name = "Script_bat_paramerer_tB";
            this.Script_bat_paramerer_tB.Size = new System.Drawing.Size(112, 25);
            this.Script_bat_paramerer_tB.TabIndex = 5;
            // 
            // ScriptBatSendButton
            // 
            this.ScriptBatSendButton.Location = new System.Drawing.Point(531, 8);
            this.ScriptBatSendButton.Name = "ScriptBatSendButton";
            this.ScriptBatSendButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScriptBatSendButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptBatSendButton.TabIndex = 2;
            this.ScriptBatSendButton.Text = "推送执行";
            this.ScriptBatSendButton.UseVisualStyleBackColor = true;
            this.ScriptBatSendButton.Click += new System.EventHandler(this.ScriptBatSendButton_Click);
            // 
            // ScriptBatLocalTestButton
            // 
            this.ScriptBatLocalTestButton.Location = new System.Drawing.Point(450, 8);
            this.ScriptBatLocalTestButton.Name = "ScriptBatLocalTestButton";
            this.ScriptBatLocalTestButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScriptBatLocalTestButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptBatLocalTestButton.TabIndex = 1;
            this.ScriptBatLocalTestButton.Text = "本地测试";
            this.ScriptBatLocalTestButton.UseVisualStyleBackColor = true;
            this.ScriptBatLocalTestButton.Click += new System.EventHandler(this.ScriptBatLocalTestButton_Click);
            // 
            // ScriptBatClipboardButton
            // 
            this.ScriptBatClipboardButton.Location = new System.Drawing.Point(3, 8);
            this.ScriptBatClipboardButton.Name = "ScriptBatClipboardButton";
            this.ScriptBatClipboardButton.Size = new System.Drawing.Size(56, 23);
            this.ScriptBatClipboardButton.TabIndex = 0;
            this.ScriptBatClipboardButton.Text = "粘贴";
            this.ScriptBatClipboardButton.UseVisualStyleBackColor = true;
            this.ScriptBatClipboardButton.Click += new System.EventHandler(this.ScriptBatClipboardButton_Click);
            // 
            // Script_rar
            // 
            this.Script_rar.Controls.Add(this.splitContainer10);
            this.Script_rar.Location = new System.Drawing.Point(4, 25);
            this.Script_rar.Name = "Script_rar";
            this.Script_rar.Padding = new System.Windows.Forms.Padding(3);
            this.Script_rar.Size = new System.Drawing.Size(624, 435);
            this.Script_rar.TabIndex = 1;
            this.Script_rar.Text = "打包脚本";
            this.Script_rar.UseVisualStyleBackColor = true;
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer10.Location = new System.Drawing.Point(3, 3);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.ScriptRARLocalTestButton);
            this.splitContainer10.Panel1.Controls.Add(this.ScriptRarSend);
            this.splitContainer10.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(618, 429);
            this.splitContainer10.SplitterDistance = 120;
            this.splitContainer10.TabIndex = 0;
            // 
            // ScriptRARLocalTestButton
            // 
            this.ScriptRARLocalTestButton.Location = new System.Drawing.Point(486, 74);
            this.ScriptRARLocalTestButton.Name = "ScriptRARLocalTestButton";
            this.ScriptRARLocalTestButton.Size = new System.Drawing.Size(112, 23);
            this.ScriptRARLocalTestButton.TabIndex = 2;
            this.ScriptRARLocalTestButton.Text = "打包本地测试";
            this.ScriptRARLocalTestButton.UseVisualStyleBackColor = true;
            this.ScriptRARLocalTestButton.Click += new System.EventHandler(this.ScriptRARLocalTestButton_Click);
            // 
            // ScriptRarSend
            // 
            this.ScriptRarSend.Location = new System.Drawing.Point(486, 45);
            this.ScriptRarSend.Name = "ScriptRarSend";
            this.ScriptRarSend.Size = new System.Drawing.Size(112, 23);
            this.ScriptRarSend.TabIndex = 1;
            this.ScriptRarSend.Text = "打包推送执行";
            this.ScriptRarSend.UseVisualStyleBackColor = true;
            this.ScriptRarSend.Click += new System.EventHandler(this.ScriptRarSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScriptRAR_pamarerer_tB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ScriptRAR3_cB);
            this.groupBox2.Controls.Add(this.ScriptRAR2_cB);
            this.groupBox2.Controls.Add(this.ScriptRAR1_cB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // ScriptRAR_pamarerer_tB
            // 
            this.ScriptRAR_pamarerer_tB.Location = new System.Drawing.Point(56, 95);
            this.ScriptRAR_pamarerer_tB.Name = "ScriptRAR_pamarerer_tB";
            this.ScriptRAR_pamarerer_tB.Size = new System.Drawing.Size(100, 25);
            this.ScriptRAR_pamarerer_tB.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "参数";
            // 
            // ScriptRAR3_cB
            // 
            this.ScriptRAR3_cB.AutoSize = true;
            this.ScriptRAR3_cB.Location = new System.Drawing.Point(16, 74);
            this.ScriptRAR3_cB.Name = "ScriptRAR3_cB";
            this.ScriptRAR3_cB.Size = new System.Drawing.Size(104, 19);
            this.ScriptRAR3_cB.TabIndex = 2;
            this.ScriptRAR3_cB.Text = "执行后清除";
            this.ScriptRAR3_cB.UseVisualStyleBackColor = true;
            // 
            // ScriptRAR2_cB
            // 
            this.ScriptRAR2_cB.AutoSize = true;
            this.ScriptRAR2_cB.Location = new System.Drawing.Point(16, 49);
            this.ScriptRAR2_cB.Name = "ScriptRAR2_cB";
            this.ScriptRAR2_cB.Size = new System.Drawing.Size(149, 19);
            this.ScriptRAR2_cB.TabIndex = 1;
            this.ScriptRAR2_cB.Text = "直接覆盖已有文件";
            this.ScriptRAR2_cB.UseVisualStyleBackColor = true;
            // 
            // ScriptRAR1_cB
            // 
            this.ScriptRAR1_cB.AutoSize = true;
            this.ScriptRAR1_cB.Location = new System.Drawing.Point(16, 24);
            this.ScriptRAR1_cB.Name = "ScriptRAR1_cB";
            this.ScriptRAR1_cB.Size = new System.Drawing.Size(149, 19);
            this.ScriptRAR1_cB.TabIndex = 0;
            this.ScriptRAR1_cB.Text = "等待所有执行结束";
            this.ScriptRAR1_cB.UseVisualStyleBackColor = true;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            this.splitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer11.Size = new System.Drawing.Size(618, 305);
            this.splitContainer11.SplitterDistance = 151;
            this.splitContainer11.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ScriptRARFile1_dGV);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(618, 151);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "脚本文件---会被顺序执行";
            // 
            // ScriptRARFile1_dGV
            // 
            this.ScriptRARFile1_dGV.AllowUserToDeleteRows = false;
            this.ScriptRARFile1_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptRARFile1_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column5,
            this.dataGridViewButtonColumn1});
            this.ScriptRARFile1_dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptRARFile1_dGV.Location = new System.Drawing.Point(3, 21);
            this.ScriptRARFile1_dGV.Name = "ScriptRARFile1_dGV";
            this.ScriptRARFile1_dGV.ReadOnly = true;
            this.ScriptRARFile1_dGV.RowHeadersVisible = false;
            this.ScriptRARFile1_dGV.RowTemplate.Height = 27;
            this.ScriptRARFile1_dGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ScriptRARFile1_dGV.Size = new System.Drawing.Size(612, 127);
            this.ScriptRARFile1_dGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "文件名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "路径";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "大小";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "...";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "操作";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "删除";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScriptRARFile2_dGV);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 150);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "资源文件---不会执行";
            // 
            // ScriptRARFile2_dGV
            // 
            this.ScriptRARFile2_dGV.AllowUserToDeleteRows = false;
            this.ScriptRARFile2_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptRARFile2_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4});
            this.ScriptRARFile2_dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptRARFile2_dGV.Location = new System.Drawing.Point(3, 21);
            this.ScriptRARFile2_dGV.Name = "ScriptRARFile2_dGV";
            this.ScriptRARFile2_dGV.ReadOnly = true;
            this.ScriptRARFile2_dGV.RowHeadersVisible = false;
            this.ScriptRARFile2_dGV.RowTemplate.Height = 27;
            this.ScriptRARFile2_dGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ScriptRARFile2_dGV.Size = new System.Drawing.Size(612, 126);
            this.ScriptRARFile2_dGV.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "文件名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "路径";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "大小";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "...";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "操作";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "删除";
            // 
            // tab_process
            // 
            this.tab_process.Controls.Add(this.splitContainer7);
            this.tab_process.Location = new System.Drawing.Point(4, 24);
            this.tab_process.Name = "tab_process";
            this.tab_process.Size = new System.Drawing.Size(1020, 470);
            this.tab_process.TabIndex = 8;
            this.tab_process.Text = "进程管理";
            this.tab_process.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.PSS_rtb);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer7.Size = new System.Drawing.Size(1020, 470);
            this.splitContainer7.SplitterDistance = 338;
            this.splitContainer7.TabIndex = 0;
            // 
            // PSS_rtb
            // 
            this.PSS_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSS_rtb.Location = new System.Drawing.Point(0, 0);
            this.PSS_rtb.Name = "PSS_rtb";
            this.PSS_rtb.Size = new System.Drawing.Size(338, 470);
            this.PSS_rtb.TabIndex = 0;
            this.PSS_rtb.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 470);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.process_lv);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "进程管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // process_lv
            // 
            this.process_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader14,
            this.columnHeader15});
            this.process_lv.ContextMenuStrip = this.ctm_process;
            this.process_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.process_lv.FullRowSelect = true;
            this.process_lv.HideSelection = false;
            this.process_lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.process_lv.Location = new System.Drawing.Point(3, 3);
            this.process_lv.Name = "process_lv";
            this.process_lv.Size = new System.Drawing.Size(664, 435);
            this.process_lv.TabIndex = 0;
            this.process_lv.UseCompatibleStateImageBehavior = false;
            this.process_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程Id";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程名称";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "进程句柄";
            this.columnHeader3.Width = 66;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "进程路径";
            this.columnHeader14.Width = 157;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "启动时间";
            // 
            // ctm_process
            // 
            this.ctm_process.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm_process.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新进程toolStripMenuItem1,
            this.结束任务toolStripMenuItem1});
            this.ctm_process.Name = "ctm_process";
            this.ctm_process.Size = new System.Drawing.Size(145, 56);
            // 
            // 刷新进程toolStripMenuItem1
            // 
            this.刷新进程toolStripMenuItem1.Name = "刷新进程toolStripMenuItem1";
            this.刷新进程toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.刷新进程toolStripMenuItem1.Text = "刷新进程";
            this.刷新进程toolStripMenuItem1.Click += new System.EventHandler(this.刷新进程toolStripMenuItem1_Click);
            // 
            // 结束任务toolStripMenuItem1
            // 
            this.结束任务toolStripMenuItem1.Name = "结束任务toolStripMenuItem1";
            this.结束任务toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.结束任务toolStripMenuItem1.Text = "结束任务";
            this.结束任务toolStripMenuItem1.Click += new System.EventHandler(this.结束任务toolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Service_lv);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "服务管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Service_lv
            // 
            this.Service_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader18,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader16,
            this.columnHeader17});
            this.Service_lv.ContextMenuStrip = this.ctm_secvice;
            this.Service_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Service_lv.FullRowSelect = true;
            this.Service_lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Service_lv.Location = new System.Drawing.Point(3, 3);
            this.Service_lv.Name = "Service_lv";
            this.Service_lv.Size = new System.Drawing.Size(664, 435);
            this.Service_lv.TabIndex = 0;
            this.Service_lv.UseCompatibleStateImageBehavior = false;
            this.Service_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "名称";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "全称";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "描述";
            this.columnHeader5.Width = 174;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "启动类型";
            this.columnHeader7.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "登录为";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "执行路径";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "进程Id";
            // 
            // ctm_secvice
            // 
            this.ctm_secvice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm_secvice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新toolStripMenuItem1,
            this.启动toolStripMenuItem1,
            this.停止toolStripMenuItem1,
            this.启动类型toolStripMenuItem1});
            this.ctm_secvice.Name = "ctm_secvice";
            this.ctm_secvice.Size = new System.Drawing.Size(145, 108);
            // 
            // 刷新toolStripMenuItem1
            // 
            this.刷新toolStripMenuItem1.Name = "刷新toolStripMenuItem1";
            this.刷新toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.刷新toolStripMenuItem1.Text = "刷新";
            this.刷新toolStripMenuItem1.Click += new System.EventHandler(this.刷新toolStripMenuItem1_Click);
            // 
            // 启动toolStripMenuItem1
            // 
            this.启动toolStripMenuItem1.Name = "启动toolStripMenuItem1";
            this.启动toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.启动toolStripMenuItem1.Text = "启动";
            this.启动toolStripMenuItem1.Click += new System.EventHandler(this.启动toolStripMenuItem1_Click);
            // 
            // 停止toolStripMenuItem1
            // 
            this.停止toolStripMenuItem1.Name = "停止toolStripMenuItem1";
            this.停止toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.停止toolStripMenuItem1.Text = "停止";
            this.停止toolStripMenuItem1.Click += new System.EventHandler(this.停止toolStripMenuItem1_Click);
            // 
            // 启动类型toolStripMenuItem1
            // 
            this.启动类型toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动toolStripMenuItem1,
            this.手动toolStripMenuItem1,
            this.禁止toolStripMenuItem1});
            this.启动类型toolStripMenuItem1.Name = "启动类型toolStripMenuItem1";
            this.启动类型toolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.启动类型toolStripMenuItem1.Text = "启动类型";
            // 
            // 自动toolStripMenuItem1
            // 
            this.自动toolStripMenuItem1.Name = "自动toolStripMenuItem1";
            this.自动toolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.自动toolStripMenuItem1.Text = "自动";
            this.自动toolStripMenuItem1.Click += new System.EventHandler(this.自动toolStripMenuItem1_Click);
            // 
            // 手动toolStripMenuItem1
            // 
            this.手动toolStripMenuItem1.Name = "手动toolStripMenuItem1";
            this.手动toolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.手动toolStripMenuItem1.Text = "手动";
            this.手动toolStripMenuItem1.Click += new System.EventHandler(this.手动toolStripMenuItem1_Click);
            // 
            // 禁止toolStripMenuItem1
            // 
            this.禁止toolStripMenuItem1.Name = "禁止toolStripMenuItem1";
            this.禁止toolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.禁止toolStripMenuItem1.Text = "禁止";
            this.禁止toolStripMenuItem1.Click += new System.EventHandler(this.禁止toolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Startup_lv);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(670, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "启动项管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Startup_lv
            // 
            this.Startup_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader13});
            this.Startup_lv.ContextMenuStrip = this.ctm_startup;
            this.Startup_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Startup_lv.FullRowSelect = true;
            this.Startup_lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.Startup_lv.Location = new System.Drawing.Point(0, 0);
            this.Startup_lv.Name = "Startup_lv";
            this.Startup_lv.Size = new System.Drawing.Size(670, 441);
            this.Startup_lv.TabIndex = 0;
            this.Startup_lv.UseCompatibleStateImageBehavior = false;
            this.Startup_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "名称";
            this.columnHeader9.Width = 98;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "命令行";
            // 
            // ctm_startup
            // 
            this.ctm_startup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm_startup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新toolStripMenuItem2,
            this.禁用toolStripMenuItem2});
            this.ctm_startup.Name = "ctm_startup";
            this.ctm_startup.Size = new System.Drawing.Size(115, 56);
            // 
            // 刷新toolStripMenuItem2
            // 
            this.刷新toolStripMenuItem2.Name = "刷新toolStripMenuItem2";
            this.刷新toolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.刷新toolStripMenuItem2.Text = "刷新";
            this.刷新toolStripMenuItem2.Click += new System.EventHandler(this.刷新toolStripMenuItem2_Click);
            // 
            // 禁用toolStripMenuItem2
            // 
            this.禁用toolStripMenuItem2.Name = "禁用toolStripMenuItem2";
            this.禁用toolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.禁用toolStripMenuItem2.Text = "禁用";
            this.禁用toolStripMenuItem2.Click += new System.EventHandler(this.禁用toolStripMenuItem2_Click);
            // 
            // tab_Regedit
            // 
            this.tab_Regedit.Controls.Add(this.splitContainer12);
            this.tab_Regedit.Location = new System.Drawing.Point(4, 24);
            this.tab_Regedit.Name = "tab_Regedit";
            this.tab_Regedit.Size = new System.Drawing.Size(1020, 469);
            this.tab_Regedit.TabIndex = 9;
            this.tab_Regedit.Text = "注册表管理";
            this.tab_Regedit.UseVisualStyleBackColor = true;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.Reg_tV);
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.splitContainer13);
            this.splitContainer12.Size = new System.Drawing.Size(1020, 469);
            this.splitContainer12.SplitterDistance = 340;
            this.splitContainer12.TabIndex = 0;
            // 
            // Reg_tV
            // 
            this.Reg_tV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reg_tV.Location = new System.Drawing.Point(0, 0);
            this.Reg_tV.Name = "Reg_tV";
            treeNode1.Name = "HKEY_CLASSES_ROOT";
            treeNode1.Text = "HKEY_CLASSES_ROOT";
            treeNode1.ToolTipText = "HKEY_CLASSES_ROOT";
            treeNode9.Name = "HKEY_CURRENT_USER";
            treeNode9.Text = "HKEY_CURRENT_USER";
            treeNode9.ToolTipText = "HKEY_CURRENT_USER";
            treeNode10.Name = "HKEY_LOCAL_MACHINE";
            treeNode10.Text = "HKEY_LOCAL_MACHINE";
            treeNode10.ToolTipText = "HKEY_LOCAL_MACHINE";
            treeNode11.Name = "HKEY_USERS";
            treeNode11.Text = "HKEY_USERS";
            treeNode11.ToolTipText = "HKEY_USERS";
            treeNode12.Name = "HKEY_CURRENT_CONFIG";
            treeNode12.Text = "HKEY_CURRENT_CONFIG";
            treeNode12.ToolTipText = "HKEY_CURRENT_CONFIG";
            treeNode13.Name = "节点0";
            treeNode13.Text = "远程注册表根目录";
            this.Reg_tV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.Reg_tV.Size = new System.Drawing.Size(340, 469);
            this.Reg_tV.TabIndex = 0;
            this.Reg_tV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Reg_tV_AfterSelect);
            // 
            // splitContainer13
            // 
            this.splitContainer13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer13.Location = new System.Drawing.Point(0, 0);
            this.splitContainer13.Name = "splitContainer13";
            this.splitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            this.splitContainer13.Panel1.Controls.Add(this.Reg_lV);
            // 
            // splitContainer13.Panel2
            // 
            this.splitContainer13.Panel2.Controls.Add(this.splitContainer14);
            this.splitContainer13.Size = new System.Drawing.Size(676, 469);
            this.splitContainer13.SplitterDistance = 224;
            this.splitContainer13.TabIndex = 0;
            // 
            // Reg_lV
            // 
            this.Reg_lV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.Reg_lV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reg_lV.Location = new System.Drawing.Point(0, 0);
            this.Reg_lV.Name = "Reg_lV";
            this.Reg_lV.Size = new System.Drawing.Size(676, 224);
            this.Reg_lV.TabIndex = 0;
            this.Reg_lV.UseCompatibleStateImageBehavior = false;
            this.Reg_lV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "名称";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "类型";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "数据";
            this.columnHeader12.Width = 400;
            // 
            // splitContainer14
            // 
            this.splitContainer14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer14.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer14.Location = new System.Drawing.Point(0, 0);
            this.splitContainer14.Name = "splitContainer14";
            // 
            // splitContainer14.Panel1
            // 
            this.splitContainer14.Panel1.Controls.Add(this.Reg_rTB);
            // 
            // splitContainer14.Panel2
            // 
            this.splitContainer14.Panel2.Controls.Add(this.RegImportButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegDirDelButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegDirModiButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegDirAddButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegKeyDelButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegKeyAddButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegKeyModiButton);
            this.splitContainer14.Panel2.Controls.Add(this.RegKeyOutportButton);
            this.splitContainer14.Size = new System.Drawing.Size(676, 241);
            this.splitContainer14.SplitterDistance = 560;
            this.splitContainer14.TabIndex = 0;
            // 
            // Reg_rTB
            // 
            this.Reg_rTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reg_rTB.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.Reg_rTB.Location = new System.Drawing.Point(0, 0);
            this.Reg_rTB.Name = "Reg_rTB";
            this.Reg_rTB.Size = new System.Drawing.Size(560, 241);
            this.Reg_rTB.TabIndex = 0;
            this.Reg_rTB.Text = "";
            this.Reg_rTB.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // RegImportButton
            // 
            this.RegImportButton.Location = new System.Drawing.Point(18, 179);
            this.RegImportButton.Name = "RegImportButton";
            this.RegImportButton.Size = new System.Drawing.Size(75, 23);
            this.RegImportButton.TabIndex = 7;
            this.RegImportButton.Text = "导入...";
            this.RegImportButton.UseVisualStyleBackColor = true;
            // 
            // RegDirDelButton
            // 
            this.RegDirDelButton.Location = new System.Drawing.Point(18, 149);
            this.RegDirDelButton.Name = "RegDirDelButton";
            this.RegDirDelButton.Size = new System.Drawing.Size(75, 23);
            this.RegDirDelButton.TabIndex = 6;
            this.RegDirDelButton.Text = "删除子项";
            this.RegDirDelButton.UseVisualStyleBackColor = true;
            // 
            // RegDirModiButton
            // 
            this.RegDirModiButton.Location = new System.Drawing.Point(18, 120);
            this.RegDirModiButton.Name = "RegDirModiButton";
            this.RegDirModiButton.Size = new System.Drawing.Size(75, 23);
            this.RegDirModiButton.TabIndex = 5;
            this.RegDirModiButton.Text = "修改子项";
            this.RegDirModiButton.UseVisualStyleBackColor = true;
            // 
            // RegDirAddButton
            // 
            this.RegDirAddButton.Location = new System.Drawing.Point(18, 91);
            this.RegDirAddButton.Name = "RegDirAddButton";
            this.RegDirAddButton.Size = new System.Drawing.Size(75, 23);
            this.RegDirAddButton.TabIndex = 4;
            this.RegDirAddButton.Text = "新增子项";
            this.RegDirAddButton.UseVisualStyleBackColor = true;
            // 
            // RegKeyDelButton
            // 
            this.RegKeyDelButton.Location = new System.Drawing.Point(18, 61);
            this.RegKeyDelButton.Name = "RegKeyDelButton";
            this.RegKeyDelButton.Size = new System.Drawing.Size(75, 23);
            this.RegKeyDelButton.TabIndex = 3;
            this.RegKeyDelButton.Text = "删除";
            this.RegKeyDelButton.UseVisualStyleBackColor = true;
            // 
            // RegKeyAddButton
            // 
            this.RegKeyAddButton.Location = new System.Drawing.Point(18, 32);
            this.RegKeyAddButton.Name = "RegKeyAddButton";
            this.RegKeyAddButton.Size = new System.Drawing.Size(75, 23);
            this.RegKeyAddButton.TabIndex = 2;
            this.RegKeyAddButton.Text = "新增";
            this.RegKeyAddButton.UseVisualStyleBackColor = true;
            // 
            // RegKeyModiButton
            // 
            this.RegKeyModiButton.Location = new System.Drawing.Point(18, 3);
            this.RegKeyModiButton.Name = "RegKeyModiButton";
            this.RegKeyModiButton.Size = new System.Drawing.Size(75, 23);
            this.RegKeyModiButton.TabIndex = 1;
            this.RegKeyModiButton.Text = "修改";
            this.RegKeyModiButton.UseVisualStyleBackColor = true;
            // 
            // RegKeyOutportButton
            // 
            this.RegKeyOutportButton.Location = new System.Drawing.Point(18, 208);
            this.RegKeyOutportButton.Name = "RegKeyOutportButton";
            this.RegKeyOutportButton.Size = new System.Drawing.Size(75, 23);
            this.RegKeyOutportButton.TabIndex = 0;
            this.RegKeyOutportButton.Text = "导出...";
            this.RegKeyOutportButton.UseVisualStyleBackColor = true;
            // 
            // tab_StatusScan
            // 
            this.tab_StatusScan.Controls.Add(this.splitContainer6);
            this.tab_StatusScan.Location = new System.Drawing.Point(4, 24);
            this.tab_StatusScan.Name = "tab_StatusScan";
            this.tab_StatusScan.Size = new System.Drawing.Size(1020, 470);
            this.tab_StatusScan.TabIndex = 10;
            this.tab_StatusScan.Text = "状态检测";
            this.tab_StatusScan.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.chkStatus_rtb);
            this.splitContainer6.Size = new System.Drawing.Size(1020, 470);
            this.splitContainer6.SplitterDistance = 79;
            this.splitContainer6.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStatusOKButton);
            this.groupBox1.Controls.Add(this.chkStatusButton);
            this.groupBox1.Controls.Add(this.chkTax_cB);
            this.groupBox1.Controls.Add(this.chkOffice_cB);
            this.groupBox1.Controls.Add(this.chkSafe_cB);
            this.groupBox1.Controls.Add(this.chkInfo_cB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主机运行状态检测";
            // 
            // chkStatusOKButton
            // 
            this.chkStatusOKButton.Location = new System.Drawing.Point(610, 37);
            this.chkStatusOKButton.Name = "chkStatusOKButton";
            this.chkStatusOKButton.Size = new System.Drawing.Size(75, 23);
            this.chkStatusOKButton.TabIndex = 5;
            this.chkStatusOKButton.Text = "开始修复";
            this.chkStatusOKButton.UseVisualStyleBackColor = true;
            // 
            // chkStatusButton
            // 
            this.chkStatusButton.Location = new System.Drawing.Point(515, 37);
            this.chkStatusButton.Name = "chkStatusButton";
            this.chkStatusButton.Size = new System.Drawing.Size(75, 23);
            this.chkStatusButton.TabIndex = 4;
            this.chkStatusButton.Text = "开始检查";
            this.chkStatusButton.UseVisualStyleBackColor = true;
            // 
            // chkTax_cB
            // 
            this.chkTax_cB.AutoSize = true;
            this.chkTax_cB.Location = new System.Drawing.Point(390, 41);
            this.chkTax_cB.Name = "chkTax_cB";
            this.chkTax_cB.Size = new System.Drawing.Size(119, 19);
            this.chkTax_cB.TabIndex = 3;
            this.chkTax_cB.Text = "办税环境检查";
            this.chkTax_cB.UseVisualStyleBackColor = true;
            // 
            // chkOffice_cB
            // 
            this.chkOffice_cB.AutoSize = true;
            this.chkOffice_cB.Location = new System.Drawing.Point(265, 41);
            this.chkOffice_cB.Name = "chkOffice_cB";
            this.chkOffice_cB.Size = new System.Drawing.Size(119, 19);
            this.chkOffice_cB.TabIndex = 2;
            this.chkOffice_cB.Text = "办公环境检查";
            this.chkOffice_cB.UseVisualStyleBackColor = true;
            // 
            // chkSafe_cB
            // 
            this.chkSafe_cB.AutoSize = true;
            this.chkSafe_cB.Location = new System.Drawing.Point(140, 41);
            this.chkSafe_cB.Name = "chkSafe_cB";
            this.chkSafe_cB.Size = new System.Drawing.Size(119, 19);
            this.chkSafe_cB.TabIndex = 1;
            this.chkSafe_cB.Text = "安全环境检查";
            this.chkSafe_cB.UseVisualStyleBackColor = true;
            // 
            // chkInfo_cB
            // 
            this.chkInfo_cB.AutoSize = true;
            this.chkInfo_cB.Location = new System.Drawing.Point(15, 41);
            this.chkInfo_cB.Name = "chkInfo_cB";
            this.chkInfo_cB.Size = new System.Drawing.Size(119, 19);
            this.chkInfo_cB.TabIndex = 0;
            this.chkInfo_cB.Text = "主机概要信息";
            this.chkInfo_cB.UseVisualStyleBackColor = true;
            // 
            // chkStatus_rtb
            // 
            this.chkStatus_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkStatus_rtb.Location = new System.Drawing.Point(0, 0);
            this.chkStatus_rtb.Name = "chkStatus_rtb";
            this.chkStatus_rtb.Size = new System.Drawing.Size(1020, 387);
            this.chkStatus_rtb.TabIndex = 0;
            this.chkStatus_rtb.Text = "";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1303, 553);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1303, 578);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ScreenTimer
            // 
            this.ScreenTimer.Interval = 2000;
            this.ScreenTimer.Tick += new System.EventHandler(this.ScreenTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "气球状文本";
            this.notifyIcon.BalloonTipTitle = "气球状标题";
            this.notifyIcon.ContextMenuStrip = this.cnm_notifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ICanSeeYou  ---  远程控制软件";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // cnm_notifyIcon
            // 
            this.cnm_notifyIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnm_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem3,
            this.关闭连接CToolStripMenuItem,
            this.关于AToolStripMenuItem1,
            this.退出EToolStripMenuItem1});
            this.cnm_notifyIcon.Name = "cnm_notifyIcon";
            this.cnm_notifyIcon.Size = new System.Drawing.Size(165, 108);
            // 
            // 打开OToolStripMenuItem3
            // 
            this.打开OToolStripMenuItem3.Image = global::INCUclient.Properties.Resources.Fire;
            this.打开OToolStripMenuItem3.Name = "打开OToolStripMenuItem3";
            this.打开OToolStripMenuItem3.Size = new System.Drawing.Size(164, 26);
            this.打开OToolStripMenuItem3.Text = "打开(&O)";
            this.打开OToolStripMenuItem3.Click += new System.EventHandler(this.打开OToolStripMenuItem3_Click);
            // 
            // 关闭连接CToolStripMenuItem
            // 
            this.关闭连接CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关闭连接CToolStripMenuItem.Image")));
            this.关闭连接CToolStripMenuItem.Name = "关闭连接CToolStripMenuItem";
            this.关闭连接CToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.关闭连接CToolStripMenuItem.Text = "关闭连接(&C)";
            this.关闭连接CToolStripMenuItem.Click += new System.EventHandler(this.关闭连接CToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem1
            // 
            this.关于AToolStripMenuItem1.Image = global::INCUclient.Properties.Resources.info;
            this.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1";
            this.关于AToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.关于AToolStripMenuItem1.Text = "关于(&A)";
            this.关于AToolStripMenuItem1.Click += new System.EventHandler(this.关于AToolStripMenuItem1_Click);
            // 
            // 退出EToolStripMenuItem1
            // 
            this.退出EToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("退出EToolStripMenuItem1.Image")));
            this.退出EToolStripMenuItem1.Name = "退出EToolStripMenuItem1";
            this.退出EToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.退出EToolStripMenuItem1.Text = "退出(&E)";
            this.退出EToolStripMenuItem1.Click += new System.EventHandler(this.退出EToolStripMenuItem1_Click);
            // 
            // oFD_Script
            // 
            this.oFD_Script.FileName = "openFileDialog1";
            this.oFD_Script.Filter = "BAT文件|*.bat|EXE文件|*.exe|VBS文件|*.vbs";
            // 
            // frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tls_Main);
            this.Controls.Add(this.sts_Main);
            this.Controls.Add(this.mnu_Main);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Tools Manager  ---  远程控制软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_client_FormClosing);
            this.cnm_HostParentView.ResumeLayout(false);
            this.cnm_HostView.ResumeLayout(false);
            this.sts_Main.ResumeLayout(false);
            this.sts_Main.PerformLayout();
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.tls_Main.ResumeLayout(false);
            this.tls_Main.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tab_Speak.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tab_Desktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Screen)).EndInit();
            this.tab_FileView.ResumeLayout(false);
            this.spl_Explorer.Panel1.ResumeLayout(false);
            this.spl_Explorer.Panel2.ResumeLayout(false);
            this.spl_Explorer.ResumeLayout(false);
            this.pnl_bottom_hostexplorer.ResumeLayout(false);
            this.ctm_HostExplorer.ResumeLayout(false);
            this.pnl_top_hostexplorer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnl_bottom_myexplorer.ResumeLayout(false);
            this.ctm_MyExplorer.ResumeLayout(false);
            this.pnl_top_myexplorer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tab_Log.ResumeLayout(false);
            this.tab_Info.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            this.splitContainer5.ResumeLayout(false);
            this.tab_Dos.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.tab_Soft.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            this.splitContainer8.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Script_bat.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.Panel2.PerformLayout();
            this.splitContainer9.ResumeLayout(false);
            this.Script_rar.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            this.splitContainer10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptRARFile1_dGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptRARFile2_dGV)).EndInit();
            this.tab_process.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ctm_process.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ctm_secvice.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ctm_startup.ResumeLayout(false);
            this.tab_Regedit.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel2.ResumeLayout(false);
            this.splitContainer12.ResumeLayout(false);
            this.splitContainer13.Panel1.ResumeLayout(false);
            this.splitContainer13.Panel2.ResumeLayout(false);
            this.splitContainer13.ResumeLayout(false);
            this.splitContainer14.Panel1.ResumeLayout(false);
            this.splitContainer14.Panel2.ResumeLayout(false);
            this.splitContainer14.ResumeLayout(false);
            this.tab_StatusScan.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.cnm_notifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_Main;
        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStrip tls_Main;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trv_HostView;
        private System.Windows.Forms.ToolStripMenuItem 连接CtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有主机AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定主机SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程屏幕DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Display;
        private System.Windows.Forms.ImageList iml_ExplorerImages;
        private System.Windows.Forms.ContextMenuStrip ctm_HostExplorer;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 下载DToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctm_MyExplorer;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 上传UToolStripMenuItem;
        private System.Windows.Forms.Timer ScreenTimer;
        private System.Windows.Forms.ToolStripMenuItem 暂停PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_Speak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RichTextBox rtb_Speak;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TabPage tab_Desktop;
        private System.Windows.Forms.PictureBox pic_Screen;
        private System.Windows.Forms.TabPage tab_FileView;
        private System.Windows.Forms.SplitContainer spl_Explorer;
        private System.Windows.Forms.Panel pnl_bottom_hostexplorer;
        private System.Windows.Forms.ListView ltv_hostexplorer;
        private System.Windows.Forms.Panel pnl_top_hostexplorer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_hostexplorer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_hostexplorer;
        private System.Windows.Forms.Panel pnl_bottom_myexplorer;
        private System.Windows.Forms.ListView ltv_myexplorer;
        private System.Windows.Forms.Panel pnl_top_myexplorer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_myexplorer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_myexplorer;
        private System.Windows.Forms.TabPage tab_Log;
        private System.Windows.Forms.ListView ltv_Log;
        private System.Windows.Forms.ColumnHeader col_Datetime;
        private System.Windows.Forms.ColumnHeader col_IP;
        private System.Windows.Forms.ColumnHeader col_Event;
        private System.Windows.Forms.ContextMenuStrip cnm_HostView;
        private System.Windows.Forms.ToolStripMenuItem 重新连接RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关机SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 屏幕控制PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除MToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cnm_HostParentView;
        private System.Windows.Forms.ToolStripMenuItem 增加主机NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除所有RToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_Connect;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_ScreenOpen;
        private System.Windows.Forms.ToolStripButton tsb_ScreenHoldOn;
        private System.Windows.Forms.ToolStripButton tsb_ScreenStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cnm_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 关闭连接CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem1;
        private System.Windows.Forms.ImageList iml_HostView;
        private System.Windows.Forms.ToolStripButton tsb_ConnectAll;
        private System.Windows.Forms.ToolStripMenuItem 屏幕发送速度SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢SToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_Context;
        private System.Windows.Forms.ToolStripButton tsb_AboutINCU;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_ExistApp;
        private System.Windows.Forms.ToolStripMenuItem 高级HToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_UpdateServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 升级服务端UtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新RtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新RToolStripMenuItem1;
        private System.Windows.Forms.TabPage tab_Info;
        private System.Windows.Forms.TabPage tab_Soft;
        private System.Windows.Forms.TabPage tab_Dos;
        private System.Windows.Forms.RichTextBox DosResult_rtb;
        private System.Windows.Forms.Button DosCommand_bn;
        private System.Windows.Forms.TextBox DosCommand_tB;
        private System.Windows.Forms.TabPage tab_process;
        private System.Windows.Forms.TabPage tab_Regedit;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RichTextBox computerInfo_rtb;
        private System.Windows.Forms.Button computerInfoGet_bt;
        private System.Windows.Forms.Button WMISearchButton;
        private System.Windows.Forms.TextBox WMISearch_tB;
        private System.Windows.Forms.Button WMISearchButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WMISearch_tB2;
        private System.Windows.Forms.TextBox WMISearch_tB1;
        private System.Windows.Forms.ToolStripMenuItem 远程执行toolStripMenuItem1;
        private System.Windows.Forms.TabPage tab_StatusScan;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSafe_cB;
        private System.Windows.Forms.CheckBox chkInfo_cB;
        private System.Windows.Forms.Button chkStatusButton;
        private System.Windows.Forms.CheckBox chkTax_cB;
        private System.Windows.Forms.CheckBox chkOffice_cB;
        private System.Windows.Forms.Button chkStatusOKButton;
        private System.Windows.Forms.RichTextBox chkStatus_rtb;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView process_lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip ctm_process;
        private System.Windows.Forms.ToolStripMenuItem 刷新进程toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 结束任务toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox PSS_rtb;
        private System.Windows.Forms.ListView Service_lv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView Startup_lv;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ContextMenuStrip ctm_secvice;
        private System.Windows.Forms.ToolStripMenuItem 启动toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 停止toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 启动类型toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 自动toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 手动toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 禁止toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ctm_startup;
        private System.Windows.Forms.ToolStripMenuItem 刷新toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 禁用toolStripMenuItem2;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.RichTextBox Script_rtb;
        private System.Windows.Forms.Button ScriptFileOpenButton;
        private System.Windows.Forms.Button ScriptSendButton;
        private System.Windows.Forms.TextBox Script_filepath_tB;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Script_bat;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.RichTextBox ScriptBatEdit_rtb;
        private System.Windows.Forms.Button ScriptBatSendButton;
        private System.Windows.Forms.Button ScriptBatLocalTestButton;
        private System.Windows.Forms.Button ScriptBatClipboardButton;
        private System.Windows.Forms.TabPage Script_rar;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.Button ScriptRARLocalTestButton;
        private System.Windows.Forms.Button ScriptRarSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ScriptRAR3_cB;
        private System.Windows.Forms.CheckBox ScriptRAR2_cB;
        private System.Windows.Forms.CheckBox ScriptRAR1_cB;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView ScriptRARFile1_dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ScriptRARFile2_dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.OpenFileDialog oFD_Script;
        private System.Windows.Forms.TextBox Script_paramerer_tB;
        private System.Windows.Forms.CheckBox Script_IsWaiting_cB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ScriptBatCheckButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Script_bat_paramerer_tB;
        private System.Windows.Forms.Button ScriptBatClearButton;
        private System.Windows.Forms.CheckBox Script_bat_IsWaiting_cB;
        private System.Windows.Forms.TextBox ScriptRAR_pamarerer_tB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private System.Windows.Forms.TreeView Reg_tV;
        private System.Windows.Forms.SplitContainer splitContainer13;
        private System.Windows.Forms.ListView Reg_lV;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.SplitContainer splitContainer14;
        private CCWin.SkinControl.RtfRichTextBox Reg_rTB;
        private System.Windows.Forms.Button RegImportButton;
        private System.Windows.Forms.Button RegDirDelButton;
        private System.Windows.Forms.Button RegDirModiButton;
        private System.Windows.Forms.Button RegDirAddButton;
        private System.Windows.Forms.Button RegKeyDelButton;
        private System.Windows.Forms.Button RegKeyAddButton;
        private System.Windows.Forms.Button RegKeyModiButton;
        private System.Windows.Forms.Button RegKeyOutportButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentIP_tSSL;
    }
}

