using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

[StructLayout(LayoutKind.Explicit)]
public struct StrRet
{
	[FieldOffset(0)]
	public uint uType;

	[FieldOffset(4)]
	public IntPtr pOleStr;

	[FieldOffset(4)]
	public IntPtr pStr;

	[FieldOffset(4)]
	public uint uOffset;

	[FieldOffset(4)]
	public IntPtr cStr;
}
