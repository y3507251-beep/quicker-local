using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType31<_003CIsDeleted_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CIsDeleted_003Ej__TPar _003CIsDeleted_003Ei__Field;

	private static object KJCTfWQqgXfeC6PHPGf;

	public _003CIsDeleted_003Ej__TPar IsDeleted => _003CIsDeleted_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType31(_003CIsDeleted_003Ej__TPar IsDeleted)
	{
		_003CIsDeleted_003Ei__Field = IsDeleted;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType31<_003CIsDeleted_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType31<_003CIsDeleted_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.Equals(_003CIsDeleted_003Ei__Field, anon._003CIsDeleted_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1497923623 + EqualityComparer<_003CIsDeleted_003Ej__TPar>.Default.GetHashCode(_003CIsDeleted_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CIsDeleted_003Ej__TPar val = _003CIsDeleted_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ IsDeleted = {0} }}", array);
	}

	internal static bool EhH1JZQiGtSJ7e6Th8E()
	{
		return KJCTfWQqgXfeC6PHPGf == null;
	}
}
