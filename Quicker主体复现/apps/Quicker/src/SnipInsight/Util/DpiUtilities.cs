using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using jeaU1l2eVVj4W2gaVc;

namespace SnipInsight.Util;

public static class DpiUtilities
{
	private static ProcessDpiAwareness nbqi6abDk;

	internal static object kr4HHrWJ4RIUeTpJmLS;

	public static ProcessDpiAwareness DpiAwareness
	{
		get
		{
			if (nbqi6abDk == (ProcessDpiAwareness)(-1))
			{
				nbqi6abDk = aW0OcEbNc();
			}
			return nbqi6abDk;
		}
	}

	private static ProcessDpiAwareness aW0OcEbNc()
	{
		ProcessDpiAwareness result = ProcessDpiAwareness.DpiUnaware;
		try
		{
			if (kfkFoxNIm(6, 3))
			{
				int int_ = 0;
				if (OO77uFW4jgnwuPwqBc.QZmtGOXtkF(IntPtr.Zero, ref int_) == 0)
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

	private static bool kfkFoxNIm(int int_0, int int_1)
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

	public static DpiScale CalculateScale(uint dpi1X, uint dpi1Y, uint dpi2X, uint dpi2Y)
	{
		return new DpiScale((double)dpi1X / (double)dpi2X, (double)dpi1Y / (double)dpi2Y);
	}

	public static DpiScale GetSystemScale()
	{
		GetSystemEffectiveDpi(out var dpiX, out var dpiY);
		return CalculateScale(dpiX, dpiY, 96u, 96u);
	}

	public static DpiScale GetWindowScale(Window window)
	{
		return GetWindowScale(OO77uFW4jgnwuPwqBc.uIKgtYo8ob(window));
	}

	public static DpiScale GetWindowScale(IntPtr hwnd)
	{
		GetWindowEffectiveDpi(hwnd, out var dpiX, out var dpiY);
		GetSystemEffectiveDpi(out var dpiX2, out var dpiY2);
		return CalculateScale(dpiX, dpiY, dpiX2, dpiY2);
	}

	public static DpiScale GetVirtualPixelScale(Window window)
	{
		return GetVirtualPixelScale(OO77uFW4jgnwuPwqBc.uIKgtYo8ob(window));
	}

	public static DpiScale GetVirtualPixelScale(IntPtr hwnd)
	{
		GetWindowEffectiveDpi(hwnd, out var dpiX, out var dpiY);
		return CalculateScale(dpiX, dpiY, 96u, 96u);
	}

	public static DpiScale GetVirtualPixelScaleByMonitor(IntPtr hMonitor)
	{
		GetMonitorEffectiveDpi(hMonitor, out var dpiX, out var dpiY);
		return CalculateScale(dpiX, dpiY, 96u, 96u);
	}

	public static void GetMonitorEffectiveDpi(IntPtr hMonitor, out uint dpiX, out uint dpiY)
	{
		dpiX = 96u;
		dpiY = 96u;
		ProcessDpiAwareness dpiAwareness = DpiAwareness;
		if (dpiAwareness >= ProcessDpiAwareness.PerMonitorDpiAware)
		{
			if (OO77uFW4jgnwuPwqBc.obdtWHKGtx(hMonitor, (OO77uFW4jgnwuPwqBc.l1CVdnmgKVFwCrLHRwQ)0, ref dpiX, ref dpiY) != 0)
			{
				dpiX = 96u;
				dpiY = 96u;
			}
		}
		else if (dpiAwareness == ProcessDpiAwareness.SystemDpiAware)
		{
			GetSystemEffectiveDpi(out dpiX, out dpiY);
			int num = 0;
			if (!sjcnohWkNdZu6u9CUAr())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	public static double GetDpiScaleByPoint(System.Drawing.Point point)
	{
		GetMonitorEffectiveDpi(OO77uFW4jgnwuPwqBc.iQmtmpU4fF(point, (OO77uFW4jgnwuPwqBc.OHrPKkmvyWlWe2UcC9T)0u), out var dpiX, out var dpiY);
		return 96.0 / (double)dpiX;
	}

	public static double GetDpiScaleByPoint()
	{
		return GetDpiScaleByPoint(Cursor.Position);
	}

	public static void GetSystemEffectiveDpi(out uint dpiX, out uint dpiY)
	{
		IntPtr intptr_ = OO77uFW4jgnwuPwqBc.CuMtPghyV8(IntPtr.Zero);
		int num = OO77uFW4jgnwuPwqBc.OX3tzoM4et(intptr_, 88);
		int num2 = OO77uFW4jgnwuPwqBc.OX3tzoM4et(intptr_, 90);
		dpiX = ((num > 0) ? ((uint)num) : 96u);
		dpiY = ((num2 > 0) ? ((uint)num2) : 96u);
	}

	public static void GetWindowEffectiveDpi(Window window, out uint dpiX, out uint dpiY)
	{
		GetWindowEffectiveDpi(OO77uFW4jgnwuPwqBc.uIKgtYo8ob(window), out dpiX, out dpiY);
	}

	public static void GetWindowEffectiveDpi(IntPtr hwnd, out uint dpiX, out uint dpiY)
	{
		GetMonitorEffectiveDpi(OO77uFW4jgnwuPwqBc.N7ggg78LZg(hwnd), out dpiX, out dpiY);
	}

	public static double GetScreenScalingFactor(string deviceName = null)
	{
		IntPtr intPtr = OO77uFW4jgnwuPwqBc.v6ct34MHW3("DISPLAY", deviceName, null, IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return 1.0;
		}
		int num = OO77uFW4jgnwuPwqBc.OX3tzoM4et(intPtr, 10);
		double result = (double)OO77uFW4jgnwuPwqBc.OX3tzoM4et(intPtr, 117) / (double)num;
		OO77uFW4jgnwuPwqBc.MNjtf6Dtq0(intPtr);
		return result;
	}

	static DpiUtilities()
	{
		nbqi6abDk = (ProcessDpiAwareness)(-1);
	}

	internal static bool sjcnohWkNdZu6u9CUAr()
	{
		return kr4HHrWJ4RIUeTpJmLS == null;
	}
}
