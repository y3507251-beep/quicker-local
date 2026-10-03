using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidValue
{
	internal readonly HidReader odWkAZhGfT;

	internal readonly HidPValueCaps skskOTIJRO;

	[CompilerGenerated]
	private readonly HidUsageAndPage YRxkFDGn8d;

	private static HidValue iLBKojqLEOxqhpXSQib;

	public int ReportId => skskOTIJRO.ReportID;

	public int ReportCount => skskOTIJRO.ReportCount;

	public HidUsageAndPage UsageAndPage
	{
		[CompilerGenerated]
		get
		{
			return YRxkFDGn8d;
		}
	}

	public HidUsageAndPage LinkUsageAndPage => new HidUsageAndPage(skskOTIJRO.LinkUsagePage, skskOTIJRO.LinkUsage);

	public int LinkCollection => skskOTIJRO.LinkCollection;

	public int MinValue => skskOTIJRO.LogicalMin;

	public int MaxValue => skskOTIJRO.LogicalMax;

	public int MinPhysicalValue => skskOTIJRO.PhysicalMin;

	public int MaxPhysicalValue => skskOTIJRO.PhysicalMax;

	public bool CanBeNull => skskOTIJRO.HasNull;

	internal HidValue(HidReader reader, HidPValueCaps valueCaps, ushort usage)
	{
		odWkAZhGfT = reader;
		skskOTIJRO = valueCaps;
		YRxkFDGn8d = new HidUsageAndPage(valueCaps.UsagePage, usage);
	}

	public HidValueState GetValue(ArraySegment<byte> report)
	{
		return GetValue(report.ToArray(), report.Count);
	}

	public HidValueState GetValue(byte[] report, int reportLength)
	{
		return new HidValueState(this, report, reportLength);
	}

	public override string ToString()
	{
		return $"{ReportId}, {LinkCollection}, Link: {{{LinkUsageAndPage}}}, Usage: {{{UsageAndPage}}}";
	}

	internal static bool Xtc0fkquYc5FQa0QQSh()
	{
		return iLBKojqLEOxqhpXSQib == null;
	}
}
