using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Grabber_Checker_Proxy_1._0.My
{
	// Token: 0x0200000E RID: 14
	[StandardModule]
	[DebuggerNonUserCode]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002B0C File Offset: 0x00000D0C
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
