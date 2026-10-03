using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType42<_003CActionId_003Ej__TPar, _003CLastClickTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CActionId_003Ej__TPar _003CActionId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLastClickTimeUtc_003Ej__TPar _003CLastClickTimeUtc_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncState_003Ej__TPar _003CSyncState_003Ei__Field;

	internal static object e9DjlvFpabYe2pmmrH3;

	public _003CActionId_003Ej__TPar ActionId => _003CActionId_003Ei__Field;

	public _003CLastClickTimeUtc_003Ej__TPar LastClickTimeUtc => _003CLastClickTimeUtc_003Ei__Field;

	public _003CSyncState_003Ej__TPar SyncState => _003CSyncState_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType42(_003CActionId_003Ej__TPar ActionId, _003CLastClickTimeUtc_003Ej__TPar LastClickTimeUtc, _003CSyncState_003Ej__TPar SyncState)
	{
		_003CActionId_003Ei__Field = ActionId;
		_003CLastClickTimeUtc_003Ei__Field = LastClickTimeUtc;
		_003CSyncState_003Ei__Field = SyncState;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType42<_003CActionId_003Ej__TPar, _003CLastClickTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType42<_003CActionId_003Ej__TPar, _003CLastClickTimeUtc_003Ej__TPar, _003CSyncState_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CActionId_003Ej__TPar>.Default.Equals(_003CActionId_003Ei__Field, anon._003CActionId_003Ei__Field) && EqualityComparer<_003CLastClickTimeUtc_003Ej__TPar>.Default.Equals(_003CLastClickTimeUtc_003Ei__Field, anon._003CLastClickTimeUtc_003Ei__Field))
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
		return ((209343202 + EqualityComparer<_003CActionId_003Ej__TPar>.Default.GetHashCode(_003CActionId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CLastClickTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CLastClickTimeUtc_003Ei__Field)) * -1521134295 + EqualityComparer<_003CSyncState_003Ej__TPar>.Default.GetHashCode(_003CSyncState_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CActionId_003Ej__TPar val = _003CActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CLastClickTimeUtc_003Ej__TPar val2 = _003CLastClickTimeUtc_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CSyncState_003Ej__TPar val3 = _003CSyncState_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ ActionId = {0}, LastClickTimeUtc = {1}, SyncState = {2} }}", array);
	}

	internal static bool cVxvjTFXhinjXGExnL3()
	{
		return e9DjlvFpabYe2pmmrH3 == null;
	}
}
