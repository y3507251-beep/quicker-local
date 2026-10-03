using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidReader
{
	private HidPCaps NQfk4xfcqG;

	[CompilerGenerated]
	private readonly byte[] oLRk5jTilC;

	[CompilerGenerated]
	private readonly HidPreparsedData GkekDpeHgH;

	[CompilerGenerated]
	private HidButtonSet[] nKHkdu9SV7;

	[CompilerGenerated]
	private HidValueSet[] zb8kokQwEG;

	internal static HidReader M13Ks1qdDjPnA2Zy3d7;

	public byte[] PreparsedData
	{
		[CompilerGenerated]
		get
		{
			return oLRk5jTilC;
		}
	}

	public HidPreparsedData PreparsedDataPtr
	{
		[CompilerGenerated]
		get
		{
			return GkekDpeHgH;
		}
	}

	public int ValueCount => NQfk4xfcqG.NumberInputValueCaps;

	public HidButtonSet[] ButtonSets
	{
		[CompilerGenerated]
		get
		{
			return nKHkdu9SV7;
		}
		[CompilerGenerated]
		private set
		{
			nKHkdu9SV7 = value;
		}
	}

	public HidValueSet[] ValueSets
	{
		[CompilerGenerated]
		get
		{
			return zb8kokQwEG;
		}
		[CompilerGenerated]
		private set
		{
			zb8kokQwEG = value;
		}
	}

	public HidReader(HidPreparsedData preparsedData)
	{
		yNxkrVSfkb(GkekDpeHgH = preparsedData);
	}

	public HidReader(byte[] preparsedData)
	{
		using HidPreparsedDataPtr hidPreparsedDataPtr = new HidPreparsedDataPtr(oLRk5jTilC = preparsedData);
		yNxkrVSfkb(hidPreparsedDataPtr);
	}

	private void yNxkrVSfkb(HidPreparsedData hidPreparsedData_0)
	{
		NQfk4xfcqG = HidP.GetCaps(hidPreparsedData_0);
		HidPButtonCaps[] buttonCaps = HidP.GetButtonCaps(hidPreparsedData_0, HidPReportType.Input);
		ButtonSets = buttonCaps.Select(EhakBPdWnG).ToArray();
		HidPValueCaps[] valueCaps = HidP.GetValueCaps(hidPreparsedData_0, HidPReportType.Input);
		ValueSets = valueCaps.Select(uD6kQn6V2C).ToArray();
	}

	internal HidPreparsedDataPtr FwBkpWOFtC()
	{
		if (PreparsedData != null)
		{
			return new HidPreparsedDataPtr(PreparsedData);
		}
		return new HidPreparsedDataPtr(PreparsedDataPtr);
	}

	[CompilerGenerated]
	private HidButtonSet EhakBPdWnG(HidPButtonCaps hidPButtonCaps_0)
	{
		return new HidButtonSet(this, hidPButtonCaps_0);
	}

	[CompilerGenerated]
	private HidValueSet uD6kQn6V2C(HidPValueCaps hidPValueCaps_0)
	{
		return new HidValueSet(this, hidPValueCaps_0);
	}

	internal static bool xqUwIHqOYLsf42gn3e7()
	{
		return M13Ks1qdDjPnA2Zy3d7 == null;
	}

	internal static void cnBwMHqkqMeFZYulT2s()
	{
	}
}
