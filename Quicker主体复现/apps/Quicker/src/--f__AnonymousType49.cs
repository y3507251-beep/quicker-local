using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType49<_003CSource_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSource_003Ej__TPar _003CSource_003Ei__Field;

	internal static object rJN3Y9FrCRGPpXxss7t;

	public _003CSource_003Ej__TPar Source => _003CSource_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType49(_003CSource_003Ej__TPar Source)
	{
		_003CSource_003Ei__Field = Source;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType49<_003CSource_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType49<_003CSource_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CSource_003Ej__TPar>.Default.Equals(_003CSource_003Ei__Field, anon._003CSource_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 666493579 + EqualityComparer<_003CSource_003Ej__TPar>.Default.GetHashCode(_003CSource_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CSource_003Ej__TPar val = _003CSource_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ Source = {0} }}", array);
	}

	internal static bool dBdj0EFNBWJwtYjFTtb()
	{
		return rJN3Y9FrCRGPpXxss7t == null;
	}
}
