using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType53<_003Csuccess_003Ej__TPar, _003Cerror_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Csuccess_003Ej__TPar _003Csuccess_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cerror_003Ej__TPar _003Cerror_003Ei__Field;

	internal static object T9aPWoF5iiIJnjCikVq;

	public _003Csuccess_003Ej__TPar success => _003Csuccess_003Ei__Field;

	public _003Cerror_003Ej__TPar error => _003Cerror_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType53(_003Csuccess_003Ej__TPar success, _003Cerror_003Ej__TPar error)
	{
		_003Csuccess_003Ei__Field = success;
		_003Cerror_003Ei__Field = error;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType53<_003Csuccess_003Ej__TPar, _003Cerror_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType53<_003Csuccess_003Ej__TPar, _003Cerror_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Csuccess_003Ej__TPar>.Default.Equals(_003Csuccess_003Ei__Field, anon._003Csuccess_003Ei__Field))
			{
				return EqualityComparer<_003Cerror_003Ej__TPar>.Default.Equals(_003Cerror_003Ei__Field, anon._003Cerror_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1980936759 + EqualityComparer<_003Csuccess_003Ej__TPar>.Default.GetHashCode(_003Csuccess_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cerror_003Ej__TPar>.Default.GetHashCode(_003Cerror_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Csuccess_003Ej__TPar val = _003Csuccess_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cerror_003Ej__TPar val2 = _003Cerror_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ success = {0}, error = {1} }}", array);
	}

	internal static bool M3efHXFYYAgp7mAcQ9q()
	{
		return T9aPWoF5iiIJnjCikVq == null;
	}
}
