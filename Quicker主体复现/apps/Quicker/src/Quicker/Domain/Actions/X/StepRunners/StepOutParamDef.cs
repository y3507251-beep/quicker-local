using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.StepRunners;

public class StepOutParamDef
{
	[CompilerGenerated]
	private string PFbtDmGe7Kh;

	[CompilerGenerated]
	private string PjjtDKrEeso;

	[CompilerGenerated]
	private string ifPtDxODoN1;

	[CompilerGenerated]
	private VarType g6stDrd4GKn;

	[CompilerGenerated]
	private ICollection<string> hjFtDpZ30cp;

	[CompilerGenerated]
	private ICollection<string> ob5tDB4Fukb;

	[CompilerGenerated]
	private string X8CtDQE0d1K;

	[CompilerGenerated]
	private bool S2JtDjZxGVC;

	[CompilerGenerated]
	private string qUHtDnyUL2e;

	public static readonly StepOutParamDef ErrorMessageOutputParam;

	public static readonly StepOutParamDef IsSuccessOutputParam;

	internal static StepOutParamDef sjlWZfQbMcxqq5m2pHvH;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return PFbtDmGe7Kh;
		}
		[CompilerGenerated]
		set
		{
			PFbtDmGe7Kh = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return PjjtDKrEeso;
		}
		[CompilerGenerated]
		set
		{
			PjjtDKrEeso = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return ifPtDxODoN1;
		}
		[CompilerGenerated]
		set
		{
			ifPtDxODoN1 = value;
		}
	}

	public VarType Type
	{
		[CompilerGenerated]
		get
		{
			return g6stDrd4GKn;
		}
		[CompilerGenerated]
		set
		{
			g6stDrd4GKn = value;
		}
	}

	public ICollection<string> ValidForList
	{
		[CompilerGenerated]
		get
		{
			return hjFtDpZ30cp;
		}
		[CompilerGenerated]
		set
		{
			hjFtDpZ30cp = value;
		}
	}

	public ICollection<string> InvalidForList
	{
		[CompilerGenerated]
		get
		{
			return ob5tDB4Fukb;
		}
		[CompilerGenerated]
		set
		{
			ob5tDB4Fukb = value;
		}
	}

	public string VisibleExpression
	{
		[CompilerGenerated]
		get
		{
			return X8CtDQE0d1K;
		}
		[CompilerGenerated]
		set
		{
			X8CtDQE0d1K = value;
		}
	}

	public bool IsAdvanced
	{
		[CompilerGenerated]
		get
		{
			return S2JtDjZxGVC;
		}
		[CompilerGenerated]
		set
		{
			S2JtDjZxGVC = value;
		}
	}

	public string CustomTypeName
	{
		[CompilerGenerated]
		get
		{
			return qUHtDnyUL2e;
		}
		[CompilerGenerated]
		set
		{
			qUHtDnyUL2e = value;
		}
	}

	static StepOutParamDef()
	{
		ErrorMessageOutputParam = new StepOutParamDef
		{
			Key = "errMessage",
			Description = "步骤执行出错时的消息",
			Name = "错误消息",
			Type = VarType.Text
		};
		IsSuccessOutputParam = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "步骤是否成功",
			Description = "步骤是否成功完成",
			Type = VarType.Boolean
		};
	}

	internal static bool nFdHGuQbUAodnNLBIDIK()
	{
		return sjlWZfQbMcxqq5m2pHvH == null;
	}
}
