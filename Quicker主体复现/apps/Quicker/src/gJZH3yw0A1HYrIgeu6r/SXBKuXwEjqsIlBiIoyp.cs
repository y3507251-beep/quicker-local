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

namespace gJZH3yw0A1HYrIgeu6r;

internal class SXBKuXwEjqsIlBiIoyp : NTdXwYwCQD062G5tRAm
{
	[CompilerGenerated]
	private readonly IDictionary<string, string> eEQtth6ygZU = new Dictionary<string, string>
	{
		{ "IdleTimeExpire", "设备闲置超过一段时间" },
		{ "IdleEnd", "设备结束闲置" }
	};

	private IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> LUbtte3Nu7y = new Dictionary<Guid, iwjxGgwa8FtkWhCNo7L>();

	private long eotttYLC7s5;

	private long dtjttINewna;

	private long KVqttWwL2FD;

	internal static SXBKuXwEjqsIlBiIoyp qCOfdIQcdRnmYnBEf4Mh;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return eEQtth6ygZU;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		if (string_1 == "IdleTimeExpire")
		{
			return new List<FormField>
			{
				new FormField
				{
					FieldKey = "InputMethod",
					Label = "输入方式",
					HelpText = "",
					DictVarType = VarType.Enum,
					IsRequired = true,
					InputMethod = InputMethod.DropDown,
					DefaultValue = "ANY",
					SelectionItems = "键盘或鼠标|ANY\r\n键盘|KEYBOARD\r\n鼠标|MOUSE"
				},
				new FormField
				{
					FieldKey = "ExpireSeconds",
					Label = "空闲时长",
					HelpText = "秒数。没有鼠标或键盘输入超过指定的时间后触发事件。",
					DictVarType = VarType.Integer,
					IsRequired = true,
					InputMethod = InputMethod.NumberBox
				},
				new FormField
				{
					FieldKey = "RepeatInternval",
					Label = "重复间隔",
					HelpText = "秒数。如果仍然继续保持闲置，间隔多久自动重复触发事件。值为0时不重复。",
					DictVarType = VarType.Integer,
					IsRequired = true,
					InputMethod = InputMethod.NumberBox,
					DefaultValue = 0
				},
				gqmtg2SxfVB
			};
		}
		if (!(string_1 == "IdleEnd"))
		{
			throw new Exception("不支持的事件类型：" + string_1);
		}
		return new List<FormField>
		{
			new FormField
			{
				FieldKey = "InputMethod",
				Label = "输入方式",
				HelpText = "",
				DictVarType = VarType.Enum,
				IsRequired = true,
				InputMethod = InputMethod.DropDown,
				DefaultValue = "ANY",
				SelectionItems = "键盘或鼠标|ANY\r\n键盘|KEYBOARD\r\n鼠标|MOUSE"
			},
			new FormField
			{
				FieldKey = "ExpireSeconds",
				Label = "最短空闲时长",
				HelpText = "秒数。闲置超过这个时间后使用电脑时触发。",
				DictVarType = VarType.Integer,
				IsRequired = true,
				InputMethod = InputMethod.NumberBox,
				DefaultValue = 600
			}
		};
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		if (string_1 == "IdleTimeExpire")
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
					Desc = "空闲时长（秒）",
					Type = VarType.Integer
				}
			};
		}
		if (!(string_1 == "IdleEnd"))
		{
			throw new Exception("不支持的事件类型：" + string_1);
		}
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "Seconds",
				Desc = "空闲时长（秒）",
				Type = VarType.Integer
			}
		};
	}

	public SXBKuXwEjqsIlBiIoyp()
		: base(new string[2] { "IdleTimeExpire", "IdleEnd" })
	{
	}

	protected override void wF2M2TOWlFs()
	{
		LUbtte3Nu7y.Clear();
	}

	protected override void NsxM2ZRjpT5()
	{
		LUbtte3Nu7y.Clear();
	}

	protected override void dtIM2ouEUn0(long long_4)
	{
		try
		{
			foreach (CommonTriggerTask item in jpqtg8Grl0b)
			{
				if (item.EventType == "IdleTimeExpire")
				{
					VZlttZn2UoR(long_4, item);
				}
				else if (item.EventType == "IdleEnd")
				{
					Ru1ttVYr4FJ(long_4, item);
				}
			}
		}
		finally
		{
			eotttYLC7s5 = AppState.LastKeyboardInputTime;
			dtjttINewna = AppState.LastMouseInputTime;
			KVqttWwL2FD = AppState.LastInputTime;
		}
	}

	private void Ru1ttVYr4FJ(long long_4, CommonTriggerTask commonTriggerTask_0)
	{
		if (KVqttWwL2FD == 0L || KVqttWwL2FD == AppState.LastInputTime)
		{
			return;
		}
		int num = commonTriggerTask_0.TryGetParamValue("ExpireSeconds", 600);
		long num2 = 0L;
		string text = commonTriggerTask_0.TryGetParamValue("InputMethod", "ANY");
		if (!(text == "KEYBOARD"))
		{
			num2 = ((text == "MOUSE") ? ((AppState.LastMouseInputTime - dtjttINewna) / 1000L) : ((AppState.LastInputTime - KVqttWwL2FD) / 1000L));
		}
		else
		{
			num2 = (AppState.LastKeyboardInputTime - eotttYLC7s5) / 1000L;
			int num3 = 0;
			if (qCOfdIQcdRnmYnBEf4Mh != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		if (num2 >= num)
		{
			Dictionary<string, object> idictionary_ = new Dictionary<string, object> { { "Seconds", num2 } };
			iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
		}
	}

	private void VZlttZn2UoR(long long_4, CommonTriggerTask commonTriggerTask_0)
	{
        long num4 = default;
		int num = commonTriggerTask_0.TryGetParamValue("ExpireSeconds", 0);
		long num2 = AppState.LastInputTime;
		string text = commonTriggerTask_0.TryGetParamValue("InputMethod", "ANY");
		int num3;
		if (!(text == "KEYBOARD"))
		{
			num3 = 1;
			if (qCOfdIQcdRnmYnBEf4Mh != null)
			{
				goto IL_008e;
			}
			goto IL_0092;
		}
		num2 = AppState.LastKeyboardInputTime;
		goto IL_00b9;
		IL_00b9:
		num4 = long_4 - num2;
		if (!LUbtte3Nu7y.ContainsKey(commonTriggerTask_0.Id))
		{
			if (num4 >= num * 1000)
			{
				IDictionary<Guid, iwjxGgwa8FtkWhCNo7L> lUbtte3Nu7y = LUbtte3Nu7y;
				Guid id = commonTriggerTask_0.Id;
				iwjxGgwa8FtkWhCNo7L iwjxGgwa8FtkWhCNo7L = new iwjxGgwa8FtkWhCNo7L();
				iwjxGgwa8FtkWhCNo7L.HuRtgZvJyf0(long_4);
				iwjxGgwa8FtkWhCNo7L.Repeat = 0;
				lUbtte3Nu7y[id] = iwjxGgwa8FtkWhCNo7L;
				num3 = 0;
				if (!bbRXrgQcOk63Io1vH03G())
				{
					goto IL_008e;
				}
				goto IL_0092;
			}
			return;
		}
		if (num4 < num * 1000)
		{
			LUbtte3Nu7y.Remove(commonTriggerTask_0.Id);
			return;
		}
		int num5 = commonTriggerTask_0.TryGetParamValue("MaxRepeatCount", 0);
		if (num5 <= 0 || LUbtte3Nu7y[commonTriggerTask_0.Id].Repeat < num5)
		{
			int num6 = commonTriggerTask_0.TryGetParamValue("RepeatInternval", 0);
			if (num6 > 0 && long_4 - LUbtte3Nu7y[commonTriggerTask_0.Id].IBKtgVfyAon() >= num6 * 1000)
			{
				LUbtte3Nu7y[commonTriggerTask_0.Id].HuRtgZvJyf0(long_4);
				LUbtte3Nu7y[commonTriggerTask_0.Id].Repeat++;
				XPvtt9fYkfu(commonTriggerTask_0, num4);
			}
		}
		return;
		IL_0092:
		switch (num3)
		{
		case 1:
			break;
		default:
			XPvtt9fYkfu(commonTriggerTask_0, num4);
			return;
		}
		if (text == "MOUSE")
		{
			num2 = AppState.LastMouseInputTime;
		}
		goto IL_00b9;
		IL_008e:
		int num7 = default(int);
		num3 = num7;
		goto IL_0092;
	}

	private void XPvtt9fYkfu(CommonTriggerTask commonTriggerTask_0, long long_4)
	{
		Dictionary<string, object> idictionary_ = new Dictionary<string, object>
		{
			{
				"Repeat",
				LUbtte3Nu7y[commonTriggerTask_0.Id].Repeat
			},
			{
				"Seconds",
				long_4 / 1000L
			}
		};
		iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
	}

	internal static bool bbRXrgQcOk63Io1vH03G()
	{
		return qCOfdIQcdRnmYnBEf4Mh == null;
	}
}
