using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType9<_003Cinclude_latex_003Ej__TPar, _003Cinclude_mathml_003Ej__TPar, _003Cinclude_asciimath_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cinclude_latex_003Ej__TPar _003Cinclude_latex_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cinclude_mathml_003Ej__TPar _003Cinclude_mathml_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cinclude_asciimath_003Ej__TPar _003Cinclude_asciimath_003Ei__Field;

	private static object SMN9jFubeAJLC8Mqya;

	public _003Cinclude_latex_003Ej__TPar include_latex => _003Cinclude_latex_003Ei__Field;

	public _003Cinclude_mathml_003Ej__TPar include_mathml => _003Cinclude_mathml_003Ei__Field;

	public _003Cinclude_asciimath_003Ej__TPar include_asciimath => _003Cinclude_asciimath_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType9(_003Cinclude_latex_003Ej__TPar include_latex, _003Cinclude_mathml_003Ej__TPar include_mathml, _003Cinclude_asciimath_003Ej__TPar include_asciimath)
	{
		_003Cinclude_latex_003Ei__Field = include_latex;
		_003Cinclude_mathml_003Ei__Field = include_mathml;
		_003Cinclude_asciimath_003Ei__Field = include_asciimath;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType9<_003Cinclude_latex_003Ej__TPar, _003Cinclude_mathml_003Ej__TPar, _003Cinclude_asciimath_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType9<_003Cinclude_latex_003Ej__TPar, _003Cinclude_mathml_003Ej__TPar, _003Cinclude_asciimath_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cinclude_latex_003Ej__TPar>.Default.Equals(_003Cinclude_latex_003Ei__Field, anon._003Cinclude_latex_003Ei__Field) && EqualityComparer<_003Cinclude_mathml_003Ej__TPar>.Default.Equals(_003Cinclude_mathml_003Ei__Field, anon._003Cinclude_mathml_003Ei__Field))
			{
				return EqualityComparer<_003Cinclude_asciimath_003Ej__TPar>.Default.Equals(_003Cinclude_asciimath_003Ei__Field, anon._003Cinclude_asciimath_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((649827161 + EqualityComparer<_003Cinclude_latex_003Ej__TPar>.Default.GetHashCode(_003Cinclude_latex_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cinclude_mathml_003Ej__TPar>.Default.GetHashCode(_003Cinclude_mathml_003Ei__Field)) * -1521134295 + EqualityComparer<_003Cinclude_asciimath_003Ej__TPar>.Default.GetHashCode(_003Cinclude_asciimath_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003Cinclude_latex_003Ej__TPar val = _003Cinclude_latex_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Cinclude_mathml_003Ej__TPar val2 = _003Cinclude_mathml_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003Cinclude_asciimath_003Ej__TPar val3 = _003Cinclude_asciimath_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ include_latex = {0}, include_mathml = {1}, include_asciimath = {2} }}", array);
	}

	internal static bool z7YjxJoY2AsTr2SXrU()
	{
		return SMN9jFubeAJLC8Mqya == null;
	}
}
