using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcTemplateAttribute : Attribute
{
}
