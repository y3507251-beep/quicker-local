using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using FontAwesome5;
using FontAwesome5.WPF;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Recorder.UI;

public class RecorderWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public HintWindow mlevq0VJQeT;

		public RecorderWindow wxrvqC7PTbL;

		public Action m8dvqPJf8Od;

		internal static _003C_003Ec__DisplayClass14_0 PsttnScJIgXvZYNNfa1A;

		internal void o7AvqNGVpY5()
		{
			if (mlevq0VJQeT == null)
			{
				if (wxrvqC7PTbL.s1s6eCGnBk > 0.001)
				{
					Thread.Sleep((int)(wxrvqC7PTbL.s1s6eCGnBk * 1000.0));
				}
			}
			else
			{
				_003C_003Ec__DisplayClass14_1 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_1
				{
					QDvvq826R51 = this,
					FKKvqyWIoWD = (int)(wxrvqC7PTbL.s1s6eCGnBk * 1000.0)
				};
				while (_003C_003Ec__DisplayClass14_.FKKvqyWIoWD > 0)
				{
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass14_.OSSvqEurnVA);
					if (PsttnScJIgXvZYNNfa1A != null)
					{
						switch (0)
						{
						}
					}
					Thread.Sleep(100);
					_003C_003Ec__DisplayClass14_.FKKvqyWIoWD -= 100;
				}
				AppHelper.RunOnUiThread(true, m8dvqPJf8Od ?? (m8dvqPJf8Od = TSevqJ1CbMF));
			}
			wxrvqC7PTbL.H3p6W3ydM4 = false;
			AppHelper.RunOnUiThread(true, wxrvqC7PTbL.WHy6c3wbYS);
		}

		internal void TSevqJ1CbMF()
		{
			mlevq0VJQeT.Close();
		}

		internal static bool wFjIjwcJ6hrLwJjyCBP6()
		{
			return PsttnScJIgXvZYNNfa1A == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_1
	{
		public int FKKvqyWIoWD;

		public _003C_003Ec__DisplayClass14_0 QDvvq826R51;

		internal static _003C_003Ec__DisplayClass14_1 jNEo8ocJSDlIsdj03Kwo;

		internal void OSSvqEurnVA()
		{
			QDvvq826R51.mlevq0VJQeT.Message = $"即将开始录制：{(double)FKKvqyWIoWD / 1000.0:F1} 秒";
		}

		internal static bool lABDRNcJwEbaCLbFqepc()
		{
			return jNEo8ocJSDlIsdj03Kwo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnPlay_OnClick_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RecorderWindow _003C_003E4__this;

		private HintWindow _003ChintWindow_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object HYvXNxcJsRpA69fIaeRM;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RecorderWindow recorderWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0095;
				}
				int num2;
				if (recorderWindow.rlj6YFGOGq.IsRecording)
				{
					AppHelper.ShowInformation("正在录制");
					num2 = 0;
					if (!jOnm7ncJCeMGj8ojXuTU())
					{
						goto IL_0111;
					}
				}
				else
				{
					if (!recorderWindow.qLJ6I0c5K5.IsPlaying)
					{
						num2 = 1;
						if (HYvXNxcJsRpA69fIaeRM != null)
						{
							goto IL_010d;
						}
						goto IL_0111;
					}
					AppHelper.ShowInformation("正在重放");
				}
				goto end_IL_0010;
				IL_0095:
				awaiter.GetResult();
				num2 = 2;
				if (!jOnm7ncJCeMGj8ojXuTU())
				{
					goto IL_010d;
				}
				goto IL_0111;
				IL_010d:
				int num3 = default(int);
				num2 = num3;
				goto IL_0111;
				IL_0111:
				switch (num2)
				{
				case 1:
					if (recorderWindow.rlj6YFGOGq.Records.Count >= 2)
					{
						_003ChintWindow_003E5__2 = new HintWindow("重放中...", ShowWindowLocation.TopCenter, true);
						_003ChintWindow_003E5__2.Show();
						awaiter = Task.Run((Action)recorderWindow.jhD6VCldYj).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					AppHelper.ShowInformation("请先录制操作");
					goto end_IL_0010;
				default:
					goto end_IL_0010;
				case 2:
					_003ChintWindow_003E5__2.Close();
					AppHelper.ShowInformation("重放完成");
					goto end_IL_0010;
				}
				goto IL_0095;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003ChintWindow_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003ChintWindow_003E5__2 = null;
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

		internal static bool jOnm7ncJCeMGj8ojXuTU()
		{
			return HYvXNxcJsRpA69fIaeRM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnRecord_OnClick_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RecorderWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object QJDo5ycJ4TK6mV04iee0;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RecorderWindow recorderWindow = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (QJDo5ycJ4TK6mV04iee0 != null)
					{
						goto IL_00e0;
					}
					goto IL_00e4;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_01fb;
				IL_01fb:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_00e4:
				_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
				while (true)
				{
					switch (num2)
					{
					default:
					{
						if (!recorderWindow.rlj6YFGOGq.IsRecording)
						{
							_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0
							{
								wxrvqC7PTbL = recorderWindow
							};
							recorderWindow.IconRecord.Foreground = Brushes.Red;
							recorderWindow.IconRecord.Icon = EFontAwesomeIcon.Solid_Stop;
							_003C_003Ec__DisplayClass14_.mlevq0VJQeT = null;
							if (recorderWindow.s1s6eCGnBk > 1.0)
							{
								_003C_003Ec__DisplayClass14_.mlevq0VJQeT = new HintWindow($"即将开始录制：{recorderWindow.s1s6eCGnBk:F1} 秒", ShowWindowLocation.CenterScreen, true);
								_003C_003Ec__DisplayClass14_.mlevq0VJQeT.Show();
							}
							goto IL_00b9;
						}
						recorderWindow.rlj6YFGOGq.Stop();
						recorderWindow.IconRecord.Foreground = Brushes.DodgerBlue;
						recorderWindow.IconRecord.Icon = EFontAwesomeIcon.Solid_Circle;
						Button btnSave = recorderWindow.BtnSave;
						bool isEnabled = (recorderWindow.BtnPlay.IsEnabled = recorderWindow.rlj6YFGOGq.Records.Count > 2);
						btnSave.IsEnabled = isEnabled;
						recorderWindow.rlj6YFGOGq.RemoveLastClick();
						goto end_IL_00e4;
					}
					case 1:
						recorderWindow.BtnSave.IsEnabled = false;
						recorderWindow.BtnCancel.IsEnabled = false;
						recorderWindow.ChkRecordMouseMove.IsEnabled = false;
						recorderWindow.H3p6W3ydM4 = true;
						awaiter = Task.Run((Action)_003C_003Ec__DisplayClass14_.o7AvqNGVpY5).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							break;
						}
						num = 0;
						_003C_003E1__state = 0;
						goto case 2;
					case 2:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01fb;
					IL_00b9:
					recorderWindow.BtnRecord.IsEnabled = false;
					recorderWindow.BtnPlay.IsEnabled = false;
					num2 = 1;
					if (QDgH4GcJhAkkNZgdDDv3())
					{
						continue;
					}
					goto IL_00e0;
					continue;
					end_IL_00e4:
					break;
				}
				goto end_IL_0010;
				IL_00e0:
				int num3 = default(int);
				num2 = num3;
				goto IL_00e4;
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

		internal static bool QDgH4GcJhAkkNZgdDDv3()
		{
			return QJDo5ycJ4TK6mV04iee0 == null;
		}
	}

	private readonly bool co769Or8RO;

	private readonly bool oLC6hRtWoX;

	private readonly double s1s6eCGnBk;

	private OperationRecorder rlj6YFGOGq = new OperationRecorder();

	private RecordPlayer qLJ6I0c5K5 = new RecordPlayer();

	private bool H3p6W3ydM4;

	[CompilerGenerated]
	private string PST6kKjc4y;

	internal Button BtnRecord;

	internal SvgAwesome IconRecord;

	internal Button BtnPlay;

	internal Button BtnExport;

	internal Button BtnSave;

	internal Button BtnCancel;

	internal CheckBox ChkRecordMouseMove;

	private bool Dgh6GBs5sa;

	internal static RecorderWindow lRgGSGgn8PBl7PC4aT7;

	public string ResultData
	{
		[CompilerGenerated]
		get
		{
			return PST6kKjc4y;
		}
		[CompilerGenerated]
		private set
		{
			PST6kKjc4y = value;
		}
	}

	public RecorderWindow(bool showModal = false, bool autoStart = false, bool recordMouseMove = false, double prepareSeconds = 2.0)
	{
		co769Or8RO = showModal;
		oLC6hRtWoX = autoStart;
		s1s6eCGnBk = prepareSeconds;
		InitializeComponent();
		base.SourceInitialized += oFH6q50MX0;
		base.Loaded += R7F6C3XD3I;
		base.Closing += McX60X6hUH;
		BtnExport.Visibility = (showModal ? Visibility.Collapsed : Visibility.Visible);
		BtnSave.Visibility = (BtnCancel.Visibility = ((!showModal) ? Visibility.Collapsed : Visibility.Visible));
		ChkRecordMouseMove.IsChecked = recordMouseMove;
		rlj6YFGOGq.RecordMouseMove = recordMouseMove;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void McX60X6hUH(object sender, CancelEventArgs e)
	{
		if (rlj6YFGOGq.IsRecording || H3p6W3ydM4)
		{
			e.Cancel = true;
			AppHelper.ShowWarning("正在录制！");
		}
		if (qLJ6I0c5K5.IsPlaying)
		{
			e.Cancel = true;
			AppHelper.ShowWarning("正在重放！");
		}
	}

	private void R7F6C3XD3I(object sender, RoutedEventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowWindowLocation.BottomRight);
		if (co769Or8RO && oLC6hRtWoX)
		{
			AppHelper.TriggerButtonClick(BtnRecord);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnRecord_OnClick_003Ed__14))]
	private void jmk6P7LvEf(object sender, RoutedEventArgs e)
	{
		_003CBtnRecord_OnClick_003Ed__14 stateMachine = default(_003CBtnRecord_OnClick_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Lfe6EHcGGN(object sender, RoutedEventArgs e)
	{
	}

	private void J876yaEmEL(object sender, RoutedEventArgs e)
	{
		rlj6YFGOGq.Stop();
		BtnRecord.IsEnabled = true;
		Button btnSave = BtnSave;
		bool isEnabled = (BtnPlay.IsEnabled = rlj6YFGOGq.Records.Count > 2);
		btnSave.IsEnabled = isEnabled;
		ChkRecordMouseMove.IsEnabled = true;
	}

	[AsyncStateMachine(typeof(_003CBtnPlay_OnClick_003Ed__17))]
	private void W9k68e0NUU(object sender, RoutedEventArgs e)
	{
		_003CBtnPlay_OnClick_003Ed__17 stateMachine = default(_003CBtnPlay_OnClick_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void QOE6aNSLfM(object sender, RoutedEventArgs e)
	{
		if (rlj6YFGOGq.Records.Count < 2)
		{
			AppHelper.ShowWarning("请先录制。");
			return;
		}
		string recordData = rlj6YFGOGq.GetRecordData();
		ClipboardHelper.SetMultipleData(new Dictionary<string, object>
		{
			{ "UnicodeText", recordData },
			{
				"quicker-action-item",
				ActionConverter.CreateRecordAction(recordData)
			}
		});
		AppHelper.ShowInformation("录制内容已写入剪贴板，您可以：\n(1)在面板空白位置粘贴动作，\n(2)或在已有动作中添加“重放键鼠”模块后粘贴录制数据。");
	}

	private void egl67lqACB(object sender, RoutedEventArgs e)
	{
		if (rlj6YFGOGq.Records.Count < 2)
		{
			AppHelper.ShowWarning("请先录制。");
			return;
		}
		if (rlj6YFGOGq.IsRecording)
		{
			AppHelper.ShowWarning("录制中...");
			return;
		}
		if (qLJ6I0c5K5.IsPlaying)
		{
			qLJ6I0c5K5.Stop();
		}
		ResultData = rlj6YFGOGq.GetRecordData();
		Close();
	}

	private void E9L6RGWcSm(object sender, RoutedEventArgs e)
	{
		if (rlj6YFGOGq.IsRecording)
		{
			rlj6YFGOGq.Stop();
		}
		if (qLJ6I0c5K5.IsPlaying)
		{
			qLJ6I0c5K5.Stop();
		}
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Dgh6GBs5sa)
		{
			Dgh6GBs5sa = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/recorder/ui/recorderwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Dgh6GBs5sa = true;
			break;
		case 1:
			BtnRecord = (Button)target;
			BtnRecord.Click += jmk6P7LvEf;
			break;
		case 2:
			IconRecord = (SvgAwesome)target;
			break;
		case 3:
			BtnPlay = (Button)target;
			BtnPlay.Click += W9k68e0NUU;
			break;
		case 4:
		{
			BtnExport = (Button)target;
			BtnExport.Click += QOE6aNSLfM;
			int num = 0;
			if (lRgGSGgn8PBl7PC4aT7 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 5:
			BtnSave = (Button)target;
			BtnSave.Click += egl67lqACB;
			break;
		case 6:
			BtnCancel = (Button)target;
			BtnCancel.Click += E9L6RGWcSm;
			break;
		case 7:
			ChkRecordMouseMove = (CheckBox)target;
			break;
		}
	}

	[CompilerGenerated]
	private void oFH6q50MX0(object sender, EventArgs e)
	{
		NativeMethods.SetWindowNoActivate(this);
	}

	[CompilerGenerated]
	private void WHy6c3wbYS()
	{
		BtnRecord.IsEnabled = true;
		BtnCancel.IsEnabled = true;
		rlj6YFGOGq.RecordMouseMove = ChkRecordMouseMove.IsChecked == true;
		rlj6YFGOGq.Start(true);
	}

	[CompilerGenerated]
	private void jhD6VCldYj()
	{
		Thread.Sleep(500);
		if (rlj6YFGOGq.Records.HasData())
		{
			try
			{
				qLJ6I0c5K5.Play(rlj6YFGOGq.GetRecordData(), 2.0, null);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("重放失败！" + exception.GetMessageWithInner());
			}
		}
	}

	internal static bool NqBAdxgeG9bE96I8IK7()
	{
		return lRgGSGgn8PBl7PC4aT7 == null;
	}
}
