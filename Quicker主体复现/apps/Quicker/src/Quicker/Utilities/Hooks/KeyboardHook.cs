using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Quicker.Domain.PowerKeys;
using Quicker.Utilities.Win32;
using WindowsInput.Native;

namespace Quicker.Utilities.Hooks;

public class KeyboardHook : GlobalHook
{
	public delegate void QuickerKeyEventHandler(object? sender, HookKeyEventArgs e);

	[CompilerGenerated]
	private KeyboardState fDNLA7W164Z = new KeyboardState();

	[CompilerGenerated]
	private QuickerKeyEventHandler A9eLARj0OPW;

	[CompilerGenerated]
	private QuickerKeyEventHandler FDYLAqISXHK;

	[CompilerGenerated]
	private KeyPressEventHandler GPvLAcTq7uH;

	[CompilerGenerated]
	private QuickerKeyEventHandler pSyLAVmVT6L;

	internal static KeyboardHook Wj6IyuFgNUmcM2ZKPeGc;

	public KeyboardState RealKeyState
	{
		[CompilerGenerated]
		get
		{
			return fDNLA7W164Z;
		}
		[CompilerGenerated]
		set
		{
			fDNLA7W164Z = value;
		}
	}

	public event QuickerKeyEventHandler KeyDown
	{
		[CompilerGenerated]
		add
		{
			QuickerKeyEventHandler quickerKeyEventHandler = A9eLARj0OPW;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Combine(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref A9eLARj0OPW, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			QuickerKeyEventHandler quickerKeyEventHandler = A9eLARj0OPW;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Remove(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref A9eLARj0OPW, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
	}

	public event QuickerKeyEventHandler KeyUp
	{
		[CompilerGenerated]
		add
		{
			QuickerKeyEventHandler quickerKeyEventHandler = FDYLAqISXHK;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Combine(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref FDYLAqISXHK, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			QuickerKeyEventHandler quickerKeyEventHandler = FDYLAqISXHK;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Remove(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref FDYLAqISXHK, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		[CompilerGenerated]
		add
		{
			KeyPressEventHandler keyPressEventHandler = GPvLAcTq7uH;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange(ref GPvLAcTq7uH, value2, keyPressEventHandler2);
			}
			while ((object)keyPressEventHandler != keyPressEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			KeyPressEventHandler keyPressEventHandler = GPvLAcTq7uH;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
				keyPressEventHandler = Interlocked.CompareExchange(ref GPvLAcTq7uH, value2, keyPressEventHandler2);
			}
			while ((object)keyPressEventHandler != keyPressEventHandler2);
		}
	}

	public event QuickerKeyEventHandler ToggleableKeyDown
	{
		[CompilerGenerated]
		add
		{
			QuickerKeyEventHandler quickerKeyEventHandler = pSyLAVmVT6L;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Combine(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref pSyLAVmVT6L, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			QuickerKeyEventHandler quickerKeyEventHandler = pSyLAVmVT6L;
			QuickerKeyEventHandler quickerKeyEventHandler2;
			do
			{
				quickerKeyEventHandler2 = quickerKeyEventHandler;
				QuickerKeyEventHandler value2 = (QuickerKeyEventHandler)Delegate.Remove(quickerKeyEventHandler2, value);
				quickerKeyEventHandler = Interlocked.CompareExchange(ref pSyLAVmVT6L, value2, quickerKeyEventHandler2);
			}
			while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
		}
	}

	public KeyboardHook()
	{
		base.HookType = HookType.WH_KEYBOARD_LL;
	}

	protected override IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
	{
		bool flag = false;
		HookKeyEventArgs e = null;
		bool flag3 = false;
		bool flag4 = false;
		NativeMethods.KeyboardHookStruct keyboardHookStruct;
		bool flag2;
		int num;
		int num2;
		if (nCode > -1 && (A9eLARj0OPW != null || FDYLAqISXHK != null || GPvLAcTq7uH != null))
		{
			keyboardHookStruct = (NativeMethods.KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(NativeMethods.KeyboardHookStruct));
			flag2 = (NativeMethods.GetKeyState(162) & 0x80) != 0 || (NativeMethods.GetKeyState(3) & 0x80) != 0;
			if ((NativeMethods.GetKeyState(160) & 0x80) == 0)
			{
				num = 1;
				if (Wj6IyuFgNUmcM2ZKPeGc != null)
				{
					goto IL_00e0;
				}
				goto IL_033c;
			}
			num2 = 1;
			goto IL_03a4;
		}
		goto IL_03a9;
		IL_033c:
		while (true)
		{
			switch (num)
			{
			case 6:
				if (FDYLAqISXHK != null)
				{
					FDYLAqISXHK(this, e);
					flag = flag || e.Handled;
				}
				goto IL_010f;
			case 5:
				if (GPvLAcTq7uH != null)
				{
					byte[] array = new byte[256];
					byte[] array2 = new byte[2];
					NativeMethods.GetKeyboardState(array);
					if (NativeMethods.ToAscii(keyboardHookStruct.vkCode, keyboardHookStruct.scanCode, array, array2, keyboardHookStruct.flags) == 1)
					{
						char c = (char)array2[0];
						if ((flag3 ^ flag4) && char.IsLetter(c))
						{
							c = char.ToUpper(c, CultureInfo.InvariantCulture);
						}
						KeyPressEventArgs e2 = new KeyPressEventArgs(c);
						GPvLAcTq7uH(this, e2);
						flag = flag || e.Handled;
						num = 1;
						if (!qD4yg1Fg9m4CSoMQl3LD())
						{
							continue;
						}
					}
				}
				goto IL_03a9;
			case 4:
				RealKeyState.KeyDown((int)e.KeyCode);
				goto IL_01ee;
			default:
				e.IsInjected = (keyboardHookStruct.flags & 0x10) != 0;
				e.IsExtended = (keyboardHookStruct.flags & 1) != 0;
				e.IsFromQuicker = keyboardHookStruct.dwExtraInfo == 4660;
				e.IsRestore = keyboardHookStruct.dwExtraInfo == 8756;
				switch ((int)wParam)
				{
				case 256:
				case 260:
					goto IL_02ef;
				case 257:
				case 261:
					goto IL_0319;
				}
				goto IL_010f;
			case 3:
				break;
			case 1:
				goto IL_0391;
			case 2:
				goto IL_03a9;
				IL_0319:
				if (!e.IsInjected)
				{
					RealKeyState.KeyUp((int)e.KeyCode);
				}
				goto case 6;
				IL_010f:
				if ((int)wParam == 256 && !flag && !e.SuppressKeyPress)
				{
					goto case 5;
				}
				goto IL_03a9;
				IL_02ef:
				if (!e.IsInjected)
				{
					e.IsRepeating = RealKeyState.IsKeyDown((int)e.KeyCode);
					goto case 4;
				}
				goto IL_01ee;
				IL_01ee:
				if (A9eLARj0OPW != null)
				{
					A9eLARj0OPW(this, e);
					flag = flag || e.Handled;
				}
				if (!flag && pSyLAVmVT6L != null && (e.KeyCode == Keys.Capital || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.Scroll))
				{
					pSyLAVmVT6L?.Invoke(this, e);
				}
				goto IL_010f;
			}
			break;
		}
		goto IL_037a;
		IL_037a:
		bool flag5 = (NativeMethods.GetKeyState(164) & 0x80) != 0 || (NativeMethods.GetKeyState(165) & 0x80) != 0;
		flag3 = NativeMethods.GetKeyState(20) != 0;
		e = new HookKeyEventArgs((Keys)(keyboardHookStruct.vkCode | (flag2 ? 131072 : 0) | (flag4 ? 65536 : 0) | (flag5 ? 262144 : 0)));
		num = 0;
		if (Wj6IyuFgNUmcM2ZKPeGc != null)
		{
			goto IL_00e0;
		}
		goto IL_033c;
		IL_00e0:
		int num3 = default(int);
		num = num3;
		goto IL_033c;
		IL_03a9:
		if (flag)
		{
			return (IntPtr)1;
		}
		return NativeMethods.CallNextHookEx(base.HandleToHook, nCode, wParam, lParam);
		IL_03a4:
		flag4 = (byte)num2 != 0;
		goto IL_037a;
		IL_0391:
		num2 = (((NativeMethods.GetKeyState(161) & 0x80) != 0) ? 1 : 0);
		goto IL_03a4;
	}

	public override void StartInternal()
	{
		RealKeyState.Reset();
	}

	public bool IsKeyDown(VirtualKeyCode key)
	{
		return RealKeyState.IsKeyDown((int)key);
	}

	internal static bool qD4yg1Fg9m4CSoMQl3LD()
	{
		return Wj6IyuFgNUmcM2ZKPeGc == null;
	}
}
