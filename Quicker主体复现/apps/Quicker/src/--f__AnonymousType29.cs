using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType29<_003CExpireTime_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CExpireTime_003Ej__TPar _003CExpireTime_003Ei__Field;

	private static object nYLabrQ97uirLpQlDkd;

	public _003CExpireTime_003Ej__TPar ExpireTime => _003CExpireTime_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType29(_003CExpireTime_003Ej__TPar ExpireTime)
	{
		_003CExpireTime_003Ei__Field = ExpireTime;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType29<_003CExpireTime_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType29<_003CExpireTime_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CExpireTime_003Ej__TPar>.Default.Equals(_003CExpireTime_003Ei__Field, anon._003CExpireTime_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 739528762 + EqualityComparer<_003CExpireTime_003Ej__TPar>.Default.GetHashCode(_003CExpireTime_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CExpireTime_003Ej__TPar val = _003CExpireTime_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ ExpireTime = {0} }}", array);
	}

	internal static bool l9a8MCQLkUqgYu3CYvE()
	{
		return nYLabrQ97uirLpQlDkd == null;
	}
}
