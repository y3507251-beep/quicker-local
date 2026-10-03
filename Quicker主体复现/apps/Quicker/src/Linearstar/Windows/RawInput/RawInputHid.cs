using System;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputHid : RawInputDevice
{
	private readonly Lazy<HidReader> iQ4GmVvPE8;

	private static RawInputHid rL8lRsiEnGDLuN5vgu9;

	public override HidUsageAndPage UsageAndPage => base.DeviceInfo.Hid.UsageAndPage;

	public override int VendorId => base.DeviceInfo.Hid.VendorId;

	public override int ProductId => base.DeviceInfo.Hid.ProductId;

	public int Version => base.DeviceInfo.Hid.VersionNumber;

	public HidReader Reader => iQ4GmVvPE8.Value;

	internal RawInputHid(RawInputDeviceHandle device, RawInputDeviceInfo deviceInfo)
		: base(device, deviceInfo)
	{
		if (deviceInfo.Type != RawInputDeviceType.Hid)
		{
			throw new ArgumentException($"Device type must be {RawInputDeviceType.Hid}.", "deviceInfo");
		}
		iQ4GmVvPE8 = new Lazy<HidReader>(NwaGXaU3vV);
	}

	[CompilerGenerated]
	private HidReader NwaGXaU3vV()
	{
		return new HidReader(GetPreparsedData());
	}

	internal static bool Od6JHniGmeYjfaQxJji()
	{
		return rL8lRsiEnGDLuN5vgu9 == null;
	}
}
