using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	[CompilerGenerated]
	private readonly ImplicitUseKindFlags MFy6oXxLg2;

	[CompilerGenerated]
	private readonly ImplicitUseTargetFlags bBq6TefQ8f;

	internal static MeansImplicitUseAttribute dXrdAWP1YZPX8fZk4in;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags
	{
		[CompilerGenerated]
		get
		{
			return MFy6oXxLg2;
		}
	}

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags
	{
		[CompilerGenerated]
		get
		{
			return bBq6TefQ8f;
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
		MFy6oXxLg2 = useKindFlags;
		bBq6TefQ8f = targetFlags;
	}

	internal static bool H0iidjPKfpEDWuxxrGI()
	{
		return dXrdAWP1YZPX8fZk4in == null;
	}
}
