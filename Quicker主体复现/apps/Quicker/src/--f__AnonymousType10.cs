using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType10<_003CeventType_003Ej__TPar, _003Cselector_003Ej__TPar, _003Ctimeout_003Ej__TPar, _003CeventParams_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CeventType_003Ej__TPar _003CeventType_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cselector_003Ej__TPar _003Cselector_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Ctimeout_003Ej__TPar _003Ctimeout_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CeventParams_003Ej__TPar _003CeventParams_003Ei__Field;

	private static object zXxpOTbeePtap2IGUd;

	public _003CeventType_003Ej__TPar eventType => _003CeventType_003Ei__Field;

	public _003Cselector_003Ej__TPar selector => _003Cselector_003Ei__Field;

	public _003Ctimeout_003Ej__TPar timeout => _003Ctimeout_003Ei__Field;

	public _003CeventParams_003Ej__TPar eventParams => _003CeventParams_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType10(_003CeventType_003Ej__TPar eventType, _003Cselector_003Ej__TPar selector, _003Ctimeout_003Ej__TPar timeout, _003CeventParams_003Ej__TPar eventParams)
	{
		_003CeventType_003Ei__Field = eventType;
		_003Cselector_003Ei__Field = selector;
		_003Ctimeout_003Ei__Field = timeout;
		_003CeventParams_003Ei__Field = eventParams;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType10<_003CeventType_003Ej__TPar, _003Cselector_003Ej__TPar, _003Ctimeout_003Ej__TPar, _003CeventParams_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType10<_003CeventType_003Ej__TPar, _003Cselector_003Ej__TPar, _003Ctimeout_003Ej__TPar, _003CeventParams_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CeventType_003Ej__TPar>.Default.Equals(_003CeventType_003Ei__Field, anon._003CeventType_003Ei__Field) && EqualityComparer<_003Cselector_003Ej__TPar>.Default.Equals(_003Cselector_003Ei__Field, anon._003Cselector_003Ei__Field) && EqualityComparer<_003Ctimeout_003Ej__TPar>.Default.Equals(_003Ctimeout_003Ei__Field, anon._003Ctimeout_003Ei__Field))
			{
				return EqualityComparer<_003CeventParams_003Ej__TPar>.Default.Equals(_003CeventParams_003Ei__Field, anon._003CeventParams_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (((1716738192 + EqualityComparer<_003CeventType_003Ej__TPar>.Default.GetHashCode(_003CeventType_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cselector_003Ej__TPar>.Default.GetHashCode(_003Cselector_003Ei__Field)) * -1521134295 + EqualityComparer<_003Ctimeout_003Ej__TPar>.Default.GetHashCode(_003Ctimeout_003Ei__Field)) * -1521134295 + EqualityComparer<_003CeventParams_003Ej__TPar>.Default.GetHashCode(_003CeventParams_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[4];
		_003CeventType_003Ej__TPar val = _003CeventType_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cselector_003Ej__TPar val2 = _003Cselector_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003Ctimeout_003Ej__TPar val3 = _003Ctimeout_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		_003CeventParams_003Ej__TPar val4 = _003CeventParams_003Ei__Field;
		array[3] = ((val4 != null) ? val4.ToString() : null);
		return string.Format(null, "{{ eventType = {0}, selector = {1}, timeout = {2}, eventParams = {3} }}", array);
	}

	internal static bool stkkQXq4UgVjetE9be()
	{
		return zXxpOTbeePtap2IGUd == null;
	}
}
