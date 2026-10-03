using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType24<_003Ctext_003Ej__TPar, _003CmaxResults_003Ej__TPar, _003CstartTime_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Ctext_003Ej__TPar _003Ctext_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CmaxResults_003Ej__TPar _003CmaxResults_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CstartTime_003Ej__TPar _003CstartTime_003Ei__Field;

	internal static object Q18vjVQ3g1qeJVTnLya;

	public _003Ctext_003Ej__TPar text => _003Ctext_003Ei__Field;

	public _003CmaxResults_003Ej__TPar maxResults => _003CmaxResults_003Ei__Field;

	public _003CstartTime_003Ej__TPar startTime => _003CstartTime_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType24(_003Ctext_003Ej__TPar text, _003CmaxResults_003Ej__TPar maxResults, _003CstartTime_003Ej__TPar startTime)
	{
		_003Ctext_003Ei__Field = text;
		_003CmaxResults_003Ei__Field = maxResults;
		_003CstartTime_003Ei__Field = startTime;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType24<_003Ctext_003Ej__TPar, _003CmaxResults_003Ej__TPar, _003CstartTime_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType24<_003Ctext_003Ej__TPar, _003CmaxResults_003Ej__TPar, _003CstartTime_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Ctext_003Ej__TPar>.Default.Equals(_003Ctext_003Ei__Field, anon._003Ctext_003Ei__Field) && EqualityComparer<_003CmaxResults_003Ej__TPar>.Default.Equals(_003CmaxResults_003Ei__Field, anon._003CmaxResults_003Ei__Field))
			{
				return EqualityComparer<_003CstartTime_003Ej__TPar>.Default.Equals(_003CstartTime_003Ei__Field, anon._003CstartTime_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1615271790 + EqualityComparer<_003Ctext_003Ej__TPar>.Default.GetHashCode(_003Ctext_003Ei__Field)) * -1521134295 + EqualityComparer<_003CmaxResults_003Ej__TPar>.Default.GetHashCode(_003CmaxResults_003Ei__Field)) * -1521134295 + EqualityComparer<_003CstartTime_003Ej__TPar>.Default.GetHashCode(_003CstartTime_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003Ctext_003Ej__TPar val = _003Ctext_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CmaxResults_003Ej__TPar val2 = _003CmaxResults_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CstartTime_003Ej__TPar val3 = _003CstartTime_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ text = {0}, maxResults = {1}, startTime = {2} }}", array);
	}

	internal static bool pcDx2IQEJTYbC27aLiA()
	{
		return Q18vjVQ3g1qeJVTnLya == null;
	}
}
