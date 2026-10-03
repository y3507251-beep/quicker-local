using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace wwbmqGwON3D9BxqCkYx;

internal class cEquwXwn27y7jERmTG4 : kWjRPcwItwkeAamARyg
{
	private static readonly ILog Ylettu7vGkU;

	[CompilerGenerated]
	private readonly IDictionary<string, string> A2ettNGj9oS = new Dictionary<string, string> { { "FileSystemChange", "文件系统事件" } };

	private FormField sDHttJuX8Ox = new FormField
	{
		FieldKey = "Path",
		Label = "路径",
		DictVarType = VarType.Text,
		HelpText = "监控的路径",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = $"{TextToolType.SelectSingleFolder}"
	};

	private FormField ERAtt0yNiJb = new FormField
	{
		FieldKey = "Filter",
		Label = "文件筛选器",
		DictVarType = VarType.Text,
		HelpText = "如*.*（监控所有文件）或*.txt（仅监控文本文件）。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox
	};

	private FormField U23ttCkEWFV = new FormField
	{
		FieldKey = "IncludeSubdirectories",
		Label = "包含子目录",
		DictVarType = VarType.Boolean,
		HelpText = "是否监控子目录中的文件",
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField BUqttPuFVp7 = new FormField
	{
		FieldKey = "WatchCreated",
		Label = "监控文件创建事件",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField tpAttEe118M = new FormField
	{
		FieldKey = "WatchChanged",
		Label = "监控文件修改事件",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField BVItty8RI8J = new FormField
	{
		FieldKey = "WatchDeleted",
		Label = "监控文件删除事件",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField iCCtt8xU6rA = new FormField
	{
		FieldKey = "WatchRenamed",
		Label = "监控文件重命名事件",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private FormField VDGtta3VDk7 = new FormField
	{
		FieldKey = "WatchError",
		Label = "监控错误事件",
		DictVarType = VarType.Boolean,
		IsRequired = false,
		InputMethod = InputMethod.CheckBox
	};

	private IDictionary<FileSystemWatcher, CommonTriggerTask> fwjtt727dcI = new Dictionary<FileSystemWatcher, CommonTriggerTask>();

	private static cEquwXwn27y7jERmTG4 tes9qKQceqhX6kyNEoZV;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return A2ettNGj9oS;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { sDHttJuX8Ox, ERAtt0yNiJb, U23ttCkEWFV, BUqttPuFVp7, tpAttEe118M, BVItty8RI8J, iCCtt8xU6rA, VDGtta3VDk7 };
	}

	public override IDictionary<string, object> kLIM2b7eEDv(string string_1)
	{
		return new Dictionary<string, object>
		{
			{ "Filter", "*.*" },
			{ "WatchCreated", true },
			{ "WatchChanged", false },
			{ "WatchDeleted", false },
			{ "WatchRenamed", false },
			{ "WatchError", false }
		};
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "ChangeType",
				Desc = "变更类型。可能为：Created/Deleted/Changed/Renamed",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "Name",
				Desc = "受影响的文件名或目录名",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "FullPath",
				Desc = "受影响的文件或目录的完整路径",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "OldName",
				Desc = "旧名称",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "OldFullPath",
				Desc = "旧完整路径",
				Type = VarType.Text
			}
		};
	}

	public cEquwXwn27y7jERmTG4()
		: base(new string[1] { "FileSystemChange" })
	{
	}

	protected override void fb3M2Rxtx1E()
	{
		TWGttwLc2k6();
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			AETtwzqeAQ7(item);
		}
	}

	private void AETtwzqeAQ7(CommonTriggerTask commonTriggerTask_0)
	{
		string text = commonTriggerTask_0.TryGetParamValue("Path", "");
		if (text.Contains('%'))
		{
			text = Environment.ExpandEnvironmentVariables(text);
		}
		int num;
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		FileSystemWatcher fileSystemWatcher = default(FileSystemWatcher);
		if (!Directory.Exists(text))
		{
			num = 1;
			if (tes9qKQceqhX6kyNEoZV != null)
			{
				goto IL_0126;
			}
		}
		else
		{
			string filter = commonTriggerTask_0.TryGetParamValue("Filter", "*.*");
			bool includeSubdirectories = commonTriggerTask_0.TryGetParamValue("IncludeSubdirectories", false);
			bool num2 = commonTriggerTask_0.TryGetParamValue("WatchCreated", true);
			bool flag = commonTriggerTask_0.TryGetParamValue("WatchDeleted", false);
			bool flag2 = commonTriggerTask_0.TryGetParamValue("WatchChanged", false);
			flag3 = commonTriggerTask_0.TryGetParamValue("WatchRenamed", false);
			flag4 = commonTriggerTask_0.TryGetParamValue("WatchError", false);
			fileSystemWatcher = new FileSystemWatcher(text)
			{
				Filter = filter,
				IncludeSubdirectories = includeSubdirectories
			};
			if (num2)
			{
				fileSystemWatcher.Created += LbRttS0v3bn;
			}
			if (flag)
			{
				fileSystemWatcher.Deleted += RZ1tttwaaPd;
			}
			if (!flag2)
			{
				goto IL_0142;
			}
			fileSystemWatcher.Changed += eegttvxiDSG;
			num = 0;
			if (!qqZyDVQcjpiFkGHFjhRV())
			{
				int num3 = default(int);
				num = num3;
			}
		}
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0142;
		}
		goto IL_0126;
		IL_0126:
		Ylettu7vGkU.Warn("路径 '" + text + "' 不存在，因此无法创建监控器。");
		return;
		IL_0142:
		if (flag3)
		{
			fileSystemWatcher.Renamed += NCPttLbboQ5;
		}
		if (flag4)
		{
			fileSystemWatcher.Error += kwitt2lT3TF;
		}
		fileSystemWatcher.EnableRaisingEvents = true;
		fwjtt727dcI.Add(fileSystemWatcher, commonTriggerTask_0);
	}

	protected override void C5rM2eDjuIN()
	{
		TWGttwLc2k6();
	}

	private void TWGttwLc2k6()
	{
		foreach (FileSystemWatcher key in fwjtt727dcI.Keys)
		{
			key.EnableRaisingEvents = false;
			key.Error -= kwitt2lT3TF;
			key.Created -= LbRttS0v3bn;
			key.Changed -= eegttvxiDSG;
			key.Renamed -= NCPttLbboQ5;
			key.Deleted -= RZ1tttwaaPd;
			key.Dispose();
		}
		fwjtt727dcI.Clear();
	}

	private void RZ1tttwaaPd(object sender, FileSystemEventArgs e)
	{
		ljEttgboaVq(sender, e);
	}

	private void ljEttgboaVq(object sender, FileSystemEventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{
				"ChangeType",
				e.ChangeType.ToString()
			},
			{ "Name", e.Name },
			{ "FullPath", e.FullPath }
		};
		if (e is RenamedEventArgs e2)
		{
			dictionary["OldName"] = e2.OldName;
			dictionary["OldFullPath"] = e2.OldFullPath;
		}
		else
		{
			dictionary["OldName"] = "";
			dictionary["OldFullPath"] = "";
		}
		CommonTriggerTask value;
		if (!(sender is FileSystemWatcher key))
		{
			int num = 0;
			if (!qqZyDVQcjpiFkGHFjhRV())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (fwjtt727dcI.TryGetValue(key, out value))
		{
			iJ2tguv8HCS(value, dictionary);
		}
	}

	private void NCPttLbboQ5(object sender, RenamedEventArgs e)
	{
		ljEttgboaVq(sender, e);
	}

	private void eegttvxiDSG(object sender, FileSystemEventArgs e)
	{
		ljEttgboaVq(sender, e);
	}

	private void LbRttS0v3bn(object sender, FileSystemEventArgs e)
	{
		ljEttgboaVq(sender, e);
	}

	private void kwitt2lT3TF(object sender, ErrorEventArgs e)
	{
		Exception exception = e.GetException();
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{ "ChangeType", "Error" },
			{ "Name", exception.Message },
			{ "FullPath", "" }
		};
		dictionary["OldName"] = "";
		dictionary["OldFullPath"] = "";
		if (sender is FileSystemWatcher key && fwjtt727dcI.TryGetValue(key, out var value))
		{
			iJ2tguv8HCS(value, dictionary);
		}
	}

	static cEquwXwn27y7jERmTG4()
	{
		Ylettu7vGkU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool qqZyDVQcjpiFkGHFjhRV()
	{
		return tes9qKQceqhX6kyNEoZV == null;
	}

	internal static void cIM3MeQcGQPB2OKQItKr()
	{
	}
}
