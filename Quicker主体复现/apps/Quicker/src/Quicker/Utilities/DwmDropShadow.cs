using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using log4net;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public static class DwmDropShadow
{
	private struct YlYIVPDX600PesChuif
	{
		public int Left;

		public int Right;

		public int Top;

		public int Bottom;
	}

	private static readonly ILog Gn9LM1U4EX0;

	private static object akDJeEFRLeKfy9Jet7CI;

	[DllImport("DwmApi.dll", EntryPoint = "DwmSetWindowAttribute")]
	private static extern int hevLMkcL0WL(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("DwmApi.dll", EntryPoint = "DwmExtendFrameIntoClientArea")]
	private static extern int gk8LMG7aDFr(IntPtr intptr_0, ref YlYIVPDX600PesChuif ylYIVPDX600PesChuif_0);

	public static void DropShadowToWindow(Window window)
	{
		if (!rI8LMHYR1db(window))
		{
			window.SourceInitialized += nFlLMs2wWMJ;
		}
	}

	private static void nFlLMs2wWMJ(object window_0Input, EventArgs eventArgs_0)
	{
        Window window_0 = (Window)window_0Input;
		Window obj = window_0;
		rI8LMHYR1db(obj);
		obj.SourceInitialized -= nFlLMs2wWMJ;
	}

	private static bool rI8LMHYR1db(Window window_0)
	{
		try
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window_0);
			int int_ = 2;
			if (hevLMkcL0WL(windowInteropHelper.Handle, 2, ref int_, 4) == 0)
			{
				YlYIVPDX600PesChuif ylYIVPDX600PesChuif = new YlYIVPDX600PesChuif
				{
					Bottom = 1
				};
				int num = 0;
				if (!bu1TkmFRuHnsJZrWMSNc())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
				{
					ylYIVPDX600PesChuif.Left = 1;
					ylYIVPDX600PesChuif.Right = 1;
					ylYIVPDX600PesChuif.Top = 1;
					YlYIVPDX600PesChuif ylYIVPDX600PesChuif_ = ylYIVPDX600PesChuif;
					return gk8LMG7aDFr(windowInteropHelper.Handle, ref ylYIVPDX600PesChuif_) == 0;
				}
				}
			}
			return false;
		}
		catch (Exception ex)
		{
			Gn9LM1U4EX0.Warn("设置窗口阴影失败：" + ex.Message);
			return false;
		}
	}

	public static bool TryAddShadow(Window window)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
		int int_ = 2;
		if (hevLMkcL0WL(windowInteropHelper.Handle, 2, ref int_, 4) == 0)
		{
			YlYIVPDX600PesChuif ylYIVPDX600PesChuif = new YlYIVPDX600PesChuif
			{
				Bottom = 0,
				Left = 0,
				Right = 0,
				Top = 0
			};
			int num = 0;
			if (akDJeEFRLeKfy9Jet7CI != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				YlYIVPDX600PesChuif ylYIVPDX600PesChuif_ = ylYIVPDX600PesChuif;
				return gk8LMG7aDFr(windowInteropHelper.Handle, ref ylYIVPDX600PesChuif_) == 0;
			}
			}
		}
		return false;
	}

	public static void SetRoundCorner(Window window)
	{
		if (NativeMethods.DwmIsCompositionEnabled())
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
			int int_ = 2;
			hevLMkcL0WL(windowInteropHelper.Handle, 33, ref int_, 4);
			NativeMethods.DWM_BLURBEHIND blurBehind = new NativeMethods.DWM_BLURBEHIND
			{
				fEnable = true,
				dwFlags = NativeMethods.DWM_BB.DWM_BB_ENABLE,
				hRgnBlur = IntPtr.Zero
			};
			NativeMethods.DwmEnableBlurBehindWindow(windowInteropHelper.Handle, ref blurBehind);
		}
	}

	public static void SetRoundCornerMode(Window window, int cornerMode)
	{
		if (NativeMethods.DwmIsCompositionEnabled())
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(window);
			int int_ = cornerMode;
			hevLMkcL0WL(windowInteropHelper.Handle, 33, ref int_, 4);
		}
	}

	static DwmDropShadow()
	{
		Gn9LM1U4EX0 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool bu1TkmFRuHnsJZrWMSNc()
	{
		return akDJeEFRLeKfy9Jet7CI == null;
	}
}
