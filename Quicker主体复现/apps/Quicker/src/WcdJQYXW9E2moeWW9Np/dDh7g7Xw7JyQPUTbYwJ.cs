using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using log4net;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Entities;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;

namespace WcdJQYXW9E2moeWW9Np;

internal class dDh7g7Xw7JyQPUTbYwJ
{
	private static readonly ILog VjWtHijoJFd;

	[CompilerGenerated]
	private string r8dtH37SrQH;

	internal static dDh7g7Xw7JyQPUTbYwJ GUk4c7QaIPOjnmeDjSwP;

	internal static bool ExpandAdvancedParams
	{
		get
		{
			return OYqtHVkiqkn("ExpandAdvancedParams", "0") == "1";
		}
		set
		{
			SetValue("ExpandAdvancedParams", value ? "1" : "0");
		}
	}

	internal static Point? SearchWindowLocation
	{
		get
		{
			string text = OYqtHVkiqkn("SearchWindowLocation");
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			try
			{
				string[] array = text.Split(',');
				return new Point(double.Parse(array[0]), double.Parse(array[1]));
			}
			catch (Exception)
			{
				return null;
			}
		}
		set
		{
			SetValue("SearchWindowLocation", value.HasValue ? $"{value.Value.X},{value.Value.Y}" : "");
		}
	}

	internal static double? SearchWindowWidth
	{
		get
		{
			string text = OYqtHVkiqkn("SearchWindowWidth");
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			if (double.TryParse(text, out var result))
			{
				return result;
			}
			return null;
		}
		set
		{
			object obj;
			if (!value.HasValue)
			{
				obj = null;
			}
			else
			{
				obj = value.GetValueOrDefault().ToString();
				if (obj != null)
				{
					goto IL_0029;
				}
			}
			obj = "";
			goto IL_0029;
			IL_0029:
			SetValue("SearchWindowWidth", (string)obj);
		}
	}

	internal static DateTime? LastStartupTime
	{
		get
		{
			string value = OYqtHVkiqkn("LastStartupTime");
			if (!string.IsNullOrEmpty(value))
			{
				try
				{
					return new DateTime(Convert.ToInt64(value));
				}
				catch
				{
					return null;
				}
			}
			return null;
		}
		set
		{
			object obj;
			if (!value.HasValue)
			{
				obj = null;
			}
			else
			{
				obj = value.GetValueOrDefault().Ticks.ToString();
				if (obj != null)
				{
					goto IL_0031;
				}
			}
			obj = "";
			goto IL_0031;
			IL_0031:
			SetValue("LastStartupTime", (string)obj);
		}
	}

	internal static bool HideTextCommandSummary
	{
		get
		{
			string b = OYqtHVkiqkn("HideTextCommandSummary", "0");
			return string.Equals("1", b);
		}
		set
		{
			SetValue("HideTextCommandSummary", value ? "1" : "0");
		}
	}

	internal static bool SortGlobalSpByLastEditTime
	{
		get
		{
			string b = OYqtHVkiqkn("SortGlobalSpByLastEditTime", "0");
			return string.Equals("1", b);
		}
		set
		{
			SetValue("SortGlobalSpByLastEditTime", value ? "1" : "0");
		}
	}

	internal static LocalSettings LocalSettings
	{
		get
		{
			string value = OYqtHVkiqkn("LocalSettings");
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			return JsonConvert.DeserializeObject<LocalSettings>(value);
		}
		set
		{
			SetValue("LocalSettings", JsonConvert.SerializeObject(value));
		}
	}

	internal static double? CompletionWindowWidth
	{
		get
		{
			string text = OYqtHVkiqkn("CompletionWindowWidth");
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			if (double.TryParse(text, out var result))
			{
				return result;
			}
			return null;
		}
		set
		{
			object obj;
			if (!value.HasValue)
			{
				obj = null;
			}
			else
			{
				obj = value.GetValueOrDefault().ToString();
				if (obj != null)
				{
					goto IL_0029;
				}
			}
			obj = "";
			goto IL_0029;
			IL_0029:
			SetValue("CompletionWindowWidth", (string)obj);
		}
	}

	public static int LocalOcrKeepAliveSeconds
	{
		get
		{
			string text = OYqtHVkiqkn("LocalOcrKeepAliveSeconds");
			if (string.IsNullOrWhiteSpace(text))
			{
				return 120;
			}
			if (int.TryParse(text, out var result))
			{
				return result;
			}
			return 120;
		}
		set
		{
			SetValue("LocalOcrKeepAliveSeconds", value.ToString());
		}
	}

	public static int ViewStaticDays
	{
		get
		{
			string text = OYqtHVkiqkn("ViewStaticDays");
			if (string.IsNullOrWhiteSpace(text))
			{
				return -1;
			}
			if (int.TryParse(text, out var result))
			{
				return result;
			}
			return -1;
		}
		set
		{
			SetValue("ViewStaticDays", value.ToString());
		}
	}

	public static string NoCreateProfilePromptProcesses
	{
		get
		{
			return OYqtHVkiqkn("NoCreateProfilePromptProcesses");
		}
		private set
		{
			SetValue("NoCreateProfilePromptProcesses", value);
		}
	}

	private static string OYqtHVkiqkn(string string_1, string string_2 = "")
	{
		try
		{
			(bool, string) tuple = ActionStateWriter.ReadActionStateValue("_local_app_state", string_1);
			if (tuple.Item1)
			{
				return tuple.Item2;
			}
			return string_2;
		}
		catch (Exception ex)
		{
			VjWtHijoJFd.Warn("读取LocalStateManager数据出错：" + ex.Message, ex);
			return string_2;
		}
	}

	private static void SetValue(string key, string value)
	{
		ActionStateWriter.WriteActionState("_local_app_state", key, value);
	}

	[SpecialName]
	internal static SettingPageId? BWhtHHAiaSf()
	{
		string value = OYqtHVkiqkn("LastSettingPage");
		if (!string.IsNullOrEmpty(value) && Enum.TryParse<SettingPageId>(value, out var result))
		{
			return result;
		}
		return null;
	}

	[SpecialName]
	internal static void tC9tH1ELoWJ(SettingPageId? nullable_0)
	{
		object obj;
		if (!nullable_0.HasValue)
		{
			obj = null;
		}
		else
		{
			obj = nullable_0.GetValueOrDefault().ToString();
			if (obj != null)
			{
				goto IL_002f;
			}
		}
		obj = "";
		goto IL_002f;
		IL_002f:
		SetValue("LastSettingPage", (string)obj);
	}

	[SpecialName]
	internal static IList<string> okJtHx8iWyG()
	{
		return OYqtHVkiqkn("RecentActions").SplitToList();
	}

	[SpecialName]
	internal static void UVhtHrfISJb(IList<string> ilist_0)
	{
		SetValue("RecentActions", ilist_0.HasData() ? string.Join("\r\n", ilist_0) : "");
	}

	[SpecialName]
	internal static string TXntHBXc65x()
	{
		return OYqtHVkiqkn("pythonDllPath");
	}

	[SpecialName]
	internal static void GJctHQ0XIpa(string string_1)
	{
		SetValue("pythonDllPath", string_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public string tEutHdjARa8()
	{
		return r8dtH37SrQH;
	}

	[SpecialName]
	[CompilerGenerated]
	public void BZPtHoCBnVF(string string_1)
	{
		r8dtH37SrQH = string_1;
	}

	public static void csttHZWbl6L(string string_1)
	{
		string_1 = string_1.ToLower();
		List<string> list = NoCreateProfilePromptProcesses.SplitToList().ToList();
		if (!list.Contains(string_1))
		{
			list.Add(string_1);
			NoCreateProfilePromptProcesses = "|" + string.Join("|", list) + "|";
		}
	}

	public static bool FJLtH9XuchQ(string string_1)
	{
		return NoCreateProfilePromptProcesses.Contains("|" + string_1.ToLower() + "|");
	}

	static dDh7g7Xw7JyQPUTbYwJ()
	{
		VjWtHijoJFd = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool c280fPQa6eSHH8nvR5ro()
	{
		return GUk4c7QaIPOjnmeDjSwP == null;
	}
}
