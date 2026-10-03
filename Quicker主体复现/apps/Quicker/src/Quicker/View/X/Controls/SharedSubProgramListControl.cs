using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Common.Vm.SubPrograms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.View.X.Controls;

public class SharedSubProgramListControl : UserControl, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnClearFilter_OnClick_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CqrU4KyceCf2AZOm3Q0C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					sharedSubProgramListControl.TxtFilter.Text = "";
					awaiter = sharedSubProgramListControl.KTtLXTnHPf9().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						if (hsRYFIycjojuAFd2bKda())
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

		internal static bool hsRYFIycjojuAFd2bKda()
		{
			return CqrU4KyceCf2AZOm3Q0C == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnQuery_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object mr4cB1yc3J0r7XCY2inh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = sharedSubProgramListControl.KTtLXTnHPf9().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						if (mr4cB1yc3J0r7XCY2inh != null)
						{
							switch (0)
							{
							}
						}
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

		internal static bool nrJt0MycECwr9KMhwSGF()
		{
			return mr4cB1yc3J0r7XCY2inh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoQueryAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListControl _003C_003E4__this;

		private TaskAwaiter<ApiResult<IList<SharedSubProgramListItemDto>>> _003C_003Eu__1;

		internal static object RHSdgMyc0XQrHSuhSsac;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				if (num == 0 || sharedSubProgramListControl.BtnQuery.IsEnabled)
				{
					try
					{
						TaskAwaiter<ApiResult<IList<SharedSubProgramListItemDto>>> awaiter;
						if (num != 0)
						{
							int num2 = 0;
							if (!XifZCyyc1NS7DSrHpn8v())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							sharedSubProgramListControl.BtnQuery.IsEnabled = false;
							sharedSubProgramListControl.BtnQuery.Content = "查询中...";
							awaiter = aFIptTXYsUoTUF4v33R.PEXtbqPY9Vo(sharedSubProgramListControl.TxtFilter.Text).GetAwaiter();
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
							_003C_003Eu__1 = default(TaskAwaiter<ApiResult<IList<SharedSubProgramListItemDto>>>);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<IList<SharedSubProgramListItemDto>> result = awaiter.GetResult();
						if (!result.IsSuccess)
						{
							AppHelper.ShowWarning("查询失败！" + result.Message, true);
						}
						else
						{
							sharedSubProgramListControl.SubProgramList.Reset(result.Data);
						}
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("查询失败！" + ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							sharedSubProgramListControl.BtnQuery.IsEnabled = true;
							sharedSubProgramListControl.BtnQuery.Content = "查询(_Q)";
						}
					}
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

		internal static bool XifZCyyc1NS7DSrHpn8v()
		{
			return RHSdgMyc0XQrHSuhSsac == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuImport_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListControl _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object b9hdSQycdfouZBUOCGV4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00be;
					}
					SharedSubProgramListItemDto sharedSubProgramListItemDto = sharedSubProgramListControl.LvSubprograms.SelectedItem as SharedSubProgramListItemDto;
					int num2 = 0;
					if (b9hdSQycdfouZBUOCGV4 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					if (sharedSubProgramListItemDto != null)
					{
						awaiter = (Window.GetWindow(sharedSubProgramListControl) as ActionDesignerWindow).ImportSharedSubProgramAsync(sharedSubProgramListItemDto.Id).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00be;
					}
					goto end_IL_0011;
					IL_00be:
					awaiter.GetResult();
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					xmiLXzmq2iS.Warn("导入子程序失败，" + ex.Message, ex);
					AppHelper.ShowWarning("导入失败！" + ex.Message);
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

		internal static bool cPh0cPycORVQgiZGraie()
		{
			return b9hdSQycdfouZBUOCGV4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharedSubProgramListControl _003C_003E4__this;

		private static object yaNy7yycaEXxOG5hhWrn;

		private void MoveNext()
		{
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				int count = sharedSubProgramListControl.SubProgramList.Count;
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

		internal static bool LNUG3QycrYctcSirE95w()
		{
			return yaNy7yycaEXxOG5hhWrn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTxtFilter_OnPreviewKeyDown_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public SharedSubProgramListControl _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object jYNUeVyc9D82apJ1UEOk;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharedSubProgramListControl sharedSubProgramListControl = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (jYNUeVyc9D82apJ1UEOk != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_00a2;
				}
				if (e.Key == Key.Return)
				{
					e.Handled = true;
					awaiter = sharedSubProgramListControl.KTtLXTnHPf9().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
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

		internal static bool QiebtuycLOhTUnv5ycxi()
		{
			return jYNUeVyc9D82apJ1UEOk == null;
		}
	}

	[CompilerGenerated]
	private readonly SmartCollection<SharedSubProgramListItemDto> zonLXfpFu2Y = new SmartCollection<SharedSubProgramListItemDto>();

	private static readonly ILog xmiLXzmq2iS;

	internal TextBox TxtFilter;

	internal Button BtnClearFilter;

	internal Button BtnQuery;

	internal ListBox LvSubprograms;

	private bool O40LmwWoKyw;

	private static SharedSubProgramListControl tupraQF98kJKnpUVdcw5;

	public SmartCollection<SharedSubProgramListItemDto> SubProgramList
	{
		[CompilerGenerated]
		get
		{
			return zonLXfpFu2Y;
		}
	}

	public SharedSubProgramListControl()
	{
		InitializeComponent();
		LvSubprograms.ItemsSource = SubProgramList;
		LvSubprograms.SelectedItem = null;
		base.Loaded += i0YLXdjMaAQ;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__1))]
	private void i0YLXdjMaAQ(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__1 stateMachine = default(_003COnLoaded_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnClearFilter_OnClick_003Ed__5))]
	private void wsyLXobkxDO(object sender, RoutedEventArgs e)
	{
		_003CBtnClearFilter_OnClick_003Ed__5 stateMachine = default(_003CBtnClearFilter_OnClick_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoQueryAsync_003Ed__6))]
	private Task KTtLXTnHPf9()
	{
		_003CDoQueryAsync_003Ed__6 stateMachine = default(_003CDoQueryAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void c52LXMd7ZIl(object sender, TextChangedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CBtnQuery_OnClick_003Ed__8))]
	private void P74LXA6FQcq(object sender, RoutedEventArgs e)
	{
		_003CBtnQuery_OnClick_003Ed__8 stateMachine = default(_003CBtnQuery_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void dm1LXOYu9Vs(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(AppHelper.CreateSharedActionLink(((sender as FrameworkElement).Tag as SharedSubProgramListItemDto).Id.ToString()));
	}

	[AsyncStateMachine(typeof(_003CTxtFilter_OnPreviewKeyDown_003Ed__10))]
	private void a6OLXF8LYKh(object sender, KeyEventArgs e)
	{
		_003CTxtFilter_OnPreviewKeyDown_003Ed__10 stateMachine = default(_003CTxtFilter_OnPreviewKeyDown_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Ut7LXU4tORw(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SharedSubProgramListItemDto { Id: var id })
		{
			AppHelper.PreviewSharedSubProgram(id.ToString());
		}
	}

	[AsyncStateMachine(typeof(_003CMenuImport_OnClick_003Ed__13))]
	private void bWnLXlC36ke(object sender, RoutedEventArgs e)
	{
		_003CMenuImport_OnClick_003Ed__13 stateMachine = default(_003CMenuImport_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void xmTLXiXM7dU(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SharedSubProgramListItemDto sharedSubProgramListItemDto)
		{
			(Window.GetWindow(this) as ActionDesignerWindow).HighlightText(sharedSubProgramListItemDto.Title);
		}
	}

	private void UN3LX3wyFwC(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H))
		{
			xmTLXiXM7dU(sender, e);
			e.Handled = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!O40LmwWoKyw)
		{
			O40LmwWoKyw = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/sharedsubprogramlistcontrol.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			O40LmwWoKyw = true;
			break;
		case 1:
			TxtFilter = (TextBox)target;
			TxtFilter.PreviewKeyDown += a6OLXF8LYKh;
			TxtFilter.TextChanged += c52LXMd7ZIl;
			break;
		case 2:
			BtnClearFilter = (Button)target;
			BtnClearFilter.Click += wsyLXobkxDO;
			break;
		case 3:
			BtnQuery = (Button)target;
			BtnQuery.Click += P74LXA6FQcq;
			break;
		case 4:
		{
			LvSubprograms = (ListBox)target;
			LvSubprograms.PreviewKeyDown += UN3LX3wyFwC;
			int num = 0;
			if (!gVL7cNF9RXUvjTq2dLYO())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 5:
			((MenuItem)target).Click += Ut7LXU4tORw;
			break;
		case 6:
			((MenuItem)target).Click += bWnLXlC36ke;
			break;
		case 7:
			((MenuItem)target).Click += xmTLXiXM7dU;
			break;
		case 8:
			((Button)target).Click += dm1LXOYu9Vs;
			break;
		}
	}

	static SharedSubProgramListControl()
	{
		xmiLXzmq2iS = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool gVL7cNF9RXUvjTq2dLYO()
	{
		return tupraQF98kJKnpUVdcw5 == null;
	}
}
