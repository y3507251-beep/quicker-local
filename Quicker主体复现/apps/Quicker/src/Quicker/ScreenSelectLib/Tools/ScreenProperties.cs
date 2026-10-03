using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using MTvu7H59xFIE4dJJH9K;
using XAK0Gv5H9h6VY926piI;

namespace Quicker.ScreenSelectLib.Tools;

public class ScreenProperties
{
	public class MonitorInformation
	{
		public string deviceName;

		public bool isPrimary;

		internal lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ m1nvctlQB8h;

		internal lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ pSgvcgdhodw;

		public double scalingFactor;

		public double dpiX;

		public double dpiY;

		internal static MonitorInformation aYLGavcrDakNLugMZ34L;

		internal static bool dPNVVwcr3faAhBMeFi7N()
		{
			return aYLGavcrDakNLugMZ34L == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec wdMvcSIF15C;

		public static Func<KeyValuePair<IntPtr, MonitorInformation>, bool> Fqcvc2bEy4F;

		public static Func<KeyValuePair<IntPtr, MonitorInformation>, MonitorInformation> bqsvcuHCUEN;

		internal static _003C_003Ec S3pPEGcrGfqmZ71WEPPW;

		static _003C_003Ec()
		{
			wdMvcSIF15C = new _003C_003Ec();
		}

		internal bool XoivcLMsAFR(KeyValuePair<IntPtr, MonitorInformation> x)
		{
			return x.Key != IntPtr.Zero;
		}

		internal MonitorInformation T2Wvcvu7eSw(KeyValuePair<IntPtr, MonitorInformation> x)
		{
			return x.Value;
		}

		internal static void R0ryXHcrKQVAoGkQxKgA()
		{
		}

		internal static bool opSimmcr0ZIOyB30L7Af()
		{
			return S3pPEGcrGfqmZ71WEPPW == null;
		}
	}

	private readonly Dictionary<IntPtr, MonitorInformation> Jl5rMLI6V6 = new Dictionary<IntPtr, MonitorInformation>();

	internal static ScreenProperties cLGLov6eSVS4Qpx5ifC;

	public ScreenProperties()
	{
		tQyroONVCZ();
	}

	public IEnumerable<MonitorInformation> GetMonitors()
	{
		return Jl5rMLI6V6.Where(_003C_003Ec.Fqcvc2bEy4F ?? (_003C_003Ec.Fqcvc2bEy4F = _003C_003Ec.wdMvcSIF15C.XoivcLMsAFR)).Select(_003C_003Ec.bqsvcuHCUEN ?? (_003C_003Ec.bqsvcuHCUEN = _003C_003Ec.wdMvcSIF15C.T2Wvcvu7eSw)).ToList();
	}

	public MonitorInformation GetMonitorInformation(Point point)
	{
		IntPtr hMonitor = lTX1EJ5crAHPVuUbPH8.aNUrL2fnOZ(point, (lTX1EJ5crAHPVuUbPH8.OofhsFuW6fkX1NgjjXD)0u);
		return GetMonitorInformation(hMonitor);
	}

	public MonitorInformation GetMonitorInformation(IntPtr hMonitor)
	{
		if (Jl5rMLI6V6.ContainsKey(hMonitor))
		{
			return Jl5rMLI6V6[hMonitor];
		}
		if (hMonitor == IntPtr.Zero)
		{
			hMonitor = lTX1EJ5crAHPVuUbPH8.cyRxXyMddA(IntPtr.Zero, 1);
			int num = 0;
			if (cLGLov6eSVS4Qpx5ifC != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (Jl5rMLI6V6.ContainsKey(hMonitor))
			{
				Jl5rMLI6V6[IntPtr.Zero] = Jl5rMLI6V6[hMonitor];
				return Jl5rMLI6V6[hMonitor];
			}
		}
		lTX1EJ5crAHPVuUbPH8.In7U8EdZ2NUvehTOPat in7U8EdZ2NUvehTOPat_ = lTX1EJ5crAHPVuUbPH8.In7U8EdZ2NUvehTOPat.New();
		if (!lTX1EJ5crAHPVuUbPH8.hJ0x6ODqfE(hMonitor, ref in7U8EdZ2NUvehTOPat_))
		{
			Jl5rMLI6V6[hMonitor] = null;
			return null;
		}
		bxlYjy5DCfnONDuA8Y4.hoZxCdSBMu(hMonitor, out var uint_, out var uint_2);
		MonitorInformation monitorInformation = new MonitorInformation
		{
			deviceName = in7U8EdZ2NUvehTOPat_.UtVvqkSyYoh,
			isPrimary = ((in7U8EdZ2NUvehTOPat_.zeAvqWIa7bn & 1) != 0),
			m1nvctlQB8h = in7U8EdZ2NUvehTOPat_.ijOvqYS7ENq,
			pSgvcgdhodw = in7U8EdZ2NUvehTOPat_.WJOvqIPnWCD,
			scalingFactor = bxlYjy5DCfnONDuA8Y4.HZbx8WLrCD(in7U8EdZ2NUvehTOPat_.UtVvqkSyYoh),
			dpiX = uint_,
			dpiY = uint_2
		};
		Jl5rMLI6V6[hMonitor] = monitorInformation;
		if (monitorInformation.isPrimary && !Jl5rMLI6V6.ContainsKey(IntPtr.Zero))
		{
			Jl5rMLI6V6[IntPtr.Zero] = monitorInformation;
		}
		return monitorInformation;
	}

	private void tQyroONVCZ()
	{
		lTX1EJ5crAHPVuUbPH8.H0ervf9rIn(IntPtr.Zero, IntPtr.Zero, aHIrT6TTKT, IntPtr.Zero);
	}

	[CompilerGenerated]
	private bool aHIrT6TTKT(IntPtr intptr_0, IntPtr intptr_1, ref lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_0, IntPtr intptr_2)
	{
		GetMonitorInformation(intptr_0);
		return true;
	}

	internal static void VRcbk7632per2OnG5dT()
	{
	}

	internal static bool k7Oaok6jqDC4by7akxe()
	{
		return cLGLov6eSVS4Qpx5ifC == null;
	}
}
