using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using FontAwesome5;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace Quicker.Settings.Pages.Tools;

public class UpdateActionsPage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ukJvZzm9p8M;

		public static Func<string, Guid> VOFv9wRHWvE;

		public static Func<SharedActionUpdateListItem, DateTime?> KZiv9tk5cZm;

		public static Func<SharedActionUpdateListItem, bool> crpv9gXa2K9;

		public static Func<SharedActionUpdateListItem, bool> Tpfv9LAGNcB;

		public static Func<SharedActionUpdateListItem, bool> ieCv9vD7Jml;

		internal static _003C_003Ec bWCBRocu5qiCuvhidx85;

		static _003C_003Ec()
		{
			ukJvZzm9p8M = new _003C_003Ec();
		}

		internal Guid mE8vZUrqpfO(string x)
		{
			return Guid.Parse(x);
		}

		internal DateTime? jaLvZlG4Txj(SharedActionUpdateListItem x)
		{
			return x.LastUpdateTimeUtc;
		}

		internal bool blgvZi49Zss(SharedActionUpdateListItem x)
		{
			return x.Action.SkipCheckUpdate;
		}

		internal bool ip1vZ3HT4t0(SharedActionUpdateListItem x)
		{
			return !x.Action.SkipCheckUpdate;
		}

		internal bool WopvZf8Iyxh(SharedActionUpdateListItem x)
		{
			return x.Action.SkipCheckUpdate;
		}

		internal static bool GVpeBKcuYZxBxtQuWEUy()
		{
			return bWCBRocu5qiCuvhidx85 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public Guid vUHv92wANZP;

		internal static _003C_003Ec__DisplayClass14_0 tCUEgpcuRCT2pXSCPPtW;

		internal bool brQv9SQ6uJ4(CheckActionUpdatesDto.SharedActionInfo x)
		{
			return x.Id == vUHv92wANZP;
		}

		internal static bool L01iJRcugGgYVZfnbGYv()
		{
			return tCUEgpcuRCT2pXSCPPtW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public UpdateActionsPage QZsv9NDFnOP;

		public SharedActionUpdateListItem TbDv9JnCG7V;

		internal static _003C_003Ec__DisplayClass16_0 Fat77dcuMHE0JkhPjjtm;

		internal void Wqnv9uT4hUI()
		{
			QZsv9NDFnOP.YCqDx38xbP.Remove(TbDv9JnCG7V);
		}

		internal static bool Kc9wUKcuUG1ebDJCtZgk()
		{
			return Fat77dcuMHE0JkhPjjtm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Dx8DTKHU0yjSMQaGjq3 : IAsyncStateMachine
		{
			public int zrk2aNxH8rA;

			public AsyncTaskMethodBuilder A6W2aJrKISP;

			public _003C_003Ec__DisplayClass28_0 uJf2a0ryogP;

			private TaskAwaiter JfC2aC6TQ6I;

			private static object J2kpoCy9wrRpt7eRk0PR;

			private void MoveNext()
			{
				int num = zrk2aNxH8rA;
				_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = uJf2a0ryogP;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(250).GetAwaiter();
						int num2 = 0;
						if (!xiVUxTy9TE2ug2oyBQmf())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							zrk2aNxH8rA = 0;
							JfC2aC6TQ6I = awaiter;
							A6W2aJrKISP.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = JfC2aC6TQ6I;
						JfC2aC6TQ6I = default(TaskAwaiter);
						num = -1;
						zrk2aNxH8rA = -1;
					}
					awaiter.GetResult();
					AppState.AppServer.RequestSwitchProfile(_003C_003Ec__DisplayClass28_.bM9v9Ek7M8Q.Profile.Id, false);
				}
				catch (Exception exception)
				{
					zrk2aNxH8rA = -2;
					A6W2aJrKISP.SetException(exception);
					return;
				}
				zrk2aNxH8rA = -2;
				A6W2aJrKISP.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				A6W2aJrKISP.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool xiVUxTy9TE2ug2oyBQmf()
			{
				return J2kpoCy9wrRpt7eRk0PR == null;
			}
		}

		public SharedActionUpdateListItem bM9v9Ek7M8Q;

		public Func<Task> aW6v9yedNXY;

		private static _003C_003Ec__DisplayClass28_0 cfIBZ2cuISC8yY0vjSkt;

		internal void H2yv90EkiXp(object sender, RoutedEventArgs e)
		{
			AppHelper.OpenSharedActionUrl(bM9v9Ek7M8Q.Action.TemplateId);
		}

		internal void Qllv9CdO4Oq(object sender, RoutedEventArgs e)
		{
			AppState.AppServer.RequestShowPanel();
			Task.Run(aW6v9yedNXY ?? (aW6v9yedNXY = zYTv9PLbEgp));
		}

		[AsyncStateMachine(typeof(Dx8DTKHU0yjSMQaGjq3))]
		internal Task zYTv9PLbEgp()
		{
			Dx8DTKHU0yjSMQaGjq3 stateMachine = default(Dx8DTKHU0yjSMQaGjq3);
			stateMachine.A6W2aJrKISP = AsyncTaskMethodBuilder.Create();
			stateMachine.uJf2a0ryogP = this;
			stateMachine.zrk2aNxH8rA = -1;
			stateMachine.A6W2aJrKISP.Start(ref stateMachine);
			return stateMachine.A6W2aJrKISP.Task;
		}

		static _003C_003Ec__DisplayClass28_0()
		{
		}

		internal static bool RCuknvcu68BiuFi2Y9OS()
		{
			return cfIBZ2cuISC8yY0vjSkt == null;
		}

		internal static void ADpVcBcuSUeagKG46ewr()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnUpdateItem_OnClick_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public UpdateActionsPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object bk7fugcuwVTybnWYqFXU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00ac;
				}
				SharedActionUpdateListItem sharedActionUpdateListItem = (sender as Button).Tag as SharedActionUpdateListItem;
				int num2 = 0;
				if (!wQkdYacuTcZVQs4Lmd1W())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (sharedActionUpdateListItem != null)
				{
					awaiter = updateActionsPage.VBKDquCPjB(sharedActionUpdateListItem).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00ac;
				}
				goto end_IL_0010;
				IL_00ac:
				awaiter.GetResult();
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

		internal static bool wQkdYacuTcZVQs4Lmd1W()
		{
			return bk7fugcuwVTybnWYqFXU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnUpdateSelected_OnClick_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UpdateActionsPage _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private IEnumerator<SharedActionUpdateListItem> _003C_003E7__wrap2;

		private SharedActionUpdateListItem _003Citem_003E5__4;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object z1ABRscusBGbdmCB9gjM;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
        IList<SharedActionUpdateListItem> list = default;
				if (num == 0)
				{
					goto IL_0062;
				}
				list = default(IList<SharedActionUpdateListItem>);
				if (updateActionsPage.LvItems.SelectedItems.Count >= 1)
				{
					list = updateActionsPage.WQND9AZ6Vj();
					_003Ccount_003E5__2 = 0;
					updateActionsPage.Nx9D6gsoDf(true);
					goto IL_0062;
				}
				AppHelper.ShowWarning("请选择动作后执行。", true);
				if (z1ABRscusBGbdmCB9gjM == null)
				{
					switch (0)
					{
					}
				}
				goto end_IL_000e;
				IL_0062:
				try
				{
					if (num != 0)
					{
						_003C_003E7__wrap2 = list.GetEnumerator();
					}
					try
					{
        (ActionItem, ActionProfile) actionById = default;
						if (num != 0)
						{
							goto IL_01bd;
						}
						goto IL_007d;
						IL_01bd:
						while (_003C_003E7__wrap2.MoveNext())
						{
							_003Citem_003E5__4 = _003C_003E7__wrap2.Current;
							if (_003Citem_003E5__4 == null)
							{
								continue;
							}
							goto IL_01cc;
						}
						goto end_IL_0072;
						IL_0203:
						_003Citem_003E5__4 = null;
						goto IL_01bd;
						IL_01cc:
						actionById = updateActionsPage.gX1DmhEk5y.GetActionById(_003Citem_003E5__4.ActionId);
						if (z1ABRscusBGbdmCB9gjM != null)
						{
							switch (0)
							{
							}
						}
						if (actionById.Item1 != null)
						{
							goto IL_007d;
						}
						goto IL_0203;
						IL_007d:
						try
						{
							ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = updateActionsPage.WUKDKqxkcS.InstallAction(actionById.Item1, AppHelper.CreateSharedActionLink(_003Citem_003E5__4.Action.TemplateId), _003Citem_003E5__4.Profile, _003Citem_003E5__4.Row, _003Citem_003E5__4.Col, Window.GetWindow(updateActionsPage), updateActionsPage.ChkSkipConfirm.IsChecked == true).ConfigureAwait(true).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter;
									int num2 = 0;
									if (z1ABRscusBGbdmCB9gjM != null)
									{
										int num3 = default(int);
										num2 = num3;
									}
									switch (num2)
									{
									}
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
								num = -1;
								_003C_003E1__state = -1;
							}
							if (awaiter.GetResult())
							{
								_003Ccount_003E5__2++;
								updateActionsPage.YCqDx38xbP.Remove(_003Citem_003E5__4);
							}
						}
						catch (Exception exception)
						{
							AppHelper.ShowWarning("更新动作出错，请重试：" + exception.GetMessageWithInner(), true);
							goto end_IL_0062;
						}
						goto IL_0203;
						end_IL_0072:;
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap2 != null)
						{
							_003C_003E7__wrap2.Dispose();
						}
					}
					_003C_003E7__wrap2 = null;
					AppHelper.ShowInformation($"共更新了{_003Ccount_003E5__2}个动作");
					end_IL_0062:;
				}
				finally
				{
					if (num < 0)
					{
						updateActionsPage.Nx9D6gsoDf(false);
					}
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

		internal static bool EadjwscuC0KHEf0bmsrg()
		{
			return z1ABRscusBGbdmCB9gjM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UpdateActionsPage _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object EKuacocu4cCuLSYeTjCO;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
				List<string> list = default(List<string>);
				if (num != 0)
				{
					list = new List<string>();
					IEnumerator<ActionProfile> enumerator = updateActionsPage.gX1DmhEk5y.mP6tXA8VyNP().Values.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IEnumerator<ActionItem> enumerator2 = enumerator.Current.ActionItems.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									ActionItem current = enumerator2.Current;
									if (!string.IsNullOrEmpty(current.TemplateId) && !list.Contains(current.TemplateId))
									{
										list.Add(current.TemplateId);
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator2?.Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>> configuredTaskAwaitable = aFIptTXYsUoTUF4v33R.jKQtbNcw92B(new CheckActionUpdatesVm
						{
							SharedActions = list.Select(_003C_003Ec.VOFv9wRHWvE ?? (_003C_003Ec.VOFv9wRHWvE = _003C_003Ec.ukJvZzm9p8M.mE8vZUrqpfO)).ToList()
						}).ConfigureAwait(true);
						int num2 = 1;
						if (EKuacocu4cCuLSYeTjCO != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						case 1:
							break;
						default:
							goto IL_01e0;
						}
						awaiter = configuredTaskAwaitable.GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<CheckActionUpdatesDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<CheckActionUpdatesDto> result = awaiter.GetResult();
					if (!result.IsSuccess)
					{
						AppHelper.ShowWarning("检查更新出错：" + result.Message);
					}
					else
					{
						if (result.Data.SharedActions.Count == 0)
						{
							goto IL_01e0;
						}
						updateActionsPage.n4fD7ZMWyO(result.Data.SharedActions);
						updateActionsPage.LvItems.Visibility = Visibility.Visible;
					}
					goto end_IL_00bd;
					IL_01e0:
					AppHelper.ShowInformation("没有可更新的动作。");
					end_IL_00bd:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("检查更新异常：" + ex.Message);
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

		internal static bool RCaioDcuhUPqE6mSU0S7()
		{
			return EKuacocu4cCuLSYeTjCO == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLvItems_OnMouseDoubleClick_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MouseButtonEventArgs e;

		public UpdateActionsPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object DsLYjXcuz5h9VwkyB2ya;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00b8;
				}
				if (e.ChangedButton == MouseButton.Left && ((FrameworkElement)e.OriginalSource).DataContext is SharedActionUpdateListItem sharedActionUpdateListItem_)
				{
					awaiter = updateActionsPage.VBKDquCPjB(sharedActionUpdateListItem_).ConfigureAwait(true).GetAwaiter();
					if (DsLYjXcuz5h9VwkyB2ya != null)
					{
						switch (0)
						{
						}
					}
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b8;
				}
				goto end_IL_000e;
				IL_00b8:
				awaiter.GetResult();
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

		internal static bool TBjknlcoV3Vo1dBEhSE1()
		{
			return DsLYjXcuz5h9VwkyB2ya == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UpdateActionsPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object StZahTcoFFNmWY1uoMF7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = updateActionsPage.oFrDauMHEY().ConfigureAwait(true).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				if (StZahTcoFFNmWY1uoMF7 != null)
				{
					switch (0)
					{
					}
				}
				updateActionsPage.XKQDYgYWbQ();
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

		internal static bool W6QqyPcocqGBhGN1DPqR()
		{
			return StZahTcoFFNmWY1uoMF7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateItem_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UpdateActionsPage _003C_003E4__this;

		public SharedActionUpdateListItem item;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object A5DdK3coyun9yeGphdJ7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UpdateActionsPage updateActionsPage = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass16_0();
					_003C_003E8__1.QZsv9NDFnOP = _003C_003E4__this;
					_003C_003E8__1.TbDv9JnCG7V = item;
					updateActionsPage.Nx9D6gsoDf(true);
				}
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_016b;
					}
					(ActionItem, ActionProfile) actionById = updateActionsPage.gX1DmhEk5y.GetActionById(_003C_003E8__1.TbDv9JnCG7V.ActionId);
					if (actionById.Item1 != null)
					{
						awaiter = updateActionsPage.WUKDKqxkcS.InstallAction(actionById.Item1, AppHelper.CreateSharedActionLink(_003C_003E8__1.TbDv9JnCG7V.Action.TemplateId), _003C_003E8__1.TbDv9JnCG7V.Profile, _003C_003E8__1.TbDv9JnCG7V.Row, _003C_003E8__1.TbDv9JnCG7V.Col, Window.GetWindow(updateActionsPage), updateActionsPage.ChkSkipConfirm.IsChecked == true).ConfigureAwait(false).GetAwaiter();
						int num2 = 0;
						if (A5DdK3coyun9yeGphdJ7 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_016b;
					}
					goto end_IL_004a;
					IL_016b:
					if (awaiter.GetResult())
					{
						updateActionsPage.Dispatcher.Invoke(_003C_003E8__1.Wqnv9uT4hUI);
					}
					end_IL_004a:;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("更新动作出错，请重试：" + exception.GetMessageWithInner());
				}
				finally
				{
					if (num < 0)
					{
						updateActionsPage.Nx9D6gsoDf(false);
					}
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool ghNeracopaS3q5cBwUT7()
		{
			return A5DdK3coyun9yeGphdJ7 == null;
		}
	}

	private readonly DataService gX1DmhEk5y;

	private readonly ActionEditMgr WUKDKqxkcS;

	private readonly ObservableCollection<SharedActionUpdateListItem> YCqDx38xbP = new ObservableCollection<SharedActionUpdateListItem>();

	private ICollectionView uUpDrAl9GN;

	[CompilerGenerated]
	private bool N9TDpJoSdg;

	internal CheckBox ChkSelectAll;

	internal CheckBox ChkShowSkippedActions;

	internal Button BtnAddToSkipList;

	internal Button BtnSetAutoUpdate;

	internal Button BtnRemoveFromSkipList;

	internal StackPanel PnlButton;

	internal CheckBox ChkSkipConfirm;

	internal Button BtnUpdateSelected;

	internal ListView LvItems;

	private bool HxADBe1ZtS;

	internal static UpdateActionsPage V3EMaKm4mZ4GoW6mKe1;

	[SpecialName]
	[CompilerGenerated]
	private bool SpdDbKdXLE()
	{
		return N9TDpJoSdg;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Nx9D6gsoDf(bool value)
	{
		N9TDpJoSdg = value;
	}

	public UpdateActionsPage()
	{
		InitializeComponent();
		gX1DmhEk5y = AppState.DataService;
		WUKDKqxkcS = AppState.lWutartRfUY();
		InitializeComponent();
		uUpDrAl9GN = CollectionViewSource.GetDefaultView(YCqDx38xbP);
		uUpDrAl9GN.Filter = BlaD13alZ2;
		LvItems.ItemsSource = uUpDrAl9GN;
		base.Loaded += ghLD8JkPcn;
		ChkSkipConfirm.IsChecked = AppState.UserPreference.SkipConfirmationWhenBatchUpdateActions;
		BtnSetAutoUpdate.Content = "检查动作更新";
		BtnSetAutoUpdate.ToolTip = "手动查询网站上的动作版本；选择动作后下载到本地。";
	}

	private void ghLD8JkPcn(object sender, RoutedEventArgs e)
	{
		XKQDYgYWbQ();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	public override bool OnUnloading()
	{
		return !SpdDbKdXLE();
	}

	private async Task oFrDauMHEY()
	{
		if (SpdDbKdXLE()) return;
		Nx9D6gsoDf(true);
		BtnSetAutoUpdate.IsEnabled = false;
		try
		{
			var ids = new HashSet<Guid>();
			foreach (var profile in gX1DmhEk5y.mP6tXA8VyNP().Values)
			{
				if (profile?.ActionItems == null) continue;
				foreach (var action in profile.ActionItems)
					if (Guid.TryParse(action?.TemplateId, out var id)) ids.Add(id);
			}
			var result = await SharedActionImportService.CheckUpdatesAsync(ids);
			if (!result.IsSuccess)
			{
				AppHelper.ShowWarning(result.Message);
				return;
			}
			n4fD7ZMWyO(result.Data.SharedActions ?? new List<CheckActionUpdatesDto.SharedActionInfo>());
			if (YCqDx38xbP.Count == 0) AppHelper.ShowInformation("没有可更新的动作。");
		}
		catch (Exception error)
		{
			AppHelper.ShowWarning("检查动作更新异常：" + error.Message);
		}
		finally
		{
			Nx9D6gsoDf(false);
			BtnSetAutoUpdate.IsEnabled = true;
			XKQDYgYWbQ();
		}
	}

	private void n4fD7ZMWyO(IList<CheckActionUpdatesDto.SharedActionInfo> ilist_0)
	{
		List<SharedActionUpdateListItem> list = new List<SharedActionUpdateListItem>();
		foreach (ActionProfile value in gX1DmhEk5y.mP6tXA8VyNP().Values)
		{
			foreach (ActionItem actionItem in value.ActionItems ?? new List<ActionItem>())
			{
				if (actionItem != null && Guid.TryParse(actionItem.TemplateId, out var templateId))
				{
					_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					_003C_003Ec__DisplayClass14_.vUHv92wANZP = templateId;
					CheckActionUpdatesDto.SharedActionInfo sharedActionInfo = ilist_0.FirstOrDefault(_003C_003Ec__DisplayClass14_.brQv9SQ6uJ4);
					if (sharedActionInfo != null && sharedActionInfo.Revision > actionItem.TemplateRevision && !string.Equals(actionItem.SharedActionId, actionItem.TemplateId, StringComparison.OrdinalIgnoreCase))
					{
						SharedActionUpdateListItem item = new SharedActionUpdateListItem
						{
							Action = actionItem,
							ActionId = actionItem.Id,
							Title = actionItem.Title,
							Icon = actionItem.Icon,
							Description = actionItem.Description,
							Profile = value,
							ProfileId = value.Id,
							ProfileName = value.Name,
							Row = actionItem.Row,
							Col = actionItem.Col,
							CreateTimeUtc = actionItem.CreateTimeUtc,
							LastEditTimeUtc = actionItem.LastEditTimeUtc,
							CurrentRevision = actionItem.TemplateRevision,
							LastRevision = sharedActionInfo.Revision,
							LastUpdateTimeUtc = sharedActionInfo.LastUpdateTimeUtc,
							LastUpdateNote = sharedActionInfo.LastUpdateNote
						};
						list.Add(item);
					}
				}
			}
		}
		LvItems.BeginInit();
		YCqDx38xbP.Clear();
		foreach (SharedActionUpdateListItem item2 in list.OrderByDescending(_003C_003Ec.KZiv9tk5cZm ?? (_003C_003Ec.KZiv9tk5cZm = _003C_003Ec.ukJvZzm9p8M.jaLvZlG4Txj)))
		{
			YCqDx38xbP.Add(item2);
		}
		LvItems.EndInit();
	}

	[AsyncStateMachine(typeof(_003CBtnUpdateItem_OnClick_003Ed__15))]
	private void MFQDRk4Ky1(object sender, RoutedEventArgs e)
	{
		_003CBtnUpdateItem_OnClick_003Ed__15 stateMachine = default(_003CBtnUpdateItem_OnClick_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private async Task VBKDquCPjB(SharedActionUpdateListItem item)
	{
		if (SpdDbKdXLE() || item == null) return;
		Nx9D6gsoDf(true);
		try { await UpdateActionAsync(item); }
		finally { Nx9D6gsoDf(false); XKQDYgYWbQ(); }
	}

	private async Task<bool> UpdateActionAsync(SharedActionUpdateListItem item)
	{
		try
		{
			var current = gX1DmhEk5y.GetActionById(item.ActionId);
			if (current.Item1 == null || current.Item2 == null) return false;
			bool updated = await WUKDKqxkcS.InstallAction(current.Item1,
				AppHelper.CreateSharedActionLink(current.Item1.TemplateId), current.Item2,
				current.Item1.Row, current.Item1.Col, Window.GetWindow(this), ChkSkipConfirm.IsChecked == true);
			if (updated) YCqDx38xbP.Remove(item);
			return updated;
		}
		catch (Exception error)
		{
			AppHelper.ShowWarning("更新动作出错：" + error.GetMessageWithInner());
			return false;
		}
	}

	[AsyncStateMachine(typeof(_003CLvItems_OnMouseDoubleClick_003Ed__17))]
	private void GFWDc5gwXj(object sender, MouseButtonEventArgs e)
	{
		_003CLvItems_OnMouseDoubleClick_003Ed__17 stateMachine = default(_003CLvItems_OnMouseDoubleClick_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void rJwDVliK2q(object sender, RoutedEventArgs e)
	{
		SharedActionUpdateListItem sharedActionUpdateListItem = ((FrameworkElement)e.OriginalSource).DataContext as SharedActionUpdateListItem;
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/Share/Actions/Versions?code=" + sharedActionUpdateListItem.Action.TemplateId);
	}

	private async void SJVDZSQL2T(object sender, RoutedEventArgs e)
	{
		if (SpdDbKdXLE()) return;
		var items = WQND9AZ6Vj().Where(item => item != null).ToList();
		if (items.Count == 0) { AppHelper.ShowWarning("请选择动作后执行。", true); return; }
		Nx9D6gsoDf(true);
		try
		{
			int updated = 0;
			foreach (var item in items)
				if (await UpdateActionAsync(item)) updated++;
			AppHelper.ShowInformation($"共更新了{updated}个动作");
		}
		finally { Nx9D6gsoDf(false); XKQDYgYWbQ(); }
	}

	private IList<SharedActionUpdateListItem> WQND9AZ6Vj()
	{
		IList<SharedActionUpdateListItem> list = new List<SharedActionUpdateListItem>();
		foreach (object selectedItem in LvItems.SelectedItems)
		{
			list.Add(selectedItem as SharedActionUpdateListItem);
		}
		return list;
	}

	private void PKbDhe6CK6(object sender, RoutedEventArgs e)
	{
		uUpDrAl9GN.Refresh();
		XKQDYgYWbQ();
	}

	private void y6ODegv2Kv(object sender, RoutedEventArgs e)
	{
		IList<SharedActionUpdateListItem> list = WQND9AZ6Vj();
		if (list.Count == 0)
		{
			AppHelper.ShowWarning("请选择要忽略更新的动作。 ", true);
		}
		IList<ActionItem> list2 = new List<ActionItem>();
		foreach (SharedActionUpdateListItem item in list)
		{
			if (!item.SkipCheckUpdate)
			{
				item.Action.SkipCheckUpdate = true;
				list2.Add(item.Action);
			}
		}
		if (list2.Count > 0)
		{
			WUKDKqxkcS.UpdateActionProfiles(list2);
			uUpDrAl9GN.Refresh();
			LvItems.SelectedItems.Clear();
		}
	}

	private void XKQDYgYWbQ()
	{
		ChkShowSkippedActions.Visibility = ((!YCqDx38xbP.Any(_003C_003Ec.crpv9gXa2K9 ?? (_003C_003Ec.crpv9gXa2K9 = _003C_003Ec.ukJvZzm9p8M.blgvZi49Zss))) ? Visibility.Collapsed : Visibility.Visible);
		BtnSetAutoUpdate.Visibility = Visibility.Visible;
		Visibility visibility = (BtnAddToSkipList.Visibility = ((!LvItems.SelectedItems.Cast<SharedActionUpdateListItem>().Any(_003C_003Ec.Tpfv9LAGNcB ?? (_003C_003Ec.Tpfv9LAGNcB = _003C_003Ec.ukJvZzm9p8M.ip1vZ3HT4t0))) ? Visibility.Collapsed : Visibility.Visible));
		BtnRemoveFromSkipList.Visibility = ((!LvItems.SelectedItems.Cast<SharedActionUpdateListItem>().Any(_003C_003Ec.ieCv9vD7Jml ?? (_003C_003Ec.ieCv9vD7Jml = _003C_003Ec.ukJvZzm9p8M.WopvZf8Iyxh))) ? Visibility.Collapsed : Visibility.Visible);
		if (LvItems.SelectedItems.Count == 0)
		{
			ChkSelectAll.IsChecked = false;
		}
		else if (LvItems.SelectedItems.Count == LvItems.Items.Count)
		{
			ChkSelectAll.IsChecked = true;
		}
		else
		{
			ChkSelectAll.IsChecked = null;
		}
	}

	private void s6XDIcSfxr(object sender, RoutedEventArgs e)
	{
		IList<SharedActionUpdateListItem> list = WQND9AZ6Vj();
		if (list.Count == 0)
		{
			AppHelper.ShowWarning("请选择要取消忽略更新的动作。 ", true);
		}
		IList<ActionItem> list2 = new List<ActionItem>();
		foreach (SharedActionUpdateListItem item in list)
		{
			if (item.SkipCheckUpdate)
			{
				item.Action.SkipCheckUpdate = false;
				list2.Add(item.Action);
			}
		}
		if (list2.Count > 0)
		{
			WUKDKqxkcS.UpdateActionProfiles(list2);
			uUpDrAl9GN.Refresh();
			LvItems.SelectedItems.Clear();
		}
	}

	private void WWEDWQ57Yt(object sender, SelectionChangedEventArgs e)
	{
		XKQDYgYWbQ();
	}

	private void M47DkWKhyx(object sender, RoutedEventArgs e)
	{
		if (ChkSelectAll.IsChecked != true)
		{
			LvItems.SelectedItems.Clear();
		}
		else
		{
			LvItems.SelectAll();
		}
	}

	private void iZvDG0SdFs(object sender, RoutedEventArgs e)
	{
		AppState.UserPreference.SkipConfirmationWhenBatchUpdateActions = ChkSkipConfirm.IsChecked == true;
		AppState.DataService.tbAtXR5TON1();
	}

	private void FKBDs0cBsG(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		ListViewItem listViewItem = sender as ListViewItem;
		_003C_003Ec__DisplayClass28_.bM9v9Ek7M8Q = listViewItem?.DataContext as SharedActionUpdateListItem;
		if (_003C_003Ec__DisplayClass28_.bM9v9Ek7M8Q != null)
		{
			ContextMenu contextMenu = new ContextMenu();
			AppHelper.AddMenuItem(contextMenu.Items, "打开动作网页", "", $"fa:{EFontAwesomeIcon.Light_Globe}:#1296db", _003C_003Ec__DisplayClass28_.H2yv90EkiXp);
			int num = 0;
			if (!zjSxMVmhXgGL2GcsTHR())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.AddMenuItem(contextMenu.Items, "打开所在动作页", "在面板窗口中加载动作所在的动作页", $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#1296db", _003C_003Ec__DisplayClass28_.Qllv9CdO4Oq);
			listViewItem.ContextMenu = contextMenu;
		}
		e.Handled = true;
	}

	private async void rltDHWe49C(object sender, RoutedEventArgs e)
	{
		await oFrDauMHEY();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HxADBe1ZtS)
		{
			HxADBe1ZtS = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/updateactionspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			HxADBe1ZtS = true;
			return;
		case 1:
			ChkSelectAll = (CheckBox)target;
			ChkSelectAll.Click += M47DkWKhyx;
			return;
		case 2:
			ChkShowSkippedActions = (CheckBox)target;
			ChkShowSkippedActions.Click += PKbDhe6CK6;
			return;
		case 3:
			BtnAddToSkipList = (Button)target;
			BtnAddToSkipList.Click += y6ODegv2Kv;
			return;
		case 4:
			BtnSetAutoUpdate = (Button)target;
			BtnSetAutoUpdate.Click += rltDHWe49C;
			return;
		case 5:
			BtnRemoveFromSkipList = (Button)target;
			BtnRemoveFromSkipList.Click += s6XDIcSfxr;
			num = 1;
			if (V3EMaKm4mZ4GoW6mKe1 == null)
			{
				break;
			}
			goto IL_0181;
		case 6:
			PnlButton = (StackPanel)target;
			return;
		case 7:
			ChkSkipConfirm = (CheckBox)target;
			ChkSkipConfirm.Click += iZvDG0SdFs;
			return;
		case 8:
			BtnUpdateSelected = (Button)target;
			BtnUpdateSelected.Click += SJVDZSQL2T;
			return;
		case 9:
			{
				LvItems = (ListView)target;
				LvItems.MouseDoubleClick += GFWDc5gwXj;
				num = 0;
				if (zjSxMVmhXgGL2GcsTHR())
				{
					break;
				}
				goto IL_0181;
			}
			IL_0181:
			num = num2;
			break;
		}
		switch (num)
		{
		case 1:
			return;
		}
		LvItems.SelectionChanged += WWEDWQ57Yt;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 10:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = UIElement.PreviewMouseRightButtonDownEvent;
			eventSetter.Handler = new MouseButtonEventHandler(FKBDs0cBsG);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		case 11:
			((Button)target).Click += MFQDRk4Ky1;
			break;
		case 12:
			((Button)target).Click += rJwDVliK2q;
			break;
		}
	}

	[CompilerGenerated]
	private bool BlaD13alZ2(object object_0)
	{
		if (ChkShowSkippedActions.IsChecked != true)
		{
			return !((SharedActionUpdateListItem)object_0).Action.SkipCheckUpdate;
		}
		return true;
	}

	internal static bool zjSxMVmhXgGL2GcsTHR()
	{
		return V3EMaKm4mZ4GoW6mKe1 == null;
	}
}
