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
using Joker_Combo_Leecher__v1._0_.My;
using Leaf.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SkinSoft.VisualStyler;
using SkinSoft.VisualStyler.Licensing;
using xNet;

namespace Joker_Combo_Leecher__v1._0_
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000029D4 File Offset: 0x00000BD4
		public Form1()
		{
			base.FormClosing += this.Form1_FormClosing;
			this.searchTime = string.Empty;
			this.domain = new string[]
			{
				".com",
				".ac",
				".ad",
				".bj",
				".cc"
			};
			this.regexc = new string[]
			{
				"([\\w+]{3,10}\\:[\\w+]{3,10})",
				"[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}",
				"(\\d{16,16}\\|\\d{2,2}\\|\\d{2,4}\\|\\d{3,3})"
			};
			this.random = new Random();
			this.reggex = string.Empty;
			this.results = string.Empty;
			this.InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
			base.MaximizeBox = false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021BE File Offset: 0x000003BE
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002A98 File Offset: 0x00000C98
		private void GoogleSearcher()
		{
			checked
			{
				try
				{
					foreach (string text in this.TextBox1.Lines)
					{
						using (xNet.HttpRequest httpRequest = new xNet.HttpRequest())
						{
							int num = Conversions.ToInteger(Convert.ToString(this.random.Next(0, 4)));
							string text2 = this.domain[num];
							httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
							httpRequest.KeepAlive = true;
							httpRequest.Cookies = new CookieDictionary(false);
							string input = httpRequest.Get(string.Concat(new string[]
							{
								"https://www.google",
								text2,
								"/search?q=",
								text,
								"&num=100&tbs=qdr:",
								this.searchTime,
								"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
								Conversions.ToString(22),
								"&sa=N&biw=1366&bih=604"
							}), null).ToString();
							MatchCollection matchCollection = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})\\/\\w+").Matches(input);
							StringBuilder stringBuilder = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj in matchCollection)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(obj);
										stringBuilder.AppendLine(((Match)objectValue).ToString());
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
							finally
							{
								IEnumerator enumerator2;
								bool flag = enumerator2 is IDisposable;
								if (flag)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
							}
							MatchCollection matchCollection2 = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})\\/\\w+").Matches(input);
							StringBuilder stringBuilder2 = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj2 in matchCollection)
									{
										object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
										stringBuilder2.AppendLine(((Match)objectValue2).ToString());
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
							finally
							{
								IEnumerator enumerator4;
								bool flag2 = enumerator4 is IDisposable;
								if (flag2)
								{
									(enumerator4 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
							}
						}
					}
					string[] source = this.TextBox2.Text.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					int length = this.TextBox2.Text.Length;
					int num2 = source.Distinct<string>().Count<string>();
					int num3 = length - num2;
					this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
				}
				catch (Exception ex)
				{
					this.method_1();
					foreach (string text3 in this.TextBox1.Lines)
					{
						using (xNet.HttpRequest httpRequest2 = new xNet.HttpRequest())
						{
							int num4 = Conversions.ToInteger(Convert.ToString(this.random.Next(0, 4)));
							string text4 = this.domain[num4];
							httpRequest2.UserAgent = Leaf.Net.Http.RandomUserAgent();
							httpRequest2.KeepAlive = true;
							httpRequest2.Cookies = new CookieDictionary(false);
							string input2 = httpRequest2.Get(string.Concat(new string[]
							{
								"https://www.bing.com/search?q=",
								text3,
								"&num=100&tbs=qdr:",
								this.searchTime,
								"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
								Conversions.ToString(22),
								"&sa=N&biw=1366&bih=604"
							}), null).ToString();
							MatchCollection matchCollection3 = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})\\/\\w+").Matches(input2);
							StringBuilder stringBuilder3 = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj3 in matchCollection3)
									{
										object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
										stringBuilder3.AppendLine(((Match)objectValue3).ToString());
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
							finally
							{
								IEnumerator enumerator6;
								bool flag3 = enumerator6 is IDisposable;
								if (flag3)
								{
									(enumerator6 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder3.ToString();
							}
							MatchCollection matchCollection4 = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})\\/\\w+").Matches(input2);
							StringBuilder stringBuilder4 = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj4 in matchCollection3)
									{
										object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
										stringBuilder4.AppendLine(((Match)objectValue4).ToString());
									}
								}
								finally
								{
									IEnumerator enumerator7;
									if (enumerator7 is IDisposable)
									{
										(enumerator7 as IDisposable).Dispose();
									}
								}
							}
							finally
							{
								IEnumerator enumerator8;
								bool flag4 = enumerator8 is IDisposable;
								if (flag4)
								{
									(enumerator8 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder4.ToString();
							}
						}
					}
					string[] source2 = this.TextBox2.Text.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					int length2 = this.TextBox2.Text.Length;
					int num5 = source2.Distinct<string>().Count<string>();
					int num6 = length2 - num5;
					this.TextBox2.Text = string.Join("\r\n", source2.Distinct<string>().ToArray<string>());
				}
				this.method_2();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003158 File Offset: 0x00001358
		private void pastebinSearcher()
		{
			checked
			{
				try
				{
					foreach (string text in this.TextBox1.Lines)
					{
						using (xNet.HttpRequest httpRequest = new xNet.HttpRequest())
						{
							int num = Conversions.ToInteger(Convert.ToString(this.random.Next(0, 4)));
							string text2 = this.domain[num];
							httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
							httpRequest.KeepAlive = true;
							httpRequest.Cookies = new CookieDictionary(false);
							string input = httpRequest.Get(string.Concat(new string[]
							{
								"https://www.google",
								text2,
								"/search?q=site:pastebin.com+",
								text,
								"&num=100&tbs=qdr:",
								this.searchTime,
								"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
								Conversions.ToString(22),
								"&sa=N&biw=1366&bih=604"
							}), null).ToString();
							MatchCollection matchCollection = new Regex("(https:\\/\\/pastebin.com\\/\\w+)").Matches(input);
							StringBuilder stringBuilder = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj in matchCollection)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(obj);
										stringBuilder.AppendLine(((Match)objectValue).ToString());
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
							finally
							{
								IEnumerator enumerator2;
								bool flag = enumerator2 is IDisposable;
								if (flag)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
							}
							MatchCollection matchCollection2 = new Regex("(https:\\/\\/pastebin.com\\/\\w+)").Matches(input);
							StringBuilder stringBuilder2 = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj2 in matchCollection)
									{
										object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
										stringBuilder2.AppendLine(((Match)objectValue2).ToString());
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
							finally
							{
								IEnumerator enumerator4;
								bool flag2 = enumerator4 is IDisposable;
								if (flag2)
								{
									(enumerator4 as IDisposable).Dispose();
								}
								this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
							}
						}
					}
					string[] source = this.TextBox2.Text.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					int length = this.TextBox2.Text.Length;
					int num2 = source.Distinct<string>().Count<string>();
					int num3 = length - num2;
					this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
				}
				catch (Exception ex)
				{
					try
					{
						foreach (string text3 in this.TextBox1.Lines)
						{
							using (xNet.HttpRequest httpRequest2 = new xNet.HttpRequest())
							{
								httpRequest2.UserAgent = Leaf.Net.Http.RandomUserAgent();
								httpRequest2.KeepAlive = true;
								httpRequest2.Cookies = new CookieDictionary(false);
								string input2 = httpRequest2.Get(string.Concat(new string[]
								{
									"https://www.bing.com/search?q=site:pastebin.com+",
									text3,
									"&num=100&tbs=qdr:",
									this.searchTime,
									"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start="
								}), null).ToString();
								MatchCollection matchCollection3 = new Regex("(https:\\/\\/pastebin.com\\/\\w+)").Matches(input2);
								StringBuilder stringBuilder3 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj3 in matchCollection3)
										{
											object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
											stringBuilder3.AppendLine(((Match)objectValue3).ToString());
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
								finally
								{
									IEnumerator enumerator6;
									bool flag3 = enumerator6 is IDisposable;
									if (flag3)
									{
										(enumerator6 as IDisposable).Dispose();
									}
									this.TextBox2.Text = this.TextBox2.Text + stringBuilder3.ToString();
								}
								MatchCollection matchCollection4 = new Regex("(https:\\/\\/pastebin.com\\/\\w+)").Matches(input2);
								StringBuilder stringBuilder4 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj4 in matchCollection3)
										{
											object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
											stringBuilder4.AppendLine(((Match)objectValue4).ToString());
										}
									}
									finally
									{
										IEnumerator enumerator7;
										if (enumerator7 is IDisposable)
										{
											(enumerator7 as IDisposable).Dispose();
										}
									}
								}
								finally
								{
									IEnumerator enumerator8;
									bool flag4 = enumerator8 is IDisposable;
									if (flag4)
									{
										(enumerator8 as IDisposable).Dispose();
									}
									this.TextBox2.Text = this.TextBox2.Text + stringBuilder4.ToString();
								}
							}
						}
						string[] source2 = this.TextBox2.Text.Split(new string[]
						{
							"\r\n"
						}, StringSplitOptions.None);
						int length2 = this.TextBox2.Text.Length;
						int num4 = source2.Distinct<string>().Count<string>();
						int num5 = length2 - num4;
						this.TextBox2.Text = string.Join("\r\n", source2.Distinct<string>().ToArray<string>());
					}
					catch (Exception ex2)
					{
						this.method_1();
					}
				}
				this.method_2();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000380C File Offset: 0x00001A0C
		private void searcher_forum1()
		{
			try
			{
				foreach (string str in this.TextBox1.Lines)
				{
					using (Leaf.Net.HttpRequest httpRequest = new Leaf.Net.HttpRequest())
					{
						httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest.KeepAlive = true;
						httpRequest.Cookies = new CookieStorage(false, null);
						string input = httpRequest.Get("https://crackia.com/search/?q=" + str, null).ToString();
						MatchCollection matchCollection = new Regex("\\<a href='(.*?)\\/\\?(.*?)' data-linkType=\"link\" data-searchable\\>").Matches(input);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									stringBuilder.AppendLine(((Match)objectValue).Groups[1].Value);
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
						finally
						{
							IEnumerator enumerator2;
							bool flag = enumerator2 is IDisposable;
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
						}
						MatchCollection matchCollection2 = new Regex("\\<a href='(.*?)\\/\\?(.*?)' data-linkType=\"link\" data-searchable\\>").Matches(input);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									stringBuilder2.AppendLine(((Match)objectValue2).Groups[1].Value);
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
						finally
						{
							IEnumerator enumerator4;
							bool flag2 = enumerator4 is IDisposable;
							if (flag2)
							{
								(enumerator4 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
						}
					}
				}
				string[] source = this.TextBox2.Text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				int length = this.TextBox2.Text.Length;
				int num = source.Distinct<string>().Count<string>();
				int num2 = checked(length - num);
				this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
			}
			catch (Exception ex)
			{
				this.method_1();
			}
			this.method_2();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003B40 File Offset: 0x00001D40
		private void searcher_forum2()
		{
			try
			{
				foreach (string str in this.TextBox1.Lines)
				{
					using (Leaf.Net.HttpRequest httpRequest = new Leaf.Net.HttpRequest())
					{
						httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest.KeepAlive = true;
						httpRequest.Cookies = new CookieStorage(false, null);
						string input = httpRequest.Get("https://crackians.com/search/?q=" + str, null).ToString();
						MatchCollection matchCollection = new Regex("\\<a href='(.*?)\\/\\?(.*?)' data-linkType=\"link\" data-searchable\\>").Matches(input);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									stringBuilder.AppendLine(((Match)objectValue).Groups[1].Value);
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
						finally
						{
							IEnumerator enumerator2;
							bool flag = enumerator2 is IDisposable;
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
						}
						MatchCollection matchCollection2 = new Regex("\\<a href='(.*?)\\/\\?(.*?)' data-linkType=\"link\" data-searchable\\>").Matches(input);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									stringBuilder2.AppendLine(((Match)objectValue2).Groups[1].Value);
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
						finally
						{
							IEnumerator enumerator4;
							bool flag2 = enumerator4 is IDisposable;
							if (flag2)
							{
								(enumerator4 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
						}
					}
				}
				string[] source = this.TextBox2.Text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				int length = this.TextBox2.Text.Length;
				int num = source.Distinct<string>().Count<string>();
				int num2 = checked(length - num);
				this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
			}
			catch (Exception ex)
			{
				this.method_1();
			}
			this.method_2();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003E74 File Offset: 0x00002074
		private void searcher_forum3()
		{
			try
			{
				foreach (string str in this.TextBox1.Lines)
				{
					using (Leaf.Net.HttpRequest httpRequest = new Leaf.Net.HttpRequest())
					{
						httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest.KeepAlive = true;
						httpRequest.Cookies = new CookieStorage(false, null);
						string input = httpRequest.Get("https://hqcombo.com/search/11070/?q=" + str + "&o=date", null).ToString();
						MatchCollection matchCollection = new Regex("\\<a href=\"(.*?)\"\\>\\<span class=\"label label--silver\"").Matches(input);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									stringBuilder.AppendLine(((Match)objectValue).Groups[1].Value.Replace("/threads/", "https://hqcombo.com/threads/"));
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
						finally
						{
							IEnumerator enumerator2;
							bool flag = enumerator2 is IDisposable;
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
						}
						MatchCollection matchCollection2 = new Regex("\\<a href=\"(.*?)\"\\>\\<span class=\"label label--silver\"").Matches(input);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									stringBuilder2.AppendLine(((Match)objectValue2).Groups[1].Value.Replace("/threads/", "https://hqcombo.com/threads/"));
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
						finally
						{
							IEnumerator enumerator4;
							bool flag2 = enumerator4 is IDisposable;
							if (flag2)
							{
								(enumerator4 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
						}
					}
				}
				string[] source = this.TextBox2.Text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				int length = this.TextBox2.Text.Length;
				int num = source.Distinct<string>().Count<string>();
				int num2 = checked(length - num);
				this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
			}
			catch (Exception ex)
			{
				this.method_1();
			}
			this.method_2();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000041CC File Offset: 0x000023CC
		private void searcher_forum4()
		{
			try
			{
				foreach (string str in this.TextBox1.Lines)
				{
					using (Leaf.Net.HttpRequest httpRequest = new Leaf.Net.HttpRequest())
					{
						httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest.KeepAlive = true;
						httpRequest.Cookies = new CookieStorage(false, null);
						string input = httpRequest.Get("https://altenens.org/search/270614/?q=" + str + "&o=date", null).ToString();
						MatchCollection matchCollection = new Regex("\\<h3 class=\"contentRow-title\"\\> \\<a href=\"(.*?)\"\\>(.*?)\\<\\/a\\> \\<span").Matches(input);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									stringBuilder.AppendLine(((Match)objectValue).Groups[1].Value.Replace("/threads/", "https://altenens.org/threads/"));
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
						finally
						{
							IEnumerator enumerator2;
							bool flag = enumerator2 is IDisposable;
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
						}
						MatchCollection matchCollection2 = new Regex("\\<h3 class=\"contentRow-title\"\\> \\<a href=\"(.*?)\"\\>(.*?)\\<\\/a\\> \\<span").Matches(input);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									stringBuilder2.AppendLine(((Match)objectValue2).Groups[1].Value.Replace("/threads/", "https://altenens.org/threads/"));
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
						finally
						{
							IEnumerator enumerator4;
							bool flag2 = enumerator4 is IDisposable;
							if (flag2)
							{
								(enumerator4 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
						}
					}
				}
				string[] source = this.TextBox2.Text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				int length = this.TextBox2.Text.Length;
				int num = source.Distinct<string>().Count<string>();
				int num2 = checked(length - num);
				this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
			}
			catch (Exception ex)
			{
				this.method_1();
			}
			this.method_2();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004524 File Offset: 0x00002724
		private void anonfile_searcher()
		{
			try
			{
				foreach (string str in this.TextBox1.Lines)
				{
					using (xNet.HttpRequest httpRequest = new xNet.HttpRequest())
					{
						int num = Conversions.ToInteger(Convert.ToString(this.random.Next(0, 4)));
						string str2 = this.domain[num];
						httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest.KeepAlive = true;
						httpRequest.Cookies = new CookieDictionary(false);
						string text = httpRequest.Get("https://www.google" + str2 + "/search?q=anonfile.com:" + str, null).ToString();
						text = WebUtility.UrlDecode(text);
						MatchCollection matchCollection = new Regex("https:\\/\\/anonfile.com\\/+[a-zA-Z0-9.]{3,}").Matches(text);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									stringBuilder.AppendLine(((Match)objectValue).ToString());
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
						finally
						{
							IEnumerator enumerator2;
							bool flag = enumerator2 is IDisposable;
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
						}
						MatchCollection matchCollection2 = new Regex("https:\\/\\/anonfile.com\\/+[a-zA-Z0-9.]{3,}").Matches(text);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									stringBuilder2.AppendLine(((Match)objectValue2).ToString());
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
						finally
						{
							IEnumerator enumerator4;
							bool flag2 = enumerator4 is IDisposable;
							if (flag2)
							{
								(enumerator4 as IDisposable).Dispose();
							}
							this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
						}
					}
				}
				string[] source = this.TextBox2.Text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				int length = this.TextBox2.Text.Length;
				int num2 = source.Distinct<string>().Count<string>();
				int num3 = checked(length - num2);
				this.TextBox2.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
			}
			catch (Exception ex)
			{
				this.method_1();
			}
			this.method_2();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004878 File Offset: 0x00002A78
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			int length = this.TextBox2.Text.Length;
			this.TextBox2.SelectionStart = length;
			this.TextBox2.ScrollToCaret();
			this.Label5.Text = Conversions.ToString(this.TextBox2.Lines.Count<string>());
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000048D4 File Offset: 0x00002AD4
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBox1.Lines.Count<string>() > 0;
			checked
			{
				if (flag)
				{
					bool @checked = this.RadioButton1.Checked;
					if (@checked)
					{
						this.searchTime = "all";
					}
					else
					{
						bool checked2 = this.RadioButton2.Checked;
						if (checked2)
						{
							this.searchTime = "y";
						}
						else
						{
							bool checked3 = this.RadioButton3.Checked;
							if (checked3)
							{
								this.searchTime = "m";
							}
							else
							{
								bool checked4 = this.RadioButton4.Checked;
								if (checked4)
								{
									this.searchTime = "w";
								}
								else
								{
									bool checked5 = this.RadioButton5.Checked;
									if (checked5)
									{
										this.searchTime = "d";
									}
									else
									{
										bool checked6 = this.RadioButton5.Checked;
										if (checked6)
										{
											this.searchTime = "h";
										}
									}
								}
							}
						}
					}
					this.TextBox1.ReadOnly = true;
					this.TextBox2.ReadOnly = true;
					this.CheckBox1.Enabled = false;
					this.CheckBox2.Enabled = false;
					this.CheckBox3.Enabled = false;
					this.CheckBox4.Enabled = false;
					this.Button1.Enabled = false;
					this.Button2.Enabled = true;
					this.GroupBox2.Enabled = false;
					int num = 0;
					do
					{
						bool checked7 = this.CheckBox1.Checked;
						if (checked7)
						{
							bool flag2 = num == 1;
							if (flag2)
							{
								Thread thread = new Thread(new ThreadStart(this.GoogleSearcher));
								thread.IsBackground = false;
								List.thread1.Add(thread);
								thread.Start();
							}
						}
						bool checked8 = this.CheckBox2.Checked;
						if (checked8)
						{
							bool flag3 = num == 2;
							if (flag3)
							{
								Thread thread2 = new Thread(new ThreadStart(this.pastebinSearcher));
								thread2.IsBackground = false;
								List.thread1.Add(thread2);
								thread2.Start();
							}
						}
						bool checked9 = this.CheckBox3.Checked;
						if (checked9)
						{
							bool flag4 = num == 3;
							if (flag4)
							{
								Thread thread3 = new Thread(new ThreadStart(this.searcher_forum1));
								thread3.IsBackground = false;
								List.thread1.Add(thread3);
								thread3.Start();
							}
							bool flag5 = num == 4;
							if (flag5)
							{
								Thread thread4 = new Thread(new ThreadStart(this.searcher_forum2));
								thread4.IsBackground = false;
								List.thread1.Add(thread4);
								thread4.Start();
							}
							bool flag6 = num == 5;
							if (flag6)
							{
								Thread thread5 = new Thread(new ThreadStart(this.searcher_forum3));
								thread5.IsBackground = false;
								List.thread1.Add(thread5);
								thread5.Start();
							}
							bool flag7 = num == 6;
							if (flag7)
							{
								Thread thread6 = new Thread(new ThreadStart(this.searcher_forum4));
								thread6.IsBackground = false;
								List.thread1.Add(thread6);
								thread6.Start();
							}
						}
						bool checked10 = this.CheckBox4.Checked;
						if (checked10)
						{
							bool flag8 = num == 7;
							if (flag8)
							{
								Thread thread7 = new Thread(new ThreadStart(this.anonfile_searcher));
								thread7.IsBackground = false;
								List.thread1.Add(thread7);
								thread7.Start();
							}
						}
						num++;
					}
					while (num <= 7);
				}
				else
				{
					Interaction.MsgBox("Please add keywords", MsgBoxStyle.Information, null);
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004C44 File Offset: 0x00002E44
		private void Button2_Click(object sender, EventArgs e)
		{
			using (IEnumerator<Thread> enumerator = (IEnumerator<Thread>)List.thread1.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Thread thread = enumerator.Current;
					thread.Abort();
				}
			}
			this.Button1.Enabled = true;
			this.Button2.Enabled = false;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004CBC File Offset: 0x00002EBC
		private void Button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Accounts (*.txt)|*.txt";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				foreach (string item in File.ReadAllLines(openFileDialog.FileName))
				{
					List.urls.Add(item);
				}
				this.Label14.Text = Conversions.ToString(List.urls.Count);
				this.Label19.Text = "0\\" + Conversions.ToString(List.urls.Count);
				List.iUsed = List.urls.Count;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004D70 File Offset: 0x00002F70
		private void runer()
		{
			checked
			{
				while (this.@bool)
				{
					try
					{
						string proxy = string.Empty;
						string empty = string.Empty;
						string text = string.Empty;
						string empty2 = string.Empty;
						lock (this)
						{
							bool flag2 = List.urls.Count > 0 && this.Timer1.Enabled;
							if (!flag2)
							{
								continue;
							}
							text = List.urls[0];
							List.urls.RemoveAt(0);
							bool flag3 = List.Prxs.Count > 0;
							if (flag3)
							{
								bool flag4 = List.Prxs.Count > List.iPrx;
								if (flag4)
								{
									proxy = List.Prxs[List.iPrx];
								}
								else
								{
									List.iPrx = 0;
									proxy = List.Prxs[List.iPrx];
								}
								List.iPrx++;
							}
							else
							{
								proxy = null;
							}
						}
						bool flag5 = string.IsNullOrEmpty(text);
						if (flag5)
						{
							Thread.Sleep(900);
							break;
						}
						this.grabber(text, proxy);
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004EE8 File Offset: 0x000030E8
		private void grabber(string url, string proxy)
		{
			bool flag = Operators.CompareString(this.ComboBox2.Text, "Email:Pass", false) == 0;
			if (flag)
			{
				bool flag2 = url.Contains("hqcombo.com");
				if (flag2)
				{
					try
					{
						using (Leaf.Net.HttpRequest httpRequest = new Leaf.Net.HttpRequest())
						{
							httpRequest.Cookies = new CookieStorage(false, null);
							httpRequest.UserAgent = Leaf.Net.Http.RandomUserAgent();
							httpRequest.KeepAlive = true;
							httpRequest.IgnoreProtocolErrors = true;
							bool flag3 = Operators.CompareString(this.ComboBox1.Text, "Https", false) == 0;
							if (flag3)
							{
								httpRequest.Proxy = Leaf.Net.HttpProxyClient.Parse(proxy);
							}
							else
							{
								bool flag4 = Operators.CompareString(this.ComboBox1.Text, "Socks4", false) == 0;
								if (flag4)
								{
									httpRequest.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
								}
								else
								{
									bool flag5 = Operators.CompareString(this.ComboBox1.Text, "Socks5", false) == 0;
									if (flag5)
									{
										httpRequest.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
									}
								}
							}
							string input = httpRequest.Get(url, null).ToString();
							MatchCollection matchCollection = new Regex("\"\\>(.*?).com\\<\\/a\\>:(.*?)\\<br \\/\\>").Matches(input);
							StringBuilder stringBuilder = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj in matchCollection)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(obj);
										stringBuilder.AppendLine(((Match)objectValue).Groups[1].Value + ".com:" + ((Match)objectValue).Groups[2].Value);
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
							finally
							{
								IEnumerator enumerator2;
								bool flag6 = enumerator2 is IDisposable;
								if (flag6)
								{
									(enumerator2 as IDisposable).Dispose();
								}
								this.results += stringBuilder.ToString();
							}
							MatchCollection matchCollection2 = new Regex("\"\\>(.*?).com\\<\\/a\\>:(.*?)\\<br \\/\\>").Matches(input);
							StringBuilder stringBuilder2 = new StringBuilder();
							try
							{
								try
								{
									foreach (object obj2 in matchCollection)
									{
										object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
										stringBuilder2.AppendLine(((Match)objectValue2).Groups[1].Value + ".com:" + ((Match)objectValue2).Groups[2].Value);
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
							finally
							{
								IEnumerator enumerator4;
								bool flag7 = enumerator4 is IDisposable;
								if (flag7)
								{
									(enumerator4 as IDisposable).Dispose();
								}
								this.results += stringBuilder2.ToString();
							}
							this.method_4();
							Thread.Sleep(2000);
						}
					}
					catch (Leaf.Net.HttpException ex)
					{
						bool flag8 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
						if (flag8)
						{
							this.method_8(url);
						}
						else
						{
							this.method_4();
						}
					}
					catch (Exception ex2)
					{
						this.method_4();
					}
				}
				else
				{
					bool flag9 = url.Contains("anonfile");
					if (flag9)
					{
						try
						{
							using (Leaf.Net.HttpRequest httpRequest2 = new Leaf.Net.HttpRequest())
							{
								httpRequest2.Cookies = new CookieStorage(false, null);
								httpRequest2.UserAgent = Leaf.Net.Http.RandomUserAgent();
								httpRequest2.KeepAlive = true;
								httpRequest2.IgnoreProtocolErrors = true;
								bool flag10 = Operators.CompareString(this.ComboBox1.Text, "Https", false) == 0;
								if (flag10)
								{
									httpRequest2.Proxy = Leaf.Net.HttpProxyClient.Parse(proxy);
								}
								else
								{
									bool flag11 = Operators.CompareString(this.ComboBox1.Text, "Socks4", false) == 0;
									if (flag11)
									{
										httpRequest2.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
									}
									else
									{
										bool flag12 = Operators.CompareString(this.ComboBox1.Text, "Socks5", false) == 0;
										if (flag12)
										{
											httpRequest2.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
										}
									}
								}
								string input2 = httpRequest2.Get(url, null).ToString();
								string value = Regex.Match(input2, "href=\"(.*?)\"\\>\\<img").Groups[1].Value;
								string input3 = httpRequest2.Get(value, null).ToString();
								MatchCollection matchCollection3 = new Regex("[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})").Matches(input3);
								StringBuilder stringBuilder3 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj3 in matchCollection3)
										{
											object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
											stringBuilder3.AppendLine(((Match)objectValue3).ToString());
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
								finally
								{
									IEnumerator enumerator6;
									bool flag13 = enumerator6 is IDisposable;
									if (flag13)
									{
										(enumerator6 as IDisposable).Dispose();
									}
									this.results += stringBuilder3.ToString();
								}
								MatchCollection matchCollection4 = new Regex("[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})").Matches(input3);
								StringBuilder stringBuilder4 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj4 in matchCollection3)
										{
											object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
											stringBuilder4.AppendLine(((Match)objectValue4).ToString());
										}
									}
									finally
									{
										IEnumerator enumerator7;
										if (enumerator7 is IDisposable)
										{
											(enumerator7 as IDisposable).Dispose();
										}
									}
								}
								finally
								{
									IEnumerator enumerator8;
									bool flag14 = enumerator8 is IDisposable;
									if (flag14)
									{
										(enumerator8 as IDisposable).Dispose();
									}
									this.results += stringBuilder4.ToString();
								}
								this.method_4();
								Thread.Sleep(2000);
							}
						}
						catch (Leaf.Net.HttpException ex3)
						{
							bool flag15 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
							if (flag15)
							{
								this.method_8(url);
							}
							else
							{
								this.method_4();
							}
						}
						catch (Exception ex4)
						{
							this.method_4();
						}
					}
					else
					{
						try
						{
							using (Leaf.Net.HttpRequest httpRequest3 = new Leaf.Net.HttpRequest())
							{
								httpRequest3.Cookies = new CookieStorage(false, null);
								httpRequest3.UserAgent = Leaf.Net.Http.RandomUserAgent();
								httpRequest3.KeepAlive = true;
								httpRequest3.IgnoreProtocolErrors = true;
								bool flag16 = Operators.CompareString(this.ComboBox1.Text, "Https", false) == 0;
								if (flag16)
								{
									httpRequest3.Proxy = Leaf.Net.HttpProxyClient.Parse(proxy);
								}
								else
								{
									bool flag17 = Operators.CompareString(this.ComboBox1.Text, "Socks4", false) == 0;
									if (flag17)
									{
										httpRequest3.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
									}
									else
									{
										bool flag18 = Operators.CompareString(this.ComboBox1.Text, "Socks5", false) == 0;
										if (flag18)
										{
											httpRequest3.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
										}
									}
								}
								string input4 = httpRequest3.Get(url, null).ToString();
								MatchCollection matchCollection5 = new Regex("[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})").Matches(input4);
								StringBuilder stringBuilder5 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj5 in matchCollection5)
										{
											object objectValue5 = RuntimeHelpers.GetObjectValue(obj5);
											stringBuilder5.AppendLine(((Match)objectValue5).ToString());
										}
									}
									finally
									{
										IEnumerator enumerator9;
										if (enumerator9 is IDisposable)
										{
											(enumerator9 as IDisposable).Dispose();
										}
									}
								}
								finally
								{
									IEnumerator enumerator10;
									bool flag19 = enumerator10 is IDisposable;
									if (flag19)
									{
										(enumerator10 as IDisposable).Dispose();
									}
									this.results += stringBuilder5.ToString();
								}
								MatchCollection matchCollection6 = new Regex("[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})").Matches(input4);
								StringBuilder stringBuilder6 = new StringBuilder();
								try
								{
									try
									{
										foreach (object obj6 in matchCollection5)
										{
											object objectValue6 = RuntimeHelpers.GetObjectValue(obj6);
											stringBuilder6.AppendLine(((Match)objectValue6).ToString());
										}
									}
									finally
									{
										IEnumerator enumerator11;
										if (enumerator11 is IDisposable)
										{
											(enumerator11 as IDisposable).Dispose();
										}
									}
								}
								finally
								{
									IEnumerator enumerator12;
									bool flag20 = enumerator12 is IDisposable;
									if (flag20)
									{
										(enumerator12 as IDisposable).Dispose();
									}
									this.results += stringBuilder6.ToString();
								}
								this.method_4();
								Thread.Sleep(200);
							}
						}
						catch (Leaf.Net.HttpException ex5)
						{
							bool flag21 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
							if (flag21)
							{
								this.method_8(url);
							}
							else
							{
								this.method_4();
							}
						}
						catch (Exception ex6)
						{
							this.method_4();
						}
					}
				}
			}
			else
			{
				try
				{
					bool flag22 = Operators.CompareString(this.ComboBox2.Text, "User:Pass", false) == 0;
					if (flag22)
					{
						this.reggex = this.regexc[0];
					}
					else
					{
						bool flag23 = Operators.CompareString(this.ComboBox2.Text, "Emails", false) == 0;
						if (flag23)
						{
							this.reggex = this.regexc[1];
						}
						else
						{
							bool flag24 = Operators.CompareString(this.ComboBox2.Text, "Proxy", false) == 0;
							if (flag24)
							{
								this.reggex = this.regexc[2];
							}
							else
							{
								this.reggex = List.Regex;
							}
						}
					}
					using (Leaf.Net.HttpRequest httpRequest4 = new Leaf.Net.HttpRequest())
					{
						httpRequest4.Cookies = new CookieStorage(false, null);
						httpRequest4.UserAgent = Leaf.Net.Http.RandomUserAgent();
						httpRequest4.KeepAlive = true;
						bool flag25 = Operators.CompareString(this.ComboBox1.Text, "Https", false) == 0;
						if (flag25)
						{
							httpRequest4.Proxy = Leaf.Net.HttpProxyClient.Parse(proxy);
						}
						else
						{
							bool flag26 = Operators.CompareString(this.ComboBox1.Text, "Socks4", false) == 0;
							if (flag26)
							{
								httpRequest4.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
							}
							else
							{
								bool flag27 = Operators.CompareString(this.ComboBox1.Text, "Socks5", false) == 0;
								if (flag27)
								{
									httpRequest4.Proxy = Leaf.Net.Socks4ProxyClient.Parse(proxy);
								}
							}
						}
						httpRequest4.IgnoreProtocolErrors = true;
						string input5 = httpRequest4.Get(url, null).ToString();
						MatchCollection matchCollection7 = new Regex(this.reggex).Matches(input5);
						StringBuilder stringBuilder7 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj7 in matchCollection7)
								{
									object objectValue7 = RuntimeHelpers.GetObjectValue(obj7);
									stringBuilder7.AppendLine(((Match)objectValue7).ToString());
								}
							}
							finally
							{
								IEnumerator enumerator13;
								if (enumerator13 is IDisposable)
								{
									(enumerator13 as IDisposable).Dispose();
								}
							}
						}
						finally
						{
							IEnumerator enumerator14;
							bool flag28 = enumerator14 is IDisposable;
							if (flag28)
							{
								(enumerator14 as IDisposable).Dispose();
							}
							this.results += stringBuilder7.ToString();
						}
						MatchCollection matchCollection8 = new Regex(this.reggex).Matches(input5);
						StringBuilder stringBuilder8 = new StringBuilder();
						try
						{
							try
							{
								foreach (object obj8 in matchCollection7)
								{
									object objectValue8 = RuntimeHelpers.GetObjectValue(obj8);
									stringBuilder8.AppendLine(((Match)objectValue8).ToString());
								}
							}
							finally
							{
								IEnumerator enumerator15;
								if (enumerator15 is IDisposable)
								{
									(enumerator15 as IDisposable).Dispose();
								}
							}
						}
						finally
						{
							IEnumerator enumerator16;
							bool flag29 = enumerator16 is IDisposable;
							if (flag29)
							{
								(enumerator16 as IDisposable).Dispose();
							}
							this.results += stringBuilder8.ToString();
						}
						this.method_4();
						Thread.Sleep(2000);
					}
				}
				catch (Leaf.Net.HttpException ex7)
				{
					bool flag30 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
					if (flag30)
					{
						this.method_8(url);
					}
					else
					{
						this.method_4();
					}
				}
				catch (Exception ex8)
				{
					this.method_4();
				}
			}
			this.method_7();
			this.method_5();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005DC4 File Offset: 0x00003FC4
		private void method_1()
		{
			checked
			{
				try
				{
					lock (this)
					{
						List.iErr++;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005E2C File Offset: 0x0000402C
		private void method_2()
		{
			try
			{
				lock (this)
				{
					base.Invoke(new MethodInvoker(this.method_3));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005E9C File Offset: 0x0000409C
		private void method_3()
		{
			string[] values = new string[]
			{
				List.iErr.ToString()
			};
			this.Label11.Text = string.Concat(values);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005ED0 File Offset: 0x000040D0
		private void method_4()
		{
			checked
			{
				try
				{
					lock (this)
					{
						List.iDone++;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005F38 File Offset: 0x00004138
		private void method_5()
		{
			try
			{
				lock (this)
				{
					base.Invoke(new MethodInvoker(this.method_6));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005FA8 File Offset: 0x000041A8
		private void method_6()
		{
			try
			{
				string[] values = new string[]
				{
					Conversions.ToString(Conversions.ToDouble(List.iDone.ToString()) + 1.0) + "/" + List.iUsed.ToString()
				};
				string[] values2 = new string[]
				{
					Conversions.ToString(checked(this.TextBox3.Lines.Count<string>() - 1))
				};
				string[] values3 = new string[]
				{
					List.iErr2.ToString()
				};
				this.Label19.Text = string.Concat(values);
				this.Label10.Text = string.Concat(values2);
				this.Label9.Text = string.Concat(values3);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006080 File Offset: 0x00004280
		private void method_7()
		{
			try
			{
				lock (this)
				{
					string[] source = this.results.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					int length = this.results.Length;
					int num = source.Distinct<string>().Count<string>();
					int num2 = checked(length - num);
					this.TextBox3.Text = string.Join("\r\n", source.Distinct<string>().ToArray<string>());
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000613C File Offset: 0x0000433C
		private void method_8(string url)
		{
			checked
			{
				try
				{
					lock (this)
					{
						List.iErr2++;
						List.urls.Add(url);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000061B0 File Offset: 0x000043B0
		private void Button7_Click(object sender, EventArgs e)
		{
			bool flag = List.urls.Count == 0;
			if (flag)
			{
				Interaction.MsgBox("Please load urls", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = List.Prxs.Count == 0;
				if (flag2)
				{
					bool flag3 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
					if (flag3)
					{
						Interaction.MsgBox("Please load proxy", MsgBoxStyle.OkOnly, null);
						return;
					}
				}
				bool flag4 = decimal.Compare(this.NumericUpDown1.Value, new decimal(List.urls.Count)) > 0;
				if (flag4)
				{
					Interaction.MsgBox("Threads number cannot be larger then the urls list", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					bool flag5 = decimal.Compare(this.NumericUpDown1.Value, new decimal(List.Prxs.Count)) > 0;
					if (flag5)
					{
						bool flag6 = Operators.CompareString(this.ComboBox1.Text, "No Proxy", false) != 0;
						if (flag6)
						{
							Interaction.MsgBox("Threads number cannot be larger then the proxy list", MsgBoxStyle.OkOnly, null);
							return;
						}
					}
					this.Button3.Enabled = false;
					this.Button7.Enabled = false;
					this.Button5.Enabled = false;
					this.Button8.Enabled = true;
					this.ComboBox1.Enabled = false;
					this.ComboBox2.Enabled = false;
					this.NumericUpDown1.Enabled = false;
					this.Timer1.Start();
					this.@bool = true;
					decimal d = decimal.Subtract(this.NumericUpDown1.Value, 1m);
					decimal d2 = 0m;
					while (decimal.Compare(d2, d) <= 0)
					{
						Thread thread = new Thread(new ThreadStart(this.runer));
						thread.IsBackground = false;
						List.thread2.Add(thread);
						thread.Start();
						d2 = decimal.Add(d2, 1m);
					}
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006394 File Offset: 0x00004594
		private void Button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Urls (*.txt)|*.txt";
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.OpenFile());
				bool flag2 = streamWriter != null;
				if (flag2)
				{
					streamWriter.WriteLine(this.TextBox2.Text);
					streamWriter.Close();
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000063F4 File Offset: 0x000045F4
		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.ComboBox2.Text, "Custom", false) == 0;
			if (flag)
			{
				MyProject.Forms.Regex_Form.Show();
				this.reggex = MyProject.Forms.Regex_Form.TextBox1.Text;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000644C File Offset: 0x0000464C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = List.iDone == List.iUsed;
			if (flag)
			{
				this.Timer1.Stop();
				this.Button3.Enabled = false;
				this.Button5.Enabled = false;
				this.Button7.Enabled = false;
				this.Button8.Enabled = false;
				using (IEnumerator<Thread> enumerator = (IEnumerator<Thread>)List.thread2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Thread thread = enumerator.Current;
						thread.Abort();
					}
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000064FC File Offset: 0x000046FC
		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			int length = this.TextBox3.Text.Length;
			this.TextBox3.SelectionStart = length;
			this.TextBox3.ScrollToCaret();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006534 File Offset: 0x00004734
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Proxy (*.txt)|*.txt";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					List.Prxs.Clear();
					List.Prxs.AddRange(File.ReadAllLines(openFileDialog.FileName).Distinct<string>());
				}
				this.Label12.Text = List.Prxs.Count.ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000065CC File Offset: 0x000047CC
		private void Button8_Click(object sender, EventArgs e)
		{
			this.@bool = false;
			this.Timer1.Stop();
			this.Button8.Enabled = false;
			this.Button8.Text = "Stopping";
			using (IEnumerator<Thread> enumerator = (IEnumerator<Thread>)List.thread2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Thread thread = enumerator.Current;
					thread.Abort();
				}
			}
			this.Button7.Enabled = true;
			this.Button8.Text = "Stop";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006678 File Offset: 0x00004878
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Combo list (*.txt)|*.txt";
				bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					StreamWriter streamWriter = new StreamWriter(saveFileDialog.OpenFile());
					bool flag2 = streamWriter != null;
					if (flag2)
					{
						streamWriter.WriteLine(this.TextBox3.Text);
						streamWriter.Close();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021CC File Offset: 0x000003CC
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000021D6 File Offset: 0x000003D6
		internal virtual BindingSource BindingSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000021DF File Offset: 0x000003DF
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000021E9 File Offset: 0x000003E9
		internal virtual VisualStyler VisualStyler1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000021F2 File Offset: 0x000003F2
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000021FC File Offset: 0x000003FC
		internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002205 File Offset: 0x00000405
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000220F File Offset: 0x0000040F
		internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002218 File Offset: 0x00000418
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002222 File Offset: 0x00000422
		internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000222B File Offset: 0x0000042B
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002235 File Offset: 0x00000435
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000223E File Offset: 0x0000043E
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002248 File Offset: 0x00000448
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002251 File Offset: 0x00000451
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000225B File Offset: 0x0000045B
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000226E File Offset: 0x0000046E
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002277 File Offset: 0x00000477
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002281 File Offset: 0x00000481
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000228A File Offset: 0x0000048A
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002294 File Offset: 0x00000494
		internal virtual RadioButton RadioButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000229D File Offset: 0x0000049D
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022A7 File Offset: 0x000004A7
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000022BA File Offset: 0x000004BA
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000022C3 File Offset: 0x000004C3
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000022CD File Offset: 0x000004CD
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000022D6 File Offset: 0x000004D6
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000022E0 File Offset: 0x000004E0
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000022E9 File Offset: 0x000004E9
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000022F3 File Offset: 0x000004F3
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000022FC File Offset: 0x000004FC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002306 File Offset: 0x00000506
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000230F File Offset: 0x0000050F
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002319 File Offset: 0x00000519
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002322 File Offset: 0x00000522
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000232C File Offset: 0x0000052C
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002335 File Offset: 0x00000535
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000233F File Offset: 0x0000053F
		internal virtual Label HideSolution { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002348 File Offset: 0x00000548
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002352 File Offset: 0x00000552
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000235B File Offset: 0x0000055B
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002365 File Offset: 0x00000565
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000236E File Offset: 0x0000056E
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002378 File Offset: 0x00000578
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002381 File Offset: 0x00000581
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00008AF0 File Offset: 0x00006CF0
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000238B File Offset: 0x0000058B
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00008B34 File Offset: 0x00006D34
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002395 File Offset: 0x00000595
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00008B78 File Offset: 0x00006D78
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000239F File Offset: 0x0000059F
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00008BBC File Offset: 0x00006DBC
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000023A9 File Offset: 0x000005A9
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023B3 File Offset: 0x000005B3
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000023BC File Offset: 0x000005BC
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023C6 File Offset: 0x000005C6
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000023CF File Offset: 0x000005CF
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000023D9 File Offset: 0x000005D9
		internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023E2 File Offset: 0x000005E2
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023EC File Offset: 0x000005EC
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000023F5 File Offset: 0x000005F5
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000023FF File Offset: 0x000005FF
		internal virtual NumericUpDown NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002408 File Offset: 0x00000608
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00008C00 File Offset: 0x00006E00
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002412 File Offset: 0x00000612
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00008C44 File Offset: 0x00006E44
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000241C File Offset: 0x0000061C
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00008C88 File Offset: 0x00006E88
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002426 File Offset: 0x00000626
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002430 File Offset: 0x00000630
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002439 File Offset: 0x00000639
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002443 File Offset: 0x00000643
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000244C File Offset: 0x0000064C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00008CCC File Offset: 0x00006ECC
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002456 File Offset: 0x00000656
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00008D10 File Offset: 0x00006F10
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000246A File Offset: 0x0000066A
		internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002473 File Offset: 0x00000673
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000247D File Offset: 0x0000067D
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002486 File Offset: 0x00000686
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002490 File Offset: 0x00000690
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002499 File Offset: 0x00000699
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000024A3 File Offset: 0x000006A3
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000024AC File Offset: 0x000006AC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024B6 File Offset: 0x000006B6
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000024BF File Offset: 0x000006BF
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000024C9 File Offset: 0x000006C9
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000024D2 File Offset: 0x000006D2
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000024DC File Offset: 0x000006DC
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000024E5 File Offset: 0x000006E5
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000024EF File Offset: 0x000006EF
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000024F8 File Offset: 0x000006F8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002502 File Offset: 0x00000702
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000250B File Offset: 0x0000070B
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002515 File Offset: 0x00000715
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000251E File Offset: 0x0000071E
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002528 File Offset: 0x00000728
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002531 File Offset: 0x00000731
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00008D54 File Offset: 0x00006F54
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000253B File Offset: 0x0000073B
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00008D98 File Offset: 0x00006F98
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002545 File Offset: 0x00000745
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00008DDC File Offset: 0x00006FDC
		internal virtual ComboBox ComboBox2
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox2_SelectedIndexChanged);
				ComboBox comboBox = this._ComboBox2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				this._ComboBox2 = value;
				comboBox = this._ComboBox2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x0400000F RID: 15
		private Thread thread;

		// Token: 0x04000010 RID: 16
		private string searchTime;

		// Token: 0x04000011 RID: 17
		private string[] domain;

		// Token: 0x04000012 RID: 18
		private string[] regexc;

		// Token: 0x04000013 RID: 19
		private Random random;

		// Token: 0x04000014 RID: 20
		private bool @bool;

		// Token: 0x04000015 RID: 21
		private int count;

		// Token: 0x04000016 RID: 22
		private string reggex;

		// Token: 0x04000017 RID: 23
		private string results;
	}
}
