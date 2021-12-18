using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace Grabber_Checker_Proxy_1._0
{
	// Token: 0x02000017 RID: 23
	public class Separator : Control
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00005F88 File Offset: 0x00004188
		public Separator()
		{
			this.DoubleBuffered = true;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005F9C File Offset: 0x0000419C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			base.OnPaint(e);
			using (Pen pen = new Pen(this.ColorFromHex("#EBEBEC")))
			{
				graphics.DrawLine(pen, new Point(0, 0), new Point(base.Width, 0));
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006014 File Offset: 0x00004214
		public Color ColorFromHex(string Hex)
		{
			return Color.FromArgb(Convert.ToInt32(long.Parse(string.Format("FFFFFFFFFF{0}", Hex.Substring(1)), NumberStyles.HexNumber)));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006050 File Offset: 0x00004250
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Size = new Size(base.Width, 2);
		}
	}
}
