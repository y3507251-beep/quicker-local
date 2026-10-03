using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WpfLocalizationWithMultipleResourceManagers;

public class TranslationSource : INotifyPropertyChanged
{
	[CompilerGenerated]
	private static readonly TranslationSource gidLQGvr5R;

	private readonly Dictionary<string, ResourceManager> Vy5Ljc6kjL = new Dictionary<string, ResourceManager>();

	private CultureInfo gs3LnRVAiW = CultureInfo.InstalledUICulture;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static TranslationSource fQi170peFS1CGXtXcnG;

	public static TranslationSource Instance
	{
		[CompilerGenerated]
		get
		{
			return gidLQGvr5R;
		}
	}

	public string this[string key]
	{
		get
		{
			(string baseName, string stringName) tuple = SplitName(key);
			string item = tuple.baseName;
			string item2 = tuple.stringName;
			string text = null;
			if (Vy5Ljc6kjL.ContainsKey(item))
			{
				text = Vy5Ljc6kjL[item].GetString(item2, gs3LnRVAiW);
			}
			return text ?? key;
		}
	}

	public CultureInfo CurrentCulture
	{
		get
		{
			return gs3LnRVAiW;
		}
		set
		{
			if (gs3LnRVAiW != value)
			{
				gs3LnRVAiW = value;
				this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public void AddResourceManager(ResourceManager resourceManager)
	{
		if (!Vy5Ljc6kjL.ContainsKey(resourceManager.BaseName))
		{
			Vy5Ljc6kjL.Add(resourceManager.BaseName, resourceManager);
		}
	}

	public static (string baseName, string stringName) SplitName(string name)
	{
		int num = name.LastIndexOf('.');
		return (baseName: name.Substring(0, num), stringName: name.Substring(num + 1));
	}

	static TranslationSource()
	{
		gidLQGvr5R = new TranslationSource();
	}

	internal static bool CUDgTrpjpQDpJoHxGZ4()
	{
		return fQi170peFS1CGXtXcnG == null;
	}
}
