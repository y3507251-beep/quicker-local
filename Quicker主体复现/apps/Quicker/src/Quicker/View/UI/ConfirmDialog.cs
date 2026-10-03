using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using MdXaml;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using SCyJThYoNMQE7IHLXbA;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View.UI;

public class ConfirmDialog : Window, IComponentConnector, iTHRNJY2ZQQokysD4pN, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec P9rS4HOqjIK;

		public static EventHandler MAeS41GgnQC;

		private static _003C_003Ec h7VZw9WS1LN0uASmDLPb;

		static _003C_003Ec()
		{
			P9rS4HOqjIK = new _003C_003Ec();
		}

		internal void f53S4sgM95P(object sender, EventArgs e)
		{
		}

		internal static void RaKrxkWSvNdA1Gp47Xcq()
		{
		}

		internal static bool PUfGElWSK27MtxVArG9g()
		{
			return h7VZw9WS1LN0uASmDLPb == null;
		}

		internal static void xueS2hWSdFtxwoLMBtUq()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowConfirmDialogAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string button)> _003C_003Et__builder;

		public Window owner;

		public string title;

		public string titleIcon;

		public string message;

		public string icon;

		public string buttons;

		public string primaryButton;

		public CancellationToken? cancellationToken;

		private ConfirmDialog _003Cdlg_003E5__2;

		private ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Xl1Fp5WSOUwH69UK4bjH;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (!hQr2w3WSJ251kiENZSSQ())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003Cdlg_003E5__2 = lN0L0GusKFx(owner, title, titleIcon, message, icon, buttons, primaryButton);
					if (cancellationToken.HasValue)
					{
						_003Cdlg_003E5__2.V6hgjEnp8ZH(cancellationToken);
					}
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).ConfigureAwait(true).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = (awaiter.GetResult() == true, _003Cdlg_003E5__2.SelectedButton);
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
			_003C_003Et__builder.SetResult(result);
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

		internal static bool hQr2w3WSJ251kiENZSSQ()
		{
			return Xl1Fp5WSOUwH69UK4bjH == null;
		}
	}

	[CompilerGenerated]
	private string L7KL0bj03hP;

	private double dVbL06sABLp = 12.0;

	private double IconSize = 16.0;

	private Button eCrL0XwIVuk;

	private string ofjL0maZ1w6;

	[CompilerGenerated]
	private bool? WGSL0KDTYEH;

	[CompilerGenerated]
	private CancellationTokenRegistration? n8KL0xsgRi1;

	internal ConfirmDialog TheWindow;

	internal IconControl TitleIcon;

	internal TextBlock LblTitle;

	internal Button BtnClose;

	internal IconControl MainIcon;

	internal ContentControl ContentBody;

	internal TextBlock LblContent;

	internal WrapPanel PnlButtons;

	private bool dUFL0rxrJIZ;

	internal static ConfirmDialog OmHmrKF3iKR7DCbEPIOl;

	public string SelectedButton
	{
		[CompilerGenerated]
		get
		{
			return L7KL0bj03hP;
		}
		[CompilerGenerated]
		set
		{
			L7KL0bj03hP = value;
		}
	}

	public string TitleIconString
	{
		get
		{
			return TitleIcon.Icon as string;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				TitleIcon.Icon = null;
				TitleIcon.Visibility = Visibility.Collapsed;
			}
			else
			{
				TitleIcon.Icon = value;
				TitleIcon.Visibility = Visibility.Visible;
			}
		}
	}

	public string MainIconString
	{
		get
		{
			return MainIcon.Icon as string;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				MainIcon.Icon = value;
				MainIcon.Visibility = Visibility.Visible;
			}
			else
			{
				MainIcon.Icon = null;
				MainIcon.Visibility = Visibility.Collapsed;
			}
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return WGSL0KDTYEH;
		}
		[CompilerGenerated]
		set
		{
			WGSL0KDTYEH = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return n8KL0xsgRi1;
		}
		[CompilerGenerated]
		set
		{
			n8KL0xsgRi1 = value;
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

	public void SetMessage(string message)
	{
		ofjL0maZ1w6 = message;
		if (string.IsNullOrEmpty(message) || !message.StartsWith("MD:", StringComparison.OrdinalIgnoreCase))
		{
			LblContent.Text = message;
			return;
		}
		string markdown = message.Substring("md:".Length);
		if (zFrNPAF3lHQUHx3PUZ1E())
		{
			switch (0)
			{
			}
		}
		MarkdownScrollViewer markdownScrollViewer = new MarkdownScrollViewer();
		markdownScrollViewer.Markdown = markdown;
		markdownScrollViewer.Padding = new Thickness(15.0);
		markdownScrollViewer.MarkdownStyle = TryFindResource("MarkdownHelpStyle") as Style;
		ContentBody.Content = markdownScrollViewer;
	}

	public ConfirmDialog()
	{
		InitializeComponent();
		base.SourceInitialized += _003C_003Ec.MAeS41GgnQC ?? (_003C_003Ec.MAeS41GgnQC = _003C_003Ec.P9rS4HOqjIK.f53S4sgM95P);
		base.Loaded += k26L0hn5xul;
		base.Closing += ppQL09q86P2;
		this.HyLvSSIkkYN();
		AppHelper.AddGoToPageCommandBinding(this);
	}

	private void ppQL09q86P2(object sender, CancelEventArgs e)
	{
	}

	private void k26L0hn5xul(object sender, RoutedEventArgs e)
	{
		if (eCrL0XwIVuk != null)
		{
			base.Dispatcher.InvokeAsync(PpHL01vrG6x);
		}
		InvalidateVisual();
	}

	private void LnZL0eKnTvO(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void LF5L0YiICcd(string string_2, string string_3)
	{
		List<SimpleOperationItem> list = AppHelper.StringToOperationItems(string_2, false);
		if (list.HasData())
		{
			using List<SimpleOperationItem>.Enumerator enumerator = list.GetEnumerator();
			SimpleOperationItem current = default(SimpleOperationItem);
			Button button = default(Button);
			(string, string, string) tuple = default((string, string, string));
			while (true)
			{
				int num;
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					button = new Button();
					button.Margin = new Thickness(10.0, 0.0, 0.0, 10.0);
					button.MinWidth = 80.0;
					button.Height = double.NaN;
					button.FontSize = dVbL06sABLp;
					tuple = UIHelper.ExtractIconAndTitle(current.Name);
					button.Content = UIHelper.CreateButtonContent(tuple.Item1, tuple.Item2, IconSize);
					num = 0;
					if (zFrNPAF3lHQUHx3PUZ1E())
					{
						goto IL_00c3;
					}
				}
				else
				{
					num = 1;
					if (zFrNPAF3lHQUHx3PUZ1E())
					{
						goto IL_00c3;
					}
				}
				goto IL_00d0;
				IL_00c3:
				switch (num)
				{
				case 1:
					goto end_IL_0164;
				}
				goto IL_00d0;
				IL_00d0:
				if (!string.IsNullOrEmpty(tuple.Item3))
				{
					button.ToolTip = tuple.Item3;
				}
				if (string.Equals(current.Key, string_3))
				{
					button.Style = FindResource("ButtonPrimary") as Style;
					eCrL0XwIVuk = button;
					button.IsDefault = true;
				}
				button.Tag = current.Key;
				button.Click += Af7L0ImYFBv;
				PnlButtons.Children.Add(button);
				continue;
				end_IL_0164:
				break;
			}
		}
		InvalidateMeasure();
		UpdateLayout();
		InvalidateVisual();
	}

	private void Af7L0ImYFBv(object sender, RoutedEventArgs e)
	{
		SelectedButton = (sender as Button).Tag as string;
		this.ThNvuM5Q9GQ(true);
	}

	[AsyncStateMachine(typeof(_003CShowConfirmDialogAsync_003Ed__26))]
	internal static Task<(bool isSuccess, string button)> jQyL0Wq9wU6(Window window_0, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, CancellationToken? nullable_2 = null)
	{
		_003CShowConfirmDialogAsync_003Ed__26 stateMachine = default(_003CShowConfirmDialogAsync_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.owner = window_0;
		stateMachine.title = string_2;
		stateMachine.titleIcon = string_3;
		stateMachine.message = string_4;
		stateMachine.icon = string_5;
		stateMachine.buttons = string_6;
		stateMachine.primaryButton = string_7;
		stateMachine.cancellationToken = nullable_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static (bool isSuccess, string button) lVeL0kxeWvI(Window window_0, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
	{
		ConfirmDialog confirmDialog = lN0L0GusKFx(window_0, string_2, string_3, string_4, string_5, string_6, string_7);
		return (isSuccess: confirmDialog.ShowDialog() == true, button: confirmDialog.SelectedButton);
	}

	private static ConfirmDialog lN0L0GusKFx(Window window_0, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
	{
		ConfirmDialog confirmDialog = new ConfirmDialog
		{
			Owner = window_0,
			Title = string_2
		};
		confirmDialog.TitleIconString = string_3;
		confirmDialog.SetMessage(string_4);
		if (!string.IsNullOrEmpty(string_5))
		{
			string text = string_5.ToLower();
			if (!(text == "information"))
			{
				int num = 0;
				if (!zFrNPAF3lHQUHx3PUZ1E())
				{
					int num2 = default(int);
					num = num2;
				}
				while (true)
				{
					IL_00ac:
					switch (num)
					{
					default:
						while (true)
						{
							switch (text)
							{
							case "success":
								goto IL_0088;
							case "error":
								string_5 = "fa:Solid_TimesCircle:#dc3545";
								break;
							case "warning":
								string_5 = "fa:Solid_ExclamationTriangle:#ffc107";
								break;
							case "question":
								string_5 = "fa:Solid_QuestionCircle:#0078d7";
								break;
							}
							break;
							IL_0088:
							string_5 = "fa:Solid_CheckCircle:#28a745";
							num = 1;
							if (!zFrNPAF3lHQUHx3PUZ1E())
							{
								continue;
							}
							goto IL_00ac;
						}
						break;
					case 1:
						break;
					}
					break;
				}
			}
			else
			{
				string_5 = "fa:Solid_InfoCircle:#007bff";
			}
			if (string_5.StartsWith("["))
			{
				string_5 = string_5.TrimStart('[').TrimEnd(']', ' ');
			}
			confirmDialog.MainIconString = string_5;
		}
		else
		{
			confirmDialog.MainIconString = null;
		}
		confirmDialog.LF5L0YiICcd(string_6, string_7);
		return confirmDialog;
	}

	private void CUnL0sOTAy8(object sender, EventArgs e)
	{
	}

	private void cDoL0HusiuQ(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.C && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
		{
			string value = new string('-', 8);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(base.Title);
			stringBuilder.AppendLine(value);
			stringBuilder.AppendLine(ofjL0maZ1w6);
			stringBuilder.AppendLine();
			ClipboardHelper.SetText(stringBuilder.ToString());
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!dUFL0rxrJIZ)
		{
			dUFL0rxrJIZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/confirmdialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			dUFL0rxrJIZ = true;
			break;
		case 1:
			TheWindow = (ConfirmDialog)target;
			TheWindow.ContentRendered += CUnL0sOTAy8;
			TheWindow.PreviewKeyDown += cDoL0HusiuQ;
			break;
		case 2:
			TitleIcon = (IconControl)target;
			break;
		case 3:
			LblTitle = (TextBlock)target;
			break;
		case 4:
			BtnClose = (Button)target;
			BtnClose.Click += LnZL0eKnTvO;
			break;
		case 5:
			MainIcon = (IconControl)target;
			break;
		case 6:
			ContentBody = (ContentControl)target;
			if (!zFrNPAF3lHQUHx3PUZ1E())
			{
				switch (0)
				{
				}
			}
			break;
		case 7:
			LblContent = (TextBlock)target;
			break;
		case 8:
			PnlButtons = (WrapPanel)target;
			break;
		}
	}

	[CompilerGenerated]
	private void PpHL01vrG6x()
	{
		Activate();
		eCrL0XwIVuk.Focus();
	}

	internal static bool zFrNPAF3lHQUHx3PUZ1E()
	{
		return OmHmrKF3iKR7DCbEPIOl == null;
	}
}
