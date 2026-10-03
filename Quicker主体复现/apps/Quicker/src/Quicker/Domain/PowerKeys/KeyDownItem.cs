using System.Runtime.CompilerServices;
using Quicker.Utilities;

namespace Quicker.Domain.PowerKeys;

public class KeyDownItem
{
	[CompilerGenerated]
	private int M41tVfgJEPM;

	[CompilerGenerated]
	private long VCftVz0Hl1D;

	internal static KeyDownItem OjrayjQKZoUSi8FxrsiF;

	public int KeyValue
	{
		[CompilerGenerated]
		get
		{
			return M41tVfgJEPM;
		}
		[CompilerGenerated]
		set
		{
			M41tVfgJEPM = value;
		}
	}

	public long KeydownTicks
	{
		[CompilerGenerated]
		get
		{
			return VCftVz0Hl1D;
		}
		[CompilerGenerated]
		set
		{
			VCftVz0Hl1D = value;
		}
	}

	public KeyDownItem(int keyValue)
	{
		KeyValue = keyValue;
		KeydownTicks = AppHelper.fLiLTj0x4QY();
	}

	internal static bool VjVuq8QK5Ghs7LgUSAAF()
	{
		return OjrayjQKZoUSi8FxrsiF == null;
	}
}
