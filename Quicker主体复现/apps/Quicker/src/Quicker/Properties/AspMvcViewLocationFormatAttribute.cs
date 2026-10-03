using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class AspMvcViewLocationFormatAttribute : Attribute
{
	[CompilerGenerated]
	private string ghSbNntxuY;

	private static AspMvcViewLocationFormatAttribute G8PheMYuZHK0iwxYqZY;

	[NotNull]
	public string Format
	{
		[CompilerGenerated]
		get
		{
			return ghSbNntxuY;
		}
		[CompilerGenerated]
		private set
		{
			ghSbNntxuY = value;
		}
	}

	public AspMvcViewLocationFormatAttribute([NotNull] string format)
	{
		Format = format;
	}

	internal static bool VTjxhPYoZYoELDeIf9w()
	{
		return G8PheMYuZHK0iwxYqZY == null;
	}
}
