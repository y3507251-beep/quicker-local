using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.TextCommands;
using WindowsInput.Native;

namespace Quicker.View.Mouse;

public class MouseActionEditWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec EUfSplvxHyo;

		public static Func<int, int> OThSpiNxYuE;

		public static Func<MouseActionLocation, bool> HqfSp3xyPwf;

		private static _003C_003Ec lWVyKcWUTlDAXUlGIeOk;

		static _003C_003Ec()
		{
			EUfSplvxHyo = new _003C_003Ec();
		}

		internal int SrwSpFcuesJ(int x)
		{
			return x;
		}

		internal bool dFOSpUBjKN0(MouseActionLocation x)
		{
			if (x < MouseActionLocation.TopBorderLeft)
			{
				return x > MouseActionLocation.NA;
			}
			return false;
		}

		internal static bool CKkaU8WUm4ma1Z6wr8ys()
		{
			return lWVyKcWUTlDAXUlGIeOk == null;
		}
	}

	private readonly DataService yIaLvvVhccP;

	private readonly MouseAction sKDLvSEWKEA;

	[CompilerGenerated]
	private MouseAction xXoLv2JYjZi;

	private IList<MouseActionLocation> QkxLvuFML5D = new List<MouseActionLocation>
	{
		MouseActionLocation.NA,
		MouseActionLocation.CornerTopLeft,
		MouseActionLocation.CornerTopRight,
		MouseActionLocation.CornerBottomLeft,
		MouseActionLocation.CornerBottomRight,
		MouseActionLocation.TopBorderLeft,
		MouseActionLocation.TopBorderRight,
		MouseActionLocation.TopBorder,
		MouseActionLocation.BottomBorderLeft,
		MouseActionLocation.BottomBorderRight,
		MouseActionLocation.BottomBorder,
		MouseActionLocation.LeftBorderUp,
		MouseActionLocation.LeftBorderDown,
		MouseActionLocation.LeftBorder,
		MouseActionLocation.RightBorderUp,
		MouseActionLocation.RightBorderDown,
		MouseActionLocation.RightBorder,
		MouseActionLocation.Up,
		MouseActionLocation.UpLeft,
		MouseActionLocation.UpRight,
		MouseActionLocation.Down,
		MouseActionLocation.DownLeft,
		MouseActionLocation.DownRight,
		MouseActionLocation.Left,
		MouseActionLocation.Right,
		MouseActionLocation.WorkingArea,
		MouseActionLocation.TaskBar,
		MouseActionLocation.FullScreen,
		MouseActionLocation.TitleBar
	};

	internal System.Windows.Controls.TextBox TxtDescription;

	internal System.Windows.Controls.CheckBox ChkIsEnabled;

	internal System.Windows.Controls.ComboBox CbMouseActionType;

	internal TextBlock LblMouseButton;

	internal StackPanel PnlMouseButton;

	internal System.Windows.Controls.ComboBox CbMouseButton;

	internal TextBlock LblControlKey;

	internal StackPanel PnlControlKey;

	internal System.Windows.Controls.ComboBox CbControlKey;

	internal System.Windows.Controls.ComboBox CbLocation;

	internal System.Windows.Controls.CheckBox ChkLimitOnPrimaryScreen;

	internal TextBlock LblWhiteList;

	internal StackPanel PnlWhiteList;

	internal System.Windows.Controls.TextBox TxtWhiteList;

	internal WindowSelector WhiteListWindowSelector;

	internal TextBlock LblBlackList;

	internal StackPanel PnlBlackList;

	internal System.Windows.Controls.TextBox TxtBlackList;

	internal WindowSelector BlackListWindowSelector;

	internal System.Windows.Controls.CheckBox ChkDisableInFullScreen;

	internal System.Windows.Controls.CheckBox ChkActivateWindow;

	internal QuickActionEditor QuickActionEditor;

	internal System.Windows.Controls.Button BtnSave;

	private bool N1fLvNe3kli;

	private static MouseActionEditWindow cnp3G8FA88JVRssWhXwH;

	public MouseAction Result
	{
		[CompilerGenerated]
		get
		{
			return xXoLv2JYjZi;
		}
		[CompilerGenerated]
		private set
		{
			xXoLv2JYjZi = value;
		}
	}

	public MouseActionEditWindow(DataService dataService, MouseAction editingAction, bool forBasicTrigger = false)
	{
		yIaLvvVhccP = dataService;
		sKDLvSEWKEA = editingAction;
		InitializeComponent();
		Aj5LL3VkoXU();
		base.Loaded += QplLLiP6JUO;
		if (forBasicTrigger)
		{
			CbControlKey.IsEnabled = false;
			CbLocation.IsEnabled = false;
			CbMouseActionType.IsEnabled = false;
			CbMouseButton.IsEnabled = false;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void QplLLiP6JUO(object sender, RoutedEventArgs e)
	{
		if (sKDLvSEWKEA != null)
		{
			TxtDescription.Text = sKDLvSEWKEA.Description;
			ChkIsEnabled.IsChecked = sKDLvSEWKEA.IsEnabled;
			CbMouseActionType.SelectedItem = sKDLvSEWKEA.MouseActionType;
			CbControlKey.SelectedItem = sKDLvSEWKEA.ControlKey;
			CbMouseButton.SelectedItem = sKDLvSEWKEA.MouseButton;
			int num = 0;
			if (!U1k6TaFARp10wUXkhPw9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			ChkDisableInFullScreen.IsChecked = sKDLvSEWKEA.DisableInFullScreen;
			CbLocation.SelectedItem = sKDLvSEWKEA.Location;
			TxtBlackList.Text = sKDLvSEWKEA.BlackList.JoinToString(";");
			TxtWhiteList.Text = sKDLvSEWKEA.WhiteList.JoinToString(";");
			QuickActionEditor.SetData(sKDLvSEWKEA);
			ChkLimitOnPrimaryScreen.IsChecked = sKDLvSEWKEA.LimitOnPrimaryScreen;
			ChkActivateWindow.IsChecked = sKDLvSEWKEA.ActivatePointingWindow;
		}
		else
		{
			ChkIsEnabled.IsChecked = true;
			CbMouseActionType.SelectedIndex = 0;
			CbMouseButton.SelectedIndex = 2;
			CbLocation.SelectedIndex = 0;
		}
	}

	private void Aj5LL3VkoXU()
	{
		CbMouseActionType.ItemsSource = new List<MouseActionType>
		{
			MouseActionType.Down,
			MouseActionType.Click,
			MouseActionType.LongPress,
			MouseActionType.Drag,
			MouseActionType.WheelUp,
			MouseActionType.WheelDown,
			MouseActionType.WheelLeft,
			MouseActionType.WheelRight,
			MouseActionType.MoveToCorner,
			MouseActionType.DoubleClick
		};
		CbMouseButton.ItemsSource = new List<MouseButtons>
		{
			MouseButtons.None,
			MouseButtons.Middle,
			MouseButtons.Right,
			MouseButtons.XButton1,
			MouseButtons.XButton2,
			MouseButtons.Left
		};
		List<int?> list = new List<int?>
		{
			0, 17, 16, 18, 162, 160, 164, 5, 6, 4,
			2, 262, 263, 264, 265, 261
		};
		foreach (int item in yIaLvvVhccP.DyhtXJ0GcZv().Keys.OrderBy(_003C_003Ec.OThSpiNxYuE ?? (_003C_003Ec.OThSpiNxYuE = _003C_003Ec.EUfSplvxHyo.SrwSpFcuesJ)))
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		CbControlKey.ItemsSource = list;
		CbLocation.ItemsSource = QkxLvuFML5D;
	}

	private void XB5LLf9fryc(object sender, RoutedEventArgs e)
	{
		MouseOperationType operation = default(MouseOperationType);
		MouseActionType mouseActionType = default(MouseActionType);
		QuickActionSelectItem quickActionSelectItem = default(QuickActionSelectItem);
		while (true)
		{
			Result = new MouseAction();
			int num = 3;
			if (U1k6TaFARp10wUXkhPw9())
			{
				while (true)
				{
					switch (num)
					{
					case 6:
						Result.ActivatePointingWindow = ChkActivateWindow.IsChecked == true;
						Result.Location = ((CbLocation.SelectedItem != null) ? ((MouseActionLocation)CbLocation.SelectedItem) : MouseActionLocation.NA);
						Result.LimitOnPrimaryScreen = ChkLimitOnPrimaryScreen.IsChecked == true;
						Result.BlackList = ((PnlBlackList.Visibility == Visibility.Visible) ? TxtBlackList.Text.SplitToList(';', '；', ',', '，') : Array.Empty<string>());
						num = 5;
						if (cnp3G8FA88JVRssWhXwH == null)
						{
							continue;
						}
						goto case 3;
					case 3:
						if (sKDLvSEWKEA != null)
						{
							Result.Id = sKDLvSEWKEA.Id;
						}
						if (TxtDescription.EnsureNotEmpty("规则名称"))
						{
							operation = MouseOperationType.QuickAction;
							mouseActionType = (MouseActionType)CbMouseActionType.SelectedItem;
							if (QuickActionEditor.IsValid())
							{
								Result.Description = TxtDescription.Text;
								Result.IsEnabled = ChkIsEnabled.IsChecked == true;
								Result.MouseActionType = mouseActionType;
								Result.ControlKey = ((PnlControlKey.Visibility != Visibility.Visible || CbControlKey.SelectedItem == null || (int)CbControlKey.SelectedItem == 0) ? ((int?)null) : new int?((int)(VirtualKeyCode)CbControlKey.SelectedItem));
								Result.MouseButton = ((PnlMouseButton.Visibility == Visibility.Visible) ? ((MouseButtons?)CbMouseButton.SelectedItem) : ((MouseButtons?)null));
								Result.DisableInFullScreen = ChkDisableInFullScreen.IsChecked == true;
								goto case 6;
							}
							AppHelper.ShowWarning("请设置操作内容。", true);
							return;
						}
						return;
					case 5:
						Result.WhiteList = ((PnlWhiteList.Visibility == Visibility.Visible) ? TxtWhiteList.Text.SplitToList(';', '；', ',', '，') : Array.Empty<string>());
						Result.Operation = operation;
						if (QuickActionEditor.Visibility == Visibility.Visible)
						{
							QuickActionEditor.SaveData(Result);
						}
						else
						{
							Result.ActionType = QuickActionType.None;
							Result.Data = string.Empty;
						}
						if (!Result.HasMouseButton)
						{
							goto case 2;
						}
						goto IL_02c5;
					case 2:
						if (Result.MouseActionType.IsEither(MouseActionType.Click, MouseActionType.Down, MouseActionType.LongPress))
						{
							AppHelper.ShowWarning("未选择鼠标按键。");
							return;
						}
						goto IL_02c5;
					case 4:
						goto end_IL_03ed;
					case 1:
						goto IL_0428;
					}
					goto IL_03d3;
					IL_02c5:
					if (mouseActionType != MouseActionType.Drag || Result.HasMouseButton || (Result.ControlKey.HasValue && Result.ControlKey.Value <= 255))
					{
						if (Result.MouseButton != MouseButtons.Left || mouseActionType == MouseActionType.DoubleClick)
						{
							if (mouseActionType != MouseActionType.DoubleClick)
							{
								goto IL_0348;
							}
							num = 0;
							if (cnp3G8FA88JVRssWhXwH != null)
							{
								continue;
							}
							goto IL_03d3;
						}
						AppHelper.ShowWarning("左键只能用于双击触发方式。");
						return;
					}
					AppHelper.ShowWarning("不按鼠标键划动触发时，需使用物理按键作为引导键。");
					return;
					IL_03d3:
					if (Result.ControlKey.HasValue && Result.ControlKey.Value > 0 && !KeyboardHelper.UriLMd2nUfC((Keys)Result.ControlKey.Value))
					{
						AppHelper.ShowWarning("双击按键只支持Ctrl、Shift、Alt作为引导键。");
						return;
					}
					goto IL_0348;
					IL_0348:
					quickActionSelectItem = QuickActionSelectItem.AllQuickActionSelectItems.FirstOrDefault(Yq5LvgX5JV1);
					if (quickActionSelectItem != null && quickActionSelectItem.IsBasicOperation)
					{
						if (quickActionSelectItem.RequireDrag && Result.MouseActionType != MouseActionType.Drag)
						{
							num = 1;
							if (cnp3G8FA88JVRssWhXwH == null)
							{
								continue;
							}
							goto IL_03d3;
						}
						goto IL_0472;
					}
					goto IL_0483;
					continue;
					end_IL_03ed:
					break;
				}
				continue;
			}
			goto IL_0428;
			IL_0472:
			Result.Operation = quickActionSelectItem.MouseOperationType;
			goto IL_0483;
			IL_0428:
			if (Result.MouseActionType != MouseActionType.LongPress)
			{
				AppHelper.ShowWarning("此操作需要使用 按下并立即移动 的方式触发。", true);
				break;
			}
			goto IL_0472;
			IL_0483:
			base.DialogResult = true;
			break;
		}
	}

	private void EgULLzkUCfZ()
	{
		MouseActionType? mouseActionType = (MouseActionType?)CbMouseActionType.SelectedItem;
		TextBlock lblMouseButton = LblMouseButton;
		Visibility visibility = (PnlMouseButton.Visibility = (mouseActionType.ContainedIn(MouseActionType.MoveToCorner, MouseActionType.WheelDown, MouseActionType.WheelUp, MouseActionType.WheelLeft, MouseActionType.WheelRight, MouseActionType.Scratch) ? Visibility.Collapsed : Visibility.Visible));
		lblMouseButton.Visibility = visibility;
		System.Windows.Controls.ComboBox cbLocation = CbLocation;
		IList<MouseActionLocation> itemsSource;
		if (mouseActionType != MouseActionType.MoveToCorner)
		{
			itemsSource = QkxLvuFML5D;
		}
		else
		{
			IList<MouseActionLocation> list = QkxLvuFML5D.Where(_003C_003Ec.HqfSp3xyPwf ?? (_003C_003Ec.HqfSp3xyPwf = _003C_003Ec.EUfSplvxHyo.dFOSpUBjKN0)).ToList();
			itemsSource = list;
		}
		cbLocation.ItemsSource = itemsSource;
		QuickActionEditor.ShowDragOperation = mouseActionType == MouseActionType.Drag || mouseActionType == MouseActionType.LongPress;
		QuickActionEditor.UpdateOperationList();
		QuickActionEditor.Visibility = Visibility.Visible;
	}

	private void WhiteListWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtWhiteList, e.ProcessName + ".exe", e.HWnd);
	}

	private void BlackListWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		UIHelper.AddExeOrProcess(TxtBlackList, e.ProcessName + ".exe", e.HWnd);
	}

	private void J4nLvwDTflC(object sender, SelectionChangedEventArgs e)
	{
	}

	private void eALLvt9Nn8w(object sender, SelectionChangedEventArgs e)
	{
		EgULLzkUCfZ();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!N1fLvNe3kli)
		{
			N1fLvNe3kli = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/mouseactioneditwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			N1fLvNe3kli = true;
			break;
		case 1:
			TxtDescription = (System.Windows.Controls.TextBox)target;
			break;
		case 2:
			ChkIsEnabled = (System.Windows.Controls.CheckBox)target;
			break;
		case 3:
		{
			CbMouseActionType = (System.Windows.Controls.ComboBox)target;
			int num2 = 2;
			goto IL_018f;
		}
		case 4:
			LblMouseButton = (TextBlock)target;
			break;
		case 5:
			PnlMouseButton = (StackPanel)target;
			break;
		case 6:
			CbMouseButton = (System.Windows.Controls.ComboBox)target;
			break;
		case 7:
			LblControlKey = (TextBlock)target;
			break;
		case 8:
			PnlControlKey = (StackPanel)target;
			num = 1;
			if (!U1k6TaFARp10wUXkhPw9())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_017c;
		case 9:
			CbControlKey = (System.Windows.Controls.ComboBox)target;
			break;
		case 10:
			CbLocation = (System.Windows.Controls.ComboBox)target;
			break;
		case 11:
			ChkLimitOnPrimaryScreen = (System.Windows.Controls.CheckBox)target;
			break;
		case 12:
			LblWhiteList = (TextBlock)target;
			break;
		case 13:
			PnlWhiteList = (StackPanel)target;
			break;
		case 14:
			TxtWhiteList = (System.Windows.Controls.TextBox)target;
			break;
		case 15:
			WhiteListWindowSelector = (WindowSelector)target;
			break;
		case 16:
			LblBlackList = (TextBlock)target;
			break;
		case 17:
			PnlBlackList = (StackPanel)target;
			num = 0;
			if (!U1k6TaFARp10wUXkhPw9())
			{
				break;
			}
			goto IL_017c;
		case 18:
			TxtBlackList = (System.Windows.Controls.TextBox)target;
			break;
		case 19:
			BlackListWindowSelector = (WindowSelector)target;
			break;
		case 20:
			ChkDisableInFullScreen = (System.Windows.Controls.CheckBox)target;
			break;
		case 21:
			ChkActivateWindow = (System.Windows.Controls.CheckBox)target;
			break;
		case 22:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 23:
			{
				BtnSave = (System.Windows.Controls.Button)target;
				BtnSave.Click += XB5LLf9fryc;
				break;
			}
			IL_017c:
			switch (num)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				break;
			}
			goto IL_018f;
			IL_018f:
			CbMouseActionType.SelectionChanged += eALLvt9Nn8w;
			break;
		}
	}

	[CompilerGenerated]
	private bool Yq5LvgX5JV1(QuickActionSelectItem quickActionSelectItem_0)
	{
		return quickActionSelectItem_0.ActionType == Result.ActionType;
	}

	internal static bool U1k6TaFARp10wUXkhPw9()
	{
		return cnp3G8FA88JVRssWhXwH == null;
	}
}
