using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x0200000C RID: 12
	[OptionText]
	[DesignerGenerated]
	public partial class Export : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0017102C File Offset: 0x0016F42C
		public Export()
		{
			base.Load += this.Export_Load;
			this.proxies_list = new HashSet<string>();
			this.lv = new ListView();
			this.InitializeComponent();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00171828 File Offset: 0x0016FC28
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0017183C File Offset: 0x0016FC3C
		internal virtual CheckBox CheckBox1
		{
			get
			{
				return this._CheckBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00171848 File Offset: 0x0016FC48
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0017185C File Offset: 0x0016FC5C
		internal virtual CheckBox CheckBox2
		{
			get
			{
				return this._CheckBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox2 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00171868 File Offset: 0x0016FC68
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0017187C File Offset: 0x0016FC7C
		internal virtual CheckBox CheckBox3
		{
			get
			{
				return this._CheckBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox3 = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00171888 File Offset: 0x0016FC88
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0017189C File Offset: 0x0016FC9C
		internal virtual CheckBox CheckBox4
		{
			get
			{
				return this._CheckBox4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox4_CheckedChanged);
				if (this._CheckBox4 != null)
				{
					this._CheckBox4.CheckedChanged -= value2;
				}
				this._CheckBox4 = value;
				if (this._CheckBox4 != null)
				{
					this._CheckBox4.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x001718E8 File Offset: 0x0016FCE8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x001718FC File Offset: 0x0016FCFC
		internal virtual CheckedListBox CheckedListBox1
		{
			get
			{
				return this._CheckedListBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckedListBox1 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00171908 File Offset: 0x0016FD08
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0017191C File Offset: 0x0016FD1C
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00171928 File Offset: 0x0016FD28
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0017193C File Offset: 0x0016FD3C
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00171948 File Offset: 0x0016FD48
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0017195C File Offset: 0x0016FD5C
		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00171968 File Offset: 0x0016FD68
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0017197C File Offset: 0x0016FD7C
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005D RID: 93 RVA: 0x001719C8 File Offset: 0x0016FDC8
		// (set) Token: 0x0600005E RID: 94 RVA: 0x001719DC File Offset: 0x0016FDDC
		internal virtual GroupBox GroupBox4
		{
			get
			{
				return this._GroupBox4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x001719E8 File Offset: 0x0016FDE8
		// (set) Token: 0x06000060 RID: 96 RVA: 0x001719FC File Offset: 0x0016FDFC
		internal virtual CheckBox CheckBox5
		{
			get
			{
				return this._CheckBox5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox5 = value;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00171A08 File Offset: 0x0016FE08
		private void CheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckedListBox1.Enabled = this.CheckBox4.Checked;
			if (this.CheckBox4.Enabled)
			{
				this.showcountry();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00171A34 File Offset: 0x0016FE34
		public void showcountry()
		{
			try
			{
				this.CheckedListBox1.Items.Clear();
				try
				{
					foreach (object obj in this.lv.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (!this.CheckedListBox1.Items.Contains(listViewItem.SubItems[2].Text))
						{
							this.CheckedListBox1.Items.Add(listViewItem.SubItems[2].Text);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00171B00 File Offset: 0x0016FF00
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.proxies_list.Clear();
					this.@bool = new bool[]
					{
						this.CheckBox1.Checked,
						this.CheckBox2.Checked,
						this.CheckBox3.Checked,
						this.CheckBox4.Checked,
						this.CheckBox5.Checked
					};
					try
					{
						foreach (object obj in this.lv.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							if (this.@bool[0] && Operators.CompareString(listViewItem.SubItems[3].Text, "Elite", true) == 0)
							{
								if (this.@bool[3])
								{
									int num = 0;
									int num2 = this.CheckedListBox1.Items.Count - 1;
									for (int i = num; i <= num2; i++)
									{
										if (Operators.CompareString(this.CheckedListBox1.Items[i].ToString(), listViewItem.SubItems[2].Text, true) == 0 && this.CheckedListBox1.GetItemChecked(i))
										{
											if (this.@bool[4])
											{
												if (Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
												{
													this.proxies_list.Add(listViewItem.SubItems[1].Text);
												}
											}
											else
											{
												this.proxies_list.Add(listViewItem.SubItems[1].Text);
											}
										}
									}
								}
								else if (this.@bool[4])
								{
									if (Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
									{
										this.proxies_list.Add(listViewItem.SubItems[1].Text);
									}
								}
								else
								{
									this.proxies_list.Add(listViewItem.SubItems[1].Text);
								}
							}
							if (this.@bool[1] && Operators.CompareString(listViewItem.SubItems[3].Text, "Anonymous", true) == 0)
							{
								if (this.@bool[3])
								{
									int num3 = 0;
									int num4 = this.CheckedListBox1.Items.Count - 1;
									for (int j = num3; j <= num4; j++)
									{
										if (Operators.CompareString(this.CheckedListBox1.Items[j].ToString(), listViewItem.SubItems[2].Text, true) == 0 && this.CheckedListBox1.GetItemChecked(j))
										{
											if (this.@bool[4])
											{
												if (Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
												{
													this.proxies_list.Add(listViewItem.SubItems[1].Text);
												}
											}
											else
											{
												this.proxies_list.Add(listViewItem.SubItems[1].Text);
											}
										}
									}
								}
								else if (this.@bool[4] && Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
								{
									this.proxies_list.Add(listViewItem.SubItems[1].Text);
								}
							}
							if (this.@bool[2] && Operators.CompareString(listViewItem.SubItems[3].Text, "Transparent", true) == 0)
							{
								if (this.@bool[3])
								{
									int num5 = 0;
									int num6 = this.CheckedListBox1.Items.Count - 1;
									for (int k = num5; k <= num6; k++)
									{
										if (Operators.ConditionalCompareObjectEqual(this.CheckedListBox1.Items[k], listViewItem.SubItems[2].Text, true) && this.CheckedListBox1.GetItemChecked(k))
										{
											if (this.@bool[4])
											{
												if (Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
												{
													this.proxies_list.Add(listViewItem.SubItems[1].Text);
												}
											}
											else
											{
												this.proxies_list.Add(listViewItem.SubItems[1].Text);
											}
										}
									}
								}
								else if (this.@bool[4])
								{
									if (Operators.CompareString(listViewItem.SubItems[4].Text, "True", true) == 0)
									{
										this.proxies_list.Add(listViewItem.SubItems[1].Text);
									}
								}
								else
								{
									this.proxies_list.Add(listViewItem.SubItems[1].Text);
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.Close();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00172028 File Offset: 0x00170428
		private void Export_Load(object sender, EventArgs e)
		{
			this.CheckedListBox1.Enabled = this.CheckBox4.Checked;
			if (this.CheckBox4.Enabled)
			{
				this.showcountry();
			}
		}

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("CheckBox4")]
		private CheckBox _CheckBox4;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("CheckedListBox1")]
		private CheckedListBox _CheckedListBox1;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("CheckBox5")]
		private CheckBox _CheckBox5;

		// Token: 0x04000029 RID: 41
		private bool[] @bool;

		// Token: 0x0400002A RID: 42
		public HashSet<string> proxies_list;

		// Token: 0x0400002B RID: 43
		public ListView lv;
	}
}
