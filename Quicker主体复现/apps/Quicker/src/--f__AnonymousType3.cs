using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType3<_003CItem_003Ej__TPar, _003CScore_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CItem_003Ej__TPar _003CItem_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CScore_003Ej__TPar _003CScore_003Ei__Field;

	private static object aAT6yeDSSHyDfHPDjn;

	public _003CItem_003Ej__TPar Item => _003CItem_003Ei__Field;

	public _003CScore_003Ej__TPar Score => _003CScore_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType3(_003CItem_003Ej__TPar Item, _003CScore_003Ej__TPar Score)
	{
		_003CItem_003Ei__Field = Item;
		_003CScore_003Ei__Field = Score;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		global::_003C_003Ef__AnonymousType3<_003CItem_003Ej__TPar, _003CScore_003Ej__TPar> anon = value as global::_003C_003Ef__AnonymousType3<_003CItem_003Ej__TPar, _003CScore_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CItem_003Ej__TPar>.Default.Equals(_003CItem_003Ei__Field, anon._003CItem_003Ei__Field))
			{
				return EqualityComparer<_003CScore_003Ej__TPar>.Default.Equals(_003CScore_003Ei__Field, anon._003CScore_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-2022896859 + EqualityComparer<_003CItem_003Ej__TPar>.Default.GetHashCode(_003CItem_003Ei__Field)) * -1521134295 + EqualityComparer<_003CScore_003Ej__TPar>.Default.GetHashCode(_003CScore_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CItem_003Ej__TPar val = _003CItem_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CScore_003Ej__TPar val2 = _003CScore_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ Item = {0}, Score = {1} }}", array);
	}

	internal static bool xUXD1R3x38Msw9VJxF()
	{
		return aAT6yeDSSHyDfHPDjn == null;
	}
}
