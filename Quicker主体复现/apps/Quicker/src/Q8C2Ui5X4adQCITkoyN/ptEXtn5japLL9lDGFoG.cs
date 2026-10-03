using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Quicker.ScreenSelectLib.Tools;
using tnhyg357Ch4jKrVvHlZ;
using W1nDCS5uH6EHTduDwL5;

namespace Q8C2Ui5X4adQCITkoyN;

internal class ptEXtn5japLL9lDGFoG
{
	private readonly N4PkhP56DLuHvaMdN6G c9WXlxRZmU;

	private readonly ScreenProperties xyFXiKgrR4;

	private int xLFX3icvex = 14;

	private int aLXXf3XHT3 = 20;

	private Rectangle FeiXzPBnGi = Rectangle.Empty;

	private Rectangle UocmwnBBaH = Rectangle.Empty;

	private Rectangle Bwgmt8e3Rq = Rectangle.Empty;

	private Point myBmgaoEDy = Point.Empty;

	private Pen I5rmLbJUdl = new Pen(Color.FromArgb(255, 60, 127, 177), 2f);

	private Pen SQ0mvBAeAu = new Pen(Color.FromArgb(100, 176, 176, 176));

	private Pen Rs9mS2ZNSk;

	private Font dZMm2MLsne = new Font(FontFamily.GenericMonospace, 9f);

	private Brush dZdmuhfLQY = new SolidBrush(Color.FromArgb(140, Color.Black));

	private Brush pG5mN1dC2j = new SolidBrush(Color.FromArgb(80, 0, 0, 0));

	private bool PenmJukrGG = true;

	private static ptEXtn5japLL9lDGFoG pimNVExw1nLk2v1N96w;

	public ptEXtn5japLL9lDGFoG(N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G_1, ScreenProperties screenProperties_1)
	{
		c9WXlxRZmU = n4PkhP56DLuHvaMdN6G_1;
		xyFXiKgrR4 = screenProperties_1;
	}

	[SpecialName]
	public Point narXFEqGyC()
	{
		return myBmgaoEDy;
	}

	private Rectangle VGdXnec7hj(Point point_1)
	{
		Point point = c9WXlxRZmU.PointToScreen(point_1);
		ScreenProperties.MonitorInformation monitorInformation = xyFXiKgrR4.GetMonitorInformation(point);
		xLFX3icvex = (int)(9.0 * monitorInformation.dpiX / 96.0);
		if (!M5hes7xT03OJxltxPjc())
		{
			switch (0)
			{
			}
		}
		int num = 19 * xLFX3icvex;
		int num2 = 13 * xLFX3icvex;
		int num3 = num2 + 110;
		bool flag = monitorInformation.m1nvctlQB8h.t1ivqmCnUM7 - point.Y < num3 + 10;
		int x = ((monitorInformation.m1nvctlQB8h.tRZvqXJG8BS - point.X < num + 10) ? (point_1.X - num - aLXXf3XHT3) : (point_1.X + aLXXf3XHT3));
		int y = (flag ? (point_1.Y - aLXXf3XHT3 - num3) : (point_1.Y + aLXXf3XHT3));
		return new Rectangle(x, y, num, num2);
	}

	public void vU8X4cI1To(Point point_1)
	{
		myBmgaoEDy = point_1;
		UocmwnBBaH = VGdXnec7hj(myBmgaoEDy);
		Bwgmt8e3Rq = UocmwnBBaH;
		Bwgmt8e3Rq.Height += 110;
		c9WXlxRZmU.qubmU3QRTP(FeiXzPBnGi, 20);
		c9WXlxRZmU.qubmU3QRTP(Bwgmt8e3Rq, 20);
		FeiXzPBnGi = Bwgmt8e3Rq;
	}

	public void Dispose()
	{
		I5rmLbJUdl?.Dispose();
		SQ0mvBAeAu?.Dispose();
		Pen rs9mS2ZNSk = Rs9mS2ZNSk;
		if (rs9mS2ZNSk == null)
		{
			int num = 0;
			if (pimNVExw1nLk2v1N96w != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			rs9mS2ZNSk.Dispose();
		}
		dZMm2MLsne?.Dispose();
		dZdmuhfLQY?.Dispose();
		pG5mN1dC2j?.Dispose();
	}

	public void pl3X5wrG7k(PaintEventArgs paintEventArgs_0, Rectangle rectangle_3)
	{
		if (PenmJukrGG)
		{
			PenmJukrGG = false;
			if (myBmgaoEDy.X == 0 && myBmgaoEDy.Y == 0)
			{
				return;
			}
		}
		Rectangle rectangle_4 = vYbXOtMTFB(myBmgaoEDy);
		Graphics graphics = paintEventArgs_0.Graphics;
		int num = 0;
		if (!M5hes7xT03OJxltxPjc())
		{
			goto IL_004c;
		}
		goto IL_0098;
		IL_004c:
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
		graphics.CompositingQuality = CompositingQuality.HighSpeed;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		vneXARklBK(graphics, rectangle_4, rectangle_3);
		d5UXMmxCV6(graphics);
		graphics.SmoothingMode = SmoothingMode.None;
		num = 1;
		if (pimNVExw1nLk2v1N96w != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0098;
		IL_0098:
		switch (num)
		{
		case 1:
			graphics.PixelOffsetMode = PixelOffsetMode.None;
			VkQXTv9nfp(rectangle_4, graphics);
			ySjXo0qxYF(graphics);
			d7dXdhmh07(rectangle_4, graphics);
			bC2XDx0vPk(graphics);
			return;
		}
		goto IL_004c;
	}

	private void bC2XDx0vPk(Graphics graphics_0)
	{
		int num = 1;
		while (true)
		{
			Rectangle rect = new Rectangle(UocmwnBBaH.Left - 1, UocmwnBBaH.Bottom + 1, UocmwnBBaH.Width + 2, 110);
			int num2 = 0;
			if (!M5hes7xT03OJxltxPjc())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			graphics_0.FillRectangle(dZdmuhfLQY, rect);
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Center
			};
			string s = $"{Cursor.Position.X}, {Cursor.Position.Y}";
			int num3 = rect.Top + 5;
			graphics_0.DrawString(s, dZMm2MLsne, Brushes.White, rect.X + rect.Width / 2, num3, format);
			Color color = c9WXlxRZmU.sruKwmBbYf();
			string text = Ue2xdk5dQigvC9ZyWdl.eDOxtWNPgt(color, c9WXlxRZmU.m9aKZ3UteU());
			SizeF sizeF = graphics_0.MeasureString(text, dZMm2MLsne);
			int num4 = 10;
			int num5 = 16;
			float num6 = sizeF.Width + 10f + 14f;
			float num7 = ((float)rect.Width - num6) / 2f;
			num3 += 28;
			using (SolidBrush brush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(brush, (float)rect.Left + num7, num3, num5, num5);
			}
			graphics_0.DrawRectangle(Pens.White, (float)rect.Left + num7, num3, num5, num5);
			graphics_0.DrawString(text, dZMm2MLsne, Brushes.White, (float)rect.Left + num7 + (float)num4 + (float)num5, num3);
			num3 += 28;
			graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
			graphics_0.DrawString(c9WXlxRZmU.HTPKedprPL(), dZMm2MLsne, Brushes.White, rect.X + rect.Width / 2, num3, format);
			return;
		}
	}

	private void d7dXdhmh07(Rectangle rectangle_3, Graphics graphics_0)
	{
		int x = UocmwnBBaH.Left + rectangle_3.Width / 2 * xLFX3icvex - 2;
		int y = UocmwnBBaH.Top + rectangle_3.Height / 2 * xLFX3icvex - 2;
		graphics_0.DrawRectangle(Pens.Black, x, y, xLFX3icvex + 4, xLFX3icvex + 4);
		int x2 = UocmwnBBaH.Left + rectangle_3.Width / 2 * xLFX3icvex - 1;
		int y2 = UocmwnBBaH.Top + rectangle_3.Height / 2 * xLFX3icvex - 1;
		graphics_0.DrawRectangle(Pens.White, x2, y2, xLFX3icvex + 2, xLFX3icvex + 2);
	}

	private void ySjXo0qxYF(Graphics graphics_0)
	{
		if (Rs9mS2ZNSk == null || (int)Rs9mS2ZNSk.Width != xLFX3icvex)
		{
			Rs9mS2ZNSk?.Dispose();
			Rs9mS2ZNSk = new Pen(Color.FromArgb(50, 30, 144, 255), xLFX3icvex);
		}
		int num = UocmwnBBaH.Top + 13 * xLFX3icvex / 2;
		graphics_0.DrawLine(Rs9mS2ZNSk, UocmwnBBaH.Left, num, UocmwnBBaH.Left + UocmwnBBaH.Width / 2 - xLFX3icvex / 2, num);
		graphics_0.DrawLine(Rs9mS2ZNSk, UocmwnBBaH.Left + UocmwnBBaH.Width / 2 + xLFX3icvex / 2, num, UocmwnBBaH.Right, num);
		int num2 = 0;
		if (pimNVExw1nLk2v1N96w != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		int num4 = UocmwnBBaH.Left + 19 * xLFX3icvex / 2;
		graphics_0.DrawLine(Rs9mS2ZNSk, num4, UocmwnBBaH.Top, num4, UocmwnBBaH.Top + UocmwnBBaH.Height / 2 - xLFX3icvex / 2);
		graphics_0.DrawLine(Rs9mS2ZNSk, num4, UocmwnBBaH.Top + UocmwnBBaH.Height / 2 + xLFX3icvex / 2, num4, UocmwnBBaH.Bottom);
	}

	private void VkQXTv9nfp(Rectangle rectangle_3, Graphics graphics_0)
	{
		for (int i = 1; i < rectangle_3.Width; i++)
		{
			int x = UocmwnBBaH.Left + i * xLFX3icvex;
			graphics_0.DrawLine(SQ0mvBAeAu, new Point(x, UocmwnBBaH.Top), new Point(x, UocmwnBBaH.Bottom));
		}
		int num = 1;
		while (num < rectangle_3.Height)
		{
			int y = UocmwnBBaH.Top + num * xLFX3icvex;
			graphics_0.DrawLine(SQ0mvBAeAu, new Point(UocmwnBBaH.Left, y), new Point(UocmwnBBaH.Right, y));
			num++;
			if (pimNVExw1nLk2v1N96w == null)
			{
				switch (0)
				{
				}
			}
		}
	}

	private void d5UXMmxCV6(Graphics graphics_0)
	{
		graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
		graphics_0.DrawRectangle(I5rmLbJUdl, UocmwnBBaH);
	}

	private void vneXARklBK(Graphics graphics_0, Rectangle rectangle_3, Rectangle rectangle_4)
	{
		graphics_0.FillRectangle(Brushes.Black, UocmwnBBaH);
		graphics_0.DrawImage(c9WXlxRZmU.PsMKW8FMWS(), UocmwnBBaH, rectangle_3, GraphicsUnit.Pixel);
		if (!(rectangle_4 != Rectangle.Empty) || rectangle_4.Contains(rectangle_3))
		{
			return;
		}
		graphics_0.FillRectangle(pG5mN1dC2j, UocmwnBBaH);
		Rectangle srcRect = rectangle_3;
		srcRect.Intersect(rectangle_4);
		if (srcRect.Width > 0 && srcRect.Height > 0)
		{
			Rectangle uocmwnBBaH = UocmwnBBaH;
			uocmwnBBaH.Offset((srcRect.X - rectangle_3.X) * xLFX3icvex, (srcRect.Y - rectangle_3.Y) * xLFX3icvex);
			int num = 0;
			if (!M5hes7xT03OJxltxPjc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			uocmwnBBaH.Width = srcRect.Width * xLFX3icvex;
			uocmwnBBaH.Height = srcRect.Height * xLFX3icvex;
			graphics_0.DrawImage(c9WXlxRZmU.PsMKW8FMWS(), uocmwnBBaH, srcRect, GraphicsUnit.Pixel);
		}
	}

	private static Rectangle vYbXOtMTFB(Point point_1)
	{
		return new Rectangle(point_1.X - 9, point_1.Y - 6, 19, 13);
	}

	internal static bool M5hes7xT03OJxltxPjc()
	{
		return pimNVExw1nLk2v1N96w == null;
	}
}
