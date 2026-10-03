using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using HandyControl.Tools;
using Microsoft.WindowsAPICodePack.Taskbar;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View;

public class WaitUserWindow : Window, IComponentConnector, iTHRNJY2ZQQokysD4pN
{
	private readonly string qFAgzGpR2us;

	private readonly ActionExecuteContext YYRgzsol7TT;

	private readonly ShowWindowLocation qwxgzHTS63E;

	private List<SimpleOperationItem> BsAgz1pMTXg;

	private readonly bool qnIgzbaUuL7;

	private string cmBgz6C4DS3 = string.Empty;

	[CompilerGenerated]
	private double M1ggzXjf4ZH = 16.0;

	[CompilerGenerated]
	private bool RVjgzmAUyXV = true;

	[CompilerGenerated]
	private double lycgzKGM7Lj;

	public static readonly DependencyProperty ButtonFontSizeProperty;

	[CompilerGenerated]
	private bool BuQgzxvyjC9;

	private bool swfgzrcXApH;

	private DateTime? tUngzp6JFLv;

	private DispatcherTimer Y1PgzByLXyB;

	[CompilerGenerated]
	private CancellationTokenRegistration? hxcgzQiSNYO;

	internal Grid GridProgress;

	internal System.Windows.Controls.ProgressBar TheProgressBar;

	internal TextBlock TxtProgress;

	internal TextBlock LblPrompt;

	internal WrapPanel PnlButtons;

	internal System.Windows.Controls.Button BtnOk;

	internal MarkdownHintButton HintButton;

	internal System.Windows.Controls.ProgressBar ProgressBarAutoClose;

	private bool SXkgzj17lKt;

	internal static WaitUserWindow NjeSRVFXptdAn4QslAdG;

	public double IconSize
	{
		[CompilerGenerated]
		get
		{
			return M1ggzXjf4ZH;
		}
		[CompilerGenerated]
		set
		{
			M1ggzXjf4ZH = value;
		}
	}

	public bool StopActionWhenClosedByCross
	{
		[CompilerGenerated]
		get
		{
			return RVjgzmAUyXV;
		}
		[CompilerGenerated]
		set
		{
			RVjgzmAUyXV = value;
		}
	}

	public double AutoCloseSeconds
	{
		[CompilerGenerated]
		get
		{
			return lycgzKGM7Lj;
		}
		[CompilerGenerated]
		set
		{
			lycgzKGM7Lj = value;
		}
	}

	public double ButtonFontSize
	{
		get
		{
			return (double)GetValue(ButtonFontSizeProperty);
		}
		set
		{
			SetValue(ButtonFontSizeProperty, value);
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

	public bool WindowDragMoved
	{
		[CompilerGenerated]
		get
		{
			return BuQgzxvyjC9;
		}
		[CompilerGenerated]
		set
		{
			BuQgzxvyjC9 = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return hxcgzQiSNYO;
		}
		[CompilerGenerated]
		set
		{
			hxcgzQiSNYO = value;
		}
	}

	public WaitUserWindow(string title, string prompt, string btnText, string winKey, ActionExecuteContext context, ShowWindowLocation location, string progress, List<SimpleOperationItem> operations, double iconSize, double fontSize, string activateMode)
	{
		qFAgzGpR2us = winKey;
		YYRgzsol7TT = context;
		qwxgzHTS63E = location;
		BsAgz1pMTXg = operations;
		IconSize = Math.Max(0.0, iconSize);
		ButtonFontSize = Math.Max(6.0, fontSize);
		base.LocationChanged += WLfgzE2HOP6;
		InitializeComponent();
		switch (activateMode)
		{
		case "NotActivated":
			base.ShowActivated = false;
			break;
		case "AutoActivate":
			base.ShowActivated = true;
			break;
		case "NotActivatable":
			base.ShowActivated = false;
			base.SourceInitialized += wMogzhMn4Gd;
			break;
		}
		base.Title = title;
		LblPrompt.Text = prompt;
		PQwgza5LKiT();
		BtnOk.Content = btnText;
		BtnOk.FontSize = ButtonFontSize;
		base.Loaded += YjwgzREjI2w;
		base.Closed += yTVgzPq5w66;
		Q7fgz79E9I9(progress);
		VMsgzykoG2H();
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

	private void yTVgzPq5w66(object sender, EventArgs e)
	{
		zZ0gzqgrfCZ();
		if (!swfgzrcXApH && StopActionWhenClosedByCross)
		{
			YYRgzsol7TT?.StopAction(ActionStopFlag.UserCancel, "用户停止动作（关闭等待窗口）。");
		}
		YYRgzsol7TT?.OnWaitWindowClosed(qFAgzGpR2us, cmBgz6C4DS3);
	}

	private void WLfgzE2HOP6(object sender, EventArgs e)
	{
		if (AppState.v5FtaQ4hQfg().zYwvLopdTEn().RealState.Kcpt9nPM6AT(MouseButtons.Left))
		{
			WindowDragMoved = true;
		}
	}

	private void VMsgzykoG2H()
	{
		LblPrompt.Visibility = (string.IsNullOrEmpty(LblPrompt.Text) ? Visibility.Collapsed : Visibility.Visible);
		cmBgz6C4DS3 = string.Empty;
		if (string.IsNullOrEmpty(BtnOk.Content as string))
		{
			BtnOk.Visibility = Visibility.Collapsed;
		}
		else
		{
			BtnOk.Visibility = Visibility.Visible;
			int num = 0;
			if (NjeSRVFXptdAn4QslAdG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (PnlButtons.Children.Count > 2)
		{
			while (PnlButtons.Children.Count > 2)
			{
				PnlButtons.Children.RemoveAt(0);
			}
		}
		if (!BsAgz1pMTXg.HasData())
		{
			return;
		}
		int num4 = default(int);
		foreach (SimpleOperationItem item in BsAgz1pMTXg)
		{
			System.Windows.Controls.Button button = new System.Windows.Controls.Button();
			button.Margin = new Thickness(0.0, 0.0, 6.0, 7.0);
			button.Height = double.NaN;
			button.FontSize = ButtonFontSize;
			(string, string, string) tuple = UIHelper.ExtractIconAndTitle(item.Name);
			button.Content = UIHelper.CreateButtonContent(tuple.Item1, tuple.Item2, IconSize);
			int num3 = 0;
			if (!CFnyAZFXXAsTTZL5UFCh())
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			if (!string.IsNullOrEmpty(tuple.Item3))
			{
				button.ToolTip = tuple.Item3;
			}
			button.Tag = item.Key;
			button.Click += EwxgzeuRXrb;
			PnlButtons.Children.Insert(PnlButtons.Children.Count - 2, button);
		}
	}

	public void Update(string title, string prompt, string btnText, string progress, List<SimpleOperationItem> operations)
	{
		base.Title = title;
		LblPrompt.Text = prompt;
		BtnOk.Content = btnText;
		Q7fgz79E9I9(progress);
		if (BsAgz1pMTXg != null && operations != null && BsAgz1pMTXg.Count == operations.Count)
		{
			BsAgz1pMTXg = operations;
			kPegz8kNYVk();
		}
		else
		{
			BsAgz1pMTXg = operations;
			VMsgzykoG2H();
		}
		PQwgza5LKiT();
		if (!WindowDragMoved && qwxgzHTS63E.IsAny(ShowWindowLocation.BottomRight, ShowWindowLocation.TopRight, ShowWindowLocation.BottomCenter, ShowWindowLocation.CenterScreen, ShowWindowLocation.TopCenter))
		{
			UpdateLayout();
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, qwxgzHTS63E);
		}
	}

	private void kPegz8kNYVk()
	{
		if (!BsAgz1pMTXg.HasData())
		{
			return;
		}
		int num = 0;
		while (num < BsAgz1pMTXg.Count)
		{
			System.Windows.Controls.Button button = PnlButtons.Children[num] as System.Windows.Controls.Button;
			(string, string, string) tuple = UIHelper.ExtractIconAndTitle(BsAgz1pMTXg[num].Name);
			button.Content = UIHelper.CreateButtonContent(tuple.Item1, tuple.Item2, IconSize);
			if (!string.IsNullOrEmpty(tuple.Item3))
			{
				button.ToolTip = tuple.Item3;
			}
			button.Tag = BsAgz1pMTXg[num].Key;
			num++;
			if (NjeSRVFXptdAn4QslAdG != null)
			{
				switch (0)
				{
				}
			}
		}
	}

	private void PQwgza5LKiT()
	{
		string text = LblPrompt.Text;
		if (text != null && text.Contains("\n"))
		{
			LblPrompt.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
		}
		else
		{
			LblPrompt.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
		}
	}

	private void Q7fgz79E9I9(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			GridProgress.Visibility = Visibility.Collapsed;
			return;
		}
		GridProgress.Visibility = Visibility.Visible;
		int num;
		double num2 = default(double);
		double num3 = default(double);
		if (!string_2.Contains("/"))
		{
			num = 0;
			if (NjeSRVFXptdAn4QslAdG != null)
			{
				goto IL_009c;
			}
		}
		else
		{
			string[] array = string_2.Split('/');
			if (array.Length != 2)
			{
				AppHelper.ShowWarning("进参数不正确，请使用 当前/总数 的格式传入。 当前传入值：" + string_2);
			}
			num2 = Convert.ToDouble(array[0], CultureInfo.InvariantCulture);
			num3 = Convert.ToDouble(array[1], CultureInfo.InvariantCulture);
			num = 1;
			if (NjeSRVFXptdAn4QslAdG != null)
			{
				goto IL_00ae;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_00ae;
		}
		goto IL_009c;
		IL_009c:
		AppHelper.ShowWarning("进参数不正确，请使用 当前/总数 的格式传入。 当前传入值：" + string_2);
		return;
		IL_00ae:
		if (num2 < 0.0)
		{
			num2 = num3 + num2;
		}
		TheProgressBar.Minimum = 0.0;
		TheProgressBar.Maximum = num3;
		TheProgressBar.Value = num2;
		IntPtr handle = this.GetHandle();
		if (num2 >= num3)
		{
			TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, handle);
		}
		else
		{
			TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal, handle);
			TaskbarManager.Instance.SetProgressValue((int)num2, (int)num3, handle);
		}
		TxtProgress.Text = string_2.TrimStart('-');
	}

	private void YjwgzREjI2w(object sender, RoutedEventArgs e)
	{
		int num;
		if (qwxgzHTS63E == ShowWindowLocation.LastPosition)
		{
			if (YYRgzsol7TT.WaiteUserWindowTopLeft.HasValue)
			{
				base.WindowStartupLocation = WindowStartupLocation.Manual;
				base.Left = YYRgzsol7TT.WaiteUserWindowTopLeft.Value.X;
				num = 0;
				if (!CFnyAZFXXAsTTZL5UFCh())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00b4;
			}
			base.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}
		else
		{
			UpdateLayout();
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, qwxgzHTS63E);
		}
		goto IL_00e4;
		IL_00e4:
		YYRgzsol7TT.UpdateWaiteWindowLocation(new Point(base.Left, base.Top));
		base.LocationChanged += glegzYsFPrG;
		if (AutoCloseSeconds > 0.5)
		{
			tUngzp6JFLv = DateTime.Now.AddSeconds(AutoCloseSeconds);
			num = 1;
			if (NjeSRVFXptdAn4QslAdG == null)
			{
				goto IL_00b4;
			}
			goto IL_0129;
		}
		return;
		IL_00b4:
		switch (num)
		{
		case 1:
			goto IL_0129;
		}
		base.Top = YYRgzsol7TT.WaiteUserWindowTopLeft.Value.Y;
		goto IL_00e4;
		IL_0129:
		Y1PgzByLXyB = new DispatcherTimer
		{
			Interval = new TimeSpan(0, 0, 0, 0, 100)
		};
		Y1PgzByLXyB.Tick += sm3gzcFcG1A;
		Y1PgzByLXyB.Start();
		base.PreviewMouseDown += TWYgzWIbxMQ;
		base.PreviewKeyDown += ND8gzku4MBB;
		ProgressBarAutoClose.Visibility = Visibility.Visible;
	}

	private void zZ0gzqgrfCZ()
	{
		if (Y1PgzByLXyB != null)
		{
			Y1PgzByLXyB.Tick -= sm3gzcFcG1A;
			Y1PgzByLXyB.Stop();
			Y1PgzByLXyB = null;
			ProgressBarAutoClose.Visibility = Visibility.Collapsed;
		}
	}

	private void sm3gzcFcG1A(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		DateTime? dateTime = tUngzp6JFLv;
		if (now > dateTime)
		{
			zZ0gzqgrfCZ();
			Close();
			return;
		}
		double value = 100.0 - (tUngzp6JFLv.Value - DateTime.Now).TotalSeconds / AutoCloseSeconds * 100.0;
		ProgressBarAutoClose.Value = value;
		int num = 0;
		if (!CFnyAZFXXAsTTZL5UFCh())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void sNngzVyw5kA(object sender, RoutedEventArgs e)
	{
		swfgzrcXApH = true;
		cmBgz6C4DS3 = "";
		Close();
	}

	public void CloseFromCode()
	{
		swfgzrcXApH = true;
		Close();
	}

	private void b4QgzZTmHfB(object sender, EventArgs e)
	{
		WindowState windowState = base.WindowState;
	}

	private void LCSgz9ahwtG(object sender, ExecutedRoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!SXkgzj17lKt)
		{
			SXkgzj17lKt = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/waituserwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			SXkgzj17lKt = true;
			break;
		case 1:
			((WaitUserWindow)target).StateChanged += b4QgzZTmHfB;
			break;
		case 2:
			((CommandBinding)target).Executed += LCSgz9ahwtG;
			break;
		case 3:
			GridProgress = (Grid)target;
			break;
		case 4:
			TheProgressBar = (System.Windows.Controls.ProgressBar)target;
			break;
		case 5:
			TxtProgress = (TextBlock)target;
			break;
		case 6:
			LblPrompt = (TextBlock)target;
			if (NjeSRVFXptdAn4QslAdG != null)
			{
				switch (0)
				{
				}
			}
			break;
		case 7:
			PnlButtons = (WrapPanel)target;
			break;
		case 8:
			BtnOk = (System.Windows.Controls.Button)target;
			BtnOk.Click += sNngzVyw5kA;
			break;
		case 9:
			HintButton = (MarkdownHintButton)target;
			break;
		case 10:
			ProgressBarAutoClose = (System.Windows.Controls.ProgressBar)target;
			break;
		}
	}

	static WaitUserWindow()
	{
		ButtonFontSizeProperty = DependencyProperty.Register("ButtonFontSize", typeof(double), typeof(WaitUserWindow), new PropertyMetadata(12.0));
	}

	[CompilerGenerated]
	private void wMogzhMn4Gd(object sender, EventArgs e)
	{
		NativeMethods.SetWindowNoActivate(this);
	}

	[CompilerGenerated]
	private void EwxgzeuRXrb(object sender, RoutedEventArgs e)
	{
		swfgzrcXApH = true;
		cmBgz6C4DS3 = (sender as System.Windows.Controls.Button).Tag as string;
		Close();
	}

	[CompilerGenerated]
	private void glegzYsFPrG(object sender, EventArgs e)
	{
		base.Dispatcher.InvokeAsync(YyxgzIwtjXA);
	}

	[CompilerGenerated]
	private void YyxgzIwtjXA()
	{
		if (base.WindowState != WindowState.Minimized)
		{
			YYRgzsol7TT.UpdateWaiteWindowLocation(new Point(base.Left, base.Top));
		}
	}

	[CompilerGenerated]
	private void TWYgzWIbxMQ(object sender, MouseButtonEventArgs e)
	{
		zZ0gzqgrfCZ();
	}

	[CompilerGenerated]
	private void ND8gzku4MBB(object sender, System.Windows.Input.KeyEventArgs e)
	{
		zZ0gzqgrfCZ();
	}

	internal static bool CFnyAZFXXAsTTZL5UFCh()
	{
		return NjeSRVFXptdAn4QslAdG == null;
	}
}
