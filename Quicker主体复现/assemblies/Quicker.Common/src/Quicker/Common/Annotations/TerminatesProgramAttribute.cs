using System;

namespace Quicker.Common.Annotations;

[Obsolete("Use [ContractAnnotation('=> halt')] instead")]
[AttributeUsage(AttributeTargets.Method)]
public sealed class TerminatesProgramAttribute : Attribute
{
}
