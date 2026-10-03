using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Services;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View.UI;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class DrawStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep XZ6SRa7eD7k;

		public ActionExecuteContext fdBSR7qLXpX;

		public XAction DujSRRfwhhv;

		internal static _003C_003Ec__DisplayClass41_0 IXhcaVWklOnx8qlYhoTn;

		internal (bool isSuccess, string message, ActionStopFlag failReason) N26SR8aTAws()
		{
			_003C_003Ec__DisplayClass41_1 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_1
			{
				rDOSRVQtnO1 = this,
				fxYSRcXDfrQ = null
			};
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass41_.kaFSRqdmhlD);
			if (_003C_003Ec__DisplayClass41_.fxYSRcXDfrQ == null)
			{
				return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
			}
			XActionHelper.OutputResult(goKg89lpamd, XZ6SRa7eD7k, fdBSR7qLXpX, _003C_003Ec__DisplayClass41_.fxYSRcXDfrQ, DujSRRfwhhv);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass41_0()
		{
		}

		internal static bool nLqvV4WkZL6IBQhtPmQs()
		{
			return IXhcaVWklOnx8qlYhoTn == null;
		}

		internal static void oJyVxoWkYHXjG8pCsqpE()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_1
	{
		public Bitmap fxYSRcXDfrQ;

		public _003C_003Ec__DisplayClass41_0 rDOSRVQtnO1;

		private static _003C_003Ec__DisplayClass41_1 Lid3LAWk8wb8FUD3vevk;

		internal void kaFSRqdmhlD()
		{
			WhiteboardWindow whiteboardWindow = new WhiteboardWindow(XActionHelper.GetBooleanParamValue(cRpg8qQBmjy, rDOSRVQtnO1.XZ6SRa7eD7k, rDOSRVQtnO1.fdBSR7qLXpX), XActionHelper.GetBooleanParamValue(JFQg8cW0RKG, rDOSRVQtnO1.XZ6SRa7eD7k, rDOSRVQtnO1.fdBSR7qLXpX))
			{
				WindowPosition = XActionHelper.GetTextParamValue(BwUg8aQvgXE, rDOSRVQtnO1.XZ6SRa7eD7k, rDOSRVQtnO1.fdBSR7qLXpX),
				BgColor = XActionHelper.GetTextParamValue(apLg87MKvbQ, rDOSRVQtnO1.XZ6SRa7eD7k, rDOSRVQtnO1.fdBSR7qLXpX),
				StrokeColor = XActionHelper.GetTextParamValue(CFOg8RHGxCw, rDOSRVQtnO1.XZ6SRa7eD7k, rDOSRVQtnO1.fdBSR7qLXpX)
			};
			AppWindowManager.ShowWindowAndWaitClose(whiteboardWindow, true);
			if (whiteboardWindow.IsSuccess)
			{
				fxYSRcXDfrQ = whiteboardWindow.ResultBitmap;
			}
		}

		internal static bool FnO5vIWkRNjYUvQoogcB()
		{
			return Lid3LAWk8wb8FUD3vevk == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> DTxg8Cb02lY = new List<string> { "绘图板" };

	[CompilerGenerated]
	private readonly string yCRg8P64dU3 = $"fa:{EFontAwesomeIcon.Light_Pencil}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> EZMg8Emc8BE;

	[CompilerGenerated]
	private readonly string PLLg8yyGXBU = "https://getquicker.net/KC/Help/Doc/whiteboard";

	private static readonly StepInParamDef T8Qg88DaZnf;

	private static readonly StepInParamDef BwUg8aQvgXE;

	private static readonly StepInParamDef apLg87MKvbQ;

	private static readonly StepInParamDef CFOg8RHGxCw;

	private static readonly StepInParamDef cRpg8qQBmjy;

	private static readonly StepInParamDef JFQg8cW0RKG;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Xe5g8VZ0s91 = new List<StepInParamDef> { BwUg8aQvgXE, apLg87MKvbQ, CFOg8RHGxCw, cRpg8qQBmjy, JFQg8cW0RKG, T8Qg88DaZnf };

	private static readonly StepOutParamDef S2Og8ZZyYyh;

	private static readonly StepOutParamDef goKg89lpamd;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> HiUg8h73R10 = new List<StepOutParamDef> { S2Og8ZZyYyh, goKg89lpamd };

	internal static DrawStep ho8IDRQIXx3b5AOpvqBr;

	public string Key => "sys:whiteboard";

	public string Name => "手写板";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return DTxg8Cb02lY;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return yCRg8P64dU3;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return EZMg8Emc8BE;
		}
	}

	public string Description => "手写内容，生成图片对象。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return PLLg8yyGXBU;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Xe5g8VZ0s91;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return HiUg8h73R10;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.XZ6SRa7eD7k = step;
		_003C_003Ec__DisplayClass41_.fdBSR7qLXpX = context;
		_003C_003Ec__DisplayClass41_.DujSRRfwhhv = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.fdBSR7qLXpX, _003C_003Ec__DisplayClass41_.XZ6SRa7eD7k, _003C_003Ec__DisplayClass41_.DujSRRfwhhv, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.N26SR8aTAws, (Action)null, (Action)null, T8Qg88DaZnf, S2Og8ZZyYyh);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static DrawStep()
	{
		T8Qg88DaZnf = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "取消后停止动作",
			DefaultValue = true,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		BwUg8aQvgXE = new StepInParamDef
		{
			Key = "winPosition",
			Name = "窗口位置",
			Description = "可选。指定显示位置，格式为：left,top,right,bottom。支持像素数值或屏幕宽高百分比。",
			DefaultValue = "15%,30%,85%,70%",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		apLg87MKvbQ = new StepInParamDef
		{
			Key = "bgColor",
			Name = "绘图区背景颜色",
			Description = "绘图窗口的背景颜色。格式为#AARRGGBB",
			DefaultValue = "#FFFFFFFF",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		CFOg8RHGxCw = new StepInParamDef
		{
			Key = "penColor",
			Name = "画笔颜色",
			Description = "画笔颜色。格式为#AARRGGBB",
			DefaultValue = "#FFFF0000",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		cRpg8qQBmjy = new StepInParamDef
		{
			Key = "enableTransparent",
			Name = "使用透明无边框窗口",
			Description = "不显示窗口标题栏，绘图区透明，可以看到底层窗口内容。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		JFQg8cW0RKG = new StepInParamDef
		{
			Key = "imageWithBackground",
			Name = "图片包含背景内容",
			Description = "使用透明窗口时，结果图片是否包含背景内容。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		S2Og8ZZyYyh = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		goKg89lpamd = new StepOutParamDef
		{
			Key = "result",
			Name = "结果图片",
			Type = VarType.Image
		};
	}

	internal static bool TOYrc7QI2jU27H7HiT4A()
	{
		return ho8IDRQIXx3b5AOpvqBr == null;
	}
}
