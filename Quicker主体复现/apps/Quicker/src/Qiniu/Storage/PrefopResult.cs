using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class PrefopResult : HttpResult
{
	internal static PrefopResult eWp1qjo9NIQjvgUUju5;

	public PfopInfo Result
	{
		get
		{
			PfopInfo result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				result = JsonConvert.DeserializeObject<PfopInfo>(base.Text);
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
			int num2 = default(int);
			while (true)
			{
				if (string.IsNullOrEmpty(base.Text))
				{
					int num = 0;
					if (eWp1qjo9NIQjvgUUju5 != null)
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						continue;
					}
				}
				else
				{
					stringBuilder.AppendLine("text:");
					stringBuilder.AppendLine(base.Text);
				}
				break;
			}
		}
		else
		{
			stringBuilder.AppendFormat("result: {0}\n", JsonConvert.SerializeObject(Result));
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat("ref-code:{0}\n", base.RefCode);
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
				stringBuilder.AppendLine($"{item.Key}:{item.Value}");
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool wiW5mCoL1vFYyWb22Ht()
	{
		return eWp1qjo9NIQjvgUUju5 == null;
	}
}
