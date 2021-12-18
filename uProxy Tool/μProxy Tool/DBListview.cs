using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x0200000E RID: 14
	[OptionText]
	internal class DBListview : Component
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00170094 File Offset: 0x0016E494
		[DebuggerNonUserCode]
		public DBListview(IContainer container) : this()
		{
			if (container != null)
			{
				container.Add(this);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x001700A8 File Offset: 0x0016E4A8
		[DebuggerNonUserCode]
		public DBListview()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x001700B8 File Offset: 0x0016E4B8
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x001700F8 File Offset: 0x0016E4F8
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x0400003D RID: 61
		private IContainer components;
	}
}
