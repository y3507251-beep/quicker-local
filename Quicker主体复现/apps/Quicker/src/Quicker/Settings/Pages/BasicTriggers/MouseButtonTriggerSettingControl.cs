using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Markup;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Domain.PowerMouse;
using Quicker.Utilities;
using Quicker.View.Mouse;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.BasicTriggers;

public class MouseButtonTriggerSettingControl : System.Windows.Controls.UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fbjv9eYaNpl;

		public static Func<BasicMouseTrigger, bool> hAgv9YEYEwJ;

		public static Func<BasicMouseTrigger, bool> pjav9In4eJW;

		public static Func<BasicMouseTrigger, bool> PRvv9WaG53X;

		public static Func<BasicMouseTrigger, bool> c8rv9kuhriZ;

		public static Func<BasicMouseTrigger, bool> e6ev9Gms8s2;

		public static Func<BasicMouseTrigger, bool> b2xv9sn66Qx;

		public static Func<BasicMouseTrigger, bool> dJjv9HV1rNU;

		public static Func<BasicMouseTrigger, bool> SaWv91y1knP;

		public static Func<BasicMouseTrigger, bool> TY7v9bMvG9M;

		public static Func<BasicMouseTrigger, bool> vuEv96KQbOY;

		private static _003C_003Ec DS3pOKcoex0FoJGFb1ao;

		static _003C_003Ec()
		{
			fbjv9eYaNpl = new _003C_003Ec();
		}

		internal bool Tm4v98dQVOT(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return !x.ControlKey.HasValue;
			}
			return false;
		}

		internal bool j7Zv9aYVBpF(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return x.ControlKey == 17;
			}
			return false;
		}

		internal bool XXSv972GERD(BasicMouseTrigger x)
		{
			return x.MouseActionType == MouseActionType.LongPress;
		}

		internal bool xgSv9R28p3U(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return x.ControlKey == 17;
			}
			return false;
		}

		internal bool Vp0v9qDOGCX(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Drag)
			{
				return !x.ControlKey.HasValue;
			}
			return false;
		}

		internal bool vUBv9clSeb2(BasicMouseTrigger x)
		{
			return x.MouseActionType == MouseActionType.Down;
		}

		internal bool Vhsv9VdIHlc(BasicMouseTrigger x)
		{
			return x.MouseActionType == MouseActionType.Down;
		}

		internal bool DfRv9ZBbXo8(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return !x.ControlKey.HasValue;
			}
			return false;
		}

		internal bool j0jv99oBXTl(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return !x.ControlKey.HasValue;
			}
			return false;
		}

		internal bool keLv9h2Wshu(BasicMouseTrigger x)
		{
			if (x.MouseActionType == MouseActionType.Down)
			{
				return x.ControlKey == AppState.HHxtaMaoqJr().ScreenShotSettings.AdornKey;
			}
			return false;
		}

		internal static bool fDK466cojF4f4GYvZPZ4()
		{
			return DS3pOKcoex0FoJGFb1ao == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public MouseButtonTriggerSettingControl bhwv9my4UUi;

		public BasicMouseTrigger HbKv9KPl7fG;

		internal static _003C_003Ec__DisplayClass10_0 irQdX7coEDprLrDAoyQh;

		internal bool u73v9XBDDLU(MouseAction x)
		{
			if (x.MouseButton == bhwv9my4UUi.MouseButton && x.ControlKey == HbKv9KPl7fG.ControlKey && x.MouseActionType == HbKv9KPl7fG.MouseActionType)
			{
				if (x.Location != MouseActionLocation.NA)
				{
					return x.Location == MouseActionLocation.FullScreen;
				}
				return true;
			}
			return false;
		}

		internal static bool E2kK4hcoGo0J5w0uoHHs()
		{
			return irQdX7coEDprLrDAoyQh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public MouseAction f2Tv9rwYVrK;

		internal static _003C_003Ec__DisplayClass9_0 NAvJXacoK2XcgAeFliqV;

		internal bool BFmv9xcexnG(BasicMouseTrigger x)
		{
			if (x.MouseActionType == f2Tv9rwYVrK.MouseActionType)
			{
				return x.ControlKey == f2Tv9rwYVrK.ControlKey;
			}
			return false;
		}

		internal static bool zlROPdcoBWy0h8UeQBdS()
		{
			return NAvJXacoK2XcgAeFliqV == null;
		}
	}

	private readonly IList<MouseActionType> iYlDdX5wCo = new List<MouseActionType>
	{
		MouseActionType.Down,
		MouseActionType.Click,
		MouseActionType.LongPress,
		MouseActionType.Drag
	};

	private ObservableCollection<BasicMouseTrigger> npIDoTFasO = new ObservableCollection<BasicMouseTrigger>();

	[CompilerGenerated]
	private MouseButtons c3eDTRZa01;

	internal System.Windows.Controls.ListView LvTriggers;

	private bool pApDMDwNrC;

	private static MouseButtonTriggerSettingControl NOSwJtsjJdYPl9SvnHO;

	public MouseButtons MouseButton
	{
		[CompilerGenerated]
		get
		{
			return c3eDTRZa01;
		}
		[CompilerGenerated]
		set
		{
			c3eDTRZa01 = value;
		}
	}

	public MouseButtonTriggerSettingControl()
	{
		InitializeComponent();
		base.Loaded += btFDjPsbva;
	}

	private void btFDjPsbva(object sender, RoutedEventArgs e)
	{
		if (LvTriggers.ItemsSource == null)
		{
			ylZDnmtjfk();
		}
	}

	private void ylZDnmtjfk()
	{
		h68D42aNxN(MouseButton);
		LvTriggers.ItemsSource = npIDoTFasO;
		CollectionView obj = (CollectionView)CollectionViewSource.GetDefaultView(LvTriggers.ItemsSource);
		PropertyGroupDescription item = new PropertyGroupDescription("ControlKey");
		obj.GroupDescriptions.Add(item);
	}

	private void h68D42aNxN(MouseButtons mouseButtons_1)
	{
		foreach (MouseActionType item in iYlDdX5wCo)
		{
			npIDoTFasO.Add(new BasicMouseTrigger
			{
				ControlKey = null,
				MouseActionType = item,
				MouseButton = mouseButtons_1
			});
		}
		foreach (MouseActionType item2 in iYlDdX5wCo)
		{
			npIDoTFasO.Add(new BasicMouseTrigger
			{
				ControlKey = 17,
				MouseActionType = item2,
				MouseButton = mouseButtons_1
			});
		}
		foreach (MouseActionType item3 in iYlDdX5wCo)
		{
			npIDoTFasO.Add(new BasicMouseTrigger
			{
				ControlKey = 18,
				MouseActionType = item3,
				MouseButton = mouseButtons_1
			});
		}
		foreach (MouseActionType item4 in iYlDdX5wCo)
		{
			npIDoTFasO.Add(new BasicMouseTrigger
			{
				ControlKey = 16,
				MouseActionType = item4,
				MouseButton = mouseButtons_1
			});
		}
		string lockReason = "已在“弹出面板”设置中使用";
		int num;
		if (MouseButton == MouseButtons.Middle)
		{
			if (AppState.HHxtaMaoqJr().OpenPopWithMiddleClick)
			{
				num = 0;
				if (!Y6h50TsDqJeIMUxi0AI())
				{
					goto IL_02f4;
				}
				goto IL_02f8;
			}
			goto IL_0370;
		}
		if (MouseButton == MouseButtons.Right)
		{
			if (AppState.HHxtaMaoqJr().OpenPopWithCtrlRightClick)
			{
				BasicMouseTrigger basicMouseTrigger = npIDoTFasO.First(_003C_003Ec.c8rv9kuhriZ ?? (_003C_003Ec.c8rv9kuhriZ = _003C_003Ec.fbjv9eYaNpl.xgSv9R28p3U));
				basicMouseTrigger.IsLocked = true;
				basicMouseTrigger.LockReason = lockReason;
			}
			if (!AppState.HHxtaMaoqJr().OpenPopWithRightPressMove)
			{
				num = 1;
				if (!Y6h50TsDqJeIMUxi0AI())
				{
					goto IL_02f4;
				}
				goto IL_02f8;
			}
			BasicMouseTrigger basicMouseTrigger2 = npIDoTFasO.First(_003C_003Ec.e6ev9Gms8s2 ?? (_003C_003Ec.e6ev9Gms8s2 = _003C_003Ec.fbjv9eYaNpl.Vp0v9qDOGCX));
			basicMouseTrigger2.IsLocked = true;
			basicMouseTrigger2.LockReason = lockReason;
		}
		else if (MouseButton == MouseButtons.XButton1)
		{
			if (AppState.HHxtaMaoqJr().OpenPopWithXButton1Click)
			{
				num = 3;
				if (Y6h50TsDqJeIMUxi0AI())
				{
					goto IL_02f8;
				}
			}
		}
		else if (MouseButton == MouseButtons.XButton2 && AppState.HHxtaMaoqJr().OpenPopWithXButton2Click)
		{
			BasicMouseTrigger basicMouseTrigger3 = npIDoTFasO.First(_003C_003Ec.dJjv9HV1rNU ?? (_003C_003Ec.dJjv9HV1rNU = _003C_003Ec.fbjv9eYaNpl.Vhsv9VdIHlc));
			basicMouseTrigger3.IsLocked = true;
			basicMouseTrigger3.LockReason = lockReason;
		}
		goto IL_048c;
		IL_04ef:
		if (AppState.HHxtaMaoqJr().ScreenShotSettings != null && AppState.HHxtaMaoqJr().ScreenShotSettings.Trigger.ToMouseButtons() == MouseButton)
		{
			BasicMouseTrigger basicMouseTrigger4 = npIDoTFasO.FirstOrDefault(_003C_003Ec.vuEv96KQbOY ?? (_003C_003Ec.vuEv96KQbOY = _003C_003Ec.fbjv9eYaNpl.keLv9h2Wshu));
			if (basicMouseTrigger4 != null)
			{
				basicMouseTrigger4.IsLocked = true;
				basicMouseTrigger4.LockReason = "已设置为快速截图触发键";
			}
		}
		using (IEnumerator<MouseAction> enumerator2 = AppState.DataService.FnrtmLxNViE().GetEnumerator())
		{
			int num3 = default(int);
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				_003C_003Ec__DisplayClass9_.f2Tv9rwYVrK = enumerator2.Current;
				int num2 = 0;
				if (NOSwJtsjJdYPl9SvnHO != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (_003C_003Ec__DisplayClass9_.f2Tv9rwYVrK.MouseButton == MouseButton && (_003C_003Ec__DisplayClass9_.f2Tv9rwYVrK.Location == MouseActionLocation.NA || _003C_003Ec__DisplayClass9_.f2Tv9rwYVrK.Location == MouseActionLocation.FullScreen))
				{
					BasicMouseTrigger basicMouseTrigger5 = npIDoTFasO.FirstOrDefault(_003C_003Ec__DisplayClass9_.BFmv9xcexnG);
					if (basicMouseTrigger5 != null)
					{
						basicMouseTrigger5.MouseAction = _003C_003Ec__DisplayClass9_.f2Tv9rwYVrK;
					}
				}
			}
			return;
		}
		IL_0327:
		if (AppState.HHxtaMaoqJr().GestureTrigger != 0)
		{
			num = 2;
			if (NOSwJtsjJdYPl9SvnHO != null)
			{
				goto IL_02f4;
			}
			goto IL_02f8;
		}
		goto IL_04ef;
		IL_049d:
		if (AppState.HHxtaMaoqJr().GestureTrigger.ToMouseButtons() == MouseButton)
		{
			BasicMouseTrigger basicMouseTrigger6 = npIDoTFasO.First(_003C_003Ec.TY7v9bMvG9M ?? (_003C_003Ec.TY7v9bMvG9M = _003C_003Ec.fbjv9eYaNpl.j0jv99oBXTl));
			basicMouseTrigger6.IsLocked = true;
			basicMouseTrigger6.LockReason = "已设置为鼠标手势触发键";
		}
		goto IL_04ef;
		IL_0370:
		if (AppState.HHxtaMaoqJr().OpenPopWithCtrlMiddleClick)
		{
			BasicMouseTrigger basicMouseTrigger7 = npIDoTFasO.First(_003C_003Ec.pjav9In4eJW ?? (_003C_003Ec.pjav9In4eJW = _003C_003Ec.fbjv9eYaNpl.j7Zv9aYVBpF));
			basicMouseTrigger7.IsLocked = true;
			basicMouseTrigger7.LockReason = lockReason;
		}
		if (AppState.HHxtaMaoqJr().OpenPopWithLongMiddlePress)
		{
			BasicMouseTrigger basicMouseTrigger8 = npIDoTFasO.First(_003C_003Ec.PRvv9WaG53X ?? (_003C_003Ec.PRvv9WaG53X = _003C_003Ec.fbjv9eYaNpl.XXSv972GERD));
			basicMouseTrigger8.IsLocked = true;
			basicMouseTrigger8.LockReason = lockReason;
		}
		goto IL_048c;
		IL_02f8:
		switch (num)
		{
		case 4:
			break;
		default:
			goto IL_0338;
		case 3:
		{
			BasicMouseTrigger basicMouseTrigger9 = npIDoTFasO.First(_003C_003Ec.b2xv9sn66Qx ?? (_003C_003Ec.b2xv9sn66Qx = _003C_003Ec.fbjv9eYaNpl.vUBv9clSeb2));
			basicMouseTrigger9.IsLocked = true;
			basicMouseTrigger9.LockReason = lockReason;
			goto IL_048c;
		}
		case 1:
			goto IL_048c;
		case 2:
			goto IL_049d;
		}
		goto IL_0313;
		IL_02f4:
		int num4 = default(int);
		num = num4;
		goto IL_02f8;
		IL_0313:
		BasicMouseTrigger basicMouseTrigger10 = default(BasicMouseTrigger);
		basicMouseTrigger10.IsLocked = true;
		basicMouseTrigger10.LockReason = "已设置为轮盘菜单触发键";
		goto IL_0327;
		IL_0338:
		BasicMouseTrigger basicMouseTrigger11 = npIDoTFasO.First(_003C_003Ec.hAgv9YEYEwJ ?? (_003C_003Ec.hAgv9YEYEwJ = _003C_003Ec.fbjv9eYaNpl.Tm4v98dQVOT));
		basicMouseTrigger11.IsLocked = true;
		basicMouseTrigger11.LockReason = lockReason;
		goto IL_0370;
		IL_048c:
		if (AppState.HHxtaMaoqJr().CircleMenuTrigger != 0 && AppState.HHxtaMaoqJr().CircleMenuTrigger.ToMouseButtons() == MouseButton)
		{
			basicMouseTrigger10 = npIDoTFasO.First(_003C_003Ec.SaWv91y1knP ?? (_003C_003Ec.SaWv91y1knP = _003C_003Ec.fbjv9eYaNpl.DfRv9ZBbXo8));
			if (basicMouseTrigger10 != null)
			{
				goto IL_0313;
			}
		}
		goto IL_0327;
	}

	private void i60D51Y1Lm(object sender, RoutedEventArgs e)
	{
        MouseActionEditWindow mouseActionEditWindow = default;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.bhwv9my4UUi = this;
		int num = 3;
		if (!Y6h50TsDqJeIMUxi0AI())
		{
			goto IL_0196;
		}
		goto IL_0294;
		IL_0196:
		mouseActionEditWindow = default(MouseActionEditWindow);
		AppState.DataService.FnrtmLxNViE().Add(mouseActionEditWindow.Result);
		_003C_003Ec__DisplayClass10_.HbKv9KPl7fG.MouseAction = mouseActionEditWindow.Result;
		goto IL_0269;
		IL_0269:
		AppState.DataService.mxCtX8S7NGg();
		AppState.Y2RtaqSv0AQ().NotifyCommonDataUpdated(this, "user_mouseActions");
		num = 1;
		if (!Y6h50TsDqJeIMUxi0AI())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0294;
		IL_01e7:
		MouseAction mouseAction = default(MouseAction);
		AppState.DataService.FnrtmLxNViE().Remove(mouseAction);
		int num3 = default(int);
		if (mouseActionEditWindow.Result.ActionType != QuickActionType.None)
		{
			if (num3 < 0)
			{
				AppState.DataService.FnrtmLxNViE().Add(mouseActionEditWindow.Result);
			}
			else
			{
				AppState.DataService.FnrtmLxNViE().Insert(num3, mouseActionEditWindow.Result);
			}
			_003C_003Ec__DisplayClass10_.HbKv9KPl7fG.MouseAction = mouseActionEditWindow.Result;
		}
		else
		{
			_003C_003Ec__DisplayClass10_.HbKv9KPl7fG.MouseAction = null;
			AppHelper.ShowWarning("您已去除此操作。");
		}
		goto IL_0269;
		IL_0294:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				goto end_IL_0294;
			case 2:
				goto IL_01e7;
			case 1:
				return;
			}
			_003C_003Ec__DisplayClass10_.HbKv9KPl7fG = (sender as System.Windows.Controls.Button).Tag as BasicMouseTrigger;
			if (_003C_003Ec__DisplayClass10_.HbKv9KPl7fG != null)
			{
				List<MouseAction> list = AppState.DataService.FnrtmLxNViE().Where(_003C_003Ec__DisplayClass10_.u73v9XBDDLU).ToList();
				if (list.Count <= 1)
				{
					mouseAction = list.FirstOrDefault();
					bool flag = false;
					if (mouseAction == null)
					{
						mouseAction = new MouseAction
						{
							Id = Guid.NewGuid(),
							Description = (_003C_003Ec__DisplayClass10_.HbKv9KPl7fG.ControlKey.HasValue ? (KeyboardHelper.GetKeyName((VirtualKeyCode)_003C_003Ec__DisplayClass10_.HbKv9KPl7fG.ControlKey.Value) + " + ") : "") + yqODDhosw4(MouseButton) + " " + _003C_003Ec__DisplayClass10_.HbKv9KPl7fG.MouseActionName,
							MouseButton = MouseButton,
							ControlKey = _003C_003Ec__DisplayClass10_.HbKv9KPl7fG.ControlKey,
							MouseActionType = _003C_003Ec__DisplayClass10_.HbKv9KPl7fG.MouseActionType,
							Location = MouseActionLocation.NA
						};
						flag = true;
					}
					mouseActionEditWindow = new MouseActionEditWindow(AppState.DataService, mouseAction, true)
					{
						Owner = Window.GetWindow(this)
					};
					if (mouseActionEditWindow.ShowDialog() == true)
					{
						if (flag)
						{
							goto IL_0178;
						}
						num3 = AppState.DataService.FnrtmLxNViE().IndexOf(mouseAction);
						num = 2;
						if (NOSwJtsjJdYPl9SvnHO != null)
						{
							continue;
						}
						goto IL_01e7;
					}
					return;
				}
				AppHelper.ShowInformation("此触发方式有多项设置，请在 高级鼠标触发 配置页中管理。");
				return;
			}
			return;
			continue;
			end_IL_0294:
			break;
		}
		goto IL_0196;
		IL_0178:
		if (mouseActionEditWindow.Result.ActionType != QuickActionType.None)
		{
			goto IL_0196;
		}
		AppHelper.ShowWarning("未设置任何操作。");
		goto IL_0269;
	}

	private static string yqODDhosw4(MouseButtons mouseButtons_1)
	{
		return mouseButtons_1 switch
		{
			MouseButtons.Right => "右键", 
			MouseButtons.Left => "左键", 
			MouseButtons.XButton2 => "X2键", 
			MouseButtons.XButton1 => "X1键", 
			MouseButtons.Middle => "中键", 
			_ => mouseButtons_1.ToString(), 
		};
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!pApDMDwNrC)
		{
			pApDMDwNrC = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basictriggers/mousebuttontriggersettingcontrol.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			LvTriggers = (System.Windows.Controls.ListView)target;
		}
		else
		{
			pApDMDwNrC = true;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			((System.Windows.Controls.Button)target).Click += i60D51Y1Lm;
		}
	}

	internal static bool Y6h50TsDqJeIMUxi0AI()
	{
		return NOSwJtsjJdYPl9SvnHO == null;
	}
}
