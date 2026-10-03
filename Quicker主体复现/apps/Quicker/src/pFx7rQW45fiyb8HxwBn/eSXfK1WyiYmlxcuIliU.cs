using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Quicker.Modules.TextTools;
using Quicker.Modules.TextTools.Tools;
using Quicker.Utilities;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace pFx7rQW45fiyb8HxwBn;

internal class eSXfK1WyiYmlxcuIliU : BaseTextTool
{
	private readonly KeysInputMode LHPtS4roXkD;

	private readonly KeyValueType ISZtS5Q5uSP;

	private static eSXfK1WyiYmlxcuIliU KmL48iQphMyBlnk48ahf;

	public eSXfK1WyiYmlxcuIliU(TextToolContext textToolContext_1, KeysInputMode keysInputMode_1, KeyValueType keyValueType_1)
		: base(textToolContext_1)
	{
		LHPtS4roXkD = keysInputMode_1;
		ISZtS5Q5uSP = keyValueType_1;
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		AppHelper.RunOnUiThread(false, WwBtSnhAEnA);
	}

	private string QeKtSB1aryZ(Hotkey hotkey_0)
	{
		if (hotkey_0 == null)
		{
			return string.Empty;
		}
		return ISZtS5Q5uSP switch
		{
			KeyValueType.VirtualKeyCode => ((int)hotkey_0.Key).ToString(CultureInfo.InvariantCulture), 
			KeyValueType.KeyName => ((Keys)hotkey_0.Key/*cast due to .constrained prefix*/).ToString(), 
			KeyValueType.SendKeys => YMMtSQPywEw(hotkey_0), 
			_ => "ERROR:未知的返回类型", 
		};
	}

	public static string YMMtSQPywEw(Hotkey hotkey_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (hotkey_0.Modifiers.HasFlag(ModifierKeys.Control))
		{
			stringBuilder.Append("^");
		}
		if (hotkey_0.Modifiers.HasFlag(ModifierKeys.Shift))
		{
			stringBuilder.Append("+");
		}
		if (hotkey_0.Modifiers.HasFlag(ModifierKeys.Alt))
		{
			stringBuilder.Append("%");
		}
		stringBuilder.Append(mW6tSjSgFNN(hotkey_0.Key));
		return stringBuilder.ToString();
	}

	public static string mW6tSjSgFNN(VirtualKeyCode virtualKeyCode_0)
	{
		VirtualKeyCode virtualKeyCode = virtualKeyCode_0;
		switch (virtualKeyCode)
		{
		case VirtualKeyCode.BACK:
			return "{BS}";
		case VirtualKeyCode.CANCEL:
			return "{BREAK}";
		case VirtualKeyCode.RETURN:
			return "{ENTER}";
		case VirtualKeyCode.TAB:
			return "{TAB}";
		case VirtualKeyCode.ESCAPE:
			return "{ESC}";
		case VirtualKeyCode.PRIOR:
			return "{PGUP}";
		case VirtualKeyCode.NEXT:
			return "{PGDN}";
		case VirtualKeyCode.END:
			return "{END}";
		case VirtualKeyCode.HOME:
			return "{HOME}";
		case VirtualKeyCode.LEFT:
			return "{LEFT}";
		case VirtualKeyCode.UP:
			return "{UP}";
		case VirtualKeyCode.RIGHT:
			return "{RIGHT}";
		case VirtualKeyCode.DOWN:
			return "{DOWN}";
		case VirtualKeyCode.SNAPSHOT:
			return "{PRTSC}";
		case VirtualKeyCode.INSERT:
			return "{INSERT}";
		case VirtualKeyCode.DELETE:
			return "{DEL}";
		case VirtualKeyCode.HELP:
			return "{HELP}";
		case VirtualKeyCode.CAPITAL:
			return "{CAPSLOCK}";
		default:
			if (virtualKeyCode >= VirtualKeyCode.F1 && virtualKeyCode <= VirtualKeyCode.F16)
			{
				return "{" + virtualKeyCode.ToString() + "}";
			}
			switch (virtualKeyCode)
			{
			case VirtualKeyCode.LSHIFT:
			case VirtualKeyCode.RSHIFT:
				return "+";
			case VirtualKeyCode.LCONTROL:
			case VirtualKeyCode.RCONTROL:
				return "^";
			case VirtualKeyCode.LMENU:
			case VirtualKeyCode.RMENU:
				return "%";
			case VirtualKeyCode.MULTIPLY:
				return "{MULTIPLY}";
			case VirtualKeyCode.ADD:
				return "{ADD}";
			case VirtualKeyCode.SUBTRACT:
				return "{SUBTRACT}";
			default:
			{
				string text = new KeysConverter().ConvertToString((int)virtualKeyCode_0).ToLowerInvariant();
				if (text.Length > 1)
				{
					text = KeyboardHelper.GetKeyName(virtualKeyCode_0);
					if (text.Length > 1)
					{
						AppHelper.ShowWarning("不支持此按键(" + text + ")。");
						return "";
					}
					return text;
				}
				return text;
			}
			case VirtualKeyCode.DIVIDE:
				return "{DIVIDE}";
			case VirtualKeyCode.SPACE:
				return " ";
			}
		case VirtualKeyCode.SCROLL:
			return "{SCROLLLOCK}";
		case VirtualKeyCode.NUMLOCK:
			return "{NUMLOCK}";
		}
	}

	[CompilerGenerated]
	private void WwBtSnhAEnA()
	{
		KeysInputWindow keysInputWindow = new KeysInputWindow(LHPtS4roXkD)
		{
			Owner = base.Context.ParentWindow
		};
		if (keysInputWindow.Owner == null || !keysInputWindow.Owner.IsVisible)
		{
			keysInputWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		}
		if (keysInputWindow.ShowDialog() == true)
		{
			string text = QeKtSB1aryZ(keysInputWindow.SelectedHotkey);
			base.Context.ProcessSelectedTextFunc?.Invoke(text, false);
		}
		else
		{
			CancelSelection("");
		}
	}

	internal static bool cIGEKcQpHWLha628Y5lF()
	{
		return KmL48iQphMyBlnk48ahf == null;
	}
}
