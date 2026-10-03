using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class FetchResult : HttpResult
{
	private static FetchResult aVRqYWuPQCGKTWVnL33;

	public FetchInfo Result
	{
		get
		{
			FetchInfo result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				result = JsonConvert.DeserializeObject<FetchInfo>(base.Text);
			}
			return result;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code: {0}\n", base.Code);
		if (Result == null)
		{
			if (!string.IsNullOrEmpty(base.Text))
			{
				stringBuilder.AppendLine("text:");
				if (aVRqYWuPQCGKTWVnL33 == null)
				{
					switch (0)
					{
					case 1:
						goto IL_0167;
					}
				}
				stringBuilder.AppendLine(base.Text);
			}
		}
		else
		{
			stringBuilder.AppendFormat("Key={0}, Size={1}, Type={2}, Hash={3}\n", Result.Key, Result.Fsize, Result.MimeType, Result.Hash);
		}
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
		goto IL_0167;
		IL_0167:
		return stringBuilder.ToString();
	}

	internal static bool Q1USsKuMERwf7IjHD7r()
	{
		return aVRqYWuPQCGKTWVnL33 == null;
	}
}
