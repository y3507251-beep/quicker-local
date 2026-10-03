using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Quicker.View;

public class ListBoxSelectionItemChangedOnMouseUp : ListBox
{
	internal static ListBoxSelectionItemChangedOnMouseUp tVw5VyQzmyP8mVwGUR7u;

	protected override void OnMouseUp(MouseButtonEventArgs e)
	{
		if (e.ChangedButton != MouseButton.Left)
		{
			return;
		}
		DependencyObject dependencyObject = ContainerFromElement((Visual)e.OriginalSource);
		if (dependencyObject == null || !(dependencyObject is FrameworkElement frameworkElement))
		{
			return;
		}
		ListBoxItem listBoxItem = frameworkElement as ListBoxItem;
		if (tVw5VyQzmyP8mVwGUR7u == null)
		{
			switch (0)
			{
			}
		}
		if (listBoxItem != null && base.Items.Contains(listBoxItem))
		{
			base.SelectedItem = listBoxItem;
		}
	}

	protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
	{
		e.Handled = true;
	}

	internal static bool VvhgErQzsiX2mxY4ugcv()
	{
		return tVw5VyQzmyP8mVwGUR7u == null;
	}

	internal static void OVaDcCQzhwGCV8bNQ2kK()
	{
	}
}
