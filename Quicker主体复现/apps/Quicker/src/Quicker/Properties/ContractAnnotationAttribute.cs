using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class ContractAnnotationAttribute : Attribute
{
	[CompilerGenerated]
	private string Gbw1XGw1UO;

	[CompilerGenerated]
	private bool mIb1mdnNuO;

	internal static ContractAnnotationAttribute XYxaPT5NUsIALZWHJhn;

	[NotNull]
	public string Contract
	{
		[CompilerGenerated]
		get
		{
			return Gbw1XGw1UO;
		}
		[CompilerGenerated]
		private set
		{
			Gbw1XGw1UO = value;
		}
	}

	public bool ForceFullStates
	{
		[CompilerGenerated]
		get
		{
			return mIb1mdnNuO;
		}
		[CompilerGenerated]
		private set
		{
			mIb1mdnNuO = value;
		}
	}

	public ContractAnnotationAttribute([NotNull] string contract)
		: this(contract, false)
	{
	}

	public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
	{
		Contract = contract;
		ForceFullStates = forceFullStates;
	}

	internal static bool wGDAnd59lmjT7SyGuk2()
	{
		return XYxaPT5NUsIALZWHJhn == null;
	}
}
