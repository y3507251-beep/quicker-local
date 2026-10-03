using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NWgFv1fei1X1gnrcJmi;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Actions.XActions.StepRunners;

public class StepOperation
{
	[vfInGIfbsoYlQBMjtrM]
	public delegate StepExecuteResult ExecuteFunc(ActionStep step, ActionExecuteContext context, XAction action, string stepId);

	[vfInGIfbsoYlQBMjtrM]
	public delegate string GetSummaryFunc(ActionStep step);

	[CompilerGenerated]
	private string usJghzFXwKy;

	[CompilerGenerated]
	private string nDkgewW04Pi;

	[CompilerGenerated]
	private string mfGgetByFJd;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> eOugegtSqyS = new List<StepInParamDef>();

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> GYvgeLfLiln = new List<StepOutParamDef>();

	[CompilerGenerated]
	private ExecuteFunc n5Cgeva6LB6;

	[CompilerGenerated]
	private GetSummaryFunc fqogeSigBmU;

	internal static StepOperation HLq9PuQwsv12kM2RIKqi;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return usJghzFXwKy;
		}
		[CompilerGenerated]
		set
		{
			usJghzFXwKy = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return nDkgewW04Pi;
		}
		[CompilerGenerated]
		set
		{
			nDkgewW04Pi = value;
		}
	}

	public string Note
	{
		[CompilerGenerated]
		get
		{
			return mfGgetByFJd;
		}
		[CompilerGenerated]
		set
		{
			mfGgetByFJd = value;
		}
	}

	[vfInGIfbsoYlQBMjtrM]
	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return eOugegtSqyS;
		}
	}

	[vfInGIfbsoYlQBMjtrM]
	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return GYvgeLfLiln;
		}
	}

	public ExecuteFunc Execute
	{
		[CompilerGenerated]
		get
		{
			return n5Cgeva6LB6;
		}
		[CompilerGenerated]
		set
		{
			n5Cgeva6LB6 = value;
		}
	}

	public GetSummaryFunc GetSummary
	{
		[CompilerGenerated]
		get
		{
			return fqogeSigBmU;
		}
		[CompilerGenerated]
		set
		{
			fqogeSigBmU = value;
		}
	}

	internal static bool LnAfRlQwCcKDDlNV4kSw()
	{
		return HLq9PuQwsv12kM2RIKqi == null;
	}
}
