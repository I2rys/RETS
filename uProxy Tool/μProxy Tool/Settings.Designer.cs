namespace μProxy_Tool
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	[global::Microsoft.VisualBasic.CompilerServices.OptionText]
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00172078 File Offset: 0x00170478
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

		// Token: 0x06000067 RID: 103 RVA: 0x001720B8 File Offset: 0x001704B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::μProxy_Tool.Settings));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.CheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.TextBox3 = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.auto_save = new global::System.Windows.Forms.CheckBox();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.NumericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.CheckBox3);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(13, 156);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(289, 110);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Main";
			this.CheckBox3.AutoSize = true;
			global::System.Windows.Forms.Control checkBox = this.CheckBox3;
			location = new global::System.Drawing.Point(6, 85);
			checkBox.Location = location;
			this.CheckBox3.Name = "CheckBox3";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox3;
			size = new global::System.Drawing.Size(77, 17);
			checkBox2.Size = size;
			this.CheckBox3.TabIndex = 6;
			this.CheckBox3.Text = "Url Passed";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.TextBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control textBox = this.TextBox3;
			location = new global::System.Drawing.Point(89, 84);
			textBox.Location = location;
			this.TextBox3.Name = "TextBox3";
			global::System.Windows.Forms.Control textBox2 = this.TextBox3;
			size = new global::System.Drawing.Size(193, 20);
			textBox2.Size = size;
			this.TextBox3.TabIndex = 8;
			this.TextBox3.TabStop = false;
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label2;
			location = new global::System.Drawing.Point(17, 53);
			label.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label2 = this.Label2;
			size = new global::System.Drawing.Size(63, 13);
			label2.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Country API";
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.Enabled = false;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			location = new global::System.Drawing.Point(90, 54);
			textBox3.Location = location;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(193, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 6;
			this.TextBox2.TabStop = false;
			this.TextBox2.Text = "http://ip2c.org";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label1;
			location = new global::System.Drawing.Point(15, 21);
			label3.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(65, 13);
			label4.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Proxy Judge";
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control textBox5 = this.TextBox1;
			location = new global::System.Drawing.Point(90, 19);
			textBox5.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox6 = this.TextBox1;
			size = new global::System.Drawing.Size(193, 20);
			textBox6.Size = size;
			this.TextBox1.TabIndex = 6;
			this.GroupBox2.Controls.Add(this.auto_save);
			this.GroupBox2.Controls.Add(this.CheckBox2);
			this.GroupBox2.Controls.Add(this.CheckBox1);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.NumericUpDown2);
			this.GroupBox2.Controls.Add(this.NumericUpDown1);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(12, 9);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(289, 143);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Settings";
			this.auto_save.AutoSize = true;
			this.auto_save.Checked = true;
			this.auto_save.CheckState = global::System.Windows.Forms.CheckState.Checked;
			global::System.Windows.Forms.Control auto_save = this.auto_save;
			location = new global::System.Drawing.Point(90, 100);
			auto_save.Location = location;
			this.auto_save.Name = "auto_save";
			global::System.Windows.Forms.Control auto_save2 = this.auto_save;
			size = new global::System.Drawing.Size(113, 17);
			auto_save2.Size = size;
			this.auto_save.TabIndex = 4;
			this.auto_save.Text = "Auto Save Proxies";
			this.auto_save.UseVisualStyleBackColor = true;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Checked = true;
			this.CheckBox2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			global::System.Windows.Forms.Control checkBox3 = this.CheckBox2;
			location = new global::System.Drawing.Point(90, 122);
			checkBox3.Location = location;
			this.CheckBox2.Name = "CheckBox2";
			global::System.Windows.Forms.Control checkBox4 = this.CheckBox2;
			size = new global::System.Drawing.Size(123, 17);
			checkBox4.Size = size;
			this.CheckBox2.TabIndex = 5;
			this.CheckBox2.Text = "Inbuild Proxy Source";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.CheckBox1.AutoSize = true;
			global::System.Windows.Forms.Control checkBox5 = this.CheckBox1;
			location = new global::System.Drawing.Point(90, 78);
			checkBox5.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox6 = this.CheckBox1;
			size = new global::System.Drawing.Size(119, 17);
			checkBox6.Size = size;
			this.CheckBox1.TabIndex = 3;
			this.CheckBox1.Text = "Auto Check Proxies";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label4;
			location = new global::System.Drawing.Point(21, 52);
			label5.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label6 = this.Label4;
			size = new global::System.Drawing.Size(59, 13);
			label6.Size = size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Timeout (s)";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label3;
			location = new global::System.Drawing.Point(34, 21);
			label7.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label8 = this.Label3;
			size = new global::System.Drawing.Size(46, 13);
			label8.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Threads";
			global::System.Windows.Forms.Control numericUpDown = this.NumericUpDown2;
			location = new global::System.Drawing.Point(90, 48);
			numericUpDown.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown2;
			decimal num = new decimal(new int[]
			{
				30,
				0,
				0,
				0
			});
			numericUpDown2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.NumericUpDown2;
			num = new decimal(new int[]
			{
				3,
				0,
				0,
				0
			});
			numericUpDown3.Minimum = num;
			this.NumericUpDown2.Name = "NumericUpDown2";
			global::System.Windows.Forms.Control numericUpDown4 = this.NumericUpDown2;
			size = new global::System.Drawing.Size(77, 20);
			numericUpDown4.Size = size;
			this.NumericUpDown2.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.NumericUpDown2;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown5.Value = num;
			global::System.Windows.Forms.Control numericUpDown6 = this.NumericUpDown1;
			location = new global::System.Drawing.Point(90, 19);
			numericUpDown6.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				1000,
				0,
				0,
				0
			});
			numericUpDown7.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown8.Minimum = num;
			this.NumericUpDown1.Name = "NumericUpDown1";
			global::System.Windows.Forms.Control numericUpDown9 = this.NumericUpDown1;
			size = new global::System.Drawing.Size(77, 20);
			numericUpDown9.Size = size;
			this.NumericUpDown1.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				30,
				0,
				0,
				0
			});
			numericUpDown10.Value = num;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(120, 272);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(313, 299);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components;
	}
}
