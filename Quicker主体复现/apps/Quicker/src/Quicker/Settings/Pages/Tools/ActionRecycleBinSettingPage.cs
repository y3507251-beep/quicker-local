using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using a7dFCeYW0iYApqdSaq3;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Domain.SQL.Entities;
using Quicker.Utilities;

namespace Quicker.Settings.Pages.Tools;

public class ActionRecycleBinSettingPage : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public List<ChXEjTYwLvLEmAccjbR> JlrvV3pbx3l;

		internal static _003C_003Ec__DisplayClass2_0 wBpHBJc9Se0DfR5bBqCS;

		internal void BtqvVip1qV9()
		{
			foreach (ActionHistoryItem deletedActionBackupItem in AppState.SQLDataMgr.GetDeletedActionBackupItems())
			{
				ActionItem action = deletedActionBackupItem.GetAction();
				JlrvV3pbx3l.Add(new ChXEjTYwLvLEmAccjbR
				{
					ActionId = deletedActionBackupItem.ActionId,
					Title = action.Title,
					Description = action.Description,
					Icon = action.Icon,
					DeleteTime = deletedActionBackupItem.BackupTimeUtc,
					Action = action
				});
			}
		}

		internal static bool Cxp5etc9wlWduI2aodAy()
		{
			return wBpHBJc9Se0DfR5bBqCS == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadDataAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionRecycleBinSettingPage _003C_003E4__this;

		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object N5rKiwc9mAdvEUpSWYUo;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionRecycleBinSettingPage actionRecycleBinSettingPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass2_0();
					_003C_003E8__1.JlrvV3pbx3l = new List<ChXEjTYwLvLEmAccjbR>();
					awaiter = Task.Run((Action)_003C_003E8__1.BtqvVip1qV9).ConfigureAwait(true).GetAwaiter();
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
				actionRecycleBinSettingPage.LvDeletedActions.ItemsSource = _003C_003E8__1.JlrvV3pbx3l;
				actionRecycleBinSettingPage.LblCount.Text = $"共 {_003C_003E8__1.JlrvV3pbx3l.Count} 项。";
				int num2 = 0;
				if (N5rKiwc9mAdvEUpSWYUo != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
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

		internal static bool UZEGOmc9sPN36Atbrisj()
		{
			return N5rKiwc9mAdvEUpSWYUo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuDelete_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RoutedEventArgs e;

		public ActionRecycleBinSettingPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object s2GmmCc97QqpMLpjWH9b;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionRecycleBinSettingPage actionRecycleBinSettingPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!tAvKJsc94A5PXXa9u0T5())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_00ca;
				}
				if (((FrameworkElement)e.OriginalSource).DataContext is ChXEjTYwLvLEmAccjbR chXEjTYwLvLEmAccjbR)
				{
					AppState.SQLDataMgr.okttrkaoQGM(chXEjTYwLvLEmAccjbR.ActionId, chXEjTYwLvLEmAccjbR.DeleteTime);
					awaiter = actionRecycleBinSettingPage.e6K4mQoTrU().ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00ca;
				}
				goto end_IL_0010;
				IL_00ca:
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

		internal static bool tAvKJsc94A5PXXa9u0T5()
		{
			return s2GmmCc97QqpMLpjWH9b == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionRecycleBinSettingPage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object HpLHn9c9HyVQnPTyDbZF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionRecycleBinSettingPage actionRecycleBinSettingPage = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = actionRecycleBinSettingPage.e6K4mQoTrU().ConfigureAwait(true).GetAwaiter();
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
					if (!T5Nf9Pc9zcNCgdUL6T9Y())
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
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

		internal static bool T5Nf9Pc9zcNCgdUL6T9Y()
		{
			return HpLHn9c9HyVQnPTyDbZF == null;
		}
	}

	internal TextBlock LblCount;

	internal ListView LvDeletedActions;

	private bool Hmq4QZevmC;

	internal static ActionRecycleBinSettingPage ojS9NdmcjfD0BbvgS2e;

	public ActionRecycleBinSettingPage()
	{
		InitializeComponent();
		base.Loaded += BET4XtHXmv;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__1))]
	private void BET4XtHXmv(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__1 stateMachine = default(_003COnLoaded_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadDataAsync_003Ed__2))]
	private Task e6K4mQoTrU()
	{
		_003CLoadDataAsync_003Ed__2 stateMachine = default(_003CLoadDataAsync_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void q1W4KbWnmM(object sender, RoutedEventArgs e)
	{
		KnB4xkOPim((sender as Button)?.Tag as ChXEjTYwLvLEmAccjbR);
	}

	private static void KnB4xkOPim(ChXEjTYwLvLEmAccjbR chXEjTYwLvLEmAccjbR_0)
	{
		if (chXEjTYwLvLEmAccjbR_0 == null)
		{
			AppHelper.ShowWarning("动作为空！");
			return;
		}
		ActionEditMgr.CopyAction(chXEjTYwLvLEmAccjbR_0.Action);
		AppHelper.ShowInformation("动作已复制到剪贴板，请在合适的位置粘贴。");
	}

	private void Xvx4r9bYhu(object sender, MouseButtonEventArgs e)
	{
		KnB4xkOPim(((FrameworkElement)e.OriginalSource).DataContext as ChXEjTYwLvLEmAccjbR);
	}

	[AsyncStateMachine(typeof(_003CMenuDelete_OnClick_003Ed__6))]
	private void f144pX67Zl(object sender, RoutedEventArgs e)
	{
		_003CMenuDelete_OnClick_003Ed__6 stateMachine = default(_003CMenuDelete_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void u8r4Bleant(object sender, RoutedEventArgs e)
	{
		KnB4xkOPim(((FrameworkElement)e.OriginalSource).DataContext as ChXEjTYwLvLEmAccjbR);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Hmq4QZevmC)
		{
			Hmq4QZevmC = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/actionrecyclebinsettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			LblCount = (TextBlock)target;
			break;
		case 2:
			LvDeletedActions = (ListView)target;
			LvDeletedActions.MouseDoubleClick += Xvx4r9bYhu;
			break;
		default:
			Hmq4QZevmC = true;
			break;
		case 4:
			((MenuItem)target).Click += u8r4Bleant;
			break;
		case 5:
			((MenuItem)target).Click += f144pX67Zl;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 3)
		{
			((Button)target).Click += q1W4KbWnmM;
		}
	}

	internal static bool BaMNM4mWZCTTTrCiloG()
	{
		return ojS9NdmcjfD0BbvgS2e == null;
	}
}
