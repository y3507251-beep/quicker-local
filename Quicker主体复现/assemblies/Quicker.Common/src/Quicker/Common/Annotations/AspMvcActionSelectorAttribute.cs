using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class AspMvcActionSelectorAttribute : Attribute
{
}
