using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.View.X.Controls;
using Quicker.View.X.Controls.ParamEditors;

namespace Quicker.View.X.StepEditor.ParamEditors;

public class VariableParamSelector : BaseParamEditor, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ActionVariable HrOSFt8fTmb;

		private static _003C_003Ec__DisplayClass5_0 sEFG4KyVrEnkesLalu8m;

		internal bool txdSFwkdbDM(VariableOrValueSelectItem x)
		{
			return x.Key == HrOSFt8fTmb.Key;
		}

		internal static bool mtv8QhyVNZWOAOHKBhmA()
		{
			return sEFG4KyVrEnkesLalu8m == null;
		}
	}

	private readonly ObservableCollection<VariableOrValueSelectItem> oLILH66nILs = new ObservableCollection<VariableOrValueSelectItem>();

	private readonly ObservableCollection<ActionVariable> oBsLHXktO2W;

	internal ComboBox CbVariables;

	private bool x26LHmMtAe4;

	internal static VariableParamSelector Oocn0SFrAdLatSSsFdaH;

	public VariableParamSelector(ObservableCollection<ActionVariable> actionVariables, StepInParamDef paramDef, ActionStepParam paramData)
		: base(paramDef, paramData)
	{
		InitializeComponent();
		oBsLHXktO2W = actionVariables;
		P3CLH1WHIW5();
	}

	private void P3CLH1WHIW5()
	{
		oLILH66nILs.Add(new VariableOrValueSelectItem
		{
			Key = null,
			Type = VarType.NA,
			Desc = "--请选择变量--"
		});
		foreach (ActionVariable item in oBsLHXktO2W)
		{
			if (VariableHelper.IsAssignable(item.Type, _paramDef.Type))
			{
				oLILH66nILs.Add(new VariableOrValueSelectItem(item));
			}
		}
		if (VariableHelper.IsAssignable(VarType.Text, _paramDef.Type))
		{
			int num = 0;
			if (!LSsUq6FrnjSeKWxYUDSs())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			oLILH66nILs.Add(new VariableOrValueSelectItem(new ActionVariable
			{
				Key = "[cliptext]",
				Type = VarType.Text,
				Desc = "*剪贴板文本*"
			}));
			oLILH66nILs.Add(new VariableOrValueSelectItem(new ActionVariable
			{
				Key = "quicker_in_param",
				Type = VarType.Text,
				Desc = "*动作参数*"
			}));
		}
		ActionVariable variable = new ActionVariable
		{
			Key = null,
			Type = VarType.CreateVar,
			Desc = "创建新变量..."
		};
		oLILH66nILs.Insert(1, new VariableOrValueSelectItem(variable));
		CbVariables.ItemsSource = oLILH66nILs;
		CbVariables.SelectedItem = oLILH66nILs.FirstOrDefault(yucLHbG1Vi4);
	}

	public override ActionStepParam GetParamValue()
	{
		ActionStepParam actionStepParam = new ActionStepParam();
		VariableOrValueSelectItem variableOrValueSelectItem = CbVariables.SelectedItem as VariableOrValueSelectItem;
		object obj;
		if (variableOrValueSelectItem == null)
		{
			obj = null;
		}
		else
		{
			obj = variableOrValueSelectItem.Key;
			if (obj != null)
			{
				goto IL_002f;
			}
		}
		obj = "";
		goto IL_002f;
		IL_002f:
		actionStepParam.VarKey = (string)obj;
		return actionStepParam;
	}

	private void CbVariables_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		int num = 1;
		while (CbVariables.SelectedIndex < 0)
		{
			int num2 = 0;
			if (Oocn0SFrAdLatSSsFdaH != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			CbVariables.SelectedIndex = 0;
			return;
		}
		if (!(CbVariables.SelectedItem is VariableOrValueSelectItem { Type: VarType.CreateVar }))
		{
			return;
		}
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.HrOSFt8fTmb = XActionUiHelper.CreateVariable(Window.GetWindow(this), oBsLHXktO2W, _paramDef.Type, false, _paramDef.Key, _paramDef.Name, false, true);
		if (_003C_003Ec__DisplayClass5_.HrOSFt8fTmb != null)
		{
			VariableOrValueSelectItem variableOrValueSelectItem2 = oLILH66nILs.FirstOrDefault(_003C_003Ec__DisplayClass5_.txdSFwkdbDM);
			if (variableOrValueSelectItem2 == null)
			{
				variableOrValueSelectItem2 = new VariableOrValueSelectItem(_003C_003Ec__DisplayClass5_.HrOSFt8fTmb);
				oLILH66nILs.Insert(2, variableOrValueSelectItem2);
			}
			CbVariables.SelectedItem = variableOrValueSelectItem2;
		}
		else
		{
			CbVariables.SelectedIndex = 0;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!x26LHmMtAe4)
		{
			x26LHmMtAe4 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/variableparamselector.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			CbVariables = (ComboBox)target;
			CbVariables.SelectionChanged += CbVariables_OnSelectionChanged;
		}
		else
		{
			x26LHmMtAe4 = true;
		}
	}

	[CompilerGenerated]
	private bool yucLHbG1Vi4(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.Key == _paramData.VarKey)
		{
			return variableOrValueSelectItem_0.IsVariable;
		}
		return false;
	}

	static VariableParamSelector()
	{
	}

	internal static bool LSsUq6FrnjSeKWxYUDSs()
	{
		return Oocn0SFrAdLatSSsFdaH == null;
	}

	internal static void eKZmZDFr02hxchecDYIB()
	{
	}
}
