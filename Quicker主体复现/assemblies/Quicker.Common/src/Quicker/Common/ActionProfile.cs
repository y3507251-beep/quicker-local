using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Quicker.Common;

public class ActionProfile
{
	public const string DEFAULT_PROFILE_NAME = "_default";

	public const string GLOBAL_PROFILE_NAME = "_global";

	public const string ExeName_Global = "_global";

	public const string ExeName_Common = "common";

	public const string ExeName_SubProgram = "subprogram";

	public const string ExeName_Taskbar = "taskbar";

	public const string ExeName_Desktop = "desktop";

	public string Name { get; set; }

	public int? FileVersionId { get; set; }

	public string DisplayName
	{
		get
		{
			if (Name == "_default")
			{
				return "默认";
			}
			if (Name == "_global")
			{
				return "默认全局动作页";
			}
			return Name;
		}
	}

	public string Id { get; set; }

	public DateTime? LastUpdateTimeUtc { get; set; }

	public ProfileType ProfileType { get; set; }

	public string ExeFile { get; set; } = "";

	public bool MatchFullPath { get; set; }

	public string ExeFullpath { get; set; }

	public int ListOrder { get; set; }

	public IList<ActionItem> ActionItems { get; set; } = new List<ActionItem>();

	public string AliasOfProfile { get; set; }

	public ProfileSettings Settings { get; set; } = new ProfileSettings();

	public string[] SharedActionIds { get; set; }

	[JsonIgnore]
	public bool IsVirtual { get; set; }

	[JsonIgnore]
	public string ExeDisplayName
	{
		get
		{
			if (string.Equals(ExeFile, "taskbar", StringComparison.OrdinalIgnoreCase))
			{
				return "Windows任务栏";
			}
			if (string.Equals(ExeFile, "desktop", StringComparison.OrdinalIgnoreCase))
			{
				return "Windows桌面";
			}
			if (string.Equals(ExeFile, "_global", StringComparison.OrdinalIgnoreCase))
			{
				return "全局";
			}
			if (string.Equals(ExeFile, "common", StringComparison.OrdinalIgnoreCase))
			{
				return "通用";
			}
			return ExeFile.ToLowerInvariant();
		}
	}

	[JsonIgnore]
	public string ValidForMachines => Settings?.ValidForMachines ?? null;

	public void FixExeName()
	{
		if (string.IsNullOrEmpty(ExeFile))
		{
			if ("_global" == Name)
			{
				ExeFile = "_global";
			}
			else
			{
				ExeFile = "common";
			}
		}
	}
}
