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

public class WindowSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal CheckBox ChkIgnoreNoActivate;

	internal TextBox TxtBlackList;

	private bool ujmtNTH1aLB;

	private static WindowSearchPluginSettingsControl wxBSRSQA7KSFkoENPUt1;

	public WindowSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		if (settings != null)
		{
			if (settings.ContainsKey("BLACK_LIST"))
			{
				TxtBlackList.Text = settings["BLACK_LIST"];
			}
			if (settings.ContainsKey("IGNORE_NO_ACTIVATE"))
			{
				ChkIgnoreNoActivate.IsChecked = settings["IGNORE_NO_ACTIVATE"] == "1";
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["BLACK_LIST"] = TxtBlackList.Text;
		settings["IGNORE_NO_ACTIVATE"] = ((ChkIgnoreNoActivate.IsChecked == true) ? "1" : "0");
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ujmtNTH1aLB)
		{
			ujmtNTH1aLB = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/windowsearchpluginsettingscontrol.xaml", UriKind.Relative);
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
			ujmtNTH1aLB = true;
			break;
		case 2:
			TxtBlackList = (TextBox)target;
			break;
		case 1:
			ChkIgnoreNoActivate = (CheckBox)target;
			break;
		}
	}

	internal static bool AL42O1QA4uX8oH8kmxBn()
	{
		return wxBSRSQA7KSFkoENPUt1 == null;
	}
}
