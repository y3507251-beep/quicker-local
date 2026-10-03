using System;
using System.Drawing;
using System.Reflection;
using System.Timers;
using Ci3RULiH5a8Cgg0fIS5;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;

namespace B8V6Yui1nJ3jwiLJ3Bm;

internal class AhomQMieinjGJjNmmsS
{
	private static readonly ILog NV8vSeldTmH;

	private readonly PopupState fYTvSYRpmve;

	private readonly UIy1pYiDsLcf2l4joSP XEAvSI6mE21;

	private readonly Timer oL6vSWO0iEi;

	private long K2YvSkIIZjp;

	private Point hDNvSG0c6ty;

	private static AhomQMieinjGJjNmmsS FoT0CEFhj3GBKsTtJMUN;

	public AhomQMieinjGJjNmmsS(PopupState popupState_1, UIy1pYiDsLcf2l4joSP uiy1pYiDsLcf2l4joSP_1)
	{
		fYTvSYRpmve = popupState_1;
		XEAvSI6mE21 = uiy1pYiDsLcf2l4joSP_1;
		oL6vSWO0iEi = new Timer(3000.0);
		oL6vSWO0iEi.AutoReset = true;
		oL6vSWO0iEi.Elapsed += zbXvSZO1nbU;
	}

	private void zbXvSZO1nbU(object sender, ElapsedEventArgs e)
	{
		Point mousePosition = NativeMethods.GetMousePosition();
		if (!(mousePosition != hDNvSG0c6ty))
		{
			return;
		}
		int num = 0;
		if (!PnMJ6BFhDiALQqHmYuCP())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		hDNvSG0c6ty = mousePosition;
		if (!fYTvSYRpmve.IsEnabled)
		{
			K2YvSkIIZjp = AppHelper.fLiLTj0x4QY();
			return;
		}
		if (AppHelper.fLiLTj0x4QY() - K2YvSkIIZjp <= 4000L)
		{
			return;
		}
		NV8vSeldTmH.Warn("检测到鼠标挂钩可能丢失！当前进程：" + AppState.CurrentProcessName);
		try
		{
			Stop();
			if (AppState.DataService.CpItmVISR7P().EnableHookDetector)
			{
				AppState.Y2RtaqSv0AQ().RequestReinstallHook(this);
			}
		}
		catch (Exception ex)
		{
			NV8vSeldTmH.Error("重新加载挂钩出错！", ex);
			AppHelper.ShowWarning("重新加载挂钩出错！" + ex.Message);
		}
		K2YvSkIIZjp = AppHelper.fLiLTj0x4QY();
	}

	public void jofvS9UK1gu()
	{
		hDNvSG0c6ty = NativeMethods.GetMousePosition();
		oL6vSWO0iEi.Start();
	}

	public void Stop()
	{
		oL6vSWO0iEi.Stop();
	}

	public void K3XvSheneoZ()
	{
		K2YvSkIIZjp = AppHelper.fLiLTj0x4QY();
	}

	static AhomQMieinjGJjNmmsS()
	{
		NV8vSeldTmH = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool PnMJ6BFhDiALQqHmYuCP()
	{
		return FoT0CEFhj3GBKsTtJMUN == null;
	}
}
