using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType6<_003Cstrokes_003Ej__TPar, _003Cformats_003Ej__TPar, _003Cdata_options_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cstrokes_003Ej__TPar _003Cstrokes_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cformats_003Ej__TPar _003Cformats_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cdata_options_003Ej__TPar _003Cdata_options_003Ei__Field;

	internal static object jm6LOtdBwSoWTT9mtw;

	public _003Cstrokes_003Ej__TPar strokes => _003Cstrokes_003Ei__Field;

	public _003Cformats_003Ej__TPar formats => _003Cformats_003Ei__Field;

	public _003Cdata_options_003Ej__TPar data_options => _003Cdata_options_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType6(_003Cstrokes_003Ej__TPar strokes, _003Cformats_003Ej__TPar formats, _003Cdata_options_003Ej__TPar data_options)
	{
		_003Cstrokes_003Ei__Field = strokes;
		_003Cformats_003Ei__Field = formats;
		_003Cdata_options_003Ei__Field = data_options;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType6<_003Cstrokes_003Ej__TPar, _003Cformats_003Ej__TPar, _003Cdata_options_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType6<_003Cstrokes_003Ej__TPar, _003Cformats_003Ej__TPar, _003Cdata_options_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cstrokes_003Ej__TPar>.Default.Equals(_003Cstrokes_003Ei__Field, anon._003Cstrokes_003Ei__Field) && EqualityComparer<_003Cformats_003Ej__TPar>.Default.Equals(_003Cformats_003Ei__Field, anon._003Cformats_003Ei__Field))
			{
				return EqualityComparer<_003Cdata_options_003Ej__TPar>.Default.Equals(_003Cdata_options_003Ei__Field, anon._003Cdata_options_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-389736622 + EqualityComparer<_003Cstrokes_003Ej__TPar>.Default.GetHashCode(_003Cstrokes_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cformats_003Ej__TPar>.Default.GetHashCode(_003Cformats_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cdata_options_003Ej__TPar>.Default.GetHashCode(_003Cdata_options_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003Cstrokes_003Ej__TPar val = _003Cstrokes_003Ei__Field;
		array[0] = ((val == null) ? null : val.ToString());
		_003Cformats_003Ej__TPar val2 = _003Cformats_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003Cdata_options_003Ej__TPar val3 = _003Cdata_options_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ strokes = {0}, formats = {1}, data_options = {2} }}", array);
	}

	internal static bool y5ksY3OGjZrdETlYkI()
	{
		return jm6LOtdBwSoWTT9mtw == null;
	}
}
