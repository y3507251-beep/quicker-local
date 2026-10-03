using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class StateStorageStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public ActionStep G09SRtSZGXk;

		public ActionExecuteContext O0ESRgykrir;

		public XAction AoDSRLOOBRG;

		public StateStorageStep mhsSRvbvkrg;

		internal static _003C_003Ec__DisplayClass56_0 CU6El9WkrZDmVH3xKi3p;

		internal (bool isSuccess, string message, ActionStopFlag failReason) OQNSRw0Br8Y()
		{
			string textParamValue = XActionHelper.GetTextParamValue(DDBgymgu7oA, G09SRtSZGXk, O0ESRgykrir);
			string textParamValue2 = XActionHelper.GetTextParamValue(syHgyKDdiJR, G09SRtSZGXk, O0ESRgykrir);
			switch (textParamValue)
			{
			case "saveGlobalState":
				PA9gyWEWckt(G09SRtSZGXk, O0ESRgykrir, "global_shared_states", textParamValue2);
				goto IL_01d1;
			case "saveActionState":
				PA9gyWEWckt(G09SRtSZGXk, O0ESRgykrir, O0ESRgykrir.RootContext.ActionId, textParamValue2);
				goto IL_01d1;
			case "readGlobalState":
				LvKgykyNnRQ(G09SRtSZGXk, O0ESRgykrir, AoDSRLOOBRG, "global_shared_states", textParamValue2);
				goto IL_01d1;
			case "readActionState":
				LvKgykyNnRQ(G09SRtSZGXk, O0ESRgykrir, AoDSRLOOBRG, O0ESRgykrir.RootContext.ActionId, textParamValue2);
				goto IL_01d1;
			case "UpdateOverlyIcon":
				mhsSRvbvkrg.Gg1gyGA5j9S(O0ESRgykrir, G09SRtSZGXk, AoDSRLOOBRG);
				goto IL_01d1;
			case "UpdateContextMenu":
				mhsSRvbvkrg.jIXgysleKCe(O0ESRgykrir, G09SRtSZGXk, AoDSRLOOBRG);
				goto IL_01d1;
			case "UpdateActionBadge":
				mhsSRvbvkrg.UpdateActionBadge(O0ESRgykrir, G09SRtSZGXk, AoDSRLOOBRG);
				goto IL_01d1;
			default:
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_01d1:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool K88WFCWkNgV1nMYoem6o()
		{
			return CU6El9WkrZDmVH3xKi3p == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public string hP3SR2kZh6R;

		public string Qi0SRuTtaaS;

		public string WrhSRNibHwY;

		public ActionExecuteContext Lk6SRJVhtIe;

		public string U1QSR0yYaNK;

		internal static _003C_003Ec__DisplayClass58_0 XuHx9VWkLVPal4PsBEek;

		internal void UiESRSLysxT()
		{
			UserInputWindow userInputWindow = new UserInputWindow("multiline", U1QSR0yYaNK, "", "");
			if (userInputWindow.ShowDialog() == true)
			{
				hP3SR2kZh6R = userInputWindow.TextValue;
				ActionStateWriter.WriteActionState(Qi0SRuTtaaS, WrhSRNibHwY, hP3SR2kZh6R);
			}
			RestoreActiveWindowStep.RestoreActiveWindow(Lk6SRJVhtIe);
		}

		static _003C_003Ec__DisplayClass58_0()
		{
		}

		internal static bool yxZl3WWkuaSFDFcUtkVG()
		{
			return XuHx9VWkLVPal4PsBEek == null;
		}

		internal static void YMBNrlWkfSOqw9m1TpdC()
		{
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> l8fgyHD4WEx = new string[4] { "状态", "state", "徽标文字", "右键菜单" };

	[CompilerGenerated]
	private readonly string AYYgy1kIFsw = $"fa:{EFontAwesomeIcon.Light_Save}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> isigyb7T6lT;

	[CompilerGenerated]
	private readonly string If5gy6vtNnh = "https://getquicker.net/KC/Help/Doc/stateStorage";

	[CompilerGenerated]
	private readonly bool DdtgyXdJFEw;

	private static readonly StepInParamDef DDBgymgu7oA;

	private static readonly StepInParamDef syHgyKDdiJR;

	private static readonly StepInParamDef b4ygyxcnk0J;

	private static readonly StepInParamDef jBHgyrS2R1b;

	private static readonly StepInParamDef GhWgyppgK04;

	private static readonly StepInParamDef FULgyBJ58MD;

	private static readonly StepInParamDef mwpgyQfFAer;

	private static readonly StepInParamDef QRGgyjUr11i;

	private static readonly StepInParamDef Y63gynocua5;

	private static readonly StepInParamDef Qo4gy4YKpuV;

	private static readonly StepInParamDef rctgy52VJmK;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> eCvgyDYI5FO = new StepInParamDef[11]
	{
		DDBgymgu7oA, syHgyKDdiJR, jBHgyrS2R1b, b4ygyxcnk0J, GhWgyppgK04, FULgyBJ58MD, QRGgyjUr11i, Y63gynocua5, Qo4gy4YKpuV, rctgy52VJmK,
		mwpgyQfFAer
	};

	private static readonly StepOutParamDef iXagydeRMZY;

	private static readonly StepOutParamDef EPngyo9ZqJZ;

	private static readonly StepOutParamDef NBsgyTJkER7;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> MxbgyMx5pii = new StepOutParamDef[3] { NBsgyTJkER7, iXagydeRMZY, EPngyo9ZqJZ };

	internal static StateStorageStep YHtKLYQxI9gtWLuKI7VZ;

	public string Key => "sys:stateStorage";

	public string Name => "状态存取";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return l8fgyHD4WEx;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return AYYgy1kIFsw;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return isigyb7T6lT;
		}
	}

	public string Description => "存取状态数据；更新动作的徽标文字；设置附加的动作右键菜单项";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return If5gy6vtNnh;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DdtgyXdJFEw;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return eCvgyDYI5FO;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return MxbgyMx5pii;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.G09SRtSZGXk = step;
		_003C_003Ec__DisplayClass56_.O0ESRgykrir = context;
		_003C_003Ec__DisplayClass56_.AoDSRLOOBRG = action;
		_003C_003Ec__DisplayClass56_.mhsSRvbvkrg = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass56_.O0ESRgykrir, _003C_003Ec__DisplayClass56_.G09SRtSZGXk, _003C_003Ec__DisplayClass56_.AoDSRLOOBRG, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass56_.OQNSRw0Br8Y, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	private static void PA9gyWEWckt(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, string string_2, string string_3)
	{
		string textParamValue = XActionHelper.GetTextParamValue(b4ygyxcnk0J, actionStep_0, actionExecuteContext_0);
		ActionStateWriter.WriteActionState(string_2, string_3, textParamValue);
	}

	private static void LvKgykyNnRQ(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, string string_3)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
			int num2 = 0;
			if (YHtKLYQxI9gtWLuKI7VZ != null)
			{
				goto IL_00a5;
			}
			goto IL_00a9;
			IL_00a9:
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass58_.Qi0SRuTtaaS = string_2;
					_003C_003Ec__DisplayClass58_.WrhSRNibHwY = string_3;
					_003C_003Ec__DisplayClass58_.Lk6SRJVhtIe = actionExecuteContext_0;
					(flag, _003C_003Ec__DisplayClass58_.hP3SR2kZh6R) = ActionStateWriter.ReadActionStateValue(_003C_003Ec__DisplayClass58_.Qi0SRuTtaaS, _003C_003Ec__DisplayClass58_.WrhSRNibHwY);
					if (!flag)
					{
						_003C_003Ec__DisplayClass58_.hP3SR2kZh6R = XActionHelper.GetTextParamValue(jBHgyrS2R1b, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe);
					}
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass58_.hP3SR2kZh6R) && XActionHelper.GetBooleanParamValue(GhWgyppgK04, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe))
					{
						goto IL_0098;
					}
					goto IL_012e;
				case 1:
					break;
				case 2:
					{
						_003C_003Ec__DisplayClass58_.U1QSR0yYaNK = XActionHelper.GetTextParamValue(FULgyBJ58MD, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe);
						if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass58_.U1QSR0yYaNK))
						{
							_003C_003Ec__DisplayClass58_.U1QSR0yYaNK = "请输入" + _003C_003Ec__DisplayClass58_.WrhSRNibHwY + "的值：";
						}
						AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass58_.UiESRSLysxT);
						goto IL_012e;
					}
					IL_012e:
					XActionHelper.OutputResult(NBsgyTJkER7, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe, flag, xaction_0);
					XActionHelper.OutputResult(iXagydeRMZY, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe, _003C_003Ec__DisplayClass58_.hP3SR2kZh6R, xaction_0);
					XActionHelper.OutputResult(EPngyo9ZqJZ, actionStep_0, _003C_003Ec__DisplayClass58_.Lk6SRJVhtIe, string.IsNullOrEmpty(_003C_003Ec__DisplayClass58_.hP3SR2kZh6R), xaction_0);
					return;
				}
				break;
				IL_0098:
				num2 = 2;
				if (YHtKLYQxI9gtWLuKI7VZ == null)
				{
					continue;
				}
				goto IL_00a5;
			}
			continue;
			IL_00a5:
			num2 = num;
			goto IL_00a9;
		}
	}

	private void Gg1gyGA5j9S(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(mwpgyQfFAer, actionStep_0, actionExecuteContext_0);
		AppState.DataService.bHxtXYylCek(actionExecuteContext_0.ActionId, textParamValue, "");
	}

	private void jIXgysleKCe(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(rctgy52VJmK, actionStep_0, actionExecuteContext_0);
		AppState.DataService.GGHtXIpvHfO(actionExecuteContext_0.ActionId, textParamValue);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(DDBgymgu7oA, step) + "   " + XActionHelper.GetParamDisplayString(syHgyKDdiJR, step);
	}

	private void UpdateActionBadge(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string actionId = context.ActionId;
		string textParamValue = XActionHelper.GetTextParamValue(QRGgyjUr11i, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(Y63gynocua5, step, context);
		string textParamValue3 = XActionHelper.GetTextParamValue(Qo4gy4YKpuV, step, context);
		AppState.DataService.UpdateActionBadge(actionId, textParamValue, textParamValue2, textParamValue3);
	}

	static StateStorageStep()
	{
		DDBgymgu7oA = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			DefaultValue = "readActionState",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("readActionState", "读取动作状态"),
				new SelectionItem("saveActionState", "写入动作状态"),
				new SelectionItem("UpdateActionBadge", "设置徽标文字"),
				new SelectionItem("UpdateOverlyIcon", "设置徽标图标"),
				new SelectionItem("UpdateContextMenu", "设置附加的右键菜单项"),
				new SelectionItem("readGlobalState", "【谨慎使用】读取全局状态"),
				new SelectionItem("saveGlobalState", "【谨慎使用】写入全局状态")
			},
			IsControlField = true
		};
		syHgyKDdiJR = new StepInParamDef
		{
			Key = "key",
			Name = "名称",
			Description = "存储或读取的状态条目名称。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[4] { "readActionState", "saveActionState", "readGlobalState", "saveGlobalState" }
		};
		b4ygyxcnk0J = new StepInParamDef
		{
			Key = "value",
			Name = "值",
			Description = "要保存的状态值。使用“*NULL*”删除此状态的存储。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "saveActionState", "saveGlobalState" }
		};
		jBHgyrS2R1b = new StepInParamDef
		{
			Key = "defaultValue",
			Name = "默认值",
			Description = "读取失败的时候返回的值",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
		GhWgyppgK04 = new StepInParamDef
		{
			Key = "inputIfEmpty",
			Name = "为空时请用户输入",
			Description = "如果读到的状态值为空，则弹出对话框请用户输入值。启用此选项时，请保持默认值为空。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
		FULgyBJ58MD = new StepInParamDef
		{
			Key = "prompt",
			Name = "用户输入提示",
			Description = "需要用户输入变量内容时，给用户的输入提示。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
		mwpgyQfFAer = new StepInParamDef
		{
			Key = "overlayIcon",
			Name = "徽标图标",
			Description = "使用内置矢量图标：“fa:图标名称:图标颜色”。如：“fa:Solid_Circle:#FF0000”",
			DefaultValue = "",
			ValidForList = new List<string> { "UpdateOverlyIcon" },
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		QRGgyjUr11i = new StepInParamDef
		{
			Key = "badgeText",
			Name = "徽标文字",
			Description = "在动作右上角显示的提示文字",
			DefaultValue = "",
			ValidForList = new List<string> { "UpdateActionBadge" },
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Y63gynocua5 = new StepInParamDef
		{
			Key = "badgeColor",
			Name = "徽标颜色",
			Description = "在动作右上角显示的徽标底色。留空表示透明。",
			DefaultValue = "",
			ValidForList = new List<string> { "UpdateActionBadge" },
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Qo4gy4YKpuV = new StepInParamDef
		{
			Key = "badgeTextColor",
			Name = "徽标文字颜色",
			Description = "",
			DefaultValue = "",
			ValidForList = new List<string> { "UpdateActionBadge" },
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		rctgy52VJmK = new StepInParamDef
		{
			Key = "actionContextMenu",
			Name = "附加的右键菜单项",
			Description = "附加的动作右键菜单，格式请参考文档",
			DefaultValue = "",
			ValidForList = new List<string> { "UpdateContextMenu" },
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		iXagydeRMZY = new StepOutParamDef
		{
			Key = "value",
			Name = "值",
			Description = "读取到的值",
			Type = VarType.Any,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
		EPngyo9ZqJZ = new StepOutParamDef
		{
			Key = "isEmpty",
			Name = "是否为空",
			Description = "读取到的值是否为空",
			Type = VarType.Boolean,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
		NBsgyTJkER7 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功获取了值",
			Type = VarType.Boolean,
			ValidForList = new string[2] { "readActionState", "readGlobalState" }
		};
	}

	internal static bool ObJHRQQx6f7Y2HRYWXLA()
	{
		return YHtKLYQxI9gtWLuKI7VZ == null;
	}
}
