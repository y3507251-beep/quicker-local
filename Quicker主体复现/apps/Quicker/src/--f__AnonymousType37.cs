using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType37<_003CBackupType_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CBackupType_003Ej__TPar _003CBackupType_003Ei__Field;

	private static object DEFI5xQTCJfHhrshJ4l;

	public _003CBackupType_003Ej__TPar BackupType => _003CBackupType_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType37(_003CBackupType_003Ej__TPar BackupType)
	{
		_003CBackupType_003Ei__Field = BackupType;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType37<_003CBackupType_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType37<_003CBackupType_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CBackupType_003Ej__TPar>.Default.Equals(_003CBackupType_003Ei__Field, anon._003CBackupType_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 1940846118 + EqualityComparer<_003CBackupType_003Ej__TPar>.Default.GetHashCode(_003CBackupType_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CBackupType_003Ej__TPar val = _003CBackupType_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ BackupType = {0} }}", array);
	}

	internal static bool jdEXeKQmAFVoQFmnE1f()
	{
		return DEFI5xQTCJfHhrshJ4l == null;
	}
}
