using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class ValueProviderAttribute : Attribute
{
	[CompilerGenerated]
	private string Ffc1s5FkCt;

	internal static ValueProviderAttribute oZ7yWo50is1QTM2WFMW;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return Ffc1s5FkCt;
		}
		[CompilerGenerated]
		private set
		{
			Ffc1s5FkCt = value;
		}
	}

	public ValueProviderAttribute([NotNull] string name)
	{
		Name = name;
	}

	internal static void tD0KnT5BGkQycq7WO49()
	{
	}

	internal static bool TyTyVQ51XyDSM6Prcqx()
	{
		return oZ7yWo50is1QTM2WFMW == null;
	}
}
