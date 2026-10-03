using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using log4net;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using XAK0Gv5H9h6VY926piI;

namespace ClickShow;

public class ClickIndicator : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public double LNEvCjN0t1t;

		public System.Windows.Media.Brush RY4vCnvi0M1;

		public System.Drawing.Point ciEvC42RlbP;

		private static _003C_003Ec__DisplayClass26_0 mAiEFNcXsHZlvoCNeN9n;

		internal void ze1vCQf0oZF()
		{
			ClickIndicator clickIndicator = new ClickIndicator(LNEvCjN0t1t)
			{
				WindowStartupLocation = WindowStartupLocation.Manual,
				Topmost = true,
				ShowActivated = false
			};
			try
			{
				clickIndicator.Play(RY4vCnvi0M1, true);
				double num = 1.0 / bxlYjy5DCfnONDuA8Y4.WJmxPEK51o(ciEvC42RlbP);
				int num2 = (int)(LNEvCjN0t1t * num);
				cgkb8m33H(clickIndicator, ciEvC42RlbP.X - num2 / 2, ciEvC42RlbP.Y - num2 / 2, num2, num2);
			}
			catch (Exception ex)
			{
				AVUmGbqVH.Warn(ex.Message, ex);
			}
		}

		internal static bool TbwqpYcXC4o0qnrrhj52()
		{
			return mAiEFNcXsHZlvoCNeN9n == null;
		}
	}

	private static readonly ILog AVUmGbqVH;

	private Storyboard Ug7KVVMHc;

	private Storyboard jvsxD9TQ2;

	[CompilerGenerated]
	private int ItQrPvs8I = Environment.TickCount;

	[CompilerGenerated]
	private bool lSOpY3fwE;

	private DpiScale qAYBemtQ6;

	[CompilerGenerated]
	private bool dueQ4H86e;

	internal Ellipse TheCircle;

	private bool tbpjdfnH2;

	private static ClickIndicator VS3otkWFA9Jtg4Ed2L8;

	public int LastLiveTime
	{
		[CompilerGenerated]
		get
		{
			return ItQrPvs8I;
		}
		[CompilerGenerated]
		set
		{
			ItQrPvs8I = value;
		}
	}

	public bool IsIdle
	{
		[CompilerGenerated]
		get
		{
			return lSOpY3fwE;
		}
		[CompilerGenerated]
		private set
		{
			lSOpY3fwE = value;
		}
	}

	public bool DpiHasChanged
	{
		[CompilerGenerated]
		get
		{
			return dueQ4H86e;
		}
		[CompilerGenerated]
		private set
		{
			dueQ4H86e = value;
		}
	}

	public ClickIndicator(double size)
	{
		base.ShowActivated = false;
		InitializeComponent();
		base.Width = size;
		base.Height = size;
		base.SourceInitialized += Y0sHrCZQT;
		RenderOptions.SetBitmapScalingMode(TheCircle, BitmapScalingMode.LowQuality);
		pKDGLnobg();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void takkTFm4G()
	{
		double value = 0.3;
		jvsxD9TQ2 = new Storyboard();
		int num = 1;
		DoubleAnimation doubleAnimation3 = default(DoubleAnimation);
		if (Y93efTWcH81BSsDLCKV())
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					jvsxD9TQ2.FillBehavior = FillBehavior.Stop;
					DoubleAnimation doubleAnimation = new DoubleAnimation(base.Width / 2.0, new Duration(TimeSpan.FromSeconds(value)));
					Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Width"));
					Storyboard.SetTarget(doubleAnimation, TheCircle);
					jvsxD9TQ2.Children.Add(doubleAnimation);
					DoubleAnimation doubleAnimation2 = new DoubleAnimation(base.Height / 2.0, new Duration(TimeSpan.FromSeconds(value)));
					Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath("Height"));
					Storyboard.SetTarget(doubleAnimation2, TheCircle);
					jvsxD9TQ2.Children.Add(doubleAnimation2);
					doubleAnimation3 = new DoubleAnimation(0.0, new Duration(TimeSpan.FromSeconds(value)));
					Storyboard.SetTargetProperty(doubleAnimation3, new PropertyPath("Opacity"));
					Storyboard.SetTarget(doubleAnimation3, TheCircle);
					num = 0;
					if (!Y93efTWcH81BSsDLCKV())
					{
						num = num2;
					}
					continue;
				}
				}
				break;
			}
		}
		jvsxD9TQ2.Children.Add(doubleAnimation3);
		jvsxD9TQ2.Completed += ArP1fOlc9;
		if (jvsxD9TQ2.CanFreeze)
		{
			jvsxD9TQ2.Freeze();
		}
	}

	private void pKDGLnobg()
	{
		int num = 1;
		while (true)
		{
			double value = 0.4;
			int num2 = 0;
			if (!Y93efTWcH81BSsDLCKV())
			{
				goto IL_000e;
			}
			goto IL_0147;
			IL_0147:
			switch (num2)
			{
			case 1:
				continue;
			case 2:
				Ug7KVVMHc.Freeze();
				return;
			}
			goto IL_000e;
			IL_000e:
			Ug7KVVMHc = new Storyboard();
			Ug7KVVMHc.FillBehavior = FillBehavior.Stop;
			DoubleAnimation doubleAnimation = new DoubleAnimation(base.Width, new Duration(TimeSpan.FromSeconds(value)));
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Width"));
			Storyboard.SetTarget(doubleAnimation, TheCircle);
			Ug7KVVMHc.Children.Add(doubleAnimation);
			DoubleAnimation doubleAnimation2 = new DoubleAnimation(base.Height, new Duration(TimeSpan.FromSeconds(value)));
			Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath("Height"));
			Storyboard.SetTarget(doubleAnimation2, TheCircle);
			Ug7KVVMHc.Children.Add(doubleAnimation2);
			DoubleAnimation doubleAnimation3 = new DoubleAnimation(0.0, new Duration(TimeSpan.FromSeconds(value)));
			Storyboard.SetTargetProperty(doubleAnimation3, new PropertyPath("Opacity"));
			Storyboard.SetTarget(doubleAnimation3, TheCircle);
			Ug7KVVMHc.Children.Add(doubleAnimation3);
			Ug7KVVMHc.Completed += ArP1fOlc9;
			if (Ug7KVVMHc.CanFreeze)
			{
				num2 = 2;
				if (!Y93efTWcH81BSsDLCKV())
				{
					num2 = num;
				}
				goto IL_0147;
			}
			break;
		}
	}

	private void eNQs5BjaW(object sender, DpiChangedEventArgs e)
	{
		DpiHasChanged = true;
		qAYBemtQ6 = e.NewDpi;
	}

	public double GetDpiScale()
	{
		if (qAYBemtQ6.DpiScaleX < 0.1)
		{
			qAYBemtQ6 = VisualTreeHelper.GetDpi(this);
		}
		return qAYBemtQ6.DpiScaleX;
	}

	public void Prepare()
	{
		IsIdle = false;
	}

	public void Play(System.Windows.Media.Brush circleBrush, bool isDown)
	{
		LastLiveTime = Environment.TickCount;
		base.Opacity = (isDown ? 0.95 : 0.7);
		TheCircle.Stroke = circleBrush;
		IsIdle = false;
		if (isDown)
		{
			TheCircle.Width = base.Width * 0.2;
			TheCircle.Height = base.Height * 0.2;
			Ug7KVVMHc.Begin();
		}
		else
		{
			jvsxD9TQ2.Begin();
		}
		Show();
		int num = 0;
		if (VS3otkWFA9Jtg4Ed2L8 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void Y0sHrCZQT(object sender, EventArgs e)
	{
		WindowHelper.SetWindowExTransparent(new WindowInteropHelper(this).Handle);
	}

	private void ArP1fOlc9(object sender, EventArgs e)
	{
		Close();
	}

	public static void ShowIndicator(double indicatorSize, System.Windows.Media.Brush brush, System.Drawing.Point point)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.LNEvCjN0t1t = indicatorSize;
		_003C_003Ec__DisplayClass26_.RY4vCnvi0M1 = brush;
		_003C_003Ec__DisplayClass26_.ciEvC42RlbP = point;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass26_.ze1vCQf0oZF);
	}

	private static void cgkb8m33H(Window window_0, int int_1, int int_2, int int_3, int int_4)
	{
		NativeMethods.SetWindowPos(new WindowInteropHelper(window_0).Handle, NativeMethods.HWND_TOPMOST, int_1, int_2, int_3, int_4, SetWindowPosFlags.SWP_NOACTIVATE);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!tbpjdfnH2)
		{
			tbpjdfnH2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/clickindicator.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TheCircle = (Ellipse)target;
		}
		else
		{
			tbpjdfnH2 = true;
		}
	}

	static ClickIndicator()
	{
		AVUmGbqVH = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool Y93efTWcH81BSsDLCKV()
	{
		return VS3otkWFA9Jtg4Ed2L8 == null;
	}
}
