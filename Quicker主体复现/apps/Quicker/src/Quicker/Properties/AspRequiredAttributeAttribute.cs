using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspRequiredAttributeAttribute : Attribute
{
	[CompilerGenerated]
	private string Md3bWOHfKB;

	internal static AspRequiredAttributeAttribute Mlt8PRREoRJTdAXHfCF;

	[NotNull]
	public string Attribute
	{
		[CompilerGenerated]
		get
		{
			return Md3bWOHfKB;
		}
		[CompilerGenerated]
		private set
		{
			Md3bWOHfKB = value;
		}
	}

	public AspRequiredAttributeAttribute([NotNull] string attribute)
	{
		Attribute = attribute;
	}

	internal static bool UOUcSjRGoUDf2bU8oYc()
	{
		return Mlt8PRREoRJTdAXHfCF == null;
	}
}
