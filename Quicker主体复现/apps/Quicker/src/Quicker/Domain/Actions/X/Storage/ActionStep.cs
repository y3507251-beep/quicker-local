using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using NWgFv1fei1X1gnrcJmi;
using Quicker.Domain.Actions.X.StepRunners;

namespace Quicker.Domain.Actions.X.Storage;

public class ActionStep
{
	[CompilerGenerated]
	private string kfdtdDhd8Fk;

	[CompilerGenerated]
	private IDictionary<string, ActionStepParam> e8ctddZAAYm = new Dictionary<string, ActionStepParam>();

	[CompilerGenerated]
	private IDictionary<string, string> vAvtdojuwSB = new Dictionary<string, string>();

	[CompilerGenerated]
	private IList<ActionStep> GYdtdTJqMUM;

	[CompilerGenerated]
	private IList<ActionStep> Mn7tdMd7wjU;

	[CompilerGenerated]
	private string dlTtdAnAqxV;

	[CompilerGenerated]
	private bool B7KtdOYBOtm;

	[CompilerGenerated]
	private bool QXhtdFhdoSy;

	[CompilerGenerated]
	private int CUVtdU69gmF;

	internal static ActionStep Nn4HbwQqZZlHs2AKkkhO;

	public string StepRunnerKey
	{
		[CompilerGenerated]
		get
		{
			return kfdtdDhd8Fk;
		}
		[CompilerGenerated]
		set
		{
			kfdtdDhd8Fk = value;
		}
	}

	[JsonIgnore]
	public StepType StepType => StepRunnerRegistry.GetRunner(StepRunnerKey)?.StepType ?? StepType.Action;

	[JsonIgnore]
	public string StepRunnerName
	{
		get
		{
			IStepRunner runner = StepRunnerRegistry.GetRunner(StepRunnerKey);
			object obj;
			if (runner == null)
			{
				obj = null;
			}
			else
			{
				obj = runner.Name;
				if (obj != null)
				{
					goto IL_0020;
				}
			}
			obj = "";
			goto IL_0020;
			IL_0020:
			return (string)obj;
		}
	}

	public IDictionary<string, ActionStepParam> InputParams
	{
		[CompilerGenerated]
		get
		{
			return e8ctddZAAYm;
		}
		[CompilerGenerated]
		set
		{
			e8ctddZAAYm = value;
		}
	}

	[vfInGIfbsoYlQBMjtrM]
	public IDictionary<string, string> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return vAvtdojuwSB;
		}
		[CompilerGenerated]
		set
		{
			vAvtdojuwSB = value;
		}
	}

	public IList<ActionStep> IfSteps
	{
		[CompilerGenerated]
		get
		{
			return GYdtdTJqMUM;
		}
		[CompilerGenerated]
		set
		{
			GYdtdTJqMUM = value;
		}
	}

	public IList<ActionStep> ElseSteps
	{
		[CompilerGenerated]
		get
		{
			return Mn7tdMd7wjU;
		}
		[CompilerGenerated]
		set
		{
			Mn7tdMd7wjU = value;
		}
	}

	public string Note
	{
		[CompilerGenerated]
		get
		{
			return dlTtdAnAqxV;
		}
		[CompilerGenerated]
		set
		{
			dlTtdAnAqxV = value;
		}
	}

	public bool Disabled
	{
		[CompilerGenerated]
		get
		{
			return B7KtdOYBOtm;
		}
		[CompilerGenerated]
		set
		{
			B7KtdOYBOtm = value;
		}
	}

	public bool Collapsed
	{
		[CompilerGenerated]
		get
		{
			return QXhtdFhdoSy;
		}
		[CompilerGenerated]
		set
		{
			QXhtdFhdoSy = value;
		}
	}

	public int DelayMs
	{
		[CompilerGenerated]
		get
		{
			return CUVtdU69gmF;
		}
		[CompilerGenerated]
		set
		{
			CUVtdU69gmF = value;
		}
	}

	internal static bool hcHIC7Qq5FrfJGLOvK9g()
	{
		return Nn4HbwQqZZlHs2AKkkhO == null;
	}
}
