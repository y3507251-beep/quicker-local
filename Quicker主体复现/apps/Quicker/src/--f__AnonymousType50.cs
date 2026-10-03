using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType50<_003CError_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CError_003Ej__TPar _003CError_003Ei__Field;

	private static object CFkUiQFLHLVOw9w17bY;

	public _003CError_003Ej__TPar Error => _003CError_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType50(_003CError_003Ej__TPar Error)
	{
		_003CError_003Ei__Field = Error;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType50<_003CError_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType50<_003CError_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CError_003Ej__TPar>.Default.Equals(_003CError_003Ei__Field, anon._003CError_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1988297956 + EqualityComparer<_003CError_003Ej__TPar>.Default.GetHashCode(_003CError_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CError_003Ej__TPar val = _003CError_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Error = {0} }}", array);
	}

	internal static bool o5lQfbFuArdgCjpwMS2()
	{
		return CFkUiQFLHLVOw9w17bY == null;
	}
}
