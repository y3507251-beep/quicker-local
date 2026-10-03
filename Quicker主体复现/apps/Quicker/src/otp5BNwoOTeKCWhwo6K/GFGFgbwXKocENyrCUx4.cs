using System;
using System.Text.RegularExpressions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace otp5BNwoOTeKCWhwo6K;

internal static class GFGFgbwXKocENyrCUx4
{
	internal static object NCJNstQF2nFZCLCADLAC;

	internal static bool ibMflIV9C4(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			if (string_0.StartsWith("regex:", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					if (new Regex(string_0.Substring(6)).IsMatch(string_1))
					{
						return true;
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("正则匹配出错：" + ex.Message);
					return false;
				}
			}
			else
			{
				string[] others = string_0.SplitToList(';', '；');
				if (string_1.EqualsAny(true, others))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	internal static bool hc7cmVQFA9j9JnayZ6Vp()
	{
		return NCJNstQF2nFZCLCADLAC == null;
	}
}
