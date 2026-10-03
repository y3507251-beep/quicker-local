using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using WindowsInput.Native;

namespace Quicker.Utilities;

public static class KeyboardHelper
{
	[StructLayout(LayoutKind.Explicit)]
	private struct flRjJLDonyRY1Pm6Jgl
	{
		[FieldOffset(0)]
		public short Value;

		[FieldOffset(0)]
		public readonly byte FW62g6dY3EO;

		[FieldOffset(1)]
		public readonly byte H2l2gXRyGU5;
	}

	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<VirtualKeyCode, string> uHr2gmOVUVc;

		static _003C_003EO()
		{
		}

		internal static void e0gSLryDkvSanlfK3uoY()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec b6j2grRpTHg;

		internal static _003C_003Ec pK3YlsyDatZWK68FHdHG;

		static _003C_003Ec()
		{
			b6j2grRpTHg = new _003C_003Ec();
		}

		internal bool Ljg2gKBvtyu(Key item)
		{
			return item != Key.None;
		}

		internal byte tpe2gxKHDaG(Key item)
		{
			return (byte)KeyInterop.VirtualKeyFromKey(item);
		}

		internal static bool aAdC4WyDrSjYsUhXtkkl()
		{
			return pK3YlsyDatZWK68FHdHG == null;
		}
	}

	private static readonly IDictionary<VirtualKeyCode, string> a9lLMoTUgQB;

	private static readonly byte[] FDELMTJEICW;

	internal static object GEYxPOFRhJD5T2veflyj;

	public static VirtualKeyCode TranslateToKeyCode(string keyName)
	{
        flRjJLDonyRY1Pm6Jgl flRjJLDonyRY1Pm6Jgl = default;
        string text2 = default;
		string text;
		uint num;
		int num2;
		if (!string.Equals(keyName, "control", StringComparison.OrdinalIgnoreCase))
		{
			if (string.Equals(keyName, "shift", StringComparison.OrdinalIgnoreCase))
			{
				return VirtualKeyCode.SHIFT;
			}
			if (string.Equals(keyName, "alt", StringComparison.OrdinalIgnoreCase))
			{
				return VirtualKeyCode.MENU;
			}
			if (Enum.TryParse<Keys>(keyName, true, out var result))
			{
				return (VirtualKeyCode)result;
			}
			if (Enum.TryParse<VirtualKeyCode>(keyName, true, out var result2))
			{
				return result2;
			}
			text = keyName.ToLower();
			num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
			if (num <= 1158232965)
			{
				if (num <= 438466282)
				{
					if (num <= 203579616)
					{
						num2 = 17;
						if (!AGwSDTFRHcGNZXYKvljM())
						{
							goto IL_08b6;
						}
						goto IL_0bbd;
					}
					if (num <= 352699745)
					{
						if (num <= 297952813)
						{
							if (num != 220357235)
							{
								if (num == 297952813)
								{
									if (!(text == "select"))
									{
										num2 = 10;
										if (!AGwSDTFRHcGNZXYKvljM())
										{
											goto IL_0889;
										}
										goto IL_08b6;
									}
									return VirtualKeyCode.SELECT;
								}
							}
							else if (text == "f8")
							{
								return VirtualKeyCode.F8;
							}
						}
						else if (num != 306900080)
						{
							if (num == 337800568)
							{
								if (!(text == "f1"))
								{
									num2 = 0;
									if (!AGwSDTFRHcGNZXYKvljM())
									{
										goto IL_0889;
									}
									goto IL_08b6;
								}
								return VirtualKeyCode.F1;
							}
							if (num == 352699745 && text == "rbutton")
							{
								goto IL_0684;
							}
						}
						else if (text == "left")
						{
							return VirtualKeyCode.LEFT;
						}
					}
					else if (num <= 388133425)
					{
						if (num != 371355806)
						{
							goto IL_0b06;
						}
						if (text == "f3")
						{
							return VirtualKeyCode.F3;
						}
					}
					else if (num != 404911044)
					{
						if (num == 421688663)
						{
							if (!(text == "f4"))
							{
								num2 = 36;
								if (GEYxPOFRhJD5T2veflyj == null)
								{
									goto IL_08b6;
								}
								goto IL_0a46;
							}
							return VirtualKeyCode.F4;
						}
						if (num == 438466282)
						{
							goto IL_0984;
						}
					}
					else if (text == "f5")
					{
						return VirtualKeyCode.F5;
					}
				}
				else if (num <= 894689925)
				{
					if (num <= 722245873)
					{
						num2 = 8;
						if (GEYxPOFRhJD5T2veflyj != null)
						{
							goto IL_0889;
						}
						goto IL_08b6;
					}
					if (num <= 772578730)
					{
						if (num != 728231983)
						{
							switch (num)
							{
							case 772578730u:
								if (text == "+")
								{
									return VirtualKeyCode.ADD;
								}
								break;
							case 762061944u:
								if (text == "scrolldown")
								{
									return VirtualKeyCode.APP_SCROLL_DOWN;
								}
								break;
							}
						}
						else if (text == "capslock")
						{
							goto IL_0f50;
						}
					}
					else if (num != 781226039)
					{
						if (num != 789356349)
						{
							if (num == 894689925)
							{
								goto IL_0b91;
							}
						}
						else if (text == "*")
						{
							return VirtualKeyCode.MULTIPLY;
						}
					}
					else if (text == "prtsc")
					{
						goto IL_0f8f;
					}
				}
				else
				{
					if (num > 1074344870)
					{
						if (num <= 1124677727)
						{
							goto IL_088f;
						}
						goto IL_0a6a;
					}
					if (num <= 1035581717)
					{
						if (num != 923542272)
						{
							if (num == 1035581717 && text == "down")
							{
								return VirtualKeyCode.DOWN;
							}
						}
						else if (text == "mbtn")
						{
							goto IL_0756;
						}
					}
					else if (num != 1040789632)
					{
						switch (num)
						{
						case 1074344870u:
							if (text == "num1")
							{
								return VirtualKeyCode.NUMPAD1;
							}
							break;
						case 1057567251u:
							if (text == "num2")
							{
								return VirtualKeyCode.NUMPAD2;
							}
							break;
						}
					}
					else if (text == "num3")
					{
						goto IL_0f4d;
					}
				}
			}
			else if (num <= 2581912890u)
			{
				if (num <= 1704568510)
				{
					if (num <= 1320620651)
					{
						if (num <= 1208565822)
						{
							if (num != 1170961795)
							{
								if (num == 1208565822 && text == "num9")
								{
									return VirtualKeyCode.NUMPAD9;
								}
							}
							else if (text == "scrolllock")
							{
								goto IL_0fa4;
							}
						}
						else if (num != 1225343441)
						{
							if (num != 1229125814)
							{
								if (num == 1320620651 && text == "pageup")
								{
									goto IL_0659;
								}
							}
							else if (text == "scrollright")
							{
								return VirtualKeyCode.APP_SCROLL_RIGHT;
							}
						}
						else if (text == "num8")
						{
							return VirtualKeyCode.NUMPAD8;
						}
					}
					else if (num <= 1486790257)
					{
						if (num != 1386144670)
						{
							if (num == 1409389383)
							{
								goto IL_099a;
							}
							if (num == 1486790257)
							{
								if (!(text == "scrollup"))
								{
									num2 = 24;
									if (!AGwSDTFRHcGNZXYKvljM())
									{
										goto IL_0889;
									}
									goto IL_08b6;
								}
								return VirtualKeyCode.APP_SCROLL_UP;
							}
						}
						else if (text == "control")
						{
							goto IL_0f56;
						}
					}
					else
					{
						if (num != 1538531746)
						{
							num2 = 9;
							if (GEYxPOFRhJD5T2veflyj != null)
							{
								goto IL_0889;
							}
							goto IL_08b6;
						}
						if (text == "back")
						{
							goto IL_0581;
						}
					}
				}
				else
				{
					if (num > 2246981567u)
					{
						goto IL_0dca;
					}
					if (num <= 1887753101)
					{
						switch (num)
						{
						case 1887753101u:
							if (text == "pause")
							{
								return VirtualKeyCode.PAUSE;
							}
							break;
						case 1787721130u:
							if (text == "end")
							{
								return VirtualKeyCode.END;
							}
							break;
						}
					}
					else if (num != 2028154341)
					{
						if (num != 2235328556u)
						{
							goto IL_0960;
						}
						if (text == "backspace")
						{
							goto IL_0581;
						}
					}
					else if (text == "right")
					{
						return VirtualKeyCode.RIGHT;
					}
				}
			}
			else if (num > 3712926252u)
			{
				if (num <= 3981920889u)
				{
					if (num <= 3776985003u)
					{
						if (num != 3724402957u)
						{
							if (num != 3739752062u)
							{
								goto IL_0acc;
							}
							if (text == "pagedown")
							{
								goto IL_0f6e;
							}
						}
						else if (text == "enter")
						{
							goto IL_0f17;
						}
					}
					else if (num != 3906143141u)
					{
						if (num != 3968918830u)
						{
							if (num == 3981920889u && text == "lbtn")
							{
								goto IL_0f61;
							}
						}
						else if (text == "mail")
						{
							return VirtualKeyCode.LAUNCH_MAIL;
						}
					}
					else if (text == "pgup")
					{
						goto IL_0659;
					}
				}
				else if (num <= 4197582936u)
				{
					if (num != 4009345063u)
					{
						goto IL_0d44;
					}
					if (text == "rbtn")
					{
						goto IL_0684;
					}
				}
				else
				{
					switch (num)
					{
					case 4266524220u:
						if (text == "numlock")
						{
							return VirtualKeyCode.NUMLOCK;
						}
						break;
					case 4231138174u:
						if (text == "f12")
						{
							return VirtualKeyCode.F12;
						}
						break;
					case 4214360555u:
						if (text == "f11")
						{
							return VirtualKeyCode.F11;
						}
						break;
					}
				}
			}
			else if (num <= 3332609576u)
			{
				if (num > 2770536920u)
				{
					if (num != 3023392844u)
					{
						switch (num)
						{
						case 3332609576u:
							if (text == "insert")
							{
								return VirtualKeyCode.INSERT;
							}
							break;
						case 3220866424u:
							if (text == "comma")
							{
								return VirtualKeyCode.OEM_COMMA;
							}
							break;
						}
					}
					else if (text == "mbutton")
					{
						goto IL_0756;
					}
				}
				else if (num != 2652972038u)
				{
					if (num == 2770536920u && text == "caps")
					{
						goto IL_0f50;
					}
				}
				else if (text == "escape")
				{
					goto IL_0f4a;
				}
			}
			else
			{
				if (num > 3536372366u)
				{
					if (num != 3551317645u)
					{
						goto IL_0864;
					}
					goto IL_0af0;
				}
				if (num != 3378807160u)
				{
					switch (num)
					{
					case 3536372366u:
						if (text == "home")
						{
							return VirtualKeyCode.HOME;
						}
						break;
					case 3478752842u:
						if (text == "del")
						{
							return VirtualKeyCode.DELETE;
						}
						break;
					}
				}
				else if (text == "break")
				{
					goto IL_0fb2;
				}
			}
			goto IL_0eb8;
		}
		return VirtualKeyCode.CONTROL;
		IL_0581:
		return VirtualKeyCode.BACK;
		IL_099a:
		if (!(text == "shift"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.SHIFT;
		IL_0756:
		return VirtualKeyCode.MBUTTON;
		IL_0684:
		return VirtualKeyCode.RBUTTON;
		IL_0dca:
		if (num <= 2459114655u)
		{
			if (num != 2443994791u)
			{
				if (num != 2455421340u)
				{
					if (num != 2459114655u || !(text == "prtscr"))
					{
						goto IL_0eb8;
					}
				}
				else if (!(text == "printscreen"))
				{
					goto IL_0eb8;
				}
				goto IL_0f8f;
			}
			if (text == "app1")
			{
				return VirtualKeyCode.LAUNCH_APP1;
			}
		}
		else if (num != 2460772410u)
		{
			if (num != 2566336076u)
			{
				goto IL_0e47;
			}
			if (text == "tab")
			{
				return VirtualKeyCode.TAB;
			}
		}
		else if (text == "app2")
		{
			return VirtualKeyCode.LAUNCH_APP2;
		}
		goto IL_0eb8;
		IL_0acc:
		if (num != 3776985003u || !(text == "capital"))
		{
			goto IL_0eb8;
		}
		goto IL_0f50;
		IL_0d71:
		if (!(text == "pgdn"))
		{
			goto IL_0eb8;
		}
		goto IL_0f6e;
		IL_0eb8:
		text2 = default(string);
		flRjJLDonyRY1Pm6Jgl = default(flRjJLDonyRY1Pm6Jgl);
		if (!string.IsNullOrEmpty(keyName))
		{
			if (keyName.Length != 1)
			{
				if (keyName.Length != 2 || !keyName.StartsWith("\\", StringComparison.Ordinal))
				{
					if (keyName.StartsWith("#", StringComparison.Ordinal))
					{
						text2 = keyName.Substring(1);
						num2 = 1;
						if (GEYxPOFRhJD5T2veflyj != null)
						{
							goto IL_0889;
						}
						goto IL_08b6;
					}
					return VirtualKeyCode.None;
				}
				return TranslateToKeyCode(keyName.Substring(1));
			}
			flRjJLDonyRY1Pm6Jgl = default(flRjJLDonyRY1Pm6Jgl);
			goto IL_0f71;
		}
		return VirtualKeyCode.NONAME;
		IL_0d90:
		if (num != 455432284 || !(text == "alt"))
		{
			goto IL_0eb8;
		}
		goto IL_0f98;
		IL_088f:
		if (num != 1091122489)
		{
			if (num != 1107900108)
			{
				num2 = 13;
				if (GEYxPOFRhJD5T2veflyj == null)
				{
					goto IL_08b6;
				}
			}
			else if (text == "num7")
			{
				return VirtualKeyCode.NUMPAD7;
			}
		}
		else if (text == "num0")
		{
			return VirtualKeyCode.NUMPAD0;
		}
		goto IL_0eb8;
		IL_0f50:
		return VirtualKeyCode.CAPITAL;
		IL_0b06:
		switch (num)
		{
		case 388133425u:
			if (!(text == "f2"))
			{
				break;
			}
			return VirtualKeyCode.F2;
		case 372738696u:
			if (!(text == "print"))
			{
				break;
			}
			return VirtualKeyCode.PRINT;
		}
		goto IL_0eb8;
		IL_0f4d:
		return VirtualKeyCode.NUMPAD3;
		IL_0f8f:
		return VirtualKeyCode.SNAPSHOT;
		IL_0a16:
		if (num != 1550717474)
		{
			if (num == 1704568510)
			{
				goto IL_0ba7;
			}
		}
		else if (text == "clear")
		{
			return VirtualKeyCode.CLEAR;
		}
		goto IL_0eb8;
		IL_0f71:
		flRjJLDonyRY1Pm6Jgl.Value = NativeMethods.VkKeyScan(keyName[0]);
		return (VirtualKeyCode)flRjJLDonyRY1Pm6Jgl.FW62g6dY3EO;
		IL_09c7:
		if (num != 671913016)
		{
			if (num != 705468254)
			{
				if (num == 722245873)
				{
					goto IL_0b49;
				}
			}
			else if (text == "/")
			{
				return VirtualKeyCode.DIVIDE;
			}
		}
		else if (text == "-")
		{
			return VirtualKeyCode.SUBTRACT;
		}
		goto IL_0eb8;
		IL_0af0:
		if (!(text == "apps"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.APPS;
		IL_0f66:
		return VirtualKeyCode.LWIN;
		IL_0960:
		if (num != 2246981567u || !(text == "return"))
		{
			goto IL_0eb8;
		}
		goto IL_0f17;
		IL_0d44:
		if (num == 4176997806u)
		{
			goto IL_0d71;
		}
		if (num != 4197582936u || !(text == "f10"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.F10;
		IL_0bbd:
		if (num <= 102175844)
		{
			if (num <= 41178555)
			{
				if (num != 5556585)
				{
					if (num == 41178555 && text == "cap")
					{
						goto IL_0f50;
					}
				}
				else if (text == "rwin")
				{
					return VirtualKeyCode.RWIN;
				}
			}
			else if (num != 49887787)
			{
				if (num != 83144765)
				{
					if (num == 102175844)
					{
						goto IL_0c35;
					}
				}
				else if (text == "scrollleft")
				{
					return VirtualKeyCode.APP_SCROLL_LEFT;
				}
			}
			else if (text == "lwin")
			{
				goto IL_0f66;
			}
		}
		else
		{
			if (num > 114631999)
			{
				goto IL_0ce2;
			}
			if (num != 105778099)
			{
				if (num != 107912219)
				{
					if (num == 114631999 && text == "xbutton2")
					{
						return VirtualKeyCode.XBUTTON2;
					}
				}
				else if (text == "cancel")
				{
					goto IL_0fb2;
				}
			}
			else if (text == "lbutton")
			{
				goto IL_0f61;
			}
		}
		goto IL_0eb8;
		IL_0ce2:
		if (num != 131409618)
		{
			if (num != 200788825)
			{
				if (num == 203579616 && text == "f9")
				{
					return VirtualKeyCode.F9;
				}
			}
			else if (text == "win")
			{
				goto IL_0f66;
			}
		}
		else if (text == "xbutton1")
		{
			return VirtualKeyCode.XBUTTON1;
		}
		goto IL_0eb8;
		IL_0fb2:
		return VirtualKeyCode.CANCEL;
		IL_0a6a:
		switch (num)
		{
		case 1158232965u:
			if (!(text == "num4"))
			{
				break;
			}
			return VirtualKeyCode.NUMPAD4;
		case 1141455346u:
			if (!(text == "num5"))
			{
				break;
			}
			return VirtualKeyCode.NUMPAD5;
		case 1128467232u:
			if (text == "up")
			{
				return VirtualKeyCode.UP;
			}
			break;
		}
		goto IL_0eb8;
		IL_0f4a:
		return VirtualKeyCode.ESCAPE;
		IL_0889:
		int num3 = default(int);
		num2 = num3;
		goto IL_08b6;
		IL_0f17:
		return VirtualKeyCode.RETURN;
		IL_08b6:
		switch (num2)
		{
		case 39:
			break;
		case 26:
			goto IL_088f;
		case 2:
			goto IL_0960;
		case 4:
			goto IL_0984;
		case 7:
			goto IL_099a;
		case 8:
			if (num > 455432284)
			{
				goto IL_09c7;
			}
			num3 = 37;
			goto case 37;
		case 9:
			goto IL_0a16;
		case 13:
			goto IL_0a46;
		case 15:
			goto IL_0a6a;
		case 17:
			goto IL_0acc;
		case 19:
			goto IL_0af0;
		case 21:
			goto IL_0b06;
		case 22:
			goto IL_0b49;
		case 27:
			goto IL_0b91;
		case 28:
			goto IL_0ba7;
		case 31:
			goto IL_0bbd;
		case 14:
			goto IL_0c35;
		case 29:
			goto IL_0ce2;
		case 32:
			goto IL_0d44;
		case 33:
			goto IL_0d71;
		case 37:
			if (num != 455243901)
			{
				goto IL_0d90;
			}
			goto case 12;
		case 12:
			if (!(text == "f6"))
			{
				goto IL_0eb8;
			}
			return VirtualKeyCode.F6;
		case 38:
			goto IL_0dca;
		case 16:
			goto IL_0e47;
		default:
			goto IL_0eb8;
		case 1:
			goto IL_0ee3;
		case 30:
			goto IL_0f4d;
		case 35:
			goto IL_0f71;
		}
		goto IL_0864;
		IL_0ee3:
		if (text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			return (VirtualKeyCode)int.Parse(text2.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return (VirtualKeyCode)int.Parse(text2, CultureInfo.InvariantCulture);
		IL_0f56:
		return VirtualKeyCode.CONTROL;
		IL_0659:
		return VirtualKeyCode.PRIOR;
		IL_0b49:
		if (!(text == "."))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.DECIMAL;
		IL_0f98:
		return VirtualKeyCode.MENU;
		IL_0c35:
		if (!(text == "ctrl"))
		{
			goto IL_0eb8;
		}
		goto IL_0f56;
		IL_0e47:
		if (num != 2581912890u || !(text == "menu"))
		{
			goto IL_0eb8;
		}
		goto IL_0f98;
		IL_0ba7:
		if (!(text == "esc"))
		{
			goto IL_0eb8;
		}
		goto IL_0f4a;
		IL_0a46:
		if (num != 1124677727 || !(text == "num6"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.NUMPAD6;
		IL_0984:
		if (!(text == "f7"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.F7;
		IL_0fa4:
		return VirtualKeyCode.SCROLL;
		IL_0f61:
		return VirtualKeyCode.LBUTTON;
		IL_0864:
		if (num != 3656316258u)
		{
			if (num != 3712926252u)
			{
				num2 = 6;
				if (!AGwSDTFRHcGNZXYKvljM())
				{
					goto IL_0889;
				}
				goto IL_08b6;
			}
			if (text == "scroll")
			{
				goto IL_0fa4;
			}
		}
		else
		{
			if (text == "numpadenter")
			{
				return VirtualKeyCode.NumpadEnter;
			}
			num3 = 23;
		}
		goto IL_0eb8;
		IL_0b91:
		if (!(text == "space"))
		{
			goto IL_0eb8;
		}
		return VirtualKeyCode.SPACE;
		IL_0f6e:
		return VirtualKeyCode.NEXT;
	}

	public static string GetKeyName(VirtualKeyCode code)
	{
		if (a9lLMoTUgQB.ContainsKey(code))
		{
			return a9lLMoTUgQB[code];
		}
		string text = code.ToString();
		if (text.StartsWith("VK_", StringComparison.OrdinalIgnoreCase))
		{
			return text.Substring(3);
		}
		return text;
	}

	public static string GetKeysName(IList<VirtualKeyCode> modifierKeys, IList<VirtualKeyCode> keys)
	{
		keys = keys ?? new List<VirtualKeyCode>();
		string text = ((modifierKeys == null || modifierKeys.Count <= 0) ? string.Join(",", keys.Select(_003C_003EO.uHr2gmOVUVc ?? (_003C_003EO.uHr2gmOVUVc = GetKeyName))) : (string.Join("+", modifierKeys.Select(_003C_003EO.uHr2gmOVUVc ?? (_003C_003EO.uHr2gmOVUVc = GetKeyName))) + "+ [ " + string.Join(",", keys.Select(_003C_003EO.uHr2gmOVUVc ?? (_003C_003EO.uHr2gmOVUVc = GetKeyName))) + " ]"));
		if (string.IsNullOrEmpty(text))
		{
			return "<未设置>";
		}
		return text;
	}

	[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool a6tLM5GG1EJ(byte[] byte_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern short GetKeyState(int keyCode);

	public static bool IsAnyKeyDown()
	{
		int num = 7;
		while (true)
		{
			if (num <= 254)
			{
				if (num != 18 && num != 17 && num != 16 && (GetAsyncKeyState(num) & 0x8000) != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool IsAnyModifierKeyDown()
	{
		foreach (VirtualKeyCode item in new List<VirtualKeyCode>
		{
			VirtualKeyCode.CONTROL,
			VirtualKeyCode.MENU,
			VirtualKeyCode.SHIFT,
			VirtualKeyCode.LWIN,
			VirtualKeyCode.RWIN
		})
		{
			if (IsKeyDown(item))
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsKeyDown(VirtualKeyCode key)
	{
		return (GetAsyncKeyState((int)key) & 0x8000) != 0;
	}

	public static bool IsKeyLocked(VirtualKeyCode key)
	{
		return (GetKeyState((int)key) & 1) != 0;
	}

	public static Keys KeyFromValueOrName(string valueOrName)
	{
		if (string.IsNullOrEmpty(valueOrName))
		{
			throw new ArgumentException("键值为空。");
		}
		if (valueOrName.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			return (Keys)Convert.ToInt32(valueOrName, 16);
		}
		if (int.TryParse(valueOrName, out var result))
		{
			return (Keys)result;
		}
		if (!Enum.TryParse<Keys>(valueOrName, true, out var result2))
		{
			throw new ArgumentException("无法识别的键值：" + valueOrName);
		}
		return result2;
	}

	public static (bool isDown, bool isToggle) GetKeyStateFromSystem(Keys key)
	{
		short keyState = GetKeyState((int)key);
		bool item = false;
		bool item2 = false;
		if ((keyState & 0x8000) == 32768)
		{
			item = true;
		}
		if ((keyState & 1) == 1)
		{
			item2 = true;
		}
		return (isDown: item, isToggle: item2);
	}

	public static int GetMouseButtonKeyCode(MouseButtons button)
	{
		int result = 0;
		int num;
		if (button <= MouseButtons.Right)
		{
			if (button != MouseButtons.Left)
			{
				num = 1;
				if (GEYxPOFRhJD5T2veflyj != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0057;
			}
			result = 1;
		}
		else if (button != MouseButtons.Middle)
		{
			if (button != MouseButtons.XButton1)
			{
				if (button == MouseButtons.XButton2)
				{
					result = 6;
					num = 0;
					if (!AGwSDTFRHcGNZXYKvljM())
					{
						goto IL_0057;
					}
				}
			}
			else
			{
				result = 5;
			}
		}
		else
		{
			result = 4;
		}
		goto IL_007d;
		IL_0057:
		switch (num)
		{
		case 1:
			if (button == MouseButtons.Right)
			{
				result = 2;
			}
			break;
		}
		goto IL_007d;
		IL_007d:
		return result;
	}

	public static MouseButtons MouseButtonFromKeyCode(int keyCode)
	{
		return keyCode switch
		{
			1 => MouseButtons.Left, 
			2 => MouseButtons.Right, 
			4 => MouseButtons.Middle, 
			5 => MouseButtons.XButton1, 
			6 => MouseButtons.XButton2, 
			_ => MouseButtons.None, 
		};
	}

	public static int GetMouseScrollKeyCode(bool isVertical, int delta)
	{
		if (isVertical)
		{
			if (delta < 0)
			{
				return 258;
			}
			return 257;
		}
		if (delta > 0)
		{
			return 260;
		}
		return 259;
	}

	internal static bool fDPLMDBnLis(VirtualKeyCode virtualKeyCode_0, VirtualKeyCode virtualKeyCode_1)
	{
		if (virtualKeyCode_0 == virtualKeyCode_1)
		{
			return true;
		}
		switch (virtualKeyCode_0)
		{
		case VirtualKeyCode.CONTROL:
			if (virtualKeyCode_1 != VirtualKeyCode.LCONTROL)
			{
				return virtualKeyCode_1 == VirtualKeyCode.RCONTROL;
			}
			return true;
		case VirtualKeyCode.MENU:
			if (virtualKeyCode_1 != VirtualKeyCode.LMENU)
			{
				return virtualKeyCode_1 == VirtualKeyCode.RMENU;
			}
			return true;
		case VirtualKeyCode.SHIFT:
			if (virtualKeyCode_1 != VirtualKeyCode.RSHIFT)
			{
				return virtualKeyCode_1 == VirtualKeyCode.LSHIFT;
			}
			return true;
		default:
			return false;
		}
	}

	internal static bool UriLMd2nUfC(Keys keys_0)
	{
		return keys_0.IsEither(Keys.ControlKey, Keys.LControlKey, Keys.RControlKey, Keys.Control, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey, Keys.Menu, Keys.LMenu, Keys.RMenu, Keys.LWin, Keys.RWin);
	}

	static KeyboardHelper()
	{
		a9lLMoTUgQB = new Dictionary<VirtualKeyCode, string>
		{
			{
				VirtualKeyCode.LEFT,
				"←"
			},
			{
				VirtualKeyCode.RIGHT,
				"→"
			},
			{
				VirtualKeyCode.UP,
				"↑"
			},
			{
				VirtualKeyCode.DOWN,
				"↓"
			},
			{
				VirtualKeyCode.ESCAPE,
				"Esc"
			},
			{
				VirtualKeyCode.BACK,
				"Backspace(退格)"
			},
			{
				VirtualKeyCode.TAB,
				"Tab"
			},
			{
				VirtualKeyCode.RETURN,
				"Return(回车)"
			},
			{
				VirtualKeyCode.SHIFT,
				"Shift"
			},
			{
				VirtualKeyCode.CONTROL,
				"Ctrl"
			},
			{
				VirtualKeyCode.MENU,
				"Alt"
			},
			{
				VirtualKeyCode.PAUSE,
				"Pause"
			},
			{
				VirtualKeyCode.CAPITAL,
				"CapsLock"
			},
			{
				VirtualKeyCode.SPACE,
				"Space"
			},
			{
				VirtualKeyCode.PRIOR,
				"Page Up"
			},
			{
				VirtualKeyCode.NEXT,
				"Page Down"
			},
			{
				VirtualKeyCode.END,
				"End"
			},
			{
				VirtualKeyCode.HOME,
				"Home"
			},
			{
				VirtualKeyCode.SNAPSHOT,
				"Print Screen"
			},
			{
				VirtualKeyCode.INSERT,
				"Insert"
			},
			{
				VirtualKeyCode.DELETE,
				"Delete"
			},
			{
				VirtualKeyCode.NUMLOCK,
				"Num Lock"
			},
			{
				VirtualKeyCode.SCROLL,
				"Scroll Lock"
			},
			{
				VirtualKeyCode.APPS,
				"Apps(右键菜单)"
			},
			{
				VirtualKeyCode.CANCEL,
				"Break"
			},
			{
				VirtualKeyCode.LMENU,
				"LeftAlt"
			},
			{
				VirtualKeyCode.RMENU,
				"RightAlt"
			},
			{
				VirtualKeyCode.LCONTROL,
				"LeftCtrl"
			},
			{
				VirtualKeyCode.RCONTROL,
				"RightCtrl"
			},
			{
				VirtualKeyCode.LSHIFT,
				"LeftShift"
			},
			{
				VirtualKeyCode.RSHIFT,
				"RightShift"
			},
			{
				VirtualKeyCode.LWIN,
				"LeftWin"
			},
			{
				VirtualKeyCode.RWIN,
				"RightWin"
			},
			{
				VirtualKeyCode.OEM_1,
				";"
			},
			{
				VirtualKeyCode.OEM_PLUS,
				"="
			},
			{
				VirtualKeyCode.OEM_COMMA,
				","
			},
			{
				VirtualKeyCode.OEM_MINUS,
				"-"
			},
			{
				VirtualKeyCode.OEM_PERIOD,
				"."
			},
			{
				VirtualKeyCode.OEM_2,
				"/"
			},
			{
				VirtualKeyCode.OEM_3,
				"`"
			},
			{
				VirtualKeyCode.OEM_4,
				"["
			},
			{
				VirtualKeyCode.OEM_5,
				"\\"
			},
			{
				VirtualKeyCode.OEM_6,
				"]"
			},
			{
				VirtualKeyCode.OEM_7,
				"'"
			},
			{
				VirtualKeyCode.NUMPAD0,
				"Numpad 0"
			},
			{
				VirtualKeyCode.NUMPAD1,
				"Numpad 1"
			},
			{
				VirtualKeyCode.NUMPAD2,
				"Numpad 2"
			},
			{
				VirtualKeyCode.NUMPAD3,
				"Numpad 3"
			},
			{
				VirtualKeyCode.NUMPAD4,
				"Numpad 4"
			},
			{
				VirtualKeyCode.NUMPAD5,
				"Numpad 5"
			},
			{
				VirtualKeyCode.NUMPAD6,
				"Numpad 6"
			},
			{
				VirtualKeyCode.NUMPAD7,
				"Numpad 7"
			},
			{
				VirtualKeyCode.NUMPAD8,
				"Numpad 8"
			},
			{
				VirtualKeyCode.NUMPAD9,
				"Numpad 9"
			},
			{
				VirtualKeyCode.ADD,
				"Numpad +"
			},
			{
				VirtualKeyCode.SUBTRACT,
				"Numpad -"
			},
			{
				VirtualKeyCode.MULTIPLY,
				"Numpad *"
			},
			{
				VirtualKeyCode.DIVIDE,
				"Numpad /"
			},
			{
				VirtualKeyCode.DECIMAL,
				"Numpad ."
			},
			{
				VirtualKeyCode.SEPARATOR,
				"SEPARATOR(用途未知)"
			},
			{
				VirtualKeyCode.VOLUME_MUTE,
				"静音"
			},
			{
				VirtualKeyCode.VOLUME_DOWN,
				"音量-"
			},
			{
				VirtualKeyCode.VOLUME_UP,
				"音量+"
			},
			{
				VirtualKeyCode.MEDIA_NEXT_TRACK,
				"下一首"
			},
			{
				VirtualKeyCode.MEDIA_PREV_TRACK,
				"上一首"
			},
			{
				VirtualKeyCode.MEDIA_STOP,
				"停止"
			},
			{
				VirtualKeyCode.MEDIA_PLAY_PAUSE,
				"暂停/继续"
			},
			{
				VirtualKeyCode.LBUTTON,
				"鼠标左键"
			},
			{
				VirtualKeyCode.MBUTTON,
				"鼠标中键"
			},
			{
				VirtualKeyCode.RBUTTON,
				"鼠标右键"
			},
			{
				VirtualKeyCode.XBUTTON1,
				"鼠标X1键"
			},
			{
				VirtualKeyCode.XBUTTON2,
				"鼠标X2键"
			},
			{
				VirtualKeyCode.APP_SCROLL_UP,
				"向上滚动"
			},
			{
				VirtualKeyCode.APP_SCROLL_DOWN,
				"向下滚动"
			},
			{
				VirtualKeyCode.APP_SCROLL_LEFT,
				"向左滚动"
			},
			{
				VirtualKeyCode.APP_SCROLL_RIGHT,
				"向右滚动"
			},
			{
				VirtualKeyCode.APP_ANYKEY,
				"*任意键*"
			},
			{
				VirtualKeyCode.APP_V1,
				"*Quicker虚拟键V1*"
			},
			{
				VirtualKeyCode.APP_CAPS_LOCKED,
				"*CapsLock已锁定*"
			},
			{
				VirtualKeyCode.APP_SCROLL_LOCKED,
				"*ScrollLock已锁定*"
			},
			{
				VirtualKeyCode.APP_NUM_LOCKED,
				"*NumLock已锁定*"
			}
		};
		FDELMTJEICW = Enumerable.Range(0, 256).Select(KeyInterop.KeyFromVirtualKey).Where(_003C_003Ec.b6j2grRpTHg.Ljg2gKBvtyu)
			.Distinct()
			.Select(_003C_003Ec.b6j2grRpTHg.tpe2gxKHDaG)
			.ToArray();
	}

	internal static bool AGwSDTFRHcGNZXYKvljM()
	{
		return GEYxPOFRhJD5T2veflyj == null;
	}
}
