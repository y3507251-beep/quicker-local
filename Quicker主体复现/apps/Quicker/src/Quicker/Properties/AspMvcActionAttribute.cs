using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public sealed class AspMvcActionAttribute : Attribute
{
	[CompilerGenerated]
	private string NTtb0tS7fY;

	internal static AspMvcActionAttribute Rls1p1Yboq3NYk4oYoB;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return NTtb0tS7fY;
		}
		[CompilerGenerated]
		private set
		{
			NTtb0tS7fY = value;
		}
	}

	public AspMvcActionAttribute()
	{
	}

	public AspMvcActionAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}

	internal static bool sQn6ZjYq2gaSLTcEk3a()
	{
		return Rls1p1Yboq3NYk4oYoB == null;
	}
}
