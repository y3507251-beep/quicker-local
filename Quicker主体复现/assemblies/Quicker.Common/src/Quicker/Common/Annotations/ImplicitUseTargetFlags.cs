using System;

namespace Quicker.Common.Annotations;

[Flags]
public enum ImplicitUseTargetFlags
{
	Default = 1,
	Itself = 1,
	Members = 2,
	WithInheritors = 4,
	WithMembers = 3
}
