using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Utilities.Pinyin;

namespace Quicker.Domain.Searching.Actions;

public class ActionSearchResult
{
	[CompilerGenerated]
	private ActionItem CSxteoDPdo4;

	[CompilerGenerated]
	private ActionProfile cxkteTohFrp;

	[CompilerGenerated]
	private int KPDteMCPPNi;

	[CompilerGenerated]
	private bool YcyteA1goIo;

	[CompilerGenerated]
	private IMatchResult OTQteOitNY8;

	[CompilerGenerated]
	private IMatchResult StBteFUudQV;

	private static ActionSearchResult duKJ5sQdg2hACWyx0LLT;

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return CSxteoDPdo4;
		}
		[CompilerGenerated]
		set
		{
			CSxteoDPdo4 = value;
		}
	}

	public ActionProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return cxkteTohFrp;
		}
		[CompilerGenerated]
		set
		{
			cxkteTohFrp = value;
		}
	}

	public int Score
	{
		[CompilerGenerated]
		get
		{
			return KPDteMCPPNi;
		}
		[CompilerGenerated]
		set
		{
			KPDteMCPPNi = value;
		}
	}

	public bool IsDirectWord
	{
		[CompilerGenerated]
		get
		{
			return YcyteA1goIo;
		}
		[CompilerGenerated]
		set
		{
			YcyteA1goIo = value;
		}
	}

	public IMatchResult TitleMatchResult
	{
		[CompilerGenerated]
		get
		{
			return OTQteOitNY8;
		}
		[CompilerGenerated]
		set
		{
			OTQteOitNY8 = value;
		}
	}

	public IMatchResult DescriptionMatchResult
	{
		[CompilerGenerated]
		get
		{
			return StBteFUudQV;
		}
		[CompilerGenerated]
		set
		{
			StBteFUudQV = value;
		}
	}

	public ActionSearchResult(ActionItem action, ActionProfile profile, int score)
	{
		Action = action;
		Profile = profile;
		Score = score;
	}

	internal static bool UjvygKQdPVxgPMELJLNy()
	{
		return duKJ5sQdg2hACWyx0LLT == null;
	}
}
