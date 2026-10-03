using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using c4LBdq5YohQFUgxFYw4;
using HandyControl.Controls;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;

namespace Quicker.View.Tools;

public class WindowInfoWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public qsQtMm5MtHtoYi1dcdV ziISBG3ZELP;

		public WindowInfoWindow nTISBsNETks;

		private static _003C_003Ec__DisplayClass7_0 upBtZEWxLx0q542Jspsk;

		internal void f68SBku7Rtv()
		{
			try
			{
				ziISBG3ZELP = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Control);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
			WindowHelper.RestoreWindowAndOwner(System.Windows.Window.GetWindow(nTISBsNETks));
		}

		internal static void ey7cBFWxfBvRZTukNdrn()
		{
		}

		internal static bool gbEyaUWxuPsswxakIh2d()
		{
			return upBtZEWxLx0q542Jspsk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public string cpeSB1cLu7Q;

		internal static _003C_003Ec__DisplayClass9_0 c7J3vMWxbkYpcWhIJpT7;

		internal bool HhASBHmY9vV(KeyValuePair p)
		{
			return p.Key == cpeSB1cLu7Q;
		}

		internal static bool YSeNjMWxqlxdA0aX4Zm9()
		{
			return c7J3vMWxbkYpcWhIJpT7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectWindow_OnMouseUp_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WindowInfoWindow _003C_003E4__this;

		public MouseButtonEventArgs e;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object D6JPR3WxlEgdaXB6dt1d;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WindowInfoWindow windowInfoWindow = _003C_003E4__this;
			try
			{
				try
				{
					System.Drawing.Point mousePosition = default(System.Drawing.Point);
					IntPtr intptr_ = default(IntPtr);
					int num2;
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						windowInfoWindow.BtnSelectWindow.ReleaseMouseCapture();
						windowInfoWindow.Cursor = Cursors.Arrow;
						if (AppHelper.IsFarThan(windowInfoWindow.VGGLSXkuAhV, e.GetPosition(windowInfoWindow), 10))
						{
							mousePosition = NativeMethods.GetMousePosition();
							intptr_ = NativeMethods.WindowFromPoint(mousePosition);
							num2 = 1;
							if (D6JPR3WxlEgdaXB6dt1d != null)
							{
								goto IL_00f3;
							}
						}
						else
						{
							_003C_003E8__1 = new _003C_003Ec__DisplayClass7_0();
							_003C_003E8__1.nTISBsNETks = windowInfoWindow;
							AppHelper.RunOnUiThread(true, windowInfoWindow.oWpLSsLumDE);
							awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_014a;
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = 0;
							if (!Tsr0A8WxZ31HwtpfoQkc())
							{
								goto IL_00f3;
							}
						}
						goto IL_0110;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_014a;
					IL_0110:
					while (true)
					{
						switch (num2)
						{
						case 1:
							windowInfoWindow.TCULSIpBZMN(mousePosition, intptr_);
							num2 = 1;
							if (D6JPR3WxlEgdaXB6dt1d != null)
							{
								continue;
							}
							break;
						default:
							return;
						case 2:
							break;
						}
						break;
					}
					goto end_IL_0011;
					IL_014a:
					awaiter.GetResult();
					_003C_003E8__1.ziISBG3ZELP = null;
					AppHelper.RunOnUiThread(true, _003C_003E8__1.f68SBku7Rtv);
					if (_003C_003E8__1.ziISBG3ZELP.IsSuccess)
					{
						IntPtr intptr_2 = _003C_003E8__1.ziISBG3ZELP.VpumGqYoKI();
						windowInfoWindow.TCULSIpBZMN(_003C_003E8__1.ziISBG3ZELP.nwQmhJ5RTi(), intptr_2);
					}
					_003C_003E8__1 = null;
					goto end_IL_0011;
					IL_00f3:
					int num3 = default(int);
					num2 = num3;
					goto IL_0110;
					end_IL_0011:;
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

		internal static bool Tsr0A8WxZ31HwtpfoQkc()
		{
			return D6JPR3WxlEgdaXB6dt1d == null;
		}
	}

	[CompilerGenerated]
	private ObservableCollection<KeyValuePair> XTMLS6W9JlS = new ObservableCollection<KeyValuePair>();

	private System.Windows.Point VGGLSXkuAhV;

	internal Button BtnSelectWindow;

	internal TextBlock TxtTitle;

	internal ListView lvKeyValue;

	private bool O9BLSmncqkm;

	private static WindowInfoWindow pNkQg2FeeYHP9Ki3BHMw;

	public WindowInfoWindow()
	{
		InitializeComponent();
	}

	[SpecialName]
	[CompilerGenerated]
	private ObservableCollection<KeyValuePair> jB4LSHYdcmX()
	{
		return XTMLS6W9JlS;
	}

	[SpecialName]
	[CompilerGenerated]
	private void NwgLS1mB9ea(ObservableCollection<KeyValuePair> value)
	{
		XTMLS6W9JlS = value;
	}

	private void mlOLSeefCD7(object sender, MouseButtonEventArgs e)
	{
		base.Cursor = Cursors.Cross;
		BtnSelectWindow.CaptureMouse();
		VGGLSXkuAhV = e.GetPosition(this);
		lvKeyValue.ItemsSource = jB4LSHYdcmX();
	}

	[AsyncStateMachine(typeof(_003CBtnSelectWindow_OnMouseUp_003Ed__7))]
	private void rclLSYCOrEA(object sender, MouseButtonEventArgs e)
	{
		_003CBtnSelectWindow_OnMouseUp_003Ed__7 stateMachine = default(_003CBtnSelectWindow_OnMouseUp_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void TCULSIpBZMN(System.Drawing.Point point_1, IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			jB4LSHYdcmX().Clear();
			return;
		}
		TrLLSWMMyCN("窗口句柄", $"{intptr_0}");
		TrLLSWMMyCN("窗口标题", NativeMethods.GetWindowText(intptr_0) ?? "");
		TrLLSWMMyCN("窗口类名", NativeMethods.GetWindowClass(intptr_0) ?? "");
		if (pNkQg2FeeYHP9Ki3BHMw != null)
		{
			switch (0)
			{
			}
		}
		NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(intptr_0);
		TrLLSWMMyCN("窗口坐标", $"{windowRect.Left},{windowRect.Top},{windowRect.Right},{windowRect.Bottom}");
		TrLLSWMMyCN("窗口尺寸", $"{windowRect.Right - windowRect.Left} * {windowRect.Bottom - windowRect.Top}");
		TrLLSWMMyCN("屏幕坐标", $"{point_1.X},{point_1.Y}");
		TrLLSWMMyCN("窗口坐标", $"{point_1.X - windowRect.Left},{point_1.Y - windowRect.Top}");
		int windowProcessId = NativeMethods.GetWindowProcessId(intptr_0);
		TrLLSWMMyCN("进程ID", $"{windowProcessId}");
		try
		{
			Process processById = Process.GetProcessById(windowProcessId);
			TrLLSWMMyCN("进程名", processById.ProcessName ?? "");
			ProcessModule mainModule = processById.MainModule;
			object obj;
			if (mainModule == null)
			{
				obj = null;
			}
			else
			{
				obj = mainModule.FileName;
				if (obj != null)
				{
					goto IL_01df;
				}
			}
			obj = "";
			goto IL_01df;
			IL_01df:
			TrLLSWMMyCN("进程路径", (string)obj);
		}
		catch (Exception ex)
		{
			TrLLSWMMyCN("进程名", "ERR: " + ex.Message);
			TrLLSWMMyCN("进程路径", "ERR: " + ex.Message);
		}
	}

	private void TrLLSWMMyCN(string string_0, string string_1)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.cpeSB1cLu7Q = string_0;
		KeyValuePair keyValuePair = jB4LSHYdcmX().FirstOrDefault(_003C_003Ec__DisplayClass9_.HhASBHmY9vV);
		if (keyValuePair != null)
		{
			keyValuePair.Value = string_1;
		}
		else
		{
			jB4LSHYdcmX().Add(new KeyValuePair(_003C_003Ec__DisplayClass9_.cpeSB1cLu7Q, string_1));
		}
	}

	private void UvLLSkpv0db(object sender, MouseEventArgs e)
	{
	}

	private void yDHLSGCUSo3(object sender, MouseButtonEventArgs e)
	{
		string text = (sender as TextBlock)?.Text;
		if (!string.IsNullOrEmpty(text))
		{
			AppHelper.TryCopy(text, true);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!O9BLSmncqkm)
		{
			O9BLSmncqkm = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/tools/windowinfowindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			O9BLSmncqkm = true;
			break;
		case 1:
			BtnSelectWindow = (Button)target;
			BtnSelectWindow.PreviewMouseDown += mlOLSeefCD7;
			BtnSelectWindow.PreviewMouseMove += UvLLSkpv0db;
			BtnSelectWindow.PreviewMouseUp += rclLSYCOrEA;
			if (pNkQg2FeeYHP9Ki3BHMw != null)
			{
				switch (0)
				{
				}
			}
			break;
		case 2:
			TxtTitle = (TextBlock)target;
			break;
		case 3:
			lvKeyValue = (ListView)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 4)
		{
			((TextBlock)target).PreviewMouseDown += yDHLSGCUSo3;
		}
	}

	[CompilerGenerated]
	private void oWpLSsLumDE()
	{
		WindowHelper.MinimizeWindowAndOwner(System.Windows.Window.GetWindow(this));
	}

	internal static bool HQJXg2Fejw4mrNJxCmCp()
	{
		return pNkQg2FeeYHP9Ki3BHMw == null;
	}
}
