using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using MTvu7H59xFIE4dJJH9K;
using Quicker.ScreenSelectLib.Tools;

namespace XAK0Gv5H9h6VY926piI;

internal static class bxlYjy5DCfnONDuA8Y4
{
	private static ProcessDpiAwareness FM9xq8HhtC;

	internal static object dT6I5OIlQrB1KANYe7d;

	[SpecialName]
	public static ProcessDpiAwareness qeTx7nJtKv()
	{
		if (FM9xq8HhtC == (ProcessDpiAwareness)(-1))
		{
			FM9xq8HhtC = XcjxvguO0H();
		}
		return FM9xq8HhtC;
	}

	private static ProcessDpiAwareness XcjxvguO0H()
	{
		ProcessDpiAwareness result = ProcessDpiAwareness.DpiUnaware;
		try
		{
			if (JjfxSjaBXQ(6, 3))
			{
				int int_ = 0;
				if (lTX1EJ5crAHPVuUbPH8.s2Wxi7GCKt(IntPtr.Zero, ref int_) == 0)
				{
					result = (ProcessDpiAwareness)int_;
				}
			}
		}
		catch
		{
			result = ProcessDpiAwareness.DpiUnaware;
		}
		return result;
	}

	private static bool JjfxSjaBXQ(int int_0, int int_1)
	{
		int major = Environment.OSVersion.Version.Major;
		int minor = Environment.OSVersion.Version.Minor;
		if (major == int_0 && minor >= int_1)
		{
			return true;
		}
		if (major > int_0)
		{
			return true;
		}
		return false;
	}

	public static DpiScale WRRx23qOwH(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		return new DpiScale((double)uint_0 / (double)uint_2, (double)uint_1 / (double)uint_3);
	}

	public static DpiScale AtUxu8OsQY()
	{
		QulxEExPYX(out var uint_, out var uint_2);
		return WRRx23qOwH(uint_, uint_2, 96u, 96u);
	}

	public static DpiScale X10xNPmi5s(IntPtr intptr_0)
	{
		Bm5xyXxNAC(intptr_0, out var uint_, out var uint_2);
		QulxEExPYX(out var uint_3, out var uint_4);
		return WRRx23qOwH(uint_, uint_2, uint_3, uint_4);
	}

	public static DpiScale irAxJpnkIN(IntPtr intptr_0)
	{
		Bm5xyXxNAC(intptr_0, out var uint_, out var uint_2);
		return WRRx23qOwH(uint_, uint_2, 96u, 96u);
	}

	public static DpiScale DNPx0HREjr(IntPtr intptr_0)
	{
		hoZxCdSBMu(intptr_0, out var uint_, out var uint_2);
		return WRRx23qOwH(uint_, uint_2, 96u, 96u);
	}

	public static void hoZxCdSBMu(IntPtr intptr_0, out uint uint_0, out uint uint_1)
	{
		uint_0 = 96u;
		uint_1 = 96u;
		ProcessDpiAwareness processDpiAwareness = qeTx7nJtKv();
		if (processDpiAwareness < ProcessDpiAwareness.PerMonitorDpiAware)
		{
			if (processDpiAwareness == ProcessDpiAwareness.SystemDpiAware)
			{
				QulxEExPYX(out uint_0, out uint_1);
			}
		}
		else if (lTX1EJ5crAHPVuUbPH8.jMjxUukK6e(intptr_0, (lTX1EJ5crAHPVuUbPH8.Gfy1Ffu5sCpwbcWtTve)0, ref uint_0, ref uint_1) != 0)
		{
			uint_0 = 96u;
			int num = 0;
			if (!lEacCyIZ5w7WicwpYFE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			uint_1 = 96u;
		}
	}

	public static double WJmxPEK51o(Point point_0)
	{
		hoZxCdSBMu(lTX1EJ5crAHPVuUbPH8.aNUrL2fnOZ(point_0, (lTX1EJ5crAHPVuUbPH8.OofhsFuW6fkX1NgjjXD)0u), out var uint_, out var uint_2);
		return 96.0 / (double)uint_;
	}

	public static void QulxEExPYX(out uint uint_0, out uint uint_1)
	{
		IntPtr intptr_ = lTX1EJ5crAHPVuUbPH8.RfJx11RS3O(IntPtr.Zero);
		int num = lTX1EJ5crAHPVuUbPH8.gn5rIfSO8c(intptr_, 88);
		int num2 = lTX1EJ5crAHPVuUbPH8.gn5rIfSO8c(intptr_, 90);
		uint_0 = ((num > 0) ? ((uint)num) : 96u);
		uint_1 = ((num2 > 0) ? ((uint)num2) : 96u);
	}

	public static void Bm5xyXxNAC(IntPtr intptr_0, out uint uint_0, out uint uint_1)
	{
		hoZxCdSBMu(lTX1EJ5crAHPVuUbPH8.B20rk49MuW(intptr_0), out uint_0, out uint_1);
	}

	public static double HZbx8WLrCD(string string_0 = null)
	{
		IntPtr intPtr = lTX1EJ5crAHPVuUbPH8.kVqreFgULV("DISPLAY", string_0, null, IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return 1.0;
		}
		int num = lTX1EJ5crAHPVuUbPH8.gn5rIfSO8c(intPtr, 10);
		double result = (double)lTX1EJ5crAHPVuUbPH8.gn5rIfSO8c(intPtr, 117) / (double)num;
		lTX1EJ5crAHPVuUbPH8.kHtrYAp3UG(intPtr);
		return result;
	}

	static bxlYjy5DCfnONDuA8Y4()
	{
		FM9xq8HhtC = (ProcessDpiAwareness)(-1);
	}

	internal static bool lEacCyIZ5w7WicwpYFE()
	{
		return dT6I5OIlQrB1KANYe7d == null;
	}

	internal static void yppMRlI8yio76CN77I7()
	{
	}
}
