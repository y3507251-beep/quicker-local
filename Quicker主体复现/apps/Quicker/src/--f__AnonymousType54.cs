using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType54<_003Cmessage_003Ej__TPar, _003Cstack_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cmessage_003Ej__TPar _003Cmessage_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cstack_003Ej__TPar _003Cstack_003Ei__Field;

	internal static object lrIb4vFRxBrdIPbqteR;

	public _003Cmessage_003Ej__TPar message => _003Cmessage_003Ei__Field;

	public _003Cstack_003Ej__TPar stack => _003Cstack_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType54(_003Cmessage_003Ej__TPar message, _003Cstack_003Ej__TPar stack)
	{
		_003Cmessage_003Ei__Field = message;
		_003Cstack_003Ei__Field = stack;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType54<_003Cmessage_003Ej__TPar, _003Cstack_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType54<_003Cmessage_003Ej__TPar, _003Cstack_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cmessage_003Ej__TPar>.Default.Equals(_003Cmessage_003Ei__Field, anon._003Cmessage_003Ei__Field))
			{
				return EqualityComparer<_003Cstack_003Ej__TPar>.Default.Equals(_003Cstack_003Ei__Field, anon._003Cstack_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-2113257463 + EqualityComparer<_003Cmessage_003Ej__TPar>.Default.GetHashCode(_003Cmessage_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cstack_003Ej__TPar>.Default.GetHashCode(_003Cstack_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Cmessage_003Ej__TPar val = _003Cmessage_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cstack_003Ej__TPar val2 = _003Cstack_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ message = {0}, stack = {1} }}", array);
	}

	internal static bool wRHf9IFggpI4WBEXd0i()
	{
		return lrIb4vFRxBrdIPbqteR == null;
	}
}
