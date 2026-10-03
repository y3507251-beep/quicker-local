using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class JsonExtractStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public ActionStep sjaSNyIteSp;

		public ActionExecuteContext T0rSN8FQppV;

		public JsonExtractStep HpHSNao9u3r;

		public XAction n5ySN72MHWa;

		internal static _003C_003Ec__DisplayClass44_0 DmfjPLWBIxF2JZfpkCAT;

		internal (bool isSuccess, string message, ActionStopFlag failReason) CNdSNEFbIYQ()
		{
			object paramValue = XActionHelper.GetParamValue(t2jg2Qub7Rt, sjaSNyIteSp, T0rSN8FQppV, false, true);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(aodg2jEII6g, sjaSNyIteSp, T0rSN8FQppV);
			if (paramValue == null)
			{
				return (isSuccess: false, message: "输入内容为空", failReason: ActionStopFlag.OperationFailed);
			}
			JToken jToken = null;
			if (paramValue is JToken)
			{
				jToken = paramValue as JToken;
			}
			else if (paramValue is string text)
			{
				if (string.IsNullOrEmpty(text))
				{
					string item = "JSON输入内容为空。";
					return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
				}
				try
				{
					jToken = HpHSNao9u3r.tykg26JCyRu(text, booleanParamValue);
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: "提取JSON失败，数据不合法。" + ex.Message, failReason: ActionStopFlag.OperationFailed);
				}
			}
			else
			{
				jToken = HpHSNao9u3r.tykg26JCyRu(Convert.ToString(VariableHelper.ConvertToType(VarType.Text, paramValue)), booleanParamValue);
			}
			if (jToken == null)
			{
				return (isSuccess: false, message: "输入内容为空", failReason: ActionStopFlag.OperationFailed);
			}
			XActionHelper.OutputResult(oWtg2DJpc6G, sjaSNyIteSp, T0rSN8FQppV, jToken, n5ySN72MHWa);
			_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_1
			{
				O1PSNcoUgAU = 0
			};
			while (_003C_003Ec__DisplayClass44_.O1PSNcoUgAU < 5)
			{
				string text2 = XActionHelper.GetTextParamValue(HpHSNao9u3r.InputParams.First(_003C_003Ec__DisplayClass44_.vFOSNRgoOEP), sjaSNyIteSp, T0rSN8FQppV);
				if (!string.IsNullOrEmpty(text2))
				{
					StepOutParamDef stepOutParamDef = HpHSNao9u3r.OutputParams.First(_003C_003Ec__DisplayClass44_.vAySNqmAaLW);
					if (XActionHelper.IsOutputParamSetted(stepOutParamDef.Key, sjaSNyIteSp))
					{
						try
						{
							if (text2.StartsWith("list:"))
							{
								text2 = text2.Substring("list:".Length);
								throw new InvalidDataException("使用组提取");
							}
							JToken jToken2 = jToken.SelectToken(text2);
							if (jToken2 == null)
							{
								XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, "", n5ySN72MHWa);
							}
							else
							{
								switch (jToken2.Type)
								{
								case JTokenType.Integer:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2.ToObject<long>(), n5ySN72MHWa);
									break;
								case JTokenType.Float:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2.ToObject<double>(), n5ySN72MHWa);
									break;
								case JTokenType.Boolean:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2.ToObject<bool>(), n5ySN72MHWa);
									break;
								default:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2, n5ySN72MHWa);
									break;
								case JTokenType.Comment:
								case JTokenType.String:
								case JTokenType.Uri:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2.ToObject<string>(), n5ySN72MHWa);
									break;
								case JTokenType.Date:
								case JTokenType.TimeSpan:
									XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, jToken2.ToObject<DateTime>(), n5ySN72MHWa);
									break;
								}
							}
						}
						catch (Exception ex2)
						{
							try
							{
								IEnumerable<JToken> result = jToken.SelectTokens(text2);
								XActionHelper.OutputResult(stepOutParamDef, sjaSNyIteSp, T0rSN8FQppV, result, n5ySN72MHWa);
							}
							catch
							{
								string item2 = "JSON提取 " + text2 + " 失败。" + ex2.Message;
								return (isSuccess: false, message: item2, failReason: ActionStopFlag.OperationFailed);
							}
						}
					}
				}
				_003C_003Ec__DisplayClass44_.O1PSNcoUgAU++;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool jKhTsZWB6IOYFZ9fqJe4()
		{
			return DmfjPLWBIxF2JZfpkCAT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_1
	{
		public int O1PSNcoUgAU;

		internal static _003C_003Ec__DisplayClass44_1 FDt9DIWBSHr6qRqEWP8S;

		internal bool vFOSNRgoOEP(StepInParamDef x)
		{
			return x.Key == "p" + O1PSNcoUgAU;
		}

		internal bool vAySNqmAaLW(StepOutParamDef x)
		{
			return x.Key == "v" + O1PSNcoUgAU;
		}

		internal static bool wxca7oWBw8QmhMqqG939()
		{
			return FDt9DIWBSHr6qRqEWP8S == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> QyDg2K88usG;

	[CompilerGenerated]
	private readonly string ro0g2xi5vo3 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> X7Ng2rZQ9Xf;

	[CompilerGenerated]
	private readonly string tPwg2p11byE = "https://getquicker.net/KC/Help/Doc/jsonExtract";

	[CompilerGenerated]
	private readonly bool qB4g2BGuqG6;

	public const int MAX_EXTRACT_COUNT = 5;

	private static readonly StepInParamDef t2jg2Qub7Rt;

	private static readonly StepInParamDef aodg2jEII6g;

	private static readonly StepInParamDef SKRg2n2O2GB;

	private static readonly StepOutParamDef NtPg24pZXeD;

	[CompilerGenerated]
	private IList<StepInParamDef> OjZg25pL6x5;

	private static StepOutParamDef oWtg2DJpc6G;

	[CompilerGenerated]
	private IList<StepOutParamDef> gejg2dfH4Av;

	internal static JsonExtractStep kRXCjBQP3XOkq18s2JOP;

	public string Key => "sys:jsonExtract";

	public string Name => "提取JSON内容";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return QyDg2K88usG;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ro0g2xi5vo3;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return X7Ng2rZQ9Xf;
		}
	}

	public string Description => "提取Json文本中的信息";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return tPwg2p11byE;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return qB4g2BGuqG6;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return OjZg25pL6x5;
		}
		[CompilerGenerated]
		private set
		{
			OjZg25pL6x5 = value;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return gejg2dfH4Av;
		}
		[CompilerGenerated]
		private set
		{
			gejg2dfH4Av = value;
		}
	}

	public JsonExtractStep()
	{
		InputParams = new List<StepInParamDef> { t2jg2Qub7Rt };
		for (int i = 0; i < 5; i++)
		{
			StepInParamDef item = new StepInParamDef
			{
				Key = "p" + i,
				Name = "提取路径" + i,
				Description = "",
				Type = VarType.Text,
				VariableMode = ParamVariableMode.Input
			};
			InputParams.Add(item);
		}
		InputParams.Add(aodg2jEII6g);
		InputParams.Add(SKRg2n2O2GB);
		OutputParams = new List<StepOutParamDef> { NtPg24pZXeD };
		for (int j = 0; j < 5; j++)
		{
			StepOutParamDef item2 = new StepOutParamDef
			{
				Key = "v" + j,
				Name = "值" + j,
				Description = "提取到的内容，和提取路径对应",
				Type = VarType.Any
			};
			OutputParams.Add(item2);
		}
		OutputParams.Add(oWtg2DJpc6G);
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	private JToken tykg26JCyRu(string string_2, bool bool_1)
	{
		if (bool_1)
		{
			return JsonConvert.DeserializeObject<JToken>(string_2, new JsonSerializerSettings
			{
				DateParseHandling = DateParseHandling.None
			});
		}
		return JToken.Parse(string_2);
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.sjaSNyIteSp = step;
		_003C_003Ec__DisplayClass44_.T0rSN8FQppV = context;
		_003C_003Ec__DisplayClass44_.HpHSNao9u3r = this;
		_003C_003Ec__DisplayClass44_.n5ySN72MHWa = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass44_.T0rSN8FQppV, _003C_003Ec__DisplayClass44_.sjaSNyIteSp, _003C_003Ec__DisplayClass44_.n5ySN72MHWa, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass44_.CNdSNEFbIYQ, (Action)null, (Action)null, SKRg2n2O2GB, NtPg24pZXeD);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(t2jg2Qub7Rt, step) + " => " + XActionHelper.GetOutputParamDisplayString("v0", step) + " " + XActionHelper.GetOutputParamDisplayString("v1", step) + " " + XActionHelper.GetOutputParamDisplayString("v2", step) + "...";
	}

	static JsonExtractStep()
	{
		t2jg2Qub7Rt = new StepInParamDef
		{
			Key = "data",
			Name = "输入",
			Description = "要从中提取内容的Json文本或JToken对象",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		aodg2jEII6g = new StepInParamDef
		{
			Key = "dateAsString",
			Name = "日期时间按照文本处理",
			DefaultValue = false,
			Description = "保留原有数据格式",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		SKRg2n2O2GB = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NtPg24pZXeD = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否没有异常",
			Type = VarType.Boolean
		};
		oWtg2DJpc6G = new StepOutParamDef
		{
			Key = "rootToken",
			Name = "根对象",
			Description = "整个输入内容解析后获得的JToken对象。可用于后续使用。",
			Type = VarType.Object
		};
	}

	internal static bool yjCZZcQPEUetCFZvk50l()
	{
		return kRXCjBQP3XOkq18s2JOP == null;
	}

	internal static void GS6l0GQPKaSBvAft0tYF()
	{
	}
}
