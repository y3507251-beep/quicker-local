using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using log4net;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using WindowsInput;
using WindowsInput.Native;

namespace Ko4fe7AdlIHVfm4LNc6;

internal static class D3mwCbAmx8tANGphaEi
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec HHTveSvXSJS;

		public static Func<string, string> L2Wve2uNMNX;

		public static Func<string, bool> Tndveuwvcrg;

		public static Func<string, string> urhveNKuDKI;

		public static Func<string, bool> cubveJJqIhw;

		internal static _003C_003Ec WZOFC9cbSwitAkK62U83;

		static _003C_003Ec()
		{
			HHTveSvXSJS = new _003C_003Ec();
		}

		internal string n5avetKW72x(string x)
		{
			return x.Trim();
		}

		internal bool KSOvegDtM67(string x)
		{
			if (!File.Exists(x))
			{
				return Directory.Exists(x);
			}
			return true;
		}

		internal string guBveLBc3pk(string x)
		{
			return x.Trim();
		}

		internal bool e6yvevosbiw(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal static bool LvF1T6cbwqAXZki8vLQV()
		{
			return WZOFC9cbSwitAkK62U83 == null;
		}
	}

	private static readonly ILog ddmAWALVkZ;

	internal static object cU9H3LHpbionvDxBJfP;

	internal static void ExecuteScript(string script)
	{
		if (string.IsNullOrWhiteSpace(script))
		{
			return;
		}
		string[] array = script.SplitToList();
		int num2 = default(int);
		foreach (string text in array)
		{
			if (text.StartsWith("//"))
			{
				continue;
			}
			int num = 0;
			if (!dHEZgJHXyweCXdqvd0k())
			{
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				WksAafhbsK(text);
			}
			catch (Exception ex)
			{
				ddmAWALVkZ.Warn(ex.Message, ex);
				throw new InvalidOperationException("处理输入命令出错：" + ex.Message + ", 原始命令：" + text, ex);
			}
		}
	}

	private static VirtualKeyCode YymA8QRe91(string string_0)
	{
		VirtualKeyCode num = KeyboardHelper.TranslateToKeyCode(string_0);
		if (num == VirtualKeyCode.None)
		{
			throw new InvalidDataException("未识别的按键：" + string_0);
		}
		return num;
	}

	private static void WksAafhbsK(string string_0)
	{
		int millisecondsTimeout = 1;
		string[] array = string_0.Split(new char[1] { ':' }, 2);
		if (array.Length != 2)
		{
			throw new InvalidDataException("命令数据格式不正确，缺少冒号(:)。原始内容：" + string_0);
		}
		string text = array[0].ToLower();
		string text2 = array[1];
		if (text != null)
		{
			int num;
			int num2 = default(int);
			List<string> list;
			char c;
			switch (text.Length)
			{
			case 2:
				if (text == "up")
				{
					HyKAZrbqpT(text2);
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				break;
			case 4:
				c = text[0];
				if (c != 'd')
				{
					if (c != 'm')
					{
						num = 1;
						if (cU9H3LHpbionvDxBJfP == null)
						{
							goto IL_03ae;
						}
						goto IL_03f4;
					}
					if (text == "move")
					{
						p4OAhp0cds(text2);
						Thread.Sleep(millisecondsTimeout);
						return;
					}
					break;
				}
				if (text == "down")
				{
					yrNAVm7OUR(text2);
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				break;
			case 5:
				c = text[0];
				if ((uint)c <= 105u)
				{
					if (c != 'c')
					{
						if (c != 'd')
						{
							if (c != 'i' || !(text == "input"))
							{
								break;
							}
							goto IL_059b;
						}
						if (!(text == "delay"))
						{
							break;
						}
						goto IL_0410;
					}
					if (!(text == "click"))
					{
						break;
					}
					nuhAqa40Cw(text2);
					Thread.Sleep(millisecondsTimeout);
					num = 7;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						goto IL_03aa;
					}
				}
				else
				{
					if (c == 'k')
					{
						if (text == "keyup")
						{
							VirtualKeyCode keyCode3 = YymA8QRe91(text2);
							InputSimulator.Instance.Keyboard.KeyUp(keyCode3);
							Thread.Sleep(millisecondsTimeout);
							return;
						}
						break;
					}
					if (c == 'p')
					{
						if (text == "paste")
						{
							if (!string.IsNullOrEmpty(text2))
							{
								ActionHelper.SendTextToWindow(text2, true, false, 50, 50);
							}
							return;
						}
						break;
					}
					num = 3;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						goto IL_03aa;
					}
				}
				goto IL_03ae;
			case 6:
				c = text[2];
				num2 = 13;
				goto IL_0333;
			case 7:
				c = text[0];
				if (c != 'd')
				{
					num = 9;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						goto IL_03aa;
					}
					goto IL_03ae;
				}
				if (text == "dbclick")
				{
					Ch7AcbbLkw(text2);
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				break;
			case 8:
			{
				c = text[0];
				if (c != 'k')
				{
					if (c != 's' || !(text == "sendkeys"))
					{
						break;
					}
					SendKeys.SendWait(text2);
					return;
				}
				if (!(text == "keypress"))
				{
					break;
				}
				VirtualKeyCode keyCode2 = YymA8QRe91(text2);
				InputSimulator.Instance.Keyboard.KeyPress(keyCode2);
				goto IL_0491;
			}
			case 9:
				c = text[0];
				if (c != 'i')
				{
					if (c != 'p' || !(text == "pastefile"))
					{
						break;
					}
					if (!string.IsNullOrEmpty(text2))
					{
						num = 14;
						if (!dHEZgJHXyweCXdqvd0k())
						{
							goto IL_03aa;
						}
						goto IL_03ae;
					}
					return;
				}
				if (!(text == "inputtext"))
				{
					break;
				}
				goto IL_059b;
			case 10:
				goto IL_05bc;
			case 11:
				{
					if (text == "hwheeldelta")
					{
						nKeA7Gmajq(text2, true);
						Thread.Sleep(millisecondsTimeout);
						return;
					}
					break;
				}
				IL_050b:
				list = text2.SplitToList(';').Select(_003C_003Ec.L2Wve2uNMNX ?? (_003C_003Ec.L2Wve2uNMNX = _003C_003Ec.HHTveSvXSJS.n5avetKW72x)).Where(_003C_003Ec.Tndveuwvcrg ?? (_003C_003Ec.Tndveuwvcrg = _003C_003Ec.HHTveSvXSJS.KSOvegDtM67))
					.ToList();
				if (!list.HasData())
				{
					throw new InvalidDataException("没有可粘贴的文件。请检查文件路径是否正确。");
				}
				ClipboardHelper.SetFile(list);
				AppHelper.SendPasteKeys();
				return;
				IL_05bc:
				c = text[0];
				if (c != 'p')
				{
					if (c != 'w' || !(text == "wheeldelta"))
					{
						break;
					}
					YVOARuueRK(text2, true);
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				if (!(text == "pasteimage"))
				{
					break;
				}
				if (!string.IsNullOrEmpty(text2))
				{
					string text3 = text2.Trim();
					if (File.Exists(text3))
					{
						ImageClipboardHelper.SetImageFromFile(text3);
						goto IL_0622;
					}
					throw new InvalidDataException("要粘贴的图片文件不存在。");
				}
				return;
				IL_059b:
				ActionHelper.SendTextToWindow(text2, false, false, 0, 0);
				return;
				IL_03ae:
				switch (num)
				{
				case 13:
					break;
				default:
					goto IL_034f;
				case 1:
					goto IL_03f4;
				case 3:
					if (c != 'w' || !(text == "wheel"))
					{
						goto end_IL_004e;
					}
					YVOARuueRK(text2, false);
					Thread.Sleep(millisecondsTimeout);
					return;
				case 6:
					Thread.Sleep(millisecondsTimeout);
					return;
				case 7:
					return;
				case 9:
					if (c != 'k' || !(text == "keydown"))
					{
						goto end_IL_004e;
					}
					goto case 2;
				case 2:
				{
					VirtualKeyCode keyCode = YymA8QRe91(text2);
					InputSimulator.Instance.Keyboard.KeyDown(keyCode);
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				case 11:
					goto IL_0491;
				case 4:
					goto IL_04d8;
				case 14:
					goto IL_050b;
				case 8:
					goto IL_05bc;
				case 5:
					goto IL_0622;
				case 10:
				case 12:
					goto end_IL_004e;
				}
				goto IL_0333;
				IL_0410:
				Thread.Sleep(Convert.ToInt32(text2));
				return;
				IL_03f4:
				if (c != 'w' || !(text == "wait"))
				{
					break;
				}
				goto IL_0410;
				IL_0622:
				AppHelper.SendPasteKeys();
				return;
				IL_034f:
				if (c != 'p')
				{
					break;
				}
				if (!(text == "input2"))
				{
					num = 12;
					if (cU9H3LHpbionvDxBJfP != null)
					{
						goto IL_03aa;
					}
					goto IL_03ae;
				}
				ActionHelper.SendTextToWindow(Regex.Unescape(text2), false, false, 0, 0);
				return;
				IL_0333:
				if ((uint)c <= 112u)
				{
					if (c == 'h')
					{
						if (!(text == "hwheel"))
						{
							break;
						}
						nKeA7Gmajq(text2, false);
						goto IL_04d8;
					}
					num = 0;
					if (cU9H3LHpbionvDxBJfP == null)
					{
						goto IL_034f;
					}
				}
				else
				{
					if (c != 't')
					{
						if (c != 'v' || !(text == "moveto"))
						{
							break;
						}
						cDuA9cehY0(text2);
						Thread.Sleep(millisecondsTimeout);
						return;
					}
					if (!(text == "hotkey"))
					{
						break;
					}
					dtZAeyacSu(text2);
					num = 6;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						goto IL_03aa;
					}
				}
				goto IL_03ae;
				IL_0491:
				Thread.Sleep(millisecondsTimeout);
				return;
				IL_04d8:
				Thread.Sleep(millisecondsTimeout);
				return;
				IL_03aa:
				num = num2;
				goto IL_03ae;
				end_IL_004e:
				break;
			}
		}
		throw new InvalidDataException("不支持的多步骤输入命令类型：" + text + "，可能拼写错误或者您使用的Quicker版本过低。");
	}

	private static void nKeA7Gmajq(string string_0, bool bool_0)
	{
		if (bool_0)
		{
			InputSimulator.Instance.Mouse.HorizontalScrollInDelta(Convert.ToInt32(string_0));
		}
		else
		{
			InputSimulator.Instance.Mouse.HorizontalScroll(Convert.ToInt32(string_0));
		}
	}

	private static void YVOARuueRK(string string_0, bool bool_0)
	{
		if (bool_0)
		{
			InputSimulator.Instance.Mouse.VerticalScrollInDelta(Convert.ToInt32(string_0));
		}
		else
		{
			InputSimulator.Instance.Mouse.VerticalScroll(Convert.ToInt32(string_0));
		}
	}

	private static void nuhAqa40Cw(string string_0)
	{
		string text = string_0.ToLower();
		if (text == null)
		{
			return;
		}
		switch (text.Length)
		{
		default:
			return;
		case 1:
		{
			char c = text[0];
			if (c == 'l')
			{
				goto IL_00e9;
			}
			if (c == 'm')
			{
				break;
			}
			if (c != 'r')
			{
				return;
			}
			goto IL_0108;
		}
		case 2:
		{
			char c = text[1];
			if (c != '1')
			{
				int num;
				if (c != '2')
				{
					num = 1;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						return;
					}
				}
				else
				{
					if (!(text == "x2"))
					{
						return;
					}
					InputSimulator.Instance.Mouse.XButtonClick(2);
					num = 0;
					if (!dHEZgJHXyweCXdqvd0k())
					{
						return;
					}
				}
				switch (num)
				{
				case 1:
					break;
				case 0:
					break;
				}
			}
			else if (text == "x1")
			{
				InputSimulator.Instance.Mouse.XButtonClick(1);
			}
			return;
		}
		case 4:
			if (!(text == "left"))
			{
				return;
			}
			goto IL_00e9;
		case 5:
			if (!(text == "right"))
			{
				return;
			}
			goto IL_0108;
		case 6:
			if (!(text == "middle"))
			{
				return;
			}
			break;
		case 3:
			return;
			IL_0108:
			InputSimulator.Instance.Mouse.RightButtonClick();
			return;
			IL_00e9:
			InputSimulator.Instance.Mouse.LeftButtonClick();
			return;
		}
		InputSimulator.Instance.Mouse.MiddleButtonClick();
	}

	private static void Ch7AcbbLkw(string string_0)
	{
		string text = string_0.ToLower();
		if (text == null)
		{
			return;
		}
		int num;
		int num2 = default(int);
		switch (text.Length)
		{
		default:
			return;
		case 1:
		{
			char c = text[0];
			if (c == 'l')
			{
				goto IL_00c9;
			}
			if (c != 'm')
			{
				if (c != 'r')
				{
					return;
				}
				goto IL_00f7;
			}
			goto IL_0117;
		}
		case 2:
			switch (text[1])
			{
			case '2':
				if (text == "x2")
				{
					InputSimulator.Instance.Mouse.XButtonDoubleClick(2);
				}
				break;
			case '1':
				if (text == "x1")
				{
					InputSimulator.Instance.Mouse.XButtonDoubleClick(1);
				}
				break;
			}
			return;
		case 4:
			if (!(text == "left"))
			{
				return;
			}
			goto IL_00c9;
		case 5:
			if (text == "right")
			{
				goto IL_00f7;
			}
			num = 0;
			if (dHEZgJHXyweCXdqvd0k())
			{
				break;
			}
			goto IL_0134;
		case 6:
			if (!(text == "middle"))
			{
				return;
			}
			goto IL_0117;
		case 3:
			return;
			IL_0117:
			InputSimulator.Instance.Mouse.MiddleButtonDoubleClick();
			num = 1;
			if (cU9H3LHpbionvDxBJfP == null)
			{
				break;
			}
			goto IL_0134;
			IL_0134:
			num = num2;
			break;
			IL_00c9:
			InputSimulator.Instance.Mouse.LeftButtonDoubleClick();
			return;
			IL_00f7:
			InputSimulator.Instance.Mouse.RightButtonDoubleClick();
			return;
		}
		switch (num)
		{
		case 1:
			break;
		}
	}

	private static void yrNAVm7OUR(string string_0)
	{
		string text = string_0.ToLower();
		if (text == null)
		{
			return;
		}
		char c;
		int num;
		int num2 = default(int);
		switch (text.Length)
		{
		case 1:
			c = text[0];
			if (c == 'l')
			{
				goto IL_00f6;
			}
			if (c != 'm')
			{
				num = 1;
				if (!dHEZgJHXyweCXdqvd0k())
				{
					goto IL_00ce;
				}
				goto IL_00d2;
			}
			goto IL_0135;
		case 2:
			c = text[1];
			if (c != '1')
			{
				if (c == '2' && text == "x2")
				{
					InputSimulator.Instance.Mouse.XButtonDown(2);
				}
				break;
			}
			if (!(text == "x1"))
			{
				break;
			}
			InputSimulator.Instance.Mouse.XButtonDown(1);
			num = 0;
			if (cU9H3LHpbionvDxBJfP != null)
			{
				goto IL_00ce;
			}
			goto IL_00d2;
		case 4:
			if (!(text == "left"))
			{
				break;
			}
			goto IL_00f6;
		case 5:
			if (!(text == "right"))
			{
				break;
			}
			goto IL_0116;
		case 6:
			if (!(text == "middle"))
			{
				break;
			}
			goto IL_0135;
		case 3:
			break;
			IL_0116:
			InputSimulator.Instance.Mouse.RightButtonDown();
			break;
			IL_00ce:
			num = num2;
			goto IL_00d2;
			IL_00d2:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			if (c != 'r')
			{
				break;
			}
			goto IL_0116;
			IL_0135:
			InputSimulator.Instance.Mouse.MiddleButtonDown();
			break;
			IL_00f6:
			InputSimulator.Instance.Mouse.LeftButtonDown();
			break;
		}
	}

	private static void HyKAZrbqpT(string string_0)
	{
		int num = 1;
		char c = default(char);
		while (true)
		{
			string text = string_0.ToLower();
			int num2 = 0;
			if (!dHEZgJHXyweCXdqvd0k())
			{
				goto IL_0055;
			}
			goto IL_0059;
			IL_0059:
			while (true)
			{
				switch (num2)
				{
				default:
					if (text != null)
					{
						switch (text.Length)
						{
						default:
							return;
						case 1:
							break;
						case 2:
							goto IL_0084;
						case 3:
							return;
						case 4:
							goto IL_00df;
						case 5:
							goto IL_00ee;
						case 6:
							goto IL_00fd;
						}
						goto IL_003e;
					}
					return;
				case 1:
					break;
				case 2:
					{
						if (c != 'l')
						{
							if (c != 'm')
							{
								if (c != 'r')
								{
									return;
								}
								goto IL_011f;
							}
							goto IL_0130;
						}
						goto IL_0141;
					}
					IL_00df:
					if (!(text == "left"))
					{
						return;
					}
					goto IL_0141;
					IL_0141:
					InputSimulator.Instance.Mouse.LeftButtonUp();
					return;
					IL_0084:
					switch (text[1])
					{
					case '2':
						if (text == "x2")
						{
							InputSimulator.Instance.Mouse.XButtonUp(2);
						}
						break;
					case '1':
						if (text == "x1")
						{
							InputSimulator.Instance.Mouse.XButtonUp(1);
						}
						break;
					}
					return;
					IL_00fd:
					if (!(text == "middle"))
					{
						return;
					}
					goto IL_0130;
					IL_0130:
					InputSimulator.Instance.Mouse.MiddleButtonUp();
					return;
					IL_00ee:
					if (!(text == "right"))
					{
						return;
					}
					goto IL_011f;
					IL_011f:
					InputSimulator.Instance.Mouse.RightButtonUp();
					return;
				}
				break;
				IL_003e:
				c = text[0];
				num2 = 2;
				if (cU9H3LHpbionvDxBJfP == null)
				{
					continue;
				}
				goto IL_0055;
			}
			continue;
			IL_0055:
			num2 = num;
			goto IL_0059;
		}
	}

	private static void cDuA9cehY0(string string_0)
	{
		string[] array = string_0.Split(',', '，');
		if (array.Length != 2)
		{
			throw new InvalidDataException("坐标格式不正确");
		}
		int x = XIqAYuMNvx(array[0].Trim());
		int y = AWQAIKRsM1(array[1].Trim());
		Cursor.Position = new Point(x, y);
	}

	private static void p4OAhp0cds(string string_0)
	{
		string[] array = string_0.Split(',', '，');
		if (array.Length != 2)
		{
			throw new InvalidDataException("坐标格式不正确");
		}
		int dx = int.Parse(array[0]);
		int dy = int.Parse(array[1]);
		Point position = Cursor.Position;
		position.Offset(dx, dy);
		Cursor.Position = position;
	}

	private static void dtZAeyacSu(string string_0)
	{
		List<string> list = string_0.Split('+', '＋').Select(_003C_003Ec.urhveNKuDKI ?? (_003C_003Ec.urhveNKuDKI = _003C_003Ec.HHTveSvXSJS.guBveLBc3pk)).Where(_003C_003Ec.cubveJJqIhw ?? (_003C_003Ec.cubveJJqIhw = _003C_003Ec.HHTveSvXSJS.e6yvevosbiw))
			.ToList();
		IList<VirtualKeyCode> list2 = new List<VirtualKeyCode>();
		IList<VirtualKeyCode> list3 = new List<VirtualKeyCode>();
		foreach (string item in list)
		{
			VirtualKeyCode virtualKeyCode = YymA8QRe91(item);
			switch (virtualKeyCode)
			{
			default:
				list3.Add(virtualKeyCode);
				break;
			case VirtualKeyCode.LWIN:
			case VirtualKeyCode.RWIN:
				list2.Add(virtualKeyCode);
				break;
			case VirtualKeyCode.SHIFT:
			case VirtualKeyCode.LSHIFT:
			case VirtualKeyCode.RSHIFT:
				list2.Add(virtualKeyCode);
				break;
			case VirtualKeyCode.CONTROL:
			case VirtualKeyCode.LCONTROL:
			case VirtualKeyCode.RCONTROL:
				list2.Add(virtualKeyCode);
				break;
			case VirtualKeyCode.MENU:
			case VirtualKeyCode.LMENU:
			case VirtualKeyCode.RMENU:
				list2.Add(virtualKeyCode);
				break;
			}
		}
		InputSimulator.Instance.Keyboard.ModifiedKeyStroke(list2, list3, AppHelper.kPoLTdWFLA7());
	}

	static D3mwCbAmx8tANGphaEi()
	{
		ddmAWALVkZ = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static int XIqAYuMNvx(string string_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)Screen.PrimaryScreen.Bounds.Left + string_0.PercentToDouble() * (double)Screen.PrimaryScreen.Bounds.Width);
		}
		return int.Parse(string_0);
	}

	[CompilerGenerated]
	internal static int AWQAIKRsM1(string string_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)Screen.PrimaryScreen.Bounds.Top + string_0.PercentToDouble() * (double)Screen.PrimaryScreen.Bounds.Height);
		}
		return int.Parse(string_0);
	}

	internal static bool dHEZgJHXyweCXdqvd0k()
	{
		return cU9H3LHpbionvDxBJfP == null;
	}
}
