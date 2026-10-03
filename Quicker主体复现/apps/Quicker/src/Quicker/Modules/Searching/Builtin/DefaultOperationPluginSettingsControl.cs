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

public class DefaultOperationPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal CheckBox ChkEnableRunAsCommand;

	internal CheckBox ChkEnableOpenAsUrl;

	internal TextBox TxtCustomOperations;

	private bool WkqtC0WyqNM;

	internal static DefaultOperationPluginSettingsControl eiPVlMQeOC1pFwBUsqPU;

	public DefaultOperationPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		ChkEnableOpenAsUrl.IsChecked = true;
		ChkEnableRunAsCommand.IsChecked = true;
		if (settings != null)
		{
			if (settings.ContainsKey("CUSTOM_OPERATIONS"))
			{
				TxtCustomOperations.Text = settings["CUSTOM_OPERATIONS"];
			}
			if (settings.ContainsKey("ENABLE_RUN_AS_COMMAND"))
			{
				ChkEnableRunAsCommand.IsChecked = settings["ENABLE_RUN_AS_COMMAND"] == "1";
			}
			if (settings.ContainsKey("ENABLE_OPEN_AS_URL"))
			{
				ChkEnableOpenAsUrl.IsChecked = settings["ENABLE_OPEN_AS_URL"] == "1";
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["CUSTOM_OPERATIONS"] = TxtCustomOperations.Text;
		settings["ENABLE_RUN_AS_COMMAND"] = ((ChkEnableRunAsCommand.IsChecked == true) ? "1" : "0");
		settings["ENABLE_OPEN_AS_URL"] = ((ChkEnableOpenAsUrl.IsChecked == true) ? "1" : "0");
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!WkqtC0WyqNM)
		{
			WkqtC0WyqNM = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/defaultoperationpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			WkqtC0WyqNM = true;
			break;
		case 1:
			ChkEnableRunAsCommand = (CheckBox)target;
			break;
		case 2:
			ChkEnableOpenAsUrl = (CheckBox)target;
			break;
		case 3:
			TxtCustomOperations = (TextBox)target;
			break;
		}
	}

	internal static void iNVTIoQeaNiflYd4pTD0()
	{
	}

	internal static bool VqKjiXQeJNNrjf7pOyVU()
	{
		return eiPVlMQeOC1pFwBUsqPU == null;
	}
}
