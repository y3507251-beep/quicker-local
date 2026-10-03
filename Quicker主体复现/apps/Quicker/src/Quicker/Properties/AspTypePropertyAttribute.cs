using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Property)]
public sealed class AspTypePropertyAttribute : Attribute
{
	[CompilerGenerated]
	private bool YtRbGr1LYf;

	private static AspTypePropertyAttribute zbAN02R11I2FWOUouR2;

	public bool CreateConstructorReferences
	{
		[CompilerGenerated]
		get
		{
			return YtRbGr1LYf;
		}
		[CompilerGenerated]
		private set
		{
			YtRbGr1LYf = value;
		}
	}

	public AspTypePropertyAttribute(bool createConstructorReferences)
	{
		CreateConstructorReferences = createConstructorReferences;
	}

	internal static bool gIGt9eRKXMUtOKjgx2r()
	{
		return zbAN02R11I2FWOUouR2 == null;
	}
}
