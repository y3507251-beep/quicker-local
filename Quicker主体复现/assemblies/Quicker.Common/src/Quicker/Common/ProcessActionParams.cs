using System;
using Newtonsoft.Json;

namespace Quicker.Common;

public class ProcessActionParams
{
	public const string PrefixString = "json:";

	public string FileName { get; set; }

	public string Arguments { get; set; }

	public bool RunAsAdmin { get; set; }

	public bool WaitForExit { get; set; }

	public string WindowStyle { get; set; }

	[Obsolete]
	public bool SetWorkingDir { get; set; }

	public string WorkingDir { get; set; }

	public string AlternativePaths { get; set; }

	public bool ActivateWindowIfRunning { get; set; }

	public string ActivateWindowHotkey { get; set; }

	public string GetWorkingDir()
	{
		if (WorkingDir == null)
		{
			if (!SetWorkingDir)
			{
				return "0";
			}
			return "1";
		}
		return WorkingDir;
	}

	public static ProcessActionParams FromActionItem(ActionItem action)
	{
		if (action != null && !string.IsNullOrEmpty(action.Data))
		{
			if (action.Data.StartsWith("json:", StringComparison.InvariantCultureIgnoreCase))
			{
				return JsonConvert.DeserializeObject<ProcessActionParams>(action.Data.Substring("json:".Length));
			}
			return new ProcessActionParams
			{
				FileName = action.Data,
				Arguments = action.Data2,
				RunAsAdmin = (action.Data3 == "true"),
				WaitForExit = false
			};
		}
		return new ProcessActionParams();
	}

	public string ToDataString()
	{
		return "json:" + JsonConvert.SerializeObject(this);
	}
}
