using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType43<_003CId_003Ej__TPar, _003CRevision_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtcAlternative_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CId_003Ej__TPar _003CId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CRevision_003Ej__TPar _003CRevision_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncState_003Ej__TPar _003CSyncState_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLastUpdateTimeUtc_003Ej__TPar _003CLastUpdateTimeUtc_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLastUpdateTimeUtcAlternative_003Ej__TPar _003CLastUpdateTimeUtcAlternative_003Ei__Field;

	private static object mWWZqlFAD0EFNmLUqua;

	public _003CId_003Ej__TPar Id => _003CId_003Ei__Field;

	public _003CRevision_003Ej__TPar Revision => _003CRevision_003Ei__Field;

	public _003CSyncState_003Ej__TPar SyncState => _003CSyncState_003Ei__Field;

	public _003CLastUpdateTimeUtc_003Ej__TPar LastUpdateTimeUtc => _003CLastUpdateTimeUtc_003Ei__Field;

	public _003CLastUpdateTimeUtcAlternative_003Ej__TPar LastUpdateTimeUtcAlternative => _003CLastUpdateTimeUtcAlternative_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType43(_003CId_003Ej__TPar Id, _003CRevision_003Ej__TPar Revision, _003CSyncState_003Ej__TPar SyncState, _003CLastUpdateTimeUtc_003Ej__TPar LastUpdateTimeUtc, _003CLastUpdateTimeUtcAlternative_003Ej__TPar LastUpdateTimeUtcAlternative)
	{
		_003CId_003Ei__Field = Id;
		_003CRevision_003Ei__Field = Revision;
		_003CSyncState_003Ei__Field = SyncState;
		_003CLastUpdateTimeUtc_003Ei__Field = LastUpdateTimeUtc;
		_003CLastUpdateTimeUtcAlternative_003Ei__Field = LastUpdateTimeUtcAlternative;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType43<_003CId_003Ej__TPar, _003CRevision_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtcAlternative_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType43<_003CId_003Ej__TPar, _003CRevision_003Ej__TPar, _003CSyncState_003Ej__TPar, _003CLastUpdateTimeUtc_003Ej__TPar, _003CLastUpdateTimeUtcAlternative_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CId_003Ej__TPar>.Default.Equals(_003CId_003Ei__Field, anon._003CId_003Ei__Field) && EqualityComparer<_003CRevision_003Ej__TPar>.Default.Equals(_003CRevision_003Ei__Field, anon._003CRevision_003Ei__Field) && EqualityComparer<_003CSyncState_003Ej__TPar>.Default.Equals(_003CSyncState_003Ei__Field, anon._003CSyncState_003Ei__Field) && EqualityComparer<_003CLastUpdateTimeUtc_003Ej__TPar>.Default.Equals(_003CLastUpdateTimeUtc_003Ei__Field, anon._003CLastUpdateTimeUtc_003Ei__Field))
			{
				return EqualityComparer<_003CLastUpdateTimeUtcAlternative_003Ej__TPar>.Default.Equals(_003CLastUpdateTimeUtcAlternative_003Ei__Field, anon._003CLastUpdateTimeUtcAlternative_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((((1395861391 + EqualityComparer<_003CId_003Ej__TPar>.Default.GetHashCode(_003CId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CRevision_003Ej__TPar>.Default.GetHashCode(_003CRevision_003Ei__Field)) * -1521134295 + EqualityComparer<_003CSyncState_003Ej__TPar>.Default.GetHashCode(_003CSyncState_003Ei__Field)) * -1521134295 + EqualityComparer<_003CLastUpdateTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CLastUpdateTimeUtc_003Ei__Field)) * -1521134295 + EqualityComparer<_003CLastUpdateTimeUtcAlternative_003Ej__TPar>.Default.GetHashCode(_003CLastUpdateTimeUtcAlternative_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[5];
		_003CId_003Ej__TPar val = _003CId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CRevision_003Ej__TPar val2 = _003CRevision_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CSyncState_003Ej__TPar val3 = _003CSyncState_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		_003CLastUpdateTimeUtc_003Ej__TPar val4 = _003CLastUpdateTimeUtc_003Ei__Field;
		array[3] = ((val4 != null) ? val4.ToString() : null);
		_003CLastUpdateTimeUtcAlternative_003Ej__TPar val5 = _003CLastUpdateTimeUtcAlternative_003Ei__Field;
		array[4] = ((val5 != null) ? val5.ToString() : null);
		return string.Format(null, "{{ Id = {0}, Revision = {1}, SyncState = {2}, LastUpdateTimeUtc = {3}, LastUpdateTimeUtcAlternative = {4} }}", array);
	}

	internal static bool HppJb4FnDILcwYs3Wy4()
	{
		return mWWZqlFAD0EFNmLUqua == null;
	}
}
