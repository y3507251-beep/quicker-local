using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Extensions;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Settings.Pages.Basic;

public class ActionBlockSettings : SettingPage, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec SaZvhRRVd9l;

		public static Func<string, bool> nVmvhqfFMo9;

		public static Func<string, string> giavhcbFFxB;

		public static Action eh6vhVdwxCl;

		private static _003C_003Ec lj7p0jcfgMnsd90fOLxh;

		static _003C_003Ec()
		{
			SaZvhRRVd9l = new _003C_003Ec();
		}

		internal bool zvRvh8OHrpo(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string qEWvhadZQdb(string x)
		{
			return x.Split('-')[0].ToLower();
		}

		internal void H2evh7Fh10q()
		{
			AppState.vjAt7Seco0Y()?.YyrtG5nkZFy(null);
		}

		internal static bool DkLdDRcfPrtYaSpQHKe5()
		{
			return lj7p0jcfgMnsd90fOLxh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public string browser;

		internal static _003C_003Ec__DisplayClass1_0 qf97rkcfUlcw2AZYtNC6;

		internal bool cBpvhZgvinm(SelectionItem x)
		{
			return string.Equals(x.Value, browser);
		}

		static _003C_003Ec__DisplayClass1_0()
		{
		}

		internal static bool ScpEIacfxEyhgso7AU5g()
		{
			return qf97rkcfUlcw2AZYtNC6 == null;
		}

		internal static void qmRHCkcf6CGKNsPYpNtQ()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public UserSettings SWFvhhDB5w1;

		private static _003C_003Ec__DisplayClass2_0 AXZHnhcftNNUNft5od5y;

		internal bool lvdvh9GPp1w(SelectionItem x)
		{
			return x.Value == SWFvhhDB5w1.DefaultBrowser;
		}

		internal static bool TwngMGcfSBKKdDUBHLD7()
		{
			return AXZHnhcftNNUNft5od5y == null;
		}
	}

	private List<SelectionItem> a3nTYJ15Hx = new List<SelectionItem>
	{
		new SelectionItem("chrome", "Chrome"),
		new SelectionItem("msedge", "Edge"),
		new SelectionItem("firefox", "Firefox"),
		new SelectionItem("vivaldi", "Vivaldi")
	};

	internal ProcessSelectorControl ProcessSelectorControl;

	internal BooleanSettingControl ToggleUse3rdScreenCapture;

	internal HotkeyEditorControl HotkeyFor3rdScreenCapture;

	internal System.Windows.Controls.ComboBox CbDefaultBrowser;

	internal CheckBox ChkEnableBrowserContextMenu;

	internal CheckBox ChkEnableWebPageActions;

	internal CheckBox ChkEnableWebPageActionsForActionPage;

	internal System.Windows.Controls.ComboBox CbDefaultExplorer;

	internal System.Windows.Controls.TextBox TxtCustomSelectInExplorerCmd;

	internal System.Windows.Controls.TextBox TxtCustomOpenFolderCmd;

	internal CheckBox ChkAlwaysUseClipboardToGetSelectedFiles;

	internal NumericUpDown TxtDefaultModifiedKeyDownDelay;

	internal PathSelectControl PythonDllPathSelector;

	internal System.Windows.Controls.ComboBox CbCustomPanelWindowDbClickAction;

	internal HotkeyEditorControl HotkeyForImeToEn;

	internal HotkeyEditorControl HotkeyForImeToZh;

	internal HandyControl.Controls.PasswordBox TxtBaiduApiKey;

	internal HandyControl.Controls.PasswordBox TxtBaiduSecretKey;

	internal CheckBox ChkAlwaysUseOwnKey;

	internal CheckBox ChkAllowUseQBean;

	internal NumericUpDown TxtOfflineOcrWaitSeconds;

	internal CheckBox ChkHideAllWaitKeyHintWindow;

	internal CheckBox ChkDisableCloseTextWindowByEsc;

	private bool OVPTISIv8q;

	internal static ActionBlockSettings WYYFIj7Pl3yP3aFRV3L;

	public ActionBlockSettings()
	{
		InitializeComponent();
		List<string> list = AppState.vjAt7Seco0Y()?.k3itG4fRlwV().Where(_003C_003Ec.nVmvhqfFMo9 ?? (_003C_003Ec.nVmvhqfFMo9 = _003C_003Ec.SaZvhRRVd9l.zvRvh8OHrpo)).Select(_003C_003Ec.giavhcbFFxB ?? (_003C_003Ec.giavhcbFFxB = _003C_003Ec.SaZvhRRVd9l.qEWvhadZQdb))
			.Distinct()
			.ToList();
		if (list.HasData())
		{
			using List<string>.Enumerator enumerator = list.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				_003C_003Ec__DisplayClass1_.browser = enumerator.Current;
				if (!a3nTYJ15Hx.Any(_003C_003Ec__DisplayClass1_.cBpvhZgvinm))
				{
					a3nTYJ15Hx.Add(new SelectionItem(_003C_003Ec__DisplayClass1_.browser, _003C_003Ec__DisplayClass1_.browser));
				}
			}
		}
		CbDefaultBrowser.ItemsSource = a3nTYJ15Hx;
		CbDefaultExplorer.ItemsSource = Enum.GetValues(typeof(ExplorerSoftware));
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.SWFvhhDB5w1 = settings;
		int num = 1;
		if (WYYFIj7Pl3yP3aFRV3L != null)
		{
			int num2 = default(int);
			num = num2;
		}
		do
		{
			switch (num)
			{
			case 1:
				goto IL_0028;
			}
			break;
			IL_0028:
			ProcessSelectorControl.ProcessList = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.CtrlInsertProcesses;
			ToggleUse3rdScreenCapture.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.EnableExternScreenCapture;
			HotkeyFor3rdScreenCapture.SetData(_003C_003Ec__DisplayClass2_.SWFvhhDB5w1.ExternScreenCaptureHotkey);
			a3nTYJ15Hx.FirstOrDefault(_003C_003Ec__DisplayClass2_.lvdvh9GPp1w);
			CbDefaultBrowser.Text = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.DefaultBrowser;
			ChkEnableBrowserContextMenu.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.EnableBrowserContextMenu;
			TxtDefaultModifiedKeyDownDelay.Value = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.DefaultModifiedKeyDownDelay;
			HotkeyForImeToEn.SetData(_003C_003Ec__DisplayClass2_.SWFvhhDB5w1.ImeToEnHotkey);
			HotkeyForImeToZh.SetData(_003C_003Ec__DisplayClass2_.SWFvhhDB5w1.ImeToZhHotkey);
			CbDefaultExplorer.SelectedValue = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.DefaultExplorerSoftware;
			num = 0;
		}
		while (!kqvWA77MuEhAsCRd5QW());
		TxtCustomSelectInExplorerCmd.Text = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.CustomSelectInExplorerCommand;
		ChkAlwaysUseClipboardToGetSelectedFiles.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.AlwaysUseClipboardToGetSelectedFiles;
		TxtCustomOpenFolderCmd.Text = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.CustomOpenFolderCommand;
		HandyControl.Controls.PasswordBox txtBaiduApiKey = TxtBaiduApiKey;
		BasicOcrSettings basicOcrSettings = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.BasicOcrSettings;
		object obj;
		if (basicOcrSettings == null)
		{
			obj = null;
		}
		else
		{
			obj = basicOcrSettings.BaiduApiKey;
			if (obj != null)
			{
				goto IL_01ab;
			}
		}
		obj = "";
		goto IL_01ab;
		IL_01ab:
		txtBaiduApiKey.Password = (string)obj;
		HandyControl.Controls.PasswordBox txtBaiduSecretKey = TxtBaiduSecretKey;
		BasicOcrSettings basicOcrSettings2 = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.BasicOcrSettings;
		object obj2;
		if (basicOcrSettings2 == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = basicOcrSettings2.BaiduSecretKey;
			if (obj2 != null)
			{
				goto IL_01d7;
			}
		}
		obj2 = "";
		goto IL_01d7;
		IL_01d7:
		txtBaiduSecretKey.Password = (string)obj2;
		ChkAllowUseQBean.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.BasicOcrSettings?.AllowUseQBean ?? false;
		ChkAlwaysUseOwnKey.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.BasicOcrSettings?.AlwaysUseOwnKey ?? false;
		ChkHideAllWaitKeyHintWindow.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.HideAllEmptyWaitKeyNotifyWindow;
		ChkDisableCloseTextWindowByEsc.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.DisableCloseTextWindowByEsc;
		ChkEnableWebPageActions.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.EnableWebPageActions;
		ChkEnableWebPageActionsForActionPage.IsChecked = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.EnableWebPageActionsForActionPage;
		PythonDllPathSelector.Path = dDh7g7Xw7JyQPUTbYwJ.TXntHBXc65x();
		TxtOfflineOcrWaitSeconds.Value = dDh7g7Xw7JyQPUTbYwJ.LocalOcrKeepAliveSeconds;
		CbCustomPanelWindowDbClickAction.SelectedIndex = _003C_003Ec__DisplayClass2_.SWFvhhDB5w1.CustomPanelWindowDbClickAction;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		bool flag = settings.EnableWebPageActions != (ChkEnableWebPageActions.IsChecked == true) || settings.EnableWebPageActionsForActionPage != (ChkEnableWebPageActionsForActionPage.IsChecked == true) || settings.EnableBrowserContextMenu != (ChkEnableBrowserContextMenu.IsChecked == true);
		settings.CtrlInsertProcesses = ProcessSelectorControl.ProcessList;
		settings.EnableExternScreenCapture = ToggleUse3rdScreenCapture.IsChecked;
		settings.ExternScreenCaptureHotkey = HotkeyFor3rdScreenCapture.GetKeyData();
		settings.DefaultBrowser = CbDefaultBrowser.Text.Trim();
		settings.EnableBrowserContextMenu = ChkEnableBrowserContextMenu.IsChecked == true;
		int num = 0;
		if (WYYFIj7Pl3yP3aFRV3L != null)
		{
			goto IL_026c;
		}
		goto IL_02ce;
		IL_026c:
		int num2 = default(int);
		num = num2;
		goto IL_02ce;
		IL_02ce:
		do
		{
			Action action;
			switch (num)
			{
			case 2:
				settings.DefaultExplorerSoftware = ((ExplorerSoftware?)CbDefaultExplorer.SelectedValue).GetValueOrDefault();
				settings.CustomSelectInExplorerCommand = TxtCustomSelectInExplorerCmd.Text;
				settings.AlwaysUseClipboardToGetSelectedFiles = ChkAlwaysUseClipboardToGetSelectedFiles.IsChecked == true;
				settings.CustomOpenFolderCommand = TxtCustomOpenFolderCmd.Text;
				if (settings.BasicOcrSettings == null)
				{
					settings.BasicOcrSettings = new BasicOcrSettings();
				}
				settings.BasicOcrSettings.BaiduApiKey = TxtBaiduApiKey.Password;
				settings.BasicOcrSettings.BaiduSecretKey = TxtBaiduSecretKey.Password;
				settings.BasicOcrSettings.AllowUseQBean = ChkAllowUseQBean.IsChecked == true;
				settings.BasicOcrSettings.AlwaysUseOwnKey = ChkAlwaysUseOwnKey.IsChecked == true;
				settings.HideAllEmptyWaitKeyNotifyWindow = ChkHideAllWaitKeyHintWindow.IsChecked == true;
				settings.DisableCloseTextWindowByEsc = ChkDisableCloseTextWindowByEsc.IsChecked == true;
				settings.EnableWebPageActions = ChkEnableWebPageActions.IsChecked == true;
				settings.EnableWebPageActionsForActionPage = ChkEnableWebPageActionsForActionPage.IsChecked == true;
				dDh7g7Xw7JyQPUTbYwJ.GJctHQ0XIpa(PythonDllPathSelector.Path);
				dDh7g7Xw7JyQPUTbYwJ.LocalOcrKeepAliveSeconds = Math.Max(1, (int)TxtOfflineOcrWaitSeconds.Value);
				settings.CustomPanelWindowDbClickAction = CbCustomPanelWindowDbClickAction.SelectedIndex;
				if (!flag)
				{
					break;
				}
				action = _003C_003Ec.eh6vhVdwxCl;
				if (action == null)
				{
					goto IL_025e;
				}
				goto IL_0304;
			default:
				if (!ToggleUse3rdScreenCapture.IsChecked || !string.IsNullOrEmpty(settings.ExternScreenCaptureHotkey))
				{
					settings.DefaultModifiedKeyDownDelay = (int)TxtDefaultModifiedKeyDownDelay.Value;
					settings.ImeToEnHotkey = HotkeyForImeToEn.GetKeyData();
					settings.ImeToZhHotkey = HotkeyForImeToZh.GetKeyData();
					num2 = 2;
					goto case 2;
				}
				AppHelper.ShowWarning("请输入截图热键。", true);
				return false;
			case 1:
				{
					action = (_003C_003Ec.eh6vhVdwxCl = _003C_003Ec.SaZvhRRVd9l.H2evh7Fh10q);
					goto IL_0304;
				}
				IL_0304:
				Task.Run(action);
				break;
			}
			return true;
			IL_025e:
			num = 1;
		}
		while (kqvWA77MuEhAsCRd5QW());
		goto IL_026c;
	}

	private void HotkeyFor3rdScreenCapture_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!OVPTISIv8q)
		{
			OVPTISIv8q = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/actionblocksettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			OVPTISIv8q = true;
			break;
		case 2:
			ToggleUse3rdScreenCapture = (BooleanSettingControl)target;
			break;
		case 3:
			HotkeyFor3rdScreenCapture = (HotkeyEditorControl)target;
			break;
		case 4:
			CbDefaultBrowser = (System.Windows.Controls.ComboBox)target;
			break;
		case 5:
			ChkEnableBrowserContextMenu = (CheckBox)target;
			break;
		case 6:
			ChkEnableWebPageActions = (CheckBox)target;
			break;
		case 7:
			ChkEnableWebPageActionsForActionPage = (CheckBox)target;
			if (!kqvWA77MuEhAsCRd5QW())
			{
				break;
			}
			switch (0)
			{
			default:
				return;
			case 1:
				break;
			}
			goto case 1;
		case 1:
			ProcessSelectorControl = (ProcessSelectorControl)target;
			break;
		case 8:
			CbDefaultExplorer = (System.Windows.Controls.ComboBox)target;
			break;
		case 9:
			TxtCustomSelectInExplorerCmd = (System.Windows.Controls.TextBox)target;
			break;
		case 10:
			TxtCustomOpenFolderCmd = (System.Windows.Controls.TextBox)target;
			break;
		case 11:
			ChkAlwaysUseClipboardToGetSelectedFiles = (CheckBox)target;
			break;
		case 12:
			TxtDefaultModifiedKeyDownDelay = (NumericUpDown)target;
			break;
		case 13:
			PythonDllPathSelector = (PathSelectControl)target;
			break;
		case 14:
			CbCustomPanelWindowDbClickAction = (System.Windows.Controls.ComboBox)target;
			break;
		case 15:
			HotkeyForImeToEn = (HotkeyEditorControl)target;
			break;
		case 16:
			HotkeyForImeToZh = (HotkeyEditorControl)target;
			break;
		case 17:
			TxtBaiduApiKey = (HandyControl.Controls.PasswordBox)target;
			break;
		case 18:
			TxtBaiduSecretKey = (HandyControl.Controls.PasswordBox)target;
			break;
		case 19:
			ChkAlwaysUseOwnKey = (CheckBox)target;
			break;
		case 20:
			ChkAllowUseQBean = (CheckBox)target;
			break;
		case 21:
			TxtOfflineOcrWaitSeconds = (NumericUpDown)target;
			break;
		case 22:
			ChkHideAllWaitKeyHintWindow = (CheckBox)target;
			break;
		case 23:
			ChkDisableCloseTextWindowByEsc = (CheckBox)target;
			break;
		}
	}

	internal static bool kqvWA77MuEhAsCRd5QW()
	{
		return WYYFIj7Pl3yP3aFRV3L == null;
	}
}
