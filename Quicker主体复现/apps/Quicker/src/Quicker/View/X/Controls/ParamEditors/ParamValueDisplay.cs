using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.View.Controls;

namespace Quicker.View.X.Controls.ParamEditors;

public class ParamValueDisplay : BaseParamEditor, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ActionStepParam fUWSlqZR6OM;

		private static _003C_003Ec__DisplayClass2_0 eSD2YFycR6arfVCTEplj;

		internal bool vFYSlR2dSQE(ActionVariable x)
		{
			return x.Key == fUWSlqZR6OM.VarKey;
		}

		internal static bool AYmHkWycgZyXDoUQqmAe()
		{
			return eSD2YFycR6arfVCTEplj == null;
		}
	}

	private readonly IList<ActionVariable> zhcLmntQ7RC;

	internal Grid TheGrid;

	internal IconControl ImgIcon;

	internal TextBlock TheText;

	private bool AVWLm4OwajW;

	internal static ParamValueDisplay iVc93hFLJykpmgTmJOsb;

	public ParamValueDisplay(StepInParamDef paramDef, ActionStepParam paramData, IList<ActionVariable> variables)
		: base(paramDef, paramData)
	{
		zhcLmntQ7RC = variables;
		InitializeComponent();
		zoOLmQpDO40(paramData, variables);
	}

	private void zoOLmQpDO40(ActionStepParam actionStepParam_0, IList<ActionVariable> ilist_1)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.fUWSlqZR6OM = actionStepParam_0;
		ImgIcon.Visibility = Visibility.Collapsed;
		if (_003C_003Ec__DisplayClass2_.fUWSlqZR6OM == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass2_.fUWSlqZR6OM.VarKey))
		{
			ActionVariable actionVariable = ilist_1.FirstOrDefault(_003C_003Ec__DisplayClass2_.vFYSlR2dSQE);
			TheText.Text = _003C_003Ec__DisplayClass2_.fUWSlqZR6OM.VarKey;
			if (actionVariable != null)
			{
				ImgIcon.Icon = actionVariable.IconStr;
				ImgIcon.Visibility = Visibility.Visible;
				TheText.ToolTip = actionVariable.Desc;
			}
			else
			{
				TheText.Foreground = Brushes.Red;
				TheText.ToolTip = "不存在的变量!";
			}
		}
		else if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass2_.fUWSlqZR6OM.Value))
		{
			TheText.Text = uH0LmjthibC(_003C_003Ec__DisplayClass2_.fUWSlqZR6OM.Value);
			TheText.ToolTip = _003C_003Ec__DisplayClass2_.fUWSlqZR6OM.Value;
		}
		else
		{
			TheText.Text = "(空)";
			TheText.Foreground = Brushes.DarkGray;
		}
	}

	private static string uH0LmjthibC(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		int num = string_0.IndexOfAny(new char[2] { '\r', '\n' });
		if (num > 0)
		{
			if (num > 50)
			{
				num = 50;
			}
			return string_0.Substring(0, num) + "\r\n……";
		}
		if (string_0.Length <= 50)
		{
			return string_0;
		}
		return string_0.Substring(0, 50) + "……";
	}

	public override ActionStepParam GetParamValue()
	{
		return _paramData;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!AVWLm4OwajW)
		{
			AVWLm4OwajW = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/paramvaluedisplay.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			AVWLm4OwajW = true;
			break;
		case 1:
			TheGrid = (Grid)target;
			break;
		case 2:
			ImgIcon = (IconControl)target;
			break;
		case 3:
			TheText = (TextBlock)target;
			break;
		}
	}

	internal static bool USPNkPFLkx81uXU6C6xP()
	{
		return iVc93hFLJykpmgTmJOsb == null;
	}
}
