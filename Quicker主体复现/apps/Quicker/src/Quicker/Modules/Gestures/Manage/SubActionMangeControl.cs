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
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Quicker.Domain;
using Quicker.Domain.PowerMouse;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View.CircleMenu;

namespace Quicker.Modules.Gestures.Manage;

public class SubActionMangeControl : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec B9EvWx6LFld;

		public static Comparison<SubAction> k83vWrXOKJ5;

		public static Comparison<SubAction> mIVvWpx0D1A;

		internal static _003C_003Ec EuCTJnc5EdqYv4oKOfja;

		static _003C_003Ec()
		{
			B9EvWx6LFld = new _003C_003Ec();
		}

		internal int eA6vWm2aNGH(SubAction action1, SubAction action2)
		{
			return action1.Key - action2.Key;
		}

		internal int waWvWKhuNWU(SubAction action1, SubAction action2)
		{
			return action1.Key - action2.Key;
		}

		internal static bool StLyyGc5GjrYNje1O9gf()
		{
			return EuCTJnc5EdqYv4oKOfja == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAddKey_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SubActionMangeControl _003C_003E4__this;

		private SubActionEditWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object bYZMaMc51Inl8vt8af9M;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubActionMangeControl subActionMangeControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00f3;
				}
				if (AppState.DataService.Hb9tmk3OsJ7() || subActionMangeControl.SubActions.Count < 2)
				{
					_003Cdlg_003E5__2 = new SubActionEditWindow(subActionMangeControl.SubActions, null);
					int num2 = 1;
					if (aMkUeqc5KmHpi9fykbIK())
					{
						int num3 = default(int);
						while (true)
						{
							switch (num2)
							{
							case 1:
								_003Cdlg_003E5__2.Owner = Window.GetWindow(subActionMangeControl);
								num2 = 0;
								if (bYZMaMc51Inl8vt8af9M != null)
								{
									num2 = num3;
								}
								continue;
							}
							break;
						}
					}
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00f3;
				}
				AppHelper.ShowWarning("免费版支持创建2条按键触发规则，当前已达到限额。\n如您已购买专业版，请重启软件生效。");
				goto end_IL_0010;
				IL_00f3:
				if (awaiter.GetResult() == true)
				{
					subActionMangeControl.SubActions.Add(_003Cdlg_003E5__2.ResultItem);
					subActionMangeControl.SubActions.Sort(_003C_003Ec.k83vWrXOKJ5 ?? (_003C_003Ec.k83vWrXOKJ5 = _003C_003Ec.B9EvWx6LFld.eA6vWm2aNGH));
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool aMkUeqc5KmHpi9fykbIK()
		{
			return bYZMaMc51Inl8vt8af9M == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEditActionItem_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public SubActionMangeControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object eDJqImc5vJE4gMg2Rp9k;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubActionMangeControl subActionMangeControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009b;
				}
				if ((sender as FrameworkElement)?.Tag is SubAction subAction_)
				{
					awaiter = subActionMangeControl.tfHtL0JNByj(subAction_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						if (!u5ZOxcc5dW2y4uTUbklD())
						{
							switch (0)
							{
							}
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009b;
				}
				goto end_IL_000e;
				IL_009b:
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

		internal static bool u5ZOxcc5dW2y4uTUbklD()
		{
			return eDJqImc5vJE4gMg2Rp9k == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItem_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SubActionMangeControl _003C_003E4__this;

		public SubAction item;

		private SubActionEditWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object RoGlMZc5J9YFlHSjQp7B;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubActionMangeControl subActionMangeControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (RoGlMZc5J9YFlHSjQp7B != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					default:
					{
						PresentationSource presentationSource = PresentationSource.FromVisual(Window.GetWindow(subActionMangeControl));
						if (presentationSource != null && !presentationSource.IsDisposed)
						{
							goto case 1;
						}
						goto end_IL_0010;
					}
					case 1:
						_003Cdlg_003E5__2 = new SubActionEditWindow(subActionMangeControl.SubActions, item);
						_003Cdlg_003E5__2.Owner = Window.GetWindow(subActionMangeControl);
						awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					subActionMangeControl.SubActions.Replace(item, _003Cdlg_003E5__2.ResultItem);
					subActionMangeControl.SubActions.Sort(_003C_003Ec.mIVvWpx0D1A ?? (_003C_003Ec.mIVvWpx0D1A = _003C_003Ec.B9EvWx6LFld.waWvWKhuNWU));
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool klNSHxc5kHxGtjIBBDNe()
		{
			return RoGlMZc5J9YFlHSjQp7B == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleDoubleClick_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public SubActionMangeControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object sP4CJ4c5r91lvU3lkW3R;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubActionMangeControl subActionMangeControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a2;
				}
				if (((ListViewItem)sender).DataContext is SubAction subAction_)
				{
					awaiter = subActionMangeControl.tfHtL0JNByj(subAction_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!G7MvN8c5N8uT88G2SKSF())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a2;
				}
				goto end_IL_0010;
				IL_00a2:
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

		internal static bool G7MvN8c5N8uT88G2SKSF()
		{
			return sP4CJ4c5r91lvU3lkW3R == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLvActions_OnMouseDoubleClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SubActionMangeControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object yDnbikc5LndFHdLJbFb5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SubActionMangeControl subActionMangeControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009e;
				}
				int num2 = 0;
				if (yDnbikc5LndFHdLJbFb5 != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (subActionMangeControl.LvActions.SelectedItem is SubAction subAction_)
				{
					awaiter = subActionMangeControl.tfHtL0JNByj(subAction_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009e;
				}
				goto end_IL_0010;
				IL_009e:
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

		internal static bool z7mxnEc5uSQ3HQKpb75n()
		{
			return yDnbikc5LndFHdLJbFb5 == null;
		}
	}

	[CompilerGenerated]
	private readonly SmartCollection<SubAction> glstLEbyImr = new SmartCollection<SubAction>();

	internal ListView LvActions;

	internal Button BtnDelete;

	internal Button BtnAddKey;

	private bool pnRtLycUFoU;

	internal static SubActionMangeControl EXCbcBQWPSxNEY2SGCKL;

	public SmartCollection<SubAction> SubActions
	{
		[CompilerGenerated]
		get
		{
			return glstLEbyImr;
		}
	}

	public SubActionMangeControl()
	{
		InitializeComponent();
		LvActions.ItemsSource = SubActions;
	}

	public void SetData(GestureAction gestureAction)
	{
		if (gestureAction.SubActions.HasData())
		{
			SubActions.Reset(gestureAction.SubActions);
		}
	}

	public void SetData(CircleMenuAction circleMenuAction)
	{
		if (circleMenuAction.SubActions.HasData())
		{
			SubActions.Reset(circleMenuAction.SubActions);
		}
	}

	public IList<SubAction> GetData()
	{
		return SubActions.ToList();
	}

	private void T02tLSDXw2P(object sender, SelectionChangedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CBtnAddKey_OnClick_003Ed__8))]
	private void QtDtL2gmYgs(object sender, RoutedEventArgs e)
	{
		_003CBtnAddKey_OnClick_003Ed__8 stateMachine = default(_003CBtnAddKey_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void wUltLuA5HkP(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItem != null)
		{
			SubActions.Remove(LvActions.SelectedItem as SubAction);
			LvActions.SelectedItem = null;
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除按键。");
		}
	}

	[AsyncStateMachine(typeof(_003CHandleDoubleClick_003Ed__10))]
	private void gRjtLNnMcPp(object sender, MouseButtonEventArgs e)
	{
		_003CHandleDoubleClick_003Ed__10 stateMachine = default(_003CHandleDoubleClick_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLvActions_OnMouseDoubleClick_003Ed__11))]
	private void ESttLJqcnLQ(object sender, MouseButtonEventArgs e)
	{
		_003CLvActions_OnMouseDoubleClick_003Ed__11 stateMachine = default(_003CLvActions_OnMouseDoubleClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItem_003Ed__12))]
	private Task tfHtL0JNByj(SubAction subAction_0)
	{
		_003CEditItem_003Ed__12 stateMachine = default(_003CEditItem_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = subAction_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnEditActionItem_OnClick_003Ed__13))]
	private void QpGtLCfvabE(object sender, RoutedEventArgs e)
	{
		_003CBtnEditActionItem_OnClick_003Ed__13 stateMachine = default(_003CBtnEditActionItem_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void XbutLP10sft(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement)?.Tag is SubAction item && AppHelper.Confirm("您确定要删除么？"))
		{
			SubActions.Remove(item);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!pnRtLycUFoU)
		{
			pnRtLycUFoU = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/subactionmangecontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
		{
			LvActions = (ListView)target;
			int num = 0;
			if (EXCbcBQWPSxNEY2SGCKL != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				LvActions.SelectionChanged += T02tLSDXw2P;
				break;
			}
			break;
		}
		default:
			pnRtLycUFoU = true;
			break;
		case 4:
			BtnDelete = (Button)target;
			BtnDelete.Click += wUltLuA5HkP;
			break;
		case 5:
			BtnAddKey = (Button)target;
			BtnAddKey.Click += QtDtL2gmYgs;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += QpGtLCfvabE;
			break;
		case 1:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(gRjtLNnMcPp);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	internal static bool vU0rmGQWMuvrZ8StaIJf()
	{
		return EXCbcBQWPSxNEY2SGCKL == null;
	}
}
