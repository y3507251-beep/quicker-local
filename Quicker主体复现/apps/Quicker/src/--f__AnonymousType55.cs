using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType55<_003Cidentifier_003Ej__TPar, _003Cdata_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cidentifier_003Ej__TPar _003Cidentifier_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cdata_003Ej__TPar _003Cdata_003Ei__Field;

	private static object I1pZGgFMPFuaEhHLP7T;

	public _003Cidentifier_003Ej__TPar identifier => _003Cidentifier_003Ei__Field;

	public _003Cdata_003Ej__TPar data => _003Cdata_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType55(_003Cidentifier_003Ej__TPar identifier, _003Cdata_003Ej__TPar data)
	{
		_003Cidentifier_003Ei__Field = identifier;
		_003Cdata_003Ei__Field = data;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType55<_003Cidentifier_003Ej__TPar, _003Cdata_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType55<_003Cidentifier_003Ej__TPar, _003Cdata_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cidentifier_003Ej__TPar>.Default.Equals(_003Cidentifier_003Ei__Field, anon._003Cidentifier_003Ei__Field))
			{
				return EqualityComparer<_003Cdata_003Ej__TPar>.Default.Equals(_003Cdata_003Ei__Field, anon._003Cdata_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1597470549 + EqualityComparer<_003Cidentifier_003Ej__TPar>.Default.GetHashCode(_003Cidentifier_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cdata_003Ej__TPar>.Default.GetHashCode(_003Cdata_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Cidentifier_003Ej__TPar val = _003Cidentifier_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cdata_003Ej__TPar val2 = _003Cdata_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ identifier = {0}, data = {1} }}", array);
	}

	internal static bool I9y3PQFU7QAbLcqmLjo()
	{
		return I1pZGgFMPFuaEhHLP7T == null;
	}
}
