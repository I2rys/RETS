using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Grabber_Checker_Proxy_1._0.My
{
	// Token: 0x0200000D RID: 13
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002928 File Offset: 0x00000B28
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002954 File Offset: 0x00000B54
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000029E0 File Offset: 0x00000BE0
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002A04 File Offset: 0x00000C04
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isBusy
		{
			get
			{
				return Conversions.ToBoolean(this["isBusy"]);
			}
			set
			{
				this["isBusy"] = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002A1C File Offset: 0x00000C1C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002A40 File Offset: 0x00000C40
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		public int OrcaSourceMax
		{
			get
			{
				return Conversions.ToInteger(this["OrcaSourceMax"]);
			}
			set
			{
				this["OrcaSourceMax"] = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002A58 File Offset: 0x00000C58
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002A7C File Offset: 0x00000C7C
		[DefaultSettingValue("15")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int GrabberThreads
		{
			get
			{
				return Conversions.ToInteger(this["GrabberThreads"]);
			}
			set
			{
				this["GrabberThreads"] = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002A94 File Offset: 0x00000C94
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002AB8 File Offset: 0x00000CB8
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool StopFunction
		{
			get
			{
				return Conversions.ToBoolean(this["StopFunction"]);
			}
			set
			{
				this["StopFunction"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002AD0 File Offset: 0x00000CD0
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002AF4 File Offset: 0x00000CF4
		[DefaultSettingValue("500")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int CheckerThreads
		{
			get
			{
				return Conversions.ToInteger(this["CheckerThreads"]);
			}
			set
			{
				this["CheckerThreads"] = value;
			}
		}

		// Token: 0x04000015 RID: 21
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000016 RID: 22
		private static bool addedHandler;

		// Token: 0x04000017 RID: 23
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
