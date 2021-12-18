using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x0200000A RID: 10
	[OptionText]
	public class Scraper : IDisposable
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0016FDF4 File Offset: 0x0016E1F4
		public Scraper()
		{
			this.scraper_match1 = "\\b(\\d{1,3}\\.){3}\\d{1,3}\\:\\d{1,8}\\b";
			this.scraper_match2 = "\\b((\\d{1,3}\\.){3}\\d{1,3})(?:.{1,}?)(\\d{1,5})\\b";
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0016FE14 File Offset: 0x0016E214
		private string Get_Method(string url)
		{
			string result = "";
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Method = "GET";
				httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:49.0) Gecko/20100101 Firefox/49.0";
				httpWebRequest.Timeout = 10000;
				httpWebRequest.ReadWriteTimeout = 12000;
				httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					result = streamReader.ReadToEnd();
					streamReader.Close();
					responseStream.Close();
					httpWebResponse.Close();
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0016FEE8 File Offset: 0x0016E2E8
		private string Samair(string url)
		{
			string input = this.Get_Method(url);
			return "http://www.samair.ru/proxy/ip-port/" + Regex.Match(input, "<a href=\"/proxy/ip-port/(.*?).html\">").Groups[1].Value + ".html";
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0016FF28 File Offset: 0x0016E328
		public List<string> Proxy_Scraper(string url)
		{
			List<string> list = new List<string>();
			if (url.Contains("samair.ru"))
			{
				url = this.Samair(url);
			}
			string input = this.Get_Method(url);
			try
			{
				foreach (object obj in new Regex(this.scraper_match1, RegexOptions.IgnoreCase | RegexOptions.Singleline).Matches(input))
				{
					Match match = (Match)obj;
					if (match.Value.Count<char>() >= 9)
					{
						list.Add(match.Value);
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
			try
			{
				foreach (object obj2 in new Regex(this.scraper_match2, RegexOptions.IgnoreCase | RegexOptions.Singleline).Matches(input))
				{
					Match match2 = (Match)obj2;
					if (match2.Value.Count<char>() > 7)
					{
						string item = match2.Groups[1].Value + ":" + match2.Groups[3].Value;
						list.Add(item);
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
			return list;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00170070 File Offset: 0x0016E470
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00170084 File Offset: 0x0016E484
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000012 RID: 18
		private string scraper_match1;

		// Token: 0x04000013 RID: 19
		private string scraper_match2;

		// Token: 0x04000014 RID: 20
		private bool disposedValue;
	}
}
