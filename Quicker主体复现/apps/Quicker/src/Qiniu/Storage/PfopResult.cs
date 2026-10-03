using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class PfopResult : HttpResult
{
	internal static PfopResult gVrVBroJwH2qe6lFBdp;

	public string PersistentId
	{
		get
		{
			string result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(base.Text);
				if (dictionary.ContainsKey("persistentId"))
				{
					result = dictionary["persistentId"];
				}
			}
			return result;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code: {0}\n", base.Code);
		if (string.IsNullOrEmpty(PersistentId))
		{
			if (!string.IsNullOrEmpty(base.Text))
			{
				stringBuilder.AppendLine("text:");
				stringBuilder.AppendLine(base.Text);
			}
		}
		else
		{
			stringBuilder.AppendFormat("PersistentId: {0}\n", PersistentId);
		}
		stringBuilder.AppendLine();
		int num = 0;
		if (gVrVBroJwH2qe6lFBdp != null)
		{
			int num2 = default(int);
			num = num2;
		}
		Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				stringBuilder.AppendFormat("ref-code:{0}\n", base.RefCode);
				if (!string.IsNullOrEmpty(base.RefText))
				{
					stringBuilder.AppendLine("ref-text:");
					stringBuilder.AppendLine(base.RefText);
				}
				if (base.RefInfo == null)
				{
					break;
				}
				stringBuilder.AppendFormat("ref-info:\n");
				enumerator = base.RefInfo.GetEnumerator();
				num = 1;
				if (gVrVBroJwH2qe6lFBdp != null)
				{
					continue;
				}
				goto case 1;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.Current;
						stringBuilder.AppendLine($"{current.Key}:{current.Value}");
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				break;
			}
			break;
		}
		return stringBuilder.ToString();
	}

	internal static bool jgq1amok5iUNGenO0G4()
	{
		return gVrVBroJwH2qe6lFBdp == null;
	}
}
