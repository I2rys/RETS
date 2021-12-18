using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	[OptionText]
	public partial class About : Form
	{
		// Token: 0x06000035 RID: 53 RVA: 0x001703D0 File Offset: 0x0016E7D0
		public About()
		{
			base.Load += this.About_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00170944 File Offset: 0x0016ED44
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00170958 File Offset: 0x0016ED58
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00170964 File Offset: 0x0016ED64
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00170978 File Offset: 0x0016ED78
		internal virtual Label About_Lbl
		{
			get
			{
				return this._About_Lbl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.About_Lbl_Click);
				if (this._About_Lbl != null)
				{
					this._About_Lbl.Click -= value2;
				}
				this._About_Lbl = value;
				if (this._About_Lbl != null)
				{
					this._About_Lbl.Click += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x001709C4 File Offset: 0x0016EDC4
		// (set) Token: 0x0600003D RID: 61 RVA: 0x001709D8 File Offset: 0x0016EDD8
		internal virtual Label Desc_Label
		{
			get
			{
				return this._Desc_Label;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Desc_Label = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x001709E4 File Offset: 0x0016EDE4
		// (set) Token: 0x0600003F RID: 63 RVA: 0x001709F8 File Offset: 0x0016EDF8
		internal virtual Label Version_Lbl
		{
			get
			{
				return this._Version_Lbl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Version_Lbl = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00170A04 File Offset: 0x0016EE04
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00170A18 File Offset: 0x0016EE18
		internal virtual PictureBox PictureBox2
		{
			get
			{
				return this._PictureBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00170A24 File Offset: 0x0016EE24
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00170A38 File Offset: 0x0016EE38
		internal virtual LinkLabel LinkLabel1
		{
			get
			{
				return this._LinkLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				if (this._LinkLabel1 != null)
				{
					this._LinkLabel1.LinkClicked -= value2;
				}
				this._LinkLabel1 = value;
				if (this._LinkLabel1 != null)
				{
					this._LinkLabel1.LinkClicked += value2;
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00170A84 File Offset: 0x0016EE84
		private void About_Load(object sender, EventArgs e)
		{
			this.PictureBox2.Show();
			this.Version_Lbl.Text = "Version: " + this.ProductVersion;
			Thread thread = new Thread(new ThreadStart(this.Check_Update))
			{
				IsBackground = true,
				Name = "Update"
			};
			thread.Start();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00170AE4 File Offset: 0x0016EEE4
		private void About_Lbl_Click(object sender, EventArgs e)
		{
			Process.Start("http://hackforums.net/member.php?action=profile&uid=1845328");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00170AF4 File Offset: 0x0016EEF4
		public void Check_Update()
		{
			try
			{
				WebClient webClient = new WebClient();
				string str = webClient.DownloadString("http://pastebin.com/raw/SbVwVgtB");
				webClient.Dispose();
				this.Invoke(new MethodInvoker(delegate()
				{
					this.PictureBox2.Hide();
					if (Conversions.ToDouble(str.Split(new char[]
					{
						','
					})[0]) > Conversions.ToDouble(this.ProductVersion))
					{
						this.download_link = str.Split(new char[]
						{
							','
						})[1];
						this.LinkLabel1.Text = "Download μProxy Tool " + str.Split(new char[]
						{
							','
						})[0];
						this.LinkLabel1.Show();
					}
					else
					{
						this.Version_Lbl.Text = "Version: " + this.ProductVersion + " (Latest)";
					}
				}));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00170B60 File Offset: 0x0016EF60
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(this.download_link);
		}

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("About_Lbl")]
		private Label _About_Lbl;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("Desc_Label")]
		private Label _Desc_Label;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("Version_Lbl")]
		private Label _Version_Lbl;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x0400001C RID: 28
		private string download_link;
	}
}
