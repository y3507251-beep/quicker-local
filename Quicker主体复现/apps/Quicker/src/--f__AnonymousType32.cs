using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType32<_003CId_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CId_003Ej__TPar _003CId_003Ei__Field;

	private static object fYmNkGQZ0sl5fQs0nTc;

	public _003CId_003Ej__TPar Id => _003CId_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType32(_003CId_003Ej__TPar Id)
	{
		_003CId_003Ei__Field = Id;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType32<_003CId_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType32<_003CId_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CId_003Ej__TPar>.Default.Equals(_003CId_003Ei__Field, anon._003CId_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1271893453 + EqualityComparer<_003CId_003Ej__TPar>.Default.GetHashCode(_003CId_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CId_003Ej__TPar val = _003CId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Id = {0} }}", array);
	}

	internal static bool dR6uZVQ5vaxZQcGeoqG()
	{
		return fYmNkGQZ0sl5fQs0nTc == null;
	}
}
