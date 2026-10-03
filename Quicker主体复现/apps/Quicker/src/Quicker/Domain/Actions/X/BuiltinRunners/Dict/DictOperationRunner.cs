using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Dict;

public class DictOperationRunner : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec YCAS2NOqtS6;

		public static Func<object, string> NOAS2JPqOi3;

		public static Func<KeyValuePair<string, object>, string> J90S20wousb;

		public static Func<KeyValuePair<string, object>, object> nQ6S2CKVqQB;

		private static _003C_003Ec hTHRNbWKDBSsftucVMHh;

		static _003C_003Ec()
		{
			YCAS2NOqtS6 = new _003C_003Ec();
		}

		internal string EdRS2SAnmAf(object x)
		{
			return x.ToString();
		}

		internal string eEiS22C8ZhG(KeyValuePair<string, object> x)
		{
			return x.Value?.ToString();
		}

		internal object WbgS2uXGCxR(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal static bool nVMupWWK3tFK2bF2Igj2()
		{
			return hTHRNbWKDBSsftucVMHh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public ActionStep B0nS2E4gTHQ;

		public ActionExecuteContext DOaS2ye5JHF;

		public DictOperationRunner qLvS28BKZ5x;

		public XAction CZmS2aMI34g;

		internal static _003C_003Ec__DisplayClass58_0 XjpZLgWKGrGZ7SG1mwAO;

		internal (bool isSuccess, string message, ActionStopFlag failReason) P7xS2PTMXFx()
		{
			_003C_003Ec__DisplayClass58_1 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_1();
			string textParamValue = XActionHelper.GetTextParamValue(QDsgvpyWwWJ, B0nS2E4gTHQ, DOaS2ye5JHF);
			_003C_003Ec__DisplayClass58_.lAvS2RDDG6f = XActionHelper.GetDictParamValue(RlcgvrukySk, B0nS2E4gTHQ, DOaS2ye5JHF);
			if (_003C_003Ec__DisplayClass58_.lAvS2RDDG6f == null && !textParamValue.ContainedInAny(RlcgvrukySk.InvalidForList.ToArray()))
			{
				return (isSuccess: false, message: "输入的数据不是词典。", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(FZugvQuTB8y, B0nS2E4gTHQ, DOaS2ye5JHF);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(kTSgvn2bKC3, B0nS2E4gTHQ, DOaS2ye5JHF);
			switch (textParamValue)
			{
			case "setOriginValue":
			{
				string textParamValue6 = XActionHelper.GetTextParamValue(HjBgvBb5rOC, B0nS2E4gTHQ, DOaS2ye5JHF);
				object paramValue = XActionHelper.GetParamValue(FZugvQuTB8y, B0nS2E4gTHQ, DOaS2ye5JHF, true, true);
				qLvS28BKZ5x.SetValue(_003C_003Ec__DisplayClass58_.lAvS2RDDG6f, textParamValue6, paramValue, booleanParamValue);
				goto IL_04bd;
			}
			case "set":
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(HjBgvBb5rOC, B0nS2E4gTHQ, DOaS2ye5JHF);
				qLvS28BKZ5x.SetValue(_003C_003Ec__DisplayClass58_.lAvS2RDDG6f, textParamValue4, textParamValue2, booleanParamValue);
				goto IL_04bd;
			}
			case "get":
			{
				string textParamValue5 = XActionHelper.GetTextParamValue(HjBgvBb5rOC, B0nS2E4gTHQ, DOaS2ye5JHF);
				var (flag, result2) = qLvS28BKZ5x.jOsgvHoMmiF(_003C_003Ec__DisplayClass58_.lAvS2RDDG6f, textParamValue5, booleanParamValue);
				XActionHelper.OutputResult(LT0gvdB2bwh, B0nS2E4gTHQ, DOaS2ye5JHF, result2, CZmS2aMI34g);
				if (!flag)
				{
					if (!XActionHelper.GetBooleanParamValue(kcNgv4wSRyP, B0nS2E4gTHQ, DOaS2ye5JHF))
					{
						throw new Exception("键 " + textParamValue5 + " 不存在。");
					}
					DOaS2ye5JHF.ActionLogger.LogWarning("键" + textParamValue5 + "不存在，已返回空值。");
				}
				goto IL_04bd;
			}
			case "clear":
				_003C_003Ec__DisplayClass58_.lAvS2RDDG6f.Clear();
				goto IL_04bd;
			case "remove":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(HjBgvBb5rOC, B0nS2E4gTHQ, DOaS2ye5JHF);
				qLvS28BKZ5x.j1Tgv1pdb6u(_003C_003Ec__DisplayClass58_.lAvS2RDDG6f, textParamValue3, booleanParamValue);
				goto IL_04bd;
			}
			case "reverse":
			{
				Dictionary<string, object> result = _003C_003Ec__DisplayClass58_.lAvS2RDDG6f.ToDictionary(_003C_003Ec.J90S20wousb ?? (_003C_003Ec.J90S20wousb = _003C_003Ec.YCAS2NOqtS6.eEiS22C8ZhG), _003C_003Ec.nQ6S2CKVqQB ?? (_003C_003Ec.nQ6S2CKVqQB = _003C_003Ec.YCAS2NOqtS6.WbgS2uXGCxR));
				XActionHelper.OutputResult(LT0gvdB2bwh, B0nS2E4gTHQ, DOaS2ye5JHF, result, CZmS2aMI34g);
				goto IL_04bd;
			}
			case "keyList":
				XActionHelper.OutputResult(LT0gvdB2bwh, B0nS2E4gTHQ, DOaS2ye5JHF, _003C_003Ec__DisplayClass58_.lAvS2RDDG6f.Keys.ToList(), CZmS2aMI34g);
				goto IL_04bd;
			case "valueList":
				XActionHelper.OutputResult(LT0gvdB2bwh, B0nS2E4gTHQ, DOaS2ye5JHF, _003C_003Ec__DisplayClass58_.lAvS2RDDG6f.Values.Select(_003C_003Ec.NOAS2JPqOi3 ?? (_003C_003Ec.NOAS2JPqOi3 = _003C_003Ec.YCAS2NOqtS6.EdRS2SAnmAf)).ToList(), CZmS2aMI34g);
				goto IL_04bd;
			case "dictToQueryStringNoEncode":
				XActionHelper.OutputResultIfNeeded(LT0gvdB2bwh, _003C_003Ec__DisplayClass58_.BBOS27Y01f4, B0nS2E4gTHQ, DOaS2ye5JHF, CZmS2aMI34g);
				goto IL_04bd;
			case "queryStringToDict":
				qLvS28BKZ5x.aWVgvsCG99r(DOaS2ye5JHF, B0nS2E4gTHQ, CZmS2aMI34g);
				goto IL_04bd;
			case "dictToQueryString":
				qLvS28BKZ5x.OAEgvGpvwPM(_003C_003Ec__DisplayClass58_.lAvS2RDDG6f, DOaS2ye5JHF, B0nS2E4gTHQ, CZmS2aMI34g);
				goto IL_04bd;
			default:
				{
					string item = "不支持的词典操作类型，请升级Quicker版本：" + textParamValue;
					return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
				}
				IL_04bd:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool wZyjOPWK03aRjaU8F0g5()
		{
			return XjpZLgWKGrGZ7SG1mwAO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_1
	{
		public IDictionary<string, object> lAvS2RDDG6f;

		private static _003C_003Ec__DisplayClass58_1 U391qTWKK9sM4p4PH1hR;

		internal object BBOS27Y01f4()
		{
			return lAvS2RDDG6f.ToQueryString(false, false);
		}

		internal static void uYwAUgWKduOvdjenK6lF()
		{
		}

		internal static bool jIC9X9WKB5cyDPCl7QFZ()
		{
			return U391qTWKK9sM4p4PH1hR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_0
	{
		public IDictionary<string, object> RAeS2cTBo0I;

		private static _003C_003Ec__DisplayClass60_0 T4BydHWKOGN2AaZyZrwU;

		internal object iwwS2qsD4yr()
		{
			return RAeS2cTBo0I;
		}

		internal static bool oQf54jWKJhLRQwwmjep3()
		{
			return T4BydHWKOGN2AaZyZrwU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public string i30S2Z3Qrvm;

		private static _003C_003Ec__DisplayClass62_0 vnghFgWKafvtQl7SdYIL;

		internal bool bQ1S2VvbUfw(KeyValuePair<string, object> x)
		{
			return x.Key.Equals(i30S2Z3Qrvm, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool JIBbT4WKrupR0etDD7Xq()
		{
			return vnghFgWKafvtQl7SdYIL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		public string feKS2hU2RZl;

		internal static _003C_003Ec__DisplayClass63_0 edHTjNWK9vZOPrZbI4uh;

		internal bool aSsS29N2aXY(KeyValuePair<string, object> x)
		{
			return x.Key.Equals(feKS2hU2RZl, StringComparison.OrdinalIgnoreCase);
		}

		internal static void cwYFZoWKoxtR7RaipNuK()
		{
		}

		internal static bool PpyAnRWKLHsEjs62Ujqi()
		{
			return edHTjNWK9vZOPrZbI4uh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass64_0
	{
		public string uEHS2YgNQ3v;

		private static _003C_003Ec__DisplayClass64_0 MWe5OOWKf5t6aDhRbNKv;

		internal bool tYZS2eRdPYH(KeyValuePair<string, object> x)
		{
			return x.Key.Equals(uEHS2YgNQ3v, StringComparison.OrdinalIgnoreCase);
		}

		internal static void p20AYYWKiLo9RRyR6ukt()
		{
		}

		internal static bool LbuWk8WKbp8WGjmawFJs()
		{
			return MWe5OOWKf5t6aDhRbNKv == null;
		}
	}

	private static readonly ILog wGcgvbCo9uV;

	private static List<string> cTTgv6gx2X4;

	[CompilerGenerated]
	private readonly string l59gvXdDFFC = $"fa:{EFontAwesomeIcon.Light_Book}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> eNDgvmOWrdV;

	[CompilerGenerated]
	private readonly string COGgvKvQtNw = "https://getquicker.net/KC/Help/Doc/dictoperations";

	[CompilerGenerated]
	private readonly bool oCLgvxZKGb2;

	private static readonly StepInParamDef RlcgvrukySk;

	private static readonly StepInParamDef QDsgvpyWwWJ;

	private static readonly StepInParamDef HjBgvBb5rOC;

	private static readonly StepInParamDef FZugvQuTB8y;

	private static readonly StepInParamDef uBWgvj6kdJR;

	private static readonly StepInParamDef kTSgvn2bKC3;

	private static readonly StepInParamDef kcNgv4wSRyP;

	private static readonly StepInParamDef UlMgv5jXsJP;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> qfjgvDV12RB = new StepInParamDef[8] { QDsgvpyWwWJ, RlcgvrukySk, uBWgvj6kdJR, HjBgvBb5rOC, FZugvQuTB8y, kcNgv4wSRyP, kTSgvn2bKC3, UlMgv5jXsJP };

	private static readonly StepOutParamDef LT0gvdB2bwh;

	private static readonly StepOutParamDef QFCgvofH200;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> YkxgvTlbhgx = new StepOutParamDef[2] { QFCgvofH200, LT0gvdB2bwh };

	private static object HiGgvMREnCf;

	internal static DictOperationRunner BdUUprQgB8YoOKywihT9;

	public string Key => "sys:dictOperations";

	public string Name => "词典操作";

	public IEnumerable<string> KeyWords => cTTgv6gx2X4;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return l59gvXdDFFC;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return eNDgvmOWrdV;
		}
	}

	public string Description => "对词典变量进行添加、删除等操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return COGgvKvQtNw;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return oCLgvxZKGb2;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return qfjgvDV12RB;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return YkxgvTlbhgx;
		}
	}

	static DictOperationRunner()
	{
		wGcgvbCo9uV = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		cTTgv6gx2X4 = new List<string>();
		RlcgvrukySk = new StepInParamDef
		{
			Key = "dict",
			Name = "词典",
			Description = "要操作的词典变量",
			DefaultValue = null,
			Type = VarType.Dict,
			VariableMode = ParamVariableMode.UseVar,
			IsMultiLine = true,
			InvalidForList = new List<string> { "queryStringToDict" }
		};
		QDsgvpyWwWJ = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "setOriginValue",
			Type = VarType.Enum,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("get", "取值"),
				new SelectionItem("set", "设置值 (文本类型)"),
				new SelectionItem("setOriginValue", "设置值 (变量原始类型)"),
				new SelectionItem("remove", "删除一项"),
				new SelectionItem("clear", "清空"),
				new SelectionItem("keyList", "获取键(Key)列表"),
				new SelectionItem("valueList", "获取值列表"),
				new SelectionItem("reverse", "翻转键值"),
				new SelectionItem("queryStringToDict", "查询字符串转换为词典(name1=value1&name2=value2...)"),
				new SelectionItem("dictToQueryString", "词典转换为查询字符串"),
				new SelectionItem("dictToQueryStringNoEncode", "词典转换为查询字符串(不对键和值进行URL编码)")
			}
		};
		HjBgvBb5rOC = new StepInParamDef
		{
			Key = "key",
			Name = "键",
			Description = "要操作元素的键值。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[4] { "get", "set", "remove", "setOriginValue" }
		};
		FZugvQuTB8y = new StepInParamDef
		{
			Key = "value",
			Name = "值",
			Description = "要保存的内容",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "set", "setOriginValue" }
		};
		uBWgvj6kdJR = new StepInParamDef
		{
			Key = "queryString",
			Name = "查询字符串",
			Description = "要解析的查询字符串",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "queryStringToDict" }
		};
		kTSgvn2bKC3 = new StepInParamDef
		{
			Key = "ignoreCase",
			Name = "忽略键的大小写",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[4] { "set", "get", "remove", "setOriginValue" }
		};
		kcNgv4wSRyP = new StepInParamDef
		{
			Key = "returnEmptyIfKeyNotExist",
			Name = "键不存在时返回空值",
			DefaultValue = false,
			Description = "此时不作为失败处理",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "get" }
		};
		UlMgv5jXsJP = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = false,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		LT0gvdB2bwh = new StepOutParamDef
		{
			Key = "value",
			Name = "结果",
			Description = "操作后的输出（取的元素值、键列表、值列表等）",
			Type = VarType.Any,
			ValidForList = new string[7] { "get", "keyList", "valueList", "reverse", "queryStringToDict", "dictToQueryString", "dictToQueryStringNoEncode" }
		};
		QFCgvofH200 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		HiGgvMREnCf = new object();
		foreach (SelectionItem selectionItem in QDsgvpyWwWJ.SelectionItems)
		{
			cTTgv6gx2X4.Add(selectionItem.Name);
			cTTgv6gx2X4.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
		_003C_003Ec__DisplayClass58_.B0nS2E4gTHQ = step;
		_003C_003Ec__DisplayClass58_.DOaS2ye5JHF = context;
		_003C_003Ec__DisplayClass58_.qLvS28BKZ5x = this;
		_003C_003Ec__DisplayClass58_.CZmS2aMI34g = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass58_.DOaS2ye5JHF, _003C_003Ec__DisplayClass58_.B0nS2E4gTHQ, _003C_003Ec__DisplayClass58_.CZmS2aMI34g, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass58_.P7xS2PTMXFx, (Action)null, (Action)null, UlMgv5jXsJP, QFCgvofH200);
	}

	private void OAEgvGpvwPM(IDictionary<string, object> idictionary_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		XActionHelper.OutputResultIfNeeded(LT0gvdB2bwh, idictionary_0.ToQueryString<object>, actionStep_0, actionExecuteContext_0, xaction_0);
	}

	private void aWVgvsCG99r(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
		string textParamValue = XActionHelper.GetTextParamValue(uBWgvj6kdJR, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass60_.RAeS2cTBo0I = textParamValue.QueryStringToDict();
		XActionHelper.OutputResultIfNeeded(LT0gvdB2bwh, _003C_003Ec__DisplayClass60_.iwwS2qsD4yr, actionStep_0, actionExecuteContext_0, xaction_0);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(RlcgvrukySk, step) + " " + XActionHelper.GetParamDirectValue(QDsgvpyWwWJ, step) + " Key:" + XActionHelper.GetParamDirectValue(HjBgvBb5rOC, step);
	}

	private (bool, object) jOsgvHoMmiF(IDictionary<string, object> idictionary_0, string string_2, bool bool_1)
	{
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
		_003C_003Ec__DisplayClass62_.i30S2Z3Qrvm = string_2;
		if (bool_1)
		{
			KeyValuePair<string, object> keyValuePair = idictionary_0.FirstOrDefault(_003C_003Ec__DisplayClass62_.bQ1S2VvbUfw);
			if (keyValuePair.Equals(default(KeyValuePair<string, object>)))
			{
				wGcgvbCo9uV.Warn("键值不存在");
				return (false, null);
			}
			return (true, keyValuePair.Value);
		}
		if (idictionary_0.TryGetValue(_003C_003Ec__DisplayClass62_.i30S2Z3Qrvm, out var value))
		{
			return (true, value);
		}
		return (false, null);
	}

	private void SetValue(IDictionary<string, object> dict, string key, object value, bool ignoreCase)
	{
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		_003C_003Ec__DisplayClass63_.feKS2hU2RZl = key;
		lock (HiGgvMREnCf)
		{
			if (ignoreCase)
			{
				KeyValuePair<string, object> keyValuePair = dict.FirstOrDefault(_003C_003Ec__DisplayClass63_.aSsS29N2aXY);
				if (keyValuePair.Equals(default(KeyValuePair<string, object>)))
				{
					dict[_003C_003Ec__DisplayClass63_.feKS2hU2RZl] = value;
				}
				else
				{
					dict[keyValuePair.Key] = value;
				}
			}
			else
			{
				dict[_003C_003Ec__DisplayClass63_.feKS2hU2RZl] = value;
			}
		}
	}

	private void j1Tgv1pdb6u(IDictionary<string, object> idictionary_0, string string_2, bool bool_1)
	{
		_003C_003Ec__DisplayClass64_0 _003C_003Ec__DisplayClass64_ = new _003C_003Ec__DisplayClass64_0();
		_003C_003Ec__DisplayClass64_.uEHS2YgNQ3v = string_2;
		if (bool_1)
		{
			KeyValuePair<string, object> keyValuePair = idictionary_0.FirstOrDefault(_003C_003Ec__DisplayClass64_.tYZS2eRdPYH);
			if (!keyValuePair.Equals(default(KeyValuePair<string, object>)))
			{
				idictionary_0.Remove(keyValuePair.Key);
			}
		}
		else if (idictionary_0.ContainsKey(_003C_003Ec__DisplayClass64_.uEHS2YgNQ3v))
		{
			idictionary_0.Remove(_003C_003Ec__DisplayClass64_.uEHS2YgNQ3v);
		}
	}

	internal static void n6nJ8YQgOTdFHeYa08hx()
	{
	}

	internal static bool vVTJ1GQgv2liBp5u8Vns()
	{
		return BdUUprQgB8YoOKywihT9 == null;
	}
}
