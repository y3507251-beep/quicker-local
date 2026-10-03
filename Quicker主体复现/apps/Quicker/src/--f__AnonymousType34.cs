using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType34<_003CLocalOnly_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CLocalOnly_003Ej__TPar _003CLocalOnly_003Ei__Field;

	internal static object Y60H6nQPLYsKXmLNJbN;

	public _003CLocalOnly_003Ej__TPar LocalOnly => _003CLocalOnly_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType34(_003CLocalOnly_003Ej__TPar LocalOnly)
	{
		_003CLocalOnly_003Ei__Field = LocalOnly;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType34<_003CLocalOnly_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType34<_003CLocalOnly_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CLocalOnly_003Ej__TPar>.Default.Equals(_003CLocalOnly_003Ei__Field, anon._003CLocalOnly_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 594731549 + EqualityComparer<_003CLocalOnly_003Ej__TPar>.Default.GetHashCode(_003CLocalOnly_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CLocalOnly_003Ej__TPar val = _003CLocalOnly_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ LocalOnly = {0} }}", array);
	}

	internal static bool o700vCQMbn2JSXq0xD4()
	{
		return Y60H6nQPLYsKXmLNJbN == null;
	}
}
