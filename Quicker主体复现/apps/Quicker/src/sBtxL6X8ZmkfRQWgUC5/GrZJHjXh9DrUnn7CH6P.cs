using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Hotkeys;
using WindowsInput;
using WindowsInput.Native;

namespace sBtxL6X8ZmkfRQWgUC5;

internal class GrZJHjXh9DrUnn7CH6P
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public PowerKeyActionItem tU6v4oggoah;

		private static _003C_003Ec__DisplayClass16_0 TJhB3AWQMVeBejKLHcPp;

		internal void lTWv4dh7C1W()
		{
			try
			{
				InputSimulator.Instance.Mouse.LeftButtonUp();
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("抬起左键出错：" + exception.GetMessageWithInner());
			}
			try
			{
				QuickActionRunner.RunQuickActionAsync(AppState.AppServer, tU6v4oggoah, AppState.Y2RtaqSv0AQ(), AppState.AppServer, false, ActionTrigger.LeftButtonPlus, "");
				if (tU6v4oggoah.LongPressActionType > QuickActionType.None)
				{
					LongPressTriggerService.Start(new _003C_003Ec__DisplayClass16_1
					{
						nZJv4AJewrA = this,
						agtv4Mvrv7u = new PowerKeyActionItem
						{
							ActionType = tU6v4oggoah.LongPressActionType,
							Data = tU6v4oggoah.LongPressData
						}
					}.Rmov4TiHPuy);
				}
			}
			catch (Exception exception2)
			{
				AppHelper.ShowWarning("执行操作异常：" + exception2.GetMessageWithInner());
			}
		}

		internal static bool iiE2KUWQUO8OLSUEwmxQ()
		{
			return TJhB3AWQMVeBejKLHcPp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_1
	{
		public PowerKeyActionItem agtv4Mvrv7u;

		public _003C_003Ec__DisplayClass16_0 nZJv4AJewrA;

		internal static _003C_003Ec__DisplayClass16_1 qRLMcyWQtbCWJDZe18bN;

		internal void Rmov4TiHPuy()
		{
			if (nZJv4AJewrA.tU6v4oggoah.SecondaryKey > 0 && NiptKhk2i4G((VirtualKeyCode)nZJv4AJewrA.tU6v4oggoah.SecondaryKey.Value))
			{
				QuickActionRunner.RunQuickActionAsync(AppState.AppServer, agtv4Mvrv7u, AppState.Y2RtaqSv0AQ(), AppState.AppServer, false, ActionTrigger.LeftButtonPlus, "");
				if (!string.IsNullOrEmpty(nZJv4AJewrA.tU6v4oggoah.LongPressNotification))
				{
					AppHelper.ShowInformation(nZJv4AJewrA.tU6v4oggoah.LongPressNotification);
				}
			}
		}

		internal static bool GmHLBTWQSTBXUJrwrchu()
		{
			return qRLMcyWQtbCWJDZe18bN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public int fBLv4Ui6qQs;

		private static _003C_003Ec__DisplayClass21_0 fyZCQuWQsongSNBidtFm;

		internal bool VvHv4OpIxlB(PowerKeyActionItem x)
		{
			return x.SecondaryKey == fBLv4Ui6qQs;
		}

		internal bool rDav4FMWuit(PowerKeyActionItem x)
		{
			return x.SecondaryKey == fBLv4Ui6qQs;
		}

		internal static bool ubHea4WQCGGPnIN09ge2()
		{
			return fyZCQuWQsongSNBidtFm == null;
		}
	}

	[CompilerGenerated]
	private static bool bSMtKmcfoi2;

	[CompilerGenerated]
	private static bool IrAtKKUrZLa;

	private static IList<PowerKeyActionItem> M4dtKxDFLOy;

	internal static GrZJHjXh9DrUnn7CH6P v8McsnQrqRkVYP3BvDoJ;

	[SpecialName]
	[CompilerGenerated]
	private static void G1ftKG5nDmQ(bool bool_2)
	{
		bSMtKmcfoi2 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void IXFtK10PdH5(bool bool_2)
	{
		IrAtKKUrZLa = bool_2;
	}

	[SpecialName]
	public static bool FqktK6Zw1fT()
	{
		return bSMtKmcfoi2;
	}

	public static void xQFtK7YexvG()
	{
		G1ftKG5nDmQ(false);
		IXFtK10PdH5(true);
		AppState.LastMouseMoveTicks = AppHelper.fLiLTj0x4QY();
	}

	public static void fojtKR5YnP0()
	{
		IXFtK10PdH5(false);
		if (!bSMtKmcfoi2 && AppHelper.fLiLTj0x4QY() > AppState.LastMouseMoveTicks + AppState.HHxtaMaoqJr().LeftButtonLongPressExpireTime)
		{
			if (GCOtKqbAVB0() && !string.Equals(AppState.CurrentProcessName, "snipaste", StringComparison.OrdinalIgnoreCase))
			{
				AmgtKZQRDr7(MouseButtons.Left);
			}
			G1ftKG5nDmQ(true);
		}
	}

	internal static bool GCOtKqbAVB0()
	{
		if (AppState.DataService.CpItmVISR7P().EnableLeftButtonPlus && !BlackListMgr.IsCurrentAppInBlackListOrDisabledByFullScreen())
		{
			return !BlackListHelper.IsProcessInBlackList(AppState.CurrentProcessName, AppState.HHxtaMaoqJr().LeftButtonPlusBlackList);
		}
		return false;
	}

	internal static void PuHtKcfO7hv()
	{
		if (IrAtKKUrZLa)
		{
		}
	}

	public static bool MqUtKVJYvAv(int int_0, bool bool_2)
	{
		PowerKeyActionItem powerKeyActionItem = CxptKInBN4L(int_0);
		if (powerKeyActionItem != null)
		{
			if (powerKeyActionItem.LongPressActionType > QuickActionType.None && bool_2)
			{
				return true;
			}
			xEftK9BN5N3(powerKeyActionItem);
			return true;
		}
		return false;
	}

	public static bool AmgtKZQRDr7(MouseButtons mouseButtons_0)
	{
		return MqUtKVJYvAv(KeyboardHelper.GetMouseButtonKeyCode(mouseButtons_0), false);
	}

	private static void xEftK9BN5N3(PowerKeyActionItem powerKeyActionItem_0)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.tU6v4oggoah = powerKeyActionItem_0;
		G1ftKG5nDmQ(true);
		Task.Run((Action)_003C_003Ec__DisplayClass16_.lTWv4dh7C1W);
	}

	private static bool NiptKhk2i4G(VirtualKeyCode virtualKeyCode_0)
	{
		if (virtualKeyCode_0 > VirtualKeyCode.XBUTTON2)
		{
			return AppState.v5FtaQ4hQfg().dHavLMV7kRX().IsKeyDown(virtualKeyCode_0);
		}
		return AppState.v5FtaQ4hQfg().xT0vgpbZgCc(virtualKeyCode_0);
	}

	public static IList<PowerKeyActionItem> eCntKe8gqVY()
	{
		return M4dtKxDFLOy;
	}

	public static IList<PowerKeyActionItem> nRytKYA0FUP()
	{
		DataService dataService = AppState.DataService;
		if (dataService != null && dataService.CpItmVISR7P()?.LeftButtonPlusActions.HasData() == true)
		{
			return AppState.DataService?.CpItmVISR7P()?.LeftButtonPlusActions;
		}
		return M4dtKxDFLOy;
	}

	private static PowerKeyActionItem CxptKInBN4L(int int_0)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.fBLv4Ui6qQs = int_0;
		if (_003C_003Ec__DisplayClass21_.fBLv4Ui6qQs == 0)
		{
			return null;
		}
		PowerKeyActionItem powerKeyActionItem = null;
		ExeSettings exeSettings = AppState.DataService.DjNt6MCQCru();
		int num = 0;
		if (v8McsnQrqRkVYP3BvDoJ != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (exeSettings != null && exeSettings.LeftButtonPlusActions.HasData())
			{
				powerKeyActionItem = exeSettings.LeftButtonPlusActions.FirstOrDefault(_003C_003Ec__DisplayClass21_.VvHv4OpIxlB);
				if (powerKeyActionItem != null)
				{
					if (CCRtKWgD5Se(powerKeyActionItem))
					{
						return powerKeyActionItem;
					}
					return null;
				}
			}
			powerKeyActionItem = nRytKYA0FUP().FirstOrDefault(_003C_003Ec__DisplayClass21_.rDav4FMWuit);
			if (powerKeyActionItem != null && CCRtKWgD5Se(powerKeyActionItem))
			{
				return powerKeyActionItem;
			}
			return null;
		}
	}

	static GrZJHjXh9DrUnn7CH6P()
	{
		M4dtKxDFLOy = new List<PowerKeyActionItem>
		{
			new PowerKeyActionItem
			{
				Title = "Copy",
				SecondaryKey = 67,
				ActionType = QuickActionType.QuickerOperation,
				Data = "operation_copy"
			},
			new PowerKeyActionItem
			{
				Title = "Paste",
				SecondaryKey = 86,
				ActionType = QuickActionType.QuickerOperation,
				Data = "operation_paste"
			},
			new PowerKeyActionItem
			{
				Title = "SelectAll",
				SecondaryKey = 65,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_A, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Cut",
				SecondaryKey = 88,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_X, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Enter",
				SecondaryKey = 20,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.RETURN, ModifierKeys.None).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Delete",
				SecondaryKey = 68,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.DELETE, ModifierKeys.None).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Find",
				SecondaryKey = 70,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_F, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Underline",
				SecondaryKey = 85,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_U, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Italic",
				SecondaryKey = 73,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_I, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Bold",
				SecondaryKey = 66,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_B, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Undo",
				SecondaryKey = 90,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.VK_Z, ModifierKeys.Control).ToData()
			},
			new PowerKeyActionItem
			{
				Title = "Run",
				SecondaryKey = 82,
				ActionType = QuickActionType.QuickerOperation,
				Data = "run_selected_text"
			},
			new PowerKeyActionItem
			{
				Title = "Search",
				SecondaryKey = 83,
				ActionType = QuickActionType.QuickerOperation,
				Data = "search_selected_text"
			},
			new PowerKeyActionItem
			{
				Title = "Left+Right",
				SecondaryKey = 2,
				ActionType = QuickActionType.QuickerOperation,
				Data = "operation_copy_or_paste"
			},
			new PowerKeyActionItem
			{
				Title = "Left+Middle",
				SecondaryKey = 4,
				ActionType = QuickActionType.None
			},
			new PowerKeyActionItem
			{
				Title = "Left+X1",
				SecondaryKey = 5,
				ActionType = QuickActionType.QuickerOperation,
				Data = "operation_paste"
			},
			new PowerKeyActionItem
			{
				Title = "Left+X2",
				SecondaryKey = 6,
				ActionType = QuickActionType.QuickerOperation,
				Data = "operation_paste"
			}
		};
	}

	[CompilerGenerated]
	internal static bool CCRtKWgD5Se(PowerKeyActionItem powerKeyActionItem_0)
	{
		if (!powerKeyActionItem_0.IsDisabled)
		{
			return powerKeyActionItem_0.ActionType != QuickActionType.None;
		}
		return false;
	}

	internal static bool jMBtVKQri1nJdirXmMOB()
	{
		return v8McsnQrqRkVYP3BvDoJ == null;
	}
}
