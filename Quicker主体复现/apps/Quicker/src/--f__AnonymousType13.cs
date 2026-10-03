using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType13<_003Cselector_003Ej__TPar, _003CinfoType_003Ej__TPar, _003CattrName_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cselector_003Ej__TPar _003Cselector_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CinfoType_003Ej__TPar _003CinfoType_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CattrName_003Ej__TPar _003CattrName_003Ei__Field;

	internal static object vEVPbig8Wn2l9XVjti;

	public _003Cselector_003Ej__TPar selector => _003Cselector_003Ei__Field;

	public _003CinfoType_003Ej__TPar infoType => _003CinfoType_003Ei__Field;

	public _003CattrName_003Ej__TPar attrName => _003CattrName_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType13(_003Cselector_003Ej__TPar selector, _003CinfoType_003Ej__TPar infoType, _003CattrName_003Ej__TPar attrName)
	{
		_003Cselector_003Ei__Field = selector;
		_003CinfoType_003Ei__Field = infoType;
		_003CattrName_003Ei__Field = attrName;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType13<_003Cselector_003Ej__TPar, _003CinfoType_003Ej__TPar, _003CattrName_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType13<_003Cselector_003Ej__TPar, _003CinfoType_003Ej__TPar, _003CattrName_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cselector_003Ej__TPar>.Default.Equals(_003Cselector_003Ei__Field, anon._003Cselector_003Ei__Field) && EqualityComparer<_003CinfoType_003Ej__TPar>.Default.Equals(_003CinfoType_003Ei__Field, anon._003CinfoType_003Ei__Field))
			{
				return EqualityComparer<_003CattrName_003Ej__TPar>.Default.Equals(_003CattrName_003Ei__Field, anon._003CattrName_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((1839929199 + EqualityComparer<_003Cselector_003Ej__TPar>.Default.GetHashCode(_003Cselector_003Ei__Field)) * -1521134295 + EqualityComparer<_003CinfoType_003Ej__TPar>.Default.GetHashCode(_003CinfoType_003Ei__Field)) * -1521134295 + EqualityComparer<_003CattrName_003Ej__TPar>.Default.GetHashCode(_003CattrName_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003Cselector_003Ej__TPar val = _003Cselector_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CinfoType_003Ej__TPar val2 = _003CinfoType_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CattrName_003Ej__TPar val3 = _003CattrName_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ selector = {0}, infoType = {1}, attrName = {2} }}", array);
	}

	internal static bool skTX1APRwAm6iX8u23()
	{
		return vEVPbig8Wn2l9XVjti == null;
	}
}
