using System;
using System.Runtime.InteropServices;

namespace oZ2JqH51hKk9IEXwhPZ;

internal class L1wn5K5eLwUyw5guJ3E
{
	private static int bhBxW52Owa;

	private static int ExYxkWs9mQ;

	private static int TPuxGrgq5f;

	private static L1wn5K5eLwUyw5guJ3E byRKRDISEMW9qVcBRqx;

	[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
	public static extern int PmMxZ5nVq9(int int_3, int int_4, IntPtr intptr_0, int int_5);

	[DllImport("kernel32.dll", EntryPoint = "GetLastError")]
	public static extern int flux9kyZFP();

	public static void CcIxhiTkSP()
	{
		ExYxkWs9mQ = kPIxY7sMtM();
	}

	public static void lQrxecFxJZ()
	{
		if (ExYxkWs9mQ == 20)
		{
			XrsxIaSLSu(bhBxW52Owa);
		}
		else if (ExYxkWs9mQ < 10)
		{
			XrsxIaSLSu(bhBxW52Owa);
		}
	}

	public static int kPIxY7sMtM()
	{
		IntPtr intPtr = Marshal.AllocCoTaskMem(4);
		PmMxZ5nVq9(112, 0, intPtr, 0);
		int result = Marshal.ReadInt32(intPtr);
		Marshal.FreeCoTaskMem(intPtr);
		return result;
	}

	public static void XrsxIaSLSu(int int_3)
	{
		IntPtr intptr_ = new IntPtr(int_3);
		if (PmMxZ5nVq9(113, 0, intptr_, 0) != 0)
		{
		}
	}

	static L1wn5K5eLwUyw5guJ3E()
	{
		bhBxW52Owa = 10;
	}

	internal static bool t8T3mPIwqlybdgtBSPK()
	{
		return byRKRDISEMW9qVcBRqx == null;
	}
}
