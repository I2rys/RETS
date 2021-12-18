using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x0200000F RID: 15
	[OptionText]
	public class DoubleBufferedListView : ListView
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00170108 File Offset: 0x0016E508
		public DoubleBufferedListView()
		{
			base.DoubleBuffered = true;
		}
	}
}
