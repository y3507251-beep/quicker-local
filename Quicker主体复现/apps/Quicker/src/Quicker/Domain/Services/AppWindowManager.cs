using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;
using Quicker.Modules.AppBar;
using Quicker.Modules.AppMenu;
using Quicker.Settings;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.View.Tools;
using Quicker.View.X;

namespace Quicker.Domain.Services;

public static class AppWindowManager
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec pIfvj2ctCgR;

		public static Action kdLvjuWap6J;

		public static Action nSAvjN4PQ0o;

		public static Action RqkvjJxxKX9;

		private static _003C_003Ec gmJxBEcCE456SWo9Csaq;

		static _003C_003Ec()
		{
			pIfvj2ctCgR = new _003C_003Ec();
		}

		internal void DkKvjLdlK48()
		{
			if (AppHelper.FindRootWindow<AppBarWindow>() == null)
			{
				new AppBarWindow().Show();
			}
		}

		internal void RFOvjvJD9KM()
		{
			AppMenuWindow appMenuWindow = AppHelper.FindRootWindow<AppMenuWindow>();
			if (appMenuWindow == null)
			{
				appMenuWindow = new AppMenuWindow();
			}
			appMenuWindow.Show();
		}

		internal void BXevjSWyuf2()
		{
			InstallWebView2Window installWebView2Window = AppHelper.FindRootWindow<InstallWebView2Window>();
			if (installWebView2Window == null)
			{
				installWebView2Window = new InstallWebView2Window();
			}
			installWebView2Window.Show();
			installWebView2Window.Activate();
		}

		internal static bool iNqQ6LcCGq3MfQ3mxECq()
		{
			return gmJxBEcCE456SWo9Csaq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public SettingPageId? DbnvjC2n4yG;

		internal static _003C_003Ec__DisplayClass2_0 uFiQSxcC1RLK2GoaFwck;

		internal void Fpbvj0lvgBo()
		{
			SettingsWindow2 settingsWindow = AppHelper.FindRootWindow<SettingsWindow2>();
			if (settingsWindow != null)
			{
				if (settingsWindow.IsLoaded)
				{
					if (DbnvjC2n4yG.HasValue)
					{
						settingsWindow.SwitchToPage(DbnvjC2n4yG.Value);
					}
					goto IL_005e;
				}
				int num = 0;
				if (!PoP6u4cCK9uqLnVlFkuC())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			settingsWindow = new SettingsWindow2(DbnvjC2n4yG);
			goto IL_005e;
			IL_005e:
			if (settingsWindow.WindowState == WindowState.Minimized)
			{
				settingsWindow.WindowState = WindowState.Normal;
			}
			settingsWindow.Show();
			settingsWindow.Activate();
		}

		internal static bool PoP6u4cCK9uqLnVlFkuC()
		{
			return uFiQSxcC1RLK2GoaFwck == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public DispatcherFrame EtkvjEIDiXL;

		internal static _003C_003Ec__DisplayClass5_0 JZ7UvVcCdRCBL5i8VUoi;

		internal void rXevjPZfhZD(object sender, EventArgs e)
		{
			EtkvjEIDiXL.Continue = false;
		}

		internal static void iFmFWZcCkNosdHX7pEx1()
		{
		}

		internal static bool RgheIocCOCGutH1fsCVy()
		{
			return JZ7UvVcCdRCBL5i8VUoi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public string[] cFyvjaduPp1;

		public string y2hvj78L7KV;

		public string gnvvjRqtyss;

		public Func<ActionDesignerWindow, bool> FgUvjqFTBmG;

		private static _003C_003Ec__DisplayClass6_0 ePKoJdcCa1Ma7k1khZbp;

		internal void xFVvjywEe0B()
		{
			ActionDesignerWindow actionDesignerWindow = AppHelper.FindRootWindows<ActionDesignerWindow>().FirstOrDefault(FgUvjqFTBmG ?? (FgUvjqFTBmG = eQDvj8PtOt1));
			if (actionDesignerWindow != null)
			{
				actionDesignerWindow.FindStep(y2hvj78L7KV);
				actionDesignerWindow.Activate();
				return;
			}
			ClipboardHelper.SetText(y2hvj78L7KV);
			if (MessageBoxHelper.Show("未找到该动作的编辑窗口。是否立即编辑此动作？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation, MessageBoxResult.Cancel) == MessageBoxResult.OK)
			{
				AppState.lWutartRfUY().EditActionById(gnvvjRqtyss, new EditActionParam
				{
					FindStepPath = y2hvj78L7KV
				});
			}
		}

		internal bool eQDvj8PtOt1(ActionDesignerWindow x)
		{
			return string.Equals(x.EditingActionItem?.Id, cFyvjaduPp1[0], StringComparison.Ordinal);
		}

		internal static bool GsRdgccCrhEN4j7gRy8s()
		{
			return ePKoJdcCa1Ma7k1khZbp == null;
		}
	}

	internal static object i2DSXeQaiCZMYMM16ZM9;

	public static bool IsSettingsWindowOpen()
	{
		return AppHelper.FindRootWindow<SettingsWindow2>() != null;
	}

	public static bool IsSettingPageOpened(SettingPageId page)
	{
		SettingsWindow2 settingsWindow = AppHelper.FindRootWindow<SettingsWindow2>();
		if (settingsWindow == null)
		{
			return false;
		}
		return settingsWindow.CurrentSettingPageId == page;
	}

	public static void ShowSettingsWindow(SettingPageId? pageId = null)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.DbnvjC2n4yG = pageId;
		AppState.ExeBeforeShowConfigWindow = AppState.CurrentExeName;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass2_.Fpbvj0lvgBo);
	}

	public static void ShowAppBarWindow()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.kdLvjuWap6J ?? (_003C_003Ec.kdLvjuWap6J = _003C_003Ec.pIfvj2ctCgR.DkKvjLdlK48));
	}

	public static void ShowAppMenuWindow()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.nSAvjN4PQ0o ?? (_003C_003Ec.nSAvjN4PQ0o = _003C_003Ec.pIfvj2ctCgR.RFOvjvJD9KM));
	}

	public static void ShowWindowAndWaitClose(Window window, bool activate)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.EtkvjEIDiXL = new DispatcherFrame();
		window.Closed += _003C_003Ec__DisplayClass5_.rXevjPZfhZD;
		window.Show();
		if (activate)
		{
			window.Activate();
		}
		Dispatcher.PushFrame(_003C_003Ec__DisplayClass5_.EtkvjEIDiXL);
	}

	public static void FindStep(string cmd)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.cFyvjaduPp1 = cmd.Split(';');
		if (_003C_003Ec__DisplayClass6_.cFyvjaduPp1.Length != 3)
		{
			AppHelper.ShowWarning("定位步骤：参数格式不正确。\\n" + cmd);
			return;
		}
		_003C_003Ec__DisplayClass6_.gnvvjRqtyss = _003C_003Ec__DisplayClass6_.cFyvjaduPp1[0];
		_003C_003Ec__DisplayClass6_.y2hvj78L7KV = _003C_003Ec__DisplayClass6_.cFyvjaduPp1[2];
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass6_.xFVvjywEe0B);
	}

	public static void ShowWebViewInstaller()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.RqkvjJxxKX9 ?? (_003C_003Ec.RqkvjJxxKX9 = _003C_003Ec.pIfvj2ctCgR.BXevjSWyuf2));
	}

	static AppWindowManager()
	{
	}

	internal static bool VQWLJ0QalAFnu5KixqlZ()
	{
		return i2DSXeQaiCZMYMM16ZM9 == null;
	}

	internal static void ybe6JrQaYfbAADZf8civ()
	{
	}
}
