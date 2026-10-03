using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using jeaU1l2eVVj4W2gaVc;
using SnipInsight.Util;

namespace SnipInsight.ImageCapture;

public class ScreenProperties
{
	public class MonitorInformation
	{
		public string deviceName;

		public bool isPrimary;

		internal OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS jjdvPrg3DCq;

		internal OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS N8UvPpT0YnJ;

		public double scalingFactor;

		public double dpiX;

		public double dpiY;

		internal static MonitorInformation UdUkcUcnGAOvsBmVv6BT;

		internal static bool AeEU6Jcn0LDU2fVhDvR9()
		{
			return UdUkcUcnGAOvsBmVv6BT == null;
		}
	}

	private readonly Dictionary<IntPtr, MonitorInformation> UlsL978Ngu = new Dictionary<IntPtr, MonitorInformation>();

	internal static ScreenProperties R4amEcyz9QifU53K4xM;

	public ScreenProperties()
	{
		CSZLVus8Gj();
	}

	public MonitorInformation GetMonitorInformation(IntPtr hMonitor)
	{
		if (UlsL978Ngu.ContainsKey(hMonitor))
		{
			return UlsL978Ngu[hMonitor];
		}
		if (hMonitor == IntPtr.Zero)
		{
			hMonitor = OO77uFW4jgnwuPwqBc.Ajct8eA8UC(IntPtr.Zero, 1);
			if (UlsL978Ngu.ContainsKey(hMonitor))
			{
				UlsL978Ngu[IntPtr.Zero] = UlsL978Ngu[hMonitor];
				return UlsL978Ngu[hMonitor];
			}
		}
		OO77uFW4jgnwuPwqBc.ngTuxbmDsTD4eNDuh33 ngTuxbmDsTD4eNDuh33_ = OO77uFW4jgnwuPwqBc.ngTuxbmDsTD4eNDuh33.New();
		if (!OO77uFW4jgnwuPwqBc.DHKtyYxbLo(hMonitor, ref ngTuxbmDsTD4eNDuh33_))
		{
			UlsL978Ngu[hMonitor] = null;
			return null;
		}
		DpiUtilities.GetMonitorEffectiveDpi(hMonitor, out var dpiX, out var dpiY);
		MonitorInformation monitorInformation = new MonitorInformation
		{
			deviceName = ngTuxbmDsTD4eNDuh33_.dwvvCffjLQ1,
			isPrimary = ((ngTuxbmDsTD4eNDuh33_.r0uvC3tFRuU & 1) != 0),
			jjdvPrg3DCq = ngTuxbmDsTD4eNDuh33_.t4ovClxJKWQ,
			N8UvPpT0YnJ = ngTuxbmDsTD4eNDuh33_.EOgvCiNsR30,
			scalingFactor = DpiUtilities.GetScreenScalingFactor(ngTuxbmDsTD4eNDuh33_.dwvvCffjLQ1),
			dpiX = dpiX,
			dpiY = dpiY
		};
		if (R4amEcyz9QifU53K4xM == null)
		{
			switch (0)
			{
			}
		}
		UlsL978Ngu[hMonitor] = monitorInformation;
		if (monitorInformation.isPrimary && !UlsL978Ngu.ContainsKey(IntPtr.Zero))
		{
			UlsL978Ngu[IntPtr.Zero] = monitorInformation;
		}
		return monitorInformation;
	}

	private void CSZLVus8Gj()
	{
		OO77uFW4jgnwuPwqBc.IEWtKqYIjk(IntPtr.Zero, IntPtr.Zero, IONLZT4bT3, IntPtr.Zero);
	}

	[CompilerGenerated]
	private bool IONLZT4bT3(IntPtr intptr_0, IntPtr intptr_1, ref Rect rect_0, IntPtr intptr_2)
	{
		GetMonitorInformation(intptr_0);
		return true;
	}

	internal static bool gmEJeIpV64Mu5yBxxsy()
	{
		return R4amEcyz9QifU53K4xM == null;
	}
}
