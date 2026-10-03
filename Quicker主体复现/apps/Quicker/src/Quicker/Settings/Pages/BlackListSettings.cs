using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using log4net;
using Microsoft.Win32;
using Quicker.Common.Entities;
using Quicker.Public.Extensions;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Controls;

namespace Quicker.Settings.Pages;

public class BlackListSettings : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec AZbvVIDfSyj;

		public static Func<ProcessModule, string> N6uvVWUJlPE;

		public static Func<SpecialExeItem, bool> Bv8vVkV2qkk;

		internal static _003C_003Ec gcAMD3cNHgQnPCdFRAU8;

		static _003C_003Ec()
		{
			AZbvVIDfSyj = new _003C_003Ec();
		}

		internal string l4EvVe7hEb2(ProcessModule x)
		{
			return x.ModuleName;
		}

		internal bool AOhvVYkZXMl(SpecialExeItem x)
		{
			return x.ExeName.Equals("unknown-proc.exe", StringComparison.OrdinalIgnoreCase);
		}

		internal static bool Q7Zis5cNzsVCmZoCZHip()
		{
			return gcAMD3cNHgQnPCdFRAU8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public string HrhvVsbvfJD;

		private static _003C_003Ec__DisplayClass15_0 HNa9XFc9Q1wEZ8YsaxTS;

		internal bool xFyvVGwO6QV(SpecialExeItem x)
		{
			return x.ExeName.Equals(HrhvVsbvfJD, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool sX8y70c9FJcsGaNK9T9x()
		{
			return HNa9XFc9Q1wEZ8YsaxTS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public (bool isSuccess, string pathName) vwbvV1PyNgj;

		internal static _003C_003Ec__DisplayClass16_0 dD6WUTc9WxmMwJyWH83k;

		internal bool HR4vVHB71UQ(SpecialExeItem x)
		{
			return x.ExeName.Equals(vwbvV1PyNgj.pathName, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool X9cOZTc9ySqyMD9h1o13()
		{
			return dD6WUTc9WxmMwJyWH83k == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public Process Fl7vV6Mk2KH;

		private static _003C_003Ec__DisplayClass6_0 NX1XGmc9XMBoQ0Yn9Zcv;

		internal bool Yy4vVbFGcgD(ProcessModule m)
		{
			return m.FileName == Fl7vV6Mk2KH.MainModule.FileName;
		}

		internal static bool QVk8COc9212IpJsoR4Em()
		{
			return NX1XGmc9XMBoQ0Yn9Zcv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_1
	{
		public ProcessModule DwrvVmm6mva;

		internal static _003C_003Ec__DisplayClass6_1 dHaVwYc9eXKEPdR6MpXG;

		internal bool lnavVXI3FnS(SpecialExeItem x)
		{
			return x.ExeName.Equals(Path.GetFileName(DwrvVmm6mva.FileName), StringComparison.OrdinalIgnoreCase);
		}

		internal static bool rhKmPJc9jKT2h8VDQCkB()
		{
			return dHaVwYc9eXKEPdR6MpXG == null;
		}
	}

	private static readonly ILog AwAneAAPaY;

	[CompilerGenerated]
	private ObservableCollection<SpecialExeItem> pk7nYBvJP1 = new ObservableCollection<SpecialExeItem>();

	internal ListBox LbSpecialExeList;

	internal WindowSelector TheWindowSelector;

	internal Button BtnAddExtraExe;

	internal Button BtnAddUnKnownExe;

	internal Button BtnAddFolder;

	internal CheckBox ToggleDisableOnFullscreenApp;

	internal ProcessSelectorControl FullScreenWhiteListProcessEditor;

	internal BooleanSettingControl TogglePowerKeysEnableBlackList;

	private bool rVGnIpPoNf;

	internal static BlackListSettings D3QvmfwKGj4xNDnGUJA;

	[SpecialName]
	[CompilerGenerated]
	private ObservableCollection<SpecialExeItem> v7InZTETpu()
	{
		return pk7nYBvJP1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void fDxn9hrlrk(ObservableCollection<SpecialExeItem> value)
	{
		pk7nYBvJP1 = value;
	}

	public BlackListSettings()
	{
		InitializeComponent();
		LbSpecialExeList.ItemsSource = v7InZTETpu();
		be7nqHquwO();
	}

	private void ficnyhwGqy(object sender, RoutedEventArgs e)
	{
		if (BtnAddExtraExe.ContextMenu != null && BtnAddExtraExe.ContextMenu.IsOpen)
		{
			BtnAddExtraExe.ContextMenu.IsOpen = false;
			int num = 0;
			if (D3QvmfwKGj4xNDnGUJA != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			return;
		}
		IList<Process> processesWithWindow = NativeMethods.GetProcessesWithWindow();
		List<ProcessModule> list = new List<ProcessModule>();
		using (IEnumerator<Process> enumerator = processesWithWindow.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				_003C_003Ec__DisplayClass6_.Fl7vV6Mk2KH = enumerator.Current;
				if (_003C_003Ec__DisplayClass6_.Fl7vV6Mk2KH == null || _003C_003Ec__DisplayClass6_.Fl7vV6Mk2KH.Id < 10)
				{
					continue;
				}
				try
				{
					if (!list.Any(_003C_003Ec__DisplayClass6_.Yy4vVbFGcgD))
					{
						list.Add(_003C_003Ec__DisplayClass6_.Fl7vV6Mk2KH.MainModule);
					}
				}
				catch
				{
				}
			}
		}
		list = list.OrderBy(_003C_003Ec.N6uvVWUJlPE ?? (_003C_003Ec.N6uvVWUJlPE = _003C_003Ec.AZbvVIDfSyj.l4EvVe7hEb2)).ToList();
		IList<ProcessItem> list2 = new List<ProcessItem>();
		using (List<ProcessModule>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_2 = new _003C_003Ec__DisplayClass6_1();
				_003C_003Ec__DisplayClass6_2.DwrvVmm6mva = enumerator2.Current;
				if (v7InZTETpu().Any(_003C_003Ec__DisplayClass6_2.lnavVXI3FnS))
				{
					continue;
				}
				try
				{
					string text = _003C_003Ec__DisplayClass6_2.DwrvVmm6mva.FileVersionInfo.FileDescription;
					if (string.IsNullOrEmpty(text))
					{
						text = Path.GetFileNameWithoutExtension(_003C_003Ec__DisplayClass6_2.DwrvVmm6mva.ModuleName);
					}
					using Icon icon = Icon.ExtractAssociatedIcon(_003C_003Ec__DisplayClass6_2.DwrvVmm6mva.FileName);
					list2.Add(new ProcessItem
					{
						ExePath = _003C_003Ec__DisplayClass6_2.DwrvVmm6mva.FileName,
						ExeFileName = Path.GetFileName(_003C_003Ec__DisplayClass6_2.DwrvVmm6mva.FileName),
						Title = text,
						Icon = IconHelper.IconToImageSource(icon)
					});
				}
				catch
				{
				}
			}
		}
		ContextMenu contextMenu = new ContextMenu();
		foreach (ProcessItem item in list2)
		{
			MenuItem menuItem = new MenuItem
			{
				Icon = new System.Windows.Controls.Image
				{
					Source = item.Icon,
					Width = 16.0,
					Height = 16.0
				},
				Header = item.ExeFileName,
				Tag = item
			};
			menuItem.Click += fyvn8NUaNW;
			contextMenu.Items.Add(menuItem);
		}
		MenuItem menuItem2 = new MenuItem
		{
			Header = "从计算机选择程序...",
			Tag = "SELECT"
		};
		menuItem2.Click += fyvn8NUaNW;
		contextMenu.Items.Add(menuItem2);
		BtnAddExtraExe.ContextMenu = contextMenu;
		contextMenu.IsOpen = true;
	}

	private void fyvn8NUaNW(object sender, RoutedEventArgs e)
	{
		if ((sender as MenuItem).Tag is string)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				ValidateNames = false,
				CheckFileExists = false,
				CheckPathExists = true,
				FileName = "",
				DefaultExt = ".exe",
				Filter = "可执行程序 (.exe)|*.exe|任意文件 (*.*)|*.*"
			};
			if (openFileDialog.ShowDialog() == true)
			{
				string fileName = openFileDialog.FileName;
				try
				{
					string fileDescription = FileVersionInfo.GetVersionInfo(fileName).FileDescription;
				}
				catch (Exception ex)
				{
					AwAneAAPaY.Info("获取文件信息失败：" + ex.Message, ex);
				}
				h4gn7GKG0x(Path.GetFileName(fileName));
			}
		}
		else
		{
			ProcessItem processItem = (sender as MenuItem).Tag as ProcessItem;
			h4gn7GKG0x(Path.GetFileName(processItem.ExeFileName));
		}
	}

	private void A15naMqlqw(object sender, RoutedEventArgs e)
	{
		SpecialExeItem item = (sender as Button).Tag as SpecialExeItem;
		v7InZTETpu().Remove(item);
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		v7InZTETpu().Clear();
		if (settings.SpecialExeList != null)
		{
			foreach (SpecialExeItem specialExe in settings.SpecialExeList)
			{
				v7InZTETpu().Add(specialExe);
			}
		}
		ToggleDisableOnFullscreenApp.IsChecked = settings.DisableOnFullscreenApp;
		FullScreenWhiteListProcessEditor.ProcessList = settings.AllowedFullscreenProcesses;
		TogglePowerKeysEnableBlackList.IsChecked = settings.PowerKeys_EnableBlackList;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.SpecialExeList = v7InZTETpu().ToList();
		settings.DisableOnFullscreenApp = ToggleDisableOnFullscreenApp.IsChecked == true;
		settings.AllowedFullscreenProcesses = FullScreenWhiteListProcessEditor.ProcessList;
		settings.PowerKeys_EnableBlackList = TogglePowerKeysEnableBlackList.IsChecked;
		return true;
	}

	private void TheWindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		string string_ = e.ProcessName + ".exe";
		try
		{
			string_ = Path.GetFileName(e.Process?.MainModule?.FileName);
		}
		catch (Exception exception)
		{
			AwAneAAPaY.Warn("无法获得进程的程序路径。", exception);
		}
		h4gn7GKG0x(string_);
	}

	private void h4gn7GKG0x(string string_1)
	{
		IList<string> relatedExes = RelatedExeHelper.GetRelatedExes(string_1);
		if (relatedExes.HasData() && AppHelper.Confirm("该程序(" + string_1 + ")有一些关联的程序，是否一同添加到黑名单？\n" + string.Join("\n", relatedExes)))
		{
			foreach (string item in relatedExes)
			{
				yx7ncbDUhJ(item, "", true);
			}
			return;
		}
		yx7ncbDUhJ(string_1, "", true);
	}

	private void ldenRESPgM(object sender, RoutedEventArgs e)
	{
		yx7ncbDUhJ("unknown-proc.exe", "", true);
		be7nqHquwO();
	}

	private void be7nqHquwO()
	{
		BtnAddUnKnownExe.Visibility = (!v7InZTETpu().Any(_003C_003Ec.Bv8vVkV2qkk ?? (_003C_003Ec.Bv8vVkV2qkk = _003C_003Ec.AZbvVIDfSyj.AOhvVYkZXMl))).ToVisibility();
	}

	private void yx7ncbDUhJ(string string_1, string string_2, bool bool_3)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.HrhvVsbvfJD = string_1;
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass15_.HrhvVsbvfJD))
		{
			if (!v7InZTETpu().Any(_003C_003Ec__DisplayClass15_.xFyvVGwO6QV))
			{
				v7InZTETpu().Add(new SpecialExeItem
				{
					ExeName = _003C_003Ec__DisplayClass15_.HrhvVsbvfJD,
					Description = string_2,
					Icon = ""
				});
			}
			else if (bool_3)
			{
				AppHelper.ShowInformation("应用已添加过：" + _003C_003Ec__DisplayClass15_.HrhvVsbvfJD);
			}
		}
	}

	private void cSonVOrDpG(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.vwbvV1PyNgj = AppHelper.ShowSelectFolderDialog("", "要加入黑名单的目录");
		if (_003C_003Ec__DisplayClass16_.vwbvV1PyNgj.isSuccess)
		{
			if (!v7InZTETpu().Any(_003C_003Ec__DisplayClass16_.HR4vVHB71UQ))
			{
				v7InZTETpu().Add(new SpecialExeItem
				{
					ExeName = _003C_003Ec__DisplayClass16_.vwbvV1PyNgj.pathName,
					Description = "文件夹",
					Icon = ""
				});
			}
			else
			{
				AppHelper.ShowInformation("应用已添加过：" + _003C_003Ec__DisplayClass16_.vwbvV1PyNgj.pathName);
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!rVGnIpPoNf)
		{
			rVGnIpPoNf = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/blacklist/blacklistsettings.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			LbSpecialExeList = (ListBox)target;
			break;
		default:
			rVGnIpPoNf = true;
			break;
		case 3:
			TheWindowSelector = (WindowSelector)target;
			break;
		case 4:
			BtnAddExtraExe = (Button)target;
			BtnAddExtraExe.Click += ficnyhwGqy;
			break;
		case 5:
		{
			BtnAddUnKnownExe = (Button)target;
			int num = 0;
			if (D3QvmfwKGj4xNDnGUJA != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnAddUnKnownExe.Click += ldenRESPgM;
				break;
			}
			break;
		}
		case 6:
			BtnAddFolder = (Button)target;
			BtnAddFolder.Click += cSonVOrDpG;
			break;
		case 7:
			ToggleDisableOnFullscreenApp = (CheckBox)target;
			break;
		case 8:
			FullScreenWhiteListProcessEditor = (ProcessSelectorControl)target;
			break;
		case 9:
			TogglePowerKeysEnableBlackList = (BooleanSettingControl)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			((Button)target).Click += A15naMqlqw;
		}
	}

	static BlackListSettings()
	{
		AwAneAAPaY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ujytvBwBunE6KQ0ro7n()
	{
		return D3QvmfwKGj4xNDnGUJA == null;
	}
}
