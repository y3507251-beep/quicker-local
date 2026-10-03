using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PPX3CDMJHNv8RxgxHm3;

internal class dZnrTDMKnfykVqF8Pjr
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct FL0gIDDhCtJ5oF2MsK7
	{
		public IntPtr BDZ2S11OaoV;

		public int jm82SbdZbu6;

		public uint r0Z2S6UqclZ;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string kRC2SXI7lYb;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string Kin2Smvr5dr;
	}

	public struct mNcI5DD86pjtV3pKQVZ
	{
		private int lZg2SQ3qlQ8;

		internal static object bLeumEyE8903h9LNdl6D;

		public int Value => lZg2SQ3qlQ8;

		public Exception Exception => Marshal.GetExceptionForHR(lZg2SQ3qlQ8);

		public bool IsSuccess => lZg2SQ3qlQ8 >= 0;

		[SpecialName]
		public bool ylW2Sp3Vf1E()
		{
			return lZg2SQ3qlQ8 < 0;
		}

		internal static bool WlNgtjyER662xHaFBZFW()
		{
			return bLeumEyE8903h9LNdl6D == null;
		}
	}

	internal static dZnrTDMKnfykVqF8Pjr rlkmm2FMdaUJhIeBH5CE;

	public static string A9xLF7T2CPg(Environment.SpecialFolder specialFolder_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			if (el8LFq60xS5(IntPtr.Zero, (int)specialFolder_0, IntPtr.Zero, 0, out intptr_).ylW2Sp3Vf1E())
			{
				return null;
			}
			if (TD3LFR3qQmF(intptr_, 128u, out var fl0gIDDhCtJ5oF2MsK7_, (uint)Marshal.SizeOf(typeof(FL0gIDDhCtJ5oF2MsK7)), 520u) != 0)
			{
				return fl0gIDDhCtJ5oF2MsK7_.kRC2SXI7lYb;
			}
			return null;
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				VAXLFcYqOLn(intptr_);
			}
		}
	}

	[DllImport("shell32", CharSet = CharSet.Auto, EntryPoint = "SHGetFileInfo")]
	private static extern int TD3LFR3qQmF(IntPtr intptr_0, uint uint_0, out FL0gIDDhCtJ5oF2MsK7 fl0gIDDhCtJ5oF2MsK7_0, uint uint_1, uint uint_2);

	[DllImport("shell32", CharSet = CharSet.Auto, EntryPoint = "SHGetFolderLocation")]
	private static extern mNcI5DD86pjtV3pKQVZ el8LFq60xS5(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1, out IntPtr intptr_2);

	[DllImport("shell32", CharSet = CharSet.Auto, EntryPoint = "ILFree")]
	private static extern void VAXLFcYqOLn(IntPtr intptr_0);

	internal static bool owBKJlFMOab1RjFjM3PC()
	{
		return rlkmm2FMdaUJhIeBH5CE == null;
	}
}
