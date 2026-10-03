using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType7<_003Cstrokes_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cstrokes_003Ej__TPar _003Cstrokes_003Ei__Field;

	internal static object Sh7ExFkCmiZ3WjvJjx;

	public _003Cstrokes_003Ej__TPar strokes => _003Cstrokes_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType7(_003Cstrokes_003Ej__TPar strokes)
	{
		_003Cstrokes_003Ei__Field = strokes;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType7<_003Cstrokes_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType7<_003Cstrokes_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003Cstrokes_003Ej__TPar>.Default.Equals(_003Cstrokes_003Ei__Field, anon._003Cstrokes_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1482093519 + EqualityComparer<_003Cstrokes_003Ej__TPar>.Default.GetHashCode(_003Cstrokes_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003Cstrokes_003Ej__TPar val = _003Cstrokes_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ strokes = {0} }}", array);
	}

	internal static bool qlnSl6aCak4Mq8NCue()
	{
		return Sh7ExFkCmiZ3WjvJjx == null;
	}
}
