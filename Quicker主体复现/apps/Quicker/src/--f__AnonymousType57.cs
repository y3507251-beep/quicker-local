using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType57<_003CmatchResult_003Ej__TPar, _003CmatchResultDesc_003Ej__TPar, _003Citem_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CmatchResult_003Ej__TPar _003CmatchResult_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CmatchResultDesc_003Ej__TPar _003CmatchResultDesc_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Citem_003Ej__TPar _003Citem_003Ei__Field;

	internal static object ALQnbXFSbp0WDHgH3Hk;

	public _003CmatchResult_003Ej__TPar matchResult => _003CmatchResult_003Ei__Field;

	public _003CmatchResultDesc_003Ej__TPar matchResultDesc => _003CmatchResultDesc_003Ei__Field;

	public _003Citem_003Ej__TPar item => _003Citem_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType57(_003CmatchResult_003Ej__TPar matchResult, _003CmatchResultDesc_003Ej__TPar matchResultDesc, _003Citem_003Ej__TPar item)
	{
		_003CmatchResult_003Ei__Field = matchResult;
		_003CmatchResultDesc_003Ei__Field = matchResultDesc;
		_003Citem_003Ei__Field = item;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType57<_003CmatchResult_003Ej__TPar, _003CmatchResultDesc_003Ej__TPar, _003Citem_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType57<_003CmatchResult_003Ej__TPar, _003CmatchResultDesc_003Ej__TPar, _003Citem_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CmatchResult_003Ej__TPar>.Default.Equals(_003CmatchResult_003Ei__Field, anon._003CmatchResult_003Ei__Field) && EqualityComparer<_003CmatchResultDesc_003Ej__TPar>.Default.Equals(_003CmatchResultDesc_003Ei__Field, anon._003CmatchResultDesc_003Ei__Field))
			{
				return EqualityComparer<_003Citem_003Ej__TPar>.Default.Equals(_003Citem_003Ei__Field, anon._003Citem_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((249965504 + EqualityComparer<_003CmatchResult_003Ej__TPar>.Default.GetHashCode(_003CmatchResult_003Ei__Field)) * -1521134295 + EqualityComparer<_003CmatchResultDesc_003Ej__TPar>.Default.GetHashCode(_003CmatchResultDesc_003Ei__Field)) * -1521134295 + EqualityComparer<_003Citem_003Ej__TPar>.Default.GetHashCode(_003Citem_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CmatchResult_003Ej__TPar val = _003CmatchResult_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CmatchResultDesc_003Ej__TPar val2 = _003CmatchResultDesc_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003Citem_003Ej__TPar val3 = _003Citem_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ matchResult = {0}, matchResultDesc = {1}, item = {2} }}", array);
	}

	internal static bool KUOZ71FwALcrEKKQHAg()
	{
		return ALQnbXFSbp0WDHgH3Hk == null;
	}
}
