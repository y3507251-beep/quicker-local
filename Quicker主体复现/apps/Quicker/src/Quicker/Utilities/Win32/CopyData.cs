using System;
using System.Runtime.InteropServices;

namespace Quicker.Utilities.Win32;

public struct CopyData : IDisposable
{
	[Flags]
	private enum lJL6E8DHafQLx3TQgrM : uint
	{

	}

	public IntPtr dwData;

	public int cbData;

	public IntPtr lpData;

	internal static object VNCiGpFPOSbx8846yo5l;

	public string AsAnsiString => Marshal.PtrToStringAnsi(lpData, cbData);

	public string AsUnicodeString => Marshal.PtrToStringUni(lpData);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessageTimeout")]
	private static extern IntPtr YcoLOIj5U3I(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, ref CopyData copyData_0, lJL6E8DHafQLx3TQgrM lJL6E8DHafQLx3TQgrM_0, uint uint_1, out UIntPtr uintptr_0);

	public void Dispose()
	{
		if (lpData != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(lpData);
			lpData = IntPtr.Zero;
			cbData = 0;
		}
	}

	public static CopyData CreateForString(int dwData, string value, bool Unicode = false)
	{
		return new CopyData
		{
			dwData = (IntPtr)dwData,
			lpData = (Unicode ? Marshal.StringToCoTaskMemUni(value) : Marshal.StringToCoTaskMemAnsi(value)),
			cbData = value.Length * Marshal.SystemDefaultCharSize + 1
		};
	}

	public static UIntPtr Send(IntPtr targetHandle, int dwData, string value, uint timeoutMs = 1000u, bool Unicode = false)
	{
		CopyData copyData_ = CreateForString(dwData, value, Unicode);
		YcoLOIj5U3I(targetHandle, 74u, IntPtr.Zero, ref copyData_, (lJL6E8DHafQLx3TQgrM)0u, timeoutMs, out var uintptr_);
		copyData_.Dispose();
		return uintptr_;
	}

	internal static bool nkvK6wFPJXm6aoIcNGRU()
	{
		return VNCiGpFPOSbx8846yo5l == null;
	}
}
