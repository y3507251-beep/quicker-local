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

public class WindowsAppSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal CheckBox ChkIndexEnvPath;

	internal CheckBox ChkIndexSysFolder;

	internal TextBox GreenSoftPathList;

	internal TextBox TxtBlackList;

	private bool nUQtCsTDbMB;

	internal static WindowsAppSearchPluginSettingsControl vHVI7dQeUBs0g2Eyevk9;

	public WindowsAppSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		ChkIndexEnvPath.IsChecked = true;
		ChkIndexSysFolder.IsChecked = true;
		if (settings != null)
		{
			if (settings.ContainsKey("EXTRA_PATH_LIST"))
			{
				GreenSoftPathList.Text = settings["EXTRA_PATH_LIST"];
			}
			if (settings.ContainsKey("EXTRA_BLACKLIST"))
			{
				TxtBlackList.Text = settings["EXTRA_BLACKLIST"];
			}
			if (settings.ContainsKey("INDEX_ENVIROMENT_PATH"))
			{
				ChkIndexEnvPath.IsChecked = settings["INDEX_ENVIROMENT_PATH"] == "1";
			}
			if (settings.ContainsKey("INDEX_SYSTEM_FOLDER"))
			{
				ChkIndexSysFolder.IsChecked = settings["INDEX_SYSTEM_FOLDER"] == "1";
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["EXTRA_PATH_LIST"] = GreenSoftPathList.Text;
		settings["EXTRA_BLACKLIST"] = TxtBlackList.Text;
		settings["INDEX_ENVIROMENT_PATH"] = ((ChkIndexEnvPath.IsChecked == true) ? "1" : "0");
		settings["INDEX_SYSTEM_FOLDER"] = ((ChkIndexSysFolder.IsChecked == true) ? "1" : "0");
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!nUQtCsTDbMB)
		{
			nUQtCsTDbMB = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/windowsappsearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			nUQtCsTDbMB = true;
			break;
		case 1:
			ChkIndexEnvPath = (CheckBox)target;
			break;
		case 2:
			ChkIndexSysFolder = (CheckBox)target;
			break;
		case 3:
			GreenSoftPathList = (TextBox)target;
			break;
		case 4:
			TxtBlackList = (TextBox)target;
			break;
		}
	}

	internal static bool kbsJJsQexmTq65mWIe3C()
	{
		return vHVI7dQeUBs0g2Eyevk9 == null;
	}
}
