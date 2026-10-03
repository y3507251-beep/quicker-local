using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using uDL5IgqaOLgOa1ojKgW;

namespace Linearstar.Windows.RawInput.Native;

public static class HidD
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<IntPtr, byte[], uint, bool> y2JvREyCTEe;

		public static Func<IntPtr, byte[], uint, bool> zgovRygwCoK;

		static _003C_003EO()
		{
		}

		internal static void aGNs5CcOujKBK4A0sWTu()
		{
		}
	}

	private static object zWwIRyi6pwX6q9A5kUt;

	[DllImport("hid", CharSet = CharSet.Unicode, EntryPoint = "HidD_GetManufacturerString")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool HYwGdTTKYn(IntPtr intptr_0, [Out] byte[] byte_0, uint uint_0);

	[DllImport("hid", CharSet = CharSet.Unicode, EntryPoint = "HidD_GetProductString")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool lHuGoucXBJ(IntPtr intptr_0, [Out] byte[] byte_0, uint uint_0);

	[DllImport("hid", EntryPoint = "HidD_GetPreparsedData")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool pxjGTimsNi(IntPtr intptr_0, out IntPtr intptr_1);

	[DllImport("hid", EntryPoint = "HidD_FreePreparsedData")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool SQJGMGNgob(IntPtr intptr_0);

	public static HidDeviceHandle OpenDevice(string devicePath)
	{
		return (HidDeviceHandle)EnuqjjqpaxFuoWX08Ny.J6LsRpApQv(devicePath, (EnuqjjqpaxFuoWX08Ny.K7Hpfmdn5K3iD3SRAe4)3u, (EnuqjjqpaxFuoWX08Ny.IUe16CdOnQDpuYThFec)3u, EnuqjjqpaxFuoWX08Ny.l5spsEdNJqVSnsuc0mk.None, (IntPtr)0, 0u, (IntPtr)0);
	}

	public static bool TryOpenDevice(string devicePath, out HidDeviceHandle device)
	{
		if (EnuqjjqpaxFuoWX08Ny.D5Hsq3xFfD(devicePath, (EnuqjjqpaxFuoWX08Ny.K7Hpfmdn5K3iD3SRAe4)3u, (EnuqjjqpaxFuoWX08Ny.IUe16CdOnQDpuYThFec)3u, out var intptr_, EnuqjjqpaxFuoWX08Ny.l5spsEdNJqVSnsuc0mk.None, (IntPtr)0, 0u, (IntPtr)0))
		{
			device = (HidDeviceHandle)intptr_;
			return true;
		}
		device = HidDeviceHandle.Zero;
		return false;
	}

	public static void CloseDevice(HidDeviceHandle device)
	{
		EnuqjjqpaxFuoWX08Ny.MYJs0y9yOe(HidDeviceHandle.GetRawValue(device));
	}

	public static string GetManufacturerString(HidDeviceHandle device)
	{
		return a0HGApjNNi(HidDeviceHandle.GetRawValue(device), _003C_003EO.y2JvREyCTEe ?? (_003C_003EO.y2JvREyCTEe = HYwGdTTKYn));
	}

	public static string GetProductString(HidDeviceHandle device)
	{
		return a0HGApjNNi(HidDeviceHandle.GetRawValue(device), _003C_003EO.zgovRygwCoK ?? (_003C_003EO.zgovRygwCoK = lHuGoucXBJ));
	}

	public static HidPreparsedData GetPreparsedData(HidDeviceHandle device)
	{
		pxjGTimsNi(HidDeviceHandle.GetRawValue(device), out var intptr_);
		return (HidPreparsedData)intptr_;
	}

	public static void FreePreparsedData(HidPreparsedData preparsedData)
	{
		SQJGMGNgob(HidPreparsedData.GetRawValue(preparsedData));
	}

	private static string a0HGApjNNi(IntPtr intptr_0, Func<IntPtr, byte[], uint, bool> func_0)
	{
		byte[] array = new byte[256];
		if (!func_0(intptr_0, array, (uint)array.Length))
		{
			return null;
		}
		string text = Encoding.Unicode.GetString(array, 0, array.Length);
		if (!text.Contains("\0"))
		{
			return text;
		}
		return text.Substring(0, text.IndexOf('\0'));
	}

	internal static bool kjyuuaitCIwdhEFqatL()
	{
		return zWwIRyi6pwX6q9A5kUt == null;
	}
}
