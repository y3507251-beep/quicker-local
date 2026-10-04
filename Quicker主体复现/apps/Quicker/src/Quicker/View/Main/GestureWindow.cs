using System;
using System.CodeDom.Compiler;
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
using System.Timers;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using kZafZx2CyPXdK8fqwA7;
using log4net;
using Quicker.Annotations;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Modules.Gesture;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using UniversalRecognizer.PointPatterns;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.View.Main;

public class GestureWindow : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CHideWindowWithDelay_003Eb__41_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GestureWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object uNqdyIWmZPjsiZ6Jqq2Z;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			GestureWindow gestureWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_008e;
				}
				int num2 = 0;
				if (!z8jFwxWm5rhQOwLpI3B7())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (!gestureWindow.IsWorking)
				{
					awaiter = Task.Delay(80).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_008e;
				}
				goto end_IL_0010;
				IL_008e:
				awaiter.GetResult();
				gestureWindow.hwbL7X3BdVB();
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

		internal static bool z8jFwxWm5rhQOwLpI3B7()
		{
			return uNqdyIWmZPjsiZ6Jqq2Z == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec VBMSdtVkVue;

		public static Func<SubAction, int> fLGSdgmPWYo;

		public static Func<SubAction, bool> QNaSdLU6Jxx;

		public static Func<SubAction, string> XadSdvhyguK;

		public static Func<SubAction, bool> lifSdSv6Quc;

		public static Func<SubAction, bool> kSjSd2fOm6F;

		private static _003C_003Ec pSTyerWm8Ftpj4Cym7VN;

		static _003C_003Ec()
		{
			VBMSdtVkVue = new _003C_003Ec();
		}

		internal int MB7SDi0uE8c(SubAction x)
		{
			return x.Key;
		}

		internal bool svRSD3KBRT0(SubAction x)
		{
			return x.ActionType != QuickActionType.None;
		}

		internal string JM9SDfdFqOW(SubAction a)
		{
			return KeyboardHelper.GetKeyName((VirtualKeyCode)a.Key) + ": " + a.Description.Or(a.GetSummary());
		}

		internal bool wFOSDzSLe6T(SubAction x)
		{
			return x.Key == 261;
		}

		internal bool hitSdwqKfZe(SubAction x)
		{
			return x.Key == 261;
		}

		internal static bool BxMhJZWmR5IY3MDDZqvr()
		{
			return pSTyerWm8Ftpj4Cym7VN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct q2bjGMkSYlKm7FAgjAT : IAsyncStateMachine
		{
			public int cYC2VOGATNY;

			public AsyncTaskMethodBuilder FyG2VFc7Plb;

			public _003C_003Ec__DisplayClass39_0 CxO2VU3kd8y;

			private int Ud52Vl9cY2P;

			private TaskAwaiter rTs2Vikq4bF;

			internal static object hfI5blyb4jnkplGApD8G;

			private void MoveNext()
			{
				int num = cYC2VOGATNY;
				_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = CxO2VU3kd8y;
				try
				{
					try
					{
						int num2;
						if (num != 0)
						{
							System.Windows.Point point = _003C_003Ec__DisplayClass39_.C35SdN0F5R4[0];
							System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)point.X, (int)point.Y);
							num2 = 1;
							if (hfI5blyb4jnkplGApD8G != null)
							{
								goto IL_01a0;
							}
							goto IL_01b3;
						}
						TaskAwaiter awaiter = rTs2Vikq4bF;
						rTs2Vikq4bF = default(TaskAwaiter);
						num = -1;
						cYC2VOGATNY = -1;
						goto IL_01f8;
						IL_01a0:
						switch (num2)
						{
						case 1:
							break;
						case 2:
							goto IL_01c3;
						default:
							goto IL_0214;
						}
						goto IL_01b3;
						IL_0214:
						rTs2Vikq4bF = awaiter;
						FyG2VFc7Plb.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_01b3:
						InputSimulator.Instance.Mouse.RightButtonDown();
						goto IL_01c3;
						IL_01c3:
						Ud52Vl9cY2P = 1;
						goto IL_01ca;
						IL_01ca:
						if (Ud52Vl9cY2P < _003C_003Ec__DisplayClass39_.C35SdN0F5R4.Count - 1)
						{
							System.Windows.Point point2 = _003C_003Ec__DisplayClass39_.C35SdN0F5R4[Ud52Vl9cY2P];
							if (Ud52Vl9cY2P != _003C_003Ec__DisplayClass39_.C35SdN0F5R4.Count - 1 && point2.X < _003C_003Ec__DisplayClass39_.C35SdN0F5R4[Ud52Vl9cY2P - 1].X + 10.0 && point2.X > _003C_003Ec__DisplayClass39_.C35SdN0F5R4[Ud52Vl9cY2P - 1].X - 10.0 && point2.Y < _003C_003Ec__DisplayClass39_.C35SdN0F5R4[Ud52Vl9cY2P - 1].Y + 10.0 && point2.Y > _003C_003Ec__DisplayClass39_.C35SdN0F5R4[Ud52Vl9cY2P - 1].Y - 10.0)
							{
								goto IL_01e4;
							}
							System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)point2.X, (int)point2.Y);
							awaiter = Task.Delay(1).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_01f8;
							}
							num = 0;
							cYC2VOGATNY = 0;
							num2 = 0;
							if (!iKPJ85ybhJrE7D9W6kSW())
							{
								goto IL_01a0;
							}
							goto IL_0214;
						}
						InputSimulator.Instance.Mouse.RightButtonUp();
						goto end_IL_000f;
						IL_01f8:
						awaiter.GetResult();
						goto IL_01e4;
						IL_01e4:
						Ud52Vl9cY2P++;
						goto IL_01ca;
						end_IL_000f:;
					}
					catch (Exception ex)
					{
						iI5L7zy8jx2.Warn(ex.ToString());
					}
				}
				catch (Exception exception)
				{
					cYC2VOGATNY = -2;
					FyG2VFc7Plb.SetException(exception);
					return;
				}
				cYC2VOGATNY = -2;
				FyG2VFc7Plb.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				FyG2VFc7Plb.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool iKPJ85ybhJrE7D9W6kSW()
			{
				return hfI5blyb4jnkplGApD8G == null;
			}
		}

		public IList<System.Windows.Point> C35SdN0F5R4;

		internal static _003C_003Ec__DisplayClass39_0 xu3fHkWmMwaTreeLGBZu;

		[AsyncStateMachine(typeof(q2bjGMkSYlKm7FAgjAT))]
		internal Task ynHSdu14E2V()
		{
			q2bjGMkSYlKm7FAgjAT stateMachine = default(q2bjGMkSYlKm7FAgjAT);
			stateMachine.FyG2VFc7Plb = AsyncTaskMethodBuilder.Create();
			stateMachine.CxO2VU3kd8y = this;
			stateMachine.cYC2VOGATNY = -1;
			stateMachine.FyG2VFc7Plb.Start(ref stateMachine);
			return stateMachine.FyG2VFc7Plb.Task;
		}

		internal static void aGOCmeWmIcxYbOsUIBJZ()
		{
		}

		internal static bool VBXMTfWmUQcmbVBYIZgo()
		{
			return xu3fHkWmMwaTreeLGBZu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public PointPatternMatchResult x;

		private static _003C_003Ec__DisplayClass45_0 DZ1JC2Wm6x02krpuTKg2;

		internal bool KMkSdJ20Pas(Gesture g)
		{
			return g.Id == x.PatternId;
		}

		internal static bool ul1YEXWmtu0vHo4Px7te()
		{
			return DZ1JC2Wm6x02krpuTKg2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public SubAction eQaSdCbf6i7;

		internal static _003C_003Ec__DisplayClass47_0 VE5UCRWmw2xd2OqnkXhD;

		internal bool BIVSd0B1tEr(SubAction x)
		{
			return x.Key == eQaSdCbf6i7.Key;
		}

		internal static void IkqykKWmsRecnIHfqXHi()
		{
		}

		internal static bool X3t2YgWmTfD7g5j6jse8()
		{
			return VE5UCRWmw2xd2OqnkXhD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass52_0
	{
		public GestureWindow wQ5SdEqp0Oy;

		public GestureAction retSdym6Lyb;

		internal static _003C_003Ec__DisplayClass52_0 YN157CWmCsOs86AsFq9X;

		internal void TUxSdPRE3K1()
		{
			wQ5SdEqp0Oy.NQoL7n0PesQ(retSdym6Lyb != null, retSdym6Lyb);
		}

		internal static bool ohhlJhWm7duK8qsBWv15()
		{
			return YN157CWmCsOs86AsFq9X == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public GestureAction HEVSda7q52a;

		internal static _003C_003Ec__DisplayClass54_0 VAZgAbWmhrLD0v91Xhnh;

		internal bool AkSSd8leVKh(GestureAction x)
		{
			if (x != null)
			{
				return x.GestureId == HEVSda7q52a.GestureId;
			}
			return false;
		}

		internal static bool b08ocLWmHTNg7fF59vVy()
		{
			return VAZgAbWmhrLD0v91Xhnh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public int iZ4SdqXkDgi;

		internal static _003C_003Ec__DisplayClass56_0 f22ZNlWsQOcNtq8ybcsV;

		internal bool O2tSd75pwHE(SubAction x)
		{
			return KeyboardHelper.fDPLMDBnLis((VirtualKeyCode)x.Key, (VirtualKeyCode)iZ4SdqXkDgi);
		}

		internal bool tJSSdRWlMCE(SubAction x)
		{
			return KeyboardHelper.fDPLMDBnLis((VirtualKeyCode)x.Key, (VirtualKeyCode)iZ4SdqXkDgi);
		}

		internal static bool ds2ESyWsFNaxl0yaEBOZ()
		{
			return f22ZNlWsQOcNtq8ybcsV == null;
		}
	}

	private static readonly ILog iI5L7zy8jx2;

	public IList<Gesture> _gestures;

	public IDictionary<string, GestureAction> _gestureActions;

	private PointPatternAnalyzer nefLRwrSkvH = new PointPatternAnalyzer();

	private ers66j2xyiWRSpKLFdb jfpLRt4ZJM9;

	private System.Timers.Timer sNfLRgR6kM5 = new System.Timers.Timer(100.0);

	private System.Windows.Media.Brush FKmLRL3xyIL = System.Windows.Media.Brushes.Gray;

	private bool SENLRvprmVI;

	private Thread iI8LRSFVT0A;

	private AutoResetEvent cTjLR2YsWYt = new AutoResetEvent(false);

	[CompilerGenerated]
	private GestureAction UKRLRuI2jOI;

	[CompilerGenerated]
	private bool zK6LRNPKxG1;

	public long _lastMoveTicks;

	private Storyboard SbsLRJ9ZPn4;

	private IntPtr dyxLR0diN0p;

	private bool Y8OLRCeYMX6;

	[CompilerGenerated]
	private PointTargetInfo thwLRPlLZAO;

	private bool IiTLREWmnvF;

	private System.Windows.Point qL7LRyj1Ssg;

	private bool A5yLR83rDx9;

	private GestureAction JJhLRawWekw;

	private IList<GestureAction> aL8LR7AXJDK;

	internal GestureVisualHost GestureVisualHost;

	internal Border WrapperGestureName;

	internal TextBlock TxtGestureName;

	internal TextBlock TxtGestureChildActions;

	internal System.Windows.Controls.ListBox LbGestures;

	private bool TakLRRpPEqi;

	internal static GestureWindow fXgM2PF0x9Xk0fVmGc65;

	public GestureAction Result
	{
		[CompilerGenerated]
		get
		{
			return UKRLRuI2jOI;
		}
		[CompilerGenerated]
		private set
		{
			UKRLRuI2jOI = value;
		}
	}

	public bool IsWorking
	{
		[CompilerGenerated]
		get
		{
			return zK6LRNPKxG1;
		}
		[CompilerGenerated]
		private set
		{
			zK6LRNPKxG1 = value;
		}
	}

	public PointTargetInfo PointTargetInfo
	{
		[CompilerGenerated]
		get
		{
			return thwLRPlLZAO;
		}
		[CompilerGenerated]
		private set
		{
			thwLRPlLZAO = value;
		}
	}

	public GestureWindow()
	{
		InitializeComponent();
		base.SourceInitialized += RZ9L7MwuJCL;
		sNfLRgR6kM5.Elapsed += wSlL7jWarOL;
		iI8LRSFVT0A = new Thread(zsRL75o2jL9)
		{
			IsBackground = true
		};
		iI8LRSFVT0A.Start();
		base.Closed += KJrL71GjwXZ;
		r3HL7b6Yb7c();
	}

	private void KJrL71GjwXZ(object sender, EventArgs e)
	{
		IiTLREWmnvF = true;
	}

	protected override void OnActivated(EventArgs e)
	{
		base.OnActivated(e);
		if (PointTargetInfo != null)
		{
			base.Dispatcher.InvokeAsync(sX5L7AY8YOR);
		}
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		iI8LRSFVT0A?.Abort();
		sNfLRgR6kM5?.Stop();
	}

	private void r3HL7b6Yb7c()
	{
		SbsLRJ9ZPn4 = new Storyboard();
		SbsLRJ9ZPn4.FillBehavior = FillBehavior.HoldEnd;
		DoubleAnimation doubleAnimation = new DoubleAnimation(1.0, 0.0, new Duration(TimeSpan.FromMilliseconds(100.0)));
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity"));
		Storyboard.SetTarget(doubleAnimation, this);
		SbsLRJ9ZPn4.Children.Add(doubleAnimation);
		if (!jUsmuaF0Icolbd4xdusx())
		{
			switch (0)
			{
			}
		}
		SbsLRJ9ZPn4.Completed += LTQL7pkmOdt;
		if (SbsLRJ9ZPn4.CanFreeze)
		{
			SbsLRJ9ZPn4.Freeze();
		}
	}

	internal void BXZL76quEQh()
	{
		Rectangle workingArea = Screen.FromPoint(NativeMethods.GetMousePosition()).WorkingArea;
		NativeMethods.SetWindowPos(dyxLR0diN0p, NativeMethods.HWND_TOPMOST, workingArea.X, workingArea.Y, workingArea.Width, workingArea.Height, SetWindowPosFlags.SWP_DRAWFRAME | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_SHOWWINDOW);
	}

	internal void hwbL7X3BdVB()
	{
		NativeMethods.SetWindowPos(dyxLR0diN0p, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_HIDEWINDOW | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOOWNERZORDER | SetWindowPosFlags.SWP_NOREDRAW);
	}

	internal void hQlL7mZB1sL(IList<System.Windows.Point> ilist_1, IList<Gesture> ilist_2, IDictionary<string, GestureAction> idictionary_0, ers66j2xyiWRSpKLFdb ers66j2xyiWRSpKLFdb_1, bool bool_6, PointTargetInfo pointTargetInfo_1, IList<GestureAction> ilist_3)
	{
		if (ilist_1.Count != 0)
		{
			PointTargetInfo = pointTargetInfo_1;
			aL8LR7AXJDK = ilist_3;
			A5yLR83rDx9 = false;
			SbsLRJ9ZPn4.Stop();
			List<System.Windows.Point> ilist_4 = ilist_1.Select(base.PointFromScreen).ToList();
			_gestures = ilist_2;
			_gestureActions = idictionary_0;
			nefLRwrSkvH.PointPatternSet = ilist_2.Cast<PointPattern>().ToList();
			jfpLRt4ZJM9 = ers66j2xyiWRSpKLFdb_1;
			SENLRvprmVI = false;
			Result = null;
			Y8OLRCeYMX6 = false;
			_lastMoveTicks = AppHelper.fLiLTj0x4QY();
			sNfLRgR6kM5.Start();
			JJhLRawWekw = null;
			GestureVisualHost.Opacity = 1.0;
			if (bool_6)
			{
				Show();
			}
			WindowHelper.SetWindowExTransparent(dyxLR0diN0p, false);
			IsWorking = true;
			if (AppState.DataService.CpItmVISR7P().GestureHideTrack)
			{
				GestureVisualHost.Visibility = Visibility.Collapsed;
				return;
			}
			GestureVisualHost.Visibility = Visibility.Visible;
			GestureVisualHost.gyAOGICo7P(ilist_4);
			WrapperGestureName.Visibility = Visibility.Collapsed;
		}
	}

	internal void hrfL7KafprL()
	{
		nefLRwrSkvH.ResetCache();
	}

	internal void fGbL7xnwo7Y()
	{
		AppState.LogTriggerWindowHideTime();
		IsWorking = false;
		JJhLRawWekw = null;
		sNfLRgR6kM5.Stop();
		WindowHelper.SetWindowExTransparent(dyxLR0diN0p);
		AppHelper.RunOnUiThread(A5yLR83rDx9, r56L7Oovcu8);
	}

	internal void End(IList<System.Windows.Point> points = null)
	{
		fGbL7xnwo7Y();
		HSXL7rc841J(points);
	}

	private void HSXL7rc841J(IList<System.Windows.Point> ilist_1)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.C35SdN0F5R4 = ilist_1;
		if (Result != null)
		{
			if (Y8OLRCeYMX6)
			{
				return;
			}
			GestureAction gestureAction = Result;
			if (Result.ActionType == QuickActionType.InheritGlobal)
			{
				GestureAction gestureAction2 = vySL7o1Ac9d(gestureAction);
				if (gestureAction2 != null)
				{
					gestureAction = gestureAction2;
				}
			}
			QuickActionRunner.RunQuickActionAsync(this, gestureAction, AppState.Y2RtaqSv0AQ(), AppState.AppServer, true, ActionTrigger.Gesture, "", null, PointTargetInfo);
		}
		else if (AppState.DataService.CpItmVISR7P().GesturePlaybackUnknownGesture && _003C_003Ec__DisplayClass39_.C35SdN0F5R4.HasData() && _003C_003Ec__DisplayClass39_.C35SdN0F5R4.Count > 3)
		{
			Task.Run((Func<Task>)_003C_003Ec__DisplayClass39_.ynHSdu14E2V);
		}
	}

	private void LTQL7pkmOdt(object sender, EventArgs e)
	{
		GestureVisualHost.Refresh();
		GestureVisualHost.InvalidateVisual();
		apZL7BBECkl();
	}

	private void apZL7BBECkl()
	{
		Task.Run((Func<Task>)nkTL7FA4TN4);
	}

	internal void oIJL7QM4CSt(int int_0, int int_1)
	{
		if (!SENLRvprmVI)
		{
			System.Windows.Point point_ = (qL7LRyj1Ssg = PointFromScreen(new System.Windows.Point(int_0, int_1)));
			_lastMoveTicks = AppHelper.fLiLTj0x4QY();
			if (!AppState.DataService.CpItmVISR7P().GestureHideTrack)
			{
				GestureVisualHost.QNyOsjmGZK(point_);
			}
			cTjLR2YsWYt.Set();
		}
	}

	private void wSlL7jWarOL(object sender, ElapsedEventArgs e)
	{
		if (AppState.HHxtaMaoqJr().GestureHintListDelayMs > 100 && AppHelper.fLiLTj0x4QY() - _lastMoveTicks > AppState.HHxtaMaoqJr().GestureHintListDelayMs)
		{
			sNfLRgR6kM5.Stop();
			if (base.IsVisible)
			{
				base.Dispatcher.InvokeAsync(o6GL7UyjSiF);
			}
		}
	}

	private void NQoL7n0PesQ(bool bool_6, GestureAction gestureAction_2)
	{
        string text2 = default;
		string text;
		bool value;
		int num;
		int num2 = default(int);
		if (bool_6 && gestureAction_2 != null)
		{
			text = gestureAction_2.Description.Or(gestureAction_2.GetSummary()).Or("- 无 -");
			if (gestureAction_2.ActionType == QuickActionType.InheritGlobal)
			{
				GestureAction gestureAction = vySL7o1Ac9d(gestureAction_2);
				if (gestureAction != null)
				{
					text = gestureAction.Description.Or(gestureAction.GetSummary()).Or("- 无 -");
				}
			}
			if (AppState.HHxtaMaoqJr().GestureShowActionName)
			{
				value = false;
				if (AppState.HHxtaMaoqJr().GestureShowActionNameAtFixedPosition)
				{
					num = 0;
					if (jUsmuaF0Icolbd4xdusx())
					{
						goto IL_00dd;
					}
					goto IL_00ee;
				}
				TxtGestureName.Visibility = Visibility.Collapsed;
				GestureVisualHost.i3VOHuBWyE(text);
				num2 = 2;
				goto IL_0120;
			}
			goto IL_01a5;
		}
		GestureVisualHost.i3VOHuBWyE(null);
		TxtGestureName.Text = null;
		WrapperGestureName.Visibility = Visibility.Collapsed;
		GestureVisualHost.N6DObwTR7p(ColorHelper.StringToColor(AppState.HHxtaMaoqJr().GestureInvalidColor));
		return;
		IL_0193:
		WrapperGestureName.Visibility = value.ToVisibility();
		goto IL_01a5;
		IL_01a5:
		GestureVisualHost.N6DObwTR7p(ColorHelper.StringToColor(AppState.HHxtaMaoqJr().GestureValidColor));
		return;
		IL_00dd:
		switch (num)
		{
		case 2:
			goto IL_0120;
		case 1:
			goto IL_0159;
		}
		goto IL_00ee;
		IL_0120:
		GestureAction gestureAction2 = vySL7o1Ac9d(gestureAction_2);
		text2 = default(string);
		if (gestureAction_2.SubActions.HasData() || (gestureAction2 != null && gestureAction2.SubActions.HasData()))
		{
			text2 = UNCL74b9Mqt(gestureAction_2.SubActions, gestureAction2?.SubActions);
			num = 1;
			if (!jUsmuaF0Icolbd4xdusx())
			{
				num = num2;
			}
			goto IL_00dd;
		}
		TxtGestureChildActions.Text = "";
		TxtGestureChildActions.Visibility = Visibility.Collapsed;
		goto IL_0193;
		IL_0159:
		if (!string.IsNullOrEmpty(text2))
		{
			TxtGestureChildActions.Text = text2;
			TxtGestureChildActions.Visibility = (string.IsNullOrEmpty(TxtGestureChildActions.Text) ? Visibility.Collapsed : Visibility.Visible);
			value = true;
		}
		goto IL_0193;
		IL_00ee:
		TxtGestureName.Text = text;
		TxtGestureName.Visibility = Visibility.Visible;
		value = true;
		goto IL_0120;
	}

	private string UNCL74b9Mqt([CanBeNull] IList<SubAction> actionSubActions, [CanBeNull] IList<SubAction> globalSubActions)
	{
		if (actionSubActions == null && globalSubActions == null)
		{
			return "";
		}
		IList<SubAction> list = new List<SubAction>();
		if (actionSubActions != null)
		{
			list.AddRange(actionSubActions);
		}
		if (globalSubActions != null)
		{
			using IEnumerator<SubAction> enumerator = globalSubActions.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
				_003C_003Ec__DisplayClass47_.eQaSdCbf6i7 = enumerator.Current;
				if (!list.Any(_003C_003Ec__DisplayClass47_.BIVSd0B1tEr))
				{
					list.Add(_003C_003Ec__DisplayClass47_.eQaSdCbf6i7);
				}
			}
		}
		list = list.OrderBy(_003C_003Ec.fLGSdgmPWYo ?? (_003C_003Ec.fLGSdgmPWYo = _003C_003Ec.VBMSdtVkVue.MB7SDi0uE8c)).ToList();
		return string.Join("   ", list.Where(_003C_003Ec.QNaSdLU6Jxx ?? (_003C_003Ec.QNaSdLU6Jxx = _003C_003Ec.VBMSdtVkVue.svRSD3KBRT0)).Select(_003C_003Ec.XadSdvhyguK ?? (_003C_003Ec.XadSdvhyguK = _003C_003Ec.VBMSdtVkVue.JM9SDfdFqOW)));
	}

	private void zsRL75o2jL9()
	{
		while (!IiTLREWmnvF)
		{
			cTjLR2YsWYt.WaitOne();
			e2YL7DlxTMh();
		}
	}

	private void e2YL7DlxTMh()
	{
		if (!_gestures.HasData())
		{
			iI5L7zy8jx2.Warn("_gestures 为空。");
		}
		else if (!_gestureActions.HasData())
		{
			iI5L7zy8jx2.Warn("_gestureActions 为空。");
		}
		else if (jfpLRt4ZJM9 == null)
		{
			iI5L7zy8jx2.Warn("_mouseSession 为空。");
		}
		else
		{
			if (_gestures.Count < 1 || jfpLRt4ZJM9.Points.Count < 6)
			{
				return;
			}
			try
			{
				PointPatternMatchResult[] pointPatternMatchResults = nefLRwrSkvH.GetPointPatternMatchResults(jfpLRt4ZJM9.HM2tZ4X1XVi());
				if (pointPatternMatchResults.Length != 0 && pointPatternMatchResults[0].Probability > (double)AppState.HHxtaMaoqJr().GestureMinScore)
				{
					if (_gestureActions.TryGetValue(pointPatternMatchResults[0].PatternId, out var value))
					{
						FvcL7draLyh(value);
					}
					else
					{
						FvcL7draLyh(null);
					}
				}
				else
				{
					FvcL7draLyh(null);
				}
			}
			catch (Exception ex)
			{
				iI5L7zy8jx2.Warn("手势Analyze告警：" + ex.Message, ex);
			}
		}
	}

	private void FvcL7draLyh(GestureAction gestureAction_2)
	{
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
		_003C_003Ec__DisplayClass52_.wQ5SdEqp0Oy = this;
		_003C_003Ec__DisplayClass52_.retSdym6Lyb = gestureAction_2;
		if (JJhLRawWekw == _003C_003Ec__DisplayClass52_.retSdym6Lyb && Result == _003C_003Ec__DisplayClass52_.retSdym6Lyb)
		{
			return;
		}
		Result = _003C_003Ec__DisplayClass52_.retSdym6Lyb;
		int num = 0;
		if (fXgM2PF0x9Xk0fVmGc65 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		JJhLRawWekw = _003C_003Ec__DisplayClass52_.retSdym6Lyb;
		if (!AppState.DataService.CpItmVISR7P().GestureHideTrack)
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass52_.TUxSdPRE3K1);
		}
	}

	public void UpdateSettings()
	{
		GestureVisualHost.UpdateSettings();
	}

	[CanBeNull]
	private GestureAction vySL7o1Ac9d(GestureAction gestureAction_2)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.HEVSda7q52a = gestureAction_2;
		if (_003C_003Ec__DisplayClass54_.HEVSda7q52a == null)
		{
			return null;
		}
		GestureAction gestureAction = aL8LR7AXJDK?.FirstOrDefault(_003C_003Ec__DisplayClass54_.AkSSd8leVKh);
		if (gestureAction == _003C_003Ec__DisplayClass54_.HEVSda7q52a)
		{
			gestureAction = null;
		}
		return gestureAction;
	}

	public bool OnKeyDown(int eKeyCode)
	{
		int num = 1;
		GestureAction gestureAction2 = default(GestureAction);
		while (true)
		{
			int num2;
			Keys keys;
			if (IsWorking)
			{
				if (Result == null)
				{
					break;
				}
				sNfLRgR6kM5.Stop();
				GestureAction result = Result;
				GestureAction gestureAction = vySL7o1Ac9d(Result);
				if (result.SubActions.HasData() || (gestureAction != null && gestureAction.SubActions.HasData()))
				{
					var (subAction, flag) = AW6L7T6visB(eKeyCode, result, gestureAction);
					if (subAction != null)
					{
						ITinyMessengerHub hub = AppState.Y2RtaqSv0AQ();
						AppServer appServer = AppState.AppServer;
						object inputText;
						if (!flag)
						{
							inputText = "";
						}
						else
						{
							keys = (Keys)eKeyCode;
							inputText = keys.ToString();
						}
						QuickActionRunner.RunQuickActionAsync(this, subAction, hub, appServer, true, ActionTrigger.Gesture, (string)inputText, null, PointTargetInfo);
						Y8OLRCeYMX6 = true;
						return true;
					}
				}
				gestureAction2 = Result;
				if (gestureAction2.ActionType != QuickActionType.InheritGlobal)
				{
					goto IL_014e;
				}
				num2 = 3;
				if (fXgM2PF0x9Xk0fVmGc65 != null)
				{
					goto IL_00bb;
				}
			}
			else
			{
				num2 = 0;
				if (!jUsmuaF0Icolbd4xdusx())
				{
					goto IL_00bb;
				}
			}
			goto IL_00bf;
			IL_00bb:
			num2 = num;
			goto IL_00bf;
			IL_00bf:
			while (true)
			{
				switch (num2)
				{
				default:
					if (base.IsVisible)
					{
						goto IL_00a7;
					}
					goto case 2;
				case 1:
					break;
				case 2:
					return false;
				case 3:
					goto IL_0138;
				}
				break;
				IL_00a7:
				End(null);
				num2 = 2;
				if (jUsmuaF0Icolbd4xdusx())
				{
					continue;
				}
				goto IL_00bb;
			}
			continue;
			IL_014e:
			if ((AppState.HHxtaMaoqJr().GestureRepeatKey == 0 && eKeyCode == 112) || eKeyCode == AppState.HHxtaMaoqJr().GestureRepeatKey)
			{
				QuickActionRunner.RunQuickActionAsync(this, gestureAction2, AppState.Y2RtaqSv0AQ(), AppState.AppServer, true, ActionTrigger.Gesture, "", null, PointTargetInfo);
				sNfLRgR6kM5.Stop();
				Y8OLRCeYMX6 = true;
				return true;
			}
			if (!AppState.HHxtaMaoqJr().GestureEnableTriggerByKey || eKeyCode > 254)
			{
				break;
			}
			GestureAction cmd = gestureAction2;
			ITinyMessengerHub hub2 = AppState.Y2RtaqSv0AQ();
			AppServer appServer2 = AppState.AppServer;
			keys = (Keys)eKeyCode;
			QuickActionRunner.RunQuickActionAsync(this, cmd, hub2, appServer2, true, ActionTrigger.Gesture, keys.ToString(), null, PointTargetInfo);
			Y8OLRCeYMX6 = true;
			sNfLRgR6kM5.Stop();
			fGbL7xnwo7Y();
			return true;
			IL_0138:
			GestureAction gestureAction3 = vySL7o1Ac9d(Result);
			if (gestureAction3 != null)
			{
				gestureAction2 = gestureAction3;
			}
			goto IL_014e;
		}
		if (eKeyCode != 27 && eKeyCode != 1)
		{
			return false;
		}
		fGbL7xnwo7Y();
		return true;
	}

	private static (SubAction childAction, bool isAnyKeyMode) AW6L7T6visB(int int_0, GestureAction gestureAction_2, [CanBeNull] GestureAction global)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.iZ4SdqXkDgi = int_0;
		SubAction subAction = gestureAction_2.SubActions?.FirstOrDefault(_003C_003Ec__DisplayClass56_.O2tSd75pwHE);
		bool item = false;
		if (subAction == null)
		{
			subAction = global?.SubActions?.FirstOrDefault(_003C_003Ec__DisplayClass56_.tJSSdRWlMCE);
			if (subAction == null)
			{
				subAction = gestureAction_2.SubActions?.FirstOrDefault(_003C_003Ec.lifSdSv6Quc ?? (_003C_003Ec.lifSdSv6Quc = _003C_003Ec.VBMSdtVkVue.wFOSDzSLe6T));
				if (subAction == null)
				{
					subAction = global?.SubActions?.FirstOrDefault(_003C_003Ec.kSjSd2fOm6F ?? (_003C_003Ec.kSjSd2fOm6F = _003C_003Ec.VBMSdtVkVue.hitSdwqKfZe));
				}
				item = true;
			}
		}
		return (childAction: subAction, isAnyKeyMode: item);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!TakLRRpPEqi)
		{
			TakLRRpPEqi = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/gesturewindow.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			TakLRRpPEqi = true;
			break;
		case 1:
			GestureVisualHost = (GestureVisualHost)target;
			break;
		case 2:
			WrapperGestureName = (Border)target;
			break;
		case 3:
			TxtGestureName = (TextBlock)target;
			break;
		case 4:
			TxtGestureChildActions = (TextBlock)target;
			break;
		case 5:
			LbGestures = (System.Windows.Controls.ListBox)target;
			break;
		}
	}

	static GestureWindow()
	{
		iI5L7zy8jx2 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void RZ9L7MwuJCL(object sender, EventArgs e)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		dyxLR0diN0p = windowInteropHelper.Handle;
		int windowLong = NativeMethods.GetWindowLong(windowInteropHelper.Handle, -20);
		if (NativeMethods.SetWindowLong(windowInteropHelper.Handle, -20, (int)(windowLong | 0x80L | 0x8000000L | 8L)) == 0)
		{
			NativeMethods.GetLastError();
		}
	}

	[CompilerGenerated]
	private void sX5L7AY8YOR()
	{
		NativeMethods.SetForegroundWindow(PointTargetInfo.HWnd);
		NativeMethods.SetActiveWindow(PointTargetInfo.HWnd);
	}

	[CompilerGenerated]
	private void r56L7Oovcu8()
	{
		if (Result == null && LbGestures.Visibility == Visibility.Visible)
		{
			if (!jUsmuaF0Icolbd4xdusx())
			{
				switch (0)
				{
				}
			}
			if (LbGestures.SelectedItem is Gesture gesture && _gestureActions.TryGetValue(gesture.Id, out var value))
			{
				Result = value;
			}
		}
		GestureVisualHost.End();
		LbGestures.ItemsSource = null;
		LbGestures.Visibility = Visibility.Collapsed;
		if (AppState.HHxtaMaoqJr().GestureEnableHideEffect)
		{
			SbsLRJ9ZPn4.Begin();
			return;
		}
		GestureVisualHost.Refresh();
		apZL7BBECkl();
	}

	[AsyncStateMachine(typeof(_003C_003CHideWindowWithDelay_003Eb__41_0_003Ed))]
	[CompilerGenerated]
	private Task nkTL7FA4TN4()
	{
		_003C_003CHideWindowWithDelay_003Eb__41_0_003Ed stateMachine = default(_003C_003CHideWindowWithDelay_003Eb__41_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void o6GL7UyjSiF()
	{
		NQoL7n0PesQ(false, null);
		SENLRvprmVI = true;
		List<Gesture> itemsSource = nefLRwrSkvH.GetPointPatternMatchResults(jfpLRt4ZJM9.HM2tZ4X1XVi()).Take(7).Select(yH5L7lhli8F)
			.ToList();
		LbGestures.ItemsSource = itemsSource;
		LbGestures.Margin = new Thickness(qL7LRyj1Ssg.X - 50.0, qL7LRyj1Ssg.Y + 10.0, 0.0, 0.0);
		LbGestures.Visibility = Visibility.Visible;
		A5yLR83rDx9 = true;
		FvcL7draLyh(null);
	}

	[CompilerGenerated]
	private Gesture yH5L7lhli8F(PointPatternMatchResult pointPatternMatchResult_0)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.x = pointPatternMatchResult_0;
		return new Gesture(_003C_003Ec__DisplayClass45_.x.PatternId, _gestureActions[_003C_003Ec__DisplayClass45_.x.PatternId].Description + "(" + _003C_003Ec__DisplayClass45_.x.Probability.ToString("F1") + "%)", _gestures.First(_003C_003Ec__DisplayClass45_.KMkSdJ20Pas).WindowsPoints);
	}

	internal static bool jUsmuaF0Icolbd4xdusx()
	{
		return fXgM2PF0x9Xk0fVmGc65 == null;
	}
}
