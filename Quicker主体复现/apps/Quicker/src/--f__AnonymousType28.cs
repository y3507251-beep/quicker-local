using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType28<_003CNow_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CNow_003Ej__TPar _003CNow_003Ei__Field;

	private static object A7wo1YQaXdwsvZFmh84;

	public _003CNow_003Ej__TPar Now => _003CNow_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType28(_003CNow_003Ej__TPar Now)
	{
		_003CNow_003Ei__Field = Now;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType28<_003CNow_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType28<_003CNow_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CNow_003Ej__TPar>.Default.Equals(_003CNow_003Ei__Field, anon._003CNow_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1633403526 + EqualityComparer<_003CNow_003Ej__TPar>.Default.GetHashCode(_003CNow_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CNow_003Ej__TPar val = _003CNow_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Now = {0} }}", array);
	}

	internal static bool LR0URcQrP0OshGGFyCr()
	{
		return A7wo1YQaXdwsvZFmh84 == null;
	}
}
