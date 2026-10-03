using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.X;

public class InputParamSettingsWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private InputParamInfo YP0LW3TeNt6;

	internal StackPanel PnlTextOptions;

	internal CheckBox ChkMultiLine;

	internal TextToolsSelectorControl TextToolsSelector;

	internal TextBox TxtSelectItems;

	internal CheckBox ChkOnlySelect;

	internal TextBoxWithToolsControl TxtVisibleExpression;

	internal StackPanel PnlSkipEval;

	internal CheckBox ChkSkipEval;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool EnvLWfajWMC;

	private static InputParamSettingsWindow HBoUlTFkVQNLcxyjof26;

	public InputParamInfo InputParamInfo
	{
		[CompilerGenerated]
		get
		{
			return YP0LW3TeNt6;
		}
		[CompilerGenerated]
		set
		{
			YP0LW3TeNt6 = value;
		}
	}

	public InputParamSettingsWindow(InputParamInfo inputParamInfo, IList<ActionVariable> variables, VarTypeItem varTypeItem)
	{
		InputParamInfo = inputParamInfo;
		InitializeComponent();
		if (inputParamInfo != null)
		{
			TxtSelectItems.Text = inputParamInfo.SelectionItems;
			ChkOnlySelect.IsChecked = inputParamInfo.OnlyUseSelect;
			TextToolsSelector.SetSelectedToolsString(inputParamInfo.TextTools);
			ChkMultiLine.IsChecked = inputParamInfo.MultiLine;
			TxtVisibleExpression.Text = inputParamInfo.VisibleExpression ?? "";
			ChkSkipEval.IsChecked = inputParamInfo.SkipEval;
		}
		TxtVisibleExpression.SetVariables(variables);
		if (varTypeItem != null)
		{
			PnlSkipEval.IsEnabled = varTypeItem.VarType == VarType.Text;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void CigLWUgYsvm(object sender, RoutedEventArgs e)
	{
		Save();
		base.DialogResult = true;
	}

	private void Save()
	{
		InputParamInfo = new InputParamInfo
		{
			SelectionItems = TxtSelectItems.Text,
			OnlyUseSelect = (ChkOnlySelect.IsChecked == true),
			TextTools = TextToolsSelector.GetSelectedToolsString(),
			MultiLine = (ChkMultiLine.IsChecked == true),
			VisibleExpression = TxtVisibleExpression.Text,
			SkipEval = (ChkSkipEval.IsChecked == true)
		};
	}

	private void RpYLWltlm5G(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void llFLWiHK91b(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtSelectItems);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!EnvLWfajWMC)
		{
			EnvLWfajWMC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/inputparamsettingswindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			EnvLWfajWMC = true;
			break;
		case 1:
			PnlTextOptions = (StackPanel)target;
			break;
		case 2:
			ChkMultiLine = (CheckBox)target;
			break;
		case 3:
			TextToolsSelector = (TextToolsSelectorControl)target;
			break;
		case 4:
			TxtSelectItems = (TextBox)target;
			break;
		case 5:
			((MenuItem)target).Click += llFLWiHK91b;
			break;
		case 6:
			ChkOnlySelect = (CheckBox)target;
			break;
		case 7:
			TxtVisibleExpression = (TextBoxWithToolsControl)target;
			break;
		case 8:
			PnlSkipEval = (StackPanel)target;
			if (HBoUlTFkVQNLcxyjof26 == null)
			{
				switch (0)
				{
				}
			}
			break;
		case 9:
			ChkSkipEval = (CheckBox)target;
			break;
		case 10:
			BtnSave = (Button)target;
			BtnSave.Click += CigLWUgYsvm;
			break;
		case 11:
			BtnCancel = (Button)target;
			BtnCancel.Click += RpYLWltlm5G;
			break;
		}
	}

	internal static bool YjiA0sFkQAoVms0SvMRs()
	{
		return HBoUlTFkVQNLcxyjof26 == null;
	}
}
