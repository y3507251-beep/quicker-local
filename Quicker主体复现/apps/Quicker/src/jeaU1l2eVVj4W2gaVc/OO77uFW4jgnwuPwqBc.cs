using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using hWHwsGXCuDLJDTTA5c;

namespace jeaU1l2eVVj4W2gaVc;

internal class OO77uFW4jgnwuPwqBc
{
	internal delegate bool hI5iv1m6D8AOY0y89AB(IntPtr hWnd, IntPtr lParam);

	internal enum JotpnXm78XZw93Uu92b
	{

	}

	[Flags]
	internal enum KKNJG3miHEvgcgNgnT4 : uint
	{

	}

	[Flags]
	internal enum JB4ecNmmQXiiui3lBgP : uint
	{

	}

	internal enum z3M151mdRe2Fa0CZ5hr
	{

	}

	internal struct Mxof7rmuiCarILJwHHd
	{
		public IaO2hrmHFyKYyawhEpV uI3vCTVJWC4;

		public IaO2hrmHFyKYyawhEpV KPIvCMxv42E;

		public IaO2hrmHFyKYyawhEpV rltvCATN2Uq;

		public IaO2hrmHFyKYyawhEpV ARCvCOX2ksP;

		public IaO2hrmHFyKYyawhEpV XnfvCF5O4Zv;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct ngTuxbmDsTD4eNDuh33
	{
		public int dOAvCUPtQat;

		public SX5yqVmkWqZQKeT9UhS t4ovClxJKWQ;

		public SX5yqVmkWqZQKeT9UhS EOgvCiNsR30;

		public int r0uvC3tFRuU;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dwvvCffjLQ1;

		internal static object MvfRX6c21GdnDJhqHZh6;

		public static ngTuxbmDsTD4eNDuh33 New()
		{
			return new ngTuxbmDsTD4eNDuh33
			{
				dOAvCUPtQat = Marshal.SizeOf(typeof(ngTuxbmDsTD4eNDuh33)),
				dwvvCffjLQ1 = string.Empty
			};
		}

		internal static bool e1LJMAc2KDTFZLuDHWHS()
		{
			return MvfRX6c21GdnDJhqHZh6 == null;
		}
	}

	internal struct IaO2hrmHFyKYyawhEpV
	{
		public int x;

		public int dvlvCzBLYdL;

		private static object WHp5bAc2vkadqwuwQRBp;

		public IaO2hrmHFyKYyawhEpV(int int_1, int int_2)
		{
			x = int_1;
			dvlvCzBLYdL = int_2;
		}

		public override string ToString()
		{
			return $"({x},{dvlvCzBLYdL})";
		}

		internal static void ikKGykc2J0MwkbrdeNZF()
		{
		}

		internal static bool tYygFlc2dfsyGfDnjdfy()
		{
			return WHp5bAc2vkadqwuwQRBp == null;
		}
	}

	internal struct SX5yqVmkWqZQKeT9UhS
	{
		internal int XD7vPLOJ5hE;

		internal int wTivPvfjMFS;

		internal int DhUvPSLdZXQ;

		internal int dPwvP2kZV1u;

		public static readonly SX5yqVmkWqZQKeT9UhS Empty;

		private static object vExOiDc2kjUjxZKg4LBa;

		internal int width => DhUvPSLdZXQ - XD7vPLOJ5hE;

		internal int height => dPwvP2kZV1u - wTivPvfjMFS;

		public bool IsEmpty
		{
			get
			{
				if (XD7vPLOJ5hE >= DhUvPSLdZXQ)
				{
					return true;
				}
				return wTivPvfjMFS >= dPwvP2kZV1u;
			}
		}

		public SX5yqVmkWqZQKeT9UhS(int int_4, int int_5, int int_6, int int_7)
		{
			XD7vPLOJ5hE = int_4;
			wTivPvfjMFS = int_5;
			DhUvPSLdZXQ = int_6;
			dPwvP2kZV1u = int_7;
		}

		public SX5yqVmkWqZQKeT9UhS(SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0)
		{
			XD7vPLOJ5hE = sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE;
			wTivPvfjMFS = sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS;
			DhUvPSLdZXQ = sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ;
			dPwvP2kZV1u = sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u;
		}

		public override string ToString()
		{
			if (this == Empty)
			{
				return "RECT {Empty}";
			}
			return "RECT { left : " + XD7vPLOJ5hE + " / top : " + wTivPvfjMFS + " / right : " + DhUvPSLdZXQ + " / bottom : " + dPwvP2kZV1u + " }";
		}

		public override bool Equals(object o)
		{
			if (!(o is Rect))
			{
				return false;
			}
			return this == (SX5yqVmkWqZQKeT9UhS)o;
		}

		public override int GetHashCode()
		{
			return XD7vPLOJ5hE.GetHashCode() + wTivPvfjMFS.GetHashCode() + DhUvPSLdZXQ.GetHashCode() + dPwvP2kZV1u.GetHashCode();
		}

		public static bool operator ==(SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0, SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_1)
		{
			if (sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE == sx5yqVmkWqZQKeT9UhS_1.XD7vPLOJ5hE && sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS == sx5yqVmkWqZQKeT9UhS_1.wTivPvfjMFS && sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ == sx5yqVmkWqZQKeT9UhS_1.DhUvPSLdZXQ)
			{
				return sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u == sx5yqVmkWqZQKeT9UhS_1.dPwvP2kZV1u;
			}
			return false;
		}

		public static bool operator !=(SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0, SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_1)
		{
			return !(sx5yqVmkWqZQKeT9UhS_0 == sx5yqVmkWqZQKeT9UhS_1);
		}

		internal static bool R0Gatvc2ayqIEIeMcBay()
		{
			return vExOiDc2kjUjxZKg4LBa == null;
		}
	}

	internal struct T3dZJumhW7xBWeT4alb
	{
		internal int Rx6vPNoMlTK;

		internal int FVrvPJBc2Cf;

		internal z3M151mdRe2Fa0CZ5hr EfmvP0TsvWl;

		internal IaO2hrmHFyKYyawhEpV nYsvPCIe2Fx;

		internal IaO2hrmHFyKYyawhEpV m5CvPPRUWak;

		internal SX5yqVmkWqZQKeT9UhS tEovPEWWyDg;

		internal static object NEFjQQc29hCXvGyFfeE3;

		internal static T3dZJumhW7xBWeT4alb Empty
		{
			get
			{
				T3dZJumhW7xBWeT4alb t3dZJumhW7xBWeT4alb = default(T3dZJumhW7xBWeT4alb);
				t3dZJumhW7xBWeT4alb.Rx6vPNoMlTK = Marshal.SizeOf(t3dZJumhW7xBWeT4alb);
				return t3dZJumhW7xBWeT4alb;
			}
		}

		internal static bool vcZZRrc2L4aY86uQ28sv()
		{
			return NEFjQQc29hCXvGyFfeE3 == null;
		}
	}

	internal enum hrLclZm80ALM03cIHdA : uint
	{

	}

	[Flags]
	internal enum Xl0HeQmbWu6UJ4wXRtM : uint
	{

	}

	internal enum d6mS1Eme1247E1wQHEo
	{

	}

	internal enum vPuLP8m1otUPFTtElNF
	{

	}

	internal enum uxVkjpmcWhSl7FM0k1j
	{

	}

	internal enum LV7ANHm9kbysOqWbfyo
	{

	}

	internal enum TYKBdEmPwqswtkkPODJ
	{

	}

	[Flags]
	public enum I5V1f3mybZ5R3kcX8Ko : uint
	{

	}

	internal enum nBXP9Km4R6ixJGbkpSe
	{

	}

	internal struct q5e3eEmUhgORbHuEg7c
	{
		internal uint qlEvPytUtII;

		internal uint N6lvP8EGQ9R;
	}

	internal enum l1CVdnmgKVFwCrLHRwQ
	{

	}

	internal enum RMVQc5mVJPHjmjvGhwN
	{

	}

	internal struct KkUs8lmFfBi5OUKvEsA
	{
		internal uint ck3vPaY1rJg;
	}

	public enum OHrPKkmvyWlWe2UcC9T : uint
	{

	}

	public delegate bool rceMNJmNb76kgqAoLZs(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);

	internal enum VwO2SImnIcWlOH452y4
	{

	}

	internal struct LHTGLAmOuSP6bCXu92y
	{
		public bool zYhvP743KWR;

		public int JCbvPRJhHJm;

		public int UGavPqgLf9f;

		public IntPtr NnxvPcoNSHY;

		public IntPtr p3CvPVEE67j;
	}

	internal enum crviX3msnHrLYPuN3wx
	{

	}

	internal enum NoBp5Em3ZvASVH36FW9 : uint
	{

	}

	internal static uint hdbgLrBqH5;

	internal static uint adGgvRFQoZ;

	internal static uint RZ6gSlyTTK;

	internal static OO77uFW4jgnwuPwqBc PXW4wMWIh7bG0deI7YV;

	[DllImport("user32.dll", EntryPoint = "EnumWindows")]
	internal static extern bool HTKt0aXUCH(hI5iv1m6D8AOY0y89AB hI5iv1m6D8AOY0y89AB_0, IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool YIQtC6E1LT(IntPtr intptr_0, hI5iv1m6D8AOY0y89AB hI5iv1m6D8AOY0y89AB_0, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "GetDC")]
	internal static extern IntPtr CuMtPghyV8(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetClientRect")]
	internal static extern bool dhktEuIdPr(IntPtr intptr_0, out SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0);

	[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "GetMonitorInfo", SetLastError = true)]
	internal static extern bool DHKtyYxbLo(IntPtr intptr_0, ref ngTuxbmDsTD4eNDuh33 ngTuxbmDsTD4eNDuh33_0);

	[DllImport("user32", EntryPoint = "MonitorFromWindow")]
	internal static extern IntPtr Ajct8eA8UC(IntPtr intptr_0, int int_0);

	[DllImport("user32", EntryPoint = "MonitorFromPoint")]
	internal static extern IntPtr mNWta3fx6m(IaO2hrmHFyKYyawhEpV iaO2hrmHFyKYyawhEpV_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	internal static extern int cIvt7If2Tl(int int_0);

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	internal static extern bool NYMtR1k04U(IntPtr intptr_0, out SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0);

	[DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
	internal static extern bool PiZtqwy1Fc(IntPtr intptr_0, out T3dZJumhW7xBWeT4alb t3dZJumhW7xBWeT4alb_0);

	[DllImport("user32.dll", EntryPoint = "GetAncestor", ExactSpelling = true)]
	internal static extern IntPtr GHntcetS3m(IntPtr intptr_0, vPuLP8m1otUPFTtElNF vPuLP8m1otUPFTtElNF_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongW", SetLastError = true)]
	private static extern int BjatVUn0Jf(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongPtrW", SetLastError = true)]
	private static extern IntPtr mWVtZHan4R(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegisterHotKey", SetLastError = true)]
	internal static extern bool JYSt9cNHqD(IntPtr intptr_0, int int_0, int int_1, int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "UnregisterHotKey", SetLastError = true)]
	internal static extern bool HRsth3ERWB(IntPtr intptr_0, int int_0);

	public static IntPtr fcyteUxmW7(IntPtr intptr_0, uxVkjpmcWhSl7FM0k1j uxVkjpmcWhSl7FM0k1j_0)
	{
		if (kIytAg6sUl())
		{
			return (IntPtr)BjatVUn0Jf(intptr_0, (int)uxVkjpmcWhSl7FM0k1j_0);
		}
		return mWVtZHan4R(intptr_0, (int)uxVkjpmcWhSl7FM0k1j_0);
	}

	[DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
	internal static extern bool zqitYFTh8i(ref q5e3eEmUhgORbHuEg7c q5e3eEmUhgORbHuEg7c_0);

	[DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool bbntIljsU5([In] IntPtr intptr_0);

	[DllImport("shcore", EntryPoint = "GetDpiForMonitor")]
	internal static extern int obdtWHKGtx(IntPtr intptr_0, l1CVdnmgKVFwCrLHRwQ l1CVdnmgKVFwCrLHRwQ_0, ref uint uint_3, ref uint uint_4);

	[DllImport("shcore", EntryPoint = "SetProcessDpiAwareness")]
	internal static extern int u2Stky8M9A(int int_0);

	[DllImport("shcore", EntryPoint = "GetProcessDpiAwareness")]
	internal static extern int QZmtGOXtkF(IntPtr intptr_0, ref int int_0);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
	internal static extern uint MNZtsePrfv();

	[DllImport("kernel32.dll", EntryPoint = "GetTickCount64")]
	internal static extern ulong KtAtHaVmNe();

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
	internal static extern bool aP4t18eMbV(IntPtr intptr_0);

	[DllImport("advapi32.dll", EntryPoint = "GetTokenInformation", SetLastError = true)]
	internal static extern bool cTUtbJUilr(IntPtr intptr_0, RMVQc5mVJPHjmjvGhwN rmvqc5mVJPHjmjvGhwN_0, IntPtr intptr_1, uint uint_3, out uint uint_4);

	[DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", SetLastError = true)]
	internal static extern bool EOrt6UnZGB(IntPtr intptr_0, uint uint_3, out IntPtr intptr_1);

	internal static void xvxtXrfIS4()
	{
		Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
	}

	[DllImport("user32.dll", EntryPoint = "MonitorFromPoint", SetLastError = true)]
	public static extern IntPtr iQmtmpU4fF(System.Drawing.Point point_0, OHrPKkmvyWlWe2UcC9T ohrPKkmvyWlWe2UcC9T_0);

	[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
	public static extern bool IEWtKqYIjk(IntPtr intptr_0, IntPtr intptr_1, rceMNJmNb76kgqAoLZs rceMNJmNb76kgqAoLZs_0, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "GetWindowLong", SetLastError = true)]
	public static extern uint uDbtxeaINX(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
	internal static extern IntPtr X0xtrxYBGM();

	[DllImport("user32.dll", EntryPoint = "GetShellWindow")]
	internal static extern IntPtr vfmtpHd1gM();

	[DllImport("user32.dll", EntryPoint = "GetWindowDC")]
	internal static extern IntPtr OF6tByAHkP(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool WJDtQQLbdw(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetWindow")]
	internal static extern IntPtr cEgtj7g8PZ(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	internal static extern uint zwWtn6n1Bo(IntPtr intptr_0, out uint uint_3);

	[DllImport("user32", EntryPoint = "SetWindowPos")]
	internal static extern bool J9rt4eiyvV(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, uint uint_3);

	[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
	internal static extern bool TZXt5jYrmP(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("authorex.dll", EntryPoint = "CreateDeviceDiscoveryClass")]
	internal static extern int v9ltD9GFfH(out CjERW1jqh77wF3n973.dS9aclmKYNl7S2QFYU4 dS9aclmKYNl7S2QFYU4_0, CjERW1jqh77wF3n973.rZOPCLmJ5ypgru39oOC rZOPCLmJ5ypgru39oOC_0);

	[DllImport("authorex.dll", EntryPoint = "CreateCaptureControlClass")]
	internal static extern int ITWtdSt6YT(out CjERW1jqh77wF3n973.hbnZZJmRrLv3CWjT4Uw hbnZZJmRrLv3CWjT4Uw_0, CjERW1jqh77wF3n973.tTwYaAmQrQ6nBPAGm3E tTwYaAmQrQ6nBPAGm3E_0);

	[DllImport("authorex.dll", EntryPoint = "CreateMP4MediaTransferClass")]
	internal static extern int GVrto5n4YZ(out CjERW1jqh77wF3n973.Et8IhUmxR0tYAqtyZ6Q et8IhUmxR0tYAqtyZ6Q_0);

	[DllImport("authorex.dll", EntryPoint = "VerifyEmbeddedSignature")]
	internal static extern int b9DtTAgNUE([MarshalAs(UnmanagedType.BStr)] string string_0, bool bool_0);

	[DllImport("authorex.dll", EntryPoint = "CheckD3D")]
	internal static extern int h9RtMkaF3W(uint uint_3);

	internal static bool kIytAg6sUl()
	{
		return IntPtr.Size == 4;
	}

	[DllImport("gdi32.dll", EntryPoint = "GetClipBox")]
	internal static extern int YghtOJ4cZA(IntPtr intptr_0, out SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0);

	[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
	public static extern IntPtr ilZtF8oyNl(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
	public static extern IntPtr FL6tUdDkIc(IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
	public static extern IntPtr vVotlUQdYn(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("gdi32", EntryPoint = "DeleteObject")]
	internal static extern bool xAXtipNCOY(IntPtr intptr_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateDC")]
	internal static extern IntPtr v6ct34MHW3(string string_0, string string_1, string string_2, IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
	internal static extern bool MNjtf6Dtq0(IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
	internal static extern int OX3tzoM4et(IntPtr intptr_0, int int_0);

	[DllImport("gdi32.dll", EntryPoint = "BitBlt")]
	internal static extern bool smjgwPNFom(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, NoBp5Em3ZvASVH36FW9 noBp5Em3ZvASVH36FW9_0);

	public static IntPtr uIKgtYo8ob(Window window_0)
	{
		return new WindowInteropHelper(window_0).Handle;
	}

	public static IntPtr N7ggg78LZg(IntPtr intptr_0)
	{
		return Ajct8eA8UC(intptr_0, 2);
	}

	static OO77uFW4jgnwuPwqBc()
	{
		hdbgLrBqH5 = 131072u;
		adGgvRFQoZ = 8u;
		RZ6gSlyTTK = hdbgLrBqH5 | adGgvRFQoZ;
	}

	internal static bool FWgORxW6W3fnMywjIHb()
	{
		return PXW4wMWIh7bG0deI7YV == null;
	}
}
