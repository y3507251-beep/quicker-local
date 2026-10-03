using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public abstract class RawInputDevice
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec RIov7raKq5C;

		public static Func<RawInputDeviceListItem, RawInputDevice> NZgv7p9he8s;

		private static _003C_003Ec oXftU4cdzjaut0VnHfct;

		static _003C_003Ec()
		{
			RIov7raKq5C = new _003C_003Ec();
		}

		internal RawInputDevice uP4v7x9S081(RawInputDeviceListItem i)
		{
			return FromHandle(i.Device);
		}

		internal static bool FgIuAUcOVHMtoLg9Qykv()
		{
			return oXftU4cdzjaut0VnHfct == null;
		}
	}

	private string xEMGJkl6ys;

	private string H3iG0IcWAJ;

	[CompilerGenerated]
	private readonly RawInputDeviceInfo DYCGCT5Saw;

	[CompilerGenerated]
	private readonly RawInputDeviceHandle YF5GPTrEXM;

	[CompilerGenerated]
	private readonly string LhHGEVcLv5;

	private static RawInputDevice bKCfyGqtM6IVVvTv0o6;

	protected RawInputDeviceInfo DeviceInfo
	{
		[CompilerGenerated]
		get
		{
			return DYCGCT5Saw;
		}
	}

	public RawInputDeviceHandle Handle
	{
		[CompilerGenerated]
		get
		{
			return YF5GPTrEXM;
		}
	}

	public RawInputDeviceType DeviceType => DeviceInfo.Type;

	public string DevicePath
	{
		[CompilerGenerated]
		get
		{
			return LhHGEVcLv5;
		}
	}

	public string ManufacturerName
	{
		get
		{
			if (H3iG0IcWAJ == null)
			{
				k31G2Y0TUQ();
			}
			return H3iG0IcWAJ;
		}
	}

	public string ProductName
	{
		get
		{
			if (xEMGJkl6ys == null)
			{
				k31G2Y0TUQ();
			}
			return xEMGJkl6ys;
		}
	}

	public bool IsConnected
	{
		get
		{
			DeviceInstanceHandle device;
			return CfgMgr32.TryLocateDevNode(DevicePath, CfgMgr32.LocateDevNodeFlags.Normal, out device) == ConfigReturnValue.Success;
		}
	}

	public abstract HidUsageAndPage UsageAndPage { get; }

	public abstract int VendorId { get; }

	public abstract int ProductId { get; }

	private void k31G2Y0TUQ()
	{
		if (DevicePath != null)
		{
			if (H3iG0IcWAJ == null || xEMGJkl6ys == null)
			{
				tR5GuuJJ1l();
			}
			if (H3iG0IcWAJ == null || xEMGJkl6ys == null)
			{
				XkuGN5lrjK();
			}
		}
	}

	private void tR5GuuJJ1l()
	{
		if (!HidD.TryOpenDevice(DevicePath, out var device))
		{
			return;
		}
		try
		{
			if (H3iG0IcWAJ == null)
			{
				H3iG0IcWAJ = HidD.GetManufacturerString(device);
			}
			if (xEMGJkl6ys == null)
			{
				xEMGJkl6ys = HidD.GetProductString(device);
			}
		}
		finally
		{
			HidD.CloseDevice(device);
		}
	}

	private void XkuGN5lrjK()
	{
		string text = DevicePath.Substring(4).Replace('#', '\\');
		if (text.Contains("{"))
		{
			text = text.Substring(0, text.IndexOf('{') - 1);
		}
		DeviceInstanceHandle device = CfgMgr32.LocateDevNode(text, CfgMgr32.LocateDevNodeFlags.Phantom);
		if (H3iG0IcWAJ == null)
		{
			H3iG0IcWAJ = CfgMgr32.GetDevNodePropertyString(device, in DevicePropertyKey.DeviceManufacturer);
			if (!GeuFEHqSYn4Awi9j3X3())
			{
				switch (0)
				{
				}
			}
		}
		if (xEMGJkl6ys == null)
		{
			xEMGJkl6ys = CfgMgr32.GetDevNodePropertyString(device, in DevicePropertyKey.DeviceFriendlyName);
		}
		if (xEMGJkl6ys == null)
		{
			xEMGJkl6ys = CfgMgr32.GetDevNodePropertyString(device, in DevicePropertyKey.Name);
		}
	}

	protected RawInputDevice(RawInputDeviceHandle device, RawInputDeviceInfo deviceInfo)
	{
		YF5GPTrEXM = device;
		LhHGEVcLv5 = User32.GetRawInputDeviceName(device);
		DYCGCT5Saw = deviceInfo;
	}

	public static RawInputDevice FromHandle(RawInputDeviceHandle device)
	{
		RawInputDeviceInfo rawInputDeviceInfo = User32.GetRawInputDeviceInfo(device);
		switch (rawInputDeviceInfo.Type)
		{
		default:
			throw new ArgumentException();
		case RawInputDeviceType.Mouse:
			return new RawInputMouse(device, rawInputDeviceInfo);
		case RawInputDeviceType.Keyboard:
			return new RawInputKeyboard(device, rawInputDeviceInfo);
		case RawInputDeviceType.Hid:
			if (!RawInputDigitizer.IsSupported(rawInputDeviceInfo.Hid.UsageAndPage))
			{
				return new RawInputHid(device, rawInputDeviceInfo);
			}
			return new RawInputDigitizer(device, rawInputDeviceInfo);
		}
	}

	public static RawInputDevice[] GetDevices()
	{
		return User32.GetRawInputDeviceList().Select(_003C_003Ec.NZgv7p9he8s ?? (_003C_003Ec.NZgv7p9he8s = _003C_003Ec.RIov7raKq5C.uP4v7x9S081)).ToArray();
	}

	public byte[] GetPreparsedData()
	{
		return User32.GetRawInputDevicePreparsedData(Handle);
	}

	public static void RegisterDevice(HidUsageAndPage usageAndPage, RawInputDeviceFlags flags, IntPtr hWndTarget)
	{
		User32.RegisterRawInputDevices(new RawInputDeviceRegistration(usageAndPage, flags, hWndTarget));
	}

	public static void RegisterDevice(params RawInputDeviceRegistration[] devices)
	{
		User32.RegisterRawInputDevices(devices);
	}

	public static void UnregisterDevice(HidUsageAndPage usageAndPage)
	{
		RegisterDevice(usageAndPage, RawInputDeviceFlags.Remove, IntPtr.Zero);
	}

	public static RawInputDeviceRegistration[] GetRegisteredDevices()
	{
		return User32.GetRegisteredRawInputDevices();
	}

	internal static bool GeuFEHqSYn4Awi9j3X3()
	{
		return bKCfyGqtM6IVVvTv0o6 == null;
	}
}
