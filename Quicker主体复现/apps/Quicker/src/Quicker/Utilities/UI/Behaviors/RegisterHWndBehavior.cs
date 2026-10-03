using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Interop;

namespace Quicker.Utilities.UI.Behaviors;

[Obsolete("不再使用。而是反向使用 BlockQuickerHWndBehavior ")]
public static class RegisterHWndBehavior
{
	[CompilerGenerated]
	private static readonly ConcurrentDictionary<IntPtr, int> fDZvNPoT0PC;

	public static readonly DependencyProperty IsEnabledlProperty;

	internal static object su8B1scVo1HMw40S2WEn;

	public static ConcurrentDictionary<IntPtr, int> HWnds
	{
		[CompilerGenerated]
		get
		{
			return fDZvNPoT0PC;
		}
	}

	public static bool GetIsEnabled(DependencyObject obj)
	{
		return false;
	}

	public static void SetIsEnabled(DependencyObject obj, bool value)
	{
	}

	private static void m5yvNJWwTsf(object sender, DependencyPropertyChangedEventArgs e)
	{
	}

	private static void awqvN0ZEmDN(object sender, RoutedEventArgs e)
	{
	}

	private static void dDLvNCeixqd(object sender, RoutedEventArgs e)
	{
		fDZvNPoT0PC[new WindowInteropHelper(sender as Window).Handle] = 0;
	}

	public static bool IsWindowRegistered(IntPtr hwnd)
	{
		return fDZvNPoT0PC.ContainsKey(hwnd);
	}

	static RegisterHWndBehavior()
	{
		fDZvNPoT0PC = new ConcurrentDictionary<IntPtr, int>();
		IsEnabledlProperty = DependencyProperty.RegisterAttached("IsRegisterHWndEnabled", typeof(bool), typeof(Window), new UIPropertyMetadata(false, m5yvNJWwTsf));
	}

	internal static bool dqfOw9cVfMWo9FHwbvA6()
	{
		return su8B1scVo1HMw40S2WEn == null;
	}
}
