using System;
using System.Collections.Generic;

namespace IHGJ4aXzANwCaRMsxRt;

internal static class HA9eTPXa13am6cij1ts
{
	public static string kNjgWW5DqaP(this IDictionary<string, string> idictionary_0, string string_0, bool bool_0 = true)
	{
		if (idictionary_0.ContainsKey(string_0))
		{
			string text = idictionary_0[string_0].Trim();
			if (bool_0 && string.IsNullOrWhiteSpace(text))
			{
				throw new ArgumentException("参数：" + string_0 + " 不能为空。");
			}
			return text;
		}
		throw new ArgumentException("缺少参数：" + string_0);
	}
}
