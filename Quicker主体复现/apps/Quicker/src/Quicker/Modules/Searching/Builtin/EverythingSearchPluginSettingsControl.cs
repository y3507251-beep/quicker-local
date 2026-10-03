using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Searching;

namespace Quicker.Modules.Searching.Builtin;

public class EverythingSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal TextBox TxtBlackList;

	internal RadioButton RbSortByName;

	internal RadioButton RbSortByEditTime;

	private bool XvetJD42SkE;

	internal static EverythingSearchPluginSettingsControl iLJ4KHQnkl0uAWeBqJVS;

	public EverythingSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		RbSortByEditTime.IsChecked = true;
		RbSortByName.IsChecked = false;
		TxtBlackList.Text = string.Join("\r\n", "\\WinSxS\\", "\\$Recycle.Bin\\", "C:\\Windows\\Prefetch\\");
		if (settings != null)
		{
			if (settings.TryGetValue("sort", out var value))
			{
				RbSortByName.IsChecked = value == "1";
				RbSortByEditTime.IsChecked = value != "1";
			}
			if (settings.TryGetValue("exclude", out var value2))
			{
				TxtBlackList.Text = value2;
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["sort"] = ((RbSortByName.IsChecked == true) ? "1" : "14");
		settings["exclude"] = TxtBlackList.Text;
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!XvetJD42SkE)
		{
			XvetJD42SkE = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/everythingsearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			XvetJD42SkE = true;
			break;
		case 1:
			TxtBlackList = (TextBox)target;
			break;
		case 2:
			RbSortByName = (RadioButton)target;
			break;
		case 3:
			RbSortByEditTime = (RadioButton)target;
			break;
		}
	}

	internal static bool qZCu03Qnao8x6VBRW4Aq()
	{
		return iLJ4KHQnkl0uAWeBqJVS == null;
	}
}
