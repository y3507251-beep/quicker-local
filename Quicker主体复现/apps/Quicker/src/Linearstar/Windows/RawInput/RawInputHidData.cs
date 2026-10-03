using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using KN1lrKqGejXc8uE67VR;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputHidData : RawInputData
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public ArraySegment<byte> kx2vR00hBOs;

		private static _003C_003Ec__DisplayClass6_0 SQmdQ0cO1cUlRlIvDsA6;

		internal HidButtonSetState TjBvRJeia8k(HidButtonSet x)
		{
			return x.GetStates(kx2vR00hBOs);
		}

		internal static bool whWwIAcOKOxYuc3gvUon()
		{
			return SQmdQ0cO1cUlRlIvDsA6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public ArraySegment<byte> NlkvRP2XDKy;

		private static _003C_003Ec__DisplayClass8_0 iZ7vn6cOvVDt8viftZNF;

		internal HidValueSetState lbcvRCq5N8F(HidValueSet x)
		{
			return x.GetStates(NlkvRP2XDKy);
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}

		internal static bool FWg9YKcOdpsvWwke3xgR()
		{
			return iZ7vn6cOvVDt8viftZNF == null;
		}

		internal static void JqgOKPcOJbVjAUBCEhNk()
		{
		}
	}

	[CompilerGenerated]
	private readonly RawHid E8yGrpZy5e;

	internal static RawInputHidData tDMAToi1Lb01EINkBoR;

	public new RawInputHid Device => (RawInputHid)base.Device;

	public RawHid Hid
	{
		[CompilerGenerated]
		get
		{
			return E8yGrpZy5e;
		}
	}

	public HidButtonSetState[] ButtonSetStates => Hid.ToHidReports().SelectMany(XsjGKgt1Hs).ToArray();

	public HidValueSetState[] ValueSetStates => Hid.ToHidReports().SelectMany(MjCGxeovN7).ToArray();

	protected RawInputHidData(RawInputHeader header, RawHid hid)
		: base(header)
	{
		E8yGrpZy5e = hid;
	}

	public static RawInputHidData Create(RawInputHeader header, RawHid hid)
	{
		RawInputDevice rawInputDevice = ((header.DeviceHandle != RawInputDeviceHandle.Zero) ? RawInputDevice.FromHandle(header.DeviceHandle) : null);
		if (rawInputDevice != null && RawInputDigitizer.IsSupported(rawInputDevice.UsageAndPage))
		{
			return new RawInputDigitizerData(header, hid);
		}
		return new RawInputHidData(header, hid);
	}

	public unsafe override byte[] ToStructure()
	{
		int num = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		RawHid hid = Hid;
		int num2 = 0;
		if (!DcuUFJiKeforO9UF1Ta())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			byte[] array = hid.ToStructure();
			byte[] array2 = new byte[RawInputData.Align(num + array.Length)];
			fixed (byte* ptr = array2)
			{
				*(RawInputHeader*)ptr = base.Header;
			}
			array.CopyTo(array2, num);
			return array2;
		}
		}
	}

	public override string ToString()
	{
		return $"{{{base.Header}, {Hid}}}";
	}

	[CompilerGenerated]
	private IEnumerable<HidButtonSetState> XsjGKgt1Hs(ArraySegment<byte> arraySegment_0)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.kx2vR00hBOs = arraySegment_0;
		return Device.Reader.ButtonSets.Select(_003C_003Ec__DisplayClass6_.TjBvRJeia8k);
	}

	[CompilerGenerated]
	private IEnumerable<HidValueSetState> MjCGxeovN7(ArraySegment<byte> arraySegment_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.NlkvRP2XDKy = arraySegment_0;
		return Device.Reader.ValueSets.Select(_003C_003Ec__DisplayClass8_.lbcvRCq5N8F);
	}

	internal static bool DcuUFJiKeforO9UF1Ta()
	{
		return tDMAToi1Lb01EINkBoR == null;
	}

	internal static void pOkjtxivEDtvYbKHFJR()
	{
	}
}
