using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using IPX7yRZnyyrui5B9FZ;

namespace WpfAppBar;

public class AppBarWindow : Window
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec etkvEWTnRI2;

		public static Func<MonitorInfo, bool> UE5vEk2vUoj;

		private static _003C_003Ec oJhWcTcj0JsTs6pn68Nc;

		static _003C_003Ec()
		{
			etkvEWTnRI2 = new _003C_003Ec();
		}

		internal bool OBMvEILPB0V(MonitorInfo f)
		{
			return f.IsPrimary;
		}

		internal static bool lu5ByMcj1G5qwhZu0xKn()
		{
			return oJhWcTcj0JsTs6pn68Nc == null;
		}

		internal static void UHyr7McjBFRwsjhIBrUM()
		{
		}
	}

	private bool biqJNIDIv9;

	private bool havJJ9L2Fn;

	public static readonly DependencyProperty DockModeProperty;

	public static readonly DependencyProperty MonitorProperty;

	public static readonly DependencyProperty DockedWidthOrHeightProperty;

	private static int ycVJ0PPI8q;

	private static AppBarWindow prg1dQ3WGqTFBPlXyG6;

	public AppBarDockMode DockMode
	{
		get
		{
			return (AppBarDockMode)GetValue(DockModeProperty);
		}
		set
		{
			SetValue(DockModeProperty, value);
		}
	}

	public MonitorInfo Monitor
	{
		get
		{
			return (MonitorInfo)GetValue(MonitorProperty);
		}
		set
		{
			SetValue(MonitorProperty, value);
		}
	}

	public int DockedWidthOrHeight
	{
		get
		{
			return (int)GetValue(DockedWidthOrHeightProperty);
		}
		set
		{
			SetValue(DockedWidthOrHeightProperty, value);
		}
	}

	public static int AppBarMessageId
	{
		get
		{
			if (ycVJ0PPI8q == 0)
			{
				ycVJ0PPI8q = qalNllR8qMeP2UbUj1.MIpJ7OYkZs("AppBarMessage_EEDFB5206FC3");
			}
			return ycVJ0PPI8q;
		}
	}

	static AppBarWindow()
	{
		DockModeProperty = DependencyProperty.Register("DockMode", typeof(AppBarDockMode), typeof(AppBarWindow), new FrameworkPropertyMetadata(AppBarDockMode.Left, vFDJwg5xSU));
		MonitorProperty = DependencyProperty.Register("Monitor", typeof(MonitorInfo), typeof(AppBarWindow), new FrameworkPropertyMetadata(null, vFDJwg5xSU));
		DockedWidthOrHeightProperty = DependencyProperty.Register("DockedWidthOrHeight", typeof(int), typeof(AppBarWindow), new FrameworkPropertyMetadata(200, vFDJwg5xSU, eu1N3DbX5M));
		Window.ShowInTaskbarProperty.OverrideMetadata(typeof(AppBarWindow), new FrameworkPropertyMetadata(false));
		FrameworkElement.MinHeightProperty.OverrideMetadata(typeof(AppBarWindow), new FrameworkPropertyMetadata(20.0, OCtNz877pv));
		FrameworkElement.MinWidthProperty.OverrideMetadata(typeof(AppBarWindow), new FrameworkPropertyMetadata(20.0, OCtNz877pv));
		FrameworkElement.MaxHeightProperty.OverrideMetadata(typeof(AppBarWindow), new FrameworkPropertyMetadata(OCtNz877pv));
		FrameworkElement.MaxWidthProperty.OverrideMetadata(typeof(AppBarWindow), new FrameworkPropertyMetadata(OCtNz877pv));
	}

	public AppBarWindow()
	{
		base.WindowStyle = WindowStyle.None;
		base.ResizeMode = ResizeMode.NoResize;
		base.Topmost = true;
	}

	private static object eu1N3DbX5M(DependencyObject dependencyObject_0, object object_0)
	{
		AppBarWindow appBarWindow = (AppBarWindow)dependencyObject_0;
		int int_ = (int)object_0;
		switch (appBarWindow.DockMode)
		{
		default:
			throw new NotSupportedException();
		case AppBarDockMode.Left:
		case AppBarDockMode.Right:
			return LwJNfbWPVq(int_, appBarWindow.MinWidth, appBarWindow.MaxWidth);
		case AppBarDockMode.Top:
		case AppBarDockMode.Bottom:
			return LwJNfbWPVq(int_, appBarWindow.MinHeight, appBarWindow.MaxHeight);
		}
	}

	private static int LwJNfbWPVq(int int_1, double double_0, double double_1)
	{
		if (double_0 > (double)int_1)
		{
			return (int)Math.Ceiling(double_0);
		}
		if (double_1 < (double)int_1)
		{
			return (int)Math.Floor(double_1);
		}
		return int_1;
	}

	private static void OCtNz877pv(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		dependencyObject_0.CoerceValue(DockedWidthOrHeightProperty);
	}

	private static void vFDJwg5xSU(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		AppBarWindow appBarWindow = (AppBarWindow)dependencyObject_0;
		if (appBarWindow.biqJNIDIv9)
		{
			appBarWindow.lrhJLmoqUa();
		}
	}

	protected override void OnDpiChanged(DpiScale oldDpi, DpiScale newDpi)
	{
		base.OnDpiChanged(oldDpi, newDpi);
		lrhJLmoqUa();
	}

	protected override void OnSourceInitialized(EventArgs e)
	{
		base.OnSourceInitialized(e);
		HwndSource hwndSource = (HwndSource)PresentationSource.FromVisual(this);
		if (!base.ShowInTaskbar)
		{
			ulong num = (ulong)(long)qalNllR8qMeP2UbUj1.ebXJq99Rj4(hwndSource.Handle, -20);
			num |= 0x80L;
			qalNllR8qMeP2UbUj1.ubxJZkvTMp(hwndSource.Handle, -20, (IntPtr)(long)num);
			if (!gySbYX3y2xU0JX26LaX())
			{
				switch (0)
				{
				}
			}
		}
		hwndSource.AddHook(WndProc);
		qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_ = MSMJSQDaAt();
		qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)0, ref x0Mc2AmpIjryYFa7se6_);
		biqJNIDIv9 = true;
		lrhJLmoqUa();
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		base.OnClosing(e);
		if (!e.Cancel && biqJNIDIv9)
		{
			qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_ = MSMJSQDaAt();
			qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)1, ref x0Mc2AmpIjryYFa7se6_);
			biqJNIDIv9 = false;
		}
	}

	private int SwWJt1pJ9J(double double_0)
	{
		return (int)Math.Ceiling(double_0 * VisualTreeHelper.GetDpi(this).PixelsPerDip);
	}

	private double UqyJgj7L7h(double double_0)
	{
		return double_0 / VisualTreeHelper.GetDpi(this).PixelsPerDip;
	}

	private void lrhJLmoqUa()
	{
		if (havJJ9L2Fn)
		{
			return;
		}
		qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_ = MSMJSQDaAt();
		x0Mc2AmpIjryYFa7se6_.AlIvEX3veso = (qalNllR8qMeP2UbUj1.nPsPMemzmBfsakHs52Q)K7YJvkfOhX().ViewportBounds;
		qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)2, ref x0Mc2AmpIjryYFa7se6_);
		int num = SwWJt1pJ9J(DockedWidthOrHeight);
		switch (DockMode)
		{
		default:
			throw new NotSupportedException();
		case AppBarDockMode.Left:
			x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.PUEvEQbc7IS = x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.kYlvEpsT3ds + num;
			break;
		case AppBarDockMode.Top:
			x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.Kk1vEjthAu4 = x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.K0fvEBmFjTF + num;
			break;
		case AppBarDockMode.Right:
			x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.kYlvEpsT3ds = x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.PUEvEQbc7IS - num;
			break;
		case AppBarDockMode.Bottom:
			x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.K0fvEBmFjTF = x0Mc2AmpIjryYFa7se6_.AlIvEX3veso.Kk1vEjthAu4 - num;
			break;
		}
		qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)3, ref x0Mc2AmpIjryYFa7se6_);
		havJJ9L2Fn = true;
		try
		{
			nT8J2T6RPL((Rect)x0Mc2AmpIjryYFa7se6_.AlIvEX3veso);
		}
		finally
		{
			havJJ9L2Fn = false;
		}
	}

	private MonitorInfo K7YJvkfOhX()
	{
		MonitorInfo monitorInfo = Monitor;
		IEnumerable<MonitorInfo> allMonitors = MonitorInfo.GetAllMonitors();
		if (monitorInfo == null || !allMonitors.Contains(monitorInfo))
		{
			monitorInfo = allMonitors.First(_003C_003Ec.UE5vEk2vUoj ?? (_003C_003Ec.UE5vEk2vUoj = _003C_003Ec.etkvEWTnRI2.OBMvEILPB0V));
		}
		return monitorInfo;
	}

	private qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 MSMJSQDaAt()
	{
		return new qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6
		{
			aTEvEH1v0PK = Marshal.SizeOf(typeof(qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6)),
			V7SvE1yoKVx = new WindowInteropHelper(this).Handle,
			CBCvEbvv8bA = AppBarMessageId,
			OCSvE6TG4LB = (int)DockMode
		};
	}

	public IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		int num;
		if (msg == 70 && !havJJ9L2Fn)
		{
			qalNllR8qMeP2UbUj1.KqmHpYdl5APsuA3N1oT structure = Marshal.PtrToStructure<qalNllR8qMeP2UbUj1.KqmHpYdl5APsuA3N1oT>(lParam);
			structure.TtTvEAd9Op3 |= 3;
			Marshal.StructureToPtr(structure, lParam, false);
		}
		else
		{
			if (msg != 6)
			{
				if (msg == 71)
				{
					qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_ = MSMJSQDaAt();
					qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)9, ref x0Mc2AmpIjryYFa7se6_);
					num = 1;
					if (prg1dQ3WGqTFBPlXyG6 != null)
					{
						goto IL_0089;
					}
				}
				else
				{
					if (msg != AppBarMessageId || (int)wParam != 1)
					{
						goto IL_00a4;
					}
					num = 0;
					if (prg1dQ3WGqTFBPlXyG6 != null)
					{
						goto IL_0089;
					}
				}
				goto IL_008d;
			}
			qalNllR8qMeP2UbUj1.X0Mc2AmpIjryYFa7se6 x0Mc2AmpIjryYFa7se6_2 = MSMJSQDaAt();
			qalNllR8qMeP2UbUj1.YaMJaf5uaV((qalNllR8qMeP2UbUj1.c5D173dqIrFX4ASBdh2)6, ref x0Mc2AmpIjryYFa7se6_2);
		}
		goto IL_00a4;
		IL_008d:
		switch (num)
		{
		default:
			lrhJLmoqUa();
			handled = true;
			break;
		case 1:
			break;
		}
		goto IL_00a4;
		IL_00a4:
		return IntPtr.Zero;
		IL_0089:
		int num2 = default(int);
		num = num2;
		goto IL_008d;
	}

	[SpecialName]
	private void nT8J2T6RPL(Rect value)
	{
		base.Left = UqyJgj7L7h(value.Left);
		base.Top = UqyJgj7L7h(value.Top);
		base.Width = UqyJgj7L7h(value.Width);
		base.Height = UqyJgj7L7h(value.Height);
	}

	internal static bool gySbYX3y2xU0JX26LaX()
	{
		return prg1dQ3WGqTFBPlXyG6 == null;
	}
}
