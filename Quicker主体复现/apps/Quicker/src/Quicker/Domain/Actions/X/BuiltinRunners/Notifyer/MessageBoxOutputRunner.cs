using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using Quicker.View.UI;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Notifyer;

public class MessageBoxOutputRunner : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public string HmaSSTwvcaF;

		public string UWiSSM7NqPu;

		public IntPtr vJpSSAI2iqm;

		public ActionExecuteContext GUmSSOP7qU7;

		internal static _003C_003Ec__DisplayClass47_0 r5lsexWKceABJfFgh17a;

		internal static void EvQcLUWKpsADQM9idEpO()
		{
		}

		internal static bool KcmBpIWKW3MqDSVIxbw0()
		{
			return r5lsexWKceABJfFgh17a == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct V7SBWmkgoryDX23wBsW : IAsyncStateMachine
		{
			public int bVE2cbcSGPA;

			public AsyncVoidMethodBuilder IZ72c6GmSyQ;

			public _003C_003Ec__DisplayClass47_1 FNK2cXKcmCV;

			internal static object ixM8Aiyb2seulw11BYwj;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = FNK2cXKcmCV;
				try
				{
					_003C_003Ec__DisplayClass47_.zIwSSUUrV5d = MessageBoxHelper.Show(null, _003C_003Ec__DisplayClass47_.BH7SS3NXEWp.HmaSSTwvcaF, _003C_003Ec__DisplayClass47_.BH7SS3NXEWp.UWiSSM7NqPu, _003C_003Ec__DisplayClass47_.cfhSSlI2v1f, _003C_003Ec__DisplayClass47_.JXWSSicfdb0, MessageBoxResult.None);
					if (_003C_003Ec__DisplayClass47_.BH7SS3NXEWp.vJpSSAI2iqm != IntPtr.Zero)
					{
						NativeMethods.SetForegroundWindow(_003C_003Ec__DisplayClass47_.BH7SS3NXEWp.vJpSSAI2iqm);
					}
				}
				catch (Exception exception)
				{
					bVE2cbcSGPA = -2;
					IZ72c6GmSyQ.SetException(exception);
					return;
				}
				bVE2cbcSGPA = -2;
				IZ72c6GmSyQ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IZ72c6GmSyQ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool RZCYINybAR3gqq93mnxF()
			{
				return ixM8Aiyb2seulw11BYwj == null;
			}
		}

		public MessageBoxResult zIwSSUUrV5d;

		public MessageBoxButton cfhSSlI2v1f;

		public MessageBoxImage JXWSSicfdb0;

		public _003C_003Ec__DisplayClass47_0 BH7SS3NXEWp;

		internal static _003C_003Ec__DisplayClass47_1 yj1m4VWKXFlh7EEomxhC;

		[AsyncStateMachine(typeof(V7SBWmkgoryDX23wBsW))]
		internal void Y4RSSFB3FQ1()
		{
			V7SBWmkgoryDX23wBsW stateMachine = default(V7SBWmkgoryDX23wBsW);
			stateMachine.IZ72c6GmSyQ = AsyncVoidMethodBuilder.Create();
			stateMachine.FNK2cXKcmCV = this;
			stateMachine.bVE2cbcSGPA = -1;
			stateMachine.IZ72c6GmSyQ.Start(ref stateMachine);
		}

		internal static bool hqHEPQWK2qUseJThFs4f()
		{
			return yj1m4VWKXFlh7EEomxhC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct YETDBhkV06xRHGh2c3Q : IAsyncStateMachine
		{
			public int XYY2cmCQqrt;

			public AsyncVoidMethodBuilder hfr2cKAZEXZ;

			public _003C_003Ec__DisplayClass47_2 fk02cxbpkJu;

			private TaskAwaiter<(bool isSuccess, string button)> qaJ2crqg0xR;

			internal static object EPPMk5ybe9tqNyFNDV70;

			private void MoveNext()
			{
				int num = XYY2cmCQqrt;
				_003C_003Ec__DisplayClass47_2 _003C_003Ec__DisplayClass47_ = fk02cxbpkJu;
				try
				{
					TaskAwaiter<(bool, string)> awaiter;
					if (num != 0)
					{
						awaiter = ConfirmDialog.jQyL0Wq9wU6(null, _003C_003Ec__DisplayClass47_.iekS2vFEv2K.UWiSSM7NqPu, _003C_003Ec__DisplayClass47_.iekS2vFEv2K.GUmSSOP7qU7.Action?.Icon, _003C_003Ec__DisplayClass47_.iekS2vFEv2K.HmaSSTwvcaF, _003C_003Ec__DisplayClass47_.uKUSSzAbfSA, _003C_003Ec__DisplayClass47_.UZES2wTQIMV, _003C_003Ec__DisplayClass47_.e8gS2tG7RHf, _003C_003Ec__DisplayClass47_.iekS2vFEv2K.GUmSSOP7qU7.CancellationToken).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							XYY2cmCQqrt = 0;
							qaJ2crqg0xR = awaiter;
							hfr2cKAZEXZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (EPPMk5ybe9tqNyFNDV70 == null)
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
						awaiter = qaJ2crqg0xR;
						qaJ2crqg0xR = default(TaskAwaiter<(bool, string)>);
						num = -1;
						XYY2cmCQqrt = -1;
					}
					_003C_003Ec__DisplayClass47_.iYUS2gtIfB0 = awaiter.GetResult().Item2 ?? "";
					_003C_003Ec__DisplayClass47_.XTVS2LseNi8.Set();
				}
				catch (Exception exception)
				{
					XYY2cmCQqrt = -2;
					hfr2cKAZEXZ.SetException(exception);
					return;
				}
				XYY2cmCQqrt = -2;
				hfr2cKAZEXZ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				hfr2cKAZEXZ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool CfnoaGybjTFouLsUDJ5u()
			{
				return EPPMk5ybe9tqNyFNDV70 == null;
			}
		}

		public string uKUSSzAbfSA;

		public string UZES2wTQIMV;

		public string e8gS2tG7RHf;

		public string iYUS2gtIfB0;

		public ManualResetEventSlim XTVS2LseNi8;

		public _003C_003Ec__DisplayClass47_0 iekS2vFEv2K;

		private static _003C_003Ec__DisplayClass47_2 c2U33dWKnMXblDrCPrs5;

		[AsyncStateMachine(typeof(YETDBhkV06xRHGh2c3Q))]
		internal void iifSSfBrJbF()
		{
			YETDBhkV06xRHGh2c3Q stateMachine = default(YETDBhkV06xRHGh2c3Q);
			stateMachine.hfr2cKAZEXZ = AsyncVoidMethodBuilder.Create();
			stateMachine.fk02cxbpkJu = this;
			stateMachine.XYY2cmCQqrt = -1;
			stateMachine.hfr2cKAZEXZ.Start(ref stateMachine);
		}

		internal static bool LqmJyqWKeBvg8DWoI4Tv()
		{
			return c2U33dWKnMXblDrCPrs5 == null;
		}
	}

	public const string KEY = "sys:MsgBox";

	public const string OP_DEFAULT = "default";

	public const string OP_CUSTOM = "custom";

	private static readonly StepInParamDef A8lgvgeM3CR;

	private static readonly StepInParamDef ncIgvLY3SfJ;

	private static readonly StepInParamDef vQCgvvLfmTB;

	private static readonly StepInParamDef itjgvSSObpA;

	private static readonly StepInParamDef OeAgv2gN77q;

	private static readonly StepInParamDef V78gvujsqCr;

	private static readonly StepInParamDef EujgvNm3ZKw;

	private static readonly StepInParamDef MlqgvJ99YA8;

	private static readonly StepInParamDef iIJgv04nldu;

	private static readonly IList<StepInParamDef> cWmgvChOnI3;

	private static readonly StepOutParamDef i69gvP4CBYp;

	private static readonly StepOutParamDef mLLgvEPYuvA;

	private static readonly IList<StepOutParamDef> WBIgvyuyAFE;

	[CompilerGenerated]
	private readonly IEnumerable<string> ycYgv8A9Rwb = new string[1] { "message" };

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> IQMgvaxYQmj = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string UAqgv72iHOF = "https://getquicker.net/KC/Help/Doc/msgbox";

	[CompilerGenerated]
	private readonly bool ecegvRoRGRl;

	private static MessageBoxOutputRunner o0RBrcQgef84wOy9XPMc;

	public string Key => "sys:MsgBox";

	public string Name => "弹窗提示或确认";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return ycYgv8A9Rwb;
		}
	}

	public string Icon => "Steps/msgbox.png";

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return IQMgvaxYQmj;
		}
	}

	public string Description => "弹窗显示提示或确认对话框";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return UAqgv72iHOF;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return ecegvRoRGRl;
		}
	}

	public IList<StepInParamDef> InputParams => cWmgvChOnI3;

	public IList<StepOutParamDef> OutputParams => WBIgvyuyAFE;

	public bool ValidateParam(string paramData, out string message)
	{
		message = "";
		return true;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.GUmSSOP7qU7 = context;
		string textParamValue = XActionHelper.GetTextParamValue(A8lgvgeM3CR, step, _003C_003Ec__DisplayClass47_.GUmSSOP7qU7);
		_003C_003Ec__DisplayClass47_.HmaSSTwvcaF = XActionHelper.GetTextParamValue(ncIgvLY3SfJ, step, _003C_003Ec__DisplayClass47_.GUmSSOP7qU7);
		_003C_003Ec__DisplayClass47_.UWiSSM7NqPu = XActionHelper.GetTextParamValue(vQCgvvLfmTB, step, _003C_003Ec__DisplayClass47_.GUmSSOP7qU7);
		int num = 2;
		if (o0RBrcQgef84wOy9XPMc != null)
		{
			goto IL_00be;
		}
		goto IL_00d9;
		IL_00be:
		int num2 = default(int);
		num = num2;
		goto IL_00d9;
		IL_00d9:
		while (true)
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_2;
			string textParamValue2;
			bool booleanParamValue;
			switch (num)
			{
			case 2:
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.UWiSSM7NqPu))
				{
					num = 0;
					if (muK4qgQgjfBEsxUBintJ())
					{
						continue;
					}
					break;
				}
				goto IL_0081;
			default:
				_003C_003Ec__DisplayClass47_.UWiSSM7NqPu = _003C_003Ec__DisplayClass47_.GUmSSOP7qU7.ActionTitle;
				goto IL_0081;
			case 1:
				{
					if (textParamValue.Length != 0)
					{
						goto IL_00f8;
					}
					goto IL_020d;
				}
				IL_020d:
				_003C_003Ec__DisplayClass47_2 = new _003C_003Ec__DisplayClass47_1();
				_003C_003Ec__DisplayClass47_2.BH7SS3NXEWp = _003C_003Ec__DisplayClass47_;
				textParamValue2 = XActionHelper.GetTextParamValue(OeAgv2gN77q, step, _003C_003Ec__DisplayClass47_2.BH7SS3NXEWp.GUmSSOP7qU7);
				if (!Enum.TryParse<MessageBoxButton>(XActionHelper.GetTextParamValue(V78gvujsqCr, step, _003C_003Ec__DisplayClass47_2.BH7SS3NXEWp.GUmSSOP7qU7), out _003C_003Ec__DisplayClass47_2.cfhSSlI2v1f))
				{
					_003C_003Ec__DisplayClass47_2.cfhSSlI2v1f = MessageBoxButton.OK;
				}
				if (!Enum.TryParse<MessageBoxImage>(textParamValue2, out _003C_003Ec__DisplayClass47_2.JXWSSicfdb0))
				{
					_003C_003Ec__DisplayClass47_2.JXWSSicfdb0 = MessageBoxImage.Asterisk;
				}
				_003C_003Ec__DisplayClass47_2.zIwSSUUrV5d = MessageBoxResult.No;
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_2.Y4RSSFB3FQ1);
				XActionHelper.OutputResult(i69gvP4CBYp, step, _003C_003Ec__DisplayClass47_2.BH7SS3NXEWp.GUmSSOP7qU7, _003C_003Ec__DisplayClass47_2.zIwSSUUrV5d.ToString(), action);
				XActionHelper.OutputResult(mLLgvEPYuvA, step, _003C_003Ec__DisplayClass47_2.BH7SS3NXEWp.GUmSSOP7qU7, _003C_003Ec__DisplayClass47_2.zIwSSUUrV5d == MessageBoxResult.OK || _003C_003Ec__DisplayClass47_2.zIwSSUUrV5d == MessageBoxResult.Yes, action);
				return;
				IL_0081:
				booleanParamValue = XActionHelper.GetBooleanParamValue(iIJgv04nldu, step, _003C_003Ec__DisplayClass47_.GUmSSOP7qU7);
				_003C_003Ec__DisplayClass47_.vJpSSAI2iqm = IntPtr.Zero;
				if (booleanParamValue)
				{
					_003C_003Ec__DisplayClass47_.vJpSSAI2iqm = NativeMethods.GetForegroundWindow();
				}
				if (textParamValue != null)
				{
					num = 1;
					if (o0RBrcQgef84wOy9XPMc == null)
					{
						continue;
					}
					break;
				}
				goto IL_00f8;
				IL_00f8:
				if (!(textParamValue == "default"))
				{
					if (textParamValue == "custom")
					{
						_003C_003Ec__DisplayClass47_2 _003C_003Ec__DisplayClass47_3 = new _003C_003Ec__DisplayClass47_2();
						_003C_003Ec__DisplayClass47_3.iekS2vFEv2K = _003C_003Ec__DisplayClass47_;
						_003C_003Ec__DisplayClass47_3.uKUSSzAbfSA = XActionHelper.GetTextParamValue(itjgvSSObpA, step, _003C_003Ec__DisplayClass47_3.iekS2vFEv2K.GUmSSOP7qU7);
						_003C_003Ec__DisplayClass47_3.UZES2wTQIMV = XActionHelper.GetTextParamValue(EujgvNm3ZKw, step, _003C_003Ec__DisplayClass47_3.iekS2vFEv2K.GUmSSOP7qU7);
						_003C_003Ec__DisplayClass47_3.e8gS2tG7RHf = XActionHelper.GetTextParamValue(MlqgvJ99YA8, step, _003C_003Ec__DisplayClass47_3.iekS2vFEv2K.GUmSSOP7qU7);
						_003C_003Ec__DisplayClass47_3.iYUS2gtIfB0 = null;
						_003C_003Ec__DisplayClass47_3.XTVS2LseNi8 = new ManualResetEventSlim(false);
						AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_3.iifSSfBrJbF);
						_003C_003Ec__DisplayClass47_3.XTVS2LseNi8.Wait();
						if (_003C_003Ec__DisplayClass47_3.iekS2vFEv2K.vJpSSAI2iqm != IntPtr.Zero)
						{
							NativeMethods.SetForegroundWindow(_003C_003Ec__DisplayClass47_3.iekS2vFEv2K.vJpSSAI2iqm);
						}
						XActionHelper.OutputResult(i69gvP4CBYp, step, _003C_003Ec__DisplayClass47_3.iekS2vFEv2K.GUmSSOP7qU7, _003C_003Ec__DisplayClass47_3.iYUS2gtIfB0.Or(""), action);
					}
					return;
				}
				goto IL_020d;
			}
			break;
		}
		goto IL_00be;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ncIgvLY3SfJ, step) ?? "";
	}

	static MessageBoxOutputRunner()
	{
		A8lgvgeM3CR = new StepInParamDef
		{
			Key = "operation",
			Name = "模式",
			Description = "",
			DefaultValue = "default",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("default", "标准"),
				new SelectionItem("custom", "自定义")
			},
			IsControlField = true
		};
		ncIgvLY3SfJ = new StepInParamDef
		{
			Key = "message",
			Name = "消息内容",
			Description = "弹窗显示的消息内容。“自定义”模式时，也支持“MD:Markdown内容”。",
			DefaultValue = "Hello.",
			Type = VarType.Text,
			IsMultiLine = true,
			IsRequired = true
		};
		vQCgvvLfmTB = new StepInParamDef
		{
			Key = "title",
			Name = "标题",
			Description = "消息窗口标题。留空时自动使用动作名称。",
			DefaultValue = "Quicker",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input
		};
		itjgvSSObpA = new StepInParamDef
		{
			Key = "customIcon",
			Name = "图标",
			Description = "消息窗口图标。",
			DefaultValue = "Information",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("", "无"),
				new SelectionItem("Information", "信息"),
				new SelectionItem("Question", "疑问"),
				new SelectionItem("Warning", "警告"),
				new SelectionItem("Error", "错误")
			},
			ValidForList = new string[1] { "custom" }
		};
		OeAgv2gN77q = new StepInParamDef
		{
			Key = "icon",
			Name = "图标",
			Description = "消息窗口图标",
			DefaultValue = MessageBoxImage.Asterisk.ToString(),
			Type = VarType.Enum,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(MessageBoxImage.None.ToString(), "无"),
				new SelectionItem(MessageBoxImage.Asterisk.ToString(), "信息"),
				new SelectionItem(MessageBoxImage.Question.ToString(), "疑问"),
				new SelectionItem(MessageBoxImage.Exclamation.ToString(), "警告"),
				new SelectionItem(MessageBoxImage.Hand.ToString(), "错误")
			},
			ValidForList = new string[1] { "default" }
		};
		V78gvujsqCr = new StepInParamDef
		{
			Key = "buttons",
			Name = "按钮",
			Description = "消息窗口图标",
			DefaultValue = "OK",
			Type = VarType.Enum,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(MessageBoxButton.OK.ToString(), "确定"),
				new SelectionItem(MessageBoxButton.OKCancel.ToString(), "确定/取消"),
				new SelectionItem(MessageBoxButton.YesNo.ToString(), "是/否")
			},
			ValidForList = new string[1] { "default" }
		};
		EujgvNm3ZKw = new StepInParamDef
		{
			Key = "customButtons",
			Name = "按钮",
			Description = "每行定义一个按钮，格式为 “文本” 或 “[图标]显示文本(提示内容)|值”。",
			DefaultValue = "[fa:Regular_Check:#4caf50]是(_Y)|Yes\r\n[fa:Regular_Times:#dc3545]否(_N)|No\r\n[fa:Light_Undo:#444444]取消(_C)|Cancel",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			ValidForList = new string[1] { "custom" }
		};
		MlqgvJ99YA8 = new StepInParamDef
		{
			Key = "defaultButton",
			Name = "默认按钮",
			Description = "指定默认按钮的值。默认按钮以高亮颜色显示，可直接回车选择。",
			DefaultValue = "Yes",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			ValidForList = new string[1] { "custom" }
		};
		iIJgv04nldu = new StepInParamDef
		{
			Key = "restoreFocus",
			Name = "恢复活动窗口",
			Description = "关闭弹窗后，是否将焦点还原到之前的活动窗口",
			DefaultValue = true,
			Type = VarType.Boolean,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		cWmgvChOnI3 = new StepInParamDef[9] { A8lgvgeM3CR, ncIgvLY3SfJ, vQCgvvLfmTB, OeAgv2gN77q, itjgvSSObpA, V78gvujsqCr, EujgvNm3ZKw, MlqgvJ99YA8, iIJgv04nldu };
		i69gvP4CBYp = new StepOutParamDef
		{
			Key = "result",
			Name = "选择的按钮",
			Description = "点击的按钮，标准模式下结果可能为OK,Cancel,Yes,No，自定义模式下为按钮的值。",
			Type = VarType.Text
		};
		mLLgvEPYuvA = new StepOutParamDef
		{
			Key = "okOrYes",
			Name = "是否确认",
			Description = "选择的按钮是否为“确定”或“是”",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "default" }
		};
		WBIgvyuyAFE = new StepOutParamDef[2] { i69gvP4CBYp, mLLgvEPYuvA };
	}

	internal static bool muK4qgQgjfBEsxUBintJ()
	{
		return o0RBrcQgef84wOy9XPMc == null;
	}
}
