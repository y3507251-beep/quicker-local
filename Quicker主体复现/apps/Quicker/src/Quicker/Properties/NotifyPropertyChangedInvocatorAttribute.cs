using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Method)]
public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
	[CompilerGenerated]
	private string Lgv11nL5Md;

	internal static NotifyPropertyChangedInvocatorAttribute tLLvRg5Jd9P2F4l3TCP;

	[CanBeNull]
	public string ParameterName
	{
		[CompilerGenerated]
		get
		{
			return Lgv11nL5Md;
		}
		[CompilerGenerated]
		private set
		{
			Lgv11nL5Md = value;
		}
	}

	public NotifyPropertyChangedInvocatorAttribute()
	{
	}

	public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
	{
		ParameterName = parameterName;
	}

	internal static bool KT7wsx5k1yHDrjmXqLr()
	{
		return tLLvRg5Jd9P2F4l3TCP == null;
	}

	internal static void iFwhSH5rSNeM9rySIfZ()
	{
	}
}
