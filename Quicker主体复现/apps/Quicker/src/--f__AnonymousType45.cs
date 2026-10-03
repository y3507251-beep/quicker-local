using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType45<_003CId_003Ej__TPar, _003CSyncState_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CId_003Ej__TPar _003CId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncState_003Ej__TPar _003CSyncState_003Ei__Field;

	internal static object qQUykTFEA8eaNl3YcTI;

	public _003CId_003Ej__TPar Id => _003CId_003Ei__Field;

	public _003CSyncState_003Ej__TPar SyncState => _003CSyncState_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType45(_003CId_003Ej__TPar Id, _003CSyncState_003Ej__TPar SyncState)
	{
		_003CId_003Ei__Field = Id;
		_003CSyncState_003Ei__Field = SyncState;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType45<_003CId_003Ej__TPar, _003CSyncState_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType45<_003CId_003Ej__TPar, _003CSyncState_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CId_003Ej__TPar>.Default.Equals(_003CId_003Ei__Field, anon._003CId_003Ei__Field))
			{
				return EqualityComparer<_003CSyncState_003Ej__TPar>.Default.Equals(_003CSyncState_003Ei__Field, anon._003CSyncState_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-461023311 + EqualityComparer<_003CId_003Ej__TPar>.Default.GetHashCode(_003CId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CSyncState_003Ej__TPar>.Default.GetHashCode(_003CSyncState_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CId_003Ej__TPar val = _003CId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CSyncState_003Ej__TPar val2 = _003CSyncState_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ Id = {0}, SyncState = {1} }}", array);
	}

	internal static bool uRgEyYFGjahcA9ZyEL0()
	{
		return qQUykTFEA8eaNl3YcTI == null;
	}
}
