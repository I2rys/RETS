using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool.My
{
	// Token: 0x02000013 RID: 19
	[OptionText]
	[StandardModule]
	[DebuggerNonUserCode]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000128 RID: 296 RVA: 0x001703BC File Offset: 0x0016E7BC
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
