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

public class BookmarksSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal CheckBox ChkReadBookmarksFile;

	internal TextBox TxtBrowser;

	private bool JAktJedvXeM;

	internal static BookmarksSearchPluginSettingsControl A1EolBQnjUHeLF7k9twr;

	public BookmarksSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		TxtBrowser.Text = "#chrome\r\n#msedge\r\n#firefox\r\n#360chromex:%LOCALAPPDATA%\\360ChromeX\\Chrome\\User Data\\Default\\Bookmarks";
		ChkReadBookmarksFile.IsChecked = true;
		if (settings != null)
		{
			if (settings.ContainsKey("browsers"))
			{
				TxtBrowser.Text = settings["browsers"];
			}
			if (settings.ContainsKey("enableReadFile"))
			{
				ChkReadBookmarksFile.IsChecked = settings["enableReadFile"] == "1";
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["browsers"] = TxtBrowser.Text;
		settings["enableReadFile"] = ((ChkReadBookmarksFile.IsChecked == true) ? "1" : "0");
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!JAktJedvXeM)
		{
			JAktJedvXeM = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/bookmarkssearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			JAktJedvXeM = true;
			break;
		case 2:
			TxtBrowser = (TextBox)target;
			break;
		case 1:
			ChkReadBookmarksFile = (CheckBox)target;
			break;
		}
	}

	internal static bool zJjTOjQnDIIqaCxo5NyI()
	{
		return A1EolBQnjUHeLF7k9twr == null;
	}
}
