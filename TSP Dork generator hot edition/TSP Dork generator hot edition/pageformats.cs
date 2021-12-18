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
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public class pageformats : UserControl
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00008668 File Offset: 0x00006868
		public pageformats()
		{
			base.Load += this.pageformats_Load;
			this.InitializeComponent();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008688 File Offset: 0x00006888
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

		// Token: 0x060000FF RID: 255 RVA: 0x000086D8 File Offset: 0x000068D8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.pageformatlist = new RichTextBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			base.SuspendLayout();
			this.pageformatlist.Location = new Point(3, 49);
			this.pageformatlist.Name = "pageformatlist";
			this.pageformatlist.Size = new Size(801, 147);
			this.pageformatlist.TabIndex = 29;
			this.pageformatlist.Text = "";
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
			base.Controls.Add(this.pageformatlist);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Name = "pageformats";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008A03 File Offset: 0x00006C03
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00008A0D File Offset: 0x00006C0D
		public virtual RichTextBox pageformatlist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00008A16 File Offset: 0x00006C16
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00008A20 File Offset: 0x00006C20
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008A63 File Offset: 0x00006C63
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00008A70 File Offset: 0x00006C70
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00008AB3 File Offset: 0x00006CB3
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00008AC0 File Offset: 0x00006CC0
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00008B03 File Offset: 0x00006D03
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00008B10 File Offset: 0x00006D10
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

		// Token: 0x0600010A RID: 266 RVA: 0x00008B54 File Offset: 0x00006D54
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.pageformatlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pageformats\\preset1.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008BC4 File Offset: 0x00006DC4
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.pageformatlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pageformats\\preset2.txt");
				this.checkBox1.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008C34 File Offset: 0x00006E34
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.pageformatlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pageformats\\preset3.txt");
				this.checkBox2.Checked = false;
				this.checkBox1.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008CA4 File Offset: 0x00006EA4
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.pageformatlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pageformats\\preset4.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox1.Checked = false;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008D14 File Offset: 0x00006F14
		private void pageformats_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = true;
		}

		// Token: 0x0400006E RID: 110
		private IContainer components;
	}
}
