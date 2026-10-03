using System;
using System.Globalization;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputKeyboard : RawInputDevice
{
	internal static RawInputKeyboard zJqcITideyl69WcqOjG;

	public override HidUsageAndPage UsageAndPage => HidUsageAndPage.Keyboard;

	public override int VendorId
	{
		get
		{
			if (!base.DevicePath.Contains("VID_"))
			{
				return 0;
			}
			return int.Parse(base.DevicePath.Substring(base.DevicePath.IndexOf("VID_", StringComparison.Ordinal) + 4, 4), NumberStyles.HexNumber);
		}
	}

	public override int ProductId
	{
		get
		{
			if (!base.DevicePath.Contains("PID_"))
			{
				return 0;
			}
			return int.Parse(base.DevicePath.Substring(base.DevicePath.IndexOf("PID_", StringComparison.Ordinal) + 4, 4), NumberStyles.HexNumber);
		}
	}

	public int KeyboardType => base.DeviceInfo.Keyboard.KeyboardType;

	public int KeyboardSubType => base.DeviceInfo.Keyboard.KeyboardSubType;

	public int KeyboardMode => base.DeviceInfo.Keyboard.KeyboardMode;

	public int FunctionKeyCount => base.DeviceInfo.Keyboard.FunctionKeyCount;

	public int IndicatorCount => base.DeviceInfo.Keyboard.IndicatorCount;

	public int TotalKeyCount => base.DeviceInfo.Keyboard.TotalKeyCount;

	internal RawInputKeyboard(RawInputDeviceHandle device, RawInputDeviceInfo deviceInfo)
		: base(device, deviceInfo)
	{
		if (deviceInfo.Type != RawInputDeviceType.Keyboard)
		{
			throw new ArgumentException($"Device type must be {RawInputDeviceType.Keyboard}", "deviceInfo");
		}
	}

	internal static bool cC5xXniO6Caop4nUKdq()
	{
		return zJqcITideyl69WcqOjG == null;
	}
}
