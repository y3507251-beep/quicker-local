using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

namespace IPX7yRZnyyrui5B9FZ;

internal static class qalNllR8qMeP2UbUj1
{
	public enum No27hJmLrXI3EyZmcdi
	{
		Left,
		Top,
		Right,
		Bottom,
		None
	}

	public struct X0Mc2AmpIjryYFa7se6
	{
		public int aTEvEH1v0PK;

		public IntPtr V7SvE1yoKVx;

		public int CBCvEbvv8bA;

		public int OCSvE6TG4LB;

		public nPsPMemzmBfsakHs52Q AlIvEX3veso;

		public IntPtr hhnvEmRPReR;
	}

	public struct E7iiWjmaHUqBlUF6FXS
	{
		public int X;

		public int Y;

		private static object Jl70RicjuQ08JxwZWEVP;

		public static explicit operator E7iiWjmaHUqBlUF6FXS(Point point_0)
		{
			return new E7iiWjmaHUqBlUF6FXS
			{
				X = (int)point_0.X,
				Y = (int)point_0.Y
			};
		}

		public static explicit operator Point(E7iiWjmaHUqBlUF6FXS e7iiWjmaHUqBlUF6FXS_0)
		{
			return new Point(e7iiWjmaHUqBlUF6FXS_0.X, e7iiWjmaHUqBlUF6FXS_0.Y);
		}

		internal static bool DBNOADcjoHqY7Q0F5Rht()
		{
			return Jl70RicjuQ08JxwZWEVP == null;
		}
	}

	public struct nPsPMemzmBfsakHs52Q
	{
		public int kYlvEpsT3ds;

		public int K0fvEBmFjTF;

		public int PUEvEQbc7IS;

		public int Kk1vEjthAu4;

		internal static object Hwb6L6cjbWn6sAWyTUeK;

		public int Width => PUEvEQbc7IS - kYlvEpsT3ds;

		public int Height => Kk1vEjthAu4 - K0fvEBmFjTF;

		public bool IsEmpty
		{
			get
			{
				if (kYlvEpsT3ds < PUEvEQbc7IS)
				{
					return K0fvEBmFjTF >= Kk1vEjthAu4;
				}
				return true;
			}
		}

		public nPsPMemzmBfsakHs52Q(int int_4, int int_5, int int_6, int int_7)
		{
			kYlvEpsT3ds = int_4;
			K0fvEBmFjTF = int_5;
			PUEvEQbc7IS = int_6;
			Kk1vEjthAu4 = int_7;
		}

		public void Offset(int dx, int dy)
		{
			kYlvEpsT3ds += dx;
			K0fvEBmFjTF += dy;
			PUEvEQbc7IS += dx;
			Kk1vEjthAu4 += dy;
		}

		public static explicit operator Int32Rect(nPsPMemzmBfsakHs52Q nPsPMemzmBfsakHs52Q_0)
		{
			return new Int32Rect(nPsPMemzmBfsakHs52Q_0.kYlvEpsT3ds, nPsPMemzmBfsakHs52Q_0.K0fvEBmFjTF, nPsPMemzmBfsakHs52Q_0.Width, nPsPMemzmBfsakHs52Q_0.Height);
		}

		public static explicit operator Rect(nPsPMemzmBfsakHs52Q nPsPMemzmBfsakHs52Q_0)
		{
			return new Rect(nPsPMemzmBfsakHs52Q_0.kYlvEpsT3ds, nPsPMemzmBfsakHs52Q_0.K0fvEBmFjTF, nPsPMemzmBfsakHs52Q_0.Width, nPsPMemzmBfsakHs52Q_0.Height);
		}

		public static explicit operator nPsPMemzmBfsakHs52Q(Rect rect_0)
		{
			return new nPsPMemzmBfsakHs52Q((int)rect_0.Left, (int)rect_0.Top, (int)rect_0.Right, (int)rect_0.Bottom);
		}

		internal static void OZtm9OcjlrHnvkF7n6hT()
		{
		}

		internal static bool Kq3t6vcjqMMLjQghpSCe()
		{
			return Hwb6L6cjbWn6sAWyTUeK == null;
		}
	}

	public struct KqmHpYdl5APsuA3N1oT
	{
		public IntPtr PAhvED5MPHR;

		public IntPtr aMfvEdtCynW;

		public int x;

		public int YyqvEot4HvA;

		public int IAXvETWsJ3i;

		public int zRHvEMCxwOi;

		public int TtTvEAd9Op3;

		private static object sQxhFwcjZfs2ocoqxLS2;

		[SpecialName]
		public Rect vN3vEnOa1tc()
		{
			return new Rect(x, YyqvEot4HvA, IAXvETWsJ3i, zRHvEMCxwOi);
		}

		[SpecialName]
		public void SeLvE4yS6yE(Rect rect_0)
		{
			x = (int)rect_0.X;
			YyqvEot4HvA = (int)rect_0.Y;
			IAXvETWsJ3i = (int)rect_0.Width;
			zRHvEMCxwOi = (int)rect_0.Height;
		}

		internal static bool LvQL3ucj5G7lIRukFty8()
		{
			return sQxhFwcjZfs2ocoqxLS2 == null;
		}
	}

	public enum c5D173dqIrFX4ASBdh2
	{

	}

	public enum Jgt8a0d5c3aUhnP6d1m
	{

	}

	[Flags]
	public enum MJASfDdAHSTfRd8b6o3
	{

	}

	[Flags]
	public enum H0AJgndw1OI1UtbLrrv
	{

	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct rcNLaJdWJ4UNxK2tSfY
	{
		public int u62vEO3GbHG;

		public nPsPMemzmBfsakHs52Q eRevEF8oPlk;

		public nPsPMemzmBfsakHs52Q MCKvEUbEObK;

		public MJASfDdAHSTfRd8b6o3 iTQvEl4v8Mu;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string CcPvEiuGi5L;
	}

	public delegate bool arURA5d21f8GXfeZaWi(IntPtr hMonitor, IntPtr hdcMonitor, ref nPsPMemzmBfsakHs52Q lprcMonitor, IntPtr dwData);

	private static object uMlft73KYo0YpKLHUB7;

	public static int vTpJ8PpWIC(IntPtr intptr_0)
	{
		return (int)intptr_0 & 0xFFF0;
	}

	[DllImport("Shell32.dll", EntryPoint = "SHAppBarMessage", ExactSpelling = true)]
	public static extern uint YaMJaf5uaV(c5D173dqIrFX4ASBdh2 c5D173dqIrFX4ASBdh2_0, ref X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegisterWindowMessage")]
	public static extern int MIpJ7OYkZs(string string_0);

	[DllImport("user32.dll", EntryPoint = "SetWindowPos", ExactSpelling = true, SetLastError = true)]
	public static extern bool BKbJRTm5ao(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, uint uint_0);

	public static IntPtr ebXJq99Rj4(IntPtr intptr_0, int int_0)
	{
		if (IntPtr.Size != 4)
		{
			return B7YJVFSu2N(intptr_0, int_0);
		}
		return hABJc2qZYp(intptr_0, int_0);
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern IntPtr hABJc2qZYp(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
	private static extern IntPtr B7YJVFSu2N(IntPtr intptr_0, int int_0);

	public static IntPtr ubxJZkvTMp(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		if (IntPtr.Size != 4)
		{
			return D1qJh8ArRL(intptr_0, int_0, intptr_1);
		}
		return TvGJ9DjDDN(intptr_0, int_0, intptr_1);
	}

	[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
	private static extern IntPtr TvGJ9DjDDN(IntPtr intptr_0, int int_0, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
	private static extern IntPtr D1qJh8ArRL(IntPtr intptr_0, int int_0, IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetMonitorInfo", SetLastError = true)]
	public static extern bool V5xJeshOyy(IntPtr intptr_0, ref rcNLaJdWJ4UNxK2tSfY rcNLaJdWJ4UNxK2tSfY_0);

	[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
	public static extern bool AOmJYk1HKF(IntPtr intptr_0, IntPtr intptr_1, arURA5d21f8GXfeZaWi arURA5d21f8GXfeZaWi_0, IntPtr intptr_2);

	[DllImport("ShCore.dll", EntryPoint = "GetDpiForMonitor", ExactSpelling = true, PreserveSig = false)]
	public static extern void EfyJIgqj9P(IntPtr intptr_0, H0AJgndw1OI1UtbLrrv h0AJgndw1OI1UtbLrrv_0, out int int_0, out int int_1);

	internal static bool wZelxB3BFYbkZ6V4Tp5()
	{
		return uMlft73KYo0YpKLHUB7 == null;
	}
}
