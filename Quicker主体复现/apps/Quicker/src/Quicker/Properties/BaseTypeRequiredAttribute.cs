using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[BaseTypeRequired(typeof(Attribute))]
public sealed class BaseTypeRequiredAttribute : Attribute
{
	[CompilerGenerated]
	private Type im31pMH2CY;

	private static BaseTypeRequiredAttribute mDXUSQ5lxaIEHtw2Fv2;

	[NotNull]
	public Type BaseType
	{
		[CompilerGenerated]
		get
		{
			return im31pMH2CY;
		}
		[CompilerGenerated]
		private set
		{
			im31pMH2CY = value;
		}
	}

	public BaseTypeRequiredAttribute([NotNull] Type baseType)
	{
		BaseType = baseType;
	}

	internal static bool Ss7qrK5ZLPZpW8FIPLr()
	{
		return mDXUSQ5lxaIEHtw2Fv2 == null;
	}
}
