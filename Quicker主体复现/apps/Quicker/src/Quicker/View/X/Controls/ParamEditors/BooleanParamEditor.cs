using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.View.X.Controls.ParamEditors;

public class BooleanParamEditor : BaseParamEditor, IComponentConnector
{
	internal CheckBox ChkBoolean;

	private bool yk6Lm6tlFIU;

	private static BooleanParamEditor TkBy2bFLEqcfyYSPKOyA;

	public BooleanParamEditor(StepInParamDef paramDef, ActionStepParam pramData)
		: base(paramDef, pramData)
	{
		InitializeComponent();
		ChkBoolean.Content = paramDef.Name;
		HsKLm1iyqJX(pramData);
	}

	private void HsKLm1iyqJX(ActionStepParam actionStepParam_0)
	{
		if (actionStepParam_0 != null && !string.IsNullOrEmpty(actionStepParam_0.Value))
		{
			try
			{
				bool flag = false;
				flag = string.Equals(actionStepParam_0.Value, "true", StringComparison.OrdinalIgnoreCase) || (!string.Equals(actionStepParam_0.Value, "false", StringComparison.OrdinalIgnoreCase) && Convert.ToBoolean(VariableHelper.ConvertToType(VarType.Boolean, actionStepParam_0.Value), CultureInfo.InvariantCulture));
				ChkBoolean.IsChecked = flag;
				return;
			}
			catch (Exception ex)
			{
				ChkBoolean.IsChecked = false;
				AppHelper.ShowWarning("把" + actionStepParam_0.Value + "转换为布尔类型出错：" + ex.Message);
				return;
			}
		}
		ChkBoolean.IsChecked = false;
	}

	public override ActionStepParam GetParamValue()
	{
		return new ActionStepParam
		{
			Value = ((ChkBoolean.IsChecked == true) ? "1" : "0")
		};
	}

	private void gssLmbkJCci(object sender, RoutedEventArgs e)
	{
		NotifyValueChange();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!yk6Lm6tlFIU)
		{
			yk6Lm6tlFIU = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/booleanparameditor.xaml", UriKind.Relative);
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
			ChkBoolean = (CheckBox)target;
			ChkBoolean.Click += gssLmbkJCci;
		}
		else
		{
			yk6Lm6tlFIU = true;
		}
	}

	internal static bool RnHi83FLGfPxAxGaGTjL()
	{
		return TkBy2bFLEqcfyYSPKOyA == null;
	}
}
