using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool.My
{
	// Token: 0x02000012 RID: 18
	[OptionText]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000116 RID: 278 RVA: 0x001701A4 File Offset: 0x0016E5A4
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000117 RID: 279 RVA: 0x001701BC File Offset: 0x0016E5BC
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00170224 File Offset: 0x0016E624
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00170244 File Offset: 0x0016E644
		[DefaultSettingValue("50")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int Threads
		{
			get
			{
				return Conversions.ToInteger(this["Threads"]);
			}
			set
			{
				this["Threads"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00170258 File Offset: 0x0016E658
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00170278 File Offset: 0x0016E678
		[DefaultSettingValue("10")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int Timeout
		{
			get
			{
				return Conversions.ToInteger(this["Timeout"]);
			}
			set
			{
				this["Timeout"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0017028C File Offset: 0x0016E68C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x001702AC File Offset: 0x0016E6AC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool Auto_Check
		{
			get
			{
				return Conversions.ToBoolean(this["Auto_Check"]);
			}
			set
			{
				this["Auto_Check"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600011E RID: 286 RVA: 0x001702C0 File Offset: 0x0016E6C0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x001702E0 File Offset: 0x0016E6E0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool Inbuild_Source
		{
			get
			{
				return Conversions.ToBoolean(this["Inbuild_Source"]);
			}
			set
			{
				this["Inbuild_Source"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000120 RID: 288 RVA: 0x001702F4 File Offset: 0x0016E6F4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00170314 File Offset: 0x0016E714
		[DebuggerNonUserCode]
		[DefaultSettingValue("http://azenv.net")]
		[UserScopedSetting]
		public string Proxy_Judge
		{
			get
			{
				return Conversions.ToString(this["Proxy_Judge"]);
			}
			set
			{
				this["Proxy_Judge"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00170324 File Offset: 0x0016E724
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00170344 File Offset: 0x0016E744
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool Auto_Save
		{
			get
			{
				return Conversions.ToBoolean(this["Auto_Save"]);
			}
			set
			{
				this["Auto_Save"] = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00170358 File Offset: 0x0016E758
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00170378 File Offset: 0x0016E778
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://www.google.com/")]
		[UserScopedSetting]
		public string Url_Passed
		{
			get
			{
				return Conversions.ToString(this["Url_Passed"]);
			}
			set
			{
				this["Url_Passed"] = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00170388 File Offset: 0x0016E788
		// (set) Token: 0x06000127 RID: 295 RVA: 0x001703A8 File Offset: 0x0016E7A8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool Passed
		{
			get
			{
				return Conversions.ToBoolean(this["Passed"]);
			}
			set
			{
				this["Passed"] = value;
			}
		}

		// Token: 0x04000078 RID: 120
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000079 RID: 121
		private static bool addedHandler;

		// Token: 0x0400007A RID: 122
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
