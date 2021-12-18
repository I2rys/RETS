using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using B3RAP_Leecher.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class LeechOptions : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000259F File Offset: 0x0000079F
		public LeechOptions()
		{
			base.Load += this.LeechOptions_Load;
			base.FormClosing += this.LeechOptions_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002B48 File Offset: 0x00000D48
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002B52 File Offset: 0x00000D52
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002B5B File Offset: 0x00000D5B
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002B65 File Offset: 0x00000D65
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002B6E File Offset: 0x00000D6E
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002B78 File Offset: 0x00000D78
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002B81 File Offset: 0x00000D81
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002B8B File Offset: 0x00000D8B
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002B94 File Offset: 0x00000D94
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002B9E File Offset: 0x00000D9E
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002BA7 File Offset: 0x00000DA7
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002BB1 File Offset: 0x00000DB1
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000032 RID: 50 RVA: 0x00002BBC File Offset: 0x00000DBC
		private void LeechOptions_Load(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "emailpass", false) == 0;
			if (flag)
			{
				this.RadioButton1.Checked = true;
			}
			else
			{
				bool flag2 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "userpass", false) == 0;
				if (flag2)
				{
					this.RadioButton2.Checked = true;
				}
				else
				{
					bool flag3 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "proxies", false) == 0;
					if (flag3)
					{
						this.RadioButton4.Checked = true;
					}
					else
					{
						bool flag4 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "emailonly", false) == 0;
						if (flag4)
						{
							this.RadioButton3.Checked = true;
						}
						else
						{
							bool flag5 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "custom", false) == 0;
							if (flag5)
							{
								this.RadioButton5.Checked = true;
								this.TextBox1.Text = MySettingsProperty.Settings.customregex;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002CC4 File Offset: 0x00000EC4
		private void LeechOptions_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool @checked = this.RadioButton1.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.leechoptions = "emailpass";
				MySettingsProperty.Settings.Save();
			}
			else
			{
				bool checked2 = this.RadioButton2.Checked;
				if (checked2)
				{
					MySettingsProperty.Settings.leechoptions = "userpass";
					MySettingsProperty.Settings.Save();
				}
				else
				{
					bool checked3 = this.RadioButton4.Checked;
					if (checked3)
					{
						MySettingsProperty.Settings.leechoptions = "proxies";
						MySettingsProperty.Settings.Save();
					}
					else
					{
						bool checked4 = this.RadioButton3.Checked;
						if (checked4)
						{
							MySettingsProperty.Settings.leechoptions = "emailonly";
							MySettingsProperty.Settings.Save();
						}
						else
						{
							bool checked5 = this.RadioButton5.Checked;
							if (checked5)
							{
								bool flag = Operators.CompareString(this.TextBox1.Text, null, false) == 0;
								if (flag)
								{
									Interaction.MsgBox("Please insert a custom regex!", MsgBoxStyle.OkOnly, null);
								}
								else
								{
									MySettingsProperty.Settings.leechoptions = "custom";
									MySettingsProperty.Settings.Save();
									MySettingsProperty.Settings.customregex = this.TextBox1.Text;
									MySettingsProperty.Settings.Save();
								}
							}
						}
					}
				}
			}
		}
	}
}
