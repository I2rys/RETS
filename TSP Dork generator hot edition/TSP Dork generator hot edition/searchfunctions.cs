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
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public class searchfunctions : UserControl
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000093E0 File Offset: 0x000075E0
		public searchfunctions()
		{
			base.Load += this.searchfunctions_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00009400 File Offset: 0x00007600
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

		// Token: 0x06000123 RID: 291 RVA: 0x00009450 File Offset: 0x00007650
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.searchfunctionlist = new RichTextBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			base.SuspendLayout();
			this.searchfunctionlist.Location = new Point(3, 49);
			this.searchfunctionlist.Name = "searchfunctionlist";
			this.searchfunctionlist.Size = new Size(801, 147);
			this.searchfunctionlist.TabIndex = 24;
			this.searchfunctionlist.Text = "";
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new Point(141, 26);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new Size(65, 17);
			this.checkBox4.TabIndex = 23;
			this.checkBox4.Text = "Preset 4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new Point(141, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new Size(65, 17);
			this.checkBox3.TabIndex = 22;
			this.checkBox3.Text = "Preset 3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(3, 26);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new Size(65, 17);
			this.checkBox2.TabIndex = 21;
			this.checkBox2.Text = "Preset 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Size(65, 17);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Preset 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.searchfunctionlist);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Name = "searchfunctions";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000977B File Offset: 0x0000797B
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00009785 File Offset: 0x00007985
		public virtual RichTextBox searchfunctionlist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000978E File Offset: 0x0000798E
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00009798 File Offset: 0x00007998
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000097DB File Offset: 0x000079DB
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000097E8 File Offset: 0x000079E8
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000982B File Offset: 0x00007A2B
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00009838 File Offset: 0x00007A38
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000987B File Offset: 0x00007A7B
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00009888 File Offset: 0x00007A88
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

		// Token: 0x0600012E RID: 302 RVA: 0x000098CC File Offset: 0x00007ACC
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.searchfunctionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\searchfunctions\\preset1.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000993C File Offset: 0x00007B3C
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.searchfunctionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\searchfunctions\\preset2.txt");
				this.checkBox1.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000099AC File Offset: 0x00007BAC
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.searchfunctionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\searchfunctions\\preset3.txt");
				this.checkBox2.Checked = false;
				this.checkBox1.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00009A1C File Offset: 0x00007C1C
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.searchfunctionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\searchfunctions\\preset4.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox1.Checked = false;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00009A8C File Offset: 0x00007C8C
		private void searchfunctions_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = true;
		}

		// Token: 0x0400007A RID: 122
		private IContainer components;
	}
}
