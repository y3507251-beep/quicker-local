using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType17<_003CScript_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CScript_003Ej__TPar _003CScript_003Ei__Field;

	internal static object W9bbJgsyXjxBxWO7GY;

	public _003CScript_003Ej__TPar Script => _003CScript_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType17(_003CScript_003Ej__TPar Script)
	{
		_003CScript_003Ei__Field = Script;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType17<_003CScript_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType17<_003CScript_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CScript_003Ej__TPar>.Default.Equals(_003CScript_003Ei__Field, anon._003CScript_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -432046371 + EqualityComparer<_003CScript_003Ej__TPar>.Default.GetHashCode(_003CScript_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CScript_003Ej__TPar val = _003CScript_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Script = {0} }}", array);
	}

	internal static bool SLCndGCvBn48k00Vta()
	{
		return W9bbJgsyXjxBxWO7GY == null;
	}
}
