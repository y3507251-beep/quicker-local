using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Quicker.Modules.TextTools;

public static class TextToolsHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec S5bvkyR7T3B;

		public static Func<string, TextToolType> YLGvk88q9n0;

		public static Func<TextToolType, bool> GAIvka6uTDC;

		private static _003C_003Ec RVOOOQcY0D8o8cpbLSos;

		static _003C_003Ec()
		{
			S5bvkyR7T3B = new _003C_003Ec();
		}

		internal TextToolType N10vkPmNWJg(string x)
		{
			if (Enum.TryParse<TextToolType>(x, out var result))
			{
				return result;
			}
			return TextToolType.Na;
		}

		internal bool eAmvkE3PtbT(TextToolType x)
		{
			return x != TextToolType.Na;
		}

		internal static bool jwnxf5cY1ePceX1yVlwg()
		{
			return RVOOOQcY0D8o8cpbLSos == null;
		}
	}

	public static IList<TextToolType> ParseToolsString(this string toolsStr)
	{
		if (string.IsNullOrEmpty(toolsStr))
		{
			return new List<TextToolType>();
		}
		return toolsStr.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.YLGvk88q9n0 ?? (_003C_003Ec.YLGvk88q9n0 = _003C_003Ec.S5bvkyR7T3B.N10vkPmNWJg)).Where(_003C_003Ec.GAIvka6uTDC ?? (_003C_003Ec.GAIvka6uTDC = _003C_003Ec.S5bvkyR7T3B.eAmvkE3PtbT))
			.ToList();
	}
}
