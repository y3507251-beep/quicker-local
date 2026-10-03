using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Domain.Searching.Actions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.Settings.Pages.Features;

public class SearchPluginSettingsWindow : System.Windows.Window, IComponentConnector, IStyleConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec modv9j0b7aQ;

		public static Func<SearchTrigger, SearchTriggerDto> BB5v9nA3PMQ;

		public static Func<SearchTriggerDto, bool> gTUv94YShwh;

		public static Func<SearchTriggerDto, SearchTrigger> QKCv95ChOv3;

		private static _003C_003Ec ktXV4bcoOv6iXFGRWUIu;

		static _003C_003Ec()
		{
			modv9j0b7aQ = new _003C_003Ec();
		}

		internal SearchTriggerDto s9jv9pRsZdE(SearchTrigger x)
		{
			return new SearchTriggerDto(x);
		}

		internal bool r15v9BZxeZT(SearchTriggerDto x)
		{
			return !string.IsNullOrEmpty(x.TriggerWord);
		}

		internal SearchTrigger TYSv9Qe0LlG(SearchTriggerDto x)
		{
			return x.ToSearchTrigger();
		}

		internal static bool A19HNpcoJ8GeH2uKf91J()
		{
			return ktXV4bcoOv6iXFGRWUIu == null;
		}
	}

	private readonly SearchPlugin T0Xd22YXhm;

	[CompilerGenerated]
	private readonly SmartCollection<SearchTriggerDto> t5wdubDZjK = new SmartCollection<SearchTriggerDto>();

	private SearchPluginSettings FkPdNYLs7S;

	private IPluginSettingsControl DhrdJfKf7n;

	[CompilerGenerated]
	private bool? L5od00biMD;

	internal GroupBox PnlGlobal;

	internal ToggleButton ChkIncludeInGlobal;

	internal NumericUpDown TxtGlobalWeight;

	internal NumericUpDown TxtGlobalTriggerLength;

	internal StackPanel PnlGlobalCondition;

	internal System.Windows.Controls.TextBox TxtGlobalSearchCondition;

	internal ListView LvTriggers;

	internal Button BtnAddTrigger;

	internal TextBlock TxtConditionNote;

	internal GroupBox PnlPluginSettings;

	internal ContentControl PluginSettingHost;

	internal Button BtnRestoreDefault;

	internal CheckBox ChkShowSearchHistory;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool lpJdCaYhI2;

	private static SearchPluginSettingsWindow G8peAYs9Raa9pP2wbCZ;

	public new SmartCollection<SearchTriggerDto> Triggers
	{
		[CompilerGenerated]
		get
		{
			return t5wdubDZjK;
		}
	}

	public SearchPluginSettings ResultSettings
	{
		get
		{
			FkPdNYLs7S.IncludeInGlobalSearch = ChkIncludeInGlobal.IsChecked == true;
			FkPdNYLs7S.GlobalSearchWeight = TxtGlobalWeight.Value;
			FkPdNYLs7S.MinGlobalTriggerLength = (int)TxtGlobalTriggerLength.Value;
			FkPdNYLs7S.GlobalSearchCondition = TxtGlobalSearchCondition.Text;
			FkPdNYLs7S.ShowSearchHistory = ChkShowSearchHistory.IsChecked == true;
			FkPdNYLs7S.Triggers = Triggers.Where(_003C_003Ec.gTUv94YShwh ?? (_003C_003Ec.gTUv94YShwh = _003C_003Ec.modv9j0b7aQ.r15v9BZxeZT)).Select(_003C_003Ec.QKCv95ChOv3 ?? (_003C_003Ec.QKCv95ChOv3 = _003C_003Ec.modv9j0b7aQ.TYSv9Qe0LlG)).ToList();
			if (DhrdJfKf7n != null)
			{
				int num = 0;
				if (G8peAYs9Raa9pP2wbCZ != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				DhrdJfKf7n.SaveData(dictionary);
				FkPdNYLs7S.CustomSettings = dictionary;
			}
			return FkPdNYLs7S;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return L5od00biMD;
		}
		[CompilerGenerated]
		set
		{
			L5od00biMD = value;
		}
	}

	public SearchPluginSettingsWindow(SearchPluginSettings settings, SearchPlugin plugin)
	{
		T0Xd22YXhm = plugin;
		InitializeComponent();
		if (plugin is ICreateSettingUI createSettingUI)
		{
			DhrdJfKf7n = createSettingUI.CreateSettingsControl();
			PluginSettingHost.Content = DhrdJfKf7n;
			PnlPluginSettings.Visibility = Visibility.Visible;
		}
		base.Title = plugin.PluginInfo.Name + " - 搜索插件设置";
		if (!plugin.IsSupportCondition)
		{
			PnlGlobalCondition.Visibility = Visibility.Collapsed;
			(LvTriggers.View as GridView)?.Columns.RemoveAt(1);
			TxtConditionNote.Visibility = Visibility.Collapsed;
		}
		else if (string.IsNullOrEmpty(plugin.PluginInfo.ConditionNote))
		{
			TxtConditionNote.Visibility = Visibility.Collapsed;
		}
		else
		{
			TxtConditionNote.Text = plugin.PluginInfo.ConditionNote;
		}
		LvTriggers.ItemsSource = Triggers;
		FkPdNYLs7S = AppHelper.Clone(settings);
		pvXDfglcjj();
		if (plugin is QuickerActionSearchPlugin)
		{
			TxtGlobalTriggerLength.Value = 0.0;
			TxtGlobalTriggerLength.IsEnabled = false;
		}
		base.Loaded += E5KD3DMWDI;
	}

	private void E5KD3DMWDI(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(ajrdSwHhGP);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void pvXDfglcjj()
	{
		if (!T0Xd22YXhm.IsSupportHistory)
		{
			ChkShowSearchHistory.Visibility = Visibility.Collapsed;
		}
		Triggers.Reset(FkPdNYLs7S.Triggers.Select(_003C_003Ec.BB5v9nA3PMQ ?? (_003C_003Ec.BB5v9nA3PMQ = _003C_003Ec.modv9j0b7aQ.s9jv9pRsZdE)));
		ChkIncludeInGlobal.IsChecked = FkPdNYLs7S.IncludeInGlobalSearch;
		TxtGlobalWeight.Value = FkPdNYLs7S.GlobalSearchWeight;
		TxtGlobalTriggerLength.Value = FkPdNYLs7S.MinGlobalTriggerLength;
		TxtGlobalSearchCondition.Text = FkPdNYLs7S.GlobalSearchCondition;
		ChkShowSearchHistory.IsChecked = FkPdNYLs7S.ShowSearchHistory;
		IPluginSettingsControl dhrdJfKf7n = DhrdJfKf7n;
		if (dhrdJfKf7n == null)
		{
			return;
		}
		dhrdJfKf7n.LoadData(FkPdNYLs7S.CustomSettings ?? new Dictionary<string, string>());
		if (!PvQAp3sLQ9uImMBEjBa())
		{
			switch (0)
			{
			}
		}
	}

	private void MmQDzWQW8y(object sender, RoutedEventArgs e)
	{
		Triggers.Add(new SearchTriggerDto());
	}

	private void vIadwhXRvD(object sender, RoutedEventArgs e)
	{
		SearchTriggerDto item = ((Button)sender).Tag as SearchTriggerDto;
		Triggers.Remove(item);
	}

	private void FvIdtjGkTn(object sender, RoutedEventArgs e)
	{
		if (DhrdJfKf7n != null)
		{
			(bool, string) tuple = DhrdJfKf7n.IsValid();
			if (!tuple.Item1)
			{
				AppHelper.ShowWarning(tuple.Item2);
				return;
			}
		}
		this.ThNvuM5Q9GQ(true);
	}

	private void cwYdgDuphv(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void qLxdLCe3oL(object sender, TextChangedEventArgs e)
	{
		System.Windows.Controls.TextBox obj = (System.Windows.Controls.TextBox)sender;
		string text = (obj.Text = obj.Text.Replace(' ', '⎵'));
		obj.CaretIndex = text.Length;
	}

	private void dkVdv148iw(object sender, RoutedEventArgs e)
	{
		FkPdNYLs7S = AppHelper.Clone(T0Xd22YXhm.DefaultSettings);
		pvXDfglcjj();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lpJdCaYhI2)
		{
			lpJdCaYhI2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/features/searchpluginsettingswindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 1:
			PnlGlobal = (GroupBox)target;
			return;
		case 2:
			ChkIncludeInGlobal = (ToggleButton)target;
			return;
		case 3:
			TxtGlobalWeight = (NumericUpDown)target;
			return;
		case 4:
			TxtGlobalTriggerLength = (NumericUpDown)target;
			return;
		case 5:
			PnlGlobalCondition = (StackPanel)target;
			return;
		case 6:
			TxtGlobalSearchCondition = (System.Windows.Controls.TextBox)target;
			return;
		case 7:
			LvTriggers = (ListView)target;
			return;
		default:
			lpJdCaYhI2 = true;
			return;
		case 10:
			BtnAddTrigger = (Button)target;
			BtnAddTrigger.Click += MmQDzWQW8y;
			return;
		case 11:
			TxtConditionNote = (TextBlock)target;
			return;
		case 12:
			PnlPluginSettings = (GroupBox)target;
			num = 0;
			if (G8peAYs9Raa9pP2wbCZ != null)
			{
				return;
			}
			break;
		case 13:
			PluginSettingHost = (ContentControl)target;
			return;
		case 14:
			BtnRestoreDefault = (Button)target;
			BtnRestoreDefault.Click += dkVdv148iw;
			return;
		case 15:
			ChkShowSearchHistory = (CheckBox)target;
			return;
		case 16:
			BtnOk = (Button)target;
			BtnOk.Click += FvIdtjGkTn;
			return;
		case 17:
			BtnCancel = (Button)target;
			BtnCancel.Click += cwYdgDuphv;
			num = 1;
			if (!PvQAp3sLQ9uImMBEjBa())
			{
				int num2 = default(int);
				num = num2;
			}
			break;
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 9:
			((Button)target).Click += vIadwhXRvD;
			break;
		case 8:
			((System.Windows.Controls.TextBox)target).TextChanged += qLxdLCe3oL;
			break;
		}
	}

	[CompilerGenerated]
	private void ajrdSwHhGP()
	{
		UIHelper.MaximizeWindowIfTooHigh(this);
	}

	internal static bool PvQAp3sLQ9uImMBEjBa()
	{
		return G8peAYs9Raa9pP2wbCZ == null;
	}
}
