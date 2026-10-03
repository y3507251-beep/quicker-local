using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Quicker.Annotations;

namespace Quicker.Utilities.UI;

public class MarginSetter
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static RoutedEventHandler Hxe2PkJIYCG;
	}

	public static readonly DependencyProperty MarginProperty;

	public static readonly DependencyProperty LastItemMarginProperty;

	internal static MarginSetter B6pQS1F4ESbbb9Qrgdwo;

	private static Thickness SXwvSJryu05(Panel panel_0)
	{
		return (Thickness)panel_0.GetValue(LastItemMarginProperty);
	}

	[UsedImplicitly]
	public static Thickness GetMargin(DependencyObject obj)
	{
		return (Thickness)obj.GetValue(MarginProperty);
	}

	private static void RJJvS0BvclW(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (sender is Panel panel)
		{
			panel.Loaded -= _003C_003EO.Hxe2PkJIYCG ?? (_003C_003EO.Hxe2PkJIYCG = DDNvSCknmUg);
			panel.Loaded += _003C_003EO.Hxe2PkJIYCG ?? (_003C_003EO.Hxe2PkJIYCG = DDNvSCknmUg);
			if (panel.IsLoaded)
			{
				DDNvSCknmUg(panel, null);
			}
		}
	}

	private static void DDNvSCknmUg(object panel_0Input, RoutedEventArgs routedEventArgs_0)
	{
        Panel panel_0 = (Panel)panel_0Input;
		Panel panel = panel_0;
		for (int i = 0; i < panel.Children.Count; i++)
		{
			if (!OhOuaVF4GSjqJAoZ1Irb())
			{
				switch (0)
				{
				}
			}
			if (panel.Children[i] is FrameworkElement frameworkElement)
			{
				bool flag = i == panel.Children.Count - 1;
				frameworkElement.Margin = (flag ? SXwvSJryu05(panel) : GetMargin(panel));
			}
		}
	}

	[UsedImplicitly]
	public static void SetLastItemMargin(DependencyObject obj, Thickness value)
	{
		obj.SetValue(LastItemMarginProperty, value);
	}

	[UsedImplicitly]
	public static void SetMargin(DependencyObject obj, Thickness value)
	{
		obj.SetValue(MarginProperty, value);
	}

	static MarginSetter()
	{
		MarginProperty = DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(MarginSetter), new UIPropertyMetadata(default(Thickness), RJJvS0BvclW));
		LastItemMarginProperty = DependencyProperty.RegisterAttached("LastItemMargin", typeof(Thickness), typeof(MarginSetter), new UIPropertyMetadata(default(Thickness), RJJvS0BvclW));
	}

	internal static bool OhOuaVF4GSjqJAoZ1Irb()
	{
		return B6pQS1F4ESbbb9Qrgdwo == null;
	}
}
