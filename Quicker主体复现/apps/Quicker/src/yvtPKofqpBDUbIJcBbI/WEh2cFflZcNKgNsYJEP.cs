using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using HandyControl.Tools;

namespace yvtPKofqpBDUbIJcBbI;

internal class WEh2cFflZcNKgNsYJEP
{
	public class rGTrSyDCFyrsSN5pBCD
	{
		private static rGTrSyDCFyrsSN5pBCD fELucayKreBPVKUrgVjO;

		[DllImport("shell32", CallingConvention = CallingConvention.StdCall, EntryPoint = "SHAppBarMessage")]
		public static extern uint yqq2uDGIblH(int int_0, ref fANCSXDIGmHdt3ajbiQ fANCSXDIGmHdt3ajbiQ_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterWindowMessage")]
		public static extern int jlZ2ud1PcLe(string string_0);

		[DllImport("user32.dll", EntryPoint = "GetShellWindow")]
		public static extern IntPtr jvr2uoldEOd();

		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		public static extern IntPtr CDN2uTfPJxs();

		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		public static extern IntPtr HO12uM7kQOV();

		internal static bool cpTuyayKNbDE72nfZUvT()
		{
			return fELucayKreBPVKUrgVjO == null;
		}
	}

	public struct DjaObHDr3JHRVHxNwyL
	{
		public int SET2uAiL0Dh;

		public int j8a2uOiyf3I;

		public int LaB2uFYVs3r;

		public int JrJ2uU4CXs8;
	}

	public struct fANCSXDIGmHdt3ajbiQ
	{
		public int v4v2ulGpIPy;

		public IntPtr PK32uicSCYO;

		public int U7r2u3bOY9r;

		public int ORe2ufMOZf8;

		public DjaObHDr3JHRVHxNwyL gN02uzOXkXl;

		public IntPtr gCT2Nw6RkFQ;
	}

	public enum MRP4MyDGSweuIBoyHkl
	{

	}

	public enum BYbc9ODLT3piEcnptKc
	{

	}

	public enum jC8BdKDperqgH7lybbZ
	{

	}

	private static WEh2cFflZcNKgNsYJEP HafLlt8iJZ2;

	public bool i5oLlgPSJ91;

	private IntPtr j6VLlLNhADO;

	private IntPtr zthLlvqt9tm;

	[CompilerGenerated]
	private IntPtr EnMLlSJVwtp;

	[CompilerGenerated]
	private int xXjLl257HDZ;

	internal static WEh2cFflZcNKgNsYJEP T0vrYwFUS32M8i7iUInc;

	[SpecialName]
	public static WEh2cFflZcNKgNsYJEP xqJLUFgYj50()
	{
		if (HafLlt8iJZ2 == null)
		{
			HafLlt8iJZ2 = new WEh2cFflZcNKgNsYJEP();
		}
		return HafLlt8iJZ2;
	}

	private WEh2cFflZcNKgNsYJEP()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr oOsLUlPAPPd()
	{
		return EnMLlSJVwtp;
	}

	[SpecialName]
	[CompilerGenerated]
	public void RISLUifdU1w(IntPtr intptr_3)
	{
		EnMLlSJVwtp = intptr_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int X0oLUfw3xOA()
	{
		return xXjLl257HDZ;
	}

	[SpecialName]
	[CompilerGenerated]
	public void dBELUzJHBiP(int int_1)
	{
		xXjLl257HDZ = int_1;
	}

	public void rDrLUA0dkhn(Window window_0, bool bool_1)
	{
		fANCSXDIGmHdt3ajbiQ fANCSXDIGmHdt3ajbiQ_ = default(fANCSXDIGmHdt3ajbiQ);
		fANCSXDIGmHdt3ajbiQ_.v4v2ulGpIPy = Marshal.SizeOf(fANCSXDIGmHdt3ajbiQ_);
		fANCSXDIGmHdt3ajbiQ_.PK32uicSCYO = window_0.GetHandle();
		j6VLlLNhADO = rGTrSyDCFyrsSN5pBCD.CDN2uTfPJxs();
		zthLlvqt9tm = rGTrSyDCFyrsSN5pBCD.jvr2uoldEOd();
		if (bool_1)
		{
			dBELUzJHBiP(rGTrSyDCFyrsSN5pBCD.jlZ2ud1PcLe("APPBARMSG_QUICKER_FULLSCREEN_MONITOR"));
			if (!xSw4bvFUwe9b3gV34k4B())
			{
				switch (0)
				{
				}
			}
			fANCSXDIGmHdt3ajbiQ_.U7r2u3bOY9r = X0oLUfw3xOA();
			rGTrSyDCFyrsSN5pBCD.yqq2uDGIblH(0, ref fANCSXDIGmHdt3ajbiQ_);
		}
		else
		{
			rGTrSyDCFyrsSN5pBCD.yqq2uDGIblH(1, ref fANCSXDIGmHdt3ajbiQ_);
		}
	}

	public void YkoLUOZymWL(IntPtr intptr_3, IntPtr intptr_4)
	{
		if ((int)intptr_3 != 2)
		{
			return;
		}
		IntPtr intptr_5 = rGTrSyDCFyrsSN5pBCD.HO12uM7kQOV();
		if (!intptr_5.Equals(j6VLlLNhADO) && !intptr_5.Equals(zthLlvqt9tm))
		{
			if ((int)intptr_4 == 1)
			{
				if (!xSw4bvFUwe9b3gV34k4B())
				{
					switch (0)
					{
					}
				}
				i5oLlgPSJ91 = true;
				RISLUifdU1w(intptr_5);
			}
			else
			{
				i5oLlgPSJ91 = false;
				RISLUifdU1w(IntPtr.Zero);
			}
		}
		else
		{
			i5oLlgPSJ91 = false;
			RISLUifdU1w(IntPtr.Zero);
		}
	}

	internal static bool xSw4bvFUwe9b3gV34k4B()
	{
		return T0vrYwFUS32M8i7iUInc == null;
	}
}
