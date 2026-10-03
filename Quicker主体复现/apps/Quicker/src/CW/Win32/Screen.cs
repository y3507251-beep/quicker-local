using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CW.Win32;

public static class Screen
{
	private delegate void qchbC9dM6WD7MjIOxkd(IntPtr hMonir, IntPtr hdcMonitor, IntPtr lprcMonitor, IntPtr dwData);

	internal struct mu1DCmdfaEny33ihLQa
	{
		public int r7dvyxvtUdt;

		public Rectangle vYovyr96Q7n;

		public Rectangle IsovypLqSPq;

		public int lGGvyBv7HNR;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string J2AvyQdH5ke;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec np1vy4BxiYQ;

		public static Func<_003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo>, long> cBQvy5OtbK6;

		public static Func<_003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo>, ScreenInfo> du5vyDxgmoT;

		private static _003C_003Ec tWDfJ2cEml6UgsrSb444;

		static _003C_003Ec()
		{
			np1vy4BxiYQ = new _003C_003Ec();
		}

		internal long tdXvyj7npTt(_003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo> x)
		{
			return x.Rect.Area;
		}

		internal ScreenInfo HbVvynFLmEn(_003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo> x)
		{
			return x.Monitor;
		}

		internal static bool sZ2swZcEsA44W45scEY0()
		{
			return tWDfJ2cEml6UgsrSb444 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public List<ScreenInfo> GYVvyo6KqR6;

		internal static _003C_003Ec__DisplayClass0_0 rLhYDJcE7IWhlrje15AV;

		internal void jSSvydkV6p1(IntPtr hMonitor, IntPtr hdcMonitor, IntPtr lprcMonitor, IntPtr dwData)
		{
			mu1DCmdfaEny33ihLQa mu1DCmdfaEny33ihLQa_ = new mu1DCmdfaEny33ihLQa
			{
				r7dvyxvtUdt = Marshal.SizeOf(typeof(mu1DCmdfaEny33ihLQa))
			};
			uQyCo5sv6h(hMonitor, ref mu1DCmdfaEny33ihLQa_);
			GYVvyo6KqR6.Add(new ScreenInfo(mu1DCmdfaEny33ihLQa_));
		}

		internal static bool qG7Qn6cE4tU9mc9ux8Ev()
		{
			return rLhYDJcE7IWhlrje15AV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public Int32Rect PT1vyMa1R8F;

		internal static _003C_003Ec__DisplayClass5_0 Ap1D9AcEHRMQP66vFHmB;

		internal _003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo> uvbvyTfBnqF(ScreenInfo mon)
		{
			return new _003C_003Ef__AnonymousType16<Int32Rect, ScreenInfo>(mon.ScreenArea.Intersect(PT1vyMa1R8F), mon);
		}

		internal static bool cLugOUcEzHdQrISCEx0Z()
		{
			return Ap1D9AcEHRMQP66vFHmB == null;
		}
	}

	private static object RTlfTZ1jh6bLRc2AjcE;

	public static IEnumerable<ScreenInfo> GetMonitors()
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.GYVvyo6KqR6 = new List<ScreenInfo>();
		ijvCdDcVit(IntPtr.Zero, IntPtr.Zero, _003C_003Ec__DisplayClass0_.jSSvydkV6p1, IntPtr.Zero);
		return _003C_003Ec__DisplayClass0_.GYVvyo6KqR6;
	}

	[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
	private static extern bool ijvCdDcVit(IntPtr intptr_0, IntPtr intptr_1, qchbC9dM6WD7MjIOxkd qchbC9dM6WD7MjIOxkd_0, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "GetMonitorInfo")]
	private static extern bool uQyCo5sv6h(IntPtr intptr_0, ref mu1DCmdfaEny33ihLQa mu1DCmdfaEny33ihLQa_0);

	public static ScreenInfo GetCurrentMonitor(Int32Rect rect)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.PT1vyMa1R8F = rect;
		return GetMonitors().Select(_003C_003Ec__DisplayClass5_.uvbvyTfBnqF).OrderByDescending(_003C_003Ec.cBQvy5OtbK6 ?? (_003C_003Ec.cBQvy5OtbK6 = _003C_003Ec.np1vy4BxiYQ.tdXvyj7npTt)).Select(_003C_003Ec.du5vyDxgmoT ?? (_003C_003Ec.du5vyDxgmoT = _003C_003Ec.np1vy4BxiYQ.HbVvynFLmEn))
			.First();
	}

	internal static bool aaFP4J1DwvB9bH39evx()
	{
		return RTlfTZ1jh6bLRc2AjcE == null;
	}
}
