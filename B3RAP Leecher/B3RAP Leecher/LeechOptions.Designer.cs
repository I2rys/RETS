namespace B3RAP_Leecher
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class LeechOptions : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000025D4 File Offset: 0x000007D4
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

		// Token: 0x06000025 RID: 37 RVA: 0x00002624 File Offset: 0x00000824
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.RadioButton2 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton1 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton3 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton4 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton5 = new global::System.Windows.Forms.RadioButton();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton2.Location = new global::System.Drawing.Point(32, 42);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new global::System.Drawing.Size(86, 24);
			this.RadioButton2.TabIndex = 23;
			this.RadioButton2.Text = "User:Pass";
			this.RadioButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton1.Location = new global::System.Drawing.Point(32, 12);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new global::System.Drawing.Size(94, 24);
			this.RadioButton1.TabIndex = 22;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Email:Pass";
			this.RadioButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton3.Location = new global::System.Drawing.Point(32, 102);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new global::System.Drawing.Size(98, 24);
			this.RadioButton3.TabIndex = 25;
			this.RadioButton3.Text = "Email Only";
			this.RadioButton3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton4.Location = new global::System.Drawing.Point(32, 72);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new global::System.Drawing.Size(74, 24);
			this.RadioButton4.TabIndex = 26;
			this.RadioButton4.Text = "Proxies";
			this.RadioButton4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton5.Location = new global::System.Drawing.Point(32, 132);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new global::System.Drawing.Size(122, 24);
			this.RadioButton5.TabIndex = 27;
			this.RadioButton5.Text = "Custom Regex";
			this.RadioButton5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.TextBox1.Location = new global::System.Drawing.Point(32, 162);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(122, 23);
			this.TextBox1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(183, 200);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.RadioButton5);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.RadioButton1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LeechOptions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Leech Options";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;
	}
}
