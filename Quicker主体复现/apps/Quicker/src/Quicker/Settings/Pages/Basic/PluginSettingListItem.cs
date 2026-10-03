using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;

namespace Quicker.Settings.Pages.Basic;

public class PluginSettingListItem : INotifyPropertyChanged
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec G7fvhrVFjpE;

		public static Func<SearchTrigger, string> T0cvhpQYbWY;

		private static _003C_003Ec s70pyecbAIFTvHOj7dXN;

		static _003C_003Ec()
		{
			G7fvhrVFjpE = new _003C_003Ec();
		}

		internal string CQKvhxBaAw9(SearchTrigger t)
		{
			return t.TriggerWord.Replace(" ", "⎵");
		}

		internal static bool P2Yx04cbn35y5uFQTPvX()
		{
			return s70pyecbAIFTvHOj7dXN == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings f9oMNYjSP2;

	[CompilerGenerated]
	private SearchPlugin lOLMJmPiDX;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static PluginSettingListItem hUI2tL4xDGo2IrK3Tig;

	public string PluginId => Plugin.Id;

	public string PluginName => Plugin.PluginInfo.Name;

	public string PluginDescription => Plugin.PluginInfo.Description;

	public string PluginIcon => Plugin.PluginInfo.Icon;

	public bool IncludeInGlobal => Settings.IncludeInGlobalSearch;

	public double GlobalSearchWeight => Settings.GlobalSearchWeight;

	public string TriggerWords
	{
		get
		{
			if (!Settings.Triggers.HasData())
			{
				return "";
			}
			return string.Join(" ", Settings.Triggers.Select(_003C_003Ec.T0cvhpQYbWY ?? (_003C_003Ec.T0cvhpQYbWY = _003C_003Ec.G7fvhrVFjpE.CQKvhxBaAw9)));
		}
	}

	public bool IsEnabled
	{
		get
		{
			return Settings.IsEnabled;
		}
		set
		{
			Settings.IsEnabled = value;
			OnPropertyChanged("IsEnabled");
		}
	}

	public SearchPluginSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return f9oMNYjSP2;
		}
	}

	public SearchPlugin Plugin
	{
		[CompilerGenerated]
		get
		{
			return lOLMJmPiDX;
		}
		[CompilerGenerated]
		set
		{
			lOLMJmPiDX = value;
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

	public PluginSettingListItem(SearchPlugin plugin, SearchPluginSettings settings)
	{
		Plugin = plugin;
		f9oMNYjSP2 = settings;
		if (string.IsNullOrEmpty(Settings.PluginId))
		{
			Settings.PluginId = plugin.Id;
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool p5BTnE4I5WNwZuHTLtx()
	{
		return hUI2tL4xDGo2IrK3Tig == null;
	}
}
