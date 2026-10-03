using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Hotkeys;
using Quicker.Utilities;
using Quicker.View.Hotkeys;

namespace Quicker.Settings.Pages.Triggers;

public class ActionHotkeysSettingPage : SettingPage, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private ObservableCollection<ActionHotKeyItem> ojPoq1xLNk = new ObservableCollection<ActionHotKeyItem>();

	internal CheckBox ChkOrderByProc;

	internal ListView LvHotKeys;

	internal MenuItem MenuDelete;

	internal Button BtnNew;

	internal TextBlock LblLimit;

	private bool W1HocPGvge;

	private static ActionHotkeysSettingPage fesDoVCrNAaZeCE12JB;

	public ObservableCollection<ActionHotKeyItem> _list
	{
		[CompilerGenerated]
		get
		{
			return ojPoq1xLNk;
		}
		[CompilerGenerated]
		private set
		{
			ojPoq1xLNk = value;
		}
	}

	public ActionHotkeysSettingPage()
	{
		InitializeComponent();
		{
			LblLimit.Visibility = Visibility.Collapsed;
		}
		ChkOrderByProc.IsChecked = AppState.DataService.UserPreference?.SettingsHotKeyGroupBy == "process";
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		if (LvHotKeys.ItemsSource != null)
		{
			return;
		}
		CollectionView itemsSource = (CollectionView)CollectionViewSource.GetDefaultView(_list);
		euPoywTKFj();
		LvHotKeys.ItemsSource = itemsSource;
		HotKeySettings hotKeySettings = HotKeySettings.FromData(settings.HotKeysData);
		_list.Clear();
		foreach (ActionHotKeyItem actionHotkey in hotKeySettings.ActionHotkeys)
		{
			if (AppState.DataService.QHmtXwg81eY(actionHotkey.ActionId).action == null)
			{
				actionHotkey.IsEnabled = false;
				actionHotkey.Title = (actionHotkey.Title.StartsWith("动作已删除") ? actionHotkey.Title : ("动作已删除：" + actionHotkey.Title));
			}
			_list.Add(actionHotkey);
		}
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		HotKeySettings hotKeySettings = HotKeySettings.FromData(settings.HotKeysData);
		hotKeySettings.ActionHotkeys = _list.ToList();
		settings.HotKeysData = hotKeySettings.ToData();
		return true;
	}

	private void bAqoJ7PwcR(object sender, RoutedEventArgs e)
	{
		ActionHotkeyEditorWindow actionHotkeyEditorWindow = new ActionHotkeyEditorWindow
		{
			Owner = Window.GetWindow(this)
		};
		if (actionHotkeyEditorWindow.ShowDialog() == true)
		{
			_list.Add(actionHotkeyEditorWindow.ResultItem);
		}
	}

	private void S32o0jo8Hi(object sender, RoutedEventArgs e)
	{
		ActionHotKeyItem actionHotKeyItem_ = (sender as Button).Tag as ActionHotKeyItem;
		NvqoCMdMrW(actionHotKeyItem_);
	}

	private void NvqoCMdMrW(ActionHotKeyItem actionHotKeyItem_0)
	{
		ActionHotkeyEditorWindow actionHotkeyEditorWindow = new ActionHotkeyEditorWindow
		{
			Owner = Window.GetWindow(this),
			EditingItem = actionHotKeyItem_0
		};
		if (actionHotkeyEditorWindow.ShowDialog() == true)
		{
			_list[_list.IndexOf(actionHotKeyItem_0)] = actionHotkeyEditorWindow.ResultItem;
		}
	}

	private void elooPQpIWT(object sender, RoutedEventArgs e)
	{
		ActionHotKeyItem item = (sender as Button).Tag as ActionHotKeyItem;
		_list.Remove(item);
	}

	private void xndoEWgnG0(object sender, RoutedEventArgs e)
	{
		AppState.DataService.UserPreference.SettingsHotKeyGroupBy = ((ChkOrderByProc.IsChecked == true) ? "process" : "");
		AppState.DataService.tbAtXR5TON1();
		euPoywTKFj();
	}

	private void euPoywTKFj()
	{
		CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(_list);
		if (collectionView.GroupDescriptions == null)
		{
			int num = 0;
			if (!K154FTCNqjsmwo7WEeg())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		collectionView.GroupDescriptions.Clear();
		if (AppState.DataService.UserPreference?.SettingsHotKeyGroupBy == "process")
		{
			PropertyGroupDescription item = new PropertyGroupDescription("BindingProcessName");
			collectionView.GroupDescriptions.Add(item);
			collectionView.SortDescriptions.Add(new SortDescription("BindingProcessName", ListSortDirection.Ascending));
			collectionView.SortDescriptions.Add(new SortDescription("Keys", ListSortDirection.Ascending));
		}
		else
		{
			PropertyGroupDescription item2 = new PropertyGroupDescription("Keys");
			collectionView.GroupDescriptions.Add(item2);
			collectionView.SortDescriptions.Add(new SortDescription("Keys", ListSortDirection.Ascending));
			collectionView.SortDescriptions.Add(new SortDescription("BindingProcessName", ListSortDirection.Ascending));
		}
	}

	private void WPdo8d3OHy(object sender, RoutedEventArgs e)
	{
		if (LvHotKeys.SelectedItems.Count > 0 && AppHelper.Confirm($"您确认要删除 {LvHotKeys.SelectedItems.Count} 条规则么？\r\n删除后将无法恢复。"))
		{
			LvHotKeys.SelectedItems.Cast<ActionHotKeyItem>().ToList().ForEach(LCco7Mf8mB);
		}
	}

	private void CkEoa2PyYL(object sender, MouseButtonEventArgs e)
	{
		if (((ListViewItem)sender).Content is ActionHotKeyItem actionHotKeyItem_)
		{
			NvqoCMdMrW(actionHotKeyItem_);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!W1HocPGvge)
		{
			W1HocPGvge = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/actionhotkeyssettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			ChkOrderByProc = (CheckBox)target;
			ChkOrderByProc.Click += xndoEWgnG0;
			break;
		case 2:
		{
			LvHotKeys = (ListView)target;
			int num = 0;
			if (!K154FTCNqjsmwo7WEeg())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 3:
			MenuDelete = (MenuItem)target;
			MenuDelete.Click += WPdo8d3OHy;
			break;
		default:
			W1HocPGvge = true;
			break;
		case 7:
			BtnNew = (Button)target;
			BtnNew.Click += bAqoJ7PwcR;
			break;
		case 8:
			LblLimit = (TextBlock)target;
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
		case 4:
			((Button)target).Click += S32o0jo8Hi;
			break;
		case 5:
			((Button)target).Click += elooPQpIWT;
			break;
		case 6:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(CkEoa2PyYL);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	[CompilerGenerated]
	private void LCco7Mf8mB(ActionHotKeyItem actionHotKeyItem_0)
	{
		if (_list.Contains(actionHotKeyItem_0))
		{
			_list.Remove(actionHotKeyItem_0);
		}
	}

	internal static bool K154FTCNqjsmwo7WEeg()
	{
		return fesDoVCrNAaZeCE12JB == null;
	}
}
