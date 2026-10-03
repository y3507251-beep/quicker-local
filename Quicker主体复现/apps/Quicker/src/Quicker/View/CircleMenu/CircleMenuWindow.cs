using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using System.Windows.Media.Effects;
using JTIh7V5l65QV75A93Ly;
using log4net;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.View.CircleMenu;

public class CircleMenuWindow : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CDoHide_003Eb__33_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CircleMenuWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object c1M0LiWCOpYJnpY3fiY1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CircleMenuWindow circleMenuWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					int num2 = 0;
					if (!y0r2QNWCJyXdXIrGasYa())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				circleMenuWindow.WEpLZOjZWPT();
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

		internal static bool y0r2QNWCJyXdXIrGasYa()
		{
			return c1M0LiWCOpYJnpY3fiY1 == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct QVYOYjkK3n578pEQ7fp : IAsyncStateMachine
		{
			public int nmr2V3jwgAe;

			public AsyncTaskMethodBuilder lOK2VfqEc3V;

			private TaskAwaiter Mt02VzRZPko;

			private static object QWhqLfyqVa0DqhXv5EvO;

			private void MoveNext()
			{
				int num = nmr2V3jwgAe;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(150).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							nmr2V3jwgAe = 0;
							Mt02VzRZPko = awaiter;
							int num2 = 0;
							if (!HXuY3jyqQLTe4RZ7dUvr())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							lOK2VfqEc3V.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Mt02VzRZPko;
						Mt02VzRZPko = default(TaskAwaiter);
						num = -1;
						nmr2V3jwgAe = -1;
					}
					awaiter.GetResult();
					try
					{
						InputSimulator.Instance.Mouse.RightButtonClick();
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("出错了：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					nmr2V3jwgAe = -2;
					lOK2VfqEc3V.SetException(exception);
					return;
				}
				nmr2V3jwgAe = -2;
				lOK2VfqEc3V.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				lOK2VfqEc3V.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static QVYOYjkK3n578pEQ7fp()
			{
			}

			internal static bool HXuY3jyqQLTe4RZ7dUvr()
			{
				return QWhqLfyqVa0DqhXv5EvO == null;
			}

			internal static void kn7TW7yqysX5UofuVoLB()
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct KCeh6rkJrJDTJ5JdFaR : IAsyncStateMachine
		{
			public int KRX2Zwbg6Br;

			public AsyncTaskMethodBuilder mXL2ZtyFWB1;

			private TaskAwaiter omr2ZgSKINB;

			private static object CAKskpyqpjDVjxlCFMfJ;

			private void MoveNext()
			{
				int num = KRX2Zwbg6Br;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							KRX2Zwbg6Br = 0;
							omr2ZgSKINB = awaiter;
							mXL2ZtyFWB1.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (!D4oputyqXK8IM8mWBQgW())
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter = omr2ZgSKINB;
						omr2ZgSKINB = default(TaskAwaiter);
						num = -1;
						KRX2Zwbg6Br = -1;
					}
					awaiter.GetResult();
					InputSimulator.Instance.Mouse.RightButtonClick();
				}
				catch (Exception exception)
				{
					KRX2Zwbg6Br = -2;
					mXL2ZtyFWB1.SetException(exception);
					return;
				}
				KRX2Zwbg6Br = -2;
				mXL2ZtyFWB1.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				mXL2ZtyFWB1.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool D4oputyqXK8IM8mWBQgW()
			{
				return CAKskpyqpjDVjxlCFMfJ == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct mEStuKkRMPa9MXZHdmK : IAsyncStateMachine
		{
			public int kEs2ZLf8Gyy;

			public AsyncTaskMethodBuilder DoS2Zv9DGdS;

			private TaskAwaiter m8q2ZScu1jV;

			internal static object CxryeeyqASpdykrhEKgF;

			private void MoveNext()
			{
				int num = kEs2ZLf8Gyy;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							kEs2ZLf8Gyy = 0;
							m8q2ZScu1jV = awaiter;
							DoS2Zv9DGdS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = m8q2ZScu1jV;
						m8q2ZScu1jV = default(TaskAwaiter);
						num = -1;
						kEs2ZLf8Gyy = -1;
						int num2 = 0;
						if (!N8maGPyqnnW8p4qjfnC6())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
					}
					awaiter.GetResult();
					InputSimulator.Instance.Mouse.RightButtonClick();
				}
				catch (Exception exception)
				{
					kEs2ZLf8Gyy = -2;
					DoS2Zv9DGdS.SetException(exception);
					return;
				}
				kEs2ZLf8Gyy = -2;
				DoS2Zv9DGdS.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				DoS2Zv9DGdS.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool N8maGPyqnnW8p4qjfnC6()
			{
				return CxryeeyqASpdykrhEKgF == null;
			}
		}

		public static readonly _003C_003Ec TNPSoMYvxkJ;

		public static Func<Task> nWESoA7oVH2;

		public static Func<Task> nCHSoO37ZfO;

		public static Func<SubAction, bool> TscSoFBJtkQ;

		public static Func<Task> E2sSoUetDG2;

		internal static _003C_003Ec TcuaxJWCrIsq1yhMarAN;

		static _003C_003Ec()
		{
			TNPSoMYvxkJ = new _003C_003Ec();
		}

		[AsyncStateMachine(typeof(KCeh6rkJrJDTJ5JdFaR))]
		internal Task NJOSoDdfHlh()
		{
			KCeh6rkJrJDTJ5JdFaR stateMachine = default(KCeh6rkJrJDTJ5JdFaR);
			stateMachine.mXL2ZtyFWB1 = AsyncTaskMethodBuilder.Create();
			stateMachine.KRX2Zwbg6Br = -1;
			stateMachine.mXL2ZtyFWB1.Start(ref stateMachine);
			return stateMachine.mXL2ZtyFWB1.Task;
		}

		[AsyncStateMachine(typeof(QVYOYjkK3n578pEQ7fp))]
		internal Task J5WSodq8j4B()
		{
			QVYOYjkK3n578pEQ7fp stateMachine = default(QVYOYjkK3n578pEQ7fp);
			stateMachine.lOK2VfqEc3V = AsyncTaskMethodBuilder.Create();
			stateMachine.nmr2V3jwgAe = -1;
			stateMachine.lOK2VfqEc3V.Start(ref stateMachine);
			return stateMachine.lOK2VfqEc3V.Task;
		}

		internal bool nTuSoorpdxY(SubAction x)
		{
			return x.Key == 261;
		}

		[AsyncStateMachine(typeof(mEStuKkRMPa9MXZHdmK))]
		internal Task AnMSoTEa3bn()
		{
			mEStuKkRMPa9MXZHdmK stateMachine = default(mEStuKkRMPa9MXZHdmK);
			stateMachine.DoS2Zv9DGdS = AsyncTaskMethodBuilder.Create();
			stateMachine.kEs2ZLf8Gyy = -1;
			stateMachine.DoS2Zv9DGdS.Start(ref stateMachine);
			return stateMachine.DoS2Zv9DGdS.Task;
		}

		internal static bool AE0AMAWCNMp8aDaqdYkr()
		{
			return TcuaxJWCrIsq1yhMarAN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public CircleMenuWindow gpZSoiI5typ;

		public System.Drawing.Point YreSo3xcBLf;

		public bool wVeSofomWEH;

		internal static _003C_003Ec__DisplayClass54_0 Q54kZiWCLO6UoriZL97x;

		internal void YFASolinMNx()
		{
			ActionItem mouseOverAction = gpZSoiI5typ.CircleMenu.GetMouseOverAction(YreSo3xcBLf);
			if (mouseOverAction != null)
			{
				gpZSoiI5typ.DoHide();
				gpZSoiI5typ.ndTLZMW8Hng(mouseOverAction);
				return;
			}
			if (wVeSofomWEH && UIHelper.IsMouseOverElement(gpZSoiI5typ.BtnCorner, YreSo3xcBLf) && AppHelper.fLiLTj0x4QY() - gpZSoiI5typ._popupTime < 500L)
			{
				Func<Task> func = _003C_003Ec.nWESoA7oVH2;
				if (func == null)
				{
					int num = 0;
					if (Q54kZiWCLO6UoriZL97x != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					func = (_003C_003Ec.nWESoA7oVH2 = _003C_003Ec.TNPSoMYvxkJ.NJOSoDdfHlh);
				}
				Task.Run(func);
			}
			gpZSoiI5typ.DoHide();
		}

		internal static bool xu7Q1uWCuGgvpNIDoLt8()
		{
			return Q54kZiWCLO6UoriZL97x == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public ActionItem BXPSTttGDOg;

		public CircleMenuWindow nT7STgMAMNW;

		public System.Drawing.Point IRKSTLsqmh5;

		public int j9qSTvNfN5q;

		public bool AXMSTSCEW2c;

		public Func<SubAction, bool> iAoST2LqLbA;

		internal static _003C_003Ec__DisplayClass59_0 Sa8aelWCf46CuYkCHvCw;

		internal void eSSSozi26bN()
		{
			BXPSTttGDOg = nT7STgMAMNW.V4HL9wHa46k(IRKSTLsqmh5);
			if (BXPSTttGDOg != null && BXPSTttGDOg.ActionType == ActionType.TempAction)
			{
				CircleMenuAction circleMenuAction = (BXPSTttGDOg as CircleMenuTempAction)?.CircleMenuAction;
				if (circleMenuAction != null && circleMenuAction.SubActions.HasData())
				{
					SubAction subAction = circleMenuAction.SubActions.FirstOrDefault(iAoST2LqLbA ?? (iAoST2LqLbA = W2qSTwYvb0p));
					bool flag = false;
					if (subAction == null)
					{
						int num = 1;
						if (!jBAthqWCbUWdISElQldK())
						{
							int num2 = default(int);
							num = num2;
						}
						do
						{
							IList<SubAction> subActions;
							Func<SubAction, bool> predicate;
							switch (num)
							{
							case 1:
								subActions = circleMenuAction.SubActions;
								predicate = _003C_003Ec.TscSoFBJtkQ ?? (_003C_003Ec.TscSoFBJtkQ = _003C_003Ec.TNPSoMYvxkJ.nTuSoorpdxY);
								goto IL_00d7;
							}
							break;
							IL_00d7:
							subAction = subActions.FirstOrDefault(predicate);
							flag = true;
							num = 0;
						}
						while (jBAthqWCbUWdISElQldK());
					}
					if (subAction != null)
					{
						CircleMenuWindow sender = nT7STgMAMNW;
						SubAction cmd = subAction;
						ITinyMessengerHub lJsL98xGglp = nT7STgMAMNW.LJsL98xGglp;
						AppServer tTTL9RvbHxT = nT7STgMAMNW.tTTL9RvbHxT;
						object inputText;
						if (!flag)
						{
							inputText = "";
						}
						else
						{
							Keys keys = (Keys)j9qSTvNfN5q;
							inputText = keys.ToString();
						}
						QuickActionRunner.RunQuickActionAsync(sender, cmd, lJsL98xGglp, tTTL9RvbHxT, true, ActionTrigger.CircleMenu, (string)inputText, null, nT7STgMAMNW.PointTargetInfo, KeyboardHelper.IsKeyDown(VirtualKeyCode.RSHIFT), circleMenuAction.DelayMs);
						nT7STgMAMNW.i9TL99TObPu = true;
						AXMSTSCEW2c = true;
					}
				}
			}
			if (!AXMSTSCEW2c)
			{
				if (j9qSTvNfN5q == 257)
				{
					nT7STgMAMNW.xYyL9v1xq1U();
					AXMSTSCEW2c = true;
				}
				else if (j9qSTvNfN5q == 258)
				{
					nT7STgMAMNW.IQnL9LRIMj5();
					AXMSTSCEW2c = true;
				}
			}
		}

		internal bool W2qSTwYvb0p(SubAction x)
		{
			return x.Key == j9qSTvNfN5q;
		}

		internal static bool jBAthqWCbUWdISElQldK()
		{
			return Sa8aelWCf46CuYkCHvCw == null;
		}
	}

	private static readonly ILog RRkL9ypfUQj;

	private readonly ITinyMessengerHub LJsL98xGglp;

	private readonly PopupState Ic9L9as2fk2;

	private readonly DataService AulL979r08D;

	private readonly AppServer tTTL9RvbHxT;

	private System.Threading.Timer bnfL9q4STai;

	[CompilerGenerated]
	private PointTargetInfo ONrL9crDQpf;

	[CompilerGenerated]
	private IntPtr wrVL9VkDD5O;

	[CompilerGenerated]
	private bool YTqL9Z0f8hM;

	public long _popupTime;

	private bool i9TL99TObPu;

	private int KluL9hrBtcu;

	[CompilerGenerated]
	private bool xvgL9eJ7pi2;

	private ExeSettings uaEL9Y7QGvY;

	private ExeSettings RyML9IPco4M;

	private bool usUL9WWw4Nk;

	private DateTime UwZL9kRF8Hy = DateTime.Now;

	internal Grid MainGrid;

	internal Border CircleWrapper;

	internal CircleActionMenu CircleMenu;

	internal ActionButton BtnCorner;

	private bool AdrL9GD6xVk;

	internal static CircleMenuWindow lr8pHJFvhxXsNWGwGcTE;

	public PointTargetInfo PointTargetInfo
	{
		[CompilerGenerated]
		get
		{
			return ONrL9crDQpf;
		}
		[CompilerGenerated]
		set
		{
			ONrL9crDQpf = value;
		}
	}

	public IntPtr hwnd
	{
		[CompilerGenerated]
		get
		{
			return wrVL9VkDD5O;
		}
		[CompilerGenerated]
		private set
		{
			wrVL9VkDD5O = value;
		}
	}

	public bool IsWorking
	{
		[CompilerGenerated]
		get
		{
			return YTqL9Z0f8hM;
		}
		[CompilerGenerated]
		set
		{
			YTqL9Z0f8hM = value;
		}
	}

	public bool ShowExternalCircle
	{
		[CompilerGenerated]
		get
		{
			return xvgL9eJ7pi2;
		}
		[CompilerGenerated]
		private set
		{
			xvgL9eJ7pi2 = value;
		}
	}

	public CircleMenuWindow(ITinyMessengerHub hub, PopupState popupState, DataService dataService, AppServer appServer)
	{
		LJsL98xGglp = hub;
		Ic9L9as2fk2 = popupState;
		AulL979r08D = dataService;
		tTTL9RvbHxT = appServer;
		base.WindowStyle = WindowStyle.None;
		base.AllowsTransparency = true;
		InitializeComponent();
		BtnCorner.ClearIconColorBinding();
		base.Loaded += kejLZTpkix1;
		base.Closing += g8NLZolqso1;
		base.DpiChanged += j8RLZ5Eg20X;
		base.Activated += dxPLZ4gvSOY;
		base.IsVisibleChanged += J8nLZddllWa;
		base.SourceInitialized += QjgL92w7WMs;
		SetValue(ActionButton.EmptyHoverColorProperty, System.Windows.Media.Brushes.Transparent);
		SetValue(ActionButton.HoverColorProperty, System.Windows.Media.Brushes.Transparent);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (!AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return new FakeWindowsPeer(this);
		}
		return base.OnCreateAutomationPeer();
	}

	private IntPtr Hook(IntPtr intPtr, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
	{
		if (msg == 736)
		{
			float num = (float)(wparam.ToInt32() & 0xFFFF) / 96f;
			handled = true;
		}
		return IntPtr.Zero;
	}

	private void dxPLZ4gvSOY(object sender, EventArgs e)
	{
		if (PointTargetInfo != null)
		{
			base.Dispatcher.InvokeAsync(pSTL9uUIMx1);
		}
	}

	private void j8RLZ5Eg20X(object sender, System.Windows.DpiChangedEventArgs e)
	{
		e.Handled = true;
	}

	private void jAMLZDsqrYQ(object object_0)
	{
		if (bnfL9q4STai == null)
		{
			return;
		}
		try
		{
			bnfL9q4STai?.Dispose();
		}
		catch (Exception ex)
		{
			RRkL9ypfUQj.Warn("释放timertimer出错：" + ex.Message);
		}
		finally
		{
			bnfL9q4STai = null;
		}
		if (IsWorking)
		{
			AppHelper.RunOnUiThread(false, DoHide);
		}
	}

	private void J8nLZddllWa(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (!base.IsVisible)
		{
			MORLZlWT9K7();
		}
		else
		{
			bool isVisible = base.IsVisible;
		}
	}

	private void g8NLZolqso1(object sender, CancelEventArgs e)
	{
	}

	private void kejLZTpkix1(object sender, RoutedEventArgs e)
	{
	}

	private void CircleMenu_OnActionSelected(object sender, CircleMenuEventArgs e)
	{
		DoHide();
		ActionItem action = e.Action;
		ndTLZMW8Hng(action);
	}

	private void ndTLZMW8Hng(ActionItem actionItem_0)
	{
		if (actionItem_0 != null)
		{
			if (actionItem_0.ActionType == ActionType.TempAction)
			{
				CircleMenuAction circleMenuAction = (actionItem_0 as CircleMenuTempAction).CircleMenuAction;
				QuickActionRunner.RunQuickActionAsync(this, circleMenuAction, LJsL98xGglp, tTTL9RvbHxT, true, ActionTrigger.CircleMenu, "", null, PointTargetInfo, KeyboardHelper.IsKeyDown(VirtualKeyCode.RSHIFT), circleMenuAction.DelayMs);
			}
			else
			{
				LJsL98xGglp.NotifyRunAction(this, actionItem_0.Id, KeyboardHelper.IsKeyDown(VirtualKeyCode.RSHIFT), false, ActionTrigger.CircleMenu, true, PointTargetInfo);
			}
		}
	}

	private void N2mLZAac79C(object sender, MouseButtonEventArgs e)
	{
		DoHide();
	}

	public void DoHide()
	{
		if (IsWorking)
		{
			AppState.LogTriggerWindowHideTime();
			IsWorking = false;
			WindowHelper.SetWindowExTransparent(hwnd);
			AppHelper.RunOnUiThread(false, FAtL9NWetDK);
		}
	}

	private void WEpLZOjZWPT()
	{
		NativeMethods.SetWindowPos(hwnd, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_HIDEWINDOW | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOMOVE);
	}

	private void DX6LZFYW3uS()
	{
		NativeMethods.SetWindowPos(hwnd, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_SHOWWINDOW);
	}

	public void TriggerShow(PointTargetInfo pointTargetInfo, ExeSettings exeSettings, bool forClick, bool onlyCurrentExeActions = false)
	{
		IsWorking = true;
		_popupTime = AppHelper.fLiLTj0x4QY();
		i9TL99TObPu = false;
		ShowExternalCircle = forClick && AppState.HHxtaMaoqJr().CircleMenuShowExternalWhenPopup && AulL979r08D.HnJtXqHvdn3();
		usUL9WWw4Nk = forClick;
		KluL9hrBtcu = 0;
		AppState.Lista4qx2wK().CountCircleMenu();
		int num;
		if (ShowExternalCircle)
		{
			CircleMenu.SetExternItemsVisibility(true);
			CircleMenu.Width = 600.0;
			num = 0;
			if (lr8pHJFvhxXsNWGwGcTE != null)
			{
				goto IL_00e5;
			}
			goto IL_00f6;
		}
		CircleMenu.SetExternItemsVisibility(false);
		CircleMenu.Width = 420.0;
		CircleMenu.Height = 420.0;
		goto IL_010a;
		IL_00f6:
		CircleMenu.Height = 600.0;
		goto IL_010a;
		IL_00c1:
		WindowHelper.SetWindowExTransparent(hwnd, false);
		PointTargetInfo = pointTargetInfo;
		num = 1;
		if (!vDsXPyFvHxllZIBcg199())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00e5;
		IL_010a:
		BtnCorner.IsHitTestVisible = usUL9WWw4Nk;
		num = 1;
		if (lr8pHJFvhxXsNWGwGcTE == null)
		{
			goto IL_00c1;
		}
		goto IL_00e5;
		IL_00e5:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_00f6;
		case 1:
			RyML9IPco4M = AulL979r08D.yQWt6ownR4Z("_global", true);
			uaEL9Y7QGvY = exeSettings;
			CircleMenu.Clear();
			KluL9hrBtcu = (onlyCurrentExeActions ? 1 : 0);
			W0jLZU9XjMd();
			base.ShowActivated = false;
			if (!base.IsLoaded)
			{
				base.Width = AppState.HHxtaMaoqJr().CircleMenuSize;
				base.Height = AppState.HHxtaMaoqJr().CircleMenuSize;
				Show();
			}
			else
			{
				BiLLZiHa3oW();
			}
			base.WindowState = WindowState.Normal;
			if (AulL979r08D.CpItmVISR7P().CircleMenuTimeoutMs > 100)
			{
				MORLZlWT9K7();
				bnfL9q4STai = new System.Threading.Timer(jAMLZDsqrYQ, this, AulL979r08D.CpItmVISR7P().CircleMenuTimeoutMs, -1);
			}
			return;
		}
		goto IL_00c1;
	}

	private void W0jLZU9XjMd()
	{
		for (int i = 0; i < CircleMenu.Circle1ActionCount; i++)
		{
			CircleMenu.SetPosition(i, m8dL9CugYst(i));
		}
		for (int j = 100; j < CircleMenu.Circle2ActionCount + 100; j++)
		{
			CircleMenu.SetPosition(j, m8dL9CugYst(j));
		}
		for (int k = 200; k < CircleMenu.Circle3ActionCount + 200; k++)
		{
			CircleMenu.SetPosition(k, m8dL9CugYst(k));
		}
		BtnCorner.SetAction(null);
	}

	private void MORLZlWT9K7()
	{
		if (bnfL9q4STai != null)
		{
			bnfL9q4STai.Dispose();
			bnfL9q4STai = null;
		}
	}

	private void BiLLZiHa3oW()
	{
		(int, int) tuple = IHNRIiikxBwJdYmHpM3.WGEvSL7K2PN(this, ShowWindowLocation.ByCenterLocation, PointTargetInfo.Point.X, PointTargetInfo.Point.Y, AulL979r08D.CpItmVISR7P().CircleMenuLimitInScreen, AulL979r08D.CpItmVISR7P().CircleMenuAutoMoveCursor);
		NativeMethods.SetWindowPos(hwnd, NativeMethods.HWND_TOPMOST, tuple.Item1, tuple.Item2, 0, 0, SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_DRAWFRAME | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_SHOWWINDOW);
	}

	public void TryTriggerExternAction()
	{
		if (!AulL979r08D.HnJtXqHvdn3())
		{
			AppHelper.ShowWarning("轮盘菜单扩展圈需要购买专业版后使用。\n(免费版可试用90天扩展圈)");
			return;
		}
		ActionItem actionItem = BtnCorner.ActionItem;
		if (actionItem != null)
		{
			ndTLZMW8Hng(actionItem);
		}
	}

	private void O13LZ3PKlNv(int int_1, ExeSettings exeSettings_2, ExeSettings exeSettings_3)
	{
		int num = 1;
		while (true)
		{
			string key = int_1.ToString();
			int num2 = 0;
			if (!vDsXPyFvHxllZIBcg199())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (exeSettings_2 != null && exeSettings_2.CircleMenuActions != null && exeSettings_2.CircleMenuActions.ContainsKey(key) && !string.IsNullOrEmpty(exeSettings_2.CircleMenuActions[key]))
			{
				CircleMenu.SetPosition(int_1, TempActionCreator.CreateTempAction(exeSettings_2.CircleMenuActions[key], true));
			}
			else if (exeSettings_3 != null && exeSettings_3.CircleMenuActions != null && exeSettings_3.CircleMenuActions.ContainsKey(key) && !string.IsNullOrEmpty(exeSettings_3.CircleMenuActions[key]))
			{
				CircleMenu.SetPosition(int_1, TempActionCreator.CreateTempAction(exeSettings_3.CircleMenuActions[key], true));
			}
			return;
		}
	}

	public void OnMouseMoveFromHook(System.Drawing.Point pt)
	{
		if (!IsWorking)
		{
			return;
		}
		if (IsMouseOnWindow(pt))
		{
			CircleMenu.OnMouseMoveAboveWindow(new System.Windows.Point(pt.X, pt.Y));
			if (!AppState.HHxtaMaoqJr().CircleMenuHideLabelIfHaveIcon || !AppState.HHxtaMaoqJr().CircleMenuShowLabelInCenterWhenHideLabel)
			{
				BtnCorner.SetAction(null);
				return;
			}
		}
		else
		{
			System.Windows.Point point = new System.Windows.Point(pt.X, pt.Y);
			int num = 1;
			if (lr8pHJFvhxXsNWGwGcTE != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
			{
				System.Windows.Point point2 = CircleMenu.PointFromScreen(point);
				double num3 = CircleMenu.Width / 2.0;
				double num4 = CircleMenu.Height / 2.0;
				double num5 = Math.Atan2(point2.Y - num4, point2.X - num3);
				int num6 = GZiLZfHKr0J(num5);
				ActionItem itemAction = CircleMenu.GetItemAction(200 + num6);
				BtnCorner.SetAction(itemAction);
				ActionButton.SetShrinkTitle(BtnCorner, true);
				CircleMenu.OnMouseMoveOutsideWindow(num5);
				return;
			}
			}
		}
		ActionItem mouseOverAction = CircleMenu.GetMouseOverAction(pt);
		if (mouseOverAction != null)
		{
			BtnCorner.SetAction(new ActionItem
			{
				Title = mouseOverAction.Title
			});
		}
		else
		{
			BtnCorner.SetAction(null);
		}
	}

	private static int GZiLZfHKr0J(double double_0)
	{
		if (double_0 < 0.0)
		{
			double_0 = Math.PI * 2.0 + double_0;
		}
		double_0 += Math.PI * 5.0 / 8.0;
		if (double_0 > Math.PI * 2.0)
		{
			double_0 -= Math.PI * 2.0;
		}
		return (int)(double_0 * 4.0 / Math.PI);
	}

	public void UpdateUi()
	{
		int num = 2;
		CircleMenuUiSettings circleMenu = default(CircleMenuUiSettings);
		while (true)
		{
			SetValue(ActionButton.HideLabelIfHasIconProperty, AulL979r08D.CpItmVISR7P().CircleMenuHideLabelIfHaveIcon);
			int num2 = 1;
			if (lr8pHJFvhxXsNWGwGcTE != null)
			{
				goto IL_0124;
			}
			goto IL_025f;
			IL_025f:
			switch (num2)
			{
			case 5:
				break;
			case 3:
				goto IL_00e3;
			case 1:
				goto IL_0124;
			default:
				goto IL_01aa;
			case 2:
				continue;
			case 4:
				goto end_IL_0281;
			}
			goto IL_000e;
			IL_0124:
			Border circleWrapper = CircleWrapper;
			double width = (CircleWrapper.Height = AulL979r08D.CpItmVISR7P().CircleMenuSize);
			circleWrapper.Width = width;
			ActionButton btnCorner = BtnCorner;
			width = (BtnCorner.Height = AulL979r08D.CpItmVISR7P().CircleMenuSize * 50.0 / 420.0);
			btnCorner.Width = width;
			circleMenu = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().CircleMenu;
			num2 = 0;
			if (lr8pHJFvhxXsNWGwGcTE != null)
			{
				goto IL_01aa;
			}
			goto IL_025f;
			IL_01aa:
			if (!string.IsNullOrEmpty(circleMenu.LabelColor))
			{
				SetValue(ActionButton.LabelColorProperty, circleMenu.LabelColor.GetBrush());
			}
			if (!string.IsNullOrEmpty(circleMenu.DefaultIconColor))
			{
				SetValue(ActionButton.DefaultIconColorProperty, circleMenu.DefaultIconColor);
			}
			if (!string.IsNullOrEmpty(circleMenu.ButtonBgColor))
			{
				if (circleMenu.ButtonBgColor == "#00000000")
				{
					SetValue(RadialMenuItem.ButtonBgProperty, System.Windows.Media.Color.FromArgb(1, 0, 0, 0).GetBrush());
				}
				else
				{
					SetValue(RadialMenuItem.ButtonBgProperty, circleMenu.ButtonBgColor.GetBrush());
				}
			}
			else
			{
				SetValue(RadialMenuItem.ButtonBgProperty, System.Windows.Media.Brushes.Transparent);
			}
			goto IL_00e3;
			IL_000e:
			if (!string.IsNullOrEmpty(circleMenu.ButtonSpaceColor))
			{
				SetValue(RadialMenuItem.SpaceColorProperty, circleMenu.ButtonSpaceColor.GetBrush());
			}
			if (!string.IsNullOrEmpty(circleMenu.IndicateLineColor))
			{
				CircleMenu.IndicateLineBrush = circleMenu.IndicateLineColor.GetBrush();
				BtnCorner.LabelColor = circleMenu.IndicateLineColor.GetBrush();
			}
			CircleMenu.BgOverlayOpacity = circleMenu.BgOverlyOpacity;
			if (circleMenu.BgOverlyOpacity > 0.0)
			{
				CircleMenu.BgOverlayFill = GwdLZzOYPpV(circleMenu.BgOverlyFill);
			}
			else
			{
				CircleMenu.BgOverlayFill = System.Windows.Media.Brushes.Transparent;
			}
			CircleMenu.BgOpacity = circleMenu.BgOpacity;
			num2 = 3;
			if (lr8pHJFvhxXsNWGwGcTE == null)
			{
				break;
			}
			goto IL_025f;
			IL_00e3:
			if (string.IsNullOrEmpty(circleMenu.ButtonHoverColor))
			{
				goto IL_000e;
			}
			SetValue(RadialMenuItem.HoverColorProperty, circleMenu.ButtonHoverColor.GetBrush());
			num2 = 5;
			if (lr8pHJFvhxXsNWGwGcTE != null)
			{
				num2 = num;
			}
			goto IL_025f;
			continue;
			end_IL_0281:
			break;
		}
		if (circleMenu.BgOpacity > 0.0)
		{
			CircleMenu.BgFill = GwdLZzOYPpV(circleMenu.BgFill);
		}
		else
		{
			CircleMenu.BgFill = System.Windows.Media.Brushes.Transparent;
		}
		if (circleMenu.ShowShadow)
		{
			MainGrid.Margin = new Thickness(10.0);
			CircleWrapper.Effect = new DropShadowEffect
			{
				BlurRadius = 15.0,
				Direction = -90.0,
				Opacity = 0.4,
				RenderingBias = RenderingBias.Quality,
				ShadowDepth = 5.0,
				Color = System.Windows.Media.Color.FromArgb(byte.MaxValue, 160, 160, 160)
			};
		}
		else
		{
			MainGrid.Margin = new Thickness(0.0);
			CircleWrapper.Effect = null;
		}
		base.FontSize = AulL979r08D.CpItmVISR7P().CircleMenuFontSize;
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		if (AppState.DataService.Hb9tmk3OsJ7())
		{
			string text = (uiSettings.FontFamily1 + "," + uiSettings.FontFamily2).Trim(',');
			try
			{
				if (string.IsNullOrEmpty(text))
				{
					base.FontFamily = System.Windows.SystemFonts.CaptionFontFamily;
				}
				else
				{
					base.FontFamily = new System.Windows.Media.FontFamily(text);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("设置面板字体（" + text + "）失败：" + ex.Message);
			}
			base.FontWeight = FontWeight.FromOpenTypeWeight(uiSettings.FontWeight);
		}
		UIHelper.DisableWindowTooltip(this, AppState.HHxtaMaoqJr().HidePanelToolTip);
	}

	private System.Windows.Media.Brush GwdLZzOYPpV(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return System.Windows.Media.Brushes.White;
		}
		System.Windows.Media.Brush result;
		try
		{
			if (string_0.StartsWith("#"))
			{
				string[] array = string_0.Split(new char[2] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 1)
				{
					result = array[0].GetBrush();
					int num = 0;
					if (!vDsXPyFvHxllZIBcg199())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				else if (array.Length == 2)
				{
					RadialGradientBrush radialGradientBrush = new RadialGradientBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(array[0]), (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(array[1]));
					radialGradientBrush.TryFreeze();
					result = radialGradientBrush;
				}
				else
				{
					AppHelper.ShowWarning("不支持的画刷定义：" + string_0);
					result = System.Windows.Media.Brushes.White;
				}
			}
			else
			{
				try
				{
					if (!string_0.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !File.Exists(string_0))
					{
						AppHelper.ShowWarning("轮盘背景图片不存在：" + string_0);
						result = System.Windows.Media.Brushes.White;
					}
					else
					{
						ImageBrush obj = new ImageBrush(ImageCache.GetImageSource(string_0))
						{
							Stretch = Stretch.UniformToFill
						};
						obj.TryFreeze();
						result = obj;
					}
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("不支持的画刷定义：" + string_0 + " " + exception.GetMessageWithInner());
					result = System.Windows.Media.Brushes.White;
				}
			}
		}
		catch (Exception exception2)
		{
			AppHelper.ShowWarning("轮盘外观参数不正确。" + exception2.GetMessageWithInner());
			result = System.Windows.Media.Brushes.White;
		}
		return result;
	}

	public bool IsMouseOnWindow(System.Drawing.Point pt)
	{
		return hwnd == NativeMethods.WindowFromPhysicalPoint(pt);
	}

	public void TriggerActionByLocation(System.Drawing.Point point, bool byPen)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.gpZSoiI5typ = this;
		_003C_003Ec__DisplayClass54_.YreSo3xcBLf = point;
		_003C_003Ec__DisplayClass54_.wVeSofomWEH = byPen;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass54_.YFASolinMNx);
	}

	private void BtnCorner_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		DoHide();
		Task.Run(_003C_003Ec.nCHSoO37ZfO ?? (_003C_003Ec.nCHSoO37ZfO = _003C_003Ec.TNPSoMYvxkJ.J5WSodq8j4B));
	}

	private ActionItem V4HL9wHa46k(System.Drawing.Point point_0)
	{
		if (IsMouseOnWindow(point_0))
		{
			return CircleMenu.GetMouseOverAction(point_0);
		}
		if (!AulL979r08D.HnJtXqHvdn3() && CnuL9tK9ZBc() != null)
		{
			if ((DateTime.Now - UwZL9kRF8Hy).TotalSeconds > 5.0)
			{
				AppHelper.ShowWarning("轮盘菜单扩展圈需要购买专业版后使用。如果您已购买，请重启Quicker生效。\n(免费版可试用90天扩展圈)");
				UwZL9kRF8Hy = DateTime.Now;
			}
			return null;
		}
		return CnuL9tK9ZBc();
	}

	private ActionItem CnuL9tK9ZBc()
	{
		return BtnCorner.ActionItem;
	}

	internal bool JMXL9glYsxj(int int_1, System.Drawing.Point? nullable_0 = null)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.nT7STgMAMNW = this;
		_003C_003Ec__DisplayClass59_.j9qSTvNfN5q = int_1;
		if (!IsWorking)
		{
			return false;
		}
		if (_003C_003Ec__DisplayClass59_.j9qSTvNfN5q == 1 && usUL9WWw4Nk)
		{
			return false;
		}
		MORLZlWT9K7();
		_003C_003Ec__DisplayClass59_.IRKSTLsqmh5 = nullable_0 ?? NativeMethods.GetMousePosition();
		_003C_003Ec__DisplayClass59_.AXMSTSCEW2c = false;
		_003C_003Ec__DisplayClass59_.BXPSTttGDOg = null;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass59_.eSSSozi26bN);
		if (_003C_003Ec__DisplayClass59_.AXMSTSCEW2c)
		{
			return true;
		}
		if (_003C_003Ec__DisplayClass59_.BXPSTttGDOg != null && (_003C_003Ec__DisplayClass59_.j9qSTvNfN5q == 112 || _003C_003Ec__DisplayClass59_.j9qSTvNfN5q == AppState.HHxtaMaoqJr().CircleMenuRepeatKey))
		{
			ndTLZMW8Hng(_003C_003Ec__DisplayClass59_.BXPSTttGDOg);
			i9TL99TObPu = true;
			return true;
		}
		if (_003C_003Ec__DisplayClass59_.j9qSTvNfN5q != 27 && _003C_003Ec__DisplayClass59_.j9qSTvNfN5q != 1)
		{
			return false;
		}
		DoHide();
		return true;
	}

	private void IQnL9LRIMj5()
	{
		if (KluL9hrBtcu < 1)
		{
			KluL9hrBtcu++;
			W0jLZU9XjMd();
		}
	}

	private void xYyL9v1xq1U()
	{
		if (KluL9hrBtcu > -1)
		{
			KluL9hrBtcu--;
			W0jLZU9XjMd();
		}
	}

	internal void i5FL9Sk9QEf(System.Drawing.Point? nullable_0 = null, bool bool_5 = false)
	{
		if (i9TL99TObPu)
		{
			DoHide();
			return;
		}
		System.Drawing.Point point = nullable_0 ?? NativeMethods.GetMousePosition();
		ActionItem actionItem = V4HL9wHa46k(point);
		DoHide();
		if (actionItem != null)
		{
			ndTLZMW8Hng(actionItem);
		}
		else if (bool_5 && UIHelper.IsMouseOverElement(BtnCorner, point) && AppHelper.fLiLTj0x4QY() - _popupTime < 500L)
		{
			Task.Run(_003C_003Ec.E2sSoUetDG2 ?? (_003C_003Ec.E2sSoUetDG2 = _003C_003Ec.TNPSoMYvxkJ.AnMSoTEa3bn));
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!AdrL9GD6xVk)
		{
			AdrL9GD6xVk = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/circlemenu/circlemenuwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			AdrL9GD6xVk = true;
			break;
		case 1:
			((CircleMenuWindow)target).MouseUp += N2mLZAac79C;
			break;
		case 2:
			MainGrid = (Grid)target;
			break;
		case 3:
			CircleWrapper = (Border)target;
			break;
		case 4:
			CircleMenu = (CircleActionMenu)target;
			break;
		case 5:
			BtnCorner = (ActionButton)target;
			break;
		}
	}

	static CircleMenuWindow()
	{
		RRkL9ypfUQj = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void QjgL92w7WMs(object sender, EventArgs e)
	{
		double width = (base.Height = AulL979r08D.CpItmVISR7P().CircleMenuSize);
		base.Width = width;
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
		hwnd = windowInteropHelper.Handle;
		int windowLong = NativeMethods.GetWindowLong(windowInteropHelper.Handle, -20);
		NativeMethods.SetWindowLong(windowInteropHelper.Handle, -20, (int)(windowLong | 0x8000000L));
		UpdateUi();
		if (PointTargetInfo != null)
		{
			BiLLZiHa3oW();
		}
	}

	[CompilerGenerated]
	private void pSTL9uUIMx1()
	{
		NativeMethods.SetForegroundWindow(PointTargetInfo.HWnd);
		NativeMethods.SetActiveWindow(PointTargetInfo.HWnd);
	}

	[CompilerGenerated]
	private void FAtL9NWetDK()
	{
		CircleMenu.ResetLine();
		this.Refresh();
		Task.Run((Func<Task>)HeLL9J6GtHp);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CDoHide_003Eb__33_1_003Ed))]
	private Task HeLL9J6GtHp()
	{
		_003C_003CDoHide_003Eb__33_1_003Ed stateMachine = default(_003C_003CDoHide_003Eb__33_1_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	internal static ActionItem dBML90P7vOx(string string_0, ExeSettings exeSettings_2)
	{
		if (exeSettings_2 != null && exeSettings_2.CircleMenuActions != null && exeSettings_2.CircleMenuActions.ContainsKey(string_0) && !string.IsNullOrEmpty(exeSettings_2.CircleMenuActions[string_0]))
		{
			return TempActionCreator.CreateTempAction(exeSettings_2.CircleMenuActions[string_0], true);
		}
		return null;
	}

	[CompilerGenerated]
	private ActionItem m8dL9CugYst(int int_1)
	{
		string string_ = int_1.ToString();
		if (KluL9hrBtcu == 0)
		{
			ActionItem actionItem = dBML90P7vOx(string_, uaEL9Y7QGvY);
			if (actionItem != null)
			{
				return actionItem;
			}
			return dBML90P7vOx(string_, RyML9IPco4M);
		}
		if (KluL9hrBtcu < 0)
		{
			return dBML90P7vOx(string_, RyML9IPco4M);
		}
		if (KluL9hrBtcu > 0)
		{
			return dBML90P7vOx(string_, uaEL9Y7QGvY);
		}
		return null;
	}

	internal static bool vDsXPyFvHxllZIBcg199()
	{
		return lr8pHJFvhxXsNWGwGcTE == null;
	}
}
