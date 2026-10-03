using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View;

public class DateTimeInputWindow : System.Windows.Window, IComponentConnector, iTHRNJY2ZQQokysD4pN, IMockModalWindow
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_0
	{
		public DateTimeInputWindow kuOSpurRkmj;

		public int AY6SpNCrmlZ;

		internal static _003C_003Ec__DisplayClass25_0 LkGYdYWMfMCeN7ArmUJQ;

		internal void sZxSp2Mx14a(object sender, RoutedEventArgs e)
		{
			kuOSpurRkmj.Picker.SelectedDateTime = DateTime.Now.AddDays(AY6SpNCrmlZ);
		}

		internal static bool oW2F2KWMbHjXfmlym0Uw()
		{
			return LkGYdYWMfMCeN7ArmUJQ == null;
		}
	}

	private readonly string NTDgzg71VJh;

	private readonly string JcZgzLE8bIN;

	private readonly string kZVgzvrqoki;

	private readonly DateTime? K8WgzSCeiQW;

	public const string TYPE_DATE_TIME = "date_time";

	[CompilerGenerated]
	private bool oW2gz2eer9t;

	[CompilerGenerated]
	private ShowWindowLocation? kBFgzuwHn27;

	[CompilerGenerated]
	private bool DUwgzN02oBh;

	[CompilerGenerated]
	private bool? SIDgzJRGuld;

	[CompilerGenerated]
	private CancellationTokenRegistration? xtngz0bePeU;

	internal TextBlock LblPrompt;

	internal DateTimePicker Picker;

	internal StackPanel PnlButtons;

	internal TextBlock LblError;

	internal TextBlock LblHelp;

	internal Hyperlink LnkHelp;

	internal MarkdownHintButton HintButton;

	internal TextBlock LblTip;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool j1lgzCUW7EZ;

	private static DateTimeInputWindow Nc2LEkFpCAfwrw67A7aP;

	public DateTime? Value => Picker.SelectedDateTime;

	public bool IsRequired
	{
		[CompilerGenerated]
		get
		{
			return oW2gz2eer9t;
		}
		[CompilerGenerated]
		set
		{
			oW2gz2eer9t = value;
		}
	}

	public ShowWindowLocation? ShowLocation
	{
		[CompilerGenerated]
		get
		{
			return kBFgzuwHn27;
		}
		[CompilerGenerated]
		set
		{
			kBFgzuwHn27 = value;
		}
	}

	public bool CloseOnDeactivated
	{
		[CompilerGenerated]
		get
		{
			return DUwgzN02oBh;
		}
		[CompilerGenerated]
		set
		{
			DUwgzN02oBh = value;
		}
	}

	public string HelpText
	{
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				HintButton.MarkDownToolTip = value;
				HintButton.Visibility = Visibility.Visible;
			}
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return SIDgzJRGuld;
		}
		[CompilerGenerated]
		set
		{
			SIDgzJRGuld = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return xtngz0bePeU;
		}
		[CompilerGenerated]
		set
		{
			xtngz0bePeU = value;
		}
	}

	public DateTimeInputWindow(string valueType, string prompt, string pattern, DateTime? defaultValue)
	{
		NTDgzg71VJh = valueType;
		JcZgzLE8bIN = prompt;
		kZVgzvrqoki = pattern;
		K8WgzSCeiQW = defaultValue;
		InitializeComponent();
		base.Loaded += ONtgfUEuYTh;
		base.Deactivated += xgkgfFNj5ZH;
		AppHelper.AddGoToPageCommandBinding(this);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void xgkgfFNj5ZH(object sender, EventArgs e)
	{
		if (CloseOnDeactivated)
		{
			this.ThNvuM5Q9GQ(false);
		}
	}

	private void ONtgfUEuYTh(object sender, RoutedEventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.sE6vSvkrdZI(this);
		base.Title = JcZgzLE8bIN;
		LblPrompt.Visibility = Visibility.Collapsed;
		base.ResizeMode = ResizeMode.CanResizeWithGrip;
		Activate();
		int num = 0;
		if (!bD1eSaFp7JyUP9EUUufQ())
		{
			goto IL_015e;
		}
		goto IL_0162;
		IL_015e:
		int num2 = default(int);
		num = num2;
		goto IL_0162;
		IL_0162:
		do
		{
			switch (num)
			{
			case 1:
				if (ShowLocation.HasValue)
				{
					UpdateLayout();
					IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowLocation.Value);
				}
				else
				{
					IHNRIiikxBwJdYmHpM3.sE6vSvkrdZI(this);
				}
				return;
			}
			Focus();
			LblPrompt.Text = JcZgzLE8bIN;
			Picker.SelectedDateTime = K8WgzSCeiQW;
			kcygflBrVET("现在", 0);
			kcygflBrVET("明天", 1);
			kcygflBrVET("后天", 2);
			kcygflBrVET("一周后", 7);
			Button button = new Button
			{
				Content = "一月后"
			};
			button.Click += ONtgfziQYD0;
			PnlButtons.Children.Add(button);
			Button button2 = new Button
			{
				Content = "0点",
				Margin = new Thickness(5.0, 0.0, 0.0, 0.0)
			};
			button2.Click += xcDgzw8FQnG;
			PnlButtons.Children.Add(button2);
			base.Dispatcher.InvokeAsync(R5Ngzt4jKhu);
			num = 1;
		}
		while (Nc2LEkFpCAfwrw67A7aP == null);
		goto IL_015e;
	}

	private void kcygflBrVET(string string_3, int int_0)
	{
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
		_003C_003Ec__DisplayClass25_.kuOSpurRkmj = this;
		_003C_003Ec__DisplayClass25_.AY6SpNCrmlZ = int_0;
		Button button = new Button
		{
			Content = string_3
		};
		button.Click += _003C_003Ec__DisplayClass25_.sZxSp2Mx14a;
		PnlButtons.Children.Add(button);
	}

	private void LHdgfiV8vKZ(object sender, RoutedEventArgs e)
	{
		yYdgf3qs4Ax();
	}

	private void yYdgf3qs4Ax()
	{
		LblError.Text = "";
		if (!Picker.SelectedDateTime.HasValue)
		{
			if (!IsRequired)
			{
				this.ThNvuM5Q9GQ(true);
			}
			else
			{
				LblError.Text = "不能为空！";
			}
		}
		else
		{
			this.ThNvuM5Q9GQ(true);
		}
	}

	public void SetHelplink(string helpLink)
	{
		if (string.IsNullOrEmpty(helpLink))
		{
			return;
		}
		string text;
		string uriString;
		if (helpLink.Contains("|"))
		{
			string[] array = helpLink.Split(new char[1] { '|' }, 2);
			text = array[0];
			uriString = array[1];
		}
		else
		{
			text = (uriString = helpLink);
		}
		try
		{
			LnkHelp.NavigateUri = new Uri(uriString);
			LnkHelp.Inlines.Add(text);
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void oXVgff53okt(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!j1lgzCUW7EZ)
		{
			j1lgzCUW7EZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/datetimeinputwindow.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			j1lgzCUW7EZ = true;
			break;
		case 1:
			LblPrompt = (TextBlock)target;
			break;
		case 2:
			Picker = (DateTimePicker)target;
			break;
		case 3:
			PnlButtons = (StackPanel)target;
			break;
		case 4:
			LblError = (TextBlock)target;
			break;
		case 5:
			LblHelp = (TextBlock)target;
			break;
		case 6:
			LnkHelp = (Hyperlink)target;
			break;
		case 7:
			HintButton = (MarkdownHintButton)target;
			break;
		case 8:
			LblTip = (TextBlock)target;
			break;
		case 9:
			BtnOk = (Button)target;
			BtnOk.Click += LHdgfiV8vKZ;
			break;
		case 10:
		{
			BtnCancel = (Button)target;
			int num = 0;
			if (!bD1eSaFp7JyUP9EUUufQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnCancel.Click += oXVgff53okt;
				break;
			}
			break;
		}
		}
	}

	[CompilerGenerated]
	private void ONtgfziQYD0(object sender, RoutedEventArgs e)
	{
		Picker.SelectedDateTime = DateTime.Now.AddMonths(1);
	}

	[CompilerGenerated]
	private void xcDgzw8FQnG(object sender, RoutedEventArgs e)
	{
		Picker.SelectedDateTime = Picker.SelectedDateTime?.Date;
	}

	[CompilerGenerated]
	private void R5Ngzt4jKhu()
	{
		Picker.Focus();
	}

	internal static bool bD1eSaFp7JyUP9EUUufQ()
	{
		return Nc2LEkFpCAfwrw67A7aP == null;
	}
}
