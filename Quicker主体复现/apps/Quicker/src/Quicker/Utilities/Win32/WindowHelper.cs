using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using AutoIt;
using PInvoke;
using Quicker.Domain;
using Quicker.Public.Extensions;
using ViNASxihuuLY1Gg9m6p;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Utilities.Win32;

public static class WindowHelper
{
	internal enum wfilwvDbbr9unseQn7y
	{
		Normal = 1,
		Maximized = 3
	}

	[Serializable]
	internal struct lf5vekDeXk46lOmE24G
	{
		public int DZ32SlyB0v9;

		public int qZn2SifZsqO;

		public wfilwvDbbr9unseQn7y c6o2S3eADqB;

		public System.Drawing.Point JFR2SfDtUAO;

		public System.Drawing.Point KwL2SzBX2VA;

		public Rectangle C9622woYuYO;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec gbi22gxZHLM;

		public static Func<KeyValuePair<IntPtr, long>, long> NHS22L30TS7;

		internal static _003C_003Ec uyRDsFyGXND9ZeQE5T5q;

		static _003C_003Ec()
		{
			gbi22gxZHLM = new _003C_003Ec();
		}

		internal long ruF22tw06kR(KeyValuePair<IntPtr, long> x)
		{
			return x.Value;
		}

		internal static bool xKn4EyyG2v2I40B10CUV()
		{
			return uyRDsFyGXND9ZeQE5T5q == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public int Yia22S2WTHk;

		private static _003C_003Ec__DisplayClass55_0 A22tKqyGn4bvhcU6R2lU;

		internal bool HhI22vRbFDg(int x)
		{
			return x != Yia22S2WTHk;
		}

		internal static bool DMrqOayGeUqaxIkQJXv5()
		{
			return A22tKqyGn4bvhcU6R2lU == null;
		}
	}

	public const int WM_SYSCOMMAND = 274;

	public const int WM_CLOSE = 16;

	public const int SC_MAXIMIZE = 61488;

	public const int SC_MINIMIZE = 61472;

	public const int SC_RESTORE = 61728;

	internal static object avqoi0FMYEgIy1DbVT4a;

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern int flpLFWnLnvW(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
	private static extern int mYgLFkh2gWO(IntPtr intptr_0, int int_0, int int_1);

	public static void SetWindowExTransparent(IntPtr hwnd, bool enable = true)
	{
		int num = flpLFWnLnvW(hwnd, -20);
		if (enable)
		{
			mYgLFkh2gWO(hwnd, -20, num | 0x20);
		}
		else
		{
			mYgLFkh2gWO(hwnd, -20, num & -33);
		}
	}

	public static void SetWindowExToolWindow(IntPtr hwnd, bool hideFromAltTabWindow = true)
	{
		int num = flpLFWnLnvW(hwnd, -20);
		if (hideFromAltTabWindow)
		{
			mYgLFkh2gWO(hwnd, -20, num | 0x80);
		}
		else
		{
			mYgLFkh2gWO(hwnd, -20, num & -129);
		}
	}

	public static void CloseForegroundWindow()
	{
		IntPtr foregroundOrMousePositionWindow = GetForegroundOrMousePositionWindow();
		if (foregroundOrMousePositionWindow == NativeMethods.GetDesktopWindow())
		{
			int num = 0;
			if (!q5GYb7FM8VHW28NpZJvu())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		if (!NativeMethods.IsOnDesktop(foregroundOrMousePositionWindow) && !NativeMethods.IsOnTaskbar(foregroundOrMousePositionWindow))
		{
			bool flag = false;
			try
			{
				string windowProcessName = NativeMethods.GetWindowProcessName(foregroundOrMousePositionWindow);
				if (windowProcessName.EqualsAny(true, "excel"))
				{
					InputSimulator.Instance.Keyboard.ModifiedKeyStroke(new List<VirtualKeyCode> { VirtualKeyCode.LMENU }, VirtualKeyCode.F4, 0);
					flag = true;
				}
				else if (windowProcessName.EqualsAny(true, "wechatbrowser", "wechat", "shiyeline"))
				{
					InputSimulator.Instance.Keyboard.ModifiedKeyStroke(new List<VirtualKeyCode>(), VirtualKeyCode.ESCAPE, 0);
					flag = true;
				}
			}
			catch
			{
			}
			if (!flag)
			{
				NativeMethods.SendMessage(foregroundOrMousePositionWindow, 16, IntPtr.Zero, IntPtr.Zero);
			}
			return;
		}
		try
		{
			InputSimulator.Instance.Keyboard.ModifiedKeyStroke(new List<VirtualKeyCode> { VirtualKeyCode.LMENU }, VirtualKeyCode.F4, 0);
		}
		catch
		{
		}
	}

	public static void CloseWindow(IntPtr hWnd)
	{
		NativeMethods.SendMessage(hWnd, 16, IntPtr.Zero, IntPtr.Zero);
	}

	public static void MinimizeForegroundWindow()
	{
		IntPtr foregroundOrMousePositionWindow = GetForegroundOrMousePositionWindow();
		if (!NativeMethods.IsOnDesktop(foregroundOrMousePositionWindow) && !NativeMethods.IsOnTaskbar(foregroundOrMousePositionWindow))
		{
			SendCommandToForegroundWindow((IntPtr)61472L);
		}
	}

	public static void MaxmizeForegroundWindow()
	{
		SendCommandToForegroundWindow((IntPtr)61488L);
	}

	public static void RestoreForegroundWindow()
	{
		SendCommandToForegroundWindow((IntPtr)61728L);
	}

	public static void SendCommandToForegroundWindow(IntPtr cmd)
	{
		IntPtr foregroundOrMousePositionWindow = GetForegroundOrMousePositionWindow();
		if (foregroundOrMousePositionWindow != IntPtr.Zero)
		{
			SendSysCommand(foregroundOrMousePositionWindow, cmd);
		}
	}

	public static void SendSysCommand(IntPtr hWnd, IntPtr cmd)
	{
		NativeMethods.SendMessage(hWnd, 274, cmd, IntPtr.Zero);
	}

	public static void MaximizeWindow(IntPtr hwnd)
	{
		SendSysCommand(hwnd, (IntPtr)61488L);
	}

	public static bool RestoreAndSetForeground(IntPtr hwnd)
	{
		if (NativeMethods.IsIconic(hwnd))
		{
			NativeMethods.ShowWindow(hwnd, 9);
		}
		return NativeMethods.SetForegroundWindow(hwnd);
	}

	public static void MoveToScreenCenter(IntPtr hwnd)
	{
		Screen screen = Screen.FromPoint(NativeMethods.GetMousePosition());
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(hwnd);
		NativeMethods.SetWindowPos(hwnd, IntPtr.Zero, screen.WorkingArea.Left + (screen.WorkingArea.Width - (windowRectangle.Right - windowRectangle.Left)) / 2, screen.WorkingArea.Top + (screen.WorkingArea.Height - (windowRectangle.Bottom - windowRectangle.Top)) / 2, 0, 0, SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOZORDER);
	}

	public static bool IsWindowTopmost(IntPtr hWnd)
	{
		return (NativeMethods.GetWindowLong(hWnd, -20) & 8) == 8;
	}

	public static (bool isSuccess, bool isTopmoseAfterOperation) ToggleTopmost(IntPtr hWnd)
	{
		bool flag;
		IntPtr hWndInsertAfter = ((flag = IsWindowTopmost(hWnd)) ? NativeMethods.HWND_NOTOPMOST : NativeMethods.HWND_TOPMOST);
		return (isSuccess: NativeMethods.SetWindowPos(hWnd, hWndInsertAfter, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE), isTopmoseAfterOperation: !flag);
	}

	public static bool RemoveTopmost(IntPtr hWnd)
	{
		return NativeMethods.SetWindowPos(hWnd, NativeMethods.HWND_NOTOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
	}

	public static bool SetTopmost(IntPtr hWnd)
	{
		return NativeMethods.SetWindowPos(hWnd, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
	}

	internal static bool hMNLFGcwaHv(IntPtr intptr_0)
	{
		return NativeMethods.SetWindowPos(intptr_0, NativeMethods.HWND_BOTTOM, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
	}

	public static void EnsureTopMost(Window window, bool noActivate)
	{
		NativeMethods.SetWindowPos(new WindowInteropHelper(window).Handle, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, (SetWindowPosFlags)(3 | (noActivate ? 16 : 0)));
	}

	public static System.Drawing.Point GetWindowTopLeft(IntPtr hWnd)
	{
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(hWnd);
		return new System.Drawing.Point(windowRectangle.Left, windowRectangle.Top);
	}

	public static System.Drawing.Point GetWindowTopLeft(Window window)
	{
		return GetWindowTopLeft(new WindowInteropHelper(window).Handle);
	}

	public static IntPtr GetHandle(Window window)
	{
		return new WindowInteropHelper(window).Handle;
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowPlacement", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool h1FLFsKmFKE(IntPtr intptr_0, [In] ref lf5vekDeXk46lOmE24G lf5vekDeXk46lOmE24G_0);

	private static lf5vekDeXk46lOmE24G eRaLFHc3who(IntPtr intptr_0)
	{
		lf5vekDeXk46lOmE24G lf5vekDeXk46lOmE24G_ = default(lf5vekDeXk46lOmE24G);
		lf5vekDeXk46lOmE24G_.DZ32SlyB0v9 = Marshal.SizeOf(lf5vekDeXk46lOmE24G_);
		NBbLF1XquoH(intptr_0, ref lf5vekDeXk46lOmE24G_);
		return lf5vekDeXk46lOmE24G_;
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowPlacement", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool NBbLF1XquoH(IntPtr intptr_0, ref lf5vekDeXk46lOmE24G lf5vekDeXk46lOmE24G_0);

	public static void MaximizeOrRestoreForegroundWindow()
	{
		MaximizeOrRestoreWindow(GetForegroundOrMousePositionWindow());
	}

	public static IntPtr GetForegroundOrMousePositionWindow()
	{
		IntPtr intPtr = NativeMethods.GetForegroundWindow();
		if (intPtr == IntPtr.Zero || intPtr == AppState.MainWinHandle)
		{
			intPtr = NativeMethods.GetMousePositionWindow();
		}
		return intPtr;
	}

	public static void MaximizeOrRestoreWindow(IntPtr hwnd)
	{
		if (eRaLFHc3who(hwnd).c6o2S3eADqB == wfilwvDbbr9unseQn7y.Maximized)
		{
			SendSysCommand(hwnd, (IntPtr)61728L);
		}
		else
		{
			SendSysCommand(hwnd, (IntPtr)61488L);
		}
	}

	public static void RestoreWindowIfMaxmized(IntPtr hwnd)
	{
		if (eRaLFHc3who(hwnd).c6o2S3eADqB == wfilwvDbbr9unseQn7y.Maximized)
		{
			SendSysCommand(hwnd, (IntPtr)61728L);
		}
	}

	public static int GetWindowState(IntPtr hwnd)
	{
		return (int)eRaLFHc3who(hwnd).c6o2S3eADqB;
	}

	public static void MinimizeWindowAndOwner(Window window)
	{
		if (window != null)
		{
			window.WindowState = WindowState.Minimized;
			MinimizeWindowAndOwner(window.Owner);
		}
	}

	public static void RestoreWindowAndOwner(Window window)
	{
		if (window != null)
		{
			window.WindowState = WindowState.Normal;
			RestoreWindowAndOwner(window.Owner);
			window.Activate();
		}
	}

	public static void MoveTo(Window window, System.Drawing.Point pos, bool moveIntoScreen)
	{
		if (moveIntoScreen && !IHNRIiikxBwJdYmHpM3.AfmvSwEMPMe(new System.Drawing.Point(pos.X + (int)window.Width / 2, pos.Y + (int)window.Height / 2)))
		{
			new System.Drawing.Point(100, 100);
		}
		NativeMethods.SetWindowPos(new WindowInteropHelper(window).Handle, IntPtr.Zero, pos.X, pos.Y, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOREDRAW | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOZORDER);
	}

	public static IntPtr GetRootWindowWithSameProcess(IntPtr wnd)
	{
		User32.GetWindowThreadProcessId(wnd, out var lpdwProcessId);
		IntPtr intPtr = wnd;
		while (true)
		{
			IntPtr ancestor = User32.GetAncestor(intPtr, User32.GetAncestorFlags.GA_PARENT);
			if (!(ancestor == IntPtr.Zero))
			{
				if (!(ancestor == intPtr))
				{
					User32.GetWindowThreadProcessId(ancestor, out var lpdwProcessId2);
					if (lpdwProcessId2 != lpdwProcessId)
					{
						break;
					}
					intPtr = ancestor;
					continue;
				}
				return intPtr;
			}
			return intPtr;
		}
		return intPtr;
	}

	[DllImport("user32.dll", EntryPoint = "GetLayeredWindowAttributes", SetLastError = true)]
	private static extern bool VrYLFbr8Me2(IntPtr intptr_0, out uint uint_0, out byte byte_0, out uint uint_1);

	internal static byte LLXLF6Ttuxf(IntPtr intptr_0)
	{
		uint uint_ = 2u;
		if (!VrYLFbr8Me2(intptr_0, out var uint_2, out var byte_, out uint_))
		{
			return byte.MaxValue;
		}
		return byte_;
	}

	internal static void pq6LFXUHba6(IntPtr intptr_0, int int_0)
	{
		int num = LLXLF6Ttuxf(intptr_0) + int_0;
		if (num < 0)
		{
			num = 0;
		}
		else if (num > 255)
		{
			num = 255;
		}
		AutoItX.WinSetTrans(intptr_0, num);
	}

	internal static void EmWLFmQtusT(int int_0)
	{
		pq6LFXUHba6(GetForegroundOrMousePositionWindow(), int_0);
	}

	[DllImport("kernel32.dll")]
	public static extern uint GetCurrentThreadId();

	[DllImport("user32.dll", EntryPoint = "AttachThreadInput")]
	private static extern bool t0ZLFKgNiHN(uint uint_0, uint uint_1, bool bool_0);

	[DllImport("user32.dll", EntryPoint = "GetFocus")]
	private static extern IntPtr O9uLFxLVKwP();

	[DllImport("user32.dll", EntryPoint = "GetCaretPos")]
	private static extern bool KCDLFrOHnXx(out System.Drawing.Point point_0);

	[DllImport("user32.dll", EntryPoint = "ClientToScreen")]
	private static extern bool wUiLFpmMbE4(IntPtr intptr_0, ref System.Drawing.Point point_0);

	public static System.Drawing.Point GetCaretPosition()
	{
		NativeMethods.GUITHREADINFO foregroundGUITHREADINFO = NativeMethods.GetForegroundGUITHREADINFO();
		System.Drawing.Point point_ = new System.Drawing.Point
		{
			X = foregroundGUITHREADINFO.rectCaret.Left,
			Y = foregroundGUITHREADINFO.rectCaret.Bottom
		};
		bool flag = point_ == System.Drawing.Point.Empty;
		wUiLFpmMbE4(foregroundGUITHREADINFO.hwndCaret, ref point_);
		return point_;
	}

	internal static bool HP9LFBj7trn(IntPtr intptr_0, string string_0, string string_1, int[] int_0, bool bool_0, bool bool_1 = false)
	{
		if (int_0.HasData())
		{
			_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
			_003C_003Ec__DisplayClass55_.Yia22S2WTHk = NativeMethods.GetWindowProcessId(intptr_0);
			if (int_0.All(_003C_003Ec__DisplayClass55_.HhI22vRbFDg))
			{
				return false;
			}
		}
		int num;
		if (!string.IsNullOrEmpty(string_0))
		{
			string windowClass = NativeMethods.GetWindowClass(intptr_0);
			if (!bool_0)
			{
				if (!string.Equals(windowClass, string_0, StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
			}
			else if (!Regex.IsMatch(windowClass, string_0))
			{
				num = 1;
				if (q5GYb7FM8VHW28NpZJvu())
				{
					goto IL_00d4;
				}
				goto IL_010a;
			}
		}
		else if (bool_1)
		{
			string windowClass2 = NativeMethods.GetWindowClass(intptr_0);
			if (windowClass2.StartsWith("BAIDU_CLASS_IME_"))
			{
				return false;
			}
			if (windowClass2.Equals("GDI+ Hook Window Class", StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (windowClass2.Contains("Candidate") || windowClass2 == "StatusBarWnd")
			{
				return false;
			}
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			num = 0;
			if (!q5GYb7FM8VHW28NpZJvu())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00d4;
		}
		goto IL_010c;
		IL_010c:
		return true;
		IL_010a:
		return false;
		IL_00d4:
		switch (num)
		{
		case 1:
			goto IL_010a;
		}
		string windowTitle = NativeMethods.GetWindowTitle(intptr_0);
		if (bool_0)
		{
			if (windowTitle == null || !Regex.IsMatch(windowTitle, string_1))
			{
				return false;
			}
		}
		else if (!string.Equals(windowTitle, string_1, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		goto IL_010c;
	}

	internal static bool IKlLFQNEaTx(IntPtr intptr_0, out System.Drawing.Size size_0)
	{
		NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(intptr_0);
		size_0 = new System.Drawing.Size(windowRect.Right - windowRect.Left, windowRect.Bottom - windowRect.Top);
		if (windowRect.Right <= windowRect.Left)
		{
			return windowRect.Bottom > windowRect.Top;
		}
		return true;
	}

	internal static IntPtr hVrLFjUVDGe(int[] int_0, string string_0, string string_1, System.Drawing.Size size_0 = default(System.Drawing.Size))
	{
		IDictionary<IntPtr, long> dictionary = new Dictionary<IntPtr, long>();
		foreach (KeyValuePair<IntPtr, string> openWindow in OpenWindowGetter.GetOpenWindows(false))
		{
			if (!IKlLFQNEaTx(openWindow.Key, out var size_1))
			{
				continue;
			}
			if (size_0 != default(System.Drawing.Size))
			{
				if (size_1.Width < size_0.Width)
				{
					if (q5GYb7FM8VHW28NpZJvu())
					{
						switch (0)
						{
						}
					}
					continue;
				}
				if (size_1.Height < size_0.Height)
				{
					continue;
				}
			}
			if (HP9LFBj7trn(openWindow.Key, string_0, string_1, int_0, true, true))
			{
				dictionary.Add(openWindow.Key, size_1.Height * size_1.Width);
			}
		}
		if (!dictionary.HasData())
		{
			return IntPtr.Zero;
		}
		return dictionary.OrderByDescending(_003C_003Ec.NHS22L30TS7 ?? (_003C_003Ec.NHS22L30TS7 = _003C_003Ec.gbi22gxZHLM.ruF22tw06kR)).First().Key;
	}

	internal static void WEZLFn7C238(IntPtr intptr_0, int int_0, int int_1)
	{
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intptr_0);
		NativeMethods.SetWindowPos(intptr_0, IntPtr.Zero, windowRectangle.Left + int_0, windowRectangle.Top + int_1, 0, 0, SetWindowPosFlags.SWP_NOREDRAW | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOZORDER);
	}

	internal static bool q5GYb7FM8VHW28NpZJvu()
	{
		return avqoi0FMYEgIy1DbVT4a == null;
	}
}
