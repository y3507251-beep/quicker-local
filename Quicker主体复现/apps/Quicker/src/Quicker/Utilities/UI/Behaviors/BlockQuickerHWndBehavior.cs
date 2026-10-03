using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Interop;

namespace Quicker.Utilities.UI.Behaviors;

public static class BlockQuickerHWndBehavior
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static RoutedEventHandler eMr28gpxCkB;

		public static RoutedEventHandler JGI28LXo83o;
	}

	[CompilerGenerated]
	private static readonly ConcurrentDictionary<IntPtr, int> ofuvNaaZOWx;

	public static readonly DependencyProperty IsEnabledProperty;

	internal static object wZBDkwcVqTl6tqBww47e;

	public static ConcurrentDictionary<IntPtr, int> HWnds
	{
		[CompilerGenerated]
		get
		{
			return ofuvNaaZOWx;
		}
	}

	public static bool GetIsEnabled(DependencyObject obj)
	{
		return (bool)obj.GetValue(IsEnabledProperty);
	}

	public static void SetIsEnabled(DependencyObject obj, bool value)
	{
		obj.SetValue(IsEnabledProperty, value);
	}

	private static void wQZvNEJ5G0b(object sender, DependencyPropertyChangedEventArgs e)
	{
		Window window = sender as Window;
		if ((bool)e.NewValue)
		{
			window.Loaded += _003C_003EO.eMr28gpxCkB ?? (_003C_003EO.eMr28gpxCkB = nhTvN8sZNEi);
			window.Unloaded += _003C_003EO.JGI28LXo83o ?? (_003C_003EO.JGI28LXo83o = h45vNyF8Jsl);
		}
		else
		{
			window.Loaded -= _003C_003EO.eMr28gpxCkB ?? (_003C_003EO.eMr28gpxCkB = nhTvN8sZNEi);
			window.Unloaded -= _003C_003EO.JGI28LXo83o ?? (_003C_003EO.JGI28LXo83o = h45vNyF8Jsl);
		}
	}

	private static void h45vNyF8Jsl(object sender, RoutedEventArgs e)
	{
		Window window = sender as Window;
		ofuvNaaZOWx.TryRemove(new WindowInteropHelper(window).Handle, out var value);
		window.Loaded -= _003C_003EO.eMr28gpxCkB ?? (_003C_003EO.eMr28gpxCkB = nhTvN8sZNEi);
		window.Unloaded -= _003C_003EO.JGI28LXo83o ?? (_003C_003EO.JGI28LXo83o = h45vNyF8Jsl);
	}

	private static void nhTvN8sZNEi(object sender, RoutedEventArgs e)
	{
		ofuvNaaZOWx[new WindowInteropHelper(sender as Window).Handle] = 0;
	}

	public static bool IsWindowRegistered(IntPtr hwnd)
	{
		return ofuvNaaZOWx.ContainsKey(hwnd);
	}

	static BlockQuickerHWndBehavior()
	{
		ofuvNaaZOWx = new ConcurrentDictionary<IntPtr, int>();
		IsEnabledProperty = DependencyProperty.RegisterAttached("IsBlockQuickerHWndEnabled", typeof(bool), typeof(Window), new UIPropertyMetadata(false, wQZvNEJ5G0b));
	}

	internal static bool G2stoQcVi4NTceijEfd9()
	{
		return wZBDkwcVqTl6tqBww47e == null;
	}
}
