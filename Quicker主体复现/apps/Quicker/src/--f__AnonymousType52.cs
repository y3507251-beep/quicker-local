using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType52<_003Csuccess_003Ej__TPar, _003Cresult_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Csuccess_003Ej__TPar _003Csuccess_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cresult_003Ej__TPar _003Cresult_003Ei__Field;

	internal static object bYtW7EFivslrNEajsQK;

	public _003Csuccess_003Ej__TPar success => _003Csuccess_003Ei__Field;

	public _003Cresult_003Ej__TPar result => _003Cresult_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType52(_003Csuccess_003Ej__TPar success, _003Cresult_003Ej__TPar result)
	{
		_003Csuccess_003Ei__Field = success;
		_003Cresult_003Ei__Field = result;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType52<_003Csuccess_003Ej__TPar, _003Cresult_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType52<_003Csuccess_003Ej__TPar, _003Cresult_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Csuccess_003Ej__TPar>.Default.Equals(_003Csuccess_003Ei__Field, anon._003Csuccess_003Ei__Field))
			{
				return EqualityComparer<_003Cresult_003Ej__TPar>.Default.Equals(_003Cresult_003Ei__Field, anon._003Cresult_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1885580186 + EqualityComparer<_003Csuccess_003Ej__TPar>.Default.GetHashCode(_003Csuccess_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cresult_003Ej__TPar>.Default.GetHashCode(_003Cresult_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Csuccess_003Ej__TPar val = _003Csuccess_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cresult_003Ej__TPar val2 = _003Cresult_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ success = {0}, result = {1} }}", array);
	}

	internal static bool VtwaugFlowI6TAQ4Oxw()
	{
		return bYtW7EFivslrNEajsQK == null;
	}
}
