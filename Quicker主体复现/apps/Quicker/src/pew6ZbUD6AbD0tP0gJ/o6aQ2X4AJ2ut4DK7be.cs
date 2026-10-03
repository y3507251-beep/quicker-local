using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using jeaU1l2eVVj4W2gaVc;
using NwHZKfynhH8WtL1MH5;
using SnipInsight.Util;

namespace pew6ZbUD6AbD0tP0gJ;

internal class o6aQ2X4AJ2ut4DK7be : IDisposable
{
	private Rectangle gZdLkdOuUW;

	private Bitmap iXdLGQt0xX;

	private double b1dLsmQC4j;

	private static o6aQ2X4AJ2ut4DK7be BdeogKpFOOyYv0G5qMx;

	[SpecialName]
	public Bitmap JVcLI8ALKx()
	{
		return iXdLGQt0xX;
	}

	public void Dispose()
	{
		if (iXdLGQt0xX != null)
		{
			iXdLGQt0xX.Dispose();
		}
		GC.SuppressFinalize(this);
	}

	~o6aQ2X4AJ2ut4DK7be()
	{
		if (iXdLGQt0xX != null)
		{
			iXdLGQt0xX.Dispose();
		}
	}

	public void dieLhnbCqs(Rectangle rectangle_1, double double_1)
	{
		b1dLsmQC4j = double_1;
		gZdLkdOuUW = new Rectangle((int)((double)rectangle_1.Left * b1dLsmQC4j), (int)((double)rectangle_1.Top * b1dLsmQC4j), (int)((double)rectangle_1.Width * b1dLsmQC4j), (int)((double)rectangle_1.Height * b1dLsmQC4j));
		Bitmap bitmap = jq3gKOPRxplQoOLJZg.I3uLye4LQU();
		iXdLGQt0xX = bitmap;
	}

	public BitmapSource WxVLecZvxI(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0, DpiScale dpiScale_0)
	{
        double num4 = default;
		if (b1dLsmQC4j != 1.0)
		{
			dpiScale_0 = new DpiScale(dpiScale_0.X * b1dLsmQC4j, dpiScale_0.Y * b1dLsmQC4j);
		}
		double num = (((double)sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE * b1dLsmQC4j < (double)gZdLkdOuUW.Left) ? ((double)gZdLkdOuUW.Left) : ((double)sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE * b1dLsmQC4j));
		double num2 = (((double)sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS * b1dLsmQC4j < (double)gZdLkdOuUW.Top) ? ((double)gZdLkdOuUW.Top) : ((double)sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS * b1dLsmQC4j));
		int num3 = 0;
		if (!xtsJgMpcpNEYlyBLZHO())
		{
			goto IL_00b6;
		}
		goto IL_018f;
		IL_01a1:
		num4 = num4 + num2;
		num2 = 0.0;
		goto IL_01b3;
		IL_01b3:
		double num5 = default(double);
		Rectangle rectangle_ = new Rectangle((int)num, (int)num2, (int)num5, (int)num4);
		return jq3gKOPRxplQoOLJZg.fguLa5Krp9(iXdLGQt0xX, rectangle_, dpiScale_0);
		IL_00b6:
		double num6 = (((double)sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ * b1dLsmQC4j > (double)gZdLkdOuUW.Right) ? ((double)gZdLkdOuUW.Right) : ((double)sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ * b1dLsmQC4j));
		num4 = (((double)sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u * b1dLsmQC4j > (double)gZdLkdOuUW.Bottom) ? ((double)gZdLkdOuUW.Bottom) : ((double)sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u * b1dLsmQC4j)) - num2;
		num5 = num6 - num;
		num -= (double)gZdLkdOuUW.Left;
		num2 -= (double)gZdLkdOuUW.Top;
		if (num < 0.0)
		{
			num5 += num;
			num = 0.0;
		}
		if (num2 < 0.0)
		{
			num3 = 1;
			if (BdeogKpFOOyYv0G5qMx != null)
			{
				int num7 = default(int);
				num3 = num7;
			}
			goto IL_018f;
		}
		goto IL_01b3;
		IL_018f:
		switch (num3)
		{
		case 1:
			goto IL_01a1;
		}
		goto IL_00b6;
	}

	public Bitmap kxGLYKQneA(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0, DpiScale dpiScale_0)
	{
		int num;
		if (b1dLsmQC4j != 1.0)
		{
			dpiScale_0 = new DpiScale(dpiScale_0.X * b1dLsmQC4j, dpiScale_0.Y * b1dLsmQC4j);
			num = 1;
			if (!xtsJgMpcpNEYlyBLZHO())
			{
				goto IL_004e;
			}
			goto IL_0052;
		}
		goto IL_0061;
		IL_007f:
		double num2 = (double)sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE * b1dLsmQC4j;
		goto IL_009b;
		IL_004e:
		int num3 = default(int);
		num = num3;
		goto IL_0052;
		IL_0052:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_007f;
		}
		goto IL_0061;
		IL_0061:
		if (!((double)sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE * b1dLsmQC4j < (double)gZdLkdOuUW.Left))
		{
			num = 0;
			if (BdeogKpFOOyYv0G5qMx != null)
			{
				goto IL_004e;
			}
			goto IL_0052;
		}
		num2 = gZdLkdOuUW.Left;
		goto IL_009b;
		IL_009b:
		double num4 = num2;
		double num5 = (((double)sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS * b1dLsmQC4j < (double)gZdLkdOuUW.Top) ? ((double)gZdLkdOuUW.Top) : ((double)sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS * b1dLsmQC4j));
		double num6 = (((double)sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ * b1dLsmQC4j > (double)gZdLkdOuUW.Right) ? ((double)gZdLkdOuUW.Right) : ((double)sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ * b1dLsmQC4j));
		double num7 = (((double)sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u * b1dLsmQC4j > (double)gZdLkdOuUW.Bottom) ? ((double)gZdLkdOuUW.Bottom) : ((double)sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u * b1dLsmQC4j)) - num5;
		double num8 = num6 - num4;
		num4 -= (double)gZdLkdOuUW.Left;
		num5 -= (double)gZdLkdOuUW.Top;
		if (num4 < 0.0)
		{
			num8 += num4;
			num4 = 0.0;
		}
		if (num5 < 0.0)
		{
			num7 += num5;
			num5 = 0.0;
		}
		Rectangle rectangle_ = new Rectangle((int)num4, (int)num5, (int)num8, (int)num7);
		return jq3gKOPRxplQoOLJZg.z3DL70qh82(iXdLGQt0xX, rectangle_, dpiScale_0);
	}

	internal static bool xtsJgMpcpNEYlyBLZHO()
	{
		return BdeogKpFOOyYv0G5qMx == null;
	}
}
