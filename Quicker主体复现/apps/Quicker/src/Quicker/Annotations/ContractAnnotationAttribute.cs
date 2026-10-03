using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class ContractAnnotationAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string xq96j4CPtg;

	[CompilerGenerated]
	private readonly bool srI6n9jcHk;

	private static ContractAnnotationAttribute WvGqXsPQfFxTIZZmyaV;

	[NotNull]
	public string Contract
	{
		[CompilerGenerated]
		get
		{
			return xq96j4CPtg;
		}
	}

	public bool ForceFullStates
	{
		[CompilerGenerated]
		get
		{
			return srI6n9jcHk;
		}
	}

	public ContractAnnotationAttribute([NotNull] string contract)
		: this(contract, false)
	{
	}

	public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
	{
		xq96j4CPtg = contract;
		srI6n9jcHk = forceFullStates;
	}

	internal static bool hRIu9wPFALum7kO7pKm()
	{
		return WvGqXsPQfFxTIZZmyaV == null;
	}

	internal static void BqMCPmPWQfobEWxwEbt()
	{
	}
}
