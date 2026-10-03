using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	[CompilerGenerated]
	private ImplicitUseKindFlags Ntx1D6OBmq;

	[CompilerGenerated]
	private ImplicitUseTargetFlags ze51dwWTNf;

	private static MeansImplicitUseAttribute RuxrI75ghPS6dIGPToU;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags
	{
		[CompilerGenerated]
		get
		{
			return Ntx1D6OBmq;
		}
		[CompilerGenerated]
		private set
		{
			Ntx1D6OBmq = value;
		}
	}

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags
	{
		[CompilerGenerated]
		get
		{
			return ze51dwWTNf;
		}
		[CompilerGenerated]
		private set
		{
			ze51dwWTNf = value;
		}
	}

	public MeansImplicitUseAttribute()
		: this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
	{
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
		: this(useKindFlags, ImplicitUseTargetFlags.Default)
	{
	}

	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
		: this(ImplicitUseKindFlags.Default, targetFlags)
	{
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
	}

	internal static bool vnpmeF5PN7wKtoKwNU6()
	{
		return RuxrI75ghPS6dIGPToU == null;
	}
}
