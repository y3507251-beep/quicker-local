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
using System.Windows.Input;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.View.PowerKeys;

public class InstallPowerKeyWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public PowerKeyActionItem NVfSnUe8al1;

		public InstallPowerKeyWindow v4sSnluZaZ9;

		private static _003C_003Ec__DisplayClass5_0 KsefQJWt5A3rwUUhSJ6T;

		internal bool IwhSnFry4pk(PowerKeyActionItem x)
		{
			if (x.AdornKey == NVfSnUe8al1.AdornKey && x.SecondaryKey == NVfSnUe8al1.SecondaryKey)
			{
				return v4sSnluZaZ9.iaKLJeCgkVQ(x.BindingProcessName, NVfSnUe8al1.BindingProcessName);
			}
			return false;
		}

		internal static bool i1CHMJWtYpoHLJ7YG9y2()
		{
			return KsefQJWt5A3rwUUhSJ6T == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public string[] bIBSn3wqaa5;

		internal static _003C_003Ec__DisplayClass6_0 ApZpH1WtgKXLeAxxpaKQ;

		internal bool BDlSnicvX4x(string x)
		{
			return bIBSn3wqaa5.Contains(x);
		}

		internal static bool rM3M82WtPC7VvWfJPsgm()
		{
			return ApZpH1WtgKXLeAxxpaKQ == null;
		}
	}

	private readonly IDictionary<int, PowerKey> Mp1LJkJhPej;

	private readonly SharedPowerKeyDto aPWLJGWLvm2;

	[CompilerGenerated]
	private int lMwLJs08wHL;

	[CompilerGenerated]
	private IList<PowerKeyActionItem> XZbLJHDYYWR;

	internal HotkeyEditorControl KeyEditor;

	internal ListView LvActions;

	internal TextBlock LblInfo;

	internal Button BtnImport;

	internal Button BtnCancel;

	private bool oG8LJ1o0F6v;

	internal static InstallPowerKeyWindow v6BS56FD5njltnIjCrEr;

	public int Key
	{
		[CompilerGenerated]
		get
		{
			return lMwLJs08wHL;
		}
		[CompilerGenerated]
		set
		{
			lMwLJs08wHL = value;
		}
	}

	public IList<PowerKeyActionItem> Actions
	{
		[CompilerGenerated]
		get
		{
			return XZbLJHDYYWR;
		}
		[CompilerGenerated]
		set
		{
			XZbLJHDYYWR = value;
		}
	}

	public InstallPowerKeyWindow(IDictionary<int, PowerKey> powerKeys, SharedPowerKeyDto sharedPowerKey)
	{
		Mp1LJkJhPej = powerKeys;
		aPWLJGWLvm2 = sharedPowerKey;
		InitializeComponent();
		base.Loaded += T7qLJ9S9w8H;
		if (powerKeys == null)
		{
			BtnImport.Visibility = Visibility.Collapsed;
			BtnCancel.Content = "关闭";
			base.Title = "预览扩展热键包";
		}
	}

	private void T7qLJ9S9w8H(object sender, RoutedEventArgs e)
	{
		IList<PowerKeyActionItem> list = JsonConvert.DeserializeObject<IList<PowerKeyActionItem>>(aPWLJGWLvm2.Data);
		if (list == null)
		{
			list = new List<PowerKeyActionItem>();
		}
		LvActions.ItemsSource = list;
		foreach (PowerKeyActionItem item in list)
		{
			LvActions.SelectedItems.Add(item);
		}
		KeyEditor.Hotkey = new Hotkey((VirtualKeyCode)aPWLJGWLvm2.Key, ModifierKeys.None);
		mlxLJh09vfF();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void mlxLJh09vfF()
	{
		if (Mp1LJkJhPej == null)
		{
			return;
		}
		BtnImport.IsEnabled = false;
		(bool, string) tuple = CheckControlKey();
		int num = 0;
		if (v6BS56FD5njltnIjCrEr != null)
		{
			int num2 = default(int);
			num = num2;
		}
		int key = default(int);
		IList<string> list = default(IList<string>);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (tuple.Item1)
				{
					if (LvActions.SelectedItems.Count != 0)
					{
						if (KeyEditor.Hotkey != null)
						{
							key = (int)KeyEditor.Hotkey.Key;
							list = new List<string>();
							if (!Mp1LJkJhPej.ContainsKey(key))
							{
								break;
							}
							num = 0;
							if (!Q1jOmNFDYeKNHN06WNP8())
							{
								continue;
							}
							goto case 1;
						}
						return;
					}
					LblInfo.Text = "请选择要导入的按键组合。";
					return;
				}
				LblInfo.Text = tuple.Item2;
				return;
			case 1:
			{
				PowerKey powerKey = Mp1LJkJhPej[key];
				using (IEnumerator<PowerKeyActionItem> enumerator = LvActions.SelectedItems.Cast<PowerKeyActionItem>().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
						_003C_003Ec__DisplayClass5_.v4sSnluZaZ9 = this;
						_003C_003Ec__DisplayClass5_.NVfSnUe8al1 = enumerator.Current;
						if (!powerKey.KeyActions.Any(_003C_003Ec__DisplayClass5_.IwhSnFry4pk))
						{
							continue;
						}
						string text = "";
						int? adornKey = _003C_003Ec__DisplayClass5_.NVfSnUe8al1.AdornKey;
						int num3 = 1;
						if (v6BS56FD5njltnIjCrEr != null)
						{
							goto IL_0165;
						}
						goto IL_0169;
						IL_0169:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!adornKey.HasValue)
								{
									break;
								}
								goto IL_0158;
							default:
								text = text + KeyboardHelper.GetKeyName((VirtualKeyCode)_003C_003Ec__DisplayClass5_.NVfSnUe8al1.AdornKey.Value) + "+";
								break;
							}
							break;
							IL_0158:
							num3 = 0;
							if (Q1jOmNFDYeKNHN06WNP8())
							{
								continue;
							}
							goto IL_0165;
						}
						text = (_003C_003Ec__DisplayClass5_.NVfSnUe8al1.SecondaryKey.HasValue ? (text + KeyboardHelper.GetKeyName((VirtualKeyCode)_003C_003Ec__DisplayClass5_.NVfSnUe8al1.SecondaryKey.Value)) : (text ?? ""));
						list.Add(text);
						continue;
						IL_0165:
						num3 = num4;
						goto IL_0169;
					}
				}
				if (list.Count > 0)
				{
					LblInfo.Text = "如下按键在本地已有设置：" + string.Join(",", list);
					return;
				}
				break;
			}
			}
			break;
		}
		LblInfo.Text = "";
		BtnImport.IsEnabled = true;
	}

	private bool iaKLJeCgkVQ(string string_0, string string_1)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			_003C_003Ec__DisplayClass6_.bIBSn3wqaa5 = string_0.ToLower().SplitToList();
			return string_1.ToLower().SplitToList().Any(_003C_003Ec__DisplayClass6_.BDlSnicvX4x);
		}
		return true;
	}

	private void WMXLJYI3e2K(object sender, RoutedEventArgs e)
	{
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("引导键不能为空！");
			return;
		}
		Key = (int)KeyEditor.Hotkey.Key;
		Actions = LvActions.SelectedItems.Cast<PowerKeyActionItem>().ToList();
		{
			base.DialogResult = true;
		}
	}

	public (bool isOk, string message) CheckControlKey()
	{
		if (KeyEditor.Hotkey != null && KeyEditor.Hotkey.Modifiers == ModifierKeys.None)
		{
			if (KeyEditor.Hotkey.Key != VirtualKeyCode.LCONTROL && KeyEditor.Hotkey.Key != VirtualKeyCode.LSHIFT && KeyEditor.Hotkey.Key != VirtualKeyCode.LMENU && KeyEditor.Hotkey.Key != VirtualKeyCode.LWIN)
			{
				return (isOk: true, message: "");
			}
			return (isOk: false, message: "使用控制键将使其失去原来的功能，请更换为其他按键。");
		}
		return (isOk: false, message: "引导键请输入单个按键。");
	}

	private void rXwLJIK5kcg(object sender, SelectionChangedEventArgs e)
	{
		mlxLJh09vfF();
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		if (e.Hotkey != null)
		{
			mlxLJh09vfF();
		}
	}

	private void PBELJW1NsQc(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!oG8LJ1o0F6v)
		{
			oG8LJ1o0F6v = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/powerkeys/installpowerkeywindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			oG8LJ1o0F6v = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			LvActions = (ListView)target;
			LvActions.SelectionChanged += rXwLJIK5kcg;
			break;
		case 3:
		{
			LblInfo = (TextBlock)target;
			int num = 0;
			if (v6BS56FD5njltnIjCrEr != null)
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
			BtnImport = (Button)target;
			BtnImport.Click += WMXLJYI3e2K;
			break;
		case 5:
			BtnCancel = (Button)target;
			BtnCancel.Click += PBELJW1NsQc;
			break;
		}
	}

	internal static bool Q1jOmNFDYeKNHN06WNP8()
	{
		return v6BS56FD5njltnIjCrEr == null;
	}
}
