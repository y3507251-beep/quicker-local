using System;

namespace Linearstar.Windows.RawInput;

public struct RawInputDeviceRegistration
{
	private readonly ushort OpgGyn7TFG;

	private readonly ushort s7tG8rKuCv;

	private readonly RawInputDeviceFlags eRNGaPlSCF;

	private readonly IntPtr uwCG7Yl7bB;

	private static object YIplPBqCikfXKG8Ol15;

	public ushort UsagePage => OpgGyn7TFG;

	public ushort Usage => s7tG8rKuCv;

	public RawInputDeviceFlags Flags => eRNGaPlSCF;

	public IntPtr HwndTarget => uwCG7Yl7bB;

	public RawInputDeviceRegistration(HidUsageAndPage usageAndPage, RawInputDeviceFlags flags, IntPtr hWndTarget)
		: this(usageAndPage.UsagePage, usageAndPage.Usage, flags, hWndTarget)
	{
	}

	public RawInputDeviceRegistration(ushort usagePage, ushort usage, RawInputDeviceFlags flags, IntPtr hWndTarget)
	{
		OpgGyn7TFG = usagePage;
		s7tG8rKuCv = usage;
		eRNGaPlSCF = flags;
		uwCG7Yl7bB = hWndTarget;
	}

	internal static bool K9AXMpq7Pt3Gy74bf1t()
	{
		return YIplPBqCikfXKG8Ol15 == null;
	}
}
