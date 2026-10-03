using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using c4LBdq5YohQFUgxFYw4;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.View.Controls;

public class WindowSelector : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public qsQtMm5MtHtoYi1dcdV EvFS3qGyR5J;

		public WindowSelector pRQS3chjZpa;

		internal static _003C_003Ec__DisplayClass13_0 Oe6BlAyp6kr6TvhNG5M0;

		internal void fWcS3RSVBnE()
		{
			try
			{
				EvFS3qGyR5J = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Window);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(Window.GetWindow(pRQS3chjZpa));
		}

		internal static bool YhmcuiyptRcasSjoy7If()
		{
			return Oe6BlAyp6kr6TvhNG5M0 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectWindow_OnMouseUp_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WindowSelector _003C_003E4__this;

		public MouseButtonEventArgs e;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object FC1ClhypwMX3mUOlDKmU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WindowSelector windowSelector = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						num2 = 0;
						if (!JIaEcoypTVrxmlZeVuin())
						{
							goto IL_0134;
						}
						goto IL_0185;
					}
					windowSelector.BtnSelectWindow.ReleaseMouseCapture();
					windowSelector.Cursor = Cursors.Arrow;
					if (!AppHelper.IsFarThan(windowSelector.KPPLjKnoA7d, e.GetPosition(windowSelector), 10))
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass13_0();
						_003C_003E8__1.pRQS3chjZpa = windowSelector;
						AppHelper.RunOnUiThread(true, windowSelector.K3ALjmHMA17);
						awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014a;
					}
					IntPtr intptr_ = NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition());
					windowSelector.kSRLjXKuHPf(intptr_);
					goto end_IL_0011;
					IL_0185:
					IntPtr intptr_2 = default(IntPtr);
					while (true)
					{
						switch (num2)
						{
						case 2:
							if (_003C_003E8__1.EvFS3qGyR5J.IsSuccess)
							{
								goto IL_010f;
							}
							goto IL_01a1;
						case 1:
							{
								windowSelector.kSRLjXKuHPf(intptr_2);
								goto IL_01a1;
							}
							IL_01a1:
							_003C_003E8__1 = null;
							goto end_IL_0185;
						}
						goto IL_0134;
						IL_010f:
						intptr_2 = _003C_003E8__1.EvFS3qGyR5J.VpumGqYoKI();
						num2 = 1;
						if (FC1ClhypwMX3mUOlDKmU == null)
						{
							continue;
						}
						goto IL_012e;
						continue;
						end_IL_0185:
						break;
					}
					goto end_IL_0011;
					IL_012e:
					int num3 = default(int);
					num2 = num3;
					goto IL_0185;
					IL_0134:
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_014a;
					IL_014a:
					awaiter.GetResult();
					_003C_003E8__1.EvFS3qGyR5J = null;
					AppHelper.RunOnUiThread(true, _003C_003E8__1.fWcS3RSVBnE);
					num2 = 2;
					if (FC1ClhypwMX3mUOlDKmU != null)
					{
						goto IL_012e;
					}
					goto IL_0185;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取进程失败。" + ex.Message);
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

		static _003CBtnSelectWindow_OnMouseUp_003Ed__13()
		{
		}

		internal static bool JIaEcoypTVrxmlZeVuin()
		{
			return FC1ClhypwMX3mUOlDKmU == null;
		}

		internal static void ckDlXlyp73kIeE7da0Wv()
		{
		}
	}

	public static readonly DependencyProperty CornerRadiusProperty;

	private Point KPPLjKnoA7d;

	[CompilerGenerated]
	private EventHandler<WindowSelectedEventArgs> m_WindowSelected;

	internal WindowSelector TheControl;

	internal Button BtnSelectWindow;

	internal TextBlock TxtTitle;

	private bool IFpLjxZU0dP;

	internal static WindowSelector NZx82QFqrYoHZT4cD68r;

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	public string Title
	{
		get
		{
			return TxtTitle.Text;
		}
		set
		{
			TxtTitle.Text = value;
		}
	}

	public event EventHandler<WindowSelectedEventArgs> WindowSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<WindowSelectedEventArgs> eventHandler = this.m_WindowSelected;
			EventHandler<WindowSelectedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowSelectedEventArgs> value2 = (EventHandler<WindowSelectedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_WindowSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<WindowSelectedEventArgs> eventHandler = this.m_WindowSelected;
			EventHandler<WindowSelectedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowSelectedEventArgs> value2 = (EventHandler<WindowSelectedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_WindowSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public WindowSelector()
	{
		InitializeComponent();
	}

	private void S6fLjb3WcBD(object sender, MouseButtonEventArgs e)
	{
		base.Cursor = Cursors.Cross;
		BtnSelectWindow.CaptureMouse();
		KPPLjKnoA7d = e.GetPosition(this);
	}

	[AsyncStateMachine(typeof(_003CBtnSelectWindow_OnMouseUp_003Ed__13))]
	private void KZcLj6UpaXK(object sender, MouseButtonEventArgs e)
	{
		_003CBtnSelectWindow_OnMouseUp_003Ed__13 stateMachine = default(_003CBtnSelectWindow_OnMouseUp_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void kSRLjXKuHPf(IntPtr intptr_0)
	{
		int num = 1;
		while (true)
		{
			NativeMethods.GetWindowThreadProcessId(intptr_0, out int ProcessId);
			int num2 = 0;
			if (!hd8ZopFqNWnBpbGcWlOa())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			Process processById = Process.GetProcessById(ProcessId);
			WindowSelectedEventArgs e = new WindowSelectedEventArgs();
			e.HWnd = intptr_0;
			e.WindowTitle = NativeMethods.GetWindowTitle(intptr_0);
			e.Pid = ProcessId;
			e.Process = processById;
			e.ProcessName = processById.ProcessName;
			this.m_WindowSelected?.Invoke(this, e);
			return;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!IFpLjxZU0dP)
		{
			IFpLjxZU0dP = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/windowselector.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			IFpLjxZU0dP = true;
			break;
		case 1:
			TheControl = (WindowSelector)target;
			break;
		case 2:
			BtnSelectWindow = (Button)target;
			BtnSelectWindow.PreviewMouseDown += S6fLjb3WcBD;
			BtnSelectWindow.PreviewMouseUp += KZcLj6UpaXK;
			break;
		case 3:
			TxtTitle = (TextBlock)target;
			break;
		}
	}

	static WindowSelector()
	{
		CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(WindowSelector), new PropertyMetadata(new CornerRadius(4.0)));
	}

	[CompilerGenerated]
	private void K3ALjmHMA17()
	{
		WindowHelper.MinimizeWindowAndOwner(Window.GetWindow(this));
	}

	internal static bool hd8ZopFqNWnBpbGcWlOa()
	{
		return NZx82QFqrYoHZT4cD68r == null;
	}
}
