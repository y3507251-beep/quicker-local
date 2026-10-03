using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfToolkit.Controls;

public class GridView : ListView
{
	public static readonly DependencyProperty OrientationProperty;

	private static GridView cSFrfrpIXTPNFTqYpMQ;

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public GridView()
	{
		FrameworkElementFactory frameworkElementFactory = new FrameworkElementFactory(typeof(VirtualizingWrapPanel));
		frameworkElementFactory.SetBinding(VirtualizingWrapPanel.OrientationProperty, new Binding
		{
			Source = this,
			Path = new PropertyPath("Orientation"),
			Mode = BindingMode.OneWay
		});
		base.ItemsPanel = new ItemsPanelTemplate(frameworkElementFactory);
		VirtualizingPanel.SetCacheLengthUnit(this, VirtualizationCacheLengthUnit.Page);
		VirtualizingPanel.SetCacheLength(this, new VirtualizationCacheLength(1.0));
		VirtualizingPanel.SetIsVirtualizingWhenGrouping(this, true);
		base.ItemContainerStyle = new Style
		{
			Setters = 
			{
				(SetterBase)new Setter
				{
					Property = FrameworkElement.MarginProperty,
					Value = new Thickness(4.0)
				},
				(SetterBase)new Setter
				{
					Property = Control.PaddingProperty,
					Value = new Thickness(4.0)
				}
			}
		};
	}

	static GridView()
	{
		OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(GridView), new FrameworkPropertyMetadata(Orientation.Vertical));
	}

	internal static bool vnlWYmp6gnuyUsV5DxP()
	{
		return cSFrfrpIXTPNFTqYpMQ == null;
	}
}
