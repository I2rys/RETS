using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using TSP_Dork_generator_hot_edition.My;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public class generate_dorks_panel : UserControl
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00005A50 File Offset: 0x00003C50
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

		// Token: 0x0600009D RID: 157 RVA: 0x00005AA0 File Offset: 0x00003CA0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.numericUpDown2 = new NumericUpDown();
			this.GenerateButton = new Button();
			this.panel4 = new Panel();
			this.Label2 = new Label();
			this.NumericUpDown3 = new NumericUpDown();
			this.Label1 = new Label();
			this.generateddorks = new RichTextBox();
			this.button6 = new Button();
			this.button4 = new Button();
			this.button3 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.panel5 = new Panel();
			this.Searchfunctions1 = new searchfunctions();
			this.Pagetypes1 = new pagetypes();
			this.Pageformats1 = new pageformats();
			this.Keywords1 = new keywords();
			this.Dorktypes1 = new dorktypes();
			this.Domainextentions1 = new domainextentions();
			this.button5 = new Button();
			this.temp_sf = new TextBox();
			this.temp_pf = new TextBox();
			this.temp_pt = new TextBox();
			this.temp_kw = new TextBox();
			this.temp_de = new TextBox();
			((ISupportInitialize)this.numericUpDown2).BeginInit();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.NumericUpDown3).BeginInit();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.numericUpDown2.Location = new Point(146, 39);
			NumericUpDown numericUpDown = this.numericUpDown2;
			int[] array = new int[4];
			array[0] = 10000000;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numericUpDown2;
			int[] array2 = new int[4];
			array2[0] = 1000;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new Size(89, 20);
			this.numericUpDown2.TabIndex = 13;
			NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Value = new decimal(array3);
			this.GenerateButton.Dock = DockStyle.Top;
			this.GenerateButton.FlatStyle = FlatStyle.Flat;
			this.GenerateButton.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.GenerateButton.Location = new Point(0, 0);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Padding = new Padding(0, 3, 0, 3);
			this.GenerateButton.Size = new Size(235, 35);
			this.GenerateButton.TabIndex = 1;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.panel4.Controls.Add(this.Label2);
			this.panel4.Controls.Add(this.NumericUpDown3);
			this.panel4.Controls.Add(this.Label1);
			this.panel4.Controls.Add(this.numericUpDown2);
			this.panel4.Controls.Add(this.generateddorks);
			this.panel4.Controls.Add(this.GenerateButton);
			this.panel4.Location = new Point(818, 11);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(235, 236);
			this.panel4.TabIndex = 6;
			this.Label2.AutoSize = true;
			this.Label2.Font = new Font("Consolas", 9f);
			this.Label2.Location = new Point(-3, 68);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(91, 14);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "File number:";
			this.NumericUpDown3.Location = new Point(146, 65);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new Size(89, 20);
			this.NumericUpDown3.TabIndex = 14;
			this.Label1.AutoSize = true;
			this.Label1.Font = new Font("Consolas", 9f);
			this.Label1.Location = new Point(-3, 42);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(91, 14);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "Dork amount:";
			this.generateddorks.Dock = DockStyle.Bottom;
			this.generateddorks.Location = new Point(0, 85);
			this.generateddorks.Name = "generateddorks";
			this.generateddorks.Size = new Size(235, 151);
			this.generateddorks.TabIndex = 0;
			this.generateddorks.Text = "";
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.Location = new Point(670, 0);
			this.button6.Name = "button6";
			this.button6.Padding = new Padding(0, 3, 0, 3);
			this.button6.Size = new Size(137, 35);
			this.button6.TabIndex = 6;
			this.button6.Text = "Search functions";
			this.button6.UseVisualStyleBackColor = true;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.Location = new Point(420, 0);
			this.button4.Margin = new Padding(0);
			this.button4.Name = "button4";
			this.button4.Size = new Size(120, 35);
			this.button4.TabIndex = 4;
			this.button4.Text = "Pagetypes";
			this.button4.UseVisualStyleBackColor = true;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.Location = new Point(295, 0);
			this.button3.Margin = new Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new Size(120, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "Keywords";
			this.button3.UseVisualStyleBackColor = true;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(123, 0);
			this.button2.Margin = new Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new Size(168, 35);
			this.button2.TabIndex = 2;
			this.button2.Text = "Domain extentions";
			this.button2.UseVisualStyleBackColor = true;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Padding = new Padding(0, 3, 0, 3);
			this.button1.Size = new Size(120, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Dork types";
			this.button1.UseVisualStyleBackColor = true;
			this.panel5.Controls.Add(this.Searchfunctions1);
			this.panel5.Controls.Add(this.Pagetypes1);
			this.panel5.Controls.Add(this.Pageformats1);
			this.panel5.Controls.Add(this.Keywords1);
			this.panel5.Controls.Add(this.Dorktypes1);
			this.panel5.Controls.Add(this.Domainextentions1);
			this.panel5.Controls.Add(this.button6);
			this.panel5.Controls.Add(this.button5);
			this.panel5.Controls.Add(this.button4);
			this.panel5.Controls.Add(this.button3);
			this.panel5.Controls.Add(this.button2);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.temp_sf);
			this.panel5.Controls.Add(this.temp_pf);
			this.panel5.Controls.Add(this.temp_pt);
			this.panel5.Controls.Add(this.temp_kw);
			this.panel5.Controls.Add(this.temp_de);
			this.panel5.Location = new Point(5, 10);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(807, 238);
			this.panel5.TabIndex = 7;
			this.Searchfunctions1.Location = new Point(0, 39);
			this.Searchfunctions1.Name = "Searchfunctions1";
			this.Searchfunctions1.Size = new Size(807, 206);
			this.Searchfunctions1.TabIndex = 12;
			this.Pagetypes1.Location = new Point(0, 39);
			this.Pagetypes1.Name = "Pagetypes1";
			this.Pagetypes1.Size = new Size(807, 199);
			this.Pagetypes1.TabIndex = 11;
			this.Pageformats1.Location = new Point(0, 39);
			this.Pageformats1.Name = "Pageformats1";
			this.Pageformats1.Size = new Size(807, 199);
			this.Pageformats1.TabIndex = 10;
			this.Keywords1.Location = new Point(0, 39);
			this.Keywords1.Name = "Keywords1";
			this.Keywords1.Size = new Size(807, 199);
			this.Keywords1.TabIndex = 9;
			this.Dorktypes1.Location = new Point(0, 39);
			this.Dorktypes1.Name = "Dorktypes1";
			this.Dorktypes1.Size = new Size(807, 199);
			this.Dorktypes1.TabIndex = 8;
			this.Domainextentions1.Location = new Point(0, 39);
			this.Domainextentions1.Name = "Domainextentions1";
			this.Domainextentions1.Size = new Size(807, 199);
			this.Domainextentions1.TabIndex = 7;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.Location = new Point(544, 0);
			this.button5.Name = "button5";
			this.button5.Padding = new Padding(0, 3, 0, 3);
			this.button5.Size = new Size(120, 35);
			this.button5.TabIndex = 5;
			this.button5.Text = "Pageformats";
			this.button5.UseVisualStyleBackColor = true;
			this.temp_sf.Location = new Point(409, 58);
			this.temp_sf.Name = "temp_sf";
			this.temp_sf.Size = new Size(20, 20);
			this.temp_sf.TabIndex = 17;
			this.temp_sf.Visible = false;
			this.temp_pf.Location = new Point(383, 58);
			this.temp_pf.Name = "temp_pf";
			this.temp_pf.Size = new Size(20, 20);
			this.temp_pf.TabIndex = 16;
			this.temp_pf.Visible = false;
			this.temp_pt.Location = new Point(357, 58);
			this.temp_pt.Name = "temp_pt";
			this.temp_pt.Size = new Size(20, 20);
			this.temp_pt.TabIndex = 15;
			this.temp_pt.Visible = false;
			this.temp_kw.Location = new Point(331, 58);
			this.temp_kw.Name = "temp_kw";
			this.temp_kw.Size = new Size(20, 20);
			this.temp_kw.TabIndex = 14;
			this.temp_kw.Visible = false;
			this.temp_de.Location = new Point(305, 58);
			this.temp_de.Name = "temp_de";
			this.temp_de.Size = new Size(20, 20);
			this.temp_de.TabIndex = 13;
			this.temp_de.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel5);
			base.Name = "generate_dorks_panel";
			base.Size = new Size(1059, 258);
			((ISupportInitialize)this.numericUpDown2).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((ISupportInitialize)this.NumericUpDown3).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006A03 File Offset: 0x00004C03
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00006A0D File Offset: 0x00004C0D
		public virtual RichTextBox generateddorks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006A16 File Offset: 0x00004C16
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00006A20 File Offset: 0x00004C20
		public virtual NumericUpDown numericUpDown2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006A29 File Offset: 0x00004C29
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00006A34 File Offset: 0x00004C34
		public virtual Button GenerateButton
		{
			[CompilerGenerated]
			get
			{
				return this._GenerateButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GenerateButton_Click);
				Button generateButton = this._GenerateButton;
				if (generateButton != null)
				{
					generateButton.Click -= value2;
				}
				this._GenerateButton = value;
				generateButton = this._GenerateButton;
				if (generateButton != null)
				{
					generateButton.Click += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00006A77 File Offset: 0x00004C77
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00006A81 File Offset: 0x00004C81
		public virtual Panel panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006A8A File Offset: 0x00004C8A
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00006A94 File Offset: 0x00004C94
		public virtual Button button6
		{
			[CompilerGenerated]
			get
			{
				return this._button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button6_Click);
				Button button = this._button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button6 = value;
				button = this._button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006AD7 File Offset: 0x00004CD7
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00006AE4 File Offset: 0x00004CE4
		public virtual Button button4
		{
			[CompilerGenerated]
			get
			{
				return this._button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button4_Click);
				Button button = this._button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button4 = value;
				button = this._button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00006B27 File Offset: 0x00004D27
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00006B34 File Offset: 0x00004D34
		public virtual Button button3
		{
			[CompilerGenerated]
			get
			{
				return this._button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button3_Click);
				Button button = this._button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button3 = value;
				button = this._button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006B77 File Offset: 0x00004D77
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00006B84 File Offset: 0x00004D84
		public virtual Button button2
		{
			[CompilerGenerated]
			get
			{
				return this._button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button2_Click);
				Button button = this._button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button2 = value;
				button = this._button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00006BC7 File Offset: 0x00004DC7
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public virtual Button button1
		{
			[CompilerGenerated]
			get
			{
				return this._button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button1_Click);
				Button button = this._button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button1 = value;
				button = this._button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006C17 File Offset: 0x00004E17
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00006C21 File Offset: 0x00004E21
		public virtual Panel panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00006C2A File Offset: 0x00004E2A
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00006C34 File Offset: 0x00004E34
		public virtual Button button5
		{
			[CompilerGenerated]
			get
			{
				return this._button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button5_Click);
				Button button = this._button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._button5 = value;
				button = this._button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006C77 File Offset: 0x00004E77
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00006C81 File Offset: 0x00004E81
		public virtual searchfunctions Searchfunctions1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00006C8A File Offset: 0x00004E8A
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00006C94 File Offset: 0x00004E94
		public virtual pagetypes Pagetypes1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006C9D File Offset: 0x00004E9D
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00006CA7 File Offset: 0x00004EA7
		public virtual pageformats Pageformats1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00006CB0 File Offset: 0x00004EB0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00006CBA File Offset: 0x00004EBA
		public virtual keywords Keywords1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00006CC3 File Offset: 0x00004EC3
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00006CCD File Offset: 0x00004ECD
		public virtual dorktypes Dorktypes1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00006CD6 File Offset: 0x00004ED6
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00006CE0 File Offset: 0x00004EE0
		public virtual domainextentions Domainextentions1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00006CE9 File Offset: 0x00004EE9
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00006CF3 File Offset: 0x00004EF3
		public virtual TextBox temp_sf { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00006CFC File Offset: 0x00004EFC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00006D06 File Offset: 0x00004F06
		public virtual TextBox temp_pf { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006D0F File Offset: 0x00004F0F
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00006D19 File Offset: 0x00004F19
		public virtual TextBox temp_pt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006D22 File Offset: 0x00004F22
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00006D2C File Offset: 0x00004F2C
		public virtual TextBox temp_kw { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006D35 File Offset: 0x00004F35
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00006D3F File Offset: 0x00004F3F
		public virtual TextBox temp_de { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006D48 File Offset: 0x00004F48
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00006D52 File Offset: 0x00004F52
		public virtual NumericUpDown NumericUpDown3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006D5B File Offset: 0x00004F5B
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00006D65 File Offset: 0x00004F65
		public virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006D6E File Offset: 0x00004F6E
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00006D78 File Offset: 0x00004F78
		public virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000D0 RID: 208 RVA: 0x00006D84 File Offset: 0x00004F84
		public async void GenerateButton_Click(object sender, EventArgs e)
		{
			bool flag = !this.Dorktypes1.dorktype1.Checked & !this.Dorktypes1.dorktype2.Checked & !this.Dorktypes1.dorktype5.Checked & !this.Dorktypes1.dorktype6.Checked & !this.Dorktypes1.dorktype7.Checked & !this.Dorktypes1.dorktype8.Checked & !this.Dorktypes1.dorktype11.Checked & !this.Dorktypes1.dorktype13.Checked & !this.Dorktypes1.dorktype14.Checked;
			if (flag)
			{
				Interaction.MsgBox("You need to select atleast 1 dork type", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Strings.Len(this.Domainextentions1.domainextentionlist.Text) == 0;
				if (flag2)
				{
					bool flag3 = this.Dorktypes1.dorktype2.Checked | this.Dorktypes1.dorktype5.Checked | this.Dorktypes1.dorktype7.Checked | this.Dorktypes1.dorktype8.Checked | this.Dorktypes1.dorktype11.Checked | this.Dorktypes1.dorktype14.Checked;
					if (flag3)
					{
						Interaction.MsgBox("You need to select atleast 1 domain extention for this dorktype", MsgBoxStyle.OkOnly, null);
						return;
					}
				}
				this.temp_kw.Text = this.Keywords1.keywordlist.Text;
				this.temp_kw.Text = Regex.Replace(this.temp_kw.Text, " ", "-");
				this.temp_kw.Text = Regex.Replace(this.temp_kw.Text, "\n", " ");
				this.temp_kw.Text = Regex.Replace(this.temp_kw.Text, "\r", string.Empty);
				this.temp_de.Text = this.Domainextentions1.domainextentionlist.Text;
				this.temp_de.Text = Regex.Replace(this.temp_de.Text, " ", "-");
				this.temp_de.Text = Regex.Replace(this.temp_de.Text, "\n", " ");
				this.temp_de.Text = Regex.Replace(this.temp_de.Text, "\r", string.Empty);
				this.temp_pf.Text = this.Pageformats1.pageformatlist.Text;
				this.temp_pf.Text = Regex.Replace(this.temp_pf.Text, " ", "-");
				this.temp_pf.Text = Regex.Replace(this.temp_pf.Text, "\n", " ");
				this.temp_pf.Text = Regex.Replace(this.temp_pf.Text, "\r", string.Empty);
				this.temp_pt.Text = this.Pagetypes1.pagetypeslist.Text;
				this.temp_pt.Text = Regex.Replace(this.temp_pt.Text, " ", "-");
				this.temp_pt.Text = Regex.Replace(this.temp_pt.Text, "\n", " ");
				this.temp_pt.Text = Regex.Replace(this.temp_pt.Text, "\r", string.Empty);
				this.temp_sf.Text = this.Searchfunctions1.searchfunctionlist.Text;
				this.temp_sf.Text = Regex.Replace(this.temp_sf.Text, " ", "-");
				this.temp_sf.Text = Regex.Replace(this.temp_sf.Text, "\n", " ");
				this.temp_sf.Text = Regex.Replace(this.temp_sf.Text, "\r", string.Empty);
				await Task.WhenAll(new List<Task>
				{
					Task.Run(new Action(this.generate))
				});
				this.generateddorks.Text = MyProject.Computer.FileSystem.ReadAllText(Application.StartupPath + "\\Generated" + Conversions.ToString(this.NumericUpDown3.Value) + ".txt");
				this.generateddorks.Lines = this.generateddorks.Lines.Distinct<string>().ToArray<string>();
				this.generateddorks.Text = Regex.Replace(this.generateddorks.Text, "-", " ");
				this.generateddorks.SaveFile(Application.StartupPath + "\\Generated" + Conversions.ToString(this.NumericUpDown3.Value) + ".txt", RichTextBoxStreamType.PlainText);
				MessageBox.Show("Dorks generated in Generated" + Conversions.ToString(this.NumericUpDown3.Value) + ".txt", "Task Completed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006DCB File Offset: 0x00004FCB
		public generate_dorks_panel()
		{
			base.Load += this.generate_dorks_panel_Load;
			this.random_0 = new Random();
			this.InitializeComponent();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006DFC File Offset: 0x00004FFC
		private void generate()
		{
			string path = Application.StartupPath + "/Generated" + Conversions.ToString(this.NumericUpDown3.Value) + ".txt";
			string[] array_ = Strings.Split(this.temp_sf.Text + " bug", " ", -1, CompareMethod.Binary);
			string[] array_2 = Strings.Split(this.temp_pt.Text + " bug", " ", -1, CompareMethod.Binary);
			string[] array_3 = Strings.Split(this.temp_pf.Text + " .bug?", " ", -1, CompareMethod.Binary);
			string[] array_4 = Strings.Split(this.temp_de.Text + " .bug?", " ", -1, CompareMethod.Binary);
			Strings.Split(this.temp_pf.Text + " .bug?", " ", -1, CompareMethod.Binary);
			Strings.Split(this.temp_pt.Text + " bug", " ", -1, CompareMethod.Binary);
			Strings.Split(this.temp_sf.Text + " bug", " ", -1, CompareMethod.Binary);
			Strings.Split(this.temp_de.Text + " bug", " ", -1, CompareMethod.Binary);
			List<string> list = new List<string>();
			list.AddRange(Strings.Split(this.temp_kw.Text + " bug", " ", -1, CompareMethod.Binary));
			string[] array_5 = list.ToArray();
			Random random = new Random();
			using (StreamWriter streamWriter = File.CreateText(path))
			{
				bool @checked = this.Dorktypes1.dorktype1.Checked;
				if (@checked)
				{
					decimal value = this.numericUpDown2.Value;
					decimal d = 1m;
					while (decimal.Compare(d, value) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_5)), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "=")));
						d = decimal.Add(d, 1m);
					}
				}
				bool checked2 = this.Dorktypes1.dorktype2.Checked;
				if (checked2)
				{
					decimal value2 = this.numericUpDown2.Value;
					decimal d2 = 1m;
					while (decimal.Compare(d2, value2) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_5)), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "= site:")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))));
						d2 = decimal.Add(d2, 1m);
					}
				}
				bool checked3 = this.Dorktypes1.dorktype5.Checked;
				if (checked3)
				{
					decimal value3 = this.numericUpDown2.Value;
					decimal d3 = 1m;
					while (decimal.Compare(d3, value3) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_)), "\"")), ".")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))), "\"")), " + ")), "\"")), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), "\"")));
						d3 = decimal.Add(d3, 1m);
					}
				}
				bool checked4 = this.Dorktypes1.dorktype6.Checked;
				if (checked4)
				{
					decimal value4 = this.numericUpDown2.Value;
					decimal d4 = 1m;
					while (decimal.Compare(d4, value4) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_)), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "=")));
						d4 = decimal.Add(d4, 1m);
					}
				}
				bool checked5 = this.Dorktypes1.dorktype7.Checked;
				if (checked5)
				{
					decimal value5 = this.numericUpDown2.Value;
					decimal d5 = 1m;
					while (decimal.Compare(d5, value5) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_)), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "= ")), "site:")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))));
						d5 = decimal.Add(d5, 1m);
					}
				}
				bool checked6 = this.Dorktypes1.dorktype8.Checked;
				if (checked6)
				{
					decimal value6 = this.numericUpDown2.Value;
					decimal d6 = 1m;
					while (decimal.Compare(d6, value6) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_)), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "= ")), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), " site:")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))));
						d6 = decimal.Add(d6, 1m);
					}
				}
				bool checked7 = this.Dorktypes1.dorktype11.Checked;
				if (checked7)
				{
					decimal value7 = this.numericUpDown2.Value;
					decimal d7 = 1m;
					while (decimal.Compare(d7, value7) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_)), "\"")), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), "\" + \".")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))), "\"")), RuntimeHelpers.GetObjectValue(this.method_0(array_3)))), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "=")));
						d7 = decimal.Add(d7, 1m);
					}
				}
				bool checked8 = this.Dorktypes1.dorktype13.Checked;
				if (checked8)
				{
					decimal value8 = this.numericUpDown2.Value;
					decimal d8 = 1m;
					while (decimal.Compare(d8, value8) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_3)), RuntimeHelpers.GetObjectValue(this.method_0(array_2)))), "= \"")), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), "\"")));
						d8 = decimal.Add(d8, 1m);
					}
				}
				bool checked9 = this.Dorktypes1.dorktype14.Checked;
				if (checked9)
				{
					decimal value9 = this.numericUpDown2.Value;
					decimal d9 = 1m;
					while (decimal.Compare(d9, value9) <= 0)
					{
						streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(this.method_0(array_2)), "= \"")), RuntimeHelpers.GetObjectValue(this.method_0(array_5)))), "\" + \".")), RuntimeHelpers.GetObjectValue(this.method_0(array_4)))), "\"")));
						d9 = decimal.Add(d9, 1m);
					}
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007720 File Offset: 0x00005920
		private object method_0(Array array_0)
		{
			return NewLateBinding.LateIndexGet(array_0, new object[]
			{
				this.random_0.Next(0, checked(array_0.Length - 1))
			}, null);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000775C File Offset: 0x0000595C
		private void generate_dorks_panel_Load(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = true;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000077B8 File Offset: 0x000059B8
		private void button1_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = true;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007814 File Offset: 0x00005A14
		private void button2_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = false;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = true;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007870 File Offset: 0x00005A70
		private void button3_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = false;
			this.Keywords1.Visible = true;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000078CC File Offset: 0x00005ACC
		private void button4_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = false;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = true;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007928 File Offset: 0x00005B28
		private void button5_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = false;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = true;
			this.Searchfunctions1.Visible = false;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007984 File Offset: 0x00005B84
		private void button6_Click(object sender, EventArgs e)
		{
			this.Dorktypes1.Visible = false;
			this.Keywords1.Visible = false;
			this.Pagetypes1.Visible = false;
			this.Pageformats1.Visible = false;
			this.Searchfunctions1.Visible = true;
			this.Domainextentions1.Visible = false;
		}

		// Token: 0x04000045 RID: 69
		private IContainer components;

		// Token: 0x0400005F RID: 95
		private Random random_0;
	}
}
