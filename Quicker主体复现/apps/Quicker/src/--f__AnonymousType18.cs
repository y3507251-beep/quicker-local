using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType18<_003CCommand_003Ej__TPar, _003CCommandParams_003Ej__TPar, _003CValueFilter_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CCommand_003Ej__TPar _003CCommand_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CCommandParams_003Ej__TPar _003CCommandParams_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CValueFilter_003Ej__TPar _003CValueFilter_003Ei__Field;

	internal static object hijkd644W3qZ1n3GEV;

	public _003CCommand_003Ej__TPar Command => _003CCommand_003Ei__Field;

	public _003CCommandParams_003Ej__TPar CommandParams => _003CCommandParams_003Ei__Field;

	public _003CValueFilter_003Ej__TPar ValueFilter => _003CValueFilter_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType18(_003CCommand_003Ej__TPar Command, _003CCommandParams_003Ej__TPar CommandParams, _003CValueFilter_003Ej__TPar ValueFilter)
	{
		_003CCommand_003Ei__Field = Command;
		_003CCommandParams_003Ei__Field = CommandParams;
		_003CValueFilter_003Ei__Field = ValueFilter;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType18<_003CCommand_003Ej__TPar, _003CCommandParams_003Ej__TPar, _003CValueFilter_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType18<_003CCommand_003Ej__TPar, _003CCommandParams_003Ej__TPar, _003CValueFilter_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CCommand_003Ej__TPar>.Default.Equals(_003CCommand_003Ei__Field, anon._003CCommand_003Ei__Field) && EqualityComparer<_003CCommandParams_003Ej__TPar>.Default.Equals(_003CCommandParams_003Ei__Field, anon._003CCommandParams_003Ei__Field))
			{
				return EqualityComparer<_003CValueFilter_003Ej__TPar>.Default.Equals(_003CValueFilter_003Ei__Field, anon._003CValueFilter_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((2107949459 + EqualityComparer<_003CCommand_003Ej__TPar>.Default.GetHashCode(_003CCommand_003Ei__Field)) * -1521134295 + EqualityComparer<_003CCommandParams_003Ej__TPar>.Default.GetHashCode(_003CCommandParams_003Ei__Field)) * -1521134295 + EqualityComparer<_003CValueFilter_003Ej__TPar>.Default.GetHashCode(_003CValueFilter_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CCommand_003Ej__TPar val = _003CCommand_003Ei__Field;
		array[0] = ((val == null) ? null : val.ToString());
		_003CCommandParams_003Ej__TPar val2 = _003CCommandParams_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CValueFilter_003Ej__TPar val3 = _003CValueFilter_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ Command = {0}, CommandParams = {1}, ValueFilter = {2} }}", array);
	}

	internal static bool qno0bIhZWiNBSo8X6r()
	{
		return hijkd644W3qZ1n3GEV == null;
	}
}
