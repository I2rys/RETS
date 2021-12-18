using System;
using System.Collections.Generic;
using System.Threading;

namespace Joker_Combo_Leecher__v1._0_
{
	// Token: 0x0200000C RID: 12
	internal class List
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00008E20 File Offset: 0x00007020
		static List()
		{
			List.iPrx = 0;
			List.iUsed = 0;
			List.iDone = 0;
			List.iErr = 0;
			List.iErr2 = 0;
		}

		// Token: 0x0400004E RID: 78
		public static List<Thread> thread1 = new List<Thread>();

		// Token: 0x0400004F RID: 79
		public static List<Thread> thread2 = new List<Thread>();

		// Token: 0x04000050 RID: 80
		public static List<string> urls = new List<string>();

		// Token: 0x04000051 RID: 81
		public static int iPrx;

		// Token: 0x04000052 RID: 82
		public static int iUsed;

		// Token: 0x04000053 RID: 83
		public static int iDone;

		// Token: 0x04000054 RID: 84
		public static int iErr;

		// Token: 0x04000055 RID: 85
		public static int iErr2;

		// Token: 0x04000056 RID: 86
		public static string Regex;

		// Token: 0x04000057 RID: 87
		public static List<string> Prxs = new List<string>();
	}
}
