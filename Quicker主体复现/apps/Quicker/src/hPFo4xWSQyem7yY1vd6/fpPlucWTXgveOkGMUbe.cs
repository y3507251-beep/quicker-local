using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ch6AunMoPvwJjkV6ebu;
using log4net;
using Quicker.Modules.TextTools;
using Quicker.Modules.TextTools.Tools;
using Quicker.ScreenSelectLib.Processors;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace hPFo4xWSQyem7yY1vd6;

internal class fpPlucWTXgveOkGMUbe : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public fpPlucWTXgveOkGMUbe eBfvsvbZR1w;

		public IntPtr U76vsSd0Ni0;

		private static _003C_003Ec__DisplayClass4_0 fZpZQNcRVeFj9NucJdRG;

		internal void nYEvsguSKiK()
		{
			WindowHelper.MinimizeWindowAndOwner(eBfvsvbZR1w.Context.ParentWindow);
		}

		internal void XcovsLNExe9()
		{
			U76vsSd0Ni0 = RehfZTMXemxEse5TOoa.SelectWindow(WindowDetectLevel.RootWindow);
			WindowHelper.RestoreWindowAndOwner(eBfvsvbZR1w.Context.ParentWindow);
		}

		internal static bool pn8EyUcRQlxHO7MhmpOk()
		{
			return fZpZQNcRVeFj9NucJdRG == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public fpPlucWTXgveOkGMUbe _003C_003E4__this;

		public object sender;

		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object BRxaC2cRyedFyw4pqyQF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			fpPlucWTXgveOkGMUbe fpPlucWTXgveOkGMUbe2 = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				int num2;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass4_0();
					_003C_003E8__1.eBfvsvbZR1w = _003C_003E4__this;
					fpPlucWTXgveOkGMUbe2.srTt2vIhD1V(sender);
					AppHelper.RunOnUiThread(true, _003C_003E8__1.nYEvsguSKiK);
					awaiter = Task.Delay(300).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = 1;
						if (!K5lmdMcRpR8tGQgLmHhv())
						{
							goto IL_00e4;
						}
						goto IL_00e8;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				_003C_003E8__1.U76vsSd0Ni0 = IntPtr.Zero;
				AppHelper.RunOnUiThread(true, _003C_003E8__1.XcovsLNExe9);
				num2 = 0;
				if (!K5lmdMcRpR8tGQgLmHhv())
				{
					goto IL_00e4;
				}
				goto IL_00e8;
				IL_00e4:
				int num3 = default(int);
				num2 = num3;
				goto IL_00e8;
				IL_00e8:
				switch (num2)
				{
				default:
					if (_003C_003E8__1.U76vsSd0Ni0 != IntPtr.Zero)
					{
						try
						{
							fpPlucWTXgveOkGMUbe2.cVTt2L6odCW(_003C_003E8__1.U76vsSd0Ni0);
						}
						catch (Exception ex)
						{
							bZVt22XFe2c.Warn("获取窗口信息出错：" + ex.Message, ex);
							AppHelper.ShowWarning("读取窗口相关信息出错：" + ex.Message);
							fpPlucWTXgveOkGMUbe2.CancelSelection("读取窗口相关信息出错：" + ex.Message);
						}
					}
					else
					{
						fpPlucWTXgveOkGMUbe2.CancelSelection("");
					}
					break;
				case 1:
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool K5lmdMcRpR8tGQgLmHhv()
		{
			return BRxaC2cRyedFyw4pqyQF == null;
		}
	}

	private readonly WindowInfoType PpAt2SlySaP;

	private static readonly ILog bZVt22XFe2c;

	private static fpPlucWTXgveOkGMUbe YDNYivQXZvU47AWNaC35;

	public fpPlucWTXgveOkGMUbe(TextToolContext textToolContext_1, WindowInfoType windowInfoType_1)
		: base(textToolContext_1)
	{
		PpAt2SlySaP = windowInfoType_1;
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
	}

	[AsyncStateMachine(typeof(_003COnMouseUp_003Ed__4))]
	public override void OnMouseUp(object sender)
	{
		_003COnMouseUp_003Ed__4 stateMachine = default(_003COnMouseUp_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public void cVTt2L6odCW(IntPtr intptr_0)
	{
		int windowProcessId = NativeMethods.GetWindowProcessId(intptr_0);
		string text = "";
		int num2 = default(int);
		switch (PpAt2SlySaP)
		{
		case WindowInfoType.WindowTitle:
			text = NativeMethods.GetWindowTitle(intptr_0);
			goto IL_01c1;
		case WindowInfoType.WindowClassName:
			text = NativeMethods.GetWindowClass(intptr_0);
			goto IL_01c1;
		case WindowInfoType.WindowText:
			NativeMethods.GetWindowText(intptr_0);
			goto IL_01c1;
		case WindowInfoType.Handle:
			text = intptr_0.ToString();
			goto IL_01c1;
		case WindowInfoType.ExePath:
		{
			using (Process process3 = Process.GetProcessById(windowProcessId))
			{
				ProcessModule mainModule2 = process3.MainModule;
				object obj2;
				if (mainModule2 == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = mainModule2.FileName;
					if (obj2 != null)
					{
						goto IL_00a0;
					}
				}
				obj2 = "";
				goto IL_00a0;
				IL_00a0:
				text = (string)obj2;
			}
			goto IL_01c1;
		}
		case WindowInfoType.ExeName:
		{
			using (Process process2 = Process.GetProcessById(windowProcessId))
			{
				ProcessModule mainModule = process2.MainModule;
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
						goto IL_00d8;
					}
				}
				obj = "";
				goto IL_00d8;
				IL_00d8:
				text = Path.GetFileName((string)obj);
			}
			goto IL_01c1;
		}
		case WindowInfoType.ProcessName:
		{
			using (Process process = Process.GetProcessById(windowProcessId))
			{
				text = process.ProcessName;
			}
			goto IL_01c1;
		}
		case WindowInfoType.WindowLocation:
		{
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intptr_0);
			text = $"{windowRectangle.Left},{windowRectangle.Top},{windowRectangle.Right},{windowRectangle.Bottom}";
			goto IL_01c1;
		}
		case WindowInfoType.WindowLocationWithInvisibleBorder:
		{
			NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(intptr_0);
			text = $"{windowRect.Left},{windowRect.Top},{windowRect.Right},{windowRect.Bottom}";
			goto IL_01c1;
		}
		default:
			{
				AppHelper.ShowWarning("不支持的窗口信息操作类型：" + PpAt2SlySaP);
				goto IL_01c1;
			}
			IL_01c1:
			while (true)
			{
				TextToolContext.ProcessSelectedText processSelectedTextFunc = base.Context.ProcessSelectedTextFunc;
				if (processSelectedTextFunc == null)
				{
					int num = 1;
					if (YDNYivQXZvU47AWNaC35 != null)
					{
						num = num2;
					}
					switch (num)
					{
					case 2:
						continue;
					case 1:
						return;
					}
					break;
				}
				processSelectedTextFunc(text, false);
				return;
			}
			goto default;
		}
	}

	public override void OnMouseMove(object sender, MouseEventArgs mouseEventArgs)
	{
		base.OnMouseMove(sender, mouseEventArgs);
	}

	public override void OnUnload()
	{
		base.OnUnload();
	}

	static fpPlucWTXgveOkGMUbe()
	{
		bZVt22XFe2c = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void srTt2vIhD1V(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool oThoUZQX5OaymtPZSa6N()
	{
		return YDNYivQXZvU47AWNaC35 == null;
	}
}
