using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType11<_003Cselector_003Ej__TPar, _003CeventType_003Ej__TPar, _003CeventProperties_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cselector_003Ej__TPar _003Cselector_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CeventType_003Ej__TPar _003CeventType_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CeventProperties_003Ej__TPar _003CeventProperties_003Ei__Field;

	internal static object QpsZIKljU3pjacJsQO;

	public _003Cselector_003Ej__TPar selector => _003Cselector_003Ei__Field;

	public _003CeventType_003Ej__TPar eventType => _003CeventType_003Ei__Field;

	public _003CeventProperties_003Ej__TPar eventProperties => _003CeventProperties_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType11(_003Cselector_003Ej__TPar selector, _003CeventType_003Ej__TPar eventType, _003CeventProperties_003Ej__TPar eventProperties)
	{
		_003Cselector_003Ei__Field = selector;
		_003CeventType_003Ei__Field = eventType;
		_003CeventProperties_003Ei__Field = eventProperties;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType11<_003Cselector_003Ej__TPar, _003CeventType_003Ej__TPar, _003CeventProperties_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType11<_003Cselector_003Ej__TPar, _003CeventType_003Ej__TPar, _003CeventProperties_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cselector_003Ej__TPar>.Default.Equals(_003Cselector_003Ei__Field, anon._003Cselector_003Ei__Field) && EqualityComparer<_003CeventType_003Ej__TPar>.Default.Equals(_003CeventType_003Ei__Field, anon._003CeventType_003Ei__Field))
			{
				return EqualityComparer<_003CeventProperties_003Ej__TPar>.Default.Equals(_003CeventProperties_003Ei__Field, anon._003CeventProperties_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((1729633774 + EqualityComparer<_003Cselector_003Ej__TPar>.Default.GetHashCode(_003Cselector_003Ei__Field)) * -1521134295 + EqualityComparer<_003CeventType_003Ej__TPar>.Default.GetHashCode(_003CeventType_003Ei__Field)) * -1521134295 + EqualityComparer<_003CeventProperties_003Ej__TPar>.Default.GetHashCode(_003CeventProperties_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003Cselector_003Ej__TPar val = _003Cselector_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CeventType_003Ej__TPar val2 = _003CeventType_003Ei__Field;
		array[1] = ((val2 == null) ? null : val2.ToString());
		_003CeventProperties_003Ej__TPar val3 = _003CeventProperties_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ selector = {0}, eventType = {1}, eventProperties = {2} }}", array);
	}

	internal static bool tORp1fZl2QcHgy0KsA()
	{
		return QpsZIKljU3pjacJsQO == null;
	}
}
