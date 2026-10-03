using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using c4LBdq5YohQFUgxFYw4;
using FontAwesome5.WPF;
using HandyControl.Controls;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.View.Controls;

public class ScreenColorPickerControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public qsQtMm5MtHtoYi1dcdV i5gS3823uYc;

		internal static _003C_003Ec__DisplayClass16_0 npZf9GypgiEOH9jpknwU;

		internal void IeDS3y1clhT()
		{
			i5gS3823uYc = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
		}

		internal static bool FuqoPxypPkpwpMfETvGx()
		{
			return npZf9GypgiEOH9jpknwU == null;
		}
	}

	[CompilerGenerated]
	private EventHandler m_ValueChanged;

	[CompilerGenerated]
	private Color? uQaLjw3vSDf;

	private System.Windows.Point pLhLjtgP0rM;

	private Bitmap e8QLjgPSmk4 = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

	internal ScreenColorPickerControl TheControl;

	internal Button BtnPicker;

	internal SvgAwesome TheIcon;

	private bool I8bLjL203MC;

	private static ScreenColorPickerControl jLxJxqFbmXRdc6gPWR1r;

	public Color? Color
	{
		[CompilerGenerated]
		get
		{
			return uQaLjw3vSDf;
		}
		[CompilerGenerated]
		set
		{
			uQaLjw3vSDf = value;
		}
	}

	public Thickness ButtonPadding
	{
		get
		{
			return BtnPicker.Padding;
		}
		set
		{
			BtnPicker.Padding = value;
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)BtnPicker.GetValue(BorderElement.CornerRadiusProperty);
		}
		set
		{
			BtnPicker.SetValue(BorderElement.CornerRadiusProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ScreenColorPickerControl()
	{
		InitializeComponent();
	}

	private void hA6LQ3oqI7v(object sender, MouseButtonEventArgs e)
	{
		base.Cursor = Cursors.Cross;
		BtnPicker.CaptureMouse();
		pLhLjtgP0rM = e.GetPosition(this);
	}

	private void hQ3LQfE840s(object sender, MouseButtonEventArgs e)
	{
		BtnPicker.ReleaseMouseCapture();
		base.Cursor = Cursors.Arrow;
		if (!(e.GetPosition(this) == pLhLjtgP0rM))
		{
			System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
			Color = GetColorAt(mousePosition);
			EventHandler eventHandler = this.m_ValueChanged;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, EventArgs.Empty);
			if (KGfvkLFbsChADg4JJoto())
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
			_003C_003Ec__DisplayClass16_.i5gS3823uYc = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass16_.IeDS3y1clhT);
			if (_003C_003Ec__DisplayClass16_.i5gS3823uYc.IsSuccess)
			{
				Color = _003C_003Ec__DisplayClass16_.i5gS3823uYc.wZFmIfirit();
				this.m_ValueChanged?.Invoke(this, EventArgs.Empty);
			}
		}
	}

	private void Rx0LQzHLLOh(object sender, MouseEventArgs e)
	{
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

	public Color GetColorAt(System.Drawing.Point location)
	{
		using (Graphics graphics = Graphics.FromImage(e8QLjgPSmk4))
		{
			using Graphics graphics2 = Graphics.FromHwnd(IntPtr.Zero);
			IntPtr hdc = graphics2.GetHdc();
			BitBlt(graphics.GetHdc(), 0, 0, 1, 1, hdc, location.X, location.Y, 13369376);
			graphics.ReleaseHdc();
			graphics2.ReleaseHdc();
		}
		return e8QLjgPSmk4.GetPixel(0, 0);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!I8bLjL203MC)
		{
			I8bLjL203MC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/screencolorpickercontrol.xaml", UriKind.Relative);
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
			I8bLjL203MC = true;
			break;
		case 1:
			TheControl = (ScreenColorPickerControl)target;
			break;
		case 2:
		{
			BtnPicker = (Button)target;
			BtnPicker.PreviewMouseDown += hA6LQ3oqI7v;
			BtnPicker.PreviewMouseMove += Rx0LQzHLLOh;
			BtnPicker.PreviewMouseUp += hQ3LQfE840s;
			int num = 0;
			if (jLxJxqFbmXRdc6gPWR1r != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 3:
			TheIcon = (SvgAwesome)target;
			break;
		}
	}

	internal static bool KGfvkLFbsChADg4JJoto()
	{
		return jLxJxqFbmXRdc6gPWR1r == null;
	}
}
