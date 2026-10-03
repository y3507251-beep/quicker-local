using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType41<_003CrowIdList_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CrowIdList_003Ej__TPar _003CrowIdList_003Ei__Field;

	internal static object gJoDlpFcBEkG6qLh3Hn;

	public _003CrowIdList_003Ej__TPar rowIdList => _003CrowIdList_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType41(_003CrowIdList_003Ej__TPar rowIdList)
	{
		_003CrowIdList_003Ei__Field = rowIdList;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType41<_003CrowIdList_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType41<_003CrowIdList_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CrowIdList_003Ej__TPar>.Default.Equals(_003CrowIdList_003Ei__Field, anon._003CrowIdList_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1428063059 + EqualityComparer<_003CrowIdList_003Ej__TPar>.Default.GetHashCode(_003CrowIdList_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CrowIdList_003Ej__TPar val = _003CrowIdList_003Ei__Field;
		array[0] = ((val == null) ? null : val.ToString());
		return string.Format(null, "{{ rowIdList = {0} }}", array);
	}

	internal static bool Xkle0rFWn2pXpMqPpL9()
	{
		return gJoDlpFcBEkG6qLh3Hn == null;
	}
}
