using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Quicker.Domain;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;

namespace Quicker.View;

public class ScreenPointSelectWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private System.Drawing.Point? cN8g5vDijUa;

	private Bitmap GV9g5Sl7Efk = new Bitmap(20, 20, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

	private WriteableBitmap pjvg52SQRfE = new WriteableBitmap(20, 20, 96.0, 96.0, PixelFormats.Bgr32, null);

	internal System.Windows.Controls.Image ImgPreview;

	internal System.Windows.Controls.Image ImgCross;

	internal System.Windows.Shapes.Rectangle TheRect;

	private bool CHig5u44QYI;

	internal static ScreenPointSelectWindow DyMHGaFQu1mhutquqnao;

	public System.Drawing.Point? SelectedPoint
	{
		[CompilerGenerated]
		get
		{
			return cN8g5vDijUa;
		}
		[CompilerGenerated]
		private set
		{
			cN8g5vDijUa = value;
		}
	}

	public ScreenPointSelectWindow(bool autoStart = true)
	{
		InitializeComponent();
		ImgPreview.Source = pjvg52SQRfE;
		base.Closed += mIXg5g5RYxp;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void eV5g4iNN7mB(object sender, MouseButtonEventArgs e)
	{
		YFhg433PDaW();
		ImgCross.Visibility = Visibility.Collapsed;
		ImgPreview.Visibility = Visibility.Visible;
		TheRect.Visibility = Visibility.Visible;
	}

	private void YFhg433PDaW()
	{
		vC5g4z85p0E();
		CaptureMouse();
	}

	private void nCxg4feVGnb(object sender, MouseButtonEventArgs e)
	{
		WDvg5wNv63V();
		ReleaseMouseCapture();
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		SelectedPoint = mousePosition;
		ImgCross.Visibility = Visibility.Visible;
		Close();
	}

	private void vC5g4z85p0E()
	{
		System.Windows.Input.Mouse.OverrideCursor = Cursors.Cross;
	}

	private void WDvg5wNv63V()
	{
		System.Windows.Input.Mouse.OverrideCursor = null;
	}

	private void B3Kg5t51Z1Y(object sender, MouseEventArgs e)
	{
		if (base.IsMouseCaptured)
		{
			System.Windows.Point position = e.GetPosition(this);
			position.X = base.Left + position.X;
			position.Y = base.Top + position.Y;
			base.Left = position.X + 20.0;
			base.Top = position.Y + 20.0;
			CopyScreen(NativeMethods.GetMousePosition());
		}
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

	[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
	public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int Length);

	public void CopyScreen(System.Drawing.Point location)
	{
		using (Graphics graphics = Graphics.FromImage(GV9g5Sl7Efk))
		{
			using Graphics graphics2 = Graphics.FromHwnd(IntPtr.Zero);
			IntPtr hdc = graphics2.GetHdc();
			BitBlt(graphics.GetHdc(), 0, 0, 20, 20, hdc, location.X - 10, location.Y - 10, 13369376);
			graphics.ReleaseHdc();
			graphics2.ReleaseHdc();
		}
		BitmapData bitmapData = GV9g5Sl7Efk.LockBits(new System.Drawing.Rectangle(0, 0, GV9g5Sl7Efk.Width, GV9g5Sl7Efk.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		try
		{
			pjvg52SQRfE.WritePixels(new Int32Rect(0, 0, GV9g5Sl7Efk.Width, GV9g5Sl7Efk.Height), bitmapData.Scan0, bitmapData.Stride * GV9g5Sl7Efk.Height, bitmapData.Stride);
		}
		finally
		{
			GV9g5Sl7Efk.UnlockBits(bitmapData);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!CHig5u44QYI)
		{
			CHig5u44QYI = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/screenpointselectwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			CHig5u44QYI = true;
			break;
		case 1:
			((ScreenPointSelectWindow)target).PreviewMouseDown += eV5g4iNN7mB;
			((ScreenPointSelectWindow)target).PreviewMouseMove += B3Kg5t51Z1Y;
			((ScreenPointSelectWindow)target).PreviewMouseUp += nCxg4feVGnb;
			break;
		case 2:
			ImgPreview = (System.Windows.Controls.Image)target;
			break;
		case 3:
			ImgCross = (System.Windows.Controls.Image)target;
			break;
		case 4:
		{
			TheRect = (System.Windows.Shapes.Rectangle)target;
			int num = 0;
			if (DyMHGaFQu1mhutquqnao != null)
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

	[CompilerGenerated]
	private void mIXg5g5RYxp(object sender, EventArgs e)
	{
		GV9g5Sl7Efk.Dispose();
	}

	static ScreenPointSelectWindow()
	{
	}

	internal static bool maGNmIFQo4txmW0TMTx3()
	{
		return DyMHGaFQu1mhutquqnao == null;
	}

	internal static void hvcajGFQloLPcB5i0oGh()
	{
	}
}
