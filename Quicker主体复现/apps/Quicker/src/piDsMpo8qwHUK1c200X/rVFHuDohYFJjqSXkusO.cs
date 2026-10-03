using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using FontAwesome5;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Enums;
using Quicker.Common.Services.Trans;
using Quicker.Common.Vm;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace piDsMpo8qwHUK1c200X;

internal class rVFHuDohYFJjqSXkusO : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep gcGSk5vfjMQ;

		public ActionExecuteContext zHjSkDPbALe;

		public rVFHuDohYFJjqSXkusO oghSkdaweGQ;

		public XAction iSDSkolDdAp;

		private static _003C_003Ec__DisplayClass50_0 igNGsqWf6JB1uomqeFEa;

		internal (bool isSuccess, string message, ActionStopFlag failReason) FYCSk4h88nB()
		{
			string textParamValue = XActionHelper.GetTextParamValue(AGug62EoVKg, gcGSk5vfjMQ, zHjSkDPbALe);
			string textParamValue2 = XActionHelper.GetTextParamValue(L3pg6uWBliB, gcGSk5vfjMQ, zHjSkDPbALe);
			if (string.IsNullOrEmpty(textParamValue2))
			{
				return (isSuccess: false, message: "要翻译的内容为空", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue3 = XActionHelper.GetTextParamValue(FG6g6Ng2WQB, gcGSk5vfjMQ, zHjSkDPbALe);
			string textParamValue4 = XActionHelper.GetTextParamValue(xXjg6JqCvdm, gcGSk5vfjMQ, zHjSkDPbALe);
			return textParamValue switch
			{
				"en2zh_dict" => oghSkdaweGQ.cAegbimTrgO(textParamValue2, gcGSk5vfjMQ, zHjSkDPbALe, iSDSkolDdAp), 
				"multiple" => oghSkdaweGQ.Ou7gb36MIg4(textParamValue2, textParamValue3, textParamValue4, gcGSk5vfjMQ, zHjSkDPbALe, iSDSkolDdAp), 
				"single" => oghSkdaweGQ.iCPgbf92pty(textParamValue2, textParamValue3, textParamValue4, gcGSk5vfjMQ, zHjSkDPbALe, iSDSkolDdAp), 
				_ => (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed), 
			};
		}

		internal static bool oPyZ3JWftVCrBiEHQjFn()
		{
			return igNGsqWf6JB1uomqeFEa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass52_0
	{
		public string TLWSkMRljfH;

		private static _003C_003Ec__DisplayClass52_0 CZmyRjWfwYrgmVd3Zp9o;

		internal bool vecSkTUtuFD(KeyValuePair<string, string> x)
		{
			return string.Equals(x.Key, TLWSkMRljfH, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool RAHQAsWfTsAak7u799yr()
		{
			return CZmyRjWfwYrgmVd3Zp9o == null;
		}
	}

	[CompilerGenerated]
	private IEnumerable<string> ceYg6wRxA6f = new string[2] { "translation", "fy" };

	[CompilerGenerated]
	private readonly string GiWg6t8LLsU = $"fa:{EFontAwesomeIcon.Light_Language}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Llug6ghBi4w = new StepRunnerCategory[1] { StepRunnerCategory.Text };

	[CompilerGenerated]
	private readonly string hDeg6LfMN2a = "https://getquicker.net/KC/Help/Doc/translation";

	private static IList<SelectionItem> GC9g6vNi74O;

	private static IList<SelectionItem> t1Zg6S1lqIP;

	private static readonly StepInParamDef AGug62EoVKg;

	private static readonly StepInParamDef L3pg6uWBliB;

	private static readonly StepInParamDef FG6g6Ng2WQB;

	private static readonly StepInParamDef xXjg6JqCvdm;

	private static readonly StepInParamDef b2rg602FGR0;

	private static readonly StepInParamDef a6wg6CAnOLn;

	private static readonly StepInParamDef cyng6PoGDLR;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> afrg6ETXrbu = new StepInParamDef[7] { AGug62EoVKg, L3pg6uWBliB, FG6g6Ng2WQB, xXjg6JqCvdm, b2rg602FGR0, a6wg6CAnOLn, cyng6PoGDLR };

	private static readonly StepOutParamDef ekkg6y5APUO;

	private static readonly StepOutParamDef ynYg68KVMuS;

	private static readonly StepOutParamDef UJWg6aDnxOp;

	private static readonly StepOutParamDef WsNg67I3vnZ;

	private static readonly StepOutParamDef FpSg6RsrVfA;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> y1tg6qhagCm = new StepOutParamDef[5] { ynYg68KVMuS, UJWg6aDnxOp, WsNg67I3vnZ, FpSg6RsrVfA, ekkg6y5APUO };

	private static rVFHuDohYFJjqSXkusO VlLUK9QCqJjD3om9Qom2;

	public string Key => "sys:translation";

	public string Name => "机器翻译/词典";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return ceYg6wRxA6f;
		}
		[CompilerGenerated]
		set
		{
			ceYg6wRxA6f = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GiWg6t8LLsU;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Llug6ghBi4w;
		}
	}

	public string Description => "调用第三方服务翻译文字到指定的语言。此功能需要单独付费使用，详情请参考文档。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return hDeg6LfMN2a;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return afrg6ETXrbu;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return y1tg6qhagCm;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.gcGSk5vfjMQ = step;
		_003C_003Ec__DisplayClass50_.zHjSkDPbALe = context;
		_003C_003Ec__DisplayClass50_.oghSkdaweGQ = this;
		_003C_003Ec__DisplayClass50_.iSDSkolDdAp = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.zHjSkDPbALe, _003C_003Ec__DisplayClass50_.gcGSk5vfjMQ, _003C_003Ec__DisplayClass50_.iSDSkolDdAp, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.FYCSk4h88nB, (Action)null, (Action)null, cyng6PoGDLR, ekkg6y5APUO);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) cAegbimTrgO(string string_2, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		return (false, "原厂在线词典及翻译代理已删除，请改用本地词典或自行配置的翻译服务。", ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Ou7gb36MIg4(string string_2, string string_3, string string_4, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		return (false, "原厂在线词典及翻译代理已删除，请改用本地词典或自行配置的翻译服务。", ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) iCPgbf92pty(string string_2, string string_3, string string_4, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		return (false, "原厂在线词典及翻译代理已删除，请改用本地词典或自行配置的翻译服务。", ActionStopFlag.OperationFailed);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(AGug62EoVKg, step) + " => " + XActionHelper.GetOutputParamDisplayString(ynYg68KVMuS, step);
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static rVFHuDohYFJjqSXkusO()
	{
		GC9g6vNi74O = new SelectionItem[5]
		{
			new SelectionItem(CommonLanguage.Auto.ToString(), "自动"),
			new SelectionItem(CommonLanguage.ZhCn.ToString(), "简体中文"),
			new SelectionItem(CommonLanguage.En.ToString(), "英文"),
			new SelectionItem(CommonLanguage.Ja.ToString(), "日文"),
			new SelectionItem(CommonLanguage.Ko.ToString(), "韩文")
		};
		t1Zg6S1lqIP = new SelectionItem[9]
		{
			new SelectionItem(Vendors.Quicker.ToString(), "Quicker服务"),
			new SelectionItem(Vendors.Aliyun.ToString(), "阿里云"),
			new SelectionItem(Vendors.Baidu.ToString(), "百度"),
			new SelectionItem(Vendors.Tencent.ToString(), "腾讯云"),
			new SelectionItem(Vendors.Youdao.ToString(), "网易有道"),
			new SelectionItem(Vendors.Caiyun.ToString(), "彩云"),
			new SelectionItem(Vendors.Xunfei.ToString(), "讯飞"),
			new SelectionItem(Vendors.XunfeiNiutrans.ToString(), "讯飞(2代)"),
			new SelectionItem(Vendors.Google.ToString(), "谷歌")
		};
		AGug62EoVKg = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "single",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("single", "单厂商文字翻译"),
				new SelectionItem("multiple", "多厂商文字翻译"),
				new SelectionItem("en2zh_dict", "英汉词典")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		L3pg6uWBliB = new StepInParamDef
		{
			Key = "text",
			Name = "待翻译文本内容或单词。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		FG6g6Ng2WQB = new StepInParamDef
		{
			Key = "srcLang",
			Name = "源语言",
			Description = "待翻译内容的语言",
			DefaultValue = CommonLanguage.Auto.ToString(),
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = GC9g6vNi74O,
			InvalidForList = new List<string> { "en2zh_dict" }
		};
		xXjg6JqCvdm = new StepInParamDef
		{
			Key = "dstLang",
			Name = "目标语言",
			Description = "翻译的结果语言",
			DefaultValue = CommonLanguage.Auto.ToString(),
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = GC9g6vNi74O,
			InvalidForList = new List<string> { "en2zh_dict" }
		};
		b2rg602FGR0 = new StepInParamDef
		{
			Key = "vendor",
			Name = "厂商",
			Description = "不同厂商价格不同，详情请参考文档。",
			Type = VarType.Enum,
			DefaultValue = Vendors.Youdao.ToString(),
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = t1Zg6S1lqIP,
			ValidForList = new string[1] { "single" }
		};
		a6wg6CAnOLn = new StepInParamDef
		{
			Key = "vendorList",
			Name = "厂商列表",
			Description = "用逗号分割的厂商标识，详细信息请参考文档。",
			Type = VarType.Enum,
			DefaultValue = "Youdao,Baidu,Tencent,Caiyun",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "multiple" }
		};
		cyng6PoGDLR = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ekkg6y5APUO = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		ynYg68KVMuS = new StepOutParamDef
		{
			Key = "resultText",
			Name = "结果文本",
			Description = "翻译结果文本。多厂商翻译时自动组合各厂商结果",
			Type = VarType.Text
		};
		UJWg6aDnxOp = new StepOutParamDef
		{
			Key = "rawData",
			Name = "原始响应",
			Description = "厂商接口返回的原始内容，通常为json格式。",
			Type = VarType.Text,
			ValidForList = new string[2] { "single", "en2zh_dict" }
		};
		WsNg67I3vnZ = new StepOutParamDef
		{
			Key = "vendorResult",
			Name = "各厂商翻译结果",
			Description = "各厂商的翻译结果（词典）。key为厂商标识，value为翻译结果。",
			Type = VarType.Dict,
			ValidForList = new string[1] { "multiple" }
		};
		FpSg6RsrVfA = new StepOutParamDef
		{
			Key = "vendorRawData",
			Name = "各厂商原始响应",
			Description = "各厂商的原始响应内容（词典）。key为厂商标识，value为厂商原始响应。",
			Type = VarType.Dict,
			ValidForList = new string[1] { "multiple" }
		};
	}

	internal static bool WUx2F2QCiXpFsK5CMRTa()
	{
		return VlLUK9QCqJjD3om9Qom2 == null;
	}

	internal static void P009wRQCZDMYYEU4AT00()
	{
	}
}
