using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class AspMvcViewComponentViewAttribute : Attribute
{
}
