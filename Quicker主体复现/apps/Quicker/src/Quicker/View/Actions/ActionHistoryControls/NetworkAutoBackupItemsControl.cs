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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Backup;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.View.Actions.ActionHistoryControls;

public class NetworkAutoBackupItemsControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec o43STEVDioG;

		public static Func<BackupItemListDto, DateTime> AccSTyK8Tj7;

		public static Func<BackupItemListDto, long> nBhST83WEus;

		internal static _003C_003Ec D73q4PWCRtZ5Bai03wrp;

		static _003C_003Ec()
		{
			o43STEVDioG = new _003C_003Ec();
		}

		internal DateTime JnJSTCsoUgM(BackupItemListDto x)
		{
			return x.CreateTimeUtc;
		}

		internal long UmrSTPBONPC(BackupItemListDto x)
		{
			return x.Id;
		}

		internal static bool OPLv3wWCgtCvCVyP0exp()
		{
			return D73q4PWCRtZ5Bai03wrp == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDelete_OnClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkAutoBackupItemsControl _003C_003E4__this;

		private List<BackupItemListDto> _003Citems_003E5__2;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		private static object q5Z3K0WCMkbjhYgEB6FT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkAutoBackupItemsControl networkAutoBackupItemsControl = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_006b;
				}
				_003Citems_003E5__2 = networkAutoBackupItemsControl.LbHistoryAuto.SelectedItems.Cast<BackupItemListDto>().ToList();
				if (AppHelper.Confirm($"您确认要删除这 {_003Citems_003E5__2.Count} 条记录么？") && _003Citems_003E5__2.HasData())
				{
					goto IL_006b;
				}
				goto end_IL_0010;
				IL_006b:
				try
				{
					TaskAwaiter<ApiResult<string>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.PVFt1hn78xu(UserObjectType.Action, _003Citems_003E5__2.Select(_003C_003Ec.nBhST83WEus ?? (_003C_003Ec.nBhST83WEus = _003C_003Ec.o43STEVDioG.UmrSTPBONPC)).ToList()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							int num2 = 0;
							if (q5Z3K0WCMkbjhYgEB6FT != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
					List<BackupItemListDto>.Enumerator enumerator = _003Citems_003E5__2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							BackupItemListDto current = enumerator.Current;
							networkAutoBackupItemsControl.lSgL9dLgctZ.Remove(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("删除失败！" + ex.Message);
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Citems_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Citems_003E5__2 = null;
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

		internal static bool aFM7doWCUdV6GaSjI2Zv()
		{
			return q5Z3K0WCMkbjhYgEB6FT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectAuto_OnClick_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkAutoBackupItemsControl _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object HZQdpVWCInlijcIFj8Gk;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkAutoBackupItemsControl networkAutoBackupItemsControl = _003C_003E4__this;
			try
			{
        BackupItemListDto backupItemListDto = default;
				if (num == 0)
				{
					goto IL_008e;
				}
				backupItemListDto = default(BackupItemListDto);
				if (networkAutoBackupItemsControl.LbHistoryAuto.SelectedItem == null)
				{
					AppHelper.ShowWarning("请选择要加载的版本。", true);
				}
				else if (networkAutoBackupItemsControl.LbHistoryAuto.SelectedItems.Count > 1)
				{
					if (!qTstSVWC6ONUYwEBJDuS())
					{
						switch (0)
						{
						}
					}
					AppHelper.ShowWarning("只能选择1项进行恢复。", true);
				}
				else
				{
					backupItemListDto = networkAutoBackupItemsControl.LbHistoryAuto.SelectedItem as BackupItemListDto;
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
						awaiter = aFIptTXYsUoTUF4v33R.vPwt19mLrpD(UserObjectType.Action, networkAutoBackupItemsControl.ActionId, backupItemListDto.Id).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							if (HZQdpVWCInlijcIFj8Gk == null)
							{
								switch (0)
								{
								}
							}
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
					if (result.IsSuccess)
					{
						ActionItem restoredItem = JsonConvert.DeserializeObject<ActionItem>(result.Data.Data);
						((ActionHistoryWindow)Window.GetWindow(networkAutoBackupItemsControl)).SelectItem(restoredItem);
					}
					else
					{
						AppHelper.ShowWarning("下载出错：" + result.Message);
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

		internal static bool qTstSVWC6ONUYwEBJDuS()
		{
			return HZQdpVWCInlijcIFj8Gk == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAutoBackups_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NetworkAutoBackupItemsControl _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object wyOcKaWCS4cp2c0Zt1QZ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkAutoBackupItemsControl networkAutoBackupItemsControl = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.GDXt1VN8yYU(UserObjectType.Action, networkAutoBackupItemsControl.ActionId).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<IList<BackupItemListDto>> result = awaiter.GetResult();
					List<BackupItemListDto> list;
					int num2;
					if (result.IsSuccess)
					{
						list = result.Data.OrderByDescending(_003C_003Ec.AccSTyK8Tj7 ?? (_003C_003Ec.AccSTyK8Tj7 = _003C_003Ec.o43STEVDioG.JnJSTCsoUgM)).ToList();
						networkAutoBackupItemsControl.lSgL9dLgctZ.Reset(list);
						networkAutoBackupItemsControl.LbHistoryAuto.ItemsSource = networkAutoBackupItemsControl.lSgL9dLgctZ;
						num2 = 0;
						if (!ESIGgXWCwYbTT5dn1yBy())
						{
							goto IL_0125;
						}
						goto IL_0129;
					}
					AppHelper.ShowWarning("获取自动备份数据出错：" + result.Message, true);
					goto end_IL_0011;
					IL_0129:
					while (true)
					{
						switch (num2)
						{
						case 1:
							goto end_IL_0129;
						}
						networkAutoBackupItemsControl.LblSummaryAuto.Content = $"共有 {list.Count} 个历史版本";
						num2 = 1;
						if (ESIGgXWCwYbTT5dn1yBy())
						{
							continue;
						}
						goto IL_0125;
						continue;
						end_IL_0129:
						break;
					}
					goto end_IL_0011;
					IL_0125:
					int num3 = default(int);
					num2 = num3;
					goto IL_0129;
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

		internal static bool ESIGgXWCwYbTT5dn1yBy()
		{
			return wyOcKaWCS4cp2c0Zt1QZ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkAutoBackupItemsControl _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object RCOmr5WCCeQ5y0428Dfc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkAutoBackupItemsControl networkAutoBackupItemsControl = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					if (networkAutoBackupItemsControl.WcAL9oBghBS)
					{
						goto IL_004d;
					}
					networkAutoBackupItemsControl.WcAL9oBghBS = true;
					num2 = 0;
					if (!oLYPBnWC7IMl4MblFZNK())
					{
						goto IL_0076;
					}
					goto IL_0083;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00a1;
				IL_00a1:
				awaiter.GetResult();
				goto IL_004d;
				IL_0076:
				switch (num2)
				{
				case 1:
					goto end_IL_000e;
				}
				goto IL_0083;
				IL_004d:
				if (!AppState.DataService.CpItmVISR7P().EnableAutoBackupActions)
				{
					networkAutoBackupItemsControl.PnlNotEnabled.Visibility = Visibility.Visible;
					num2 = 1;
					if (oLYPBnWC7IMl4MblFZNK())
					{
						goto IL_0076;
					}
				}
				else
				{
					networkAutoBackupItemsControl.PnlNotEnabled.Visibility = Visibility.Collapsed;
				}
				goto end_IL_000e;
				IL_0083:
				awaiter = networkAutoBackupItemsControl.EHRL9j8obaV().ConfigureAwait(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00a1;
				end_IL_000e:;
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

		internal static bool oLYPBnWC7IMl4MblFZNK()
		{
			return RCOmr5WCCeQ5y0428Dfc == null;
		}
	}

	[CompilerGenerated]
	private string e2XL9DSfGgD;

	private SmartCollection<BackupItemListDto> lSgL9dLgctZ = new SmartCollection<BackupItemListDto>();

	private bool WcAL9oBghBS;

	internal Label LblSummaryAuto;

	internal ListView LbHistoryAuto;

	internal StackPanel PnlNotEnabled;

	internal Hyperlink LnkEnableAutoBackup;

	internal Button BtnDelete;

	internal Button BtnSelectAuto;

	internal Button BtnCancel1;

	private bool E5lL9TiPYMC;

	private static NetworkAutoBackupItemsControl LREheSFdfNAIbJ9ufrWF;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return e2XL9DSfGgD;
		}
		[CompilerGenerated]
		set
		{
			e2XL9DSfGgD = value;
		}
	}

	public NetworkAutoBackupItemsControl()
	{
		InitializeComponent();
		base.Loaded += H4iL9QoS5v5;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__7))]
	private void H4iL9QoS5v5(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__7 stateMachine = default(_003COnLoaded_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadAutoBackups_003Ed__8))]
	private Task EHRL9j8obaV()
	{
		_003CLoadAutoBackups_003Ed__8 stateMachine = default(_003CLoadAutoBackups_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnSelectAuto_OnClick_003Ed__9))]
	private void F4cL9nh5NJ0(object sender, RoutedEventArgs e)
	{
		_003CBtnSelectAuto_OnClick_003Ed__9 stateMachine = default(_003CBtnSelectAuto_OnClick_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Y6SL94GfqxD(object sender, MouseButtonEventArgs e)
	{
		AppState.DataService.CpItmVISR7P().EnableAutoBackupActions = true;
		AppState.DataService.ydot6rVZAkW();
		PnlNotEnabled.Visibility = Visibility.Collapsed;
	}

	[AsyncStateMachine(typeof(_003CBtnDelete_OnClick_003Ed__11))]
	private void kaPL95pfeQW(object sender, RoutedEventArgs e)
	{
		_003CBtnDelete_OnClick_003Ed__11 stateMachine = default(_003CBtnDelete_OnClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!E5lL9TiPYMC)
		{
			E5lL9TiPYMC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actionhistorycontrols/networkautobackupitemscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			E5lL9TiPYMC = true;
			break;
		case 1:
			LblSummaryAuto = (Label)target;
			break;
		case 2:
			LbHistoryAuto = (ListView)target;
			break;
		case 3:
			PnlNotEnabled = (StackPanel)target;
			break;
		case 4:
			LnkEnableAutoBackup = (Hyperlink)target;
			LnkEnableAutoBackup.PreviewMouseDown += Y6SL94GfqxD;
			break;
		case 5:
			BtnDelete = (Button)target;
			BtnDelete.Click += kaPL95pfeQW;
			break;
		case 6:
		{
			BtnSelectAuto = (Button)target;
			int num = 0;
			if (!ycR4uWFdbh0iuMRECDPc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnSelectAuto.Click += F4cL9nh5NJ0;
				break;
			}
			break;
		}
		case 7:
			BtnCancel1 = (Button)target;
			break;
		}
	}

	internal static bool ycR4uWFdbh0iuMRECDPc()
	{
		return LREheSFdfNAIbJ9ufrWF == null;
	}
}
