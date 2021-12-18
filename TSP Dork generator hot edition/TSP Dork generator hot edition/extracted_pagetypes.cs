using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public class extracted_pagetypes : UserControl
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003325 File Offset: 0x00001525
		public extracted_pagetypes()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003334 File Offset: 0x00001534
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

		// Token: 0x06000046 RID: 70 RVA: 0x00003384 File Offset: 0x00001584
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
			this.RichTextBox1.TabIndex = 0;
			this.RichTextBox1.Text = "";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.RichTextBox1);
			base.Name = "extracted_pagetypes";
			base.Size = new Size(372, 165);
			base.ResumeLayout(false);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003476 File Offset: 0x00001676
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00003480 File Offset: 0x00001680
		public virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400001F RID: 31
		private IContainer components;
	}
}
