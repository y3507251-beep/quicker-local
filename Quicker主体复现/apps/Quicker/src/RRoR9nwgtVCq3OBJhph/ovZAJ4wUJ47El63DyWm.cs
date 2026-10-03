using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using GEs2Jejr6IXgOTY0tM8;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Services;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace RRoR9nwgtVCq3OBJhph;

internal class ovZAJ4wUJ47El63DyWm : kWjRPcwItwkeAamARyg
{
	[CompilerGenerated]
	private readonly IDictionary<string, string> zNBtwmcghdM = new Dictionary<string, string> { { "BrowserUrlChanged", "浏览器网址变更" } };

	private FormField lPOtwKYpLm0 = new FormField
	{
		FieldKey = "UrlPattern",
		Label = "匹配网址",
		DictVarType = VarType.Text,
		HelpText = "可选。输入网址开始部分，如“https://www.baidu.com”，多个可用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox
	};

	private FormField o26twxsaShl = new FormField
	{
		FieldKey = "OnlyActiveTab",
		Label = "忽略非活动标签页的网址变更",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox,
		DefaultValue = false
	};

	internal static ovZAJ4wUJ47El63DyWm Oa8UJ8QFC5wx1PoUAq61;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return zNBtwmcghdM;
	}

	public ovZAJ4wUJ47El63DyWm()
		: base(new string[1] { "BrowserUrlChanged" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { lPOtwKYpLm0, o26twxsaShl };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "Browser",
				Desc = "浏览器进程名",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "Pid",
				Desc = "浏览器进程ID",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "TabId",
				Desc = "标签页ID",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "Url",
				Desc = "网址",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "IsActive",
				Desc = "是否为活动标签页",
				Type = VarType.Boolean
			},
			new ActionVariable
			{
				Key = "EventType",
				Desc = "事件类型：1 标签页激活 2 标签页更新  3 窗口获得焦点",
				Type = VarType.Integer
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		SKLtwb7L0qM();
		WsnAlhjCfHjoVZXu241 wsnAlhjCfHjoVZXu = AppState.vjAt7Seco0Y();
		wsnAlhjCfHjoVZXu.a4xtGlB9Stc = (EventHandler<ActiveUrlChangedEventArgs>)Delegate.Combine(wsnAlhjCfHjoVZXu.a4xtGlB9Stc, new EventHandler<ActiveUrlChangedEventArgs>(z3Ltw6D6Pxu));
	}

	private void SKLtwb7L0qM()
	{
		WsnAlhjCfHjoVZXu241 wsnAlhjCfHjoVZXu = AppState.vjAt7Seco0Y();
		wsnAlhjCfHjoVZXu.a4xtGlB9Stc = (EventHandler<ActiveUrlChangedEventArgs>)Delegate.Remove(wsnAlhjCfHjoVZXu.a4xtGlB9Stc, new EventHandler<ActiveUrlChangedEventArgs>(z3Ltw6D6Pxu));
	}

	protected override void C5rM2eDjuIN()
	{
		SKLtwb7L0qM();
	}

	private void z3Ltw6D6Pxu(object sender, ActiveUrlChangedEventArgs e)
	{
		if (string.IsNullOrEmpty(e.Url))
		{
			return;
		}
		Dictionary<string, object> idictionary_ = new Dictionary<string, object>
		{
			{ "Browser", e.Browser },
			{ "Pid", e.ProcessId },
			{ "TabId", e.TabId },
			{ "Url", e.Url },
			{
				"IsActive",
				e.IsActive ?? true
			},
			{
				"EventType",
				e.EventType ?? 2
			}
		};
		int num2 = default(int);
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.TryGetParamValue("OnlyActiveTab", false))
			{
				int num = 0;
				if (!c1Z51BQF7YpMa6BRVMo3())
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (e.IsActive == false)
				{
					continue;
				}
			}
			string text = item.TryGetParamValue("UrlPattern", "");
			if ((string.IsNullOrEmpty(text) || aNvtwXSP8xT(text, e.Url)) && iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private bool aNvtwXSP8xT(string string_1, string string_2)
	{
		if (string_1.StartsWith("regex:"))
		{
			if (new Regex(string_1.Substring(6)).IsMatch(string_2))
			{
				return true;
			}
			return false;
		}
		string[] array = string_1.SplitToList(';', '；');
		int num = 0;
		if (!c1Z51BQF7YpMa6BRVMo3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			int num3 = 0;
			while (true)
			{
				if (num3 < array.Length)
				{
					string value = array[num3];
					if (string_2.StartsWith(value, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num3++;
					continue;
				}
				return false;
			}
			return true;
		}
		}
	}

	internal static bool c1Z51BQF7YpMa6BRVMo3()
	{
		return Oa8UJ8QFC5wx1PoUAq61 == null;
	}
}
