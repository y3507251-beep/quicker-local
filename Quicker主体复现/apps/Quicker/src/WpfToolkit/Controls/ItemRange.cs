using System.Runtime.CompilerServices;

namespace WpfToolkit.Controls;

public struct ItemRange
{
	[CompilerGenerated]
	private readonly int KUVvR8Dmrr;

	[CompilerGenerated]
	private readonly int AhGvqKSTT8;

	private static object Lw897dpTZDttOuY1x9N;

	public readonly int StartIndex
	{
		[CompilerGenerated]
		get
		{
			return KUVvR8Dmrr;
		}
	}

	public readonly int EndIndex
	{
		[CompilerGenerated]
		get
		{
			return AhGvqKSTT8;
		}
	}

	public ItemRange(int startIndex, int endIndex)
	{
		this = default(ItemRange);
		KUVvR8Dmrr = startIndex;
		AhGvqKSTT8 = endIndex;
	}

	public bool Contains(int itemIndex)
	{
		if (itemIndex >= StartIndex)
		{
			return itemIndex <= EndIndex;
		}
		return false;
	}

	internal static bool bNpK2ApmjsxMJcpwxq5()
	{
		return Lw897dpTZDttOuY1x9N == null;
	}
}
