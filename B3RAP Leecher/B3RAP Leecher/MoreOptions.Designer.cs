namespace B3RAP_Leecher
{
	// Token: 0x0200000A RID: 10
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MoreOptions : global::System.Windows.Forms.Form
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00006508 File Offset: 0x00004708
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

		// Token: 0x06000087 RID: 135 RVA: 0x00006558 File Offset: 0x00004758
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.NumericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.Button9 = new global::System.Windows.Forms.Button();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			base.SuspendLayout();
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox1.Location = new global::System.Drawing.Point(16, 49);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new global::System.Drawing.Size(190, 25);
			this.CheckBox1.TabIndex = 28;
			this.CheckBox1.Text = "Use VPN by LeakMania";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(68, 20);
			this.Label1.TabIndex = 31;
			this.Label1.Text = "Threads :";
			this.NumericUpDown1.BackColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.NumericUpDown1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.NumericUpDown1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.NumericUpDown1.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.NumericUpDown1.Location = new global::System.Drawing.Point(86, 9);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.NumericUpDown1;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new global::System.Drawing.Size(170, 23);
			this.NumericUpDown1.TabIndex = 32;
			this.NumericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.NumericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 150;
			numericUpDown3.Value = new decimal(array3);
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox2.Location = new global::System.Drawing.Point(16, 80);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new global::System.Drawing.Size(157, 25);
			this.CheckBox2.TabIndex = 33;
			this.CheckBox2.Text = "Use Proxies (BETA)";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.Button9.BackColor = global::System.Drawing.Color.FromArgb(94, 94, 94);
			this.Button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button9.Enabled = false;
			this.Button9.FlatAppearance.BorderSize = 0;
			this.Button9.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gray;
			this.Button9.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Silver;
			this.Button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button9.Location = new global::System.Drawing.Point(179, 80);
			this.Button9.Name = "Button9";
			this.Button9.Size = new global::System.Drawing.Size(75, 25);
			this.Button9.TabIndex = 34;
			this.Button9.Text = "Browse";
			this.Button9.UseVisualStyleBackColor = false;
			this.OpenFileDialog1.Filter = "Text Files|*.txt";
			this.OpenFileDialog1.Title = "Choose your proxylist :";
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Enabled = false;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[]
			{
				"HTTP",
				"SOCKS4",
				"SOCKS5"
			});
			this.ComboBox1.Location = new global::System.Drawing.Point(16, 115);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new global::System.Drawing.Size(238, 23);
			this.ComboBox1.TabIndex = 35;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(268, 150);
			base.Controls.Add(this.ComboBox1);
			base.Controls.Add(this.Button9);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.NumericUpDown1);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.CheckBox1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MoreOptions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "More Options";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000049 RID: 73
		private global::System.ComponentModel.IContainer components;
	}
}
