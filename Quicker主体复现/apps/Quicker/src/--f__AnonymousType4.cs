using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class _003C_003Ef__AnonymousType4<_003CScript_003Ej__TPar, _003CAllFrames_003Ej__TPar, _003CFrameId_003Ej__TPar, _003CWaitManualReturn_003Ej__TPar>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CScript_003Ej__TPar _003CScript_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CAllFrames_003Ej__TPar _003CAllFrames_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CFrameId_003Ej__TPar _003CFrameId_003Ei__Field;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _003CWaitManualReturn_003Ej__TPar _003CWaitManualReturn_003Ei__Field;

	private static object MFuLLKGX4ZJlHHM0lR;

	public _003CScript_003Ej__TPar Script => _003CScript_003Ei__Field;

	public _003CAllFrames_003Ej__TPar AllFrames => _003CAllFrames_003Ei__Field;

	public _003CFrameId_003Ej__TPar FrameId => _003CFrameId_003Ei__Field;

	public _003CWaitManualReturn_003Ej__TPar WaitManualReturn => _003CWaitManualReturn_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType4(_003CScript_003Ej__TPar Script, _003CAllFrames_003Ej__TPar AllFrames, _003CFrameId_003Ej__TPar FrameId, _003CWaitManualReturn_003Ej__TPar WaitManualReturn)
	{
		_003CScript_003Ei__Field = Script;
		_003CAllFrames_003Ei__Field = AllFrames;
		_003CFrameId_003Ei__Field = FrameId;
		_003CWaitManualReturn_003Ei__Field = WaitManualReturn;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		_003C_003Ef__AnonymousType4<_003CScript_003Ej__TPar, _003CAllFrames_003Ej__TPar, _003CFrameId_003Ej__TPar, _003CWaitManualReturn_003Ej__TPar> anon = value as _003C_003Ef__AnonymousType4<_003CScript_003Ej__TPar, _003CAllFrames_003Ej__TPar, _003CFrameId_003Ej__TPar, _003CWaitManualReturn_003Ej__TPar>;
		if (this != anon)
		{
			if (anon != null && EqualityComparer<_003CScript_003Ej__TPar>.Default.Equals(_003CScript_003Ei__Field, anon._003CScript_003Ei__Field) && EqualityComparer<_003CAllFrames_003Ej__TPar>.Default.Equals(_003CAllFrames_003Ei__Field, anon._003CAllFrames_003Ei__Field) && EqualityComparer<_003CFrameId_003Ej__TPar>.Default.Equals(_003CFrameId_003Ei__Field, anon._003CFrameId_003Ei__Field))
			{
				return EqualityComparer<_003CWaitManualReturn_003Ej__TPar>.Default.Equals(_003CWaitManualReturn_003Ei__Field, anon._003CWaitManualReturn_003Ei__Field);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (((-307408013 + EqualityComparer<_003CScript_003Ej__TPar>.Default.GetHashCode(_003CScript_003Ei__Field)) * -1521134295 + EqualityComparer<_003CAllFrames_003Ej__TPar>.Default.GetHashCode(_003CAllFrames_003Ei__Field)) * -1521134295 + EqualityComparer<_003CFrameId_003Ej__TPar>.Default.GetHashCode(_003CFrameId_003Ei__Field)) * -1521134295 + EqualityComparer<_003CWaitManualReturn_003Ej__TPar>.Default.GetHashCode(_003CWaitManualReturn_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[4];
		_003CScript_003Ej__TPar val = _003CScript_003Ei__Field;
		array[0] = ((val != null) ? val.ToString() : null);
		_003CAllFrames_003Ej__TPar val2 = _003CAllFrames_003Ei__Field;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		_003CFrameId_003Ej__TPar val3 = _003CFrameId_003Ei__Field;
		array[2] = ((val3 == null) ? null : val3.ToString());
		_003CWaitManualReturn_003Ej__TPar val4 = _003CWaitManualReturn_003Ei__Field;
		array[3] = ((val4 != null) ? val4.ToString() : null);
		return string.Format(null, "{{ Script = {0}, AllFrames = {1}, FrameId = {2}, WaitManualReturn = {3} }}", array);
	}

	internal static bool DOeA270OBB6LRx0sao()
	{
		return MFuLLKGX4ZJlHHM0lR == null;
	}
}
