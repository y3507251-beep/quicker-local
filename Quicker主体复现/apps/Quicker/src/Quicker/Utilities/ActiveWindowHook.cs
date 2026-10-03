using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using eHGj15MUIx8QneCHitQ;
using log4net;
using PInvoke;
using Quicker.Domain;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public class ActiveWindowHook : IDisposable
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass71_0
	{
		public int G9gSzsIvCLE;

		public IntPtr EXnSzHxP3eY;

		public ActiveWindowHook u7YSz1jdso9;

		private static _003C_003Ec__DisplayClass71_0 arISPwynVEBKOShipoG3;

		internal void QqnSzG2TjCV()
		{
			if (G9gSzsIvCLE == AppState.QuickerProcessId && NativeMethods.IsWindowNoActivate(EXnSzHxP3eY))
			{
				return;
			}
			u7YSz1jdso9.ForegroundWindowHwnd = EXnSzHxP3eY;
			u7YSz1jdso9.ForegroundProcessId = G9gSzsIvCLE;
			u7YSz1jdso9.IsDesktop = false;
			u7YSz1jdso9.IsExplorer = false;
			u7YSz1jdso9.IsTaskbar = false;
			if (G9gSzsIvCLE != AppState.QuickerProcessId)
			{
				u7YSz1jdso9.LastNotQuickerForegroundWindow = EXnSzHxP3eY;
				if (!YTs6o9ynQlOJtoPZnAR1())
				{
					switch (0)
					{
					}
				}
			}
			u7YSz1jdso9.LastForegroundWindow = u7YSz1jdso9.CurrentForegroundWindow;
			u7YSz1jdso9.CurrentForegroundWindow = EXnSzHxP3eY;
			try
			{
				u7YSz1jdso9.JPgLdQX09nm(0);
			}
			catch (Exception ex)
			{
				u7YSz1jdso9.ForegroundProcessName = "";
				u7YSz1jdso9.ForegroundExeName = "";
				jNSLdfMdrQT.Warn("获取进程名称失败:" + ex.Message, ex);
				return;
			}
			u7YSz1jdso9.K8BLdBeMICn();
		}

		internal static bool YTs6o9ynQlOJtoPZnAR1()
		{
			return arISPwynVEBKOShipoG3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass74_0
	{
		public ActiveWindowHook IuDSzX2g29b;

		public int QgWSzmeA6Ag;

		internal static _003C_003Ec__DisplayClass74_0 siI2uWynyBp4Bg48Pfju;

		internal void EwKSzb7asp5()
		{
			Thread.Sleep(500);
			if (IuDSzX2g29b.JPgLdQX09nm(QgWSzmeA6Ag + 1))
			{
				IuDSzX2g29b.K8BLdBeMICn();
			}
		}

		internal void EAoSz6wZAdG()
		{
			Thread.Sleep(400);
			if (IuDSzX2g29b.JPgLdQX09nm(QgWSzmeA6Ag + 1))
			{
				IuDSzX2g29b.K8BLdBeMICn();
			}
		}

		internal static bool E5NwGpynpk1uTbO7UAQw()
		{
			return siI2uWynyBp4Bg48Pfju == null;
		}
	}

	[CompilerGenerated]
	private EventHandler<ActiveWindowChangedEventArgs> uiYLddUI2tM;

	[CompilerGenerated]
	private IntPtr BEALdofE7kR;

	[CompilerGenerated]
	private int xt0LdTT4CJq;

	[CompilerGenerated]
	private string twuLdME4Yay = string.Empty;

	[CompilerGenerated]
	private string WK9LdArXttA;

	[CompilerGenerated]
	private string W58LdOD703s;

	[CompilerGenerated]
	private bool YWMLdF9rcoy;

	[CompilerGenerated]
	private bool t0vLdUwfH7d;

	[CompilerGenerated]
	private bool iuILdlYx9El;

	private IntPtr ChnLdiarUaW;

	private readonly NativeMethods.WinEventDelegate d8KLd3nrBd1;

	private static readonly ILog jNSLdfMdrQT;

	private Timer SbfLdzIjnF1;

	private IntPtr hj5LowUe4rW;

	[CompilerGenerated]
	private bool NvKLotahOGI = true;

	[CompilerGenerated]
	private IntPtr RN0Log5xPOU;

	[CompilerGenerated]
	private IntPtr JcTLoLj954u;

	[CompilerGenerated]
	private IntPtr kHDLovqHkx5;

	private WindowInfo AI4LoS3oF2Z = new WindowInfo();

	internal static ActiveWindowHook kZ8oLSFZHdV7esYPSpJm;

	public IntPtr ForegroundWindowHwnd
	{
		[CompilerGenerated]
		get
		{
			return BEALdofE7kR;
		}
		[CompilerGenerated]
		private set
		{
			BEALdofE7kR = value;
		}
	}

	public int ForegroundProcessId
	{
		[CompilerGenerated]
		get
		{
			return xt0LdTT4CJq;
		}
		[CompilerGenerated]
		private set
		{
			xt0LdTT4CJq = value;
		}
	}

	public string ExeFilePath
	{
		[CompilerGenerated]
		get
		{
			return twuLdME4Yay;
		}
		[CompilerGenerated]
		set
		{
			twuLdME4Yay = value;
		}
	}

	public string ForegroundProcessName
	{
		[CompilerGenerated]
		get
		{
			return WK9LdArXttA;
		}
		[CompilerGenerated]
		set
		{
			WK9LdArXttA = value;
		}
	}

	public string ForegroundExeName
	{
		[CompilerGenerated]
		get
		{
			return W58LdOD703s;
		}
		[CompilerGenerated]
		set
		{
			W58LdOD703s = value;
		}
	}

	public bool IsExplorer
	{
		[CompilerGenerated]
		get
		{
			return YWMLdF9rcoy;
		}
		[CompilerGenerated]
		private set
		{
			YWMLdF9rcoy = value;
		}
	}

	public bool IsDesktop
	{
		[CompilerGenerated]
		get
		{
			return t0vLdUwfH7d;
		}
		[CompilerGenerated]
		private set
		{
			t0vLdUwfH7d = value;
		}
	}

	public bool IsTaskbar
	{
		[CompilerGenerated]
		get
		{
			return iuILdlYx9El;
		}
		[CompilerGenerated]
		private set
		{
			iuILdlYx9El = value;
		}
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return NvKLotahOGI;
		}
		[CompilerGenerated]
		set
		{
			NvKLotahOGI = value;
		}
	}

	public IntPtr LastNotQuickerForegroundWindow
	{
		[CompilerGenerated]
		get
		{
			return RN0Log5xPOU;
		}
		[CompilerGenerated]
		set
		{
			RN0Log5xPOU = value;
		}
	}

	public IntPtr LastForegroundWindow
	{
		[CompilerGenerated]
		get
		{
			return JcTLoLj954u;
		}
		[CompilerGenerated]
		set
		{
			JcTLoLj954u = value;
		}
	}

	public IntPtr CurrentForegroundWindow
	{
		[CompilerGenerated]
		get
		{
			return kHDLovqHkx5;
		}
		[CompilerGenerated]
		set
		{
			kHDLovqHkx5 = value;
		}
	}

	public event EventHandler<ActiveWindowChangedEventArgs> ForegroundWindowChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ActiveWindowChangedEventArgs> eventHandler = uiYLddUI2tM;
			EventHandler<ActiveWindowChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActiveWindowChangedEventArgs> value2 = (EventHandler<ActiveWindowChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uiYLddUI2tM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ActiveWindowChangedEventArgs> eventHandler = uiYLddUI2tM;
			EventHandler<ActiveWindowChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActiveWindowChangedEventArgs> value2 = (EventHandler<ActiveWindowChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uiYLddUI2tM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ActiveWindowHook()
	{
		d8KLd3nrBd1 = e31LdxDrIlj;
		SbfLdzIjnF1 = new Timer(myJLdrjchNg, this, -1, -1);
	}

	public void Hook()
	{
		ChnLdiarUaW = NativeMethods.SetWinEventHook(3u, 23u, IntPtr.Zero, d8KLd3nrBd1, 0u, 0u, 0u);
	}

	private void e31LdxDrIlj(IntPtr intptr_5, uint uint_0, IntPtr intptr_6, int int_1, int int_2, uint uint_1, uint uint_2)
	{
		if (!IsEnabled || !AppState.IsAppLoaded || AppState.IsWindowsLocked)
		{
			return;
		}
		int num = 0;
		if (!HAHCLtFZzWOtFXx4hVhI())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!AppState.IsComputerSuspended && (uint_0 == 3 || uint_0 == 23 || uint_0 == 22))
		{
			neuLdpyJhHA(intptr_6, false);
			hj5LowUe4rW = intptr_6;
			SbfLdzIjnF1.Change(100, -1);
		}
	}

	private void myJLdrjchNg(object object_0)
	{
		IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
		neuLdpyJhHA(foregroundWindow, false);
	}

	public void RaiseOne(bool forceUpdate)
	{
		neuLdpyJhHA(NativeMethods.GetForegroundWindow(), forceUpdate);
	}

	public void Unhook()
	{
		NativeMethods.UnhookWinEvent(ChnLdiarUaW);
	}

	public void Dispose()
	{
		Unhook();
	}

	public void TryRefresh()
	{
		IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
		if (!(foregroundWindow == ForegroundWindowHwnd))
		{
			neuLdpyJhHA(foregroundWindow, false);
		}
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private void neuLdpyJhHA(IntPtr intptr_5, bool bool_4)
	{
		_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
		_003C_003Ec__DisplayClass71_.EXnSzHxP3eY = intptr_5;
		_003C_003Ec__DisplayClass71_.u7YSz1jdso9 = this;
		if (!bool_4)
		{
			if (HAHCLtFZzWOtFXx4hVhI())
			{
				switch (0)
				{
				}
			}
			if (_003C_003Ec__DisplayClass71_.EXnSzHxP3eY == ForegroundWindowHwnd)
			{
				return;
			}
		}
		_003C_003Ec__DisplayClass71_.G9gSzsIvCLE = NativeMethods.GetWindowProcessId(_003C_003Ec__DisplayClass71_.EXnSzHxP3eY);
		if (bool_4 || !(ForegroundWindowHwnd == _003C_003Ec__DisplayClass71_.EXnSzHxP3eY) || ForegroundProcessId != _003C_003Ec__DisplayClass71_.G9gSzsIvCLE)
		{
			Task.Run((Action)_003C_003Ec__DisplayClass71_.QqnSzG2TjCV);
		}
	}

	private void K8BLdBeMICn()
	{
		WindowInfo windowInfo = new WindowInfo
		{
			Handle = ForegroundWindowHwnd,
			Pid = ForegroundProcessId,
			ProcessName = ForegroundProcessName,
			ExeName = ForegroundExeName,
			ExePath = ExeFilePath
		};
		uiYLddUI2tM?.Invoke(this, new ActiveWindowChangedEventArgs
		{
			ActivatedWindow = windowInfo,
			DeactivatedWindow = AI4LoS3oF2Z
		});
		AI4LoS3oF2Z = windowInfo;
	}

	private bool JPgLdQX09nm(int int_1)
	{
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
		_003C_003Ec__DisplayClass74_.IuDSzX2g29b = this;
		int num = 0;
		if (kZ8oLSFZHdV7esYPSpJm != null)
		{
			goto IL_001f;
		}
		goto IL_00dd;
		IL_001f:
		_003C_003Ec__DisplayClass74_.QgWSzmeA6Ag = int_1;
		if (!(ForegroundWindowHwnd == IntPtr.Zero))
		{
			ExeFilePath = tZZhZGM4HaKvySF2OqY.ulvLOm7PgsE((uint)ForegroundProcessId);
			ForegroundExeName = string.Intern(Path.GetFileName(ExeFilePath).ToLowerInvariant());
			ForegroundProcessName = string.Intern(ExeFilePath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) ? Path.GetFileNameWithoutExtension(ExeFilePath) : Path.GetFileName(ExeFilePath));
			if (ProcessHelper.IsDesktopSoftware(ForegroundProcessName))
			{
				ExeFilePath = "explorer.exe";
				ForegroundProcessName = "explorer";
				ForegroundExeName = "explorer.exe";
				num = 1;
				if (kZ8oLSFZHdV7esYPSpJm != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00dd;
			}
			if (HostedProcessHelper.IsHostProcess(ForegroundProcessName))
			{
				using Process hostProcess = Process.GetProcessById(ForegroundProcessId);
				using Process process = HostedProcessHelper.GetRealProcess(hostProcess);
				if (process != null)
				{
					ForegroundProcessId = process.Id;
					ForegroundProcessName = process.ProcessName;
					ExeFilePath = process.MainModule?.FileName;
					if (!string.IsNullOrEmpty(ExeFilePath))
					{
						ForegroundExeName = Path.GetFileName(ExeFilePath);
					}
					return true;
				}
				if (_003C_003Ec__DisplayClass74_.QgWSzmeA6Ag < 4)
				{
					int num3 = 0;
					if (kZ8oLSFZHdV7esYPSpJm != null)
					{
						int num4 = default(int);
						num3 = num4;
					}
					switch (num3)
					{
					default:
						Task.Run((Action)_003C_003Ec__DisplayClass74_.EwKSzb7asp5);
						return false;
					}
				}
				return false;
			}
			if (string.Equals(ForegroundProcessName, "explorer", StringComparison.OrdinalIgnoreCase))
			{
				if (!(NativeMethods.GetWindowClass(ForegroundWindowHwnd) == "ApplicationFrameWindow"))
				{
					(IsDesktop, IsExplorer, IsTaskbar) = NativeMethods.GetExplorerWindow(ForegroundWindowHwnd);
				}
				else
				{
					IsDesktop = false;
					IsExplorer = false;
					IsTaskbar = false;
					try
					{
						using Process process2 = new UwpProcessHelper().GetRealProcess(ForegroundWindowHwnd);
						if (process2 == null)
						{
							if (_003C_003Ec__DisplayClass74_.QgWSzmeA6Ag < 4)
							{
								Task.Run((Action)_003C_003Ec__DisplayClass74_.EAoSz6wZAdG);
								return false;
							}
							return false;
						}
						ForegroundProcessId = process2.Id;
						int num5 = 0;
						if (!HAHCLtFZzWOtFXx4hVhI())
						{
							int num6 = default(int);
							num5 = num6;
						}
						switch (num5)
						{
						default:
							ForegroundProcessName = process2.ProcessName;
							ExeFilePath = process2.MainModule?.FileName;
							if (!string.IsNullOrEmpty(ExeFilePath))
							{
								ForegroundExeName = Path.GetFileName(ExeFilePath);
							}
							jNSLdfMdrQT.Info("发现UWP进程：" + process2.ProcessName);
							break;
						}
					}
					catch (Exception ex)
					{
						jNSLdfMdrQT.Warn("获取UWP进程失败。" + ex.Message, ex);
					}
				}
			}
			if (string.Equals(ForegroundProcessName, "wps", StringComparison.OrdinalIgnoreCase))
			{
				goto IL_0381;
			}
			goto IL_0459;
		}
		ForegroundProcessName = "";
		ForegroundExeName = "";
		return true;
		IL_00dd:
		switch (num)
		{
		case 1:
			IsDesktop = true;
			return true;
		case 2:
			goto IL_0381;
		}
		goto IL_001f;
		IL_0381:
		IntPtr intPtr = User32.WindowFromPoint(User32.GetCursorPos());
		User32.GetWindowThreadProcessId(intPtr, out var lpdwProcessId);
		if (lpdwProcessId != ForegroundProcessId && lpdwProcessId != AppState.QuickerProcessId)
		{
			try
			{
				Process processById = Process.GetProcessById(lpdwProcessId);
				ExeFilePath = processById.MainModule?.FileName;
				if (!string.IsNullOrEmpty(ExeFilePath))
				{
					ForegroundWindowHwnd = intPtr;
					ForegroundProcessId = lpdwProcessId;
					ForegroundExeName = Path.GetFileName(ExeFilePath);
					ForegroundProcessName = (ExeFilePath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) ? Path.GetFileNameWithoutExtension(ExeFilePath) : Path.GetFileName(ExeFilePath));
				}
			}
			catch (Exception ex2)
			{
				jNSLdfMdrQT.Warn("获取WPS内部进程出错：" + ex2.Message, ex2);
			}
			goto IL_0459;
		}
		return true;
		IL_0459:
		return true;
	}

	static ActiveWindowHook()
	{
		jNSLdfMdrQT = LogManager.GetLogger(typeof(ActiveWindowHook));
	}

	internal static bool HAHCLtFZzWOtFXx4hVhI()
	{
		return kZ8oLSFZHdV7esYPSpJm == null;
	}

	internal static void N9YnQnF5QekrUBwVWjYy()
	{
	}
}
