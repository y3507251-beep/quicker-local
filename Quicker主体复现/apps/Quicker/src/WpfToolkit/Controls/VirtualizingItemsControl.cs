using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfToolkit.Controls;

public class VirtualizingItemsControl : ItemsControl
{
	internal static VirtualizingItemsControl ohPQcCph6Hm1PRHuanX;

	public VirtualizingItemsControl()
	{
		base.ItemsPanel = new ItemsPanelTemplate(new FrameworkElementFactory(typeof(VirtualizingStackPanel)));
		string xamlText = "\r\n            <ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>\r\n                <Border\r\n                    BorderThickness='{TemplateBinding Border.BorderThickness}'\r\n                    Padding='{TemplateBinding Control.Padding}'\r\n                    BorderBrush='{TemplateBinding Border.BorderBrush}'\r\n                    Background='{TemplateBinding Panel.Background}'\r\n                    SnapsToDevicePixels='True'>\r\n                    <ScrollViewer\r\n                        Padding='{TemplateBinding Control.Padding}'\r\n                        Focusable='False'>\r\n                        <ItemsPresenter\r\n                            SnapsToDevicePixels='{TemplateBinding UIElement.SnapsToDevicePixels}'/>\r\n                    </ScrollViewer>\r\n                </Border>\r\n            </ControlTemplate>";
		base.Template = (ControlTemplate)XamlReader.Parse(xamlText);
		ScrollViewer.SetCanContentScroll(this, true);
		ScrollViewer.SetVerticalScrollBarVisibility(this, ScrollBarVisibility.Auto);
		ScrollViewer.SetHorizontalScrollBarVisibility(this, ScrollBarVisibility.Auto);
		VirtualizingPanel.SetCacheLengthUnit(this, VirtualizationCacheLengthUnit.Page);
		VirtualizingPanel.SetCacheLength(this, new VirtualizationCacheLength(1.0));
		VirtualizingPanel.SetIsVirtualizingWhenGrouping(this, true);
	}

	internal static bool qk2NkypH6mf4EefQ4aX()
	{
		return ohPQcCph6Hm1PRHuanX == null;
	}
}
