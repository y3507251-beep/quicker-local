using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcMasterLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string mvr6z8sKmV;

	private static AspMvcMasterLocationFormatAttribute eTrOhkMQ7tj72uF2RgL;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return mvr6z8sKmV;
		}
	}

	public AspMvcMasterLocationFormatAttribute([NotNull] string format)
	{
		mvr6z8sKmV = format;
	}

	internal static bool rgtgFiMFeESZ1cUIKJq()
	{
		return eTrOhkMQ7tj72uF2RgL == null;
	}
}
