using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType47<_003CSharedActionId_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSharedActionId_003Ej__TPar _003CSharedActionId_003Ei__Field;

	internal static object xaMTX6Fv0EFsgtGTJyc;

	public _003CSharedActionId_003Ej__TPar SharedActionId => _003CSharedActionId_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType47(_003CSharedActionId_003Ej__TPar SharedActionId)
	{
		_003CSharedActionId_003Ei__Field = SharedActionId;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType47<_003CSharedActionId_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType47<_003CSharedActionId_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null)
			{
				return EqualityComparer<_003CSharedActionId_003Ej__TPar>.Default.Equals(_003CSharedActionId_003Ei__Field, anon._003CSharedActionId_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 307526338 + EqualityComparer<_003CSharedActionId_003Ej__TPar>.Default.GetHashCode(_003CSharedActionId_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[1];
		_003CSharedActionId_003Ej__TPar val = _003CSharedActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ SharedActionId = {0} }}", array);
	}

	internal static bool eILUILFdWClEu9rHpKM()
	{
		return xaMTX6Fv0EFsgtGTJyc == null;
	}
}
