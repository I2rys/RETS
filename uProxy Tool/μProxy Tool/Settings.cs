using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using μProxy_Tool.My;

namespace μProxy_Tool
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	[OptionText]
	public partial class Settings : Form
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00172054 File Offset: 0x00170454
		public Settings()
		{
			base.Load += this.Settings_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00172BC0 File Offset: 0x00170FC0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00172BD4 File Offset: 0x00170FD4
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00172BE0 File Offset: 0x00170FE0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00172BF4 File Offset: 0x00170FF4
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00172C00 File Offset: 0x00171000
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00172C14 File Offset: 0x00171014
		internal virtual TextBox TextBox2
		{
			get
			{
				return this._TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00172C20 File Offset: 0x00171020
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00172C34 File Offset: 0x00171034
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00172C40 File Offset: 0x00171040
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00172C54 File Offset: 0x00171054
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00172C60 File Offset: 0x00171060
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00172C74 File Offset: 0x00171074
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00172C80 File Offset: 0x00171080
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00172C94 File Offset: 0x00171094
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00172CA0 File Offset: 0x001710A0
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00172CB4 File Offset: 0x001710B4
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00172CC0 File Offset: 0x001710C0
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00172CD4 File Offset: 0x001710D4
		internal virtual NumericUpDown NumericUpDown1
		{
			get
			{
				return this._NumericUpDown1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown1 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00172CE0 File Offset: 0x001710E0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00172CF4 File Offset: 0x001710F4
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00172D00 File Offset: 0x00171100
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00172D14 File Offset: 0x00171114
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00172D60 File Offset: 0x00171160
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00172D74 File Offset: 0x00171174
		internal virtual CheckBox CheckBox2
		{
			get
			{
				return this._CheckBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox2 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00172D80 File Offset: 0x00171180
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00172D94 File Offset: 0x00171194
		internal virtual NumericUpDown NumericUpDown2
		{
			get
			{
				return this._NumericUpDown2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown2 = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00172DA0 File Offset: 0x001711A0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00172DB4 File Offset: 0x001711B4
		internal virtual CheckBox auto_save
		{
			get
			{
				return this._auto_save;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._auto_save = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00172DC0 File Offset: 0x001711C0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00172DD4 File Offset: 0x001711D4
		internal virtual TextBox TextBox3
		{
			get
			{
				return this._TextBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00172DE0 File Offset: 0x001711E0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00172DF4 File Offset: 0x001711F4
		internal virtual CheckBox CheckBox3
		{
			get
			{
				return this._CheckBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_CheckedChanged);
				if (this._CheckBox3 != null)
				{
					this._CheckBox3.CheckedChanged -= value2;
				}
				this._CheckBox3 = value;
				if (this._CheckBox3 != null)
				{
					this._CheckBox3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00172E40 File Offset: 0x00171240
		private void Settings_Load(object sender, EventArgs e)
		{
			this.NumericUpDown1.Value = new decimal(MySettingsProperty.Settings.Threads);
			this.NumericUpDown2.Value = new decimal(MySettingsProperty.Settings.Timeout);
			this.CheckBox1.Checked = MySettingsProperty.Settings.Auto_Check;
			this.CheckBox2.Checked = MySettingsProperty.Settings.Inbuild_Source;
			this.TextBox1.Text = MySettingsProperty.Settings.Proxy_Judge;
			this.auto_save.Checked = MySettingsProperty.Settings.Auto_Save;
			this.TextBox3.Text = MySettingsProperty.Settings.Url_Passed;
			this.CheckBox3.Checked = MySettingsProperty.Settings.Passed;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00172F00 File Offset: 0x00171300
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBox1.Text, "", true) == 0 || !this.TextBox1.Text.Contains("http"))
			{
				MessageBox.Show("Please Put Valid Proxy Judge!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Operators.CompareString(this.TextBox3.Text, "", true) == 0 || !this.TextBox3.Text.Contains("http"))
			{
				MessageBox.Show("Please Put Valid Url to Check!", "μProxy Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			MySettings settings = MySettingsProperty.Settings;
			settings.Threads = Convert.ToInt32(this.NumericUpDown1.Value);
			settings.Timeout = Convert.ToInt32(this.NumericUpDown2.Value);
			settings.Auto_Check = this.CheckBox1.Checked;
			settings.Inbuild_Source = this.CheckBox2.Checked;
			settings.Auto_Save = this.auto_save.Checked;
			settings.Url_Passed = this.TextBox3.Text;
			settings.Proxy_Judge = this.TextBox1.Text;
			settings.Passed = this.CheckBox3.Checked;
			this.Close();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00173038 File Offset: 0x00171438
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			this.TextBox3.Enabled = this.CheckBox3.Checked;
		}

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("NumericUpDown1")]
		private NumericUpDown _NumericUpDown1;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("NumericUpDown2")]
		private NumericUpDown _NumericUpDown2;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("auto_save")]
		private CheckBox _auto_save;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;
	}
}
