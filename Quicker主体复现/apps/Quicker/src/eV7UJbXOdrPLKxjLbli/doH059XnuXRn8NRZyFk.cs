using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Utilities;
using Quicker.Utilities.Texting;

namespace eV7UJbXOdrPLKxjLbli;

internal static class doH059XnuXRn8NRZyFk
{
	private static IDictionary<string, string> hkTgZ967dQu;

	private static object j418iWQSOFyiqATOo7Gc;

	private static string EfxgZqgHuLn(string string_0)
	{
		return InternalTextProcessor.ComputeMd5Hash(string_0) + AppHelper.GetCurrAppShortVersion();
	}

	public static string uO7gZckltxx(string string_0)
	{
		string text = EfxgZqgHuLn(string_0);
		if (string.IsNullOrWhiteSpace(text))
		{
			return string.Empty;
		}
		(bool, string) tuple = ActionStateWriter.ReadActionStateValue("_cs_cache", text);
		if (tuple.Item1 && !hkTgZ967dQu.ContainsKey(tuple.Item2) && File.Exists(tuple.Item2))
		{
			return tuple.Item2;
		}
		return string.Empty;
	}

	public static void rMEgZV7dwv2(string string_0, string string_1)
	{
		if (!hkTgZ967dQu.ContainsKey(string_1))
		{
			string key = EfxgZqgHuLn(string_0);
			ActionStateWriter.WriteActionState("_cs_cache", key, string_1);
			hkTgZ967dQu[string_1] = "";
		}
	}

	public static void MhagZZtDHep()
	{
		ActionStateWriter.DeleteStateFile("_cs_cache");
	}

	static doH059XnuXRn8NRZyFk()
	{
		hkTgZ967dQu = new ConcurrentDictionary<string, string>();
	}

	internal static bool YEf1VAQSJTTsomVYRY4Z()
	{
		return j418iWQSOFyiqATOo7Gc == null;
	}
}
