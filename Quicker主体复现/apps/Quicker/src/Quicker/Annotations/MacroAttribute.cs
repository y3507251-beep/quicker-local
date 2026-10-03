using System;
using System.Runtime.CompilerServices;

namespace Quicker.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class MacroAttribute : Attribute
{
	[CompilerGenerated]
	private string jSv6F1EbIw;

	[CompilerGenerated]
	private int sJa6UPpWg7;

	[CompilerGenerated]
	private string VGJ6l1SLRm;

	private static MacroAttribute RQWQmBPStEypicfW4aW;

	[CanBeNull]
	public string Expression
	{
		[CompilerGenerated]
		get
		{
			return jSv6F1EbIw;
		}
		[CompilerGenerated]
		set
		{
			jSv6F1EbIw = value;
		}
	}

	public int Editable
	{
		[CompilerGenerated]
		get
		{
			return sJa6UPpWg7;
		}
		[CompilerGenerated]
		set
		{
			sJa6UPpWg7 = value;
		}
	}

	[CanBeNull]
	public string Target
	{
		[CompilerGenerated]
		get
		{
			return VGJ6l1SLRm;
		}
		[CompilerGenerated]
		set
		{
			VGJ6l1SLRm = value;
		}
	}

	internal static bool yhD6VMPwxIqbOnuk1Yu()
	{
		return RQWQmBPStEypicfW4aW == null;
	}
}
