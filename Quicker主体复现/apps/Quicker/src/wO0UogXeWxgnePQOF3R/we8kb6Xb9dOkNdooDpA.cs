using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using log4net;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using SWBMfZYGyc6L9yHIvKQ;

namespace wO0UogXeWxgnePQOF3R;

internal class we8kb6Xb9dOkNdooDpA
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec rpgv5tiMa8R;

		public static Func<TextCommand, bool> chNv5guwtIC;

		public static Func<TextCommand, bool> tJcv5LXne1K;

		internal static _003C_003Ec jItIpMWFFkjQ2d0BU3l2;

		static _003C_003Ec()
		{
			rpgv5tiMa8R = new _003C_003Ec();
		}

		internal bool dl8v4zaVaWL(TextCommand x)
		{
			return AppState.CurrentProcessName.IsProcessInBinding(x.BindingProcessName, false);
		}

		internal bool Goxv5wQTbr5(TextCommand x)
		{
			return string.IsNullOrEmpty(x.BindingProcessName);
		}

		internal static void EqPItrWFy9IfY74Jjb9m()
		{
		}

		internal static bool JGwH2TWFclwwiMSf6uOc()
		{
			return jItIpMWFFkjQ2d0BU3l2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public TextCommand gtwv52r6SH8;

		public we8kb6Xb9dOkNdooDpA Kakv5uMDU3j;

		public TextCommand Enov5NOka8Y;

		public string AJ2v5JvlFAR;

		public int xvJv507i7SU;

		private static _003C_003Ec__DisplayClass19_0 F3pleeWFpgWSmLTwhqs4;

		internal bool opWv5v0MCal(TextCommand x)
		{
			if (x.CmdText == gtwv52r6SH8.CmdText && x.UseRegex == gtwv52r6SH8.UseRegex)
			{
				return x.TriggerKey == gtwv52r6SH8.TriggerKey;
			}
			return false;
		}

		internal void fA3v5SUuYfY()
		{
			QuickActionRunner.ExecuteTextCommand(Kakv5uMDU3j, Enov5NOka8Y, AJ2v5JvlFAR, Kakv5uMDU3j.Oc2txqfLeTK.CpItmVISR7P(), Kakv5uMDU3j.iXGtxcr10hf, Kakv5uMDU3j.sk8txZPCGEE, false, false, xvJv507i7SU);
		}

		static _003C_003Ec__DisplayClass19_0()
		{
		}

		internal static bool JaUyVuWFX3y1G3DiAPlB()
		{
			return F3pleeWFpgWSmLTwhqs4 == null;
		}

		internal static void YoC4ScWFnQqiYsPror7j()
		{
		}
	}

	private readonly DataService Oc2txqfLeTK;

	private readonly ITinyMessengerHub iXGtxcr10hf;

	private readonly ActiveWindowHook xf5txVgTmHr;

	private readonly AppServer sk8txZPCGEE;

	private static readonly ILog XZbtx91p6Lc;

	private char[] mYPtxhEdHMn = new char[100];

	private int WjotxewddSa;

	private long hK8txYbSFBL = AppHelper.fLiLTj0x4QY();

	private static we8kb6Xb9dOkNdooDpA yEkMEaQNVEgrAAhihM0T;

	public we8kb6Xb9dOkNdooDpA(DataService dataService_1, ITinyMessengerHub itinyMessengerHub_1, ActiveWindowHook activeWindowHook_1, AppServer appServer_1)
	{
		Oc2txqfLeTK = dataService_1;
		iXGtxcr10hf = itinyMessengerHub_1;
		xf5txVgTmHr = activeWindowHook_1;
		sk8txZPCGEE = appServer_1;
	}

	internal void VDNtxJDE4av(KeyEventArgs keyEventArgs_0)
	{
		if (AppHelper.fLiLTj0x4QY() - hK8txYbSFBL > 3000L)
		{
			WjotxewddSa = 0;
		}
		hK8txYbSFBL = AppHelper.fLiLTj0x4QY();
		if (keyEventArgs_0.KeyCode == Keys.Back)
		{
			if (!keyEventArgs_0.Control && !keyEventArgs_0.Alt)
			{
				if (WjotxewddSa > 0)
				{
					WjotxewddSa--;
				}
			}
			else
			{
				jkntx0ksqUV();
			}
		}
		else
		{
			if (keyEventArgs_0.Alt || keyEventArgs_0.Control)
			{
				return;
			}
			try
			{
				if (HDotxa8w1jC(keyEventArgs_0))
				{
					jkntx0ksqUV();
					if (yEkMEaQNVEgrAAhihM0T == null)
					{
						switch (0)
						{
						}
					}
					keyEventArgs_0.Handled = true;
					return;
				}
				if (keyEventArgs_0.KeyCode == Keys.Return)
				{
					jkntx0ksqUV();
					return;
				}
				char? c = R4DtxRXoo84(keyEventArgs_0);
				if (c.HasValue)
				{
					mYPtxhEdHMn[WjotxewddSa++] = c.Value;
					eVmtxPs8Pmw();
				}
				else if (yUrtxC0Glau(keyEventArgs_0.KeyCode))
				{
					jkntx0ksqUV();
				}
			}
			catch (Exception ex)
			{
				XZbtx91p6Lc.Warn("文本指令匹配出错：" + ex.Message);
				AppHelper.ShowWarning("文本指令匹配出错：" + ex.Message);
			}
		}
	}

	internal void jkntx0ksqUV()
	{
		WjotxewddSa = 0;
	}

	private bool yUrtxC0Glau(Keys keys_0)
	{
		if (keys_0 != Keys.Capital && (uint)(keys_0 - 160) > 1u)
		{
			return true;
		}
		return false;
	}

	private void eVmtxPs8Pmw()
	{
		if (WjotxewddSa > 97)
		{
			for (int i = 0; i < WjotxewddSa - 1; i++)
			{
				mYPtxhEdHMn[i] = mYPtxhEdHMn[i + 1];
			}
			WjotxewddSa--;
		}
	}

	private static bool YwCtxEaTvjY(char char_1, char char_2, bool bool_0)
	{
		if (!bool_0)
		{
			return char_1 == char_2;
		}
		return char.ToUpper(char_1) == char.ToUpper(char_2);
	}

	private static bool ShxtxyrD0Bc(int int_0, int int_1)
	{
		if (int_0 == int_1)
		{
			return true;
		}
		switch (int_1)
		{
		case 18:
			if (int_0 != 164)
			{
				return int_0 == 165;
			}
			return true;
		case 17:
			if (int_0 != 162)
			{
				return int_0 == 163;
			}
			return true;
		case 16:
			if (int_0 != 160)
			{
				return int_0 == 161;
			}
			return true;
		default:
			return false;
		}
	}

	private bool fMUtx8mHJeD(TextCommand textCommand_0, int int_0, char? nullable_0)
	{
		bool flag = nullable_0.HasValue && Oc2txqfLeTK.CpItmVISR7P().TextCommandDelimiterChars.Contains(nullable_0.Value);
		bool flag2 = Oc2txqfLeTK.CpItmVISR7P().TextCommandTriggerKey.HasValue && ShxtxyrD0Bc(int_0, Oc2txqfLeTK.CpItmVISR7P().TextCommandTriggerKey.Value);
		if (textCommand_0.TriggerKey.HasValue)
		{
			if (textCommand_0.TriggerKey.Value == 0)
			{
				if (nullable_0.HasValue)
				{
					return YwCtxEaTvjY(textCommand_0.CmdText.LastOrDefault(), nullable_0.Value, textCommand_0.IgnoreCase);
				}
				return false;
			}
			return ShxtxyrD0Bc(int_0, textCommand_0.TriggerKey.Value);
		}
		return flag || flag2;
	}

	private bool HDotxa8w1jC(KeyEventArgs keyEventArgs_0)
	{
		int keyValue = keyEventArgs_0.KeyValue;
		char? nullable_ = R4DtxRXoo84(keyEventArgs_0);
		if (!Oc2txqfLeTK.pI6tmwhv9XL().HasData())
		{
			return false;
		}
		int num2 = default(int);
		bool isDirectInputTrigger = default(bool);
		bool flag = default(bool);
		string string_ = default(string);
		int i = default(int);
		foreach (TextCommand item in Oc2txqfLeTK.pI6tmwhv9XL())
		{
			int num = 3;
			if (!qJxmdiQNQK2lyAtv6WNC())
			{
				goto IL_010c;
			}
			goto IL_0110;
			IL_010c:
			num = num2;
			goto IL_0110;
			IL_0110:
			while (true)
			{
				int int_;
				switch (num)
				{
				case 3:
					if (!AppState.CurrentProcessName.IsProcessInBinding(item.BindingProcessName, true))
					{
						break;
					}
					num = 0;
					if (qJxmdiQNQK2lyAtv6WNC())
					{
						continue;
					}
					goto default;
				default:
				{
					if (!fMUtx8mHJeD(item, keyValue, nullable_))
					{
						break;
					}
					isDirectInputTrigger = item.IsDirectInputTrigger;
					flag = false;
					string_ = item.CmdText;
					int_ = 0;
					if (isDirectInputTrigger || !item.UseRegex)
					{
						goto case 1;
					}
					string text = new string(mYPtxhEdHMn, 0, WjotxewddSa);
					try
					{
						string text2 = item.CmdText;
						if (text2.Last() != '$')
						{
							text2 += "$";
						}
						Match match = Regex.Match(text, text2, item.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None);
						if (match.Success)
						{
							flag = true;
							string_ = match.Value;
							int_ = match.Length;
						}
					}
					catch (Exception exception)
					{
						XZbtx91p6Lc.Warn("文本指令正则匹配出错：input=" + text + ", exp=" + item.CmdText + ", err=" + exception.GetMessageWithInner());
					}
					goto IL_02bf;
				}
				case 1:
				{
					if (isDirectInputTrigger)
					{
						if (WjotxewddSa < item.CmdText.Length - 1)
						{
							break;
						}
					}
					else if (WjotxewddSa < item.CmdText.Length)
					{
						break;
					}
					flag = true;
					if (!isDirectInputTrigger)
					{
						goto IL_00fc;
					}
					for (int j = 0; j < item.CmdText.Length - 1; j++)
					{
						if (!YwCtxEaTvjY(item.CmdText[item.CmdText.Length - 2 - j], mYPtxhEdHMn[WjotxewddSa - 1 - j], item.IgnoreCase))
						{
							flag = false;
							break;
						}
					}
					int_ = item.CmdText.Length - 1;
					goto IL_02bf;
				}
				case 2:
					{
						for (; i < item.CmdText.Length; i++)
						{
							if (!YwCtxEaTvjY(item.CmdText[item.CmdText.Length - 1 - i], mYPtxhEdHMn[WjotxewddSa - 1 - i], item.IgnoreCase))
							{
								flag = false;
								break;
							}
						}
						int_ = item.CmdText.Length;
						goto IL_02bf;
					}
					IL_02bf:
					if (flag)
					{
						return uNxtx7FpFP4(item, string_, int_);
					}
					break;
				}
				break;
				IL_00fc:
				i = 0;
				num = 2;
				if (qJxmdiQNQK2lyAtv6WNC())
				{
					continue;
				}
				goto IL_010c;
			}
		}
		return false;
	}

	private bool uNxtx7FpFP4(TextCommand textCommand_0, string string_0, int int_0)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.gtwv52r6SH8 = textCommand_0;
		int num = 0;
		if (yEkMEaQNVEgrAAhihM0T != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			_003C_003Ec__DisplayClass19_.Kakv5uMDU3j = this;
			_003C_003Ec__DisplayClass19_.AJ2v5JvlFAR = string_0;
			_003C_003Ec__DisplayClass19_.xvJv507i7SU = int_0;
			List<TextCommand> source = Oc2txqfLeTK.pI6tmwhv9XL().Where(_003C_003Ec__DisplayClass19_.opWv5v0MCal).ToList();
			_003C_003Ec__DisplayClass19_.Enov5NOka8Y = source.FirstOrDefault(_003C_003Ec.chNv5guwtIC ?? (_003C_003Ec.chNv5guwtIC = _003C_003Ec.rpgv5tiMa8R.dl8v4zaVaWL));
			if (_003C_003Ec__DisplayClass19_.Enov5NOka8Y == null)
			{
				_003C_003Ec__DisplayClass19_.Enov5NOka8Y = source.FirstOrDefault(_003C_003Ec.tJcv5LXne1K ?? (_003C_003Ec.tJcv5LXne1K = _003C_003Ec.rpgv5tiMa8R.Goxv5wQTbr5));
			}
			if (_003C_003Ec__DisplayClass19_.Enov5NOka8Y != null)
			{
				GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(_003C_003Ec__DisplayClass19_.fA3v5SUuYfY, "text_command");
				return true;
			}
			return false;
		}
		}
	}

	private char? R4DtxRXoo84(KeyEventArgs keyEventArgs_0)
	{
		bool capsLock = Console.CapsLock;
		bool flag = keyEventArgs_0.Shift || JrJWiKYIEBcPm8FFZOl.I7rLDNZhD3f();
		bool flag2 = (capsLock && !flag) || (!capsLock && flag);
		return keyEventArgs_0.KeyCode switch
		{
			Keys.OemOpenBrackets => flag ? '{' : '[', 
			Keys.OemPipe => flag ? '|' : '\\', 
			Keys.OemCloseBrackets => flag ? '}' : ']', 
			Keys.OemQuotes => flag ? '"' : '\'', 
			Keys.OemSemicolon => flag ? ':' : ';', 
			Keys.Oemplus => flag ? '+' : '=', 
			Keys.Oemcomma => flag ? '<' : ',', 
			Keys.OemMinus => flag ? '_' : '-', 
			Keys.OemPeriod => flag ? '>' : '.', 
			Keys.OemQuestion => flag ? '?' : '/', 
			Keys.Oemtilde => flag ? '~' : '`', 
			Keys.Tab => '\t', 
			Keys.Return => '\n', 
			Keys.Space => ' ', 
			Keys.D0 => flag ? ')' : '0', 
			Keys.D1 => flag ? '!' : '1', 
			Keys.D2 => flag ? '@' : '2', 
			Keys.D3 => flag ? '#' : '3', 
			Keys.D4 => flag ? '$' : '4', 
			Keys.D5 => flag ? '%' : '5', 
			Keys.D6 => flag ? '^' : '6', 
			Keys.D7 => flag ? '&' : '7', 
			Keys.D8 => flag ? '*' : '8', 
			Keys.D9 => flag ? '(' : '9', 
			Keys.A => flag2 ? 'A' : 'a', 
			Keys.B => flag2 ? 'B' : 'b', 
			Keys.C => flag2 ? 'C' : 'c', 
			Keys.D => flag2 ? 'D' : 'd', 
			Keys.E => flag2 ? 'E' : 'e', 
			Keys.F => flag2 ? 'F' : 'f', 
			Keys.G => flag2 ? 'G' : 'g', 
			Keys.H => flag2 ? 'H' : 'h', 
			Keys.I => flag2 ? 'I' : 'i', 
			Keys.J => flag2 ? 'J' : 'j', 
			Keys.K => flag2 ? 'K' : 'k', 
			Keys.L => flag2 ? 'L' : 'l', 
			Keys.M => flag2 ? 'M' : 'm', 
			Keys.N => flag2 ? 'N' : 'n', 
			Keys.O => flag2 ? 'O' : 'o', 
			Keys.P => flag2 ? 'P' : 'p', 
			Keys.Q => flag2 ? 'Q' : 'q', 
			Keys.R => flag2 ? 'R' : 'r', 
			Keys.S => flag2 ? 'S' : 's', 
			Keys.T => flag2 ? 'T' : 't', 
			Keys.U => flag2 ? 'U' : 'u', 
			Keys.V => flag2 ? 'V' : 'v', 
			Keys.W => flag2 ? 'W' : 'w', 
			Keys.X => flag2 ? 'X' : 'x', 
			Keys.Y => flag2 ? 'Y' : 'y', 
			Keys.Z => flag2 ? 'Z' : 'z', 
			Keys.NumPad0 => '0', 
			Keys.NumPad1 => '1', 
			Keys.NumPad2 => '2', 
			Keys.NumPad3 => '3', 
			Keys.NumPad4 => '4', 
			Keys.NumPad5 => '5', 
			Keys.NumPad6 => '6', 
			Keys.NumPad7 => '7', 
			Keys.NumPad8 => '8', 
			Keys.NumPad9 => '9', 
			Keys.Multiply => '*', 
			Keys.Add => '+', 
			Keys.Subtract => '-', 
			Keys.Decimal => '.', 
			Keys.Divide => '/', 
			_ => null, 
		};
	}

	static we8kb6Xb9dOkNdooDpA()
	{
		XZbtx91p6Lc = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool qJxmdiQNQK2lyAtv6WNC()
	{
		return yEkMEaQNVEgrAAhihM0T == null;
	}
}
