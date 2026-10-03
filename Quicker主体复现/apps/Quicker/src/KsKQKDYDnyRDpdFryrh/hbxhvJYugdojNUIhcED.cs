using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Editing;
using Quicker.View.UI;

namespace KsKQKDYDnyRDpdFryrh;

internal class hbxhvJYugdojNUIhcED : Adorner
{
	private readonly SearchReplacePanel zKFLyZoWBY6;

	private static hbxhvJYugdojNUIhcED yich08FGftfxXpeiv8wN;

	protected override int VisualChildrenCount => 1;

	public hbxhvJYugdojNUIhcED(TextArea textArea_0, SearchReplacePanel searchReplacePanel_1)
		: base(textArea_0)
	{
		zKFLyZoWBY6 = searchReplacePanel_1;
		AddVisualChild(searchReplacePanel_1);
	}

	protected override Visual GetVisualChild(int index)
	{
		if (index != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return zKFLyZoWBY6;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		zKFLyZoWBY6.Arrange(new Rect(new Point(0.0, 0.0), finalSize));
		return new Size(zKFLyZoWBY6.ActualWidth, zKFLyZoWBY6.ActualHeight);
	}

	internal static bool foto8cFGbDE5lY44tey8()
	{
		return yich08FGftfxXpeiv8wN == null;
	}
}
