using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType39<_003CActionId_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CActionId_003Ej__TPar _003CActionId_003Ei__Field;

	private static object AJNJ8AQhxsXvMFHMwbZ;

	public _003CActionId_003Ej__TPar ActionId => _003CActionId_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType39(_003CActionId_003Ej__TPar ActionId)
	{
		_003CActionId_003Ei__Field = ActionId;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType39<_003CActionId_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType39<_003CActionId_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CActionId_003Ej__TPar>.Default.Equals(_003CActionId_003Ei__Field, anon._003CActionId_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 358073901 + EqualityComparer<_003CActionId_003Ej__TPar>.Default.GetHashCode(_003CActionId_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CActionId_003Ej__TPar val = _003CActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ ActionId = {0} }}", array);
	}

	internal static bool IXpe7GQHlTgRjsxJOmj()
	{
		return AJNJ8AQhxsXvMFHMwbZ == null;
	}
}
