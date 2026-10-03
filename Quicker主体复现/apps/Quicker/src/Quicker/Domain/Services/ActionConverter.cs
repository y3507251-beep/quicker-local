using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.View.KeyInput;
using WindowsInput.Native;

namespace Quicker.Domain.Services;

public static class ActionConverter
{
	internal static object xNVkMOQadPumQT519JG3;

	public static ActionItem ConvertToXAction(ActionItem action)
	{
		XAction xAction = null;
		ActionType actionType = action.ActionType;
		if (actionType <= ActionType.SendText)
		{
			if (actionType != ActionType.OpenUrl)
			{
				if (actionType != ActionType.SendText)
				{
					if (zWp60IQaOhbp3ou7H8vt())
					{
						goto IL_0053;
					}
					switch (0)
					{
					case 1:
						break;
					default:
						goto IL_0053;
					}
				}
				xAction = QHAtsiDWL6P(action);
			}
			else
			{
				xAction = Rnhts3I3ecZ(action);
			}
		}
		else if (actionType != ActionType.SendKeys)
		{
			if (actionType != ActionType.RunProgram)
			{
				if (actionType != ActionType.RunScriptFile)
				{
					goto IL_0053;
				}
				xAction = KoetslbtqVP(action);
			}
			else
			{
				xAction = vxVtsfXKVwx(action);
			}
		}
		else
		{
			xAction = bJYtszqd730(action);
		}
		if (xAction == null)
		{
			throw new NotSupportedException("无法转换为组合动作。");
		}
		ActionItem? actionItem = JsonConvert.DeserializeObject<ActionItem>(JsonConvert.SerializeObject(action));
		actionItem.ActionType = ActionType.XAction;
		actionItem.Data = JsonConvert.SerializeObject(xAction);
		actionItem.Data2 = "";
		actionItem.Data3 = "";
		return actionItem;
		IL_0053:
		throw new NotSupportedException("不支持将此类型的动作转换为组合动作。");
	}

	private static XAction KoetslbtqVP(ActionItem actionItem_0)
	{
		RunScriptActionParam scriptActionParam = JsonConvert.DeserializeObject<RunScriptActionParam>(actionItem_0.Data);
		return new XAction
		{
			Steps = { RunScriptStep.CreateStep(scriptActionParam) }
		};
	}

	private static XAction QHAtsiDWL6P(ActionItem actionItem_0)
	{
		return new XAction
		{
			Steps = { OutputTextStep.CreateStep(actionItem_0.Data, string.Equals(actionItem_0.Data3, "true", StringComparison.OrdinalIgnoreCase), string.Equals(actionItem_0.Data2, "true", StringComparison.OrdinalIgnoreCase)) }
		};
	}

	private static XAction Rnhts3I3ecZ(ActionItem actionItem_0)
	{
		return new XAction
		{
			Steps = { OpenUrlStep.CreateStep(actionItem_0.Data, actionItem_0.Data2, actionItem_0.Data3) }
		};
	}

	private static XAction vxVtsfXKVwx(ActionItem actionItem_0)
	{
		XAction xAction = new XAction();
		ProcessActionParams processActionParams = ProcessActionParams.FromActionItem(actionItem_0);
		xAction.Steps.Add(RunOrOpenStep.CreateStep(processActionParams));
		return xAction;
	}

	private static XAction bJYtszqd730(ActionItem actionItem_0)
	{
		XAction xAction = new XAction();
		using IEnumerator<KeyInputItem> enumerator = KeyInputItem.ParseLines(actionItem_0.Data).GetEnumerator();
		int num2 = default(int);
		while (true)
		{
			int num;
			if (enumerator.MoveNext())
			{
				KeyInputItem current = enumerator.Current;
				switch (current.ItemType)
				{
				case KeyInputItemType.MultiKey:
					xAction.Steps.Add(KeyInputStep.CreateStep(current.CtrlKeys, current.NormalKeys));
					continue;
				case KeyInputItemType.SingleKey:
					if (current.SingleKey.HasValue || current.SingleKey > VirtualKeyCode.None)
					{
						xAction.Steps.Add(KeyInputStep.CreateStep(new List<VirtualKeyCode>(), new List<VirtualKeyCode> { current.SingleKey.GetValueOrDefault() }));
						continue;
					}
					throw new InvalidOperationException("单个按键键值为空。");
				case KeyInputItemType.Text:
					xAction.Steps.Add(OutputTextStep.CreateStep(current.Text, false));
					continue;
				case KeyInputItemType.Sleep:
					xAction.Steps.Add(WaitTimeRunner.CreateStep(current.SleepMs.GetValueOrDefault()));
					continue;
				}
				num = 0;
				if (!zWp60IQaOhbp3ou7H8vt())
				{
					goto IL_0050;
				}
			}
			else
			{
				num = 1;
				if (xNVkMOQadPumQT519JG3 != null)
				{
					goto IL_0050;
				}
			}
			goto IL_0051;
			IL_0051:
			switch (num)
			{
			case 1:
				return xAction;
			}
			continue;
			IL_0050:
			num = num2;
			goto IL_0051;
		}
	}

	public static string BoolToString(bool value)
	{
		if (!value)
		{
			return "0";
		}
		return "1";
	}

	public static ActionItem CreateRecordAction(string recordData)
	{
		return new ActionItem
		{
			Title = $"录制{DateTime.Now:MMdd_HHmm}",
			Description = "录制键鼠自动生成的动作",
			ActionType = ActionType.XAction,
			Data = JsonConvert.SerializeObject(new XAction
			{
				Steps = { PlayRecordStep.CreateStep(recordData) }
			})
		};
	}

	internal static bool zWp60IQaOhbp3ou7H8vt()
	{
		return xNVkMOQadPumQT519JG3 == null;
	}
}
