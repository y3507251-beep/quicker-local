using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32.Shell;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("000214e4-0000-0000-c000-000000000046")]
public interface IContextMenu
{
	[PreserveSig]
	int QueryContextMenu(IntPtr hmenu, uint iMenu, uint idCmdFirst, uint idCmdLast, uint uFlags);

	[PreserveSig]
	int InvokeCommand(ref InvokeCommandInfo info);

	[PreserveSig]
	void GetCommandString(int idcmd, uint uflags, uint reserved, StringBuilder commandstring, uint cch);
}
