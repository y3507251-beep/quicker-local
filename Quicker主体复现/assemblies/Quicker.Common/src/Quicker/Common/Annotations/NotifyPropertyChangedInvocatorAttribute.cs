using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method)]
public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
	[CanBeNull]
	public string ParameterName { get; }

	public NotifyPropertyChangedInvocatorAttribute()
	{
	}

	public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
	{
		ParameterName = parameterName;
	}
}
