using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputDigitizer : RawInputHid
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LcLv7QpGF2S;

		public static Func<HidValueSet, IEnumerable<HidValue>> Adpv7jNTk6K;

		internal static _003C_003Ec W8NH0WcOFQbFmKgWMc2U;

		static _003C_003Ec()
		{
			LcLv7QpGF2S = new _003C_003Ec();
		}

		internal IEnumerable<HidValue> igRv7BQmYBE(HidValueSet x)
		{
			return x;
		}

		internal static bool FfCwsscOcptG0rM3L5Zj()
		{
			return W8NH0WcOFQbFmKgWMc2U == null;
		}
	}

	public static readonly HidUsageAndPage UsageContactCount;

	private static RawInputDigitizer p1VKnMiVNakfNDQ5Eqt;

	public int MaxContactCount => base.Reader.ValueSets.SelectMany(_003C_003Ec.Adpv7jNTk6K ?? (_003C_003Ec.Adpv7jNTk6K = _003C_003Ec.LcLv7QpGF2S.igRv7BQmYBE)).FirstOrDefault(TrLGRKDhsR)?.MaxValue ?? 1;

	internal RawInputDigitizer(RawInputDeviceHandle device, RawInputDeviceInfo deviceInfo)
		: base(device, deviceInfo)
	{
		if (!IsSupported(deviceInfo.Hid.UsageAndPage))
		{
			throw new ArgumentException($"UsagePage and Usage {deviceInfo.Hid.UsageAndPage} is not supported as a digitizer.", "deviceInfo");
		}
	}

	public static bool IsSupported(HidUsageAndPage usageAndPage)
	{
		return usageAndPage.UsagePage == 13;
	}

	static RawInputDigitizer()
	{
		UsageContactCount = new HidUsageAndPage(13, 84);
	}

	[CompilerGenerated]
	private bool TrLGRKDhsR(HidValue hidValue_0)
	{
		if (hidValue_0.LinkUsageAndPage == UsageAndPage)
		{
			return hidValue_0.UsageAndPage == UsageContactCount;
		}
		return false;
	}

	internal static bool c7DV1niQTTTX0gU2rKg()
	{
		return p1VKnMiVNakfNDQ5Eqt == null;
	}
}
