namespace μProxy_Tool
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.OptionText]
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Export : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00171064 File Offset: 0x0016F464
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x001710A4 File Offset: 0x0016F4A4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::μProxy_Tool.Export));
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox4 = new global::System.Windows.Forms.CheckBox();
			this.CheckedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.CheckBox5 = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Checked = true;
			this.CheckBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(16, 22);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(90, 17);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 0;
			this.CheckBox1.Text = "Elite (Level 1)";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Checked = true;
			this.CheckBox2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			global::System.Windows.Forms.Control checkBox3 = this.CheckBox2;
			location = new global::System.Drawing.Point(16, 45);
			checkBox3.Location = location;
			this.CheckBox2.Name = "CheckBox2";
			global::System.Windows.Forms.Control checkBox4 = this.CheckBox2;
			size = new global::System.Drawing.Size(125, 17);
			checkBox4.Size = size;
			this.CheckBox2.TabIndex = 1;
			this.CheckBox2.Text = "Anonymous (Level 2)";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.CheckBox3.AutoSize = true;
			global::System.Windows.Forms.Control checkBox5 = this.CheckBox3;
			location = new global::System.Drawing.Point(16, 68);
			checkBox5.Location = location;
			this.CheckBox3.Name = "CheckBox3";
			global::System.Windows.Forms.Control checkBox6 = this.CheckBox3;
			size = new global::System.Drawing.Size(127, 17);
			checkBox6.Size = size;
			this.CheckBox3.TabIndex = 2;
			this.CheckBox3.Text = "Transparent (Level 3)";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.CheckBox4.AutoSize = true;
			global::System.Windows.Forms.Control checkBox7 = this.CheckBox4;
			location = new global::System.Drawing.Point(9, 15);
			checkBox7.Location = location;
			this.CheckBox4.Name = "CheckBox4";
			global::System.Windows.Forms.Control checkBox8 = this.CheckBox4;
			size = new global::System.Drawing.Size(62, 17);
			checkBox8.Size = size;
			this.CheckBox4.TabIndex = 4;
			this.CheckBox4.Text = "Country";
			this.CheckBox4.UseVisualStyleBackColor = true;
			this.CheckedListBox1.CheckOnClick = true;
			this.CheckedListBox1.Enabled = false;
			this.CheckedListBox1.FormattingEnabled = true;
			global::System.Windows.Forms.Control checkedListBox = this.CheckedListBox1;
			location = new global::System.Drawing.Point(6, 32);
			checkedListBox.Location = location;
			this.CheckedListBox1.Name = "CheckedListBox1";
			global::System.Windows.Forms.Control checkedListBox2 = this.CheckedListBox1;
			size = new global::System.Drawing.Size(166, 94);
			checkedListBox2.Size = size;
			this.CheckedListBox1.TabIndex = 5;
			this.GroupBox1.Controls.Add(this.CheckBox2);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.CheckBox3);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new global::System.Drawing.Point(12, 6);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new global::System.Drawing.Size(184, 88);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Anonymity:";
			this.GroupBox2.Controls.Add(this.CheckedListBox1);
			this.GroupBox2.Controls.Add(this.CheckBox4);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(202, 6);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(179, 132);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 7;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Country:";
			this.GroupBox3.Controls.Add(this.Button1);
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox3;
			location = new global::System.Drawing.Point(12, 143);
			groupBox5.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			size = new global::System.Drawing.Size(369, 43);
			groupBox6.Size = size;
			this.GroupBox3.TabIndex = 8;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Export";
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(143, 11);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(107, 27);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Export";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.CheckBox5);
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox4;
			location = new global::System.Drawing.Point(12, 96);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox4;
			size = new global::System.Drawing.Size(184, 41);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 9;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Url Passed";
			this.CheckBox5.AutoSize = true;
			global::System.Windows.Forms.Control checkBox9 = this.CheckBox5;
			location = new global::System.Drawing.Point(16, 19);
			checkBox9.Location = location;
			this.CheckBox5.Name = "CheckBox5";
			global::System.Windows.Forms.Control checkBox10 = this.CheckBox5;
			size = new global::System.Drawing.Size(86, 17);
			checkBox10.Size = size;
			this.CheckBox5.TabIndex = 4;
			this.CheckBox5.Text = "URL Passed";
			this.CheckBox5.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(392, 191);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Export";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Export";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0400001D RID: 29
		private global::System.ComponentModel.IContainer components;
	}
}
