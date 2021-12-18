using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using B3RAP_Leecher.My;
using B3RAP_Leecher.My.Resources;
using Leaf.xNet;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class Main : Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002E0C File Offset: 0x0000100C
		public Main()
		{
			base.Load += this.Main_Load;
			base.FormClosing += this.Main_FormClosing;
			this.StopThread = false;
			this.AppName = "B3RAP Leecher";
			this.AppVersion = "0.5";
			this.AppCompany = "B3RAP Softwares";
			this.AppAuthor = "ErrupTion_";
			this.UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			this.AppData = this.UserProfile + "\\AppData\\Roaming";
			this.Bin = this.AppData + "\\LeakManiaVPN";
			this.ConfigDir = this.Bin + "\\CONFIG";
			this.HTMLDir = this.Bin + "\\HTML";
			this.OpenVPNDir = this.Bin + "\\OpenVPN";
			this.DirArray = new string[]
			{
				this.Bin,
				this.ConfigDir,
				this.HTMLDir,
				this.OpenVPNDir
			};
			this.PSI = new ProcessStartInfo();
			this.Threads = 150;
			this.UseVPN = false;
			this.Proxies = new List<string>();
			this.UseProxies = false;
			this.InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002F64 File Offset: 0x00001164
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.TextBox2.Clear();
				this.Label3.Text = "None";
				this.Label4.Text = "None";
				this.Label9.Text = "0";
				this.Label10.Text = "0";
				this.Label11.Text = "0";
				this.TextBox1.Enabled = false;
				this.TextBox3.Enabled = false;
				this.Button1.Enabled = false;
				this.Button2.Enabled = true;
				this.Button3.Enabled = false;
				this.Button4.Enabled = false;
				this.Button8.Enabled = false;
				this.Button9.Enabled = false;
				this.StopThread = false;
				this.ScrapThr = new Thread(new ThreadStart(this.GetAccounts));
				this.ScrapThr.Start();
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000030AC File Offset: 0x000012AC
		public void GetAccounts()
		{
			try
			{
				ThreadPool.SetMinThreads(this.Threads, this.Threads);
				ThreadPool.SetMaxThreads(this.Threads, this.Threads);
				this.Timer1.Start();
				foreach (string keyword in this.TextBox1.Lines)
				{
					foreach (string website in this.TextBox3.Lines)
					{
						bool flag = Operators.CompareString(MySettingsProperty.Settings.searchengines, "bing", false) == 0;
						if (flag)
						{
							this.Leech("https://www.bing.com/search?q=", keyword, website);
						}
						else
						{
							bool flag2 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "yahoo", false) == 0;
							if (flag2)
							{
								this.Leech("https://search.yahoo.com/search?q=", keyword, website);
							}
							else
							{
								bool flag3 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "yandex", false) == 0;
								if (flag3)
								{
									this.Leech("https://www.yandex.com/search/?text=", keyword, website);
								}
								else
								{
									bool flag4 = Operators.CompareString(MySettingsProperty.Settings.searchengines, "google", false) == 0;
									if (flag4)
									{
										this.Leech("https://www.google.com/search?q=", keyword, website);
									}
								}
							}
						}
						bool stopThread = this.StopThread;
						if (stopThread)
						{
							return;
						}
					}
					bool stopThread2 = this.StopThread;
					if (stopThread2)
					{
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000327C File Offset: 0x0000147C
		private void Leech(string SearchEngine, string Keyword, string Website)
		{
			checked
			{
				try
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						httpRequest.UserAgent = Http.RandomUserAgent();
						httpRequest.Cookies = new CookieStorage(false, null);
						httpRequest.IgnoreProtocolErrors = true;
						bool useProxies = this.UseProxies;
						if (useProxies)
						{
							bool flag = Operators.CompareString(this.ProxiesType, "HTTP", false) == 0;
							if (flag)
							{
								string text = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
								httpRequest.Proxy = new HttpProxyClient(text.Split(new char[]
								{
									':'
								})[0], int.Parse(text.Split(new char[]
								{
									':'
								})[1]));
								this.Label3.Text = "Using proxy " + text;
							}
							else
							{
								bool flag2 = Operators.CompareString(this.ProxiesType, "SOCKS4", false) == 0;
								if (flag2)
								{
									string text2 = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
									httpRequest.Proxy = new Socks4ProxyClient(text2.Split(new char[]
									{
										':'
									})[0], int.Parse(text2.Split(new char[]
									{
										':'
									})[1]));
									this.Label3.Text = "Using proxy " + text2;
								}
								else
								{
									bool flag3 = Operators.CompareString(this.ProxiesType, "SOCKS5", false) == 0;
									if (flag3)
									{
										string text3 = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
										httpRequest.Proxy = new Socks5ProxyClient(text3.Split(new char[]
										{
											':'
										})[0], int.Parse(text3.Split(new char[]
										{
											':'
										})[1]));
										this.Label3.Text = "Using proxy " + text3;
									}
								}
							}
						}
						else
						{
							httpRequest.Proxy = null;
						}
						this.Label4.Text = Keyword;
						this.Label3.Text = "Getting links...";
						string input = httpRequest.Get(string.Concat(new string[]
						{
							SearchEngine,
							"site:",
							Website,
							"+",
							Keyword
						}), null).ToString();
						MatchCollection matchCollection = new Regex("(https:\\/\\/" + Website + "\\/\\w+)").Matches(input);
						bool flag4 = matchCollection.Count == 0 | matchCollection.Count <= 1 | matchCollection.Count < 1;
						if (flag4)
						{
							this.Label3.Text = "Done!";
						}
						else
						{
							this.TextBox5.Clear();
							int num = matchCollection.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								this.TextBox5.AppendText(matchCollection[i].Value + "\r\n");
								bool stopThread = this.StopThread;
								if (stopThread)
								{
									return;
								}
							}
							string[] source = this.TextBox5.Text.Split(new string[]
							{
								"\r\n"
							}, StringSplitOptions.RemoveEmptyEntries);
							this.TextBox5.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
							this.Label3.Text = string.Concat(new string[]
							{
								"Got ",
								Conversions.ToString(this.TextBox5.Lines.Count<string>()),
								" links from ",
								Website.ToUpper(),
								"."
							});
							int num2 = this.TextBox5.Lines.Count<string>() - 1;
							for (int j = 0; j <= num2; j++)
							{
								using (HttpRequest httpRequest2 = new HttpRequest())
								{
									httpRequest2.UserAgent = Http.RandomUserAgent();
									httpRequest2.Cookies = new CookieStorage(false, null);
									httpRequest2.IgnoreProtocolErrors = true;
									bool useProxies2 = this.UseProxies;
									if (useProxies2)
									{
										bool flag5 = Operators.CompareString(this.ProxiesType, "HTTP", false) == 0;
										if (flag5)
										{
											string text4 = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
											httpRequest2.Proxy = new HttpProxyClient(text4.Split(new char[]
											{
												':'
											})[0], int.Parse(text4.Split(new char[]
											{
												':'
											})[1]));
											this.Label3.Text = "Using proxy " + text4;
										}
										else
										{
											bool flag6 = Operators.CompareString(this.ProxiesType, "SOCKS4", false) == 0;
											if (flag6)
											{
												string text5 = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
												httpRequest2.Proxy = new Socks4ProxyClient(text5.Split(new char[]
												{
													':'
												})[0], int.Parse(text5.Split(new char[]
												{
													':'
												})[1]));
												this.Label3.Text = "Using proxy " + text5;
											}
											else
											{
												bool flag7 = Operators.CompareString(this.ProxiesType, "SOCKS5", false) == 0;
												if (flag7)
												{
													string text6 = this.Proxies[new Random().Next(this.Proxies.Count)].ToString();
													httpRequest2.Proxy = new Socks5ProxyClient(text6.Split(new char[]
													{
														':'
													})[0], int.Parse(text6.Split(new char[]
													{
														':'
													})[1]));
													this.Label3.Text = "Using proxy " + text6;
												}
											}
										}
									}
									else
									{
										httpRequest.Proxy = null;
									}
									string respo = httpRequest.Post(this.TextBox5.Lines[j]).ToString();
									this.AppendResult(respo);
								}
								bool stopThread2 = this.StopThread;
								if (stopThread2)
								{
									break;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ref int ptr = ref this.Errors;
					this.Errors = ptr + 1;
					this.Label9.Text = this.Errors.ToString();
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003940 File Offset: 0x00001B40
		private void AppendResult(string Respo)
		{
			try
			{
				bool flag = Respo.Count<char>() == 0 | Respo.Count<char>() <= 1 | Respo.Count<char>() < 1;
				if (flag)
				{
					this.Label3.Text = "Done!";
				}
				else
				{
					bool flag2 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "emailpass", false) == 0;
					if (flag2)
					{
						try
						{
							foreach (object obj in new Regex("([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5}):([a-zA-Z0-9_\\-\\.]+)").Matches(Respo))
							{
								Match match = (Match)obj;
								this.Label3.Text = "Getting result...";
								this.TextBox2.AppendText(match.Value + "\r\n");
								bool stopThread = this.StopThread;
								if (stopThread)
								{
									break;
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
					else
					{
						bool flag3 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "userpass", false) == 0;
						if (flag3)
						{
							try
							{
								foreach (object obj2 in new Regex("[a-z0-9_-]{3,16}:([a-zA-Z0-9_\\-\\.]+)").Matches(Respo))
								{
									Match match2 = (Match)obj2;
									this.Label3.Text = "Getting result...";
									this.TextBox2.AppendText(match2.Value + "\r\n");
									bool stopThread2 = this.StopThread;
									if (stopThread2)
									{
										break;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						else
						{
							bool flag4 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "proxies", false) == 0;
							if (flag4)
							{
								try
								{
									foreach (object obj3 in new Regex("(\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3})(?=[^\\d])\\s*:?\\s*(\\d{2,5})").Matches(Respo))
									{
										Match match3 = (Match)obj3;
										this.Label3.Text = "Getting result...";
										this.TextBox2.AppendText(match3.Value + "\r\n");
										bool stopThread3 = this.StopThread;
										if (stopThread3)
										{
											break;
										}
									}
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							else
							{
								bool flag5 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "emailonly", false) == 0;
								if (flag5)
								{
									try
									{
										foreach (object obj4 in new Regex("([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})").Matches(Respo))
										{
											Match match4 = (Match)obj4;
											this.Label3.Text = "Getting result...";
											this.TextBox2.AppendText(match4.Value + "\r\n");
											bool stopThread4 = this.StopThread;
											if (stopThread4)
											{
												break;
											}
										}
									}
									finally
									{
										IEnumerator enumerator4;
										if (enumerator4 is IDisposable)
										{
											(enumerator4 as IDisposable).Dispose();
										}
									}
								}
								else
								{
									bool flag6 = Operators.CompareString(MySettingsProperty.Settings.leechoptions, "custom", false) == 0;
									if (flag6)
									{
										try
										{
											foreach (object obj5 in new Regex(MySettingsProperty.Settings.customregex).Matches(Respo))
											{
												Match match5 = (Match)obj5;
												this.Label3.Text = "Getting result...";
												this.TextBox2.AppendText(match5.Value + "\r\n");
												bool stopThread5 = this.StopThread;
												if (stopThread5)
												{
													break;
												}
											}
										}
										finally
										{
											IEnumerator enumerator5;
											if (enumerator5 is IDisposable)
											{
												(enumerator5 as IDisposable).Dispose();
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.Errors;
				this.Errors = checked(ptr + 1);
				this.Label9.Text = this.Errors.ToString();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.SearchEngines.Show();
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003E40 File Offset: 0x00002040
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.LeechOptions.Show();
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003EA8 File Offset: 0x000020A8
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				Interaction.MsgBox(string.Concat(new string[]
				{
					this.AppName,
					" v",
					this.AppVersion,
					" by ",
					this.AppCompany,
					" (",
					this.AppAuthor,
					").\r\nContact me on Discord if you find bugs / need help : \r\nArFiZ_7#5002"
				}), MsgBoxStyle.OkOnly, null);
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003F54 File Offset: 0x00002154
		private void Button5_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string[] source = this.TextBox2.Text.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.RemoveEmptyEntries);
					this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
					this.OneMore = this.AllResult + 1;
					this.Label11.Text = Conversions.ToString(this.OneMore);
					Interaction.MsgBox("Removed duplicates.", MsgBoxStyle.OkOnly, null);
				}
				catch (Exception ex)
				{
					ref int ptr = ref this.ProgErrors;
					this.ProgErrors = ptr + 1;
					this.Label10.Text = this.ProgErrors.ToString();
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000401C File Offset: 0x0000221C
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.AllResult = this.TextBox2.Lines.Count<string>() - 1;
					this.Label11.Text = this.AllResult.ToString();
					bool flag = Operators.CompareString(this.TextBox2.Text, null, false) == 0;
					if (flag)
					{
						this.Button6.Enabled = false;
						this.Button5.Enabled = false;
					}
					else
					{
						this.Button6.Enabled = true;
						this.Button5.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					ref int ptr = ref this.ProgErrors;
					this.ProgErrors = ptr + 1;
					this.Label10.Text = this.ProgErrors.ToString();
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000040F4 File Offset: 0x000022F4
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveFileDialog1.ShowDialog();
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004158 File Offset: 0x00002358
		private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				File.AppendAllText(this.SaveFileDialog1.FileName, this.TextBox2.Text);
				Thread.Sleep(1000);
				Interaction.MsgBox("Sucessfully wrote the result in " + Path.GetFileName(this.SaveFileDialog1.FileName) + ".", MsgBoxStyle.OkOnly, null);
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000041FC File Offset: 0x000023FC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.StopThread = true;
				this.ScrapThr.Abort();
				this.Timer1.Stop();
				this.TextBox1.Enabled = true;
				this.TextBox3.Enabled = true;
				this.Button1.Enabled = true;
				this.Button2.Enabled = false;
				this.Button3.Enabled = true;
				this.Button4.Enabled = true;
				this.Button8.Enabled = true;
				this.Button9.Enabled = true;
				this.Label3.Text = "Stopped.";
				this.Label4.Text = "None";
			}
			catch (Exception ex)
			{
				ref int ptr = ref this.ProgErrors;
				this.ProgErrors = checked(ptr + 1);
				this.Label10.Text = this.ProgErrors.ToString();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000042FC File Offset: 0x000024FC
		private void Main_Load(object sender, EventArgs e)
		{
			this.Text = string.Concat(new string[]
			{
				this.AppName,
				" v",
				this.AppVersion,
				" | ",
				this.AppCompany.ToUpper()
			});
			this.Label1.Text = "Keywords (" + Conversions.ToString(this.TextBox1.Lines.Count<string>()) + ") :";
			this.Label6.Text = "Paste Sites (" + Conversions.ToString(this.TextBox3.Lines.Count<string>()) + ") :";
			this.PSI.CreateNoWindow = true;
			this.PSI.UseShellExecute = false;
			this.PSI.FileName = this.OpenVPNDir + "\\openvpn.exe";
			this.OpenVPNConsoleEncoding = Encoding.GetEncoding(866);
			foreach (string path in this.DirArray)
			{
				bool flag = !Directory.Exists(path);
				if (flag)
				{
					Directory.CreateDirectory(path);
				}
			}
			bool flag2 = !File.Exists(this.OpenVPNDir + "\\libcrypto-1_1-x64.dll");
			if (flag2)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\libcrypto-1_1-x64.dll", Resources.libcrypto_1_1_x64);
			}
			bool flag3 = !File.Exists(this.OpenVPNDir + "\\liblzo2-2.dll");
			if (flag3)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\liblzo2-2.dll", Resources.liblzo2_2);
			}
			bool flag4 = !File.Exists(this.OpenVPNDir + "\\libpkcs11-helper-1.dll");
			if (flag4)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\libpkcs11-helper-1.dll", Resources.libpkcs11_helper_1);
			}
			bool flag5 = !File.Exists(this.OpenVPNDir + "\\libssl-1_1-x64.dll");
			if (flag5)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\libssl-1_1-x64.dll", Resources.libssl_1_1_x64);
			}
			bool flag6 = !File.Exists(this.OpenVPNDir + "\\openssl.exe");
			if (flag6)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\openssl.exe", Resources.openssl);
			}
			bool flag7 = !File.Exists(this.OpenVPNDir + "\\openvpn.exe");
			if (flag7)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\openvpn.exe", Resources.openvpn);
			}
			bool flag8 = !File.Exists(this.OpenVPNDir + "\\openvpnserv.exe");
			if (flag8)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\openvpnserv.exe", Resources.openvpnserv);
			}
			bool flag9 = !File.Exists(this.OpenVPNDir + "\\openvpnserv2.exe");
			if (flag9)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\openvpnserv2.exe", Resources.openvpnserv2);
			}
			bool flag10 = !File.Exists(this.OpenVPNDir + "\\tap-windows.exe");
			if (flag10)
			{
				File.WriteAllBytes(this.OpenVPNDir + "\\tap-windows.exe", Resources.tap_windows);
			}
			bool flag11 = !File.Exists(this.ConfigDir + "\\LeakMania-NL.ovpn");
			if (flag11)
			{
				File.WriteAllBytes(this.ConfigDir + "\\LeakMania-NL.ovpn", Resources.LeakMania_NL);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004676 File Offset: 0x00002876
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.Label1.Text = "Keywords (" + Conversions.ToString(this.TextBox1.Lines.Count<string>()) + ") :";
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000046A9 File Offset: 0x000028A9
		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			this.Label6.Text = "Paste Sites (" + Conversions.ToString(this.TextBox3.Lines.Count<string>()) + ") :";
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000046DC File Offset: 0x000028DC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("openvpn"))
			{
				process.Kill();
				process.WaitForExit();
			}
			ProjectData.EndApp();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004720 File Offset: 0x00002920
		private void Button8_Click(object sender, EventArgs e)
		{
			MyProject.Forms.MoreOptions.Show();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004733 File Offset: 0x00002933
		private void Timer1_Tick(object sender, EventArgs e)
		{
			ThreadPool.SetMinThreads(this.Threads, this.Threads);
			ThreadPool.SetMaxThreads(this.Threads, this.Threads);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000475C File Offset: 0x0000295C
		private void Button9_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(this.Tester));
			thread.Start();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004784 File Offset: 0x00002984
		private void Tester()
		{
			int num = 0;
			this.Button9.Enabled = false;
			checked
			{
				foreach (string str in this.TextBox3.Lines)
				{
					try
					{
						string text = new WebClient().DownloadString("http://" + str);
						num++;
						this.Button9.Text = string.Concat(new string[]
						{
							"Test (",
							Conversions.ToString(num),
							"/",
							Conversions.ToString(this.TextBox3.Lines.Count<string>()),
							")"
						});
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("Invalid website : " + str, MsgBoxStyle.OkOnly, null);
					}
				}
				this.Button9.Enabled = true;
				this.Button9.Text = "Test";
				Interaction.MsgBox("Finished testing paste sites!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005F62 File Offset: 0x00004162
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00005F6C File Offset: 0x0000416C
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005FAF File Offset: 0x000041AF
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00005FBC File Offset: 0x000041BC
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005FFF File Offset: 0x000041FF
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00006009 File Offset: 0x00004209
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00006012 File Offset: 0x00004212
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000601C File Offset: 0x0000421C
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006025 File Offset: 0x00004225
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000602F File Offset: 0x0000422F
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006038 File Offset: 0x00004238
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00006042 File Offset: 0x00004242
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000604B File Offset: 0x0000424B
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00006055 File Offset: 0x00004255
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000605E File Offset: 0x0000425E
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00006068 File Offset: 0x00004268
		internal virtual TextBox TextBox2
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox2_TextChanged);
				TextBox textBox = this._TextBox2;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this._TextBox2 = value;
				textBox = this._TextBox2;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000060AB File Offset: 0x000042AB
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000060B5 File Offset: 0x000042B5
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000060BE File Offset: 0x000042BE
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000060C8 File Offset: 0x000042C8
		internal virtual TextBox TextBox3
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox3_TextChanged);
				TextBox textBox = this._TextBox3;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this._TextBox3 = value;
				textBox = this._TextBox3;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000610B File Offset: 0x0000430B
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00006118 File Offset: 0x00004318
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000615B File Offset: 0x0000435B
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00006168 File Offset: 0x00004368
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000061AB File Offset: 0x000043AB
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000061B8 File Offset: 0x000043B8
		internal virtual Button Button4
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000061FB File Offset: 0x000043FB
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00006208 File Offset: 0x00004408
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000624B File Offset: 0x0000444B
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00006258 File Offset: 0x00004458
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000629B File Offset: 0x0000449B
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000062A8 File Offset: 0x000044A8
		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Button7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button7_Click);
				Button button = this._Button7;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button7 = value;
				button = this._Button7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000062EB File Offset: 0x000044EB
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000062F8 File Offset: 0x000044F8
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return this._SaveFileDialog1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.SaveFileDialog1_FileOk);
				SaveFileDialog saveFileDialog = this._SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= value2;
				}
				this._SaveFileDialog1 = value;
				saveFileDialog = this._SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk += value2;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000633B File Offset: 0x0000453B
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00006345 File Offset: 0x00004545
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000634E File Offset: 0x0000454E
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00006358 File Offset: 0x00004558
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00006361 File Offset: 0x00004561
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000636B File Offset: 0x0000456B
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006374 File Offset: 0x00004574
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000637E File Offset: 0x0000457E
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00006387 File Offset: 0x00004587
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00006391 File Offset: 0x00004591
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000639A File Offset: 0x0000459A
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000063A4 File Offset: 0x000045A4
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000063AD File Offset: 0x000045AD
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000063B7 File Offset: 0x000045B7
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000063CA File Offset: 0x000045CA
		internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000063D3 File Offset: 0x000045D3
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000063DD File Offset: 0x000045DD
		internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000063E6 File Offset: 0x000045E6
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000063F0 File Offset: 0x000045F0
		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006433 File Offset: 0x00004633
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00006440 File Offset: 0x00004640
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006483 File Offset: 0x00004683
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00006490 File Offset: 0x00004690
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				System.Windows.Forms.Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x04000012 RID: 18
		private int Errors;

		// Token: 0x04000013 RID: 19
		private int ProgErrors;

		// Token: 0x04000014 RID: 20
		private int AllResult;

		// Token: 0x04000015 RID: 21
		private int OneMore;

		// Token: 0x04000016 RID: 22
		private bool StopThread;

		// Token: 0x04000017 RID: 23
		private string AppName;

		// Token: 0x04000018 RID: 24
		private string AppVersion;

		// Token: 0x04000019 RID: 25
		private string AppCompany;

		// Token: 0x0400001A RID: 26
		private string AppAuthor;

		// Token: 0x0400001B RID: 27
		private Thread ScrapThr;

		// Token: 0x0400001C RID: 28
		public string UserProfile;

		// Token: 0x0400001D RID: 29
		public string AppData;

		// Token: 0x0400001E RID: 30
		public string Bin;

		// Token: 0x0400001F RID: 31
		public string ConfigDir;

		// Token: 0x04000020 RID: 32
		public string HTMLDir;

		// Token: 0x04000021 RID: 33
		public string OpenVPNDir;

		// Token: 0x04000022 RID: 34
		public string[] DirArray;

		// Token: 0x04000023 RID: 35
		public ProcessStartInfo PSI;

		// Token: 0x04000024 RID: 36
		public Process OpenVPNConsoleProcess;

		// Token: 0x04000025 RID: 37
		public Encoding OpenVPNConsoleEncoding;

		// Token: 0x04000026 RID: 38
		public int Threads;

		// Token: 0x04000027 RID: 39
		public bool UseVPN;

		// Token: 0x04000028 RID: 40
		public List<string> Proxies;

		// Token: 0x04000029 RID: 41
		public string ProxiesType;

		// Token: 0x0400002A RID: 42
		public bool UseProxies;
	}
}
