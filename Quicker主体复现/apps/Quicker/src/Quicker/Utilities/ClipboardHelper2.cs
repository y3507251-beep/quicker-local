using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using qcrGlGMkgcYtX0leyxF;

namespace Quicker.Utilities;

public class ClipboardHelper2
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public string zkeSzQIyb0K;

		private static _003C_003Ec__DisplayClass23_0 HXJbxgyn0oNdJ3fOc9Sa;

		internal void o0ySzBbrLPq()
		{
			zkeSzQIyb0K = GetASCIITextInternal();
		}

		internal static void pypNu1ynBw7sw1KNB11S()
		{
		}

		internal static bool uMPIWgyn197L81qcoMvH()
		{
			return HXJbxgyn0oNdJ3fOc9Sa == null;
		}
	}

	public const int WM_CLIPBOARDUPDATE = 797;

	public const int WM_DRAWCLIPBOARD = 776;

	private static ClipboardHelper2 zB4ibBF5NpYWcGcCHUbE;

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AddClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll")]
	public static extern IntPtr GetClipboardOwner();

	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr handle, out uint threadid);

	[DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow", SetLastError = true)]
	private static extern IntPtr imULoImg7tG();

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EmptyClipboard();

	[DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool Dl6LoWsctGh(uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetClipboardData(uint uFormat);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll", EntryPoint = "CloseClipboard", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool St9LokO6A4h();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GlobalLock(IntPtr hMem);

	[DllImport("kernel32.dll", EntryPoint = "GlobalUnlock", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool sSKLoGH4MA7(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GlobalAlloc(uint uFlags, int dwBytes);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int GlobalSize(IntPtr hMem);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

	public static string GetUnicodeText()
	{
		return CEqLosA5mZT();
	}

	private static string CEqLosA5mZT()
	{
		if (!Dl6LoWsctGh(13u))
		{
			return null;
		}
		try
		{
			if (OpenClipboard(IntPtr.Zero))
			{
				IntPtr clipboardData = GetClipboardData(13u);
				if (clipboardData == IntPtr.Zero)
				{
					if (Qt2bbUF59sJfUrddVq9X())
					{
						switch (0)
						{
						}
					}
					return null;
				}
				IntPtr intPtr = IntPtr.Zero;
				try
				{
					intPtr = GlobalLock(clipboardData);
					if (intPtr == IntPtr.Zero)
					{
						return null;
					}
					return Marshal.PtrToStringUni(intPtr);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						sSKLoGH4MA7(clipboardData);
					}
				}
			}
			return null;
		}
		finally
		{
			St9LokO6A4h();
		}
	}

	public static string GetASCIIText()
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.zkeSzQIyb0K = "";
		GaZT3MMHZ3eZxDOySux.sL2LMlMVkZs(_003C_003Ec__DisplayClass23_.o0ySzBbrLPq);
		return _003C_003Ec__DisplayClass23_.zkeSzQIyb0K;
	}

	public static string GetASCIITextInternal()
	{
		if (!Dl6LoWsctGh(13u))
		{
			return null;
		}
		try
		{
			if (!OpenClipboard(IntPtr.Zero))
			{
				return null;
			}
			IntPtr clipboardData = GetClipboardData(1u);
			if (!(clipboardData == IntPtr.Zero))
			{
				IntPtr intPtr = IntPtr.Zero;
				try
				{
					intPtr = GlobalLock(clipboardData);
					if (intPtr == IntPtr.Zero)
					{
						return null;
					}
					int num = GlobalSize(clipboardData);
					byte[] array = new byte[num];
					Marshal.Copy(intPtr, array, 0, num);
					return Encoding.ASCII.GetString(array).TrimEnd(default(char));
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						sSKLoGH4MA7(clipboardData);
					}
				}
			}
			return null;
		}
		finally
		{
			St9LokO6A4h();
		}
	}

	public static bool IsFree()
	{
		return imULoImg7tG() == IntPtr.Zero;
	}

	public static bool ContainsText()
	{
		return Dl6LoWsctGh(13u);
	}

	public static string GetText()
	{
		if (!IsFree())
		{
			return null;
		}
		byte[] array = lULLoHhn7nF(13u, IntPtr.Zero);
		if (array == null)
		{
			return null;
		}
		return Encoding.Unicode.GetString(array).Trim(default(char));
	}

	private static byte[] lULLoHhn7nF(uint uint_0, IntPtr intptr_0)
	{
		try
		{
			if (OpenClipboard(intptr_0))
			{
				IntPtr clipboardData = GetClipboardData(uint_0);
				if (clipboardData == IntPtr.Zero)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), "GetClipboardData");
				}
				try
				{
					IntPtr intPtr = GlobalLock(clipboardData);
					if (intPtr == IntPtr.Zero)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error(), "GlobalLock");
					}
					int num = GlobalSize(clipboardData);
					if (num == 0)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error(), "GlobalSize");
					}
					byte[] array = new byte[num];
					Marshal.Copy(intPtr, array, 0, num);
					return array;
				}
				finally
				{
					sSKLoGH4MA7(clipboardData);
				}
			}
			return null;
		}
		finally
		{
			St9LokO6A4h();
		}
	}

	public static bool SetText(string text)
	{
		if (!IsFree())
		{
			return false;
		}
		byte[] bytes = Encoding.Unicode.GetBytes(text + "\0");
		return SMtLo1qF0pG(13u, IntPtr.Zero, bytes);
	}

	private static bool SMtLo1qF0pG(uint uint_0, IntPtr intptr_0, byte[] byte_0)
	{
		try
		{
			if (OpenClipboard(intptr_0))
			{
				if (!EmptyClipboard())
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), "EmptyClipboard");
				}
				IntPtr intPtr = GlobalAlloc(66u, byte_0.Length);
				if (intPtr == IntPtr.Zero)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), "GlobalAlloc");
				}
				try
				{
					IntPtr intPtr2 = GlobalLock(intPtr);
					if (!(intPtr2 == IntPtr.Zero))
					{
						Marshal.Copy(byte_0, 0, intPtr2, byte_0.Length);
						if (SetClipboardData(uint_0, intPtr) == IntPtr.Zero)
						{
							throw new Win32Exception(Marshal.GetLastWin32Error(), "SetClipboardData");
						}
						return true;
					}
					throw new Win32Exception(Marshal.GetLastWin32Error(), "GlobalLock");
				}
				finally
				{
					sSKLoGH4MA7(intPtr);
				}
			}
			return false;
		}
		finally
		{
			St9LokO6A4h();
		}
	}

	internal static bool Qt2bbUF59sJfUrddVq9X()
	{
		return zB4ibBF5NpYWcGcCHUbE == null;
	}

	internal static void r2Rm0eF5i7jaUHdp4JHt()
	{
	}
}
