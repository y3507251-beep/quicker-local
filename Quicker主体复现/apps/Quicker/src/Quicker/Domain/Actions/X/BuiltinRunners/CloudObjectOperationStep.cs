using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class CloudObjectOperationStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public ActionStep gexv3ZaqIk6;

		public ActionExecuteContext LHuv39WD0cu;

		public CloudObjectOperationStep WGCv3hr9RCE;

		internal static _003C_003Ec__DisplayClass49_0 kxnsldWDAyMZmmxqxFrL;

		internal (bool isSuccess, string message, ActionStopFlag failReason) uhcv3V3sc53()
		{
			string textParamValue = XActionHelper.GetTextParamValue(RfhtMCWa5oW, gexv3ZaqIk6, LHuv39WD0cu);
			string textParamValue2 = XActionHelper.GetTextParamValue(tS9tMPPmndg, gexv3ZaqIk6, LHuv39WD0cu);
			string textParamValue3 = XActionHelper.GetTextParamValue(M2gtME7xgN3, gexv3ZaqIk6, LHuv39WD0cu);
			string textParamValue4 = XActionHelper.GetTextParamValue(cJhtMabddDP, gexv3ZaqIk6, LHuv39WD0cu);
			double numberParamValue = XActionHelper.GetNumberParamValue(jhrtMqo9Pgu, gexv3ZaqIk6, LHuv39WD0cu);
			string textParamValue5 = XActionHelper.GetTextParamValue(k9dtMyrWLTj, gexv3ZaqIk6, LHuv39WD0cu);
			string textParamValue6 = XActionHelper.GetTextParamValue(mK3tM8deWFk, gexv3ZaqIk6, LHuv39WD0cu);
			switch (textParamValue)
			{
			case "upload_file":
				WGCv3hr9RCE.IdRtM2NMwma(textParamValue2, textParamValue5, textParamValue6, textParamValue3, textParamValue4, numberParamValue, gexv3ZaqIk6, LHuv39WD0cu);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool KSRiZNWDnN78ZSTOO6XF()
		{
			return kxnsldWDAyMZmmxqxFrL == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> QxZtMubLdLf = new List<string> { "aliyun", "阿里云", "对象存储" };

	[CompilerGenerated]
	private readonly string PrgtMNJImic = $"fa:{EFontAwesomeIcon.Light_Cloud}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> GXPtMJaB6MP;

	[CompilerGenerated]
	private readonly string fxTtM0XXkZx = "https://getquicker.net/KC/Help/Doc/cloudObjectOperation";

	private static readonly StepInParamDef RfhtMCWa5oW;

	private static readonly StepInParamDef tS9tMPPmndg;

	private static readonly StepInParamDef M2gtME7xgN3;

	private static readonly StepInParamDef k9dtMyrWLTj;

	private static readonly StepInParamDef mK3tM8deWFk;

	private static readonly StepInParamDef cJhtMabddDP;

	private static readonly StepInParamDef R3XtM7ffSsr;

	private static readonly StepInParamDef lwCtMRCy7JL;

	private static readonly StepInParamDef jhrtMqo9Pgu;

	private static readonly StepInParamDef wJ3tMcQSHM9;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> cnctMVuIufS = new List<StepInParamDef> { RfhtMCWa5oW, tS9tMPPmndg, M2gtME7xgN3, cJhtMabddDP, R3XtM7ffSsr, lwCtMRCy7JL, jhrtMqo9Pgu };

	private static readonly StepOutParamDef jeHtMZRaBJK;

	private static readonly StepOutParamDef rp5tM9pqnSR;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> GA4tMha6g0I = new List<StepOutParamDef> { jeHtMZRaBJK, rp5tM9pqnSR };

	private static CloudObjectOperationStep KoKq1bQiRGlm5kWiQqcT;

	public string Key => "sys:cloudObjectOperation";

	public string Name => "第三方云对象存储服务";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return QxZtMubLdLf;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return PrgtMNJImic;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return GXPtMJaB6MP;
		}
	}

	public string Description => "操作第三方云服务商的对象存储上传和下载文件。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return fxTtM0XXkZx;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return cnctMVuIufS;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return GA4tMha6g0I;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.gexv3ZaqIk6 = step;
		_003C_003Ec__DisplayClass49_.LHuv39WD0cu = context;
		_003C_003Ec__DisplayClass49_.WGCv3hr9RCE = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass49_.LHuv39WD0cu, _003C_003Ec__DisplayClass49_.gexv3ZaqIk6, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass49_.uhcv3V3sc53, (Action)null, (Action)null, wJ3tMcQSHM9, rp5tM9pqnSR);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(RfhtMCWa5oW, step);
	}

	private void IdRtM2NMwma(string string_2, string string_3, string string_4, string string_5, string string_6, double double_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(R3XtM7ffSsr, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue) || !System.IO.File.Exists(textParamValue))
		{
			throw new InvalidDataException("要上传的文件不存在。路径：" + textParamValue);
		}
	}

	private static HttpClient CreateClient(bool allowRedirect, double expireSeconds)
	{
		WebRequestHandler obj = new WebRequestHandler
		{
			CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.BypassCache),
			AllowAutoRedirect = allowRedirect
		};
		AppHelper.ApplyProxy(obj);
		obj.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		return new HttpClient(obj)
		{
			Timeout = TimeSpan.FromSeconds(expireSeconds)
		};
	}

	static CloudObjectOperationStep()
	{
		RfhtMCWa5oW = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			DefaultValue = "upload_file",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("upload_file", "上传文件"),
				new SelectionItem("upload_var", "上传变量内容"),
				new SelectionItem("delete", "删除对象")
			},
			IsControlField = true
		};
		tS9tMPPmndg = new StepInParamDef
		{
			Key = "vendor",
			Name = "服务商",
			Description = "",
			DefaultValue = "aliyun",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("aliyun", "阿里云")
			},
			IsControlField = false
		};
		M2gtME7xgN3 = new StepInParamDef
		{
			Key = "endpoint",
			Name = "Endpoint",
			Description = "存储目标区域网址",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		k9dtMyrWLTj = new StepInParamDef
		{
			Key = "accessKeyId",
			Name = "AccessKeyId",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		mK3tM8deWFk = new StepInParamDef
		{
			Key = "accessKeySecret",
			Name = "AccessKeySecret",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		cJhtMabddDP = new StepInParamDef
		{
			Key = "objectKey",
			Name = "Key",
			Description = "存储对象的Key。可以不填写（自动生成key），或填写以/结尾的前缀。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		R3XtM7ffSsr = new StepInParamDef
		{
			Key = "content",
			Name = "上传内容",
			Type = VarType.Any,
			Description = "要上传到对象存储的内容。如果为路径则上传文件。",
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		lwCtMRCy7JL = new StepInParamDef
		{
			Key = "extraHeaders",
			Name = "附加的Http头",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input
		};
		jhrtMqo9Pgu = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时时间",
			Description = "请求超时时间（秒数）",
			Type = VarType.Number,
			DefaultValue = 100,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		wJ3tMcQSHM9 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		jeHtMZRaBJK = new StepOutParamDef
		{
			Key = "objectUrl",
			Name = "对象网址",
			Description = "对象存储后生成的网址",
			ValidForList = new List<string> { "upload_file", "upload_var" }
		};
		rp5tM9pqnSR = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool zd75LYQigOyYi0IRy2Fu()
	{
		return KoKq1bQiRGlm5kWiQqcT == null;
	}
}
