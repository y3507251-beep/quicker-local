using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class CharInfoStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep wFMS2D7vdWs;

		public ActionExecuteContext SffS2dGtwlG;

		public XAction rFYS2oPwX3d;

		private static _003C_003Ec__DisplayClass41_0 UUI9fJWKIjDwlhWuO19S;

		internal (bool isSuccess, string message, ActionStopFlag failReason) b9nS25qYUvs()
		{
			_003C_003Ec__DisplayClass41_1 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_1
			{
				KBXS2FNJGht = XActionHelper.GetTextParamValue(daigSEW1RU8, wFMS2D7vdWs, SffS2dGtwlG)
			};
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass41_.KBXS2FNJGht))
			{
				return (isSuccess: false, message: "获取字符信息的参数为空！", failReason: ActionStopFlag.OperationFailed);
			}
			uint num = _003C_003Ec__DisplayClass41_.KBXS2FNJGht[0];
			XActionHelper.OutputResult(f8MgS83qxbp, wFMS2D7vdWs, SffS2dGtwlG, num, rFYS2oPwX3d);
			XActionHelper.OutputResult(f9BgSainMEE, wFMS2D7vdWs, SffS2dGtwlG, num.ToString("X", CultureInfo.InvariantCulture), rFYS2oPwX3d);
			XActionHelper.OutputResultIfNeeded(gmegS7oDDlm, _003C_003Ec__DisplayClass41_.W2hS2TdBw82, wFMS2D7vdWs, SffS2dGtwlG, rFYS2oPwX3d);
			XActionHelper.OutputResultIfNeeded(X9UgSRPZIb2, _003C_003Ec__DisplayClass41_.NPmS2MiQ15I, wFMS2D7vdWs, SffS2dGtwlG, rFYS2oPwX3d);
			XActionHelper.OutputResultIfNeeded(zsWgSqcRonf, _003C_003Ec__DisplayClass41_.ErIS2Avu07v, wFMS2D7vdWs, SffS2dGtwlG, rFYS2oPwX3d);
			XActionHelper.OutputResultIfNeeded(cuPgScfu93T, _003C_003Ec__DisplayClass41_.GKkS2O7Bhgq, wFMS2D7vdWs, SffS2dGtwlG, rFYS2oPwX3d);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool fbx5WUWK6eST8rspcZYh()
		{
			return UUI9fJWKIjDwlhWuO19S == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_1
	{
		public string KBXS2FNJGht;

		internal static _003C_003Ec__DisplayClass41_1 m8GJyEWKSGFO0A2pGkqS;

		internal object W2hS2TdBw82()
		{
			return XRlL56iKFaTMc4ji9eS.GmHvNpLOZ3b(KBXS2FNJGht[0]).ToUpper()[0].ToString();
		}

		internal object NPmS2MiQ15I()
		{
			string[] array = XRlL56iKFaTMc4ji9eS.qX1vN4saiJ7(KBXS2FNJGht[0]);
			object obj;
			if (array == null)
			{
				obj = null;
			}
			else
			{
				obj = array.FirstOrDefault();
				if (obj != null)
				{
					goto IL_0036;
				}
			}
			obj = KBXS2FNJGht[0].ToString();
			goto IL_0036;
			IL_0036:
			return obj;
		}

		internal object ErIS2Avu07v()
		{
			return XRlL56iKFaTMc4ji9eS.GmHvNpLOZ3b(KBXS2FNJGht[0]).ToUpper();
		}

		internal object GKkS2O7Bhgq()
		{
			return XRlL56iKFaTMc4ji9eS.v2rvNxu3DgM(KBXS2FNJGht[0]);
		}

		static _003C_003Ec__DisplayClass41_1()
		{
		}

		internal static bool FRjtywWKwehAXjCR8J42()
		{
			return m8GJyEWKSGFO0A2pGkqS == null;
		}

		internal static void RyxuyaWKm4VhMtwaBegc()
		{
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> WqngSNwZnsJ = new string[2] { "pinyin", "拼音" };

	[CompilerGenerated]
	private readonly string w9ugSJhxcgE = $"fa:{EFontAwesomeIcon.Light_Font}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> mehgS097I8a;

	[CompilerGenerated]
	private readonly string pEygSCUfuLZ = "https://getquicker.net/KC/Help/Doc/charInfo";

	[CompilerGenerated]
	private readonly bool RMkgSPnRNGm;

	private static readonly StepInParamDef daigSEW1RU8;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> qF4gSy48nTc = new StepInParamDef[1] { daigSEW1RU8 };

	private static readonly StepOutParamDef f8MgS83qxbp;

	private static readonly StepOutParamDef f9BgSainMEE;

	private static readonly StepOutParamDef gmegS7oDDlm;

	private static readonly StepOutParamDef X9UgSRPZIb2;

	private static readonly StepOutParamDef zsWgSqcRonf;

	private static readonly StepOutParamDef cuPgScfu93T;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> dLWgSVoWCNE = new StepOutParamDef[6] { f8MgS83qxbp, f9BgSainMEE, gmegS7oDDlm, X9UgSRPZIb2, zsWgSqcRonf, cuPgScfu93T };

	internal static CharInfoStep TewehGQgMIvv0teJ2DFe;

	public string Key => "sys:charInfo";

	public string Name => "获取字符信息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return WqngSNwZnsJ;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return w9ugSJhxcgE;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return mehgS097I8a;
		}
	}

	public string Description => "获取字符信息";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return pEygSCUfuLZ;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return RMkgSPnRNGm;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return qF4gSy48nTc;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return dLWgSVoWCNE;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.wFMS2D7vdWs = step;
		_003C_003Ec__DisplayClass41_.SffS2dGtwlG = context;
		_003C_003Ec__DisplayClass41_.rFYS2oPwX3d = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.SffS2dGtwlG, _003C_003Ec__DisplayClass41_.wFMS2D7vdWs, _003C_003Ec__DisplayClass41_.rFYS2oPwX3d, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.b9nS25qYUvs, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "获取字符 " + XActionHelper.GetParamDisplayString(daigSEW1RU8, step) + " 的信息";
	}

	static CharInfoStep()
	{
		daigSEW1RU8 = new StepInParamDef
		{
			Key = "char",
			Name = "字符",
			Description = "要获取编码的字符，如果是多个字符，则取第一个。",
			DefaultValue = "中",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		f8MgS83qxbp = new StepOutParamDef
		{
			Key = "unicodeNum",
			Name = "Unicode编码(数字)",
			Description = "字符的Unicode编码数字",
			Type = VarType.Integer
		};
		f9BgSainMEE = new StepOutParamDef
		{
			Key = "unicodeHex",
			Name = "Unicode编码(十六进制)",
			Description = "字符的Unicode编码数字的十六进制，如“中”的Unicode编码十六进制为“4E2D”",
			Type = VarType.Text
		};
		gmegS7oDDlm = new StepOutParamDef
		{
			Key = "pinyinFirstChar",
			Name = "拼音首字母",
			Description = "字母的拼音首字母(仅第一个常用读音)",
			Type = VarType.Text
		};
		X9UgSRPZIb2 = new StepOutParamDef
		{
			Key = "pinyin",
			Name = "拼音",
			Description = "字母的拼音(多音字只输出第一个常用读音)",
			Type = VarType.Text
		};
		zsWgSqcRonf = new StepOutParamDef
		{
			Key = "pinyinFirstCharAll",
			Name = "拼音首字母(全部)",
			Description = "字母的拼音首字母(多音字输出所有读音)",
			Type = VarType.Text
		};
		cuPgScfu93T = new StepOutParamDef
		{
			Key = "pinyinAll",
			Name = "拼音(全部)",
			Description = "字母的拼音(多音字输出所有读音，空格分隔)",
			Type = VarType.Text
		};
	}

	internal static bool QkEOkAQgUODuwj89Gl1t()
	{
		return TewehGQgMIvv0teJ2DFe == null;
	}
}
