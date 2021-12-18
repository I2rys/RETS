using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00003F3B File Offset: 0x0000213B
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003F5C File Offset: 0x0000215C
		private void DorkGeneratorButton_Click(object sender, EventArgs e)
		{
			this.DorkGeneratorActive.Visible = true;
			this.ExtractorActive.Visible = false;
			this.InfoActive.Visible = false;
			this.SettingsActive.Visible = false;
			this.Extractor_panel1.Visible = false;
			this.Generate_dorks_panel1.Visible = true;
			this.Info_panel1.Visible = false;
			this.Settings_panel1.Visible = false;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003FD4 File Offset: 0x000021D4
		private void ExtractorButton_Click(object sender, EventArgs e)
		{
			this.DorkGeneratorActive.Visible = false;
			this.ExtractorActive.Visible = true;
			this.InfoActive.Visible = false;
			this.SettingsActive.Visible = false;
			this.Extractor_panel1.Visible = true;
			this.Generate_dorks_panel1.Visible = false;
			this.Info_panel1.Visible = false;
			this.Settings_panel1.Visible = false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000404C File Offset: 0x0000224C
		private void SettingsButton_Click(object sender, EventArgs e)
		{
			this.DorkGeneratorActive.Visible = false;
			this.ExtractorActive.Visible = false;
			this.InfoActive.Visible = false;
			this.SettingsActive.Visible = true;
			this.Extractor_panel1.Visible = false;
			this.Generate_dorks_panel1.Visible = false;
			this.Info_panel1.Visible = false;
			this.Settings_panel1.Visible = true;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000040C4 File Offset: 0x000022C4
		private void InfoButton_Click(object sender, EventArgs e)
		{
			this.DorkGeneratorActive.Visible = false;
			this.ExtractorActive.Visible = false;
			this.InfoActive.Visible = true;
			this.SettingsActive.Visible = false;
			this.Extractor_panel1.Visible = false;
			this.Generate_dorks_panel1.Visible = false;
			this.Info_panel1.Visible = true;
			this.Settings_panel1.Visible = false;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000413A File Offset: 0x0000233A
		private void label2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004144 File Offset: 0x00002344
		private void label1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004150 File Offset: 0x00002350
		private void Form1_Load(object sender, EventArgs e)
		{
			this.DorkGeneratorActive.Visible = true;
			this.ExtractorActive.Visible = false;
			this.InfoActive.Visible = false;
			this.SettingsActive.Visible = false;
			this.label3.Text = "TSP Dork generator v" + Application.ProductVersion;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://dl.dropbox.com/s/mf700aojmh05jqx/version.txt?dl=0");
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text = streamReader.ReadToEnd();
			string productVersion = Application.ProductVersion;
			bool flag = text.Contains(productVersion);
			if (!flag)
			{
				Interaction.MsgBox("There is a new update we, will download it now for you.", MsgBoxStyle.OkOnly, null);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://dl.dropbox.com/s/3y13fhzxmgyb69o/TSP%20Dork%20generator.rar?dl=0", "TSP Dork generator v" + text + ".rar");
				Interaction.MsgBox("TSP Dork generator v" + text + " downloaded to " + Application.StartupPath, MsgBoxStyle.OkOnly, null);
			}
			this.Extractor_panel1.Visible = false;
			this.Generate_dorks_panel1.Visible = true;
			this.Info_panel1.Visible = false;
			this.Settings_panel1.Visible = false;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004278 File Offset: 0x00002478
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000427C File Offset: 0x0000247C
		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			this.drag = true;
			checked
			{
				this.mousex = Cursor.Position.X - base.Left;
				this.mousey = Cursor.Position.Y - base.Top;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000042C8 File Offset: 0x000024C8
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.drag;
			checked
			{
				if (flag)
				{
					base.Top = Cursor.Position.Y - this.mousey;
					base.Left = Cursor.Position.X - this.mousex;
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004318 File Offset: 0x00002518
		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			this.drag = false;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000056AF File Offset: 0x000038AF
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000056B9 File Offset: 0x000038B9
		public virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000056C2 File Offset: 0x000038C2
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000056CC File Offset: 0x000038CC
		public virtual Button DorkGeneratorButton
		{
			[CompilerGenerated]
			get
			{
				return this._DorkGeneratorButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DorkGeneratorButton_Click);
				Button dorkGeneratorButton = this._DorkGeneratorButton;
				if (dorkGeneratorButton != null)
				{
					dorkGeneratorButton.Click -= value2;
				}
				this._DorkGeneratorButton = value;
				dorkGeneratorButton = this._DorkGeneratorButton;
				if (dorkGeneratorButton != null)
				{
					dorkGeneratorButton.Click += value2;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000570F File Offset: 0x0000390F
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005719 File Offset: 0x00003919
		public virtual Panel DorkGeneratorActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005722 File Offset: 0x00003922
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000572C File Offset: 0x0000392C
		public virtual TableLayoutPanel tableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005735 File Offset: 0x00003935
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005740 File Offset: 0x00003940
		public virtual Button SettingsButton
		{
			[CompilerGenerated]
			get
			{
				return this._SettingsButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SettingsButton_Click);
				Button settingsButton = this._SettingsButton;
				if (settingsButton != null)
				{
					settingsButton.Click -= value2;
				}
				this._SettingsButton = value;
				settingsButton = this._SettingsButton;
				if (settingsButton != null)
				{
					settingsButton.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005783 File Offset: 0x00003983
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000578D File Offset: 0x0000398D
		public virtual Panel SettingsActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005796 File Offset: 0x00003996
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000057A0 File Offset: 0x000039A0
		public virtual TableLayoutPanel tableLayoutPanel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000057A9 File Offset: 0x000039A9
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000057B4 File Offset: 0x000039B4
		public virtual Panel panel2
		{
			[CompilerGenerated]
			get
			{
				return this._panel2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.panel2_Paint);
				MouseEventHandler value3 = new MouseEventHandler(this.panel2_MouseDown);
				MouseEventHandler value4 = new MouseEventHandler(this.panel2_MouseMove);
				MouseEventHandler value5 = new MouseEventHandler(this.panel2_MouseUp);
				Panel panel = this._panel2;
				if (panel != null)
				{
					panel.Paint -= value2;
					panel.MouseDown -= value3;
					panel.MouseMove -= value4;
					panel.MouseUp -= value5;
				}
				this._panel2 = value;
				panel = this._panel2;
				if (panel != null)
				{
					panel.Paint += value2;
					panel.MouseDown += value3;
					panel.MouseMove += value4;
					panel.MouseUp += value5;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005854 File Offset: 0x00003A54
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000585E File Offset: 0x00003A5E
		public virtual TableLayoutPanel tableLayoutPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005867 File Offset: 0x00003A67
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00005874 File Offset: 0x00003A74
		public virtual Label label1
		{
			[CompilerGenerated]
			get
			{
				return this._label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.label1_Click);
				Label label = this._label1;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._label1 = value;
				label = this._label1;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000058B7 File Offset: 0x00003AB7
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000058C4 File Offset: 0x00003AC4
		public virtual Label label2
		{
			[CompilerGenerated]
			get
			{
				return this._label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.label2_Click);
				Label label = this._label2;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._label2 = value;
				label = this._label2;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005907 File Offset: 0x00003B07
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00005914 File Offset: 0x00003B14
		public virtual Button ExtractorButton
		{
			[CompilerGenerated]
			get
			{
				return this._ExtractorButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExtractorButton_Click);
				Button extractorButton = this._ExtractorButton;
				if (extractorButton != null)
				{
					extractorButton.Click -= value2;
				}
				this._ExtractorButton = value;
				extractorButton = this._ExtractorButton;
				if (extractorButton != null)
				{
					extractorButton.Click += value2;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005957 File Offset: 0x00003B57
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00005961 File Offset: 0x00003B61
		public virtual Panel ExtractorActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000596A File Offset: 0x00003B6A
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00005974 File Offset: 0x00003B74
		public virtual Button InfoButton
		{
			[CompilerGenerated]
			get
			{
				return this._InfoButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InfoButton_Click);
				Button infoButton = this._InfoButton;
				if (infoButton != null)
				{
					infoButton.Click -= value2;
				}
				this._InfoButton = value;
				infoButton = this._InfoButton;
				if (infoButton != null)
				{
					infoButton.Click += value2;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000059B7 File Offset: 0x00003BB7
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000059C1 File Offset: 0x00003BC1
		public virtual Panel InfoActive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000059CA File Offset: 0x00003BCA
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000059D4 File Offset: 0x00003BD4
		public virtual TableLayoutPanel tableLayoutPanel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000059DD File Offset: 0x00003BDD
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000059E7 File Offset: 0x00003BE7
		public virtual Panel panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000059F0 File Offset: 0x00003BF0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000059FA File Offset: 0x00003BFA
		public virtual TableLayoutPanel tableLayoutPanel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005A03 File Offset: 0x00003C03
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00005A0D File Offset: 0x00003C0D
		public virtual generate_dorks_panel Generate_dorks_panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005A16 File Offset: 0x00003C16
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00005A20 File Offset: 0x00003C20
		public virtual extractor_panel Extractor_panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005A29 File Offset: 0x00003C29
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00005A33 File Offset: 0x00003C33
		public virtual settings_panel Settings_panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00005A46 File Offset: 0x00003C46
		public virtual info_panel Info_panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400002B RID: 43
		private bool drag;

		// Token: 0x0400002C RID: 44
		private int mousex;

		// Token: 0x0400002D RID: 45
		private int mousey;
	}
}
