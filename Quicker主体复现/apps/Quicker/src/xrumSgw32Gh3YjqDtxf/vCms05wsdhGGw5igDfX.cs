using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using lyhcXTwzVI7YLubdxW3;
using p4gFtSwrNXntXvsJso6;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;

namespace xrumSgw32Gh3YjqDtxf;

internal class vCms05wsdhGGw5igDfX : NTdXwYwCQD062G5tRAm
{
	[CompilerGenerated]
	private readonly IDictionary<string, string> juYttq84rOa = new Dictionary<string, string> { { "BusyTimeExpire", "设备连续使用超过一段时间" } };

	private IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> mAfttc3nhGk = new Dictionary<Guid, iwjxGgwa8FtkWhCNo7L>();

	private static vCms05wsdhGGw5igDfX dp9IPPQc0plUQLvuKwE2;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return juYttq84rOa;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField>
		{
			new FormField
			{
				FieldKey = "ExpireSeconds",
				Label = "连续使用时长",
				HelpText = "秒数。使用电脑超过指定的秒数时触发事件。",
				DictVarType = VarType.Integer,
				IsRequired = true,
				InputMethod = InputMethod.NumberBox,
				DefaultValue = 1800
			},
			new FormField
			{
				FieldKey = "RepeatInternval",
				Label = "重复间隔",
				HelpText = "秒数。如果仍然继续使用电脑，间隔多久自动重复触发事件。值为0时不重复。",
				DictVarType = VarType.Integer,
				IsRequired = true,
				InputMethod = InputMethod.NumberBox,
				DefaultValue = 0
			},
			new FormField
			{
				FieldKey = "IdelResetSeconds",
				Label = "空闲重置时间",
				HelpText = "秒数。空闲多久后使用电脑时开始重新计时。",
				DictVarType = VarType.Integer,
				IsRequired = true,
				InputMethod = InputMethod.NumberBox,
				DefaultValue = 30
			},
			gqmtg2SxfVB
		};
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "Repeat",
				Desc = "重复次数",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "Seconds",
				Desc = "连续使用时长（秒）",
				Type = VarType.Integer
			}
		};
	}

	public vCms05wsdhGGw5igDfX()
		: base(new string[1] { "BusyTimeExpire" })
	{
	}

	protected override void wF2M2TOWlFs()
	{
	}

	protected override void NsxM2ZRjpT5()
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (!mAfttc3nhGk.ContainsKey(item.Id))
			{
				IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> dictionary = mAfttc3nhGk;
				Guid id = item.Id;
				iwjxGgwa8FtkWhCNo7L iwjxGgwa8FtkWhCNo7L = new iwjxGgwa8FtkWhCNo7L();
				iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(AppHelper.fLiLTj0x4QY());
				dictionary.Add(id, iwjxGgwa8FtkWhCNo7L);
			}
		}
	}

	protected override void dtIM2ouEUn0(long long_1)
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (!mAfttc3nhGk.ContainsKey(item.Id))
			{
				IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> dictionary = mAfttc3nhGk;
				Guid id = item.Id;
				iwjxGgwa8FtkWhCNo7L iwjxGgwa8FtkWhCNo7L = new iwjxGgwa8FtkWhCNo7L();
				iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(AppHelper.fLiLTj0x4QY());
				dictionary.Add(id, iwjxGgwa8FtkWhCNo7L);
			}
			else
			{
				WIYttRvb6WO(item, long_1);
			}
		}
	}

	private void WIYttRvb6WO(CommonTriggerTask commonTriggerTask_0, long long_1)
	{
		long num = long_1 - AppState.LastInputTime;
		int num2 = commonTriggerTask_0.TryGetParamValue("IdelResetSeconds", 30) * 1000;
		iwjxGgwa8FtkWhCNo7L iwjxGgwa8FtkWhCNo7L = mAfttc3nhGk[commonTriggerTask_0.Id];
		if (num > num2)
		{
			iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(long_1);
			int num3 = 0;
			if (!WCQQRmQc1FZ3axsYTnXO())
			{
				int num4 = default(int);
				num3 = num4;
			}
			while (true)
			{
				switch (num3)
				{
				case 1:
					return;
				}
				iwjxGgwa8FtkWhCNo7L.q61tgI26gs7(long_1);
				iwjxGgwa8FtkWhCNo7L.Repeat = 0;
				num3 = 1;
				if (dp9IPPQc0plUQLvuKwE2 == null)
				{
					return;
				}
			}
		}
		int num5 = ((iwjxGgwa8FtkWhCNo7L.Repeat == 0) ? commonTriggerTask_0.TryGetParamValue("ExpireSeconds", 0) : commonTriggerTask_0.TryGetParamValue("RepeatInternval", 0));
		if (num5 <= 0 || long_1 - iwjxGgwa8FtkWhCNo7L.IBKtgVfyAon() < num5 * 1000)
		{
			return;
		}
		if (iwjxGgwa8FtkWhCNo7L.Repeat > 0)
		{
			int num6 = commonTriggerTask_0.TryGetParamValue("MaxRepeatCount", 0);
			if ((num6 > 0 && iwjxGgwa8FtkWhCNo7L.Repeat >= num6) || num > num5 * 1000)
			{
				return;
			}
		}
		iwjxGgwa8FtkWhCNo7L.Repeat++;
		iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(long_1);
		Dictionary<string, object> idictionary_ = new Dictionary<string, object>
		{
			{ "Repeat", iwjxGgwa8FtkWhCNo7L.Repeat },
			{
				"Seconds",
				(long_1 - iwjxGgwa8FtkWhCNo7L.iMAtgYmtDyR()) / 1000L
			}
		};
		iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
	}

	internal static bool WCQQRmQc1FZ3axsYTnXO()
	{
		return dp9IPPQc0plUQLvuKwE2 == null;
	}
}
