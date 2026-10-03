using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using MTvu7H59xFIE4dJJH9K;
using Quicker.ScreenSelectLib.Tools;
using ssVc8F5V5BPQdafyZEi;

namespace zr5vAB5vDEPwCkpSC6R;

internal class G9VJ2H5FA4DCooQHERD : IDisposable
{
	private Rectangle TvPrlC2yTh;

	private Bitmap Sk3riLN0R2;

	private double NGbr35TnYd;

	private static G9VJ2H5FA4DCooQHERD SkptGy6GYeW9JYd1YId;

	[SpecialName]
	public Bitmap PcIrFkFlSC()
	{
		return Sk3riLN0R2;
	}

	public void Dispose()
	{
		if (Sk3riLN0R2 != null)
		{
			Sk3riLN0R2.Dispose();
		}
		GC.SuppressFinalize(this);
	}

	~G9VJ2H5FA4DCooQHERD()
	{
		if (Sk3riLN0R2 != null)
		{
			Sk3riLN0R2.Dispose();
		}
	}

	public void uZMrAkVZ95(Rectangle rectangle_1, double double_1)
	{
		NGbr35TnYd = double_1;
		TvPrlC2yTh = new Rectangle((int)((double)rectangle_1.Left * NGbr35TnYd), (int)((double)rectangle_1.Top * NGbr35TnYd), (int)((double)rectangle_1.Width * NGbr35TnYd), (int)((double)rectangle_1.Height * NGbr35TnYd));
		Bitmap sk3riLN0R = uVl3oF5gw329ne6sMi2.zigr4uD9ct(IntPtr.Zero, TvPrlC2yTh.Left, TvPrlC2yTh.Top, TvPrlC2yTh.Width, TvPrlC2yTh.Height);
		Sk3riLN0R2 = sk3riLN0R;
	}

	public Bitmap Dt5rOGM528(lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0, DpiScale dpiScale_0)
	{
		if (NGbr35TnYd != 1.0)
		{
			dpiScale_0 = new DpiScale(dpiScale_0.X * NGbr35TnYd, dpiScale_0.Y * NGbr35TnYd);
		}
		double num = (((double)uqwBGEdQOmobi3k3BTZ_0.crGvqbYWVF6 * NGbr35TnYd < (double)TvPrlC2yTh.Left) ? ((double)TvPrlC2yTh.Left) : ((double)uqwBGEdQOmobi3k3BTZ_0.crGvqbYWVF6 * NGbr35TnYd));
		int num2 = 1;
		if (SkptGy6GYeW9JYd1YId != null)
		{
			goto IL_0164;
		}
		goto IL_0168;
		IL_0164:
		int num3 = default(int);
		num2 = num3;
		goto IL_0168;
		IL_0168:
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		do
		{
			double num7;
			double num8;
			switch (num2)
			{
			case 1:
				num5 = (((double)uqwBGEdQOmobi3k3BTZ_0.mP6vq6MOjic * NGbr35TnYd < (double)TvPrlC2yTh.Top) ? ((double)TvPrlC2yTh.Top) : ((double)uqwBGEdQOmobi3k3BTZ_0.mP6vq6MOjic * NGbr35TnYd));
				num7 = (((double)uqwBGEdQOmobi3k3BTZ_0.tRZvqXJG8BS * NGbr35TnYd > (double)TvPrlC2yTh.Right) ? ((double)TvPrlC2yTh.Right) : ((double)uqwBGEdQOmobi3k3BTZ_0.tRZvqXJG8BS * NGbr35TnYd));
				num8 = (((double)uqwBGEdQOmobi3k3BTZ_0.t1ivqmCnUM7 * NGbr35TnYd > (double)TvPrlC2yTh.Bottom) ? ((double)TvPrlC2yTh.Bottom) : ((double)uqwBGEdQOmobi3k3BTZ_0.t1ivqmCnUM7 * NGbr35TnYd));
				break;
			default:
			{
				if (num < 0.0)
				{
					num4 += num;
					num = 0.0;
				}
				if (num5 < 0.0)
				{
					num6 += num5;
					num5 = 0.0;
				}
				Rectangle rectangle_ = new Rectangle((int)num, (int)num5, (int)num4, (int)num6);
				return uVl3oF5gw329ne6sMi2.abfr5jOZBg(Sk3riLN0R2, rectangle_, dpiScale_0);
			}
			}
			num6 = num8 - num5;
			num4 = num7 - num;
			num -= (double)TvPrlC2yTh.Left;
			num5 -= (double)TvPrlC2yTh.Top;
			num2 = 0;
		}
		while (RIYScu608j5S2Il8IWt());
		goto IL_0164;
	}

	internal static bool RIYScu608j5S2Il8IWt()
	{
		return SkptGy6GYeW9JYd1YId == null;
	}
}
