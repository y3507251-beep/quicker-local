using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Settings.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Triggers;

public class TextCommandSettingPage : SettingPage, IComponentConnector
{
	internal CheckBox ChkDelimiterSpace;

	internal CheckBox ChkDelimiterTab;

	internal CheckBox ChkDelimiterReturn;

	internal CheckBox ChkDelimiterSemicolon;

	internal HotkeyEditorControl KeyEditor;

	internal ProcessSelectorControl BlackListEditor;

	internal CheckBox ChkAutoDisableIme;

	private bool LZIooj25PS;

	internal static TextCommandSettingPage yJ7EfpCHWp6lFbZ9Iv2;

	public TextCommandSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ChkDelimiterTab.IsChecked = settings.TextCommandDelimiterChars.Contains("\t");
		ChkDelimiterSpace.IsChecked = settings.TextCommandDelimiterChars.Contains(" ");
		if (yJ7EfpCHWp6lFbZ9Iv2 != null)
		{
			switch (0)
			{
			}
		}
		ChkDelimiterReturn.IsChecked = settings.TextCommandDelimiterChars.Contains("\n");
		ChkDelimiterSemicolon.IsChecked = settings.TextCommandDelimiterChars.Contains(";");
		if (settings.TextCommandTriggerKey.HasValue)
		{
			KeyEditor.Hotkey = new Hotkey((VirtualKeyCode)settings.TextCommandTriggerKey.Value, ModifierKeys.None);
		}
		BlackListEditor.ProcessList = settings.TextCommandBlackList;
		ChkAutoDisableIme.IsChecked = settings.TextCommandAutoDisableIme;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.TextCommandDelimiterChars = ((ChkDelimiterTab.IsChecked == true) ? "\t" : "") + ((ChkDelimiterSpace.IsChecked == true) ? " " : "") + ((ChkDelimiterReturn.IsChecked == true) ? "\n" : "") + ((ChkDelimiterSemicolon.IsChecked == true) ? ";" : "");
		settings.TextCommandTriggerKey = (int?)KeyEditor.Hotkey?.Key;
		settings.TextCommandBlackList = BlackListEditor.ProcessList;
		settings.TextCommandAutoDisableIme = ChkAutoDisableIme.IsChecked == true;
		return true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!LZIooj25PS)
		{
			LZIooj25PS = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/textcommand/textcommandsettingpage.xaml", UriKind.Relative);
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
			LZIooj25PS = true;
			break;
		case 1:
			ChkDelimiterSpace = (CheckBox)target;
			break;
		case 2:
			ChkDelimiterTab = (CheckBox)target;
			break;
		case 3:
			ChkDelimiterReturn = (CheckBox)target;
			break;
		case 4:
			ChkDelimiterSemicolon = (CheckBox)target;
			break;
		case 5:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 6:
			BlackListEditor = (ProcessSelectorControl)target;
			break;
		case 7:
			ChkAutoDisableIme = (CheckBox)target;
			break;
		}
	}

	internal static bool ULYIQhCzEsnj4cqaX57()
	{
		return yJ7EfpCHWp6lFbZ9Iv2 == null;
	}
}
