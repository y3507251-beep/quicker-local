using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AspMvcAreaAttribute : Attribute
{
	[CompilerGenerated]
	private string xcHbPVhGDV;

	private static AspMvcAreaAttribute gnQrIsYlGNA27CU0cuU;

	[CanBeNull]
	public string AnonymousProperty
	{
		[CompilerGenerated]
		get
		{
			return xcHbPVhGDV;
		}
		[CompilerGenerated]
		private set
		{
			xcHbPVhGDV = value;
		}
	}

	public AspMvcAreaAttribute()
	{
	}

	public AspMvcAreaAttribute([NotNull] string anonymousProperty)
	{
		AnonymousProperty = anonymousProperty;
	}

	internal static bool oDRXQVYZB7yebrkJcYe()
	{
		return gnQrIsYlGNA27CU0cuU == null;
	}
}
