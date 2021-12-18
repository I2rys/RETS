using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x02000008 RID: 8
	[OptionText]
	public class Checker : IDisposable
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0016F9C0 File Offset: 0x0016DDC0
		public Checker()
		{
			this.useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:50.0) Gecko/20100101 Firefox/50.0";
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0016F9D4 File Offset: 0x0016DDD4
		public string API()
		{
			try
			{
				string text = this.Get_Address("http://ip2c.org/" + this.proxy.Split(new char[]
				{
					':'
				})[0]);
				return (text.Split(new char[]
				{
					';'
				})[3].ToString().Count<char>() <= 18) ? text.Split(new char[]
				{
					';'
				})[3] : "Unknown";
			}
			catch (Exception ex)
			{
			}
			return "Unknown";
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0016FA78 File Offset: 0x0016DE78
		public bool Passed(string url)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.UserAgent = Conversions.ToString(this.useragent);
				httpWebRequest.Proxy = new WebProxy(this.proxy);
				httpWebRequest.Timeout = this.timeout;
				httpWebRequest.ReadWriteTimeout = this.timeout;
				httpWebRequest.AllowAutoRedirect = false;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				if (httpWebResponse.StatusCode == HttpStatusCode.OK)
				{
					httpWebResponse.Close();
					httpWebRequest.Abort();
					return true;
				}
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0016FB20 File Offset: 0x0016DF20
		public string[] Check()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.judge);
			httpWebRequest.UserAgent = Conversions.ToString(this.useragent);
			httpWebRequest.Proxy = new WebProxy(this.proxy);
			httpWebRequest.Timeout = this.timeout;
			httpWebRequest.ReadWriteTimeout = this.timeout;
			httpWebRequest.AllowAutoRedirect = false;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			string[] result;
			using (StreamReader streamReader = new StreamReader(responseStream))
			{
				string text = streamReader.ReadToEnd();
				stopwatch.Stop();
				if (stopwatch.ElapsedMilliseconds >= (long)this.timeout)
				{
					httpWebResponse.Close();
					streamReader.Close();
					responseStream.Close();
					result = null;
				}
				else
				{
					httpWebResponse.Close();
					streamReader.Close();
					result = new string[]
					{
						text,
						Conversions.ToString(stopwatch.ElapsedMilliseconds)
					};
				}
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0016FC30 File Offset: 0x0016E030
		private string Get_Address(string url)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.UserAgent = Conversions.ToString(this.useragent);
			httpWebRequest.Timeout = this.timeout;
			httpWebRequest.ReadWriteTimeout = this.timeout;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			string result;
			using (StreamReader streamReader = new StreamReader(responseStream))
			{
				string text = streamReader.ReadToEnd();
				httpWebResponse.Close();
				streamReader.Close();
				responseStream.Close();
				result = text;
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0016FCCC File Offset: 0x0016E0CC
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0016FCE0 File Offset: 0x0016E0E0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400000C RID: 12
		public int timeout;

		// Token: 0x0400000D RID: 13
		public string proxy;

		// Token: 0x0400000E RID: 14
		public string judge;

		// Token: 0x0400000F RID: 15
		private object useragent;

		// Token: 0x04000010 RID: 16
		private bool disposedValue;
	}
}
