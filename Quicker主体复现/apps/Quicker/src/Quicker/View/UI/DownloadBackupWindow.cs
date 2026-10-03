using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Backup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.View.UI;

public class DownloadBackupWindow : Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec P9GS4XSM6dT;

		public static Func<BackupItemListDto, DateTime> ocOS4mIM02K;

		public static Func<BackupItemListDto, bool> zI6S4KRmp2u;

		private static _003C_003Ec SeVHUxWSa9gFFumsqiw6;

		static _003C_003Ec()
		{
			P9GS4XSM6dT = new _003C_003Ec();
		}

		internal DateTime IUwS4b3BuS4(BackupItemListDto x)
		{
			return x.CreateTimeUtc;
		}

		internal bool suJS46MSIFQ(BackupItemListDto x)
		{
			return x.IsManualSave;
		}

		internal static bool LK7WZAWSr2bDbJ4sHuYw()
		{
			return SeVHUxWSa9gFFumsqiw6 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDownload_OnClick_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DownloadBackupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object p3vFqRWS9bhjgvaaeCr0;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DownloadBackupWindow downloadBackupWindow = _003C_003E4__this;
			try
			{
        BackupItemListDto backupItemListDto = default;
				if (num == 0)
				{
					goto IL_008e;
				}
				backupItemListDto = default(BackupItemListDto);
				if (downloadBackupWindow.LbHistoryAuto.SelectedItem == null)
				{
					AppHelper.ShowWarning("请选择要加载的版本。", true);
				}
				else if (downloadBackupWindow.LbHistoryAuto.SelectedItems.Count > 1)
				{
					AppHelper.ShowWarning("只能选择1项进行恢复。", true);
					if (!Unru72WSLig6LpoS7gsX())
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					backupItemListDto = downloadBackupWindow.LbHistoryAuto.SelectedItem as BackupItemListDto;
					if (backupItemListDto != null)
					{
						goto IL_008e;
					}
					AppHelper.ShowWarning("请选择要使用的备份。");
				}
				goto end_IL_000e;
				IL_008e:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.vPwt19mLrpD(downloadBackupWindow.JrrL05k2GZK, downloadBackupWindow.IwcL0DoH3LA, backupItemListDto.Id).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<BackupItemDetailDto> result = awaiter.GetResult();
					int num2 = 0;
					if (!Unru72WSLig6LpoS7gsX())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
						if (result.IsSuccess)
						{
							downloadBackupWindow.BackupItem = result.Data;
							downloadBackupWindow.ThNvuM5Q9GQ(true);
						}
						else
						{
							AppHelper.ShowWarning("下载出错：" + result.Message);
						}
						break;
					}
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("下载出错：" + exception.GetMessageWithInner());
				}
				end_IL_000e:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool Unru72WSLig6LpoS7gsX()
		{
			return p3vFqRWS9bhjgvaaeCr0 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAutoBackups_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DownloadBackupWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Rt1jpAWSo9Ket7xMRFj9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DownloadBackupWindow downloadBackupWindow = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.GDXt1VN8yYU(downloadBackupWindow.JrrL05k2GZK, downloadBackupWindow.IwcL0DoH3LA).ConfigureAwait(true).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_00a1;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						num2 = 1;
						if (Rt1jpAWSo9Ket7xMRFj9 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter);
						num2 = 0;
						if (!i9cBVgWSfkB4IJGxghA5())
						{
							goto IL_0097;
						}
					}
					switch (num2)
					{
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0097;
					IL_00a1:
					ApiResult<IList<BackupItemListDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						downloadBackupWindow.QdHL0oapdkI = result.Data.OrderByDescending(_003C_003Ec.ocOS4mIM02K ?? (_003C_003Ec.ocOS4mIM02K = _003C_003Ec.P9GS4XSM6dT.IUwS4b3BuS4)).ToList();
						downloadBackupWindow.CUfL0Q3sRwj();
						downloadBackupWindow.LbHistoryAuto.ItemsSource = downloadBackupWindow.RS3L0dyWdJW;
						downloadBackupWindow.LblSummaryAuto.Content = $"共有 {downloadBackupWindow.QdHL0oapdkI.Count} 个历史版本";
					}
					else
					{
						AppHelper.ShowWarning("获取自动备份数据出错：" + result.Message, true);
					}
					goto end_IL_0011;
					IL_0097:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a1;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取自动备份数据出错：" + ex.Message, true);
				}
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

		internal static bool i9cBVgWSfkB4IJGxghA5()
		{
			return Rt1jpAWSo9Ket7xMRFj9 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DownloadBackupWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object LhEs9uWSihhDbgeZQNVB;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DownloadBackupWindow downloadBackupWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = downloadBackupWindow.KJWL0BMSEyK().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		static _003COnLoaded_003Ed__10()
		{
		}

		internal static bool WoueoEWSlfy0QoFEkdOZ()
		{
			return LhEs9uWSihhDbgeZQNVB == null;
		}

		internal static void CXjYbNWSY8jP0DQRTo9a()
		{
		}
	}

	private readonly UserObjectType JrrL05k2GZK;

	private readonly string IwcL0DoH3LA;

	private SmartCollection<BackupItemListDto> RS3L0dyWdJW = new SmartCollection<BackupItemListDto>();

	private IList<BackupItemListDto> QdHL0oapdkI;

	[CompilerGenerated]
	private BackupItemDetailDto sOcL0T6GaOP;

	[CompilerGenerated]
	private bool? Ra1L0MX56tM;

	internal Label LblSummaryAuto;

	internal CheckBox ChkOnlyManual;

	internal ListView LbHistoryAuto;

	internal Button BtnDownload;

	internal Button BtnClose;

	private bool zUML0AZHCcC;

	private static DownloadBackupWindow jqmQTsF3xpmleDm7N0FR;

	public BackupItemDetailDto BackupItem
	{
		[CompilerGenerated]
		get
		{
			return sOcL0T6GaOP;
		}
		[CompilerGenerated]
		set
		{
			sOcL0T6GaOP = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return Ra1L0MX56tM;
		}
		[CompilerGenerated]
		set
		{
			Ra1L0MX56tM = value;
		}
	}

	public DownloadBackupWindow(UserObjectType objectType, string objectId, string title)
	{
		JrrL05k2GZK = objectType;
		IwcL0DoH3LA = objectId;
		InitializeComponent();
		base.Title = title;
		base.Loaded += xjXL0pXVHhd;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__10))]
	private void xjXL0pXVHhd(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__10 stateMachine = default(_003COnLoaded_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadAutoBackups_003Ed__11))]
	private Task KJWL0BMSEyK()
	{
		_003CLoadAutoBackups_003Ed__11 stateMachine = default(_003CLoadAutoBackups_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void CUfL0Q3sRwj()
	{
		if (ChkOnlyManual.IsChecked != true)
		{
			RS3L0dyWdJW.Reset(QdHL0oapdkI);
		}
		else
		{
			RS3L0dyWdJW.Reset(QdHL0oapdkI.Where(_003C_003Ec.zI6S4KRmp2u ?? (_003C_003Ec.zI6S4KRmp2u = _003C_003Ec.P9GS4XSM6dT.suJS46MSIFQ)));
		}
	}

	[AsyncStateMachine(typeof(_003CBtnDownload_OnClick_003Ed__17))]
	private void N2UL0jUfkVX(object sender, RoutedEventArgs e)
	{
		_003CBtnDownload_OnClick_003Ed__17 stateMachine = default(_003CBtnDownload_OnClick_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void JLLL0nFa0XL(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void pj8L04LtgvU(object sender, RoutedEventArgs e)
	{
		CUfL0Q3sRwj();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zUML0AZHCcC)
		{
			zUML0AZHCcC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/downloadbackupwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				LblSummaryAuto = (Label)target;
				return;
			case 2:
				ChkOnlyManual = (CheckBox)target;
				ChkOnlyManual.Click += pj8L04LtgvU;
				return;
			case 3:
				LbHistoryAuto = (ListView)target;
				return;
			case 4:
				BtnDownload = (Button)target;
				BtnDownload.Click += N2UL0jUfkVX;
				return;
			case 5:
				BtnClose = (Button)target;
				BtnClose.Click += JLLL0nFa0XL;
				return;
			}
			int num2 = 0;
			if (!MIcFvAF3ItRryC1H2bMi())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			zUML0AZHCcC = true;
			return;
		}
	}

	internal static bool MIcFvAF3ItRryC1H2bMi()
	{
		return jqmQTsF3xpmleDm7N0FR == null;
	}
}
