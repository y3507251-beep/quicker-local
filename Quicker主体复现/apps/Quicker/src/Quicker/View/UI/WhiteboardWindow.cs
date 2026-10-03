using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View.UI;

public class WhiteboardWindow : System.Windows.Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSave_OnClick_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WhiteboardWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object LhyWWNWmarq82Trta7mT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WhiteboardWindow whiteboardWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_014a;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (whiteboardWindow.Ct4L7w4HSMg && whiteboardWindow.ImageIncludeBg)
				{
					whiteboardWindow.ActionRow.Visibility = Visibility.Collapsed;
					int num2 = 0;
					if (!bhV2PTWmr158MPdSOqhE())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_014a;
					}
					whiteboardWindow.InvalidateVisual();
					awaiter = Task.Delay(400).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0168;
				}
				whiteboardWindow.TheCanvas.UpdateLayout();
				double dpiScaling = AppHelper.GetDpiScaling(whiteboardWindow);
				int pixelWidth = (int)(whiteboardWindow.TheCanvas.ActualWidth / dpiScaling);
				int pixelHeight = (int)(whiteboardWindow.TheCanvas.ActualHeight / dpiScaling);
				MemoryStream stream = new MemoryStream();
				RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(pixelWidth, pixelHeight, 96.0 / dpiScaling, 96.0 / dpiScaling, PixelFormats.Default);
				renderTargetBitmap.Render(whiteboardWindow.TheCanvas);
				PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
				pngBitmapEncoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));
				pngBitmapEncoder.Save(stream);
				whiteboardWindow.ResultBitmap = new Bitmap(stream);
				goto IL_0182;
				IL_014a:
				awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0168;
				IL_0182:
				whiteboardWindow.IsSuccess = true;
				whiteboardWindow.Close();
				goto end_IL_0010;
				IL_0168:
				awaiter.GetResult();
				whiteboardWindow.ResultBitmap = CaptureStep.CaptureWindow(whiteboardWindow.GetHandle());
				goto IL_0182;
				end_IL_0010:;
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

		internal static bool bhV2PTWmr158MPdSOqhE()
		{
			return LhyWWNWmarq82Trta7mT == null;
		}
	}

	private readonly bool Ct4L7w4HSMg;

	[CompilerGenerated]
	private bool TBGL7tUbVJR;

	[CompilerGenerated]
	private Bitmap EwsL7giw08P;

	[CompilerGenerated]
	private string ndXL7LrgJQx;

	[CompilerGenerated]
	private string CsBL7vrmWL2;

	[CompilerGenerated]
	private string RaUL7S76Hmu;

	[CompilerGenerated]
	private bool I3uL727RTFA;

	internal InkCanvas TheCanvas;

	internal Grid ActionRow;

	internal Button BtnClear;

	internal Button BtnRemoveLast;

	internal ToggleButton btn_color;

	internal ColorPicker color_picker;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool qPLL7uJFQ8H;

	private static WhiteboardWindow cpcfB6F0aIIvywED0I81;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return TBGL7tUbVJR;
		}
		[CompilerGenerated]
		private set
		{
			TBGL7tUbVJR = value;
		}
	}

	public Bitmap ResultBitmap
	{
		[CompilerGenerated]
		get
		{
			return EwsL7giw08P;
		}
		[CompilerGenerated]
		private set
		{
			EwsL7giw08P = value;
		}
	}

	public string WindowPosition
	{
		[CompilerGenerated]
		get
		{
			return ndXL7LrgJQx;
		}
		[CompilerGenerated]
		set
		{
			ndXL7LrgJQx = value;
		}
	}

	public string BgColor
	{
		[CompilerGenerated]
		get
		{
			return CsBL7vrmWL2;
		}
		[CompilerGenerated]
		set
		{
			CsBL7vrmWL2 = value;
		}
	}

	public string StrokeColor
	{
		[CompilerGenerated]
		get
		{
			return RaUL7S76Hmu;
		}
		[CompilerGenerated]
		set
		{
			RaUL7S76Hmu = value;
		}
	}

	public bool ImageIncludeBg
	{
		[CompilerGenerated]
		get
		{
			return I3uL727RTFA;
		}
		[CompilerGenerated]
		set
		{
			I3uL727RTFA = value;
		}
	}

	public StrokeCollection Strokes => TheCanvas.Strokes;

	public WhiteboardWindow(bool enableTransparent, bool includeBg)
	{
		Ct4L7w4HSMg = enableTransparent;
		InitializeComponent();
		base.Loaded += UZCLaTFxOuJ;
		if (enableTransparent)
		{
			base.WindowStyle = WindowStyle.None;
			base.AllowsTransparency = true;
			base.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(1, 0, 0, 0));
			ActionRow.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(40, 0, 0, 0));
		}
		TheCanvas.UseCustomCursor = true;
		TheCanvas.Cursor = Cursors.Pen;
		ImageIncludeBg = includeBg;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void UZCLaTFxOuJ(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(WindowPosition))
		{
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowWindowLocation.Manual, WindowPosition);
		}
		if (!string.IsNullOrWhiteSpace(BgColor))
		{
			System.Windows.Media.Color color = Quicker.Utilities.Ext.ColorHelper.StringToColor(BgColor);
			TheCanvas.Background = color.GetBrush();
		}
		if (!string.IsNullOrWhiteSpace(StrokeColor))
		{
			System.Windows.Media.Color color2 = Quicker.Utilities.Ext.ColorHelper.StringToColor(StrokeColor);
			TheCanvas.DefaultDrawingAttributes.Color = color2;
		}
	}

	private void kXhLaMqM2Ft(object sender, RoutedEventArgs e)
	{
		IsSuccess = false;
		Close();
	}

	[AsyncStateMachine(typeof(_003CBtnSave_OnClick_003Ed__31))]
	private void VrELaAV70dC(object sender, RoutedEventArgs e)
	{
		_003CBtnSave_OnClick_003Ed__31 stateMachine = default(_003CBtnSave_OnClick_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Y3bLaOVqWKi(object sender, RoutedEventArgs e)
	{
		TheCanvas.Strokes.Clear();
	}

	private void txRLaFa5FD7(object sender, RoutedEventArgs e)
	{
		if (TheCanvas.Strokes.Count > 0)
		{
			TheCanvas.Strokes.Remove(TheCanvas.Strokes.Last());
		}
	}

	private void F2oLaUFuIUZ(object sender, FunctionEventArgs<System.Windows.Media.Color> e)
	{
	}

	private void nNaLalT0HxM(object sender, EventArgs e)
	{
		btn_color.IsChecked = false;
	}

	private void W0aLaiAh6CV(object sender, FunctionEventArgs<System.Windows.Media.Color> e)
	{
		TheCanvas.DefaultDrawingAttributes.Color = e.Info;
		btn_color.IsChecked = false;
	}

	private void zZRLa3w73tB(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!qPLL7uJFQ8H)
		{
			qPLL7uJFQ8H = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/whiteboardwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			qPLL7uJFQ8H = true;
			break;
		case 1:
			((WhiteboardWindow)target).PreviewKeyDown += zZRLa3w73tB;
			break;
		case 2:
			TheCanvas = (InkCanvas)target;
			break;
		case 3:
			ActionRow = (Grid)target;
			break;
		case 4:
			BtnClear = (Button)target;
			BtnClear.Click += Y3bLaOVqWKi;
			break;
		case 5:
			BtnRemoveLast = (Button)target;
			BtnRemoveLast.Click += txRLaFa5FD7;
			break;
		case 6:
			btn_color = (ToggleButton)target;
			break;
		case 7:
			color_picker = (ColorPicker)target;
			color_picker.Canceled += nNaLalT0HxM;
			num = 1;
			if (cpcfB6F0aIIvywED0I81 != null)
			{
				goto IL_0121;
			}
			goto IL_012f;
		case 8:
			BtnSave = (Button)target;
			BtnSave.Click += VrELaAV70dC;
			num = 0;
			if (!mhd7pSF0rry8hCiG4JNa())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0121;
		case 9:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += kXhLaMqM2Ft;
				break;
			}
			IL_0121:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto IL_012f;
			IL_012f:
			color_picker.Confirmed += W0aLaiAh6CV;
			color_picker.SelectedColorChanged += F2oLaUFuIUZ;
			break;
		}
	}

	internal static bool mhd7pSF0rry8hCiG4JNa()
	{
		return cpcfB6F0aIIvywED0I81 == null;
	}
}
