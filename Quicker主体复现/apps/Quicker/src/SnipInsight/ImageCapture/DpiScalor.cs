using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using jeaU1l2eVVj4W2gaVc;
using Quicker.Domain;

namespace SnipInsight.ImageCapture;

public static class DpiScalor
{
	internal static object O3wOTSyBem2Hy6VUcnr;

	public static double GetScreenScalingFactor(string deviceName = null)
	{
		IntPtr intPtr = OO77uFW4jgnwuPwqBc.v6ct34MHW3("DISPLAY", deviceName, null, IntPtr.Zero);
		if (!(intPtr == IntPtr.Zero))
		{
			int num = OO77uFW4jgnwuPwqBc.OX3tzoM4et(intPtr, 10);
			double result = (double)OO77uFW4jgnwuPwqBc.OX3tzoM4et(intPtr, 117) / (double)num;
			OO77uFW4jgnwuPwqBc.MNjtf6Dtq0(intPtr);
			return result;
		}
		return 1.0;
	}

	public static DpiScalors GetScalor()
	{
		return GetScalor(AppState.HS2taepcAbc());
	}

	public static DpiScalors GetScalor(Window window)
	{
		DpiScalors dpiScalors = null;
		try
		{
			PresentationSource presentationSource = PresentationSource.FromVisual(window);
			Matrix transformToDevice;
			if (presentationSource != null)
			{
				transformToDevice = presentationSource.CompositionTarget.TransformToDevice;
			}
			else
			{
				HwndSourceParameters parameters = default(HwndSourceParameters);
				int num = 0;
				if (!ka5EeryvERnNEpp5keY())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				using HwndSource hwndSource = new HwndSource(parameters);
				transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
			}
			dpiScalors = new DpiScalors();
			dpiScalors.X = transformToDevice.M11;
			dpiScalors.Y = transformToDevice.M22;
		}
		catch (Exception)
		{
		}
		return dpiScalors;
	}

	internal static bool ka5EeryvERnNEpp5keY()
	{
		return O3wOTSyBem2Hy6VUcnr == null;
	}
}
