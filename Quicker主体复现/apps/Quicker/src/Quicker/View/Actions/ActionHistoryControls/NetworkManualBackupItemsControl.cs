using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Backup;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.View.Actions.ActionHistoryControls;

public class NetworkManualBackupItemsControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec adpSTRU8lKr;

		public static Func<BackupItemListDto, DateTime> HP3STqL0YMa;

		public static Func<BackupItemListDto, long> J3OSTcBGRnV;

		internal static _003C_003Ec nXYiMXWCz94lDyFpERN7;

		static _003C_003Ec()
		{
			adpSTRU8lKr = new _003C_003Ec();
		}

		internal DateTime JHQSTaROnHl(BackupItemListDto x)
		{
			return x.CreateTimeUtc;
		}

		internal long K3kST7PBxDw(BackupItemListDto x)
		{
			return x.Id;
		}

		internal static void cPrtvBW7Frc8qx6SZmNL()
		{
		}

		internal static bool l7EGwZW7V8swoBXtDeh4()
		{
			return nXYiMXWCz94lDyFpERN7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDelete_OnClick_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkManualBackupItemsControl _003C_003E4__this;

		private List<BackupItemListDto> _003Citems_003E5__2;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		internal static object gugnYmW7WsDd1uWOMwmT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkManualBackupItemsControl networkManualBackupItemsControl = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_006b;
				}
				_003Citems_003E5__2 = networkManualBackupItemsControl.LbHistory.SelectedItems.Cast<BackupItemListDto>().ToList();
				if (_003Citems_003E5__2.HasData() && AppHelper.Confirm($"您确认要删除这 {_003Citems_003E5__2.Count} 条记录么？"))
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
						awaiter = aFIptTXYsUoTUF4v33R.qpxtbIddh6O(UserObjectType.Action, _003Citems_003E5__2.Select(_003C_003Ec.J3OSTcBGRnV ?? (_003C_003Ec.J3OSTcBGRnV = _003C_003Ec.adpSTRU8lKr.K3kST7PBxDw)).ToList()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (!o0yrDRW7yC6Kuhg6VDQk())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
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
							networkManualBackupItemsControl.Fv0L9FTdDQD.Remove(current);
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

		internal static bool o0yrDRW7yC6Kuhg6VDQk()
		{
			return gugnYmW7WsDd1uWOMwmT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelect_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkManualBackupItemsControl _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object un8Qc7W72k97tqKFtIPC;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkManualBackupItemsControl networkManualBackupItemsControl = _003C_003E4__this;
			try
			{
        BackupItemListDto backupItemListDto = default;
				if (num == 0)
				{
					goto IL_008d;
				}
				backupItemListDto = default(BackupItemListDto);
				if (networkManualBackupItemsControl.LbHistory.SelectedItem != null)
				{
					int num2 = 0;
					if (un8Qc7W72k97tqKFtIPC != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					if (networkManualBackupItemsControl.LbHistory.SelectedItems.Count > 1)
					{
						AppHelper.ShowWarning("只能选择一条。", true);
					}
					else
					{
						backupItemListDto = networkManualBackupItemsControl.LbHistory.SelectedItem as BackupItemListDto;
						if (backupItemListDto != null)
						{
							goto IL_008d;
						}
						AppHelper.ShowWarning("请选择要使用的备份。");
					}
				}
				else
				{
					AppHelper.ShowWarning("请选择要加载的版本。", true);
				}
				goto end_IL_000e;
				IL_008d:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<BackupItemDetailDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.j81tbWh3YoM(UserObjectType.Action, networkManualBackupItemsControl.ActionId, backupItemListDto.Id).ConfigureAwait(true).GetAwaiter();
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
					if (result.IsSuccess)
					{
						if (un8Qc7W72k97tqKFtIPC != null)
						{
							switch (0)
							{
							}
						}
						ActionItem restoredItem = JsonConvert.DeserializeObject<ActionItem>(result.Data.Data);
						((ActionHistoryWindow)Window.GetWindow(networkManualBackupItemsControl)).SelectItem(restoredItem);
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

		internal static bool vNw5cMW7Aw1yuaPNt9w8()
		{
			return un8Qc7W72k97tqKFtIPC == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkManualBackupItemsControl _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object xXvcaIW7j3mn4YmeAnwb;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkManualBackupItemsControl networkManualBackupItemsControl = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0029;
				}
				if (!networkManualBackupItemsControl.LKmL9ljDCXQ)
				{
					networkManualBackupItemsControl.LKmL9ljDCXQ = true;
					goto IL_0029;
				}
				goto end_IL_0010;
				IL_0029:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.rA8tbYrqXcM(UserObjectType.Action, networkManualBackupItemsControl.ActionId).ConfigureAwait(true).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_009f;
						}
						num2 = 1;
						if (xXvcaIW7j3mn4YmeAnwb != null)
						{
							goto IL_0078;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num2 = 0;
						if (!OWaWTWW7D7NJra2OX8lY())
						{
							goto IL_0078;
						}
					}
					goto IL_007c;
					IL_007c:
					switch (num2)
					{
					case 1:
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<BackupItemListDto>>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009f;
					IL_0078:
					int num3 = default(int);
					num2 = num3;
					goto IL_007c;
					IL_009f:
					ApiResult<IList<BackupItemListDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						networkManualBackupItemsControl.Fv0L9FTdDQD.Reset(result.Data.OrderByDescending(_003C_003Ec.HP3STqL0YMa ?? (_003C_003Ec.HP3STqL0YMa = _003C_003Ec.adpSTRU8lKr.JHQSTaROnHl)).ToList());
						networkManualBackupItemsControl.LbHistory.ItemsSource = networkManualBackupItemsControl.Fv0L9FTdDQD;
						networkManualBackupItemsControl.LblSummary.Content = $"共有 {networkManualBackupItemsControl.Fv0L9FTdDQD.Count} 个历史版本";
					}
					else
					{
						AppHelper.ShowWarning("获取手动备份数据出错：" + result.Message, true);
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取手动备份数据出错：" + ex.Message, true);
				}
				end_IL_0010:;
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

		internal static bool OWaWTWW7D7NJra2OX8lY()
		{
			return xXvcaIW7j3mn4YmeAnwb == null;
		}
	}

	private readonly SmartCollection<BackupItemListDto> Fv0L9FTdDQD = new SmartCollection<BackupItemListDto>();

	[CompilerGenerated]
	private string KEpL9UEq94c;

	private bool LKmL9ljDCXQ;

	internal Label LblSummary;

	internal ListView LbHistory;

	internal Button BtnDelete;

	internal Button BtnSelect;

	internal Button BtnCancel;

	private bool nPoL9ijc3N8;

	private static NetworkManualBackupItemsControl lgANZkFd5y9Cg0FIdtRM;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return KEpL9UEq94c;
		}
		[CompilerGenerated]
		set
		{
			KEpL9UEq94c = value;
		}
	}

	public NetworkManualBackupItemsControl()
	{
		InitializeComponent();
		base.Loaded += LvxL9M660jy;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__7))]
	private void LvxL9M660jy(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__7 stateMachine = default(_003COnLoaded_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnSelect_OnClick_003Ed__8))]
	private void s6lL9AcXJTE(object sender, RoutedEventArgs e)
	{
		_003CBtnSelect_OnClick_003Ed__8 stateMachine = default(_003CBtnSelect_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnDelete_OnClick_003Ed__9))]
	private void AqIL9OaOMOW(object sender, RoutedEventArgs e)
	{
		_003CBtnDelete_OnClick_003Ed__9 stateMachine = default(_003CBtnDelete_OnClick_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!nPoL9ijc3N8)
		{
			nPoL9ijc3N8 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actionhistorycontrols/networkmanualbackupitemscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			nPoL9ijc3N8 = true;
			break;
		case 1:
			LblSummary = (Label)target;
			break;
		case 2:
			LbHistory = (ListView)target;
			break;
		case 3:
		{
			BtnDelete = (Button)target;
			int num = 0;
			if (lgANZkFd5y9Cg0FIdtRM != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnDelete.Click += AqIL9OaOMOW;
				break;
			}
			break;
		}
		case 4:
			BtnSelect = (Button)target;
			BtnSelect.Click += s6lL9AcXJTE;
			break;
		case 5:
			BtnCancel = (Button)target;
			break;
		}
	}

	internal static bool hoSy3EFdYedYOjMmKj7E()
	{
		return lgANZkFd5y9Cg0FIdtRM == null;
	}
}
