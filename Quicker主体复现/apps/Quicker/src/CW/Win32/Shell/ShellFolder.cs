using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

public class ShellFolder : ComObject<IShellFolder>
{
	public static readonly Guid IID;

	internal static ShellFolder hgL6mDBuSThQDXVgRjZ;

	public ShellFolder(IShellFolder shellFolder)
		: base(shellFolder)
	{
	}

	public static ShellFolder GetDesktopFolder()
	{
		Marshal.ThrowExceptionForHR(Shell32.SHGetDesktopFolder(out var ppshf));
		return new ShellFolder((IShellFolder)Marshal.GetTypedObjectForIUnknown(ppshf, typeof(IShellFolder)));
	}

	public static ShellFolder GetFolder(IntPtr hwnd, string path)
	{
		ulong pchEaten = 0uL;
		ulong pdwAttributes = 0uL;
		using ShellFolder shellFolder = GetDesktopFolder();
		IntPtr pidl = IntPtr.Zero;
		if (string.IsNullOrEmpty(path))
		{
			Shell32.SHGetSpecialFolderLocation(hwnd, 17, out pidl);
		}
		else
		{
			Marshal.ThrowExceptionForHR(shellFolder.Interface.ParseDisplayName(IntPtr.Zero, IntPtr.Zero, path, ref pchEaten, out pidl, ref pdwAttributes));
		}
		using (new ComTaskMemory(pidl))
		{
			return shellFolder.BindToObject(pidl);
		}
	}

	public ShellView CreateViewObject(IntPtr hwnd)
	{
		Marshal.ThrowExceptionForHR(base.Interface.CreateViewObject(hwnd, ShellView.IID, out var ppv));
		return new ShellView((IShellView)Marshal.GetTypedObjectForIUnknown(ppv, typeof(IShellView)));
	}

	public ShellFolder BindToObject(IntPtr ppidl)
	{
		Marshal.ThrowExceptionForHR(base.Interface.BindToObject(ppidl, IntPtr.Zero, IID, out var ppv));
		return new ShellFolder((IShellFolder)Marshal.GetTypedObjectForIUnknown(ppv, typeof(IShellFolder)));
	}

	public ContextMenu GetUIObjectOf(IntPtr[] apidl, IntPtr hwnd)
	{
		uint rgfReserved = 0u;
		Marshal.ThrowExceptionForHR(base.Interface.GetUIObjectOf(hwnd, (uint)apidl.Length, apidl, ContextMenu.IID, ref rgfReserved, out var ppv));
		return new ContextMenu((IContextMenu)Marshal.GetTypedObjectForIUnknown(ppv, typeof(IContextMenu)));
	}

	static ShellFolder()
	{
		IID = new Guid("{000214E6-0000-0000-C000-000000000046}");
	}

	internal static bool XDEOB8Bol1ioXUgFDLO()
	{
		return hgL6mDBuSThQDXVgRjZ == null;
	}
}
