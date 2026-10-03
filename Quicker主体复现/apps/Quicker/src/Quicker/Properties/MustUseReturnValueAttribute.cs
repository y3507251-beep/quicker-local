using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Method)]
public sealed class MustUseReturnValueAttribute : Attribute
{
	[CompilerGenerated]
	private string BWU1Aq0iPL;

	internal static MustUseReturnValueAttribute Kb2nfh5z7gJXf563Frr;

	[CanBeNull]
	public string Justification
	{
		[CompilerGenerated]
		get
		{
			return BWU1Aq0iPL;
		}
		[CompilerGenerated]
		private set
		{
			BWU1Aq0iPL = value;
		}
	}

	public MustUseReturnValueAttribute()
	{
	}

	public MustUseReturnValueAttribute([NotNull] string justification)
	{
		Justification = justification;
	}

	internal static bool xfKKK5YV26STRXiaYgM()
	{
		return Kb2nfh5z7gJXf563Frr == null;
	}
}
