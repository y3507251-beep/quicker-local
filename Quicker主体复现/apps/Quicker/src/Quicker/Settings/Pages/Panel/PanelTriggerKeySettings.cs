using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Common.Entities;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.KeyInput;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Panel;

public class PanelTriggerKeySettings : SettingPage, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public int fd7vVB597dM;

		internal static _003C_003Ec__DisplayClass13_0 zWiSxic9abYDECX3hyk3;

		internal bool OOuvVpRmCOP(KeyValuePair<int, int> x)
		{
			return x.Value == fd7vVB597dM;
		}

		internal static bool T85q9Sc9rJG6Q6QeGdEH()
		{
			return zWiSxic9abYDECX3hyk3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public int EwrvVjBC543;

		private static _003C_003Ec__DisplayClass14_0 B6j06bc993NAQQEM41FL;

		internal bool Ej1vVQnJoSd(KeyValuePair<int, int> x)
		{
			return x.Value == EwrvVjBC543;
		}

		internal static bool umLDxhc9L2GWNpWsoIRA()
		{
			return B6j06bc993NAQQEM41FL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public int junvV5lI4Jy;

		public Func<KeyValuePair<int, int>, bool> uEGvVDOOhDx;

		internal static _003C_003Ec__DisplayClass15_0 KZO4wIc9oUFPlH6C0LLr;

		internal bool vPtvVnm3qC6(KeyValuePair<int, int> x)
		{
			return x.Value == junvV5lI4Jy;
		}

		internal bool ihQvV48w88G(KeyValuePair<int, ToggleButton> x)
		{
			return x.Key > junvV5lI4Jy;
		}

		internal static bool PwBlJlc9ftPFgw9tv0lX()
		{
			return KZO4wIc9oUFPlH6C0LLr == null;
		}
	}

	private readonly IDictionary<int, ToggleButton> NiV4ahWntq = new Dictionary<int, ToggleButton>();

	private ToggleButton kZ147TJQi6;

	private readonly IDictionary<int, int> yhV4R7QmEr = new Dictionary<int, int>();

	internal Canvas CanvasGlobal;

	internal Canvas CanvasContext;

	internal HotkeyInputControl KeyInputCtrl;

	internal Button BtnClear;

	internal Button BtnClearAll;

	internal BooleanSettingControl ToggleEnableKeyTriggerWhenPopupByMouse;

	private bool TfB4qRecjJ;

	internal static PanelTriggerKeySettings VWUeLuTddiIZBXL2U16;

	public PanelTriggerKeySettings()
	{
		InitializeComponent();
		J8l4uIUH5R();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		yhV4R7QmEr.Clear();
		IDictionary<int, int> keyTriggers = settings.KeyTriggers;
		if (keyTriggers == null)
		{
			return;
		}
		foreach (KeyValuePair<int, int> item in keyTriggers)
		{
			yhV4R7QmEr.Add(item);
		}
		foreach (KeyValuePair<int, int> item2 in yhV4R7QmEr)
		{
			gOq4PW1dZy(NiV4ahWntq[item2.Value]);
		}
		ToggleEnableKeyTriggerWhenPopupByMouse.IsChecked = settings.EnableKeyTriggerWhenPopupByMouse;
		if (kZ147TJQi6 == null)
		{
			xCR404wqJi(NiV4ahWntq[0]);
			int num = 0;
			if (VWUeLuTddiIZBXL2U16 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		IDictionary<int, int> data = GetData();
		if (settings.KeyTriggers == null)
		{
			settings.KeyTriggers = new ConcurrentDictionary<int, int>();
		}
		else
		{
			settings.KeyTriggers.Clear();
		}
		foreach (KeyValuePair<int, int> item in data)
		{
			settings.KeyTriggers.Add(item);
		}
		settings.EnableKeyTriggerWhenPopupByMouse = ToggleEnableKeyTriggerWhenPopupByMouse.IsChecked;
		return true;
	}

	public IDictionary<int, int> GetData()
	{
		return yhV4R7QmEr;
	}

	private void J8l4uIUH5R()
	{
		SetValue(ActionButton.InvalidButtonColorProperty, Color.FromArgb(200, 240, 240, 240).GetBrush());
		CanvasGlobal.Height = 184.0;
		CanvasContext.Height = 245.0;
		Canvas canvasGlobal = CanvasGlobal;
		Canvas canvasContext = CanvasContext;
		double width = 245.0;
		canvasContext.Width = 245.0;
		canvasGlobal.Width = width;
		AppHelper.CreateToggleButtonsOnCavas(CanvasGlobal, 3, 4, true, 60.0, 1.0, NiV4ahWntq, sCM4yXlAfP);
		AppHelper.CreateToggleButtonsOnCavas(CanvasContext, 4, 4, false, 60.0, 1.0, NiV4ahWntq, OY348R1laF);
	}

	private void XcB4N26f2b(object sender, KeyEventArgs e)
	{
	}

	private void Luj4J44baG(object sender, RoutedEventArgs e)
	{
		ToggleButton toggleButton_ = sender as ToggleButton;
		xCR404wqJi(toggleButton_);
		e.Handled = true;
	}

	private void xCR404wqJi(ToggleButton toggleButton_1)
	{
		if (kZ147TJQi6 != null)
		{
			kZ147TJQi6.IsChecked = false;
		}
		toggleButton_1.IsChecked = true;
		kZ147TJQi6 = toggleButton_1;
	}

	private void SIF4CaoEgP(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		if (kZ147TJQi6 != null)
		{
			_003C_003Ec__DisplayClass13_.fd7vVB597dM = Convert.ToInt32(kZ147TJQi6.Tag, CultureInfo.InvariantCulture);
			KeyValuePair<int, int> item = yhV4R7QmEr.FirstOrDefault(_003C_003Ec__DisplayClass13_.OOuvVpRmCOP);
			if (item.Key > 0)
			{
				yhV4R7QmEr.Remove(item);
			}
			gOq4PW1dZy(kZ147TJQi6);
		}
	}

	private void gOq4PW1dZy(ToggleButton toggleButton_1)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.EwrvVjBC543 = Convert.ToInt32(toggleButton_1.Tag, CultureInfo.InvariantCulture);
		KeyValuePair<int, int> keyValuePair = yhV4R7QmEr.FirstOrDefault(_003C_003Ec__DisplayClass14_.Ej1vVQnJoSd);
		if (keyValuePair.Key < 1)
		{
			NiV4ahWntq[_003C_003Ec__DisplayClass14_.EwrvVjBC543].Content = null;
		}
		else
		{
			NiV4ahWntq[_003C_003Ec__DisplayClass14_.EwrvVjBC543].Content = KeyboardHelper.GetKeyName((VirtualKeyCode)keyValuePair.Key);
		}
	}

	private void HotkeyInputControl_OnKeySelected(object sender, EventArgs e)
	{
        VirtualKeyCode virtualKeyCode = default;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		if (kZ147TJQi6 == null)
		{
			AppHelper.ShowWarning("请先选择要设置触发键的按钮。");
			return;
		}
		IList<VirtualKeyCode> list = (e as HotkeyInputControl.eui5DfuGF9WWP7Css2k).Modifiers;
		IList<VirtualKeyCode> list2 = (e as HotkeyInputControl.eui5DfuGF9WWP7Css2k).Keys;
		if (list.Count + list2.Count > 1)
		{
			AppHelper.ShowWarning("只能设置单个按键。");
			return;
		}
		if (list.Count + list2.Count == 0)
		{
			AppHelper.ShowWarning("没有选择按键。");
			return;
		}
		int num;
		if (list.Count > 0)
		{
			num = 0;
			if (!wAq5khTOfEdwx5xBOHH())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00cb;
		}
		virtualKeyCode = list2[0];
		goto IL_0097;
		IL_00db:
		AppHelper.ShowWarning("按键 $" + KeyboardHelper.GetKeyName(virtualKeyCode) + " 不可使用。");
		return;
		IL_00cb:
		switch (num)
		{
		case 1:
			goto IL_00db;
		}
		virtualKeyCode = list[0];
		goto IL_0097;
		IL_0097:
		if (new VirtualKeyCode[4]
		{
			VirtualKeyCode.CONTROL,
			VirtualKeyCode.LCONTROL,
			VirtualKeyCode.RCONTROL,
			VirtualKeyCode.ESCAPE
		}.Contains(virtualKeyCode))
		{
			num = 0;
			if (VWUeLuTddiIZBXL2U16 != null)
			{
				goto IL_00cb;
			}
			goto IL_00db;
		}
		if (yhV4R7QmEr.ContainsKey((int)virtualKeyCode))
		{
			AppHelper.ShowWarning("按键已使用。");
			return;
		}
		_003C_003Ec__DisplayClass15_.junvV5lI4Jy = Convert.ToInt32(kZ147TJQi6.Tag, CultureInfo.InvariantCulture);
		foreach (KeyValuePair<int, int> item in yhV4R7QmEr.Where(_003C_003Ec__DisplayClass15_.uEGvVDOOhDx ?? (_003C_003Ec__DisplayClass15_.uEGvVDOOhDx = _003C_003Ec__DisplayClass15_.vPtvVnm3qC6)).ToList())
		{
			yhV4R7QmEr.Remove(item);
		}
		yhV4R7QmEr.Add((int)virtualKeyCode, _003C_003Ec__DisplayClass15_.junvV5lI4Jy);
		gOq4PW1dZy(kZ147TJQi6);
		KeyValuePair<int, ToggleButton> keyValuePair = NiV4ahWntq.FirstOrDefault(_003C_003Ec__DisplayClass15_.ihQvV48w88G);
		if (keyValuePair.Equals(default(KeyValuePair<int, ToggleButton>)))
		{
			xCR404wqJi(NiV4ahWntq[0]);
		}
		else
		{
			xCR404wqJi(keyValuePair.Value);
		}
	}

	private void Y6T4E5ZOJV(object sender, RoutedEventArgs e)
	{
		if (!AppHelper.Confirm("您确认要删除所有按键设置么？"))
		{
			return;
		}
		yhV4R7QmEr.Clear();
		foreach (ToggleButton value in NiV4ahWntq.Values)
		{
			gOq4PW1dZy(value);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!TfB4qRecjJ)
		{
			TfB4qRecjJ = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/panel/paneltriggerkeysettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			TfB4qRecjJ = true;
			break;
		case 1:
			CanvasGlobal = (Canvas)target;
			break;
		case 2:
			CanvasContext = (Canvas)target;
			break;
		case 3:
		{
			KeyInputCtrl = (HotkeyInputControl)target;
			int num = 0;
			if (!wAq5khTOfEdwx5xBOHH())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 4:
			BtnClear = (Button)target;
			BtnClear.Click += SIF4CaoEgP;
			break;
		case 5:
			BtnClearAll = (Button)target;
			BtnClearAll.Click += Y6T4E5ZOJV;
			break;
		case 6:
			ToggleEnableKeyTriggerWhenPopupByMouse = (BooleanSettingControl)target;
			break;
		}
	}

	[CompilerGenerated]
	private void sCM4yXlAfP(ToggleButton toggleButton_1)
	{
		toggleButton_1.FontSize = 11.0;
		toggleButton_1.Focusable = true;
		toggleButton_1.PreviewKeyDown += XcB4N26f2b;
		toggleButton_1.PreviewMouseDown += Luj4J44baG;
	}

	[CompilerGenerated]
	private void OY348R1laF(ToggleButton toggleButton_1)
	{
		toggleButton_1.FontSize = 11.0;
		toggleButton_1.Focusable = true;
		toggleButton_1.PreviewKeyDown += XcB4N26f2b;
		toggleButton_1.PreviewMouseDown += Luj4J44baG;
	}

	internal static bool wAq5khTOfEdwx5xBOHH()
	{
		return VWUeLuTddiIZBXL2U16 == null;
	}
}
