using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType23<_003CwindowId_003Ej__TPar, _003CtabId_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CwindowId_003Ej__TPar _003CwindowId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CtabId_003Ej__TPar _003CtabId_003Ei__Field;

	private static object MDISXwQe1qTgJsooXjk;

	public _003CwindowId_003Ej__TPar windowId => _003CwindowId_003Ei__Field;

	public _003CtabId_003Ej__TPar tabId => _003CtabId_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType23(_003CwindowId_003Ej__TPar windowId, _003CtabId_003Ej__TPar tabId)
	{
		_003CwindowId_003Ei__Field = windowId;
		_003CtabId_003Ei__Field = tabId;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType23<_003CwindowId_003Ej__TPar, _003CtabId_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType23<_003CwindowId_003Ej__TPar, _003CtabId_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CwindowId_003Ej__TPar>.Default.Equals(_003CwindowId_003Ei__Field, anon._003CwindowId_003Ei__Field))
			{
				return EqualityComparer<_003CtabId_003Ej__TPar>.Default.Equals(_003CtabId_003Ei__Field, anon._003CtabId_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1243389301 + EqualityComparer<_003CwindowId_003Ej__TPar>.Default.GetHashCode(_003CwindowId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CtabId_003Ej__TPar>.Default.GetHashCode(_003CtabId_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CwindowId_003Ej__TPar val = _003CwindowId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CtabId_003Ej__TPar val2 = _003CtabId_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ windowId = {0}, tabId = {1} }}", array);
	}

	internal static bool S7VefmQjmiI0ieHDpqZ()
	{
		return MDISXwQe1qTgJsooXjk == null;
	}
}
