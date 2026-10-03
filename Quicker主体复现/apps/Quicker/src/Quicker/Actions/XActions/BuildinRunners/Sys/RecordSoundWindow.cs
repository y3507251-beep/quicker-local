using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using NAudio.Wave;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;

namespace Quicker.Actions.XActions.BuildinRunners.Sys;

public class RecordSoundWindow : Window, IComponentConnector, IMockModalWindow
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003COnLoaded_003Eb__48_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RecordSoundWindow _003C_003E4__this;

		private DateTime _003CtmStart_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object idmyHnWiehctYBrbsC1d;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RecordSoundWindow recordSoundWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003CtmStart_003E5__2 = DateTime.Now.AddSeconds(recordSoundWindow.AutoStartSeconds);
					goto IL_0054;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_010d;
				IL_00f7:
				int num3 = default(int);
				int num2 = num3;
				goto IL_00fb;
				IL_00fb:
				_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					_003C_003Ec__DisplayClass48_.XdKS1cEiJrS = (DateTime.Now - _003CtmStart_003E5__2).TotalSeconds;
					recordSoundWindow.Dispatcher.Invoke(_003C_003Ec__DisplayClass48_.sGnS1qCIpWE);
					awaiter = Task.Delay(100).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						break;
					}
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					num2 = 1;
					if (idmyHnWiehctYBrbsC1d == null)
					{
						continue;
					}
					goto IL_00f7;
				}
				goto IL_010d;
				IL_0054:
				if (DateTime.Now < _003CtmStart_003E5__2)
				{
					_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0
					{
						pHnS1Vgl05W = recordSoundWindow
					};
					num2 = 0;
					if (!G28Jw2WijDII8BEqDj6S())
					{
						goto IL_00f7;
					}
					goto IL_00fb;
				}
				recordSoundWindow.Dispatcher.Invoke(recordSoundWindow.APWgptbugZc);
				goto end_IL_0010;
				IL_010d:
				awaiter.GetResult();
				goto IL_0054;
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

		internal static bool G28Jw2WijDII8BEqDj6S()
		{
			return idmyHnWiehctYBrbsC1d == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass48_0
	{
		public double XdKS1cEiJrS;

		public RecordSoundWindow pHnS1Vgl05W;

		private static _003C_003Ec__DisplayClass48_0 LHdF4DWiEBHMwAulGbuQ;

		internal void sGnS1qCIpWE()
		{
			if (XdKS1cEiJrS < 0.0)
			{
				pHnS1Vgl05W.RecordLength = $"{XdKS1cEiJrS:0.0}";
			}
			else
			{
				pHnS1Vgl05W.RecordLength = "0.0";
			}
		}

		internal static bool NFUUNUWiGZO1e869hprF()
		{
			return LHdF4DWiEBHMwAulGbuQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public RecordSoundWindow s27S19v9qv9;

		public WaveInEventArgs D2CS1h7LbhZ;

		public int yC7S1eYF3AU;

		private static _003C_003Ec__DisplayClass51_0 uYxx67Wi13jio0rJhfhA;

		internal void TwfS1ZFgx40()
		{
			s27S19v9qv9.SMGgroWf6jc(D2CS1h7LbhZ);
			s27S19v9qv9.r6tgrTeBjdZ(yC7S1eYF3AU);
		}

		internal static bool odEUpRWiKeeMp3oFkV3M()
		{
			return uYxx67Wi13jio0rJhfhA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_0
	{
		public RecordSoundWindow AP6S1IMe9rY;

		public RecordingState k1eS1WNUKI1;

		private static _003C_003Ec__DisplayClass60_0 W0hBHfWivb9jjqx7uFAg;

		internal void um4S1Ykb9e0()
		{
			AP6S1IMe9rY.BtnStart.Visibility = Visibility.Collapsed;
			AP6S1IMe9rY.BtnStop.Visibility = Visibility.Collapsed;
			AP6S1IMe9rY.BtnOk.Visibility = Visibility.Collapsed;
			AP6S1IMe9rY.BtnCancel.Visibility = Visibility.Collapsed;
			RecordingState cFvgpVqYTB = AP6S1IMe9rY.CFvgpVqYTB6;
			if (!D27Z7CWidOKLR0VBRYr1())
			{
				switch (0)
				{
				}
			}
			switch (cFvgpVqYTB)
			{
			default:
				throw new ArgumentOutOfRangeException("state", k1eS1WNUKI1, null);
			case RecordingState.Ready:
				AP6S1IMe9rY.BtnStart.Visibility = Visibility.Visible;
				break;
			case RecordingState.Recording:
				AP6S1IMe9rY.BtnStop.Visibility = Visibility.Visible;
				break;
			case RecordingState.Paused:
				break;
			case RecordingState.Stopped:
				AP6S1IMe9rY.BtnStart.Visibility = Visibility.Visible;
				AP6S1IMe9rY.BtnOk.Visibility = Visibility.Visible;
				AP6S1IMe9rY.BtnCancel.Visibility = Visibility.Visible;
				AP6S1IMe9rY.IconStart.Icon = "fa:Light_Undo:#FF0000";
				break;
			}
		}

		internal static bool D27Z7CWidOKLR0VBRYr1()
		{
			return W0hBHfWivb9jjqx7uFAg == null;
		}
	}

	[CompilerGenerated]
	private int JH3gpvFlwsZ = 16000;

	[CompilerGenerated]
	private int BOJgpSRNnQX = 1;

	[CompilerGenerated]
	private string bctgp2sFAIC;

	private string XykgpuZfvpD;

	[CompilerGenerated]
	private double K0NgpNlBvuC;

	[CompilerGenerated]
	private double qrugpJv4TPm;

	[CompilerGenerated]
	private string vfJgp0xn6qZ;

	[CompilerGenerated]
	private bool nuygpCa3pKY;

	[CompilerGenerated]
	private string uLjgpPkTvP9;

	[CompilerGenerated]
	private string NUigpEk9SVd;

	public static readonly DependencyProperty RecordLengthProperty;

	private IWaveIn Pa1gpyyS6S5;

	private WaveFileWriter xMIgp8s9SRK;

	private Timer caqgpaP3AWG;

	private bool kkhgp762GA4;

	private long bFngpRdyI1U;

	private float Dn8gpqgG1AT;

	private IList<float> QBpgpct0EIo = new List<float>();

	private RecordingState CFvgpVqYTB6;

	[CompilerGenerated]
	private bool? LoBgpZHBvAK;

	internal Canvas WaveCanvas;

	internal Button BtnStart;

	internal IconControl IconStart;

	internal Button BtnStop;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool sBUgp9NBI2J;

	internal static RecordSoundWindow phY2tkQhkJuKVGImEJdK;

	public int SampleRate
	{
		[CompilerGenerated]
		get
		{
			return JH3gpvFlwsZ;
		}
		[CompilerGenerated]
		set
		{
			JH3gpvFlwsZ = value;
		}
	}

	public int Channels
	{
		[CompilerGenerated]
		get
		{
			return BOJgpSRNnQX;
		}
		[CompilerGenerated]
		set
		{
			BOJgpSRNnQX = value;
		}
	}

	public string SavePath
	{
		[CompilerGenerated]
		get
		{
			return bctgp2sFAIC;
		}
		[CompilerGenerated]
		set
		{
			bctgp2sFAIC = value;
		}
	}

	public double AutoStartSeconds
	{
		[CompilerGenerated]
		get
		{
			return K0NgpNlBvuC;
		}
		[CompilerGenerated]
		set
		{
			K0NgpNlBvuC = value;
		}
	}

	public double SilentStopSeconds
	{
		[CompilerGenerated]
		get
		{
			return qrugpJv4TPm;
		}
		[CompilerGenerated]
		set
		{
			qrugpJv4TPm = value;
		}
	}

	public string HelpText
	{
		[CompilerGenerated]
		get
		{
			return vfJgp0xn6qZ;
		}
		[CompilerGenerated]
		set
		{
			vfJgp0xn6qZ = value;
		}
	}

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return nuygpCa3pKY;
		}
		[CompilerGenerated]
		set
		{
			nuygpCa3pKY = value;
		}
	}

	public string OutputPath
	{
		[CompilerGenerated]
		get
		{
			return uLjgpPkTvP9;
		}
		[CompilerGenerated]
		set
		{
			uLjgpPkTvP9 = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return NUigpEk9SVd;
		}
		[CompilerGenerated]
		set
		{
			NUigpEk9SVd = value;
		}
	}

	public string RecordLength
	{
		get
		{
			return (string)GetValue(RecordLengthProperty);
		}
		set
		{
			SetValue(RecordLengthProperty, value);
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return LoBgpZHBvAK;
		}
		[CompilerGenerated]
		set
		{
			LoBgpZHBvAK = value;
		}
	}

	public RecordSoundWindow()
	{
		InitializeComponent();
		base.Loaded += RgRgr5wf9N9;
		base.Closed += NDCgr4tWS3b;
		base.DataContext = this;
	}

	private void NDCgr4tWS3b(object sender, EventArgs e)
	{
		try
		{
			xMIgp8s9SRK?.Dispose();
			xMIgp8s9SRK = null;
		}
		catch
		{
		}
	}

	private void RgRgr5wf9N9(object sender, RoutedEventArgs e)
	{
		F8NgrU2nI8Z(RecordingState.Ready);
		if (AutoStartSeconds > 1E-05)
		{
			BtnStart.IsEnabled = false;
			Task.Run((Func<Task>)Pw8gpwd5kh0);
			IconStart.Icon = "fa:Light_Clock:#FF0000";
		}
		else if (AutoStartSeconds > -1E-05)
		{
			H0EgrDnfA6D();
		}
	}

	private void H0EgrDnfA6D()
	{
		XykgpuZfvpD = (SavePath.EndsWith(".wav", StringComparison.OrdinalIgnoreCase) ? SavePath : System.IO.Path.ChangeExtension(SavePath, ".wav"));
		if (File.Exists(XykgpuZfvpD))
		{
			try
			{
				File.Delete(XykgpuZfvpD);
			}
			catch (Exception)
			{
				AppHelper.ShowWarning("文件已存在，且无法删除，请稍后再试。" + XykgpuZfvpD);
				return;
			}
		}
		QBpgpct0EIo.Clear();
		try
		{
			Pa1gpyyS6S5 = new WaveInEvent
			{
				WaveFormat = new WaveFormat(SampleRate, Channels),
				BufferMilliseconds = 50
			};
			xMIgp8s9SRK = new WaveFileWriter(XykgpuZfvpD, Pa1gpyyS6S5.WaveFormat);
			Pa1gpyyS6S5.DataAvailable += NjmgrdgoYHg;
			Pa1gpyyS6S5.RecordingStopped += oI7grMd3b19;
			Pa1gpyyS6S5.StartRecording();
			bFngpRdyI1U = AppHelper.fLiLTj0x4QY();
			if (SilentStopSeconds >= 1.0)
			{
				caqgpaP3AWG = new Timer
				{
					Interval = SilentStopSeconds * 1000.0,
					AutoReset = false
				};
				caqgpaP3AWG.Elapsed += wMwgrO6xDQY;
				int num = 0;
				if (phY2tkQhkJuKVGImEJdK != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			F8NgrU2nI8Z(RecordingState.Recording);
		}
		catch (Exception ex2)
		{
			xMIgp8s9SRK?.Dispose();
			xMIgp8s9SRK = null;
			F8NgrU2nI8Z(RecordingState.Ready);
			AppHelper.ShowWarning(ex2.Message);
		}
	}

	private void NjmgrdgoYHg(object sender, WaveInEventArgs e)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.s27S19v9qv9 = this;
		_003C_003Ec__DisplayClass51_.D2CS1h7LbhZ = e;
		if (xMIgp8s9SRK == null || !xMIgp8s9SRK.CanWrite)
		{
			return;
		}
		xMIgp8s9SRK.Write(_003C_003Ec__DisplayClass51_.D2CS1h7LbhZ.Buffer, 0, _003C_003Ec__DisplayClass51_.D2CS1h7LbhZ.BytesRecorded);
		xMIgp8s9SRK.Flush();
		float num = 0f;
		for (int i = 0; i < _003C_003Ec__DisplayClass51_.D2CS1h7LbhZ.BytesRecorded; i += 2)
		{
			float value = (float)BitConverter.ToInt16(_003C_003Ec__DisplayClass51_.D2CS1h7LbhZ.Buffer, i) / 32768f;
			num = Math.Max(num, Math.Abs(value));
		}
		QBpgpct0EIo.Add(num);
		if (QBpgpct0EIo.Count == 1)
		{
			caqgpaP3AWG?.Start();
		}
		if (num > Dn8gpqgG1AT)
		{
			Dn8gpqgG1AT = num;
		}
		int num2;
		if (caqgpaP3AWG != null && (double)num > 0.01)
		{
			num2 = 0;
			if (!d9qUWAQhaUpcSSnrBOAx())
			{
				goto IL_014b;
			}
			goto IL_014f;
		}
		goto IL_0162;
		IL_0162:
		_003C_003Ec__DisplayClass51_.yC7S1eYF3AU = (int)xMIgp8s9SRK.TotalTime.TotalMilliseconds;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass51_.TwfS1ZFgx40);
		return;
		IL_014b:
		int num3 = default(int);
		num2 = num3;
		goto IL_014f;
		IL_014f:
		while (true)
		{
			switch (num2)
			{
			default:
				if (!((double)num > (double)Dn8gpqgG1AT * 0.05))
				{
					break;
				}
				goto IL_0128;
			case 1:
				break;
			case 2:
				return;
			}
			break;
			IL_0128:
			caqgpaP3AWG.Stop();
			caqgpaP3AWG.Start();
			num2 = 1;
			if (phY2tkQhkJuKVGImEJdK == null)
			{
				continue;
			}
			goto IL_014b;
		}
		goto IL_0162;
	}

	private void SMGgroWf6jc(WaveInEventArgs waveInEventArgs_0)
	{
		WaveCanvas.Children.Clear();
		double actualWidth = WaveCanvas.ActualWidth;
		double actualHeight2 = WaveCanvas.ActualHeight;
		double num = actualWidth;
		int num2 = QBpgpct0EIo.Count - 1;
		double num3 = 1.0;
		double num4 = 1.0;
		while (!(num <= 0.0) && num2 >= 0)
		{
			double y = WaveCanvas.ActualHeight - (double)QBpgpct0EIo[num2] * WaveCanvas.ActualHeight;
			double actualHeight = WaveCanvas.ActualHeight;
			Line element = new Line
			{
				X1 = num,
				Y1 = y,
				X2 = num,
				Y2 = actualHeight,
				Stroke = Brushes.DodgerBlue,
				StrokeThickness = num3
			};
			WaveCanvas.Children.Add(element);
			if (phY2tkQhkJuKVGImEJdK != null)
			{
				switch (0)
				{
				}
			}
			num -= num3 + num4;
			num2--;
		}
	}

	private void r6tgrTeBjdZ(long long_1)
	{
		int num = (int)(long_1 % 1000L) / 100;
		int num2 = (int)(long_1 / 1000L % 60L);
		int num3 = (int)(long_1 / 1000L / 60L);
		RecordLength = $"{num3:00}:{num2:00}.{num:0}";
	}

	private void oI7grMd3b19(object sender, StoppedEventArgs e)
	{
		Pa1gpyyS6S5.Dispose();
		Pa1gpyyS6S5 = null;
		try
		{
			xMIgp8s9SRK.Flush();
			xMIgp8s9SRK.Dispose();
			xMIgp8s9SRK = null;
		}
		catch
		{
		}
		if (kkhgp762GA4)
		{
			WB4grAWMSOl();
		}
	}

	private void WB4grAWMSOl()
	{
		IsSuccess = true;
		OutputPath = (File.Exists(SavePath) ? SavePath : XykgpuZfvpD);
		base.Dispatcher.InvokeAsync(k2MgpgmwROd);
	}

	private void wMwgrO6xDQY(object sender, ElapsedEventArgs e)
	{
		kkhgp762GA4 = true;
		kWXgrFruxeA();
	}

	private void kWXgrFruxeA()
	{
		F8NgrU2nI8Z(RecordingState.Stopped);
		if (Pa1gpyyS6S5 != null)
		{
			Pa1gpyyS6S5.StopRecording();
		}
		if (caqgpaP3AWG != null)
		{
			caqgpaP3AWG.Stop();
			caqgpaP3AWG.Elapsed -= wMwgrO6xDQY;
			caqgpaP3AWG.Dispose();
			caqgpaP3AWG = null;
		}
	}

	private void F8NgrU2nI8Z(RecordingState recordingState_1)
	{
		_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
		_003C_003Ec__DisplayClass60_.AP6S1IMe9rY = this;
		_003C_003Ec__DisplayClass60_.k1eS1WNUKI1 = recordingState_1;
		CFvgpVqYTB6 = _003C_003Ec__DisplayClass60_.k1eS1WNUKI1;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass60_.um4S1Ykb9e0);
	}

	private void K62grlYKhVr(object sender, RoutedEventArgs e)
	{
		WB4grAWMSOl();
	}

	private void VWPgriw4vMy(object sender, RoutedEventArgs e)
	{
		Result = false;
		TEdgr3J3lKt();
		Close();
	}

	private void TEdgr3J3lKt()
	{
		mCZgpLexlvm(XykgpuZfvpD);
		mCZgpLexlvm(SavePath);
	}

	private void vIFgrfc5Ec4(object sender, RoutedEventArgs e)
	{
		kkhgp762GA4 = false;
		kWXgrFruxeA();
	}

	private void BhjgrzVBlSr(object sender, RoutedEventArgs e)
	{
		if (CFvgpVqYTB6 != RecordingState.Recording)
		{
			H0EgrDnfA6D();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!sBUgp9NBI2J)
		{
			sBUgp9NBI2J = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/xactions/buildinrunners/sys/sound/recordsoundwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				WaveCanvas = (Canvas)target;
				return;
			case 2:
				BtnStart = (Button)target;
				BtnStart.Click += BhjgrzVBlSr;
				return;
			case 3:
				IconStart = (IconControl)target;
				return;
			case 4:
				BtnStop = (Button)target;
				BtnStop.Click += vIFgrfc5Ec4;
				return;
			case 5:
				BtnOk = (Button)target;
				BtnOk.Click += K62grlYKhVr;
				return;
			case 6:
				BtnCancel = (Button)target;
				BtnCancel.Click += VWPgriw4vMy;
				return;
			}
			if (phY2tkQhkJuKVGImEJdK == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			sBUgp9NBI2J = true;
			return;
		}
	}

	static RecordSoundWindow()
	{
		RecordLengthProperty = DependencyProperty.Register("RecordLength", typeof(string), typeof(RecordSoundWindow), new PropertyMetadata("00:00"));
	}

	[AsyncStateMachine(typeof(_003C_003COnLoaded_003Eb__48_0_003Ed))]
	[CompilerGenerated]
	private Task Pw8gpwd5kh0()
	{
		_003C_003COnLoaded_003Eb__48_0_003Ed stateMachine = default(_003C_003COnLoaded_003Eb__48_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void APWgptbugZc()
	{
		RecordLength = "0:00.0";
		BtnStart.IsEnabled = true;
		H0EgrDnfA6D();
	}

	[CompilerGenerated]
	private void k2MgpgmwROd()
	{
		Close();
	}

	[CompilerGenerated]
	internal static void mCZgpLexlvm(string string_4)
	{
		if (File.Exists(string_4))
		{
			try
			{
				File.Delete(string_4);
			}
			catch (Exception)
			{
			}
		}
	}

	internal static bool d9qUWAQhaUpcSSnrBOAx()
	{
		return phY2tkQhkJuKVGImEJdK == null;
	}
}
