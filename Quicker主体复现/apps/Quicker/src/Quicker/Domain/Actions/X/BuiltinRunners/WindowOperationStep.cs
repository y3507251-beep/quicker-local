using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows;
using AutoIt;
using FontAwesome5;
using HandyControl.Tools;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class WindowOperationStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public ActionStep g75vfm8w66p;

		public ActionExecuteContext yOivfKwHtKg;

		public XAction DwKvfxtrRM2;

		private static _003C_003Ec__DisplayClass59_0 t5xAuiW3GVUm9sA5q0sC;

		internal (bool isSuccess, string message, ActionStopFlag failReason) NX7vfX8SCCZ()
		{
			_003C_003Ec__DisplayClass59_1 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_1();
			string textParamValue = XActionHelper.GetTextParamValue(xjdtOew45Cd, g75vfm8w66p, yOivfKwHtKg);
			_003C_003Ec__DisplayClass59_.YUXvfpd4JRm = (IntPtr)XActionHelper.GetIntegerParamValue(iqetOYvJijp, g75vfm8w66p, yOivfKwHtKg);
			if (_003C_003Ec__DisplayClass59_.YUXvfpd4JRm == IntPtr.Zero)
			{
				_003C_003Ec__DisplayClass59_.YUXvfpd4JRm = NativeMethods.GetForegroundWindow();
			}
			if (!NativeMethods.IsWindow(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm))
			{
				return (isSuccess: false, message: "窗口不存在", failReason: ActionStopFlag.OperationFailed);
			}
			if (NativeMethods.IsOnDesktop(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm))
			{
				return (isSuccess: false, message: "不支持对桌面窗口操作", failReason: ActionStopFlag.OperationFailed);
			}
			switch (textParamValue)
			{
			case "show":
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(hfGtO1l1Fdc, g75vfm8w66p, yOivfKwHtKg);
				if (string.Equals(textParamValue4, "TOGGLE_MAXMIZE"))
				{
					Quicker.Utilities.Win32.WindowHelper.MaximizeOrRestoreWindow(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				}
				else
				{
					int num7 = Convert.ToInt32(textParamValue4, CultureInfo.InvariantCulture);
					NativeMethods.ShowWindow(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, num7);
					if (num7 > 0)
					{
						AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass59_.MDcvfrUQl9c);
					}
				}
				goto IL_05ea;
			}
			case "move":
			{
				int num3 = Convert.ToInt32(XActionHelper.GetIntegerParamValue(t5WtOIcbKhq, g75vfm8w66p, yOivfKwHtKg));
				int num4 = Convert.ToInt32(XActionHelper.GetIntegerParamValue(fkLtOWHwxSr, g75vfm8w66p, yOivfKwHtKg));
				int num5 = Convert.ToInt32(XActionHelper.GetIntegerParamValue(WnvtOk2qPU8, g75vfm8w66p, yOivfKwHtKg));
				int num6 = Convert.ToInt32(XActionHelper.GetIntegerParamValue(XPHtOGjfUnn, g75vfm8w66p, yOivfKwHtKg));
				Quicker.Utilities.Win32.WindowHelper.RestoreWindowIfMaxmized(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				try
				{
					Thickness windowInvisibleWidth = NativeMethods.GetWindowInvisibleWidth(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
					num3 += (int)windowInvisibleWidth.Left;
					num4 += (int)windowInvisibleWidth.Top;
					if (num5 >= 0 && num6 >= 0)
					{
						num5 += (int)(windowInvisibleWidth.Right - windowInvisibleWidth.Left);
						num6 += (int)(windowInvisibleWidth.Bottom - windowInvisibleWidth.Top);
						NativeMethods.MoveWindow(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, num3, num4, num5, num6, true);
					}
					else
					{
						IHNRIiikxBwJdYmHpM3.oc0vvlUGaGr(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, num3, num4, false);
					}
				}
				catch (Exception ex5)
				{
					return (isSuccess: false, message: "移动窗口失败！" + ex5.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_05ea;
			}
			case "kill":
				try
				{
					AutoItX.WinKill(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				}
				catch (Exception ex4)
				{
					return (isSuccess: false, message: ex4.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_05ea;
			case "close":
				AutoItX.WinClose(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				goto IL_05ea;
			case "move_ex":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(yUStOsuy6tt, g75vfm8w66p, yOivfKwHtKg);
				NativeMethods.GetWindowInvisibleWidth(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				IHNRIiikxBwJdYmHpM3.SY9vvfU8LQC(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, textParamValue3);
				goto IL_05ea;
			}
			case "set_trans":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(BqStOHUjVRa, g75vfm8w66p, yOivfKwHtKg);
				int num = 255;
				if (!textParamValue2.StartsWith("+") && !textParamValue2.StartsWith("-"))
				{
					num = Convert.ToInt32(textParamValue2);
				}
				else
				{
					int num2 = Convert.ToInt32(textParamValue2);
					num = Quicker.Utilities.Win32.WindowHelper.LLXLF6Ttuxf(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm) + num2;
				}
				if (num < 0)
				{
					num = 0;
				}
				else if (num > 255)
				{
					num = 255;
				}
				AutoItX.WinSetTrans(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, num);
				goto IL_05ea;
			}
			case "setBottom":
			{
				bool flag3 = Quicker.Utilities.Win32.WindowHelper.hMNLFGcwaHv(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				XActionHelper.OutputResult(xj9tOXJ5rcQ, g75vfm8w66p, yOivfKwHtKg, flag3, DwKvfxtrRM2);
				goto IL_05ea;
			}
			case "setTopmost":
				try
				{
					bool flag2 = NativeMethods.SetWindowPos(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
					XActionHelper.OutputResult(xj9tOXJ5rcQ, g75vfm8w66p, yOivfKwHtKg, flag2, DwKvfxtrRM2);
				}
				catch (Exception ex3)
				{
					return (isSuccess: false, message: "设置窗口置顶失败！" + ex3.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_05ea;
			case "toggleTopMost":
				try
				{
					(bool, bool) tuple = Quicker.Utilities.Win32.WindowHelper.ToggleTopmost(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
					XActionHelper.OutputResult(xj9tOXJ5rcQ, g75vfm8w66p, yOivfKwHtKg, tuple.Item1, DwKvfxtrRM2);
					XActionHelper.OutputResult(idTtOmYSI34, g75vfm8w66p, yOivfKwHtKg, tuple.Item2, DwKvfxtrRM2);
				}
				catch (Exception ex2)
				{
					return (isSuccess: false, message: "设置/取消窗口置顶失败！" + ex2.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_05ea;
			case "removeTopmost":
				try
				{
					bool flag = Quicker.Utilities.Win32.WindowHelper.RemoveTopmost(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
					XActionHelper.OutputResult(xj9tOXJ5rcQ, g75vfm8w66p, yOivfKwHtKg, flag, DwKvfxtrRM2);
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: "取消窗口置顶失败！" + ex.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_05ea;
			case "SET_FOREGROUND":
				NativeMethods.BringProcessMainWindowToFront(_003C_003Ec__DisplayClass59_.YUXvfpd4JRm);
				goto IL_05ea;
			default:
				{
					return (isSuccess: false, message: "不支持的窗口操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_05ea:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool sUdAROW30puSN763YEUF()
		{
			return t5xAuiW3GVUm9sA5q0sC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_1
	{
		public IntPtr YUXvfpd4JRm;

		private static _003C_003Ec__DisplayClass59_1 BVCqm5W3K5yQeWf6ftJr;

		internal void MDcvfrUQl9c()
		{
			foreach (Window window in Application.Current.Windows)
			{
				if (window.GetHandle() == YUXvfpd4JRm && !window.IsVisible)
				{
					window.Show();
				}
			}
		}

		internal static void AJV54WW3dYX9uHFZ9s4U()
		{
		}

		internal static bool bKMRhlW3Buk7Y9RZ74PN()
		{
			return BVCqm5W3K5yQeWf6ftJr == null;
		}
	}

	private static List<string> LfMtOc9ieX3;

	[CompilerGenerated]
	private readonly string iphtOVHu8FJ = $"fa:{EFontAwesomeIcon.Light_Window}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> aGstOZI3PLy;

	[CompilerGenerated]
	private readonly string LSEtO9CI6m3 = "https://getquicker.net/KC/Help/Doc/windowoperations";

	[CompilerGenerated]
	private readonly bool iXttOhe9Wi1;

	private static readonly StepInParamDef xjdtOew45Cd;

	private static readonly StepInParamDef iqetOYvJijp;

	private static readonly StepInParamDef t5WtOIcbKhq;

	private static readonly StepInParamDef fkLtOWHwxSr;

	private static readonly StepInParamDef WnvtOk2qPU8;

	private static readonly StepInParamDef XPHtOGjfUnn;

	private static readonly StepInParamDef yUStOsuy6tt;

	private static readonly StepInParamDef BqStOHUjVRa;

	private static readonly StepInParamDef hfGtO1l1Fdc;

	private static readonly StepInParamDef coItObsMHYy;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> cS1tO6QwXr5 = new StepInParamDef[10] { xjdtOew45Cd, iqetOYvJijp, t5WtOIcbKhq, fkLtOWHwxSr, WnvtOk2qPU8, XPHtOGjfUnn, yUStOsuy6tt, hfGtO1l1Fdc, BqStOHUjVRa, coItObsMHYy };

	private static readonly StepOutParamDef xj9tOXJ5rcQ;

	private static readonly StepOutParamDef idTtOmYSI34;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> B15tOKQugbJ = new StepOutParamDef[2] { xj9tOXJ5rcQ, idTtOmYSI34 };

	private static WindowOperationStep qJYnxRQlx4jLrx2YeTfl;

	public string Key => "sys:windowOperations";

	public string Name => "窗口操作";

	public IEnumerable<string> KeyWords => LfMtOc9ieX3;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return iphtOVHu8FJ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return aGstOZI3PLy;
		}
	}

	public string Description => "Window窗口相关操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return LSEtO9CI6m3;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return iXttOhe9Wi1;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return cS1tO6QwXr5;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return B15tOKQugbJ;
		}
	}

	static WindowOperationStep()
	{
		LfMtOc9ieX3 = new List<string>();
		xjdtOew45Cd = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "move",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("move", "移动窗口"),
				new SelectionItem("move_ex", "移动窗口(增强)"),
				new SelectionItem("setTopmost", "置顶窗口"),
				new SelectionItem("toggleTopMost", "切换置顶状态"),
				new SelectionItem("removeTopmost", "取消置顶窗口"),
				new SelectionItem("setBottom", "置底窗口"),
				new SelectionItem("show", "设置显示状态"),
				new SelectionItem("SET_FOREGROUND", "设置为前台窗口"),
				new SelectionItem("close", "关闭"),
				new SelectionItem("kill", "强制关闭"),
				new SelectionItem("set_trans", "设置或更新透明度")
			},
			IsControlField = true
		};
		iqetOYvJijp = new StepInParamDef
		{
			Key = "hWnd",
			Name = "窗口句柄",
			Description = "要操作的窗口句柄（数字）。0或留空表示操作前台窗口。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer
		};
		t5WtOIcbKhq = new StepInParamDef
		{
			Key = "x",
			Name = "X坐标",
			Description = "窗口左上角X坐标",
			DefaultValue = 100,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[1] { "move" }
		};
		fkLtOWHwxSr = new StepInParamDef
		{
			Key = "y",
			Name = "Y坐标",
			Description = "窗口左上角Y坐标",
			DefaultValue = 100,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[1] { "move" }
		};
		WnvtOk2qPU8 = new StepInParamDef
		{
			Key = "width",
			Name = "宽度",
			Description = "窗口宽度。-1时表示不更改窗口尺寸。",
			DefaultValue = 500,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[1] { "move" }
		};
		XPHtOGjfUnn = new StepInParamDef
		{
			Key = "height",
			Name = "高度",
			Description = "窗口高度。-1时表示不更改窗口尺寸。",
			DefaultValue = 500,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[1] { "move" }
		};
		yUStOsuy6tt = new StepInParamDef
		{
			Key = "area",
			Name = "目标位置",
			Description = "窗口左,上,右,下的位置坐标",
			DefaultValue = "25%,25%,75%,75%",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "move_ex" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		BqStOHUjVRa = new StepInParamDef
		{
			Key = "alpha",
			Name = "不透明度Alpha",
			Description = "数字0-255：0为全透明，255为不透明。-数字：将当前透明度增加一些。+数字：将透明度减少一些。",
			DefaultValue = "128",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "set_trans" }
		};
		hfGtO1l1Fdc = new StepInParamDef
		{
			Key = "showCmd",
			Name = "显示状态",
			Description = "窗口显示状态，具体说明请参考Win32接口。",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "3",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("3", "最大化(SW_MAXIMIZE)"),
				new SelectionItem("6", "最小化(SW_MINIMIZE)"),
				new SelectionItem("9", "显示并恢复大小(SW_RESTORE)"),
				new SelectionItem("0", "隐藏(SW_HIDE)"),
				new SelectionItem("5", "显示(SW_SHOW)"),
				new SelectionItem("TOGGLE_MAXMIZE", "切换最大化/恢复")
			},
			IsControlField = false,
			ValidForList = new List<string> { "show" }
		};
		coItObsMHYy = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		xj9tOXJ5rcQ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		idTtOmYSI34 = new StepOutParamDef
		{
			Key = "isTopmost",
			Name = "是否置顶",
			Description = "操作后窗口是否为置顶",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "toggleTopMost" }
		};
		foreach (SelectionItem selectionItem in xjdtOew45Cd.SelectionItems)
		{
			LfMtOc9ieX3.Add(selectionItem.Name);
			LfMtOc9ieX3.Add(selectionItem.Value);
		}
		foreach (SelectionItem selectionItem2 in hfGtO1l1Fdc.SelectionItems)
		{
			LfMtOc9ieX3.Add(selectionItem2.Name);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	[HandleProcessCorruptedStateExceptions]
	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.g75vfm8w66p = step;
		_003C_003Ec__DisplayClass59_.yOivfKwHtKg = context;
		_003C_003Ec__DisplayClass59_.DwKvfxtrRM2 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass59_.yOivfKwHtKg, _003C_003Ec__DisplayClass59_.g75vfm8w66p, _003C_003Ec__DisplayClass59_.DwKvfxtrRM2, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass59_.NX7vfX8SCCZ, (Action)null, (Action)null, coItObsMHYy, xj9tOXJ5rcQ);
	}

	public static uint TextToUint(string txt)
	{
		if (string.IsNullOrEmpty(txt))
		{
			return 0u;
		}
		if (txt.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			txt = txt.Substring(2);
			return uint.Parse(txt, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return Convert.ToUInt32(txt, CultureInfo.InvariantCulture);
	}

	public string GetSummary(ActionStep step)
	{
		string text = XActionHelper.GetParamDirectValue(xjdtOew45Cd, step) ?? "";
		if (XActionHelper.GetParamDirectValue(xjdtOew45Cd, step, false) == "show")
		{
			text = text + " " + XActionHelper.GetParamDisplayString(hfGtO1l1Fdc, step);
		}
		return text;
	}

	internal static bool MMclApQlI5LbEsf0HKeQ()
	{
		return qJYnxRQlx4jLrx2YeTfl == null;
	}
}
