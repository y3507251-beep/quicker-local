using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class DomainsResult : HttpResult
{
	internal static DomainsResult S7HPd0ubfNdBd4WuGxd;

	public List<string> Result
	{
		get
		{
			List<string> result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				result = JsonConvert.DeserializeObject<List<string>>(base.Text);
			}
			return result;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code: {0}\n", base.Code);
		stringBuilder.AppendLine();
		int num;
		if (Result != null)
		{
			stringBuilder.AppendLine("domain(s):");
			num = 0;
			if (S7HPd0ubfNdBd4WuGxd != null)
			{
				goto IL_007c;
			}
			goto IL_008b;
		}
		if (!string.IsNullOrEmpty(base.Text))
		{
			stringBuilder.AppendLine("text:");
			stringBuilder.AppendLine(base.Text);
			num = 0;
			if (YFmPbcuqIQukOpI2ExT())
			{
				goto IL_007c;
			}
		}
		goto IL_00c3;
		IL_008b:
		foreach (string item in Result)
		{
			stringBuilder.AppendLine(item);
		}
		goto IL_00c3;
		IL_00c3:
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat("ref-code: {0}\n", base.RefCode);
		if (!string.IsNullOrEmpty(base.RefText))
		{
			stringBuilder.AppendLine("ref-text:");
			stringBuilder.AppendLine(base.RefText);
		}
		if (base.RefInfo != null)
		{
			stringBuilder.AppendFormat("ref-info:\n");
			foreach (KeyValuePair<string, string> item2 in base.RefInfo)
			{
				stringBuilder.AppendLine($"{item2.Key}: {item2.Value}");
			}
		}
		return stringBuilder.ToString();
		IL_007c:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00c3;
		}
		goto IL_008b;
	}

	internal static bool YFmPbcuqIQukOpI2ExT()
	{
		return S7HPd0ubfNdBd4WuGxd == null;
	}
}
