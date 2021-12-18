namespace μProxy_Tool
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	[global::Microsoft.VisualBasic.CompilerServices.OptionText]
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x001703F4 File Offset: 0x0016E7F4
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

		// Token: 0x06000037 RID: 55 RVA: 0x00170434 File Offset: 0x0016E834
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::μProxy_Tool.About));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.About_Lbl = new global::System.Windows.Forms.Label();
			this.Desc_Label = new global::System.Windows.Forms.Label();
			this.Version_Lbl = new global::System.Windows.Forms.Label();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 13);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(48, 48);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.About_Lbl.BackColor = global::System.Drawing.Color.Transparent;
			this.About_Lbl.Font = new global::System.Drawing.Font("Calibri", 21.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.About_Lbl.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control about_Lbl = this.About_Lbl;
			location = new global::System.Drawing.Point(61, 13);
			about_Lbl.Location = location;
			global::System.Windows.Forms.Control about_Lbl2 = this.About_Lbl;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(0);
			about_Lbl2.Margin = margin;
			this.About_Lbl.Name = "About_Lbl";
			global::System.Windows.Forms.Control about_Lbl3 = this.About_Lbl;
			size = new global::System.Drawing.Size(108, 38);
			about_Lbl3.Size = size;
			this.About_Lbl.TabIndex = 1;
			this.About_Lbl.Text = "μProxy";
			this.Desc_Label.AutoSize = true;
			this.Desc_Label.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Desc_Label.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control desc_Label = this.Desc_Label;
			location = new global::System.Drawing.Point(9, 93);
			desc_Label.Location = location;
			this.Desc_Label.Name = "Desc_Label";
			global::System.Windows.Forms.Control desc_Label2 = this.Desc_Label;
			size = new global::System.Drawing.Size(318, 90);
			desc_Label2.Size = size;
			this.Desc_Label.TabIndex = 2;
			this.Desc_Label.Text = "©2016 -17 Nikola Tesla, Hackforums.\r\nAll Rights Reserved.\r\n\r\nThanks for using our FREE Proxy Tool.We hope you like it.\r\n\r\nThanks to Nikola Tesla from Hackforums.";
			this.Version_Lbl.AutoSize = true;
			this.Version_Lbl.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Version_Lbl.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control version_Lbl = this.Version_Lbl;
			location = new global::System.Drawing.Point(68, 44);
			version_Lbl.Location = location;
			this.Version_Lbl.Name = "Version_Lbl";
			global::System.Windows.Forms.Control version_Lbl2 = this.Version_Lbl;
			size = new global::System.Drawing.Size(48, 15);
			version_Lbl2.Size = size;
			this.Version_Lbl.TabIndex = 3;
			this.Version_Lbl.Text = "Version";
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox2.Image");
			global::System.Windows.Forms.Control pictureBox3 = this.PictureBox2;
			location = new global::System.Drawing.Point(144, 44);
			pictureBox3.Location = location;
			this.PictureBox2.Name = "PictureBox2";
			global::System.Windows.Forms.Control pictureBox4 = this.PictureBox2;
			size = new global::System.Drawing.Size(18, 15);
			pictureBox4.Size = size;
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex = 4;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Visible = false;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
			global::System.Windows.Forms.Control linkLabel = this.LinkLabel1;
			location = new global::System.Drawing.Point(66, 60);
			linkLabel.Location = location;
			this.LinkLabel1.Name = "LinkLabel1";
			global::System.Windows.Forms.Control linkLabel2 = this.LinkLabel1;
			size = new global::System.Drawing.Size(55, 13);
			linkLabel2.Size = size;
			this.LinkLabel1.TabIndex = 5;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Download";
			this.LinkLabel1.Visible = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(338, 192);
			this.ClientSize = size;
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.Version_Lbl);
			this.Controls.Add(this.Desc_Label);
			this.Controls.Add(this.About_Lbl);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About μProxy";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000015 RID: 21
		private global::System.ComponentModel.IContainer components;
	}
}
