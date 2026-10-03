using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;

namespace Quicker.Modules.Searching;

public class ResultGroupItem : INotifyPropertyChanged
{
	[CompilerGenerated]
	private SearchPluginItem x8IturmuRrg;

	[CompilerGenerated]
	private int VnvtupBo6cR;

	[CompilerGenerated]
	private string DurtuBjfEhG;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ResultGroupItem zJeBD1QApsU8mfqF1gbv;

	public SearchPluginItem PluginItem
	{
		[CompilerGenerated]
		get
		{
			return x8IturmuRrg;
		}
		[CompilerGenerated]
		set
		{
			x8IturmuRrg = value;
		}
	}

	public int Count
	{
		[CompilerGenerated]
		get
		{
			return VnvtupBo6cR;
		}
		[CompilerGenerated]
		set
		{
			VnvtupBo6cR = value;
		}
	}

	public string ContentName
	{
		[CompilerGenerated]
		get
		{
			return DurtuBjfEhG;
		}
		[CompilerGenerated]
		set
		{
			DurtuBjfEhG = value;
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

	public ResultGroupItem(SearchPluginItem pluginItem, int count)
	{
		PluginItem = pluginItem;
		Count = count;
		ContentName = pluginItem.Plugin.PluginInfo.SearchContentName.Or(pluginItem.Plugin.PluginInfo.Name);
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public override string ToString()
	{
		return PluginItem.Plugin.PluginInfo.Name ?? "";
	}

	internal static bool kW9ZBKQAXYGtbHfXohlI()
	{
		return zJeBD1QApsU8mfqF1gbv == null;
	}
}
