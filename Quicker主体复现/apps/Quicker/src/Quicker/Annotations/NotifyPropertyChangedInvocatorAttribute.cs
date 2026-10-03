using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method)]
public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string psO6Q7vVZF;

	private static NotifyPropertyChangedInvocatorAttribute MpgwKvg4O2lXIjD9xXE;

	[CanBeNull]
	public string ParameterName
	{
		[CompilerGenerated]
		get
		{
			return psO6Q7vVZF;
		}
	}

	public NotifyPropertyChangedInvocatorAttribute()
	{
	}

	public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
	{
		psO6Q7vVZF = parameterName;
	}

	static NotifyPropertyChangedInvocatorAttribute()
	{
	}

	internal static bool EjOtX1ght9NsiopGIJ3()
	{
		return MpgwKvg4O2lXIjD9xXE == null;
	}

	internal static void zAG1uOgzaNJjWeFVoEc()
	{
	}

	internal static void pg9LSAPVelDrTsGmARE()
	{
	}
}
