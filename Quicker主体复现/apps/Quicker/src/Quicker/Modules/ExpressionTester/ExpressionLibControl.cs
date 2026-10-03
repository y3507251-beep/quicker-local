using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Expression;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Modules.ExpressionTester;

public class ExpressionLibControl : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public ExpressionLibControl MbVve5NAPGL;

		public ApiResult<IList<SharedExpressionDto>> T1cveD5o8Lh;

		internal static _003C_003Ec__DisplayClass12_0 mgk8kDcqbcAh75mOBhC4;

		internal void n2Ave4pg4vt()
		{
			if (T1cveD5o8Lh.IsSuccess)
			{
				MbVve5NAPGL.bGuF6uvOEX.Reset(T1cveD5o8Lh.Data);
				AppHelper.ShowInformation($"共搜索到{T1cveD5o8Lh.Data.Count}条记录。");
			}
			else
			{
				AppHelper.ShowWarning(T1cveD5o8Lh.Message);
			}
		}

		internal static bool c3w71OcqqSyJmrNOVL5e()
		{
			return mgk8kDcqbcAh75mOBhC4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSearch_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExpressionLibControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GLutgocqlGHlDxhEsVam;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionLibControl expressionLibControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = expressionLibControl.KYKFGEYsk3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (GLutgocqlGHlDxhEsVam != null)
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

		static _003CBtnSearch_OnClick_003Ed__13()
		{
		}

		internal static bool m9nV3QcqZQnUUYVfeHdW()
		{
			return GLutgocqlGHlDxhEsVam == null;
		}

		internal static void Y0r7vFcq81aBgr5xFj8F()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoSearch_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ExpressionLibControl _003C_003E4__this;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private TaskAwaiter<ApiResult<IList<SharedExpressionDto>>> _003C_003Eu__1;

		internal static object U0xIuKcqR4kAP8Fu8v5e;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionLibControl expressionLibControl = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass12_0();
					_003C_003E8__1.MbVve5NAPGL = _003C_003E4__this;
					if (U0xIuKcqR4kAP8Fu8v5e != null)
					{
						switch (0)
						{
						}
					}
					expressionLibControl.bGuF6uvOEX.Clear();
					if (expressionLibControl.lG7FXq4MGg != null)
					{
						expressionLibControl.lG7FXq4MGg.Cancel();
					}
					expressionLibControl.lG7FXq4MGg = new CancellationTokenSource(2000);
				}
				try
				{
					TaskAwaiter<ApiResult<IList<SharedExpressionDto>>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.Y1Ut1aT9ASd(expressionLibControl.SearchBox.Text, expressionLibControl.CbForVarType.SelectedItem as VarType?, expressionLibControl.CbForResultType.SelectedItem as VarType?, 0, 50, expressionLibControl.lG7FXq4MGg.Token).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (!amCX17cqgmAlMK6q9hYE())
							{
								switch (0)
								{
								}
							}
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<IList<SharedExpressionDto>>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<IList<SharedExpressionDto>> result = awaiter.GetResult();
					_003C_003E8__1.T1cveD5o8Lh = result;
					AppHelper.RunOnUiThread(false, _003C_003E8__1.n2Ave4pg4vt);
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("查询出错：" + ex.Message);
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

		internal static bool amCX17cqgmAlMK6q9hYE()
		{
			return U0xIuKcqR4kAP8Fu8v5e == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadMyExpressions_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ExpressionLibControl _003C_003E4__this;

		public bool initialLoad;

		private TaskAwaiter<ApiResult<IList<SharedExpressionDto>>> _003C_003Eu__1;

		internal static object ryXe66cqUWSeRA5dHumY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionLibControl expressionLibControl = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ApiResult<IList<SharedExpressionDto>>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.r8Ct18kAqRj().GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<IList<SharedExpressionDto>>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<IList<SharedExpressionDto>> result = awaiter.GetResult();
					if (result.IsSuccess && result.Data.Count > 0)
					{
						if (ryXe66cqUWSeRA5dHumY != null)
						{
							switch (0)
							{
							}
						}
						expressionLibControl.eWxFbjaRFe.Reset(result.Data);
					}
					else if (initialLoad)
					{
						expressionLibControl.TabSelector.SelectedIndex = 1;
					}
				}
				catch (Exception)
				{
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

		internal static bool pv6i9ucqxgvVuvg2nSVR()
		{
			return ryXe66cqUWSeRA5dHumY == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExpressionLibControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object nFMfktcqtGuJULF9BagJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExpressionLibControl expressionLibControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = expressionLibControl.YqMFWRFu5X(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						if (!c0ihBPcqSRJIOM67GQfy())
						{
							switch (0)
							{
							}
						}
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

		internal static bool c0ihBPcqSRJIOM67GQfy()
		{
			return nFMfktcqtGuJULF9BagJ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchBoxControl_OnSearchTextChanged_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		internal static object JYJmDxcqTmVGCK601YDd;

		private void MoveNext()
		{
			try
			{
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

		internal static bool DYYGXDcqmZn090QpdCRR()
		{
			return JYJmDxcqTmVGCK601YDd == null;
		}
	}

	private static readonly ILog ayYF1txTNU;

	private SmartCollection<SharedExpressionDto> eWxFbjaRFe = new SmartCollection<SharedExpressionDto>();

	private SmartCollection<SharedExpressionDto> bGuF6uvOEX = new SmartCollection<SharedExpressionDto>();

	[CompilerGenerated]
	private EventHandler<SharedExpressionDto> m_ExpressionSelected;

	private CancellationTokenSource lG7FXq4MGg;

	internal TabControl TabSelector;

	internal ListBox LbMyExpressions;

	internal TextBox SearchBox;

	internal ComboBox CbForVarType;

	internal ComboBox CbForResultType;

	internal Button BtnSearch;

	internal ListBox LbLibExpressions;

	private bool scyFmA3cbc;

	internal static ExpressionLibControl OgaoMIzZJjeGEEGC4fQ;

	public event EventHandler<SharedExpressionDto> ExpressionSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SharedExpressionDto> eventHandler = this.m_ExpressionSelected;
			EventHandler<SharedExpressionDto> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SharedExpressionDto> value2 = (EventHandler<SharedExpressionDto>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExpressionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SharedExpressionDto> eventHandler = this.m_ExpressionSelected;
			EventHandler<SharedExpressionDto> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SharedExpressionDto> value2 = (EventHandler<SharedExpressionDto>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExpressionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExpressionLibControl()
	{
		InitializeComponent();
		IList<VarType> itemsSource = new List<VarType>
		{
			VarType.Text,
			VarType.Integer,
			VarType.Number,
			VarType.List,
			VarType.Enum,
			VarType.Dict,
			VarType.DateTime
		};
		base.Loaded += nH2FIhKcKZ;
		CbForVarType.ItemsSource = itemsSource;
		CbForResultType.ItemsSource = itemsSource;
		LbMyExpressions.ItemsSource = eWxFbjaRFe;
		LbLibExpressions.ItemsSource = bGuF6uvOEX;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__7))]
	private void nH2FIhKcKZ(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__7 stateMachine = default(_003COnLoaded_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadMyExpressions_003Ed__8))]
	private Task YqMFWRFu5X(bool bool_1)
	{
		_003CLoadMyExpressions_003Ed__8 stateMachine = default(_003CLoadMyExpressions_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.initialLoad = bool_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void XNUFkwQPDw(object sender, SelectionChangedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CSearchBoxControl_OnSearchTextChanged_003Ed__11))]
	private void SearchBoxControl_OnSearchTextChanged(object sender, RoutedEventArgs e)
	{
		_003CSearchBoxControl_OnSearchTextChanged_003Ed__11 stateMachine = default(_003CSearchBoxControl_OnSearchTextChanged_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoSearch_003Ed__12))]
	private Task KYKFGEYsk3()
	{
		_003CDoSearch_003Ed__12 stateMachine = default(_003CDoSearch_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnSearch_OnClick_003Ed__13))]
	private void B1MFsVNOda(object sender, RoutedEventArgs e)
	{
		_003CBtnSearch_OnClick_003Ed__13 stateMachine = default(_003CBtnSearch_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void r3KFH2ZsiY(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && e.ClickCount >= 2)
		{
			SharedExpressionDto e2 = (sender as FrameworkElement).Tag as SharedExpressionDto;
			this.m_ExpressionSelected?.Invoke(this, e2);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!scyFmA3cbc)
		{
			scyFmA3cbc = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/expressiontester/expressionlibcontrol.xaml", UriKind.Relative);
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
			scyFmA3cbc = true;
			break;
		case 2:
			TabSelector = (TabControl)target;
			TabSelector.SelectionChanged += XNUFkwQPDw;
			break;
		case 3:
			LbMyExpressions = (ListBox)target;
			break;
		case 4:
			SearchBox = (TextBox)target;
			break;
		case 5:
			CbForVarType = (ComboBox)target;
			break;
		case 6:
			CbForResultType = (ComboBox)target;
			break;
		case 7:
		{
			BtnSearch = (Button)target;
			int num = 0;
			if (OgaoMIzZJjeGEEGC4fQ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnSearch.Click += B1MFsVNOda;
				break;
			}
			break;
		}
		case 8:
			LbLibExpressions = (ListBox)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((Grid)target).PreviewMouseDown += r3KFH2ZsiY;
		}
	}

	static ExpressionLibControl()
	{
		ayYF1txTNU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool gG5lPZz5KhARkgFEHUg()
	{
		return OgaoMIzZJjeGEEGC4fQ == null;
	}

	internal static void mEOjXyzgIoYR5aZ1Zvy()
	{
	}

	internal static void WiFV2szPo37VmC6yJBc()
	{
	}
}
