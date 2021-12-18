using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Joker_Combo_Leecher__v1._0_.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Joker_Combo_Leecher__v1._0_
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class Regex_Form : Form
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002557 File Offset: 0x00000757
		public Regex_Form()
		{
			base.FormClosing += this.Regex_Form_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002577 File Offset: 0x00000777
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002581 File Offset: 0x00000781
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000258A File Offset: 0x0000078A
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002594 File Offset: 0x00000794
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000259D File Offset: 0x0000079D
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000090B8 File Offset: 0x000072B8
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000090FC File Offset: 0x000072FC
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.TextBox1.Text, "", false) != 0;
			if (flag)
			{
				List.Regex = this.TextBox1.Text;
				MyProject.Forms.Form1.ComboBox2.Text = List.Regex;
				base.Hide();
			}
			else
			{
				Interaction.MsgBox("Please add your custom regex", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000025A7 File Offset: 0x000007A7
		private void Regex_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			MyProject.Forms.Form1.ComboBox2.Text = "Email:Pass";
		}
	}
}
