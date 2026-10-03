using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using log4net;
using PInvoke;
using Quicker.Domain;
using Quicker.ScreenSelectLib.Tools;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using SnipInsight.Util;

namespace ViNASxihuuLY1Gg9m6p;

internal static class IHNRIiikxBwJdYmHpM3
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public Window Yfw2PeIkEoY;

		public bool CHB2PYo7mo1;

		public double DBQ2PIfsYI6;

		public double Tks2PWVDc5U;

		internal static _003C_003Ec__DisplayClass22_0 jrAHA3yOHLs11DOXJGSp;

		internal void ARU2PZJU3tu(object sender, EventArgs e)
		{
			Yfw2PeIkEoY.InvalidateMeasure();
			CHB2PYo7mo1 = true;
			Yfw2PeIkEoY.SourceInitialized -= ARU2PZJU3tu;
		}

		internal void Tpw2P9n6iqW()
		{
			DBQ2PIfsYI6 = Yfw2PeIkEoY.ActualWidth - DBQ2PIfsYI6;
			Tks2PWVDc5U = Yfw2PeIkEoY.ActualHeight - Tks2PWVDc5U;
		}

		internal void BW72PhUCiF2(object sender, EventArgs e)
		{
			if (CHB2PYo7mo1)
			{
				if (Yfw2PeIkEoY.SizeToContent == SizeToContent.WidthAndHeight)
				{
					Tpw2P9n6iqW();
				}
				Yfw2PeIkEoY.Left -= DBQ2PIfsYI6 * 0.5;
				Yfw2PeIkEoY.Top -= Tks2PWVDc5U * 0.5;
				Yfw2PeIkEoY.LayoutUpdated -= BW72PhUCiF2;
			}
			else
			{
				Tpw2P9n6iqW();
			}
		}

		internal static bool fxCciiyOzLEkln6PIU3Q()
		{
			return jrAHA3yOHLs11DOXJGSp == null;
		}
	}

	private static readonly ILog naVvS2BWaiU;

	internal static object cv3O9oF71RDf6QNuOJO5;

	public static void kf1vv4KqpuC(Window window_0, ShowWindowLocation showWindowLocation_0, string string_0, bool bool_0, bool bool_1 = true)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0.StartsWith("!"))
		{
			Huhvv5Cwh1v(window_0, string_0.Substring(1), showWindowLocation_0, false);
		}
		else if (showWindowLocation_0 != ShowWindowLocation.Manual && !string.IsNullOrEmpty(string_0))
		{
			Huhvv5Cwh1v(window_0, string_0, showWindowLocation_0, bool_0);
		}
		z5HvvDbvaW2(window_0, showWindowLocation_0, string_0, 0.0, bool_1);
	}

	private static void Huhvv5Cwh1v(Window window_0, string string_0, ShowWindowLocation showWindowLocation_0, bool bool_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return;
		}
		if (!bool_0)
		{
			window_0.SizeToContent = SizeToContent.Manual;
			window_0.ClearValue(FrameworkElement.MaxWidthProperty);
			window_0.ClearValue(FrameworkElement.MaxHeightProperty);
		}
		string[] array = string_0.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 2)
		{
			AppHelper.ShowWarning("窗口最大尺寸设置格式不正确。当前值：" + string_0);
			return;
		}
		Screen screen_ = Screen.FromHandle(new WindowInteropHelper(window_0).Handle);
		double dpiScaling = AppHelper.GetDpiScaling(window_0);
		int num = 1;
		if (cv3O9oF71RDf6QNuOJO5 == null)
		{
			goto IL_0082;
		}
		goto IL_011f;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				double num2 = 300.0;
				array[0].Trim();
				try
				{
					num2 = PKlvvTZGC1W(screen_, dpiScaling, array[0], true);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning(exception.GetMessageWithInner());
				}
				if (bool_0)
				{
					window_0.MaxWidth = num2;
				}
				else
				{
					window_0.Width = num2;
				}
				double num3 = 400.0;
				try
				{
					num3 = PKlvvTZGC1W(screen_, dpiScaling, array[1], false);
				}
				catch (Exception exception2)
				{
					AppHelper.ShowWarning(exception2.GetMessageWithInner());
				}
				if (!bool_0)
				{
					window_0.Height = num3;
					num = 0;
					if (eiKl0vF7KccPDvFs2YhY())
					{
						break;
					}
					goto end_IL_0082;
				}
				window_0.MaxHeight = num3;
				return;
			}
			case 0:
				return;
			}
			continue;
			end_IL_0082:
			break;
		}
		goto IL_011f;
		IL_011f:
		int num4 = default(int);
		num = num4;
		goto IL_0082;
	}

	public static void z5HvvDbvaW2(Window window_0, ShowWindowLocation showWindowLocation_0, string string_0 = "", double double_0 = 0.0, bool bool_0 = false)
	{
		window_0.WindowStartupLocation = WindowStartupLocation.Manual;
		int num;
		int num2 = default(int);
		switch (showWindowLocation_0)
		{
		case ShowWindowLocation.Auto:
			window_0.WindowStartupLocation = WindowStartupLocation.Manual;
			break;
		case ShowWindowLocation.WithMouse1:
		case ShowWindowLocation.WithMouse2:
			window_0.WindowStartupLocation = WindowStartupLocation.Manual;
			p1AvvooEqum(window_0, showWindowLocation_0);
			break;
		case ShowWindowLocation.CenterScreen:
			sE6vSvkrdZI(window_0);
			break;
		case ShowWindowLocation.CenterOwner:
			window_0.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			break;
		case ShowWindowLocation.Manual:
		{
			window_0.WindowStartupLocation = WindowStartupLocation.Manual;
			window_0.ClearValue(FrameworkElement.MaxHeightProperty);
			window_0.ClearValue(FrameworkElement.MaxWidthProperty);
			if (string.IsNullOrWhiteSpace(string_0))
			{
				break;
			}
			window_0.WindowStartupLocation = WindowStartupLocation.Manual;
			if (double_0 > 0.0)
			{
				num = 1;
				if (!eiKl0vF7KccPDvFs2YhY())
				{
					goto IL_0139;
				}
				goto IL_013d;
			}
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window_0);
			try
			{
				SY9vvfU8LQC(windowInteropHelper.Handle, string_0, null, bool_0);
				break;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("移动窗口失败：" + ex.Message + "。可能参数不正确，当前值（" + string_0 + "）");
				break;
			}
		}
		case ShowWindowLocation.LastPosition:
		case ShowWindowLocation.ByOffset:
		case ShowWindowLocation.ByCenterLocation:
		case ShowWindowLocation.WorkingArea:
			break;
		case ShowWindowLocation.Maximized:
			window_0.WindowState = WindowState.Maximized;
			num = 0;
			if (!eiKl0vF7KccPDvFs2YhY())
			{
				goto IL_0139;
			}
			goto IL_013d;
		case ShowWindowLocation.TopRight:
		case ShowWindowLocation.BottomRight:
		case ShowWindowLocation.TopLeft:
		case ShowWindowLocation.BottomLeft:
		case ShowWindowLocation.TopCenter:
		case ShowWindowLocation.BottomCenter:
		case ShowWindowLocation.FullScreen:
		case ShowWindowLocation.LeftCenter:
		case ShowWindowLocation.RightCenter:
			{
				window_0.WindowStartupLocation = WindowStartupLocation.Manual;
				KYSvvdMJqcA(window_0, showWindowLocation_0);
				break;
			}
			IL_0139:
			num = num2;
			goto IL_013d;
			IL_013d:
			switch (num)
			{
			case 1:
				D6VvStVGllT(window_0, string_0, double_0);
				break;
			}
			break;
		}
	}

	private static void KYSvvdMJqcA(Window window_0, ShowWindowLocation showWindowLocation_0, bool bool_0 = false)
	{
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(NativeMethods.GetMousePosition());
		Screen screen = Screen.FromPoint(NativeMethods.GetMousePosition());
		Rectangle workingArea = screen.WorkingArea;
		IntPtr handle = new WindowInteropHelper(window_0).Handle;
		int num = (int)(window_0.ActualWidth / dpiScaleByPoint);
		int num2 = (int)(window_0.ActualHeight / dpiScaleByPoint);
		int num3;
		int num4 = default(int);
		switch (showWindowLocation_0)
		{
		case ShowWindowLocation.TopRight:
			oc0vvlUGaGr(handle, workingArea.Right - num, workingArea.Top, bool_0);
			break;
		case ShowWindowLocation.BottomRight:
			oc0vvlUGaGr(handle, workingArea.Right - num, workingArea.Bottom - num2, bool_0);
			break;
		case ShowWindowLocation.TopLeft:
			oc0vvlUGaGr(handle, workingArea.Left, workingArea.Top, bool_0);
			break;
		case ShowWindowLocation.BottomLeft:
			oc0vvlUGaGr(handle, workingArea.Left, workingArea.Bottom - num2, bool_0);
			num3 = 0;
			if (cv3O9oF71RDf6QNuOJO5 != null)
			{
				goto IL_0139;
			}
			goto IL_013d;
		case ShowWindowLocation.TopCenter:
			oc0vvlUGaGr(handle, (workingArea.Right + workingArea.Left - num) / 2, workingArea.Top, bool_0);
			num3 = 1;
			if (cv3O9oF71RDf6QNuOJO5 != null)
			{
				goto IL_0139;
			}
			goto IL_013d;
		case ShowWindowLocation.BottomCenter:
			oc0vvlUGaGr(handle, (workingArea.Right + workingArea.Left - num) / 2, workingArea.Bottom - num2, bool_0);
			break;
		case ShowWindowLocation.FullScreen:
			oYxvviDauVj(handle, screen.Bounds.Left, screen.Bounds.Top, screen.Bounds.Width, screen.Bounds.Height);
			break;
		case ShowWindowLocation.WorkingArea:
			oYxvviDauVj(handle, screen.WorkingArea.Left, screen.WorkingArea.Top, screen.WorkingArea.Width, screen.WorkingArea.Height);
			break;
		default:
			AppHelper.ShowWarning("不支持的位置类型：" + showWindowLocation_0);
			break;
		case ShowWindowLocation.LeftCenter:
			oc0vvlUGaGr(handle, workingArea.Left, (workingArea.Bottom + workingArea.Top - num2) / 2, bool_0);
			break;
		case ShowWindowLocation.RightCenter:
			{
				oc0vvlUGaGr(handle, workingArea.Right - num, (workingArea.Bottom + workingArea.Top - num2) / 2, bool_0);
				break;
			}
			IL_0139:
			num3 = num4;
			goto IL_013d;
			IL_013d:
			switch (num3)
			{
			case 1:
				break;
			}
			break;
		}
	}

	public static void p1AvvooEqum(Window window_0, ShowWindowLocation showWindowLocation_0, int int_0 = 0, int int_1 = 0, bool bool_0 = true, bool bool_1 = false)
	{
		var (int_2, int_3) = WGEvSL7K2PN(window_0, showWindowLocation_0, int_0, int_1, bool_0, false);
		if (!window_0.IsLoaded || !window_0.IsVisible)
		{
			window_0.Show();
		}
		oc0vvlUGaGr(new WindowInteropHelper(window_0).Handle, int_2, int_3, bool_1);
	}

	private static double PKlvvTZGC1W(Screen screen_0, double double_0, string string_0, bool bool_0)
	{
		string text = string_0.Trim();
		double result2;
		if (text.EndsWith("%"))
		{
			if (double.TryParse(text.TrimEnd('%'), out var result))
			{
				if (bool_0)
				{
					return (double)screen_0.WorkingArea.Width * double_0 * result / 100.0;
				}
				return (double)screen_0.WorkingArea.Height * double_0 * result / 100.0;
			}
		}
		else if (double.TryParse(string_0, out result2))
		{
			return result2;
		}
		throw new InvalidDataException("格式不合法：" + string_0);
	}

	internal static int lokvvMJSC74(Screen screen_0, string string_0)
	{
		string text = string_0.Trim();
		double result2;
		if (text.EndsWith("%"))
		{
			if (double.TryParse(text.TrimEnd('%'), out var result))
			{
				return (int)((double)screen_0.WorkingArea.Left + (double)screen_0.WorkingArea.Width * result / 100.0);
			}
		}
		else if (double.TryParse(string_0, out result2))
		{
			return (int)result2;
		}
		throw new InvalidDataException("格式不合法：" + string_0);
	}

	internal static int MLBvvADlx03(Screen screen_0, string string_0)
	{
		string text = string_0.Trim();
		double result2;
		if (text.EndsWith("%"))
		{
			if (double.TryParse(text.TrimEnd('%'), out var result))
			{
				return (int)((double)screen_0.WorkingArea.Top + (double)screen_0.WorkingArea.Height * result / 100.0);
			}
		}
		else if (double.TryParse(string_0, out result2))
		{
			return (int)result2;
		}
		throw new InvalidDataException("格式不合法：" + string_0);
	}

	public static bool TfXvvOk3NGv(double double_0, double double_1)
	{
		if (!(SystemParameters.VirtualScreenLeft > double_0) && !(SystemParameters.VirtualScreenLeft + SystemParameters.VirtualScreenWidth < double_0) && !(SystemParameters.VirtualScreenTop - 50.0 > double_1))
		{
			return SystemParameters.VirtualScreenTop + SystemParameters.VirtualScreenHeight < double_1;
		}
		return true;
	}

	public static bool oCPvvFN9wvL(System.Windows.Point point_0)
	{
		return !TfXvvOk3NGv(point_0.X, point_0.Y);
	}

	public static void GWHvvUGmjWL(Window window_0)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window_0);
		int windowLong = NativeMethods.GetWindowLong(windowInteropHelper.Handle, -20);
		if (NativeMethods.SetWindowLong(windowInteropHelper.Handle, -20, (int)(windowLong | 0x80L | 0x8000000L)) != 0)
		{
			NativeMethods.GetLastError();
		}
	}

	public static void oc0vvlUGaGr(IntPtr intptr_0, int int_0, int int_1, bool bool_0)
	{
		WindowHelper.RestoreWindowIfMaxmized(intptr_0);
		IntPtr hWndInsertAfter = (bool_0 ? User32.SpecialWindowHandles.HWND_TOPMOST : User32.SpecialWindowHandles.HWND_TOP);
		User32.SetWindowPos(intptr_0, hWndInsertAfter, int_0, int_1, 0, 0, User32.SetWindowPosFlags.SWP_DRAWFRAME | User32.SetWindowPosFlags.SWP_NOACTIVATE | User32.SetWindowPosFlags.SWP_NOSIZE);
	}

	public static void oYxvviDauVj(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0 = false)
	{
		while (bool_0)
		{
			if (!eiKl0vF7KccPDvFs2YhY())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			if (!NqKvvz8Eh0J(int_0, int_1, int_2, int_3))
			{
				naVvS2BWaiU.Warn("窗口中心未在任何屏幕内，将其显示在主屏");
				int_1 = 0;
				int_0 = 0;
			}
			break;
		}
		if (int_2 >= 0 && int_3 >= 0)
		{
			WindowHelper.RestoreWindowIfMaxmized(intptr_0);
			NativeMethods.SetWindowPos(intptr_0, NativeMethods.HWND_TOP, int_0, int_1, int_2, int_3, SetWindowPosFlags.SWP_DRAWFRAME | SetWindowPosFlags.SWP_NOACTIVATE);
			naVvS2BWaiU.Info($"更新窗口位置 {int_0},{int_1},{int_0 + int_2},{int_1 + int_3} w:{int_2},h:{int_3}");
		}
		else
		{
			naVvS2BWaiU.Warn($"MoveWindowToScreenLocation出现负数宽度或高度。width:{int_2} height:{int_3}");
		}
	}

	public static void i9avv3X72RU(IntPtr intptr_0, double double_0, double double_1, double double_2, double double_3)
	{
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		Screen screen = Screen.FromPoint(mousePosition);
		double num = new ScreenProperties().GetMonitorInformation(mousePosition).dpiX / 96.0;
		int num2 = (int)Math.Min(double_0 * num, double_2 * (double)screen.WorkingArea.Width);
		int num3 = (int)Math.Min(double_1 * num, double_3 * (double)screen.WorkingArea.Height);
		NativeMethods.MoveWindow(intptr_0, screen.WorkingArea.Left + (screen.WorkingArea.Width - num2) / 2, screen.WorkingArea.Top + (screen.WorkingArea.Height - num3) / 2, num2, num3, false);
	}

	public static void SY9vvfU8LQC(IntPtr intptr_0, string string_0, Screen screen_0 = null, bool bool_0 = false)
	{
		string[] array = string_0.Split(new char[3] { ',', '，', ';' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 4 && array.Length != 2)
		{
			AppHelper.ShowWarning("窗口位置参数格式不正确。当前值：" + string_0);
			return;
		}
		Thickness windowInvisibleWidth = NativeMethods.GetWindowInvisibleWidth(intptr_0);
		int num;
		int num2;
		int num3;
		int num4;
		if (!string_0.Contains("%"))
		{
			num = Convert.ToInt32(array[0]) + (int)windowInvisibleWidth.Left;
			num2 = Convert.ToInt32(array[1]) + (int)windowInvisibleWidth.Top;
			if (array.Length < 4)
			{
				oc0vvlUGaGr(intptr_0, num, num2, false);
				return;
			}
			num3 = Convert.ToInt32(array[2]);
			num4 = 0;
			if (eiKl0vF7KccPDvFs2YhY())
			{
				goto IL_0099;
			}
			goto IL_00b2;
		}
		Screen screen_1 = screen_0 ?? Screen.FromHandle(intptr_0);
		int num5 = lokvvMJSC74(screen_1, array[0]) + (int)windowInvisibleWidth.Left;
		int num6 = MLBvvADlx03(screen_1, array[1]) + (int)windowInvisibleWidth.Top;
		if (array.Length >= 4)
		{
			int num7 = lokvvMJSC74(screen_1, array[2]) - num5 + (int)windowInvisibleWidth.Right;
			int num8 = MLBvvADlx03(screen_1, array[3]) - num6 + (int)windowInvisibleWidth.Bottom;
			naVvS2BWaiU.Info($"移动窗口：{num5},{num6},{num5 + num7},{num6 + num8}  thickness：{windowInvisibleWidth}");
			oYxvviDauVj(intptr_0, num5, num6, num7, num8, bool_0);
		}
		else
		{
			oc0vvlUGaGr(intptr_0, num5, num6, false);
		}
		return;
		IL_00b2:
		int num9 = default(int);
		switch (num4)
		{
		case 1:
			oYxvviDauVj(intptr_0, num, num2, num3 - num + (int)windowInvisibleWidth.Right, num9 - num2 + (int)windowInvisibleWidth.Bottom, bool_0);
			return;
		}
		goto IL_0099;
		IL_0099:
		do
		{
			num9 = Convert.ToInt32(array[3]);
			num4 = 1;
		}
		while (!eiKl0vF7KccPDvFs2YhY());
		goto IL_00b2;
	}

	private static bool NqKvvz8Eh0J(int int_0, int int_1, int int_2, int int_3)
	{
		bool result = false;
		System.Drawing.Point pt = new System.Drawing.Point(int_0 + int_2 / 2, int_1 + int_3 / 2);
		Screen[] allScreens = Screen.AllScreens;
		for (int i = 0; i < allScreens.Length; i++)
		{
			if (allScreens[i].Bounds.Contains(pt))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	internal static bool AfmvSwEMPMe(System.Drawing.Point point_0)
	{
		bool result = false;
		Screen[] allScreens = Screen.AllScreens;
		int num2 = default(int);
		for (int i = 0; i < allScreens.Length; i++)
		{
			if (allScreens[i].Bounds.Contains(point_0))
			{
				int num = 0;
				if (!eiKl0vF7KccPDvFs2YhY())
				{
					num = num2;
				}
				switch (num)
				{
				}
				result = true;
				break;
			}
		}
		return result;
	}

	public static void D6VvStVGllT(Window window_0, string string_0, double double_0)
	{
		string[] array = string_0.Split(new char[3] { ',', '，', ';' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length < 2)
		{
			AppHelper.ShowWarning("窗口位置参数格式不正确。当前值：" + string_0);
			return;
		}
		int num = Convert.ToInt32(array[0]);
		int num2 = Convert.ToInt32(array[1]);
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(new System.Drawing.Point(num, num2));
		int num3 = (int)(double_0 / dpiScaleByPoint);
		oc0vvlUGaGr(new WindowInteropHelper(window_0).Handle, num - num3, num2 - num3, false);
	}

	public static void U4LvSg9Jpi8(Window window_0)
	{
		PresentationSource presentationSource = PresentationSource.FromVisual(window_0);
		double num = ((presentationSource == null || presentationSource.CompositionTarget == null) ? 1.0 : presentationSource.CompositionTarget.TransformFromDevice.M11);
		Screen screen = Screen.FromHandle(new WindowInteropHelper(window_0).Handle);
		if (window_0.ActualHeight > num * (double)screen.WorkingArea.Height)
		{
			window_0.ClearValue(FrameworkElement.MaxHeightProperty);
			window_0.SizeToContent = SizeToContent.Manual;
			int num2 = 0;
			if (!eiKl0vF7KccPDvFs2YhY())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			window_0.WindowState = WindowState.Maximized;
		}
	}

	public static (int left, int top) WGEvSL7K2PN(Window window_0, ShowWindowLocation showWindowLocation_0, int int_0, int int_1, bool bool_0, bool bool_1)
	{
		System.Drawing.Point point = ((ShowWindowLocation.ByCenterLocation != showWindowLocation_0) ? NativeMethods.GetMousePosition() : new System.Drawing.Point(int_0, int_1));
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(point);
		Rectangle workingArea = Screen.FromPoint(point).WorkingArea;
		double num = window_0.Width / dpiScaleByPoint;
		double num2 = window_0.Height / dpiScaleByPoint;
		double num3;
		double num4;
		switch (showWindowLocation_0)
		{
		case ShowWindowLocation.ByOffset:
			num3 = (double)point.X - num / 2.0 + (double)int_0;
			num4 = (double)point.Y - num2 / 2.0 + (double)int_1;
			break;
		default:
			num3 = point.X - 40;
			num4 = point.Y - 60;
			break;
		case ShowWindowLocation.WithMouse1:
		case ShowWindowLocation.ByCenterLocation:
			num3 = (double)point.X - num / 2.0;
			num4 = (double)point.Y - num2 / 2.0;
			break;
		}
		if (bool_0)
		{
			bool flag = false;
			if (num3 < (double)workingArea.Left)
			{
				num3 = workingArea.Left;
				flag = true;
			}
			else if (num3 > (double)workingArea.Right - num)
			{
				num3 = (double)workingArea.Right - num;
				flag = true;
			}
			if (num4 < (double)workingArea.Top)
			{
				num4 = workingArea.Top;
				flag = true;
			}
			else if (num4 > (double)workingArea.Bottom - num2)
			{
				num4 = (double)workingArea.Bottom - num2;
				flag = true;
			}
			if (flag && bool_1)
			{
				Cursor.Position = (Cursor.Position = new System.Drawing.Point((int)(num3 + num / 2.0), (int)(num4 + num2 / 2.0)));
			}
		}
		return (left: (int)num3, top: (int)num4);
	}

	public static void sE6vSvkrdZI(Window window_0)
	{
		int num = 1;
		while (true)
		{
			window_0.WindowStartupLocation = WindowStartupLocation.Manual;
			int num2 = 0;
			if (cv3O9oF71RDf6QNuOJO5 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
			Screen screen = Screen.FromPoint(mousePosition);
			double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(mousePosition);
			Rectangle workingArea = screen.WorkingArea;
			if (!window_0.IsLoaded)
			{
				int num3 = (int)Math.Floor((double)workingArea.Width * dpiScaleByPoint);
				int num4 = (int)Math.Floor((double)workingArea.Height * dpiScaleByPoint);
				window_0.Left = ((double)num3 - window_0.ActualWidth) / 2.0 + (double)workingArea.Left * dpiScaleByPoint;
				window_0.Top = ((double)num4 - window_0.ActualHeight) / 2.0 + (double)workingArea.Top * dpiScaleByPoint;
			}
			else
			{
				oc0vvlUGaGr(new WindowInteropHelper(window_0).Handle, (int)((double)screen.WorkingArea.Left + ((double)screen.WorkingArea.Width - window_0.ActualWidth / dpiScaleByPoint) / 2.0), (int)((double)screen.WorkingArea.Top + ((double)screen.WorkingArea.Height - window_0.ActualHeight / dpiScaleByPoint) / 2.0), false);
			}
			return;
		}
	}

	public static void HyLvSSIkkYN(this Window window_0)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.Yfw2PeIkEoY = window_0;
		_003C_003Ec__DisplayClass22_.CHB2PYo7mo1 = false;
		_003C_003Ec__DisplayClass22_.DBQ2PIfsYI6 = 0.0;
		_003C_003Ec__DisplayClass22_.Tks2PWVDc5U = 0.0;
		_003C_003Ec__DisplayClass22_.Yfw2PeIkEoY.SourceInitialized += _003C_003Ec__DisplayClass22_.ARU2PZJU3tu;
		_003C_003Ec__DisplayClass22_.Yfw2PeIkEoY.LayoutUpdated += _003C_003Ec__DisplayClass22_.BW72PhUCiF2;
	}

	static IHNRIiikxBwJdYmHpM3()
	{
		naVvS2BWaiU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool eiKl0vF7KccPDvFs2YhY()
	{
		return cv3O9oF71RDf6QNuOJO5 == null;
	}
}
