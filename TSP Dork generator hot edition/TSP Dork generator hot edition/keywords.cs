using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using TSP_Dork_generator_hot_edition.My;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public class keywords : UserControl
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00007FCC File Offset: 0x000061CC
		public keywords()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007FDC File Offset: 0x000061DC
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

		// Token: 0x060000EE RID: 238 RVA: 0x0000802C File Offset: 0x0000622C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.keywordlist = new RichTextBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			base.SuspendLayout();
			this.keywordlist.Location = new Point(3, 49);
			this.keywordlist.Name = "keywordlist";
			this.keywordlist.Size = new Size(801, 147);
			this.keywordlist.TabIndex = 29;
			this.keywordlist.Text = "";
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new Point(141, 26);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new Size(65, 17);
			this.checkBox4.TabIndex = 28;
			this.checkBox4.Text = "Preset 4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new Point(141, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new Size(65, 17);
			this.checkBox3.TabIndex = 27;
			this.checkBox3.Text = "Preset 3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(3, 26);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new Size(65, 17);
			this.checkBox2.TabIndex = 26;
			this.checkBox2.Text = "Preset 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Size(65, 17);
			this.checkBox1.TabIndex = 25;
			this.checkBox1.Text = "Preset 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.keywordlist);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Name = "keywords";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008357 File Offset: 0x00006557
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00008361 File Offset: 0x00006561
		public virtual RichTextBox keywordlist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000836A File Offset: 0x0000656A
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00008374 File Offset: 0x00006574
		public virtual CheckBox checkBox4
		{
			[CompilerGenerated]
			get
			{
				return this._checkBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.checkBox4_CheckedChanged);
				CheckBox checkBox = this._checkBox4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._checkBox4 = value;
				checkBox = this._checkBox4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000083B7 File Offset: 0x000065B7
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000083C4 File Offset: 0x000065C4
		public virtual CheckBox checkBox3
		{
			[CompilerGenerated]
			get
			{
				return this._checkBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.checkBox3_CheckedChanged);
				CheckBox checkBox = this._checkBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._checkBox3 = value;
				checkBox = this._checkBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00008407 File Offset: 0x00006607
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00008414 File Offset: 0x00006614
		public virtual CheckBox checkBox2
		{
			[CompilerGenerated]
			get
			{
				return this._checkBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.checkBox2_CheckedChanged);
				CheckBox checkBox = this._checkBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._checkBox2 = value;
				checkBox = this._checkBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00008457 File Offset: 0x00006657
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00008464 File Offset: 0x00006664
		public virtual CheckBox checkBox1
		{
			[CompilerGenerated]
			get
			{
				return this._checkBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.checkBox1_CheckedChanged);
				CheckBox checkBox = this._checkBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._checkBox1 = value;
				checkBox = this._checkBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000084A8 File Offset: 0x000066A8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.keywordlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\keywords\\preset1.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008518 File Offset: 0x00006718
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.keywordlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\keywords\\preset2.txt");
				this.checkBox1.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008588 File Offset: 0x00006788
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.keywordlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\keywords\\preset3.txt");
				this.checkBox2.Checked = false;
				this.checkBox1.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000085F8 File Offset: 0x000067F8
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.keywordlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\keywords\\preset4.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox1.Checked = false;
			}
		}

		// Token: 0x04000068 RID: 104
		private IContainer components;
	}
}
