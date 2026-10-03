using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class BucketsResult : HttpResult
{
	private static BucketsResult M2w2sruB4dDqKThf1cJ;

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
		if (Result != null)
		{
			stringBuilder.AppendLine("bucket(s):");
			foreach (string item in Result)
			{
				stringBuilder.AppendLine(item);
			}
		}
		else if (!string.IsNullOrEmpty(base.Text))
		{
			stringBuilder.AppendLine("text:");
			stringBuilder.AppendLine(base.Text);
		}
		stringBuilder.AppendLine();
		int num = 1;
		if (M2w2sruB4dDqKThf1cJ != null)
		{
			goto IL_00fc;
		}
		goto IL_0100;
		IL_00fc:
		int num2 = default(int);
		num = num2;
		goto IL_0100;
		IL_0100:
		do
		{
			switch (num)
			{
			case 1:
				stringBuilder.AppendFormat("ref-code: {0}\n", base.RefCode);
				if (string.IsNullOrEmpty(base.RefText))
				{
					break;
				}
				goto IL_00d4;
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
			IL_00d4:
			stringBuilder.AppendLine("ref-text:");
			stringBuilder.AppendLine(base.RefText);
			num = 0;
		}
		while (nDR4SvuvkXwv0UteTH6());
		goto IL_00fc;
	}

	internal static bool nDR4SvuvkXwv0UteTH6()
	{
		return M2w2sruB4dDqKThf1cJ == null;
	}
}
