using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Common.QuickActions;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Triggers.TextCommand;

public class TextCommandBatchEditWindow : Window, IComponentConnector, IMockModalWindow
{
	private readonly IList<Quicker.Common.QuickActions.TextCommand> lEZTtqFWXo;

	[CompilerGenerated]
	private bool? YxjTgTlHeL;

	internal CheckBox ChkChangeTriggerKey;

	internal HotkeyEditorControl KeyEditor;

	internal CheckBox ChkNoTrigger;

	internal CheckBox ChkChangeIgnoreCase;

	internal CheckBox ChkIgnoreCase;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool EJATLn83cV;

	internal static TextCommandBatchEditWindow M2ExOB7eysfVS8Ltxxm;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return YxjTgTlHeL;
		}
		[CompilerGenerated]
		set
		{
			YxjTgTlHeL = value;
		}
	}

	public TextCommandBatchEditWindow(IList<Quicker.Common.QuickActions.TextCommand> textCommands)
	{
		lEZTtqFWXo = textCommands;
		InitializeComponent();
		Quicker.Common.QuickActions.TextCommand textCommand = textCommands.First();
		ChkNoTrigger.IsChecked = textCommand.IsDirectInputTrigger;
		if (textCommand.TriggerKey.HasValue)
		{
			KeyEditor.Hotkey = new Hotkey((VirtualKeyCode)textCommand.TriggerKey.Value, ModifierKeys.None);
		}
		ChkIgnoreCase.IsChecked = textCommand.IgnoreCase;
	}

	private void ruXozrfYZU(object sender, RoutedEventArgs e)
	{
		if (ChkChangeIgnoreCase.IsChecked == false && ChkChangeTriggerKey.IsChecked == false)
		{
			AppHelper.ShowWarning("没有要修改的参数。");
			return;
		}
		if (!AppHelper.Confirm("您确认要保存修改么？"))
		{
			return;
		}
		if (ChkChangeIgnoreCase.IsChecked == true)
		{
			foreach (Quicker.Common.QuickActions.TextCommand item in lEZTtqFWXo)
			{
				item.IgnoreCase = ChkIgnoreCase.IsChecked == true;
			}
		}
		if (ChkChangeTriggerKey.IsChecked != true)
		{
			goto IL_00e7;
		}
		if (ChkNoTrigger.IsChecked != true)
		{
			goto IL_0110;
		}
		VirtualKeyCode? obj = 0;
		goto IL_0157;
		IL_0157:
		int? triggerKey = (int?)obj;
		foreach (Quicker.Common.QuickActions.TextCommand item2 in lEZTtqFWXo)
		{
			item2.TriggerKey = triggerKey;
		}
		goto IL_00e7;
		IL_00e7:
		while (true)
		{
			this.ThNvuM5Q9GQ(true);
			if (!q60neH7julFL2EJ4o5R())
			{
				switch (0)
				{
				default:
					continue;
				case 2:
					break;
				case 1:
					return;
				}
				break;
			}
			return;
		}
		goto IL_0110;
		IL_0110:
		obj = KeyEditor.Hotkey?.Key;
		goto IL_0157;
	}

	private void AVATwNhFXZ(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!EJATLn83cV)
		{
			EJATLn83cV = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/textcommand/textcommandbatcheditwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			EJATLn83cV = true;
			break;
		case 1:
			ChkChangeTriggerKey = (CheckBox)target;
			break;
		case 2:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 3:
			ChkNoTrigger = (CheckBox)target;
			break;
		case 4:
			ChkChangeIgnoreCase = (CheckBox)target;
			break;
		case 5:
			ChkIgnoreCase = (CheckBox)target;
			break;
		case 6:
			BtnSave = (Button)target;
			if (q60neH7julFL2EJ4o5R())
			{
				switch (0)
				{
				}
			}
			BtnSave.Click += ruXozrfYZU;
			break;
		case 7:
			BtnCancel = (Button)target;
			BtnCancel.Click += AVATwNhFXZ;
			break;
		}
	}

	internal static bool q60neH7julFL2EJ4o5R()
	{
		return M2ExOB7eysfVS8Ltxxm == null;
	}
}
