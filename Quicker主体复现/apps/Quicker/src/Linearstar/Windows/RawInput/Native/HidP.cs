using System;
using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

public static class HidP
{
	private static object UqREQ1is0wVJ5pPKs9q;

	[DllImport("hid", EntryPoint = "HidP_GetCaps")]
	private static extern NtStatus nOTGF2TeLe(IntPtr intptr_0, out HidPCaps hidPCaps_0);

	[DllImport("hid", EntryPoint = "HidP_GetButtonCaps")]
	private static extern NtStatus WQSGUbPrC3(HidPReportType hidPReportType_0, [Out] HidPButtonCaps[] hidPButtonCaps_0, ref ushort ushort_0, IntPtr intptr_0);

	[DllImport("hid", EntryPoint = "HidP_GetValueCaps")]
	private static extern NtStatus VZKGllsbvl(HidPReportType hidPReportType_0, [Out] HidPValueCaps[] hidPValueCaps_0, ref ushort ushort_0, IntPtr intptr_0);

	[DllImport("hid", EntryPoint = "HidP_GetUsages")]
	private static extern NtStatus u9WGi46hBn(HidPReportType hidPReportType_0, ushort ushort_0, ushort ushort_1, [Out] ushort[] ushort_2, ref uint uint_0, IntPtr intptr_0, byte[] byte_0, uint uint_1);

	[DllImport("hid", EntryPoint = "HidP_GetUsageValue")]
	private static extern NtStatus LMwG34Gwad(HidPReportType hidPReportType_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, out int int_0, IntPtr intptr_0, byte[] byte_0, uint uint_0);

	[DllImport("hid", EntryPoint = "HidP_GetScaledUsageValue")]
	private static extern NtStatus CwtGf0RBGr(HidPReportType hidPReportType_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, out int int_0, IntPtr intptr_0, byte[] byte_0, uint uint_0);

	[DllImport("hid", EntryPoint = "HidP_GetUsageValueArray")]
	private static extern NtStatus SmQGzvTelW(HidPReportType hidPReportType_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, [Out] byte[] byte_0, ushort ushort_3, IntPtr intptr_0, byte[] byte_1, uint uint_0);

	public static NtStatus TryGetCaps(HidPreparsedData preparsedData, out HidPCaps capabilities)
	{
		return nOTGF2TeLe(HidPreparsedData.GetRawValue(preparsedData), out capabilities);
	}

	public static HidPCaps GetCaps(HidPreparsedData preparsedData)
	{
		TryGetCaps(preparsedData, out var capabilities).EnsureSuccess();
		return capabilities;
	}

	public static NtStatus TryGetButtonCaps(HidPreparsedData preparsedData, HidPReportType reportType, out HidPButtonCaps[] buttonCaps)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		HidPCaps caps = GetCaps(preparsedData);
		ushort ushort_ = reportType switch
		{
			HidPReportType.Input => caps.NumberInputButtonCaps, 
			HidPReportType.Output => caps.NumberOutputButtonCaps, 
			HidPReportType.Feature => caps.NumberFeatureButtonCaps, 
			_ => throw new ArgumentException($"Invalid HidPReportType: {reportType}", "reportType"), 
		};
		if (!s7T4fGiCV6mmcvhjJvj())
		{
			switch (0)
			{
			}
		}
		buttonCaps = new HidPButtonCaps[ushort_];
		return WQSGUbPrC3(reportType, buttonCaps, ref ushort_, rawValue);
	}

	public static HidPButtonCaps[] GetButtonCaps(HidPreparsedData preparsedData, HidPReportType reportType)
	{
		TryGetButtonCaps(preparsedData, reportType, out var buttonCaps).EnsureSuccess();
		return buttonCaps;
	}

	public static NtStatus TryGetValueCaps(HidPreparsedData preparsedData, HidPReportType reportType, out HidPValueCaps[] valueCaps)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		HidPCaps caps = GetCaps(preparsedData);
		ushort num;
		switch (reportType)
		{
		default:
			if (UqREQ1is0wVJ5pPKs9q == null)
			{
				switch (0)
				{
				}
			}
			throw new ArgumentException($"Invalid HidPReportType: {reportType}", "reportType");
		case HidPReportType.Input:
			num = caps.NumberInputValueCaps;
			break;
		case HidPReportType.Output:
			num = caps.NumberOutputValueCaps;
			break;
		case HidPReportType.Feature:
			num = caps.NumberFeatureValueCaps;
			break;
		}
		ushort ushort_ = num;
		valueCaps = new HidPValueCaps[ushort_];
		return VZKGllsbvl(reportType, valueCaps, ref ushort_, rawValue);
	}

	public static HidPValueCaps[] GetValueCaps(HidPreparsedData preparsedData, HidPReportType reportType)
	{
		TryGetValueCaps(preparsedData, reportType, out var valueCaps).EnsureSuccess();
		return valueCaps;
	}

	public static NtStatus TryGetUsages(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, byte[] report, int reportLength, out ushort[] usageList)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		uint uint_ = 0u;
		u9WGi46hBn(reportType, usagePage, linkCollection, null, ref uint_, rawValue, report, (uint)reportLength);
		usageList = new ushort[uint_];
		return u9WGi46hBn(reportType, usagePage, linkCollection, usageList, ref uint_, rawValue, report, (uint)reportLength);
	}

	public static NtStatus TryGetUsages(HidPreparsedData preparsedData, HidPReportType reportType, HidPButtonCaps buttonCaps, byte[] report, int reportLength, out ushort[] usageList)
	{
		return TryGetUsages(preparsedData, reportType, buttonCaps.UsagePage, buttonCaps.LinkCollection, report, reportLength, out usageList);
	}

	public static ushort[] GetUsages(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, byte[] report, int reportLength)
	{
		TryGetUsages(preparsedData, reportType, usagePage, linkCollection, report, reportLength, out var usageList).EnsureSuccess();
		return usageList;
	}

	public static ushort[] GetUsages(HidPreparsedData preparsedData, HidPReportType reportType, HidPButtonCaps buttonCaps, byte[] report, int reportLength)
	{
		return GetUsages(preparsedData, reportType, buttonCaps.UsagePage, buttonCaps.LinkCollection, report, reportLength);
	}

	public static NtStatus TryGetUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, byte[] report, int reportLength, out int usageValue)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		return LMwG34Gwad(reportType, usagePage, linkCollection, usage, out usageValue, rawValue, report, (uint)reportLength);
	}

	public static NtStatus TryGetUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength, out int usageValue)
	{
		return TryGetUsageValue(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, report, reportLength, out usageValue);
	}

	public static int GetUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, byte[] report, int reportLength)
	{
		TryGetUsageValue(preparsedData, reportType, usagePage, linkCollection, usage, report, reportLength, out var usageValue).EnsureSuccess();
		return usageValue;
	}

	public static int GetUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength)
	{
		return GetUsageValue(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, report, reportLength);
	}

	public static NtStatus TryGetScaledUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, byte[] report, int reportLength, out int usageValue)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		return CwtGf0RBGr(reportType, usagePage, linkCollection, usage, out usageValue, rawValue, report, (uint)reportLength);
	}

	public static NtStatus TryGetScaledUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength, out int usageValue)
	{
		return TryGetScaledUsageValue(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, report, reportLength, out usageValue);
	}

	public static int GetScaledUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, byte[] report, int reportLength)
	{
		TryGetScaledUsageValue(preparsedData, reportType, usagePage, linkCollection, usage, report, reportLength, out var usageValue).EnsureSuccess();
		return usageValue;
	}

	public static int GetScaledUsageValue(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength)
	{
		return GetScaledUsageValue(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, report, reportLength);
	}

	public static NtStatus TryGetUsageValueArray(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, ushort usageValueByteLength, byte[] report, int reportLength, out byte[] usageValue)
	{
		IntPtr rawValue = HidPreparsedData.GetRawValue(preparsedData);
		usageValue = new byte[usageValueByteLength];
		return SmQGzvTelW(reportType, usagePage, linkCollection, usage, usageValue, usageValueByteLength, rawValue, report, (uint)reportLength);
	}

	public static NtStatus TryGetUsageValueArray(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength, out byte[] usageValue)
	{
		return TryGetUsageValueArray(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, (ushort)(valueCaps.BitSize * valueCaps.ReportCount), report, reportLength, out usageValue);
	}

	public static byte[] GetUsageValueArray(HidPreparsedData preparsedData, HidPReportType reportType, ushort usagePage, ushort linkCollection, ushort usage, ushort usageValueByteLength, byte[] report, int reportLength)
	{
		TryGetUsageValueArray(preparsedData, reportType, usagePage, linkCollection, usage, usageValueByteLength, report, reportLength, out var usageValue).EnsureSuccess();
		return usageValue;
	}

	public static byte[] GetUsageValueArray(HidPreparsedData preparsedData, HidPReportType reportType, HidPValueCaps valueCaps, ushort usage, byte[] report, int reportLength)
	{
		return GetUsageValueArray(preparsedData, reportType, valueCaps.UsagePage, valueCaps.LinkCollection, usage, (ushort)(valueCaps.BitSize * valueCaps.ReportCount), report, reportLength);
	}

	public static void EnsureSuccess(this NtStatus result)
	{
		if (result != NtStatus.Success)
		{
			throw new InvalidOperationException(result.ToString());
		}
	}

	internal static bool s7T4fGiCV6mmcvhjJvj()
	{
		return UqREQ1is0wVJ5pPKs9q == null;
	}
}
