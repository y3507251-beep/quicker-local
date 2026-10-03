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

public class LocalFileSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal TextBox TxtPathList;

	internal TextBox TxtBlackList;

	internal CheckBox ChkIndexFolder;

	internal TextBox TxtExtList;

	private bool VWAtCP7VFXX;

	internal static LocalFileSearchPluginSettingsControl XKUhjNQeLxO6v7vArIp8;

	public LocalFileSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		ChkIndexFolder.IsChecked = true;
		if (settings != null)
		{
			if (settings.ContainsKey("PATH_LIST"))
			{
				TxtPathList.Text = settings["PATH_LIST"];
			}
			if (settings.ContainsKey("EXT_LIST"))
			{
				TxtExtList.Text = settings["EXT_LIST"];
			}
			if (settings.ContainsKey("BLACK_LIST"))
			{
				TxtBlackList.Text = settings["BLACK_LIST"];
			}
			else
			{
				TxtBlackList.Text = ".git;.svn;node_modules;";
			}
			if (settings.ContainsKey("INDEX_FOLDER"))
			{
				ChkIndexFolder.IsChecked = settings["INDEX_FOLDER"] == "1";
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["PATH_LIST"] = TxtPathList.Text;
		settings["EXT_LIST"] = TxtExtList.Text;
		settings["BLACK_LIST"] = TxtBlackList.Text;
		settings["INDEX_FOLDER"] = ((ChkIndexFolder.IsChecked == true) ? "1" : "0");
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!VWAtCP7VFXX)
		{
			VWAtCP7VFXX = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/localfilesearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			VWAtCP7VFXX = true;
			break;
		case 1:
			TxtPathList = (TextBox)target;
			break;
		case 2:
			TxtBlackList = (TextBox)target;
			break;
		case 3:
			ChkIndexFolder = (CheckBox)target;
			break;
		case 4:
			TxtExtList = (TextBox)target;
			break;
		}
	}

	internal static bool gTp0KeQeuplbtBAUBrRG()
	{
		return XKUhjNQeLxO6v7vArIp8 == null;
	}
}
