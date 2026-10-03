using System.Windows;
using System.Windows.Controls;

namespace Quicker.View.Controls;

public class ToolTipControl : Control
{
	private static ToolTipControl VM74QiFoIpqLL3HmfdQL;

	static ToolTipControl()
	{
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ToolTipControl), new FrameworkPropertyMetadata(typeof(ToolTipControl)));
	}

	public ToolTipControl()
	{
		base.IsTabStop = false;
		base.Focusable = false;
	}

	internal static bool g7CnKGFo6lUMZpXbwHNe()
	{
		return VM74QiFoIpqLL3HmfdQL == null;
	}
}
