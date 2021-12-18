using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace B3RAP_Leecher.My
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002434 File Offset: 0x00000634
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002460 File Offset: 0x00000660
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag3 = !MySettings.addedHandler;
						if (flag3)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000250E File Offset: 0x0000070E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("bing")]
		public string searchengines
		{
			get
			{
				return Conversions.ToString(this["searchengines"]);
			}
			set
			{
				this["searchengines"] = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002542 File Offset: 0x00000742
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("emailpass")]
		public string leechoptions
		{
			get
			{
				return Conversions.ToString(this["leechoptions"]);
			}
			set
			{
				this["leechoptions"] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002554 File Offset: 0x00000754
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002576 File Offset: 0x00000776
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string customregex
		{
			get
			{
				return Conversions.ToString(this["customregex"]);
			}
			set
			{
				this["customregex"] = value;
			}
		}

		// Token: 0x04000008 RID: 8
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000009 RID: 9
		private static bool addedHandler;

		// Token: 0x0400000A RID: 10
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
