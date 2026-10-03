using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace doOYFIfAng8uHfpsuw4;

internal class vTUu1Lf5xGyKvteAoVZ
{
	public struct eRomYBDakkgVLUlAlaj
	{
		public IntPtr UiC2Nt9d2jP;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
		public char[] w912NgC30Fs;
	}

	public struct I8kVMfDzi0CZ7Dkm3ib
	{
		private int x;

		private int tID2NLXxBeV;
	}

	private static vTUu1Lf5xGyKvteAoVZ WAgblrFUmX7jfmpC5a6X;

	[DllImport("user32.dll", EntryPoint = "GetCursorPos", SetLastError = true)]
	private static extern bool YgHLluZkLLx(out I8kVMfDzi0CZ7Dkm3ib i8kVMfDzi0CZ7Dkm3ib_0);

	[DllImport("user32.dll", EntryPoint = "MonitorFromPoint")]
	private static extern IntPtr HEALlN5nANG(I8kVMfDzi0CZ7Dkm3ib i8kVMfDzi0CZ7Dkm3ib_0, uint uint_0);

	[DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR", SetLastError = true)]
	private static extern bool rRALlJ88ATM(IntPtr intptr_0, uint uint_0, [Out] eRomYBDakkgVLUlAlaj[] eRomYBDakkgVLUlAlaj_0);

	[DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR", SetLastError = true)]
	private static extern bool cVQLl0LY2JJ(IntPtr intptr_0, out uint uint_0);

	[DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors", SetLastError = true)]
	private static extern bool HeCLlCDedWJ(uint uint_0, eRomYBDakkgVLUlAlaj[] eRomYBDakkgVLUlAlaj_0);

	[DllImport("dxva2.dll", EntryPoint = "GetMonitorCapabilities", SetLastError = true)]
	private static extern bool xDbLlPyQoMO(IntPtr intptr_0, out uint uint_0, out uint uint_1);

	[DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness", SetLastError = true)]
	private static extern bool SAALlEFJBL5(IntPtr intptr_0, out uint uint_0, out uint uint_1, out uint uint_2);

	[DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness", SetLastError = true)]
	private static extern bool asALlyn9SqP(IntPtr intptr_0, uint uint_0);

	[DllImport("dxva2.dll", EntryPoint = "GetMonitorContrast", SetLastError = true)]
	private static extern bool aUtLl8q5dnp(IntPtr intptr_0, out uint uint_0, out uint uint_1, out uint uint_2);

	[DllImport("dxva2.dll", EntryPoint = "SetMonitorContrast", SetLastError = true)]
	private static extern bool ffALlaG347C(IntPtr intptr_0, uint uint_0);

	public static IntPtr VqOLl7WYkK7()
	{
		I8kVMfDzi0CZ7Dkm3ib i8kVMfDzi0CZ7Dkm3ib_ = default(I8kVMfDzi0CZ7Dkm3ib);
		if (!YgHLluZkLLx(out i8kVMfDzi0CZ7Dkm3ib_))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return HEALlN5nANG(i8kVMfDzi0CZ7Dkm3ib_, 2u);
	}

	public static eRomYBDakkgVLUlAlaj[] GKALlR3TRWA(IntPtr intptr_0)
	{
		if (!cVQLl0LY2JJ(intptr_0, out var uint_))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		eRomYBDakkgVLUlAlaj[] array = new eRomYBDakkgVLUlAlaj[uint_];
		if (!rRALlJ88ATM(intptr_0, uint_, array))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return array;
	}

	public static void TyLLlqIut6g(eRomYBDakkgVLUlAlaj[] eRomYBDakkgVLUlAlaj_0)
	{
		if (!HeCLlCDedWJ((uint)eRomYBDakkgVLUlAlaj_0.Length, eRomYBDakkgVLUlAlaj_0))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	private static uint LZvLlcoQl1n(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0)
	{
		if (!xDbLlPyQoMO(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, out var uint_, out var uint_2))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return uint_;
	}

	public static bool FoDLlV2qSFS(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0)
	{
		return (LZvLlcoQl1n(eRomYBDakkgVLUlAlaj_0) & 2) != 0;
	}

	public static bool PN7LlZRfB3Q(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0)
	{
		return (LZvLlcoQl1n(eRomYBDakkgVLUlAlaj_0) & 4) != 0;
	}

	public static double sGILl9mBe7q(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0)
	{
		if (!SAALlEFJBL5(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, out var uint_, out var uint_2, out var uint_3))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return (double)(uint_2 - uint_) / (double)(uint_3 - uint_);
	}

	public static void KwtLlhadrO1(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0, double double_0)
	{
		if (!SAALlEFJBL5(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, out var uint_, out var uint_2, out var uint_3))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!asALlyn9SqP(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, (uint)((double)uint_ + (double)(uint_3 - uint_) * double_0)))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	public static double OVnLle0Paue(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0)
	{
		if (!aUtLl8q5dnp(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, out var uint_, out var uint_2, out var uint_3))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return (double)(uint_2 - uint_) / (double)(uint_3 - uint_);
	}

	public static void zmFLlYenJYG(eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_0, double double_0)
	{
		if (!aUtLl8q5dnp(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, out var uint_, out var uint_2, out var uint_3))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!ffALlaG347C(eRomYBDakkgVLUlAlaj_0.UiC2Nt9d2jP, (uint)((double)uint_ + (double)(uint_3 - uint_) * double_0)))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	internal static bool VcYnPoFUsbY086pyZQ40()
	{
		return WAgblrFUmX7jfmpC5a6X == null;
	}
}
