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

public class BrowserHistorySearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal TextBox TxtBlackList;

	private bool WWetCCCw6nt;

	internal static BrowserHistorySearchPluginSettingsControl IlZYmWQerGFaaHw6dtwU;

	public BrowserHistorySearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		if (settings != null && settings.ContainsKey("blacklist"))
		{
			TxtBlackList.Text = settings["blacklist"];
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["blacklist"] = TxtBlackList.Text;
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!WWetCCCw6nt)
		{
			WWetCCCw6nt = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/browserhistorysearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TxtBlackList = (TextBox)target;
		}
		else
		{
			WWetCCCw6nt = true;
		}
	}

	internal static bool FORZiDQeNuPcORCnyFuU()
	{
		return IlZYmWQerGFaaHw6dtwU == null;
	}
}
