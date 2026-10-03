using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Quicker.Themes;

public class SharedResourceDictionary : ResourceDictionary
{
	public static Dictionary<Uri, ResourceDictionary> _sharedDictionaries;

	private Uri adGXVSs72t;

	private static SharedResourceDictionary nMIgEDxay3V8DfhL9IX;

	public new Uri Source
	{
		get
		{
			if (lyeXqK0nYx())
			{
				return base.Source;
			}
			return adGXVSs72t;
		}
		set
		{
			if (lyeXqK0nYx())
			{
				try
				{
					adGXVSs72t = new Uri(value.OriginalString);
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				adGXVSs72t = new Uri(value.OriginalString);
			}
			catch
			{
			}
			if (!_sharedDictionaries.ContainsKey(value))
			{
				base.Source = value;
				_sharedDictionaries.Add(value, this);
			}
			else
			{
				base.MergedDictionaries.Add(_sharedDictionaries[value]);
			}
		}
	}

	[SpecialName]
	private static bool lyeXqK0nYx()
	{
		return (bool)DependencyPropertyDescriptor.FromProperty(DesignerProperties.IsInDesignModeProperty, typeof(DependencyObject)).Metadata.DefaultValue;
	}

	static SharedResourceDictionary()
	{
		_sharedDictionaries = new Dictionary<Uri, ResourceDictionary>();
	}

	internal static bool zg62EDxrpBcPQIpeYAg()
	{
		return nMIgEDxay3V8DfhL9IX == null;
	}
}
