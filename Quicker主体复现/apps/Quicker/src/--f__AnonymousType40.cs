using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType40<_003Crowid_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003Crowid_003Ej__TPar _003Crowid_003Ei__Field;

	internal static object etRKirFVx72q4lEnVGU;

	public _003Crowid_003Ej__TPar rowid => _003Crowid_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType40(_003Crowid_003Ej__TPar rowid)
	{
		_003Crowid_003Ei__Field = rowid;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType40<_003Crowid_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType40<_003Crowid_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003Crowid_003Ej__TPar>.Default.Equals(_003Crowid_003Ei__Field, anon._003Crowid_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 2096668757 + EqualityComparer<_003Crowid_003Ej__TPar>.Default.GetHashCode(_003Crowid_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003Crowid_003Ej__TPar val = _003Crowid_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ rowid = {0} }}", array);
	}

	internal static bool Me9LabFQqZV9EXudEvU()
	{
		return etRKirFVx72q4lEnVGU == null;
	}
}
