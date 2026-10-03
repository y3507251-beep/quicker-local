using System;

namespace CW.Win32;

public class Win32MenuItem : DisposableObject
{
	private IntPtr FnEClyk1HH;

	private bool GdVCicnal1;

	private static Win32MenuItem Hfyl0N1Mj01RYT32HVj;

	public IntPtr Handle => FnEClyk1HH;

	public int Count => User32.GetMenuItemCount(FnEClyk1HH);

	public Win32MenuItem(IntPtr handle)
		: this(handle, false)
	{
	}

	public Win32MenuItem(IntPtr handle, bool owner)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("handle");
		}
		FnEClyk1HH = handle;
		GdVCicnal1 = owner;
	}

	public static Win32MenuItem CreatePopupMenu()
	{
		return new Win32MenuItem(User32.CreatePopupMenu(), true);
	}

	public int Show(IntPtr handle, Point pos, TrackPopupMenuOptions options)
	{
		User32.ClientToScreen(handle, ref pos);
		return User32.TrackPopupMenu(FnEClyk1HH, options, (int)pos.X, (int)pos.Y, 0, handle, 0);
	}

	public int GetDefaultItem(MenuFoundBy byPos, GetMenuDefaultItemOptions options)
	{
		return User32.GetMenuDefaultItem(FnEClyk1HH, byPos, options);
	}

	protected override void Dispose(bool disposing)
	{
		if (GdVCicnal1 && FnEClyk1HH != IntPtr.Zero)
		{
			User32.DestroyMenu(FnEClyk1HH);
			FnEClyk1HH = IntPtr.Zero;
		}
	}

	internal static bool Nxu3181UC8wEXHGnPo2()
	{
		return Hfyl0N1Mj01RYT32HVj == null;
	}
}
