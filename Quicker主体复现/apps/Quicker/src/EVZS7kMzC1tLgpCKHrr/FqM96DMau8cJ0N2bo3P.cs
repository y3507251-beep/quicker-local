using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Bx5KVGMpLudaT3Vsr6r;
using Quicker.Utilities.Win32;
using SHDocVw;

namespace EVZS7kMzC1tLgpCKHrr;

internal static class FqM96DMau8cJ0N2bo3P
{
	public enum sLgwvPDtXQfR6vUpcmv
	{

	}

	[ComImport]
	[Guid("6d5140c1-7436-11ce-8034-00aa006009fa")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface ngnWZRDxDoSRTod0rOA
	{
		[PreserveSig]
		sLgwvPDtXQfR6vUpcmv QueryService(ref Guid guidService, ref Guid riid, out IntPtr ppvObject);
	}

	private static object k7b5jnFUPcQooMe6ZGIS;

	public static IList<string> amdLU5o6tDo()
	{
		List<string> list = new List<string>();
		foreach (object item in (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39"))))
		{
			if (!(item is InternetExplorer internetExplorer))
			{
				Marshal.ReleaseComObject(item);
				continue;
			}
			if (!internetExplorer.FullName.ToLower().Contains("explorer.exe"))
			{
				Marshal.ReleaseComObject(internetExplorer);
				continue;
			}
			list.Add(kEgLUDOWK7r(internetExplorer.LocationURL));
			Marshal.ReleaseComObject(internetExplorer);
		}
		return list;
	}

	private static string kEgLUDOWK7r(string string_0)
	{
		return string_0.Replace("file:///", "").Replace("/", "\\");
	}

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	private static extern IntPtr el0LUdxTtqv();

	[DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
	public static extern IntPtr ictLUo5nDs3(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	public static string ryeLUTbBGGD(IntPtr intptr_0)
	{
		IntPtr intPtr = ictLUo5nDs3(intptr_0, IntPtr.Zero, "ShellTabWindowClass", null);
		if (intPtr == IntPtr.Zero)
		{
			int num = 0;
			if (!vcKnATFUMrEs2hnPo9Wt())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			intPtr = OpenWindowGetter.FindChildWindow(intptr_0, "ShellTabWindowClass", null);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("ERROR:不是资源管理器窗口，未找到ShellTabWindowClass窗格。");
			}
		}
		Guid iid = new Guid("6d5140c1-7436-11ce-8034-00aa006009fa");
		Guid guidService = new Guid("000214E2-0000-0000-C000-000000000046");
		Guid riid = new Guid("000214E2-0000-0000-C000-000000000046");
		int num4 = default(int);
		foreach (object item in (ShellWindows)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39"))))
		{
			if (!(item is InternetExplorer internetExplorer))
			{
				Marshal.ReleaseComObject(item);
				continue;
			}
			if (!internetExplorer.FullName.ToLower().Contains("explorer.exe"))
			{
				Marshal.ReleaseComObject(internetExplorer);
				int num3 = 0;
				if (k7b5jnFUPcQooMe6ZGIS != null)
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				continue;
			}
			if (internetExplorer.HWND != (long)intptr_0)
			{
				Marshal.ReleaseComObject(internetExplorer);
				continue;
			}
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr ppv = IntPtr.Zero;
			IntPtr ppvObject = IntPtr.Zero;
			try
			{
				intPtr2 = Marshal.GetIUnknownForObject(internetExplorer);
				Marshal.QueryInterface(intPtr2, ref iid, out ppv);
				if (!(ppv == IntPtr.Zero) && ((ngnWZRDxDoSRTod0rOA)Marshal.GetTypedObjectForIUnknown(ppv, typeof(ngnWZRDxDoSRTod0rOA))).QueryService(ref guidService, ref riid, out ppvObject) == (sLgwvPDtXQfR6vUpcmv)0 && ppvObject != IntPtr.Zero)
				{
					((bPkZl9MLR2X9Cd6jq5M.Y0k5KHDs1WwZDyDSZPV)Marshal.GetTypedObjectForIUnknown(ppvObject, typeof(bPkZl9MLR2X9Cd6jq5M.Y0k5KHDs1WwZDyDSZPV))).GetWindow(out var intptr_1);
					if (intptr_1 == intPtr)
					{
						return kEgLUDOWK7r(internetExplorer.LocationURL);
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (ppvObject != IntPtr.Zero)
				{
					Marshal.Release(ppvObject);
				}
				if (ppv != IntPtr.Zero)
				{
					Marshal.Release(ppv);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.Release(intPtr2);
				}
			}
		}
		return null;
	}

	public static InternetExplorer SR4LUMEPFYW(IntPtr intptr_0, IList<InternetExplorer> ilist_0)
	{
		IntPtr intPtr = ictLUo5nDs3(intptr_0, IntPtr.Zero, "ShellTabWindowClass", null);
		if (intPtr == IntPtr.Zero)
		{
			throw new Exception("ERROR:不是资源管理器窗口，未找到ShellTabWindowClass窗格。");
		}
		Guid iid = new Guid("6d5140c1-7436-11ce-8034-00aa006009fa");
		Guid guidService = new Guid("000214E2-0000-0000-C000-000000000046");
		Guid riid = new Guid("000214E2-0000-0000-C000-000000000046");
		foreach (InternetExplorer item in ilist_0)
		{
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr ppv = IntPtr.Zero;
			IntPtr ppvObject = IntPtr.Zero;
			try
			{
				intPtr2 = Marshal.GetIUnknownForObject(item);
				Marshal.QueryInterface(intPtr2, ref iid, out ppv);
				if (!(ppv == IntPtr.Zero) && ((ngnWZRDxDoSRTod0rOA)Marshal.GetTypedObjectForIUnknown(ppv, typeof(ngnWZRDxDoSRTod0rOA))).QueryService(ref guidService, ref riid, out ppvObject) == (sLgwvPDtXQfR6vUpcmv)0 && ppvObject != IntPtr.Zero)
				{
					((bPkZl9MLR2X9Cd6jq5M.Y0k5KHDs1WwZDyDSZPV)Marshal.GetTypedObjectForIUnknown(ppvObject, typeof(bPkZl9MLR2X9Cd6jq5M.Y0k5KHDs1WwZDyDSZPV))).GetWindow(out var intptr_1);
					if (intptr_1 == intPtr)
					{
						return item;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (ppvObject != IntPtr.Zero)
				{
					Marshal.Release(ppvObject);
				}
				if (ppv != IntPtr.Zero)
				{
					Marshal.Release(ppv);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.Release(intPtr2);
				}
			}
		}
		return null;
	}

	internal static bool vcKnATFUMrEs2hnPo9Wt()
	{
		return k7b5jnFUPcQooMe6ZGIS == null;
	}
}
