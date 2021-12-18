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
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public class pagetypes : UserControl
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00008D24 File Offset: 0x00006F24
		public pagetypes()
		{
			base.Load += this.pagetypes_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008D44 File Offset: 0x00006F44
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

		// Token: 0x06000111 RID: 273 RVA: 0x00008D94 File Offset: 0x00006F94
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.pagetypeslist = new RichTextBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			base.SuspendLayout();
			this.pagetypeslist.Location = new Point(3, 49);
			this.pagetypeslist.Name = "pagetypeslist";
			this.pagetypeslist.Size = new Size(801, 147);
			this.pagetypeslist.TabIndex = 29;
			this.pagetypeslist.Text = "";
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
			base.Controls.Add(this.pagetypeslist);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Name = "pagetypes";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000090BF File Offset: 0x000072BF
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000090C9 File Offset: 0x000072C9
		public virtual RichTextBox pagetypeslist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000090D2 File Offset: 0x000072D2
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000090DC File Offset: 0x000072DC
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000911F File Offset: 0x0000731F
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000912C File Offset: 0x0000732C
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000916F File Offset: 0x0000736F
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000917C File Offset: 0x0000737C
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000091BF File Offset: 0x000073BF
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000091CC File Offset: 0x000073CC
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

		// Token: 0x0600011C RID: 284 RVA: 0x00009210 File Offset: 0x00007410
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.pagetypeslist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pagetypes\\preset1.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00009280 File Offset: 0x00007480
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.pagetypeslist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pagetypes\\preset2.txt");
				this.checkBox1.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000092F0 File Offset: 0x000074F0
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.pagetypeslist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pagetypes\\preset3.txt");
				this.checkBox2.Checked = false;
				this.checkBox1.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009360 File Offset: 0x00007560
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.pagetypeslist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\pagetypes\\preset4.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox1.Checked = false;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000093D0 File Offset: 0x000075D0
		private void pagetypes_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = true;
		}

		// Token: 0x04000074 RID: 116
		private IContainer components;
	}
}
