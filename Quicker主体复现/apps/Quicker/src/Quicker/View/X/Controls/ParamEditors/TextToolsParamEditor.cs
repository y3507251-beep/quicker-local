using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.View.Controls;

namespace Quicker.View.X.Controls.ParamEditors;

public class TextToolsParamEditor : BaseParamEditor, IComponentConnector
{
	internal TextToolsSelectorControl Selector;

	private bool UcJLm5FXjn2;

	internal static TextToolsParamEditor vPtN4RFL99RH9pH6hXBW;

	public TextToolsParamEditor(ObservableCollection<ActionVariable> actionVariables, StepInParamDef paramDef, ActionStepParam actionStepParam)
		: base(paramDef, actionStepParam)
	{
		InitializeComponent();
		Selector.SetSelectedToolsString(actionStepParam.Value);
	}

	public override ActionStepParam GetParamValue()
	{
		return new ActionStepParam
		{
			Value = Selector.GetSelectedToolsString()
		};
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!UcJLm5FXjn2)
		{
			UcJLm5FXjn2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/texttoolsparameditor.xaml", UriKind.Relative);
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
			Selector = (TextToolsSelectorControl)target;
		}
		else
		{
			UcJLm5FXjn2 = true;
		}
	}

	internal static bool USSN5QFLLLtpTr7XRED4()
	{
		return vPtN4RFL99RH9pH6hXBW == null;
	}
}
