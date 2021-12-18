namespace Joker_Combo_Leecher__v1._0_
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Regex_Form : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00008E74 File Offset: 0x00007074
		[global::System.Diagnostics.DebuggerNonUserCode]
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

		// Token: 0x060000B7 RID: 183 RVA: 0x00008EC4 File Offset: 0x000070C4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.TextBox1.Location = new global::System.Drawing.Point(10, 25);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(306, 20);
			this.TextBox1.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(10, 6);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(149, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Please add your custom regex";
			this.Button1.Location = new global::System.Drawing.Point(87, 51);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(142, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Ok";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(335, 89);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.TextBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Regex_Form";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Regex_Form";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000058 RID: 88
		private global::System.ComponentModel.IContainer components;
	}
}
