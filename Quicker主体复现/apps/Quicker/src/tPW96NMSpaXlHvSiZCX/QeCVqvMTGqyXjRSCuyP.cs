using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using log4net;
using Quicker.Domain;
using Quicker.Utilities;

namespace tPW96NMSpaXlHvSiZCX;

internal static class QeCVqvMTGqyXjRSCuyP
{
	public struct pdEnwnDkY5E9cbe81kn
	{
		public int i5t2SVJ3t1w;

		public int poG2SZXCtRL;

		public IntPtr WuP2S9m2UrG;

		public IntPtr clv2Sh9YG0m;

		public IntPtr c8g2Sefd8Xy;

		public IntPtr K322SY9AJE1;

		public IntPtr mvc2SIAhQJD;

		public IntPtr prC2SWDJ1F4;

		public Rectangle TAq2SkIY7sB;
	}

	private static readonly ILog zPxLFC44BdY;

	internal static object HxaZ4NFM2nOZsxKjs1hI;

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	private static extern IntPtr C7gLFtT1K5i();

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	private static extern uint qsELFgTiEtC(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
	private static extern IntPtr GV6LFLdqQF1(uint uint_0);

	[DllImport("user32.dll")]
	private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("imm32.dll", EntryPoint = "ImmGetDefaultIMEWnd")]
	private static extern IntPtr KtqLFvKJJYe(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
	private static extern bool TLbLFSp5XJ0(uint uint_0, ref pdEnwnDkY5E9cbe81kn pdEnwnDkY5E9cbe81kn_0);

	public static bool hF7LF2kDefY()
	{
		IntPtr intPtr = Jp8LF0y9TND();
		if (intPtr == IntPtr.Zero)
		{
			zPxLFC44BdY.Warn("无法获取输入法状态：GetImeWnd返回空值。");
			return false;
		}
		if (SendMessage(intPtr, 643u, (IntPtr)5, IntPtr.Zero) == 0)
		{
			return false;
		}
		return SendMessage(intPtr, 643u, (IntPtr)1, IntPtr.Zero) != 0;
	}

	public static void bc0LFuNtAhp(bool bool_0)
	{
		if (bool_0 && !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().ImeToZhHotkey))
		{
			AppHelper.SendHotkey(AppState.HHxtaMaoqJr().ImeToZhHotkey);
			return;
		}
		if (!bool_0 && !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().ImeToEnHotkey))
		{
			AppHelper.SendHotkey(AppState.HHxtaMaoqJr().ImeToEnHotkey);
			return;
		}
		IntPtr intPtr = Jp8LF0y9TND();
		if (!(intPtr == IntPtr.Zero))
		{
			if (HxaZ4NFM2nOZsxKjs1hI != null)
			{
				switch (0)
				{
				}
			}
			SendMessage(intPtr, 643u, (IntPtr)6, (IntPtr)(bool_0 ? 1 : 0));
			SendMessage(intPtr, 643u, (IntPtr)2, (IntPtr)(bool_0 ? 1025 : 0));
		}
		else
		{
			zPxLFC44BdY.Warn("无法更新输入法状态，未找到ImeWindow");
		}
	}

	public static bool HjPLFNlY29G()
	{
		bool num = !hF7LF2kDefY();
		bc0LFuNtAhp(num);
		return num;
	}

	public static void mYRLFJN7ARU(int int_0 = 0)
	{
		IntPtr hWnd = Jp8LF0y9TND();
		if (SendMessage(hWnd, 643u, (IntPtr)5, IntPtr.Zero) != 0)
		{
			SendMessage(hWnd, 643u, (IntPtr)2, (IntPtr)0);
		}
	}

	private static IntPtr Jp8LF0y9TND()
	{
		pdEnwnDkY5E9cbe81kn pdEnwnDkY5E9cbe81kn_ = default(pdEnwnDkY5E9cbe81kn);
		pdEnwnDkY5E9cbe81kn_.i5t2SVJ3t1w = Marshal.SizeOf(pdEnwnDkY5E9cbe81kn_);
		IntPtr intPtr = C7gLFtT1K5i();
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		uint num = qsELFgTiEtC(intPtr, IntPtr.Zero);
		if (num == 0)
		{
			return IntPtr.Zero;
		}
		if (!TLbLFSp5XJ0(num, ref pdEnwnDkY5E9cbe81kn_))
		{
			return IntPtr.Zero;
		}
		return KtqLFvKJJYe(pdEnwnDkY5E9cbe81kn_.clv2Sh9YG0m);
	}

	static QeCVqvMTGqyXjRSCuyP()
	{
		zPxLFC44BdY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool rhCVTMFMAbYZRs6JHyXM()
	{
		return HxaZ4NFM2nOZsxKjs1hI == null;
	}

	internal static void rV7bROFMDA2JhJrS5NaI()
	{
	}
}
