using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public static class WindowUtils
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static User32.EnumWindowsProc wxBvyA43Uvi;
	}

	[CompilerGenerated]
	private sealed class _003COrderByZOrder_003Ed__0 : IEnumerable<IntPtr>, IEnumerator<IntPtr>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private IntPtr _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<IntPtr> windows;

		public IEnumerable<IntPtr> _003C_003E3__windows;

		private HashSet<IntPtr> _003Chash_003E5__2;

		private IntPtr _003ChWnd_003E5__3;

		private static _003COrderByZOrder_003Ed__0 atesb0cGWSwioWXHE31B;

		IntPtr IEnumerator<IntPtr>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003COrderByZOrder_003Ed__0(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Chash_003E5__2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0059;
			}
			_003C_003E1__state = -1;
			_003Chash_003E5__2 = new HashSet<IntPtr>(windows);
			_003ChWnd_003E5__3 = User32.GetTopWindow(IntPtr.Zero);
			goto IL_006b;
			IL_0059:
			_003ChWnd_003E5__3 = User32.GetNextWindow(_003ChWnd_003E5__3, 2u);
			goto IL_006b;
			IL_006b:
			if (_003ChWnd_003E5__3 != IntPtr.Zero)
			{
				if (_003Chash_003E5__2.Contains(_003ChWnd_003E5__3))
				{
					_003C_003E2__current = _003ChWnd_003E5__3;
					_003C_003E1__state = 1;
					int num2 = 0;
					if (!QW3ptDcGykWGnEKU0ldC())
					{
						int num3 = default(int);
						num2 = num3;
					}
					return num2 switch
					{
						_ => true, 
					};
				}
				goto IL_0059;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
		{
			_003COrderByZOrder_003Ed__0 _003COrderByZOrder_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003COrderByZOrder_003Ed__ = this;
			}
			else
			{
				_003COrderByZOrder_003Ed__ = new _003COrderByZOrder_003Ed__0(0);
			}
			_003COrderByZOrder_003Ed__.windows = _003C_003E3__windows;
			return _003COrderByZOrder_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<IntPtr>)this).GetEnumerator();
		}

		internal static bool QW3ptDcGykWGnEKU0ldC()
		{
			return atesb0cGWSwioWXHE31B == null;
		}
	}

	internal static object OAyF9N1SfhU6UrAraai;

	[IteratorStateMachine(typeof(_003COrderByZOrder_003Ed__0))]
	public static IEnumerable<IntPtr> OrderByZOrder(this IEnumerable<IntPtr> windows)
	{
		return new _003COrderByZOrder_003Ed__0(-2)
		{
			_003C_003E3__windows = windows
		};
	}

	public static IEnumerable<IntPtr> GetWindows()
	{
		List<IntPtr> list = new List<IntPtr>();
		User32.EnumWindows(_003C_003EO.wxBvyA43Uvi ?? (_003C_003EO.wxBvyA43Uvi = aMkPwf04Yt), list);
		return list;
	}

	private static bool aMkPwf04Yt(IntPtr intptr_0, object object_0)
	{
		((List<IntPtr>)object_0).Add(intptr_0);
		return true;
	}

	public static IntPtr GetWindow(IntPtr hwnd, GetWindowOption option)
	{
		return User32.GetWindow(hwnd, option);
	}

	public static void Show(IntPtr hwnd, ShowWindowCommand cmd)
	{
		User32.ShowWindow(hwnd, cmd);
	}

	public static void SetForeground(IntPtr hwnd)
	{
		User32.SetForegroundWindow(hwnd);
	}

	public static IntPtr GetForeground()
	{
		return User32.GetForegroundWindow();
	}

	public static void Activate(IntPtr hwnd)
	{
		User32.SetActiveWindow(hwnd);
	}

	public static IntPtr GetActive()
	{
		return User32.GetActiveWindow();
	}

	internal static bool tph4X61wZIXYGqxP08X()
	{
		return OAyF9N1SfhU6UrAraai == null;
	}
}
