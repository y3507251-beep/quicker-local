using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace QgRgOKGpI8sIATMykx;

internal static class xgMMIvIMwQJoofV480
{
	private static object vtmpWW3N2V0GpQ7Ufq9;

	public static FrameworkElement p7LJKkI8nb(DependencyObject dependencyObject_0, string string_0)
	{
		if (dependencyObject_0 == null)
		{
			return null;
		}
		Queue<DependencyObject> queue = new Queue<DependencyObject>();
		queue.Enqueue(dependencyObject_0);
		while (queue.Count > 0)
		{
			dependencyObject_0 = queue.Dequeue();
			int childrenCount = VisualTreeHelper.GetChildrenCount(dependencyObject_0);
			for (int i = 0; i < childrenCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(dependencyObject_0, i);
				if (!(child is FrameworkElement frameworkElement) || !(frameworkElement.Name == string_0))
				{
					queue.Enqueue(child);
					continue;
				}
				return frameworkElement;
			}
		}
		return null;
	}

	internal static bool jCgXyR394J2AF2Y7MFx()
	{
		return vtmpWW3N2V0GpQ7Ufq9 == null;
	}
}
