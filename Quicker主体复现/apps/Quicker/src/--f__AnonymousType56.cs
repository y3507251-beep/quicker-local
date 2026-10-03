using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType56<_003CFile_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CFile_003Ej__TPar _003CFile_003Ei__Field;

	internal static object tLlAGnFIhgn877yRELX;

	public _003CFile_003Ej__TPar File => _003CFile_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType56(_003CFile_003Ej__TPar File)
	{
		_003CFile_003Ei__Field = File;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType56<_003CFile_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType56<_003CFile_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CFile_003Ej__TPar>.Default.Equals(_003CFile_003Ei__Field, anon._003CFile_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -935290278 + EqualityComparer<_003CFile_003Ej__TPar>.Default.GetHashCode(_003CFile_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CFile_003Ej__TPar val = _003CFile_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ File = {0} }}", array);
	}

	internal static bool ycPPAyF6ynNVlAXisD0()
	{
		return tLlAGnFIhgn877yRELX == null;
	}
}
