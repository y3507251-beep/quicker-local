using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using CW;
using gNDpGkYZYbhLdMnAyKv;
using log4net;
using otp5BNwoOTeKCWhwo6K;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using YDnFyFwG4PlN0Cedwny;

namespace zNLRWkwFGSoZfhTlm4l;

internal class PH5f3QwVqH0eio5fc3A : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec mgOvIsnw0i7;

		public static Func<CommonTriggerTask, bool> CYwvIHonnQ0;

		public static Func<CommonTriggerTask, string> eDyvI1fAZap;

		public static Func<string, bool> lRLvIbveWXe;

		public static Func<string, bool> aXvvI6l0Rvm;

		internal static _003C_003Ec djyuVIcZ1J99ZKUNZcRS;

		static _003C_003Ec()
		{
			mgOvIsnw0i7 = new _003C_003Ec();
		}

		internal bool eLAvII37ZFb(CommonTriggerTask t)
		{
			return GFGFgbwXKocENyrCUx4.ibMflIV9C4(t.TryGetParamValue("ProcessName", ""), AppState.CurrentProcessName);
		}

		internal string avsvIWpV75v(CommonTriggerTask t)
		{
			string text = t.TryGetParamValue("ContentType", "ALL");
			if (text == "CUSTOM")
			{
				text = t.TryGetParamValue("CustomTypes", "");
			}
			return text;
		}

		internal bool n1WvIkKrkxW(string x)
		{
			return !x.IsNullOrEmpty();
		}

		internal bool T33vIGxfBUC(string x)
		{
			return x == "ALL";
		}

		internal static bool Lthc5pcZKXsqSDQnfwCZ()
		{
			return djyuVIcZ1J99ZKUNZcRS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public PH5f3QwVqH0eio5fc3A CTIvIKY1gOR;

		public List<CommonTriggerTask> mmfvIxuwvbF;

		public Action UATvIr2j95c;

		private static _003C_003Ec__DisplayClass24_0 iScdBHcZv5HutQ1sLwuH;

		internal void yfUvIX75BJw(object obj)
		{
			Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(UATvIr2j95c ?? (UATvIr2j95c = fnXvIm7Rdg9));
		}

		internal void fnXvIm7Rdg9()
		{
			CTIvIKY1gOR.YUdtwB6aKnB(mmfvIxuwvbF);
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}

		internal static bool AvgfwYcZdg4yul291a9S()
		{
			return iScdBHcZv5HutQ1sLwuH == null;
		}

		internal static void lOLF0JcZJXZF5CmhKWUK()
		{
		}
	}

	private static readonly ILog Yihtwn0anve;

	[CompilerGenerated]
	private readonly IDictionary<string, string> SeZtw4nT4yI = new Dictionary<string, string> { { "ClipboardChanged", "剪贴板内容改变" } };

	private FormField l0ptw5AiwsO = new FormField
	{
		FieldKey = "ProcessName",
		Label = "生效进程",
		DictVarType = VarType.Text,
		HelpText = "可选。关注的进程名称，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectProcessName"
	};

	private FormField jc3twDuWUnn = new FormField
	{
		FieldKey = "ContentType",
		Label = "内容类型",
		DictVarType = VarType.Enum,
		HelpText = "剪贴板变更后，并且包含指定内容类型时触发事件。",
		IsRequired = false,
		InputMethod = InputMethod.DropDown,
		SelectionItems = "*任意*|ALL\r\n文本|TEXT\r\nHTML|HTML\r\n图片|IMAGE\r\n文件|FILE\r\n自定义类型|CUSTOM"
	};

	private FormField Q7Ctwdqw6BK = new FormField
	{
		FieldKey = "CustomTypes",
		Label = "包含自定义类型",
		DictVarType = VarType.Text,
		HelpText = "剪贴板内容类型名称",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		VisibleExpression = "{ContentType} == \"CUSTOM\""
	};

	private FormField rjJtwo1d4FB = new FormField
	{
		FieldKey = "TextPattern",
		Label = "文本匹配表达式",
		DictVarType = VarType.Text,
		HelpText = "可选。剪贴板文本内容匹配特定正则表达式时才触发。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		VisibleExpression = "{ContentType} == \"TEXT\""
	};

	private FormField ACRtwTM9nfN = new FormField
	{
		FieldKey = "IgnoreQuickerGetSelected",
		Label = "忽略Quicker获取选中文本/文件引起的剪贴板变化",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField ikPtwMcsbuM = new FormField
	{
		FieldKey = "IgnoreQuickerPaste",
		Label = "忽略Quicker粘贴文本/文件引起的剪贴板变化",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private DebounceDispatcher GgjtwARa73Q;

	internal static PH5f3QwVqH0eio5fc3A SVjGoDQFH6M6S9EiordQ;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return SeZtw4nT4yI;
	}

	public PH5f3QwVqH0eio5fc3A()
		: base(new string[1] { "ClipboardChanged" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new FormField[6] { l0ptw5AiwsO, jc3twDuWUnn, Q7Ctwdqw6BK, rjJtwo1d4FB, ACRtwTM9nfN, ikPtwMcsbuM };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "cliptext",
				Desc = "剪贴板文本",
				Type = VarType.Text
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		Cfbtwr42wyl();
		GgjtwARa73Q = new DebounceDispatcher();
		ClipboardManager.Instance.ClipboardChanged += jAItwpLjogS;
	}

	private void Cfbtwr42wyl()
	{
		ClipboardManager.Instance.ClipboardChanged -= jAItwpLjogS;
		if (GgjtwARa73Q != null)
		{
			GgjtwARa73Q.Cancel();
			GgjtwARa73Q = null;
		}
	}

	protected override void C5rM2eDjuIN()
	{
		Cfbtwr42wyl();
	}

	private void jAItwpLjogS(object sender, EventArgs e)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.CTIvIKY1gOR = this;
		_003C_003Ec__DisplayClass24_.mmfvIxuwvbF = jpqtg8Grl0b.Where(_003C_003Ec.CYwvIHonnQ0 ?? (_003C_003Ec.CYwvIHonnQ0 = _003C_003Ec.mgOvIsnw0i7.eLAvII37ZFb)).ToList();
		if (_003C_003Ec__DisplayClass24_.mmfvIxuwvbF.Count != 0)
		{
			GgjtwARa73Q.Debounce(100, _003C_003Ec__DisplayClass24_.yfUvIX75BJw);
		}
	}

	private void YUdtwB6aKnB(List<CommonTriggerTask> list_0)
	{
		List<string> ilist_ = list_0.Select(_003C_003Ec.eDyvI1fAZap ?? (_003C_003Ec.eDyvI1fAZap = _003C_003Ec.mgOvIsnw0i7.avsvIWpV75v)).Distinct().Where(_003C_003Ec.lRLvIbveWXe ?? (_003C_003Ec.lRLvIbveWXe = _003C_003Ec.mgOvIsnw0i7.n1WvIkKrkxW))
			.ToList();
		try
		{
			if (!Uu6twQrxVvB(ilist_))
			{
				return;
			}
			IDataObject dataObject = kWsP1bYRVsfaicfjr67.tfwL5WeF6q7();
			if (dataObject == null)
			{
				Yihtwn0anve.Info("获得的剪贴板内容为空。");
				return;
			}
			string string_ = (dataObject.GetDataPresent(DataFormats.UnicodeText) ? ((dataObject.GetData(DataFormats.UnicodeText, true) as string) ?? "") : "");
			foreach (CommonTriggerTask item in jpqtg8Grl0b)
			{
				try
				{
					if (A13twjWnCQW(item, dataObject, string_) && item.SkipFurtherTasks)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					Yihtwn0anve.Warn("剪贴板监控触发任务时出错:" + ex.Message, ex);
				}
			}
		}
		catch (Exception ex2)
		{
			Yihtwn0anve.Warn("剪贴板监控触发任务时出错：" + ex2.Message, ex2);
		}
	}

	private bool Uu6twQrxVvB(IList<string> ilist_1)
	{
		if (ilist_1.Count != 0 && !ilist_1.Any(_003C_003Ec.aXvvI6l0Rvm ?? (_003C_003Ec.aXvvI6l0Rvm = _003C_003Ec.mgOvIsnw0i7.T33vIGxfBUC)))
		{
			foreach (string item in ilist_1)
			{
				switch (item)
				{
				default:
					if (!item.IsNullOrEmpty() && Clipboard.ContainsData(item))
					{
						return true;
					}
					break;
				case "FILE":
					if (Clipboard.ContainsFileDropList())
					{
						return true;
					}
					break;
				case "HTML":
					if (Clipboard.ContainsText(TextDataFormat.Html))
					{
						return true;
					}
					break;
				case "IMAGE":
					if (Clipboard.ContainsImage())
					{
						return true;
					}
					break;
				case "TEXT":
					if (Clipboard.ContainsText())
					{
						return true;
					}
					break;
				case "ALL":
					return true;
				}
			}
			return false;
		}
		return true;
	}

	private bool A13twjWnCQW(CommonTriggerTask commonTriggerTask_0, IDataObject idataObject_0, string string_1)
	{
		string text = commonTriggerTask_0.TryGetParamValue("ContentType", "ALL");
		Dictionary<string, object> idictionary_ = new Dictionary<string, object> { { "cliptext", string_1 } };
		int num;
		string text3 = default(string);
		if (commonTriggerTask_0.TryGetParamValue("IgnoreQuickerGetSelected", false) && AppHelper.fLiLTj0x4QY() - AppState.LastQuickerGetSelectedTime < 500L)
		{
			num = 0;
			if (SVjGoDQFH6M6S9EiordQ == null)
			{
				goto IL_0183;
			}
		}
		else
		{
			if (commonTriggerTask_0.TryGetParamValue("IgnoreQuickerPaste", false) && AppHelper.fLiLTj0x4QY() - AppState.LastQuickerPasteTime < 500L)
			{
				return false;
			}
			switch (text)
			{
			default:
			{
				string text2 = commonTriggerTask_0.TryGetParamValue("CustomTypes", "");
				if (!text2.IsNullOrEmpty() && idataObject_0.GetDataPresent(text2))
				{
					return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
				}
				goto IL_0125;
			}
			case "FILE":
				if (idataObject_0.GetDataPresent(DataFormats.FileDrop, true))
				{
					return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
				}
				goto IL_0125;
			case "HTML":
				if (idataObject_0.GetDataPresent(DataFormats.Html, true))
				{
					return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
				}
				goto IL_0125;
			case "IMAGE":
				if (idataObject_0.GetDataPresent(DataFormats.Bitmap, true))
				{
					return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
				}
				return false;
			case "TEXT":
				break;
			case "ALL":
				{
					return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
				}
				IL_0125:
				return false;
			}
			if (string.IsNullOrEmpty(string_1))
			{
				goto IL_01a2;
			}
			text3 = commonTriggerTask_0.TryGetParamValue("TextPattern", "");
			num = 1;
			if (SVjGoDQFH6M6S9EiordQ != null)
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_0185;
		}
		goto IL_0183;
		IL_01a2:
		return false;
		IL_0183:
		return false;
		IL_0185:
		if (text3.IsNullOrEmpty() || Regex.IsMatch(string_1, text3))
		{
			return iJ2tguv8HCS(commonTriggerTask_0, idictionary_);
		}
		goto IL_01a2;
	}

	static PH5f3QwVqH0eio5fc3A()
	{
		Yihtwn0anve = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool aIgeC5QFzghF4hKKmNRT()
	{
		return SVjGoDQFH6M6S9EiordQ == null;
	}
}
