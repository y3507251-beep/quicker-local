using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType36<_003CActionId_003Ej__TPar, _003CExpireTime_003Ej__TPar, _003CToLongTime_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CActionId_003Ej__TPar _003CActionId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CExpireTime_003Ej__TPar _003CExpireTime_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CToLongTime_003Ej__TPar _003CToLongTime_003Ei__Field;

	internal static object qftnktQteEcXrjVysvO;

	public _003CActionId_003Ej__TPar ActionId => _003CActionId_003Ei__Field;

	public _003CExpireTime_003Ej__TPar ExpireTime => _003CExpireTime_003Ei__Field;

	public _003CToLongTime_003Ej__TPar ToLongTime => _003CToLongTime_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType36(_003CActionId_003Ej__TPar ActionId, _003CExpireTime_003Ej__TPar ExpireTime, _003CToLongTime_003Ej__TPar ToLongTime)
	{
		_003CActionId_003Ei__Field = ActionId;
		_003CExpireTime_003Ei__Field = ExpireTime;
		_003CToLongTime_003Ei__Field = ToLongTime;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType36<_003CActionId_003Ej__TPar, _003CExpireTime_003Ej__TPar, _003CToLongTime_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType36<_003CActionId_003Ej__TPar, _003CExpireTime_003Ej__TPar, _003CToLongTime_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CActionId_003Ej__TPar>.Default.Equals(_003CActionId_003Ei__Field, anon._003CActionId_003Ei__Field) && EqualityComparer<_003CExpireTime_003Ej__TPar>.Default.Equals(_003CExpireTime_003Ei__Field, anon._003CExpireTime_003Ei__Field))
			{
				return EqualityComparer<_003CToLongTime_003Ej__TPar>.Default.Equals(_003CToLongTime_003Ei__Field, anon._003CToLongTime_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((279363237 + EqualityComparer<_003CActionId_003Ej__TPar>.Default.GetHashCode(_003CActionId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CExpireTime_003Ej__TPar>.Default.GetHashCode(_003CExpireTime_003Ei__Field)) * -1521134295 + EqualityComparer<_003CToLongTime_003Ej__TPar>.Default.GetHashCode(_003CToLongTime_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		_003CActionId_003Ej__TPar val = _003CActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CExpireTime_003Ej__TPar val2 = _003CExpireTime_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CToLongTime_003Ej__TPar val3 = _003CToLongTime_003Ei__Field;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ ActionId = {0}, ExpireTime = {1}, ToLongTime = {2} }}", array);
	}

	internal static bool uKx1oPQSJooTHlygY17()
	{
		return qftnktQteEcXrjVysvO == null;
	}
}
