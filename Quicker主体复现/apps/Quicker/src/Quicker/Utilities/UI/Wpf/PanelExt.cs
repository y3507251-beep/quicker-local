using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Quicker.Utilities.UI.Wpf;

public static class PanelExt
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public Panel giF2yliIDx0;

		public DependencyPropertyChangedEventArgs N2T2yiycHfT;

		internal static _003C_003Ec__DisplayClass3_0 quhZ4wykYxvtQjKPRc2W;

		internal void Ra32yUuHfNH(object sender, RoutedEventArgs e)
		{
			ApplyChildMargin(giF2yliIDx0, (Thickness?)N2T2yiycHfT.NewValue);
		}

		internal static bool zFgdRHyk8636LKVGblhR()
		{
			return quhZ4wykYxvtQjKPRc2W == null;
		}
	}

	public static readonly DependencyProperty ChildMarginProperty;

	internal static object THhjyKcVFVMs0M5t4Fww;

	public static Thickness? GetChildMargin(Panel obj)
	{
		return (Thickness?)obj.GetValue(ChildMarginProperty);
	}

	public static void SetChildMargin(Panel obj, Thickness? value)
	{
		obj.SetValue(ChildMarginProperty, value);
	}

	private static void BQXvuBGTZdC(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.N2T2yiycHfT = dependencyPropertyChangedEventArgs_0;
		_003C_003Ec__DisplayClass3_.giF2yliIDx0 = dependencyObject_0 as Panel;
		_003C_003Ec__DisplayClass3_.giF2yliIDx0.Loaded += _003C_003Ec__DisplayClass3_.Ra32yUuHfNH;
		ApplyChildMargin(_003C_003Ec__DisplayClass3_.giF2yliIDx0, (Thickness?)_003C_003Ec__DisplayClass3_.N2T2yiycHfT.NewValue);
	}

	public static void ApplyChildMargin(Panel panel, Thickness? margin)
	{
		int childrenCount = VisualTreeHelper.GetChildrenCount(panel);
		object value = (margin.HasValue ? ((object)margin.Value) : DependencyProperty.UnsetValue);
		for (int i = 0; i < childrenCount; i++)
		{
			if (VisualTreeHelper.GetChild(panel, i) is FrameworkElement frameworkElement)
			{
				frameworkElement.SetValue(FrameworkElement.MarginProperty, value);
			}
		}
	}

	static PanelExt()
	{
		ChildMarginProperty = DependencyProperty.RegisterAttached("ChildMargin", typeof(Thickness?), typeof(PanelExt), new PropertyMetadata(null, BQXvuBGTZdC));
	}

	internal static bool DKG2EqcVc1kh5LR9bDkJ()
	{
		return THhjyKcVFVMs0M5t4Fww == null;
	}
}
