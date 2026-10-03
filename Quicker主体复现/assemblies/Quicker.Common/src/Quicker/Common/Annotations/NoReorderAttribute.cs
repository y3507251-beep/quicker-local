using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class NoReorderAttribute : Attribute
{
}
