using System;
using System.Runtime.CompilerServices;
using Quicker.Domain.Entities;

namespace Quicker.View.ProfileManagement;

public class ExeSettingsChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private ExeSettings bF7LN8LLKks;

	private static ExeSettingsChangedEventArgs VOl2O7FjCFakdcavrGf8;

	public ExeSettings ExeSettings
	{
		[CompilerGenerated]
		get
		{
			return bF7LN8LLKks;
		}
		[CompilerGenerated]
		set
		{
			bF7LN8LLKks = value;
		}
	}

	internal static bool FwBbC9Fj7GovhDyYTwoR()
	{
		return VOl2O7FjCFakdcavrGf8 == null;
	}
}
