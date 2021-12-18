using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public class extracted_keywords : UserControl
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000031C1 File Offset: 0x000013C1
		public extracted_keywords()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000031D0 File Offset: 0x000013D0
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

		// Token: 0x06000041 RID: 65 RVA: 0x00003220 File Offset: 0x00001420
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.RichTextBox1 = new RichTextBox();
			base.SuspendLayout();
			this.RichTextBox1.DetectUrls = false;
			this.RichTextBox1.Dock = DockStyle.Fill;
			this.RichTextBox1.Location = new Point(0, 0);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new Size(372, 165);
			this.RichTextBox1.TabIndex = 1;
			this.RichTextBox1.Text = "";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.RichTextBox1);
			base.Name = "extracted_keywords";
			base.Size = new Size(372, 165);
			base.ResumeLayout(false);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003312 File Offset: 0x00001512
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000331C File Offset: 0x0000151C
		internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400001D RID: 29
		private IContainer components;
	}
}
