using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CW;
using FontAwesome5;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using XIhlRTAWcPOLc2pSp5w;

namespace Quicker.Actions.XActions.BuildinRunners;

public class ShellOperationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec kfSSkUYIX04;

		public static Func<string, bool> qMaSklGLFlo;

		public static Func<string, bool> YkjSkigCVWx;

		public static Func<string, bool> dH9Sk3fyrW7;

		internal static _003C_003Ec z42LJVWfsrHSeQqDSWtA;

		static _003C_003Ec()
		{
			kfSSkUYIX04 = new _003C_003Ec();
		}

		internal bool fTBSkAV5wcY(string x)
		{
			return !x.IsPathExists();
		}

		internal bool dh1SkOHXk3C(string x)
		{
			return !x.IsPathExists();
		}

		internal bool nEySkFKwqm6(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal static void YVwsv5Wf48143R7FGMKZ()
		{
		}

		internal static bool xhilR9WfCOOslNRrLJtK()
		{
			return z42LJVWfsrHSeQqDSWtA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep oiFSkzGtjfc;

		public ActionExecuteContext t0qSGwUbLc0;

		public XAction GM9SGt1OPXe;

		internal static _003C_003Ec__DisplayClass47_0 YlUx6xWfhoQxAmW5m6mx;

		internal (bool isSuccess, string message, ActionStopFlag failReason) tuuSkfllrF5()
		{
			switch (XActionHelper.GetTextParamValue(PBHg6hckXJT, oiFSkzGtjfc, t0qSGwUbLc0))
			{
			case "execbytitle":
			{
				_003C_003Ec__DisplayClass47_5 _003C_003Ec__DisplayClass47_4 = new _003C_003Ec__DisplayClass47_5
				{
					RAiSG7WOHBr = XActionHelper.GetListParamValue(_pathListParam, oiFSkzGtjfc, t0qSGwUbLc0)
				};
				if (_003C_003Ec__DisplayClass47_4.RAiSG7WOHBr.Count < 1)
				{
					return (isSuccess: false, message: "路径列表为空", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass47_4.XMMSGRZrDxP = XActionHelper.GetTextParamValue(_titleParam, oiFSkzGtjfc, t0qSGwUbLc0);
				_003C_003Ec__DisplayClass47_4.W6nSGqLb2Mw = false;
				_003C_003Ec__DisplayClass47_4.VwISGcaY2qZ = "";
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_4.dlbSG8BrACU);
				if (!_003C_003Ec__DisplayClass47_4.W6nSGqLb2Mw)
				{
					return (isSuccess: false, message: "未成功执行菜单(" + _003C_003Ec__DisplayClass47_4.XMMSGRZrDxP + ")，" + _003C_003Ec__DisplayClass47_4.VwISGcaY2qZ + "。", failReason: ActionStopFlag.OperationFailed);
				}
				goto default;
			}
			case "showmenu":
			{
				_003C_003Ec__DisplayClass47_4 _003C_003Ec__DisplayClass47_3 = new _003C_003Ec__DisplayClass47_4
				{
					pNTSGyRhydD = XActionHelper.GetListParamValue(_pathListParam, oiFSkzGtjfc, t0qSGwUbLc0).Where(_003C_003Ec.dH9Sk3fyrW7 ?? (_003C_003Ec.dH9Sk3fyrW7 = _003C_003Ec.kfSSkUYIX04.nEySkFKwqm6)).ToList()
				};
				if (_003C_003Ec__DisplayClass47_3.pNTSGyRhydD.Count < 1)
				{
					return (isSuccess: false, message: "路径列表为空", failReason: ActionStopFlag.OperationFailed);
				}
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_3.GYoSGEIuSqW);
				goto default;
			}
			case "execverb":
			{
				_003C_003Ec__DisplayClass47_3 _003C_003Ec__DisplayClass47_5 = new _003C_003Ec__DisplayClass47_3
				{
					ikhSGNQjoh0 = XActionHelper.GetListParamValue(_pathListParam, oiFSkzGtjfc, t0qSGwUbLc0)
				};
				if (_003C_003Ec__DisplayClass47_5.ikhSGNQjoh0.Count < 1)
				{
					return (isSuccess: false, message: "路径列表为空", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass47_5.CWpSGJyWMln = XActionHelper.GetTextParamValue(_verbParam, oiFSkzGtjfc, t0qSGwUbLc0);
				_003C_003Ec__DisplayClass47_5.kJjSG0QpM6R = false;
				_003C_003Ec__DisplayClass47_5.l7kSGCK0jpk = "";
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_5.X7iSG2NZ2LO);
				if (!_003C_003Ec__DisplayClass47_5.kJjSG0QpM6R)
				{
					return (isSuccess: false, message: "未成功执行菜单(" + _003C_003Ec__DisplayClass47_5.CWpSGJyWMln + ")，" + _003C_003Ec__DisplayClass47_5.l7kSGCK0jpk + "。", failReason: ActionStopFlag.OperationFailed);
				}
				goto default;
			}
			default:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			case "gettitles":
			{
				_003C_003Ec__DisplayClass47_2 _003C_003Ec__DisplayClass47_2 = new _003C_003Ec__DisplayClass47_2();
				string textParamValue2 = XActionHelper.GetTextParamValue(_pathOrExtParam, oiFSkzGtjfc, t0qSGwUbLc0);
				if (string.IsNullOrEmpty(textParamValue2))
				{
					return (isSuccess: false, message: "未提供文件路径或扩展名", failReason: ActionStopFlag.OperationFailed);
				}
				string text2 = textParamValue2;
				_003C_003Ec__DisplayClass47_2.wlfSGSpRqPs = "";
				if (textParamValue2.StartsWith("."))
				{
					text2 = Path.Combine(Path.GetTempPath(), _003C_003Ec__DisplayClass47_2.wlfSGSpRqPs + textParamValue2);
					File.WriteAllText(text2, "");
				}
				IList<string> list3 = null;
				list3 = ((!text2.Contains("\n")) ? ((IList<string>)new List<string> { text2 }) : ((IList<string>)text2.SplitToList()));
				if (list3.Any(_003C_003Ec.YkjSkigCVWx ?? (_003C_003Ec.YkjSkigCVWx = _003C_003Ec.kfSSkUYIX04.dh1SkOHXk3C)))
				{
					return (isSuccess: false, message: "路径不存在。", failReason: ActionStopFlag.OperationFailed);
				}
				using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip2 = new zj8rqIAw38dI180QGip(list3, IntPtr.Zero);
				IList<string> list4 = zj8rqIAw38dI180QGip2.TPiQ9pQUGL();
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_2.wlfSGSpRqPs))
				{
					list4 = list4.Select(_003C_003Ec__DisplayClass47_2.tfjSGvnK6ot).ToList();
				}
				XActionHelper.OutputResult(_titlesOutputParam, oiFSkzGtjfc, t0qSGwUbLc0, list4, GM9SGt1OPXe);
				return (isSuccess: true, message: "ok", failReason: ActionStopFlag.NoStop);
			}
			case "getverb":
			{
				_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1();
				string textParamValue = XActionHelper.GetTextParamValue(_pathOrExtParam, oiFSkzGtjfc, t0qSGwUbLc0);
				if (string.IsNullOrEmpty(textParamValue))
				{
					return (isSuccess: false, message: "未提供文件路径或扩展名", failReason: ActionStopFlag.OperationFailed);
				}
				string text = textParamValue;
				_003C_003Ec__DisplayClass47_.HvPSGLR2fZS = "";
				if (textParamValue.StartsWith("."))
				{
					_003C_003Ec__DisplayClass47_.HvPSGLR2fZS = "quicker_" + Guid.NewGuid().ToString();
					text = Path.Combine(Path.GetTempPath(), _003C_003Ec__DisplayClass47_.HvPSGLR2fZS + textParamValue);
					File.WriteAllText(text, "");
				}
				IList<string> list = null;
				list = ((!text.Contains("\n")) ? ((IList<string>)new List<string> { text }) : ((IList<string>)text.SplitToList()));
				if (list.Any(_003C_003Ec.qMaSklGLFlo ?? (_003C_003Ec.qMaSklGLFlo = _003C_003Ec.kfSSkUYIX04.fTBSkAV5wcY)))
				{
					return (isSuccess: false, message: "路径不存在。", failReason: ActionStopFlag.OperationFailed);
				}
				using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip = new zj8rqIAw38dI180QGip(list, IntPtr.Zero);
				IList<string> list2 = zj8rqIAw38dI180QGip.PGYQhEm7uM(false);
				if (!Ext.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.HvPSGLR2fZS))
				{
					list2 = list2.Select(_003C_003Ec__DisplayClass47_.R1vSGgE24DU).ToList();
				}
				XActionHelper.OutputResult(_verbsOutputParam, oiFSkzGtjfc, t0qSGwUbLc0, list2, GM9SGt1OPXe);
				return (isSuccess: true, message: "ok", failReason: ActionStopFlag.NoStop);
			}
			}
		}

		internal static bool KSEQeWWfH8a3G4ODTLbQ()
		{
			return YlUx6xWfhoQxAmW5m6mx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public string HvPSGLR2fZS;

		internal static _003C_003Ec__DisplayClass47_1 wX9EvuWbVtqQ6uRmNfKu;

		internal string R1vSGgE24DU(string x)
		{
			return x.Replace(HvPSGLR2fZS, "文件名");
		}

		internal static bool PM7FqsWbQfm9nDKobO4V()
		{
			return wX9EvuWbVtqQ6uRmNfKu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_2
	{
		public string wlfSGSpRqPs;

		internal static _003C_003Ec__DisplayClass47_2 OsqExQWbcpy4Q5eWG0NQ;

		internal string tfjSGvnK6ot(string x)
		{
			return x.Replace(wlfSGSpRqPs, "文件名");
		}

		static _003C_003Ec__DisplayClass47_2()
		{
		}

		internal static bool eFt7CSWbW0bPusMwNHfw()
		{
			return OsqExQWbcpy4Q5eWG0NQ == null;
		}

		internal static void jwGDieWbXCajG74kTcIS()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_3
	{
		public IList<string> ikhSGNQjoh0;

		public string CWpSGJyWMln;

		public bool kJjSG0QpM6R;

		public string l7kSGCK0jpk;

		public Action z7nSGPkq3Vd;

		internal static _003C_003Ec__DisplayClass47_3 r4KZG8Wb2ThmNkKEDIre;

		internal void X7iSG2NZ2LO()
		{
			try
			{
				DebugHelper.LogExecuteTime(z7nSGPkq3Vd ?? (z7nSGPkq3Vd = aUGSGu4vKVx), "调用Verb耗时");
				kJjSG0QpM6R = true;
			}
			catch (Exception ex)
			{
				l7kSGCK0jpk = ex.Message;
			}
		}

		internal void aUGSGu4vKVx()
		{
			using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip = new zj8rqIAw38dI180QGip(ikhSGNQjoh0, IntPtr.Zero);
			zj8rqIAw38dI180QGip.Ec9QVm0RcX(CWpSGJyWMln);
		}

		internal static bool HVI17OWbAD4pVWYI9t2N()
		{
			return r4KZG8Wb2ThmNkKEDIre == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_4
	{
		public List<string> pNTSGyRhydD;

		private static _003C_003Ec__DisplayClass47_4 vnNV8CWbeI4y4tSXrcXp;

		internal void GYoSGEIuSqW()
		{
			new zj8rqIAw38dI180QGip(pNTSGyRhydD, IntPtr.Zero).Sw7QR3i5Jn();
		}

		internal static bool MhG7bLWbjFYxODFlWtVb()
		{
			return vnNV8CWbeI4y4tSXrcXp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_5
	{
		public IList<string> RAiSG7WOHBr;

		public string XMMSGRZrDxP;

		public bool W6nSGqLb2Mw;

		public string VwISGcaY2qZ;

		public Action y6ISGVD9gjq;

		private static _003C_003Ec__DisplayClass47_5 PSsEP7WbEn3u59yB4UkZ;

		internal void dlbSG8BrACU()
		{
			try
			{
				DebugHelper.LogExecuteTime(y6ISGVD9gjq ?? (y6ISGVD9gjq = TeASGaWhTPH), "调用Verb耗时");
				W6nSGqLb2Mw = true;
			}
			catch (Exception ex)
			{
				VwISGcaY2qZ = ex.Message;
			}
		}

		internal void TeASGaWhTPH()
		{
			using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip = new zj8rqIAw38dI180QGip(RAiSG7WOHBr, IntPtr.Zero);
			zj8rqIAw38dI180QGip.q9CQcqSxKL(XMMSGRZrDxP);
		}

		internal static bool pXV8OaWbGH0akbreW2uN()
		{
			return PSsEP7WbEn3u59yB4UkZ == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> DnEg6cgHBAm = new string[1] { "shell" };

	[CompilerGenerated]
	private readonly string Xskg6VWsLju = $"fa:{EFontAwesomeIcon.Light_Window}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ItVg6ZWpTPJ = new StepRunnerCategory[1] { StepRunnerCategory.Files };

	[CompilerGenerated]
	private readonly string PYmg69jkDfN = "https://getquicker.net/KC/Help/Doc/shelloperation";

	public const string OPERATION_GETVERB = "getverb";

	public const string OPERATION_EXECUTEVERB = "execverb";

	public const string OPERATION_EXECUTE_BY_TITLE = "execbytitle";

	public const string OPERATION_GETTITLES = "gettitles";

	public const string OPERATION_SHOWMENU = "showmenu";

	private static readonly StepInParamDef PBHg6hckXJT;

	public static readonly StepInParamDef _pathOrExtParam;

	public static readonly StepInParamDef _pathListParam;

	public static readonly StepInParamDef _verbParam;

	public static readonly StepInParamDef _titleParam;

	private static readonly StepInParamDef k3Zg6eY0eUb;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Lfdg6Y9fXiy = new List<StepInParamDef> { PBHg6hckXJT, _pathOrExtParam, _pathListParam, _verbParam, _titleParam, k3Zg6eY0eUb };

	private static readonly StepOutParamDef Jy0g6IXG6VW;

	public static readonly StepOutParamDef _verbsOutputParam;

	public static readonly StepOutParamDef _titlesOutputParam;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> x8gg6WEbXeS = new List<StepOutParamDef> { Jy0g6IXG6VW, _verbsOutputParam, _titlesOutputParam };

	internal static ShellOperationStep OFwwxyQCRHJrtfiMYrCK;

	public string Key => "sys:shelloperation";

	public string Name => "Shell文件操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return DnEg6cgHBAm;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Xskg6VWsLju;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ItVg6ZWpTPJ;
		}
	}

	public string Description => "针对文件的Windows Shell相关操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return PYmg69jkDfN;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Lfdg6Y9fXiy;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return x8gg6WEbXeS;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.oiFSkzGtjfc = step;
		_003C_003Ec__DisplayClass47_.t0qSGwUbLc0 = context;
		_003C_003Ec__DisplayClass47_.GM9SGt1OPXe = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.t0qSGwUbLc0, _003C_003Ec__DisplayClass47_.oiFSkzGtjfc, _003C_003Ec__DisplayClass47_.GM9SGt1OPXe, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.tuuSkfllrF5, (Action)null, (Action)null, k3Zg6eY0eUb, Jy0g6IXG6VW);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(PBHg6hckXJT, step) + " " + XActionHelper.GetParamDisplayString(_verbParam, step);
	}

	static ShellOperationStep()
	{
		PBHg6hckXJT = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "getverb",
			SelectionItems = new SelectionItem[5]
			{
				new SelectionItem("getverb", "获取文件的可用动词列表(verb)"),
				new SelectionItem("execverb", "对文件执行动词(verb)"),
				new SelectionItem("gettitles", "获取文件的可用菜单标题列表"),
				new SelectionItem("execbytitle", "对文件执行菜单(指定菜单标题)"),
				new SelectionItem("showmenu", "显示系统上下文菜单")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		_pathOrExtParam = new StepInParamDef
		{
			Key = "pathOrExt",
			Name = "文件路径或扩展名",
			Description = "需要获取可用动词的文件类型，可使用扩展名如.txt或提供完整文件名。",
			DefaultValue = ".txt",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFile },
			ValidForList = new List<string> { "getverb", "gettitles" }
		};
		_pathListParam = new StepInParamDef
		{
			Key = "pathList",
			Name = "文件路径列表",
			Description = "要操作文件的完整路径的列表。每个文件将会被依次调用。",
			DefaultValue = "",
			Type = VarType.List,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFile },
			ValidForList = new List<string> { "execverb", "showmenu", "execbytitle" }
		};
		_verbParam = new StepInParamDef
		{
			Key = "verb",
			Name = "动词",
			Description = "Shell操作动词，需要在当前电脑上支持才能正常运行。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("open", "打开"),
				new SelectionItem("edit", "编辑"),
				new SelectionItem("print", "打印"),
				new SelectionItem("link", "创建快捷方式"),
				new SelectionItem("openas", "选择打开方式"),
				new SelectionItem("copy", "复制"),
				new SelectionItem("cut", "剪切"),
				new SelectionItem("delete", "删除"),
				new SelectionItem("setdesktopwallpaper", "设置为桌面背景"),
				new SelectionItem("ShellEdit", "使用照片编辑"),
				new SelectionItem("VSCode", "通过VisualStudioCode打开"),
				new SelectionItem("通过QQ发送到我的手机，打开QQ手机版接收。", "通过QQ发送到手机")
			},
			ValidForList = new List<string> { "execverb" }
		};
		_titleParam = new StepInParamDef
		{
			Key = "title",
			Name = "菜单标题",
			Description = "菜单上的标题文字，需要准确匹配。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "execbytitle" }
		};
		k3Zg6eY0eUb = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		Jy0g6IXG6VW = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		_verbsOutputParam = new StepOutParamDef
		{
			Key = "verbs",
			Name = "动词列表",
			Description = "每项格式为：描述文字|动词",
			ValidForList = new List<string> { "getverb" },
			Type = VarType.List
		};
		_titlesOutputParam = new StepOutParamDef
		{
			Key = "titles",
			Name = "菜单标题列表",
			Description = "",
			ValidForList = new List<string> { "gettitles" },
			Type = VarType.List
		};
	}

	internal static bool Md8AN8QCgpk3yoMge3qE()
	{
		return OFwwxyQCRHJrtfiMYrCK == null;
	}

	internal static void ANYDKNQCM81YiPcpmELc()
	{
	}
}
