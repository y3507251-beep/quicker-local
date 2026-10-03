using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType16<_003CRect_003Ej__TPar, _003CMonitor_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CRect_003Ej__TPar _003CRect_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CMonitor_003Ej__TPar _003CMonitor_003Ei__Field;

	internal static object TaLSgNwpWIgyBf1xFf;

	public _003CRect_003Ej__TPar Rect => _003CRect_003Ei__Field;

	public _003CMonitor_003Ej__TPar Monitor => _003CMonitor_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType16(_003CRect_003Ej__TPar Rect, _003CMonitor_003Ej__TPar Monitor)
	{
		_003CRect_003Ei__Field = Rect;
		_003CMonitor_003Ei__Field = Monitor;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType16<_003CRect_003Ej__TPar, _003CMonitor_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType16<_003CRect_003Ej__TPar, _003CMonitor_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CRect_003Ej__TPar>.Default.Equals(_003CRect_003Ei__Field, anon._003CRect_003Ei__Field))
			{
				return EqualityComparer<_003CMonitor_003Ej__TPar>.Default.Equals(_003CMonitor_003Ei__Field, anon._003CMonitor_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (589878102 + EqualityComparer<_003CRect_003Ej__TPar>.Default.GetHashCode(_003CRect_003Ei__Field)) * -1521134295 + EqualityComparer<_003CMonitor_003Ej__TPar>.Default.GetHashCode(_003CMonitor_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CRect_003Ej__TPar val = _003CRect_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CMonitor_003Ej__TPar val2 = _003CMonitor_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ Rect = {0}, Monitor = {1} }}", array);
	}

	internal static bool tfbcbATOHb5CfN5B05()
	{
		return TaLSgNwpWIgyBf1xFf == null;
	}
}
