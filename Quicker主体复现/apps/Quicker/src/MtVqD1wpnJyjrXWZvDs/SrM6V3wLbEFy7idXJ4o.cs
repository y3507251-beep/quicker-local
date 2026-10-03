using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using lyhcXTwzVI7YLubdxW3;
using p4gFtSwrNXntXvsJso6;
using Quicker.Common.Entities;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;

namespace MtVqD1wpnJyjrXWZvDs;

internal class SrM6V3wLbEFy7idXJ4o : NTdXwYwCQD062G5tRAm
{
	[CompilerGenerated]
	private readonly IDictionary<string, string> Di5tgRXyXQb = new Dictionary<string, string> { { "Repeat", "定时重复" } };

	private long I7stgqfCsQm;

	private IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> EQftgceQtov = new Dictionary<Guid, iwjxGgwa8FtkWhCNo7L>();

	private static SrM6V3wLbEFy7idXJ4o mfDdDtQWnFSu94Bleu6m;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return Di5tgRXyXQb;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField>
		{
			new FormField
			{
				FieldKey = "RepeatInternval",
				Label = "重复间隔",
				HelpText = "秒数。每隔此时间后触发一次事件。",
				DictVarType = VarType.Integer,
				IsRequired = true,
				InputMethod = InputMethod.NumberBox,
				DefaultValue = 0
			},
			gqmtg2SxfVB
		};
	}

	public SrM6V3wLbEFy7idXJ4o()
		: base(new string[1] { "Repeat" })
	{
	}

	protected override void wF2M2TOWlFs()
	{
		EQftgceQtov.Clear();
	}

	protected override void NsxM2ZRjpT5()
	{
		EQftgceQtov.Clear();
		I7stgqfCsQm = AppHelper.fLiLTj0x4QY();
	}

	protected override void dtIM2ouEUn0(long long_2)
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			int num = item.TryGetParamValue("RepeatInternval", 0);
			long num2 = long_2 - I7stgqfCsQm;
			if (EQftgceQtov.ContainsKey(item.Id))
			{
				int num3 = item.TryGetParamValue("MaxRepeatCount", 0);
				if ((num3 > 0 && EQftgceQtov[item.Id].Repeat >= num3) || long_2 - EQftgceQtov[item.Id].IBKtgVfyAon() < num * 1000)
				{
					continue;
				}
				EQftgceQtov[item.Id].HuRtgZvJyf0(long_2);
				EQftgceQtov[item.Id].Repeat++;
				iJ2tguv8HCS(item, null);
				if (ESo7wWQWex1dY6HD4K7I())
				{
					switch (0)
					{
					}
				}
			}
			else if (num2 >= num * 1000)
			{
				IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> eQftgceQtov = EQftgceQtov;
				Guid id = item.Id;
				iwjxGgwa8FtkWhCNo7L iwjxGgwa8FtkWhCNo7L = new iwjxGgwa8FtkWhCNo7L();
				iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(long_2);
				iwjxGgwa8FtkWhCNo7L.Repeat = 0;
				eQftgceQtov[id] = iwjxGgwa8FtkWhCNo7L;
				iJ2tguv8HCS(item, null);
			}
		}
	}

	internal static bool ESo7wWQWex1dY6HD4K7I()
	{
		return mfDdDtQWnFSu94Bleu6m == null;
	}
}
