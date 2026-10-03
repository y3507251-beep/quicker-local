using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Win32;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace vM86xNwxkAjTFkKFfXq;

internal class Q8bOxkwtfNrYNxKUGE5 : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec qOxvWSf7TND;

		public static Func<CommonTriggerTask, bool> fUNvW2GUt1m;

		public static Func<CommonTriggerTask, bool> YbmvWug6kjq;

		public static Func<CommonTriggerTask, bool> abEvWN90kTf;

		public static Func<CommonTriggerTask, bool> TsXvWJPyiFx;

		public static Func<CommonTriggerTask, bool> onxvW07hfEs;

		public static Func<CommonTriggerTask, bool> v9MvWCwSuyw;

		public static Func<CommonTriggerTask, bool> vl1vWPIbTcq;

		public static Func<CommonTriggerTask, bool> fuDvWEYPDJB;

		public static Func<CommonTriggerTask, bool> vEjvWybAvgJ;

		private static _003C_003Ec QBy82hcZ8RHXGMTDSb80;

		static _003C_003Ec()
		{
			qOxvWSf7TND = new _003C_003Ec();
		}

		internal bool FjgvIiRFyIO(CommonTriggerTask x)
		{
			return x.EventType == "DisplaySettingsChanged";
		}

		internal bool xAQvI3A2AU4(CommonTriggerTask x)
		{
			return x.EventType == "PowerModeChanged";
		}

		internal bool iTWvIfv8Png(CommonTriggerTask x)
		{
			return x.EventType == "SessionEnding";
		}

		internal bool meFvIzu6uk5(CommonTriggerTask x)
		{
			return x.EventType.EqualsAny(false, "SessionSwitch", "SessionLock", "SessionUnlock");
		}

		internal bool bVQvWwXjcJQ(CommonTriggerTask x)
		{
			return x.EventType == "UserPreferenceChanged";
		}

		internal bool C3XvWtcoebE(CommonTriggerTask x)
		{
			return x.EventType == "UserPreferenceChanged";
		}

		internal bool QY2vWgjwfl6(CommonTriggerTask x)
		{
			return x.EventType == "SessionEnding";
		}

		internal bool D40vWLMYDXH(CommonTriggerTask x)
		{
			return x.EventType == "PowerModeChanged";
		}

		internal bool wlYvWvs0aqk(CommonTriggerTask x)
		{
			return x.EventType == "DisplaySettingsChanged";
		}

		internal static bool CYixawcZRR5rgtofskwt()
		{
			return QBy82hcZ8RHXGMTDSb80 == null;
		}

		internal static void KmpcbTcZPanelD9pI1m6()
		{
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> o06ttzjGbax = new Dictionary<string, string>
	{
		{ "DisplaySettingsChanged", "屏幕/显示设置改变" },
		{ "PowerModeChanged", "电源状态改变" },
		{ "SessionEnding", "用户正在尝试注销或关闭系统" },
		{ "SessionSwitch", "会话切换事件" },
		{ "SessionLock", "计算机锁定" },
		{ "SessionUnlock", "计算机解锁" },
		{ "UserPreferenceChanged", "用户偏好设置改变" }
	};

	internal static Q8bOxkwtfNrYNxKUGE5 ApsJPcQcmDRHblvnwhdh;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return o06ttzjGbax;
	}

	public Q8bOxkwtfNrYNxKUGE5()
		: base(new string[7] { "DisplaySettingsChanged", "PowerModeChanged", "SessionEnding", "SessionSwitch", "SessionLock", "SessionUnlock", "UserPreferenceChanged" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return base.odUM2hmvkik(string_1);
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return string_1 switch
		{
			"SessionSwitch" => new List<ActionVariable>
			{
				new ActionVariable
				{
					Key = "Reason",
					Desc = "事件原因",
					Type = VarType.Text
				}
			}, 
			"PowerModeChanged" => new List<ActionVariable>
			{
				new ActionVariable
				{
					Key = "Mode",
					Desc = "模式",
					Type = VarType.Text
				},
				new ActionVariable
				{
					Key = "PowerLineStatus",
					Desc = "电源线状态",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "PowerLineStatusName",
					Desc = "电源线状态名称",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "BatteryChargeStatus",
					Desc = "充电状态",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "BatteryChargeStatusName",
					Desc = "充电状态名称",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "BatteryLifePercent",
					Desc = "电池剩余电量比例",
					Type = VarType.Number
				},
				new ActionVariable
				{
					Key = "BatteryLifeRemaining",
					Desc = "电池剩余时间秒数",
					Type = VarType.Integer
				},
				new ActionVariable
				{
					Key = "BatteryLifeRemaining",
					Desc = "电池满电可用时间秒数",
					Type = VarType.Integer
				}
			}, 
			"UserPreferenceChanged" => new List<ActionVariable>
			{
				new ActionVariable
				{
					Key = "Category",
					Desc = "偏好分类",
					Type = VarType.Text
				}
			}, 
			_ => base.VrkM2LPKH4P(string_1), 
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		pLMttOLPIAS();
	}

	protected override void C5rM2eDjuIN()
	{
		R5lttF6EkZs();
	}

	private void pLMttOLPIAS()
	{
		R5lttF6EkZs();
		if (jpqtg8Grl0b.Any(_003C_003Ec.fUNvW2GUt1m ?? (_003C_003Ec.fUNvW2GUt1m = _003C_003Ec.qOxvWSf7TND.FjgvIiRFyIO)))
		{
			int num = 0;
			if (!eJqEmkQcsDr88VlRBbpv())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			SystemEvents.DisplaySettingsChanged += ulYttfMtjFh;
		}
		if (jpqtg8Grl0b.Any(_003C_003Ec.YbmvWug6kjq ?? (_003C_003Ec.YbmvWug6kjq = _003C_003Ec.qOxvWSf7TND.xAQvI3A2AU4)))
		{
			SystemEvents.PowerModeChanged += zxqtt3VyR1i;
		}
		if (jpqtg8Grl0b.Any(_003C_003Ec.abEvWN90kTf ?? (_003C_003Ec.abEvWN90kTf = _003C_003Ec.qOxvWSf7TND.iTWvIfv8Png)))
		{
			SystemEvents.SessionEnding += CDjttiHYrAg;
		}
		if (jpqtg8Grl0b.Any(_003C_003Ec.TsXvWJPyiFx ?? (_003C_003Ec.TsXvWJPyiFx = _003C_003Ec.qOxvWSf7TND.meFvIzu6uk5)))
		{
			SystemEvents.SessionSwitch += kvYttlfIx37;
		}
		if (jpqtg8Grl0b.Any(_003C_003Ec.onxvW07hfEs ?? (_003C_003Ec.onxvW07hfEs = _003C_003Ec.qOxvWSf7TND.bVQvWwXjcJQ)))
		{
			SystemEvents.UserPreferenceChanged += R1JttUHhqnI;
		}
	}

	private void R5lttF6EkZs()
	{
		SystemEvents.DisplaySettingsChanged -= ulYttfMtjFh;
		SystemEvents.PowerModeChanged -= zxqtt3VyR1i;
		SystemEvents.SessionEnding -= CDjttiHYrAg;
		SystemEvents.SessionSwitch -= kvYttlfIx37;
		SystemEvents.UserPreferenceChanged -= R1JttUHhqnI;
	}

	private void R1JttUHhqnI(object sender, UserPreferenceChangedEventArgs e)
	{
		Dictionary<string, object> idictionary_ = new Dictionary<string, object> { 
		{
			"Category",
			e.Category.ToString()
		} };
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec.v9MvWCwSuyw ?? (_003C_003Ec.v9MvWCwSuyw = _003C_003Ec.qOxvWSf7TND.C3XvWtcoebE)))
		{
			if (iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void kvYttlfIx37(object sender, SessionSwitchEventArgs e)
	{
		Dictionary<string, object> idictionary_ = new Dictionary<string, object> { 
		{
			"Reason",
			e.Reason.ToString()
		} };
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (!(item.EventType == "SessionSwitch") && (!(item.EventType == "SessionLock") || e.Reason != SessionSwitchReason.SessionLock))
			{
				if (!(item.EventType == "SessionUnlock") || e.Reason != SessionSwitchReason.SessionUnlock)
				{
					continue;
				}
				if (!eJqEmkQcsDr88VlRBbpv())
				{
					switch (0)
					{
					}
				}
			}
			if (iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void CDjttiHYrAg(object sender, SessionEndingEventArgs e)
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec.vl1vWPIbTcq ?? (_003C_003Ec.vl1vWPIbTcq = _003C_003Ec.qOxvWSf7TND.QY2vWgjwfl6)))
		{
			if (iJ2tguv8HCS(item, null) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void zxqtt3VyR1i(object sender, PowerModeChangedEventArgs e)
	{
		PowerStatus powerStatus = SystemInformation.PowerStatus;
		Dictionary<string, object> idictionary_ = new Dictionary<string, object>
		{
			{
				"Mode",
				e.Mode.ToString()
			},
			{
				"PowerLineStatus",
				(int)powerStatus.PowerLineStatus
			},
			{
				"PowerLineStatusName",
				powerStatus.PowerLineStatus.ToString()
			},
			{
				"BatteryChargeStatus",
				(int)powerStatus.BatteryChargeStatus
			},
			{
				"BatteryChargeStatusName",
				powerStatus.BatteryChargeStatus.ToString()
			},
			{ "BatteryLifePercent", powerStatus.BatteryLifePercent },
			{ "BatteryLifeRemaining", powerStatus.BatteryLifeRemaining },
			{ "BatteryFullLifetime", powerStatus.BatteryFullLifetime }
		};
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec.fuDvWEYPDJB ?? (_003C_003Ec.fuDvWEYPDJB = _003C_003Ec.qOxvWSf7TND.D40vWLMYDXH)))
		{
			if (iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void ulYttfMtjFh(object sender, EventArgs e)
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec.vEjvWybAvgJ ?? (_003C_003Ec.vEjvWybAvgJ = _003C_003Ec.qOxvWSf7TND.wlYvWvs0aqk)))
		{
			if (iJ2tguv8HCS(item, null) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	internal static bool eJqEmkQcsDr88VlRBbpv()
	{
		return ApsJPcQcmDRHblvnwhdh == null;
	}
}
