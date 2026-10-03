using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidValueState
{
	private readonly byte[] JCekzNoYPR;

	private readonly int kORGwrn25G;

	[CompilerGenerated]
	private readonly HidValue psXGt0eL4L;

	private static HidValueState vqBrI2q5RFQEyuD0rSk;

	public HidValue Value
	{
		[CompilerGenerated]
		get
		{
			return psXGt0eL4L;
		}
	}

	public int CurrentValue
	{
		get
		{
			using HidPreparsedDataPtr hidPreparsedDataPtr = Value.odWkAZhGfT.FwBkpWOFtC();
			return HidP.GetUsageValue(hidPreparsedDataPtr, HidPReportType.Input, Value.skskOTIJRO, Value.UsageAndPage.Usage, JCekzNoYPR, kORGwrn25G);
		}
	}

	public int? ScaledValue
	{
		get
		{
			using HidPreparsedDataPtr hidPreparsedDataPtr = Value.odWkAZhGfT.FwBkpWOFtC();
			int usageValue;
			return (HidP.TryGetScaledUsageValue(hidPreparsedDataPtr, HidPReportType.Input, Value.skskOTIJRO, Value.UsageAndPage.Usage, JCekzNoYPR, kORGwrn25G, out usageValue) == NtStatus.Success) ? new int?(usageValue) : ((int?)null);
		}
	}

	public bool HasValue
	{
		get
		{
			if (!Value.CanBeNull)
			{
				return true;
			}
			int currentValue = CurrentValue;
			if (currentValue >= Value.MinValue)
			{
				return currentValue <= Value.MaxValue;
			}
			return false;
		}
	}

	internal HidValueState(HidValue value, byte[] report, int reportLength)
	{
		psXGt0eL4L = value;
		JCekzNoYPR = report;
		kORGwrn25G = reportLength;
	}

	public override string ToString()
	{
		return $"Value: {{{Value}}}, CurrentValue: {CurrentValue}";
	}

	internal static bool yu6ZeHqYfD0TDS0SltZ()
	{
		return vqBrI2q5RFQEyuD0rSk == null;
	}
}
