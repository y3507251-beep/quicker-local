using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using FontAwesome5;
using FontAwesome5.WPF;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using log4net;
using Newtonsoft.Json;
using Quicker.Actions.XActions.StepRunners;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.X.Nodes;
using ViNASxihuuLY1Gg9m6p;
using WcdJQYXW9E2moeWW9Np;
using Z.Expressions;

namespace Quicker.View.X;

public class ActionStepEditorWindow : HandyControl.Controls.Window, IComponentConnector, IMockModalWindow
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnLoaded_003Eb__41_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionStepEditorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object HAv52oWHtD8e7DmeiSUV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionStepEditorWindow actionStepEditorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (PhGK47WHSNeLdImwSEV3())
						{
							switch (0)
							{
							}
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				AppHelper.RunOnUiThread(false, actionStepEditorWindow.vslLWVuvJJ7);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003C_003COnLoaded_003Eb__41_0_003Ed()
		{
		}

		internal static bool PhGK47WHSNeLdImwSEV3()
		{
			return HAv52oWHtD8e7DmeiSUV == null;
		}

		internal static void DLU7bkWHTRaTvmVaqv39()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec quqSAkVHHJy;

		public static Func<StepInParamDef, bool> VU3SAGMCpVS;

		public static Func<StepInParamDef, bool> dNjSAsD9Z6F;

		public static Func<StepInParamDef, bool> pnGSAHFXi42;

		public static Func<StepOutParamDef, bool> P5hSA1aREOP;

		public static Func<StepOutParamDef, bool> AbxSAbBMrQr;

		public static Func<StepInParamDef, bool> DR4SA68fQuy;

		public static Func<StepOutParamDef, bool> bqXSAXpmTgJ;

		public static Func<string, string> c93SAmF9aKn;

		public static Func<IGrouping<string, string>, bool> qj4SAKP2Kvi;

		public static Func<IGrouping<string, string>, string> qWnSAxIKerK;

		public static Func<string, bool> EaaSArN4Ccq;

		internal static _003C_003Ec R1YAVqWHmaRP9eIBnSau;

		static _003C_003Ec()
		{
			quqSAkVHHJy = new _003C_003Ec();
		}

		internal bool msgSARgeMZi(StepInParamDef x)
		{
			if (x.Key != SubProgramStep.SubProgramNameParam.Key)
			{
				return x.Key != SubProgramStep.SubProgramSummaryParam.Key;
			}
			return false;
		}

		internal bool KOgSAq21GsK(StepInParamDef x)
		{
			return !x.IsAdvanced;
		}

		internal bool XfdSAc9qT5B(StepInParamDef x)
		{
			return x.IsAdvanced;
		}

		internal bool bZPSAVWSJAZ(StepOutParamDef x)
		{
			return x.Key == StepOutParamDef.IsSuccessOutputParam.Key;
		}

		internal bool CsnSAZWjirE(StepOutParamDef x)
		{
			return x.Key == StepOutParamDef.ErrorMessageOutputParam.Key;
		}

		internal bool DAsSA99Ztan(StepInParamDef x)
		{
			return !string.IsNullOrEmpty(x.VisibleExpression);
		}

		internal bool jPsSAh9tQaO(StepOutParamDef x)
		{
			return !string.IsNullOrEmpty(x.VisibleExpression);
		}

		internal string zd5SAeTyRWs(string x)
		{
			return x;
		}

		internal bool vA3SAYPW0TL(IGrouping<string, string> x)
		{
			return x.Count() > 1;
		}

		internal string KyOSAIW6u2Z(IGrouping<string, string> x)
		{
			return x.Key;
		}

		internal bool ohfSAWSdR42(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal static bool X3107cWHsgb55Zo7ur6B()
		{
			return R1YAVqWHmaRP9eIBnSau == null;
		}

		internal static void YRpcokWH7WftQQWatVX3()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass48_0
	{
		public IDictionary<string, string> RGGSApnVhmR;

		public IDictionary<string, object> dr8SABtb3BE;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass48_1
	{
		public KeyValuePair<string, InputParamEditorControl> W4jSAjlM8hk;

		private static _003C_003Ec__DisplayClass48_1 WXWlPbWzVdevlj6ENj2I;

		internal bool I9iSAQ2kSr3(StepInParamDef x)
		{
			return x.Key == W4jSAjlM8hk.Key;
		}

		internal static bool TRliTpWzQjQYGmkttHRk()
		{
			return WXWlPbWzVdevlj6ENj2I == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public StepOutParamDef EcfSA4jAGmS;

		internal static _003C_003Ec__DisplayClass51_0 CfY7POWzcBLlNBWFRKym;

		internal bool bPDSAnH6IEZ(VariableSelector x)
		{
			return object.Equals(x.Tag, EcfSA4jAGmS.Key);
		}

		internal static bool eNSjoYWzWHHofqZmSgHp()
		{
			return CfY7POWzcBLlNBWFRKym == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public string veDSAdvndhc;

		internal static _003C_003Ec__DisplayClass53_0 mRSFCUWzpIXiipHtVbKK;

		internal bool WO6SA5uPZOH(StepInParamDef x)
		{
			return x.Key == veDSAdvndhc;
		}

		internal bool leiSADCHuKs(StepOutParamDef x)
		{
			return x.Key == veDSAdvndhc;
		}

		internal static bool Jedp8HWzXtnlkZyRkgSP()
		{
			return mRSFCUWzpIXiipHtVbKK == null;
		}
	}

	private static readonly ILog T7ULWWvyjo5;

	[CompilerGenerated]
	private ObservableCollection<ActionVariable> gvFLWkhWbHE;

	private readonly string TC2LWGj01Er;

	[CompilerGenerated]
	private ActionStep loMLWsbF07u;

	[CompilerGenerated]
	private ActionStep FvpLWH8greU;

	[CompilerGenerated]
	private IStepRunner WP8LW14NOXu;

	[CompilerGenerated]
	private bool Iw0LWbuPKmB;

	private readonly IList<VariableSelector> SW2LW6eOyZ5 = new List<VariableSelector>();

	public readonly IDictionary<string, InputParamEditorControl> _inputFieldControls = new Dictionary<string, InputParamEditorControl>();

	private readonly IDictionary<string, IList<FrameworkElement>> XsaLWXDFrXb = new Dictionary<string, IList<FrameworkElement>>();

	private SubProgram wZALWmMhil3;

	private int GgVLWKn8jyo = 274;

	private int dRlLWxXuhIl = 61472;

	private int TAaLWrFRmxd = 61488;

	private int hbSLWpGgeTg = 70;

	private int DGhLWBAtLN6 = 163;

	private int DsTLWQyiE8h = 2;

	private bool KVyLWjuS22J;

	private IList<StepInParamDef> bk1LWnR6Z1u;

	private IList<StepOutParamDef> LrILW47MsdT;

	[CompilerGenerated]
	private bool? cr8LW5CBKcF;

	internal TextBlock LblStepType;

	internal Button BtnSubProgramLink;

	internal Button BtnLink;

	internal StackPanel MainScroll;

	internal Expander ExpanderGeneral;

	internal ItemsControl PnlGeneral;

	internal Expander ExpanderAdvanced;

	internal ItemsControl PnlAdvanced;

	internal Expander PnlOutput;

	internal Grid GridOutput;

	internal Expander PnlOther;

	internal Grid GridOther;

	internal System.Windows.Controls.TextBox TxtNote;

	internal CheckBox ChkDisable;

	internal NumericUpDown TxtDelayMs;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool RllLWDdG9BL;

	internal static ActionStepEditorWindow iNIHPKFJfB7ckNn9lTsx;

	public ObservableCollection<ActionVariable> Variables
	{
		[CompilerGenerated]
		get
		{
			return gvFLWkhWbHE;
		}
		[CompilerGenerated]
		private set
		{
			gvFLWkhWbHE = value;
		}
	}

	public ActionStep EditingStep
	{
		[CompilerGenerated]
		get
		{
			return loMLWsbF07u;
		}
		[CompilerGenerated]
		set
		{
			loMLWsbF07u = value;
		}
	}

	public ActionStep ResultStep
	{
		[CompilerGenerated]
		get
		{
			return FvpLWH8greU;
		}
		[CompilerGenerated]
		set
		{
			FvpLWH8greU = value;
		}
	}

	public bool IsInSubProgram
	{
		[CompilerGenerated]
		get
		{
			return Iw0LWbuPKmB;
		}
		[CompilerGenerated]
		set
		{
			Iw0LWbuPKmB = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return cr8LW5CBKcF;
		}
		[CompilerGenerated]
		set
		{
			cr8LW5CBKcF = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IStepRunner ppHLWeor32g()
	{
		return WP8LW14NOXu;
	}

	[SpecialName]
	[CompilerGenerated]
	private void N02LWYjNPbM(IStepRunner value)
	{
		WP8LW14NOXu = value;
	}

	public ActionStepEditorWindow(ActionStep step, ObservableCollection<ActionVariable> variables, bool isInSubProgram = false, string subprogramIdentifier = null, SubProgram subProgram = null)
	{
		if (step == null)
		{
			throw new ArgumentNullException("step");
		}
		IsInSubProgram = isInSubProgram;
		Variables = variables;
		TC2LWGj01Er = subprogramIdentifier;
		wZALWmMhil3 = subProgram;
		EditingStep = step;
		InitializeComponent();
		base.Loaded += ywDLWvCbs61;
		base.Closing += ICPLIz50VEk;
		base.Closed += FUZLWwx0xtD;
		base.SourceInitialized += cQWLWt02osq;
		if (wZALWmMhil3 != null && !string.IsNullOrEmpty(wZALWmMhil3.TemplateId))
		{
			BtnSubProgramLink.Visibility = Visibility.Visible;
		}
		hkBLWSWcR5M();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void ICPLIz50VEk(object sender, CancelEventArgs e)
	{
		Keyboard.ClearFocus();
	}

	public void SetReadonly()
	{
		MainScroll.IsEnabled = false;
		BtnSave.IsEnabled = false;
		BtnSubProgramLink.IsEnabled = false;
	}

	private void FUZLWwx0xtD(object sender, EventArgs e)
	{
		foreach (InputParamEditorControl value in _inputFieldControls.Values)
		{
			try
			{
				value.ValueChanged -= UeBLWEZV067;
			}
			catch (Exception)
			{
			}
		}
	}

	private void cQWLWt02osq(object sender, EventArgs e)
	{
		l94LWgdZavF();
		IHNRIiikxBwJdYmHpM3.U4LvSg9Jpi8(this);
	}

	private void l94LWgdZavF()
	{
		HwndSource.FromHwnd(new WindowInteropHelper(this).Handle).AddHook(AQhLWLXpWor);
	}

	private IntPtr AQhLWLXpWor(IntPtr intptr_0, int int_6, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_3)
	{
		if ((int_6 == GgVLWKn8jyo && TAaLWrFRmxd == intptr_1.ToInt32()) || (int_6 == DGhLWBAtLN6 && DsTLWQyiE8h == intptr_1.ToInt32()))
		{
			ClearValue(FrameworkElement.MaxHeightProperty);
		}
		bool_3 = false;
		return IntPtr.Zero;
	}

	private void ywDLWvCbs61(object sender, RoutedEventArgs e)
	{
		if (!KVyLWjuS22J)
		{
			KVyLWjuS22J = true;
			ExpanderAdvanced.IsExpanded = dDh7g7Xw7JyQPUTbYwJ.ExpandAdvancedParams;
			Task.Run((Func<Task>)CcyLWcHQD7I);
		}
	}

	private void hkBLWSWcR5M()
	{
		Style style_ = (Style)FindResource("FormLabelStyle");
		ResultStep = JsonConvert.DeserializeObject<ActionStep>(JsonConvert.SerializeObject(EditingStep));
		N02LWYjNPbM(StepRunnerRegistry.GetRunner(ResultStep.StepRunnerKey));
		if (ppHLWeor32g() == null)
		{
			AppHelper.ShowWarning("不支持的步骤类型：" + ResultStep.StepRunnerKey + "。请检查您的Quicker版本是否为最新。");
			return;
		}
		LblStepType.Text = ppHLWeor32g().Description;
		if (wZALWmMhil3 == null)
		{
			goto IL_0087;
		}
		goto IL_03d5;
		IL_030f:
		int num2 = default(int);
		int num = num2;
		goto IL_03b2;
		IL_0087:
		BtnLink.Visibility = (string.IsNullOrEmpty(ppHLWeor32g().HelpLink) ? Visibility.Collapsed : Visibility.Visible);
		num = 1;
		if (!pAuRHGFJb0tN4lpAdLU8())
		{
			goto IL_030f;
		}
		goto IL_03b2;
		IL_03b2:
		IEnumerator<ActionVariable> enumerator = default(IEnumerator<ActionVariable>);
		List<StepInParamDef> list = default(List<StepInParamDef>);
		while (true)
		{
			List<StepInParamDef> list2;
			switch (num)
			{
			case 4:
				try
				{
					while (enumerator.MoveNext())
					{
						ActionVariable current2 = enumerator.Current;
						if (current2.IsInput)
						{
							StepInParamDef item = SubProgramStep.CreateStepInParam(current2);
							bk1LWnR6Z1u.Add(item);
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				((List<StepInParamDef>)bk1LWnR6Z1u).AddRange(ppHLWeor32g().InputParams.Where(_003C_003Ec.VU3SAGMCpVS ?? (_003C_003Ec.VU3SAGMCpVS = _003C_003Ec.quqSAkVHHJy.msgSARgeMZi)));
				goto IL_013b;
			case 2:
				gpWLW2nFl4o(PnlAdvanced, list);
				goto IL_01df;
			case 1:
				base.Icon = AppHelper.GetStepIcon(ppHLWeor32g(), this);
				base.Title = ppHLWeor32g().Name + "  -  编辑步骤";
				if (ppHLWeor32g().InputParams != null && ppHLWeor32g().InputParams.Count > 0)
				{
					if (wZALWmMhil3 == null)
					{
						bk1LWnR6Z1u = ppHLWeor32g().InputParams;
						goto IL_013b;
					}
					bk1LWnR6Z1u = new List<StepInParamDef>();
					enumerator = wZALWmMhil3.Variables.GetEnumerator();
					goto case 4;
				}
				ExpanderGeneral.Visibility = Visibility.Collapsed;
				goto IL_01df;
			case 5:
				break;
			default:
				LrILW47MsdT = LrILW47MsdT.ToList();
				LrILW47MsdT.Add(StepOutParamDef.ErrorMessageOutputParam);
				goto IL_0437;
			case 3:
				if (ppHLWeor32g().StepType == StepType.Loop)
				{
					goto case 6;
				}
				goto IL_05a0;
			case 6:
				{
					TxtDelayMs.IsEnabled = false;
					goto IL_05a0;
				}
				IL_0437:
				v6fLWuev2sy(LrILW47MsdT, style_);
				goto IL_0452;
				IL_0452:
				if (ppHLWeor32g().InputParams != null && ppHLWeor32g().InputParams.Count > 0 && ResultStep.InputParams != null)
				{
					foreach (StepInParamDef inputParam in ppHLWeor32g().InputParams)
					{
						if (inputParam.IsControlField && inputParam.Type == VarType.Enum)
						{
							ActionStepParam paramValue = _inputFieldControls[inputParam.Key].GetParamValue();
							MKpLWNdAie5(paramValue.Value);
						}
					}
				}
				if (ppHLWeor32g() is SubProgramStep)
				{
					liXLWJys641();
				}
				TxtNote.Text = ((EditingStep == null) ? "" : (EditingStep.Note ?? ""));
				ChkDisable.IsChecked = EditingStep != null && EditingStep.Disabled;
				TxtDelayMs.Value = EditingStep.DelayMs;
				if (ppHLWeor32g().StepType != StepType.Comment && ppHLWeor32g().StepType != StepType.If)
				{
					goto case 3;
				}
				goto case 6;
				IL_013b:
				list2 = bk1LWnR6Z1u.Where(_003C_003Ec.dNjSAsD9Z6F ?? (_003C_003Ec.dNjSAsD9Z6F = _003C_003Ec.quqSAkVHHJy.KOgSAq21GsK)).ToList();
				if (list2.HasData())
				{
					gpWLW2nFl4o(PnlGeneral, list2);
				}
				else
				{
					ExpanderGeneral.Visibility = Visibility.Collapsed;
				}
				list = bk1LWnR6Z1u.Where(_003C_003Ec.pnGSAHFXi42 ?? (_003C_003Ec.pnGSAHFXi42 = _003C_003Ec.quqSAkVHHJy.XfdSAc9qT5B)).ToList();
				if (list.HasData())
				{
					num2 = 2;
					goto case 2;
				}
				goto IL_01df;
				IL_01df:
				if (ppHLWeor32g().OutputParams != null && ppHLWeor32g().OutputParams.Count > 0)
				{
					if (wZALWmMhil3 == null)
					{
						LrILW47MsdT = ppHLWeor32g().OutputParams;
					}
					else
					{
						LrILW47MsdT = new List<StepOutParamDef>();
						((List<StepOutParamDef>)LrILW47MsdT).AddRange(ppHLWeor32g().OutputParams);
						enumerator = wZALWmMhil3.Variables.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ActionVariable current3 = enumerator.Current;
								if (current3.IsOutput)
								{
									LrILW47MsdT.Add(SubProgramStep.CreateStepOutParam(current3));
								}
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
					}
					if (LrILW47MsdT.Any(_003C_003Ec.P5hSA1aREOP ?? (_003C_003Ec.P5hSA1aREOP = _003C_003Ec.quqSAkVHHJy.bZPSAVWSJAZ)) && !(ppHLWeor32g() is GroupStepRunner) && !LrILW47MsdT.Any(_003C_003Ec.AbxSAbBMrQr ?? (_003C_003Ec.AbxSAbBMrQr = _003C_003Ec.quqSAkVHHJy.CsnSAZWjirE)))
					{
						goto IL_02ff;
					}
					goto IL_0437;
				}
				PnlOutput.Visibility = Visibility.Collapsed;
				goto IL_0452;
				IL_05a0:
				if (ppHLWeor32g().StepType == StepType.Comment)
				{
					System.Windows.Controls.TextBox txtNote = TxtNote;
					ChkDisable.Visibility = Visibility.Collapsed;
					txtNote.Visibility = Visibility.Collapsed;
				}
				return;
			}
			break;
			IL_02ff:
			num = 0;
			if (iNIHPKFJfB7ckNn9lTsx == null)
			{
				continue;
			}
			goto IL_030f;
		}
		goto IL_03d5;
		IL_03d5:
		LblStepType.Text = "运行子程序：" + wZALWmMhil3.Name;
		LblStepType.ToolTip = wZALWmMhil3.Description;
		goto IL_0087;
	}

	private void gpWLW2nFl4o(ItemsControl itemsControl_0, IList<StepInParamDef> ilist_3)
	{
		foreach (StepInParamDef item in ilist_3)
		{
			ActionStepParam value = null;
			if (!ResultStep.InputParams.TryGetValue(item.Key, out value) && !string.IsNullOrEmpty(item.FromOldField))
			{
				ResultStep.InputParams.TryGetValue(item.FromOldField, out value);
			}
			InputParamEditorControl inputParamEditorControl = new InputParamEditorControl(Variables, item, value);
			inputParamEditorControl.ValueChanged += UeBLWEZV067;
			inputParamEditorControl.Tag = item.Key;
			itemsControl_0.Items.Add(inputParamEditorControl);
			_inputFieldControls.Add(item.Key, inputParamEditorControl);
		}
	}

	private void v6fLWuev2sy(IList<StepOutParamDef> ilist_3, Style style_0)
	{
		Style style = (Style)FindResource("HintQuestionStyle");
		Brush brush = (Brush)FindResource("PrimaryTextBrush");
		int num = 0;
		foreach (StepOutParamDef item in ilist_3)
		{
			if (num >= GridOutput.RowDefinitions.Count)
			{
				GridOutput.RowDefinitions.Add(new RowDefinition
				{
					Height = GridLength.Auto
				});
			}
			List<FrameworkElement> list = new List<FrameworkElement>();
			XsaLWXDFrXb[item.Key] = list;
			TextBlock textBlock = new TextBlock();
			textBlock.Text = item.Name;
			textBlock.Tag = item;
			textBlock.Style = style_0;
			textBlock.TextWrapping = TextWrapping.Wrap;
			textBlock.MouseLeftButtonDown += oZBLWPojqWJ;
			list.Add(textBlock);
			Grid.SetRow(textBlock, num);
			Grid.SetColumn(textBlock, 0);
			GridOutput.Children.Add(textBlock);
			StackPanel stackPanel = new StackPanel();
			stackPanel.Margin = new Thickness(0.0, 0.0, 0.0, 5.0);
			stackPanel.Orientation = Orientation.Horizontal;
			list.Add(stackPanel);
			Grid.SetRow(stackPanel, num);
			Grid.SetColumn(stackPanel, 2);
			string value = null;
			ResultStep.OutputParams?.TryGetValue(item.Key, out value);
			ObservableCollection<ActionVariable> variables = Variables;
			VarType type = item.Type;
			string currentVarKey = value;
			string key = item.Key;
			string name = item.Name;
			VariableSelector variableSelector = new VariableSelector(variables, type, currentVarKey, true, null, null, IsInSubProgram, true, key, name);
			variableSelector.Tag = item.Key;
			SW2LW6eOyZ5.Add(variableSelector);
			variableSelector.VerticalAlignment = VerticalAlignment.Top;
			variableSelector.HorizontalAlignment = HorizontalAlignment.Left;
			list.Add(variableSelector);
			stackPanel.Children.Add(variableSelector);
			if (!string.IsNullOrEmpty(item.Description))
			{
				if (AppState.HHxtaMaoqJr().ShowParamDescAsToolTip)
				{
					variableSelector.ToolTip = item.Description;
					Button button = new Button
					{
						ToolTip = item.Description,
						HorizontalAlignment = HorizontalAlignment.Center,
						VerticalAlignment = VerticalAlignment.Top,
						Style = style,
						Margin = new Thickness(6.0)
					};
					stackPanel.Children.Add(button);
					SvgAwesome svgAwesome = (SvgAwesome)(button.Content = new SvgAwesome
					{
						Height = 16.0,
						Width = 16.0,
						Icon = EFontAwesomeIcon.Light_QuestionCircle,
						Foreground = Brushes.Red
					});
					svgAwesome.ClearValue(SvgAwesome.ForegroundProperty);
				}
				else
				{
					TextBlock textBlock2 = new TextBlock();
					textBlock2.Foreground = Brushes.DarkGray;
					textBlock2.Text = item.Description;
					textBlock2.ToolTip = item.Description;
					textBlock2.Margin = new Thickness(3.0, 0.0, 0.0, 0.0);
					textBlock2.VerticalAlignment = VerticalAlignment.Center;
					textBlock2.TextWrapping = TextWrapping.Wrap;
					textBlock2.MaxWidth = 350.0;
					stackPanel.Children.Add(textBlock2);
				}
			}
			GridOutput.Children.Add(stackPanel);
			num++;
		}
	}

	private void MKpLWNdAie5(string string_1)
	{
		int num = 1;
		BaseMultiOperationStep baseMultiOperationStep = default(BaseMultiOperationStep);
		while (true)
		{
			bool flag = false;
			int num2 = 0;
			if (iNIHPKFJfB7ckNn9lTsx != null)
			{
				goto IL_0026;
			}
			goto IL_0027;
			IL_0027:
			while (true)
			{
				StepOperation stepOperation;
				object obj;
				IList<StepInParamDef> list;
				switch (num2)
				{
				default:
					baseMultiOperationStep = ppHLWeor32g() as BaseMultiOperationStep;
					if (baseMultiOperationStep != null)
					{
						goto IL_0019;
					}
					foreach (StepInParamDef inputParam in ppHLWeor32g().InputParams)
					{
						if (inputParam.ValidForList == null && inputParam.InvalidForList == null)
						{
							continue;
						}
						if (inputParam.ValidForList != null)
						{
							bool bool_2 = false;
							foreach (string validFor in inputParam.ValidForList)
							{
								if (validFor.Equals(string_1, StringComparison.OrdinalIgnoreCase))
								{
									bool_2 = true;
									break;
								}
							}
							bpKLW0M3ax5(inputParam.Key, bool_2);
						}
						else
						{
							if (inputParam.InvalidForList == null)
							{
								continue;
							}
							bool bool_3 = true;
							foreach (string invalidFor in inputParam.InvalidForList)
							{
								if (invalidFor.Equals(string_1, StringComparison.OrdinalIgnoreCase))
								{
									bool_3 = false;
									break;
								}
							}
							bpKLW0M3ax5(inputParam.Key, bool_3);
						}
					}
					if (ppHLWeor32g().OutputParams != null)
					{
						foreach (StepOutParamDef outputParam in ppHLWeor32g().OutputParams)
						{
							bool flag3 = true;
							if (outputParam.ValidForList != null)
							{
								flag3 = false;
								foreach (string validFor2 in outputParam.ValidForList)
								{
									if (validFor2.Equals(string_1, StringComparison.OrdinalIgnoreCase))
									{
										flag3 = true;
										break;
									}
								}
								RkbLWCQFAYL(outputParam.Key, flag3);
							}
							else if (outputParam.InvalidForList != null)
							{
								flag3 = true;
								foreach (string invalidFor2 in outputParam.InvalidForList)
								{
									if (invalidFor2.Equals(string_1, StringComparison.OrdinalIgnoreCase))
									{
										flag3 = false;
										break;
									}
								}
								RkbLWCQFAYL(outputParam.Key, flag3);
							}
							flag = flag || flag3;
							if (iNIHPKFJfB7ckNn9lTsx == null)
							{
								switch (0)
								{
								}
							}
						}
					}
					goto IL_035b;
				case 1:
					break;
				case 2:
					{
						stepOperation = baseMultiOperationStep.GetStepOperation(string_1);
						if (stepOperation == null)
						{
							return;
						}
						if (stepOperation == null)
						{
							obj = null;
						}
						else
						{
							obj = stepOperation.InputParams;
							if (obj != null)
							{
								goto IL_028e;
							}
						}
						obj = new List<StepInParamDef>();
						goto IL_028e;
					}
					IL_028e:
					list = (IList<StepInParamDef>)obj;
					foreach (StepInParamDef inputParam2 in ppHLWeor32g().InputParams)
					{
						if (!inputParam2.IsControlField && inputParam2 != BaseMultiOperationStep.dpTghM5oQ8k)
						{
							bool bool_ = list.Contains(inputParam2);
							bpKLW0M3ax5(inputParam2.Key, bool_);
						}
					}
					if (ppHLWeor32g().OutputParams != null)
					{
						foreach (StepOutParamDef outputParam2 in ppHLWeor32g().OutputParams)
						{
							bool flag2 = outputParam2 == BaseMultiOperationStep.YBvghAou5MC || stepOperation.OutputParams.Contains(outputParam2);
							RkbLWCQFAYL(outputParam2.Key, flag2);
							flag = flag || flag2;
						}
					}
					goto IL_035b;
					IL_035b:
					PnlOutput.Visibility = flag.ToVisibility();
					return;
				}
				break;
				IL_0019:
				num2 = 2;
				if (pAuRHGFJb0tN4lpAdLU8())
				{
					continue;
				}
				goto IL_0026;
			}
			continue;
			IL_0026:
			num2 = num;
			goto IL_0027;
		}
	}

	private void liXLWJys641()
	{
		if (!bk1LWnR6Z1u.Any(_003C_003Ec.DR4SA68fQuy ?? (_003C_003Ec.DR4SA68fQuy = _003C_003Ec.quqSAkVHHJy.DAsSA99Ztan)) && !LrILW47MsdT.Any(_003C_003Ec.bqXSAXpmTgJ ?? (_003C_003Ec.bqXSAXpmTgJ = _003C_003Ec.quqSAkVHHJy.jPsSAh9tQaO)))
		{
			return;
		}
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_0_ = default(_003C_003Ec__DisplayClass48_0);
		_003C_003Ec__DisplayClass48_0_.RGGSApnVhmR = new Dictionary<string, string>();
		_003C_003Ec__DisplayClass48_0_.dr8SABtb3BE = new Dictionary<string, object>();
		IEnumerator<KeyValuePair<string, InputParamEditorControl>> enumerator = _inputFieldControls.GetEnumerator();
		if (iNIHPKFJfB7ckNn9lTsx != null)
		{
			switch (0)
			{
			}
		}
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass48_1 _003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_1();
				_003C_003Ec__DisplayClass48_.W4jSAjlM8hk = enumerator.Current;
				if (!_003C_003Ec__DisplayClass48_.W4jSAjlM8hk.Key.StartsWith("var:"))
				{
					continue;
				}
				string key = _003C_003Ec__DisplayClass48_.W4jSAjlM8hk.Key.Substring(4);
				string text = _003C_003Ec__DisplayClass48_.W4jSAjlM8hk.Value.GetParamValue().Value ?? "";
				_003C_003Ec__DisplayClass48_0_.RGGSApnVhmR[key] = text;
				StepInParamDef stepInParamDef = bk1LWnR6Z1u.FirstOrDefault(_003C_003Ec__DisplayClass48_.I9iSAQ2kSr3);
				if (stepInParamDef == null)
				{
					continue;
				}
				if (iNIHPKFJfB7ckNn9lTsx == null)
				{
					switch (0)
					{
					}
				}
				if (text.StartsWith("$=") || text.StartsWith("$$"))
				{
					continue;
				}
				try
				{
					_003C_003Ec__DisplayClass48_0_.dr8SABtb3BE[key] = VariableHelper.ConvertToType(stepInParamDef.InternalType ?? stepInParamDef.Type, _003C_003Ec__DisplayClass48_0_.RGGSApnVhmR[key]);
				}
				catch (Exception)
				{
					try
					{
						_003C_003Ec__DisplayClass48_0_.dr8SABtb3BE[key] = VariableHelper.ConvertVarDefaultValue(stepInParamDef.InternalType ?? stepInParamDef.Type, "");
					}
					catch
					{
					}
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		foreach (StepInParamDef item in bk1LWnR6Z1u)
		{
			if (!string.IsNullOrEmpty(item.VisibleExpression))
			{
				bpKLW0M3ax5(item.Key, IhKLWZgEP4g(item.VisibleExpression, item.Name, ref _003C_003Ec__DisplayClass48_0_));
			}
		}
		bool flag = false;
		if (LrILW47MsdT != null)
		{
			int num2 = default(int);
			foreach (StepOutParamDef item2 in LrILW47MsdT)
			{
				if (!string.IsNullOrEmpty(item2.VisibleExpression))
				{
					bool flag2 = IhKLWZgEP4g(item2.VisibleExpression, item2.Name, ref _003C_003Ec__DisplayClass48_0_);
					RkbLWCQFAYL(item2.Key, flag2);
					flag = flag || flag2;
					int num = 0;
					if (iNIHPKFJfB7ckNn9lTsx != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					flag = true;
				}
			}
		}
		PnlOutput.Visibility = flag.ToVisibility();
	}

	private void bpKLW0M3ax5(string string_1, bool bool_3)
	{
		_inputFieldControls.TryGetValue(string_1, out var value);
		if (value != null)
		{
			value.Visibility = bool_3.ToVisibility();
		}
	}

	private void RkbLWCQFAYL(string string_1, bool bool_3)
	{
		IList<FrameworkElement> value = null;
		XsaLWXDFrXb.TryGetValue(string_1, out value);
		if (value == null)
		{
			return;
		}
		foreach (FrameworkElement item in value)
		{
			item.Visibility = bool_3.ToVisibility();
		}
	}

	private void oZBLWPojqWJ(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount != 2)
		{
			return;
		}
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.EcfSA4jAGmS = (sender as FrameworkElement).Tag as StepOutParamDef;
		VariableSelector variableSelector = SW2LW6eOyZ5.FirstOrDefault(_003C_003Ec__DisplayClass51_.bPDSAnH6IEZ);
		if (string.IsNullOrEmpty(variableSelector.GetSelectedVariableKey()))
		{
			ActionVariable actionVariable = XActionUiHelper.CreateVariable(System.Windows.Window.GetWindow(this), Variables, _003C_003Ec__DisplayClass51_.EcfSA4jAGmS.Type, wZALWmMhil3 != null, _003C_003Ec__DisplayClass51_.EcfSA4jAGmS.Key, _003C_003Ec__DisplayClass51_.EcfSA4jAGmS.Name, true, true);
			if (actionVariable != null)
			{
				variableSelector.CbVariables.SelectedItem = actionVariable;
			}
		}
	}

	private void UeBLWEZV067(object sender, EventArgs e)
	{
		if (sender is InputParamEditorControl inputParamEditorControl && inputParamEditorControl.ParamDef.IsControlField)
		{
			MKpLWNdAie5(inputParamEditorControl.GetParamValue().Value);
		}
		if (ppHLWeor32g() is SubProgramStep)
		{
			liXLWJys641();
		}
	}

	private void Am9LWyY1w4T(object sender, RoutedEventArgs e)
	{
		if (!BtnSave.IsFocused)
		{
			BtnSave.Focus();
		}
		ResultStep.InputParams.Clear();
		ResultStep.OutputParams.Clear();
		int num = 0;
		if (!pAuRHGFJb0tN4lpAdLU8())
		{
			int num2 = default(int);
			num = num2;
		}
		List<string> list = default(List<string>);
		do
		{
			switch (num)
			{
			default:
			{
				if (wZALWmMhil3 != null)
				{
					ResultStep.InputParams[SubProgramStep.SubProgramNameParam.Key] = new ActionStepParam
					{
						Value = TC2LWGj01Er
					};
				}
				foreach (InputParamEditorControl value2 in _inputFieldControls.Values)
				{
					if (value2.Visibility == Visibility.Visible)
					{
						ResultStep.InputParams[(string)value2.Tag] = value2.GetParamValue();
						continue;
					}
					string key = (string)value2.Tag;
					if (iNIHPKFJfB7ckNn9lTsx == null)
					{
						switch (0)
						{
						}
					}
					if (ResultStep.InputParams.ContainsKey(key))
					{
						ResultStep.InputParams.Remove(key);
					}
				}
				using (IEnumerator<VariableSelector> enumerator2 = SW2LW6eOyZ5.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						VariableSelector current2 = enumerator2.Current;
						if (current2.IsVisible)
						{
							ResultStep.OutputParams[(string)current2.Tag] = current2.GetSelectedVariableKey();
							continue;
						}
						string key2 = (string)current2.Tag;
						if (ResultStep.OutputParams.ContainsKey(key2))
						{
							ResultStep.OutputParams.Remove(key2);
						}
					}
					if (pAuRHGFJb0tN4lpAdLU8())
					{
						switch (0)
						{
						}
					}
				}
				if (wZALWmMhil3 != null && !string.IsNullOrEmpty(wZALWmMhil3.SummaryExpression))
				{
					string text = wZALWmMhil3.SummaryExpression;
					if (text.StartsWith("$$"))
					{
						text = text.Substring(2);
					}
					string value = new Regex("\\{([^}^{]+)\\}").Replace(text, OZELW9e9l6W);
					ResultStep.InputParams[SubProgramStep.SubProgramSummaryParam.Key] = new ActionStepParam
					{
						Value = value
					};
				}
				ResultStep.Note = TxtNote.Text;
				ResultStep.Disabled = ChkDisable.IsChecked == true;
				ResultStep.DelayMs = (int)TxtDelayMs.Value;
				list = ResultStep.OutputParams.Values.GroupBy(_003C_003Ec.c93SAmF9aKn ?? (_003C_003Ec.c93SAmF9aKn = _003C_003Ec.quqSAkVHHJy.zd5SAeTyRWs)).Where(_003C_003Ec.qj4SAKP2Kvi ?? (_003C_003Ec.qj4SAKP2Kvi = _003C_003Ec.quqSAkVHHJy.vA3SAYPW0TL)).Select(_003C_003Ec.qWnSAxIKerK ?? (_003C_003Ec.qWnSAxIKerK = _003C_003Ec.quqSAkVHHJy.KyOSAIW6u2Z))
					.Where(_003C_003Ec.EaaSArN4Ccq ?? (_003C_003Ec.EaaSArN4Ccq = _003C_003Ec.quqSAkVHHJy.ohfSAWSdR42))
					.ToList();
				if (list.Count <= 0)
				{
					this.ThNvuM5Q9GQ(true);
					return;
				}
				goto IL_0354;
			}
			case 1:
				break;
			}
			break;
			IL_0354:
			num = 1;
		}
		while (iNIHPKFJfB7ckNn9lTsx != null);
		AppHelper.ShowWarning("输出参数不能写入到相同的变量(" + string.Join(",", list) + ")中。");
	}

	private void sGBLW8563VU(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(ppHLWeor32g().HelpLink);
	}

	private void XbQLWaK0qjV(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(wZALWmMhil3?.TemplateId))
		{
			AppHelper.TryOpenUrlOrFile(AppHelper.CreateSharedSubProgramLink(wZALWmMhil3.TemplateId));
		}
	}

	private void qpCLW73PVS5(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	public void CloseAllParamEditors()
	{
		foreach (InputParamEditorControl value in _inputFieldControls.Values)
		{
			value.CloseEditor();
		}
	}

	private void eE8LWRyI8VG(object sender, RoutedEventArgs e)
	{
		dDh7g7Xw7JyQPUTbYwJ.ExpandAdvancedParams = true;
	}

	private void odbLWqJDPtN(object sender, RoutedEventArgs e)
	{
		dDh7g7Xw7JyQPUTbYwJ.ExpandAdvancedParams = false;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!RllLWDdG9BL)
		{
			RllLWDdG9BL = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/actionstepeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 4:
				MainScroll = (StackPanel)target;
				num2 = 2;
				if (!pAuRHGFJb0tN4lpAdLU8())
				{
					num2 = num;
				}
				goto IL_0028;
			default:
				num2 = 0;
				if (!pAuRHGFJb0tN4lpAdLU8())
				{
					goto IL_0028;
				}
				goto IL_00f2;
			case 1:
				LblStepType = (TextBlock)target;
				return;
			case 2:
				BtnSubProgramLink = (Button)target;
				BtnSubProgramLink.Click += XbQLWaK0qjV;
				return;
			case 3:
				BtnLink = (Button)target;
				BtnLink.Click += sGBLW8563VU;
				return;
			case 5:
				ExpanderGeneral = (Expander)target;
				return;
			case 6:
				PnlGeneral = (ItemsControl)target;
				return;
			case 7:
				ExpanderAdvanced = (Expander)target;
				ExpanderAdvanced.Collapsed += odbLWqJDPtN;
				ExpanderAdvanced.Expanded += eE8LWRyI8VG;
				return;
			case 8:
				PnlAdvanced = (ItemsControl)target;
				return;
			case 9:
				PnlOutput = (Expander)target;
				return;
			case 10:
				GridOutput = (Grid)target;
				return;
			case 11:
				PnlOther = (Expander)target;
				return;
			case 12:
				GridOther = (Grid)target;
				return;
			case 13:
				TxtNote = (System.Windows.Controls.TextBox)target;
				return;
			case 14:
				ChkDisable = (CheckBox)target;
				return;
			case 15:
				TxtDelayMs = (NumericUpDown)target;
				return;
			case 16:
				BtnSave = (Button)target;
				BtnSave.Click += Am9LWyY1w4T;
				return;
			case 17:
				{
					BtnCancel = (Button)target;
					BtnCancel.Click += qpCLW73PVS5;
					return;
				}
				IL_00f2:
				RllLWDdG9BL = true;
				return;
				IL_0028:
				switch (num2)
				{
				case 1:
					goto end_IL_004f;
				case 2:
					return;
				}
				goto IL_00f2;
				end_IL_004f:
				break;
			}
		}
	}

	static ActionStepEditorWindow()
	{
		T7ULWWvyjo5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[AsyncStateMachine(typeof(_003C_003COnLoaded_003Eb__41_0_003Ed))]
	[CompilerGenerated]
	private Task CcyLWcHQD7I()
	{
		_003C_003COnLoaded_003Eb__41_0_003Ed stateMachine = default(_003C_003COnLoaded_003Eb__41_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void vslLWVuvJJ7()
	{
		base.SizeToContent = SizeToContent.Manual;
		PnlGeneral.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	[CompilerGenerated]
	internal static bool IhKLWZgEP4g(string string_1, string string_2, ref _003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_0_0)
	{
		try
		{
			if (string_1.StartsWith("$="))
			{
				foreach (string key in _003C_003Ec__DisplayClass48_0_0.RGGSApnVhmR.Keys)
				{
					string_1 = string_1.Replace("{" + key + "}", key);
				}
				try
				{
					return Eval.Execute<bool>(string_1.Substring(2), _003C_003Ec__DisplayClass48_0_0.dr8SABtb3BE);
				}
				catch (Exception ex)
				{
					string message = "更新字段 " + string_2 + " 可见性出错，准备再次尝试。\n表达式：" + string_1 + " \n错误：" + ex.Message;
					T7ULWWvyjo5.Warn(message, ex);
					return Eval.Execute<bool>(string_1.Substring(2), _003C_003Ec__DisplayClass48_0_0.RGGSApnVhmR);
				}
			}
			try
			{
				return Eval.Execute<bool>(string_1, _003C_003Ec__DisplayClass48_0_0.dr8SABtb3BE);
			}
			catch
			{
				return Eval.Execute<bool>(string_1, _003C_003Ec__DisplayClass48_0_0.RGGSApnVhmR);
			}
		}
		catch (Exception ex2)
		{
			string message2 = "更新字段 " + string_2 + " 可见性出错。\n表达式：" + ex2.Message;
			T7ULWWvyjo5.Warn(message2, ex2);
			AppHelper.ShowWarning(message2);
			return true;
		}
	}

	[CompilerGenerated]
	private string OZELW9e9l6W(Match match_0)
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		string value = match_0.Groups[1].Value;
		_003C_003Ec__DisplayClass53_.veDSAdvndhc = "var:" + value;
		StepInParamDef stepInParamDef = bk1LWnR6Z1u.FirstOrDefault(_003C_003Ec__DisplayClass53_.WO6SA5uPZOH);
		if (stepInParamDef != null)
		{
			return XActionHelper.GetParamDisplayString(stepInParamDef, ResultStep);
		}
		StepOutParamDef stepOutParamDef = LrILW47MsdT.FirstOrDefault(_003C_003Ec__DisplayClass53_.leiSADCHuKs);
		if (stepOutParamDef != null)
		{
			return XActionHelper.GetOutputParamDisplayString(stepOutParamDef, ResultStep);
		}
		return match_0.Value;
	}

	internal static bool pAuRHGFJb0tN4lpAdLU8()
	{
		return iNIHPKFJfB7ckNn9lTsx == null;
	}
}
