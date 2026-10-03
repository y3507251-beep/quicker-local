using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType0<_003Ccontext_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Ccontext_003Ej__TPar _003Ccontext_003Ei__Field;

	internal static object EHCo0vWCaguQBYSGuB;

	public _003Ccontext_003Ej__TPar context => _003Ccontext_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType0(_003Ccontext_003Ej__TPar context)
	{
		_003Ccontext_003Ei__Field = context;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		global::_003C_003Ef__AnonymousType0<_003Ccontext_003Ej__TPar> anon = value as global::_003C_003Ef__AnonymousType0<_003Ccontext_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003Ccontext_003Ej__TPar>.Default.Equals(_003Ccontext_003Ei__Field, anon._003Ccontext_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 176375471 + EqualityComparer<_003Ccontext_003Ej__TPar>.Default.GetHashCode(_003Ccontext_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003Ccontext_003Ej__TPar val = _003Ccontext_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ context = {0} }}", array);
	}

	internal static bool xZe7OyyCMFRFnXXg6S()
	{
		return EHCo0vWCaguQBYSGuB == null;
	}
}
