using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Modules.TextTools;

public class TextToolContext
{
	public delegate void ProcessSelectedText(string text, bool isFullContent);

	[CompilerGenerated]
	private Window RFutv9gU89e;

	[CompilerGenerated]
	private ITextControl v0ytvh52I8T;

	[CompilerGenerated]
	private IList<ActionVariable> SQMtveqVSo4;

	[CompilerGenerated]
	private ProcessSelectedText NvytvYTvl4x;

	[CompilerGenerated]
	private Action ynNtvIf1wwl;

	[CompilerGenerated]
	private string WHKtvWahWN4;

	[CompilerGenerated]
	private string D16tvksXQ6E;

	[CompilerGenerated]
	private bool lKBtvGaoC4n;

	[CompilerGenerated]
	private ActionExecuteContext PeFtvsybpZl;

	internal static TextToolContext H2Rb38Qy6rtwUlO4w1Pt;

	public Window ParentWindow
	{
		[CompilerGenerated]
		get
		{
			return RFutv9gU89e;
		}
		[CompilerGenerated]
		set
		{
			RFutv9gU89e = value;
		}
	}

	public ITextControl TextControl
	{
		[CompilerGenerated]
		get
		{
			return v0ytvh52I8T;
		}
		[CompilerGenerated]
		set
		{
			v0ytvh52I8T = value;
		}
	}

	public IList<ActionVariable> ActionVariables
	{
		[CompilerGenerated]
		get
		{
			return SQMtveqVSo4;
		}
		[CompilerGenerated]
		set
		{
			SQMtveqVSo4 = value;
		}
	}

	public ProcessSelectedText ProcessSelectedTextFunc
	{
		[CompilerGenerated]
		get
		{
			return NvytvYTvl4x;
		}
		[CompilerGenerated]
		set
		{
			NvytvYTvl4x = value;
		}
	}

	public Action SelectionCanceledFunc
	{
		[CompilerGenerated]
		get
		{
			return ynNtvIf1wwl;
		}
		[CompilerGenerated]
		set
		{
			ynNtvIf1wwl = value;
		}
	}

	public string FileDialogFilter
	{
		[CompilerGenerated]
		get
		{
			return WHKtvWahWN4;
		}
		[CompilerGenerated]
		set
		{
			WHKtvWahWN4 = value;
		}
	}

	public string DefaultHighlightingType
	{
		[CompilerGenerated]
		get
		{
			return D16tvksXQ6E;
		}
		[CompilerGenerated]
		set
		{
			D16tvksXQ6E = value;
		}
	}

	public bool OperationItem_OnlyData
	{
		[CompilerGenerated]
		get
		{
			return lKBtvGaoC4n;
		}
		[CompilerGenerated]
		set
		{
			lKBtvGaoC4n = value;
		}
	}

	public ActionExecuteContext ActionExecuteContext
	{
		[CompilerGenerated]
		get
		{
			return PeFtvsybpZl;
		}
		[CompilerGenerated]
		set
		{
			PeFtvsybpZl = value;
		}
	}

	static TextToolContext()
	{
	}

	internal static bool IFpFkaQytKQjy7W6UBEE()
	{
		return H2Rb38Qy6rtwUlO4w1Pt == null;
	}

	internal static void DdaZlGQywr7YX3kr3sfg()
	{
	}
}
