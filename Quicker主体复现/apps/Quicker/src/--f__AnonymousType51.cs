using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType51<_003Csuccess_003Ej__TPar, _003CerrMsg_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Csuccess_003Ej__TPar _003Csuccess_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CerrMsg_003Ej__TPar _003CerrMsg_003Ei__Field;

	private static object EdX07wFfGlNZa3lgILO;

	public _003Csuccess_003Ej__TPar success => _003Csuccess_003Ei__Field;

	public _003CerrMsg_003Ej__TPar errMsg => _003CerrMsg_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType51(_003Csuccess_003Ej__TPar success, _003CerrMsg_003Ej__TPar errMsg)
	{
		_003Csuccess_003Ei__Field = success;
		_003CerrMsg_003Ei__Field = errMsg;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType51<_003Csuccess_003Ej__TPar, _003CerrMsg_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType51<_003Csuccess_003Ej__TPar, _003CerrMsg_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Csuccess_003Ej__TPar>.Default.Equals(_003Csuccess_003Ei__Field, anon._003Csuccess_003Ei__Field))
			{
				return EqualityComparer<_003CerrMsg_003Ej__TPar>.Default.Equals(_003CerrMsg_003Ei__Field, anon._003CerrMsg_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-546116049 + EqualityComparer<_003Csuccess_003Ej__TPar>.Default.GetHashCode(_003Csuccess_003Ei__Field)) * -1521134295 + EqualityComparer<_003CerrMsg_003Ej__TPar>.Default.GetHashCode(_003CerrMsg_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Csuccess_003Ej__TPar val = _003Csuccess_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CerrMsg_003Ej__TPar val2 = _003CerrMsg_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ success = {0}, errMsg = {1} }}", array);
	}

	internal static bool OoGTLkFbdfjfjOp1i0k()
	{
		return EdX07wFfGlNZa3lgILO == null;
	}
}
