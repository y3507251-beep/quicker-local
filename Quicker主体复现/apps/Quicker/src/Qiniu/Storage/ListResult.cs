using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class ListResult : HttpResult
{
	private static ListResult s4L2P6oykQbXolI7I4a;

	public ListInfo Result
	{
		get
		{
			ListInfo result = null;
			if (base.Code == 200 && !string.IsNullOrEmpty(base.Text))
			{
				result = JsonConvert.DeserializeObject<ListInfo>(base.Text);
			}
			return result;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code: {0}\n", base.Code);
		int num2 = default(int);
		while (true)
		{
			if (Result == null)
			{
				if (!string.IsNullOrEmpty(base.Text))
				{
					stringBuilder.AppendLine("text:");
					stringBuilder.AppendLine(base.Text);
				}
				goto IL_018e;
			}
			if (Result.CommonPrefixes != null)
			{
				stringBuilder.Append("commonPrefixes:");
				foreach (string commonPrefix in Result.CommonPrefixes)
				{
					stringBuilder.AppendFormat("{0} ", commonPrefix);
				}
				goto IL_0076;
			}
			goto IL_007e;
			IL_018e:
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("ref-code: {0}\n", base.RefCode);
			if (string.IsNullOrEmpty(base.RefText))
			{
				break;
			}
			int num = 1;
			if (s4L2P6oykQbXolI7I4a != null)
			{
				num = num2;
			}
			switch (num)
			{
			case 2:
				continue;
			case 1:
				goto IL_0236;
			}
			goto IL_0076;
			IL_007e:
			if (!string.IsNullOrEmpty(Result.Marker))
			{
				stringBuilder.AppendFormat("marker: {0}\n", Result.Marker);
			}
			if (Result.Items != null)
			{
				stringBuilder.AppendLine("items:");
				int num3 = 0;
				int count = Result.Items.Count;
				foreach (ListItem item in Result.Items)
				{
					stringBuilder.AppendFormat("#{0}/{1}:Key={2}, Size={3}, Mime={4}, Hash={5}, Time={6}, Type={7}\n", ++num3, count, item.Key, item.Fsize, item.MimeType, item.Hash, item.PutTime, item.FileType);
				}
			}
			goto IL_018e;
			IL_0236:
			stringBuilder.AppendLine("ref-text:");
			stringBuilder.AppendLine(base.RefText);
			break;
			IL_0076:
			stringBuilder.AppendLine();
			goto IL_007e;
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
	}

	internal static bool Ja8wJFopUHH8kF4rHBc()
	{
		return s4L2P6oykQbXolI7I4a == null;
	}
}
