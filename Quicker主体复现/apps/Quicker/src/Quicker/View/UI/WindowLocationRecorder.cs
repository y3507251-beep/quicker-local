using System;
using System.ComponentModel;
using System.Windows;
using HandyControl.Tools;
using Quicker.Utilities.Win32;

namespace Quicker.View.UI;

public class WindowLocationRecorder
{
	private readonly Window ipSL7ypwfKE;

	private string gBiL78cArIn = "";

	private WindowState FylL7aT3MWd;

	internal static WindowLocationRecorder hBykvoF0ufYR3HRUNAek;

	public WindowLocationRecorder(Window window)
	{
		ipSL7ypwfKE = window;
		ipSL7ypwfKE.Loaded += awJL7N4TW5L;
		ipSL7ypwfKE.Closing += A83L7PBnYI8;
		ipSL7ypwfKE.Closed += KpeL7JEnDQA;
		ipSL7ypwfKE.SizeChanged += PYWL70M3Ty6;
		ipSL7ypwfKE.LocationChanged += ghYL7CUyuIH;
	}

	private void awJL7N4TW5L(object sender, RoutedEventArgs e)
	{
		UW6L7E1ybpx();
	}

	private void KpeL7JEnDQA(object sender, EventArgs e)
	{
		ipSL7ypwfKE.Loaded -= awJL7N4TW5L;
		ipSL7ypwfKE.Closed -= KpeL7JEnDQA;
		ipSL7ypwfKE.Closing -= A83L7PBnYI8;
		ipSL7ypwfKE.SizeChanged -= PYWL70M3Ty6;
		ipSL7ypwfKE.LocationChanged -= ghYL7CUyuIH;
	}

	private void PYWL70M3Ty6(object sender, SizeChangedEventArgs e)
	{
		UW6L7E1ybpx();
	}

	private void ghYL7CUyuIH(object sender, EventArgs e)
	{
		UW6L7E1ybpx();
	}

	private void A83L7PBnYI8(object sender, CancelEventArgs e)
	{
		UW6L7E1ybpx();
	}

	public string GetLastLocation()
	{
		return gBiL78cArIn;
	}

	private void UW6L7E1ybpx()
	{
		if (ipSL7ypwfKE.IsLoaded && ipSL7ypwfKE.WindowState == WindowState.Normal)
		{
			NativeMethods.RECT lpRect = default(NativeMethods.RECT);
			NativeMethods.GetWindowRect(ipSL7ypwfKE.GetHandle(), out lpRect);
			if (lpRect.Top >= 0 || lpRect.Left > 0)
			{
				gBiL78cArIn = $"{lpRect.Left},{lpRect.Top},{lpRect.Right},{lpRect.Bottom}";
			}
		}
	}

	internal static bool ej5QiXF0o8aCHycT0AJH()
	{
		return hBykvoF0ufYR3HRUNAek == null;
	}
}
