using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType8<_003Cx_003Ej__TPar, _003Cy_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cx_003Ej__TPar _003Cx_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cy_003Ej__TPar _003Cy_003Ei__Field;

	private static object uJl5OjN3dGE12ApsLD;

	public _003Cx_003Ej__TPar x => _003Cx_003Ei__Field;

	public _003Cy_003Ej__TPar y => _003Cy_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType8(_003Cx_003Ej__TPar x, _003Cy_003Ej__TPar y)
	{
		_003Cx_003Ei__Field = x;
		_003Cy_003Ei__Field = y;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType8<_003Cx_003Ej__TPar, _003Cy_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType8<_003Cx_003Ej__TPar, _003Cy_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cx_003Ej__TPar>.Default.Equals(_003Cx_003Ei__Field, anon._003Cx_003Ei__Field))
			{
				return EqualityComparer<_003Cy_003Ej__TPar>.Default.Equals(_003Cy_003Ei__Field, anon._003Cy_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1819746159 + EqualityComparer<_003Cx_003Ej__TPar>.Default.GetHashCode(_003Cx_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cy_003Ej__TPar>.Default.GetHashCode(_003Cy_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Cx_003Ej__TPar val = _003Cx_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cy_003Ej__TPar val2 = _003Cy_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ x = {0}, y = {1} }}", array);
	}

	internal static bool c2or6R9E3bHK66oxET()
	{
		return uJl5OjN3dGE12ApsLD == null;
	}
}
