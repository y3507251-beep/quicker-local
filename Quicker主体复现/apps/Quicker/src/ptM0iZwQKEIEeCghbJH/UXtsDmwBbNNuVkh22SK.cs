using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DmuKIFwWi8fjDRD9UF8;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.Triggers.Services;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace ptM0iZwQKEIEeCghbJH;

internal class UXtsDmwBbNNuVkh22SK : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec OkDvIFhQ32V;

		public static Func<CommonTriggerTask, bool> hYFvIU4MLAb;

		public static Func<CommonTriggerTask, bool> FMvvIl1mQtx;

		internal static _003C_003Ec V7DUDtcZZ93X5WyHE7xI;

		static _003C_003Ec()
		{
			OkDvIFhQ32V = new _003C_003Ec();
		}

		internal bool NDyvIAwDerC(CommonTriggerTask x)
		{
			return x.EventType == "ProcessExited";
		}

		internal bool kKCvIOotDto(CommonTriggerTask x)
		{
			return x.EventType == "ProcessStarted";
		}

		internal static bool NMTjy7cZ5jQ5YFTqeqkR()
		{
			return V7DUDtcZZ93X5WyHE7xI == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> c4xtto8XuSK = new Dictionary<string, string>
	{
		{ "ProcessStarted", "进程启动" },
		{ "ProcessExited", "进程退出" }
	};

	private FormField gpPttTkt8jA = new FormField
	{
		FieldKey = "ProcessName",
		Label = "进程名(必填)",
		DictVarType = VarType.Text,
		HelpText = "关注的进程名称，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = true,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectProcessName"
	};

	private ManagementEventWatcher hOJttMGZ1Zi;

	private ManagementEventWatcher gEgttA5neR0;

	private static UXtsDmwBbNNuVkh22SK P1EqaGQcRAIvvkh5l4QB;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return c4xtto8XuSK;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		if (string_1 == "ProcessStarted")
		{
			return new List<FormField> { gpPttTkt8jA };
		}
		if (string_1 == "ProcessExited")
		{
			return new List<FormField> { gpPttTkt8jA };
		}
		return new List<FormField>();
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "ProcessName",
				Desc = "进程名称",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "ExeName",
				Desc = "程序文件名",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "Pid",
				Desc = "进程的Pid",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "ExePath",
				Desc = "程序路径",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "PPId",
				Desc = "父进程的Pid",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "ProcCount",
				Desc = "当前进程数量",
				Type = VarType.Integer
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		hjpttBwImdF();
		if (pqcttjoQZJ4())
		{
			hOJttMGZ1Zi.Start();
		}
		if (FX6ttQhTOpb())
		{
			gEgttA5neR0.Start();
		}
	}

	protected override void C5rM2eDjuIN()
	{
		hOJttMGZ1Zi?.Stop();
		gEgttA5neR0?.Stop();
	}

	private ManagementEventWatcher bGbttpcm8Po()
	{
		ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher(new EventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE TargetInstance isa \"Win32_Process\""));
		managementEventWatcher.EventArrived += ProcessStarted;
		return managementEventWatcher;
	}

	private void hjpttBwImdF()
	{
		if (hOJttMGZ1Zi == null && pqcttjoQZJ4())
		{
			hOJttMGZ1Zi = bGbttpcm8Po();
		}
		if (gEgttA5neR0 == null && FX6ttQhTOpb())
		{
			gEgttA5neR0 = OMsttny5n1a();
		}
	}

	private bool FX6ttQhTOpb()
	{
		return jpqtg8Grl0b.Any(_003C_003Ec.hYFvIU4MLAb ?? (_003C_003Ec.hYFvIU4MLAb = _003C_003Ec.OkDvIFhQ32V.NDyvIAwDerC));
	}

	private bool pqcttjoQZJ4()
	{
		return jpqtg8Grl0b.Any(_003C_003Ec.FMvvIl1mQtx ?? (_003C_003Ec.FMvvIl1mQtx = _003C_003Ec.OkDvIFhQ32V.kKCvIOotDto));
	}

	private ManagementEventWatcher OMsttny5n1a()
	{
		string query = "SELECT *  FROM __InstanceDeletionEvent WITHIN  1  WHERE TargetInstance ISA 'Win32_Process' ";
		ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher("\\\\.\\root\\CIMV2", query);
		managementEventWatcher.EventArrived += iWett4xjmIX;
		return managementEventWatcher;
	}

	private void ProcessStarted(object sender, EventArrivedEventArgs e)
	{
		ManagementBaseObject managementBaseObject_ = (ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value;
		string string_ = pbNttD8Yd8x(managementBaseObject_);
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.EventType == "ProcessStarted" && BQMttdAdaGc(string_, item) && JVZtt5VqOBS(item, string_, managementBaseObject_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void iWett4xjmIX(object sender, EventArrivedEventArgs e)
	{
		ManagementBaseObject managementBaseObject_ = (ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value;
		string string_ = pbNttD8Yd8x(managementBaseObject_);
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.EventType == "ProcessExited" && BQMttdAdaGc(string_, item))
			{
				JVZtt5VqOBS(item, string_, managementBaseObject_);
				if (item.SkipFurtherTasks)
				{
					break;
				}
			}
		}
	}

	private bool JVZtt5VqOBS(CommonTriggerTask commonTriggerTask_0, string string_1, ManagementBaseObject managementBaseObject_0)
	{
		if (commonTriggerTask_0.z4dfFIlpLc())
		{
			string value = managementBaseObject_0.TryGetProperty("Name");
			string value2 = managementBaseObject_0.TryGetProperty("ExecutablePath");
			string value3 = managementBaseObject_0.TryGetProperty("ProcessId");
			string value4 = managementBaseObject_0.TryGetProperty("ParentProcessId");
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("ProcessName", string_1);
			int num = 0;
			if (P1EqaGQcRAIvvkh5l4QB != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				dictionary.Add("ExeName", value);
				dictionary.Add("Pid", value3);
				dictionary.Add("ExePath", value2);
				dictionary.Add("PPId", value4);
				dictionary.Add("ProcCount", Process.GetProcessesByName(string_1).Length);
				return iJ2tguv8HCS(commonTriggerTask_0, dictionary);
			}
		}
		return iJ2tguv8HCS(commonTriggerTask_0, null);
	}

	private static string pbNttD8Yd8x(ManagementBaseObject managementBaseObject_0)
	{
		string text = managementBaseObject_0.TryGetProperty("Name").ToLower();
		if (text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			text = text.Substring(0, text.Length - 4);
		}
		return text.ToLower();
	}

	private static bool BQMttdAdaGc(string string_1, CommonTriggerTask commonTriggerTask_0)
	{
		string text = commonTriggerTask_0.TryGetParamValue<string>("ProcessName", null);
		if (text != null)
		{
			if (text.StartsWith("regex:", StringComparison.OrdinalIgnoreCase))
			{
				if (new Regex(text.Substring(6)).IsMatch(string_1))
				{
					return true;
				}
			}
			else if (text.ToLower().Split(';').Contains(string_1))
			{
				return true;
			}
		}
		return false;
	}

	public UXtsDmwBbNNuVkh22SK()
		: base(new string[2] { "ProcessStarted", "ProcessExited" })
	{
	}

	internal static bool XwZqopQcgQtafYeCxIjH()
	{
		return P1EqaGQcRAIvvkh5l4QB == null;
	}
}
