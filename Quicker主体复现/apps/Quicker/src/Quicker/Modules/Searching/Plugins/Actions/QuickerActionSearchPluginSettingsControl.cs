using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Searching;

namespace Quicker.Modules.Searching.Plugins.Actions;

public class QuickerActionSearchPluginSettingsControl : UserControl, IComponentConnector, IPluginSettingsControl
{
	internal CheckBox ChkExcludeLinkActions;

	internal CheckBox ChkExcludeOtherMachines;

	internal TextBox TxtAdjustWeight;

	private bool IKYtEzGDGZu;

	internal static QuickerActionSearchPluginSettingsControl SpZHLwQDgtlkfJ8bm0iF;

	public QuickerActionSearchPluginSettingsControl()
	{
		InitializeComponent();
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		ChkExcludeLinkActions.IsChecked = false;
		ChkExcludeOtherMachines.IsChecked = false;
		if (settings != null)
		{
			if (settings.TryGetValue("excludeLinkActions", out var value))
			{
				ChkExcludeLinkActions.IsChecked = value == "1";
			}
			if (settings.TryGetValue("excludeOtherMachines", out var value2))
			{
				ChkExcludeOtherMachines.IsChecked = value2 == "1";
			}
			if (settings.TryGetValue("adjustScore", out var value3))
			{
				TxtAdjustWeight.Text = value3;
			}
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["excludeLinkActions"] = ((ChkExcludeLinkActions.IsChecked == true) ? "1" : "0");
		settings["excludeOtherMachines"] = ((ChkExcludeOtherMachines.IsChecked == true) ? "1" : "0");
		settings["adjustScore"] = TxtAdjustWeight.Text;
	}

	public (bool isValid, string message) IsValid()
	{
		if (!string.IsNullOrEmpty(TxtAdjustWeight.Text) && !Regex.IsMatch(TxtAdjustWeight.Text, "^[\\+\\*](\\d+(\\.\\d+)?;\\d+(\\.\\d+)?;\\d+(\\.\\d+)?)$"))
		{
			return (isValid: false, message: "排序分数调整值格式不正确。");
		}
		return (isValid: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!IKYtEzGDGZu)
		{
			IKYtEzGDGZu = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/actions/quickeractionsearchpluginsettingscontrol.xaml", UriKind.Relative);
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
			IKYtEzGDGZu = true;
			break;
		case 1:
			ChkExcludeLinkActions = (CheckBox)target;
			break;
		case 2:
			ChkExcludeOtherMachines = (CheckBox)target;
			break;
		case 3:
			TxtAdjustWeight = (TextBox)target;
			break;
		}
	}

	internal static bool WZ9mNAQDP94TWeHoh022()
	{
		return SpZHLwQDgtlkfJ8bm0iF == null;
	}
}
