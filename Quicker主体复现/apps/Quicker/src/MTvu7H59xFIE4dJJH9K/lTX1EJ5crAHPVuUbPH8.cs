using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using DjWQgG5ya1aB80U0mvl;

namespace MTvu7H59xFIE4dJJH9K;

internal class lTX1EJ5crAHPVuUbPH8
{
	internal delegate bool Iq9QGHd06vZ3mhJNS1i(IntPtr hWnd, IntPtr lParam);

	internal enum aI73NmdTiONtEagOll4
	{

	}

	[Flags]
	internal enum e8dVf2dSTgRLMMxGC8V : uint
	{

	}

	[Flags]
	internal enum I3drg2dKJLA0xkdJQou : uint
	{

	}

	internal enum p8m2AJdJvoARGSJY72N
	{

	}

	internal struct JITXTMdRMZAgijBuvFy
	{
		public FBfTEwdB0MRQ5PpeoRS PB0vqcElBUb;

		public FBfTEwdB0MRQ5PpeoRS weRvqV07ifi;

		public FBfTEwdB0MRQ5PpeoRS j6TvqZiJLGE;

		public FBfTEwdB0MRQ5PpeoRS yAwvq9FoHTb;

		public FBfTEwdB0MRQ5PpeoRS gNyvqhp0V2v;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct In7U8EdZ2NUvehTOPat
	{
		public int JlmvqerPdeT;

		public UqwBGEdQOmobi3k3BTZ ijOvqYS7ENq;

		public UqwBGEdQOmobi3k3BTZ WJOvqIPnWCD;

		public int zeAvqWIa7bn;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string UtVvqkSyYoh;

		internal static object eq9fjOckBNrAl4M4ZPUT;

		public static In7U8EdZ2NUvehTOPat New()
		{
			return new In7U8EdZ2NUvehTOPat
			{
				JlmvqerPdeT = Marshal.SizeOf(typeof(In7U8EdZ2NUvehTOPat)),
				UtVvqkSyYoh = string.Empty
			};
		}

		internal static bool PhDt4yckv7foIYhcB3k6()
		{
			return eq9fjOckBNrAl4M4ZPUT == null;
		}
	}

	internal struct FBfTEwdB0MRQ5PpeoRS
	{
		public int x;

		public int dscvqGJBIpg;

		private static object GijwvbckOQX0gjnBcY7j;

		public FBfTEwdB0MRQ5PpeoRS(int int_1, int int_2)
		{
			x = int_1;
			dscvqGJBIpg = int_2;
		}

		public override string ToString()
		{
			return $"({x},{dscvqGJBIpg})";
		}

		internal static bool Vj45FMckJYMXnIjDGKjt()
		{
			return GijwvbckOQX0gjnBcY7j == null;
		}
	}

	public struct UqwBGEdQOmobi3k3BTZ
	{
		internal int crGvqbYWVF6;

		internal int mP6vq6MOjic;

		internal int tRZvqXJG8BS;

		internal int t1ivqmCnUM7;

		public static readonly UqwBGEdQOmobi3k3BTZ Empty;

		private static object MWWcr8ckaZJpXMfg6reJ;

		internal int width => tRZvqXJG8BS - crGvqbYWVF6;

		internal int height => t1ivqmCnUM7 - mP6vq6MOjic;

		public bool IsEmpty
		{
			get
			{
				if (crGvqbYWVF6 < tRZvqXJG8BS)
				{
					return mP6vq6MOjic >= t1ivqmCnUM7;
				}
				return true;
			}
		}

		public UqwBGEdQOmobi3k3BTZ(int int_4, int int_5, int int_6, int int_7)
		{
			crGvqbYWVF6 = int_4;
			mP6vq6MOjic = int_5;
			tRZvqXJG8BS = int_6;
			t1ivqmCnUM7 = int_7;
		}

		public UqwBGEdQOmobi3k3BTZ(UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0)
		{
			crGvqbYWVF6 = uqwBGEdQOmobi3k3BTZ_0.crGvqbYWVF6;
			mP6vq6MOjic = uqwBGEdQOmobi3k3BTZ_0.mP6vq6MOjic;
			tRZvqXJG8BS = uqwBGEdQOmobi3k3BTZ_0.tRZvqXJG8BS;
			t1ivqmCnUM7 = uqwBGEdQOmobi3k3BTZ_0.t1ivqmCnUM7;
		}

		public override string ToString()
		{
			if (this == Empty)
			{
				return "RECT {Empty}";
			}
			return "RECT { left : " + crGvqbYWVF6 + " / top : " + mP6vq6MOjic + " / right : " + tRZvqXJG8BS + " / bottom : " + t1ivqmCnUM7 + " }";
		}

		public override bool Equals(object o)
		{
			if (!(o is UqwBGEdQOmobi3k3BTZ))
			{
				return false;
			}
			return this == (UqwBGEdQOmobi3k3BTZ)o;
		}

		public override int GetHashCode()
		{
			return crGvqbYWVF6.GetHashCode() + mP6vq6MOjic.GetHashCode() + tRZvqXJG8BS.GetHashCode() + t1ivqmCnUM7.GetHashCode();
		}

		public static bool operator ==(UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0, UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_1)
		{
			if (uqwBGEdQOmobi3k3BTZ_0.crGvqbYWVF6 == uqwBGEdQOmobi3k3BTZ_1.crGvqbYWVF6 && uqwBGEdQOmobi3k3BTZ_0.mP6vq6MOjic == uqwBGEdQOmobi3k3BTZ_1.mP6vq6MOjic && uqwBGEdQOmobi3k3BTZ_0.tRZvqXJG8BS == uqwBGEdQOmobi3k3BTZ_1.tRZvqXJG8BS)
			{
				return uqwBGEdQOmobi3k3BTZ_0.t1ivqmCnUM7 == uqwBGEdQOmobi3k3BTZ_1.t1ivqmCnUM7;
			}
			return false;
		}

		public static bool operator !=(UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0, UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_1)
		{
			return !(uqwBGEdQOmobi3k3BTZ_0 == uqwBGEdQOmobi3k3BTZ_1);
		}

		internal static bool Gmvby3ckrFqfGVMRwxsE()
		{
			return MWWcr8ckaZJpXMfg6reJ == null;
		}
	}

	internal struct UMSyFJdtgURDjevto04
	{
		internal int V8rvqxoidAa;

		internal int jJPvqroFF47;

		internal p8m2AJdJvoARGSJY72N noYvqp04gGK;

		internal FBfTEwdB0MRQ5PpeoRS RofvqBdovPm;

		internal FBfTEwdB0MRQ5PpeoRS ajPvqQdePBl;

		internal UqwBGEdQOmobi3k3BTZ OjNvqjwlTe6;

		internal static object wxqlstck9P7xYQkZ8kvM;

		internal static UMSyFJdtgURDjevto04 Empty
		{
			get
			{
				UMSyFJdtgURDjevto04 uMSyFJdtgURDjevto = default(UMSyFJdtgURDjevto04);
				uMSyFJdtgURDjevto.V8rvqxoidAa = Marshal.SizeOf(uMSyFJdtgURDjevto);
				return uMSyFJdtgURDjevto;
			}
		}

		internal static bool cXqpVMckLeLxrGyu4SwB()
		{
			return wxqlstck9P7xYQkZ8kvM == null;
		}
	}

	internal enum fGNxV1dxG5XqA670Gp7 : uint
	{

	}

	[Flags]
	internal enum jxNIdydCwB5GoOWxO04 : uint
	{

	}

	internal enum E4pP1NdrDrZmckPETg9
	{

	}

	internal enum VL2jQ2dIGgppONEM3N8
	{

	}

	internal enum BfYXuodGlESaZBB5nUZ
	{

	}

	internal enum bCXwyWdLGdp8W5PN2wH
	{

	}

	internal enum OqJJR8dpDWjRRKQYZih
	{

	}

	[Flags]
	public enum l9UEmvdaBOo7YVhwxQb : uint
	{

	}

	internal enum bDbHpCdzkxxIwy01RrA
	{

	}

	private enum dpLx65ulUQRlLFQj8xx : uint
	{

	}

	internal struct U2wDn3uqsIw4baI7d5i
	{
		internal uint bCxvqnfGMaK;

		internal uint P2Lvq4ulH2C;
	}

	internal enum Gfy1Ffu5sCpwbcWtTve
	{

	}

	internal enum NuOumwuAjopui5cCy8W
	{

	}

	internal struct yTXYevuwPNdvZccV17p
	{
		internal uint c6Nvq5jm6rb;
	}

	public enum OofhsFuW6fkX1NgjjXD : uint
	{

	}

	public delegate bool O0PHP0u2tw01VNGcGkg(IntPtr hMonitor, IntPtr hdcMonitor, ref UqwBGEdQOmobi3k3BTZ lprcMonitor, IntPtr dwData);

	internal enum vgGG7XujgNnYrya2Djh
	{

	}

	internal struct KqnV52uXyb4tPvxvW5s
	{
		public bool eO8vqDSBloj;

		public int ClFvqd7SvC7;

		public int JiCvqoiveMR;

		public IntPtr vwrvqT1YhiV;

		public IntPtr xq5vqMbqhiF;
	}

	internal enum BUG8n2uojkVkm62obo7
	{

	}

	internal enum UVZRfnuYSiFXmr8tIZE : uint
	{

	}

	[Flags]
	public enum wVZfR8uMFkvEsIhH6wE
	{

	}

	internal static uint pBIrB9VfJ1;

	internal static uint E8DrQ4NRid;

	internal static uint pI6rjOnbvP;

	internal static readonly uint lbhrnYB5ge;

	internal static lTX1EJ5crAHPVuUbPH8 lP1ojaImIr8gOEgw8W4;

	[DllImport("user32.dll", EntryPoint = "EnumWindows")]
	internal static extern bool Qg4xsxUxe4(Iq9QGHd06vZ3mhJNS1i iq9QGHd06vZ3mhJNS1i_0, IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RXDxHVMOIa(IntPtr intptr_0, Iq9QGHd06vZ3mhJNS1i iq9QGHd06vZ3mhJNS1i_0, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "GetDC")]
	internal static extern IntPtr RfJx11RS3O(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetClientRect")]
	internal static extern bool am0xbir6T1(IntPtr intptr_0, out UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0);

	[DllImport("user32", CharSet = CharSet.Auto, EntryPoint = "GetMonitorInfo", SetLastError = true)]
	internal static extern bool hJ0x6ODqfE(IntPtr intptr_0, ref In7U8EdZ2NUvehTOPat in7U8EdZ2NUvehTOPat_0);

	[DllImport("user32", EntryPoint = "MonitorFromWindow")]
	internal static extern IntPtr cyRxXyMddA(IntPtr intptr_0, int int_0);

	[DllImport("user32", EntryPoint = "MonitorFromPoint")]
	internal static extern IntPtr Eh0xmZvkO0(FBfTEwdB0MRQ5PpeoRS fbfTEwdB0MRQ5PpeoRS_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	internal static extern int QJbxKoktRx(int int_0);

	[DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
	public static extern IntPtr BVRxxN6GhE(Point point_0);

	[DllImport("user32.dll", EntryPoint = "EnableWindow")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool U6Exr9aMh9(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll", EntryPoint = "SetCapture")]
	public static extern IntPtr wBTxp0id89(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
	public static extern bool feDxB8u3A1();

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	internal static extern bool lYSxQ8pSV1(IntPtr intptr_0, out UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0);

	[DllImport("DwmApi.dll", EntryPoint = "DwmGetWindowAttribute")]
	private static extern int AuaxjkWT5n(IntPtr intptr_0, dpLx65ulUQRlLFQj8xx dpLx65ulUQRlLFQj8xx_0, out UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0, int int_0);

	internal static void Lv3xnQtr9B(IntPtr intptr_0, out UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0)
	{
		AuaxjkWT5n(intptr_0, (dpLx65ulUQRlLFQj8xx)9u, out var uqwBGEdQOmobi3k3BTZ_1, Marshal.SizeOf(typeof(UqwBGEdQOmobi3k3BTZ)));
		uqwBGEdQOmobi3k3BTZ_0 = uqwBGEdQOmobi3k3BTZ_1;
	}

	internal static Rectangle rLgx4ZZ8Fh(IntPtr intptr_0)
	{
		AuaxjkWT5n(intptr_0, (dpLx65ulUQRlLFQj8xx)9u, out var uqwBGEdQOmobi3k3BTZ_, Marshal.SizeOf(typeof(UqwBGEdQOmobi3k3BTZ)));
		if (!uqwBGEdQOmobi3k3BTZ_.IsEmpty)
		{
			return new Rectangle(uqwBGEdQOmobi3k3BTZ_.crGvqbYWVF6, uqwBGEdQOmobi3k3BTZ_.mP6vq6MOjic, uqwBGEdQOmobi3k3BTZ_.width, uqwBGEdQOmobi3k3BTZ_.height);
		}
		lYSxQ8pSV1(intptr_0, out var uqwBGEdQOmobi3k3BTZ_2);
		return new Rectangle(uqwBGEdQOmobi3k3BTZ_2.crGvqbYWVF6, uqwBGEdQOmobi3k3BTZ_2.mP6vq6MOjic, uqwBGEdQOmobi3k3BTZ_2.width, uqwBGEdQOmobi3k3BTZ_2.height);
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
	internal static extern bool CuFx5bmBlx(IntPtr intptr_0, out UMSyFJdtgURDjevto04 umsyFJdtgURDjevto04_0);

	[DllImport("user32.dll", EntryPoint = "GetAncestor", ExactSpelling = true)]
	internal static extern IntPtr SJmxDCTdRb(IntPtr intptr_0, VL2jQ2dIGgppONEM3N8 vl2jQ2dIGgppONEM3N8_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongW", SetLastError = true)]
	private static extern int OadxdYLJcj(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongPtrW", SetLastError = true)]
	private static extern IntPtr v5axo84Ajn(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegisterHotKey", SetLastError = true)]
	internal static extern bool walxTDo89E(IntPtr intptr_0, int int_0, int int_1, int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "UnregisterHotKey", SetLastError = true)]
	internal static extern bool uqqxM1golN(IntPtr intptr_0, int int_0);

	public static IntPtr HuFxA0bcDW(IntPtr intptr_0, BfYXuodGlESaZBB5nUZ bfYXuodGlESaZBB5nUZ_0)
	{
		if (t9wrqwrpF3())
		{
			return (IntPtr)OadxdYLJcj(intptr_0, (int)bfYXuodGlESaZBB5nUZ_0);
		}
		return v5axo84Ajn(intptr_0, (int)bfYXuodGlESaZBB5nUZ_0);
	}

	[DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
	internal static extern bool hvqxOaSVga(ref U2wDn3uqsIw4baI7d5i u2wDn3uqsIw4baI7d5i_0);

	[DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool lMsxFIFIat([In] IntPtr intptr_0);

	[DllImport("shcore", EntryPoint = "GetDpiForMonitor")]
	internal static extern int jMjxUukK6e(IntPtr intptr_0, Gfy1Ffu5sCpwbcWtTve gfy1Ffu5sCpwbcWtTve_0, ref uint uint_4, ref uint uint_5);

	[DllImport("shcore", EntryPoint = "SetProcessDpiAwareness")]
	internal static extern int yskxluBDRq(int int_0);

	[DllImport("shcore", EntryPoint = "GetProcessDpiAwareness")]
	internal static extern int s2Wxi7GCKt(IntPtr intptr_0, ref int int_0);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
	internal static extern uint HNCx3KufZW();

	[DllImport("kernel32.dll", EntryPoint = "GetTickCount64")]
	internal static extern ulong lWJxfd8Kc1();

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
	internal static extern bool uOhxzEKfUj(IntPtr intptr_0);

	[DllImport("advapi32.dll", EntryPoint = "GetTokenInformation", SetLastError = true)]
	internal static extern bool G76rw8jBnf(IntPtr intptr_0, NuOumwuAjopui5cCy8W nuOumwuAjopui5cCy8W_0, IntPtr intptr_1, uint uint_4, out uint uint_5);

	[DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", SetLastError = true)]
	internal static extern bool nBQrt0CXMx(IntPtr intptr_0, uint uint_4, out IntPtr intptr_1);

	internal static void G9rrgQZ2kr()
	{
		Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
	}

	[DllImport("user32.dll", EntryPoint = "MonitorFromPoint", SetLastError = true)]
	public static extern IntPtr aNUrL2fnOZ(Point point_0, OofhsFuW6fkX1NgjjXD oofhsFuW6fkX1NgjjXD_0);

	[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
	public static extern bool H0ervf9rIn(IntPtr intptr_0, IntPtr intptr_1, O0PHP0u2tw01VNGcGkg o0PHP0u2tw01VNGcGkg_0, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "GetWindowLong", SetLastError = true)]
	public static extern uint dQbrSGJulu(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
	internal static extern IntPtr mp6r285aix();

	[DllImport("user32.dll", EntryPoint = "GetShellWindow")]
	internal static extern IntPtr heJrurlRwy();

	[DllImport("user32.dll", EntryPoint = "GetWindowDC")]
	internal static extern IntPtr Uc7rNqNWee(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool vTMrJycNWS(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetWindow")]
	internal static extern IntPtr Hnir0yyf2i(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	internal static extern uint vAxrCyFr2m(IntPtr intptr_0, out uint uint_4);

	[DllImport("user32", EntryPoint = "SetWindowPos")]
	internal static extern bool PC0rPysmjW(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, uint uint_4);

	[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
	internal static extern bool f2arE69QQ8(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("authorex.dll", EntryPoint = "CreateDeviceDiscoveryClass")]
	internal static extern int qR6ryqfVfR(out jhdtFl5PFU9jAYKTaHr.z2ZcUbumeS417H5ww1E z2ZcUbumeS417H5ww1E_0, jhdtFl5PFU9jAYKTaHr.Ty8uCNuddyaWRMKNAAs ty8uCNuddyaWRMKNAAs_0);

	[DllImport("authorex.dll", EntryPoint = "CreateCaptureControlClass")]
	internal static extern int kPgr8GanT0(out jhdtFl5PFU9jAYKTaHr.JSxoB4uuY0mW7IVEN29 jsxoB4uuY0mW7IVEN29_0, jhdtFl5PFU9jAYKTaHr.myIbXAuksyTv19achpJ myIbXAuksyTv19achpJ_0);

	[DllImport("authorex.dll", EntryPoint = "CreateMP4MediaTransferClass")]
	internal static extern int F4gra9bhfJ(out jhdtFl5PFU9jAYKTaHr.juP2WRu86wCkShLQoox juP2WRu86wCkShLQoox_0);

	[DllImport("authorex.dll", EntryPoint = "VerifyEmbeddedSignature")]
	internal static extern int qb2r7FtkNU([MarshalAs(UnmanagedType.BStr)] string string_0, bool bool_0);

	[DllImport("authorex.dll", EntryPoint = "CheckD3D")]
	internal static extern int DDrrRNZL11(uint uint_4);

	internal static bool t9wrqwrpF3()
	{
		return IntPtr.Size == 4;
	}

	[DllImport("gdi32.dll", EntryPoint = "GetClipBox")]
	internal static extern int qLYrcDvrRv(IntPtr intptr_0, out UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0);

	[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
	public static extern IntPtr EIjrV14PoK(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
	public static extern IntPtr bpDrZ80IgC(IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
	public static extern IntPtr m2Lr9m0PWC(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("gdi32", EntryPoint = "DeleteObject")]
	internal static extern bool S8KrhZjl25(IntPtr intptr_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateDC")]
	internal static extern IntPtr kVqreFgULV(string string_0, string string_1, string string_2, IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
	internal static extern bool kHtrYAp3UG(IntPtr intptr_0);

	[DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
	internal static extern int gn5rIfSO8c(IntPtr intptr_0, int int_0);

	[DllImport("gdi32.dll", EntryPoint = "BitBlt")]
	internal static extern bool OTTrWPsFSA(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, UVZRfnuYSiFXmr8tIZE uvzrfnuYSiFXmr8tIZE_0);

	public static IntPtr B20rk49MuW(IntPtr intptr_0)
	{
		return cyRxXyMddA(intptr_0, 2);
	}

	[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool yHerG4VYjF(int int_0, int int_1);

	[DllImport("user32.dll", EntryPoint = "GetPhysicalCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool kyYrsapWLH(ref FBfTEwdB0MRQ5PpeoRS fbfTEwdB0MRQ5PpeoRS_0);

	[DllImport("user32.dll", EntryPoint = "ChildWindowFromPointEx")]
	public static extern IntPtr hIHrHH6n3e(IntPtr intptr_0, Point point_0, uint uint_4);

	public static IntPtr oKIr1vTS4o(IntPtr intptr_0)
	{
		IntPtr intPtr = SJmxDCTdRb(intptr_0, (VL2jQ2dIGgppONEM3N8)2);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == mp6r285aix()))
		{
			return intPtr;
		}
		return intptr_0;
	}

	public static Point jYMrbg80Ov()
	{
		FBfTEwdB0MRQ5PpeoRS fbfTEwdB0MRQ5PpeoRS_ = default(FBfTEwdB0MRQ5PpeoRS);
		kyYrsapWLH(ref fbfTEwdB0MRQ5PpeoRS_);
		return new Point(fbfTEwdB0MRQ5PpeoRS_.x, fbfTEwdB0MRQ5PpeoRS_.dscvqGJBIpg);
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	private static extern IntPtr WRVr6WYR2J(uint uint_4, bool bool_0, uint uint_5);

	[DllImport("psapi.dll", EntryPoint = "GetModuleBaseName")]
	private static extern uint VY4rXSyHx1(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[DllImport("psapi.dll", EntryPoint = "GetModuleFileNameEx")]
	private static extern uint oxxrmmXgHa(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	public static string CSDrKFqUBI(uint uint_4)
	{
		IntPtr intPtr = WRVr6WYR2J(4112u, false, uint_4);
		if (intPtr != IntPtr.Zero)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			uint num = oxxrmmXgHa(intPtr, IntPtr.Zero, stringBuilder, stringBuilder.Capacity);
			uOhxzEKfUj(intPtr);
			if (num != 0)
			{
				return Path.GetFileName(stringBuilder.ToString());
			}
			return "-";
		}
		return "-";
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName", SetLastError = true)]
	private static extern int CsZrxKeK00(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	public static string tn9rrmFHG5(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		CsZrxKeK00(intptr_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	[DllImport("user32", EntryPoint = "SetWindowLong")]
	internal static extern int AeurpeFCxL(IntPtr intptr_0, int int_0, uint uint_4);

	static lTX1EJ5crAHPVuUbPH8()
	{
		pBIrB9VfJ1 = 131072u;
		E8DrQ4NRid = 8u;
		pI6rjOnbvP = pBIrB9VfJ1 | E8DrQ4NRid;
		lbhrnYB5ge = 33554432u;
	}

	internal static bool thdJjyIsJ5vRkUsVVfJ()
	{
		return lP1ojaImIr8gOEgw8W4 == null;
	}
}
