using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ch6AunMoPvwJjkV6ebu;
using Microsoft.Win32;
using Quicker.Domain.Exe;
using Quicker.Properties;
using Quicker.ScreenSelectLib.Processors;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.View.Controls;

public class ExeSelectorControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Dl9Si15WxrN;

		public static Func<ProcessModule, string> SSDSibxuMDo;

		internal static _003C_003Ec zXPNaYyyuBsYbxSNOpHc;

		static _003C_003Ec()
		{
			Dl9Si15WxrN = new _003C_003Ec();
		}

		internal string GgpSiHDiUUW(ProcessModule x)
		{
			return x.ModuleName;
		}

		internal static bool cEVdIdyyoi8vdHpCCcG3()
		{
			return zXPNaYyyuBsYbxSNOpHc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public List<ProcessModule> glnSimbTkBR;

		public ExeSelectorControl aKbSiKS4sEe;

		public IList<string> NaQSixFQLMP;

		public bool CVySirMXFXt;

		public Action hVgSiprbdpQ;

		internal static _003C_003Ec__DisplayClass10_0 n3nPd5yybba04IbyOvy7;

		internal void Uo9Si6vA28f()
		{
			using (IEnumerator<Process> enumerator = NativeMethods.GetProcessesWithWindow().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_1
					{
						eSjSiQy02j7 = enumerator.Current
					};
					try
					{
						if (_003C_003Ec__DisplayClass10_.eSjSiQy02j7 != null && _003C_003Ec__DisplayClass10_.eSjSiQy02j7.MainModule != null && !glnSimbTkBR.Any(_003C_003Ec__DisplayClass10_.ptqSiBUvnTN))
						{
							glnSimbTkBR.Add(_003C_003Ec__DisplayClass10_.eSjSiQy02j7.MainModule);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			glnSimbTkBR = glnSimbTkBR.OrderBy(_003C_003Ec.SSDSibxuMDo ?? (_003C_003Ec.SSDSibxuMDo = _003C_003Ec.Dl9Si15WxrN.GgpSiHDiUUW)).ToList();
			aKbSiKS4sEe.Dispatcher.InvokeAsync(hVgSiprbdpQ ?? (hVgSiprbdpQ = ytuSiXhYCGD));
		}

		internal void ytuSiXhYCGD()
		{
			aKbSiKS4sEe.CbApplications.BeginInit();
			foreach (ProcessModule item in glnSimbTkBR)
			{
				if (NaQSixFQLMP.Contains(Path.GetFileName(item.FileName).ToLowerInvariant()))
				{
					continue;
				}
				try
				{
					string text = item.FileVersionInfo.FileDescription;
					if (string.IsNullOrEmpty(text))
					{
						text = Path.GetFileNameWithoutExtension(item.ModuleName);
					}
					aKbSiKS4sEe.LI8LBi0Hu3Q.Add(new ProcessItem
					{
						ExePath = item.FileName,
						ExeFileName = Path.GetFileName(item.FileName),
						Title = text
					});
				}
				catch
				{
				}
			}
			aKbSiKS4sEe.CbApplications.EndInit();
			if (CVySirMXFXt)
			{
				aKbSiKS4sEe.AddCustomizeItem();
			}
		}

		internal static void h4NNZZyyldRq7dMHCUqX()
		{
		}

		internal static bool zwIjatyyqC6OSC0FhDSw()
		{
			return n3nPd5yybba04IbyOvy7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_1
	{
		public Process eSjSiQy02j7;

		internal static _003C_003Ec__DisplayClass10_1 a4aK8Yyy55ZKdlSuF52n;

		internal bool ptqSiBUvnTN(ProcessModule m)
		{
			return m.FileName == eSjSiQy02j7.MainModule?.FileName;
		}

		internal static bool sDtxDnyyYYxnxbqIy94d()
		{
			return a4aK8Yyy55ZKdlSuF52n == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public IntPtr SeXSinhDT4E;

		public ExeSelectorControl CuMSi4JdM2p;

		private static _003C_003Ec__DisplayClass13_0 IBHlnXyyRCMcfxmr65uj;

		internal void ES9SijMvy9F()
		{
			try
			{
				SeXSinhDT4E = RehfZTMXemxEse5TOoa.SelectWindow(WindowDetectLevel.RootWindowOfSameProcess);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(Window.GetWindow(CuMSi4JdM2p));
		}

		internal static bool uxJVtJyygE1XWLUWWCm5()
		{
			return IBHlnXyyRCMcfxmr65uj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public string ai3SiDyyYf3;

		internal static _003C_003Ec__DisplayClass17_0 le2wQ3yyMGAAGK3WZP0t;

		internal bool CP3Si5s3l3Z(ProcessItem x)
		{
			return string.Equals(x.ExePath, ai3SiDyyYf3, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool shgHIiyyUQbYJZ9HGKTO()
		{
			return le2wQ3yyMGAAGK3WZP0t == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectWindow_OnMouseUp_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExeSelectorControl _003C_003E4__this;

		public MouseButtonEventArgs e;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object OLPC2Dyy60XU7qWhgCDX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExeSelectorControl exeSelectorControl = _003C_003E4__this;
			try
			{
				try
				{
        string hoveringExe = default;
					int num2;
					if (num != 0)
					{
						exeSelectorControl.BtnSelectWindow.ReleaseMouseCapture();
						exeSelectorControl.Cursor = Cursors.Arrow;
						if (AppHelper.IsFarThan(exeSelectorControl.OgjLB3tIt9V, e.GetPosition(exeSelectorControl), 10))
						{
							goto IL_0063;
						}
						_003C_003E8__1 = new _003C_003Ec__DisplayClass13_0();
						num2 = 1;
						if (D4cqkkyytoH5dJmCxABY())
						{
							goto IL_0076;
						}
						goto IL_00ed;
					}
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0115;
					IL_0063:
					hoveringExe = NativeMethods.GetHoveringExe(true);
					num2 = 0;
					if (!D4cqkkyytoH5dJmCxABY())
					{
						goto IL_0076;
					}
					goto IL_00ed;
					IL_0115:
					awaiter.GetResult();
					_003C_003E8__1.SeXSinhDT4E = IntPtr.Zero;
					AppHelper.RunOnUiThread(true, _003C_003E8__1.ES9SijMvy9F);
					if (_003C_003E8__1.SeXSinhDT4E != IntPtr.Zero)
					{
						Process processById = Process.GetProcessById(NativeMethods.GetWindowProcessId(_003C_003E8__1.SeXSinhDT4E));
						exeSelectorControl.XDMLBOH9hVb(processById.MainModule?.FileName);
					}
					_003C_003E8__1 = null;
					goto end_IL_000f;
					IL_00ed:
					exeSelectorControl.XDMLBOH9hVb(hoveringExe);
					goto end_IL_000f;
					IL_0076:
					switch (num2)
					{
					case 2:
						break;
					case 1:
						goto IL_0089;
					default:
						goto IL_00ed;
					}
					goto IL_0063;
					IL_0089:
					_003C_003E8__1.CuMSi4JdM2p = exeSelectorControl;
					AppHelper.RunOnUiThread(true, exeSelectorControl.xuXLBlFofKH);
					awaiter = Task.Delay(100).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0115;
					end_IL_000f:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取进程失败。" + ex.Message);
				}
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

		internal static bool D4cqkkyytoH5dJmCxABY()
		{
			return OLPC2Dyy60XU7qWhgCDX == null;
		}
	}

	private readonly ObservableCollection<ProcessItem> LI8LBi0Hu3Q = new ObservableCollection<ProcessItem>();

	private System.Windows.Point OgjLB3tIt9V;

	[CompilerGenerated]
	private string uoOLBfm952s;

	[CompilerGenerated]
	private EventHandler m_SelectedExeChanged;

	internal ComboBox CbApplications;

	internal Button BtnSelectWindow;

	private bool ISLLBzfKVP4;

	internal static ExeSelectorControl Xg0aOFFbWixAXkjRg6ZX;

	public string SelectedExePathName
	{
		[CompilerGenerated]
		get
		{
			return uoOLBfm952s;
		}
		[CompilerGenerated]
		set
		{
			uoOLBfm952s = value;
		}
	}

	public event EventHandler SelectedExeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_SelectedExeChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectedExeChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_SelectedExeChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectedExeChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExeSelectorControl()
	{
		InitializeComponent();
		CbApplications.ItemsSource = LI8LBi0Hu3Q;
	}

	public void LoadRunningExeList(IList<string> filterExes, bool addCustomItem)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.aKbSiKS4sEe = this;
		_003C_003Ec__DisplayClass10_.NaQSixFQLMP = filterExes;
		_003C_003Ec__DisplayClass10_.CVySirMXFXt = addCustomItem;
		_003C_003Ec__DisplayClass10_.glnSimbTkBR = new List<ProcessModule>();
		Task.Run((Action)_003C_003Ec__DisplayClass10_.Uo9Si6vA28f).ConfigureAwait(true);
	}

	public void AddCustomizeItem()
	{
		LI8LBi0Hu3Q.Add(new ProcessItem
		{
			Title = "自定义应用(虚拟)",
			ExePath = "CUSTOM",
			ExeFileName = "CUSTOM",
			Icon = null
		});
		LI8LBi0Hu3Q.Add(new ProcessItem
		{
			Title = "网址应用(虚拟)",
			ExePath = "URL",
			ExeFileName = "URL",
			Icon = null
		});
	}

	private void AyFLBM2uttj(object sender, MouseButtonEventArgs e)
	{
		base.Cursor = Cursors.Cross;
		BtnSelectWindow.CaptureMouse();
		OgjLB3tIt9V = e.GetPosition(this);
	}

	[AsyncStateMachine(typeof(_003CBtnSelectWindow_OnMouseUp_003Ed__13))]
	private void Nq0LBAYwcaJ(object sender, MouseButtonEventArgs e)
	{
		_003CBtnSelectWindow_OnMouseUp_003Ed__13 stateMachine = default(_003CBtnSelectWindow_OnMouseUp_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void XDMLBOH9hVb(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return;
		}
		string fileName = Path.GetFileName(string_1);
		bool flag = false;
		foreach (ProcessItem item in LI8LBi0Hu3Q)
		{
			if (string.Equals(item.ExeFileName, fileName, StringComparison.OrdinalIgnoreCase))
			{
				CbApplications.SelectedItem = item;
				flag = true;
			}
		}
		if (!flag)
		{
			k76LBUCmkHy(string_1);
		}
	}

	private void rOILBFCNwS3(object sender, SelectionChangedEventArgs e)
	{
		if (!(CbApplications.SelectedItem is ProcessItem processItem))
		{
			return;
		}
		if (string.Equals(processItem.ExeFileName, "Other", StringComparison.OrdinalIgnoreCase))
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				FileName = "Exe文件",
				DefaultExt = ".exe",
				Filter = "可执行程序|*.exe"
			};
			int num = 0;
			if (!wgFS3vFbykVKGVCEoyML())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (openFileDialog.ShowDialog() == true)
			{
				string fileName = openFileDialog.FileName;
				k76LBUCmkHy(fileName);
			}
		}
		else
		{
			SelectedExePathName = processItem.ExePath;
			this.m_SelectedExeChanged?.Invoke(this, null);
		}
	}

	private void k76LBUCmkHy(string string_1)
	{
		ProcessItem processItem;
		while (true)
		{
			processItem = null;
			if (wgFS3vFbykVKGVCEoyML())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		switch (string_1)
		{
		case "desktop":
			processItem = new ProcessItem
			{
				Title = CommonStrings.CommonExeInfo_Desktop_Name,
				ExePath = string_1,
				ExeFileName = Path.GetFileName(string_1),
				Icon = ExeFileIconHelper.GetDesktopImage()
			};
			break;
		case "taskbar":
			processItem = new ProcessItem
			{
				Title = CommonStrings.CommonExeInfo_Taskbar_Name,
				ExePath = string_1,
				ExeFileName = Path.GetFileName(string_1),
				Icon = ExeFileIconHelper.GetTaskbarImage()
			};
			break;
		case "unknown-proc.exe":
			AppHelper.ShowWarning("无法识别此程序！可能是因为权限不足。");
			break;
		default:
			try
			{
				processItem = new ProcessItem
				{
					Title = Path.GetFileNameWithoutExtension(string_1),
					ExePath = string_1,
					ExeFileName = Path.GetFileName(string_1),
					Icon = IconHelper.IconToImageSource(Icon.ExtractAssociatedIcon(string_1))
				};
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("操作出错，可能是无法读取图标：" + ex.Message);
			}
			break;
		}
		if (processItem != null)
		{
			LI8LBi0Hu3Q.Add(processItem);
			CbApplications.SelectedItem = processItem;
		}
	}

	public void SelectExe(string exePathName)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.ai3SiDyyYf3 = exePathName;
		ProcessItem processItem = LI8LBi0Hu3Q.FirstOrDefault(_003C_003Ec__DisplayClass17_.CP3Si5s3l3Z);
		if (processItem == null)
		{
			k76LBUCmkHy(_003C_003Ec__DisplayClass17_.ai3SiDyyYf3);
		}
		else
		{
			CbApplications.SelectedItem = processItem;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ISLLBzfKVP4)
		{
			ISLLBzfKVP4 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/exeselectorcontrol.xaml", UriKind.Relative);
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
			ISLLBzfKVP4 = true;
			break;
		case 2:
			BtnSelectWindow = (Button)target;
			BtnSelectWindow.PreviewMouseDown += AyFLBM2uttj;
			BtnSelectWindow.PreviewMouseUp += Nq0LBAYwcaJ;
			break;
		case 1:
			CbApplications = (ComboBox)target;
			CbApplications.SelectionChanged += rOILBFCNwS3;
			break;
		}
	}

	[CompilerGenerated]
	private void xuXLBlFofKH()
	{
		WindowHelper.MinimizeWindowAndOwner(Window.GetWindow(this));
	}

	internal static bool wgFS3vFbykVKGVCEoyML()
	{
		return Xg0aOFFbWixAXkjRg6ZX == null;
	}
}
