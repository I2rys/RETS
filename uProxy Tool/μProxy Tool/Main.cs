using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using μProxy_Tool.My;

namespace μProxy_Tool
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	[OptionText]
	public partial class Main : Form
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00173050 File Offset: 0x00171450
		public Main()
		{
			this.GetData = new GetData();
			this.proxy_source = new List<string>();
			this.temp_list = new List<string>();
			this.proxies = new HashSet<string>();
			this.InitializeComponent();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0017474C File Offset: 0x00172B4C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00174760 File Offset: 0x00172B60
		internal virtual DoubleBufferedListView ListView1
		{
			get
			{
				return this._ListView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListView1 = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0017476C File Offset: 0x00172B6C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00174780 File Offset: 0x00172B80
		internal virtual ColumnHeader ColumnHeader1
		{
			get
			{
				return this._ColumnHeader1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader1 = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0017478C File Offset: 0x00172B8C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x001747A0 File Offset: 0x00172BA0
		internal virtual ColumnHeader ColumnHeader2
		{
			get
			{
				return this._ColumnHeader2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader2 = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000099 RID: 153 RVA: 0x001747AC File Offset: 0x00172BAC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x001747C0 File Offset: 0x00172BC0
		internal virtual ColumnHeader ColumnHeader3
		{
			get
			{
				return this._ColumnHeader3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader3 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009B RID: 155 RVA: 0x001747CC File Offset: 0x00172BCC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x001747E0 File Offset: 0x00172BE0
		internal virtual ColumnHeader ColumnHeader4
		{
			get
			{
				return this._ColumnHeader4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader4 = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009D RID: 157 RVA: 0x001747EC File Offset: 0x00172BEC
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00174800 File Offset: 0x00172C00
		internal virtual ColumnHeader ColumnHeader5
		{
			get
			{
				return this._ColumnHeader5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader5 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0017480C File Offset: 0x00172C0C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00174820 File Offset: 0x00172C20
		internal virtual ContextMenuStrip Menu_S
		{
			get
			{
				return this._Menu_S;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Menu_S = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0017482C File Offset: 0x00172C2C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00174840 File Offset: 0x00172C40
		internal virtual ToolStripMenuItem LoadProxiesToolStripMenuItem
		{
			get
			{
				return this._LoadProxiesToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LoadProxiesToolStripMenuItem_Click);
				if (this._LoadProxiesToolStripMenuItem != null)
				{
					this._LoadProxiesToolStripMenuItem.Click -= value2;
				}
				this._LoadProxiesToolStripMenuItem = value;
				if (this._LoadProxiesToolStripMenuItem != null)
				{
					this._LoadProxiesToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0017488C File Offset: 0x00172C8C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x001748A0 File Offset: 0x00172CA0
		internal virtual ToolStripMenuItem CopyProxyToolStripMenuItem
		{
			get
			{
				return this._CopyProxyToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyProxyToolStripMenuItem_Click);
				if (this._CopyProxyToolStripMenuItem != null)
				{
					this._CopyProxyToolStripMenuItem.Click -= value2;
				}
				this._CopyProxyToolStripMenuItem = value;
				if (this._CopyProxyToolStripMenuItem != null)
				{
					this._CopyProxyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x001748EC File Offset: 0x00172CEC
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00174900 File Offset: 0x00172D00
		internal virtual ToolStripMenuItem ExportToolStripMenuItem
		{
			get
			{
				return this._ExportToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExportToolStripMenuItem_Click);
				if (this._ExportToolStripMenuItem != null)
				{
					this._ExportToolStripMenuItem.Click -= value2;
				}
				this._ExportToolStripMenuItem = value;
				if (this._ExportToolStripMenuItem != null)
				{
					this._ExportToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0017494C File Offset: 0x00172D4C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00174960 File Offset: 0x00172D60
		internal virtual ToolStripMenuItem ClearListToolStripMenuItem
		{
			get
			{
				return this._ClearListToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ClearListToolStripMenuItem_Click);
				if (this._ClearListToolStripMenuItem != null)
				{
					this._ClearListToolStripMenuItem.Click -= value2;
				}
				this._ClearListToolStripMenuItem = value;
				if (this._ClearListToolStripMenuItem != null)
				{
					this._ClearListToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x001749AC File Offset: 0x00172DAC
		// (set) Token: 0x060000AA RID: 170 RVA: 0x001749C0 File Offset: 0x00172DC0
		internal virtual ToolStripMenuItem AboutToolStripMenuItem1
		{
			get
			{
				return this._AboutToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AboutToolStripMenuItem1_Click);
				if (this._AboutToolStripMenuItem1 != null)
				{
					this._AboutToolStripMenuItem1.Click -= value2;
				}
				this._AboutToolStripMenuItem1 = value;
				if (this._AboutToolStripMenuItem1 != null)
				{
					this._AboutToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00174A0C File Offset: 0x00172E0C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00174A20 File Offset: 0x00172E20
		internal virtual ToolStripMenuItem RemoveSelectedToolStripMenuItem
		{
			get
			{
				return this._RemoveSelectedToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoveSelectedToolStripMenuItem_Click);
				if (this._RemoveSelectedToolStripMenuItem != null)
				{
					this._RemoveSelectedToolStripMenuItem.Click -= value2;
				}
				this._RemoveSelectedToolStripMenuItem = value;
				if (this._RemoveSelectedToolStripMenuItem != null)
				{
					this._RemoveSelectedToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00174A6C File Offset: 0x00172E6C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00174A80 File Offset: 0x00172E80
		internal virtual Button Scrape_btn
		{
			get
			{
				return this._Scrape_btn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Scrape_btn_Click);
				if (this._Scrape_btn != null)
				{
					this._Scrape_btn.Click -= value2;
				}
				this._Scrape_btn = value;
				if (this._Scrape_btn != null)
				{
					this._Scrape_btn.Click += value2;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00174ACC File Offset: 0x00172ECC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00174AE0 File Offset: 0x00172EE0
		internal virtual Button OpenFile_Btn
		{
			get
			{
				return this._OpenFile_Btn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenFile_Btn_Click);
				if (this._OpenFile_Btn != null)
				{
					this._OpenFile_Btn.Click -= value2;
				}
				this._OpenFile_Btn = value;
				if (this._OpenFile_Btn != null)
				{
					this._OpenFile_Btn.Click += value2;
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00174B2C File Offset: 0x00172F2C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00174B40 File Offset: 0x00172F40
		internal virtual Button SaveAll
		{
			get
			{
				return this._SaveAll;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveAll_Click);
				if (this._SaveAll != null)
				{
					this._SaveAll.Click -= value2;
				}
				this._SaveAll = value;
				if (this._SaveAll != null)
				{
					this._SaveAll.Click += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00174B8C File Offset: 0x00172F8C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00174BA0 File Offset: 0x00172FA0
		internal virtual Button btn_Check
		{
			get
			{
				return this._btn_Check;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Check_Click);
				if (this._btn_Check != null)
				{
					this._btn_Check.Click -= value2;
				}
				this._btn_Check = value;
				if (this._btn_Check != null)
				{
					this._btn_Check.Click += value2;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00174BEC File Offset: 0x00172FEC
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00174C00 File Offset: 0x00173000
		internal virtual Button btn_Export
		{
			get
			{
				return this._btn_Export;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Export_Click);
				if (this._btn_Export != null)
				{
					this._btn_Export.Click -= value2;
				}
				this._btn_Export = value;
				if (this._btn_Export != null)
				{
					this._btn_Export.Click += value2;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00174C4C File Offset: 0x0017304C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00174C60 File Offset: 0x00173060
		internal virtual Button btn_Settings
		{
			get
			{
				return this._btn_Settings;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Settings_Click);
				if (this._btn_Settings != null)
				{
					this._btn_Settings.Click -= value2;
				}
				this._btn_Settings = value;
				if (this._btn_Settings != null)
				{
					this._btn_Settings.Click += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00174CAC File Offset: 0x001730AC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00174CC0 File Offset: 0x001730C0
		internal virtual Button btn_Clear
		{
			get
			{
				return this._btn_Clear;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Clear_Click);
				if (this._btn_Clear != null)
				{
					this._btn_Clear.Click -= value2;
				}
				this._btn_Clear = value;
				if (this._btn_Clear != null)
				{
					this._btn_Clear.Click += value2;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00174D0C File Offset: 0x0017310C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00174D20 File Offset: 0x00173120
		internal virtual Label Sp_1
		{
			get
			{
				return this._Sp_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Sp_1 = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00174D2C File Offset: 0x0017312C
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00174D40 File Offset: 0x00173140
		internal virtual Label lb_border3
		{
			get
			{
				return this._lb_border3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lb_border3 = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00174D4C File Offset: 0x0017314C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00174D60 File Offset: 0x00173160
		internal virtual Label lbl_1
		{
			get
			{
				return this._lbl_1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_1 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00174D6C File Offset: 0x0017316C
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00174D80 File Offset: 0x00173180
		internal virtual Label lbl_3
		{
			get
			{
				return this._lbl_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_3 = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00174D8C File Offset: 0x0017318C
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00174DA0 File Offset: 0x001731A0
		internal virtual Label lbl_2
		{
			get
			{
				return this._lbl_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_2 = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00174DAC File Offset: 0x001731AC
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00174DC0 File Offset: 0x001731C0
		internal virtual Button btn_Stop
		{
			get
			{
				return this._btn_Stop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_Stop_Click);
				if (this._btn_Stop != null)
				{
					this._btn_Stop.Click -= value2;
				}
				this._btn_Stop = value;
				if (this._btn_Stop != null)
				{
					this._btn_Stop.Click += value2;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00174E0C File Offset: 0x0017320C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00174E20 File Offset: 0x00173220
		internal virtual Label lb_border1
		{
			get
			{
				return this._lb_border1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lb_border1 = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00174E2C File Offset: 0x0017322C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00174E40 File Offset: 0x00173240
		internal virtual ToolTip tooltip
		{
			get
			{
				return this._tooltip;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tooltip = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00174E4C File Offset: 0x0017324C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00174E60 File Offset: 0x00173260
		internal virtual Button btn_About
		{
			get
			{
				return this._btn_About;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_About_Click);
				if (this._btn_About != null)
				{
					this._btn_About.Click -= value2;
				}
				this._btn_About = value;
				if (this._btn_About != null)
				{
					this._btn_About.Click += value2;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00174EAC File Offset: 0x001732AC
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00174EC0 File Offset: 0x001732C0
		internal virtual Panel panel_guide
		{
			get
			{
				return this._panel_guide;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._panel_guide = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00174ECC File Offset: 0x001732CC
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00174EE0 File Offset: 0x001732E0
		internal virtual PictureBox guide_icon
		{
			get
			{
				return this._guide_icon;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._guide_icon = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00174EEC File Offset: 0x001732EC
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00174F00 File Offset: 0x00173300
		internal virtual Label lb_info
		{
			get
			{
				return this._lb_info;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lb_info = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00174F0C File Offset: 0x0017330C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00174F20 File Offset: 0x00173320
		internal virtual Label lb_border
		{
			get
			{
				return this._lb_border;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lb_border = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00174F2C File Offset: 0x0017332C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00174F40 File Offset: 0x00173340
		internal virtual Label lb_detail
		{
			get
			{
				return this._lb_detail;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lb_detail = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00174F4C File Offset: 0x0017334C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00174F60 File Offset: 0x00173360
		internal virtual Label lb_close
		{
			get
			{
				return this._lb_close;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lb_close_MouseLeave);
				EventHandler value3 = new EventHandler(this.lb_close_MouseHover);
				EventHandler value4 = new EventHandler(this.lb_close_Click);
				if (this._lb_close != null)
				{
					this._lb_close.MouseLeave -= value2;
					this._lb_close.MouseHover -= value3;
					this._lb_close.Click -= value4;
				}
				this._lb_close = value;
				if (this._lb_close != null)
				{
					this._lb_close.MouseLeave += value2;
					this._lb_close.MouseHover += value3;
					this._lb_close.Click += value4;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00174FF8 File Offset: 0x001733F8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0017500C File Offset: 0x0017340C
		internal virtual StatusStrip Status
		{
			get
			{
				return this._Status;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Status = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00175018 File Offset: 0x00173418
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0017502C File Offset: 0x0017342C
		internal virtual ToolStripStatusLabel status_lbl
		{
			get
			{
				return this._status_lbl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._status_lbl = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00175038 File Offset: 0x00173438
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0017504C File Offset: 0x0017344C
		internal virtual ToolStripProgressBar status_progress
		{
			get
			{
				return this._status_progress;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._status_progress = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00175058 File Offset: 0x00173458
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0017506C File Offset: 0x0017346C
		internal virtual ToolStripStatusLabel status_per
		{
			get
			{
				return this._status_per;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._status_per = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00175078 File Offset: 0x00173478
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0017508C File Offset: 0x0017348C
		internal virtual ColumnHeader ColumnHeader6
		{
			get
			{
				return this._ColumnHeader6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader6 = value;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00175098 File Offset: 0x00173498
		public void Startchecker()
		{
			this.el = 0;
			this.an = 0;
			this.tr = 0;
			this.@checked = 0;
			this.cnt = this.proxies.Count;
			this.judge = MySettingsProperty.Settings.Proxy_Judge;
			this.urlpass = MySettingsProperty.Settings.Passed;
			this.url_passed = MySettingsProperty.Settings.Url_Passed;
			ThreadPool.SetMinThreads(MySettingsProperty.Settings.Threads, MySettingsProperty.Settings.Threads);
			ThreadPool.SetMaxThreads(MySettingsProperty.Settings.Threads, MySettingsProperty.Settings.Threads);
			ServicePointManager.DefaultConnectionLimit = checked(MySettingsProperty.Settings.Threads * 2);
			ServicePointManager.Expect100Continue = false;
			try
			{
				foreach (string state in this.proxies)
				{
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						this.proxy_checker(RuntimeHelpers.GetObjectValue(a0));
					}, state);
				}
			}
			finally
			{
				HashSet<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x001751A0 File Offset: 0x001735A0
		private string proxy_checker(object proxy)
		{
			if (!this.isrunning)
			{
				Interlocked.Decrement(ref this.cnt);
				return null;
			}
			checked
			{
				try
				{
					Checker checker = new Checker();
					checker.timeout = MySettingsProperty.Settings.Timeout * 1000;
					checker.proxy = proxy.ToString();
					checker.judge = this.judge;
					bool flag = false;
					string[] array = new string[0];
					try
					{
						array = checker.Check();
						flag = true;
					}
					catch (WebException ex)
					{
					}
					catch (Exception ex2)
					{
					}
					if (flag)
					{
						string country = checker.API();
						string passed;
						if (this.urlpass)
						{
							passed = Conversions.ToString(checker.Passed(this.url_passed));
						}
						else
						{
							passed = "-";
						}
						if (array[0].Contains("HTTP_X_FORWARDED_FOR"))
						{
							Interlocked.Increment(ref this.tr);
							this.Addlistview(proxy.ToString(), "Transparent", country, passed, Conversions.ToInteger(array[1]));
						}
						else if (!array[0].Contains("HTTP_CLIENT_IP") && !array[0].Contains("HTTP_X_FORWARDED") && !array[0].Contains("HTTP_X_CLUSTER_CLIENT_IP") && !array[0].Contains("HTTP_FORWARDED") && !array[0].Contains("HTTP_FORWARDED_FOR") && array[0].Contains("HTTP_VIA"))
						{
							Interlocked.Increment(ref this.an);
							this.Addlistview(proxy.ToString(), "Anonymous", country, passed, Conversions.ToInteger(array[1]));
						}
						else if (array[0].Contains("HTTP_") || (array[0].Contains("HTTP_UPGRADE_INSECURE_REQUESTS") && !array[0].Contains("HTTP_VIA")))
						{
							Interlocked.Increment(ref this.el);
							this.Addlistview(proxy.ToString(), "Elite", country, passed, Conversions.ToInteger(array[1]));
						}
					}
					checker.Dispose();
				}
				catch (Exception ex3)
				{
				}
				Interlocked.Increment(ref this.@checked);
				int num = this.el + this.an + this.tr;
				this.UpdateStatus(string.Format("Status: Checking [{0}/{1}] | Alive: {2} | Elite: {3} | Anon: {4} | Transparent: {5} |", new object[]
				{
					this.@checked,
					this.proxies.Count,
					num,
					this.el,
					this.an,
					this.tr
				}), false);
				Interlocked.Decrement(ref this.cnt);
				if (this.cnt == 0)
				{
					if (!this.isrunning)
					{
						this.UpdateStatus(string.Format("Status: Checker Stopped | [{0}/{1}] | Alive: {2} | Elite: {3} | Anon: {4} | Transparent: {5} |", new object[]
						{
							this.proxies.Count,
							this.proxies.Count,
							num,
							this.el,
							this.an,
							this.tr
						}), false);
						this.Checker_Stopped();
					}
					else
					{
						this.isrunning = false;
						this.UpdateStatus(string.Format("Status: Proxies Checked [{0}/{1}] | Alive: {2} | Elite: {3} | Anon: {4} | Transparent: {5} |", new object[]
						{
							this.@checked,
							this.proxies.Count,
							num,
							this.el,
							this.an,
							this.tr
						}), false);
						this.Checker_Done();
					}
				}
				return null;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x001755A8 File Offset: 0x001739A8
		public void Auto_save()
		{
			this.Save("Elite");
			this.Save("Anonymous");
			this.Save("Transparent");
			this.Save("All_Checked");
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x001755DC File Offset: 0x001739DC
		private void Checker_Stopped()
		{
			this.Invoke(new Action(delegate()
			{
				this.status_progress.Value = 100;
				this.status_per.Text = "100%";
				if (MySettingsProperty.Settings.Auto_Save)
				{
					this.Auto_save();
				}
				MessageBox.Show("Proxy Checking Stopped!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.enable_btn();
			}));
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x001755F4 File Offset: 0x001739F4
		private void Checker_Done()
		{
			this.Invoke(new Action(delegate()
			{
				if (MySettingsProperty.Settings.Auto_Save)
				{
					this.Auto_save();
				}
				MessageBox.Show("Proxy Checking Completed!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.enable_btn();
			}));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0017560C File Offset: 0x00173A0C
		private void UpdateStatus(string status, bool isscraper)
		{
			try
			{
				this.Invoke(new Action(delegate()
				{
					this.status_lbl.Text = status;
					if (isscraper)
					{
						this.status_progress.Value = checked((int)Math.Round(Conversion.Val(unchecked((double)this.@checked / (double)this.proxy_source.Count * 100.0))));
						this.status_per.Text = Conversions.ToString(Convert.ToInt32((double)this.@checked / (double)this.proxy_source.Count * 100.0)) + "%";
					}
					else
					{
						this.status_progress.Value = checked((int)Math.Round(Conversion.Val(unchecked((double)this.@checked / (double)this.proxies.Count * 100.0))));
						this.status_per.Text = Conversions.ToString(Convert.ToInt32((double)this.@checked / (double)this.proxies.Count * 100.0)) + " %";
					}
				}));
			}
			catch (ObjectDisposedException ex)
			{
			}
			catch (NullReferenceException ex2)
			{
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0017569C File Offset: 0x00173A9C
		private void Addlistview(string proxy, string status, string country, string passed, int timeout)
		{
			try
			{
				this.ListView1.Invoke(new Action(delegate()
				{
					ListViewItem listViewItem = this.ListView1.Items.Add(Conversions.ToString(checked(this.ListView1.Items.Count + 1)));
					listViewItem.UseItemStyleForSubItems = false;
					listViewItem.SubItems.Add(proxy);
					listViewItem.SubItems.Add(country).ForeColor = ColorTranslator.FromHtml("#266cd4");
					this.GetData.SetAnonColor(status);
					listViewItem.SubItems.Add(status).BackColor = this.GetData.Color;
					listViewItem.SubItems.Add(passed.ToString()).ForeColor = ((Operators.CompareString(passed, "True", true) == 0) ? Color.Green : Color.Red);
					this.GetData.SetTColor(timeout);
					listViewItem.SubItems.Add(Conversions.ToString(timeout)).ForeColor = this.GetData.Color;
					listViewItem.SubItems[3].ForeColor = Color.White;
				}));
			}
			catch (ObjectDisposedException ex)
			{
			}
			catch (NullReferenceException ex2)
			{
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00175748 File Offset: 0x00173B48
		public void List_load()
		{
			this.proxy_source = this.Loadlist();
			if (this.proxy_source.Count != 0)
			{
				this.startscraper();
			}
			else
			{
				this.Invoke(new MethodInvoker(this.enable_btn));
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00175780 File Offset: 0x00173B80
		public List<string> Loadlist()
		{
			List<string> list = new List<string>();
			string pattern = "<li><a target=\"_blank\" href=\"/(.*?)\"";
			try
			{
				string input = new WebClient().DownloadString("http://checkerproxy.net/");
				if (MySettingsProperty.Settings.Inbuild_Source)
				{
					try
					{
						foreach (object obj in new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline).Matches(input))
						{
							Match match = (Match)obj;
							list.Add("http://checkerproxy.net/" + match.Groups[1].Value);
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			checked
			{
				try
				{
					string path = Application.StartupPath + "\\Data\\Source.txt";
					foreach (string text in File.ReadAllLines(path))
					{
						text = text.Replace(" ", "");
						if (text.Contains("{") && text.Contains("}"))
						{
							Match match2 = Regex.Match(text, "{(.*?)-(.*?)}");
							Match match3 = Regex.Match(text, "{(.*?)-(.*?)-(.*?)}");
							int num = 1;
							if (Operators.CompareString(match3.Groups[3].Value, "", true) != 0)
							{
								num = Conversions.ToInteger(match3.Groups[3].Value);
								match2 = match3;
							}
							int num2 = Conversions.ToInteger(match2.Groups[1].Value);
							int num3 = Conversions.ToInteger(match2.Groups[2].Value);
							int num4 = num;
							int num5 = num2;
							while ((num4 >> 31 ^ num5) <= (num4 >> 31 ^ num3))
							{
								if (match2.Groups[1].Value.Contains("0"))
								{
									if (num5 <= 9)
									{
										list.Add(text.Split(new char[]
										{
											'{'
										})[0] + "0" + Conversions.ToString(num5) + text.Split(new char[]
										{
											'}'
										})[1]);
									}
									else
									{
										list.Add(text.Split(new char[]
										{
											'{'
										})[0] + Conversions.ToString(num5) + text.Split(new char[]
										{
											'}'
										})[1]);
									}
								}
								num5 += num4;
							}
						}
						else
						{
							list.Add(text);
						}
					}
				}
				catch (Exception ex2)
				{
				}
				return list;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00175A70 File Offset: 0x00173E70
		public void startscraper()
		{
			this.@checked = 0;
			this.cnt = this.proxy_source.Count;
			this.isrunning = true;
			this.auto_start = MySettingsProperty.Settings.Auto_Check;
			ThreadPool.SetMinThreads(MySettingsProperty.Settings.Threads, MySettingsProperty.Settings.Threads);
			ThreadPool.SetMaxThreads(MySettingsProperty.Settings.Threads, MySettingsProperty.Settings.Threads);
			ServicePointManager.DefaultConnectionLimit = MySettingsProperty.Settings.Threads;
			ServicePointManager.Expect100Continue = false;
			try
			{
				foreach (string state in this.proxy_source)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.scraper), state);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00175B48 File Offset: 0x00173F48
		public void scraper(object psource)
		{
			try
			{
				if (this.@checked >= this.proxy_source.Count)
				{
					return;
				}
				Scraper scraper = new Scraper();
				List<string> list = scraper.Proxy_Scraper(psource.ToString());
				try
				{
					foreach (string text in list)
					{
						if (Operators.CompareString(text, "", true) != 0)
						{
							this.proxies.Add(text);
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				scraper.Dispose();
			}
			catch (Exception ex)
			{
			}
			Random random = new Random();
			Thread.Sleep(random.Next(100, 1000));
			Interlocked.Increment(ref this.@checked);
			this.UpdateStatus(string.Format("Status: Scraping | Source [ {0}/{1} ] | Proxies: {2}", this.@checked, this.proxy_source.Count, this.proxies.Count), true);
			Interlocked.Decrement(ref this.cnt);
			if (this.cnt == 0)
			{
				this.isrunning = false;
				this.UpdateStatus(string.Format("Status: Proxies Scraped | Source [ {0}/{1} ] | Proxies: {2}", this.@checked, this.proxy_source.Count, this.proxies.Count), true);
				this.Scraper_Done();
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00175CB8 File Offset: 0x001740B8
		public void Scraper_Done()
		{
			Thread.Sleep(1000);
			this.Invoke(new Action(delegate()
			{
				this.enable_btn();
				if (MySettingsProperty.Settings.Auto_Save)
				{
					this.Save();
				}
				if (this.auto_start)
				{
					this.btn_Check.PerformClick();
				}
				else
				{
					MessageBox.Show("Proxy Scraping Completed!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00175CD8 File Offset: 0x001740D8
		public void enable_btn()
		{
			this.OpenFile_Btn.Enabled = true;
			this.Scrape_btn.Enabled = true;
			this.btn_Check.Enabled = true;
			this.btn_Clear.Enabled = true;
			this.btn_Stop.Enabled = false;
			this.ClearListToolStripMenuItem.Enabled = true;
			this.RemoveSelectedToolStripMenuItem.Enabled = true;
			this.LoadProxiesToolStripMenuItem.Enabled = true;
			this.OpenFile_Btn.Enabled = true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00175D54 File Offset: 0x00174154
		public void disable_btn()
		{
			this.OpenFile_Btn.Enabled = false;
			this.Scrape_btn.Enabled = false;
			this.btn_Check.Enabled = false;
			this.btn_Clear.Enabled = false;
			this.btn_Stop.Enabled = true;
			this.ClearListToolStripMenuItem.Enabled = false;
			this.RemoveSelectedToolStripMenuItem.Enabled = false;
			this.LoadProxiesToolStripMenuItem.Enabled = false;
			this.OpenFile_Btn.Enabled = false;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00175DD0 File Offset: 0x001741D0
		private void LoadProxiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.openlist();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00175DD8 File Offset: 0x001741D8
		private int ImportList()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Text files (*.txt) | *.txt"
			})
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.Default);
					List<string> list = File.ReadAllLines(openFileDialog.FileName).ToList<string>();
					try
					{
						foreach (string item in list)
						{
							this.proxies.Add(item);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			return this.proxies.Count;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00175E94 File Offset: 0x00174294
		public object Save(string choice)
		{
			this.Invoke(new Action(delegate()
			{
				try
				{
					if (!Directory.Exists(Application.StartupPath + "\\Data"))
					{
						Directory.CreateDirectory(Application.StartupPath + "\\Data");
					}
					if (!Directory.Exists(Application.StartupPath + "\\Data\\Proxies"))
					{
						Directory.CreateDirectory(Application.StartupPath + "\\Data\\Proxies");
					}
					StreamWriter streamWriter = MyProject.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\\Data\\Proxies\\" + choice + ".txt", false);
					try
					{
						foreach (object obj in this.ListView1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							if (Operators.CompareString(choice, "All_Checked", true) == 0)
							{
								streamWriter.WriteLine(listViewItem.SubItems[1].Text);
							}
							else if (Operators.CompareString(listViewItem.SubItems[3].Text, choice, true) == 0)
							{
								streamWriter.WriteLine(listViewItem.SubItems[1].Text);
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
				}
				finally
				{
					StreamWriter streamWriter;
					streamWriter.Close();
				}
			}));
			object result;
			return result;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00175ECC File Offset: 0x001742CC
		public object Save()
		{
			this.Invoke(new Action(delegate()
			{
				try
				{
					StreamWriter streamWriter = MyProject.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\\Data\\Proxies\\Scraped_Proxies.txt", false);
					try
					{
						foreach (string value in this.proxies)
						{
							streamWriter.WriteLine(value);
						}
					}
					finally
					{
						HashSet<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					streamWriter.Close();
				}
				catch (Exception ex)
				{
				}
			}));
			object result;
			return result;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00175EF0 File Offset: 0x001742F0
		private int SaveScraped()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Text Files |*.txt| all files|*.*",
				FileName = Conversions.ToString(this.proxies.Count) + " - Scraped Proxies"
			};
			checked
			{
				int num;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, true))
					{
						try
						{
							foreach (string value in this.proxies)
							{
								streamWriter.WriteLine(value);
								num++;
							}
						}
						finally
						{
							HashSet<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				return num;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00175FB0 File Offset: 0x001743B0
		private int SaveProxies(HashSet<string> s)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Text Files |*.txt| all files|*.*",
				FileName = "Proxies"
			};
			checked
			{
				int num;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, true))
					{
						try
						{
							foreach (string text in s)
							{
								streamWriter.WriteLine(text.ToString());
								num++;
							}
						}
						finally
						{
							HashSet<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				return num;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0017605C File Offset: 0x0017445C
		public void openlist()
		{
			int num = this.ImportList();
			if (num != 0)
			{
				MessageBox.Show(Conversions.ToString(num) + " - Proxies Imported", "μProxy Tool");
				this.btn_Check.Enabled = true;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0017609C File Offset: 0x0017449C
		private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Export_();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x001760A4 File Offset: 0x001744A4
		public void Export_()
		{
			MyProject.Forms.Export.lv = this.ListView1;
			MyProject.Forms.Export.ShowInTaskbar = false;
			MyProject.Forms.Export.ShowDialog();
			if (MyProject.Forms.Export.proxies_list.Count != 0)
			{
				MessageBox.Show(this.SaveProxies(MyProject.Forms.Export.proxies_list).ToString() + " - Proxies Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00176134 File Offset: 0x00174534
		public void clearlist()
		{
			if (this.proxies.Count == 0 && this.ListView1.Items.Count == 0)
			{
				MessageBox.Show("No Proxies To Clear", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			DialogResult dialogResult = MessageBox.Show("Clear List , Are you sure?", "μProxy Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				this.status_lbl.Text = "Status: Idle";
				this.status_per.Text = "0%";
				this.status_progress.Value = 0;
				this.btn_Check.Enabled = false;
				this.ListView1.Items.Clear();
				this.proxies.Clear();
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x001761E0 File Offset: 0x001745E0
		private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.About_();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x001761E8 File Offset: 0x001745E8
		private void RemoveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.ListView1.Items.Remove(this.ListView1.FocusedItem);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00176230 File Offset: 0x00174630
		private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.clearlist();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00176238 File Offset: 0x00174638
		private void CopyProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.ListView1.FocusedItem.SubItems[1].Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00176288 File Offset: 0x00174688
		private void SaveAll_Click(object sender, EventArgs e)
		{
			if (this.proxies.Count == 0)
			{
				MessageBox.Show("No Proxies Scraped!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			int num = this.SaveScraped();
			if (num != 0)
			{
				MessageBox.Show(Conversions.ToString(num) + " - Proxies Saved!", "Proxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x001762E0 File Offset: 0x001746E0
		private void OpenFile_Btn_Click(object sender, EventArgs e)
		{
			this.panel_guide.Hide();
			this.openlist();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x001762F4 File Offset: 0x001746F4
		private void btn_Check_Click(object sender, EventArgs e)
		{
			if (this.proxies.Count == 0)
			{
				MessageBox.Show("Please Load Proxies or Scrape Proxies!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			this.isrunning = true;
			this.disable_btn();
			this.Startchecker();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0017632C File Offset: 0x0017472C
		private void Scrape_btn_Click(object sender, EventArgs e)
		{
			this.disable_btn();
			this.panel_guide.Hide();
			Thread thread = new Thread(new ThreadStart(this.List_load))
			{
				IsBackground = true,
				Name = "LoadList"
			};
			thread.Start();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00176378 File Offset: 0x00174778
		private void btn_Stop_Click(object sender, EventArgs e)
		{
			this.isrunning = false;
			this.btn_Stop.Enabled = false;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00176390 File Offset: 0x00174790
		public void About_()
		{
			MyProject.Forms.About.ShowDialog();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x001763A4 File Offset: 0x001747A4
		private void btn_Clear_Click(object sender, EventArgs e)
		{
			this.clearlist();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x001763AC File Offset: 0x001747AC
		private void btn_Settings_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Settings.ShowInTaskbar = false;
			MyProject.Forms.Settings.ShowDialog();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x001763D0 File Offset: 0x001747D0
		private void btn_Export_Click(object sender, EventArgs e)
		{
			this.Export_();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x001763D8 File Offset: 0x001747D8
		private void btn_About_Click(object sender, EventArgs e)
		{
			this.About_();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x001763E0 File Offset: 0x001747E0
		private void lb_close_Click(object sender, EventArgs e)
		{
			this.panel_guide.Hide();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x001763F0 File Offset: 0x001747F0
		private void lb_close_MouseHover(object sender, EventArgs e)
		{
			this.lb_close.BackColor = ColorTranslator.FromHtml("#E81123");
			this.lb_close.ForeColor = Color.White;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00176424 File Offset: 0x00174824
		private void lb_close_MouseLeave(object sender, EventArgs e)
		{
			this.lb_close.BackColor = Color.White;
			this.lb_close.ForeColor = Color.DimGray;
		}

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("ListView1")]
		private DoubleBufferedListView _ListView1;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader _ColumnHeader3;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader _ColumnHeader4;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader _ColumnHeader5;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("Menu_S")]
		private ContextMenuStrip _Menu_S;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("LoadProxiesToolStripMenuItem")]
		private ToolStripMenuItem _LoadProxiesToolStripMenuItem;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("CopyProxyToolStripMenuItem")]
		private ToolStripMenuItem _CopyProxyToolStripMenuItem;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("ExportToolStripMenuItem")]
		private ToolStripMenuItem _ExportToolStripMenuItem;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("ClearListToolStripMenuItem")]
		private ToolStripMenuItem _ClearListToolStripMenuItem;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("AboutToolStripMenuItem1")]
		private ToolStripMenuItem _AboutToolStripMenuItem1;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("RemoveSelectedToolStripMenuItem")]
		private ToolStripMenuItem _RemoveSelectedToolStripMenuItem;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("Scrape_btn")]
		private Button _Scrape_btn;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("OpenFile_Btn")]
		private Button _OpenFile_Btn;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("SaveAll")]
		private Button _SaveAll;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("btn_Check")]
		private Button _btn_Check;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("btn_Export")]
		private Button _btn_Export;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("btn_Settings")]
		private Button _btn_Settings;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("btn_Clear")]
		private Button _btn_Clear;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("Sp_1")]
		private Label _Sp_1;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("lb_border3")]
		private Label _lb_border3;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("lbl_1")]
		private Label _lbl_1;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("lbl_3")]
		private Label _lbl_3;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("lbl_2")]
		private Label _lbl_2;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("btn_Stop")]
		private Button _btn_Stop;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("lb_border1")]
		private Label _lb_border1;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("tooltip")]
		private ToolTip _tooltip;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("btn_About")]
		private Button _btn_About;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("panel_guide")]
		private Panel _panel_guide;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("guide_icon")]
		private PictureBox _guide_icon;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("lb_info")]
		private Label _lb_info;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("lb_border")]
		private Label _lb_border;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("lb_detail")]
		private Label _lb_detail;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("lb_close")]
		private Label _lb_close;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("Status")]
		private StatusStrip _Status;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("status_lbl")]
		private ToolStripStatusLabel _status_lbl;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("status_progress")]
		private ToolStripProgressBar _status_progress;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("status_per")]
		private ToolStripStatusLabel _status_per;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("ColumnHeader6")]
		private ColumnHeader _ColumnHeader6;

		// Token: 0x04000067 RID: 103
		private GetData GetData;

		// Token: 0x04000068 RID: 104
		private List<string> proxy_source;

		// Token: 0x04000069 RID: 105
		private List<string> temp_list;

		// Token: 0x0400006A RID: 106
		private bool auto_start;

		// Token: 0x0400006B RID: 107
		private bool finished;

		// Token: 0x0400006C RID: 108
		private bool isrunning;

		// Token: 0x0400006D RID: 109
		private bool urlpass;

		// Token: 0x0400006E RID: 110
		private HashSet<string> proxies;

		// Token: 0x0400006F RID: 111
		private int @checked;

		// Token: 0x04000070 RID: 112
		private int cnt;

		// Token: 0x04000071 RID: 113
		private int el;

		// Token: 0x04000072 RID: 114
		private int an;

		// Token: 0x04000073 RID: 115
		private int tr;

		// Token: 0x04000074 RID: 116
		private string judge;

		// Token: 0x04000075 RID: 117
		private string url_passed;
	}
}
