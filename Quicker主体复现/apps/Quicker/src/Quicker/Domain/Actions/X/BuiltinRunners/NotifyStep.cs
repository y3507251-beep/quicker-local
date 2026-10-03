using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FontAwesome5;
using HandyControl.Controls;
using HandyControl.Data;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using ToastNotifications.Core;
using ToastNotifications.Messages;
using yyXIB9Yxgd6ACb7T4ig;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class NotifyStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec so2SScJjeeb;

		public static Action<NotificationBase> Q72SSVrIkjk;

		private static _003C_003Ec PZwQsxW1qmcQFFEvOrmu;

		static _003C_003Ec()
		{
			so2SScJjeeb = new _003C_003Ec();
		}

		internal void aSLSSqWcpic(NotificationBase b)
		{
			vQNggTU3ZW3((string)b.Options.Tag);
		}

		internal static bool TGUdkdW1ic3fpvNdKgvP()
		{
			return PZwQsxW1qmcQFFEvOrmu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep Y9PSS9w1Fvs;

		public ActionExecuteContext y2XSShODtg7;

		private static _003C_003Ec__DisplayClass39_0 xkc1yCW1Z1qjPs9iPHH7;

		internal (bool isSuccess, string message, ActionStopFlag failReason) G6JSSZ3Zw0o()
		{
			_003C_003Ec__DisplayClass39_1 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_1();
			string text = XActionHelper.GetTextParamValue(jgOgglhNQ5q, Y9PSS9w1Fvs, y2XSShODtg7) ?? string.Empty;
			_003C_003Ec__DisplayClass39_.GUGSSI8NxOf = XActionHelper.GetTextParamValue(Aecgg3B4tF6, Y9PSS9w1Fvs, y2XSShODtg7);
			int num = Convert.ToInt32(XActionHelper.GetIntegerParamValue(v07ggiJEqaj, Y9PSS9w1Fvs, y2XSShODtg7));
			string textParamValue = XActionHelper.GetTextParamValue(SmWggzedFMs, Y9PSS9w1Fvs, y2XSShODtg7);
			_003C_003Ec__DisplayClass39_.SRpSSYmXQOI = XActionHelper.GetTextParamValue(MF6ggft29CW, Y9PSS9w1Fvs, y2XSShODtg7);
			if (num > 0)
			{
				text = text.ReduceLine(num);
			}
			bool flag = textParamValue == "Style2";
			if (_003C_003Ec__DisplayClass39_.GUGSSI8NxOf.Equals("WINDOWSTOAST", StringComparison.OrdinalIgnoreCase))
			{
				string text2 = null;
				if (!string.IsNullOrEmpty(y2XSShODtg7?.Action.Icon) && y2XSShODtg7.Action.Icon.EndsWith(".png"))
				{
					text2 = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(y2XSShODtg7.Action.Icon);
				}
				string title = y2XSShODtg7.Action.Title;
				string message = text;
				Action callback = _003C_003Ec__DisplayClass39_.awNSSemAsLn;
				string iconPath = text2;
				AppHelper.ShowWindowsToastMessage(title, message, callback, null, iconPath);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			MessageOptions displayOptions;
			if (flag)
			{
				AppHelper.RunOnUiThread(false, new _003C_003Ec__DisplayClass39_2
				{
					YhFSSGCjh5g = _003C_003Ec__DisplayClass39_,
					gBaSSkBC7rn = new GrowlInfo
					{
						ShowDateTime = false,
						Message = text,
						WaitTime = 5,
						IsCustom = true
					}
				}.Fb6SSWIK0od);
			}
			else if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass39_.SRpSSYmXQOI))
			{
				displayOptions = new MessageOptions
				{
					FontSize = 15.0,
					UnfreezeOnMouseLeave = true,
					Tag = _003C_003Ec__DisplayClass39_.SRpSSYmXQOI,
					NotificationClickAction = (_003C_003Ec.Q72SSVrIkjk ?? (_003C_003Ec.Q72SSVrIkjk = _003C_003Ec.so2SScJjeeb.aSLSSqWcpic))
				};
				string iconPath = _003C_003Ec__DisplayClass39_.GUGSSI8NxOf.ToUpperInvariant();
				if (iconPath != null && iconPath.Length == 0)
				{
					goto IL_02ad;
				}
				switch (iconPath)
				{
				case "ERROR":
					break;
				case "WARNING":
					goto IL_0277;
				case "SUCCESS":
					goto IL_0292;
				default:
					goto IL_02ad;
				}
				AppState.vVktaZmxU7S()?.ShowError(text, displayOptions);
			}
			else
			{
				string iconPath = _003C_003Ec__DisplayClass39_.GUGSSI8NxOf.ToUpperInvariant();
				if (iconPath != null && iconPath.Length == 0)
				{
					goto IL_033b;
				}
				switch (iconPath)
				{
				case "ERROR":
					goto IL_0321;
				case "WARNING":
					goto IL_032a;
				case "SUCCESS":
					goto IL_0333;
				case "INFO":
					goto IL_033b;
				}
				AppHelper.ShowInformation(text);
			}
			goto IL_0343;
			IL_0333:
			AppHelper.ShowSuccess(text);
			goto IL_0343;
			IL_02ad:
			AppState.vVktaZmxU7S()?.ShowInformation(text, displayOptions);
			goto IL_0343;
			IL_032a:
			AppHelper.ShowWarning(text);
			goto IL_0343;
			IL_0321:
			AppHelper.ShowError(text, false);
			goto IL_0343;
			IL_033b:
			AppHelper.ShowInformation(text);
			goto IL_0343;
			IL_0277:
			AppState.vVktaZmxU7S()?.ShowWarning(text, displayOptions);
			goto IL_0343;
			IL_0292:
			AppState.vVktaZmxU7S()?.ShowSuccess(text, displayOptions);
			goto IL_0343;
			IL_0343:
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool y00pTqW15jiembIpAAh7()
		{
			return xkc1yCW1Z1qjPs9iPHH7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_1
	{
		public string SRpSSYmXQOI;

		public string GUGSSI8NxOf;

		internal static _003C_003Ec__DisplayClass39_1 G6aFNWW18L14suRtoYxT;

		internal void awNSSemAsLn()
		{
			vQNggTU3ZW3(SRpSSYmXQOI);
		}

		static _003C_003Ec__DisplayClass39_1()
		{
		}

		internal static bool gBnCJDW1ROORbZ9J4c7Q()
		{
			return G6aFNWW18L14suRtoYxT == null;
		}

		internal static void nK7TWuW1P4rPKF55UIV7()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_2
	{
		public GrowlInfo gBaSSkBC7rn;

		public _003C_003Ec__DisplayClass39_1 YhFSSGCjh5g;

		internal static _003C_003Ec__DisplayClass39_2 nwkYrtW1M2xbphUkaQ50;

		internal void Fb6SSWIK0od()
		{
			string text = YhFSSGCjh5g.GUGSSI8NxOf.ToUpperInvariant();
			if (text == null || text.Length != 0)
			{
				switch (text)
				{
				case "ERROR":
				{
					Growl.ErrorGlobal(gBaSSkBC7rn);
					int num = 0;
					if (nwkYrtW1M2xbphUkaQ50 != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					return;
				}
				default:
					Growl.InfoGlobal(gBaSSkBC7rn);
					return;
				case "WARNING":
					Growl.WarningGlobal(gBaSSkBC7rn);
					return;
				case "SUCCESS":
					Growl.SuccessGlobal(gBaSSkBC7rn);
					return;
				case "INFO":
					break;
				}
			}
			Growl.InfoGlobal(gBaSSkBC7rn);
		}

		internal static bool uOEMMPW1UvrqGUwZQxGh()
		{
			return nwkYrtW1M2xbphUkaQ50 == null;
		}
	}

	private static List<string> IUaggMKAyCp;

	[CompilerGenerated]
	private readonly string NY8ggAvgZLU = $"fa:{EFontAwesomeIcon.Light_Bullhorn}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> eVLggOMG03h = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string V3JggFKT4hs = "https://getquicker.net/KC/Help/Doc/notify";

	[CompilerGenerated]
	private readonly bool UWOggU8ZqHZ;

	private static readonly StepInParamDef jgOgglhNQ5q;

	private static readonly StepInParamDef v07ggiJEqaj;

	private static readonly StepInParamDef Aecgg3B4tF6;

	private static readonly StepInParamDef MF6ggft29CW;

	private static readonly StepInParamDef SmWggzedFMs;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> dbrgLwgoY0t = new StepInParamDef[5] { Aecgg3B4tF6, jgOgglhNQ5q, v07ggiJEqaj, SmWggzedFMs, MF6ggft29CW };

	private static NotifyStep HonRw6QRb10ESP3yi5NV;

	public string Key => "sys:notify";

	public string Name => "提示消息";

	public IEnumerable<string> KeyWords => IUaggMKAyCp;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NY8ggAvgZLU;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return eVLggOMG03h;
		}
	}

	public string Description => "显示可以自动消失的消息提示。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return V3JggFKT4hs;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return UWOggU8ZqHZ;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return dbrgLwgoY0t;
		}
	}

	public IList<StepOutParamDef> OutputParams => Array.Empty<StepOutParamDef>();

	static NotifyStep()
	{
		IUaggMKAyCp = new List<string> { "messages" };
		jgOgglhNQ5q = new StepInParamDef
		{
			Key = "msg",
			Name = "消息内容",
			Description = "显示的消息内容",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = true
		};
		v07ggiJEqaj = new StepInParamDef
		{
			Key = "maxLines",
			Name = "最大行数",
			Description = "显示内容的最大行数，0表示不限",
			DefaultValue = 0,
			Type = VarType.Integer,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Aecgg3B4tF6 = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "消息的类型",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Enum,
			DefaultValue = "Info",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Success", "成功"),
				new SelectionItem("Info", "信息"),
				new SelectionItem("Warning", "告警"),
				new SelectionItem("Error", "错误"),
				new SelectionItem("WindowsToast", "Windows 通知 (win10+)")
			}
		};
		MF6ggft29CW = new StepInParamDef
		{
			Key = "clickAction",
			Name = "点击命令",
			Description = "点击时运行命令（如网址等可以在Win+R中执行的文本，仅支持默认风格提示）。默认为复制提示文字。",
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = true,
			ValidForList = new string[1] { "Default" }
		};
		SmWggzedFMs = new StepInParamDef
		{
			Key = "style",
			Name = "风格",
			Description = "",
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			DefaultValue = "Default",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Default", "默认（显示在屏幕底部）"),
				new SelectionItem("Style2", "风格2（显示在屏幕右侧）")
			},
			IsControlField = true
		};
		foreach (SelectionItem selectionItem in Aecgg3B4tF6.SelectionItems)
		{
			IUaggMKAyCp.Add(selectionItem.Name);
			IUaggMKAyCp.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.Y9PSS9w1Fvs = step;
		_003C_003Ec__DisplayClass39_.y2XSShODtg7 = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.y2XSShODtg7, _003C_003Ec__DisplayClass39_.Y9PSS9w1Fvs, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.G6JSSZ3Zw0o, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(jgOgglhNQ5q, step) ?? "";
	}

	[CompilerGenerated]
	internal static void vQNggTU3ZW3(string string_2)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			AppHelper.ExecuteText(string_2);
		}
	}

	internal static bool HK0ofZQRqU8Q0S240mBl()
	{
		return HonRw6QRb10ESP3yi5NV == null;
	}
}
