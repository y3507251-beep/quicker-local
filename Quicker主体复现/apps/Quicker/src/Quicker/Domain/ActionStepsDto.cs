using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain;

public class ActionStepsDto
{
	[CompilerGenerated]
	private IList<ActionVariable> b6lt8pPKS5S = new List<ActionVariable>();

	[CompilerGenerated]
	private IList<ActionStep> OCAt8BdNifw = new List<ActionStep>();

	[CompilerGenerated]
	private IList<SubProgram> PIgt8QfCfOP = new List<SubProgram>();

	private static ActionStepsDto vJSSPJQEowsLmxlpjcVd;

	public IList<ActionVariable> Variables
	{
		[CompilerGenerated]
		get
		{
			return b6lt8pPKS5S;
		}
		[CompilerGenerated]
		set
		{
			b6lt8pPKS5S = value;
		}
	}

	public IList<ActionStep> Steps
	{
		[CompilerGenerated]
		get
		{
			return OCAt8BdNifw;
		}
		[CompilerGenerated]
		set
		{
			OCAt8BdNifw = value;
		}
	}

	public IList<SubProgram> SubPrograms
	{
		[CompilerGenerated]
		get
		{
			return PIgt8QfCfOP;
		}
		[CompilerGenerated]
		set
		{
			PIgt8QfCfOP = value;
		}
	}

	internal static void kRX88GQEq8eNgPn9I7QX()
	{
	}

	internal static bool uA4nEZQEfUVaYb5pLEK6()
	{
		return vJSSPJQEowsLmxlpjcVd == null;
	}
}
