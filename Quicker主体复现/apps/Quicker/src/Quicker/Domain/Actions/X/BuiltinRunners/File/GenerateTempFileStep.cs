using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class GenerateTempFileStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public ActionStep UMVSVI2tU0T;

		public ActionExecuteContext kNbSVWiOCt4;

		public XAction LEmSVksugbl;

		internal static _003C_003Ec__DisplayClass36_0 xkuci2Wr4OgDVroFimWC;

		internal (bool isSuccess, string message, ActionStopFlag failReason) mDPSVYLePp5()
		{
			string text = XActionHelper.GetTextParamValue(xncgq3rJkRv, UMVSVI2tU0T, kNbSVWiOCt4);
			if (string.IsNullOrEmpty(text))
			{
				text = ".txt";
			}
			if (!text.StartsWith(".", StringComparison.OrdinalIgnoreCase))
			{
				text = "." + text;
			}
			string result = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + text);
			XActionHelper.OutputResult(N38gqzVFEtV, UMVSVI2tU0T, kNbSVWiOCt4, result, LEmSVksugbl);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool fa8lguWrhRtqRMpkCPas()
		{
			return xkuci2Wr4OgDVroFimWC == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> stBgqO6djmL = new string[4] { "扩展名", "路径", "临时文件", "temp" };

	[CompilerGenerated]
	private readonly string Rt6gqFLe6PJ = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> GUZgqUbT3Tl;

	[CompilerGenerated]
	private readonly string kiVgqlgdrIr = "https://getquicker.net/KC/Help/Doc/gentempfilepath";

	[CompilerGenerated]
	private readonly bool jIDgqiy3LAG;

	private static readonly StepInParamDef xncgq3rJkRv;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Vn0gqfdU69t = new StepInParamDef[1] { xncgq3rJkRv };

	private static readonly StepOutParamDef N38gqzVFEtV;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> OBlgcwR1GDM = new StepOutParamDef[1] { N38gqzVFEtV };

	private static GenerateTempFileStep H0xQPKQt07hjcr0txkJI;

	public string Key => "sys:GenTempFilePath";

	public string Name => "生成临时文件路径";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return stBgqO6djmL;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Rt6gqFLe6PJ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return GUZgqUbT3Tl;
		}
	}

	public string Description => "根据指定的扩展名生成一个随机的临时文件名（完整路径），供后续步骤写入文件使用。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return kiVgqlgdrIr;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return jIDgqiy3LAG;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Vn0gqfdU69t;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return OBlgcwR1GDM;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.UMVSVI2tU0T = step;
		_003C_003Ec__DisplayClass36_.kNbSVWiOCt4 = context;
		_003C_003Ec__DisplayClass36_.LEmSVksugbl = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass36_.kNbSVWiOCt4, _003C_003Ec__DisplayClass36_.UMVSVI2tU0T, _003C_003Ec__DisplayClass36_.LEmSVksugbl, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass36_.mDPSVYLePp5, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "生成文件路径到：" + XActionHelper.GetOutputParamDisplayString(N38gqzVFEtV, step);
	}

	static GenerateTempFileStep()
	{
		xncgq3rJkRv = new StepInParamDef
		{
			Key = "ext",
			Name = "扩展名",
			Description = "生成临时文件的扩展名",
			DefaultValue = ".txt",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input
		};
		N38gqzVFEtV = new StepOutParamDef
		{
			Key = "filePath",
			Name = "文件路径",
			Description = "生成的临时文件路径",
			Type = VarType.Text
		};
	}

	internal static bool KAKWtdQt1nStTxG3cZ81()
	{
		return H0xQPKQt07hjcr0txkJI == null;
	}

	internal static void mGdUVaQtBr1C1STqaICL()
	{
	}
}
