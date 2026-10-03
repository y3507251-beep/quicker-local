using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;

namespace IeliWVi9GQPYQVRofrZ;

internal class Rvq3HeicUwD6VERTNqt : Adorner
{
	private readonly ContentPresenter contentPresenter;

	internal static Rvq3HeicUwD6VERTNqt MtIPViFz5YuiH0UEZ9oD;

	protected override int VisualChildrenCount => 1;

	private Control Control => (Control)base.AdornedElement;

	public Rvq3HeicUwD6VERTNqt(UIElement uielement_0, object object_0)
		: base(uielement_0)
	{
		base.IsHitTestVisible = false;
		contentPresenter = new ContentPresenter();
		contentPresenter.Content = object_0;
		contentPresenter.Opacity = 0.5;
		contentPresenter.Margin = new Thickness(Control.Margin.Left + Control.Padding.Left, Control.Margin.Top + Control.Padding.Top, 0.0, 0.0);
		if (Control is ItemsControl && !(Control is ComboBox))
		{
			contentPresenter.VerticalAlignment = VerticalAlignment.Center;
			contentPresenter.HorizontalAlignment = HorizontalAlignment.Center;
		}
		Binding binding = new Binding("IsVisible")
		{
			Source = uielement_0,
			Converter = new BooleanToVisibilityConverter()
		};
		SetBinding(UIElement.VisibilityProperty, binding);
	}

	protected override Visual GetVisualChild(int index)
	{
		return contentPresenter;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		contentPresenter.Measure(Control.RenderSize);
		return Control.RenderSize;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		contentPresenter.Arrange(new Rect(finalSize));
		return finalSize;
	}

	internal static bool z3SU4MFzYjwwgeWnbDO8()
	{
		return MtIPViFz5YuiH0UEZ9oD == null;
	}
}
