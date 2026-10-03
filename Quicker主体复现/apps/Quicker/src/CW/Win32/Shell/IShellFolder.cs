using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

[ComImport]
[Guid("000214E6-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IShellFolder
{
	[PreserveSig]
	int ParseDisplayName(IntPtr hwnd, IntPtr pbc, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, ref ulong pchEaten, out IntPtr ppidl, ref ulong pdwAttributes);

	[PreserveSig]
	int EnumObjects(IntPtr hwnd, int grfFlags, out IntPtr ppenumIDList);

	[PreserveSig]
	int BindToObject(IntPtr pidl, IntPtr pbc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

	[PreserveSig]
	int BindToStorage(IntPtr pidl, IntPtr pbc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

	[PreserveSig]
	int CompareIDs(int lParam, IntPtr pidl1, IntPtr pidl2);

	[PreserveSig]
	int CreateViewObject(IntPtr hwndOwner, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

	[PreserveSig]
	int GetAttributesOf(uint cidl, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IntPtr[] apidl, ref uint rgfInOut);

	[PreserveSig]
	int GetUIObjectOf(IntPtr hwndOwner, uint cidl, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] apidl, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, ref uint rgfReserved, out IntPtr ppv);

	[PreserveSig]
	int GetDisplayNameOf(IntPtr pidl, uint uFlags, out StrRet pName);

	[PreserveSig]
	int SetNameOf(IntPtr hwnd, IntPtr pidl, [MarshalAs(UnmanagedType.LPWStr)] string pszName, uint uFlags, out IntPtr ppidlOut);
}
