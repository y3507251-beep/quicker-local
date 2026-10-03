using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Quicker.Actions.XActions.Storage;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.Tables;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.UI;

namespace Quicker.View.X;

public class VariableEditorWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec SVoSOpamjTJ;

		public static Func<ActionVariable, string> BjYSOBrIXi4;

		public static Func<string, bool> O8PSOQFSx4J;

		public static Func<string, string> REZSOj437A8;

		public static Func<VarTypeItem, bool> NaeSOndO9W6;

		public static Func<ActionVariable, bool> FkhSO49avwP;

		public static Func<ActionVariable, bool> EV0SO5i2wmy;

		private static _003C_003Ec FiVbEdWz4kVLWLsLnWNl;

		static _003C_003Ec()
		{
			SVoSOpamjTJ = new _003C_003Ec();
		}

		internal string xTtSO6TxpcV(ActionVariable x)
		{
			return x.Group;
		}

		internal bool CKMSOX6r2Ek(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string e98SOmX7fY1(string x)
		{
			return x;
		}

		internal bool bRZSOKrsjiZ(VarTypeItem x)
		{
			return x.VarType == VarType.Any;
		}

		internal bool FmRSOx4ji3o(ActionVariable x)
		{
			return x.IsInput;
		}

		internal bool nNnSOrA9uLM(ActionVariable x)
		{
			return x.IsInput;
		}

		internal static bool gTlxb1WzhISmkJjiPlmx()
		{
			return FiVbEdWz4kVLWLsLnWNl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public VariableEditorWindow lZKSOT5YVJA;

		public string QnbSOMlFY19;

		internal static _003C_003Ec__DisplayClass26_0 eRUkw6yVV6DNGRbhpXcH;

		internal bool g3xSODqrCHU(ActionVariable x)
		{
			return x.Key == QnbSOMlFY19;
		}

		internal bool j2USOd5pqIo(ActionVariable x)
		{
			return x.Key == QnbSOMlFY19;
		}

		internal bool ctMSOojbmD0(ActionVariable x)
		{
			if (x != lZKSOT5YVJA.EditingVariable)
			{
				return x.Key == QnbSOMlFY19;
			}
			return false;
		}

		internal static bool s1g85ZyVQeqPmD5IyIXK()
		{
			return eRUkw6yVV6DNGRbhpXcH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditTableDef_Click_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VariableEditorWindow _003C_003E4__this;

		private TableDesignerWindow _003Cwindow_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object cpdG1ByVyQbWvTekG0rO;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VariableEditorWindow variableEditorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					TableDef tableDef = variableEditorWindow.Result.TableDef;
					if (tableDef == null)
					{
						tableDef = new TableDef();
					}
					_003Cwindow_003E5__2 = new TableDesignerWindow(tableDef)
					{
						Owner = variableEditorWindow
					};
					awaiter = _003Cwindow_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					variableEditorWindow.Result.TableDef = _003Cwindow_003E5__2.GetResult();
					int num2 = 0;
					if (!ot1ZjWyVpTmcTf6cuFMb())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cwindow_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cwindow_003E5__2 = null;
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

		internal static bool ot1ZjWyVpTmcTf6cuFMb()
		{
			return cpdG1ByVyQbWvTekG0rO == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSave_OnClick_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VariableEditorWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		private TaskAwaiter<(bool isSuccess, string button)> _003C_003Eu__1;

		private static object i12cRuyVAP13Jvckgeop;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VariableEditorWindow variableEditorWindow = _003C_003E4__this;
			try
			{
        int num3 = default;
				TaskAwaiter<(bool, string)> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0435;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass26_0();
				_003C_003E8__1.lZKSOT5YVJA = _003C_003E4__this;
				int num2;
				if (!variableEditorWindow.DE1LsL32It1(variableEditorWindow.TxtKey))
				{
					AppHelper.ShowWarning("请输入变量名称！");
				}
				else
				{
					_003C_003E8__1.QnbSOMlFY19 = variableEditorWindow.TxtKey.Text.Trim();
					if (!IsValidVarKey(_003C_003E8__1.QnbSOMlFY19))
					{
						goto IL_03b6;
					}
					if (variableEditorWindow.EditingVariable == null)
					{
						if (!variableEditorWindow.CurrentVariables.Any(_003C_003E8__1.g3xSODqrCHU))
						{
							goto IL_0190;
						}
						if (!variableEditorWindow.AllowUseExistingVariable)
						{
							num2 = 0;
							if (i12cRuyVAP13Jvckgeop != null)
							{
								goto IL_02fa;
							}
							goto IL_02fe;
						}
						awaiter = ConfirmDialog.jQyL0Wq9wU6(variableEditorWindow, "变量名已存在", "", "变量名 " + _003C_003E8__1.QnbSOMlFY19 + " 已经存在，是否直接选择此变量？", "Question", "使用此变量(_Y)|Yes\r\n更改变量名(_N)|No", "Yes").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0435;
					}
					if (!variableEditorWindow.CurrentVariables.Any(_003C_003E8__1.ctMSOojbmD0))
					{
						goto IL_0190;
					}
					AppHelper.ShowWarning("变量名 " + _003C_003E8__1.QnbSOMlFY19 + " 已存在！");
				}
				goto end_IL_0010;
				IL_03b6:
				AppHelper.ShowWarning("不能使用这个变量名。\r\n请使用英文字母或下划线开始的字符串作为变量名，不能有空格或其他特殊字符。\r\n在需要的时候也可以使用中文。", true);
				variableEditorWindow.TxtKey.Focus();
				goto end_IL_0010;
				IL_037c:
				if (variableEditorWindow.Result.Type != VarType.Table)
				{
					variableEditorWindow.Result.TableDef = null;
					num2 = 3;
					if (i12cRuyVAP13Jvckgeop != null)
					{
						goto IL_02fa;
					}
					goto IL_02fe;
				}
				goto IL_03d3;
				IL_03d3:
				if (variableEditorWindow.ChkAsInput.IsChecked != true || !variableEditorWindow.ChkAsInput.IsVisible)
				{
					variableEditorWindow.Result.InputParamInfo = null;
				}
				variableEditorWindow.DialogResult = true;
				goto end_IL_0010;
				IL_0456:
				variableEditorWindow.Result = variableEditorWindow.CurrentVariables.First(_003C_003E8__1.j2USOd5pqIo);
				variableEditorWindow.DialogResult = true;
				goto end_IL_0010;
				IL_0435:
				num3 = default(int);
				if (awaiter.GetResult().Item2 == "Yes")
				{
					num3 = 2;
					goto IL_0456;
				}
				goto end_IL_0010;
				IL_02fe:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0391;
				case 4:
					goto IL_03b6;
				case 3:
					goto IL_03d3;
				case 2:
					goto IL_0456;
				}
				try
				{
					if (!variableEditorWindow.Result.Type.IsEither(VarType.Table, VarType.Any, VarType.CreateVar, VarType.NA, VarType.Object))
					{
						VariableHelper.ConvertToType(variableEditorWindow.Result.Type, variableEditorWindow.Result.DefaultValue);
					}
				}
				catch (Exception)
				{
					AppHelper.ShowWarning("默认值不合法，无法转换成目标类型。");
					variableEditorWindow.TxtDefaultValue.Focus();
					goto end_IL_0010;
				}
				goto IL_037c;
				IL_02fa:
				num2 = num3;
				goto IL_02fe;
				IL_0190:
				variableEditorWindow.Result.Key = _003C_003E8__1.QnbSOMlFY19;
				variableEditorWindow.Result.Type = (variableEditorWindow.CbType.SelectedItem as VarTypeItem).VarType;
				variableEditorWindow.Result.Desc = variableEditorWindow.TxtDesc.Text;
				variableEditorWindow.Result.DefaultValue = variableEditorWindow.TxtDefaultValue.Text;
				variableEditorWindow.Result.SaveState = variableEditorWindow.ChkEnableSaveValue.IsChecked == true;
				variableEditorWindow.Result.IsInput = variableEditorWindow.ChkAsInput.IsChecked == true;
				variableEditorWindow.Result.IsOutput = variableEditorWindow.ChkAsOutput.IsChecked == true;
				variableEditorWindow.Result.ParamName = variableEditorWindow.TxtParamName.Text.Trim();
				variableEditorWindow.Result.Group = variableEditorWindow.CbGroup.Text?.Trim();
				if (string.IsNullOrEmpty(variableEditorWindow.TxtDefaultValue.Text) || variableEditorWindow.TxtDefaultValue.Text.StartsWith("$="))
				{
					goto IL_037c;
				}
				num2 = 1;
				if (i12cRuyVAP13Jvckgeop == null)
				{
					goto IL_02fe;
				}
				goto IL_0391;
				IL_0391:
				AppHelper.ShowWarning("变量名 " + _003C_003E8__1.QnbSOMlFY19 + " 已存在！");
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool uZTHlbyVn9MBv31WxE6h()
		{
			return i12cRuyVAP13Jvckgeop == null;
		}
	}

	private readonly bool loTLsEQ3DK8;

	private readonly ObservableCollection<VarTypeItem> RrRLsyKHGHW = new ObservableCollection<VarTypeItem>();

	[CompilerGenerated]
	private ActionVariable lWHLs8n189B;

	[CompilerGenerated]
	private ActionVariable Fs5LsaamtRH = new ActionVariable();

	[CompilerGenerated]
	private IEnumerable<ActionVariable> iBlLs79OdU0;

	[CompilerGenerated]
	private VarType? q6lLsRjxU59;

	[CompilerGenerated]
	private bool g0qLsq67223;

	internal TextBox TxtKey;

	internal TextBlock LblHintForSubprogram;

	internal ComboBox CbType;

	internal TextBox TxtDefaultValue;

	internal MenuItem MenuEditInEditor1;

	internal Button BtnEditInCode;

	internal TextBox TxtDesc;

	internal StackPanel PnlEditTableDef;

	internal Button BtnEditTableDef;

	internal StackPanel PnlEnableSaveValue;

	internal CheckBox ChkEnableSaveValue;

	internal StackPanel PnlSubProgramOptions;

	internal CheckBox ChkAsInput;

	internal Button BtnInputParamOptions;

	internal CheckBox ChkAsOutput;

	internal Button BtnOutputParamOptions;

	internal StackPanel PnlParamName;

	internal TextBox TxtParamName;

	internal TextBlock LblGroup;

	internal StackPanel PnlGroup;

	internal ComboBox CbGroup;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool HpPLscro4MC;

	internal static VariableEditorWindow UecHBhFaAEO598MmoeUB;

	public ActionVariable EditingVariable
	{
		[CompilerGenerated]
		get
		{
			return lWHLs8n189B;
		}
		[CompilerGenerated]
		set
		{
			lWHLs8n189B = value;
		}
	}

	public ActionVariable Result
	{
		[CompilerGenerated]
		get
		{
			return Fs5LsaamtRH;
		}
		[CompilerGenerated]
		set
		{
			Fs5LsaamtRH = value;
		}
	}

	public IEnumerable<ActionVariable> CurrentVariables
	{
		[CompilerGenerated]
		get
		{
			return iBlLs79OdU0;
		}
		[CompilerGenerated]
		set
		{
			iBlLs79OdU0 = value;
		}
	}

	public VarType? PresetVarType
	{
		[CompilerGenerated]
		get
		{
			return q6lLsRjxU59;
		}
		[CompilerGenerated]
		set
		{
			q6lLsRjxU59 = value;
		}
	}

	public bool AllowUseExistingVariable
	{
		[CompilerGenerated]
		get
		{
			return g0qLsq67223;
		}
		[CompilerGenerated]
		set
		{
			g0qLsq67223 = value;
		}
	}

	public VariableEditorWindow(IEnumerable<ActionVariable> currentVariables, bool isForSubProgram = false)
	{
		loTLsEQ3DK8 = isForSubProgram;
		InitializeComponent();
		CurrentVariables = currentVariables;
		CbType.ItemsSource = RrRLsyKHGHW;
		base.Loaded += MKjLswq74Rt;
		object obj;
		if (currentVariables == null)
		{
			obj = null;
		}
		else
		{
			obj = currentVariables.Select(_003C_003Ec.BjYSOBrIXi4 ?? (_003C_003Ec.BjYSOBrIXi4 = _003C_003Ec.SVoSOpamjTJ.xTtSO6TxpcV)).Distinct().Where(_003C_003Ec.O8PSOQFSx4J ?? (_003C_003Ec.O8PSOQFSx4J = _003C_003Ec.SVoSOpamjTJ.CKMSOX6r2Ek))
				.OrderBy(_003C_003Ec.REZSOj437A8 ?? (_003C_003Ec.REZSOj437A8 = _003C_003Ec.SVoSOpamjTJ.e98SOmX7fY1))
				.ToList();
			if (obj != null)
			{
				goto IL_00d9;
			}
		}
		obj = new List<string>();
		goto IL_00d9;
		IL_00d9:
		List<string> list = (List<string>)obj;
		CbGroup.ItemsSource = new ObservableCollection<string>(list);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void MKjLswq74Rt(object sender, RoutedEventArgs e)
	{
		if (loTLsEQ3DK8)
		{
			PnlEnableSaveValue.Visibility = Visibility.Collapsed;
			PnlSubProgramOptions.Visibility = Visibility.Visible;
			int num2 = default(int);
			while (true)
			{
				int num;
				if (EditingVariable != null)
				{
					num = 1;
					if (!AVER1EFan8s4Y2SY1yGF())
					{
						goto IL_0025;
					}
					goto IL_0029;
				}
				goto IL_0061;
				IL_0029:
				switch (num)
				{
				case 1:
					break;
				case 4:
					continue;
				case 3:
					goto end_IL_008b;
				default:
					goto IL_00c7;
				case 2:
					goto IL_00ee;
				}
				if (!EditingVariable.IsInput && !EditingVariable.IsOutput)
				{
					goto IL_0061;
				}
				LblHintForSubprogram.Visibility = Visibility.Visible;
				goto IL_00c7;
				IL_0061:
				LblHintForSubprogram.Visibility = Visibility.Collapsed;
				num = 0;
				if (!AVER1EFan8s4Y2SY1yGF())
				{
					goto IL_0025;
				}
				goto IL_0029;
				IL_0025:
				num = num2;
				goto IL_0029;
				continue;
				end_IL_008b:
				break;
			}
		}
		PnlEnableSaveValue.Visibility = Visibility.Visible;
		PnlSubProgramOptions.Visibility = Visibility.Collapsed;
		LblHintForSubprogram.Visibility = Visibility.Collapsed;
		goto IL_00c7;
		IL_00c7:
		kDaLstSrMYb();
		if (EditingVariable != null)
		{
			TxtDesc.Text = EditingVariable.Desc;
			goto IL_00ee;
		}
		if (PresetVarType.HasValue)
		{
			CbType.SelectedItem = RrRLsyKHGHW.FirstOrDefault(FU7LsPFWW9o);
			if (CbType.SelectedItem == null)
			{
				CbType.SelectedItem = RrRLsyKHGHW.FirstOrDefault(_003C_003Ec.NaeSOndO9W6 ?? (_003C_003Ec.NaeSOndO9W6 = _003C_003Ec.SVoSOpamjTJ.bRZSOKrsjiZ));
			}
		}
		else
		{
			CbType.SelectedIndex = 0;
		}
		ChkEnableSaveValue.IsChecked = false;
		goto IL_02c9;
		IL_00ee:
		TxtKey.Text = EditingVariable.Key;
		TxtDefaultValue.Text = EditingVariable.DefaultValue;
		CbType.SelectedItem = RrRLsyKHGHW.FirstOrDefault(AvuLsCOhZnY);
		ChkEnableSaveValue.IsChecked = EditingVariable.SaveState;
		ChkAsInput.IsChecked = EditingVariable.IsInput;
		ChkAsOutput.IsChecked = EditingVariable.IsOutput;
		TxtParamName.Text = EditingVariable.ParamName;
		CbGroup.Text = EditingVariable.Group;
		if (ChkAsInput.IsChecked == true)
		{
			ChkAsInput.Visibility = Visibility.Visible;
		}
		if (ChkAsOutput.IsChecked == true)
		{
			ChkAsOutput.Visibility = Visibility.Visible;
		}
		if (ChkEnableSaveValue.IsChecked == true)
		{
			PnlEnableSaveValue.Visibility = Visibility.Visible;
		}
		Result = AppHelper.Clone(EditingVariable);
		goto IL_02c9;
		IL_02c9:
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
		if (EditingVariable == null && !string.IsNullOrEmpty(TxtKey.Text))
		{
			TxtKey.SelectAll();
		}
	}

	private void kDaLstSrMYb()
	{
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Text,
			Name = "文本",
			Description = "文本字符串"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Image,
			Name = "图片",
			Description = "图片内容"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Boolean,
			Name = "布尔",
			Description = "布尔（True/False）类型"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Number,
			Name = "数字",
			Description = "数字类型(小数数字)"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Integer,
			Name = "数字(整数)",
			Description = "数字类型(整数数字)"
		});
		if (!AVER1EFan8s4Y2SY1yGF())
		{
			switch (0)
			{
			}
		}
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.DateTime,
			Name = "日期时间",
			Description = "日期和时间类型"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.List,
			Name = "列表",
			Description = "文本列表，如选中的多个文件等"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Dict,
			Name = "词典",
			Description = "键-值对类型"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Table,
			Name = "表格",
			Description = "二维数据表(DataTable)"
		});
		RrRLsyKHGHW.Add(new VarTypeItem
		{
			VarType = VarType.Any,
			Name = "动态对象",
			Description = "任意的C#对象"
		});
	}

	[AsyncStateMachine(typeof(_003CBtnSave_OnClick_003Ed__26))]
	private void GoqLsgGpjbd(object sender, RoutedEventArgs e)
	{
		_003CBtnSave_OnClick_003Ed__26 stateMachine = default(_003CBtnSave_OnClick_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public static bool IsValidVarKey(string txtKeyText)
	{
		if (!string.IsNullOrEmpty(txtKeyText) && !txtKeyText.Contains("{") && !txtKeyText.Contains("}") && !txtKeyText.Contains(".") && !txtKeyText.Contains(" "))
		{
			if (UecHBhFaAEO598MmoeUB != null)
			{
				switch (0)
				{
				}
			}
			if (txtKeyText != "quicker_in_param")
			{
				if (VariableHelper.IsValidVarName(txtKeyText))
				{
					return true;
				}
				return txtKeyText == "params";
			}
		}
		return false;
	}

	private bool DE1LsL32It1(TextBox textBox_0)
	{
		if (string.IsNullOrEmpty(textBox_0.Text))
		{
			textBox_0.Focus();
			return false;
		}
		return true;
	}

	private void KddLsvkbgZX(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtDefaultValue);
	}

	private void GUOLsSKV2SM(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtDefaultValue);
	}

	private void cVtLs2d1h9h(object sender, RoutedEventArgs e)
	{
		VarTypeItem varTypeItem = CbType.SelectedItem as VarTypeItem;
		InputParamSettingsWindow inputParamSettingsWindow = new InputParamSettingsWindow(Result.InputParamInfo, CurrentVariables.Where(_003C_003Ec.FkhSO49avwP ?? (_003C_003Ec.FkhSO49avwP = _003C_003Ec.SVoSOpamjTJ.FmRSOx4ji3o)).ToList(), varTypeItem);
		inputParamSettingsWindow.Owner = this;
		if (inputParamSettingsWindow.ShowDialog() == true)
		{
			Result.InputParamInfo = inputParamSettingsWindow.InputParamInfo;
		}
	}

	private void i0TLsu4oHGZ(object sender, RoutedEventArgs e)
	{
		OutputParamSettingsWindow outputParamSettingsWindow = new OutputParamSettingsWindow(Result.OutputParamInfo, CurrentVariables.Where(_003C_003Ec.EV0SO5i2wmy ?? (_003C_003Ec.EV0SO5i2wmy = _003C_003Ec.SVoSOpamjTJ.nNnSOrA9uLM)).ToList());
		outputParamSettingsWindow.Owner = this;
		if (outputParamSettingsWindow.ShowDialog() == true)
		{
			Result.OutputParamInfo = outputParamSettingsWindow.OutputParamInfo;
		}
	}

	private void XIcLsNKnONj(object sender, SelectionChangedEventArgs e)
	{
		if (CbType.SelectedItem is VarTypeItem varTypeItem)
		{
			ChkEnableSaveValue.IsEnabled = !varTypeItem.VarType.IsEither(VarType.Image, VarType.Any, VarType.Object);
			PnlEditTableDef.Visibility = (varTypeItem.VarType == VarType.Table).ToVisibility();
		}
	}

	[AsyncStateMachine(typeof(_003CBtnEditTableDef_Click_003Ed__34))]
	private void NbDLsJPx3yY(object sender, RoutedEventArgs e)
	{
		_003CBtnEditTableDef_Click_003Ed__34 stateMachine = default(_003CBtnEditTableDef_Click_003Ed__34);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void EQVLs0qQwAH(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.F2)
		{
			e.Handled = true;
			AppHelper.EditInCodeEditor(TxtDefaultValue);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HpPLscro4MC)
		{
			HpPLscro4MC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/variableeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 2;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 20:
				PnlGroup = (StackPanel)target;
				num2 = 3;
				if (UecHBhFaAEO598MmoeUB == null)
				{
					goto IL_0026;
				}
				goto IL_026b;
			case 5:
				MenuEditInEditor1 = (MenuItem)target;
				num2 = 0;
				if (AVER1EFan8s4Y2SY1yGF())
				{
					goto IL_0026;
				}
				goto IL_0253;
			default:
				num2 = 1;
				if (UecHBhFaAEO598MmoeUB != null)
				{
					num2 = num;
				}
				goto IL_0026;
			case 1:
				TxtKey = (TextBox)target;
				return;
			case 2:
				LblHintForSubprogram = (TextBlock)target;
				return;
			case 3:
				CbType = (ComboBox)target;
				CbType.SelectionChanged += XIcLsNKnONj;
				return;
			case 4:
				TxtDefaultValue = (TextBox)target;
				TxtDefaultValue.PreviewKeyDown += EQVLs0qQwAH;
				return;
			case 6:
				BtnEditInCode = (Button)target;
				BtnEditInCode.Click += GUOLsSKV2SM;
				return;
			case 7:
				TxtDesc = (TextBox)target;
				return;
			case 8:
				PnlEditTableDef = (StackPanel)target;
				return;
			case 9:
				BtnEditTableDef = (Button)target;
				BtnEditTableDef.Click += NbDLsJPx3yY;
				return;
			case 10:
				PnlEnableSaveValue = (StackPanel)target;
				return;
			case 11:
				ChkEnableSaveValue = (CheckBox)target;
				return;
			case 12:
				PnlSubProgramOptions = (StackPanel)target;
				return;
			case 13:
				ChkAsInput = (CheckBox)target;
				return;
			case 14:
				BtnInputParamOptions = (Button)target;
				BtnInputParamOptions.Click += cVtLs2d1h9h;
				return;
			case 15:
				ChkAsOutput = (CheckBox)target;
				return;
			case 16:
				BtnOutputParamOptions = (Button)target;
				BtnOutputParamOptions.Click += i0TLsu4oHGZ;
				return;
			case 17:
				PnlParamName = (StackPanel)target;
				return;
			case 18:
				TxtParamName = (TextBox)target;
				return;
			case 19:
				LblGroup = (TextBlock)target;
				return;
			case 21:
				CbGroup = (ComboBox)target;
				return;
			case 22:
				BtnSave = (Button)target;
				BtnSave.Click += GoqLsgGpjbd;
				return;
			case 23:
				{
					BtnCancel = (Button)target;
					return;
				}
				IL_026b:
				HpPLscro4MC = true;
				return;
				IL_0026:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_0253;
				case 1:
					goto IL_026b;
				case 3:
					return;
				}
				break;
				IL_0253:
				MenuEditInEditor1.Click += KddLsvkbgZX;
				return;
			}
		}
	}

	[CompilerGenerated]
	private bool AvuLsCOhZnY(VarTypeItem varTypeItem_0)
	{
		return varTypeItem_0.VarType == EditingVariable.Type;
	}

	[CompilerGenerated]
	private bool FU7LsPFWW9o(VarTypeItem varTypeItem_0)
	{
		return varTypeItem_0.VarType == PresetVarType;
	}

	internal static bool AVER1EFan8s4Y2SY1yGF()
	{
		return UecHBhFaAEO598MmoeUB == null;
	}
}
