using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NordVPN_Checker
{
	// Token: 0x02000003 RID: 3
	internal class Utils
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002A10 File Offset: 0x00000C10
		public static string LRParse(string data, string lS, string rS, bool recursive = false, bool useRegexLR = false)
		{
			string text = data;
			new List<string>();
			bool flag = lS == "" && rS == "";
			string result;
			if (flag)
			{
				result = data;
			}
			else
			{
				bool flag2 = (!text.Contains(lS) && lS != "") || (!text.Contains(rS) && rS != "");
				if (flag2)
				{
					result = "";
				}
				else
				{
					string text2 = null;
					if (recursive)
					{
						if (useRegexLR)
						{
							try
							{
								string pattern = Utils.BuildLRPattern(lS, rS);
								foreach (object obj in Regex.Matches(text, pattern))
								{
									text2 = ((Match)obj).Value;
								}
								return text2;
							}
							catch
							{
								return text2;
							}
						}
						try
						{
							while ((text.Contains(lS) || lS == "") && (text.Contains(rS) || rS == ""))
							{
								int startIndex = (lS == "") ? 0 : (text.IndexOf(lS) + lS.Length);
								text = text.Substring(startIndex);
								int length = (rS == "") ? (text.Length - 1) : text.IndexOf(rS);
								text2 = text.Substring(0, length);
								text = text.Substring(text2.Length + rS.Length);
							}
							return text2;
						}
						catch
						{
							return text2;
						}
					}
					if (useRegexLR)
					{
						string pattern2 = Utils.BuildLRPattern(lS, rS);
						MatchCollection matchCollection = Regex.Matches(text, pattern2);
						bool flag3 = matchCollection.Count > 0;
						if (flag3)
						{
							text2 = matchCollection[0].Value;
						}
					}
					else
					{
						try
						{
							int startIndex2 = (lS == "") ? 0 : (text.IndexOf(lS) + lS.Length);
							text = text.Substring(startIndex2);
							int length2 = (rS == "") ? text.Length : text.IndexOf(rS);
							text2 = text.Substring(0, length2);
						}
						catch
						{
						}
					}
					result = text2;
				}
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002C94 File Offset: 0x00000E94
		public static string BuildLRPattern(string ls, string rs)
		{
			string text = string.IsNullOrEmpty(ls) ? "^" : Regex.Escape(ls);
			string text2 = string.IsNullOrEmpty(rs) ? "$" : Regex.Escape(rs);
			return string.Concat(new string[]
			{
				"(?<=",
				text,
				").+?(?=",
				text2,
				")"
			});
		}
	}
}
