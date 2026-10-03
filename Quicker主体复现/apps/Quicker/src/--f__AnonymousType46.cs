using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType46<_003CSharedActionId_003Ej__TPar, _003CRevision_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CSharedActionId_003Ej__TPar _003CSharedActionId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CRevision_003Ej__TPar _003CRevision_003Ei__Field;

	private static object l3UeYjF1CQUGflCS1e6;

	public _003CSharedActionId_003Ej__TPar SharedActionId => _003CSharedActionId_003Ei__Field;

	public _003CRevision_003Ej__TPar Revision => _003CRevision_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType46(_003CSharedActionId_003Ej__TPar SharedActionId, _003CRevision_003Ej__TPar Revision)
	{
		_003CSharedActionId_003Ei__Field = SharedActionId;
		_003CRevision_003Ei__Field = Revision;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType46<_003CSharedActionId_003Ej__TPar, _003CRevision_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType46<_003CSharedActionId_003Ej__TPar, _003CRevision_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CSharedActionId_003Ej__TPar>.Default.Equals(_003CSharedActionId_003Ei__Field, anon._003CSharedActionId_003Ei__Field))
			{
				return EqualityComparer<_003CRevision_003Ej__TPar>.Default.Equals(_003CRevision_003Ei__Field, anon._003CRevision_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (212382073 + EqualityComparer<_003CSharedActionId_003Ej__TPar>.Default.GetHashCode(_003CSharedActionId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CRevision_003Ej__TPar>.Default.GetHashCode(_003CRevision_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		_003CSharedActionId_003Ej__TPar val = _003CSharedActionId_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CRevision_003Ej__TPar val2 = _003CRevision_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ SharedActionId = {0}, Revision = {1} }}", array);
	}

	internal static bool RGubJnFKWOWOHkcZFd6()
	{
		return l3UeYjF1CQUGflCS1e6 == null;
	}
}
