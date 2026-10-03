using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class BucketResult : HttpResult
{
	private static BucketResult sehyk7uEXHA2cKvcNr6;

	public BucketInfo Result
	{
		get
		{
			BucketInfo result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				result = JsonConvert.DeserializeObject<BucketInfo>(base.Text);
			}
			return result;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code: {0}\n", base.Code);
		int num;
		if (Result != null)
		{
			stringBuilder.AppendLine("bucket-info:");
			stringBuilder.AppendFormat("tbl={0}\n", Result.tbl);
			stringBuilder.AppendFormat("zone={0}\n", Result.zone);
			num = 0;
			if (u1qFlguGlYeNWu9xYmd())
			{
				goto IL_00be;
			}
		}
		else
		{
			if (string.IsNullOrEmpty(base.Text))
			{
				goto IL_0110;
			}
			num = 0;
			if (!u1qFlguGlYeNWu9xYmd())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_00be;
		}
		stringBuilder.AppendLine("text:");
		stringBuilder.AppendLine(base.Text);
		goto IL_0110;
		IL_00be:
		stringBuilder.AppendFormat("region={0}\n", Result.region);
		stringBuilder.AppendFormat("isGlobal={0}\n", Result.global);
		stringBuilder.AppendFormat("isLine={0}\n", Result.line);
		goto IL_0110;
		IL_0110:
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
			foreach (KeyValuePair<string, string> item in base.RefInfo)
			{
				stringBuilder.AppendLine($"{item.Key}: {item.Value}");
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool u1qFlguGlYeNWu9xYmd()
	{
		return sehyk7uEXHA2cKvcNr6 == null;
	}

	internal static void LcE4yFuKkErhVv1KOXm()
	{
	}
}
