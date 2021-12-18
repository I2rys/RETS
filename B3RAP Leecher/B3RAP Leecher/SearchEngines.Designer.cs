namespace B3RAP_Leecher
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SearchEngines : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000073E0 File Offset: 0x000055E0
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

		// Token: 0x060000A2 RID: 162 RVA: 0x00007430 File Offset: 0x00005630
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.RadioButton1 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton2 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton3 = new global::System.Windows.Forms.RadioButton();
			this.RadioButton4 = new global::System.Windows.Forms.RadioButton();
			base.SuspendLayout();
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton1.Location = new global::System.Drawing.Point(44, 12);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new global::System.Drawing.Size(57, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Bing";
			this.RadioButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton2.Location = new global::System.Drawing.Point(44, 42);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new global::System.Drawing.Size(68, 24);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "Yahoo";
			this.RadioButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton3.Location = new global::System.Drawing.Point(44, 72);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new global::System.Drawing.Size(74, 24);
			this.RadioButton3.TabIndex = 22;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "Yandex";
			this.RadioButton3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RadioButton4.Location = new global::System.Drawing.Point(44, 102);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new global::System.Drawing.Size(76, 24);
			this.RadioButton4.TabIndex = 23;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "Google";
			this.RadioButton4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RadioButton4.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(161, 138);
			base.Controls.Add(this.RadioButton4);
			base.Controls.Add(this.RadioButton3);
			base.Controls.Add(this.RadioButton2);
			base.Controls.Add(this.RadioButton1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SearchEngines";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Engines";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components;
	}
}
