using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string SN16i8xYLY;

	private static AspMvcAreaMasterLocationFormatAttribute QqM77xPmAyVI2OOpDev;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return SN16i8xYLY;
		}
	}

	public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
	{
		SN16i8xYLY = format;
	}

	internal static bool c2wDfuPsKy2dNeXDEwJ()
	{
		return QqM77xPmAyVI2OOpDev == null;
	}
}
