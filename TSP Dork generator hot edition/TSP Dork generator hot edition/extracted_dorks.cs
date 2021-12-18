using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public class extracted_dorks : UserControl
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000305B File Offset: 0x0000125B
		public extracted_dorks()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000306C File Offset: 0x0000126C
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

		// Token: 0x0600003C RID: 60 RVA: 0x000030BC File Offset: 0x000012BC
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
			base.Name = "extracted_dorks";
			base.Size = new Size(372, 165);
			base.ResumeLayout(false);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000031AE File Offset: 0x000013AE
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000031B8 File Offset: 0x000013B8
		internal virtual RichTextBox RichTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400001B RID: 27
		private IContainer components;
	}
}
