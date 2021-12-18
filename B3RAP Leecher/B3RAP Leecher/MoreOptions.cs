using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using B3RAP_Leecher.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class MoreOptions : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000064D3 File Offset: 0x000046D3
		public MoreOptions()
		{
			base.FormClosing += this.MoreOptions_FormClosing;
			base.Load += this.MoreOptions_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00006B79 File Offset: 0x00004D79
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00006B84 File Offset: 0x00004D84
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00006BC7 File Offset: 0x00004DC7
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00006BD1 File Offset: 0x00004DD1
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00006BDA File Offset: 0x00004DDA
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00006BE4 File Offset: 0x00004DE4
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006BED File Offset: 0x00004DED
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00006BF8 File Offset: 0x00004DF8
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006C3B File Offset: 0x00004E3B
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00006C48 File Offset: 0x00004E48
		internal virtual Button Button9
		{
			[CompilerGenerated]
			get
			{
				return this._Button9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button9_Click);
				Button button = this._Button9;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button9 = value;
				button = this._Button9;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006C8B File Offset: 0x00004E8B
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00006C98 File Offset: 0x00004E98
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return this._OpenFileDialog1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.OpenFileDialog1_FileOk);
				OpenFileDialog openFileDialog = this._OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				this._OpenFileDialog1 = value;
				openFileDialog = this._OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006CDB File Offset: 0x00004EDB
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00006CE5 File Offset: 0x00004EE5
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000096 RID: 150 RVA: 0x00006CF0 File Offset: 0x00004EF0
		private void MoreOptions_FormClosing(object sender, FormClosingEventArgs e)
		{
			MyProject.Forms.Main.Threads = int.Parse(Conversions.ToString(this.NumericUpDown1.Value));
			bool flag = this.ComboBox1.SelectedIndex == 0;
			if (flag)
			{
				MyProject.Forms.Main.ProxiesType = "HTTP";
			}
			else
			{
				bool flag2 = this.ComboBox1.SelectedIndex == 1;
				if (flag2)
				{
					MyProject.Forms.Main.ProxiesType = "SOCKS4";
				}
				else
				{
					bool flag3 = this.ComboBox1.SelectedIndex == 2;
					if (flag3)
					{
						MyProject.Forms.Main.ProxiesType = "SOCKS5";
					}
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006D9C File Offset: 0x00004F9C
		private void Connect()
		{
			string arguments = "--config " + MyProject.Forms.Main.ConfigDir + "\\LeakMania-NL.ovpn";
			MyProject.Forms.Main.PSI.Arguments = arguments;
			MyProject.Forms.Main.PSI.RedirectStandardInput = true;
			MyProject.Forms.Main.PSI.RedirectStandardError = true;
			MyProject.Forms.Main.PSI.StandardErrorEncoding = MyProject.Forms.Main.OpenVPNConsoleEncoding;
			MyProject.Forms.Main.PSI.RedirectStandardOutput = true;
			MyProject.Forms.Main.PSI.StandardOutputEncoding = MyProject.Forms.Main.OpenVPNConsoleEncoding;
			try
			{
				MyProject.Forms.Main.OpenVPNConsoleProcess = Process.Start(MyProject.Forms.Main.PSI);
				MyProject.Forms.Main.OpenVPNConsoleProcess.OutputDataReceived += this.OutputDataReceived;
				MyProject.Forms.Main.OpenVPNConsoleProcess.ErrorDataReceived += this.OutputDataReceived;
				MyProject.Forms.Main.OpenVPNConsoleProcess.BeginOutputReadLine();
				MyProject.Forms.Main.OpenVPNConsoleProcess.BeginErrorReadLine();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("ERROR : CAN NOT CONNECT TO THE VPN.", MsgBoxStyle.Exclamation, null);
				return;
			}
			List<string> list = new List<string>();
			foreach (Process process in Process.GetProcesses())
			{
				list.Add(process.ProcessName);
			}
			bool flag = !list.Contains("openvpn");
			if (flag)
			{
				Interaction.MsgBox("ERROR : PROCESS OPENVPN.EXE NOT FOUND.", MsgBoxStyle.Exclamation, null);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006F88 File Offset: 0x00005188
		private void Disconnect()
		{
			try
			{
				foreach (Process process in Process.GetProcessesByName("openvpn"))
				{
					process.Kill();
					process.WaitForExit();
				}
				MyProject.Forms.Main.UseVPN = false;
				Interaction.MsgBox("Disconnected.", MsgBoxStyle.OkOnly, null);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007008 File Offset: 0x00005208
		private void OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			base.Invoke(new Action<object>(this.ThreadProcSetter), new object[]
			{
				e.Data
			});
			bool flag = e.Data.ToString().Contains("Initialization Sequence Completed") & Operators.CompareString(e.Data.ToString(), null, false) != 0;
			if (flag)
			{
				MyProject.Forms.Main.UseVPN = true;
				Interaction.MsgBox("Connected.", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007088 File Offset: 0x00005288
		private void ThreadProcSetter(object text)
		{
			MyProject.Forms.Main.TextBox4.AppendText((string)text + "\r\n");
			MyProject.Forms.Main.TextBox4.SelectionStart = MyProject.Forms.Main.TextBox4.TextLength;
			MyProject.Forms.Main.TextBox4.ScrollToCaret();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000070FC File Offset: 0x000052FC
		private void MoreOptions_Load(object sender, EventArgs e)
		{
			this.NumericUpDown1.Value = decimal.Parse(Conversions.ToString(MyProject.Forms.Main.Threads));
			this.ComboBox1.SelectedIndex = 0;
			bool useVPN = MyProject.Forms.Main.UseVPN;
			if (useVPN)
			{
				this.CheckBox1.Checked = true;
			}
			else
			{
				this.CheckBox1.Checked = false;
			}
			bool useProxies = MyProject.Forms.Main.UseProxies;
			if (useProxies)
			{
				this.CheckBox2.Checked = true;
			}
			else
			{
				this.CheckBox2.Checked = false;
			}
			bool flag = Operators.CompareString(MyProject.Forms.Main.ProxiesType, "HTTP", false) == 0;
			if (flag)
			{
				this.ComboBox1.SelectedIndex = 0;
			}
			else
			{
				bool flag2 = Operators.CompareString(MyProject.Forms.Main.ProxiesType, "SOCKS4", false) == 0;
				if (flag2)
				{
					this.ComboBox1.SelectedIndex = 1;
				}
				else
				{
					bool flag3 = Operators.CompareString(MyProject.Forms.Main.ProxiesType, "SOCKS5", false) == 0;
					if (flag3)
					{
						this.ComboBox1.SelectedIndex = 2;
					}
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007234 File Offset: 0x00005434
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				MsgBoxResult msgBoxResult = Interaction.MsgBox("You must've installed the TAP driver to use the VPN. If you didn't install it, click Yes. If you already installed it, click No.", MsgBoxStyle.YesNo, "Confirmation");
				bool flag = msgBoxResult == MsgBoxResult.Yes;
				if (flag)
				{
					this.CheckBox1.Checked = false;
					try
					{
						Process.Start(MyProject.Forms.Main.OpenVPNDir + "\\tap-windows.exe");
					}
					catch (Exception ex)
					{
					}
				}
				else
				{
					bool flag2 = msgBoxResult == MsgBoxResult.No;
					if (flag2)
					{
						this.Connect();
					}
				}
			}
			else
			{
				this.Disconnect();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000072DC File Offset: 0x000054DC
		private void Button9_Click(object sender, EventArgs e)
		{
			this.OpenFileDialog1.ShowDialog();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000072EC File Offset: 0x000054EC
		private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			foreach (string item in File.ReadAllLines(this.OpenFileDialog1.FileName))
			{
				MyProject.Forms.Main.Proxies.Add(item);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007338 File Offset: 0x00005538
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				this.Button9.Enabled = true;
				this.ComboBox1.Enabled = true;
				MyProject.Forms.Main.UseProxies = true;
			}
			else
			{
				this.Button9.Enabled = false;
				this.ComboBox1.Enabled = false;
				MyProject.Forms.Main.UseProxies = false;
			}
		}
	}
}
