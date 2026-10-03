using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using HandyControl.Tools;
using log4net;
using Microsoft.Win32;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.ContextMenus;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using SnipInsight.Util;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;
using XIhlRTAWcPOLc2pSp5w;

namespace Quicker.View;

public class ImageViewerWindow : Window, IComponentConnector, iTHRNJY2ZQQokysD4pN
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

	internal struct OstZHJurdafPM7lvPvy
	{
		internal FBS4QguIuRyxmlcDjeg NNXSpJquk75;

		internal FBS4QguIuRyxmlcDjeg jCCSp0HYG1a;

		internal FBS4QguIuRyxmlcDjeg i1cSpCU7Rb5;

		internal FBS4QguIuRyxmlcDjeg HtXSpPYurfD;

		internal FBS4QguIuRyxmlcDjeg ThlSpEVqjpT;
	}

	internal struct FBS4QguIuRyxmlcDjeg
	{
		internal int X;

		internal int Y;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bntSp8o8nyQ;

		public static EventHandler<ExceptionEventArgs> J09SpaNR1K6;

		internal static _003C_003Ec lsVangWMMoRbgTWuy9Cy;

		static _003C_003Ec()
		{
			bntSp8o8nyQ = new _003C_003Ec();
		}

		internal void JmISpytSBkC(object sender, ExceptionEventArgs e)
		{
			AppHelper.ShowWarning("图片加载失败了！");
		}

		internal static bool p4ZGNPWMUSae6ipx63OF()
		{
			return lsVangWMMoRbgTWuy9Cy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass108_0
	{
		public ImageViewerWindow uWnSpRteyvV;

		public List<SimpleOperationItem> IhPSpqJehYi;

		private static _003C_003Ec__DisplayClass108_0 SDBHqQWMIaoyYaIZp1hq;

		internal void l0qSp7AKMAL()
		{
			try
			{
				string text = TempImageBedStep.Ps7g8j76rhb(null, uWnSpRteyvV.uIcLwv3GruG());
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				foreach (SimpleOperationItem item in IhPSpqJehYi)
				{
					AppHelper.TryOpenUrlOrFile(item.Key.Replace("%s", Uri.EscapeDataString(text)));
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("搜图出错：" + exception.GetMessageWithInner());
			}
		}

		static _003C_003Ec__DisplayClass108_0()
		{
		}

		internal static bool H0qBUeWM6CUJVHB9Seea()
		{
			return SDBHqQWMIaoyYaIZp1hq == null;
		}

		internal static void qUUUT1WMS57nWJiIwYOA()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass109_0
	{
		public ImageViewerWindow YJoSpVxBN79;

		public string url;

		private static _003C_003Ec__DisplayClass109_0 PGnDafWMwCnOkeYNQhpq;

		internal void dlqSpcVxkq8()
		{
			try
			{
				string text = TempImageBedStep.Ps7g8j76rhb(null, YJoSpVxBN79.uIcLwv3GruG());
				if (!string.IsNullOrEmpty(text))
				{
					AppHelper.TryOpenUrlOrFile(url.Replace("%s", Uri.EscapeDataString(text)));
				}
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("搜图出错：" + exception.GetMessageWithInner());
			}
		}

		internal static bool vkOsq1WMTMPEWXWDqsdS()
		{
			return PGnDafWMwCnOkeYNQhpq == null;
		}
	}

	private static readonly ILog VoILwxeOZxd;

	private readonly BitmapSource H62LwrNcvPs;

	private double oULLwpKhUnO = 1.0;

	[CompilerGenerated]
	private string xemLwB5fQLt;

	private readonly DispatcherTimer KPILwQBI0tK;

	[CompilerGenerated]
	private double QKbLwjQeJb7;

	[CompilerGenerated]
	private bool De4Lwn2kRnB;

	[CompilerGenerated]
	private bool IpELw4n5fPp;

	[CompilerGenerated]
	private ShowWindowLocation x1bLw5qJB3S;

	[CompilerGenerated]
	private double EvDLwD8XR1K = 1.0;

	[CompilerGenerated]
	private double B4HLwd3EC57;

	[CompilerGenerated]
	private string RJlLwoV6uTL;

	[CompilerGenerated]
	private string ymMLwTDwIIM;

	[CompilerGenerated]
	private Bitmap KvGLwMtJhRT;

	[CompilerGenerated]
	private Rectangle IFSLwAHKHAi;

	[CompilerGenerated]
	private bool kWALwOOgq8Y;

	[CompilerGenerated]
	private bool WB0LwFMBsZn;

	private bool XcnLwU9EsRi;

	private double G1rLwlo6XiR;

	private double zfnLwiiBlTK;

	[CompilerGenerated]
	private CancellationTokenRegistration? EZxLw3GASwG;

	[CompilerGenerated]
	private string HtlLwftUGBf;

	[CompilerGenerated]
	private ActionItem Tv0Lwzwsa1H;

	[CompilerGenerated]
	private ActionExecuteContext n6cLtwSWLt3;

	public static readonly DependencyProperty ShowDropShadowProperty;

	private bool s5tLttkOveS;

	private DispatcherTimer XI6Ltgt8m5K;

	private HwndSourceHook oD1LtLOy3hv;

	private HwndSource k5XLtvt5laj;

	private Bitmap k6ELtSJposA;

	private static bool xI0Lt2CN1Of;

	private System.Windows.Point bL9LtupJvOQ;

	private IntPtr zp7LtNtwBnS;

	private string DhmLtJOsJka;

	internal ImageViewerWindow TheWindow;

	internal System.Windows.Controls.MenuItem MenuImageProcess;

	internal System.Windows.Controls.MenuItem MenuReset;

	internal System.Windows.Controls.MenuItem FlipX;

	internal System.Windows.Controls.MenuItem MenuCopyImage;

	internal System.Windows.Controls.MenuItem MenuFile;

	internal System.Windows.Controls.MenuItem MenuCopyPath;

	internal System.Windows.Controls.MenuItem MenuCopyFile;

	internal System.Windows.Controls.MenuItem MenuLocateInExplorer;

	internal System.Windows.Controls.MenuItem MenuOpenFileWithDefaultProgram;

	internal System.Windows.Controls.MenuItem MenuOpenFileWithMsPaint;

	internal System.Windows.Controls.MenuItem MenuSaveAs;

	internal System.Windows.Controls.MenuItem MenuOpenWith;

	internal System.Windows.Controls.MenuItem MenuShowTip;

	internal System.Windows.Controls.MenuItem MenuClose;

	internal Border TheBorder;

	internal System.Windows.Controls.Image TheImage;

	internal ScaleTransform Px6Lt0nJSDb;

	internal RotateTransform wYVLtCcTiQc;

	internal RotateTransform DFDLtP1OxtV;

	internal ScaleTransform FOpLtEsSF69;

	internal TextBlock TxtRatio;

	private bool aunLtyp7hsw;

	internal static ImageViewerWindow W4ApgQFXkOABAdLdEvtT;

	public string ImageFilePath
	{
		[CompilerGenerated]
		get
		{
			return xemLwB5fQLt;
		}
		[CompilerGenerated]
		set
		{
			xemLwB5fQLt = value;
		}
	}

	public double RotateDegree
	{
		[CompilerGenerated]
		get
		{
			return QKbLwjQeJb7;
		}
		[CompilerGenerated]
		set
		{
			QKbLwjQeJb7 = value;
		}
	}

	public bool IsFlipX
	{
		[CompilerGenerated]
		get
		{
			return De4Lwn2kRnB;
		}
		[CompilerGenerated]
		set
		{
			De4Lwn2kRnB = value;
		}
	}

	public bool IsFlipY
	{
		[CompilerGenerated]
		get
		{
			return IpELw4n5fPp;
		}
		[CompilerGenerated]
		set
		{
			IpELw4n5fPp = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return x1bLw5qJB3S;
		}
		[CompilerGenerated]
		set
		{
			x1bLw5qJB3S = value;
		}
	}

	public double InitialScale
	{
		[CompilerGenerated]
		get
		{
			return EvDLwD8XR1K;
		}
		[CompilerGenerated]
		set
		{
			EvDLwD8XR1K = value;
		}
	}

	public double AutoCloseSeconds
	{
		[CompilerGenerated]
		get
		{
			return B4HLwd3EC57;
		}
		[CompilerGenerated]
		set
		{
			B4HLwd3EC57 = value;
		}
	}

	public string Position
	{
		[CompilerGenerated]
		get
		{
			return RJlLwoV6uTL;
		}
		[CompilerGenerated]
		set
		{
			RJlLwoV6uTL = value;
		}
	}

	public string FinalPosition
	{
		[CompilerGenerated]
		get
		{
			return ymMLwTDwIIM;
		}
		[CompilerGenerated]
		set
		{
			ymMLwTDwIIM = value;
		}
	}

	public string AutoCloseKey
	{
		get
		{
			if (string.IsNullOrEmpty(DhmLtJOsJka))
			{
				DhmLtJOsJka = "AUTO_" + Guid.NewGuid().ToString("N");
			}
			return DhmLtJOsJka;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				DhmLtJOsJka = value;
			}
		}
	}

	public Bitmap QuickScreenShotBitmap
	{
		[CompilerGenerated]
		get
		{
			return KvGLwMtJhRT;
		}
		[CompilerGenerated]
		set
		{
			KvGLwMtJhRT = value;
		}
	}

	public Rectangle QuickScreenShotArea
	{
		[CompilerGenerated]
		get
		{
			return IFSLwAHKHAi;
		}
		[CompilerGenerated]
		set
		{
			IFSLwAHKHAi = value;
		}
	}

	public bool IsForQuickScreenShot
	{
		[CompilerGenerated]
		get
		{
			return kWALwOOgq8Y;
		}
		[CompilerGenerated]
		set
		{
			kWALwOOgq8Y = value;
		}
	}

	public bool CloseAfterLostFocus
	{
		[CompilerGenerated]
		get
		{
			return WB0LwFMBsZn;
		}
		[CompilerGenerated]
		set
		{
			WB0LwFMBsZn = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return EZxLw3GASwG;
		}
		[CompilerGenerated]
		set
		{
			EZxLw3GASwG = value;
		}
	}

	public string CloseCallbackParam
	{
		[CompilerGenerated]
		get
		{
			return HtlLwftUGBf;
		}
		[CompilerGenerated]
		set
		{
			HtlLwftUGBf = value;
		}
	}

	public ActionItem ActionItem
	{
		[CompilerGenerated]
		get
		{
			return Tv0Lwzwsa1H;
		}
		[CompilerGenerated]
		set
		{
			Tv0Lwzwsa1H = value;
		}
	}

	public ActionExecuteContext ActionContext
	{
		[CompilerGenerated]
		get
		{
			return n6cLtwSWLt3;
		}
		[CompilerGenerated]
		set
		{
			n6cLtwSWLt3 = value;
		}
	}

	public bool ShowDropShadow
	{
		get
		{
			return (bool)GetValue(ShowDropShadowProperty);
		}
		set
		{
			SetValue(ShowDropShadowProperty, value);
		}
	}

	public ImageViewerWindow(BitmapSource img)
	{
		InitializeComponent();
		H62LwrNcvPs = img;
		TheImage.Source = img;
		base.Loaded += MfhgzlffEbU;
		base.ContentRendered += ykbgz5KijLa;
		base.Closed += HJmgz3YXlaw;
		base.Deactivated += SA6Lw6vBuBV;
		base.Closing += PwPLwX2p4QV;
		KPILwQBI0tK = new DispatcherTimer();
		KPILwQBI0tK.Interval = TimeSpan.FromSeconds(0.8);
		KPILwQBI0tK.Tick += OtTgzznRX0q;
		if (img is BitmapImage && img.PixelHeight == 1 && img.PixelWidth == 1)
		{
			(img as BitmapImage).DownloadCompleted += TQGgzFfA7Gg;
			(img as BitmapImage).DownloadFailed += _003C_003Ec.J09SpaNR1K6 ?? (_003C_003Ec.J09SpaNR1K6 = _003C_003Ec.bntSp8o8nyQ.JmISpytSBkC);
		}
		base.SourceInitialized += Rh2gzTLer9A;
		base.MaxHeight = 9000.0;
		base.DpiChanged += T3FgzdZY3oe;
		base.DataContext = this;
	}

	private void ykbgz5KijLa(object sender, EventArgs e)
	{
		FjQgziX6eDu();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnPropertyChanged(e);
		if (e.Property == Window.TopmostProperty)
		{
			EpYgzD94SbP();
		}
	}

	private void EpYgzD94SbP()
	{
		Quicker.Utilities.Win32.WindowHelper.SetWindowExToolWindow(zp7LtNtwBnS, base.Topmost && !base.ShowInTaskbar);
	}

	private void T3FgzdZY3oe(object sender, System.Windows.DpiChangedEventArgs e)
	{
		if (s5tLttkOveS && base.IsLoaded)
		{
			FjQgziX6eDu();
		}
	}

	private void Oa8gzoSNMdJ()
	{
		Resize(oULLwpKhUnO);
	}

	private void Rh2gzTLer9A(object sender, EventArgs e)
	{
		zp7LtNtwBnS = new WindowInteropHelper(this).Handle;
		k5XLtvt5laj = HwndSource.FromHwnd(zp7LtNtwBnS);
		oD1LtLOy3hv = tfhgzOAtEGi;
		k5XLtvt5laj.AddHook(oD1LtLOy3hv);
		EpYgzD94SbP();
		if (AutoCloseSeconds > 0.001)
		{
			XI6Ltgt8m5K = new DispatcherTimer(TimeSpan.FromSeconds(AutoCloseSeconds), DispatcherPriority.Normal, Hd0LwmBhpIQ, Dispatcher.CurrentDispatcher);
			XI6Ltgt8m5K.Start();
		}
		int num;
		if (InitialScale < 0.0)
		{
			if (Location == ShowWindowLocation.Manual && !string.IsNullOrEmpty(Position))
			{
				InitialScale = IiSgzAvO6uL(Position);
				num = 1;
				if (W4ApgQFXkOABAdLdEvtT != null)
				{
					goto IL_00f2;
				}
			}
			else
			{
				InitialScale = r9ogzM8cBZS();
				num = 0;
				if (!RjBk79FXa3XjHv07RFcV())
				{
					goto IL_00f2;
				}
			}
			goto IL_00f6;
		}
		goto IL_0103;
		IL_00f2:
		int num2 = default(int);
		num = num2;
		goto IL_00f6;
		IL_00f6:
		switch (num)
		{
		}
		goto IL_0103;
		IL_0103:
		Resize(InitialScale, false, true);
		if (Location != ShowWindowLocation.Auto)
		{
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, Location, Position, 10.0);
			Resize(InitialScale);
		}
		MenuFile.Visibility = (string.IsNullOrEmpty(ImageFilePath) ? Visibility.Collapsed : Visibility.Visible);
		MenuOpenWith.Visibility = ((!string.IsNullOrEmpty(ImageFilePath)) ? Visibility.Collapsed : Visibility.Visible);
		s5tLttkOveS = true;
		AppState.ImageViewerWindows.Add(zp7LtNtwBnS);
		FjQgziX6eDu();
	}

	private double r9ogzM8cBZS()
	{
		if (H62LwrNcvPs.PixelWidth != 0 && H62LwrNcvPs.PixelHeight != 0)
		{
			Screen screen = Screen.FromHandle(this.GetHandle());
			int width = screen.WorkingArea.Width;
			int height = screen.WorkingArea.Height;
			return Math.Min((double)width * 1.0 / (double)H62LwrNcvPs.PixelWidth * 0.9, (double)height * 1.0 / (double)H62LwrNcvPs.PixelHeight * 0.9);
		}
		return 1.0;
	}

	private double IiSgzAvO6uL(string string_5)
	{
		int num = 1;
		while (true)
		{
			string[] array = string_5.Split(',');
			int num2 = 0;
			if (W4ApgQFXkOABAdLdEvtT != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (array.Length != 4)
			{
				AppHelper.ShowWarning("位置设置不正确：" + string_5);
				return 1.0;
			}
			if (H62LwrNcvPs.PixelWidth == 0 || H62LwrNcvPs.PixelHeight == 0)
			{
				AppHelper.ShowWarning("未知图片大小。");
				return 1.0;
			}
			if (string_5.Contains("%"))
			{
				Screen screen_ = Screen.FromHandle(this.GetHandle());
				int num3 = IHNRIiikxBwJdYmHpM3.lokvvMJSC74(screen_, array[0]);
				int num4 = IHNRIiikxBwJdYmHpM3.MLBvvADlx03(screen_, array[1]);
				double num5 = IHNRIiikxBwJdYmHpM3.lokvvMJSC74(screen_, array[2]) - num3;
				double num6 = IHNRIiikxBwJdYmHpM3.MLBvvADlx03(screen_, array[3]) - num4;
				return Math.Min(num5 * 1.0 / (double)H62LwrNcvPs.PixelWidth, num6 * 1.0 / (double)H62LwrNcvPs.PixelHeight);
			}
			int num7 = Convert.ToInt32(array[0]);
			int num8 = Convert.ToInt32(array[1]);
			int num9 = Convert.ToInt32(array[2]);
			int num10 = Convert.ToInt32(array[3]);
			double num11 = num9 - num7;
			double num12 = num10 - num8;
			return Math.Min(num11 * 1.0 / (double)H62LwrNcvPs.PixelWidth, num12 * 1.0 / (double)H62LwrNcvPs.PixelHeight);
		}
	}

	private static IntPtr tfhgzOAtEGi(IntPtr intptr_1, int int_0, IntPtr intptr_2, IntPtr intptr_3, ref bool bool_8)
	{
		if (int_0 != 36)
		{
			if (int_0 == 70)
			{
				goto IL_0057;
			}
			if (int_0 == 274 && intptr_2 == new IntPtr(61488))
			{
				bool_8 = true;
				if (!RjBk79FXa3XjHv07RFcV())
				{
					switch (0)
					{
					case 1:
						break;
					default:
						goto IL_0121;
					}
					goto IL_0057;
				}
			}
		}
		else
		{
			OstZHJurdafPM7lvPvy structure = (OstZHJurdafPM7lvPvy)Marshal.PtrToStructure(intptr_3, typeof(OstZHJurdafPM7lvPvy));
			if (structure.jCCSp0HYG1a.X > 0)
			{
				structure.jCCSp0HYG1a.X = 60000;
				structure.jCCSp0HYG1a.Y = 60000;
				structure.ThlSpEVqjpT.X = 60000;
				structure.ThlSpEVqjpT.Y = 60000;
				Marshal.StructureToPtr(structure, intptr_3, true);
			}
		}
		goto IL_0121;
		IL_0057:
		if (xI0Lt2CN1Of && System.Windows.Input.Mouse.LeftButton != MouseButtonState.Pressed && System.Windows.Input.Mouse.MiddleButton != MouseButtonState.Pressed && NativeMethods.IsWindowVisible(intptr_1))
		{
			WINDOWPOS structure2 = (WINDOWPOS)Marshal.PtrToStructure(intptr_3, typeof(WINDOWPOS));
			structure2.flags |= 2u;
			Marshal.StructureToPtr(structure2, intptr_3, false);
		}
		goto IL_0121;
		IL_0121:
		return IntPtr.Zero;
	}

	private void TQGgzFfA7Gg(object sender, EventArgs e)
	{
		try
		{
			H62LwrNcvPs.TryFreeze();
			Resize(InitialScale);
			if (Location != ShowWindowLocation.Auto)
			{
				IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, Location, Position, 10.0);
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("加载图片出错：" + exception.GetMessageWithInner());
		}
	}

	private void t4BgzU7GSEs(object sender, ExceptionRoutedEventArgs e)
	{
		AppHelper.ShowWarning("图片无法打开。" + e.ErrorException.Message);
		e.Handled = true;
		Close();
	}

	private void MfhgzlffEbU(object sender, RoutedEventArgs e)
	{
	}

	private void FjQgziX6eDu()
	{
		if (base.IsLoaded && base.WindowState == WindowState.Normal)
		{
			try
			{
				FinalPosition = FcuLw1FOEQo(this, 10.0);
			}
			catch (Exception exception)
			{
				VoILwxeOZxd.Warn("保存位置出错：" + exception.GetMessageWithInner(), exception);
			}
		}
	}

	private void HJmgz3YXlaw(object sender, EventArgs e)
	{
		KPILwQBI0tK?.Stop();
		XI6Ltgt8m5K?.Stop();
		if (AppState.ImageViewerWindows.Contains(zp7LtNtwBnS))
		{
			AppState.ImageViewerWindows.Remove(zp7LtNtwBnS);
			int num = 0;
			if (W4ApgQFXkOABAdLdEvtT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (!string.IsNullOrEmpty(CloseCallbackParam) && ActionItem != null)
		{
			Task.Run((Action)H1DLwKlHikk);
		}
	}

	private void qKpgzfUBdh0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"缩放：{oULLwpKhUnO:P0}");
		if (base.Opacity < 1.0)
		{
			stringBuilder.Append($"\n透明：{base.Opacity:P0}");
		}
		if (RotateDegree > 0.0)
		{
			stringBuilder.Append($"\n旋转：{RotateDegree}°");
		}
		if (IsFlipX || IsFlipY)
		{
			stringBuilder.Append("\n镜像：" + (IsFlipX ? "水平" : " - ") + " " + (IsFlipY ? "垂直" : " - "));
		}
		string text = stringBuilder.ToString();
		if (base.Opacity < 1.0)
		{
			goto IL_014b;
		}
		int num = 1;
		if (W4ApgQFXkOABAdLdEvtT == null)
		{
			goto IL_00fb;
		}
		goto IL_017c;
		IL_00fb:
		switch (num)
		{
		case 1:
			break;
		default:
			KPILwQBI0tK.Start();
			return;
		}
		if (!(Math.Abs(oULLwpKhUnO - 1.0) > 0.001) && RotateDegree == 0.0 && !IsFlipX && !IsFlipY)
		{
			TxtRatio.Visibility = Visibility.Collapsed;
			return;
		}
		goto IL_014b;
		IL_017c:
		int num2 = default(int);
		num = num2;
		goto IL_00fb;
		IL_014b:
		TxtRatio.Text = text;
		TxtRatio.Visibility = Visibility.Visible;
		KPILwQBI0tK.Stop();
		num = 0;
		if (RjBk79FXa3XjHv07RFcV())
		{
			goto IL_00fb;
		}
		goto IL_017c;
	}

	private void OtTgzznRX0q(object sender, EventArgs e)
	{
		TxtRatio.Visibility = Visibility.Collapsed;
		KPILwQBI0tK.Stop();
	}

	private void cGdLwwCIYdS(ItemCollection itemCollection_0)
	{
		ContentContextMenuService.BuildImageContextMenu(itemCollection_0, uZeLwLJ2Zvx, QuickScreenShotArea);
	}

	private void IE5LwtPRfQZ(List<SimpleOperationItem> list_0)
	{
		_003C_003Ec__DisplayClass108_0 _003C_003Ec__DisplayClass108_ = new _003C_003Ec__DisplayClass108_0();
		_003C_003Ec__DisplayClass108_.uWnSpRteyvV = this;
		_003C_003Ec__DisplayClass108_.IhPSpqJehYi = list_0;
		Task.Run((Action)_003C_003Ec__DisplayClass108_.l0qSp7AKMAL);
	}

	private void NKGLwgjoAhg(string string_5)
	{
		_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = new _003C_003Ec__DisplayClass109_0();
		_003C_003Ec__DisplayClass109_.YJoSpVxBN79 = this;
		_003C_003Ec__DisplayClass109_.url = string_5;
		Task.Run((Action)_003C_003Ec__DisplayClass109_.dlqSpcVxkq8);
	}

	private Bitmap uZeLwLJ2Zvx()
	{
		if (QuickScreenShotBitmap != null)
		{
			return QuickScreenShotBitmap;
		}
		QuickScreenShotBitmap = Quicker.Utilities.Images.ImageConverter.BitmapFromSource(H62LwrNcvPs);
		return QuickScreenShotBitmap;
	}

	private Bitmap uIcLwv3GruG()
	{
		if (k6ELtSJposA == null)
		{
			Bitmap bitmap = uZeLwLJ2Zvx();
			if (bitmap.Width <= 1200 && bitmap.Height <= 1200)
			{
				k6ELtSJposA = bitmap;
			}
			else
			{
				k6ELtSJposA = ImageProcessingHelper.ResizeByMaxWidthOrHeight(bitmap, 1200, 1200);
			}
		}
		return k6ELtSJposA;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int GetSystemParametersInfo(int uAction, int uParam, out int lpvParam, int fuWinIni);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	public static extern int SetSystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);

	private void MjOLwS4t1RO(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton != MouseButton.Left || e.ButtonState != MouseButtonState.Pressed)
		{
			return;
		}
		if (!Keyboard.IsKeyDown(Key.LeftCtrl) && !Keyboard.IsKeyDown(Key.RightCtrl))
		{
			int lpvParam = 0;
			try
			{
				GetSystemParametersInfo(38, 0, out lpvParam, 0);
				if (lpvParam == 0)
				{
					SetSystemParametersInfo(37, 1, 0, 0);
				}
				double left = base.Left;
				double top = base.Top;
				xI0Lt2CN1Of = true;
				DragMove();
				xI0Lt2CN1Of = false;
				if (Math.Abs(left - base.Left) > 1.0 || Math.Abs(base.Top - top) > 1.0)
				{
					Oa8gzoSNMdJ();
					FjQgziX6eDu();
				}
				return;
			}
			finally
			{
				xI0Lt2CN1Of = false;
				if (lpvParam == 0)
				{
					SetSystemParametersInfo(37, 0, 0, 0);
				}
			}
		}
		if (e.ChangedButton == MouseButton.Left)
		{
			bL9LtupJvOQ = e.GetPosition(null);
		}
	}

	private void YgMLw2JAYMA(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void XkSLwufP86W(object sender, RoutedEventArgs e)
	{
		double opacity = Convert.ToDouble((sender as System.Windows.Controls.MenuItem).Tag, CultureInfo.InvariantCulture);
		base.Opacity = opacity;
	}

	private void kssLwNFBTjK(object sender, RoutedEventArgs e)
	{
		double ratio = Convert.ToDouble((sender as System.Windows.Controls.MenuItem).Tag, CultureInfo.InvariantCulture);
		Resize(ratio, true);
	}

	private void NQvLwJm1iZU(object sender, RoutedEventArgs e)
	{
		CopyImage();
	}

	private void CopyImage()
	{
		try
		{
			ClipboardHelper.SetImage(H62LwrNcvPs, true);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("复制出错：" + ex.Message);
		}
	}

	private void LUbLw0KQknP(object sender, RoutedEventArgs e)
	{
		ClipboardHelper.SetText(ImageFilePath);
	}

	private void swoLwCBwhfA(object sender, RoutedEventArgs e)
	{
		ClipboardHelper.SetFile(ImageFilePath);
	}

	private void R0HLwPOahrL(object sender, RoutedEventArgs e)
	{
		AppHelper.SelectFileInExplorer(ImageFilePath, false);
	}

	private void LDLLwE8jfq6(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(ImageFilePath);
	}

	private void r2xLwywk14G(object sender, RoutedEventArgs e)
	{
		try
		{
			Process.Start("mspaint.exe", ImageFilePath);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("打开失败！" + ex.Message);
		}
	}

	private void oltLw8T8tPH(object sender, RoutedEventArgs e)
	{
		SiuLwaiAoLD();
	}

	private void SiuLwaiAoLD()
	{
		bool closeAfterLostFocus = CloseAfterLostFocus;
		CloseAfterLostFocus = false;
		try
		{
			Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
			string text = ".png";
			if (!string.IsNullOrEmpty(ImageFilePath))
			{
				if (!RjBk79FXa3XjHv07RFcV())
				{
					switch (0)
					{
					}
				}
				if (!ImageFilePath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						text = Path.GetExtension(ImageFilePath);
						saveFileDialog.FileName = Path.GetFileName(ImageFilePath);
					}
					catch (Exception)
					{
						text = ".png";
					}
				}
			}
			else
			{
				saveFileDialog.FileName = "Quicker" + DateTime.Now.ToString("_yyyyMMdd_HHmmss") + ".png";
			}
			saveFileDialog.DefaultExt = text;
			saveFileDialog.Filter = text + "文件|*" + text + "|所有文件|*.*";
			if (saveFileDialog.ShowDialog(this) == true)
			{
				try
				{
					string fileName = saveFileDialog.FileName;
					PHtLw7bV7Zc(fileName);
					return;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("保存图片出错！" + exception.GetMessageWithInner());
					return;
				}
			}
		}
		finally
		{
			CloseAfterLostFocus = closeAfterLostFocus;
		}
	}

	private void PHtLw7bV7Zc(string string_5)
	{
		try
		{
        char c = default;
			using FileStream stream = new FileStream(string_5, FileMode.Create);
			BitmapEncoder bitmapEncoder = null;
			string text = Path.GetExtension(string_5).ToLowerInvariant();
			int length;
			int num;
			if (text != null)
			{
				length = text.Length;
				num = 1;
				if (RjBk79FXa3XjHv07RFcV())
				{
					goto IL_0037;
				}
				goto IL_006e;
			}
			goto IL_018c;
			IL_018c:
			bitmapEncoder = new PngBitmapEncoder();
			goto IL_0193;
			IL_0037:
			c = default(char);
			if (length == 4)
			{
				c = text[1];
				if ((uint)c > 106u)
				{
					if (c != 'p')
					{
						num = 0;
						if (!RjBk79FXa3XjHv07RFcV())
						{
							int num2 = default(int);
							num = num2;
						}
						goto IL_006e;
					}
					if (text == ".png")
					{
						bitmapEncoder = new PngBitmapEncoder();
						goto IL_0193;
					}
				}
				else if (c != 'b')
				{
					if (c != 'g')
					{
						if (c == 'j' && text == ".jpg")
						{
							goto IL_013c;
						}
					}
					else if (text == ".gif")
					{
						goto IL_0183;
					}
				}
				else if (text == ".bmp")
				{
					bitmapEncoder = new BmpBitmapEncoder();
					goto IL_0193;
				}
			}
			else if (length == 5)
			{
				c = text[1];
				if (c != 'j')
				{
					if (c == 't' && text == ".tiff")
					{
						goto IL_00fe;
					}
				}
				else if (text == ".jpeg")
				{
					goto IL_013c;
				}
			}
			goto IL_018c;
			IL_006e:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0087;
			case 4:
				goto IL_0183;
			case 2:
			case 3:
				goto IL_018c;
			}
			goto IL_0037;
			IL_0087:
			if (c != 't')
			{
				if (c == 'w' && text == ".wmp")
				{
					bitmapEncoder = new WmpBitmapEncoder();
					goto IL_0193;
				}
			}
			else if (text == ".tif")
			{
				goto IL_00fe;
			}
			goto IL_018c;
			IL_0183:
			bitmapEncoder = new GifBitmapEncoder();
			goto IL_0193;
			IL_0193:
			bitmapEncoder.Frames.Add(BitmapFrame.Create(H62LwrNcvPs));
			bitmapEncoder.Save(stream);
			return;
			IL_013c:
			bitmapEncoder = new JpegBitmapEncoder();
			goto IL_0193;
			IL_00fe:
			bitmapEncoder = new TiffBitmapEncoder();
			goto IL_0193;
		}
		catch (Exception ex)
		{
			VoILwxeOZxd.Warn("保存图片出错：" + ex.Message, ex);
			AppHelper.ShowWarning("保存图片出错：" + ex.Message);
		}
	}

	private void phiLwRTylRI(object sender, RoutedEventArgs e)
	{
		IsFlipX = !IsFlipX;
		xjaLwGVEgkV(true, false);
	}

	private void iTXLwqA2Dtm(object sender, RoutedEventArgs e)
	{
		IsFlipY = !IsFlipY;
		xjaLwGVEgkV(true, false);
	}

	private void XM8LwcIXwgm(object sender, RoutedEventArgs e)
	{
		if (TheBorder.BorderThickness.Left < 0.01)
		{
			TheBorder.BorderThickness = new Thickness(1.0);
		}
		else
		{
			TheBorder.BorderThickness = new Thickness(0.0);
		}
	}

	private void GrQLwVUiSa0(object sender, RoutedEventArgs e)
	{
		double rotateDegree = Convert.ToDouble((sender as System.Windows.Controls.MenuItem).Tag, CultureInfo.InvariantCulture);
		RotateDegree = rotateDegree;
		xjaLwGVEgkV(true, true);
	}

	private void h3eLwZuhxNp(object sender, RoutedEventArgs e)
	{
		string messageBoxText = "滚轮：调整缩放比例\r\nShift+滚轮：微调图片尺寸\r\nCtrl+滚轮：调整透明度\r\nAlt+滚轮：旋转；\r\n中键单击：恢复视图；\r\n左键双击：关闭图片；\r\nCtrl+拖动图片：保存到桌面或目录；\r\n方向键、Shift+方向键：调整图片位置；\r\nCtrl+=/-：缩放图片；\r\nAlt+左/右：旋转图片；\r\nR：重置图片；\r\nC、Ctrl+C：复制图片；\r\nCtrl+S：另存图片；\r\n";
		MessageBoxHelper.Show(this, messageBoxText, "图片快捷操作");
	}

	private void vEoLw90fhCd(object sender, RoutedEventArgs e)
	{
		Pn0LwkHCnm2();
	}

	private void LPELwhxvpDP(object sender, MouseButtonEventArgs e)
	{
		Close();
	}

	private void EKALweANbV9(object sender, MouseWheelEventArgs e)
	{
        double num6 = default;
        System.Windows.Point position = default;
        double num5 = default;
		System.Windows.Point? point = default(System.Windows.Point?);
		System.Windows.Point? point2 = default(System.Windows.Point?);
		int num;
		if (!Keyboard.IsKeyDown(Key.LeftCtrl) && !Keyboard.IsKeyDown(Key.RightCtrl))
		{
			if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
			{
				point = null;
				point2 = null;
				goto IL_007d;
			}
			RotateDegree -= (double)e.Delta / 120.0 * 90.0;
			num = 2;
			if (!RjBk79FXa3XjHv07RFcV())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_01cb;
		}
		double num3 = base.Opacity + (double)e.Delta / 120.0 * 0.1;
		if (!(num3 < 0.1) && num3 <= 1.0)
		{
			base.Opacity = num3;
			qKpgzfUBdh0();
			goto IL_02dd;
		}
		return;
		IL_0185:
		double num4 = default(double);
		Resize(oULLwpKhUnO + num4);
		goto IL_0196;
		IL_007d:
		num5 = base.ActualWidth - 20.0;
		num6 = base.ActualHeight - 20.0;
		if (!TheImage.IsMouseOver)
		{
			goto IL_0122;
		}
		position = System.Windows.Input.Mouse.GetPosition(this);
		num = 1;
		if (!RjBk79FXa3XjHv07RFcV())
		{
			goto IL_00c6;
		}
		goto IL_01cb;
		IL_01f4:
		double num7 = (rf1LwYnnXJA(RotateDegree) ? G1rLwlo6XiR : zfnLwiiBlTK);
		double num8 = default(double);
		double left = point2.Value.X - point.Value.X * num8 * oULLwpKhUnO - 10.0;
		double top = point2.Value.Y - point.Value.Y * num7 * oULLwpKhUnO - 10.0;
		base.Left = left;
		base.Top = top;
		goto IL_02dd;
		IL_02dd:
		e.Handled = true;
		return;
		IL_00c6:
		point = new System.Windows.Point((position.X - 10.0) / num5, (position.Y - 10.0) / num6);
		point2 = new System.Windows.Point(base.Left + position.X, base.Top + position.Y);
		goto IL_0122;
		IL_0196:
		if (point.HasValue)
		{
			num8 = (rf1LwYnnXJA(RotateDegree) ? zfnLwiiBlTK : G1rLwlo6XiR);
			num = 0;
			if (!RjBk79FXa3XjHv07RFcV())
			{
				goto IL_01cb;
			}
			goto IL_01f4;
		}
		goto IL_02dd;
		IL_0122:
		if (!Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift))
		{
			double ratio = oULLwpKhUnO + (double)e.Delta / 120.0 * 0.1;
			Resize(ratio, true);
			goto IL_0196;
		}
		double num9 = ((e.Delta > 0) ? 1 : (-1));
		num4 = Math.Min(num9 / num5, num9 / num6);
		goto IL_0185;
		IL_01e6:
		xjaLwGVEgkV(true, true);
		goto IL_02dd;
		IL_01cb:
		switch (num)
		{
		case 4:
			break;
		case 1:
			goto IL_00c6;
		case 3:
			goto IL_0185;
		case 2:
			goto IL_01e6;
		default:
			goto IL_01f4;
		}
		goto IL_007d;
	}

	private static bool rf1LwYnnXJA(double double_6)
	{
		if (double_6 % 180.0 == 0.0)
		{
			return false;
		}
		if (double_6 % 90.0 == 0.0)
		{
			return true;
		}
		return false;
	}

	private void PjyLwIHvXMI(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Middle)
		{
			Pn0LwkHCnm2();
			e.Handled = true;
		}
		else if (e.ChangedButton == MouseButton.Right && MenuImageProcess.Items.Count == 0)
		{
			cGdLwwCIYdS(MenuImageProcess.Items);
		}
	}

	private void AfaLwWdAgGk(object sender, System.Windows.Input.KeyEventArgs e)
	{
		int num = 5;
		while (true)
		{
			int num2;
			Key key;
			if (e.Key != Key.Escape)
			{
				if (!e.Key.IsEither(Key.Left, Key.Right, Key.Up, Key.Down, Key.F, Key.E, Key.S, Key.D) || (Keyboard.Modifiers != ModifierKeys.None && Keyboard.Modifiers != ModifierKeys.Shift))
				{
					if (Keyboard.Modifiers == ModifierKeys.None)
					{
						key = e.Key;
						if (key != Key.C)
						{
							if (key == Key.R)
							{
								num2 = 0;
								if (W4ApgQFXkOABAdLdEvtT != null)
								{
									goto IL_00cf;
								}
								goto IL_00f1;
							}
						}
						else
						{
							CopyImage();
						}
					}
					goto IL_00f7;
				}
				int num3 = ((Keyboard.Modifiers != ModifierKeys.Shift) ? 1 : 10);
				switch (e.Key)
				{
				case Key.Left:
				case Key.S:
					Quicker.Utilities.Win32.WindowHelper.WEZLFn7C238(zp7LtNtwBnS, -num3, 0);
					e.Handled = true;
					break;
				case Key.Up:
				case Key.E:
					Quicker.Utilities.Win32.WindowHelper.WEZLFn7C238(zp7LtNtwBnS, 0, -num3);
					e.Handled = true;
					break;
				case Key.Right:
				case Key.F:
					Quicker.Utilities.Win32.WindowHelper.WEZLFn7C238(zp7LtNtwBnS, num3, 0);
					e.Handled = true;
					break;
				case Key.Down:
				case Key.D:
					Quicker.Utilities.Win32.WindowHelper.WEZLFn7C238(zp7LtNtwBnS, 0, num3);
					e.Handled = true;
					break;
				}
				return;
			}
			goto IL_01df;
			IL_01df:
			Close();
			e.Handled = true;
			return;
			IL_00f1:
			Pn0LwkHCnm2();
			goto IL_00f7;
			IL_00f7:
			if (Keyboard.Modifiers != ModifierKeys.Control)
			{
				break;
			}
			key = e.Key;
			if (key > Key.S)
			{
				if (key != Key.OemPlus)
				{
					if (key != Key.OemMinus)
					{
						return;
					}
					Resize(oULLwpKhUnO - 0.1);
					num2 = 0;
					if (!RjBk79FXa3XjHv07RFcV())
					{
						num2 = num;
					}
					goto IL_00cf;
				}
				Resize(oULLwpKhUnO + 0.1);
				return;
			}
			switch (key)
			{
			case Key.S:
				SiuLwaiAoLD();
				break;
			case Key.C:
				CopyImage();
				break;
			}
			return;
			IL_00cf:
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 2:
				goto IL_00f7;
			case 5:
				continue;
			case 0:
				return;
			case 3:
				return;
			case 4:
				goto IL_01df;
			}
			goto IL_00f1;
		}
		if (Keyboard.Modifiers == ModifierKeys.Alt)
		{
			switch (e.SystemKey)
			{
			case Key.Right:
				RotateDegree += 90.0;
				xjaLwGVEgkV(true, false);
				break;
			case Key.Left:
				RotateDegree -= 90.0;
				xjaLwGVEgkV(true, false);
				break;
			}
		}
	}

	private void Resize(double ratio, bool showInfo = false, bool useCurrentScreenDpi = false)
	{
        double num3 = default;
		if (H62LwrNcvPs.IsDownloading)
		{
			return;
		}
		double num = 1.0;
		num = (useCurrentScreenDpi ? DpiUtilities.GetDpiScaleByPoint(NativeMethods.GetMousePosition()) : AppHelper.GetDpiScaling(this));
		if (ratio < 0.01)
		{
			ratio = 0.1;
		}
		if ((double)H62LwrNcvPs.PixelWidth * ratio < 2.0 || (ratio > 1.5 && (double)H62LwrNcvPs.PixelWidth * ratio > 6000.0) || (double)H62LwrNcvPs.PixelHeight * ratio < 2.0)
		{
			return;
		}
		int num2;
		if (ratio > 1.5 && (double)H62LwrNcvPs.PixelHeight * ratio > 6000.0)
		{
			num2 = 1;
			if (RjBk79FXa3XjHv07RFcV())
			{
				goto IL_0121;
			}
			goto IL_014b;
		}
		oULLwpKhUnO = ratio;
		num3 = (double)H62LwrNcvPs.PixelWidth * num;
		double num4 = (double)H62LwrNcvPs.PixelHeight * num;
		if (double.IsInfinity(num3) || double.IsInfinity(num4) || double.IsNaN(num3) || double.IsNaN(num4))
		{
			goto IL_0134;
		}
		goto IL_0155;
		IL_014b:
		num4 = 100.0;
		goto IL_0155;
		IL_0134:
		num3 = 100.0;
		num2 = 0;
		if (RjBk79FXa3XjHv07RFcV())
		{
			goto IL_0121;
		}
		goto IL_014b;
		IL_0121:
		switch (num2)
		{
		case 2:
			break;
		default:
			goto IL_014b;
		case 1:
			return;
		}
		goto IL_0134;
		IL_0155:
		if (Math.Abs(G1rLwlo6XiR - num3) > 1E-06)
		{
			G1rLwlo6XiR = num3;
			zfnLwiiBlTK = num4;
			TheImage.Width = num3;
			TheImage.Height = num4;
		}
		xjaLwGVEgkV(false);
		UpdateLayout();
		if (showInfo)
		{
			qKpgzfUBdh0();
		}
	}

	private void Pn0LwkHCnm2()
	{
		Resize(1.0);
		base.Opacity = 1.0;
		RotateDegree = 0.0;
		IsFlipY = false;
		IsFlipX = false;
		if (W4ApgQFXkOABAdLdEvtT != null)
		{
			switch (0)
			{
			}
		}
		xjaLwGVEgkV(true, true);
		qKpgzfUBdh0();
		if (base.Top < SystemParameters.WorkArea.Top)
		{
			base.Top = SystemParameters.WorkArea.Top + 100.0;
			UpdateLayout();
		}
		if (!string.IsNullOrEmpty(Position))
		{
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, Location, Position, 10.0);
		}
	}

	private void xjaLwGVEgkV(bool bool_8 = true, bool bool_9 = false)
	{
		double left = base.Left;
		double top = base.Top;
		double num = base.Left + base.ActualWidth / 2.0;
		double num2 = base.Top + base.ActualHeight / 2.0;
		double double_ = wYVLtCcTiQc.Angle - RotateDegree;
		TheImage.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
		wYVLtCcTiQc.Angle = RotateDegree;
		Px6Lt0nJSDb.ScaleX = oULLwpKhUnO * (double)((!IsFlipX) ? 1 : (-1));
		int num3 = 0;
		if (!RjBk79FXa3XjHv07RFcV())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		}
		Px6Lt0nJSDb.ScaleY = oULLwpKhUnO * (double)((!IsFlipY) ? 1 : (-1));
		if (bool_8)
		{
			qKpgzfUBdh0();
		}
		if (bool_9 && rf1LwYnnXJA(double_))
		{
			base.Left = num - base.ActualHeight / 2.0;
			base.Top = num2 - base.ActualWidth / 2.0;
		}
	}

	private void ihbLwsjmTMG(object sender, System.Windows.Input.MouseEventArgs e)
	{
		System.Windows.Point position = e.GetPosition(null);
		Vector vector = bL9LtupJvOQ - position;
		if (!Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			if (!RjBk79FXa3XjHv07RFcV())
			{
				switch (0)
				{
				}
			}
			if (!Keyboard.IsKeyDown(Key.RightCtrl))
			{
				return;
			}
		}
		if (e.LeftButton != MouseButtonState.Pressed || !(Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance) || !(Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance))
		{
			return;
		}
		string text = ImageFilePath;
		if (string.IsNullOrEmpty(text))
		{
			text = AppHelper.mXLLT4tZBNH(".png");
			try
			{
				PHtLw7bV7Zc(text);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法保存图片。" + ex.Message);
				return;
			}
		}
		string[] data = new string[1] { text };
		System.Windows.DataObject data2 = new System.Windows.DataObject(System.Windows.DataFormats.FileDrop, data);
		AppHelper.DoDragDropWrap(this, data2, System.Windows.DragDropEffects.Copy);
	}

	private void VpVLwHJ71hn(object sender, EventArgs e)
	{
		if (base.IsLoaded)
		{
			FjQgziX6eDu();
		}
	}

	internal static string FcuLw1FOEQo(ImageViewerWindow imageViewerWindow_0, double double_6)
	{
		double dpiScaling = AppHelper.GetDpiScaling(imageViewerWindow_0);
		NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(imageViewerWindow_0.GetHandle());
		int num = windowRect.Left + (int)(double_6 / dpiScaling);
		int num2 = windowRect.Top + (int)(double_6 / dpiScaling);
		int num3 = windowRect.Right - (int)(double_6 / dpiScaling) - 1;
		int num4 = windowRect.Bottom - (int)(double_6 / dpiScaling) - 1;
		return $"{num},{num2},{num3},{num4}";
	}

	private void jT4Lwb3xHwZ(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = Path.GetTempFileName() + ".png";
			PHtLw7bV7Zc(text);
			using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip = new zj8rqIAw38dI180QGip(text, IntPtr.Zero);
			zj8rqIAw38dI180QGip.Ec9QVm0RcX("openas");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("出错了：" + ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!aunLtyp7hsw)
		{
			aunLtyp7hsw = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/imageviewerwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			aunLtyp7hsw = true;
			break;
		case 1:
			TheWindow = (ImageViewerWindow)target;
			TheWindow.LocationChanged += VpVLwHJ71hn;
			TheWindow.MouseDoubleClick += LPELwhxvpDP;
			goto IL_05aa;
		case 2:
			MenuImageProcess = (System.Windows.Controls.MenuItem)target;
			break;
		case 3:
			MenuReset = (System.Windows.Controls.MenuItem)target;
			MenuReset.Click += vEoLw90fhCd;
			break;
		case 4:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 5:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 6:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 7:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 8:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 9:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 10:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 11:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 12:
			((System.Windows.Controls.MenuItem)target).Click += XkSLwufP86W;
			break;
		case 13:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 14:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 15:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 16:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 17:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 18:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 19:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 20:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 21:
			((System.Windows.Controls.MenuItem)target).Click += kssLwNFBTjK;
			break;
		case 22:
			((System.Windows.Controls.MenuItem)target).Click += GrQLwVUiSa0;
			break;
		case 23:
			((System.Windows.Controls.MenuItem)target).Click += GrQLwVUiSa0;
			break;
		case 24:
			((System.Windows.Controls.MenuItem)target).Click += GrQLwVUiSa0;
			break;
		case 25:
			((System.Windows.Controls.MenuItem)target).Click += GrQLwVUiSa0;
			break;
		case 26:
			FlipX = (System.Windows.Controls.MenuItem)target;
			FlipX.Click += phiLwRTylRI;
			break;
		case 27:
			((System.Windows.Controls.MenuItem)target).Click += iTXLwqA2Dtm;
			break;
		case 28:
			MenuCopyImage = (System.Windows.Controls.MenuItem)target;
			goto IL_061f;
		case 29:
			MenuFile = (System.Windows.Controls.MenuItem)target;
			break;
		case 30:
			MenuCopyPath = (System.Windows.Controls.MenuItem)target;
			MenuCopyPath.Click += LUbLw0KQknP;
			break;
		case 31:
			MenuCopyFile = (System.Windows.Controls.MenuItem)target;
			MenuCopyFile.Click += swoLwCBwhfA;
			num = 1;
			if (W4ApgQFXkOABAdLdEvtT != null)
			{
				goto IL_0583;
			}
			goto IL_0587;
		case 32:
			MenuLocateInExplorer = (System.Windows.Controls.MenuItem)target;
			MenuLocateInExplorer.Click += R0HLwPOahrL;
			num = 6;
			if (W4ApgQFXkOABAdLdEvtT != null)
			{
				break;
			}
			goto IL_0587;
		case 33:
			MenuOpenFileWithDefaultProgram = (System.Windows.Controls.MenuItem)target;
			MenuOpenFileWithDefaultProgram.Click += LDLLwE8jfq6;
			break;
		case 34:
			MenuOpenFileWithMsPaint = (System.Windows.Controls.MenuItem)target;
			MenuOpenFileWithMsPaint.Click += r2xLwywk14G;
			break;
		case 35:
			MenuSaveAs = (System.Windows.Controls.MenuItem)target;
			MenuSaveAs.Click += oltLw8T8tPH;
			break;
		case 36:
			MenuOpenWith = (System.Windows.Controls.MenuItem)target;
			MenuOpenWith.Click += jT4Lwb3xHwZ;
			break;
		case 37:
			MenuShowTip = (System.Windows.Controls.MenuItem)target;
			MenuShowTip.Click += h3eLwZuhxNp;
			break;
		case 38:
			MenuClose = (System.Windows.Controls.MenuItem)target;
			MenuClose.Click += YgMLw2JAYMA;
			break;
		case 39:
			TheBorder = (Border)target;
			break;
		case 40:
			TheImage = (System.Windows.Controls.Image)target;
			TheImage.ImageFailed += t4BgzU7GSEs;
			break;
		case 41:
			Px6Lt0nJSDb = (ScaleTransform)target;
			break;
		case 42:
			wYVLtCcTiQc = (RotateTransform)target;
			break;
		case 43:
			DFDLtP1OxtV = (RotateTransform)target;
			break;
		case 44:
			FOpLtEsSF69 = (ScaleTransform)target;
			num = 0;
			if (!RjBk79FXa3XjHv07RFcV())
			{
				goto IL_0583;
			}
			goto IL_0587;
		case 45:
			{
				TxtRatio = (TextBlock)target;
				break;
			}
			IL_0583:
			num = num2;
			goto IL_0587;
			IL_0587:
			switch (num)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				break;
			case 3:
				return;
			case 4:
				goto IL_061f;
			case 5:
				return;
			case 6:
				return;
			}
			goto IL_05aa;
			IL_061f:
			MenuCopyImage.Click += NQvLwJm1iZU;
			break;
			IL_05aa:
			TheWindow.MouseDown += MjOLwS4t1RO;
			TheWindow.MouseMove += ihbLwsjmTMG;
			TheWindow.PreviewKeyDown += AfaLwWdAgGk;
			TheWindow.PreviewMouseDown += PjyLwIHvXMI;
			TheWindow.PreviewMouseWheel += EKALweANbV9;
			break;
		}
	}

	static ImageViewerWindow()
	{
		VoILwxeOZxd = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ShowDropShadowProperty = DependencyProperty.Register("ShowDropShadow", typeof(bool), typeof(ImageViewerWindow), new PropertyMetadata(true));
		xI0Lt2CN1Of = false;
	}

	[CompilerGenerated]
	private void SA6Lw6vBuBV(object sender, EventArgs e)
	{
		if (CloseAfterLostFocus && base.OwnedWindows.Count <= 0 && !XcnLwU9EsRi && base.IsLoaded)
		{
			try
			{
				Close();
			}
			catch (Exception exception)
			{
				VoILwxeOZxd.Warn("自动关闭图片窗口出错：", exception);
			}
		}
	}

	[CompilerGenerated]
	private void PwPLwX2p4QV(object sender, CancelEventArgs e)
	{
		XcnLwU9EsRi = true;
		if (XI6Ltgt8m5K != null)
		{
			XI6Ltgt8m5K.Stop();
		}
		KPILwQBI0tK?.Stop();
		TheImage.Source = null;
		if (!RjBk79FXa3XjHv07RFcV())
		{
			switch (0)
			{
			}
		}
		if (oD1LtLOy3hv != null)
		{
			k5XLtvt5laj?.RemoveHook(oD1LtLOy3hv);
		}
	}

	[CompilerGenerated]
	private void Hd0LwmBhpIQ(object sender, EventArgs e)
	{
		Close();
	}

	[CompilerGenerated]
	private void H1DLwKlHikk()
	{
		try
		{
			VoILwxeOZxd.Info("关闭图片窗口执行动作回调。动作：" + ActionItem.Title + " 参数:" + CloseCallbackParam);
			AppState.AppServer.ExecuteAction(ActionItem, -1, null, false, false, false, CloseCallbackParam, ActionTrigger.NA);
		}
		catch (Exception ex)
		{
			VoILwxeOZxd.Warn(ex.Message, ex);
			AppHelper.ShowWarning(ex.Message);
		}
	}

	internal static bool RjBk79FXa3XjHv07RFcV()
	{
		return W4ApgQFXkOABAdLdEvtT == null;
	}

	internal static void uJPc5lFXsdTv5v1cfHso()
	{
	}

	internal static void WNMmBpFXCIuJdbUGYmSB()
	{
	}
}
