using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string MSNXwWlmsX;

	internal static AspMvcPartialViewLocationFormatAttribute MuyRZVMWxk2jXcwAYXb;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return MSNXwWlmsX;
		}
	}

	public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
	{
		MSNXwWlmsX = format;
	}

	internal static bool y5J2O0MygwPpaSD4W17()
	{
		return MuyRZVMWxk2jXcwAYXb == null;
	}
}
