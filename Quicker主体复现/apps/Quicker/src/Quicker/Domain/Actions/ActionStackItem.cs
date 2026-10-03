using System;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions;

public class ActionStackItem
{
	[CompilerGenerated]
	private int MGStjUUJO5P;

	[CompilerGenerated]
	private int bYKtjlARLO8;

	[CompilerGenerated]
	private ActionStep m8Ntjile4Ly;

	[CompilerGenerated]
	private bool Jt5tj3G2raE;

	[CompilerGenerated]
	private bool p0Ftjfwk3ta;

	[CompilerGenerated]
	private ActionStopFlag WAxtjz8pTGg;

	[CompilerGenerated]
	private Exception jt7tnwqqEcr;

	[CompilerGenerated]
	private bool ewxtntp56dv;

	[CompilerGenerated]
	private bool f1htngbb4OL;

	internal static ActionStackItem F4DuC0Qu1maSCF8yoMiZ;

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return MGStjUUJO5P;
		}
		[CompilerGenerated]
		set
		{
			MGStjUUJO5P = value;
		}
	}

	public int StepIndex
	{
		[CompilerGenerated]
		get
		{
			return bYKtjlARLO8;
		}
		[CompilerGenerated]
		private set
		{
			bYKtjlARLO8 = value;
		}
	}

	public ActionStep CurrentStep
	{
		[CompilerGenerated]
		get
		{
			return m8Ntjile4Ly;
		}
		[CompilerGenerated]
		set
		{
			m8Ntjile4Ly = value;
		}
	}

	public bool SkipError
	{
		[CompilerGenerated]
		get
		{
			return Jt5tj3G2raE;
		}
		[CompilerGenerated]
		set
		{
			Jt5tj3G2raE = value;
		}
	}

	public bool HideWarning
	{
		[CompilerGenerated]
		get
		{
			return p0Ftjfwk3ta;
		}
		[CompilerGenerated]
		set
		{
			p0Ftjfwk3ta = value;
		}
	}

	public ActionStopFlag StopFlag
	{
		[CompilerGenerated]
		get
		{
			return WAxtjz8pTGg;
		}
		[CompilerGenerated]
		set
		{
			WAxtjz8pTGg = value;
		}
	}

	public Exception ActionException
	{
		[CompilerGenerated]
		get
		{
			return jt7tnwqqEcr;
		}
		[CompilerGenerated]
		set
		{
			jt7tnwqqEcr = value;
		}
	}

	public bool BreakFlag
	{
		[CompilerGenerated]
		get
		{
			return ewxtntp56dv;
		}
		[CompilerGenerated]
		set
		{
			ewxtntp56dv = value;
		}
	}

	public bool ContinueFlag
	{
		[CompilerGenerated]
		get
		{
			return f1htngbb4OL;
		}
		[CompilerGenerated]
		set
		{
			f1htngbb4OL = value;
		}
	}

	public void SetStep(int index, ActionStep step)
	{
		StepIndex = index;
		CurrentStep = step;
	}

	internal static bool GeX9GMQuKZZyKhEiQi7l()
	{
		return F4DuC0Qu1maSCF8yoMiZ == null;
	}
}
