using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Extensions;
using Quicker.Domain.SQL.Entities;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Settings.Pages.Tools;

public class BasicToolsSettingPage : SettingPage, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec agQvVzMTbsa;

		public static Func<ActionItem, bool> bN5vZw3tkKU;

		private static _003C_003Ec FxTgZjcLQb6II885qn8o;

		static _003C_003Ec()
		{
			agQvVzMTbsa = new _003C_003Ec();
		}

		internal bool QtgvVfHuiqe(ActionItem x)
		{
			return x?.IsReadOnly() ?? false;
		}

		internal static bool ApXTeKcLF4qwF9daAjKd()
		{
			return FxTgZjcLQb6II885qn8o == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public (bool isSuccess, string pathName) vv4vZgOfpAX;

		internal static _003C_003Ec__DisplayClass7_0 fMI16hcLWuFJa7ifXsgb;

		internal void xDHvZt54mj9()
		{
			try
			{
				string text = Path.Combine(vv4vZgOfpAX.pathName, "actions");
				int num = 0;
				if (!YGaM4xcLyTWHO6bhwNR3())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string text2 = Path.Combine(vv4vZgOfpAX.pathName, "states");
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
				int num4 = default(int);
				foreach (KeyValuePair<string, ActionProfile> item in AppState.DataService.mP6tXA8VyNP())
				{
					int num3 = 0;
					if (fMI16hcLWuFJa7ifXsgb != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					ActionProfile actionProfile = AppHelper.Clone(item.Value);
					foreach (ActionItem item2 in actionProfile.ActionItems.Where(_003C_003Ec.bN5vZw3tkKU ?? (_003C_003Ec.bN5vZw3tkKU = _003C_003Ec.agQvVzMTbsa.QtgvVfHuiqe)).ToList())
					{
						actionProfile.ActionItems.Remove(item2);
					}
					File.WriteAllText(Path.Combine(vv4vZgOfpAX.pathName, "actionpage_" + item.Key + ".json"), JsonConvert.SerializeObject(actionProfile));
					foreach (ActionItem actionItem in actionProfile.ActionItems)
					{
						if (actionItem != null && !actionItem.IsReadOnly())
						{
							File.WriteAllText(Path.Combine(text, "action_" + actionItem.Id + "_" + AppHelper.RemoveInvalidCharsFromFileName(actionItem.Title) + ".json"), JsonConvert.SerializeObject(actionItem));
						}
					}
				}
				foreach (CommonDataEntity item3 in AppState.SQLDataMgr.bGGtrhbtBm3())
				{
					File.WriteAllText(Path.Combine(vv4vZgOfpAX.pathName, "common_" + AppHelper.RemoveInvalidCharsFromFileName(item3.Id) + ".json"), item3.Data);
				}
				FileSystemHelper.DirectoryCopy(AppHelper.GetUserDataDir("states"), text2, true, true);
				AppHelper.ShowSuccess("操作完成！");
				AppHelper.TryOpenUrlOrFile(vv4vZgOfpAX.pathName);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("操作失败。" + exception.GetMessageWithInner(), true);
			}
		}

		internal static bool YGaM4xcLyTWHO6bhwNR3()
		{
			return fMI16hcLWuFJa7ifXsgb == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShrinkDataFile_OnClick_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		internal static object OZh92PcL24AGaU802Bla;

		private void MoveNext()
		{
			try
			{
				AppHelper.ShrinkDbFile();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool NLSK8ccLA9SSiavIMkFL()
		{
			return OZh92PcL24AGaU802Bla == null;
		}
	}

	internal Button BtnShrinkDataFile;

	internal Button BtnClearActionBackupData;

	internal Button BtnClearStateFiles;

	internal Button BtnRepairChromeConnection;

	internal Button BtnResetTextFloatButtonPostion;

	internal SimpleLinkControl LnkAppPath;

	internal SimpleLinkControl LnkAppStatePath;

	internal SimpleLinkControl LnkAppLogPath;

	internal Button BtnExportAll;

	private bool DLZ4TM68OV;

	private static BasicToolsSettingPage fGE2c6mXC74FpbtrtU3;

	public BasicToolsSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		LnkAppPath.Url = AppHelper.GetUserDataDir(null);
		LnkAppStatePath.Url = AppHelper.GetUserDataDir("states");
		LnkAppLogPath.Url = AppHelper.GetUserDataDir("logs");
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnShrinkDataFile_OnClick_003Ed__3))]
	private void vPN4juaGsy(object sender, RoutedEventArgs e)
	{
		_003CBtnShrinkDataFile_OnClick_003Ed__3 stateMachine = default(_003CBtnShrinkDataFile_OnClick_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void UCP4nxUE3I(object sender, RoutedEventArgs e)
	{
		BtnRepairChromeConnection.IsEnabled = false;
		try
		{
			BrowserExtensionHelper.InstallChromeMessageHost(true);
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("操作失败：" + exception.GetMessageWithInner());
		}
	}

	private void UwC449cp9j(object sender, RoutedEventArgs e)
	{
	}

	private void u7Z45GXFiK(object sender, RoutedEventArgs e)
	{
		try
		{
			AppState.TextFloatPanelMgr.ResetState();
			AppHelper.ShowSuccess("已重置重置文本悬浮窗位置。");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("操作出错：" + exception.GetMessageWithInner());
		}
	}

	private void on84D3lkfd(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		BtnExportAll.IsEnabled = false;
		_003C_003Ec__DisplayClass7_.vv4vZgOfpAX = AppHelper.ShowSelectFolderDialog(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		if (_003C_003Ec__DisplayClass7_.vv4vZgOfpAX.isSuccess)
		{
			Task.Run((Action)_003C_003Ec__DisplayClass7_.xDHvZt54mj9);
		}
		BtnExportAll.IsEnabled = true;
	}

	private void Bxc4dhjPGu(object sender, RoutedEventArgs e)
	{
		try
		{
			int num = ActionStateWriter.XnjgPjcreIP(true);
			if (num == 0)
			{
				AppHelper.ShowSuccess("没有需要清理的文件了。");
			}
			else
			{
				AppHelper.ShowSuccess($"共 {num} 个状态文件不再使用，已放入_old文件夹中。");
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("操作失败：" + exception.GetMessageWithInner());
		}
	}

	private void aQm4oNIObd(object sender, RoutedEventArgs e)
	{
		if (!AppHelper.Confirm("您确认要清理么？被清理的数据将彻底删除无法恢复。"))
		{
			return;
		}
		try
		{
			int num = AppState.SQLDataMgr.ClearActionVersions();
			AppHelper.ShowSuccess($"已清理{num}条记录。");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("操作失败：" + exception.GetMessageWithInner());
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!DLZ4TM68OV)
		{
			DLZ4TM68OV = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/basictoolssettingpage.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			DLZ4TM68OV = true;
			return;
		case 1:
			BtnShrinkDataFile = (Button)target;
			BtnShrinkDataFile.Click += vPN4juaGsy;
			return;
		case 2:
			BtnClearActionBackupData = (Button)target;
			BtnClearActionBackupData.Click += aQm4oNIObd;
			return;
		case 3:
			BtnClearStateFiles = (Button)target;
			BtnClearStateFiles.Click += Bxc4dhjPGu;
			return;
		case 4:
			BtnRepairChromeConnection = (Button)target;
			BtnRepairChromeConnection.Click += UCP4nxUE3I;
			num = 0;
			if (!Jog6tLm2nWjS7SNbQKm())
			{
				return;
			}
			break;
		case 5:
			BtnResetTextFloatButtonPostion = (Button)target;
			BtnResetTextFloatButtonPostion.Click += u7Z45GXFiK;
			return;
		case 6:
			LnkAppPath = (SimpleLinkControl)target;
			return;
		case 7:
			LnkAppStatePath = (SimpleLinkControl)target;
			return;
		case 8:
			LnkAppLogPath = (SimpleLinkControl)target;
			return;
		case 9:
			BtnExportAll = (Button)target;
			BtnExportAll.Click += on84D3lkfd;
			num = 1;
			if (!Jog6tLm2nWjS7SNbQKm())
			{
				return;
			}
			break;
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	internal static bool Jog6tLm2nWjS7SNbQKm()
	{
		return fGE2c6mXC74FpbtrtU3 == null;
	}
}
