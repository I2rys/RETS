using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace TSP_Dork_generator_hot_edition
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public class dorktypes : UserControl
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000029BC File Offset: 0x00000BBC
		public dorktypes()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000029CC File Offset: 0x00000BCC
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

		// Token: 0x06000027 RID: 39 RVA: 0x00002A1C File Offset: 0x00000C1C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.dorktype13 = new CheckBox();
			this.dorktype14 = new CheckBox();
			this.dorktype11 = new CheckBox();
			this.dorktype8 = new CheckBox();
			this.dorktype2 = new CheckBox();
			this.dorktype5 = new CheckBox();
			this.dorktype6 = new CheckBox();
			this.dorktype7 = new CheckBox();
			this.dorktype1 = new CheckBox();
			base.SuspendLayout();
			this.dorktype13.AutoSize = true;
			this.dorktype13.Location = new Point(3, 159);
			this.dorktype13.Name = "dorktype13";
			this.dorktype13.Size = new Size(117, 17);
			this.dorktype13.TabIndex = 27;
			this.dorktype13.Text = ".(PF)?(PT)= \"(KW)\"";
			this.dorktype13.UseVisualStyleBackColor = true;
			this.dorktype14.AutoSize = true;
			this.dorktype14.Location = new Point(3, 181);
			this.dorktype14.Name = "dorktype14";
			this.dorktype14.Size = new Size(135, 17);
			this.dorktype14.TabIndex = 26;
			this.dorktype14.Text = "(PT)= \"(KW)\" + \".(DE)\"";
			this.dorktype14.UseVisualStyleBackColor = true;
			this.dorktype11.AutoSize = true;
			this.dorktype11.Location = new Point(3, 136);
			this.dorktype11.Name = "dorktype11";
			this.dorktype11.Size = new Size(176, 17);
			this.dorktype11.TabIndex = 24;
			this.dorktype11.Text = "(SF)\"(KW)\" + \"(DE)\".(PF)?(PT)=";
			this.dorktype11.UseVisualStyleBackColor = true;
			this.dorktype8.AutoSize = true;
			this.dorktype8.Location = new Point(3, 113);
			this.dorktype8.Name = "dorktype8";
			this.dorktype8.Size = new Size(166, 17);
			this.dorktype8.TabIndex = 23;
			this.dorktype8.Text = "(SF)(PT)=(KW).(PF)? site:(DE)";
			this.dorktype8.UseVisualStyleBackColor = true;
			this.dorktype2.AutoSize = true;
			this.dorktype2.Location = new Point(3, 25);
			this.dorktype2.Name = "dorktype2";
			this.dorktype2.Size = new Size(147, 17);
			this.dorktype2.TabIndex = 20;
			this.dorktype2.Text = "(KW).(PF)?(PT)= site:(DE)";
			this.dorktype2.UseVisualStyleBackColor = true;
			this.dorktype5.AutoSize = true;
			this.dorktype5.Location = new Point(3, 47);
			this.dorktype5.Name = "dorktype5";
			this.dorktype5.Size = new Size(125, 17);
			this.dorktype5.TabIndex = 19;
			this.dorktype5.Text = "(SF)\".(DE)\" + \"(KW)\"";
			this.dorktype5.UseVisualStyleBackColor = true;
			this.dorktype6.AutoSize = true;
			this.dorktype6.Location = new Point(3, 69);
			this.dorktype6.Name = "dorktype6";
			this.dorktype6.Size = new Size(123, 17);
			this.dorktype6.TabIndex = 18;
			this.dorktype6.Text = "(SF)(KW).(PF)?(PT)=";
			this.dorktype6.UseVisualStyleBackColor = true;
			this.dorktype7.AutoSize = true;
			this.dorktype7.Location = new Point(3, 91);
			this.dorktype7.Name = "dorktype7";
			this.dorktype7.Size = new Size(166, 17);
			this.dorktype7.TabIndex = 15;
			this.dorktype7.Text = "(SF)(KW).(PF)?(PT)= site:(DE)";
			this.dorktype7.UseVisualStyleBackColor = true;
			this.dorktype1.AutoSize = true;
			this.dorktype1.Location = new Point(3, 3);
			this.dorktype1.Name = "dorktype1";
			this.dorktype1.Size = new Size(104, 17);
			this.dorktype1.TabIndex = 14;
			this.dorktype1.Text = "(KW).(PF)?(PT)=";
			this.dorktype1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.dorktype13);
			base.Controls.Add(this.dorktype14);
			base.Controls.Add(this.dorktype11);
			base.Controls.Add(this.dorktype8);
			base.Controls.Add(this.dorktype2);
			base.Controls.Add(this.dorktype5);
			base.Controls.Add(this.dorktype6);
			base.Controls.Add(this.dorktype7);
			base.Controls.Add(this.dorktype1);
			base.Name = "dorktypes";
			base.Size = new Size(807, 199);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002FBA File Offset: 0x000011BA
		internal virtual CheckBox dorktype13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002FC3 File Offset: 0x000011C3
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002FCD File Offset: 0x000011CD
		internal virtual CheckBox dorktype14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002FD6 File Offset: 0x000011D6
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002FE0 File Offset: 0x000011E0
		internal virtual CheckBox dorktype11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002FE9 File Offset: 0x000011E9
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002FF3 File Offset: 0x000011F3
		internal virtual CheckBox dorktype8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002FFC File Offset: 0x000011FC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00003006 File Offset: 0x00001206
		internal virtual CheckBox dorktype2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000300F File Offset: 0x0000120F
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003019 File Offset: 0x00001219
		internal virtual CheckBox dorktype5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003022 File Offset: 0x00001222
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000302C File Offset: 0x0000122C
		internal virtual CheckBox dorktype6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003035 File Offset: 0x00001235
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000303F File Offset: 0x0000123F
		internal virtual CheckBox dorktype7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003052 File Offset: 0x00001252
		internal virtual CheckBox dorktype1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x04000011 RID: 17
		private IContainer components;
	}
}
