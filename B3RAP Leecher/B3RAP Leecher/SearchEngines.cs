using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using B3RAP_Leecher.My;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class SearchEngines : Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000073AE File Offset: 0x000055AE
		public SearchEngines()
		{
			base.Load += this.SearchEngines_Load;
			base.FormClosing += this.SearchEngines_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000784E File Offset: 0x00005A4E
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00007858 File Offset: 0x00005A58
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00007861 File Offset: 0x00005A61
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000786B File Offset: 0x00005A6B
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00007874 File Offset: 0x00005A74
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000787E File Offset: 0x00005A7E
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00007887 File Offset: 0x00005A87
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00007891 File Offset: 0x00005A91
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000AB RID: 171 RVA: 0x0000789C File Offset: 0x00005A9C
		private void SearchEngines_Load(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.searchengines, "bing", false) == 0;
			if (flag)
			{
				this.RadioButton1.Checked = true;
			}
			else
			{
				bool flag2 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "yahoo", false) == 0;
				if (flag2)
				{
					this.RadioButton2.Checked = true;
				}
				else
				{
					bool flag3 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "yandex", false) == 0;
					if (flag3)
					{
						this.RadioButton3.Checked = true;
					}
					else
					{
						bool flag4 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "google", false) == 0;
						if (flag4)
						{
							this.RadioButton4.Checked = true;
						}
					}
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000795C File Offset: 0x00005B5C
		private void SearchEngines_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool @checked = this.RadioButton1.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.searchengines = "bing";
				MySettingsProperty.Settings.Save();
			}
			else
			{
				bool checked2 = this.RadioButton2.Checked;
				if (checked2)
				{
					MySettingsProperty.Settings.searchengines = "yahoo";
					MySettingsProperty.Settings.Save();
				}
				else
				{
					bool checked3 = this.RadioButton3.Checked;
					if (checked3)
					{
						MySettingsProperty.Settings.searchengines = "yandex";
						MySettingsProperty.Settings.Save();
					}
					else
					{
						bool checked4 = this.RadioButton4.Checked;
						if (checked4)
						{
							MySettingsProperty.Settings.searchengines = "google";
							MySettingsProperty.Settings.Save();
						}
					}
				}
			}
		}
	}
}
