using System.Windows;
using System.Windows.Controls;

namespace Quicker.View.X.Nodes;

public class StepListBox : ListBox
{
	public static readonly DependencyProperty IsDragOverProperty;

	internal static StepListBox vY9jeMFrMZFlNI2IyMrx;

	public bool IsDragOver
	{
		get
		{
			return (bool)GetValue(IsDragOverProperty);
		}
		set
		{
			SetValue(IsDragOverProperty, value);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new StepListBoxItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is StepListBoxItem;
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		base.OnDragEnter(e);
		IsDragOver = true;
	}

	protected override void OnDragLeave(DragEventArgs e)
	{
		base.OnDragLeave(e);
		IsDragOver = false;
	}

	protected override void OnDrop(DragEventArgs e)
	{
		base.OnDrop(e);
		IsDragOver = false;
	}

	static StepListBox()
	{
		IsDragOverProperty = DependencyProperty.Register("IsDragOver", typeof(bool), typeof(StepListBox), new PropertyMetadata(false));
	}

	internal static bool VmnLf5FrUVlpEpQF5hRt()
	{
		return vY9jeMFrMZFlNI2IyMrx == null;
	}

	internal static void TSXjUEFrISoR6Iim09ok()
	{
	}
}
