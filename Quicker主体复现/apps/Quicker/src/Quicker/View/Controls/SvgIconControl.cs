using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Quicker.View.Controls;

public class SvgIconControl : Viewbox
{
	public static readonly DependencyProperty ForegroundProperty;

	public static readonly DependencyProperty IconProperty;

	private static SvgIconControl Wluv69FqFKTZmSuvhnbG;

	public Brush Foreground
	{
		get
		{
			return (Brush)GetValue(ForegroundProperty);
		}
		set
		{
			SetValue(ForegroundProperty, value);
		}
	}

	public SvgIcon Icon
	{
		get
		{
			return (SvgIcon)GetValue(IconProperty);
		}
		set
		{
			SetValue(IconProperty, value);
		}
	}

	private static void vhULjvLOgHK(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is SvgIconControl svgIconControl)
		{
			svgIconControl.v6pLjSiSxDr();
		}
	}

	private void v6pLjSiSxDr()
	{
		if (Icon == null)
		{
			base.Visibility = Visibility.Collapsed;
			return;
		}
		base.Visibility = Visibility.Visible;
		Child = oruLj2AZjcI();
	}

	private UIElement oruLj2AZjcI()
	{
		return new Path
		{
			Data = Geometry.Parse(Icon.Path),
			Width = Icon.Width,
			Height = Icon.Height,
			Fill = Foreground
		};
	}

	static SvgIconControl()
	{
		ForegroundProperty = DependencyProperty.Register("Foreground", typeof(Brush), typeof(SvgIconControl), new PropertyMetadata(Brushes.Black, vhULjvLOgHK));
		IconProperty = DependencyProperty.Register("Icon", typeof(SvgIcon), typeof(SvgIconControl), new PropertyMetadata(null, vhULjvLOgHK));
	}

	internal static bool mgxtC6Fqc9LYAuJeifDK()
	{
		return Wluv69FqFKTZmSuvhnbG == null;
	}

	internal static void CB4cesFqpRGRMecAnmDs()
	{
	}
}
