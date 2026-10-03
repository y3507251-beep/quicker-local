using System;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Xaml;

namespace WpfLocalizationWithMultipleResourceManagers;

public class LocExtension : MarkupExtension
{
	[CompilerGenerated]
	private readonly string z2ZL5krq7M;

	private static LocExtension zUW3qfp1iZWHt4hxvxT;

	public string StringName
	{
		[CompilerGenerated]
		get
		{
			return z2ZL5krq7M;
		}
	}

	public LocExtension(string stringName)
	{
		z2ZL5krq7M = stringName;
	}

	private ResourceManager zOtL4JcYM4(object object_0)
	{
		if (object_0 is DependencyObject dependencyObject)
		{
			object obj = dependencyObject.ReadLocalValue(Translation.ResourceManagerProperty);
			if (obj != DependencyProperty.UnsetValue && obj is ResourceManager resourceManager)
			{
				TranslationSource.Instance.AddResourceManager(resourceManager);
				return resourceManager;
			}
		}
		return null;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
        string text = default;
		object obj = (serviceProvider as IProvideValueTarget)?.TargetObject;
		if (obj?.GetType().Name == "SharedDp")
		{
			return obj;
		}
		ResourceManager resourceManager = zOtL4JcYM4(obj);
		int num;
		if (resourceManager == null)
		{
			num = 1;
			if (zUW3qfp1iZWHt4hxvxT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00c0;
		}
		object obj2 = resourceManager.BaseName;
		if (obj2 != null)
		{
			goto IL_005d;
		}
		goto IL_0083;
		IL_00c0:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00d0;
		}
		obj2 = null;
		goto IL_0083;
		IL_00ff:
		object obj3;
		text = (string)obj3;
		goto IL_0101;
		IL_00bc:
		object obj4;
		text = (string)obj4;
		goto IL_0068;
		IL_005d:
		text = (string)obj2;
		if (!string.IsNullOrEmpty(text))
		{
			goto IL_0068;
		}
		object object_ = (serviceProvider as IRootObjectProvider)?.RootObject;
		ResourceManager resourceManager2 = zOtL4JcYM4(object_);
		if (resourceManager2 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = resourceManager2.BaseName;
			if (obj4 != null)
			{
				goto IL_00bc;
			}
		}
		obj4 = string.Empty;
		goto IL_00bc;
		IL_0083:
		obj2 = string.Empty;
		goto IL_005d;
		IL_0101:
		Binding binding = new Binding();
		binding.Mode = BindingMode.OneWay;
		binding.Path = new PropertyPath("[" + text + "." + StringName + "]");
		binding.Source = TranslationSource.Instance;
		binding.FallbackValue = StringName;
		return binding.ProvideValue(serviceProvider);
		IL_0068:
		if (string.IsNullOrEmpty(text))
		{
			num = 0;
			if (zUW3qfp1iZWHt4hxvxT != null)
			{
				goto IL_00c0;
			}
			goto IL_00d0;
		}
		goto IL_0101;
		IL_00d0:
		if (obj is FrameworkElement frameworkElement)
		{
			ResourceManager resourceManager3 = zOtL4JcYM4(frameworkElement.TemplatedParent);
			if (resourceManager3 == null)
			{
				obj3 = null;
			}
			else
			{
				obj3 = resourceManager3.BaseName;
				if (obj3 != null)
				{
					goto IL_00ff;
				}
			}
			obj3 = string.Empty;
			goto IL_00ff;
		}
		goto IL_0101;
	}

	internal static bool bsWrp5pKmv0Gq1kXG68()
	{
		return zUW3qfp1iZWHt4hxvxT == null;
	}
}
