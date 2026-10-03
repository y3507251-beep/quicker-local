using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string eAMb2lCYXZ;

	private static AspMvcPartialViewLocationFormatAttribute IaPtd7YN1jqyREAAQdL;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return eAMb2lCYXZ;
		}
		[CompilerGenerated]
		private set
		{
			eAMb2lCYXZ = value;
		}
	}

	public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	internal static bool CdCfKEY91mfc7k9SBGL()
	{
		return IaPtd7YN1jqyREAAQdL == null;
	}
}
