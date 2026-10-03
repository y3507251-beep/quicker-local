using System;

namespace Quicker.Common.Annotations;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NoEnumerationAttribute : Attribute
{
}
