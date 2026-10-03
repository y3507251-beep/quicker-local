using System;
using System.Runtime.InteropServices;

namespace CW.Win32;

[Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class DwmBlurBehind
{
	[Serializable]
	[Flags]
	private enum NOITXddYJ2vbkI7PxOA
	{
		None = 0
	}

	private NOITXddYJ2vbkI7PxOA IPBCvxp47L;

	private bool g86CSIlKNu;

	private IntPtr kdKC2T0AVI;

	private bool sXQCuGKZKv;

	private static DwmBlurBehind XT7kUbGoAmXMFDhwEoF;

	public bool Enabled
	{
		get
		{
			return g86CSIlKNu;
		}
		set
		{
			g86CSIlKNu = value;
			if (value)
			{
				IPBCvxp47L |= (NOITXddYJ2vbkI7PxOA)1;
			}
			else
			{
				IPBCvxp47L ^= IPBCvxp47L & (NOITXddYJ2vbkI7PxOA)1;
			}
		}
	}

	public bool TransitionOnMaximized
	{
		get
		{
			return sXQCuGKZKv;
		}
		set
		{
			sXQCuGKZKv = value;
			if (!value)
			{
				IPBCvxp47L ^= IPBCvxp47L & (NOITXddYJ2vbkI7PxOA)4;
			}
			else
			{
				IPBCvxp47L |= (NOITXddYJ2vbkI7PxOA)4;
			}
		}
	}

	public IntPtr Region
	{
		get
		{
			return kdKC2T0AVI;
		}
		set
		{
			kdKC2T0AVI = value;
			if (value != IntPtr.Zero)
			{
				IPBCvxp47L |= (NOITXddYJ2vbkI7PxOA)2;
			}
			else
			{
				IPBCvxp47L ^= IPBCvxp47L & (NOITXddYJ2vbkI7PxOA)2;
			}
		}
	}

	static DwmBlurBehind()
	{
	}

	internal static bool y1WRfWGfUJo0uPp8Lke()
	{
		return XT7kUbGoAmXMFDhwEoF == null;
	}

	internal static void NG9WpPGqktFIYThuGvF()
	{
	}
}
