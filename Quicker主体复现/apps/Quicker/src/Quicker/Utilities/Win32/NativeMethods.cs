using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Bx5KVGMpLudaT3Vsr6r;
using CW.Win32;
using eHGj15MUIx8QneCHitQ;
using EVZS7kMzC1tLgpCKHrr;
using log4net;
using m3jYLpMQ1pLSiv24SaP;
using ManagedShell.Interop;
using O6kyQPMG2pgVWuvG35d;
using PHnGQZMrVDpCv5cpXPI;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Utilities._3rd;
using SHDocVw;
using Shell32;
using xrrtJZMxD9GsQRh8P5S;
using yvtPKofqpBDUbIJcBbI;

namespace Quicker.Utilities.Win32;

public static class NativeMethods
{
	public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

	public struct DWM_BLURBEHIND
	{
		public DWM_BB dwFlags;

		public bool fEnable;

		public IntPtr hRgnBlur;

		public bool fTransitionOnMaximized;
	}

	[Flags]
	public enum DWM_BB
	{
		DWM_BB_ENABLE = 1,
		DWM_BB_BLURREGION = 2,
		DWM_BB_TRANSITIONONMAXIMIZED = 4
	}

	[StructLayout(LayoutKind.Sequential)]
	public class POINT
	{
		public int x;

		public int y;

		private static POINT UCE4mGyGw8FIXmFl30ru;

		internal static bool QB5n5XyGTZPg32tBSiQI()
		{
			return UCE4mGyGw8FIXmFl30ru == null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class MouseHookStruct
	{
		public POINT pt;

		public int hwnd;

		public int wHitTestCode;

		public int dwExtraInfo;

		private static MouseHookStruct wFxfZCyGsu44QpbVjTfW;

		internal static void vm9RJiyG4tp5gZQs2Sj5()
		{
		}

		internal static bool DAMP5IyGC7t2mwwsoi6N()
		{
			return wFxfZCyGsu44QpbVjTfW == null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class MouseLLHookStruct
	{
		public POINT pt;

		public int mouseData;

		public int flags;

		public int time;

		public UIntPtr dwExtraInfo;

		internal static MouseLLHookStruct s4TCReyGh8YfEg9adZKN;

		internal static bool kwgHycyGH806IjvCwjdK()
		{
			return s4TCReyGh8YfEg9adZKN == null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class KeyboardHookStruct
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;

		private static KeyboardHookStruct PKFGoyy0VQ57O8jY1VXs;

		internal static bool uq3T0Vy0QCwbHOeaVkAq()
		{
			return PKFGoyy0VQ57O8jY1VXs == null;
		}
	}

	public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

	public delegate bool WindowEnumProc(IntPtr hwnd, IntPtr lparam);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public uint dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	[Serializable]
	internal struct oY8KsdDc7bANQ7gQUvM
	{
		public int Nvp22XwaEJO;

		public int LGS22mhHyMx;

		public defwBWD9oM0jsp5m20d Vgb22K0lnMY;

		public POINT WIC22xgjpx0;

		public POINT EQa22rtS9X5;

		public RECT EF222pD9gCa;
	}

	internal enum defwBWD9oM0jsp5m20d
	{
		Normal = 1,
		Maximized = 3
	}

	public struct HResult
	{
		private readonly int z4j22BaL0V8;

		private static object wBqm3ty0jFM4TXnpxt8e;

		public int Value => z4j22BaL0V8;

		public Exception Exception => Marshal.GetExceptionForHR(z4j22BaL0V8);

		public bool IsSuccess => z4j22BaL0V8 >= 0;

		public bool IsFailure => z4j22BaL0V8 < 0;

		internal static bool u9Tpbvy0Dd8pEyyNab0H()
		{
			return wBqm3ty0jFM4TXnpxt8e == null;
		}
	}

	internal struct WMgqc8DPfO1vLRdX3NM
	{
		public int X;

		public int Y;
	}

	public enum GetAncestorFlags
	{
		GetParent = 1,
		GetRoot,
		GetRootOwner
	}

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		private static object Gs9Fduy0vU4mvmJUebLI;

		public int Width => Right - Left;

		public int Height => Bottom - Top;

		public override string ToString()
		{
			return $"{Left},{Top},{Right},{Bottom}";
		}

		internal static bool eInt4wy0deS54c88jOVu()
		{
			return Gs9Fduy0vU4mvmJUebLI == null;
		}
	}

	[Flags]
	public enum DwmWindowAttribute : uint
	{
		DWMWA_NCRENDERING_ENABLED = 1u,
		DWMWA_NCRENDERING_POLICY = 2u,
		DWMWA_TRANSITIONS_FORCEDISABLED = 3u,
		DWMWA_ALLOW_NCPAINT = 4u,
		DWMWA_CAPTION_BUTTON_BOUNDS = 5u,
		DWMWA_NONCLIENT_RTL_LAYOUT = 6u,
		DWMWA_FORCE_ICONIC_REPRESENTATION = 7u,
		DWMWA_FLIP3D_POLICY = 8u,
		DWMWA_EXTENDED_FRAME_BOUNDS = 9u,
		DWMWA_HAS_ICONIC_BITMAP = 0xAu,
		DWMWA_DISALLOW_PEEK = 0xBu,
		DWMWA_EXCLUDED_FROM_PEEK = 0xCu,
		DWMWA_CLOAK = 0xDu,
		DWMWA_CLOAKED = 0xEu,
		DWMWA_FREEZE_REPRESENTATION = 0xFu,
		DWMWA_LAST = 0x10u
	}

	[Flags]
	public enum ProcessAccessFlags : uint
	{
		All = 0x1F0FFFu,
		Terminate = 1u,
		CreateThread = 2u,
		VMOperation = 8u,
		VMRead = 0x10u,
		VMWrite = 0x20u,
		DupHandle = 0x40u,
		SetInformation = 0x200u,
		QueryInformation = 0x400u,
		Synchronize = 0x100000u
	}

	public struct COPYDATASTRUCT
	{
		public IntPtr dwData;

		public int cbData;

		public IntPtr lpData;
	}

	private struct RnF3nvDyqaYEwCwdsoo
	{
		public int wkR22Qctr7u;

		public readonly int O7C22jFMUlk;

		public readonly IntPtr mLu22njjHQY;

		public readonly POINT zl02245Qbmu;
	}

	public enum GetWindowType : uint
	{
		GW_HWNDFIRST,
		GW_HWNDLAST,
		GW_HWNDNEXT,
		GW_HWNDPREV,
		GW_OWNER,
		GW_CHILD,
		GW_ENABLEDPOPUP
	}

	public enum QUERY_USER_NOTIFICATION_STATE
	{
		QUNS_NOT_PRESENT = 1,
		QUNS_BUSY,
		QUNS_RUNNING_D3D_FULL_SCREEN,
		QUNS_PRESENTATION_MODE,
		QUNS_ACCEPTS_NOTIFICATIONS,
		QUNS_QUIET_TIME
	}

	public struct GUITHREADINFO
	{
		public int cbSize;

		public int flags;

		public IntPtr hwndActive;

		public IntPtr hwndFocus;

		public IntPtr hwndCapture;

		public IntPtr hwndMenuOwner;

		public IntPtr hwndMoveSize;

		public IntPtr hwndCaret;

		public RECT rectCaret;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ocY22DI85XN;

		public static Func<string, string> YV322dUHNME;

		internal static _003C_003Ec q3Jv4qy0MphS5b5yaMTI;

		static _003C_003Ec()
		{
			ocY22DI85XN = new _003C_003Ec();
		}

		internal string IJb225NhBUt(string x)
		{
			return x;
		}

		internal static bool a634bBy0UeWFlLqGQyPN()
		{
			return q3Jv4qy0MphS5b5yaMTI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass115_0
	{
		public bool MHE22TEw1xw;

		public List<IntPtr> noa22MtGLlB;

		internal static _003C_003Ec__DisplayClass115_0 mlBD6Gy0IrEkvqXeCdAK;

		internal bool S2p22o6RPtm(IntPtr hwnd, object o)
		{
			if (!MHE22TEw1xw)
			{
				noa22MtGLlB.Add(hwnd);
			}
			else if (IsWindowVisible(hwnd))
			{
				noa22MtGLlB.Add(hwnd);
			}
			return true;
		}

		internal static bool tXMUYey06HOF4LWM1YE0()
		{
			return mlBD6Gy0IrEkvqXeCdAK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass116_0
	{
		public IDictionary<int, Process> nFl22OFYOAH;

		private static _003C_003Ec__DisplayClass116_0 B5Av5Ty0SHCsLQe3bSIQ;

		internal void hNY22AFcqYA(IntPtr handle)
		{
			int windowProcessId = GetWindowProcessId(handle);
			if (nFl22OFYOAH.ContainsKey(windowProcessId))
			{
				return;
			}
			try
			{
				Process process = Process.GetProcessById(windowProcessId);
				if (HostedProcessHelper.IsHostProcess(process))
				{
					process = HostedProcessHelper.GetRealProcess(process);
				}
				nFl22OFYOAH.SetOrAdd(windowProcessId, process);
			}
			catch
			{
			}
		}

		internal static bool lbSk4ly0wCV324bY8Vny()
		{
			return B5Av5Ty0SHCsLQe3bSIQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass139_0
	{
		public IntPtr? b9322UK2VPm;

		public int GaJ22lU4r0q;

		public IList<string> oR622iss84o;

		internal static _003C_003Ec__DisplayClass139_0 VNUtomy0mZSP8G4ktPjG;

		internal void xT022Fi1TOO()
		{
			(IntPtr, IntPtr) currentExplorerWindow = GetCurrentExplorerWindow(b9322UK2VPm);
			GaJ22lU4r0q = bPkZl9MLR2X9Cd6jq5M.A4JLU66XXXH(currentExplorerWindow.Item1, currentExplorerWindow.Item2, oR622iss84o);
		}

		internal static bool uxCJP3y0sJEZIL8ZYJdR()
		{
			return VNUtomy0mZSP8G4ktPjG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass140_0
	{
		public IList<string> fe722fF66AD;

		private static _003C_003Ec__DisplayClass140_0 aVPD0Sy07DSocwQqhAaj;

		internal void Qew2230oEHR()
		{
			(IntPtr, IntPtr) currentExplorerWindow = GetCurrentExplorerWindow(null);
			fe722fF66AD = bPkZl9MLR2X9Cd6jq5M.FbCLUm8mmq5(currentExplorerWindow.Item1, currentExplorerWindow.Item2);
		}

		internal static bool hgHNKIy04k98DRUHTanO()
		{
			return aVPD0Sy07DSocwQqhAaj == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__160
	{
		public static CallSite<Func<CallSite, object, object>> nyP22zDpb82;

		public static CallSite<Func<CallSite, object, object>> CMP2uwntmBi;

		public static CallSite<Func<CallSite, object, object>> z412utrOoFU;

		public static CallSite<Func<CallSite, object, string>> DNS2ugexfjQ;
	}

	private static readonly ILog zKfLUY4bvwW;

	public const int SW_MAXIMIZE = 3;

	public const int SW_SHOWNORMAL = 1;

	public const int SW_RESTORE = 9;

	public const int SW_SHOW = 5;

	public const int WS_EX_NOACTIVATE = 134217728;

	public const int WS_EX_APPWINDOW = 262144;

	public const int GWL_EXSTYLE = -20;

	public const int WS_EX_TOOLWINDOW = 128;

	public const uint SHGFI_ICON = 256u;

	public const uint SHGFI_LARGEICON = 0u;

	public const int WH_MOUSE_LL = 14;

	public const int WH_KEYBOARD_LL = 13;

	public const int WH_MOUSE = 7;

	public const int WH_KEYBOARD = 2;

	public const int WM_MOUSEMOVE = 512;

	public const int WM_LBUTTONDOWN = 513;

	public const int WM_LBUTTONUP = 514;

	public const int WM_RBUTTONDOWN = 516;

	public const int WM_RBUTTONUP = 517;

	public const int WM_MBUTTONDOWN = 519;

	public const int WM_MBUTTONUP = 520;

	public const int WM_XBUTTONDOWN = 523;

	public const int WM_XBUTTONUP = 524;

	public const int WM_LBUTTONDBLCLK = 515;

	public const int WM_RBUTTONDBLCLK = 518;

	public const int WM_MBUTTONDBLCLK = 521;

	public const int WM_MOUSEWHEEL = 522;

	public const int WM_MOUSEHWHEEL = 526;

	public const int WM_KEYDOWN = 256;

	public const int WM_KEYUP = 257;

	public const int WM_SYSKEYDOWN = 260;

	public const int WM_SYSKEYUP = 261;

	public const byte VK_SHIFT = 16;

	public const byte VK_CAPITAL = 20;

	public const byte VK_NUMLOCK = 144;

	public const byte VK_LSHIFT = 160;

	public const byte VK_RSHIFT = 161;

	public const byte VK_LCONTROL = 162;

	public const byte VK_RCONTROL = 3;

	public const byte VK_LALT = 164;

	public const byte VK_RALT = 165;

	public const byte LLKHF_ALTDOWN = 32;

	public const int ILD_IMAGE = 32;

	private static IntPtr niALUIQp6qw;

	private static bool B0uLUW0Cq7s;

	public static readonly IntPtr HWND_TOPMOST;

	public static readonly IntPtr HWND_NOTOPMOST;

	public static readonly IntPtr HWND_TOP;

	public static readonly IntPtr HWND_BOTTOM;

	public const int WM_CLIPBOARDUPDATE = 797;

	private static object NSnmDuFUA6MK6QGeH6to;

	[DllImport("user32.dll")]
	public static extern long GetClipboardSequenceNumber();

	[DllImport("user32.dll")]
	public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

	[DllImport("user32.dll")]
	public static extern bool UnhookWinEvent(IntPtr hWinEventHook);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetActiveWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32")]
	public static extern bool IsIconic(IntPtr hWnd);

	[DllImport("user32")]
	public static extern bool OpenIcon(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowLong(IntPtr hwnd, int index);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

	[DllImport("user32.dll", EntryPoint = "SetWindowCompositionAttribute")]
	internal static extern int b1XLFfxDTrm(IntPtr intptr_1, ref I7PE4lMCRDOwJcOdSQH i7PE4lMCRDOwJcOdSQH_0);

	[DllImport("DwmApi.dll", PreserveSig = false)]
	public static extern bool DwmIsCompositionEnabled();

	[DllImport("DwmApi.dll", PreserveSig = false)]
	public static extern void DwmEnableBlurBehindWindow(IntPtr hwnd, ref DWM_BLURBEHIND blurBehind);

	public static void SetWindowNoActivate(Window window)
	{
		SetWindowNoActivate(new WindowInteropHelper(window).Handle);
	}

	public static void SetWindowNoActivate(IntPtr hWnd)
	{
		int windowLong = GetWindowLong(hWnd, -20);
		SetWindowLong(hWnd, -20, windowLong | 0x8000000);
	}

	public static void SetWindowNoMaximize(IntPtr hWnd)
	{
		int windowLong = GetWindowLong(hWnd, -16);
		SetWindowLong(hWnd, -16, windowLong & -65537);
	}

	public static void SetWindowNoMaximize(Window window)
	{
		SetWindowNoMaximize(new WindowInteropHelper(window).Handle);
	}

	public static bool IsWindowNoActivate(IntPtr hWnd)
	{
		return (GetWindowLong(hWnd, -20) & 0x8000000) > 0;
	}

	public static void UnsetWindowNoActivate(IntPtr hWnd)
	{
		int windowLong = GetWindowLong(hWnd, -20);
		SetWindowLong(hWnd, -20, windowLong & -134217729);
	}

	public static void UnsetWindowNoActivate(Window window)
	{
		UnsetWindowNoActivate(new WindowInteropHelper(window).Handle);
	}

	public static void SetWindowTopmost(Window window)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
		IntPtr intptr_ = new IntPtr(-1);
		JBqLUeONmu2(windowInteropHelper.Handle, intptr_, 0, 0, 0, 0, 67u);
	}

	public static bool IsWindowTopMost(IntPtr hWnd)
	{
		return (GetWindowLong(hWnd, -20) & 8) == 8;
	}

	public static void EnableBlur(Window window, uint blurOpacity, uint blurBackgroundColor, int blurMode)
	{
		if (!DwmIsCompositionEnabled())
		{
			zKfLUY4bvwW.Warn("未开启桌面合成，已取消模糊支持。");
			return;
		}
		bool flag = blurMode == 4;
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
		UXmgA7Mtonx3Kq5919Z structure = default(UXmgA7Mtonx3Kq5919Z);
		switch (blurMode)
		{
		case 0:
			structure.E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)1;
			break;
		case 1:
			structure.E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)0;
			break;
		default:
			if (flag)
			{
				if (Environment.OSVersion.Version.Build >= 18362)
				{
					structure.E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)3;
				}
				else
				{
					structure.E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)4;
				}
			}
			else
			{
				structure.E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)3;
			}
			break;
		}
		structure.LIlLUs3yoi6 = (blurOpacity << 24) | (blurBackgroundColor & 0xFFFFFF);
		structure.LCNLUGM33wu = 480u;
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(structure, intPtr, false);
		I7PE4lMCRDOwJcOdSQH i7PE4lMCRDOwJcOdSQH_ = new I7PE4lMCRDOwJcOdSQH
		{
			JvdLU14stON = (n26edrMIxFrghoBIBkZ)19,
			Jy3LUbK2lEj = num,
			Data = intPtr
		};
		b1XLFfxDTrm(windowInteropHelper.Handle, ref i7PE4lMCRDOwJcOdSQH_);
		Marshal.FreeHGlobal(intPtr);
	}

	public static void EnableBlur(Window window)
	{
		if (DwmIsCompositionEnabled())
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
			UXmgA7Mtonx3Kq5919Z structure = new UXmgA7Mtonx3Kq5919Z
			{
				E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)3
			};
			int num = Marshal.SizeOf(structure);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(structure, intPtr, false);
			I7PE4lMCRDOwJcOdSQH i7PE4lMCRDOwJcOdSQH_ = new I7PE4lMCRDOwJcOdSQH
			{
				JvdLU14stON = (n26edrMIxFrghoBIBkZ)19,
				Jy3LUbK2lEj = num,
				Data = intPtr
			};
			b1XLFfxDTrm(windowInteropHelper.Handle, ref i7PE4lMCRDOwJcOdSQH_);
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static void DisableBlur(Window window)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
		UXmgA7Mtonx3Kq5919Z structure = new UXmgA7Mtonx3Kq5919Z
		{
			E1rLUkV06PK = (PvHsW8MB5wkpdNyM3h9)0,
			LCNLUGM33wu = 480u
		};
		int num = Marshal.SizeOf(structure);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(structure, intPtr, false);
		I7PE4lMCRDOwJcOdSQH i7PE4lMCRDOwJcOdSQH_ = new I7PE4lMCRDOwJcOdSQH
		{
			JvdLU14stON = (n26edrMIxFrghoBIBkZ)19,
			Jy3LUbK2lEj = num,
			Data = intPtr
		};
		b1XLFfxDTrm(windowInteropHelper.Handle, ref i7PE4lMCRDOwJcOdSQH_);
		Marshal.FreeHGlobal(intPtr);
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(HookType hookType, HookProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool UnhookWindowsHookEx(IntPtr idHook);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32")]
	public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

	[DllImport("user32")]
	public static extern int GetKeyboardState(byte[] pbKeyState);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern short GetKeyState(int vKey);

	[DllImport("Comctl32.dll")]
	public static extern IntPtr ImageList_GetIcon(IntPtr himl, int i, uint flags);

	[DllImport("gdi32.dll", SetLastError = true)]
	public static extern bool DeleteObject(IntPtr hObject);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc callback, IntPtr lParam);

	public static int GetWindowProcessId(IntPtr hwnd)
	{
		GetWindowThreadProcessId(hwnd, out int ProcessId);
		return ProcessId;
	}

	[DllImport("user32.dll")]
	public static extern short VkKeyScan(char ch);

	[DllImport("shlwapi.dll", BestFitMapping = false, CharSet = CharSet.Unicode, ExactSpelling = true, ThrowOnUnmappableChar = true)]
	public static extern int SHLoadIndirectString(string pszSource, StringBuilder pszOutBuf, uint cchOutBuf, IntPtr ppvReserved);

	[DllImport("kernel32")]
	public static extern int OpenPackageInfoByFullName([MarshalAs(UnmanagedType.LPWStr)] string fullName, uint reserved, out IntPtr packageInfo);

	[DllImport("kernel32")]
	public static extern int GetPackageApplicationIds(IntPtr pir, ref int bufferLength, byte[] buffer, out int count);

	[DllImport("kernel32")]
	public static extern int ClosePackageInfo(IntPtr pir);

	[DllImport("shell32", CharSet = CharSet.Unicode)]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint flags);

	[DllImport("shell32", EntryPoint = "SHGetFolderLocation")]
	private static extern HResult TiQLFzsfo3s(IntPtr intptr_1, int int_0, IntPtr intptr_2, int int_1, out IntPtr intptr_3);

	[DllImport("shell32", EntryPoint = "ILFree")]
	private static extern void ffnLUwhyfGy(IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "ChangeWindowMessageFilter", SetLastError = true)]
	private static extern IntPtr GR3LUtRBgkP(uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "ChangeWindowMessageFilterEx", SetLastError = true)]
	private static extern bool FvhLUgk8Eny(IntPtr intptr_1, uint uint_0, uint uint_1, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "GetWindowPlacement", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MI7LULeHOWE(IntPtr intptr_1, ref oY8KsdDc7bANQ7gQUvM oY8KsdDc7bANQ7gQUvM_0);

	private static ImageSource sBvLUvi5jO3(Icon icon_0)
	{
		return Imaging.CreateBitmapSourceFromHIcon(icon_0.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
	}

	public static string GetLnkFileDisplayName(string path)
	{
		SHFILEINFO psfi = default(SHFILEINFO);
		if (IntPtr.Zero != SHGetFileInfo(path, 128u, out psfi, (uint)Marshal.SizeOf(typeof(SHFILEINFO)), 512u))
		{
			return psfi.szDisplayName;
		}
		return null;
	}

	public static string GetAppBasePath()
	{
		return AppDomain.CurrentDomain.BaseDirectory;
	}

	public static IEnumerable<IntPtr> GetDesktopWindows(bool onlyVisible)
	{
		_003C_003Ec__DisplayClass115_0 _003C_003Ec__DisplayClass115_ = new _003C_003Ec__DisplayClass115_0();
		_003C_003Ec__DisplayClass115_.MHE22TEw1xw = onlyVisible;
		_003C_003Ec__DisplayClass115_.noa22MtGLlB = new List<IntPtr>();
		User32.EnumWindows(_003C_003Ec__DisplayClass115_.S2p22o6RPtm, _003C_003Ec__DisplayClass115_.noa22MtGLlB);
		return _003C_003Ec__DisplayClass115_.noa22MtGLlB;
	}

	public static IList<Process> GetProcessesWithWindow()
	{
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_0();
		IEnumerable<IntPtr> desktopWindows = GetDesktopWindows(true);
		_003C_003Ec__DisplayClass116_.nFl22OFYOAH = new ConcurrentDictionary<int, Process>();
		Parallel.ForEach(desktopWindows, _003C_003Ec__DisplayClass116_.hNY22AFcqYA);
		return _003C_003Ec__DisplayClass116_.nFl22OFYOAH.Values.ToList();
	}

	internal static oY8KsdDc7bANQ7gQUvM e7gLUSXlt3U(IntPtr intptr_1)
	{
		oY8KsdDc7bANQ7gQUvM oY8KsdDc7bANQ7gQUvM_ = default(oY8KsdDc7bANQ7gQUvM);
		oY8KsdDc7bANQ7gQUvM_.Nvp22XwaEJO = Marshal.SizeOf(oY8KsdDc7bANQ7gQUvM_);
		MI7LULeHOWE(intptr_1, ref oY8KsdDc7bANQ7gQUvM_);
		return oY8KsdDc7bANQ7gQUvM_;
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowPlacement")]
	internal static extern bool ydhLU2G2WEl(IntPtr intptr_1, [In] ref oY8KsdDc7bANQ7gQUvM oY8KsdDc7bANQ7gQUvM_0);

	[DllImport("user32.dll", EntryPoint = "GetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool kSmLUugKY6g(ref WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_0);

	[DllImport("user32.dll", EntryPoint = "GetPhysicalCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ey6LUN98AJy(ref WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_0);

	public static System.Drawing.Point GetMousePosition()
	{
		WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_ = default(WMgqc8DPfO1vLRdX3NM);
		kSmLUugKY6g(ref wmgqc8DPfO1vLRdX3NM_);
		return new System.Drawing.Point(wmgqc8DPfO1vLRdX3NM_.X, wmgqc8DPfO1vLRdX3NM_.Y);
	}

	public static System.Drawing.Point GetMousePhysicalPosition()
	{
		WMgqc8DPfO1vLRdX3NM wmgqc8DPfO1vLRdX3NM_ = default(WMgqc8DPfO1vLRdX3NM);
		ey6LUN98AJy(ref wmgqc8DPfO1vLRdX3NM_);
		return new System.Drawing.Point(wmgqc8DPfO1vLRdX3NM_.X, wmgqc8DPfO1vLRdX3NM_.Y);
	}

	public static void TryEnableDragDrop(Window window)
	{
		GR3LUtRBgkP(563u, 1u);
		GR3LUtRBgkP(74u, 1u);
		GR3LUtRBgkP(73u, 1u);
		IntPtr handle = new WindowInteropHelper(window).Handle;
		FvhLUgk8Eny(handle, 74u, 1u, IntPtr.Zero);
		FvhLUgk8Eny(handle, 563u, 1u, IntPtr.Zero);
		FvhLUgk8Eny(handle, 73u, 1u, IntPtr.Zero);
	}

	[DllImport("user32.dll")]
	public static extern IntPtr WindowFromPoint(System.Drawing.Point p);

	[DllImport("user32.dll")]
	public static extern IntPtr WindowFromPhysicalPoint(System.Drawing.Point p);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

	[DllImport("kernel32.dll")]
	public static extern uint GetCurrentProcessId();

	public static IntPtr GetMousePositionWindow()
	{
		return WindowFromPoint(GetMousePosition());
	}

	public static bool IsOnWindows10OrLater()
	{
		return Environment.OSVersion.Version.Major >= 10;
	}

	public static bool IsOnWindows11()
	{
		if (Environment.OSVersion.Version.Major >= 10)
		{
			return Environment.OSVersion.Version.Build >= 22000;
		}
		return false;
	}

	public static bool IsSupportArcylic()
	{
		int build = Environment.OSVersion.Version.Build;
		return true;
	}

	public static void BringProcessMainWindowToFront(IntPtr mainWindowHandle)
	{
		if (mainWindowHandle == IntPtr.Zero)
		{
			return;
		}
		IntPtr intPtr = mainWindowHandle;
		mainWindowHandle = GetRootWindow(mainWindowHandle);
		if (mainWindowHandle == GetForegroundWindow())
		{
			return;
		}
		if (IsIconic(mainWindowHandle))
		{
			zKfLUY4bvwW.Info($"窗口 0x{mainWindowHandle:X} (0x{intPtr:X}) 为Iconic，SW_RESTORE 方式显示。");
			if (!jVkJZLFUn1weJx1iAW9W())
			{
				switch (0)
				{
				}
			}
			ShowWindow(mainWindowHandle, 9);
		}
		else if (!IsWindowVisible(mainWindowHandle))
		{
			zKfLUY4bvwW.Info($"窗口 0x{mainWindowHandle:X} (0x{intPtr:X}) 不可见，SW_SHOW 方式显示。");
			ShowWindow(mainWindowHandle, 5);
		}
		SetForegroundWindow(mainWindowHandle);
	}

	public static (IntPtr winHandle, IntPtr tabHandle) GetCurrentExplorerWindow(IntPtr? winHandle = null)
	{
		IntPtr intPtr = ((!winHandle.HasValue || !(winHandle.Value != IntPtr.Zero)) ? GetForegroundWindow() : winHandle.Value);
		if (!IsOnExplorer(intPtr))
		{
			throw new InvalidOperationException("不是资源管理器窗口");
		}
		IntPtr explorerActiveTabHWnd = GetExplorerActiveTabHWnd(intPtr);
		return (winHandle: intPtr, tabHandle: explorerActiveTabHWnd);
	}

	public static int SetCurrentExplorerWindowSelectedFiles(IList<string> pathList, IntPtr? winHandle = null)
	{
		_003C_003Ec__DisplayClass139_0 _003C_003Ec__DisplayClass139_ = new _003C_003Ec__DisplayClass139_0();
		_003C_003Ec__DisplayClass139_.b9322UK2VPm = winHandle;
		_003C_003Ec__DisplayClass139_.oR622iss84o = pathList;
		_003C_003Ec__DisplayClass139_.GaJ22lU4r0q = 0;
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass139_.xT022Fi1TOO);
		return _003C_003Ec__DisplayClass139_.GaJ22lU4r0q;
	}

	public static IList<string> GetSelectedFiles()
	{
		_003C_003Ec__DisplayClass140_0 _003C_003Ec__DisplayClass140_ = new _003C_003Ec__DisplayClass140_0();
		_003C_003Ec__DisplayClass140_.fe722fF66AD = null;
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass140_.Qew2230oEHR);
		return _003C_003Ec__DisplayClass140_.fe722fF66AD;
	}

	public static bool IsOnDesktop(IntPtr handle)
	{
		IntPtr shellWindow = GetShellWindow();
		if (!(handle == shellWindow) && !IsChild(shellWindow, handle))
		{
			string windowClass = GetWindowClass(GetRootWindow(handle));
			if (!string.Equals("SysListView32", windowClass, StringComparison.OrdinalIgnoreCase) && !string.Equals("WorkerW", windowClass, StringComparison.OrdinalIgnoreCase))
			{
				return string.Equals("TxMiniSkin", windowClass, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
		return true;
	}

	public static bool IsOnExplorer(IntPtr handle)
	{
		StringBuilder stringBuilder_ = new StringBuilder(1024);
		while (true)
		{
			if (handle != IntPtr.Zero)
			{
				if (N0nLUJDZn0Q(handle, stringBuilder_))
				{
					break;
				}
				handle = GetRealParent(handle);
				continue;
			}
			return false;
		}
		return true;
	}

	public static IntPtr GetRootWindow(IntPtr hWnd)
	{
		IntPtr ancestor = GetAncestor(hWnd, GetAncestorFlags.GetRoot);
		if (!(ancestor == IntPtr.Zero) && !(ancestor == GetDesktopWindow()))
		{
			return ancestor;
		}
		return hWnd;
	}

	private static bool N0nLUJDZn0Q(IntPtr intptr_1, StringBuilder stringBuilder_0)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return false;
		}
		if (LEtLU78tb6t(intptr_1, stringBuilder_0, stringBuilder_0.Capacity) != 0)
		{
			string value = stringBuilder_0.ToString();
			if ("CabinetWClass".Equals(value, StringComparison.OrdinalIgnoreCase) || "ExploreWClass".Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public static IntPtr GetRealParent(IntPtr hWnd)
	{
		IntPtr ancestor = GetAncestor(hWnd, GetAncestorFlags.GetParent);
		if (!(ancestor == IntPtr.Zero) && !(ancestor == GetDesktopWindow()))
		{
			return ancestor;
		}
		return IntPtr.Zero;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	public static string GetWindowText(IntPtr hWnd)
	{
		StringBuilder stringBuilder = new StringBuilder(GetWindowTextLength(hWnd) + 1);
		GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	[DllImport("user32.dll", ExactSpelling = true)]
	public static extern IntPtr GetAncestor(IntPtr hwnd, GetAncestorFlags flags);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr GetShellWindow();

	[DllImport("user32.dll")]
	public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

	public static bool IsSameOrChildWindow(IntPtr hWndA, IntPtr hWndSameOrChild)
	{
		if (!(hWndA == hWndSameOrChild))
		{
			return IsChild(hWndA, hWndSameOrChild);
		}
		return true;
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindow(IntPtr hWnd);

	public static IntPtr GetWindowHandleOrForegroundWindow(IntPtr? windowHandle)
	{
		if (windowHandle.HasValue && windowHandle != IntPtr.Zero)
		{
			return windowHandle.Value;
		}
		return GetForegroundWindow();
	}

	public static string GetCurrentFolder(IntPtr? windowHandle = null)
	{
		return y8LLUPFBZIb(GetWindowHandleOrForegroundWindow(windowHandle));
	}

	private static string XYyLU0J30I0(string string_0)
	{
		return string_0;
	}

	public static IntPtr GetExplorerActiveTabHWnd(IntPtr windowHandle)
	{
		return OpenWindowGetter.FindChildWindow(windowHandle, "ShellTabWindowClass", null);
	}

	public static void SetExplorerWindowPath(IntPtr handle, string path)
	{
		if (handle == IntPtr.Zero)
		{
			handle = GetForegroundWindow();
			int num = 0;
			if (!jVkJZLFUn1weJx1iAW9W())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (!IsOnExplorer(handle))
		{
			throw new InvalidDataException("请在资源管理器窗口上使用此动作。");
		}
		IntPtr explorerActiveTabHWnd = GetExplorerActiveTabHWnd(handle);
		if (explorerActiveTabHWnd == IntPtr.Zero)
		{
			throw new InvalidDataException("未找到资源管理器窗格（ShellTabWindowClass），请在资源管理器窗口中使用本动作。");
		}
		ShellWindows shellWindows = (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")));
		IEnumerator enumerator = shellWindows.GetEnumerator();
		try
		{
			while (true)
			{
				if (enumerator.MoveNext())
				{
					if (!(enumerator.Current is InternetExplorer internetExplorer))
					{
						continue;
					}
					if (!internetExplorer.FullName.ToLower().Contains("explorer.exe") || internetExplorer.HWND != (long)handle)
					{
						Marshal.ReleaseComObject(internetExplorer);
						continue;
					}
					if (!(bPkZl9MLR2X9Cd6jq5M.Gf9LUKVMwte(internetExplorer) == explorerActiveTabHWnd))
					{
						Marshal.ReleaseComObject(internetExplorer);
						continue;
					}
					object Flags = Type.Missing;
					object TargetFrameName = Type.Missing;
					object PostData = Type.Missing;
					object Headers = Type.Missing;
					internetExplorer.Navigate(path, ref Flags, ref TargetFrameName, ref PostData, ref Headers);
					break;
				}
				if (!jVkJZLFUn1weJx1iAW9W())
				{
					switch (0)
					{
					}
				}
				break;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		Marshal.ReleaseComObject(shellWindows);
	}

	private static string eFBLUCVuxmY(InternetExplorer internetExplorer_0)
	{
		string text = ((dynamic)internetExplorer_0.Document).Folder.Self.Path;
		if (!jVkJZLFUn1weJx1iAW9W())
		{
			switch (0)
			{
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			text = internetExplorer_0.LocationURL?.Replace("file:///", "").Replace("/", "\\");
		}
		if (!string.IsNullOrEmpty(text))
		{
			if (text.StartsWith("::", StringComparison.InvariantCulture))
			{
				text = XYyLU0J30I0(text);
				if (string.IsNullOrEmpty(text))
				{
					StringBuilder stringBuilder = new StringBuilder(256);
					if (GetWindowText((IntPtr)internetExplorer_0.HWND, stringBuilder, 256) > 0)
					{
						text = stringBuilder.ToString();
					}
				}
			}
			return text;
		}
		return "";
	}

	private static string y8LLUPFBZIb(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			intptr_1 = GetForegroundWindow();
		}
		if (IsOnDesktop(intptr_1))
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		IList<InternetExplorer> list = new List<InternetExplorer>();
		ShellWindows shellWindows = (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")));
		try
		{
			foreach (object item in shellWindows)
			{
				if (item is InternetExplorer internetExplorer)
				{
					try
					{
						if (!internetExplorer.FullName.ToLower().Contains("explorer.exe") || internetExplorer.HWND != (long)intptr_1)
						{
							Marshal.ReleaseComObject(internetExplorer);
							continue;
						}
					}
					catch (Exception ex)
					{
						zKfLUY4bvwW.Warn(ex.Message, ex);
						Marshal.ReleaseComObject(internetExplorer);
						continue;
					}
					list.Add(internetExplorer);
					continue;
				}
				Marshal.ReleaseComObject(item);
				if (!jVkJZLFUn1weJx1iAW9W())
				{
					switch (0)
					{
					}
				}
			}
			if (list.Count == 0)
			{
				throw new Exception($"句柄不是资源管理器窗口：{intptr_1}");
			}
			if (list.Count == 1)
			{
				return eFBLUCVuxmY(list[0]);
			}
			return eFBLUCVuxmY(FqM96DMau8cJ0N2bo3P.SR4LUMEPFYW(intptr_1, list) ?? throw new Exception("多标签页资源管理器，无法获得InternetExplorer对象。"));
		}
		catch (Exception ex2)
		{
			zKfLUY4bvwW.Warn(ex2.Message, ex2);
			throw;
		}
		finally
		{
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Marshal.ReleaseComObject(list[i]);
					list[i] = null;
				}
			}
			Marshal.ReleaseComObject(shellWindows);
			shellWindows = null;
		}
	}

	internal static string BDkLUEoGYlN()
	{
		return y8LLUPFBZIb(FindWindow("CabinetWClass", null));
	}

	public static IList<string> GetAllOpenedFolders()
	{
		IList<string> list = new List<string>();
		ShellWindows shellWindows = (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")));
		try
		{
			foreach (object item in shellWindows)
			{
				if (!(item is InternetExplorer internetExplorer))
				{
					Marshal.ReleaseComObject(item);
					continue;
				}
				if (!internetExplorer.FullName.ToLower().Contains("explorer.exe"))
				{
					Marshal.ReleaseComObject(internetExplorer);
					continue;
				}
				string text = eFBLUCVuxmY(internetExplorer);
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
				Marshal.ReleaseComObject(internetExplorer);
			}
			return list.Distinct().OrderBy(_003C_003Ec.YV322dUHNME ?? (_003C_003Ec.YV322dUHNME = _003C_003Ec.ocY22DI85XN.IJb225NhBUt)).ToList();
		}
		finally
		{
			Marshal.ReleaseComObject(shellWindows);
			shellWindows = null;
		}
	}

	private static string lUWLUyBl1QG(IShellFolderViewDual2 ishellFolderViewDual2_0, IntPtr intptr_1)
	{
		FolderItem folderItem = ishellFolderViewDual2_0.Folder.Items().Item(Type.Missing);
		string text = string.Empty;
		if (folderItem != null && !folderItem.Path.StartsWith("::", StringComparison.InvariantCulture))
		{
			text = folderItem.Path;
		}
		else
		{
			if (folderItem != null && folderItem.Path.StartsWith("::"))
			{
				text = XYyLU0J30I0(folderItem.Path);
			}
			if (string.IsNullOrEmpty(text))
			{
				if (jVkJZLFUn1weJx1iAW9W())
				{
					switch (0)
					{
					}
				}
				StringBuilder stringBuilder = new StringBuilder(1024);
				if (GetWindowText(intptr_1, stringBuilder, 1024) > 0)
				{
					text = stringBuilder.ToString();
				}
			}
		}
		return text;
	}

	public static string GetActiveWindowTitle()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GetWindowText(GetForegroundWindow(), stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return null;
	}

	public static string GetWindowTitle(IntPtr hwnd)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GetWindowText(hwnd, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	public static Process GetForegroundProcess()
	{
		GetWindowThreadProcessId(GetForegroundWindow(), out uint processId);
		return Process.GetProcessById((int)processId);
	}

	public static string GetForegroundProcessName()
	{
		GetWindowThreadProcessId(GetForegroundWindow(), out uint processId);
		return GetProcessName((int)processId);
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

	[DllImport("user32.dll", EntryPoint = "GetClientRect", SetLastError = true)]
	private static extern bool cpMLU8pmoIk(IntPtr intptr_1, out RECT rect_0);

	public static RECT GetWindowRect(IntPtr hWnd)
	{
		RECT lpRect = default(RECT);
		GetWindowRect(hWnd, out lpRect);
		return lpRect;
	}

	public static RECT GetClientRect(IntPtr hWnd)
	{
		RECT rect_ = default(RECT);
		cpMLU8pmoIk(hWnd, out rect_);
		return rect_;
	}

	[DllImport("user32.dll")]
	public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

	[DllImport("DwmApi.dll", EntryPoint = "DwmGetWindowAttribute")]
	private static extern int yajLUaYwHtP(IntPtr intptr_1, int int_0, out RECT rect_0, int int_1);

	public static RECT GetWindowRectangle(IntPtr handle)
	{
		RECT rect_ = default(RECT);
		if (Environment.OSVersion.Version.Major < 6)
		{
			GetWindowRect(handle, out rect_);
			return rect_;
		}
		int int_ = Marshal.SizeOf(typeof(Rect));
		yajLUaYwHtP(handle, 9, out rect_, int_);
		if (rect_.Left == rect_.Right)
		{
			GetWindowRect(handle, out rect_);
		}
		return rect_;
	}

	public static Thickness GetWindowInvisibleWidth(IntPtr handle)
	{
		RECT rect_ = default(RECT);
		int int_ = Marshal.SizeOf(typeof(Rect));
		yajLUaYwHtP(handle, 9, out rect_, int_);
		if (rect_.Left == rect_.Right)
		{
			return new Thickness(0.0);
		}
		RECT lpRect = default(RECT);
		GetWindowRect(handle, out lpRect);
		return new Thickness(lpRect.Left - rect_.Left, lpRect.Top - rect_.Top, lpRect.Right - rect_.Right, lpRect.Bottom - rect_.Bottom);
	}

	public static RECT GetForgroundWindowPosition()
	{
		return GetWindowRectangle(GetForegroundWindow());
	}

	[DllImport("user32.dll")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

	[DllImport("user32.dll")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowTextLength(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName", SetLastError = true)]
	private static extern int LEtLU78tb6t(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	public static string GetCaptionOfWindow(IntPtr hwnd)
	{
		string result = "";
		StringBuilder stringBuilder = null;
		try
		{
			int windowTextLength = GetWindowTextLength(hwnd);
			stringBuilder = new StringBuilder("", windowTextLength + 5);
			GetWindowText(hwnd, stringBuilder, windowTextLength + 2);
			if (!string.IsNullOrEmpty(stringBuilder.ToString()) && !string.IsNullOrWhiteSpace(stringBuilder.ToString()))
			{
				result = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			result = ex.Message;
		}
		finally
		{
			stringBuilder = null;
		}
		return result;
	}

	public static string GetWindowClass(IntPtr hwnd)
	{
		string result = "";
		StringBuilder stringBuilder = null;
		try
		{
			stringBuilder = new StringBuilder("", 1005);
			LEtLU78tb6t(hwnd, stringBuilder, 1002);
			if (!string.IsNullOrEmpty(stringBuilder.ToString()) && !string.IsNullOrWhiteSpace(stringBuilder.ToString()))
			{
				result = stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
			result = ex.Message;
		}
		finally
		{
			stringBuilder = null;
		}
		return result;
	}

	public static bool IsOnTaskbar(IntPtr handle)
	{
		if (!(handle == niALUIQp6qw))
		{
			niALUIQp6qw = handle;
			StringBuilder stringBuilder_ = new StringBuilder(1024);
			while (true)
			{
				if (handle != IntPtr.Zero)
				{
					if (EVALUR24wVk(handle, stringBuilder_))
					{
						break;
					}
					handle = GetRealParent(handle);
					continue;
				}
				B0uLUW0Cq7s = false;
				return false;
			}
			if (jVkJZLFUn1weJx1iAW9W())
			{
				switch (0)
				{
				}
			}
			B0uLUW0Cq7s = true;
			return true;
		}
		return B0uLUW0Cq7s;
	}

	private static bool EVALUR24wVk(IntPtr intptr_1, StringBuilder stringBuilder_0)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return false;
		}
		if (LEtLU78tb6t(intptr_1, stringBuilder_0, stringBuilder_0.Capacity) != 0)
		{
			string value = stringBuilder_0.ToString();
			if ("Shell_TrayWnd".Equals(value, StringComparison.OrdinalIgnoreCase) || "Shell_SecondaryTrayWnd".Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public static (bool onDesktop, bool onExplorer, bool onTaskbar) GetExplorerWindow(IntPtr handle)
	{
		bool flag = IsOnDesktop(handle);
		bool flag2 = false;
		bool flag3 = false;
		if (!flag)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			while (handle != IntPtr.Zero)
			{
				if (LEtLU78tb6t(handle, stringBuilder, stringBuilder.Capacity) != 0)
				{
					string value = stringBuilder.ToString();
					if (!flag2 && ("Shell_TrayWnd".Equals(value, StringComparison.OrdinalIgnoreCase) || "Shell_SecondaryTrayWnd".Equals(value, StringComparison.OrdinalIgnoreCase)))
					{
						flag3 = true;
					}
					if (!flag3 && ("CabinetWClass".Equals(value, StringComparison.OrdinalIgnoreCase) || "ExploreWClass".Equals(value, StringComparison.OrdinalIgnoreCase)))
					{
						flag2 = true;
					}
					if (flag3 || flag2)
					{
						break;
					}
				}
				handle = GetRealParent(handle);
			}
		}
		return (onDesktop: flag, onExplorer: flag2, onTaskbar: flag3);
	}

	[DllImport("Shell32.dll", SetLastError = true)]
	public static extern int SHOpenFolderAndSelectItems(IntPtr pidlFolder, uint cidl, [In][MarshalAs(UnmanagedType.LPArray)] IntPtr[] apidl, uint dwFlags);

	[DllImport("Shell32.dll", SetLastError = true)]
	public static extern uint SHParseDisplayName([MarshalAs(UnmanagedType.LPWStr)] string name, IntPtr bindingContext, out IntPtr pidl, uint sfgaoIn, out uint psfgaoOut);

	public static void OpenFolderAndSelectItem(string folderPath, string file)
	{
		SHParseDisplayName(folderPath, IntPtr.Zero, out var pidl, 0u, out var psfgaoOut);
		if (pidl == IntPtr.Zero)
		{
			return;
		}
		SHParseDisplayName(Path.IsPathRooted(file) ? file : Path.Combine(folderPath, file), IntPtr.Zero, out var pidl2, 0u, out psfgaoOut);
		IntPtr[] array = ((!(pidl2 == IntPtr.Zero)) ? new IntPtr[1] { pidl2 } : Array.Empty<IntPtr>());
		SHOpenFolderAndSelectItems(pidl, (uint)array.Length, array, 0u);
		Marshal.FreeCoTaskMem(pidl);
		int num = 0;
		if (NSnmDuFUA6MK6QGeH6to != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (pidl2 != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(pidl2);
		}
	}

	public static void OpenFolderAndSelectItems(string folderPath, IList<string> files)
	{
		SHParseDisplayName(folderPath, IntPtr.Zero, out var pidl, 0u, out var psfgaoOut);
		if (pidl == IntPtr.Zero)
		{
			return;
		}
		IList<IntPtr> list = new List<IntPtr>();
		foreach (string file in files)
		{
			SHParseDisplayName(Path.IsPathRooted(file) ? file : Path.Combine(folderPath, file), IntPtr.Zero, out var pidl2, 0u, out psfgaoOut);
			if (!(pidl2 == IntPtr.Zero))
			{
				list.Add(pidl2);
			}
		}
		IntPtr[] array = list.ToArray();
		SHOpenFolderAndSelectItems(pidl, (uint)array.Length, array, 0u);
		Marshal.FreeCoTaskMem(pidl);
		foreach (IntPtr item in list)
		{
			Marshal.FreeCoTaskMem(item);
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

	[DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "GetModuleFileNameEx")]
	private static extern uint srYLUqoEFA8(IntPtr intptr_1, IntPtr intptr_2, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("psapi.dll", EntryPoint = "GetModuleBaseName")]
	private static extern uint KKGLUcCj8BA(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	public static extern uint GetLastError();

	public static string GetProcessName(int pid)
	{
		try
		{
			return string.Intern(Path.GetFileNameWithoutExtension(tZZhZGM4HaKvySF2OqY.u1MLOxTPiyo((uint)pid)));
		}
		catch (Exception)
		{
			return "";
		}
	}

	public static string GetProcessFilePath(uint pid)
	{
		if (pid == 0)
		{
			return string.Empty;
		}
		IntPtr intPtr = ManagedShell.Interop.NativeMethods.OpenProcess(ManagedShell.Interop.NativeMethods.ProcessAccessFlags.QueryLimitedInformation, false, (int)pid);
		if (intPtr == IntPtr.Zero)
		{
			zKfLUY4bvwW.Warn($"OpenProcess失败, pid={pid}：{GetLastError()}");
			return "unknown-proc.exe";
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			int lpdwSize = stringBuilder.Capacity;
			if (ManagedShell.Interop.NativeMethods.QueryFullProcessImageName(intPtr, 0, stringBuilder, ref lpdwSize))
			{
				return string.Intern(stringBuilder.ToString());
			}
			zKfLUY4bvwW.Warn($"QueryFullProcessImageName失败, pid={pid}：{GetLastError()}");
			return "unknown-proc.exe";
		}
		finally
		{
			CloseHandle(intPtr);
		}
	}

	public static string GetHoveringExe(bool fullPath)
	{
		IntPtr intPtr = WindowFromPoint(GetMousePosition());
		GetWindowThreadProcessId(intPtr, out uint processId);
		if (fullPath)
		{
			return GetProcessFilePath(processId);
		}
		return AppHelper.FixExeName(tZZhZGM4HaKvySF2OqY.u1MLOxTPiyo(processId), intPtr);
	}

	public static bool IsForegroundFullScreen()
	{
		return IsForegroundFullScreen(null, GetForegroundWindow());
	}

	public static bool IsForegroundFullScreen(IntPtr hWnd)
	{
		return IsForegroundFullScreen(null, hWnd);
	}

	public static bool IsForegroundFullScreen(System.Windows.Forms.Screen screen, IntPtr hWnd)
	{
		bool flag = WEh2cFflZcNKgNsYJEP.xqJLUFgYj50().i5oLlgPSJ91 && WEh2cFflZcNKgNsYJEP.xqJLUFgYj50().oOsLUlPAPPd() == hWnd;
		if (System.Windows.Forms.Screen.AllScreens.Length == 1)
		{
			return flag;
		}
		if (flag)
		{
			return true;
		}
		if (screen == null)
		{
			int num = 0;
			if (!jVkJZLFUn1weJx1iAW9W())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			screen = System.Windows.Forms.Screen.FromHandle(hWnd);
		}
		RECT lpRect = default(RECT);
		GetWindowRect(hWnd, out lpRect);
		return new System.Drawing.Rectangle(lpRect.Left, lpRect.Top, lpRect.Right - lpRect.Left, lpRect.Bottom - lpRect.Top).Contains(screen.Bounds);
	}

	[DllImport("kernel32.dll")]
	public static extern bool SetProcessWorkingSetSize(IntPtr proc, UIntPtr min, UIntPtr max);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	private static extern uint wjKLUV8rJgx(IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", EntryPoint = "SetHandleInformation", SetLastError = true)]
	private static extern bool rnwLUZbUdD5(IntPtr intptr_1, uint uint_0, uint uint_1);

	public static void MakeNotInheritable(Socket socket)
	{
		rnwLUZbUdD5(socket.Handle, 1u, 0u);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, StringBuilder lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	public static void PostMessageSafe(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
	{
		if (!PostMessage(hWnd, msg, wParam, lParam))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	[DllImport("user32.dll")]
	public static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AddClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", EntryPoint = "GetCursorInfo", SetLastError = true)]
	private static extern bool pBcLU9Rvj87(ref RnF3nvDyqaYEwCwdsoo rnF3nvDyqaYEwCwdsoo_0);

	public static bool IsSelectingTextCursor()
	{
		try
		{
			IntPtr handle = Cursors.IBeam.Handle;
			RnF3nvDyqaYEwCwdsoo rnF3nvDyqaYEwCwdsoo_ = new RnF3nvDyqaYEwCwdsoo
			{
				wkR22Qctr7u = Marshal.SizeOf(typeof(RnF3nvDyqaYEwCwdsoo))
			};
			if (!pBcLU9Rvj87(ref rnF3nvDyqaYEwCwdsoo_))
			{
				GetLastError();
			}
			return rnF3nvDyqaYEwCwdsoo_.O7C22jFMUlk == 1 && rnF3nvDyqaYEwCwdsoo_.mLu22njjHQY == handle;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static IntPtr GetCursorHandle()
	{
		try
		{
			RnF3nvDyqaYEwCwdsoo rnF3nvDyqaYEwCwdsoo_ = new RnF3nvDyqaYEwCwdsoo
			{
				wkR22Qctr7u = Marshal.SizeOf(typeof(RnF3nvDyqaYEwCwdsoo))
			};
			if (!pBcLU9Rvj87(ref rnF3nvDyqaYEwCwdsoo_))
			{
				GetLastError();
				return IntPtr.Zero;
			}
			return rnF3nvDyqaYEwCwdsoo_.mLu22njjHQY;
		}
		catch (Exception)
		{
			return IntPtr.Zero;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowType uCmd);

	public static string GetWindowProcessName(IntPtr hWnd)
	{
		int windowProcessId = GetWindowProcessId(hWnd);
		if (windowProcessId == 0)
		{
			return null;
		}
		return GetProcessName(windowProcessId);
	}

	[DllImport("Shell32.dll")]
	public static extern int SHQueryUserNotificationState(out QUERY_USER_NOTIFICATION_STATE pquns);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
	private static extern bool YppLUhjaqNN(uint uint_0, ref GUITHREADINFO guithreadinfo_0);

	public static GUITHREADINFO? GetGuiThreadInfo(IntPtr hwnd)
	{
		GUITHREADINFO guithreadinfo_ = default(GUITHREADINFO);
		uint uint_ = ((!(hwnd == IntPtr.Zero)) ? wjKLUV8rJgx(hwnd, IntPtr.Zero) : 0);
		guithreadinfo_.cbSize = Marshal.SizeOf(guithreadinfo_);
		if (!YppLUhjaqNN(uint_, ref guithreadinfo_))
		{
			return null;
		}
		return guithreadinfo_;
	}

	public static GUITHREADINFO GetForegroundGUITHREADINFO()
	{
		GUITHREADINFO guithreadinfo_ = default(GUITHREADINFO);
		guithreadinfo_.cbSize = Marshal.SizeOf(guithreadinfo_);
		YppLUhjaqNN(0u, ref guithreadinfo_);
		return guithreadinfo_;
	}

	public static bool SendTextUsingSendMessage(string text)
	{
		IntPtr foregroundWindow = GetForegroundWindow();
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		GUITHREADINFO? guiThreadInfo = GetGuiThreadInfo(foregroundWindow);
		if (guiThreadInfo.HasValue)
		{
			IntPtr hwndCaret = guiThreadInfo.Value.hwndCaret;
			if (hwndCaret != IntPtr.Zero)
			{
				int i = 0;
				int num = 0;
				if (!jVkJZLFUn1weJx1iAW9W())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				for (; i < text.Length; i++)
				{
					SendMessage(hwndCaret, 258, (IntPtr)text[i], IntPtr.Zero);
				}
				return true;
			}
		}
		return true;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern uint RegisterWindowMessage(string lpString);

	static NativeMethods()
	{
		zKfLUY4bvwW = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		niALUIQp6qw = IntPtr.Zero;
		B0uLUW0Cq7s = false;
		HWND_TOPMOST = new IntPtr(-1);
		HWND_NOTOPMOST = new IntPtr(-2);
		HWND_TOP = new IntPtr(0);
		HWND_BOTTOM = new IntPtr(1);
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	[CompilerGenerated]
	internal static extern bool JBqLUeONmu2(IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1, int int_2, int int_3, uint uint_0);

	internal static bool jVkJZLFUn1weJx1iAW9W()
	{
		return NSnmDuFUA6MK6QGeH6to == null;
	}
}
