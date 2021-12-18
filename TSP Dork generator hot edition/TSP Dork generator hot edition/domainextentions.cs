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
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public class domainextentions : UserControl
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000022FF File Offset: 0x000004FF
		public domainextentions()
		{
			base.Load += this.domainextentions_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002320 File Offset: 0x00000520
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

		// Token: 0x06000015 RID: 21 RVA: 0x00002370 File Offset: 0x00000570
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.domainextentionlist = new RichTextBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			base.SuspendLayout();
			this.domainextentionlist.Location = new Point(3, 49);
			this.domainextentionlist.Name = "domainextentionlist";
			this.domainextentionlist.Size = new Size(801, 147);
			this.domainextentionlist.TabIndex = 34;
			this.domainextentionlist.Text = "";
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new Point(141, 26);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new Size(65, 17);
			this.checkBox4.TabIndex = 33;
			this.checkBox4.Text = "Preset 4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new Point(141, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new Size(65, 17);
			this.checkBox3.TabIndex = 32;
			this.checkBox3.Text = "Preset 3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(3, 26);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new Size(65, 17);
			this.checkBox2.TabIndex = 31;
			this.checkBox2.Text = "Preset 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Size(65, 17);
			this.checkBox1.TabIndex = 30;
			this.checkBox1.Text = "Preset 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.domainextentionlist);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Name = "domainextentions";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000269B File Offset: 0x0000089B
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000026A5 File Offset: 0x000008A5
		public virtual RichTextBox domainextentionlist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000026AE File Offset: 0x000008AE
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000026B8 File Offset: 0x000008B8
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000026FB File Offset: 0x000008FB
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002708 File Offset: 0x00000908
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000274B File Offset: 0x0000094B
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002758 File Offset: 0x00000958
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000279B File Offset: 0x0000099B
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000027A8 File Offset: 0x000009A8
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

		// Token: 0x06000020 RID: 32 RVA: 0x000027EC File Offset: 0x000009EC
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.domainextentionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\domainextentions\\preset1.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000285C File Offset: 0x00000A5C
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.domainextentionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\domainextentions\\preset2.txt");
				this.checkBox1.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028CC File Offset: 0x00000ACC
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.domainextentionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\domainextentions\\preset3.txt");
				this.checkBox2.Checked = false;
				this.checkBox1.Checked = false;
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000293C File Offset: 0x00000B3C
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.domainextentionlist.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\presets\\domainextentions\\preset4.txt");
				this.checkBox2.Checked = false;
				this.checkBox3.Checked = false;
				this.checkBox1.Checked = false;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000029AC File Offset: 0x00000BAC
		private void domainextentions_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = true;
		}

		// Token: 0x0400000B RID: 11
		private IContainer components;
	}
}
