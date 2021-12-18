using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public class info_panel : UserControl
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000079E0 File Offset: 0x00005BE0
		public info_panel()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000079F0 File Offset: 0x00005BF0
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007A40 File Offset: 0x00005C40
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(info_panel));
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.Label7 = new Label();
			this.Label8 = new Label();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new Font("Consolas", 9f);
			this.Label1.Location = new Point(27, 38);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(259, 154);
			this.Label1.TabIndex = 21;
			this.Label1.Text = componentResourceManager.GetString("Label1.Text");
			this.Label2.AutoSize = true;
			this.Label2.Font = new Font("Consolas", 9f);
			this.Label2.Location = new Point(391, 38);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(392, 56);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "How to make me happy:\r\nI spend a lot of time in this dork generator\r\nand it would be very nice if you want to make me happy.\r\nHere is how you can make me happy:";
			this.Label3.AutoSize = true;
			this.Label3.Font = new Font("Consolas", 9f);
			this.Label3.Location = new Point(391, 94);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(280, 14);
			this.Label3.TabIndex = 23;
			this.Label3.Text = "BTC: 3EEgHrjgDpNj3cZkTD5fMySjiNCugZXKNj";
			this.Label4.AutoSize = true;
			this.Label4.Font = new Font("Consolas", 9f);
			this.Label4.Location = new Point(391, 108);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(336, 14);
			this.Label4.TabIndex = 24;
			this.Label4.Text = "ETH: 0x1406C9F83e791EB0e8b855078c7922fD2d16dBEF";
			this.Label5.AutoSize = true;
			this.Label5.Font = new Font("Consolas", 9f);
			this.Label5.Location = new Point(391, 122);
			this.Label5.Name = "Label5";
			this.Label5.Size = new Size(280, 14);
			this.Label5.TabIndex = 25;
			this.Label5.Text = "LTC: MJMkK5sDkhqHoePzbgi1Bt6EDbvwEuRodM";
			this.Label7.AutoSize = true;
			this.Label7.Font = new Font("Consolas", 9f);
			this.Label7.Location = new Point(391, 136);
			this.Label7.Name = "Label7";
			this.Label7.Size = new Size(329, 14);
			this.Label7.TabIndex = 27;
			this.Label7.Text = "And last but not least just be friendly to me.";
			this.Label8.AutoSize = true;
			this.Label8.Font = new Font("Consolas", 9f);
			this.Label8.Location = new Point(836, 38);
			this.Label8.Name = "Label8";
			this.Label8.Size = new Size(175, 126);
			this.Label8.TabIndex = 28;
			this.Label8.Text = "Credits:\r\nMade by thiplol.\r\nGodAntiLeech translated:\r\nDeutch\r\nSpanish\r\nJaKK0 translated:\r\nItalian\r\nTested by TSP members\r\nTSP Team";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Name = "info_panel";
			base.Size = new Size(1059, 258);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00007F47 File Offset: 0x00006147
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00007F51 File Offset: 0x00006151
		public virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00007F5A File Offset: 0x0000615A
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00007F64 File Offset: 0x00006164
		public virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00007F6D File Offset: 0x0000616D
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00007F77 File Offset: 0x00006177
		public virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00007F80 File Offset: 0x00006180
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00007F8A File Offset: 0x0000618A
		public virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007F93 File Offset: 0x00006193
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00007F9D File Offset: 0x0000619D
		public virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00007FA6 File Offset: 0x000061A6
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00007FB0 File Offset: 0x000061B0
		public virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007FB9 File Offset: 0x000061B9
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00007FC3 File Offset: 0x000061C3
		public virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x04000060 RID: 96
		private IContainer components;
	}
}
