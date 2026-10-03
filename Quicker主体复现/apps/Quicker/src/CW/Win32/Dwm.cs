using System;
using System.Runtime.InteropServices;

namespace CW.Win32;

public static class Dwm
{
	[DllImport("DwmApi.dll", EntryPoint = "DwmExtendFrameIntoClientArea")]
	public static extern int ExtendFrameIntoClientArea(IntPtr hwnd, Margins pMarInset);

	[DllImport("DwmApi.dll", EntryPoint = "DwmEnableBlurBehindWindow")]
	public static extern int EnableBlurBehindWindow(IntPtr hWnd, DwmBlurBehind pBlurBehind);
}
