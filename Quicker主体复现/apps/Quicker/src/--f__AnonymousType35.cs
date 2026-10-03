using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType35<_003CItemId_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CItemId_003Ej__TPar _003CItemId_003Ei__Field;

	internal static object cXtiucQxntZTvgpY9uN;

	public _003CItemId_003Ej__TPar ItemId => _003CItemId_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType35(_003CItemId_003Ej__TPar ItemId)
	{
		_003CItemId_003Ei__Field = ItemId;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType35<_003CItemId_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType35<_003CItemId_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CItemId_003Ej__TPar>.Default.Equals(_003CItemId_003Ei__Field, anon._003CItemId_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 812245542 + EqualityComparer<_003CItemId_003Ej__TPar>.Default.GetHashCode(_003CItemId_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CItemId_003Ej__TPar val = _003CItemId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ ItemId = {0} }}", array);
	}

	internal static bool xnJya9QIvN4DwO9gkEC()
	{
		return cXtiucQxntZTvgpY9uN == null;
	}
}
