using System.Collections.Generic;
using Quicker.Public.Searching;

namespace Quicker.Common.Entities;

public class SearchSettings
{
	public string ImeControl { get; set; }

	public int HintTriggerKey { get; set; } = 112;

	public int MaxVisibleItemCount { get; set; } = 8;

	public bool EnableCacheWords { get; set; }

	public string SearchSettingTrigger { get; set; }

	public string DefaultSearchProcessor { get; set; } = "%s";

	public double AutoFillClipTextSeconds { get; set; }

	public int AutoFillMaxLength { get; set; } = 20;

	public IList<SearchPluginSettings> PluginSettings { get; set; } = new List<SearchPluginSettings>();

	public bool ShowFileThumbnail { get; set; }

	public bool LoadPrevSearchText { get; set; }
}
