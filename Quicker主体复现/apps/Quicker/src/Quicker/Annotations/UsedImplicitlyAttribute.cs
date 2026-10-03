using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	[CompilerGenerated]
	private readonly ImplicitUseKindFlags L1V6DftcbH;

	[CompilerGenerated]
	private readonly ImplicitUseTargetFlags TJl6daOwbH;

	private static UsedImplicitlyAttribute liHe6SPEW7vGpQMtH4G;

	public ImplicitUseKindFlags UseKindFlags
	{
		[CompilerGenerated]
		get
		{
			return L1V6DftcbH;
		}
	}

	public ImplicitUseTargetFlags TargetFlags
	{
		[CompilerGenerated]
		get
		{
			return TJl6daOwbH;
		}
	}

	public UsedImplicitlyAttribute()
		: this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
	{
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
		: this(useKindFlags, ImplicitUseTargetFlags.Default)
	{
	}

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
		: this(ImplicitUseKindFlags.Default, targetFlags)
	{
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		L1V6DftcbH = useKindFlags;
		TJl6daOwbH = targetFlags;
	}

	internal static bool WLFiKYPGXVKW0Xd3igC()
	{
		return liHe6SPEW7vGpQMtH4G == null;
	}
}
