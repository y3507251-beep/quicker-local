using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType25<_003Cid_003Ej__TPar, _003Curl_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Cid_003Ej__TPar _003Cid_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Curl_003Ej__TPar _003Curl_003Ei__Field;

	private static object Mf3ODwQ0h2HZN6AnXfE;

	public _003Cid_003Ej__TPar id => _003Cid_003Ei__Field;

	public _003Curl_003Ej__TPar url => _003Curl_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType25(_003Cid_003Ej__TPar id, _003Curl_003Ej__TPar url)
	{
		_003Cid_003Ei__Field = id;
		_003Curl_003Ei__Field = url;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType25<_003Cid_003Ej__TPar, _003Curl_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType25<_003Cid_003Ej__TPar, _003Curl_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003Cid_003Ej__TPar>.Default.Equals(_003Cid_003Ei__Field, anon._003Cid_003Ei__Field))
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
		return (-289840664 + EqualityComparer<_003Cid_003Ej__TPar>.Default.GetHashCode(_003Cid_003Ei__Field)) * -1521134295 + EqualityComparer<_003Curl_003Ej__TPar>.Default.GetHashCode(_003Curl_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003Cid_003Ej__TPar val = _003Cid_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003Curl_003Ej__TPar val2 = _003Curl_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ id = {0}, url = {1} }}", array);
	}

	internal static bool ojIDgGQ10QvbQoL8bBS()
	{
		return Mf3ODwQ0h2HZN6AnXfE == null;
	}
}
