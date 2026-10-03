using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain.Services;
using Quicker.Settings.Code;
using Quicker.View.Controls;

namespace Quicker.Settings;

public class SettingPageSearcherControl : UserControl, IComponentConnector, IStyleConnector
{
	internal SearchBoxControl TxtSearch;

	internal Popup Popup;

	internal ListBox LbMenu;

	private bool rZpjtJDEVW;

	internal static SettingPageSearcherControl Ku8jQ6SXy2ix7LcYdtV;

	public SettingPageSearcherControl()
	{
		InitializeComponent();
	}

	private void SearchBoxControl_OnSearchTextChanged(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrWhiteSpace(TxtSearch.SearchText))
		{
			Popup.IsOpen = false;
			return;
		}
		IList<SettingPageInfo> list = SettingsMenuProvider.SearchPage(TxtSearch.SearchText);
		if (list.Count > 0)
		{
			LbMenu.ItemsSource = list;
			Popup.IsOpen = true;
		}
	}

	private void TxtSearch_OnPreviewKeyDown(object sender, KeyEventArgs e)
	{
		if (!Popup.IsOpen)
		{
			return;
		}
		int num;
		if (e.Key == Key.Down)
		{
			num = 1;
			if (!TUqGMXS2wkgN21Cx7ls())
			{
				goto IL_0077;
			}
			goto IL_007b;
		}
		goto IL_00ad;
		IL_007b:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (LbMenu.Items.Count <= 0)
				{
					break;
				}
				if (LbMenu.SelectedIndex >= 0)
				{
					if (LbMenu.SelectedIndex >= LbMenu.Items.Count - 1)
					{
						break;
					}
					goto IL_006a;
				}
				LbMenu.SelectedIndex = 0;
				break;
			default:
				LbMenu.SelectedIndex++;
				break;
			}
			break;
			IL_006a:
			num = 0;
			if (Ku8jQ6SXy2ix7LcYdtV == null)
			{
				continue;
			}
			goto IL_0077;
		}
		goto IL_00ad;
		IL_00ad:
		if (e.Key == Key.Up && LbMenu.Items.Count > 0)
		{
			if (LbMenu.SelectedIndex >= 0)
			{
				if (LbMenu.SelectedIndex > 0)
				{
					LbMenu.SelectedIndex--;
				}
			}
			else
			{
				LbMenu.SelectedIndex = LbMenu.Items.Count - 1;
			}
		}
		if (e.Key == Key.Return && LbMenu.SelectedItem != null)
		{
			AppWindowManager.ShowSettingsWindow((LbMenu.SelectedItem as SettingPageInfo).Id);
			Popup.IsOpen = false;
			TxtSearch.SearchText = "";
		}
		return;
		IL_0077:
		int num2 = default(int);
		num = num2;
		goto IL_007b;
	}

	public void SetFocus()
	{
		TxtSearch.SetFocus();
	}

	private void z3fQzaF7GJ(object sender, MouseButtonEventArgs e)
	{
		if (LbMenu.SelectedItem != null)
		{
			Popup.IsOpen = false;
			AppWindowManager.ShowSettingsWindow((LbMenu.SelectedItem as SettingPageInfo).Id);
		}
	}

	private void YoxjwyuqsA(object sender, MouseButtonEventArgs e)
	{
		if (LbMenu.SelectedItem != null)
		{
			Popup.IsOpen = false;
			AppWindowManager.ShowSettingsWindow((LbMenu.SelectedItem as SettingPageInfo).Id);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!rZpjtJDEVW)
		{
			rZpjtJDEVW = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/settingpagesearchercontrol.xaml", UriKind.Relative);
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
		default:
			rZpjtJDEVW = true;
			break;
		case 1:
			TxtSearch = (SearchBoxControl)target;
			break;
		case 2:
			Popup = (Popup)target;
			break;
		case 3:
			LbMenu = (ListBox)target;
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 4)
		{
			((StackPanel)target).MouseLeftButtonUp += YoxjwyuqsA;
		}
	}

	internal static bool TUqGMXS2wkgN21Cx7ls()
	{
		return Ku8jQ6SXy2ix7LcYdtV == null;
	}
}
