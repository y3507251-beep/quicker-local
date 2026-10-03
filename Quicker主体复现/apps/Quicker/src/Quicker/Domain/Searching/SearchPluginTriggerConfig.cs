using System;
using System.Runtime.CompilerServices;
using Quicker.Public.Searching;

namespace Quicker.Domain.Searching;

public class SearchPluginTriggerConfig
{
	[CompilerGenerated]
	private SearchPluginTriggerMode zrbteDaw8ac;

	[CompilerGenerated]
	private string ogttedcHbSD;

	private static SearchPluginTriggerConfig Ht6JA9QdYFgsYPuhdl5e;

	public SearchPluginTriggerMode TriggerMode
	{
		[CompilerGenerated]
		get
		{
			return zrbteDaw8ac;
		}
		[CompilerGenerated]
		set
		{
			zrbteDaw8ac = value;
		}
	}

	public string Trigger
	{
		[CompilerGenerated]
		get
		{
			return ogttedcHbSD;
		}
		[CompilerGenerated]
		set
		{
			ogttedcHbSD = value;
		}
	}

	public SearchPluginTriggerConfig(SearchPluginTriggerMode mode, string trigger)
	{
		TriggerMode = mode;
		Trigger = trigger;
		if (mode == SearchPluginTriggerMode.SpecialChar && Trigger.Length != 1)
		{
			throw new InvalidOperationException("不合法的触发模式：没有指定触发字符");
		}
		if (mode == SearchPluginTriggerMode.KeywordWithSpace && string.IsNullOrEmpty(trigger))
		{
			throw new InvalidOperationException("不合法的触发模式：没有指定触发关键词");
		}
	}

	internal static bool aEnHgoQd8U5HbWSl82TO()
	{
		return Ht6JA9QdYFgsYPuhdl5e == null;
	}
}
