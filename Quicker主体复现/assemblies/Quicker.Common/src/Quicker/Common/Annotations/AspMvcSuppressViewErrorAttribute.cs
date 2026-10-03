using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class AspMvcSuppressViewErrorAttribute : Attribute
{
}
