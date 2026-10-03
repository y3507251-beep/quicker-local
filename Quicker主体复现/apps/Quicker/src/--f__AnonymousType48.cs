using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType48<_003CContent_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CContent_003Ej__TPar _003CContent_003Ei__Field;

	private static object LanuQOFJ4lUvb0QWyaQ;

	public _003CContent_003Ej__TPar Content => _003CContent_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType48(_003CContent_003Ej__TPar Content)
	{
		_003CContent_003Ei__Field = Content;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType48<_003CContent_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType48<_003CContent_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CContent_003Ej__TPar>.Default.Equals(_003CContent_003Ei__Field, anon._003CContent_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 1785606541 + EqualityComparer<_003CContent_003Ej__TPar>.Default.GetHashCode(_003CContent_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CContent_003Ej__TPar val = _003CContent_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Content = {0} }}", array);
	}

	internal static bool dBhIxMFkuw4jgu9L3WK()
	{
		return LanuQOFJ4lUvb0QWyaQ == null;
	}
}
