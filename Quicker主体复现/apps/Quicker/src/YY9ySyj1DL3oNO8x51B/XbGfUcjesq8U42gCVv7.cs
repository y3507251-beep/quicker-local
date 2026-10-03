using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YY9ySyj1DL3oNO8x51B;

internal class XbGfUcjesq8U42gCVv7
{
	private static readonly Guid VwGtINj3XjZ;

	private static readonly Guid rePtIJc2Rw5;

	internal static XbGfUcjesq8U42gCVv7 vMS1NLQOlg1ENgkCPSJP;

	[SpecialName]
	public static string nvktIvIgYbN()
	{
		return aZstIgl01eU(VwGtINj3XjZ);
	}

	[SpecialName]
	public static string tJYtI27SXtW()
	{
		return aZstIgl01eU(rePtIJc2Rw5);
	}

	public static string aZstIgl01eU(Guid guid_2)
	{
		IntPtr intptr_ = IntPtr.Zero;
		string text = null;
		try
		{
			int num = KoTtILODqye(guid_2, 0u, IntPtr.Zero, out intptr_);
			if (num != 0)
			{
				throw Marshal.GetExceptionForHR(num);
			}
			return Marshal.PtrToStringUni(intptr_);
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intptr_);
				intptr_ = IntPtr.Zero;
			}
		}
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "SHGetKnownFolderPath", SetLastError = true)]
	private static extern int KoTtILODqye([MarshalAs(UnmanagedType.LPStruct)] Guid guid_2, uint uint_0, IntPtr intptr_0, out IntPtr intptr_1);

	static XbGfUcjesq8U42gCVv7()
	{
		VwGtINj3XjZ = new Guid("F1B32785-6FBA-4FCF-9D55-7B8E7F157091");
		rePtIJc2Rw5 = new Guid("A520A1A4-1780-4FF6-BD18-167343C5AF16");
	}

	internal static bool xPTVSIQOZCbxag4DTBf2()
	{
		return vMS1NLQOlg1ENgkCPSJP == null;
	}

	internal static void Rhc8eQQOYcslwKJvwr0k()
	{
	}
}
