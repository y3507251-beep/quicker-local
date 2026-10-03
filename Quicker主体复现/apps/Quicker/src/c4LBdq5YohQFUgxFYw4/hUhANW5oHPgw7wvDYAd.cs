using System;
using System.Runtime.CompilerServices;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using tnhyg357Ch4jKrVvHlZ;

namespace c4LBdq5YohQFUgxFYw4;

internal static class hUhANW5oHPgw7wvDYAd
{
	[CompilerGenerated]
	private static bool NlxmEsITh9;

	internal static object DWDg5cxhPXVfFhIDudp;

	[SpecialName]
	[CompilerGenerated]
	public static bool hbEm0h4K8o()
	{
		return NlxmEsITh9;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void zUVmCcanvp(bool bool_1)
	{
		NlxmEsITh9 = bool_1;
	}

	public static qsQtMm5MtHtoYi1dcdV Select(ScreenSelectType selectType, bool returnImage = false, SelectOptions options = null)
	{
		if (returnImage && (selectType == ScreenSelectType.Color || selectType == ScreenSelectType.Point))
		{
			throw new NotSupportedException("获取坐标与颜色时不支持返回位图。");
		}
		if (NlxmEsITh9)
		{
			return new qsQtMm5MtHtoYi1dcdV
			{
				IsSuccess = false,
				ErrorMessage = "ScreenSelector is working."
			};
		}
		try
		{
			zUVmCcanvp(true);
			N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G = new N4PkhP56DLuHvaMdN6G(selectType, returnImage, options ?? new SelectOptions());
			n4PkhP56DLuHvaMdN6G.ShowDialog();
			n4PkhP56DLuHvaMdN6G.Dispose();
			return n4PkhP56DLuHvaMdN6G.iLZKXJJRUG() ?? new qsQtMm5MtHtoYi1dcdV
			{
				IsSuccess = false
			};
		}
		finally
		{
			zUVmCcanvp(false);
		}
	}

	internal static bool TVS6nFxH7EP1COuXZh0()
	{
		return DWDg5cxhPXVfFhIDudp == null;
	}
}
