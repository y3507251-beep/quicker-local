using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType2<_003CSearchText_003Ej__TPar, _003CLastSelectTime_003Ej__TPar, _003CPluginWithConditions_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSearchText_003Ej__TPar _003CSearchText_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLastSelectTime_003Ej__TPar _003CLastSelectTime_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CPluginWithConditions_003Ej__TPar _003CPluginWithConditions_003Ei__Field;

	internal static object l6ZwbFnNhubAUBFWKL;

	public _003CSearchText_003Ej__TPar SearchText => _003CSearchText_003Ei__Field;

	public _003CLastSelectTime_003Ej__TPar LastSelectTime => _003CLastSelectTime_003Ei__Field;

	public _003CPluginWithConditions_003Ej__TPar PluginWithConditions => _003CPluginWithConditions_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType2(_003CSearchText_003Ej__TPar SearchText, _003CLastSelectTime_003Ej__TPar LastSelectTime, _003CPluginWithConditions_003Ej__TPar PluginWithConditions)
	{
		_003CSearchText_003Ei__Field = SearchText;
		_003CLastSelectTime_003Ei__Field = LastSelectTime;
		_003CPluginWithConditions_003Ei__Field = PluginWithConditions;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType2<_003CSearchText_003Ej__TPar, _003CLastSelectTime_003Ej__TPar, _003CPluginWithConditions_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType2<_003CSearchText_003Ej__TPar, _003CLastSelectTime_003Ej__TPar, _003CPluginWithConditions_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CSearchText_003Ej__TPar>.Default.Equals(_003CSearchText_003Ei__Field, anon._003CSearchText_003Ei__Field) && EqualityComparer<_003CLastSelectTime_003Ej__TPar>.Default.Equals(_003CLastSelectTime_003Ei__Field, anon._003CLastSelectTime_003Ei__Field))
			{
				return EqualityComparer<_003CPluginWithConditions_003Ej__TPar>.Default.Equals(_003CPluginWithConditions_003Ei__Field, anon._003CPluginWithConditions_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((875671283 + EqualityComparer<_003CSearchText_003Ej__TPar>.Default.GetHashCode(_003CSearchText_003Ei__Field)) * -1521134295 + EqualityComparer<_003CLastSelectTime_003Ej__TPar>.Default.GetHashCode(_003CLastSelectTime_003Ei__Field)) * -1521134295 + EqualityComparer<_003CPluginWithConditions_003Ej__TPar>.Default.GetHashCode(_003CPluginWithConditions_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CSearchText_003Ej__TPar val = _003CSearchText_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CLastSelectTime_003Ej__TPar val2 = _003CLastSelectTime_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CPluginWithConditions_003Ej__TPar val3 = _003CPluginWithConditions_003Ei__Field;
		array[2] = ((val3 == null) ? null : val3.ToString());
		return string.Format(null, "{{ SearchText = {0}, LastSelectTime = {1}, PluginWithConditions = {2} }}", array);
	}

	internal static bool hJl7I6eygGxH2Lti2W()
	{
		return l6ZwbFnNhubAUBFWKL == null;
	}
}
