using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.UI;
using SCyJThYoNMQE7IHLXbA;
using Z.Expressions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.List;

public class ManageListStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public ActionStep o3bSyv9hLVG;

		public ActionExecuteContext hlXSySunQmk;

		private static _003C_003Ec__DisplayClass46_0 ajrJelWOQAWNXdc5ib9b;

		internal (bool isSuccess, string message, ActionStopFlag failReason) rd2SyL0tbGG()
		{
			_003C_003Ec__DisplayClass46_1 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_1
			{
				wIjSyR6uXtG = this
			};
			IList<string> listParamValue = XActionHelper.GetListParamValue(CeHg0ktMZZm, o3bSyv9hLVG, hlXSySunQmk);
			if (listParamValue != null && listParamValue is List<string>)
			{
				_003C_003Ec__DisplayClass46_.yJcSy0bMdBK = listParamValue as List<string>;
				_003C_003Ec__DisplayClass46_.yJcSy0bMdBK.HasData();
				_003C_003Ec__DisplayClass46_.WE9SyaSDElF = false;
				_003C_003Ec__DisplayClass46_.fE4Sy7KMTdn = null;
				_003C_003Ec__DisplayClass46_.TW6SyJ3ErFc = null;
				_003C_003Ec__DisplayClass46_.xYeSyPYf25i = XActionHelper.GetBooleanParamValue(_parseDataParam, o3bSyv9hLVG, hlXSySunQmk);
				_003C_003Ec__DisplayClass46_.SZrSyywmrS5 = XActionHelper.GetTextParamValue(_separatorParam, o3bSyv9hLVG, hlXSySunQmk);
				_003C_003Ec__DisplayClass46_.t3ISyCSnRVw = XActionHelper.GetTextParamValue(iMBg01CV2pt, o3bSyv9hLVG, hlXSySunQmk);
				string textParamValue = XActionHelper.GetTextParamValue(_titleDelegateParam, o3bSyv9hLVG, hlXSySunQmk);
				_003C_003Ec__DisplayClass46_.IVGSyEqW7X8 = null;
				if (!string.IsNullOrEmpty(textParamValue))
				{
					if (textParamValue.StartsWith("regex:"))
					{
						_003C_003Ec__DisplayClass46_.IVGSyEqW7X8 = new _003C_003Ec__DisplayClass46_2
						{
							gdZSyVrEuWs = new Regex(textParamValue.Substring(6))
						}.UigSycbcmkA;
					}
					else
					{
						_003C_003Ec__DisplayClass46_.IVGSyEqW7X8 = Eval.Compile<Func<string, string>>(textParamValue, new string[1] { "x" });
					}
				}
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass46_.SZrSyywmrS5) & _003C_003Ec__DisplayClass46_.xYeSyPYf25i)
				{
					return (isSuccess: false, message: "分隔符不能为空", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass46_.g5ySy8xN0Vd = 0.0;
				string textParamValue2 = XActionHelper.GetTextParamValue(_windowWidthParam, o3bSyv9hLVG, hlXSySunQmk);
				if (!string.IsNullOrEmpty(textParamValue2) && double.TryParse(textParamValue2, out _003C_003Ec__DisplayClass46_.g5ySy8xN0Vd) && _003C_003Ec__DisplayClass46_.g5ySy8xN0Vd < 200.0)
				{
					_003C_003Ec__DisplayClass46_.g5ySy8xN0Vd = 200.0;
				}
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass46_.enLSy2sU9Qh);
				while (true)
				{
					if (!_003C_003Ec__DisplayClass46_.WE9SyaSDElF)
					{
						if (hlXSySunQmk.IsShouldStopAction())
						{
							break;
						}
						Thread.Sleep(20);
						continue;
					}
					if (_003C_003Ec__DisplayClass46_.fE4Sy7KMTdn != null)
					{
						_003C_003Ec__DisplayClass46_.yJcSy0bMdBK.Clear();
						foreach (string item in _003C_003Ec__DisplayClass46_.fE4Sy7KMTdn)
						{
							_003C_003Ec__DisplayClass46_.yJcSy0bMdBK.Add(item);
						}
					}
					if (hlXSySunQmk.IsDebugging)
					{
						hlXSySunQmk.ActionLogger.LogOutput(null, "*list*", _003C_003Ec__DisplayClass46_.yJcSy0bMdBK);
					}
					if (!_003C_003Ec__DisplayClass46_.TW6SyJ3ErFc.IsSuccess)
					{
						return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass46_.bd5SyNQARug);
				return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
			}
			return (isSuccess: false, message: "需要传入列表变量", failReason: ActionStopFlag.OperationFailed);
		}

		static _003C_003Ec__DisplayClass46_0()
		{
		}

		internal static bool e0RvghWOFJ5psNpOXZCa()
		{
			return ajrJelWOQAWNXdc5ib9b == null;
		}

		internal static void eX8ZNnWOWMsFTIHgNPwS()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_1
	{
		public ListManageWindow TW6SyJ3ErFc;

		public List<string> yJcSy0bMdBK;

		public string t3ISyCSnRVw;

		public bool xYeSyPYf25i;

		public Func<string, string> IVGSyEqW7X8;

		public string SZrSyywmrS5;

		public double g5ySy8xN0Vd;

		public bool WE9SyaSDElF;

		public IList<string> fE4Sy7KMTdn;

		public _003C_003Ec__DisplayClass46_0 wIjSyR6uXtG;

		public EventHandler gyfSyqwcUcK;

		internal static _003C_003Ec__DisplayClass46_1 FgZ8DuWOyIAoD1ePvSyY;

		internal void enLSy2sU9Qh()
		{
			TW6SyJ3ErFc = new ListManageWindow(yJcSy0bMdBK);
			TW6SyJ3ErFc.AllowAdd = XActionHelper.GetBooleanParamValue(_allowAdd, wIjSyR6uXtG.o3bSyv9hLVG, wIjSyR6uXtG.hlXSySunQmk);
			TW6SyJ3ErFc.AllowEdit = XActionHelper.GetBooleanParamValue(_allowEdit, wIjSyR6uXtG.o3bSyv9hLVG, wIjSyR6uXtG.hlXSySunQmk);
			TW6SyJ3ErFc.AllowDelete = XActionHelper.GetBooleanParamValue(_allowDelete, wIjSyR6uXtG.o3bSyv9hLVG, wIjSyR6uXtG.hlXSySunQmk);
			TW6SyJ3ErFc.HelpText = t3ISyCSnRVw;
			TW6SyJ3ErFc.ParseData = xYeSyPYf25i;
			TW6SyJ3ErFc.TitleDelegate = IVGSyEqW7X8;
			TW6SyJ3ErFc.Separator = SZrSyywmrS5;
			int num;
			if (g5ySy8xN0Vd > 200.0)
			{
				TW6SyJ3ErFc.Width = g5ySy8xN0Vd;
				num = 0;
				if (!DCjJwyWOpcZ2CpDg1mDv())
				{
					goto IL_0156;
				}
			}
			goto IL_0174;
			IL_0156:
			switch (num)
			{
			case 1:
				goto IL_01bf;
			}
			goto IL_0174;
			IL_0174:
			TW6SyJ3ErFc.V6hgjEnp8ZH(wIjSyR6uXtG.hlXSySunQmk.CancellationToken);
			string textParamValue = XActionHelper.GetTextParamValue(WPag0GCUIog, wIjSyR6uXtG.o3bSyv9hLVG, wIjSyR6uXtG.hlXSySunQmk);
			if (!string.IsNullOrEmpty(textParamValue))
			{
				TW6SyJ3ErFc.Title = textParamValue;
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(bV5g0slOjwH, wIjSyR6uXtG.o3bSyv9hLVG, wIjSyR6uXtG.hlXSySunQmk);
			if (!string.IsNullOrEmpty(textParamValue2))
			{
				TW6SyJ3ErFc.SetNote(textParamValue2);
				num = 1;
				if (FgZ8DuWOyIAoD1ePvSyY != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0156;
			}
			goto IL_01bf;
			IL_01bf:
			TW6SyJ3ErFc.Closed += gyfSyqwcUcK ?? (gyfSyqwcUcK = PlaSyux09il);
			AppHelper.SetWindowIcon(TW6SyJ3ErFc, wIjSyR6uXtG.hlXSySunQmk?.Action?.Icon, true);
			TW6SyJ3ErFc.Show();
			TW6SyJ3ErFc.Activate();
		}

		internal void PlaSyux09il(object sender, EventArgs e)
		{
			WE9SyaSDElF = true;
			if (TW6SyJ3ErFc.IsSuccess)
			{
				fE4Sy7KMTdn = TW6SyJ3ErFc.GetResult();
			}
		}

		internal void bd5SyNQARug()
		{
			TW6SyJ3ErFc?.Close();
		}

		internal static bool DCjJwyWOpcZ2CpDg1mDv()
		{
			return FgZ8DuWOyIAoD1ePvSyY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_2
	{
		public Regex gdZSyVrEuWs;

		private static _003C_003Ec__DisplayClass46_2 Jc3SBXWOniXPfhUZ0Gnt;

		internal string UigSycbcmkA(string s)
		{
			Match match = gdZSyVrEuWs.Match(s);
			if (match.Success)
			{
				return match.Value;
			}
			return s;
		}

		internal static bool c4QXb2WOe9feMBj89D05()
		{
			return Jc3SBXWOniXPfhUZ0Gnt == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> c5cg0etXZix = new List<string> { "排序", "增加", "删除", "list", "order" };

	[CompilerGenerated]
	private readonly string glBg0YSAXrQ = $"fa:{EFontAwesomeIcon.Light_ListOl}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> AaLg0IGLoVF;

	[CompilerGenerated]
	private readonly string SCug0WPwhOj = "https://getquicker.net/KC/Help/Doc/managelist";

	private static readonly StepInParamDef CeHg0ktMZZm;

	private static readonly StepInParamDef WPag0GCUIog;

	private static readonly StepInParamDef bV5g0slOjwH;

	public static readonly StepInParamDef _allowAdd;

	public static readonly StepInParamDef _allowEdit;

	public static readonly StepInParamDef _allowDelete;

	private static readonly StepInParamDef jg7g0HQfo21;

	public static readonly StepInParamDef _parseDataParam;

	public static readonly StepInParamDef _separatorParam;

	private static readonly StepInParamDef iMBg01CV2pt;

	public static readonly StepInParamDef _windowWidthParam;

	public static readonly StepInParamDef _titleDelegateParam;

	private static readonly StepOutParamDef gVwg0bhCDpF;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> pj1g06gGvAs = new List<StepInParamDef>
	{
		CeHg0ktMZZm, WPag0GCUIog, bV5g0slOjwH, _parseDataParam, _separatorParam, _windowWidthParam, _allowAdd, _allowEdit, _allowDelete, jg7g0HQfo21,
		iMBg01CV2pt, _titleDelegateParam
	};

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> BvOg0Xp5HJT = new List<StepOutParamDef> { gVwg0bhCDpF };

	internal static ManageListStep IvNUu9QUQGULqHX3lUkW;

	public string Key => "sys:manageList";

	public string Name => "管理和排序列表";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return c5cg0etXZix;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return glBg0YSAXrQ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return AaLg0IGLoVF;
		}
	}

	public string Description => "对列表内容进行手工排序、添加、删除等操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return SCug0WPwhOj;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return pj1g06gGvAs;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return BvOg0Xp5HJT;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.o3bSyv9hLVG = step;
		_003C_003Ec__DisplayClass46_.hlXSySunQmk = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass46_.hlXSySunQmk, _003C_003Ec__DisplayClass46_.o3bSyv9hLVG, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass46_.rd2SyL0tbGG, (Action)null, (Action)null, jg7g0HQfo21, gVwg0bhCDpF);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(CeHg0ktMZZm, step) ?? "";
	}

	static ManageListStep()
	{
		CeHg0ktMZZm = new StepInParamDef
		{
			Key = "list",
			Name = "列表",
			Description = "要操作的列表变量。直接选择对应变量，不要使用表达式。",
			DefaultValue = null,
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOnly,
			IsMultiLine = true
		};
		WPag0GCUIog = new StepInParamDef
		{
			Key = "winTitle",
			Name = "窗口标题",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		bV5g0slOjwH = new StepInParamDef
		{
			Key = "note",
			Name = "提示信息",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		_allowAdd = new StepInParamDef
		{
			Key = "allowAdd",
			Name = "允许添加项",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		_allowEdit = new StepInParamDef
		{
			Key = "allowEdit",
			Name = "允许编辑项",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		_allowDelete = new StepInParamDef
		{
			Key = "allowDelete",
			Name = "允许删除项",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		jg7g0HQfo21 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "取消后停止动作",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		_parseDataParam = new StepInParamDef
		{
			Key = "parseData",
			Name = "解析菜单数据",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			Description = "解析 “[图标]标题(tooltip)|值” 格式的数据并显示图标。"
		};
		_separatorParam = new StepInParamDef
		{
			Key = "seperator",
			Name = "分隔符",
			DefaultValue = "|",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			Description = "解析菜单数据时，显示内容与值之间的分隔符，默认为竖线'|'"
		};
		iMBg01CV2pt = new StepInParamDef
		{
			Key = "help",
			Name = "帮助按钮内容",
			Description = "点击弹出显示帮助内容，MarkDown格式",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			DefaultHighlightType = "MarkDown"
		};
		_windowWidthParam = new StepInParamDef
		{
			Key = "windowSize",
			Name = "窗口宽度",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			Description = "可选，在需要自定义窗口宽度的情况下使用。最小值为200。"
		};
		_titleDelegateParam = new StepInParamDef
		{
			Key = "titleDelegate",
			Name = "显示内容提取表达式",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			Description = "可选，在不解析菜单数据时自定义每一项的显示内容。使用方式请参考模块文档。",
			IsAdvanced = true
		};
		gVwg0bhCDpF = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否确认",
			Description = "是否点击了确认按钮",
			Type = VarType.Boolean
		};
	}

	internal static bool tCS4NTQUF0Y5j5s7mSxE()
	{
		return IvNUu9QUQGULqHX3lUkW == null;
	}
}
