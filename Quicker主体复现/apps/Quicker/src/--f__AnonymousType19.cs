using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType19<_003Curl_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Curl_003Ej__TPar _003Curl_003Ei__Field;

	private static object efm101ze41pbiiLpEm;

	public _003Curl_003Ej__TPar url => _003Curl_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType19(_003Curl_003Ej__TPar url)
	{
		_003Curl_003Ei__Field = url;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType19<_003Curl_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType19<_003Curl_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
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
		return 288439005 + EqualityComparer<_003Curl_003Ej__TPar>.Default.GetHashCode(_003Curl_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003Curl_003Ej__TPar val = _003Curl_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ url = {0} }}", array);
	}

	internal static bool RETeFMQVDb50Wd5ZkgY()
	{
		return efm101ze41pbiiLpEm == null;
	}
}
