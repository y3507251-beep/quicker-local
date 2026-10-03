using System.Windows;
using Quicker.Annotations;

namespace Quicker.Utilities.UI;

public class Spacing
{
	public static readonly DependencyProperty VerticalProperty;

	public static readonly DependencyProperty HorizontalProperty;

	private static Spacing mMgpbjF4BYLmIvI4xsf1;

	public static double GetHorizontal(DependencyObject obj)
	{
		return (double)obj.GetValue(HorizontalProperty);
	}

	public static double GetVertical(DependencyObject obj)
	{
		return (double)obj.GetValue(VerticalProperty);
	}

	private static void ntbvSPAy1EP(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		double right = (double)dependencyPropertyChangedEventArgs_0.NewValue;
		DependencyObject obj = dependencyObject_0;
		MarginSetter.SetMargin(obj, new Thickness(0.0, 0.0, right, 0.0));
		MarginSetter.SetLastItemMargin(obj, new Thickness(0.0));
	}

	[UsedImplicitly]
	public static void SetHorizontal(DependencyObject obj, double space)
	{
		obj.SetValue(HorizontalProperty, space);
	}

	[UsedImplicitly]
	public static void SetVertical(DependencyObject obj, double value)
	{
		obj.SetValue(VerticalProperty, value);
	}

	private static void lc2vSEiBjup(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		double bottom = (double)dependencyPropertyChangedEventArgs_0.NewValue;
		DependencyObject obj = dependencyObject_0;
		MarginSetter.SetMargin(obj, new Thickness(0.0, 0.0, 0.0, bottom));
		MarginSetter.SetLastItemMargin(obj, new Thickness(0.0));
	}

	static Spacing()
	{
		VerticalProperty = DependencyProperty.RegisterAttached("Vertical", typeof(double), typeof(Spacing), new UIPropertyMetadata(0.0, lc2vSEiBjup));
		HorizontalProperty = DependencyProperty.RegisterAttached("Horizontal", typeof(double), typeof(Spacing), new UIPropertyMetadata(0.0, ntbvSPAy1EP));
	}

	internal static bool CPjw8XF4vC1VlcPbe0WG()
	{
		return mMgpbjF4BYLmIvI4xsf1 == null;
	}
}
