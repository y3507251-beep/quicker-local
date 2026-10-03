using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType14<_003CUrl_003Ej__TPar, _003CWindowId_003Ej__TPar, _003CWindowInfo_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CUrl_003Ej__TPar _003CUrl_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CWindowId_003Ej__TPar _003CWindowId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CWindowInfo_003Ej__TPar _003CWindowInfo_003Ei__Field;

	internal static object QrLw9SUM7xLYV705N2;

	public _003CUrl_003Ej__TPar Url => _003CUrl_003Ei__Field;

	public _003CWindowId_003Ej__TPar WindowId => _003CWindowId_003Ei__Field;

	public _003CWindowInfo_003Ej__TPar WindowInfo => _003CWindowInfo_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType14(_003CUrl_003Ej__TPar Url, _003CWindowId_003Ej__TPar WindowId, _003CWindowInfo_003Ej__TPar WindowInfo)
	{
		_003CUrl_003Ei__Field = Url;
		_003CWindowId_003Ei__Field = WindowId;
		_003CWindowInfo_003Ei__Field = WindowInfo;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType14<_003CUrl_003Ej__TPar, _003CWindowId_003Ej__TPar, _003CWindowInfo_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType14<_003CUrl_003Ej__TPar, _003CWindowId_003Ej__TPar, _003CWindowInfo_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CUrl_003Ej__TPar>.Default.Equals(_003CUrl_003Ei__Field, anon._003CUrl_003Ei__Field) && EqualityComparer<_003CWindowId_003Ej__TPar>.Default.Equals(_003CWindowId_003Ei__Field, anon._003CWindowId_003Ei__Field))
			{
				return EqualityComparer<_003CWindowInfo_003Ej__TPar>.Default.Equals(_003CWindowInfo_003Ei__Field, anon._003CWindowInfo_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-854275760 + EqualityComparer<_003CUrl_003Ej__TPar>.Default.GetHashCode(_003CUrl_003Ei__Field)) * -1521134295 + EqualityComparer<_003CWindowId_003Ej__TPar>.Default.GetHashCode(_003CWindowId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CWindowInfo_003Ej__TPar>.Default.GetHashCode(_003CWindowInfo_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CUrl_003Ej__TPar val = _003CUrl_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CWindowId_003Ej__TPar val2 = _003CWindowId_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CWindowInfo_003Ej__TPar val3 = _003CWindowInfo_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ Url = {0}, WindowId = {1}, WindowInfo = {2} }}", array);
	}

	internal static bool u0KYZRx4wehZAG5ESE()
	{
		return QrLw9SUM7xLYV705N2 == null;
	}
}
