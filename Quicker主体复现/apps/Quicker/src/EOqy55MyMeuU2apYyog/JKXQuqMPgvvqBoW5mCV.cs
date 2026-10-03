using System;
using System.ComponentModel;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using PInvoke;
using Quicker.Utilities.UI.Wpf;

namespace EOqy55MyMeuU2apYyog;

internal static class JKXQuqMPgvvqBoW5mCV
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public Window MJC2S8I2u05;

		public Window anF2Sa9x7FS;

		public HwndSource SAP2S7X3oIF;

		public TaskCompletionSource<bool?> EYe2SRqH8nG;

		internal static _003C_003Ec__DisplayClass7_0 iLVLqQyE2rtHEC21ofVi;

		internal void eJ42SCmoQuT()
		{
			if (MJC2S8I2u05 != null)
			{
				MJC2S8I2u05.Focus();
			}
			if (anF2Sa9x7FS != null)
			{
				anF2Sa9x7FS.Closed -= tke2SPjDRuY;
				int num = 0;
				if (!fFlQZJyEAR4MsCPs6DZC())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				anF2Sa9x7FS.Closing -= lA22SEpb5l6;
			}
			SAP2S7X3oIF?.RemoveHook(khc2Syfhtye);
			if (MJC2S8I2u05 != null)
			{
				MJC2S8I2u05.Opacity = 1.0;
				MJC2S8I2u05.Tp8LOb1CR0C(true);
			}
		}

		internal void tke2SPjDRuY(object sender, EventArgs e)
		{
			eJ42SCmoQuT();
			if (anF2Sa9x7FS is IMockModalWindow mockModalWindow)
			{
				EYe2SRqH8nG.TrySetResult(mockModalWindow.Result);
			}
			else
			{
				EYe2SRqH8nG.TrySetResult(false);
			}
		}

		internal void lA22SEpb5l6(object sender, CancelEventArgs e)
		{
			MJC2S8I2u05?.Activate();
		}

		internal IntPtr khc2Syfhtye(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
		{
			if (msg != 32)
			{
				return IntPtr.Zero;
			}
			if (lParam.ToInt32() == 33685502)
			{
				if (anF2Sa9x7FS.WindowState == WindowState.Minimized)
				{
					anF2Sa9x7FS.WindowState = WindowState.Normal;
				}
				User32.FLASHWINFO pwfi = new User32.FLASHWINFO
				{
					hwnd = new WindowInteropHelper(anF2Sa9x7FS).Handle,
					uCount = 6,
					dwTimeout = 100,
					dwFlags = User32.FlashWindowFlags.FLASHW_ALL
				};
				int num = 0;
				if (iLVLqQyE2rtHEC21ofVi != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				pwfi.cbSize = Convert.ToInt32(Marshal.SizeOf(pwfi));
				User32.FlashWindowEx(ref pwfi);
				SystemSounds.Asterisk.Play();
			}
			return IntPtr.Zero;
		}

		internal static bool fFlQZJyEAR4MsCPs6DZC()
		{
			return iLVLqQyE2rtHEC21ofVi == null;
		}
	}

	internal static object GjVQiLFPqgn8q6ogOXox;

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern int pubLOsQTX4l(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
	private static extern int T2qLOHZ6QX0(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "FlashWindow")]
	private static extern void ORWLO1B0Bs0(IntPtr intptr_0, bool bool_0);

	private static void Tp8LOb1CR0C(this Window window_0, bool bool_0)
	{
		if (window_0 != null)
		{
			IntPtr handle = new WindowInteropHelper(window_0).Handle;
			T2qLOHZ6QX0(handle, -16, (pubLOsQTX4l(handle, -16) & -134217729) | ((!bool_0) ? 134217728 : 0));
		}
	}

	public static bool HPlLO6b0eIa(this Window window_0)
	{
		return (bool)typeof(Window).GetField("_showingAsDialog", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(window_0);
	}

	public static Task<bool?> MjdLOXIjD10(this Window window_0, bool bool_0)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.anF2Sa9x7FS = window_0;
		_003C_003Ec__DisplayClass7_.EYe2SRqH8nG = new TaskCompletionSource<bool?>();
		_003C_003Ec__DisplayClass7_.MJC2S8I2u05 = _003C_003Ec__DisplayClass7_.anF2Sa9x7FS.Owner;
		_003C_003Ec__DisplayClass7_.SAP2S7X3oIF = null;
		if (_003C_003Ec__DisplayClass7_.MJC2S8I2u05 != null)
		{
			_003C_003Ec__DisplayClass7_.SAP2S7X3oIF = PresentationSource.FromVisual(_003C_003Ec__DisplayClass7_.MJC2S8I2u05) as HwndSource;
			_003C_003Ec__DisplayClass7_.SAP2S7X3oIF?.AddHook(_003C_003Ec__DisplayClass7_.khc2Syfhtye);
		}
		try
		{
			_003C_003Ec__DisplayClass7_.MJC2S8I2u05.Tp8LOb1CR0C(false);
			if (_003C_003Ec__DisplayClass7_.MJC2S8I2u05 != null)
			{
				_003C_003Ec__DisplayClass7_.MJC2S8I2u05.Opacity = 0.9;
			}
			_003C_003Ec__DisplayClass7_.anF2Sa9x7FS.Closed += _003C_003Ec__DisplayClass7_.tke2SPjDRuY;
			_003C_003Ec__DisplayClass7_.anF2Sa9x7FS.Closing += _003C_003Ec__DisplayClass7_.lA22SEpb5l6;
			_003C_003Ec__DisplayClass7_.anF2Sa9x7FS.Show();
			if (bool_0)
			{
				_003C_003Ec__DisplayClass7_.anF2Sa9x7FS.Activate();
			}
		}
		catch (Exception)
		{
			_003C_003Ec__DisplayClass7_.eJ42SCmoQuT();
			throw;
		}
		return _003C_003Ec__DisplayClass7_.EYe2SRqH8nG.Task;
	}

	internal static bool Q9Ht1EFPiN82TycntoCY()
	{
		return GjVQiLFPqgn8q6ogOXox == null;
	}
}
