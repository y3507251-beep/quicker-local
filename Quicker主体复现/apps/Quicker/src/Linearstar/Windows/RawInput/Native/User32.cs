using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using KN1lrKqGejXc8uE67VR;

namespace Linearstar.Windows.RawInput.Native;

public static class User32
{
	public enum RawInputGetBehavior : uint
	{
		Input = 268435459u,
		Header = 268435461u
	}

	internal static object zSaJ7yZAqqdKp4Y2wwu;

	[DllImport("user32", EntryPoint = "GetRawInputDeviceList", SetLastError = true)]
	private static extern uint qsgHvBagLG([Out] RawInputDeviceListItem[] rawInputDeviceListItem_0, ref uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "GetRawInputDeviceInfo", SetLastError = true)]
	private static extern uint SK3HSMfyMV(IntPtr intptr_0, RawInputDeviceInfoBehavior rawInputDeviceInfoBehavior_0, IntPtr intptr_1, out uint uint_0);

	[DllImport("user32", CharSet = CharSet.Unicode, EntryPoint = "GetRawInputDeviceInfo", SetLastError = true)]
	private static extern uint DdUH2QjPab(IntPtr intptr_0, RawInputDeviceInfoBehavior rawInputDeviceInfoBehavior_0, StringBuilder stringBuilder_0, in uint pcbSize);

	[DllImport("user32", EntryPoint = "GetRawInputDeviceInfo", SetLastError = true)]
	private static extern uint h74Hul0XU3(IntPtr intptr_0, RawInputDeviceInfoBehavior rawInputDeviceInfoBehavior_0, out RawInputDeviceInfo rawInputDeviceInfo_0, in uint pcbSize);

	[DllImport("user32", EntryPoint = "GetRawInputDeviceInfo", SetLastError = true)]
	private static extern uint Ym4HNY3slc(IntPtr intptr_0, RawInputDeviceInfoBehavior rawInputDeviceInfoBehavior_0, [Out] byte[] byte_0, in uint pcbSize);

	[DllImport("user32", EntryPoint = "RegisterRawInputDevices", SetLastError = true)]
	private static extern bool pYYHJdAWPS(RawInputDeviceRegistration[] rawInputDeviceRegistration_0, uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "GetRegisteredRawInputDevices", SetLastError = true)]
	private static extern uint GfwH0ptFJs([Out] RawInputDeviceRegistration[] rawInputDeviceRegistration_0, ref uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "GetRawInputData", SetLastError = true)]
	private static extern uint HkdHCKX8Ww(IntPtr intptr_0, RawInputGetBehavior rawInputGetBehavior_0, IntPtr intptr_1, ref uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "GetRawInputData", SetLastError = true)]
	private static extern uint LYQHPqA3Lr(IntPtr intptr_0, RawInputGetBehavior rawInputGetBehavior_0, out RawInputHeader rawInputHeader_0, ref uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "GetRawInputBuffer", SetLastError = true)]
	private static extern uint RJ6HEdPvS5(IntPtr intptr_0, ref uint uint_0, uint uint_1);

	[DllImport("user32", EntryPoint = "DefRawInputProc", SetLastError = true)]
	private static extern IntPtr yuKHy1KbGo(byte[] byte_0, int int_0, uint uint_0);

	public static RawInputDeviceListItem[] GetRawInputDeviceList()
	{
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputDeviceListItem>();
		uint uint_2 = 0u;
		qsgHvBagLG(null, ref uint_2, uint_);
		RawInputDeviceListItem[] array = new RawInputDeviceListItem[uint_2];
		qsgHvBagLG(array, ref uint_2, uint_).EnsureSuccess();
		return array;
	}

	public static string GetRawInputDeviceName(RawInputDeviceHandle device)
	{
		IntPtr rawValue = RawInputDeviceHandle.GetRawValue(device);
		SK3HSMfyMV(rawValue, RawInputDeviceInfoBehavior.DeviceName, IntPtr.Zero, out var uint_);
		if (uint_ <= 2)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder((int)uint_);
		DdUH2QjPab(rawValue, RawInputDeviceInfoBehavior.DeviceName, stringBuilder, in uint_).EnsureSuccess();
		return stringBuilder.ToString();
	}

	public static RawInputDeviceInfo GetRawInputDeviceInfo(RawInputDeviceHandle device)
	{
		h74Hul0XU3(RawInputDeviceHandle.GetRawValue(device), RawInputDeviceInfoBehavior.DeviceInfo, out var rawInputDeviceInfo_, (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputDeviceInfo>()).EnsureSuccess();
		return rawInputDeviceInfo_;
	}

	public static byte[] GetRawInputDevicePreparsedData(RawInputDeviceHandle device)
	{
		IntPtr rawValue = RawInputDeviceHandle.GetRawValue(device);
		SK3HSMfyMV(rawValue, RawInputDeviceInfoBehavior.PreparsedData, IntPtr.Zero, out var uint_);
		if (uint_ == 0)
		{
			return null;
		}
		byte[] array = new byte[uint_];
		Ym4HNY3slc(rawValue, RawInputDeviceInfoBehavior.PreparsedData, array, in uint_).EnsureSuccess();
		return array;
	}

	public static void RegisterRawInputDevices(params RawInputDeviceRegistration[] devices)
	{
		pYYHJdAWPS(devices, (uint)devices.Length, (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputDeviceRegistration>()).EnsureSuccess();
	}

	public static RawInputDeviceRegistration[] GetRegisteredRawInputDevices()
	{
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputDeviceRegistration>();
		uint uint_2 = 0u;
		GfwH0ptFJs(null, ref uint_2, uint_);
		RawInputDeviceRegistration[] array = new RawInputDeviceRegistration[uint_2];
		GfwH0ptFJs(array, ref uint_2, uint_).EnsureSuccess();
		return array;
	}

	public static RawInputHeader GetRawInputDataHeader(RawInputHandle rawInput)
	{
		IntPtr rawValue = RawInputHandle.GetRawValue(rawInput);
		uint num = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		uint uint_ = num;
		LYQHPqA3Lr(rawValue, RawInputGetBehavior.Header, out var rawInputHeader_, ref uint_, num).EnsureSuccess();
		return rawInputHeader_;
	}

	public static uint GetRawInputDataSize(RawInputHandle rawInput)
	{
		IntPtr rawValue = RawInputHandle.GetRawValue(rawInput);
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		uint uint_2 = 0u;
		HkdHCKX8Ww(rawValue, RawInputGetBehavior.Input, IntPtr.Zero, ref uint_2, uint_);
		return uint_2;
	}

	public static void GetRawInputData(RawInputHandle rawInput, IntPtr ptr, uint size)
	{
		IntPtr rawValue = RawInputHandle.GetRawValue(rawInput);
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		HkdHCKX8Ww(rawValue, RawInputGetBehavior.Input, ptr, ref size, uint_).EnsureSuccess();
	}

	public unsafe static RawMouse GetRawInputMouseData(RawInputHandle rawInput, out RawInputHeader header)
	{
		uint rawInputDataSize;
		while (true)
		{
			rawInputDataSize = GetRawInputDataSize(rawInput);
			if (zSaJ7yZAqqdKp4Y2wwu != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		uint num = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		fixed (byte* ptr = new byte[rawInputDataSize])
		{
			GetRawInputData(rawInput, (IntPtr)ptr, rawInputDataSize);
			header = *(RawInputHeader*)ptr;
			return *(RawMouse*)(ptr + num);
		}
	}

	public unsafe static RawKeyboard GetRawInputKeyboardData(RawInputHandle rawInput, out RawInputHeader header)
	{
		uint rawInputDataSize = GetRawInputDataSize(rawInput);
		uint num = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		byte[] array = new byte[rawInputDataSize];
		fixed (byte* pinned_array2 = array)
		{
		    byte[] array2 = array;
			byte* ptr;
			if (array != null && array2.Length != 0)
			{
				ptr = pinned_array2;
			}
			else
			{
				ptr = null;
				int num2 = 0;
				if (zSaJ7yZAqqdKp4Y2wwu != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			GetRawInputData(rawInput, (IntPtr)ptr, rawInputDataSize);
			header = *(RawInputHeader*)ptr;
			return *(RawKeyboard*)(ptr + num);
		}
	}

	public unsafe static RawHid GetRawInputHidData(RawInputHandle rawInput, out RawInputHeader header)
	{
		uint rawInputDataSize = GetRawInputDataSize(rawInput);
		uint num = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		if (zSaJ7yZAqqdKp4Y2wwu != null)
		{
			switch (0)
			{
			}
		}
		fixed (byte* ptr = new byte[rawInputDataSize])
		{
			GetRawInputData(rawInput, (IntPtr)ptr, rawInputDataSize);
			header = *(RawInputHeader*)ptr;
			return RawHid.FromPointer(ptr + num);
		}
	}

	public static uint GetRawInputBufferSize()
	{
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		uint uint_2 = 0u;
		RJ6HEdPvS5(IntPtr.Zero, ref uint_2, uint_);
		return uint_2;
	}

	public static uint GetRawInputBuffer(IntPtr ptr, uint size)
	{
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		return RJ6HEdPvS5(ptr, ref size, uint_).EnsureSuccess();
	}

	public static void DefRawInputProc(byte[] paRawInput)
	{
		uint uint_ = (uint)inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		yuKHy1KbGo(paRawInput, paRawInput.Length, uint_);
	}

	public static bool EnsureSuccess(this bool result)
	{
		if (!result)
		{
			throw new Win32ErrorException();
		}
		return result;
	}

	public static uint EnsureSuccess(this uint result)
	{
		if (result == uint.MaxValue)
		{
			throw new Win32ErrorException();
		}
		return result;
	}

	internal static bool aTV96kZnTZuJbLpZcaM()
	{
		return zSaJ7yZAqqdKp4Y2wwu == null;
	}
}
