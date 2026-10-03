using System.Resources;
using System.Windows;

namespace WpfLocalizationWithMultipleResourceManagers;

public class Translation : DependencyObject
{
	public static readonly DependencyProperty ResourceManagerProperty;

	internal static Translation q3thKkp3NO6Nn2kjU5M;

	public static ResourceManager GetResourceManager(DependencyObject dependencyObject)
	{
		return (ResourceManager)dependencyObject.GetValue(ResourceManagerProperty);
	}

	public static void SetResourceManager(DependencyObject dependencyObject, ResourceManager value)
	{
		dependencyObject.SetValue(ResourceManagerProperty, value);
	}

	static Translation()
	{
		ResourceManagerProperty = DependencyProperty.RegisterAttached("ResourceManager", typeof(ResourceManager), typeof(Translation));
	}

	internal static bool V7SdaUpEwsIUKxKVaWs()
	{
		return q3thKkp3NO6Nn2kjU5M == null;
	}
}
