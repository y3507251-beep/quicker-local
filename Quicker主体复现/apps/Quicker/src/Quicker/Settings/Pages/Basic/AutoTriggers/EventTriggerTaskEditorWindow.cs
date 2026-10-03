using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using CW;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.Forms;
using r3EUytwSQ9vNYu3Es8s;

namespace Quicker.Settings.Pages.Basic.AutoTriggers;

public class EventTriggerTaskEditorWindow : System.Windows.Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec lgXvhQc7PAW;

		public static Func<string, bool> NMavhjdjXkl;

		private static _003C_003Ec X3hNKKcbjo3Ew92aNM1U;

		static _003C_003Ec()
		{
			lgXvhQc7PAW = new _003C_003Ec();
		}

		internal bool TfMvhBX31JJ(string x)
		{
			return string.Equals(x, Environment.MachineName, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool MbUXHscbDZTbBu5q9GrY()
		{
			return X3hNKKcbjo3Ew92aNM1U == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public CommonTriggerTask SU3vh4poooD;

		private static _003C_003Ec__DisplayClass7_0 OGmArhcbGydx1bPMdOwd;

		internal bool IUvvhna3f5T(EventTypeInfo x)
		{
			return x.EventType == SU3vh4poooD.EventType;
		}

		internal static void X5bFNScbKKxxbrrT7mDN()
		{
		}

		internal static bool OHVRGxcb0RLGA7uIEnGa()
		{
			return OGmArhcbGydx1bPMdOwd == null;
		}
	}

	private IList<EventTypeInfo> hCOMqlDL74;

	private IDictionary<string, object> YaSMcKQq2w = new Dictionary<string, object>();

	private readonly CommonTriggerTask AvpMVVcFVB;

	[CompilerGenerated]
	private CommonTriggerTask ynAMZSgC1O;

	[CompilerGenerated]
	private bool? vxMM9wDKQq;

	internal FilterableDropDown CbEventType;

	internal System.Windows.Controls.TextBox TxtNote;

	internal DictFormControl ParamForm;

	internal TextBoxWithToolsControl TxtEventFilterExpression;

	internal ActionSelector ActionSelector;

	internal TextBoxWithToolsControl TxtActionParam;

	internal NumericUpDown TxtThrottleMs;

	internal NumericUpDown TxtDelayMs;

	internal System.Windows.Controls.TextBox TxtBindingMachine;

	internal Button BtnAddCurrentMachine;

	internal CheckBox ChkEnable;

	internal CheckBox ChkIgnoreFurtherTasks;

	internal Button BtnCancel;

	private bool hVEMh2vcq2;

	private static EventTriggerTaskEditorWindow Qeo1rk4H1lFRB502uhW;

	public CommonTriggerTask ResultTask
	{
		[CompilerGenerated]
		get
		{
			return ynAMZSgC1O;
		}
		[CompilerGenerated]
		set
		{
			ynAMZSgC1O = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return vxMM9wDKQq;
		}
		[CompilerGenerated]
		set
		{
			vxMM9wDKQq = value;
		}
	}

	public EventTriggerTaskEditorWindow(CommonTriggerTask task)
	{
		hCOMqlDL74 = LsmMENVZlR();
		AvpMVVcFVB = task;
		InitializeComponent();
		CbEventType.SetData(hCOMqlDL74.Cast<object>().ToList(), pGiMPdNbTi);
		HMEMyCr9HV(task);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private double pGiMPdNbTi(object object_0, string string_0)
	{
		EventTypeInfo eventTypeInfo = object_0 as EventTypeInfo;
		return tkxn6HAKAgMT8gvXbyh.mRJior6F4v(eventTypeInfo.Description, 1.0, eventTypeInfo.EventType, 1.0, true, new string[1] { string_0 })?.Score ?? 0;
	}

	private IList<EventTypeInfo> LsmMENVZlR()
	{
		return AppState.uICt7cXc7Qs().yF5fza3sIW();
	}

	private void HMEMyCr9HV(CommonTriggerTask commonTriggerTask_2)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.SU3vh4poooD = commonTriggerTask_2;
		if (_003C_003Ec__DisplayClass7_.SU3vh4poooD == null)
		{
			int num = 0;
			if (Qeo1rk4H1lFRB502uhW != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		YaSMcKQq2w = _003C_003Ec__DisplayClass7_.SU3vh4poooD.Params ?? new Dictionary<string, object>();
		CbEventType.SelectedItem = hCOMqlDL74.FirstOrDefault(_003C_003Ec__DisplayClass7_.IUvvhna3f5T);
		TxtNote.Text = _003C_003Ec__DisplayClass7_.SU3vh4poooD.Note;
		ActionSelector.ActionIdOrName = _003C_003Ec__DisplayClass7_.SU3vh4poooD.ActionIdOrName;
		ChkEnable.IsChecked = _003C_003Ec__DisplayClass7_.SU3vh4poooD.IsEnabled;
		TxtActionParam.Text = _003C_003Ec__DisplayClass7_.SU3vh4poooD.ActionParam;
		TxtEventFilterExpression.Text = _003C_003Ec__DisplayClass7_.SU3vh4poooD.EventFilterExpression;
		TxtBindingMachine.Text = _003C_003Ec__DisplayClass7_.SU3vh4poooD.ValidForMachines;
		TxtDelayMs.Value = _003C_003Ec__DisplayClass7_.SU3vh4poooD.DelayMs;
		ChkIgnoreFurtherTasks.IsChecked = _003C_003Ec__DisplayClass7_.SU3vh4poooD.SkipFurtherTasks;
		TxtThrottleMs.Value = _003C_003Ec__DisplayClass7_.SU3vh4poooD.ThrottleMs;
	}

	private void f9RM82Oxj5(object sender, RoutedEventArgs e)
	{
		if (CbEventType.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择事件类型!");
			return;
		}
		(bool, string, IDictionary<string, object>) values = ParamForm.GetValues();
		if (!values.Item1)
		{
			AppHelper.ShowWarning(values.Item2);
			return;
		}
		if (ActionSelector.ActionIdOrName.IsNullOrEmpty())
		{
			AppHelper.ShowWarning("请选择要执行的动作。");
			return;
		}
		if (!TxtEventFilterExpression.Text.IsNullOrEmpty() && !TxtEventFilterExpression.Text.StartsWith("$="))
		{
			AppHelper.ShowWarning("事件过滤表达式应该以$=开始。");
			return;
		}
		ResultTask = new CommonTriggerTask();
		ResultTask.EventType = (CbEventType.SelectedValue as EventTypeInfo).EventType;
		ResultTask.Note = TxtNote.Text;
		ResultTask.Params = values.Item3;
		ResultTask.ActionIdOrName = ActionSelector.ActionIdOrName;
		ResultTask.IsEnabled = ChkEnable.IsChecked == true;
		ResultTask.ActionParam = TxtActionParam.Text;
		ResultTask.EventFilterExpression = TxtEventFilterExpression.Text;
		ResultTask.ValidForMachines = TxtBindingMachine.Text;
		int num = 0;
		if (!TxGH0f4ze8y1cWPL2Oa())
		{
			goto IL_0167;
		}
		goto IL_018f;
		IL_018f:
		switch (num)
		{
		case 1:
			ResultTask.DelayMs = (int)TxtDelayMs.Value;
			ResultTask.SkipFurtherTasks = ChkIgnoreFurtherTasks.IsChecked == true;
			this.ThNvuM5Q9GQ(true);
			return;
		}
		goto IL_0167;
		IL_0167:
		ResultTask.ThrottleMs = (int)TxtThrottleMs.Value;
		num = 1;
		if (!TxGH0f4ze8y1cWPL2Oa())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_018f;
	}

	private void iEvMagsENr(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtBindingMachine.Text))
		{
			TxtBindingMachine.Text = Environment.MachineName;
			return;
		}
		string[] array = TxtBindingMachine.Text.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (!array.Any(_003C_003Ec.NMavhjdjXkl ?? (_003C_003Ec.NMavhjdjXkl = _003C_003Ec.lgXvhQc7PAW.TfMvhBX31JJ)))
		{
			TxtBindingMachine.Text = string.Join(";", array) + ";" + Environment.MachineName;
		}
		else
		{
			AppHelper.ShowInformation("您已添加当前主机。");
		}
	}

	private void ztvM7BcFq7(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void CbEventType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (!(CbEventType.SelectedValue is EventTypeInfo eventTypeInfo))
		{
			return;
		}
		oXLGvbwTuCxD9pGrbDD oXLGvbwTuCxD9pGrbDD = AppState.uICt7cXc7Qs().QS1f3oYkWA(eventTypeInfo.EventType);
		IList<FormField> ilist_ = oXLGvbwTuCxD9pGrbDD.odUM2hmvkik(eventTypeInfo.EventType);
		if (AvpMVVcFVB == null)
		{
			IDictionary<string, object> dictionary = oXLGvbwTuCxD9pGrbDD.kLIM2b7eEDv(eventTypeInfo.EventType);
			if (dictionary != null)
			{
				YaSMcKQq2w = dictionary;
			}
		}
		d1LMRL7aDw(ilist_);
		IList<ActionVariable> variables = oXLGvbwTuCxD9pGrbDD.VrkM2LPKH4P(eventTypeInfo.EventType);
		TxtActionParam.SetVariables(variables, false);
		int num = 0;
		if (!TxGH0f4ze8y1cWPL2Oa())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TxtEventFilterExpression.SetVariables(variables);
	}

	private void d1LMRL7aDw(IList<FormField> ilist_1)
	{
		ParamForm.UpdateForm(ilist_1, YaSMcKQq2w);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!hVEMh2vcq2)
		{
			hVEMh2vcq2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/events/eventtriggertaskeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			hVEMh2vcq2 = true;
			break;
		case 2:
			TxtNote = (System.Windows.Controls.TextBox)target;
			break;
		case 3:
			ParamForm = (DictFormControl)target;
			break;
		case 4:
			TxtEventFilterExpression = (TextBoxWithToolsControl)target;
			break;
		case 5:
			ActionSelector = (ActionSelector)target;
			break;
		case 6:
			TxtActionParam = (TextBoxWithToolsControl)target;
			break;
		case 7:
			TxtThrottleMs = (NumericUpDown)target;
			break;
		case 8:
		{
			TxtDelayMs = (NumericUpDown)target;
			int num = 1;
			if (!TxGH0f4ze8y1cWPL2Oa())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				return;
			}
			goto case 1;
		}
		case 1:
			CbEventType = (FilterableDropDown)target;
			break;
		case 9:
			TxtBindingMachine = (System.Windows.Controls.TextBox)target;
			break;
		case 10:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += iEvMagsENr;
			break;
		case 11:
			ChkEnable = (CheckBox)target;
			break;
		case 12:
			ChkIgnoreFurtherTasks = (CheckBox)target;
			break;
		case 13:
			((Button)target).Click += f9RM82Oxj5;
			break;
		case 14:
			BtnCancel = (Button)target;
			BtnCancel.Click += ztvM7BcFq7;
			break;
		}
	}

	internal static bool TxGH0f4ze8y1cWPL2Oa()
	{
		return Qeo1rk4H1lFRB502uhW == null;
	}
}
