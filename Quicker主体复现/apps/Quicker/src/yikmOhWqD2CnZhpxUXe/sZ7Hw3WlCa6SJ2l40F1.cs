using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DmuKIFwWi8fjDRD9UF8;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using YDnFyFwG4PlN0Cedwny;

namespace yikmOhWqD2CnZhpxUXe;

internal class sZ7Hw3WlCa6SJ2l40F1 : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec mKGvWZT27nL;

		public static Func<CommonTriggerTask, bool> cjKvW97j6bQ;

		internal static _003C_003Ec CKr33icZH9Q0ufOOsnww;

		static _003C_003Ec()
		{
			mKGvWZT27nL = new _003C_003Ec();
		}

		internal bool mFZvWVhKOXF(CommonTriggerTask x)
		{
			if (!(x.EventType == "WindowActivated"))
			{
				return x.EventType == "WindowDeactivated";
			}
			return true;
		}

		internal static bool Nm9GsScZzoANKblxoIEZ()
		{
			return CKr33icZH9Q0ufOOsnww == null;
		}

		internal static void R6Y1gwc5QMMxm2GLi17H()
		{
		}
	}

	[CompilerGenerated]
	internal new sealed class _003C_003Ec__DisplayClass23_0
	{
		public bool OW3vWY3aVXU;

		public bool U7JvWIlibh8;

		public sZ7Hw3WlCa6SJ2l40F1 iEFvWWfGJTf;

		public ActiveWindowChangedEventArgs Fr7vWkUgBTN;

		private static _003C_003Ec__DisplayClass23_0 NHxNPjc5FPfBdhFmEC9J;

		internal bool UEkvWh7gsDC(CommonTriggerTask x)
		{
			return !ETKtg1ZMFA1(x, OW3vWY3aVXU, U7JvWIlibh8);
		}

		internal void jwuvWeGtWaR()
		{
			int num2 = default(int);
			foreach (CommonTriggerTask item in iEFvWWfGJTf.jpqtg8Grl0b)
			{
				if (!ETKtg1ZMFA1(item, OW3vWY3aVXU, U7JvWIlibh8))
				{
					continue;
				}
				if (item.EventType == "WindowActivated")
				{
					if (Fr7vWkUgBTN.ActivatedWindow != null && iEFvWWfGJTf.ImStg6MIeti(Fr7vWkUgBTN.ActivatedWindow, item.TryGetParamValue<string>("WindowTitle", null), item.TryGetParamValue<string>("WindowClass", null), item.TryGetParamValue<string>("ProcessName", null)) && iEFvWWfGJTf.yIitgbXmKqZ(item, Fr7vWkUgBTN) && item.SkipFurtherTasks)
					{
						break;
					}
				}
				else if (item.EventType == "WindowDeactivated" && Fr7vWkUgBTN.DeactivatedWindow != null && iEFvWWfGJTf.ImStg6MIeti(Fr7vWkUgBTN.DeactivatedWindow, item.TryGetParamValue<string>("WindowTitle", null), item.TryGetParamValue<string>("WindowClass", null), item.TryGetParamValue<string>("ProcessName", null)) && iEFvWWfGJTf.yIitgbXmKqZ(item, Fr7vWkUgBTN) && item.SkipFurtherTasks)
				{
					int num = 0;
					if (!PnCJShc5c1685WjGqZbt())
					{
						num = num2;
					}
					switch (num)
					{
					}
					break;
				}
			}
		}

		internal static bool PnCJShc5c1685WjGqZbt()
		{
			return NHxNPjc5FPfBdhFmEC9J == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> DsRtgXD1uHu = new Dictionary<string, string>
	{
		{ "WindowActivated", "窗口获得焦点" },
		{ "WindowDeactivated", "窗口失去焦点" }
	};

	private FormField M5atgmJusmW = new FormField
	{
		FieldKey = "ProcessName",
		Label = "进程名",
		DictVarType = VarType.Text,
		HelpText = "关注的进程名称，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectProcessName",
		ExtraSettings = "ttmode:;"
	};

	private FormField gP9tgK655hp = new FormField
	{
		FieldKey = "WindowTitle",
		Label = "窗口标题",
		DictVarType = VarType.Text,
		HelpText = "关注的窗口标题，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectWindowTitle"
	};

	private FormField QBZtgxGcmh1 = new FormField
	{
		FieldKey = "WindowClass",
		Label = "窗口类名",
		DictVarType = VarType.Text,
		HelpText = "关注的窗口类名，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectWindowClass",
		ExtraSettings = "ttmode:;"
	};

	private FormField uyftgr8fWxi = new FormField
	{
		FieldKey = "ProcChangeCondition",
		Label = "进程变化条件",
		DictVarType = VarType.Enum,
		HelpText = "是否需要进程也发生改变才触发事件",
		IsRequired = false,
		InputMethod = InputMethod.DropDown,
		SelectionItems = "不判断 (窗口不同即触发)|NA\r\n进程变化 (同一个进程的窗口切换不触发)|Pid\r\n程序变化 (同一个程序即使不是同一个进程，切换窗口时也不触发)|ProcName",
		DefaultValue = "NA"
	};

	private IntPtr qlZtgpCJVPe = IntPtr.Zero;

	internal static sZ7Hw3WlCa6SJ2l40F1 dh8Os1QW1j2O7Ari0hwQ;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return DsRtgXD1uHu;
	}

	public sZ7Hw3WlCa6SJ2l40F1()
		: base(new string[2] { "WindowActivated", "WindowDeactivated" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { gP9tgK655hp, QBZtgxGcmh1, M5atgmJusmW, uyftgr8fWxi };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		List<ActionVariable> list = new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "Handle",
				Desc = "窗口句柄",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "WindowTitle",
				Desc = "窗口标题",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "WindowClass",
				Desc = "窗口类名",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "ProcessName",
				Desc = "进程名称",
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
			}
		};
		if (!(string_1 == "WindowActivated"))
		{
			if (string_1 == "WindowDeactivated")
			{
				list.AddRange(new List<ActionVariable>
				{
					new ActionVariable
					{
						Key = "NewHandle",
						Desc = "新的窗口句柄",
						Type = VarType.Text
					},
					new ActionVariable
					{
						Key = "NewWindowTitle",
						Desc = "新的窗口标题",
						Type = VarType.Text
					},
					new ActionVariable
					{
						Key = "NewWindowClass",
						Desc = "新的窗口类名",
						Type = VarType.Text
					},
					new ActionVariable
					{
						Key = "NewProcessName",
						Desc = "新的进程名称",
						Type = VarType.Text
					},
					new ActionVariable
					{
						Key = "NewPid",
						Desc = "新的进程的Pid",
						Type = VarType.Text
					},
					new ActionVariable
					{
						Key = "NewExePath",
						Desc = "新的程序路径",
						Type = VarType.Text
					}
				});
			}
		}
		else
		{
			list.AddRange(new List<ActionVariable>
			{
				new ActionVariable
				{
					Key = "OldHandle",
					Desc = "前一个窗口句柄",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "OldWindowTitle",
					Desc = "前一个窗口标题",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "OldWindowClass",
					Desc = "前一个窗口类名",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "OldProcessName",
					Desc = "前一个进程名称",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "OldPid",
					Desc = "前一个进程的Pid",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "OldExePath",
					Desc = "前一个程序路径",
					Type = VarType.Text
				}
			});
		}
		return list;
	}

	protected override void fb3M2Rxtx1E()
	{
		AppState.r4itaWBnyVQ().ForegroundWindowChanged -= ppQtgHUjHvT;
		if (jpqtg8Grl0b.Any(_003C_003Ec.cjKvW97j6bQ ?? (_003C_003Ec.cjKvW97j6bQ = _003C_003Ec.mKGvWZT27nL.mFZvWVhKOXF)))
		{
			AppState.r4itaWBnyVQ().ForegroundWindowChanged += ppQtgHUjHvT;
		}
	}

	private void ppQtgHUjHvT(object sender, ActiveWindowChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.iEFvWWfGJTf = this;
		_003C_003Ec__DisplayClass23_.Fr7vWkUgBTN = e;
		if (!zAb0RLQWKI7r4dBZAXp7())
		{
			switch (0)
			{
			}
		}
		IntPtr value = qlZtgpCJVPe;
		IntPtr? obj = _003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.ActivatedWindow?.Handle;
		if (!(value == obj))
		{
			qlZtgpCJVPe = _003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.ActivatedWindow?.Handle ?? IntPtr.Zero;
			_003C_003Ec__DisplayClass23_.OW3vWY3aVXU = _003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.ActivatedWindow?.Pid != _003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.DeactivatedWindow?.Pid;
			_003C_003Ec__DisplayClass23_.U7JvWIlibh8 = !string.Equals(_003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.ActivatedWindow?.ProcessName, _003C_003Ec__DisplayClass23_.Fr7vWkUgBTN.DeactivatedWindow?.ProcessName, StringComparison.OrdinalIgnoreCase);
			if (!jpqtg8Grl0b.All(_003C_003Ec__DisplayClass23_.UEkvWh7gsDC))
			{
				Task.Run((Action)_003C_003Ec__DisplayClass23_.jwuvWeGtWaR);
			}
		}
	}

	private static bool ETKtg1ZMFA1(CommonTriggerTask commonTriggerTask_0, bool bool_1, bool bool_2)
	{
		return commonTriggerTask_0.TryGetParamValue("ProcChangeCondition", "NA") switch
		{
			"ProcName" => bool_2, 
			"Pid" => bool_1, 
			"NA" => true, 
			_ => true, 
		};
	}

	private bool yIitgbXmKqZ(CommonTriggerTask commonTriggerTask_0, ActiveWindowChangedEventArgs activeWindowChangedEventArgs_0)
	{
		if (commonTriggerTask_0.z4dfFIlpLc())
		{
			IDictionary<string, object> dictionary = null;
			string eventType = commonTriggerTask_0.EventType;
			if (eventType == "WindowActivated")
			{
				dictionary = new Dictionary<string, object>
				{
					{
						"Handle",
						activeWindowChangedEventArgs_0.ActivatedWindow.Handle.ToString()
					},
					{
						"WindowTitle",
						activeWindowChangedEventArgs_0.ActivatedWindow.Title
					},
					{
						"WindowClass",
						activeWindowChangedEventArgs_0.ActivatedWindow.ClassName
					},
					{
						"ProcessName",
						activeWindowChangedEventArgs_0.ActivatedWindow.ProcessName
					},
					{
						"Pid",
						activeWindowChangedEventArgs_0.ActivatedWindow.Pid.ToString()
					},
					{
						"ExePath",
						activeWindowChangedEventArgs_0.ActivatedWindow.ExePath
					},
					{
						"OldHandle",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.Handle.ToString()
					},
					{
						"OldWindowTitle",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.Title
					},
					{
						"OldWindowClass",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.ClassName
					},
					{
						"OldProcessName",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.ProcessName
					},
					{
						"OldPid",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.Pid.ToString()
					},
					{
						"OldExePath",
						activeWindowChangedEventArgs_0.DeactivatedWindow?.ExePath
					}
				};
			}
			else if (!(eventType == "WindowDeactivated"))
			{
				dictionary = new Dictionary<string, object>();
				int num = 0;
				if (dh8Os1QW1j2O7Ari0hwQ != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				dictionary = new Dictionary<string, object>
				{
					{
						"Handle",
						activeWindowChangedEventArgs_0.DeactivatedWindow.Handle.ToString()
					},
					{
						"WindowTitle",
						activeWindowChangedEventArgs_0.DeactivatedWindow.Title
					},
					{
						"WindowClass",
						activeWindowChangedEventArgs_0.DeactivatedWindow.ClassName
					},
					{
						"ProcessName",
						activeWindowChangedEventArgs_0.DeactivatedWindow.ProcessName
					},
					{
						"Pid",
						activeWindowChangedEventArgs_0.DeactivatedWindow.Pid.ToString()
					},
					{
						"ExePath",
						activeWindowChangedEventArgs_0.DeactivatedWindow.ExePath
					},
					{
						"NewHandle",
						activeWindowChangedEventArgs_0.ActivatedWindow.Handle.ToString()
					},
					{
						"NewWindowTitle",
						activeWindowChangedEventArgs_0.ActivatedWindow.Title
					},
					{
						"NewWindowClass",
						activeWindowChangedEventArgs_0.ActivatedWindow.ClassName
					},
					{
						"NewProcessName",
						activeWindowChangedEventArgs_0.ActivatedWindow.ProcessName
					},
					{
						"NewPid",
						activeWindowChangedEventArgs_0.ActivatedWindow.Pid.ToString()
					},
					{
						"NewExePath",
						activeWindowChangedEventArgs_0.ActivatedWindow.ExePath
					}
				};
			}
			return iJ2tguv8HCS(commonTriggerTask_0, dictionary);
		}
		return iJ2tguv8HCS(commonTriggerTask_0, null);
	}

	private bool ImStg6MIeti(WindowInfo windowInfo_0, string string_1, string string_2, string string_3)
	{
		if (windowInfo_0 == null)
		{
			return false;
		}
		if (!string.IsNullOrEmpty(string_1) && !GFGFgbwXKocENyrCUx4.ibMflIV9C4(string_1, windowInfo_0.Title))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(string_2) && !GFGFgbwXKocENyrCUx4.ibMflIV9C4(string_2, windowInfo_0.ClassName))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(string_3) && !GFGFgbwXKocENyrCUx4.ibMflIV9C4(string_3, windowInfo_0.ProcessName))
		{
			return false;
		}
		return true;
	}

	protected override void C5rM2eDjuIN()
	{
		AppState.r4itaWBnyVQ().ForegroundWindowChanged -= ppQtgHUjHvT;
	}

	internal static void CEC91bQWvyY5frVGdVnh()
	{
	}

	internal static bool zAb0RLQWKI7r4dBZAXp7()
	{
		return dh8Os1QW1j2O7Ari0hwQ == null;
	}
}
