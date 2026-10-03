using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	[CompilerGenerated]
	private ImplicitUseKindFlags xuN1j7bKd8;

	[CompilerGenerated]
	private ImplicitUseTargetFlags JhU1nKm725;

	internal static UsedImplicitlyAttribute oTiOBk5YNfwRSDdjTOi;

	public ImplicitUseKindFlags UseKindFlags
	{
		[CompilerGenerated]
		get
		{
			return xuN1j7bKd8;
		}
		[CompilerGenerated]
		private set
		{
			xuN1j7bKd8 = value;
		}
	}

	public ImplicitUseTargetFlags TargetFlags
	{
		[CompilerGenerated]
		get
		{
			return JhU1nKm725;
		}
		[CompilerGenerated]
		private set
		{
			JhU1nKm725 = value;
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
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
	}

	internal static bool NQ8vTJ58PEEarjHtHla()
	{
		return oTiOBk5YNfwRSDdjTOi == null;
	}
}
