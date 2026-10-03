using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using bJBpBeM0LEpwByexKDl;
using CNQbNMjy0XChie2K6Sm;
using FlaUI.Core.Tools;
using fmaGYuo4Ku330Ewtfhr;
using HandyControl.Controls;
using HandyControl.Data;
using Jp6YuAAO2nOBQFwcNUf;
using log4net;
using Newtonsoft.Json;
using Quicker.Actions.XActions.BuildinRunners.UI.CustomPanel;
using Quicker.Domain;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using t8SGKhhgLWTgeqjGcrq;
using ToastNotifications.Utilities;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.Actions.XActions.BuildinRunners.UI;

public class CustomPanelWindow : System.Windows.Window, IComponentConnector, IStyleConnector, ql8exboyDpJ7Y0f68sS, iTHRNJY2ZQQokysD4pN
{
	public struct WINDOWPOS
	{
		public IntPtr hwnd;

		public IntPtr hwndInsertAfter;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public uint flags;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CCustomPanelWindow_OnPreviewMouseRightButtonUp_003Eb__161_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CustomPanelWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object f0LdsWWqqIRXglcXIgIC;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CustomPanelWindow customPanelWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(50).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				int num2 = 0;
				if (!vmm645WqiUn5nB3D6wVg())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					AppHelper.RunOnUiThread(false, customPanelWindow.xQZgKQNYJ18);
					break;
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

		static _003C_003CCustomPanelWindow_OnPreviewMouseRightButtonUp_003Eb__161_0_003Ed()
		{
		}

		internal static bool vmm645WqiUn5nB3D6wVg()
		{
			return f0LdsWWqqIRXglcXIgIC == null;
		}

		internal static void AfHa8SWqZ9RVWGnr2hb9()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec o71SHNRNXyn;

		public static Func<CommonOperationItem, bool> liESHJbOcvM;

		public static Func<CommonOperationItem, bool> q54SH0eaR6v;

		public static Func<CommonOperationItem, bool> ulfSHCPxR46;

		public static Func<Expander, bool> Iu1SHPTOEgv;

		public static Func<Expander, string> nDlSHEYbkZr;

		public static Func<string, bool> jTMSHyrZwDQ;

		internal static _003C_003Ec jKudiJWq5JCqfFHmAvEO;

		static _003C_003Ec()
		{
			o71SHNRNXyn = new _003C_003Ec();
		}

		internal bool XmMSHgu2TqM(CommonOperationItem x)
		{
			return !x.Children.HasData();
		}

		internal bool PRFSHL9rtv8(CommonOperationItem x)
		{
			return x.Children.HasData();
		}

		internal bool IygSHvFsXnJ(CommonOperationItem x)
		{
			return !x.Children.HasData();
		}

		internal bool xTCSHSRAng5(Expander x)
		{
			return x.IsExpanded;
		}

		internal string uGqSH2RiDGE(Expander x)
		{
			return I30gKYknPuX(x.Tag as CommonOperationItem);
		}

		internal bool jcRSHuIfblL(string x)
		{
			return !x.IsNullOrEmpty();
		}

		internal static bool j1wosBWqY7kaebdF4XOi()
		{
			return jKudiJWq5JCqfFHmAvEO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass101_0
	{
		public CommonOperationItem pKiSHa2u0gO;

		public CustomPanelWindow vLbSH7HJKLw;

		internal static _003C_003Ec__DisplayClass101_0 x6S7qUWqgJUPIdbKdV5W;

		internal void J4mSH8PSC6P()
		{
			try
			{
				UQpehvAn0sgnYNEpfrQ.Execute(pKiSHa2u0gO, vLbSH7HJKLw.qPBgKjd8FI3.Context);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行操作出错：" + ex.Message);
			}
		}

		internal static bool YWrb5vWqPshQADYEsjWU()
		{
			return x6S7qUWqgJUPIdbKdV5W == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass104_0
	{
		public CommonOperationItem rgxSHqQYBjE;

		public CustomPanelWindow yWISHcFnNN7;

		internal static _003C_003Ec__DisplayClass104_0 wKiZKyWqUc7yWiyDX6Bi;

		internal void LpJSHRtLQVB()
		{
			try
			{
				UQpehvAn0sgnYNEpfrQ.Execute(rgxSHqQYBjE, yWISHcFnNN7.qPBgKjd8FI3.Context);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行菜单操作出错：" + ex.Message);
			}
		}

		internal static bool h1R2QEWqxEpZ2tvCOy15()
		{
			return wKiZKyWqUc7yWiyDX6Bi == null;
		}
	}

	private CustomPanelInfo qPBgKjd8FI3;

	public const int WM_SYSCOMMAND = 274;

	public const int SC_MAXIMIZE = 61488;

	public const int SC_MINIMIZE = 61472;

	private bool gpCgKn8SMrJ;

	private double bNygK4CnIAs = 300.0;

	private double lnngK5jfY90 = 300.0;

	public static readonly DependencyProperty IsShowContentProperty;

	public static readonly DependencyProperty IsOpenProperty;

	public static readonly DependencyProperty EnableAutoCollapseProperty;

	public static readonly DependencyProperty ButtonBackgroundBrushProperty;

	public static readonly DependencyProperty ButtonBorderBrushProperty;

	public static readonly DependencyProperty ButtonHoverBrushProperty;

	public static readonly DependencyProperty ButtonMouseDownBrushProperty;

	[CompilerGenerated]
	private string P6hgKD7FgOn = string.Empty;

	[CompilerGenerated]
	private CommonOperationItem RVGgKdUFynM;

	[CompilerGenerated]
	private CommonOperationItem a8fgKoqqlRb;

	[CompilerGenerated]
	private CommonOperationItem H0agKTjZLOW;

	private static readonly ILog KLFgKMu5XD6;

	public static readonly DependencyProperty TitleIconProperty;

	private IList<Expander> twsgKA0LnpE;

	private System.Windows.Controls.Button uvXgKOP3GiC;

	[CompilerGenerated]
	private string fQ9gKFwRckY;

	public static readonly DependencyProperty IsContextMenuOpenedProperty;

	public static readonly DependencyProperty EnableBindingProcessProperty;

	[CompilerGenerated]
	private IList<string> CLdgKUPAvg9 = new List<string>();

	private bool vqagKlSDOge;

	private bool gZ5gKi5IHjk;

	private System.Drawing.Point bOtgK3oZpKn;

	private System.Drawing.Point TVqgKfdRYvw;

	private Screen FGlgKzYTgDd;

	private double WfQgxwySQac;

	[CompilerGenerated]
	private CancellationTokenRegistration? fxxgxtWrNaq;

	private bool o9tgxgaMaUp;

	internal CustomPanelWindow TheWindow;

	internal Grid MainGrid;

	private bool Il0gxLLBtRt;

	internal static CustomPanelWindow ohZp5KQ7ldMrgEIo4PBJ;

	public string WindowId => qPBgKjd8FI3.WindowId;

	public bool IsShowContent
	{
		get
		{
			return (bool)GetValue(IsShowContentProperty);
		}
		set
		{
			SetValue(IsShowContentProperty, value);
		}
	}

	public bool IsOpen
	{
		get
		{
			return (bool)GetValue(IsOpenProperty);
		}
		set
		{
			SetValue(IsOpenProperty, value);
		}
	}

	public bool EnableAutoCollapse
	{
		get
		{
			return (bool)GetValue(EnableAutoCollapseProperty);
		}
		set
		{
			SetValue(EnableAutoCollapseProperty, value);
		}
	}

	public System.Windows.Media.Brush ButtonBackgroundBrush
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(ButtonBackgroundBrushProperty);
		}
		set
		{
			SetValue(ButtonBackgroundBrushProperty, value);
		}
	}

	public System.Windows.Media.Brush ButtonBorderBrush
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(ButtonBorderBrushProperty);
		}
		set
		{
			SetValue(ButtonBorderBrushProperty, value);
		}
	}

	public System.Windows.Media.Brush ButtonHoverBrush
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(ButtonHoverBrushProperty);
		}
		set
		{
			SetValue(ButtonHoverBrushProperty, value);
		}
	}

	public System.Windows.Media.Brush ButtonMouseDownBrush
	{
		get
		{
			return (System.Windows.Media.Brush)GetValue(ButtonMouseDownBrushProperty);
		}
		set
		{
			SetValue(ButtonMouseDownBrushProperty, value);
		}
	}

	public string ResultData
	{
		[CompilerGenerated]
		get
		{
			return P6hgKD7FgOn;
		}
		[CompilerGenerated]
		set
		{
			P6hgKD7FgOn = value;
		}
	}

	public CommonOperationItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return RVGgKdUFynM;
		}
		[CompilerGenerated]
		set
		{
			RVGgKdUFynM = value;
		}
	}

	public CommonOperationItem ResultButtonItem
	{
		[CompilerGenerated]
		get
		{
			return a8fgKoqqlRb;
		}
		[CompilerGenerated]
		set
		{
			a8fgKoqqlRb = value;
		}
	}

	public CommonOperationItem ResultButtonGroupItem
	{
		[CompilerGenerated]
		get
		{
			return H0agKTjZLOW;
		}
		[CompilerGenerated]
		set
		{
			H0agKTjZLOW = value;
		}
	}

	public string TitleIcon
	{
		get
		{
			return (string)GetValue(TitleIconProperty);
		}
		set
		{
			SetValue(TitleIconProperty, value);
		}
	}

	public string LastLocation
	{
		[CompilerGenerated]
		get
		{
			return fQ9gKFwRckY;
		}
		[CompilerGenerated]
		set
		{
			fQ9gKFwRckY = value;
		}
	}

	public bool IsContextMenuOpened
	{
		get
		{
			return (bool)GetValue(IsContextMenuOpenedProperty);
		}
		set
		{
			SetValue(IsContextMenuOpenedProperty, value);
		}
	}

	public bool EnableBindingProcess
	{
		get
		{
			return (bool)GetValue(EnableBindingProcessProperty);
		}
		set
		{
			SetValue(EnableBindingProcessProperty, value);
		}
	}

	public IList<string> BindingProcess
	{
		[CompilerGenerated]
		get
		{
			return CLdgKUPAvg9;
		}
		[CompilerGenerated]
		set
		{
			CLdgKUPAvg9 = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return fxxgxtWrNaq;
		}
		[CompilerGenerated]
		set
		{
			fxxgxtWrNaq = value;
		}
	}

	private static void BMZgmBF1Ito(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is CustomPanelWindow customPanelWindow)
		{
			customPanelWindow.JjKgmQUUIC6(true);
		}
	}

	private void JjKgmQUUIC6(bool bool_5)
	{
		if (!IsShowContent)
		{
			base.Height = 44.0;
		}
		else
		{
			base.Height = ((bNygK4CnIAs == 0.0) ? 300.0 : bNygK4CnIAs);
		}
	}

	public CustomPanelWindow(CustomPanelInfo info)
	{
		qPBgKjd8FI3 = info;
		base.DataContext = qPBgKjd8FI3;
		InitializeComponent();
		try
		{
			ox2gmlBh5Ve();
		}
		catch (Exception ex)
		{
			KLFgKMu5XD6.Error("生成窗口内容出错：" + ex.Message, ex);
			AppHelper.ShowWarning("生成窗口内容出错：" + ex.Message);
		}
		base.Loaded += eCsgmFAw4Zi;
		base.SourceInitialized += pM6gmTNjURr;
		base.Closing += agOgmdLT6t4;
		base.LocationChanged += JNVgmDtk97Q;
		base.SizeChanged += pHKgm4x8pIw;
		base.MouseRightButtonDown += YiYgmnmP1gr;
		base.ContextMenuOpening += MvFgmjBSxP0;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void MvFgmjBSxP0(object sender, ContextMenuEventArgs e)
	{
	}

	private void YiYgmnmP1gr(object sender, MouseButtonEventArgs e)
	{
	}

	private void pHKgm4x8pIw(object sender, SizeChangedEventArgs e)
	{
		if (gpCgKn8SMrJ)
		{
			if (IsShowContent)
			{
				bNygK4CnIAs = base.ActualHeight;
			}
			lnngK5jfY90 = base.ActualWidth;
			xBCgmoacfJo();
		}
	}

	private void bprgm5stGBg(object sender, ContextMenuEventArgs e)
	{
		AppHelper.ShowInformation("菜单展开了。");
	}

	private void JNVgmDtk97Q(object sender, EventArgs e)
	{
		if (base.IsLoaded)
		{
			double top = base.Top;
			xBCgmoacfJo();
		}
	}

	private void agOgmdLT6t4(object sender, CancelEventArgs e)
	{
		xBCgmoacfJo();
	}

	private void xBCgmoacfJo()
	{
		if (qPBgKjd8FI3.SavePanelState)
		{
			CustomPanelState value = new CustomPanelState
			{
				Left = base.Left,
				Top = base.Top,
				Location = WindowHelper.GetWindowTopLeft(this),
				Width = lnngK5jfY90,
				Height = Math.Max(base.ActualHeight, bNygK4CnIAs),
				CurrentGroup = GetCurrentGroup(),
				ExpandedGroups = GetExpandedGroups(),
				EnableAutoCollapse = EnableAutoCollapse,
				BindingProcesses = (EnableBindingProcess ? BindingProcess : null)
			};
			qPBgKjd8FI3.Context?.WriteState("custom_panel_state_" + qPBgKjd8FI3.WindowId, JsonConvert.SerializeObject(value));
		}
	}

	private void pM6gmTNjURr(object sender, EventArgs e)
	{
		IntPtr handle = new WindowInteropHelper(this).Handle;
		NativeMethods.SetWindowNoActivate(handle);
		NativeMethods.SetWindowNoMaximize(handle);
		NativeMethods.SetWindowPos(handle, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
		HwndSource.FromHwnd(handle).AddHook(R0NgmMPYTrX);
		System.Windows.Controls.Button button = default(System.Windows.Controls.Button);
		int num;
		if (!qPBgKjd8FI3.InitAutoCollapse.HasValue)
		{
			EnableAutoCollapse = false;
			button = GetTemplateChild("BtnToggleAutoCollapse") as System.Windows.Controls.Button;
			num = 3;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				goto IL_00fa;
			}
			goto IL_00fe;
		}
		EnableAutoCollapse = qPBgKjd8FI3.InitAutoCollapse.Value;
		goto IL_01ce;
		IL_009f:
		CustomPanelState panelState = qPBgKjd8FI3.PanelState;
		if (panelState != null)
		{
			double left = panelState.Left;
			if (true)
			{
				if (!qPBgKjd8FI3.PanelState.Location.HasValue)
				{
					base.Left = qPBgKjd8FI3.PanelState.Left;
					num = 1;
					if (ohZp5KQ7ldMrgEIo4PBJ != null)
					{
						goto IL_00fa;
					}
					goto IL_00fe;
				}
				WindowHelper.MoveTo(this, qPBgKjd8FI3.PanelState.Location.Value, true);
				goto IL_0220;
			}
		}
		qdxgmAdZNXk();
		lnngK5jfY90 = base.ActualWidth;
		bNygK4CnIAs = base.ActualHeight;
		goto IL_02af;
		IL_0220:
		if (qPBgKjd8FI3.PanelState.Width > 0.0)
		{
			base.Width = qPBgKjd8FI3.PanelState.Width;
			lnngK5jfY90 = base.Width;
			base.Height = qPBgKjd8FI3.PanelState.Height;
			bNygK4CnIAs = qPBgKjd8FI3.PanelState.Height;
		}
		dlggmOD9jLG();
		goto IL_02af;
		IL_00fa:
		int num2 = default(int);
		num = num2;
		goto IL_00fe;
		IL_00fe:
		switch (num)
		{
		case 3:
			goto IL_0119;
		case 1:
			goto IL_020a;
		case 2:
			return;
		}
		goto IL_009f;
		IL_0119:
		if (button != null)
		{
			button.Visibility = Visibility.Collapsed;
		}
		goto IL_01ce;
		IL_02af:
		JjKgmQUUIC6(false);
		if (qPBgKjd8FI3.PanelState != null)
		{
			EnableAutoCollapse = qPBgKjd8FI3.PanelState.EnableAutoCollapse;
			if (qPBgKjd8FI3.PanelState.BindingProcesses.HasData())
			{
				BindingProcess.Clear();
				qPBgKjd8FI3.PanelState.BindingProcesses.ForEach(li8gKps4sHA);
				EnableBindingProcess = true;
			}
			else
			{
				EnableBindingProcess = false;
			}
		}
		return;
		IL_01ce:
		if (!string.IsNullOrEmpty(qPBgKjd8FI3.InitBindingProcess))
		{
			if (qPBgKjd8FI3.InitBindingProcess.Trim().IsEither("-"))
			{
				if (GetTemplateChild("BtnLink") is System.Windows.Controls.Button button2)
				{
					button2.Visibility = Visibility.Collapsed;
					num = 0;
					if (!qtYlm7Q7Z73g5G1dSOxS())
					{
						goto IL_00fe;
					}
				}
			}
			else
			{
				EnableBindingProcess = true;
				qPBgKjd8FI3.InitBindingProcess.SplitToList(';', '；').ForEach(BindingProcess.Add);
			}
		}
		goto IL_009f;
		IL_020a:
		base.Top = qPBgKjd8FI3.PanelState.Top;
		goto IL_0220;
	}

	private IntPtr R0NgmMPYTrX(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_5)
	{
		if (int_0 <= 70)
		{
			if (int_0 == 33)
			{
				goto IL_00d1;
			}
			if (int_0 == 70)
			{
				if (!NativeMethods.IsOnWindows10OrLater())
				{
					return IntPtr.Zero;
				}
				if (Mouse.LeftButton != MouseButtonState.Pressed && NativeMethods.IsWindowVisible(intptr_0) && vqagKlSDOge)
				{
					WINDOWPOS structure = (WINDOWPOS)Marshal.PtrToStructure(intptr_2, typeof(WINDOWPOS));
					structure.flags |= 2u;
					Marshal.StructureToPtr(structure, intptr_2, false);
				}
			}
		}
		else
		{
			int num2 = default(int);
			while (int_0 != 274)
			{
				if (int_0 != 561)
				{
					int num = 0;
					if (!qtYlm7Q7Z73g5G1dSOxS())
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						goto IL_00bd;
					case 2:
						goto IL_00d1;
					}
					continue;
				}
				goto IL_00dc;
			}
			int num3 = intptr_1.ToInt32();
			if (num3 == 61488 || num3 == 61472)
			{
				etQgKVMVhJr();
				bool_5 = true;
			}
		}
		goto IL_010a;
		IL_00dc:
		gpCgKn8SMrJ = true;
		goto IL_010a;
		IL_010a:
		return IntPtr.Zero;
		IL_00bd:
		if (int_0 == 562)
		{
			gpCgKn8SMrJ = false;
		}
		goto IL_010a;
		IL_00d1:
		bool_5 = true;
		return new IntPtr(3);
	}

	private void qdxgmAdZNXk()
	{
		ShowWindowLocation result = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(qPBgKjd8FI3.WindowLocation, out result))
		{
			result = ShowWindowLocation.CenterScreen;
		}
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, result, qPBgKjd8FI3.WindowSize, false);
	}

	private void dlggmOD9jLG()
	{
		ShowWindowLocation result = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(qPBgKjd8FI3.WindowLocation, out result))
		{
			result = ShowWindowLocation.CenterScreen;
		}
		if (result.IsEither(ShowWindowLocation.WithMouse1, ShowWindowLocation.WithMouse2))
		{
			IHNRIiikxBwJdYmHpM3.p1AvvooEqum(this, result);
		}
	}

	private void eCsgmFAw4Zi(object sender, RoutedEventArgs e)
	{
	}

	private static System.Windows.Media.Brush qTXgmU9BNs5(System.Windows.Media.Color color_0)
	{
		if (color_0.IsLightColor())
		{
			return ColorHelper.AddOverlay(color_0, Colors.Black, 0.04).GetBrush();
		}
		return ColorHelper.AddOverlay(color_0, Colors.White, 0.04).GetBrush();
	}

	private void ox2gmlBh5Ve()
	{
		base.Title = qPBgKjd8FI3.WindowTitle;
		TitleIcon = qPBgKjd8FI3.WindowIcon;
		if (!string.IsNullOrEmpty(qPBgKjd8FI3.BackgroundColor))
		{
			System.Windows.Media.Color color = ColorHelper.StringToColor(qPBgKjd8FI3.BackgroundColor);
			base.Background = color.GetBrush();
		}
		if (qPBgKjd8FI3.FontBrush != null)
		{
			base.Foreground = qPBgKjd8FI3.FontBrush;
			SetValue(IconControl.DefaultIconColorProperty, qPBgKjd8FI3.FontColor);
		}
		base.Resources["ButtonPadding"] = qPBgKjd8FI3.ButtonPadding;
		System.Windows.Media.Color color2;
		int num;
		if (!qPBgKjd8FI3.ButtonColor.IsNullOrEmpty())
		{
			color2 = ColorHelper.StringToColor(qPBgKjd8FI3.ButtonColor);
			ButtonBackgroundBrush = color2.GetBrush();
			color2.IsLightColor();
			num = 0;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				goto IL_00e8;
			}
			goto IL_010c;
		}
		goto IL_011c;
		IL_011c:
		if (!qPBgKjd8FI3.ButtonBorderColor.IsNullOrEmpty())
		{
			ButtonBorderBrush = ColorHelper.StringToColor(qPBgKjd8FI3.ButtonBorderColor).GetBrush();
		}
		if (!qPBgKjd8FI3.Items.All(_003C_003Ec.liESHJbOcvM ?? (_003C_003Ec.liESHJbOcvM = _003C_003Ec.o71SHNRNXyn.XmMSHgu2TqM)) && !(qPBgKjd8FI3.GroupMode == "none"))
		{
			wl5gm3Ht9fL();
		}
		else
		{
			ContentControl contentControl = new ContentControl();
			kkbgKgF6vF0(contentControl);
			Q3fgKNkqJXF(contentControl, qPBgKjd8FI3.Items, null);
		}
		f30gmit4ETp();
		return;
		IL_00e8:
		ButtonHoverBrush = qTXgmU9BNs5(color2);
		ButtonMouseDownBrush = qTXgmU9BNs5(color2);
		num = 1;
		if (qtYlm7Q7Z73g5G1dSOxS())
		{
			goto IL_010c;
		}
		goto IL_011c;
		IL_010c:
		switch (num)
		{
		case 1:
			goto IL_011c;
		}
		goto IL_00e8;
	}

	private void f30gmit4ETp()
	{
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
		reLgKWi6fWD(contextMenu);
		bool flag = false;
		if (qPBgKjd8FI3.MenuItems.HasData())
		{
			foreach (CommonOperationItem menuItem in qPBgKjd8FI3.MenuItems)
			{
				string title = menuItem.Title;
				if (title != null && title.Equals("-close", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
				}
				else
				{
					BkigKEHTlWm(contextMenu.Items, menuItem, 16.0, null, null);
				}
			}
		}
		if (!flag)
		{
			if (AppState.HHxtaMaoqJr().CustomPanelWindowDbClickAction == 0)
			{
				if (contextMenu.Items.Count > 0)
				{
					AppHelper.AddMenuSeparator(contextMenu.Items);
				}
				AppHelper.AddMenuItem(contextMenu.Items, "关闭窗口", "", "fa:Light_Times:#FF0000", xLygKIKxW3o);
				if (qtYlm7Q7Z73g5G1dSOxS())
				{
					switch (0)
					{
					}
				}
			}
			else if (contextMenu.Items.Count == 0)
			{
				AppHelper.AddMenuItem(contextMenu.Items, "提示：可双击关闭窗口", "", "fa:Light_InfoCircle:#666666", null);
			}
		}
		base.ContextMenu = contextMenu;
	}

	private void wl5gm3Ht9fL()
	{
		twsgKA0LnpE = null;
		List<CommonOperationItem> list = qPBgKjd8FI3.Items.Where(_003C_003Ec.q54SH0eaR6v ?? (_003C_003Ec.q54SH0eaR6v = _003C_003Ec.o71SHNRNXyn.PRFSHL9rtv8)).ToList();
		List<CommonOperationItem> list2 = qPBgKjd8FI3.Items.Where(_003C_003Ec.ulfSHCPxR46 ?? (_003C_003Ec.ulfSHCPxR46 = _003C_003Ec.o71SHNRNXyn.IygSHvFsXnJ)).ToList();
		if (list2.HasData())
		{
			list.Add(new CommonOperationItem
			{
				Title = "*未分组*",
				Children = list2
			});
		}
		string groupMode = qPBgKjd8FI3.GroupMode;
		switch (groupMode)
		{
		case "heading":
			o4cgKvSb8Cq(list);
			return;
		case "columns":
			QFBgKLUgKyW(list);
			return;
		case "expander":
			jGZgKtT7mJe(list);
			return;
		case "tab-right":
			QHxgmfoFcYg(list, Dock.Right);
			return;
		case "tab-bottom":
		{
			QHxgmfoFcYg(list, Dock.Bottom);
			int num = 1;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				return;
			case 2:
				goto IL_01e0;
			case 3:
				return;
			}
			goto case "tab-top";
		}
		case "tab-top":
			QHxgmfoFcYg(list, Dock.Top);
			return;
		case "tab-left":
			QHxgmfoFcYg(list, Dock.Left);
			return;
		case "headingLeft":
			{
				py5gKSWM7Jr(list);
				return;
			}
			IL_01e0:
			if (!(groupMode == "tab-left"))
			{
				break;
			}
			goto case "tab-left";
		}
		o4cgKvSb8Cq(list);
	}

	private void QHxgmfoFcYg(List<CommonOperationItem> list_0, Dock dock_0)
	{
		System.Windows.Controls.TabControl tabControl = new System.Windows.Controls.TabControl();
		tabControl.Background = System.Windows.Media.Brushes.Transparent;
		MainGrid.Children.Clear();
		MainGrid.Children.Add(tabControl);
		tabControl.MouseWheel += G02gKuAPWxM;
		tabControl.SelectionChanged += klYgKwUAlU4;
		tabControl.TabStripPlacement = dock_0;
		if (dock_0 == Dock.Left || dock_0 == Dock.Right)
		{
			tabControl.Style = FindResource("ScrollableTabControlStyle") as Style;
			tabControl.BorderThickness = ((dock_0 == Dock.Left) ? new Thickness(1.0, 0.0, 0.0, 0.0) : new Thickness(0.0, 0.0, 1.0, 0.0));
		}
		tabControl.Margin = new Thickness(0.0);
		if (!string.IsNullOrWhiteSpace(qPBgKjd8FI3.BackgroundColor))
		{
			try
			{
				if ((double)ColorHelper.StringToWinformColor(qPBgKjd8FI3.BackgroundColor).GetBrightness() < 0.45)
				{
					tabControl.BorderBrush = System.Windows.Media.Color.FromArgb(32, byte.MaxValue, byte.MaxValue, byte.MaxValue).GetBrush();
				}
				else
				{
					tabControl.BorderBrush = System.Windows.Media.Color.FromArgb(32, 0, 0, 0).GetBrush();
				}
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("背景颜色格式不正确：" + qPBgKjd8FI3.BackgroundColor);
			}
		}
		foreach (CommonOperationItem item in list_0)
		{
			System.Windows.Controls.TabItem tabItem = new System.Windows.Controls.TabItem();
			tabItem.Background = System.Windows.Media.Brushes.Transparent;
			FrameworkElement frameworkElement = rAQgK289wQu(item, 16.0);
			frameworkElement.Opacity = 0.8;
			tabItem.Header = frameworkElement;
			tabItem.Tag = item;
			if (!string.IsNullOrEmpty(qPBgKjd8FI3.FontColor))
			{
				tabItem.Foreground = qPBgKjd8FI3.FontBrush;
			}
			System.Windows.Controls.ScrollViewer scrollViewer = new System.Windows.Controls.ScrollViewer();
			ContentControl contentControl = new ContentControl();
			contentControl.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
			scrollViewer.Content = contentControl;
			Q3fgKNkqJXF(contentControl, item.Children, item);
			tabItem.Content = scrollViewer;
			tabControl.Items.Add(tabItem);
		}
		if (!string.IsNullOrEmpty(qPBgKjd8FI3.SelectGroup))
		{
			FqSgmzXTqve(tabControl);
		}
		else
		{
			if (string.IsNullOrEmpty(qPBgKjd8FI3.PanelState?.CurrentGroup))
			{
				return;
			}
			foreach (System.Windows.Controls.TabItem item2 in (IEnumerable)tabControl.Items)
			{
				if (string.Equals(I30gKYknPuX(item2.Tag as CommonOperationItem), qPBgKjd8FI3.PanelState.CurrentGroup))
				{
					item2.IsSelected = true;
					break;
				}
			}
		}
	}

	private void FqSgmzXTqve(System.Windows.Controls.TabControl tabControl_0)
	{
		foreach (System.Windows.Controls.TabItem item in (IEnumerable)tabControl_0.Items)
		{
			if (string.Equals((item.Tag as CommonOperationItem)?.Title, qPBgKjd8FI3.SelectGroup))
			{
				item.IsSelected = true;
				break;
			}
		}
	}

	private void klYgKwUAlU4(object sender, SelectionChangedEventArgs e)
	{
		System.Windows.Controls.TabControl tabControl = (System.Windows.Controls.TabControl)sender;
		System.Windows.Controls.ScrollViewer scrollViewer = (System.Windows.Controls.ScrollViewer)tabControl.Template.FindName("headerPanelWrapper", tabControl);
		if (scrollViewer == null || scrollViewer.ExtentHeight <= scrollViewer.ViewportHeight)
		{
			return;
		}
		double num = tabControl.SelectedIndex;
		int num2 = 0;
		if (!qtYlm7Q7Z73g5G1dSOxS())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (tabControl.Items.Count > 1)
		{
			double val = num * (scrollViewer.ScrollableHeight / (double)(tabControl.Items.Count - 1));
			val = Math.Min(val, scrollViewer.ScrollableHeight);
			scrollViewer.ScrollToVerticalOffset(val);
		}
	}

	private void jGZgKtT7mJe(List<CommonOperationItem> list_0)
	{
		twsgKA0LnpE = new List<Expander>();
		StackPanel stackPanel = new StackPanel();
		stackPanel.Orientation = System.Windows.Controls.Orientation.Vertical;
		System.Windows.Media.Brush brush = null;
		System.Windows.Media.Brush brush2 = System.Windows.Media.Color.FromArgb(5, 0, 0, 0).GetBrush();
		if (!string.IsNullOrEmpty(qPBgKjd8FI3.BackgroundColor))
		{
			try
			{
				if ((double)ColorHelper.StringToWinformColor(qPBgKjd8FI3.BackgroundColor).GetBrightness() < 0.3)
				{
					brush = System.Windows.Media.Color.FromArgb(32, byte.MaxValue, byte.MaxValue, byte.MaxValue).GetBrush();
					brush2 = System.Windows.Media.Color.FromArgb(16, byte.MaxValue, byte.MaxValue, byte.MaxValue).GetBrush();
				}
				else
				{
					brush = System.Windows.Media.Color.FromArgb(32, 0, 0, 0).GetBrush();
					brush2 = System.Windows.Media.Color.FromArgb(16, 0, 0, 0).GetBrush();
				}
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("背景颜色格式不正确：" + qPBgKjd8FI3.BackgroundColor);
			}
		}
		System.Windows.Media.Brush brush3 = null;
		if (!string.IsNullOrEmpty(qPBgKjd8FI3.FontColor))
		{
			brush3 = qPBgKjd8FI3.FontBrush;
		}
		foreach (CommonOperationItem item in list_0)
		{
			if (!item.IsSeparator)
			{
				Expander expander = new Expander();
				expander.Tag = item;
				expander.BorderThickness = new Thickness(0.0);
				expander.Margin = new Thickness(0.0, 0.0, 0.0, 10.0);
				if (brush != null)
				{
					expander.Background = brush;
				}
				FrameworkElement frameworkElement = rAQgK289wQu(item, 16.0, FontWeights.Bold);
				frameworkElement.Opacity = 0.8;
				expander.Header = frameworkElement;
				if (brush3 != null)
				{
					expander.Foreground = brush3;
				}
				ContentControl contentControl = new ContentControl();
				contentControl.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				Q3fgKNkqJXF(contentControl, item.Children, item);
				Border border = new Border
				{
					BorderThickness = new Thickness(0.0),
					Background = brush2,
					CornerRadius = new CornerRadius(0.0, 0.0, 4.0, 4.0)
				};
				border.Child = contentControl;
				border.BorderBrush = (System.Windows.Media.Brush)FindResource("BorderBrush");
				expander.Content = border;
				twsgKA0LnpE.Add(expander);
				stackPanel.Children.Add(expander);
			}
		}
		stackPanel.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
		kkbgKgF6vF0(stackPanel);
		CustomPanelState panelState = qPBgKjd8FI3.PanelState;
		if (panelState == null || !panelState.ExpandedGroups.HasData())
		{
			return;
		}
		foreach (Expander item2 in twsgKA0LnpE)
		{
			string text = I30gKYknPuX(item2.Tag as CommonOperationItem);
			if (!string.IsNullOrEmpty(text) && qPBgKjd8FI3.PanelState.ExpandedGroups.Contains(text))
			{
				item2.IsExpanded = true;
			}
		}
	}

	private void kkbgKgF6vF0(FrameworkElement frameworkElement_0)
	{
		MainGrid.Children.Clear();
		System.Windows.Controls.ScrollViewer scrollViewer = new System.Windows.Controls.ScrollViewer();
		MainGrid.Children.Add(scrollViewer);
		scrollViewer.Content = frameworkElement_0;
	}

	private void QFBgKLUgKyW(List<CommonOperationItem> list_0)
	{
		WrapPanel wrapPanel = new WrapPanel();
		int columnCount = qPBgKjd8FI3.ColumnCount;
		qPBgKjd8FI3.ColumnCount = 1;
		foreach (CommonOperationItem item in list_0)
		{
			if (!item.IsSeparator)
			{
				StackPanel stackPanel = new StackPanel();
				stackPanel.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				stackPanel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
				FrameworkElement frameworkElement = rAQgK289wQu(item, 16.0, FontWeights.Bold);
				frameworkElement.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
				frameworkElement.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				frameworkElement.Opacity = 0.8;
				stackPanel.Children.Add(frameworkElement);
				ContentControl contentControl = new ContentControl();
				contentControl.Margin = new Thickness(0.0, 0.0, 0.0, 10.0);
				Q3fgKNkqJXF(contentControl, item.Children, item);
				stackPanel.Children.Add(contentControl);
				wrapPanel.Children.Add(stackPanel);
			}
		}
		wrapPanel.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
		kkbgKgF6vF0(wrapPanel);
		qPBgKjd8FI3.ColumnCount = columnCount;
	}

	private void o4cgKvSb8Cq(List<CommonOperationItem> list_0)
	{
		StackPanel stackPanel = new StackPanel();
		stackPanel.Orientation = System.Windows.Controls.Orientation.Vertical;
		foreach (CommonOperationItem item in list_0)
		{
			if (!item.IsSeparator)
			{
				FrameworkElement frameworkElement = rAQgK289wQu(item, 16.0, FontWeights.Bold);
				frameworkElement.Opacity = 0.8;
				stackPanel.Children.Add(frameworkElement);
				ContentControl contentControl = new ContentControl();
				contentControl.Margin = new Thickness(0.0, 0.0, 0.0, 10.0);
				stackPanel.Children.Add(contentControl);
				Q3fgKNkqJXF(contentControl, item.Children, item);
			}
		}
		stackPanel.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
		kkbgKgF6vF0(stackPanel);
	}

	private void py5gKSWM7Jr(List<CommonOperationItem> list_0)
	{
		Grid grid = new Grid();
		grid.VerticalAlignment = VerticalAlignment.Top;
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Auto)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(qPBgKjd8FI3.SpacingMargin.Left)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Star)
		});
		int num = 0;
		foreach (CommonOperationItem item in list_0)
		{
			if (!item.IsSeparator)
			{
				grid.RowDefinitions.Add(new RowDefinition());
				FrameworkElement frameworkElement = rAQgK289wQu(item, 16.0, FontWeights.Bold);
				frameworkElement.Opacity = 0.8;
				frameworkElement.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
				frameworkElement.SetValue(Grid.RowProperty, num);
				frameworkElement.SetValue(Grid.ColumnProperty, 0);
				frameworkElement.Margin = (item.IsEmptyHeader() ? new Thickness(0.0) : new Thickness(qPBgKjd8FI3.SpacingMargin.Left, qPBgKjd8FI3.SpacingMargin.Left + qPBgKjd8FI3.ButtonPadding.Top, 10.0, 0.0));
				grid.Children.Add(frameworkElement);
				ContentControl contentControl = new ContentControl();
				contentControl.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				contentControl.SetValue(Grid.RowProperty, num);
				contentControl.SetValue(Grid.ColumnProperty, 2);
				grid.Children.Add(contentControl);
				Q3fgKNkqJXF(contentControl, item.Children, item);
				num++;
			}
		}
		grid.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
		kkbgKgF6vF0(grid);
	}

	private FrameworkElement rAQgK289wQu(CommonOperationItem commonOperationItem_3, double double_3, FontWeight? nullable_0 = null)
	{
		if (commonOperationItem_3.IsEmptyHeader())
		{
			return new TextBlock();
		}
		if (string.IsNullOrEmpty(commonOperationItem_3.Icon))
		{
			TextBlock textBlock = new TextBlock();
			textBlock.Text = commonOperationItem_3.Title;
			textBlock.ToolTip = commonOperationItem_3.Description;
			if (nullable_0.HasValue)
			{
				textBlock.FontWeight = nullable_0.Value;
			}
			return textBlock;
		}
		int num = 5;
		StackPanel stackPanel = new StackPanel();
		stackPanel.Orientation = System.Windows.Controls.Orientation.Horizontal;
		stackPanel.ToolTip = commonOperationItem_3.Description;
		stackPanel.VerticalAlignment = VerticalAlignment.Top;
		if (!commonOperationItem_3.Icon.IsNullOrEmpty())
		{
			stackPanel.Children.Add(new IconControl
			{
				Icon = commonOperationItem_3.Icon,
				Width = double_3,
				Height = double_3,
				Margin = new Thickness(0.0, 0.0, (!string.IsNullOrEmpty(commonOperationItem_3.Title)) ? num : 0, 0.0)
			});
		}
		if (!string.IsNullOrEmpty(commonOperationItem_3.Title))
		{
			TextBlock textBlock2 = new TextBlock
			{
				Text = commonOperationItem_3.Title,
				VerticalAlignment = VerticalAlignment.Center
			};
			if (nullable_0.HasValue)
			{
				textBlock2.FontWeight = nullable_0.Value;
			}
			stackPanel.Children.Add(textBlock2);
		}
		return stackPanel;
	}

	private void G02gKuAPWxM(object sender, MouseWheelEventArgs e)
	{
		if (!(sender is System.Windows.Controls.TabControl tabControl))
		{
			return;
		}
		System.Windows.Controls.Primitives.TabPanel tabPanel = tabControl.FindChild<System.Windows.Controls.Primitives.TabPanel>("headerPanel");
		if (tabPanel == null || !tabPanel.IsMouseOver)
		{
			return;
		}
		if (e.Delta < 0)
		{
			if (tabControl.SelectedIndex + 1 < tabControl.Items.Count)
			{
				tabControl.SelectedItem = tabControl.Items[tabControl.SelectedIndex + 1];
			}
		}
		else if (tabControl.SelectedIndex - 1 > -1)
		{
			tabControl.SelectedItem = tabControl.Items[tabControl.SelectedIndex - 1];
			int num = 0;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void Q3fgKNkqJXF(ContentControl contentControl_0, IList<CommonOperationItem> ilist_2, CommonOperationItem commonOperationItem_3)
	{
		if (qPBgKjd8FI3.ColumnCount > 0)
		{
			UniformGrid uniformGrid = new UniformGrid();
			uniformGrid.Columns = qPBgKjd8FI3.ColumnCount;
			uniformGrid.VerticalAlignment = VerticalAlignment.Top;
			foreach (CommonOperationItem item in ilist_2)
			{
				if (!item.IsSeparator)
				{
					FrameworkElement frameworkElement = oVwgKJwv9cd(item, commonOperationItem_3);
					if (qPBgKjd8FI3.SpacingMargin.Left > 0.0 || qPBgKjd8FI3.SpacingMargin.Top > 0.0)
					{
						frameworkElement.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left / 2.0, qPBgKjd8FI3.SpacingMargin.Top / 2.0, qPBgKjd8FI3.SpacingMargin.Right / 2.0, qPBgKjd8FI3.SpacingMargin.Bottom / 2.0);
					}
					if (qPBgKjd8FI3.ColumnWidth > 1)
					{
						frameworkElement.Width = qPBgKjd8FI3.ColumnWidth;
					}
					else
					{
						frameworkElement.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
					}
					uniformGrid.Children.Add(frameworkElement);
				}
			}
			if (!(qPBgKjd8FI3.SpacingMargin.Left > 0.0) && qPBgKjd8FI3.SpacingMargin.Top <= 0.0)
			{
				contentControl_0.Content = uniformGrid;
				return;
			}
			Border border = new Border
			{
				Padding = new Thickness(qPBgKjd8FI3.SpacingMargin.Left / 2.0, qPBgKjd8FI3.SpacingMargin.Top / 2.0, qPBgKjd8FI3.SpacingMargin.Right / 2.0, qPBgKjd8FI3.SpacingMargin.Bottom / 2.0)
			};
			border.Child = uniformGrid;
			contentControl_0.Content = border;
			return;
		}
		UniformSpacingPanel uniformSpacingPanel = new UniformSpacingPanel();
		uniformSpacingPanel.ChildWrapping = VisualWrapping.Wrap;
		if (qPBgKjd8FI3.SpacingMargin.Left > 0.0 || qPBgKjd8FI3.SpacingMargin.Top > 0.0)
		{
			uniformSpacingPanel.HorizontalSpacing = qPBgKjd8FI3.SpacingMargin.Left;
			uniformSpacingPanel.VerticalSpacing = qPBgKjd8FI3.SpacingMargin.Top;
			uniformSpacingPanel.Margin = new Thickness(qPBgKjd8FI3.SpacingMargin.Left);
		}
		if (qPBgKjd8FI3.ColumnWidth == 0)
		{
			uniformSpacingPanel.SetValue(Grid.IsSharedSizeScopeProperty, true);
		}
		foreach (CommonOperationItem item2 in ilist_2)
		{
			if (item2.IsSeparator)
			{
				continue;
			}
			FrameworkElement frameworkElement2 = oVwgKJwv9cd(item2, commonOperationItem_3);
			if (qPBgKjd8FI3.ColumnWidth > 0)
			{
				if (qPBgKjd8FI3.ColumnWidth > 1)
				{
					frameworkElement2.Width = qPBgKjd8FI3.ColumnWidth;
				}
				uniformSpacingPanel.Children.Add(frameworkElement2);
				continue;
			}
			Grid grid = new Grid();
			grid.ColumnDefinitions.Add(new ColumnDefinition
			{
				Width = GridLength.Auto,
				SharedSizeGroup = "FirstColumn"
			});
			grid.RowDefinitions.Add(new RowDefinition());
			frameworkElement2.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
			grid.Children.Add(frameworkElement2);
			uniformSpacingPanel.Children.Add(grid);
		}
		contentControl_0.Content = uniformSpacingPanel;
	}

	private FrameworkElement oVwgKJwv9cd(CommonOperationItem commonOperationItem_3, CommonOperationItem commonOperationItem_4)
	{
        int num6 = default;
		if (commonOperationItem_3.Title == "[]")
		{
			return new TextBlock();
		}
		int num = 5;
		StackPanel stackPanel = new StackPanel();
		stackPanel.Orientation = System.Windows.Controls.Orientation.Horizontal;
		TextBlock textBlock = null;
		int num2 = 3;
		if (qtYlm7Q7Z73g5G1dSOxS())
		{
			goto IL_003e;
		}
		goto IL_0389;
		IL_003e:
		bool? flag3 = default(bool?);
		object value6 = default(object);
		bool? flag = default(bool?);
		System.Windows.Media.Brush brush5 = default(System.Windows.Media.Brush);
		System.Windows.Media.Brush brush = default(System.Windows.Media.Brush);
		System.Windows.Controls.Button button = default(System.Windows.Controls.Button);
		object value3 = default(object);
		double num3 = default(double);
		System.Windows.Media.Brush brush2 = default(System.Windows.Media.Brush);
		System.Windows.Media.Brush brush4 = default(System.Windows.Media.Brush);
		System.Windows.Media.Brush brush3 = default(System.Windows.Media.Brush);
		object value2 = default(object);
		int num5 = default(int);
		object value7 = default(object);
		num6 = default(int);
		while (true)
		{
			bool? obj2;
			object obj;
			IDictionary<string, object> extraData;
			object value5;
			string text;
			object value8;
			switch (num2)
			{
			case 9:
				obj2 = null;
				goto IL_007a;
			case 2:
				if (flag3 == true)
				{
					try
					{
						string text2 = value6?.ToString();
						if (!string.IsNullOrEmpty(text2))
						{
							if (text2.Equals("auto", StringComparison.OrdinalIgnoreCase))
							{
								if (qtYlm7Q7Z73g5G1dSOxS())
								{
									switch (0)
									{
									}
								}
								if (flag.HasValue)
								{
									brush5 = ((!flag.Value) ? System.Windows.Media.Brushes.White : System.Windows.Media.Brushes.Black);
								}
							}
							else
							{
								brush5 = ColorHelper.StringToColor(value6.ToString()).GetBrush();
							}
						}
						else
						{
							brush5 = qPBgKjd8FI3.FontBrush;
						}
					}
					catch (Exception)
					{
					}
				}
				goto IL_02b3;
			case 8:
			{
				brush = null;
				button.HorizontalContentAlignment = qPBgKjd8FI3.HorizontalAlignment;
				flag = null;
				if (commonOperationItem_3.ExtraData == null)
				{
					goto IL_0369;
				}
				if (commonOperationItem_3.ExtraData.TryGetValue(".width", out var value))
				{
					try
					{
						button.Width = Convert.ToDouble(value);
					}
					catch (Exception)
					{
						AppHelper.ShowWarning($".width值不是合法的数字(当前值={value})。");
					}
				}
				goto case 1;
			}
			case 1:
				if (commonOperationItem_3.ExtraData.TryGetValue(".height", out value3))
				{
					num2 = 5;
					if (qtYlm7Q7Z73g5G1dSOxS())
					{
						continue;
					}
					break;
				}
				goto IL_0457;
			case 5:
				try
				{
					button.Height = Convert.ToDouble(value3);
				}
				catch (Exception)
				{
					AppHelper.ShowWarning($".height值不是合法的数字(当前值={value3})。");
				}
				goto IL_0457;
			case 3:
				num3 = 0.0;
				if (!commonOperationItem_3.Icon.IsNullOrEmpty())
				{
					num3 = qPBgKjd8FI3.ItemIconSize;
					if (commonOperationItem_3.ExtraData != null && commonOperationItem_3.ExtraData.TryGetValue(".iconSize", out var value4))
					{
						try
						{
							num3 = Convert.ToDouble(value4);
						}
						catch (Exception)
						{
							AppHelper.ShowWarning($".iconSize值不是合法的数字(当前值={value4})。");
						}
					}
					stackPanel.Children.Add(new IconControl
					{
						Icon = commonOperationItem_3.Icon,
						Width = num3,
						Height = num3,
						Margin = new Thickness(0.0, 0.0, (!string.IsNullOrEmpty(commonOperationItem_3.Title)) ? num : 0, 0.0)
					});
				}
				if (!string.IsNullOrEmpty(commonOperationItem_3.Title))
				{
					textBlock = new TextBlock
					{
						Text = commonOperationItem_3.Title,
						VerticalAlignment = VerticalAlignment.Center
					};
					stackPanel.Children.Add(textBlock);
				}
				button = new System.Windows.Controls.Button();
				button.Tag = new TagWrapper
				{
					ButtonOperationItem = commonOperationItem_3,
					GroupItem = commonOperationItem_4
				};
				goto case 7;
			case 7:
				button.Click += Av0gKy56RpE;
				button.ToolTip = commonOperationItem_3.Description;
				button.Height = double.NaN;
				button.Content = stackPanel;
				button.Padding = qPBgKjd8FI3.ButtonPadding;
				button.FontSize = qPBgKjd8FI3.ItemFontSize;
				brush2 = null;
				brush4 = null;
				brush5 = null;
				brush3 = null;
				num2 = 8;
				if (qtYlm7Q7Z73g5G1dSOxS())
				{
					continue;
				}
				break;
			case 6:
				obj = null;
				goto IL_0477;
			default:
				if (brush4 != null)
				{
					button.BorderBrush = brush4;
					num6 = 4;
				}
				goto case 4;
			case 4:
				{
					if (commonOperationItem_3.Menu.HasData() || qPBgKjd8FI3.ButtonMenuItems.HasData())
					{
						button.PreviewMouseRightButtonDown += QeLgKPBBV8m;
					}
					if (commonOperationItem_3.Children.HasData())
					{
						Grid obj3 = new Grid
						{
							ColumnDefinitions = 
							{
								new ColumnDefinition
								{
									Width = new GridLength(1.0, GridUnitType.Star)
								},
								new ColumnDefinition
								{
									Width = new GridLength(1.0, GridUnitType.Auto)
								}
							}
						};
						button.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
						button.VerticalAlignment = VerticalAlignment.Stretch;
						button.SetValue(BorderElement.CornerRadiusProperty, new CornerRadius(4.0, 0.0, 0.0, 4.0));
						obj3.Children.Add(button);
						System.Windows.Controls.Button button2 = new System.Windows.Controls.Button();
						string content = ">";
						IDictionary<string, object> extraData2 = commonOperationItem_3.ExtraData;
						if (extraData2 != null && extraData2.ContainsKey(".dropdown_text"))
						{
							content = commonOperationItem_3.ExtraData[".dropdown_text"].ToString();
						}
						button2.Content = content;
						button2.Foreground = System.Windows.Media.Brushes.LightGray;
						button2.FontSize = qPBgKjd8FI3.ItemFontSize;
						button2.Height = double.NaN;
						button2.VerticalAlignment = VerticalAlignment.Stretch;
						if (!string.IsNullOrEmpty(qPBgKjd8FI3.FontColor))
						{
							button2.Foreground = qPBgKjd8FI3.FontBrush;
						}
						if (brush2 != null)
						{
							button2.Style = button.Style;
							button2.Background = brush2;
							if (brush3 != null)
							{
								button2.SetValue(BackgroundSwitchElement.MouseHoverBackgroundProperty, brush3);
								button2.SetValue(BackgroundSwitchElement.MouseDownBackgroundProperty, brush);
							}
						}
						if (brush4 != null)
						{
							button2.BorderBrush = brush4;
						}
						button2.HorizontalContentAlignment = qPBgKjd8FI3.HorizontalAlignment;
						button2.BorderThickness = new Thickness(0.0, 1.0, 1.0, 1.0);
						button2.Tag = button.Tag;
						button2.SetValue(BorderElement.CornerRadiusProperty, new CornerRadius(0.0, 4.0, 4.0, 0.0));
						button2.Click += JrKgKCRGGu3;
						button2.SetValue(Grid.ColumnProperty, 1);
						obj3.Children.Add(button2);
						return obj3;
					}
					return button;
				}
				IL_0532:
				extraData = commonOperationItem_3.ExtraData;
				if (extraData == null)
				{
					num2 = 9;
					if (ohZp5KQ7ldMrgEIo4PBJ == null)
					{
						continue;
					}
					goto case 3;
				}
				obj2 = extraData.TryGetValue(".background", out value2);
				goto IL_007a;
				IL_0457:
				if (commonOperationItem_3.ExtraData.TryGetValue(".overflow", out value5) && textBlock != null)
				{
					if (value5 == null)
					{
						num2 = 6;
						if (qtYlm7Q7Z73g5G1dSOxS())
						{
							continue;
						}
						goto case 5;
					}
					obj = value5.ToString();
					goto IL_0477;
				}
				goto IL_0532;
				IL_007a:
				if (obj2 ?? false)
				{
					try
					{
						System.Windows.Media.Color color = ColorHelper.StringToColor(value2.ToString());
						brush2 = color.GetBrush();
						if (brush2 != null)
						{
							string resourceKey = "CustomColorButtonStyle";
							int num4 = 0;
							if (ohZp5KQ7ldMrgEIo4PBJ != null)
							{
								num4 = num5;
							}
							while (true)
							{
								switch (num4)
								{
								default:
								{
									bool flag2 = false;
									if (commonOperationItem_3.ExtraData.ContainsKey(".fixed"))
									{
										resourceKey = "FixedCustomColorButtonStyle";
										flag2 = true;
									}
									button.Style = TryFindResource(resourceKey) as Style;
									button.Padding = qPBgKjd8FI3.ButtonPadding;
									button.Background = brush2;
									button.BorderThickness = new Thickness(1.0);
									button.SetValue(BorderElement.CornerRadiusProperty, new CornerRadius(4.0));
									flag = color.IsLightColor();
									brush3 = qTXgmU9BNs5(color);
									if (!flag2)
									{
										brush = brush3;
										button.SetValue(BackgroundSwitchElement.MouseHoverBackgroundProperty, brush3);
										num4 = 1;
										if (ohZp5KQ7ldMrgEIo4PBJ == null)
										{
											continue;
										}
										goto case 1;
									}
									button.SetValue(BackgroundSwitchElement.MouseHoverBackgroundProperty, brush2);
									button.SetValue(BackgroundSwitchElement.MouseDownBackgroundProperty, brush3);
									button.BorderBrush = brush2;
									break;
								}
								case 1:
									button.SetValue(BackgroundSwitchElement.MouseDownBackgroundProperty, brush);
									button.BorderBrush = brush;
									break;
								}
								break;
							}
							brush4 = brush;
						}
					}
					catch (Exception)
					{
					}
				}
				flag3 = commonOperationItem_3.ExtraData?.TryGetValue(".foreground", out value6);
				if (flag3.HasValue)
				{
					goto case 2;
				}
				goto IL_02b3;
				IL_0477:
				text = (string)obj;
				if (!string.IsNullOrEmpty(text))
				{
					if (!double.IsNaN(button.Width))
					{
						try
						{
							textBlock.Width = Math.Max(10.0, button.Width - qPBgKjd8FI3.ButtonPadding.Left - qPBgKjd8FI3.ButtonPadding.Right - num3);
						}
						catch (Exception)
						{
						}
					}
					switch (text)
					{
					case "wrapWithOverflow":
						textBlock.TextWrapping = TextWrapping.WrapWithOverflow;
						break;
					case "ellipsis":
					case "...":
						textBlock.TextTrimming = TextTrimming.CharacterEllipsis;
						break;
					case "wrap":
						textBlock.TextWrapping = TextWrapping.Wrap;
						break;
					}
				}
				goto IL_0532;
				IL_0369:
				if (brush5 != null)
				{
					button.Foreground = brush5;
					num2 = 0;
					if (qtYlm7Q7Z73g5G1dSOxS())
					{
						continue;
					}
					break;
				}
				goto default;
				IL_02b3:
				flag3 = commonOperationItem_3.ExtraData?.TryGetValue(".bordercolor", out value7);
				if (flag3 ?? false)
				{
					try
					{
						brush4 = ColorHelper.StringToColor(value7.ToString()).GetBrush();
					}
					catch (Exception)
					{
					}
				}
				if (commonOperationItem_3.ExtraData.TryGetValue(".text-align", out value8))
				{
					switch (value8.ToString())
					{
					case "right":
						button.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Right;
						break;
					case "center":
						button.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
						break;
					case "left":
						button.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Left;
						break;
					}
				}
				goto IL_0369;
			}
			break;
		}
		goto IL_0389;
		IL_0389:
		num2 = num6;
		goto IL_003e;
	}

	private void orHgK0bCs6K(object sender, System.Windows.Input.MouseEventArgs e)
	{
		if (Mouse.LeftButton == MouseButtonState.Pressed && (sender as System.Windows.Controls.Button).Tag is CommonOperationItem commonOperationItem && string.Equals(commonOperationItem.DataType, "file"))
		{
			string[] data = new string[1] { commonOperationItem.Data };
			System.Windows.DataObject data2 = new System.Windows.DataObject(System.Windows.DataFormats.FileDrop, data);
			AppHelper.DoDragDropWrap(this, data2, System.Windows.DragDropEffects.Copy);
		}
	}

	private void JrKgKCRGGu3(object sender, RoutedEventArgs e)
	{
		e.Handled = true;
		TagWrapper tagWrapper = (sender as System.Windows.Controls.Button).Tag as TagWrapper;
		CommonOperationItem commonOperationItem = tagWrapper?.ButtonOperationItem;
		if (commonOperationItem != null && commonOperationItem.Children.HasData())
		{
			JMRgK7MYH5v(commonOperationItem, tagWrapper.GroupItem);
		}
	}

	private void QeLgKPBBV8m(object sender, MouseButtonEventArgs e)
	{
		int num = 3;
		while (true)
		{
			System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
			while (true)
			{
				if (button == null || (button.ContextMenu != null && button.ContextMenu.Items.Count != 0))
				{
					return;
				}
				TagWrapper tagWrapper = button.Tag as TagWrapper;
				CommonOperationItem commonOperationItem = tagWrapper?.ButtonOperationItem;
				System.Windows.Controls.ContextMenu contextMenu;
				int num2;
				if (commonOperationItem != null)
				{
					contextMenu = new System.Windows.Controls.ContextMenu();
					if (qPBgKjd8FI3.ItemFontSize > 0.0)
					{
						contextMenu.FontSize = qPBgKjd8FI3.ItemFontSize;
					}
					IList<CommonOperationItem> list = null;
					if (commonOperationItem.Menu.HasData())
					{
						list = commonOperationItem.Menu;
					}
					else if (qPBgKjd8FI3.ButtonMenuItems.HasData())
					{
						list = qPBgKjd8FI3.ButtonMenuItems;
					}
					if (!list.HasData())
					{
						e.Handled = true;
						num2 = 1;
						if (!qtYlm7Q7Z73g5G1dSOxS())
						{
							goto IL_016b;
						}
					}
					else
					{
						if (list.Count == 1 && list[0].Title == "=")
						{
							e.Handled = true;
							button.ContextMenu = contextMenu;
							RXigKaxYYY7(list[0], commonOperationItem, tagWrapper.GroupItem);
							return;
						}
						foreach (CommonOperationItem item in list)
						{
							BkigKEHTlWm(contextMenu.Items, item, qPBgKjd8FI3.ItemIconSize, commonOperationItem, tagWrapper.GroupItem);
						}
						reLgKWi6fWD(contextMenu);
						num2 = 0;
						if (!qtYlm7Q7Z73g5G1dSOxS())
						{
							goto IL_016b;
						}
					}
					goto IL_016f;
				}
				AppHelper.ShowWarning("按钮的操作项为空。");
				return;
				IL_016f:
				switch (num2)
				{
				case 2:
					continue;
				case 3:
					break;
				default:
					button.ContextMenu = contextMenu;
					return;
				case 1:
					return;
				}
				break;
				IL_016b:
				num2 = num;
				goto IL_016f;
			}
		}
	}

	private void BkigKEHTlWm(ItemCollection itemCollection_0, CommonOperationItem commonOperationItem_3, double double_3, CommonOperationItem commonOperationItem_4, CommonOperationItem commonOperationItem_5)
	{
		if (commonOperationItem_3.IsSeparator)
		{
			AppHelper.AddMenuSeparator(itemCollection_0);
			return;
		}
		System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, commonOperationItem_3.Title, commonOperationItem_3.Description, commonOperationItem_3.Icon, null, null, null, null, double_3);
		if (commonOperationItem_3.Children.HasData())
		{
			foreach (CommonOperationItem child in commonOperationItem_3.Children)
			{
				BkigKEHTlWm(menuItem.Items, child, double_3, commonOperationItem_4, commonOperationItem_5);
			}
			return;
		}
		menuItem.Tag = new TagWrapper
		{
			OperationItem = commonOperationItem_3,
			ButtonOperationItem = commonOperationItem_4,
			GroupItem = commonOperationItem_5
		};
		menuItem.Click += xPfgK8Cvclx;
	}

	private void Av0gKy56RpE(object sender, RoutedEventArgs e)
	{
		object tag = (sender as FrameworkElement).Tag;
		if (tag == null)
		{
			AppHelper.ShowWarning("数据项为空。");
			return;
		}
		CommonOperationItem commonOperationItem = null;
		CommonOperationItem commonOperationItem_ = null;
		TagWrapper tagWrapper = tag as TagWrapper;
		if (tagWrapper != null)
		{
			commonOperationItem = tagWrapper.ButtonOperationItem;
			commonOperationItem_ = tagWrapper.GroupItem;
			goto IL_0042;
		}
		goto IL_00ea;
		IL_00ff:
		UgtgKRem1EQ(commonOperationItem, commonOperationItem, tagWrapper?.GroupItem);
		return;
		IL_00ea:
		if (tag is CommonOperationItem commonOperationItem2)
		{
			commonOperationItem = commonOperationItem2;
			goto IL_0042;
		}
		AppHelper.ShowWarning("数据项类型不正确。");
		return;
		IL_0042:
		if (string.IsNullOrEmpty(commonOperationItem.Operation))
		{
			if (!string.IsNullOrEmpty(commonOperationItem.Data))
			{
				int num;
				if (string.IsNullOrEmpty(qPBgKjd8FI3.DefaultOperation))
				{
					num = 1;
					if (ohZp5KQ7ldMrgEIo4PBJ == null)
					{
						goto IL_00ff;
					}
				}
				else
				{
					commonOperationItem = AppHelper.Clone(commonOperationItem);
					if (qPBgKjd8FI3.DefaultOperation.Contains("="))
					{
						commonOperationItem.LoadDefaultParams(qPBgKjd8FI3.DefaultOperation);
					}
					else
					{
						commonOperationItem.Operation = qPBgKjd8FI3.DefaultOperation;
					}
					RXigKaxYYY7(commonOperationItem, null, commonOperationItem_);
					num = 2;
					if (qtYlm7Q7Z73g5G1dSOxS())
					{
						return;
					}
				}
				switch (num)
				{
				case 1:
					goto IL_00ff;
				case 2:
					return;
				}
				goto IL_00ea;
			}
			if (commonOperationItem.Children.HasData())
			{
				JMRgK7MYH5v(commonOperationItem, tagWrapper?.GroupItem);
			}
			return;
		}
		RXigKaxYYY7(commonOperationItem, null, commonOperationItem_);
	}

	private void xPfgK8Cvclx(object sender, RoutedEventArgs e)
	{
		object tag = (sender as FrameworkElement).Tag;
		if (tag == null)
		{
			AppHelper.ShowWarning("数据项为空。");
			return;
		}
		CommonOperationItem commonOperationItem = null;
		int num = 0;
		if (ohZp5KQ7ldMrgEIo4PBJ != null)
		{
			goto IL_004e;
		}
		goto IL_007c;
		IL_007c:
		CommonOperationItem commonOperationItem_ = default(CommonOperationItem);
		CommonOperationItem commonOperationItem_2 = default(CommonOperationItem);
		TagWrapper tagWrapper = default(TagWrapper);
		do
		{
			IL_007c_2:
			switch (num)
			{
			case 2:
				break;
			default:
				commonOperationItem_ = null;
				commonOperationItem_2 = null;
				tagWrapper = tag as TagWrapper;
				if (tagWrapper != null)
				{
					commonOperationItem = tagWrapper.OperationItem;
					num = 2;
					if (ohZp5KQ7ldMrgEIo4PBJ == null)
					{
						goto IL_007c_2;
					}
					goto case 1;
				}
				AppHelper.ShowWarning("菜单操作项类型不正确。");
				return;
			case 1:
				if (string.IsNullOrEmpty(commonOperationItem.Operation))
				{
					if (!string.IsNullOrEmpty(commonOperationItem.Data))
					{
						if (!string.IsNullOrEmpty(qPBgKjd8FI3.DefaultOperation))
						{
							commonOperationItem = AppHelper.Clone(commonOperationItem);
							if (qPBgKjd8FI3.DefaultOperation.Contains("="))
							{
								commonOperationItem.LoadDefaultParams(qPBgKjd8FI3.DefaultOperation);
							}
							else
							{
								commonOperationItem.Operation = qPBgKjd8FI3.DefaultOperation;
							}
							RXigKaxYYY7(commonOperationItem, commonOperationItem_, commonOperationItem_2);
						}
						else
						{
							UgtgKRem1EQ(commonOperationItem, commonOperationItem_, tagWrapper?.GroupItem);
						}
					}
					else if (commonOperationItem.Children.HasData())
					{
						JMRgK7MYH5v(commonOperationItem, tagWrapper?.GroupItem);
					}
				}
				else
				{
					RXigKaxYYY7(commonOperationItem, commonOperationItem_, commonOperationItem_2);
				}
				return;
			}
			commonOperationItem_ = tagWrapper.ButtonOperationItem;
			commonOperationItem_2 = tagWrapper.GroupItem;
			num = 1;
		}
		while (ohZp5KQ7ldMrgEIo4PBJ == null);
		goto IL_004e;
		IL_004e:
		int num2 = default(int);
		num = num2;
		goto IL_007c;
	}

	private void RXigKaxYYY7(CommonOperationItem commonOperationItem_3, CommonOperationItem commonOperationItem_4, CommonOperationItem commonOperationItem_5)
	{
		_003C_003Ec__DisplayClass101_0 _003C_003Ec__DisplayClass101_ = new _003C_003Ec__DisplayClass101_0();
		_003C_003Ec__DisplayClass101_.pKiSHa2u0gO = commonOperationItem_3;
		_003C_003Ec__DisplayClass101_.vLbSH7HJKLw = this;
		if (string.Equals(_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.Operation, "close", StringComparison.OrdinalIgnoreCase))
		{
			UgtgKRem1EQ(_003C_003Ec__DisplayClass101_.pKiSHa2u0gO, commonOperationItem_4, commonOperationItem_5);
			return;
		}
		CommonOperationItem commonOperationItem;
		int num;
		if (string.Equals(_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.Operation, "sp", StringComparison.OrdinalIgnoreCase))
		{
			if (commonOperationItem_4 == null)
			{
				commonOperationItem_4 = _003C_003Ec__DisplayClass101_.pKiSHa2u0gO;
			}
			commonOperationItem = commonOperationItem_5 ?? GetCurrentTabGroupItem();
			num = 1;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				goto IL_00b0;
			}
			goto IL_00b4;
		}
		goto IL_01ad;
		IL_01ad:
		Task.Run((Action)_003C_003Ec__DisplayClass101_.J4mSH8PSC6P);
		return;
		IL_00b0:
		int num2 = default(int);
		num = num2;
		goto IL_00b4;
		IL_00b4:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData != null)
				{
					break;
				}
				goto IL_0092;
			}
			break;
			IL_0092:
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData = new Dictionary<string, object>();
			num = 0;
			if (qtYlm7Q7Z73g5G1dSOxS())
			{
				continue;
			}
			goto IL_00b0;
		}
		if (!string.IsNullOrEmpty(commonOperationItem?.Title))
		{
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_group"] = commonOperationItem?.Title;
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_groupData"] = commonOperationItem?.Data;
		}
		_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_handle"] = WindowHelper.GetHandle(this);
		if (commonOperationItem_4 != null)
		{
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_buttonItemData"] = commonOperationItem_4.Data;
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_buttonItemAll"] = commonOperationItem_4.OriginText;
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_buttonItemTitle"] = commonOperationItem_4.Title;
			_003C_003Ec__DisplayClass101_.pKiSHa2u0gO.ExtraData["_buttonItem"] = commonOperationItem_4;
		}
		goto IL_01ad;
	}

	private void JMRgK7MYH5v(CommonOperationItem commonOperationItem_3, CommonOperationItem commonOperationItem_4)
	{
		if (!commonOperationItem_3.Children.HasData())
		{
			throw new ArgumentException("item.Children.HasData() == false");
		}
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
		reLgKWi6fWD(contextMenu);
		if (qPBgKjd8FI3.ItemFontSize > 0.0)
		{
			contextMenu.FontSize = qPBgKjd8FI3.ItemFontSize;
		}
		foreach (CommonOperationItem child in commonOperationItem_3.Children)
		{
			BkigKEHTlWm(contextMenu.Items, child, qPBgKjd8FI3.ItemIconSize, commonOperationItem_3, commonOperationItem_4);
		}
		contextMenu.IsOpen = true;
	}

	private void UgtgKRem1EQ(CommonOperationItem commonOperationItem_3, CommonOperationItem commonOperationItem_4, CommonOperationItem commonOperationItem_5)
	{
		ResultData = commonOperationItem_3.Data;
		ResultItem = commonOperationItem_3;
		ResultButtonItem = commonOperationItem_4;
		ResultButtonGroupItem = commonOperationItem_5;
		Close();
	}

	private void AphgKq9sTjf(object sender, ItemEventArgs e)
	{
		_003C_003Ec__DisplayClass104_0 _003C_003Ec__DisplayClass104_ = new _003C_003Ec__DisplayClass104_0();
		_003C_003Ec__DisplayClass104_.yWISHcFnNN7 = this;
		_003C_003Ec__DisplayClass104_.rgxSHqQYBjE = e.Item;
		if (_003C_003Ec__DisplayClass104_.rgxSHqQYBjE != null && !_003C_003Ec__DisplayClass104_.rgxSHqQYBjE.Operation.IsNullOrEmpty())
		{
			Task.Run((Action)_003C_003Ec__DisplayClass104_.LpJSHRtLQVB);
		}
		else
		{
			AppHelper.ShowWarning("操作项为空或Operation属性为空。");
		}
	}

	private void peOgKcdThRe(object sender, RoutedEventArgs e)
	{
		etQgKVMVhJr();
	}

	private void etQgKVMVhJr()
	{
		IsOpen = !IsOpen;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int GetSystemParametersInfo(int uAction, int uParam, out int lpvParam, int fuWinIni);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int SetSystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);

	private void GrUgKZ0Aqs5(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void HdqgK92HHDG()
	{
		switch (base.WindowState)
		{
		case WindowState.Maximized:
			base.WindowState = WindowState.Normal;
			break;
		case WindowState.Normal:
			base.WindowState = WindowState.Maximized;
			break;
		}
	}

	private void l2LgKhd3PMx(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Middle)
		{
			if (!AppState.HHxtaMaoqJr().DisableMiddleClickCloseFloat)
			{
				Close();
			}
		}
		else if (e.ClickCount >= 2 && e.ChangedButton != MouseButton.Left && e.ChangedButton == MouseButton.Right)
		{
			Close();
		}
	}

	public void UpdateData(CustomPanelInfo info)
	{
        IList<string> expandedGroups = default;
		JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
		jsonSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
		if (string.Equals(JsonConvert.SerializeObject(info, jsonSerializerSettings), JsonConvert.SerializeObject(qPBgKjd8FI3, jsonSerializerSettings)))
		{
			return;
		}
		qPBgKjd8FI3 = info;
		base.DataContext = qPBgKjd8FI3;
		double num = 0.0;
		int selectedIndex = 0;
		System.Windows.Controls.TabControl tabControl = default(System.Windows.Controls.TabControl);
		int num2;
		if (MainGrid.Children.Count > 0)
		{
			if (MainGrid.Children[0] is System.Windows.Controls.ScrollViewer scrollViewer)
			{
				num = scrollViewer.VerticalOffset;
			}
			else
			{
				tabControl = MainGrid.Children[0] as System.Windows.Controls.TabControl;
				if (tabControl != null)
				{
					num2 = 0;
					if (qtYlm7Q7Z73g5G1dSOxS())
					{
						goto IL_00ad;
					}
					goto IL_00ee;
				}
			}
		}
		goto IL_0106;
		IL_00ad:
		selectedIndex = tabControl.SelectedIndex;
		if (tabControl.SelectedItem is System.Windows.Controls.TabItem { Content: System.Windows.Controls.ScrollViewer content })
		{
			num = content.VerticalOffset;
			num2 = 3;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				goto IL_00ee;
			}
		}
		goto IL_0106;
		IL_0106:
		expandedGroups = GetExpandedGroups();
		ox2gmlBh5Ve();
		num2 = 1;
		if (ohZp5KQ7ldMrgEIo4PBJ == null)
		{
			goto IL_00ee;
		}
		goto IL_0121;
		IL_00ee:
		switch (num2)
		{
		case 3:
			goto IL_0106;
		case 1:
			goto IL_0121;
		case 2:
			return;
		}
		goto IL_00ad;
		IL_0121:
		if (MainGrid.Children[0] is System.Windows.Controls.ScrollViewer scrollViewer2)
		{
			if (num > 0.0)
			{
				scrollViewer2.ScrollToVerticalOffset(num);
			}
		}
		else if (MainGrid.Children[0] is System.Windows.Controls.TabControl tabControl2)
		{
			if (!string.IsNullOrEmpty(qPBgKjd8FI3.SelectGroup))
			{
				FqSgmzXTqve(tabControl2);
			}
			else
			{
				tabControl2.SelectedIndex = selectedIndex;
				if (tabControl2.SelectedItem is System.Windows.Controls.TabItem tabItem2 && num > 0.0 && tabItem2.Content is System.Windows.Controls.ScrollViewer scrollViewer3)
				{
					scrollViewer3.ScrollToVerticalOffset(num);
				}
			}
		}
		if (!twsgKA0LnpE.HasData() || !expandedGroups.HasData())
		{
			return;
		}
		foreach (Expander item in twsgKA0LnpE)
		{
			string text = I30gKYknPuX(item.Tag as CommonOperationItem);
			if (!string.IsNullOrEmpty(text) && expandedGroups.Contains(text))
			{
				item.IsExpanded = true;
			}
		}
	}

	public string GetCurrentGroup()
	{
		System.Windows.Controls.TabControl tabControl = mSZgKeE69lC();
		if (tabControl == null)
		{
			return null;
		}
		if (!((tabControl.SelectedItem as System.Windows.Controls.TabItem)?.Tag is CommonOperationItem commonOperationItem_))
		{
			return null;
		}
		return I30gKYknPuX(commonOperationItem_);
	}

	private System.Windows.Controls.TabControl mSZgKeE69lC()
	{
		if (MainGrid.Children.Count <= 0)
		{
			return null;
		}
		return MainGrid.Children[0] as System.Windows.Controls.TabControl;
	}

	public string GetCurrentGroupName()
	{
		return GetCurrentTabGroupItem()?.Title;
	}

	public CommonOperationItem GetCurrentTabGroupItem()
	{
		System.Windows.Controls.TabControl tabControl = mSZgKeE69lC();
		if (tabControl == null)
		{
			return ResultButtonGroupItem;
		}
		if (!((tabControl.SelectedItem as System.Windows.Controls.TabItem)?.Tag is CommonOperationItem result))
		{
			return null;
		}
		return result;
	}

	private static string I30gKYknPuX(CommonOperationItem commonOperationItem_3)
	{
		if (commonOperationItem_3 == null)
		{
			return string.Empty;
		}
		return commonOperationItem_3.Icon + "_" + commonOperationItem_3.Title;
	}

	public IList<string> GetExpandedGroups()
	{
		if (twsgKA0LnpE.HasData())
		{
			return twsgKA0LnpE.Where(_003C_003Ec.Iu1SHPTOEgv ?? (_003C_003Ec.Iu1SHPTOEgv = _003C_003Ec.o71SHNRNXyn.xTCSHSRAng5)).Select(_003C_003Ec.nDlSHEYbkZr ?? (_003C_003Ec.nDlSHEYbkZr = _003C_003Ec.o71SHNRNXyn.uGqSH2RiDGE)).Where(_003C_003Ec.jTMSHyrZwDQ ?? (_003C_003Ec.jTMSHyrZwDQ = _003C_003Ec.o71SHNRNXyn.jcRSHuIfblL))
				.ToList();
		}
		return null;
	}

	private void xLygKIKxW3o(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void reLgKWi6fWD(System.Windows.Controls.ContextMenu contextMenu_0)
	{
		contextMenu_0.Opened += bGkgKsP81IK;
		contextMenu_0.Closed += bM4gKG7QPha;
	}

	private void za3gKkYhPVa(System.Windows.Controls.ContextMenu contextMenu_0)
	{
		contextMenu_0.Opened -= bGkgKsP81IK;
		contextMenu_0.Closed -= bM4gKG7QPha;
	}

	private void bM4gKG7QPha(object sender, RoutedEventArgs e)
	{
		IsContextMenuOpened = false;
	}

	private void bGkgKsP81IK(object sender, RoutedEventArgs e)
	{
		IsContextMenuOpened = true;
	}

	private static void dxQgKHyaN9k(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is CustomPanelWindow customPanelWindow)
		{
			customPanelWindow.NOcgK1Ii5Lw();
		}
	}

	private void NOcgK1Ii5Lw()
	{
		if (EnableBindingProcess)
		{
			string text = "";
			if (!string.IsNullOrWhiteSpace(qPBgKjd8FI3?.InitBindingProcess))
			{
				text = qPBgKjd8FI3?.InitBindingProcess;
			}
			else
			{
				text = AppState.CurrentProcessName;
				AppHelper.ShowSuccess("已关联到进程：" + text);
			}
			if (!string.IsNullOrWhiteSpace(text))
			{
				text.Trim().SplitToList(';', ',').ForEach(BindingProcess.Add);
				xRxEmRjPglWxd0qcCSF.MbstIlqq9p0().VcstIOSJLEc(this);
				int num = 0;
				if (ohZp5KQ7ldMrgEIo4PBJ != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				AppHelper.ShowWarning("待绑定的进程为空，可能程序出BUG了，请联系作者。");
			}
		}
		else
		{
			BindingProcess.Clear();
			xRxEmRjPglWxd0qcCSF.MbstIlqq9p0().GSOtIFqkrdf(this);
		}
	}

	private void hxOgKboMAdY(object sender, RoutedEventArgs e)
	{
		EnableBindingProcess = !EnableBindingProcess;
	}

	private void p3ogK6SymWO(object sender, RoutedEventArgs e)
	{
		EnableAutoCollapse = !EnableAutoCollapse;
	}

	private void aNwgKX5FFfE(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && e.ClickCount >= 2)
		{
			int customPanelWindowDbClickAction = AppState.HHxtaMaoqJr().CustomPanelWindowDbClickAction;
			if (customPanelWindowDbClickAction != 0 && customPanelWindowDbClickAction == 1)
			{
				Close();
				if (ohZp5KQ7ldMrgEIo4PBJ != null)
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				etQgKVMVhJr();
			}
		}
		else
		{
			vqagKlSDOge = false;
			gZ5gKi5IHjk = true;
			bOtgK3oZpKn = NativeMethods.GetMousePosition();
			TVqgKfdRYvw = WindowHelper.GetWindowTopLeft(this);
			FGlgKzYTgDd = Screen.FromPoint(bOtgK3oZpKn);
			WfQgxwySQac = FGlgKzYTgDd.CtdLOAvYTO3();
			CaptureMouse();
		}
	}

	private void jMmgKmNauIQ(object sender, MouseButtonEventArgs e)
	{
		vqagKlSDOge = false;
		gZ5gKi5IHjk = false;
		ReleaseMouseCapture();
	}

	private void TyYgKK2dWCN(object sender, System.Windows.Input.MouseEventArgs e)
	{
		if (e.LeftButton != MouseButtonState.Pressed || !gZ5gKi5IHjk)
		{
			return;
		}
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		if (!vqagKlSDOge && mousePosition.Distance(bOtgK3oZpKn) <= 5.0)
		{
			return;
		}
		vqagKlSDOge = true;
		int num = 1;
		if (!qtYlm7Q7Z73g5G1dSOxS())
		{
			int num2 = default(int);
			num = num2;
		}
		System.Drawing.Point tVqgKfdRYvw = default(System.Drawing.Point);
		int num3 = default(int);
		do
		{
			switch (num)
			{
			case 1:
			{
				System.Drawing.Point p = new System.Drawing.Point(mousePosition.X - bOtgK3oZpKn.X, mousePosition.Y - bOtgK3oZpKn.Y);
				tVqgKfdRYvw = TVqgKfdRYvw;
				tVqgKfdRYvw.Offset(p);
				if (FGlgKzYTgDd == null || !FGlgKzYTgDd.Bounds.Contains(mousePosition))
				{
					FGlgKzYTgDd = Screen.FromPoint(mousePosition);
					WfQgxwySQac = FGlgKzYTgDd.CtdLOAvYTO3();
				}
				goto IL_00db;
			}
			}
			break;
			IL_00db:
			num3 = (32.0 / WfQgxwySQac).ToInt();
			num = 0;
		}
		while (ohZp5KQ7ldMrgEIo4PBJ == null);
		if (tVqgKfdRYvw.Y < FGlgKzYTgDd.WorkingArea.Top - num3)
		{
			tVqgKfdRYvw.Y = FGlgKzYTgDd.WorkingArea.Top - num3;
		}
		WindowHelper.MoveTo(this, tVqgKfdRYvw, false);
	}

	private void LEKgKxad29b(object sender, MouseButtonEventArgs e)
	{
		o9tgxgaMaUp = EnableAutoCollapse;
		EnableAutoCollapse = false;
	}

	private void ofkgKrpY2ui(object sender, MouseButtonEventArgs e)
	{
		if (EnableAutoCollapse != o9tgxgaMaUp)
		{
			Task.Run((Func<Task>)LoAgKB4NJ7x);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Il0gxLLBtRt)
		{
			Il0gxLLBtRt = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/xactions/buildinrunners/ui/custompanel/custompanelwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
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
			Il0gxLLBtRt = true;
			break;
		case 7:
			MainGrid = (Grid)target;
			break;
		case 1:
		{
			TheWindow = (CustomPanelWindow)target;
			int num = 0;
			if (ohZp5KQ7ldMrgEIo4PBJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				TheWindow.MouseLeftButtonDown += aNwgKX5FFfE;
				TheWindow.MouseLeftButtonUp += jMmgKmNauIQ;
				TheWindow.MouseMove += TyYgKK2dWCN;
				TheWindow.PreviewMouseRightButtonDown += LEKgKxad29b;
				TheWindow.PreviewMouseRightButtonUp += ofkgKrpY2ui;
				break;
			}
			break;
		}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			((System.Windows.Controls.Button)target).Click += peOgKcdThRe;
			break;
		case 3:
			((System.Windows.Controls.Button)target).Click += p3ogK6SymWO;
			break;
		case 4:
			((System.Windows.Controls.Button)target).Click += hxOgKboMAdY;
			break;
		case 5:
			((System.Windows.Controls.Button)target).Click += GrUgKZ0Aqs5;
			break;
		case 6:
			((ContentPresenter)target).MouseDown += l2LgKhd3PMx;
			break;
		}
	}

	static CustomPanelWindow()
	{
		IsShowContentProperty = DependencyProperty.Register("IsShowContent", typeof(bool), typeof(CustomPanelWindow), new PropertyMetadata(true, BMZgmBF1Ito));
		IsOpenProperty = DependencyProperty.Register("IsOpen", typeof(bool), typeof(CustomPanelWindow), new PropertyMetadata(true));
		EnableAutoCollapseProperty = DependencyProperty.Register("EnableAutoCollapse", typeof(bool), typeof(CustomPanelWindow), new PropertyMetadata(false));
		ButtonBackgroundBrushProperty = DependencyProperty.Register("ButtonBackgroundBrush", typeof(System.Windows.Media.Brush), typeof(global::Quicker.Actions.XActions.BuildinRunners.UI.CustomPanelWindow), new PropertyMetadata((object)null));
		ButtonBorderBrushProperty = DependencyProperty.Register("ButtonBorderBrush", typeof(System.Windows.Media.Brush), typeof(CustomPanelWindow), new PropertyMetadata((object)null));
		ButtonHoverBrushProperty = DependencyProperty.Register("ButtonHoverBrush", typeof(System.Windows.Media.Brush), typeof(CustomPanelWindow), new PropertyMetadata((object)null));
		ButtonMouseDownBrushProperty = DependencyProperty.Register("ButtonMouseDownBrush", typeof(System.Windows.Media.Brush), typeof(CustomPanelWindow), new PropertyMetadata((object)null));
		KLFgKMu5XD6 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		TitleIconProperty = DependencyProperty.Register("TitleIcon", typeof(string), typeof(CustomPanelWindow), new PropertyMetadata((object)null));
		IsContextMenuOpenedProperty = DependencyProperty.Register("IsContextMenuOpened", typeof(bool), typeof(CustomPanelWindow), new PropertyMetadata(false));
		EnableBindingProcessProperty = DependencyProperty.Register("EnableBindingProcess", typeof(bool), typeof(CustomPanelWindow), new PropertyMetadata(false, dxQgKHyaN9k));
	}

	[CompilerGenerated]
	private void li8gKps4sHA(string string_2)
	{
		BindingProcess.Add(string_2);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CCustomPanelWindow_OnPreviewMouseRightButtonUp_003Eb__161_0_003Ed))]
	private Task LoAgKB4NJ7x()
	{
		_003C_003CCustomPanelWindow_OnPreviewMouseRightButtonUp_003Eb__161_0_003Ed stateMachine = default(_003C_003CCustomPanelWindow_OnPreviewMouseRightButtonUp_003Eb__161_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void xQZgKQNYJ18()
	{
		EnableAutoCollapse = o9tgxgaMaUp;
	}

	internal static bool qtYlm7Q7Z73g5G1dSOxS()
	{
		return ohZp5KQ7ldMrgEIo4PBJ == null;
	}
}
