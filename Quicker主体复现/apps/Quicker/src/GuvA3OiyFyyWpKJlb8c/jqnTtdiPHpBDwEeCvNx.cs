using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;

namespace GuvA3OiyFyyWpKJlb8c;

internal static class jqnTtdiPHpBDwEeCvNx
{
	private static object pZX1M1cVe7fa6hUIYO6J;

	public static bool IL8vudVpbi3(this Window window_0)
	{
		return (bool)typeof(Window).GetField("_showingAsDialog", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(window_0);
	}

	public static bool b4UvuoyFdfP(this Window window_0)
	{
		return (bool)typeof(Window).GetField("_isClosing", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(window_0);
	}

	public static wNrAFZi4h7pCWeaZo1r qK6vuTvuZiE<wNrAFZi4h7pCWeaZo1r>(this Window window_0) where wNrAFZi4h7pCWeaZo1r : Window
	{
		foreach (object ownedWindow in window_0.OwnedWindows)
		{
			if (ownedWindow is wNrAFZi4h7pCWeaZo1r result)
			{
				return result;
			}
		}
		return null;
	}

	public static void ThNvuM5Q9GQ(this Window window_0, bool bool_0)
	{
		if (window_0.DialogResult.HasValue || window_0.b4UvuoyFdfP())
		{
			return;
		}
		if (!window_0.IL8vudVpbi3())
		{
			try
			{
				if (window_0 is IMockModalWindow mockModalWindow)
				{
					mockModalWindow.Result = bool_0;
					window_0.Close();
				}
				else
				{
					window_0.Close();
				}
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		try
		{
			if (!window_0.DialogResult.HasValue)
			{
				window_0.DialogResult = bool_0;
			}
		}
		catch (Exception ex2)
		{
			AppHelper.ShowWarning($"为{window_0}设置DialogResult异常：" + ex2.Message);
		}
	}

	public static void aJDvuAkk8hZ(this Window window_0)
	{
		window_0.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern int jVMvuO0s9rO(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
	private static extern int qNQvuFDoaME(IntPtr intptr_0, int int_0, int int_1);

	internal static void I08vuUqpcxG(this Window window_0)
	{
		IntPtr handle = new WindowInteropHelper(window_0).Handle;
		int num = jVMvuO0s9rO(handle, -16);
		qNQvuFDoaME(handle, -16, num & -65537 & -131073);
	}

	public static bool ObVvullZt5r(this Window window_0)
	{
		if (window_0.IsLoaded && window_0.IsVisible)
		{
			return !Application.Current.Windows.OfType<Window>().Contains(window_0);
		}
		return true;
	}

	public static bool zmGvuiv40H0(this Window window_0)
	{
		if (window_0 != null && window_0.IsLoaded && window_0.IsVisible)
		{
			return Application.Current.Windows.OfType<Window>().Contains(window_0);
		}
		return false;
	}

	internal static bool hdeEmIcVjbLAoAm1N27I()
	{
		return pZX1M1cVe7fa6hUIYO6J == null;
	}
}
