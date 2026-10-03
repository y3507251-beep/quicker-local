using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType5<_003Cfile_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cfile_003Ej__TPar _003Cfile_003Ei__Field;

	internal static object XovNbBKVIn34XreTLQ;

	public _003Cfile_003Ej__TPar file => _003Cfile_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType5(_003Cfile_003Ej__TPar file)
	{
		_003Cfile_003Ei__Field = file;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType5<_003Cfile_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType5<_003Cfile_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003Cfile_003Ej__TPar>.Default.Equals(_003Cfile_003Ei__Field, anon._003Cfile_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 98418618 + EqualityComparer<_003Cfile_003Ej__TPar>.Default.GetHashCode(_003Cfile_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003Cfile_003Ej__TPar val = _003Cfile_003Ei__Field;
		array[0] = ((val == null) ? null : val.ToString());
		return string.Format(null, "{{ file = {0} }}", array);
	}

	internal static bool oeid6pB6Q0l1AeOU3v()
	{
		return XovNbBKVIn34XreTLQ == null;
	}
}
