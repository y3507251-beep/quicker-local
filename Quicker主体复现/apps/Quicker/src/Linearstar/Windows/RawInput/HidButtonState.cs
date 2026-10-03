using System;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidButtonState
{
	private readonly byte[] C2OkXIsMrL;

	private readonly int JFokmwa3Gs;

	[CompilerGenerated]
	private readonly HidButton prnkKLwKeL;

	internal static HidButtonState xRlgg6qGN66jt3UxRuC;

	public HidButton Button
	{
		[CompilerGenerated]
		get
		{
			return prnkKLwKeL;
		}
	}

	public bool IsActive
	{
		get
		{
			using HidPreparsedDataPtr hidPreparsedDataPtr = Button.p7OkWvS8kV.FwBkpWOFtC();
			return Array.IndexOf(HidP.GetUsages(hidPreparsedDataPtr, HidPReportType.Input, Button.u73kkWMeIX, C2OkXIsMrL, JFokmwa3Gs), Button.UsageAndPage.Usage) != -1;
		}
	}

	internal HidButtonState(HidButton button, byte[] report, int reportLength)
	{
		prnkKLwKeL = button;
		C2OkXIsMrL = report;
		JFokmwa3Gs = reportLength;
	}

	public override string ToString()
	{
		return $"Button: {{{Button}}}, IsActive: {IsActive}";
	}

	internal static bool Dc1UZqq0ZpTKj5Na0X0()
	{
		return xRlgg6qGN66jt3UxRuC == null;
	}
}
