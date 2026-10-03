using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType27<_003CSyncTimeUtc_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSyncTimeUtc_003Ej__TPar _003CSyncTimeUtc_003Ei__Field;

	private static object cDqIlWQOEEFsrsdNTGC;

	public _003CSyncTimeUtc_003Ej__TPar SyncTimeUtc => _003CSyncTimeUtc_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType27(_003CSyncTimeUtc_003Ej__TPar SyncTimeUtc)
	{
		_003CSyncTimeUtc_003Ei__Field = SyncTimeUtc;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType27<_003CSyncTimeUtc_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType27<_003CSyncTimeUtc_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CSyncTimeUtc_003Ej__TPar>.Default.Equals(_003CSyncTimeUtc_003Ei__Field, anon._003CSyncTimeUtc_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1961016070 + EqualityComparer<_003CSyncTimeUtc_003Ej__TPar>.Default.GetHashCode(_003CSyncTimeUtc_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CSyncTimeUtc_003Ej__TPar val = _003CSyncTimeUtc_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ SyncTimeUtc = {0} }}", array);
	}

	internal static bool g8UXVZQJSa72OxCL4Bl()
	{
		return cDqIlWQOEEFsrsdNTGC == null;
	}
}
