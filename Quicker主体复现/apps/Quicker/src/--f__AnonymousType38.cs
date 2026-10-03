using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType38<_003CActionId_003Ej__TPar, _003CBackupTimeUtc_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CActionId_003Ej__TPar _003CActionId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CBackupTimeUtc_003Ej__TPar _003CBackupTimeUtc_003Ei__Field;

	internal static object DoBO0HQCyAA240ogYTS;

	public _003CActionId_003Ej__TPar ActionId => _003CActionId_003Ei__Field;

	public _003CBackupTimeUtc_003Ej__TPar BackupTimeUtc => _003CBackupTimeUtc_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType38(_003CActionId_003Ej__TPar ActionId, _003CBackupTimeUtc_003Ej__TPar BackupTimeUtc)
	{
		_003CActionId_003Ei__Field = ActionId;
		_003CBackupTimeUtc_003Ei__Field = BackupTimeUtc;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType38<_003CActionId_003Ej__TPar, _003CBackupTimeUtc_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType38<_003CActionId_003Ej__TPar, _003CBackupTimeUtc_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CActionId_003Ej__TPar>.Default.Equals(_003CActionId_003Ei__Field, anon._003CActionId_003Ei__Field))
			{
				return EqualityComparer<_003CBackupTimeUtc_003Ej__TPar>.Default.Equals(_003CBackupTimeUtc_003Ei__Field, anon._003CBackupTimeUtc_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1786975080 + EqualityComparer<_003CActionId_003Ej__TPar>.Default.GetHashCode(_003CActionId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CBackupTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CBackupTimeUtc_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CActionId_003Ej__TPar val = _003CActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CBackupTimeUtc_003Ej__TPar val2 = _003CBackupTimeUtc_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ ActionId = {0}, BackupTimeUtc = {1} }}", array);
	}

	internal static bool BhIryxQ7locqIxuVUKv()
	{
		return DoBO0HQCyAA240ogYTS == null;
	}
}
