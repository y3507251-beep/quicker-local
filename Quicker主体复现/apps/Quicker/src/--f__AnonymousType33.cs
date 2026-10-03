using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType33<_003CId_003Ej__TPar, _003CIsDeleted_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CId_003Ej__TPar _003CId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CIsDeleted_003Ej__TPar _003CIsDeleted_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CDeleteTimeUtc_003Ej__TPar _003CDeleteTimeUtc_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLastUpdateTimeUtc_003Ej__TPar _003CLastUpdateTimeUtc_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncState_003Ej__TPar _003CSyncState_003Ei__Field;

	private static object FRI0tAQ8A9vyKeXJIUf;

	public _003CId_003Ej__TPar Id => _003CId_003Ei__Field;

	public _003CIsDeleted_003Ej__TPar IsDeleted => _003CIsDeleted_003Ei__Field;

	public _003CDeleteTimeUtc_003Ej__TPar DeleteTimeUtc => _003CDeleteTimeUtc_003Ei__Field;

	public _003CLastUpdateTimeUtc_003Ej__TPar LastUpdateTimeUtc => _003CLastUpdateTimeUtc_003Ei__Field;

	public _003CSyncState_003Ej__TPar SyncState => _003CSyncState_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType33(_003CId_003Ej__TPar Id, _003CIsDeleted_003Ej__TPar IsDeleted, _003CDeleteTimeUtc_003Ej__TPar DeleteTimeUtc, _003CLastUpdateTimeUtc_003Ej__TPar LastUpdateTimeUtc, _003CSyncState_003Ej__TPar SyncState)
	{
		_003CId_003Ei__Field = Id;
		_003CIsDeleted_003Ei__Field = IsDeleted;
		_003CDeleteTimeUtc_003Ei__Field = DeleteTimeUtc;
		_003CLastUpdateTimeUtc_003Ei__Field = LastUpdateTimeUtc;
		_003CSyncState_003Ei__Field = SyncState;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType33<_003CId_003Ej__TPar, _003CIsDeleted_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType33<_003CId_003Ej__TPar, _003CIsDeleted_003Ej__TPar, _003CDeleteTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CId_003Ej__TPar>.Default.Equals(_003CId_003Ei__Field, anon._003CId_003Ei__Field) && EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.Equals(_003CIsDeleted_003Ei__Field, anon._003CIsDeleted_003Ei__Field) && EqualityComparer<_003CDeleteTimeUtc_003Ej__TPar>.Default.Equals(_003CDeleteTimeUtc_003Ei__Field, anon._003CDeleteTimeUtc_003Ei__Field) && EqualityComparer<_003CLastUpdateTimeUtc_003Ej__TPar>.Default.Equals(_003CLastUpdateTimeUtc_003Ei__Field, anon._003CLastUpdateTimeUtc_003Ei__Field))
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
		return ((((144104884 + EqualityComparer<_003CId_003Ej__TPar>.Default.GetHashCode(_003CId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.GetHashCode(_003CIsDeleted_003Ei__Field)) * -1521134295 + EqualityComparer<_003CDeleteTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CDeleteTimeUtc_003Ei__Field)) * -1521134295 + EqualityComparer<_003CLastUpdateTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CLastUpdateTimeUtc_003Ei__Field)) * -1521134295 + EqualityComparer<_003CSyncState_003Ej__TPar>.Default.GetHashCode(_003CSyncState_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[5];
		_003CId_003Ej__TPar val = _003CId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CIsDeleted_003Ej__TPar val2 = _003CIsDeleted_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CDeleteTimeUtc_003Ej__TPar val3 = _003CDeleteTimeUtc_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		_003CLastUpdateTimeUtc_003Ej__TPar val4 = _003CLastUpdateTimeUtc_003Ei__Field;
		array[3] = ((val4 != null) ? val4.ToString() : null);
		_003CSyncState_003Ej__TPar val5 = _003CSyncState_003Ei__Field;
		array[4] = ((val5 != null) ? val5.ToString() : null);
		return string.Format(null, "{{ Id = {0}, IsDeleted = {1}, DeleteTimeUtc = {2}, LastUpdateTimeUtc = {3}, SyncState = {4} }}", array);
	}

	internal static bool LKMyGfQRS2TPqicb5mh()
	{
		return FRI0tAQ8A9vyKeXJIUf == null;
	}
}
