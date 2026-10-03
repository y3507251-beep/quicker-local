using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType15<_003CtabId_003Ej__TPar, _003Curl_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CtabId_003Ej__TPar _003CtabId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Curl_003Ej__TPar _003Curl_003Ei__Field;

	internal static object fdD6gk6S0BebAgJZxE;

	public _003CtabId_003Ej__TPar tabId => _003CtabId_003Ei__Field;

	public _003Curl_003Ej__TPar url => _003Curl_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType15(_003CtabId_003Ej__TPar tabId, _003Curl_003Ej__TPar url)
	{
		_003CtabId_003Ei__Field = tabId;
		_003Curl_003Ei__Field = url;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType15<_003CtabId_003Ej__TPar, _003Curl_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType15<_003CtabId_003Ej__TPar, _003Curl_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CtabId_003Ej__TPar>.Default.Equals(_003CtabId_003Ei__Field, anon._003CtabId_003Ei__Field))
			{
				return EqualityComparer<_003Curl_003Ej__TPar>.Default.Equals(_003Curl_003Ei__Field, anon._003Curl_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1825745237 + EqualityComparer<_003CtabId_003Ej__TPar>.Default.GetHashCode(_003CtabId_003Ei__Field)) * -1521134295 + EqualityComparer<_003Curl_003Ej__TPar>.Default.GetHashCode(_003Curl_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CtabId_003Ej__TPar val = _003CtabId_003Ei__Field;
		array[0] = ((val == null) ? null : val.ToString());
		_003Curl_003Ej__TPar val2 = _003Curl_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ tabId = {0}, url = {1} }}", array);
	}

	internal static bool BdUF83tBYVydsHxePJ()
	{
		return fdD6gk6S0BebAgJZxE == null;
	}
}
