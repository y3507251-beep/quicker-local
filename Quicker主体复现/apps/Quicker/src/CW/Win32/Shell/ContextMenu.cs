using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

public class ContextMenu : ComObject<IContextMenu>
{
	public static readonly Guid IID;

	internal static ContextMenu u41KdM1mcF4jNDCjY91;

	public ContextMenu(IContextMenu contextMenu)
		: base(contextMenu)
	{
	}

	public void InvokeCommand(int cmdId, IntPtr hwnd, ShowWindowCommand nShow)
	{
		InvokeCommandInfo info = default(InvokeCommandInfo);
		info.Hwnd = hwnd;
		info.Verb = new IntPtr(cmdId);
		info.Size = Marshal.SizeOf(info);
		info.Show = ShowWindowCommand.ShowNormal;
		base.Interface.InvokeCommand(ref info);
	}

	static ContextMenu()
	{
		IID = new Guid("{000214e4-0000-0000-c000-000000000046}");
	}

	internal static bool U1x9DE1sTV2lXXfMgc1()
	{
		return u41KdM1mcF4jNDCjY91 == null;
	}
}
