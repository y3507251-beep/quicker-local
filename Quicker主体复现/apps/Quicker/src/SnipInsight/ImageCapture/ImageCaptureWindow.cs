using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using jeaU1l2eVVj4W2gaVc;
using NwHZKfynhH8WtL1MH5;
using pew6ZbUD6AbD0tP0gJ;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using SnipInsight.Util;

namespace SnipInsight.ImageCapture;

public class ImageCaptureWindow : Window, IComponentConnector
{
	private enum IKcmARmGFxWbdlFIxWl
	{
		Center = 4
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public ImageCaptureWindow ySuvPbLFRkY;

		public System.Drawing.Rectangle wmAvP6PRqGj;

		private static _003C_003Ec__DisplayClass29_0 lNRKVgcnnyGB57wcex1e;

		internal void msIvPHWfCY8(object sender, EventArgs e)
		{
			OO77uFW4jgnwuPwqBc.J9rt4eiyvV(new WindowInteropHelper(ySuvPbLFRkY).Handle, (IntPtr)0, wmAvP6PRqGj.Left, wmAvP6PRqGj.Top, wmAvP6PRqGj.Width, wmAvP6PRqGj.Height, 0u);
		}

		internal void CbnvP1BH72G(object sender, EventArgs e)
		{
			ySuvPbLFRkY.B7ZLgvyWjT?.Dispose();
		}

		internal static bool m355vTcneKMKnHsQuluR()
		{
			return lNRKVgcnnyGB57wcex1e == null;
		}
	}

	public static RoutedCommand CaptureFullScreenCommand;

	public static RoutedCommand CaptureDoneCommand;

	public static RoutedCommand CaptureCancelCommand;

	public static RoutedCommand CaptureKeySpaceCommand;

	public static RoutedCommand CaptureKeyRightCommand;

	public static RoutedCommand CaptureKeyLeftCommand;

	public static RoutedCommand CaptureKeyUpCommand;

	public static RoutedCommand CaptureKeyDownCommand;

	[CompilerGenerated]
	private EventHandler ymyg3DYJNf;

	[CompilerGenerated]
	private EventHandler rpxgf0jkZX;

	private readonly AreaSelection t0Dgz98j3A;

	private readonly SnipInsight.Util.DpiScale tgNLw3SqYd;

	private readonly double KnlLthHhjk;

	private readonly o6aQ2X4AJ2ut4DK7be B7ZLgvyWjT;

	private bool fMrLLvviFi;

	private readonly System.Drawing.Rectangle MwNLv3U9O6;

	internal System.Windows.Shapes.Rectangle BackgroundImage;

	internal RectangleGeometry LJ2LSb7qLX;

	internal System.Windows.Shapes.Rectangle ForegroundAnts;

	internal TranslateTransform cYUL2Lofrd;

	internal Canvas MagnifierPanel;

	internal TranslateTransform IAPLuFdKdu;

	internal ScaleTransform FZvLNG6Tn1;

	internal Ellipse MagnifierCircle;

	internal VisualBrush JdVLJ8kjYo;

	internal System.Windows.Controls.Image MagnifierBackgroundImage;

	internal TextBlock MagnifierText;

	private bool ILML0CNcJE;

	internal static ImageCaptureWindow UR8ALgyYYrycy5lCPPS;

	public event EventHandler NotifyCapturingDone
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = ymyg3DYJNf;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ymyg3DYJNf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = ymyg3DYJNf;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ymyg3DYJNf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler NotifyCapturingCancel
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = rpxgf0jkZX;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref rpxgf0jkZX, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = rpxgf0jkZX;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref rpxgf0jkZX, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ImageCaptureWindow(System.Drawing.Rectangle rect, AreaSelection areaSelection)
	{
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
		_003C_003Ec__DisplayClass29_.wmAvP6PRqGj = rect;
		
		_003C_003Ec__DisplayClass29_.ySuvPbLFRkY = this;
		InitializeComponent();
		base.MouseUp += kFcgQ98VF2;
		base.MouseDown += g7Bgj7qcWU;
		base.MouseMove += HEIgnepbUB;
		base.Loaded += IghgrHa4yt;
		base.PreviewKeyDown += cMlgxQhbKt;
		tgNLw3SqYd = DpiUtilities.GetVirtualPixelScale(this);
		t0Dgz98j3A = areaSelection;
		B7ZLgvyWjT = new o6aQ2X4AJ2ut4DK7be();
		KnlLthHhjk = DpiUtilities.GetScreenScalingFactor(null);
		B7ZLgvyWjT.dieLhnbCqs(_003C_003Ec__DisplayClass29_.wmAvP6PRqGj, KnlLthHhjk);
		MwNLv3U9O6 = _003C_003Ec__DisplayClass29_.wmAvP6PRqGj;
		base.WindowStartupLocation = WindowStartupLocation.Manual;
		base.SourceInitialized += _003C_003Ec__DisplayClass29_.msIvPHWfCY8;
		BitmapSource bitmapSource = jq3gKOPRxplQoOLJZg.jirL86k2TM(B7ZLgvyWjT.JVcLI8ALKx());
		ImageBrush imageBrush = new ImageBrush(bitmapSource);
		imageBrush.TryFreeze();
		BackgroundImage.Fill = imageBrush;
		MagnifierBackgroundImage.Source = bitmapSource;
		base.Closed += _003C_003Ec__DisplayClass29_.CbnvP1BH72G;
	}

	private void cMlgxQhbKt(object sender, System.Windows.Input.KeyEventArgs e)
	{
		Key key = e.Key;
		int num;
		if (key <= Key.Escape)
		{
			num = 0;
			if (!sVPvgHy8BmmOlNyg8dl())
			{
				goto IL_00a4;
			}
		}
		else
		{
			switch (key)
			{
			case Key.A:
				kptg4bEJHP(this, null);
				goto IL_00f2;
			case Key.Space:
				AbHgFeaFFm(this, null);
				goto IL_00f2;
			case Key.Left:
			case Key.S:
				break;
			case Key.Up:
			case Key.E:
				PKCgo1pM3R(this, null);
				goto IL_00f2;
			case Key.Right:
			case Key.F:
				ypAgATpHDW(this, null);
				goto IL_00f2;
			case Key.Down:
			case Key.D:
				uQIgMQKEC7(this, null);
				goto IL_00f2;
			default:
				goto IL_00f2;
			}
			WArgODKNuA(this, null);
			num = 1;
			if (!sVPvgHy8BmmOlNyg8dl())
			{
				goto IL_00a4;
			}
		}
		goto IL_00a8;
		IL_00a4:
		int num2 = default(int);
		num = num2;
		goto IL_00a8;
		IL_00f2:
		e.Handled = true;
		return;
		IL_00a8:
		switch (num)
		{
		default:
			switch (key)
			{
			case Key.Escape:
				l3mgDi1BMc(this, null);
				break;
			case Key.Return:
				uObg5GhLIV(this, null);
				break;
			}
			break;
		case 1:
			break;
		}
		goto IL_00f2;
	}

	private void IghgrHa4yt(object sender, RoutedEventArgs e)
	{
		if (TryFindResource("animateAnts") is Storyboard storyboard)
		{
			storyboard.Begin();
		}
	}

	private BitmapSource OqwgpPO1KA()
	{
		OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_ = t0Dgz98j3A.at1gPIhG5L();
		int x = sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE + sx5yqVmkWqZQKeT9UhS_.width / 2;
		int dvlvCzBLYdL = sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS + sx5yqVmkWqZQKeT9UhS_.height / 2;
		IntPtr hMonitor = OO77uFW4jgnwuPwqBc.mNWta3fx6m(new OO77uFW4jgnwuPwqBc.IaO2hrmHFyKYyawhEpV
		{
			x = x,
			dvlvCzBLYdL = dvlvCzBLYdL
		}, 0);
		int num = 0;
		if (UR8ALgyYYrycy5lCPPS != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			ScreenProperties.MonitorInformation monitorInformation = t0Dgz98j3A.ScreenProps.GetMonitorInformation(hMonitor);
			double x2 = monitorInformation.dpiX / 96.0 / KnlLthHhjk;
			double y = monitorInformation.dpiY / 96.0 / KnlLthHhjk;
			SnipInsight.Util.DpiScale dpiScale_ = new SnipInsight.Util.DpiScale(x2, y);
			return B7ZLgvyWjT.WxVLecZvxI(sx5yqVmkWqZQKeT9UhS_, dpiScale_);
		}
		}
	}

	private (Bitmap capturedImage, System.Drawing.Rectangle rect) ocbgByfla1()
	{
		OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_ = t0Dgz98j3A.at1gPIhG5L();
		int x = sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE + sx5yqVmkWqZQKeT9UhS_.width / 2;
		int dvlvCzBLYdL = sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS + sx5yqVmkWqZQKeT9UhS_.height / 2;
		IntPtr hMonitor = OO77uFW4jgnwuPwqBc.mNWta3fx6m(new OO77uFW4jgnwuPwqBc.IaO2hrmHFyKYyawhEpV
		{
			x = x,
			dvlvCzBLYdL = dvlvCzBLYdL
		}, 0);
		ScreenProperties.MonitorInformation monitorInformation = t0Dgz98j3A.ScreenProps.GetMonitorInformation(hMonitor);
		double x2 = monitorInformation.dpiX / 96.0 / KnlLthHhjk;
		double y = monitorInformation.dpiY / 96.0 / KnlLthHhjk;
		SnipInsight.Util.DpiScale dpiScale_ = new SnipInsight.Util.DpiScale(x2, y);
		return (capturedImage: B7ZLgvyWjT.kxGLYKQneA(sx5yqVmkWqZQKeT9UhS_, dpiScale_), rect: new System.Drawing.Rectangle(sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE, sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS, sx5yqVmkWqZQKeT9UhS_.width, sx5yqVmkWqZQKeT9UhS_.height));
	}

	private void kFcgQ98VF2(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Right)
		{
			rpxgf0jkZX?.Invoke(this, null);
			return;
		}
		t0Dgz98j3A.EndDragging();
		var (image, rect) = ocbgByfla1();
		ymyg3DYJNf?.Invoke(this, new ImageCaptureEventArgs(image, rect));
	}

	private void g7Bgj7qcWU(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton != MouseButton.Right)
		{
			System.Windows.Point position = Mouse.GetPosition(this);
			System.Windows.Point point = PointToScreen(position);
			t0Dgz98j3A.StartDragging((int)point.X, (int)point.Y);
		}
	}

	private void HEIgnepbUB(object sender, System.Windows.Input.MouseEventArgs e)
	{
		System.Windows.Point position = Mouse.GetPosition(this);
		System.Windows.Point point = PointToScreen(position);
		t0Dgz98j3A.Dragging((int)point.X, (int)point.Y);
		OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_ = t0Dgz98j3A.at1gPIhG5L();
		s6TgU48Or7(sx5yqVmkWqZQKeT9UhS_);
		double num = MagnifierCircle.ActualWidth / 2.0;
		double num2 = (num - 1.0) / 2.0;
		Rect viewbox = new Rect(position.X * KnlLthHhjk - num2, position.Y * KnlLthHhjk - num2, num, num);
		JdVLJ8kjYo.Viewbox = viewbox;
		int num3 = sx5yqVmkWqZQKeT9UhS_.DhUvPSLdZXQ - sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE;
		int num4 = 0;
		if (!sVPvgHy8BmmOlNyg8dl())
		{
			int num5 = default(int);
			num4 = num5;
		}
		switch (num4)
		{
		}
		int num6 = sx5yqVmkWqZQKeT9UhS_.dPwvP2kZV1u - sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS;
		MagnifierText.Text = $"{num3} x {num6}";
		TmygiO8bC6(position);
		MagnifierPanel.Visibility = Visibility.Visible;
	}

	internal void kptg4bEJHP(object sender, ExecutedRoutedEventArgs e)
	{
		if (ymyg3DYJNf != null)
		{
			ymyg3DYJNf(this, new ImageCaptureEventArgs(B7ZLgvyWjT.JVcLI8ALKx(), MwNLv3U9O6));
		}
	}

	internal void uObg5GhLIV(object sender, ExecutedRoutedEventArgs e)
	{
		try
		{
			var (image, rect) = ocbgByfla1();
			if (ymyg3DYJNf != null)
			{
				ymyg3DYJNf(this, new ImageCaptureEventArgs(image, rect));
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("截图出错。" + ex.Message);
		}
	}

	internal void l3mgDi1BMc(object sender, ExecutedRoutedEventArgs e)
	{
		if (rpxgf0jkZX != null)
		{
			rpxgf0jkZX(this, null);
		}
	}

	[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
	private static extern bool UAogd6Qh8D(int int_0, int int_1);

	internal void PKCgo1pM3R(object sender, ExecutedRoutedEventArgs e)
	{
		System.Windows.Point position = Mouse.GetPosition(this);
		System.Windows.Point point = PointToScreen(position);
		UAogd6Qh8D((int)point.X, (int)point.Y - NOVgTakq0m());
	}

	private static int NOVgTakq0m()
	{
		if (!Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift))
		{
			return 1;
		}
		return 10;
	}

	internal void uQIgMQKEC7(object sender, ExecutedRoutedEventArgs e)
	{
		System.Windows.Point position = Mouse.GetPosition(this);
		System.Windows.Point point = PointToScreen(position);
		UAogd6Qh8D((int)point.X, (int)point.Y + NOVgTakq0m());
	}

	internal void ypAgATpHDW(object sender, ExecutedRoutedEventArgs e)
	{
		System.Windows.Point position = Mouse.GetPosition(this);
		System.Windows.Point point = PointToScreen(position);
		UAogd6Qh8D((int)point.X + NOVgTakq0m(), (int)point.Y);
	}

	internal void WArgODKNuA(object sender, ExecutedRoutedEventArgs e)
	{
		System.Windows.Point position = Mouse.GetPosition(this);
		System.Windows.Point point = PointToScreen(position);
		UAogd6Qh8D((int)point.X - NOVgTakq0m(), (int)point.Y);
	}

	internal void AbHgFeaFFm(object sender, ExecutedRoutedEventArgs e)
	{
		if (!fMrLLvviFi)
		{
			System.Windows.Point position = Mouse.GetPosition(this);
			System.Windows.Point point = PointToScreen(position);
			t0Dgz98j3A.StartDragging((int)point.X, (int)point.Y);
		}
		else
		{
			t0Dgz98j3A.EndDragging();
			var (image, rect) = ocbgByfla1();
			if (ymyg3DYJNf != null)
			{
				ymyg3DYJNf(this, new ImageCaptureEventArgs(image, rect));
				int num = 0;
				if (!sVPvgHy8BmmOlNyg8dl())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		fMrLLvviFi = !fMrLLvviFi;
	}

	private void s6TgU48Or7(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_0)
	{
		System.Windows.Point point = PointFromScreen(new System.Windows.Point(sx5yqVmkWqZQKeT9UhS_0.XD7vPLOJ5hE, sx5yqVmkWqZQKeT9UhS_0.wTivPvfjMFS));
		System.Windows.Point point2 = PointFromScreen(new System.Windows.Point(sx5yqVmkWqZQKeT9UhS_0.DhUvPSLdZXQ, sx5yqVmkWqZQKeT9UhS_0.dPwvP2kZV1u));
		LJ2LSb7qLX.Rect = new Rect(point, point2);
		ForegroundAnts.Width = point2.X - point.X;
		ForegroundAnts.Height = point2.Y - point.Y;
		cYUL2Lofrd.X = point.X;
		cYUL2Lofrd.Y = point.Y;
	}

	private IKcmARmGFxWbdlFIxWl ws1glYVwRP(out double double_1, out double double_2)
	{
		System.Drawing.Point mousePosition = System.Windows.Forms.Control.MousePosition;
		Screen screen = Screen.FromPoint(mousePosition);
		OO77uFW4jgnwuPwqBc.IaO2hrmHFyKYyawhEpV iaO2hrmHFyKYyawhEpV_ = default(OO77uFW4jgnwuPwqBc.IaO2hrmHFyKYyawhEpV);
		iaO2hrmHFyKYyawhEpV_.x = mousePosition.X;
		iaO2hrmHFyKYyawhEpV_.dvlvCzBLYdL = mousePosition.Y;
		IntPtr hMonitor = OO77uFW4jgnwuPwqBc.mNWta3fx6m(iaO2hrmHFyKYyawhEpV_, 0);
		ScreenProperties.MonitorInformation monitorInformation = t0Dgz98j3A.ScreenProps.GetMonitorInformation(hMonitor);
		double_1 = monitorInformation.dpiX / 96.0 / KnlLthHhjk;
		double_2 = monitorInformation.dpiY / 96.0 / KnlLthHhjk;
		int num = 0;
		if (!sVPvgHy8BmmOlNyg8dl())
		{
			goto IL_01ad;
		}
		goto IL_01b1;
		IL_01ad:
		int num2 = default(int);
		num = num2;
		goto IL_01b1;
		IL_01b1:
		do
		{
			switch (num)
			{
			default:
			{
				int num3 = Math.Abs(mousePosition.X - screen.Bounds.Left);
				int num4 = Math.Abs(mousePosition.Y - screen.Bounds.Top);
				bool flag = (double)num3 + 90.0 * tgNLw3SqYd.X * double_1 >= (double)screen.Bounds.Width;
				bool flag2 = (double)num3 <= 90.0 * tgNLw3SqYd.X * double_1;
				bool flag3 = (double)num4 + 102.0 * tgNLw3SqYd.Y * double_2 >= (double)screen.Bounds.Height;
				bool flag4 = (double)num4 <= 102.0 * tgNLw3SqYd.Y * double_2;
				if (!(flag && flag3))
				{
					if (!(flag2 && flag3))
					{
						if (!(flag2 && flag4))
						{
							if (!(flag && flag4))
							{
								if (flag3)
								{
									break;
								}
								if (flag4)
								{
									if (t0Dgz98j3A.DraggingRight)
									{
										return (IKcmARmGFxWbdlFIxWl)2;
									}
									return (IKcmARmGFxWbdlFIxWl)3;
								}
								if (flag2)
								{
									if (t0Dgz98j3A.DraggingDown)
									{
										return (IKcmARmGFxWbdlFIxWl)2;
									}
									return (IKcmARmGFxWbdlFIxWl)1;
								}
								if (flag)
								{
									if (t0Dgz98j3A.DraggingDown)
									{
										return (IKcmARmGFxWbdlFIxWl)3;
									}
									return (IKcmARmGFxWbdlFIxWl)0;
								}
								if (!t0Dgz98j3A.DraggingDown && t0Dgz98j3A.DraggingRight)
								{
									return (IKcmARmGFxWbdlFIxWl)2;
								}
							}
							return (IKcmARmGFxWbdlFIxWl)3;
						}
						return (IKcmARmGFxWbdlFIxWl)2;
					}
					return (IKcmARmGFxWbdlFIxWl)1;
				}
				return (IKcmARmGFxWbdlFIxWl)0;
			}
			case 1:
				if (t0Dgz98j3A.DraggingRight)
				{
					return (IKcmARmGFxWbdlFIxWl)1;
				}
				return (IKcmARmGFxWbdlFIxWl)0;
			}
			num = 1;
		}
		while (sVPvgHy8BmmOlNyg8dl());
		goto IL_01ad;
	}

	private void TmygiO8bC6(System.Windows.Point point_0)
	{
		double double_;
		double double_2;
		double x;
		double y;
		switch (ws1glYVwRP(out double_, out double_2))
		{
		default:
			throw new InvalidOperationException("invalid MagnifierPosition");
		case (IKcmARmGFxWbdlFIxWl)0:
			x = point_0.X - 90.0;
			y = point_0.Y - 102.0;
			goto IL_00ca;
		case (IKcmARmGFxWbdlFIxWl)2:
			x = point_0.X + 8.0;
			y = point_0.Y + 10.0;
			goto IL_00ca;
		case (IKcmARmGFxWbdlFIxWl)3:
			x = point_0.X - 90.0;
			y = point_0.Y + 10.0;
			goto IL_00ca;
		case IKcmARmGFxWbdlFIxWl.Center:
			x = point_0.X - 41.0;
			y = point_0.Y - 41.0;
			goto IL_00ca;
		case (IKcmARmGFxWbdlFIxWl)1:
			{
				x = point_0.X + 8.0;
				y = point_0.Y - 102.0;
				goto IL_00ca;
			}
			IL_00ca:
			IAPLuFdKdu.X = x;
			IAPLuFdKdu.Y = y;
			if (sVPvgHy8BmmOlNyg8dl())
			{
				break;
			}
			switch (0)
			{
			case 1:
				break;
			default:
				goto end_IL_000c;
			}
			goto case (IKcmARmGFxWbdlFIxWl)1;
			end_IL_000c:
			break;
		}
		FZvLNG6Tn1.CenterX = point_0.X;
		FZvLNG6Tn1.CenterY = point_0.Y;
		FZvLNG6Tn1.ScaleX = double_;
		FZvLNG6Tn1.ScaleY = double_2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ILML0CNcJE)
		{
			ILML0CNcJE = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/imagecapture/imagecapturewindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
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
			ILML0CNcJE = true;
			break;
		case 1:
			BackgroundImage = (System.Windows.Shapes.Rectangle)target;
			break;
		case 2:
			LJ2LSb7qLX = (RectangleGeometry)target;
			break;
		case 3:
			ForegroundAnts = (System.Windows.Shapes.Rectangle)target;
			break;
		case 4:
			cYUL2Lofrd = (TranslateTransform)target;
			break;
		case 5:
			MagnifierPanel = (Canvas)target;
			break;
		case 6:
			IAPLuFdKdu = (TranslateTransform)target;
			break;
		case 7:
			FZvLNG6Tn1 = (ScaleTransform)target;
			if (!sVPvgHy8BmmOlNyg8dl())
			{
				switch (0)
				{
				}
			}
			break;
		case 8:
			MagnifierCircle = (Ellipse)target;
			break;
		case 9:
			JdVLJ8kjYo = (VisualBrush)target;
			break;
		case 10:
			MagnifierBackgroundImage = (System.Windows.Controls.Image)target;
			break;
		case 11:
			MagnifierText = (TextBlock)target;
			break;
		}
	}

	static ImageCaptureWindow()
	{
		CaptureFullScreenCommand = new RoutedCommand();
		CaptureDoneCommand = new RoutedCommand();
		CaptureCancelCommand = new RoutedCommand();
		CaptureKeySpaceCommand = new RoutedCommand();
		CaptureKeyRightCommand = new RoutedCommand();
		CaptureKeyLeftCommand = new RoutedCommand();
		CaptureKeyUpCommand = new RoutedCommand();
		CaptureKeyDownCommand = new RoutedCommand();
	}

	internal static bool sVPvgHy8BmmOlNyg8dl()
	{
		return UR8ALgyYYrycy5lCPPS == null;
	}
}
