using System;
using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

public static class CfgMgr32
{
	[Flags]
	public enum LocateDevNodeFlags : uint
	{
		Normal = 0u,
		Phantom = 1u,
		CancelRemove = 2u,
		NoValidation = 4u
	}

	private static object ua0uJKilhcniI61sN5P;

	[DllImport("cfgmgr32", CharSet = CharSet.Unicode, EntryPoint = "CM_Locate_DevNode")]
	private static extern ConfigReturnValue bxiGQebxNb(out IntPtr intptr_0, string string_0, LocateDevNodeFlags locateDevNodeFlags_0);

	[DllImport("cfgmgr32", CharSet = CharSet.Unicode, EntryPoint = "CM_Get_DevNode_Property")]
	private static extern ConfigReturnValue yxZGj09ewS(IntPtr intptr_0, in DevicePropertyKey propertyKey, out uint uint_0, IntPtr intptr_1, ref uint uint_1, uint uint_2);

	public static DeviceInstanceHandle LocateDevNode(string devicePath, LocateDevNodeFlags flags)
	{
		TryLocateDevNode(devicePath, flags, out var device).iJCGn5ekLW();
		return device;
	}

	public static ConfigReturnValue TryLocateDevNode(string devicePath, LocateDevNodeFlags flags, out DeviceInstanceHandle device)
	{
		IntPtr intptr_;
		ConfigReturnValue configReturnValue = bxiGQebxNb(out intptr_, devicePath, flags);
		device = ((configReturnValue == ConfigReturnValue.Success) ? ((DeviceInstanceHandle)intptr_) : DeviceInstanceHandle.Zero);
		return configReturnValue;
	}

	public static string GetDevNodePropertyString(DeviceInstanceHandle device, in DevicePropertyKey propertyKey)
	{
		TryGetDevNodePropertyString(device, in propertyKey, out var value);
		return value;
	}

	public static ConfigReturnValue TryGetDevNodePropertyString(DeviceInstanceHandle device, in DevicePropertyKey propertyKey, out string value)
	{
		IntPtr rawValue = DeviceInstanceHandle.GetRawValue(device);
		uint uint_ = 0u;
		ConfigReturnValue configReturnValue = yxZGj09ewS(rawValue, in propertyKey, out var uint_2, IntPtr.Zero, ref uint_, 0u);
		if (configReturnValue != ConfigReturnValue.Success && configReturnValue != ConfigReturnValue.BufferSmall)
		{
			value = null;
			return configReturnValue;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)uint_);
		try
		{
			configReturnValue = yxZGj09ewS(rawValue, in propertyKey, out uint_2, intPtr, ref uint_, 0u);
			if (configReturnValue != ConfigReturnValue.Success)
			{
				value = null;
				return configReturnValue;
			}
			value = Marshal.PtrToStringUni(intPtr);
			return ConfigReturnValue.Success;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private static void iJCGn5ekLW(this ConfigReturnValue configReturnValue_0)
	{
		if (configReturnValue_0 != ConfigReturnValue.Success)
		{
			throw new InvalidOperationException(configReturnValue_0.ToString());
		}
	}

	internal static bool GZMrqHiZZUdKP0kV6tT()
	{
		return ua0uJKilhcniI61sN5P == null;
	}
}
