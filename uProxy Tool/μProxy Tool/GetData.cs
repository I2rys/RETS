using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace μProxy_Tool
{
	// Token: 0x02000009 RID: 9
	[OptionText]
	public class GetData
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0016FCF8 File Offset: 0x0016E0F8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0016FD0C File Offset: 0x0016E10C
		public Color Color
		{
			get
			{
				return this.c;
			}
			set
			{
				this.c = value;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0016FD18 File Offset: 0x0016E118
		public object SetAnonColor(string anon)
		{
			if (Operators.CompareString(anon, "Anonymous", true) == 0)
			{
				this.Color = Color.DarkTurquoise;
			}
			else if (Operators.CompareString(anon, "Elite", true) == 0)
			{
				this.Color = Color.LimeGreen;
			}
			else if (Operators.CompareString(anon, "Transparent", true) == 0)
			{
				this.Color = Color.Coral;
			}
			object result;
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0016FD7C File Offset: 0x0016E17C
		public object SetTColor(int time)
		{
			if (time >= 0 && time <= 5000)
			{
				this.Color = Color.Green;
			}
			else if (time >= 5000 && time <= 10000)
			{
				this.Color = Color.BlueViolet;
			}
			else if (time >= 10000 && time <= 20000)
			{
				this.Color = Color.OrangeRed;
			}
			else if (time > 20000)
			{
				this.Color = Color.Red;
			}
			object result;
			return result;
		}

		// Token: 0x04000011 RID: 17
		private Color c;
	}
}
