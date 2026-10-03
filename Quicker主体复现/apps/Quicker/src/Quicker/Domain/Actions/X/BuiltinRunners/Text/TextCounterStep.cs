using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class TextCounterStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionStep zWmSNxEVxXf;

		public ActionExecuteContext DgJSNrEnxCG;

		public XAction Y9NSNpTH89q;

		internal static _003C_003Ec__DisplayClass39_0 QxAXukWvyNmfijhTlQVj;

		internal (bool isSuccess, string message, ActionStopFlag failReason) YD0SNKZdpdO()
		{
			var (num, num2, num3, num4, _) = DoCount(XActionHelper.GetTextParamValue(C14gN9hecIk, zWmSNxEVxXf, DgJSNrEnxCG));
			XActionHelper.OutputResult(QVtgNeuCoiL, zWmSNxEVxXf, DgJSNrEnxCG, num, Y9NSNpTH89q);
			XActionHelper.OutputResult(lHngNYAVLrr, zWmSNxEVxXf, DgJSNrEnxCG, num2, Y9NSNpTH89q);
			XActionHelper.OutputResult(ubygNId1YEu, zWmSNxEVxXf, DgJSNrEnxCG, num3, Y9NSNpTH89q);
			XActionHelper.OutputResult(EvZgNWqmscq, zWmSNxEVxXf, DgJSNrEnxCG, num4, Y9NSNpTH89q);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool WVZuTnWvpk24x7IB1N8q()
		{
			return QxAXukWvyNmfijhTlQVj == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> KbJgNRHJRkb;

	[CompilerGenerated]
	private readonly string WnqgNq0DXB5 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ODKgNcfV4q5;

	[CompilerGenerated]
	private readonly string pSagNVlwpx3 = "https://getquicker.net/KC/Help/Doc/textcounter";

	[CompilerGenerated]
	private readonly bool AdDgNZTPfh5;

	private static readonly StepInParamDef C14gN9hecIk;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> lK7gNhfatYP = new StepInParamDef[1] { C14gN9hecIk };

	private static readonly StepOutParamDef QVtgNeuCoiL;

	private static readonly StepOutParamDef lHngNYAVLrr;

	private static readonly StepOutParamDef ubygNId1YEu;

	private static readonly StepOutParamDef EvZgNWqmscq;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> fxRgNk6OOUs = new StepOutParamDef[4] { QVtgNeuCoiL, lHngNYAVLrr, ubygNId1YEu, EvZgNWqmscq };

	private static readonly int[,] biVgNGJg31O;

	internal static TextCounterStep A2Py3cQPhPiiiHqdXnDa;

	public string Key => "sys:textCounter";

	public string Name => "字数统计";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return KbJgNRHJRkb;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return WnqgNq0DXB5;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ODKgNcfV4q5;
		}
	}

	public string Description => "统计文本行数、字符数等";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return pSagNVlwpx3;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return AdDgNZTPfh5;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return lK7gNhfatYP;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return fxRgNk6OOUs;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.zWmSNxEVxXf = step;
		_003C_003Ec__DisplayClass39_.DgJSNrEnxCG = context;
		_003C_003Ec__DisplayClass39_.Y9NSNpTH89q = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass39_.DgJSNrEnxCG, _003C_003Ec__DisplayClass39_.zWmSNxEVxXf, _003C_003Ec__DisplayClass39_.Y9NSNpTH89q, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass39_.YD0SNKZdpdO, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public static bool IsChineseCharacter(char ch)
	{
		int num = 0;
		while (true)
		{
			if (num < biVgNGJg31O.GetLength(0))
			{
				if (ch >= biVgNGJg31O[num, 0] && ch <= biVgNGJg31O[num, 1])
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static (int line, int total, int nonspace, int cnChar, int nonAscii) DoCount(string content)
	{
		if (content.IsNullOrEmpty())
		{
			return (line: 0, total: 0, nonspace: 0, cnChar: 0, nonAscii: 0);
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		foreach (char c in content)
		{
			num2++;
			if (c == '\n')
			{
				num++;
			}
			if (!char.IsControl(c) && !char.IsWhiteSpace(c) && !nthgN7Mt9ZV(c))
			{
				num3++;
			}
			if (IsChineseCharacter(c))
			{
				num4++;
			}
			if (c < '\u0080')
			{
				num5++;
			}
		}
		return (line: num, total: num2, nonspace: num3, cnChar: num4, nonAscii: num2 - num5);
	}

	internal static bool nthgN7Mt9ZV(char char_0)
	{
		int[] array = new int[8] { 8203, 8203, 8204, 8207, 8232, 8238, 8288, 8303 };
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (char_0 >= array[num] && char_0 <= array[num + 1])
				{
					break;
				}
				num += 2;
				continue;
			}
			return false;
		}
		return true;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(C14gN9hecIk, step) + " ";
	}

	static TextCounterStep()
	{
		C14gN9hecIk = new StepInParamDef
		{
			Key = "content",
			Name = "文本",
			Description = "要统计的内容",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVar
		};
		QVtgNeuCoiL = new StepOutParamDef
		{
			Key = "line",
			Name = "行数",
			Type = VarType.Integer
		};
		lHngNYAVLrr = new StepOutParamDef
		{
			Key = "char",
			Name = "字符数",
			Type = VarType.Integer
		};
		ubygNId1YEu = new StepOutParamDef
		{
			Key = "visableChar",
			Name = "可见字符数",
			Type = VarType.Integer
		};
		EvZgNWqmscq = new StepOutParamDef
		{
			Key = "cnChar",
			Name = "汉字数",
			Type = VarType.Integer
		};
		biVgNGJg31O = new int[18, 2]
		{
			{ 19968, 40869 },
			{ 40870, 40907 },
			{ 13312, 19893 },
			{ 131072, 173782 },
			{ 173824, 177972 },
			{ 177984, 178205 },
			{ 12032, 12245 },
			{ 11904, 12019 },
			{ 63744, 64217 },
			{ 194560, 195101 },
			{ 59413, 59503 },
			{ 58368, 58856 },
			{ 58880, 59087 },
			{ 12736, 12771 },
			{ 12272, 12283 },
			{ 12549, 12576 },
			{ 12704, 12730 },
			{ 12295, 12295 }
		};
	}

	internal static bool YeEoWuQPHjOMBvEvDqnt()
	{
		return A2Py3cQPhPiiiHqdXnDa == null;
	}

	internal static void GnaV4ZQMVhTT3l5G1GCl()
	{
	}
}
