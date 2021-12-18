using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool.My.Resources
{
	// Token: 0x02000011 RID: 17
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[StandardModule]
	[OptionText]
	[HideModuleName]
	[CompilerGenerated]
	public sealed class Resources
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00170118 File Offset: 0x0016E518
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("μProxy_Tool.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00170158 File Offset: 0x0016E558
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0017016C File Offset: 0x0016E56C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000076 RID: 118
		private static ResourceManager resourceMan;

		// Token: 0x04000077 RID: 119
		private static CultureInfo resourceCulture;
	}
}
