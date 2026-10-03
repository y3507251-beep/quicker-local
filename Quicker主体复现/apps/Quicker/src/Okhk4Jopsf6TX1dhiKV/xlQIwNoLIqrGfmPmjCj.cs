using System;
using System.IO;
using Newtonsoft.Json;
using Quicker.Actions.XActions.BuildinRunners.Network.Ai;
using Quicker.Utilities;

namespace Okhk4Jopsf6TX1dhiKV;

internal static class xlQIwNoLIqrGfmPmjCj
{
	internal static object lko7U2QzWgBRiQKGEIAP;

	private static string UkDgQRLVWAi()
	{
		return AppHelper.GetUserDataDir("AiLogs");
	}

	public static void Save(ChatSession session)
	{
		string path = UkDgQRLVWAi();
		string path2 = $"{session.CreateTime:yyyyMMddHHmmss}_{session.Id}.json";
		string path3 = Path.Combine(path, path2);
		string contents = JsonConvert.SerializeObject(session);
		File.WriteAllText(path3, contents);
	}

	public static ChatSession qiVgQqqkuN4(Guid guid_0)
	{
		string[] files = Directory.GetFiles(UkDgQRLVWAi(), $"*_{guid_0}.json");
		if (files.Length == 0)
		{
			return null;
		}
		return JsonConvert.DeserializeObject<ChatSession>(File.ReadAllText(files[0]));
	}

	internal static bool BA5D1nQzyNGQCs6DTsxx()
	{
		return lko7U2QzWgBRiQKGEIAP == null;
	}
}
