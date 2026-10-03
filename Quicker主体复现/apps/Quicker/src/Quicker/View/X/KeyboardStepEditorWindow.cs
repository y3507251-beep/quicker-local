using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.KeyInput;

namespace Quicker.View.X;

public class KeyboardStepEditorWindow : System.Windows.Window, IComponentConnector
{
	[CompilerGenerated]
	private ActionStep gwdLkv2a6tV;

	[CompilerGenerated]
	private ActionStep SFgLkSQdXbM;

	[CompilerGenerated]
	private IStepRunner sY6Lk2wDZAR;

	internal KeyInputOrSelectControl KeyInputOrSelectControl;

	internal NumericUpDown TxtHoldMs;

	internal NumericUpDown TxtRepeat;

	internal NumericUpDown TxtInterval;

	internal NumericUpDown TxtDelayMs;

	internal System.Windows.Controls.TextBox TxtNote;

	internal CheckBox ChkDisable;

	internal Button BtnSave;

	private bool EOULkuddtKb;

	internal static KeyboardStepEditorWindow a9boTpFkyOPVvlCGvtrr;

	public ActionStep EditingStep
	{
		[CompilerGenerated]
		get
		{
			return gwdLkv2a6tV;
		}
		[CompilerGenerated]
		set
		{
			gwdLkv2a6tV = value;
		}
	}

	public ActionStep ResultStep
	{
		[CompilerGenerated]
		get
		{
			return SFgLkSQdXbM;
		}
		[CompilerGenerated]
		set
		{
			SFgLkSQdXbM = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IStepRunner DhFLktkmXpL()
	{
		return sY6Lk2wDZAR;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Qk9Lkggm7Gm(IStepRunner value)
	{
		sY6Lk2wDZAR = value;
	}

	public KeyboardStepEditorWindow(ActionStep step)
	{
		EditingStep = step;
		InitializeComponent();
		base.Loaded += LKoLWzqBeqM;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void LKoLWzqBeqM(object sender, RoutedEventArgs e)
	{
        ActionStepParam value = default;
		ResultStep = JsonConvert.DeserializeObject<ActionStep>(JsonConvert.SerializeObject(EditingStep));
		Qk9Lkggm7Gm(StepRunnerRegistry.GetRunner(ResultStep.StepRunnerKey));
		int num;
		if (DhFLktkmXpL() == null)
		{
			AppHelper.ShowWarning("不支持的步骤类型：" + ResultStep.StepRunnerKey + "。请检查您的Quicker版本是否为最新。");
			num = 0;
			if (a9boTpFkyOPVvlCGvtrr != null)
			{
				goto IL_0074;
			}
		}
		goto IL_0081;
		IL_0074:
		switch (num)
		{
		case 1:
			goto IL_00cb;
		}
		goto IL_0081;
		IL_0081:
		base.Icon = AppHelper.GetStepIcon(DhFLktkmXpL(), this);
		base.Title = DhFLktkmXpL().Name;
		string data = string.Empty;
		value = default(ActionStepParam);
		if (ResultStep.InputParams.TryGetValue(KeyInputStep.KeysParam.Key, out value))
		{
			num = 1;
			if (!FdZUSkFkpYM8KgrEldvu())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0074;
		}
		goto IL_00d4;
		IL_00cb:
		data = value.Value;
		goto IL_00d4;
		IL_00d4:
		KeyInputStepData keyInputStepData = KeyInputStepData.Deserialize(data);
		KeyInputOrSelectControl.SetData(keyInputStepData.CtrlKeys, keyInputStepData.Keys);
		TxtNote.Text = ((EditingStep == null) ? "" : (EditingStep.Note ?? ""));
		ChkDisable.IsChecked = EditingStep != null && EditingStep.Disabled;
		int result = 1;
		if (ResultStep.InputParams.ContainsKey(KeyInputStep.RepeatCountParam.Key))
		{
			int.TryParse(ResultStep.InputParams[KeyInputStep.RepeatCountParam.Key].Value, out result);
		}
		TxtRepeat.Value = result;
		int result2 = 1;
		if (ResultStep.InputParams.ContainsKey(KeyInputStep.RepeatIntervalParam.Key))
		{
			int.TryParse(ResultStep.InputParams[KeyInputStep.RepeatIntervalParam.Key].Value, out result2);
		}
		TxtInterval.Value = result2;
		int result3 = -1;
		if (ResultStep.InputParams.ContainsKey(KeyInputStep.HoldMsParam.Key))
		{
			int.TryParse(ResultStep.InputParams[KeyInputStep.HoldMsParam.Key].Value, out result3);
		}
		TxtHoldMs.Value = result3;
		TxtDelayMs.Value = EditingStep?.DelayMs ?? 0;
	}

	private void g7pLkwHGav8(object sender, RoutedEventArgs e)
	{
		if (!BtnSave.IsFocused)
		{
			BtnSave.Focus();
		}
		KeyInputStepData keyInputStepData = new KeyInputStepData();
		keyInputStepData.Keys = KeyInputOrSelectControl.NormalKeys;
		keyInputStepData.CtrlKeys = KeyInputOrSelectControl.CtrlKeys;
		ResultStep.Note = TxtNote.Text;
		ResultStep.Disabled = ChkDisable.IsChecked == true;
		ResultStep.InputParams[KeyInputStep.KeysParam.Key] = new ActionStepParam
		{
			Value = keyInputStepData.Serialize()
		};
		ResultStep.InputParams[KeyInputStep.RepeatCountParam.Key] = new ActionStepParam
		{
			Value = ((int)TxtRepeat.Value).ToString()
		};
		ResultStep.InputParams[KeyInputStep.RepeatIntervalParam.Key] = new ActionStepParam
		{
			Value = ((int)TxtInterval.Value).ToString()
		};
		int num = 0;
		if (a9boTpFkyOPVvlCGvtrr != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ResultStep.InputParams[KeyInputStep.HoldMsParam.Key] = new ActionStepParam
		{
			Value = ((int)TxtHoldMs.Value).ToString()
		};
		ResultStep.DelayMs = (int)TxtDelayMs.Value;
		base.DialogResult = true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!EOULkuddtKb)
		{
			EOULkuddtKb = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/keyboardstepeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			KeyInputOrSelectControl = (KeyInputOrSelectControl)target;
			return;
		case 2:
			TxtHoldMs = (NumericUpDown)target;
			return;
		case 3:
			TxtRepeat = (NumericUpDown)target;
			return;
		case 4:
			TxtInterval = (NumericUpDown)target;
			return;
		case 5:
			TxtDelayMs = (NumericUpDown)target;
			return;
		case 6:
			TxtNote = (System.Windows.Controls.TextBox)target;
			return;
		case 7:
			ChkDisable = (CheckBox)target;
			return;
		case 8:
			BtnSave = (Button)target;
			BtnSave.Click += g7pLkwHGav8;
			return;
		}
		EOULkuddtKb = true;
		int num = 0;
		if (a9boTpFkyOPVvlCGvtrr != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static bool FdZUSkFkpYM8KgrEldvu()
	{
		return a9boTpFkyOPVvlCGvtrr == null;
	}
}
