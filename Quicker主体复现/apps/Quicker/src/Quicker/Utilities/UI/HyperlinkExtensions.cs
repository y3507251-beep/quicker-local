using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Navigation;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Utilities.UI;

public static class HyperlinkExtensions
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static RequestNavigateEventHandler DGs2yCCC1kU;
	}

	public static readonly DependencyProperty IsExternalProperty;

	private static object EhBZ2cFzDGE6g5fKa7vI;

	public static bool GetIsExternal(DependencyObject obj)
	{
		return (bool)obj.GetValue(IsExternalProperty);
	}

	public static void SetIsExternal(DependencyObject obj, bool value)
	{
		obj.SetValue(IsExternalProperty, value);
	}

	private static void Xfmvu2W4kbi(object sender, DependencyPropertyChangedEventArgs e)
	{
		Hyperlink hyperlink = sender as Hyperlink;
		if ((bool)e.NewValue)
		{
			hyperlink.RequestNavigate += _003C_003EO.DGs2yCCC1kU ?? (_003C_003EO.DGs2yCCC1kU = H77vuufggCW);
		}
		else
		{
			hyperlink.RequestNavigate -= _003C_003EO.DGs2yCCC1kU ?? (_003C_003EO.DGs2yCCC1kU = H77vuufggCW);
		}
	}

	private static void H77vuufggCW(object sender, RequestNavigateEventArgs e)
	{
		try
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法打开网址：" + ex.Message);
		}
		e.Handled = true;
	}

	static HyperlinkExtensions()
	{
		IsExternalProperty = DependencyProperty.RegisterAttached("IsExternal", typeof(bool), typeof(global::Quicker.Utilities.UI.HyperlinkExtensions), new UIPropertyMetadata(false, Xfmvu2W4kbi));
	}

	internal static bool YyAL3yFz3OIY9vx0CWB4()
	{
		return EhBZ2cFzDGE6g5fKa7vI == null;
	}
}
