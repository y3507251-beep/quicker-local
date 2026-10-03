using System.Threading;
using System.Windows.Input;
using Quicker.Domain;
using Quicker.Domain.PowerKeys;
using Quicker.Utilities;
using WindowsInput.Native;

namespace SWBMfZYGyc6L9yHIvKQ;

internal class JrJWiKYIEBcPm8FFZOl
{
	internal static JrJWiKYIEBcPm8FFZOl G1GVmfFliSJPKRMglmxj;

	public static ModifierKeys Modifiers
	{
		get
		{
			if (Thread.CurrentThread.ManagedThreadId != AppState.UiThreadId && Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
			{
				return xU6LDL1qT4e();
			}
			return Keyboard.Modifiers;
		}
	}

	private static ModifierKeys xU6LDL1qT4e()
	{
		bool flag = KeyboardHelper.IsKeyDown(VirtualKeyCode.SHIFT);
		bool flag2 = KeyboardHelper.IsKeyDown(VirtualKeyCode.CONTROL);
		bool flag3 = KeyboardHelper.IsKeyDown(VirtualKeyCode.MENU);
		bool flag4 = KeyboardHelper.IsKeyDown(VirtualKeyCode.LWIN) || KeyboardHelper.IsKeyDown(VirtualKeyCode.RWIN);
		return (ModifierKeys)(0 | (flag ? 4 : 0) | (flag2 ? 2 : 0) | (flag3 ? 1 : 0) | (flag4 ? 8 : 0));
	}

	public static bool hCwLDvPTh1Q(VirtualKeyCode virtualKeyCode_0)
	{
		return KeyboardHelper.IsKeyDown(virtualKeyCode_0);
	}

	public static bool Dg0LDSnOcIg(VirtualKeyCode virtualKeyCode_0)
	{
		return KeyboardHelper.IsKeyLocked(virtualKeyCode_0);
	}

	public static bool kBQLD2aG1Qb()
	{
		return KeyboardHelper.IsKeyDown(VirtualKeyCode.RSHIFT);
	}

	public static bool uZxLDuAOweP()
	{
		return KeyboardHelper.IsKeyDown(VirtualKeyCode.LSHIFT);
	}

	public static bool I7rLDNZhD3f()
	{
		KeyboardState keyboardState = AppState.v5FtaQ4hQfg()?.dHavLMV7kRX()?.RealKeyState;
		if (keyboardState == null)
		{
			return false;
		}
		if (!keyboardState.IsKeyDown(160))
		{
			return keyboardState.IsKeyDown(161);
		}
		return true;
	}

	internal static bool By3rghFlllirC8WKnxQF()
	{
		return G1GVmfFliSJPKRMglmxj == null;
	}
}
