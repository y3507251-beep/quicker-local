using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspChildControlTypeAttribute : Attribute
{
	[CompilerGenerated]
	private string s9EbemQcEI;

	[CompilerGenerated]
	private Type OxXbY5LP9I;

	internal static AspChildControlTypeAttribute PWhUeiRFwWSChDhKhPZ;

	[NotNull]
	public string TagName
	{
		[CompilerGenerated]
		get
		{
			return s9EbemQcEI;
		}
		[CompilerGenerated]
		private set
		{
			s9EbemQcEI = value;
		}
	}

	[NotNull]
	public Type ControlType
	{
		[CompilerGenerated]
		get
		{
			return OxXbY5LP9I;
		}
		[CompilerGenerated]
		private set
		{
			OxXbY5LP9I = value;
		}
	}

	public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
	{
		TagName = tagName;
		ControlType = controlType;
	}

	static AspChildControlTypeAttribute()
	{
	}

	internal static bool N1yDtsRcYg1OUMrFn2S()
	{
		return PWhUeiRFwWSChDhKhPZ == null;
	}

	internal static void VuXNhoRylHogeJNtC8h()
	{
	}
}
