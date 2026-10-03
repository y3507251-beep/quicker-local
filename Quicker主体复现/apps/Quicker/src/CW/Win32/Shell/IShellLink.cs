using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32.Shell;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("000214F9-0000-0000-C000-000000000046")]
public interface IShellLink
{
	void GetPath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cch, [MarshalAs(UnmanagedType.Struct)] ref ShellLinkFindData pfd, uint fFlags);

	void GetIDList(out IntPtr ppidl);

	void SetIDList(IntPtr pidl);

	void GetDescription([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cch);

	void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);

	void GetWorkingDirectory([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cch);

	void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

	void GetArguments([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cch);

	void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

	void GetHotkey(out ushort pwHotkey);

	void SetHotkey(ushort wHotkey);

	void GetShowCmd(out int piShowCmd);

	void SetShowCmd(int iShowCmd);

	void GetIconLocation([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cch, out int piIcon);

	void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

	void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, uint dwReserved);

	void Resolve(IntPtr hwnd, uint flags);

	void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
}
