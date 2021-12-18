namespace μProxy_Tool
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	[global::Microsoft.VisualBasic.CompilerServices.OptionText]
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0017308C File Offset: 0x0017148C
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x001730CC File Offset: 0x001714CC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::μProxy_Tool.Main));
			this.Menu_S = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.LoadProxiesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyProxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExportToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClearListToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveSelectedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.btn_Stop = new global::System.Windows.Forms.Button();
			this.lbl_3 = new global::System.Windows.Forms.Label();
			this.lbl_2 = new global::System.Windows.Forms.Label();
			this.lbl_1 = new global::System.Windows.Forms.Label();
			this.btn_About = new global::System.Windows.Forms.Button();
			this.lb_border3 = new global::System.Windows.Forms.Label();
			this.Sp_1 = new global::System.Windows.Forms.Label();
			this.btn_Export = new global::System.Windows.Forms.Button();
			this.btn_Settings = new global::System.Windows.Forms.Button();
			this.btn_Clear = new global::System.Windows.Forms.Button();
			this.btn_Check = new global::System.Windows.Forms.Button();
			this.SaveAll = new global::System.Windows.Forms.Button();
			this.OpenFile_Btn = new global::System.Windows.Forms.Button();
			this.Scrape_btn = new global::System.Windows.Forms.Button();
			this.lb_border1 = new global::System.Windows.Forms.Label();
			this.tooltip = new global::System.Windows.Forms.ToolTip(this.components);
			this.lb_info = new global::System.Windows.Forms.Label();
			this.guide_icon = new global::System.Windows.Forms.PictureBox();
			this.panel_guide = new global::System.Windows.Forms.Panel();
			this.lb_close = new global::System.Windows.Forms.Label();
			this.lb_detail = new global::System.Windows.Forms.Label();
			this.lb_border = new global::System.Windows.Forms.Label();
			this.Status = new global::System.Windows.Forms.StatusStrip();
			this.status_lbl = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.status_progress = new global::System.Windows.Forms.ToolStripProgressBar();
			this.status_per = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ListView1 = new global::μProxy_Tool.DoubleBufferedListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader6 = new global::System.Windows.Forms.ColumnHeader();
			this.Menu_S.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.guide_icon).BeginInit();
			this.panel_guide.SuspendLayout();
			this.Status.SuspendLayout();
			this.SuspendLayout();
			this.Menu_S.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.LoadProxiesToolStripMenuItem,
				this.CopyProxyToolStripMenuItem,
				this.ExportToolStripMenuItem,
				this.ClearListToolStripMenuItem,
				this.RemoveSelectedToolStripMenuItem,
				this.AboutToolStripMenuItem1
			});
			this.Menu_S.Name = "ContextMenuStrip1";
			this.Menu_S.ShowImageMargin = false;
			global::System.Windows.Forms.Control menu_S = this.Menu_S;
			global::System.Drawing.Size size = new global::System.Drawing.Size(140, 136);
			menu_S.Size = size;
			this.LoadProxiesToolStripMenuItem.Name = "LoadProxiesToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem loadProxiesToolStripMenuItem = this.LoadProxiesToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			loadProxiesToolStripMenuItem.Size = size;
			this.LoadProxiesToolStripMenuItem.Text = "Load Proxies";
			this.CopyProxyToolStripMenuItem.Name = "CopyProxyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyProxyToolStripMenuItem = this.CopyProxyToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			copyProxyToolStripMenuItem.Size = size;
			this.CopyProxyToolStripMenuItem.Text = "Copy Proxy";
			this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exportToolStripMenuItem = this.ExportToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			exportToolStripMenuItem.Size = size;
			this.ExportToolStripMenuItem.Text = "Export";
			this.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem clearListToolStripMenuItem = this.ClearListToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			clearListToolStripMenuItem.Size = size;
			this.ClearListToolStripMenuItem.Text = "Clear List";
			this.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem removeSelectedToolStripMenuItem = this.RemoveSelectedToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			removeSelectedToolStripMenuItem.Size = size;
			this.RemoveSelectedToolStripMenuItem.Text = "Remove Selected";
			this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem aboutToolStripMenuItem = this.AboutToolStripMenuItem1;
			size = new global::System.Drawing.Size(139, 22);
			aboutToolStripMenuItem.Size = size;
			this.AboutToolStripMenuItem1.Text = "About";
			this.btn_Stop.Enabled = false;
			this.btn_Stop.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Stop.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_Stop.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_Stop.Image");
			global::System.Windows.Forms.Control btn_Stop = this.btn_Stop;
			global::System.Drawing.Point location = new global::System.Drawing.Point(234, 4);
			btn_Stop.Location = location;
			this.btn_Stop.Name = "btn_Stop";
			global::System.Windows.Forms.Control btn_Stop2 = this.btn_Stop;
			size = new global::System.Drawing.Size(45, 40);
			btn_Stop2.Size = size;
			this.btn_Stop.TabIndex = 4;
			this.tooltip.SetToolTip(this.btn_Stop, "Stop Scraper/Checker");
			this.btn_Stop.UseVisualStyleBackColor = true;
			this.lbl_3.AutoSize = true;
			this.lbl_3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbl_3.ForeColor = global::System.Drawing.SystemColors.ControlDark;
			global::System.Windows.Forms.Control lbl_ = this.lbl_3;
			location = new global::System.Drawing.Point(354, 45);
			lbl_.Location = location;
			this.lbl_3.Name = "lbl_3";
			global::System.Windows.Forms.Control lbl_2 = this.lbl_3;
			size = new global::System.Drawing.Size(147, 15);
			lbl_2.Size = size;
			this.lbl_3.TabIndex = 17;
			this.lbl_3.Text = "Export     Settings     About";
			this.lbl_2.AutoSize = true;
			this.lbl_2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbl_2.ForeColor = global::System.Drawing.SystemColors.ControlDark;
			global::System.Windows.Forms.Control lbl_3 = this.lbl_2;
			location = new global::System.Drawing.Point(124, 45);
			lbl_3.Location = location;
			this.lbl_2.Name = "lbl_2";
			global::System.Windows.Forms.Control lbl_4 = this.lbl_2;
			size = new global::System.Drawing.Size(203, 15);
			lbl_4.Size = size;
			this.lbl_2.TabIndex = 16;
			this.lbl_2.Text = "Scrape      Check        Stop         Clear";
			this.lbl_1.AutoSize = true;
			this.lbl_1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbl_1.ForeColor = global::System.Drawing.SystemColors.ControlDark;
			global::System.Windows.Forms.Control lbl_5 = this.lbl_1;
			location = new global::System.Drawing.Point(8, 45);
			lbl_5.Location = location;
			this.lbl_1.Name = "lbl_1";
			global::System.Windows.Forms.Control lbl_6 = this.lbl_1;
			size = new global::System.Drawing.Size(89, 15);
			lbl_6.Size = size;
			this.lbl_1.TabIndex = 15;
			this.lbl_1.Text = "Load         Save";
			this.btn_About.BackColor = global::System.Drawing.SystemColors.Window;
			this.btn_About.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_About.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_About.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_About.Image");
			global::System.Windows.Forms.Control btn_About = this.btn_About;
			location = new global::System.Drawing.Point(460, 4);
			btn_About.Location = location;
			this.btn_About.Name = "btn_About";
			global::System.Windows.Forms.Control btn_About2 = this.btn_About;
			size = new global::System.Drawing.Size(45, 40);
			btn_About2.Size = size;
			this.btn_About.TabIndex = 8;
			this.tooltip.SetToolTip(this.btn_About, "About");
			this.btn_About.UseVisualStyleBackColor = false;
			this.lb_border3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			global::System.Windows.Forms.Control lb_border = this.lb_border3;
			location = new global::System.Drawing.Point(339, 4);
			lb_border.Location = location;
			this.lb_border3.Name = "lb_border3";
			global::System.Windows.Forms.Control lb_border2 = this.lb_border3;
			size = new global::System.Drawing.Size(2, 56);
			lb_border2.Size = size;
			this.lb_border3.TabIndex = 13;
			this.Sp_1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			global::System.Windows.Forms.Control sp_ = this.Sp_1;
			location = new global::System.Drawing.Point(113, 4);
			sp_.Location = location;
			this.Sp_1.Name = "Sp_1";
			global::System.Windows.Forms.Control sp_2 = this.Sp_1;
			size = new global::System.Drawing.Size(2, 56);
			sp_2.Size = size;
			this.Sp_1.TabIndex = 9;
			this.btn_Export.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Export.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_Export.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_Export.Image");
			global::System.Windows.Forms.Control btn_Export = this.btn_Export;
			location = new global::System.Drawing.Point(352, 4);
			btn_Export.Location = location;
			this.btn_Export.Name = "btn_Export";
			global::System.Windows.Forms.Control btn_Export2 = this.btn_Export;
			size = new global::System.Drawing.Size(45, 40);
			btn_Export2.Size = size;
			this.btn_Export.TabIndex = 6;
			this.tooltip.SetToolTip(this.btn_Export, "Export Proxies");
			this.btn_Export.UseVisualStyleBackColor = true;
			this.btn_Settings.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Settings.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_Settings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_Settings.Image");
			global::System.Windows.Forms.Control btn_Settings = this.btn_Settings;
			location = new global::System.Drawing.Point(406, 4);
			btn_Settings.Location = location;
			this.btn_Settings.Name = "btn_Settings";
			global::System.Windows.Forms.Control btn_Settings2 = this.btn_Settings;
			size = new global::System.Drawing.Size(45, 40);
			btn_Settings2.Size = size;
			this.btn_Settings.TabIndex = 7;
			this.tooltip.SetToolTip(this.btn_Settings, "μProxy Settings");
			this.btn_Settings.UseVisualStyleBackColor = true;
			this.btn_Clear.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Clear.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_Clear.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_Clear.Image");
			global::System.Windows.Forms.Control btn_Clear = this.btn_Clear;
			location = new global::System.Drawing.Point(289, 4);
			btn_Clear.Location = location;
			this.btn_Clear.Name = "btn_Clear";
			global::System.Windows.Forms.Control btn_Clear2 = this.btn_Clear;
			size = new global::System.Drawing.Size(45, 40);
			btn_Clear2.Size = size;
			this.btn_Clear.TabIndex = 5;
			this.tooltip.SetToolTip(this.btn_Clear, "Clear Proxies");
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Check.Enabled = false;
			this.btn_Check.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Check.ForeColor = global::System.Drawing.SystemColors.Window;
			this.btn_Check.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_Check.Image");
			global::System.Windows.Forms.Control btn_Check = this.btn_Check;
			location = new global::System.Drawing.Point(179, 4);
			btn_Check.Location = location;
			this.btn_Check.Name = "btn_Check";
			global::System.Windows.Forms.Control btn_Check2 = this.btn_Check;
			size = new global::System.Drawing.Size(45, 40);
			btn_Check2.Size = size;
			this.btn_Check.TabIndex = 3;
			this.tooltip.SetToolTip(this.btn_Check, "Check Proxy List");
			this.btn_Check.UseVisualStyleBackColor = true;
			this.SaveAll.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SaveAll.ForeColor = global::System.Drawing.SystemColors.Window;
			this.SaveAll.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SaveAll.Image");
			global::System.Windows.Forms.Control saveAll = this.SaveAll;
			location = new global::System.Drawing.Point(58, 4);
			saveAll.Location = location;
			this.SaveAll.Name = "SaveAll";
			global::System.Windows.Forms.Control saveAll2 = this.SaveAll;
			size = new global::System.Drawing.Size(45, 40);
			saveAll2.Size = size;
			this.SaveAll.TabIndex = 1;
			this.tooltip.SetToolTip(this.SaveAll, "Save All Proxy List");
			this.SaveAll.UseVisualStyleBackColor = true;
			this.OpenFile_Btn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OpenFile_Btn.ForeColor = global::System.Drawing.SystemColors.Window;
			this.OpenFile_Btn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OpenFile_Btn.Image");
			global::System.Windows.Forms.Control openFile_Btn = this.OpenFile_Btn;
			location = new global::System.Drawing.Point(4, 4);
			openFile_Btn.Location = location;
			this.OpenFile_Btn.Name = "OpenFile_Btn";
			global::System.Windows.Forms.Control openFile_Btn2 = this.OpenFile_Btn;
			size = new global::System.Drawing.Size(45, 40);
			openFile_Btn2.Size = size;
			this.OpenFile_Btn.TabIndex = 0;
			this.tooltip.SetToolTip(this.OpenFile_Btn, "Open Proxy List");
			this.OpenFile_Btn.UseVisualStyleBackColor = true;
			this.Scrape_btn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Scrape_btn.ForeColor = global::System.Drawing.SystemColors.Window;
			this.Scrape_btn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Scrape_btn.Image");
			global::System.Windows.Forms.Control scrape_btn = this.Scrape_btn;
			location = new global::System.Drawing.Point(124, 4);
			scrape_btn.Location = location;
			this.Scrape_btn.Name = "Scrape_btn";
			global::System.Windows.Forms.Control scrape_btn2 = this.Scrape_btn;
			size = new global::System.Drawing.Size(45, 40);
			scrape_btn2.Size = size;
			this.Scrape_btn.TabIndex = 2;
			this.tooltip.SetToolTip(this.Scrape_btn, "Scrape Proxies");
			this.Scrape_btn.UseVisualStyleBackColor = true;
			this.lb_border1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			global::System.Windows.Forms.Control lb_border3 = this.lb_border1;
			location = new global::System.Drawing.Point(4, 63);
			lb_border3.Location = location;
			this.lb_border1.Name = "lb_border1";
			global::System.Windows.Forms.Control lb_border4 = this.lb_border1;
			size = new global::System.Drawing.Size(652, 1);
			lb_border4.Size = size;
			this.lb_border1.TabIndex = 19;
			this.lb_info.AutoSize = true;
			this.lb_info.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lb_info.ForeColor = global::System.Drawing.Color.FromArgb(37, 183, 211);
			global::System.Windows.Forms.Control lb_info = this.lb_info;
			location = new global::System.Drawing.Point(27, 3);
			lb_info.Location = location;
			this.lb_info.Name = "lb_info";
			global::System.Windows.Forms.Control lb_info2 = this.lb_info;
			size = new global::System.Drawing.Size(84, 18);
			lb_info2.Size = size;
			this.lb_info.TabIndex = 21;
			this.lb_info.Text = "Quick Guide";
			this.tooltip.SetToolTip(this.lb_info, "Guide on μProxy Tool");
			this.guide_icon.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guide_icon.Image");
			global::System.Windows.Forms.Control guide_icon = this.guide_icon;
			location = new global::System.Drawing.Point(6, 4);
			guide_icon.Location = location;
			this.guide_icon.Name = "guide_icon";
			global::System.Windows.Forms.Control guide_icon2 = this.guide_icon;
			size = new global::System.Drawing.Size(16, 16);
			guide_icon2.Size = size;
			this.guide_icon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.guide_icon.TabIndex = 22;
			this.guide_icon.TabStop = false;
			this.tooltip.SetToolTip(this.guide_icon, "Guide on μProxy Tool");
			this.panel_guide.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.panel_guide.BackColor = global::System.Drawing.Color.Transparent;
			this.panel_guide.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_guide.Controls.Add(this.lb_close);
			this.panel_guide.Controls.Add(this.lb_detail);
			this.panel_guide.Controls.Add(this.guide_icon);
			this.panel_guide.Controls.Add(this.lb_info);
			this.panel_guide.Controls.Add(this.lb_border);
			global::System.Windows.Forms.Control panel_guide = this.panel_guide;
			location = new global::System.Drawing.Point(156, 152);
			panel_guide.Location = location;
			this.panel_guide.Name = "panel_guide";
			global::System.Windows.Forms.Control panel_guide2 = this.panel_guide;
			size = new global::System.Drawing.Size(348, 155);
			panel_guide2.Size = size;
			this.panel_guide.TabIndex = 20;
			this.lb_close.AutoSize = true;
			this.lb_close.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lb_close.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lb_close.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lb_close.ForeColor = global::System.Drawing.SystemColors.GrayText;
			global::System.Windows.Forms.Control lb_close = this.lb_close;
			location = new global::System.Drawing.Point(320, 2);
			lb_close.Location = location;
			this.lb_close.Name = "lb_close";
			global::System.Windows.Forms.Control lb_close2 = this.lb_close;
			size = new global::System.Drawing.Size(22, 15);
			lb_close2.Size = size;
			this.lb_close.TabIndex = 24;
			this.lb_close.Text = " X ";
			this.lb_detail.AutoSize = true;
			this.lb_detail.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lb_detail.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			global::System.Windows.Forms.Control lb_detail = this.lb_detail;
			location = new global::System.Drawing.Point(9, 33);
			lb_detail.Location = location;
			this.lb_detail.Name = "lb_detail";
			global::System.Windows.Forms.Control lb_detail2 = this.lb_detail;
			size = new global::System.Drawing.Size(328, 112);
			lb_detail2.Size = size;
			this.lb_detail.TabIndex = 23;
			this.lb_detail.Text = componentResourceManager.GetString("lb_detail.Text");
			this.lb_border.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			global::System.Windows.Forms.Control lb_border5 = this.lb_border;
			location = new global::System.Drawing.Point(0, 25);
			lb_border5.Location = location;
			this.lb_border.Name = "lb_border";
			global::System.Windows.Forms.Control lb_border6 = this.lb_border;
			size = new global::System.Drawing.Size(345, 1);
			lb_border6.Size = size;
			this.lb_border.TabIndex = 20;
			this.Status.BackColor = global::System.Drawing.Color.Transparent;
			this.Status.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.status_lbl,
				this.status_progress,
				this.status_per
			});
			global::System.Windows.Forms.Control status = this.Status;
			location = new global::System.Drawing.Point(0, 364);
			status.Location = location;
			this.Status.Name = "Status";
			global::System.Windows.Forms.Control status2 = this.Status;
			size = new global::System.Drawing.Size(660, 22);
			status2.Size = size;
			this.Status.TabIndex = 20;
			this.Status.TabStop = true;
			this.Status.Text = "StatusStrip1";
			this.status_lbl.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.status_lbl.Name = "status_lbl";
			global::System.Windows.Forms.ToolStripItem status_lbl = this.status_lbl;
			size = new global::System.Drawing.Size(64, 17);
			status_lbl.Size = size;
			this.status_lbl.Text = "Status: Idle";
			this.status_progress.Name = "status_progress";
			global::System.Windows.Forms.ToolStripControlHost status_progress = this.status_progress;
			size = new global::System.Drawing.Size(100, 16);
			status_progress.Size = size;
			this.status_per.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.status_per.Name = "status_per";
			global::System.Windows.Forms.ToolStripItem status_per = this.status_per;
			size = new global::System.Drawing.Size(23, 17);
			status_per.Size = size;
			this.status_per.Text = "0%";
			this.ListView1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.ListView1.BackColor = global::System.Drawing.SystemColors.Window;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5,
				this.ColumnHeader6
			});
			this.ListView1.ContextMenuStrip = this.Menu_S;
			this.ListView1.Font = new global::System.Drawing.Font("Franklin Gothic Book", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ListView1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.ListView1.FullRowSelect = true;
			this.ListView1.GridLines = true;
			global::System.Windows.Forms.Control listView = this.ListView1;
			location = new global::System.Drawing.Point(5, 68);
			listView.Location = location;
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			listView2.Margin = margin;
			this.ListView1.Name = "ListView1";
			global::System.Windows.Forms.Control listView3 = this.ListView1;
			size = new global::System.Drawing.Size(650, 296);
			listView3.Size = size;
			this.ListView1.TabIndex = 12;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "#";
			this.ColumnHeader1.Width = 45;
			this.ColumnHeader2.Text = "Proxy";
			this.ColumnHeader2.Width = 161;
			this.ColumnHeader3.Text = "Country";
			this.ColumnHeader3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader3.Width = 125;
			this.ColumnHeader4.Text = "Anonymity";
			this.ColumnHeader4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader4.Width = 115;
			this.ColumnHeader5.Text = "Url Passed";
			this.ColumnHeader5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader5.Width = 89;
			this.ColumnHeader6.Text = "Time (ms)";
			this.ColumnHeader6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader6.Width = 82;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 16f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(660, 386);
			this.ClientSize = size;
			this.Controls.Add(this.panel_guide);
			this.Controls.Add(this.lb_border1);
			this.Controls.Add(this.btn_Stop);
			this.Controls.Add(this.lbl_3);
			this.Controls.Add(this.ListView1);
			this.Controls.Add(this.lbl_2);
			this.Controls.Add(this.lbl_1);
			this.Controls.Add(this.OpenFile_Btn);
			this.Controls.Add(this.btn_About);
			this.Controls.Add(this.Scrape_btn);
			this.Controls.Add(this.lb_border3);
			this.Controls.Add(this.SaveAll);
			this.Controls.Add(this.btn_Check);
			this.Controls.Add(this.Sp_1);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Export);
			this.Controls.Add(this.btn_Settings);
			this.Controls.Add(this.Status);
			this.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Margin = margin;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "μProxy Tool";
			this.Menu_S.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.guide_icon).EndInit();
			this.panel_guide.ResumeLayout(false);
			this.panel_guide.PerformLayout();
			this.Status.ResumeLayout(false);
			this.Status.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400003E RID: 62
		private global::System.ComponentModel.IContainer components;
	}
}
