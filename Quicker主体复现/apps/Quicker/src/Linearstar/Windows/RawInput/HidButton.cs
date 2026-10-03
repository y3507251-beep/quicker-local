using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidButton
{
	internal readonly HidReader p7OkWvS8kV;

	internal readonly HidPButtonCaps u73kkWMeIX;

	[CompilerGenerated]
	private readonly HidUsageAndPage AElkGrodf5;

	internal static HidButton WNCTCnqyVTD7Vmiui1l;

	public int ReportId => u73kkWMeIX.ReportID;

	public HidUsageAndPage UsageAndPage
	{
		[CompilerGenerated]
		get
		{
			return AElkGrodf5;
		}
	}

	public HidUsageAndPage LinkUsageAndPage => new HidUsageAndPage(u73kkWMeIX.LinkUsagePage, u73kkWMeIX.LinkUsage);

	public int LinkCollection => u73kkWMeIX.LinkCollection;

	internal HidButton(HidReader reader, HidPButtonCaps buttonCaps, ushort usage)
	{
		p7OkWvS8kV = reader;
		u73kkWMeIX = buttonCaps;
		AElkGrodf5 = new HidUsageAndPage(buttonCaps.UsagePage, usage);
	}

	public HidButtonState GetState(ArraySegment<byte> report)
	{
		return GetState(report.ToArray(), report.Count);
	}

	public HidButtonState GetState(byte[] report, int reportLength)
	{
		return new HidButtonState(this, report, reportLength);
	}

	public override string ToString()
	{
		return $"{ReportId}, {LinkCollection}, Link: {{{LinkUsageAndPage}}}, Usage: {{{UsageAndPage}}}";
	}

	static HidButton()
	{
	}

	internal static bool pVCmVyqpopOwjnIseg1()
	{
		return WNCTCnqyVTD7Vmiui1l == null;
	}

	internal static void K12VHiq2b3vH1lxiUml()
	{
	}

	internal static void hlCtMnqA8Jw0ZKYA5xu()
	{
	}
}
