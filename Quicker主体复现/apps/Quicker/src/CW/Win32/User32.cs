using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32;

public static class User32
{
	public delegate bool EnumWindowsProc(IntPtr hWnd, object lParam);

	public static readonly IntPtr HWND_TOP;

	public static readonly IntPtr HWND_BOTTOM;

	public static readonly IntPtr HWND_TOPMOST;

	public static readonly IntPtr HWND_NOTOPMOST;

	private static object AihSXP0zt9G0sC3KlPS;

	[DllImport("user32")]
	public static extern bool RegisterHotKey(IntPtr hwnd, int id, HotKeyModifiers mods, Keys keys);

	[DllImport("user32")]
	public static extern bool UnregisterHotKey(IntPtr hwnd, int id);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DestroyIcon(IntPtr hIcon);

	[DllImport("user32")]
	public static extern IntPtr GetTopWindow(IntPtr hWnd);

	[DllImport("user32", EntryPoint = "GetWindow")]
	public static extern IntPtr GetNextWindow(IntPtr hWnd, uint wCmd);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern int EnumWindows(EnumWindowsProc lpEnumFunc, object lParam);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowOption option);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool SetWindowText(IntPtr hWnd, [MarshalAs(UnmanagedType.LPTStr)] string text);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hwndAfter, int x, int y, int width, int height, SetWindowPosOptions options);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern int GetWindowRect(IntPtr hWnd, ref Rectangle rect);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool IsWindow(IntPtr hWnd);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool GetWindowPlacement(IntPtr Handle, ref WindowPlacement placement);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern uint GetWindowLong(IntPtr Handle, GetWindowLongOption option);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool IsWindowVisible(IntPtr Handle);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern bool IsWindowEnabled(IntPtr Handle);

	[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "EnableWindow")]
	public static extern bool IsWindowEnabled(IntPtr Handle, bool enable);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int ToUnicode(uint wVirtKey, uint wScanCode, byte[] lpKeyState, StringBuilder pwszBuff, int cchBuff, uint wFlags);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetActiveWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SetActiveWindow(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetClassLong(IntPtr hwnd, GetClassLongOption nIndex);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int ShowWindow(IntPtr hwnd, ShowWindowCommand cmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hwnd, WindowMessage msg, int wParam, int lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, ref HeaderItem lParam);

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindowEx(IntPtr parent, IntPtr childAfter, string className, string windowName);

	[DllImport("user32.dll", EntryPoint = "FindWindow")]
	public static extern IntPtr FindWindowWin32(string className, string windowName);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr window, int message, int wparam, int lparam);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr window, WindowMessage message, int wparam, int lparam);

	[DllImport("user32.dll")]
	public static extern bool BringWindowToTop(IntPtr window);

	[DllImport("user32.dll")]
	public static extern IntPtr GetParent(IntPtr window);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr GetLastActivePopup(IntPtr window);

	[DllImport("user32.dll")]
	public static extern int GetWindowTextLength(IntPtr window);

	[DllImport("user32.dll")]
	public static extern bool EnumChildWindows(IntPtr window, EnumWindowsProc callback, object o);

	[DllImport("user32.dll")]
	public static extern bool EnumThreadWindows(int threadId, EnumWindowsProc callback, object o);

	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr window, IntPtr ptr);

	[DllImport("user32.dll")]
	public static extern bool IsChild(IntPtr parent, IntPtr window);

	[DllImport("user32.dll")]
	public static extern bool IsIconic(IntPtr window);

	[DllImport("user32.dll")]
	public static extern bool IsZoomed(IntPtr window);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("user32.dll")]
	public static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr CreatePopupMenu();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int TrackPopupMenu(IntPtr hMenu, TrackPopupMenuOptions wFlags, int x, int y, int nReserved, IntPtr hwnd, int lprc);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DestroyMenu(IntPtr hMenu);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetMenuDefaultItem(IntPtr hMenu, MenuFoundBy byPos, GetMenuDefaultItemOptions options);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetMenuItemCount(IntPtr hMenu);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern bool ClientToScreen(IntPtr hWnd, ref Point pt);

	static User32()
	{
		HWND_TOP = IntPtr.Zero;
		HWND_BOTTOM = (IntPtr)1;
		HWND_TOPMOST = (IntPtr)(-1);
		HWND_NOTOPMOST = (IntPtr)(-2);
	}

	internal static bool wITFTi1V7gh03ds36O3()
	{
		return AihSXP0zt9G0sC3KlPS == null;
	}
}
