using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using mkNPXD55jdUOwoyJpya;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class UnhandledExceptionWindow : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		internal static object zT74WbWU2sj2RIkSTO0J;

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

		internal static bool OITbTrWUA4YcmY8Eukux()
		{
			return zT74WbWU2sj2RIkSTO0J == null;
		}
	}

	private readonly Exception oB9LtKVm5Vh;

	private readonly string rbfLtxTEWah;

	[CompilerGenerated]
	private bool JZULtrk9uCt;

	[CompilerGenerated]
	private bool dZoLtpJEwu2;

	internal TextBlock LblTitleTitle;

	internal TextBlock LblTitle;

	internal TextBox TxtDetail;

	internal TextBlock LblState;

	internal Button BtnRestart;

	internal Button BtnIgnoreError;

	internal Button BtnClose;

	private bool XigLtBdCv7S;

	private static UnhandledExceptionWindow UT8Y2lF2DI6DCuYCJs9H;

	public bool AutoRestart
	{
		[CompilerGenerated]
		get
		{
			return JZULtrk9uCt;
		}
		[CompilerGenerated]
		set
		{
			JZULtrk9uCt = value;
		}
	}

	public bool IgnoreError
	{
		[CompilerGenerated]
		get
		{
			return dZoLtpJEwu2;
		}
		[CompilerGenerated]
		set
		{
			dZoLtpJEwu2 = value;
		}
	}

	public UnhandledExceptionWindow(Exception ex, bool canIgnore)
	{
		oB9LtKVm5Vh = ex;
		InitializeComponent();
		if (ex != null)
		{
			if (ex.StackTrace.IndexOf("Intellitools", StringComparison.OrdinalIgnoreCase) > 0)
			{
				LblTitleTitle.Text = "很抱歉，[剪贴板] 动作遇到了一个未能捕获的异常。";
			}
			LblTitle.Text = ex.Message;
			TxtDetail.Text = jvZjO55qkHGVjeDfEnG.RaVHKFoAmQ(ex);
			base.Loaded += RfmLtHJ0HWa;
			if (!canIgnore)
			{
				BtnIgnoreError.Visibility = Visibility.Collapsed;
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__12))]
	private void RfmLtHJ0HWa(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__12 stateMachine = default(_003COnLoaded_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DllImport("kernel32.dll", EntryPoint = "GetPhysicallyInstalledSystemMemory")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool asMLt1O5pJN(out long long_0);

	private void TdbLtbd8LJS(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/Search?keyword=" + HttpUtility.UrlEncode(oB9LtKVm5Vh.Message));
	}

	private void h1jLt6kUo9A(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void SQ9LtX559MY(object sender, RoutedEventArgs e)
	{
		AutoRestart = true;
		base.DialogResult = true;
	}

	private void qUULtmtTUC6(object sender, RoutedEventArgs e)
	{
		IgnoreError = true;
		base.DialogResult = true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!XigLtBdCv7S)
		{
			XigLtBdCv7S = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/unhandledexceptionwindow.xaml", UriKind.Relative);
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
			XigLtBdCv7S = true;
			break;
		case 1:
			LblTitleTitle = (TextBlock)target;
			break;
		case 2:
			LblTitle = (TextBlock)target;
			break;
		case 3:
			TxtDetail = (TextBox)target;
			break;
		case 4:
			LblState = (TextBlock)target;
			break;
		case 5:
			BtnRestart = (Button)target;
			BtnRestart.Click += SQ9LtX559MY;
			break;
		case 6:
			BtnIgnoreError = (Button)target;
			BtnIgnoreError.Click += qUULtmtTUC6;
			break;
		case 7:
			BtnClose = (Button)target;
			if (h56SUdF23nbEvMwDUs9v())
			{
				switch (0)
				{
				}
			}
			BtnClose.Click += h1jLt6kUo9A;
			break;
		}
	}

	internal static bool h56SUdF23nbEvMwDUs9v()
	{
		return UT8Y2lF2DI6DCuYCJs9H == null;
	}
}
