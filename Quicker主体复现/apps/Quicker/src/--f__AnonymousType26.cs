using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType26<_003CIsDeleted_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CIsDeleted_003Ej__TPar _003CIsDeleted_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncState_003Ej__TPar _003CSyncState_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CDeleteTimeUtc_003Ej__TPar _003CDeleteTimeUtc_003Ei__Field;

	internal static object yoWrneQBlaAYxTnV8Fj;

	public _003CIsDeleted_003Ej__TPar IsDeleted => _003CIsDeleted_003Ei__Field;

	public _003CSyncState_003Ej__TPar SyncState => _003CSyncState_003Ei__Field;

	public _003CDeleteTimeUtc_003Ej__TPar DeleteTimeUtc => _003CDeleteTimeUtc_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType26(_003CIsDeleted_003Ej__TPar IsDeleted, _003CSyncState_003Ej__TPar SyncState, _003CDeleteTimeUtc_003Ej__TPar DeleteTimeUtc)
	{
		_003CIsDeleted_003Ei__Field = IsDeleted;
		_003CSyncState_003Ei__Field = SyncState;
		_003CDeleteTimeUtc_003Ei__Field = DeleteTimeUtc;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType26<_003CIsDeleted_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType26<_003CIsDeleted_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.Equals(_003CIsDeleted_003Ei__Field, anon._003CIsDeleted_003Ei__Field) && EqualityComparer<_003CSyncState_003Ej__TPar>.Default.Equals(_003CSyncState_003Ei__Field, anon._003CSyncState_003Ei__Field))
			{
				return EqualityComparer<_003CDeleteTimeUtc_003Ej__TPar>.Default.Equals(_003CDeleteTimeUtc_003Ei__Field, anon._003CDeleteTimeUtc_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1836495659 + EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.GetHashCode(_003CIsDeleted_003Ei__Field)) * -1521134295 + EqualityComparer<_003CSyncState_003Ej__TPar>.Default.GetHashCode(_003CSyncState_003Ei__Field)) * -1521134295 + EqualityComparer<_003CDeleteTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CDeleteTimeUtc_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CIsDeleted_003Ej__TPar val = _003CIsDeleted_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CSyncState_003Ej__TPar val2 = _003CSyncState_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CDeleteTimeUtc_003Ej__TPar val3 = _003CDeleteTimeUtc_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ IsDeleted = {0}, SyncState = {1}, DeleteTimeUtc = {2} }}", array);
	}

	internal static bool klCtJQQvWfFSnAvLwHC()
	{
		return yoWrneQBlaAYxTnV8Fj == null;
	}
}
