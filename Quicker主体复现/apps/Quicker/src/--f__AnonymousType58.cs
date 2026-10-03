using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType58<_003CmatchResult_003Ej__TPar, _003Citem_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CmatchResult_003Ej__TPar _003CmatchResult_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Citem_003Ej__TPar _003Citem_003Ei__Field;

	internal static object FbMnR5FmMxSvpCrZOi2;

	public _003CmatchResult_003Ej__TPar matchResult => _003CmatchResult_003Ei__Field;

	public _003Citem_003Ej__TPar item => _003Citem_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType58(_003CmatchResult_003Ej__TPar matchResult, _003Citem_003Ej__TPar item)
	{
		_003CmatchResult_003Ei__Field = matchResult;
		_003Citem_003Ei__Field = item;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType58<_003CmatchResult_003Ej__TPar, _003Citem_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType58<_003CmatchResult_003Ej__TPar, _003Citem_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CmatchResult_003Ej__TPar>.Default.Equals(_003CmatchResult_003Ei__Field, anon._003CmatchResult_003Ei__Field))
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
		return (-559806297 + EqualityComparer<_003CmatchResult_003Ej__TPar>.Default.GetHashCode(_003CmatchResult_003Ei__Field)) * -1521134295 + EqualityComparer<_003Citem_003Ej__TPar>.Default.GetHashCode(_003Citem_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CmatchResult_003Ej__TPar val = _003CmatchResult_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Citem_003Ej__TPar val2 = _003Citem_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ matchResult = {0}, item = {1} }}", array);
	}

	internal static bool k8udEoFsqIHeqHgrPWT()
	{
		return FbMnR5FmMxSvpCrZOi2 == null;
	}
}
