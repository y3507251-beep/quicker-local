using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace Quicker.View;

public class AppWindowBase : Window
{
	internal static AppWindowBase Hl21bEQzJtJNdGE3ZPOU;

	[DllImport("DwmApi", EntryPoint = "DwmSetWindowAttribute")]
	private static extern int VZOgQmL7EpT(IntPtr intptr_0, int int_0, int[] int_1, int int_2);

	protected override void OnSourceInitialized(EventArgs e)
	{
		base.OnSourceInitialized(e);
		IntPtr handle = new WindowInteropHelper(this).Handle;
		if (VZOgQmL7EpT(handle, 19, new int[1] { 1 }, 4) != 0)
		{
			VZOgQmL7EpT(handle, 20, new int[1] { 1 }, 4);
		}
	}

	internal static bool U7oVoFQzkvW5Fl582rrV()
	{
		return Hl21bEQzJtJNdGE3ZPOU == null;
	}
}
