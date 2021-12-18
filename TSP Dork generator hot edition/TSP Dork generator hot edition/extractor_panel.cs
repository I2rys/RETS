using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public class extractor_panel : UserControl
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003489 File Offset: 0x00001689
		public extractor_panel()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003498 File Offset: 0x00001698
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

		// Token: 0x0600004B RID: 75 RVA: 0x000034E8 File Offset: 0x000016E8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.urlstoextractfrom = new RichTextBox();
			this.Label1 = new Label();
			this.keywordsbtn = new Button();
			this.dorkbtn = new Button();
			this.pagetypesbtn = new Button();
			this.Button4 = new Button();
			this.Extracted_dorks1 = new extracted_dorks();
			this.Extracted_keywords1 = new extracted_keywords();
			this.Extracted_pagetypes1 = new extracted_pagetypes();
			base.SuspendLayout();
			this.urlstoextractfrom.DetectUrls = false;
			this.urlstoextractfrom.Location = new Point(6, 49);
			this.urlstoextractfrom.Name = "urlstoextractfrom";
			this.urlstoextractfrom.Size = new Size(666, 206);
			this.urlstoextractfrom.TabIndex = 0;
			this.urlstoextractfrom.Text = "";
			this.Label1.AutoSize = true;
			this.Label1.Font = new Font("Consolas", 9f);
			this.Label1.Location = new Point(3, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(154, 14);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "Urls to extract from:";
			this.keywordsbtn.FlatStyle = FlatStyle.Flat;
			this.keywordsbtn.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.keywordsbtn.Location = new Point(804, 8);
			this.keywordsbtn.Name = "keywordsbtn";
			this.keywordsbtn.Padding = new Padding(0, 3, 0, 3);
			this.keywordsbtn.Size = new Size(120, 35);
			this.keywordsbtn.TabIndex = 20;
			this.keywordsbtn.Text = "Keywords";
			this.keywordsbtn.UseVisualStyleBackColor = true;
			this.dorkbtn.FlatStyle = FlatStyle.Flat;
			this.dorkbtn.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dorkbtn.Location = new Point(930, 8);
			this.dorkbtn.Name = "dorkbtn";
			this.dorkbtn.Padding = new Padding(0, 3, 0, 3);
			this.dorkbtn.Size = new Size(120, 35);
			this.dorkbtn.TabIndex = 21;
			this.dorkbtn.Text = "Dorks";
			this.dorkbtn.UseVisualStyleBackColor = true;
			this.pagetypesbtn.FlatStyle = FlatStyle.Flat;
			this.pagetypesbtn.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.pagetypesbtn.Location = new Point(678, 8);
			this.pagetypesbtn.Name = "pagetypesbtn";
			this.pagetypesbtn.Padding = new Padding(0, 3, 0, 3);
			this.pagetypesbtn.Size = new Size(120, 35);
			this.pagetypesbtn.TabIndex = 22;
			this.pagetypesbtn.Text = "Pagetypes";
			this.pagetypesbtn.UseVisualStyleBackColor = true;
			this.Button4.FlatStyle = FlatStyle.Flat;
			this.Button4.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button4.Location = new Point(678, 220);
			this.Button4.Name = "Button4";
			this.Button4.Padding = new Padding(0, 3, 0, 3);
			this.Button4.Size = new Size(372, 35);
			this.Button4.TabIndex = 26;
			this.Button4.Text = "Extract";
			this.Button4.UseVisualStyleBackColor = true;
			this.Extracted_dorks1.Location = new Point(678, 49);
			this.Extracted_dorks1.Name = "Extracted_dorks1";
			this.Extracted_dorks1.Size = new Size(372, 165);
			this.Extracted_dorks1.TabIndex = 27;
			this.Extracted_keywords1.Location = new Point(678, 49);
			this.Extracted_keywords1.Name = "Extracted_keywords1";
			this.Extracted_keywords1.Size = new Size(372, 165);
			this.Extracted_keywords1.TabIndex = 28;
			this.Extracted_pagetypes1.Location = new Point(678, 49);
			this.Extracted_pagetypes1.Name = "Extracted_pagetypes1";
			this.Extracted_pagetypes1.Size = new Size(372, 165);
			this.Extracted_pagetypes1.TabIndex = 29;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.Extracted_pagetypes1);
			base.Controls.Add(this.Extracted_keywords1);
			base.Controls.Add(this.Extracted_dorks1);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.pagetypesbtn);
			base.Controls.Add(this.dorkbtn);
			base.Controls.Add(this.keywordsbtn);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.urlstoextractfrom);
			base.Name = "extractor_panel";
			base.Size = new Size(1059, 258);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003AEA File Offset: 0x00001CEA
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public virtual RichTextBox urlstoextractfrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003AFD File Offset: 0x00001CFD
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00003B07 File Offset: 0x00001D07
		public virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00003B1C File Offset: 0x00001D1C
		public virtual Button keywordsbtn
		{
			[CompilerGenerated]
			get
			{
				return this._keywordsbtn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.button1_Click);
				Button keywordsbtn = this._keywordsbtn;
				if (keywordsbtn != null)
				{
					keywordsbtn.Click -= value2;
				}
				this._keywordsbtn = value;
				keywordsbtn = this._keywordsbtn;
				if (keywordsbtn != null)
				{
					keywordsbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003B5F File Offset: 0x00001D5F
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00003B6C File Offset: 0x00001D6C
		public virtual Button dorkbtn
		{
			[CompilerGenerated]
			get
			{
				return this._dorkbtn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button dorkbtn = this._dorkbtn;
				if (dorkbtn != null)
				{
					dorkbtn.Click -= value2;
				}
				this._dorkbtn = value;
				dorkbtn = this._dorkbtn;
				if (dorkbtn != null)
				{
					dorkbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003BAF File Offset: 0x00001DAF
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003BBC File Offset: 0x00001DBC
		public virtual Button pagetypesbtn
		{
			[CompilerGenerated]
			get
			{
				return this._pagetypesbtn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button pagetypesbtn = this._pagetypesbtn;
				if (pagetypesbtn != null)
				{
					pagetypesbtn.Click -= value2;
				}
				this._pagetypesbtn = value;
				pagetypesbtn = this._pagetypesbtn;
				if (pagetypesbtn != null)
				{
					pagetypesbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003BFF File Offset: 0x00001DFF
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00003C0C File Offset: 0x00001E0C
		public virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003C4F File Offset: 0x00001E4F
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00003C59 File Offset: 0x00001E59
		public virtual extracted_dorks Extracted_dorks1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003C62 File Offset: 0x00001E62
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003C6C File Offset: 0x00001E6C
		public virtual extracted_keywords Extracted_keywords1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003C75 File Offset: 0x00001E75
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003C7F File Offset: 0x00001E7F
		public virtual extracted_pagetypes Extracted_pagetypes1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600005E RID: 94 RVA: 0x00003C88 File Offset: 0x00001E88
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Extracted_pagetypes1.Visible = true;
			this.Extracted_keywords1.Visible = false;
			this.Extracted_dorks1.Visible = false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003CB2 File Offset: 0x00001EB2
		private void button1_Click(object sender, EventArgs e)
		{
			this.Extracted_pagetypes1.Visible = false;
			this.Extracted_keywords1.Visible = true;
			this.Extracted_dorks1.Visible = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003CDC File Offset: 0x00001EDC
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Extracted_pagetypes1.Visible = false;
			this.Extracted_keywords1.Visible = false;
			this.Extracted_dorks1.Visible = true;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003D08 File Offset: 0x00001F08
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Extracted_dorks1.RichTextBox1.Text = this.urlstoextractfrom.Text;
			this.Extracted_dorks1.RichTextBox1.Text = Regex.Replace(this.Extracted_dorks1.RichTextBox1.Text, ".*/", string.Empty);
			this.Extracted_dorks1.RichTextBox1.Lines = this.Extracted_dorks1.RichTextBox1.Lines.Distinct<string>().ToArray<string>();
			this.Extracted_pagetypes1.RichTextBox1.Text = this.urlstoextractfrom.Text;
			this.Extracted_pagetypes1.RichTextBox1.Text = Regex.Replace(this.Extracted_pagetypes1.RichTextBox1.Text, ".*[?]", string.Empty);
			this.Extracted_pagetypes1.RichTextBox1.Text = Regex.Replace(this.Extracted_pagetypes1.RichTextBox1.Text, "[=].*", "=");
			this.Extracted_pagetypes1.RichTextBox1.Text = Regex.Replace(this.Extracted_pagetypes1.RichTextBox1.Text, ".*[/]", string.Empty);
			this.Extracted_pagetypes1.RichTextBox1.Text = Regex.Replace(this.Extracted_pagetypes1.RichTextBox1.Text, ".*[&]", string.Empty);
			this.Extracted_pagetypes1.RichTextBox1.Lines = this.Extracted_pagetypes1.RichTextBox1.Lines.Distinct<string>().ToArray<string>();
			this.Extracted_keywords1.RichTextBox1.Text = this.urlstoextractfrom.Text;
			this.Extracted_keywords1.RichTextBox1.Text = Regex.Replace(this.Extracted_keywords1.RichTextBox1.Text, ".*[/]", string.Empty);
			this.Extracted_keywords1.RichTextBox1.Text = Regex.Replace(this.Extracted_keywords1.RichTextBox1.Text, "[.].*", string.Empty);
			this.Extracted_keywords1.RichTextBox1.Lines = this.Extracted_keywords1.RichTextBox1.Lines.Distinct<string>().ToArray<string>();
		}

		// Token: 0x04000021 RID: 33
		private IContainer components;
	}
}
