using System;
using System.Globalization;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputMouse : RawInputDevice
{
	internal static RawInputMouse f80pADi9NOODPHKX4qC;

	public override HidUsageAndPage UsageAndPage => HidUsageAndPage.Mouse;

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

	public int Id => base.DeviceInfo.Mouse.Id;

	public int ButtonCount => base.DeviceInfo.Mouse.ButtonCount;

	public int SampleRate => base.DeviceInfo.Mouse.SampleRate;

	public bool HasHorizontalWheel => base.DeviceInfo.Mouse.HasHorizontalWheel;

	internal RawInputMouse(RawInputDeviceHandle device, RawInputDeviceInfo deviceInfo)
		: base(device, deviceInfo)
	{
		if (deviceInfo.Type != RawInputDeviceType.Mouse)
		{
			throw new ArgumentException($"Device type must be {RawInputDeviceType.Mouse}.", "deviceInfo");
		}
	}

	static RawInputMouse()
	{
	}

	internal static bool QUitPoiLlgcNyQMfwUL()
	{
		return f80pADi9NOODPHKX4qC == null;
	}

	internal static void CqXqGiiftrVuL3WGFH7()
	{
	}
}
