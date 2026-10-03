using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Quicker.ScreenSelectLib;
using tnhyg357Ch4jKrVvHlZ;

namespace RvFEAp52DTGcylUZZAo;

internal class pfmcyt5WD5dg2t7AyL2
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass21_0
	{
		public Graphics LuFvqa7KvY7;
	}

	private N4PkhP56DLuHvaMdN6G ylBXbbFNjA;

	private Brush n3iX6WTkY6;

	private Pen FHsXX8ZvXv = new Pen(Color.White, 2f);

	private Brush OojXmmLtPn = new SolidBrush(Color.FromArgb(128, 0, 0, 0));

	private Brush IVbXKjjb62 = new SolidBrush(Color.FromArgb(40, Color.Red));

	private Pen LCJXx708F1;

	private Font SlqXr9rg1E;

	private string uOvXpT7Edx = "";

	private Rectangle shTXBZyhH2;

	private Rectangle N1bXQeviiS = Rectangle.Empty;

	private Rectangle dtuXjU5sRm = Rectangle.Empty;

	internal static pfmcyt5WD5dg2t7AyL2 JK2vnUx8vZaON1cCIuw;

	[SpecialName]
	public Rectangle kCWXH8aQmg()
	{
		return N1bXQeviiS;
	}

	public pfmcyt5WD5dg2t7AyL2(N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G_1)
	{
		try
		{
			SlqXr9rg1E = new Font(FontFamily.GenericMonospace, 10f);
		}
		catch (Exception)
		{
			SlqXr9rg1E = new Font(SystemFonts.MessageBoxFont.FontFamily, 10f);
		}
		ylBXbbFNjA = n4PkhP56DLuHvaMdN6G_1;
		n3iX6WTkY6 = new SolidBrush(ylBXbbFNjA.amSKc2wEOe());
		LCJXx708F1 = new Pen(ylBXbbFNjA.amSKc2wEOe(), ylBXbbFNjA.sqJKyYLjkf())
		{
			Alignment = PenAlignment.Outset
		};
	}

	public void oCdX9DJ9Fc(Rectangle rectangle_3)
	{
		if (rectangle_3 == N1bXQeviiS)
		{
			ylBXbbFNjA.qubmU3QRTP(N1bXQeviiS, 10);
			return;
		}
		dtuXjU5sRm = N1bXQeviiS;
		N1bXQeviiS = rectangle_3;
		ylBXbbFNjA.qubmU3QRTP(dtuXjU5sRm, 10);
		ylBXbbFNjA.qubmU3QRTP(N1bXQeviiS, 10);
		AbtXhWp3jf();
	}

	public void AbtXhWp3jf()
	{
		uOvXpT7Edx = $"{ylBXbbFNjA.watKGu9PM4()}  {N1bXQeviiS.Width} × {N1bXQeviiS.Height}";
		ylBXbbFNjA.qubmU3QRTP(shTXBZyhH2, 5);
		shTXBZyhH2 = ltXXGURocj();
		ylBXbbFNjA.qubmU3QRTP(shTXBZyhH2, 5);
	}

	public void Dispose()
	{
		n3iX6WTkY6.Dispose();
		FHsXX8ZvXv.Dispose();
		OojXmmLtPn.Dispose();
		n3iX6WTkY6.Dispose();
		LCJXx708F1.Dispose();
	}

	public void mVpXe2wN9X(PaintEventArgs paintEventArgs_0)
	{
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighSpeed;
		graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
		graphics.CompositingQuality = CompositingQuality.HighSpeed;
		graphics.PixelOffsetMode = PixelOffsetMode.None;
		GasXWUKM7v(paintEventArgs_0, N1bXQeviiS, graphics);
		int num = 0;
		if (JK2vnUx8vZaON1cCIuw != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		pyxXIqw9p6(N1bXQeviiS, graphics);
		if (ylBXbbFNjA.pF3K7Hs4U4())
		{
			Yd3XkqtVua(graphics, N1bXQeviiS);
		}
		qNyXYB6s82(graphics);
	}

	private void qNyXYB6s82(Graphics graphics_0)
	{
		if (N1bXQeviiS.Height > 0)
		{
			if (ylBXbbFNjA.IITKCUC0jR() == AreaHighlightMode.Overlay)
			{
				graphics_0.FillRectangle(Brushes.DarkRed, shTXBZyhH2);
			}
			graphics_0.DrawString(uOvXpT7Edx, SlqXr9rg1E, Brushes.White, shTXBZyhH2);
		}
	}

	private void pyxXIqw9p6(Rectangle rectangle_3, Graphics graphics_0)
	{
		graphics_0.DrawRectangle(LCJXx708F1, rectangle_3);
	}

	private void GasXWUKM7v(PaintEventArgs paintEventArgs_0, Rectangle rectangle_3, Graphics graphics_0)
	{
		if (ylBXbbFNjA.IITKCUC0jR() == AreaHighlightMode.SpotLight)
		{
			using (Region region = new Region(paintEventArgs_0.ClipRectangle))
			{
				region.Exclude(rectangle_3);
				graphics_0.FillRegion(OojXmmLtPn, region);
				return;
			}
		}
		if (ylBXbbFNjA.IITKCUC0jR() == AreaHighlightMode.Overlay)
		{
			graphics_0.FillRectangle(IVbXKjjb62, rectangle_3);
		}
	}

	private void Yd3XkqtVua(Graphics graphics_0, Rectangle rectangle_3)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_0_ = default(_003C_003Ec__DisplayClass21_0);
		_003C_003Ec__DisplayClass21_0_.LuFvqa7KvY7 = graphics_0;
		_003C_003Ec__DisplayClass21_0_.LuFvqa7KvY7.SmoothingMode = SmoothingMode.AntiAlias;
		int int_ = 7;
		if (JK2vnUx8vZaON1cCIuw != null)
		{
			switch (0)
			{
			}
		}
		MbuXswqNCn(rectangle_3.X, rectangle_3.Y, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
		if (N1bXQeviiS.Width > 40 && N1bXQeviiS.Height > 40)
		{
			MbuXswqNCn(rectangle_3.X + rectangle_3.Width / 2, rectangle_3.Y, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.Right, rectangle_3.Y, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.X, rectangle_3.Y + rectangle_3.Height / 2, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.Right, rectangle_3.Y + rectangle_3.Height / 2, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.X, rectangle_3.Bottom, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.X + rectangle_3.Width / 2, rectangle_3.Bottom, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
			MbuXswqNCn(rectangle_3.Right, rectangle_3.Bottom, int_, FHsXX8ZvXv, n3iX6WTkY6, ref _003C_003Ec__DisplayClass21_0_);
		}
		_003C_003Ec__DisplayClass21_0_.LuFvqa7KvY7.SmoothingMode = SmoothingMode.None;
	}

	[CompilerGenerated]
	private Rectangle ltXXGURocj()
	{
		Size size = TextRenderer.MeasureText(uOvXpT7Edx, SlqXr9rg1E);
		if (ylBXbbFNjA.IITKCUC0jR() == AreaHighlightMode.SpotLight)
		{
			return new Rectangle(N1bXQeviiS.Left, N1bXQeviiS.Bottom + 3, size.Width + 20, size.Height);
		}
		Rectangle result = new Rectangle(N1bXQeviiS.Left + ylBXbbFNjA.sqJKyYLjkf() / 2, N1bXQeviiS.Top + ylBXbbFNjA.sqJKyYLjkf() / 2, size.Width, size.Height);
		Screen screen = Screen.FromPoint(Cursor.Position);
		Rectangle rectangle = ylBXbbFNjA.RectangleToClient(screen.Bounds);
		if (result.Top < rectangle.Top)
		{
			result.Y = rectangle.Top;
			if (JK2vnUx8vZaON1cCIuw != null)
			{
				switch (0)
				{
				}
			}
		}
		if (result.X < rectangle.Left)
		{
			result.X = rectangle.Left;
		}
		return result;
	}

	[CompilerGenerated]
	internal static void MbuXswqNCn(int int_0, int int_1, int int_2, Pen pen_2, Brush brush_3, ref _003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_0_0)
	{
		Rectangle rect = new Rectangle(int_0 - int_2, int_1 - int_2, int_2 * 2, int_2 * 2);
		_003C_003Ec__DisplayClass21_0_0.LuFvqa7KvY7.FillEllipse(brush_3, rect);
		_003C_003Ec__DisplayClass21_0_0.LuFvqa7KvY7.DrawEllipse(pen_2, rect);
	}

	static pfmcyt5WD5dg2t7AyL2()
	{
	}

	internal static bool Wl5vo0xRGUL5MX35P9K()
	{
		return JK2vnUx8vZaON1cCIuw == null;
	}

	internal static void MF2Jh8xSJhWeqnbabW7()
	{
	}
}
