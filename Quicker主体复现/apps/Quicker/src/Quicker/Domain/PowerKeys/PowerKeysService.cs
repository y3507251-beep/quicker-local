using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using aWEhsXjxWyCRXOavmGf;
using log4net;
using Quicker.Common.QuickActions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Hooks;
using Quicker.Utilities.Win32;
using Quicker.View;
using sBtxL6X8ZmkfRQWgUC5;
using SWBMfZYGyc6L9yHIvKQ;
using t8SGKhhgLWTgeqjGcrq;
using WindowsInput;
using WindowsInput.Native;
using YJ7Fh9jVM9v3yLTs0Cv;

namespace Quicker.Domain.PowerKeys;

public class PowerKeysService
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec JJ6vKIoIZYg;

		public static Func<PowerKeyActionItem, int?> QfHvKWBsFWn;

		public static Func<PowerKeyActionItem, int?> yedvKkjdZ2G;

		public static Func<PowerKeyActionItem, bool> qeIvKGDsL5W;

		public static Func<PowerKeyActionItem, bool> YpHvKs8ZFum;

		public static Func<PowerKeyActionItem, bool> BQQvKHl5NGT;

		public static Func<PowerKeyActionItem, bool> kjUvK1Eixm3;

		public static Func<PowerKeyActionItem, bool> KkWvKbqCiLy;

		public static Func<PowerKeyActionItem, bool> vAgvK6NUqGA;

		public static Func<PowerKeyActionItem, int?> w2nvKXYdegt;

		public static Func<PowerKeyActionItem, string> SWHvKmNcSII;

		public static Func<IGrouping<string, PowerKeyActionItem>, string> g3ZvKK3Cppu;

		public static Func<PowerKeyActionItem, int?> xjNvKxnqBi8;

		internal static _003C_003Ec qAucwpcSG0M3x3nUb989;

		static _003C_003Ec()
		{
			JJ6vKIoIZYg = new _003C_003Ec();
		}

		internal int? l0VvK8HjuUQ(PowerKeyActionItem x)
		{
			return x.AdornKey;
		}

		internal int? bxFvKaQMeEY(PowerKeyActionItem x)
		{
			return x.SecondaryKey;
		}

		internal bool TmZvK7PhHvF(PowerKeyActionItem x)
		{
			return AppState.CurrentProcessName.IsProcessInBinding(x.BindingProcessName, false);
		}

		internal bool XKAvKRR47Vt(PowerKeyActionItem x)
		{
			return string.IsNullOrEmpty(x.BindingProcessName);
		}

		internal bool N5HvKqlOjSC(PowerKeyActionItem x)
		{
			if (!x.IsDisabled)
			{
				return !x.SecondaryKey.HasValue;
			}
			return false;
		}

		internal bool Ju7vKcfWosk(PowerKeyActionItem x)
		{
			return AppState.CurrentProcessName.IsProcessInBinding(x.BindingProcessName, false);
		}

		internal bool XNFvKVb2Vhq(PowerKeyActionItem x)
		{
			return string.IsNullOrEmpty(x.BindingProcessName);
		}

		internal bool uq7vKZ1BlbR(PowerKeyActionItem x)
		{
			if (!x.IsDisabled)
			{
				if (!AppState.CurrentProcessName.IsProcessInBinding(x.BindingProcessName, false))
				{
					return string.IsNullOrEmpty(x.BindingProcessName);
				}
				return true;
			}
			return false;
		}

		internal int? yXDvK915Lwq(PowerKeyActionItem x)
		{
			return x.SecondaryKey;
		}

		internal string JQ5vKhbf7qr(PowerKeyActionItem x)
		{
			return x.Group;
		}

		internal string zNcvKeAfYfP(IGrouping<string, PowerKeyActionItem> x)
		{
			return x.Key;
		}

		internal int? x21vKY51Gw1(PowerKeyActionItem x)
		{
			return x.AdornKey;
		}

		internal static void iZxVGFcSKgJLqAV5TuFL()
		{
		}

		internal static bool X7dWsKcS0A11LVt80whh()
		{
			return qAucwpcSG0M3x3nUb989 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public int n2dvKpnZfN5;

		private static _003C_003Ec__DisplayClass27_0 T2qLZOcSOLbHDRI2Fgie;

		internal bool GmkvKr7PSpN(PowerKeyActionItem x)
		{
			if (!x.IsDisabled)
			{
				if (x.SecondaryKey == n2dvKpnZfN5 && !x.AdornKey.HasValue)
				{
					return true;
				}
				return x.AdornKey == n2dvKpnZfN5;
			}
			return false;
		}

		internal static bool oBjLIScSJCIxwjY0mYJ4()
		{
			return T2qLZOcSOLbHDRI2Fgie == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_0
	{
		public int? XnZvKQMHN0t;

		public PowerKeysService kwRvKjTitNG;

		internal static _003C_003Ec__DisplayClass31_0 vAmrrFcSamyTIiyvM7Fo;

		internal bool u8svKBAYSf0(PowerKeyActionItem x)
		{
			if (!x.IsDisabled && (x.SecondaryKey == XnZvKQMHN0t || x.SecondaryKey == 261))
			{
				if (x.AdornKey.HasValue)
				{
					return kwRvKjTitNG.Wm7tZ1fQFTc.IsKeyDown(x.AdornKey.Value);
				}
				return true;
			}
			return false;
		}

		internal static bool mYND0NcSrBeqTYkBRmHK()
		{
			return vAmrrFcSamyTIiyvM7Fo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public PowerKeysService OukvK4rC9RE;

		public int HrBvK5awoL3;

		private static _003C_003Ec__DisplayClass35_0 f0udt7cS99STeuEbY0Sd;

		internal void Q68vKnuaXI3()
		{
			if (OukvK4rC9RE.BUYtZGRSU4S != null)
			{
				OukvK4rC9RE.BUYtZGRSU4S.Close();
				OukvK4rC9RE.BUYtZGRSU4S = null;
			}
			new StringBuilder(300).AppendLine(KeyboardHelper.GetKeyName((VirtualKeyCode)HrBvK5awoL3) + " + ");
			IOrderedEnumerable<PowerKeyActionItem> source = OukvK4rC9RE.RxKtZqABPpy()[HrBvK5awoL3].KeyActions.Where(_003C_003Ec.vAgvK6NUqGA ?? (_003C_003Ec.vAgvK6NUqGA = _003C_003Ec.JJ6vKIoIZYg.uq7vKZ1BlbR)).OrderBy(_003C_003Ec.w2nvKXYdegt ?? (_003C_003Ec.w2nvKXYdegt = _003C_003Ec.JJ6vKIoIZYg.yXDvK915Lwq));
			string title = KeyboardHelper.GetKeyName((VirtualKeyCode)HrBvK5awoL3) + " + ";
			IList<string> list = new List<string>();
			foreach (IGrouping<string, PowerKeyActionItem> item in source.GroupBy(_003C_003Ec.SWHvKmNcSII ?? (_003C_003Ec.SWHvKmNcSII = _003C_003Ec.JJ6vKIoIZYg.JQ5vKhbf7qr)).OrderBy(_003C_003Ec.g3ZvKK3Cppu ?? (_003C_003Ec.g3ZvKK3Cppu = _003C_003Ec.JJ6vKIoIZYg.zNcvKeAfYfP)))
			{
				string key = item.Key;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("分组：" + (string.IsNullOrWhiteSpace(item.Key) ? "*未分组*" : item.Key));
				foreach (PowerKeyActionItem item2 in item.OrderBy(_003C_003Ec.xjNvKxnqBi8 ?? (_003C_003Ec.xjNvKxnqBi8 = _003C_003Ec.JJ6vKIoIZYg.x21vKY51Gw1)))
				{
					if (!item2.SecondaryKey.HasValue)
					{
						stringBuilder.AppendLine(" : " + item2.Title);
						continue;
					}
					stringBuilder.Append("  ");
					if (item2.AdornKey.HasValue)
					{
						stringBuilder.Append(KeyboardHelper.GetKeyName((VirtualKeyCode)item2.AdornKey.Value) + " + ");
					}
					stringBuilder.Append(KeyboardHelper.GetKeyName((VirtualKeyCode)item2.SecondaryKey.Value) + ": ");
					if (!string.IsNullOrWhiteSpace(item2.Title))
					{
						if (f0udt7cS99STeuEbY0Sd == null)
						{
							switch (0)
							{
							}
						}
						stringBuilder.Append(item2.Title);
					}
					else
					{
						stringBuilder.Append(item2.GetSummary());
					}
					stringBuilder.AppendLine();
				}
				list.Add(stringBuilder.ToString());
			}
			if (!OukvK4rC9RE.CLmtZsYUuc7)
			{
				OukvK4rC9RE.BUYtZGRSU4S = new PowerKeyHintWindow(title, list, ShowWindowLocation.CenterScreen, true);
				OukvK4rC9RE.BUYtZGRSU4S.Show();
				int num = 0;
				if (f0udt7cS99STeuEbY0Sd != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				OukvK4rC9RE.CLmtZsYUuc7 = true;
			}
		}

		internal static bool fgTHVlcSLSilBs6MWUgu()
		{
			return f0udt7cS99STeuEbY0Sd == null;
		}
	}

	private static readonly ILog O4MtZVUyyNA;

	private readonly DataService iFOtZZ4guf3;

	private readonly ITinyMessengerHub vEWtZ9iBR1H;

	private readonly AppServer emitZhfdFBr;

	private int? nLVtZeho1NE;

	private PowerKey WgrtZYHBqgh;

	private long njntZIhULBq;

	private long H8btZWpoAG1;

	private System.Threading.Timer AHitZkBVT3X;

	private PowerKeyHintWindow BUYtZGRSU4S;

	private bool CLmtZsYUuc7;

	private int? qTJtZHxA0BK;

	private readonly KeyboardState Wm7tZ1fQFTc = new KeyboardState();

	private bool DpTtZbLGS4E = true;

	internal static PowerKeysService E5AoBUQK8yZlv4jmUgPE;

	[SpecialName]
	private IDictionary<int, PowerKey> RxKtZqABPpy()
	{
		return iFOtZZ4guf3.DyhtXJ0GcZv();
	}

	public PowerKeysService(DataService dataService, ITinyMessengerHub hub, AppServer appServer)
	{
		iFOtZZ4guf3 = dataService;
		vEWtZ9iBR1H = hub;
		emitZhfdFBr = appServer;
	}

	public void OnMouseUsed()
	{
		if (nLVtZeho1NE.HasValue)
		{
			CLmtZsYUuc7 = true;
		}
	}

	public bool IsKeyCaptured(int key)
	{
		if (nLVtZeho1NE.HasValue)
		{
			return nLVtZeho1NE.Value == key;
		}
		return false;
	}

	public bool IsKeyCaptured()
	{
		return nLVtZeho1NE.HasValue;
	}

	private MouseButtons t6BtZwqj6Lc(int int_0)
	{
		return int_0 switch
		{
			1 => MouseButtons.Left, 
			2 => MouseButtons.Right, 
			4 => MouseButtons.Middle, 
			5 => MouseButtons.XButton1, 
			6 => MouseButtons.XButton2, 
			_ => MouseButtons.None, 
		};
	}

	private bool qbStZtw5GtQ(int int_0)
	{
		if (int_0 > 6)
		{
			return false;
		}
		if (AppState.v5FtaQ4hQfg().NIlvgXuD0A9(t6BtZwqj6Lc(int_0)))
		{
			return true;
		}
		return false;
	}

	private bool H1VtZgsXC1P()
	{
		return AppState.v5FtaQ4hQfg().zNCvg68stTv();
	}

	private bool DkXtZLE6OyJ()
	{
		if (!nLVtZeho1NE.HasValue)
		{
			return H1VtZgsXC1P();
		}
		return true;
	}

	private int PHutZv81GgY()
	{
		MouseButtons? mouseButtons = AppState.v5FtaQ4hQfg().OnYvgKYBC7F();
		if (!nLVtZeho1NE.HasValue)
		{
			if (!mouseButtons.HasValue)
			{
				return 0;
			}
			return KeyboardHelper.GetMouseButtonKeyCode(mouseButtons.Value);
		}
		return nLVtZeho1NE.Value;
	}

	private bool kNNtZSrwrnF(System.Windows.Forms.KeyEventArgs keyEventArgs_0)
	{
		MouseButtons? mouseButtons = AppState.v5FtaQ4hQfg().OnYvgKYBC7F();
		if (mouseButtons.HasValue && MIytZ0yNjTu(KeyboardHelper.GetMouseButtonKeyCode(mouseButtons.Value), keyEventArgs_0.KeyValue))
		{
			AppState.v5FtaQ4hQfg().kNjvgQBvAoG();
			return true;
		}
		return false;
	}

	public bool ProcessKeyDown(HookKeyEventArgs e)
	{
		fSXtZ8HgFLY("KeyDown " + e.KeyCode.ToString() + $" 主：{(VirtualKeyCode?)nLVtZeho1NE}  临时：{(VirtualKeyCode?)qTJtZHxA0BK}");
		if (!e.IsRepeating)
		{
			mX7qQhjtCi2Je746unO.fEutGCoo9fb(e.KeyCode);
		}
		int num = default(int);
		int num4;
		if (RxKtZqABPpy() != null && RxKtZqABPpy().Count != 0)
		{
			if (!nLVtZeho1NE.HasValue && H1VtZgsXC1P())
			{
				goto IL_08ae;
			}
			if (nLVtZeho1NE.HasValue)
			{
				fSXtZ8HgFLY($"Holding Key:{(VirtualKeyCode?)nLVtZeho1NE}");
				if (nLVtZeho1NE == e.KeyValue)
				{
					fSXtZ8HgFLY("重复的控制键");
					return true;
				}
				if (qTJtZHxA0BK.HasValue)
				{
					fSXtZ8HgFLY("已捕获secondary:" + (VirtualKeyCode)qTJtZHxA0BK.Value/*cast due to .constrained prefix*/);
					Wm7tZ1fQFTc.KeyDown(qTJtZHxA0BK.Value);
					if (!MIytZ0yNjTu(nLVtZeho1NE.Value, e.KeyValue))
					{
						fSXtZ8HgFLY("第三键未设置动作。");
						Wm7tZ1fQFTc.KeyDown(e.KeyValue);
					}
					else
					{
						fSXtZ8HgFLY("触发动作。");
						qTJtZHxA0BK = null;
					}
					goto IL_08aa;
				}
				fSXtZ8HgFLY("_tempKeyAfterPrimary.HasValue 为 False");
				CLmtZsYUuc7 = true;
				iVTtZyMa7EI();
				if (AppHelper.fLiLTj0x4QY() - njntZIhULBq < iFOtZZ4guf3.CpItmVISR7P().PowerKeys_ContinuousInputCheckTime)
				{
					PowerKey wgrtZYHBqgh = WgrtZYHBqgh;
					if (wgrtZYHBqgh == null)
					{
						num = 4;
					}
					else if (wgrtZYHBqgh.KeepOriginKeyFunc)
					{
						if (dsLtZuHc4vA(nLVtZeho1NE.Value, (int)e.KeyCode))
						{
							fSXtZ8HgFLY("捕获第二个按键:" + e.KeyCode);
							qTJtZHxA0BK = e.KeyValue;
							return true;
						}
						fSXtZ8HgFLY("第二个按键未触发动作:" + e.KeyCode);
						PowerKey wgrtZYHBqgh2 = WgrtZYHBqgh;
						if (wgrtZYHBqgh2 != null && wgrtZYHBqgh2.KeepOriginKeyFunc)
						{
							fSXtZ8HgFLY("撤销拦截控制键:" + e.KeyCode);
							if (nLVtZeho1NE.HasValue)
							{
								goto IL_0854;
							}
							goto IL_0895;
						}
						fSXtZ8HgFLY("拦截按键:" + e.KeyCode);
						return true;
					}
				}
				goto IL_0506;
			}
			if (iFOtZZ4guf3.CpItmVISR7P().PowerKeys_EnableBlackList && BlackListMgr.IsCurrentAppInBlackListOrDisabledByFullScreen())
			{
				fSXtZ8HgFLY($"黑名单应用，不启用扩展热键。{AppState.CurrentExeName} win:{NativeMethods.GetForegroundWindow()}");
				return false;
			}
			if (KeyboardHelper.IsAnyModifierKeyDown())
			{
				fSXtZ8HgFLY("PowerKey:有其他键处于按下状态");
				int num3 = default(int);
				bool flag = default(bool);
				foreach (KeyValuePair<int, PowerKey> item in RxKtZqABPpy())
				{
					int num2 = 1;
					if (E5AoBUQK8yZlv4jmUgPE != null)
					{
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (!item.Value.IsEnabled)
							{
								break;
							}
							num2 = 0;
							if (E5AoBUQK8yZlv4jmUgPE != null)
							{
								continue;
							}
							goto default;
						default:
							if (item.Key != e.KeyValue)
							{
								break;
							}
							if (iFOtZZ4guf3.CpItmVISR7P().PowerKeys_AutoResetKeyboardState && AppHelper.fLiLTj0x4QY() - H8btZWpoAG1 > 2000L && !umotZ2583iZ() && KeyboardHelper.IsAnyKeyDown())
							{
								flag = false;
								Keys[] array = (Keys[])Enum.GetValues(typeof(global::System.Windows.Forms.Keys));
								foreach (Keys keys in array)
								{
									if (!keys.IsEither(Keys.Capital, Keys.Capital, Keys.NumLock, Keys.LControlKey, Keys.RControlKey, Keys.ControlKey, Keys.LMenu, Keys.RMenu, Keys.Menu, Keys.LShiftKey, Keys.RShiftKey, Keys.ShiftKey, Keys.LWin, Keys.RWin) && KeyboardHelper.IsKeyDown((VirtualKeyCode)keys))
									{
										fSXtZ8HgFLY($"自动抬起按键：{keys}");
										try
										{
											InputSimulator.Instance.Keyboard.KeyUp((VirtualKeyCode)keys);
										}
										catch (Exception ex)
										{
											O4MtZVUyyNA.Warn(ex.Message, ex);
											AppHelper.ShowWarning(ex.Message);
										}
										flag = true;
									}
								}
								num3 = 2;
								goto case 2;
							}
							goto IL_0418;
						case 2:
							{
								if (flag)
								{
									h6OtZJxrDfq(e.KeyValue, item.Value);
									return true;
								}
								goto IL_0418;
							}
							IL_0418:
							if (!item.Value.KeepOriginKeyFunc && !KeyboardHelper.IsKeyDown(VirtualKeyCode.LCONTROL) && !KeyboardHelper.IsKeyDown(VirtualKeyCode.LSHIFT) && !KeyboardHelper.IsKeyDown(VirtualKeyCode.LMENU))
							{
								fSXtZ8HgFLY("检测到误触控制键：" + e.KeyCode);
								h6OtZJxrDfq(e.KeyValue, item.Value);
								return true;
							}
							break;
						}
						break;
					}
				}
				if (r6DtZNbuKcF(e))
				{
					fSXtZ8HgFLY("成功触发左键辅助。返回");
					return true;
				}
				if (!e.IsFromQuicker)
				{
					uhcbDejgDZ3vvobZ0Nn.NQZtWFXCKDx(e);
					num4 = 3;
					if (E5AoBUQK8yZlv4jmUgPE == null)
					{
						goto IL_06b1;
					}
				}
				goto IL_08c1;
			}
			if (r6DtZNbuKcF(e))
			{
				fSXtZ8HgFLY("成功触发左键辅助。返回");
				return true;
			}
			foreach (KeyValuePair<int, PowerKey> item2 in RxKtZqABPpy())
			{
				if (E5AoBUQK8yZlv4jmUgPE == null)
				{
					switch (1)
					{
					case 1:
						break;
					default:
						goto IL_0948;
					}
				}
				if (!item2.Value.IsEnabled || item2.Key != e.KeyValue || BlackListHelper.IsProcessInBlackList(AppState.CurrentProcessName, item2.Value.BlackList))
				{
					continue;
				}
				goto IL_0948;
				IL_0948:
				if (!item2.Value.KeepOriginKeyFunc || H8btZWpoAG1 + iFOtZZ4guf3.CpItmVISR7P().PowerKeys_DelayBeforeCtrlKey <= AppHelper.fLiLTj0x4QY())
				{
					if (!AppHelper.IsLeftBtnDown() || !e.KeyCode.IsAny(Keys.LShiftKey, Keys.LControlKey, Keys.RShiftKey, Keys.RControlKey))
					{
						h6OtZJxrDfq(e.KeyValue, item2.Value);
						fSXtZ8HgFLY($"PowerKey:引导键{e.KeyCode}按下了");
						return true;
					}
					continue;
				}
				H8btZWpoAG1 = AppHelper.fLiLTj0x4QY();
				fSXtZ8HgFLY("PowerKey:距离上次keydown时间太短，当作普通按键处理");
				return false;
			}
			H8btZWpoAG1 = AppHelper.fLiLTj0x4QY();
			fSXtZ8HgFLY("PowerKey:普通键");
			if (!e.IsFromQuicker)
			{
				uhcbDejgDZ3vvobZ0Nn.NQZtWFXCKDx(e);
			}
			return false;
		}
		fSXtZ8HgFLY("PowerKeys为空。");
		if (r6DtZNbuKcF(e))
		{
			return true;
		}
		return false;
		IL_0840:
		Wm7tZ1fQFTc.KeyDown(e.KeyValue);
		goto IL_08ac;
		IL_08ac:
		return true;
		IL_06b0:
		num4 = num;
		goto IL_06b1;
		IL_0506:
		fSXtZ8HgFLY("未捕获第二按键（按键之间时间较长，或者是普通键或者是动作）：" + e.KeyCode);
		if (!MIytZ0yNjTu(nLVtZeho1NE.Value, e.KeyValue))
		{
			fSXtZ8HgFLY("未触发动作");
			if (!dsLtZuHc4vA(nLVtZeho1NE.Value, (int)e.KeyCode))
			{
				fSXtZ8HgFLY("非修饰键：" + e.KeyCode);
				if (WgrtZYHBqgh != null)
				{
					PowerKey wgrtZYHBqgh3 = WgrtZYHBqgh;
					if (wgrtZYHBqgh3 == null || wgrtZYHBqgh3.Key != 91)
					{
						PowerKey wgrtZYHBqgh4 = WgrtZYHBqgh;
						if (wgrtZYHBqgh4 == null || !wgrtZYHBqgh4.KeepOriginKeyFunc || AppState.HHxtaMaoqJr().PowerKeys_IgnoreUnknownKey)
						{
							fSXtZ8HgFLY("单独按下不还原原始操作，继续拦截：" + e.KeyCode.ToString() + $" 当前holding：{(VirtualKeyCode?)WgrtZYHBqgh?.Key}");
							num4 = 1;
							if (!a1jHasQKRs8sZM040OMc())
							{
								goto IL_06b0;
							}
							goto IL_06b1;
						}
					}
				}
				fSXtZ8HgFLY("单独按下还原原始操作，撤销拦截：" + e.KeyCode);
				try
				{
					InputSimulator.Instance.Keyboard.KeyDownForRestore((VirtualKeyCode)nLVtZeho1NE.Value);
				}
				catch (Exception ex2)
				{
					O4MtZVUyyNA.Warn(ex2.Message, ex2);
					AppHelper.ShowWarning(ex2.Message);
				}
				nLVtZeho1NE = null;
				WgrtZYHBqgh = null;
				return false;
			}
			goto IL_0663;
		}
		fSXtZ8HgFLY("成功触发动作。");
		num4 = 7;
		if (E5AoBUQK8yZlv4jmUgPE != null)
		{
			goto IL_06b0;
		}
		goto IL_06b1;
		IL_08ae:
		fSXtZ8HgFLY("鼠标捕获时按下了键盘。");
		return kNNtZSrwrnF(e);
		IL_0663:
		fSXtZ8HgFLY("捕获修饰键：" + e.KeyCode);
		num4 = 2;
		if (E5AoBUQK8yZlv4jmUgPE != null)
		{
			goto IL_06b1;
		}
		goto IL_0840;
		IL_06b1:
		switch (num4)
		{
		case 4:
			break;
		default:
			goto IL_0663;
		case 1:
			return true;
		case 2:
			goto IL_0840;
		case 5:
			goto IL_0854;
		case 6:
			goto IL_08aa;
		case 7:
			goto IL_08ac;
		case 8:
			goto IL_08ae;
		case 3:
			goto IL_08c1;
		}
		goto IL_0506;
		IL_0854:
		try
		{
			InputSimulator.Instance.Keyboard.KeyDownForRestore((VirtualKeyCode)nLVtZeho1NE.Value);
		}
		catch (Exception ex3)
		{
			O4MtZVUyyNA.Warn(ex3.GetMessageWithInner(), ex3);
			AppHelper.ShowWarning(ex3.Message);
		}
		goto IL_0895;
		IL_0895:
		nLVtZeho1NE = null;
		WgrtZYHBqgh = null;
		return false;
		IL_08c1:
		return false;
		IL_08aa:
		return true;
	}

	private bool umotZ2583iZ()
	{
		if (string.Equals(AppState.CurrentProcessName, "explorer", StringComparison.OrdinalIgnoreCase) && KeyboardHelper.IsKeyDown(VirtualKeyCode.LMENU))
		{
			return NativeMethods.GetWindowClass(AppState.r4itaWBnyVQ().ForegroundWindowHwnd).EqualsAny(true, "XamlExplorerHostIslandWindow", "TaskSwitcherWnd", "ForegroundStaging", "MultitaskingViewFrame", "TaskSwitcherOverlayWnd");
		}
		return false;
	}

	private bool dsLtZuHc4vA(int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.n2dvKpnZfN5 = int_1;
		if (!RxKtZqABPpy().ContainsKey(int_0))
		{
			return false;
		}
		PowerKey powerKey = RxKtZqABPpy()[int_0];
		if (!powerKey.IsEnabled)
		{
			return false;
		}
		return powerKey.KeyActions.Any(_003C_003Ec__DisplayClass27_.GmkvKr7PSpN);
	}

	private bool r6DtZNbuKcF(HookKeyEventArgs hookKeyEventArgs_0)
	{
		KeyboardState realKeyState = AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState;
		if (AppState.DataService.CpItmVISR7P().EnableLeftButtonPlus && AppHelper.IsLeftBtnDown() && !BlackListMgr.IsCurrentAppInBlackListOrDisabledByFullScreen() && !BlackListHelper.IsProcessInBlackList(AppState.CurrentProcessName, AppState.HHxtaMaoqJr().LeftButtonPlusBlackList) && JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.None && (!hookKeyEventArgs_0.IsInjected || !GrZJHjXh9DrUnn7CH6P.FqktK6Zw1fT()) && (!hookKeyEventArgs_0.IsRepeating || GrZJHjXh9DrUnn7CH6P.FqktK6Zw1fT()) && GrZJHjXh9DrUnn7CH6P.MqUtKVJYvAv(hookKeyEventArgs_0.KeyValue, hookKeyEventArgs_0.IsRepeating))
		{
			int num = 0;
			if (E5AoBUQK8yZlv4jmUgPE != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				AppState.v5FtaQ4hQfg().RV5vLF5yh1l(true);
				return true;
			}
		}
		return false;
	}

	public static bool IsLeftMouseButtonPressing()
	{
		return AppHelper.IsLeftBtnDown();
	}

	private void h6OtZJxrDfq(int int_0, PowerKey powerKey_1)
	{
		nLVtZeho1NE = int_0;
		WgrtZYHBqgh = powerKey_1;
		njntZIhULBq = AppHelper.fLiLTj0x4QY();
		SRItZCqifYy(int_0);
		Wm7tZ1fQFTc.Reset();
	}

	private bool MIytZ0yNjTu(int int_0, int? nullable_2)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
		_003C_003Ec__DisplayClass31_.XnZvKQMHN0t = nullable_2;
		_003C_003Ec__DisplayClass31_.kwRvKjTitNG = this;
		if (RxKtZqABPpy() != null && RxKtZqABPpy().ContainsKey(int_0))
		{
			PowerKey powerKey = RxKtZqABPpy()[int_0];
			if (!powerKey.IsEnabled)
			{
				return false;
			}
			IList<PowerKeyActionItem> list = powerKey.KeyActions.Where(_003C_003Ec__DisplayClass31_.u8svKBAYSf0).OrderByDescending(_003C_003Ec.QfHvKWBsFWn ?? (_003C_003Ec.QfHvKWBsFWn = _003C_003Ec.JJ6vKIoIZYg.l0VvK8HjuUQ)).ThenBy(_003C_003Ec.yedvKkjdZ2G ?? (_003C_003Ec.yedvKkjdZ2G = _003C_003Ec.JJ6vKIoIZYg.bxFvKaQMeEY))
				.ToList();
			if (list.HasData())
			{
				PowerKeyActionItem powerKeyActionItem = list.FirstOrDefault(_003C_003Ec.qeIvKGDsL5W ?? (_003C_003Ec.qeIvKGDsL5W = _003C_003Ec.JJ6vKIoIZYg.TmZvK7PhHvF));
				if (powerKeyActionItem == null)
				{
					powerKeyActionItem = list.FirstOrDefault(_003C_003Ec.YpHvKs8ZFum ?? (_003C_003Ec.YpHvKs8ZFum = _003C_003Ec.JJ6vKIoIZYg.XKAvKRR47Vt));
				}
				if (powerKeyActionItem != null)
				{
					if (!iFOtZZ4guf3.Nrut6SrGm6p(true))
					{
						return true;
					}
					string inputText = ((powerKeyActionItem.SecondaryKey != 261) ? "" : ((Keys?)_003C_003Ec__DisplayClass31_.XnZvKQMHN0t)?.ToString());
					QuickActionRunner.RunQuickActionAsync(this, powerKeyActionItem, vEWtZ9iBR1H, emitZhfdFBr, false, ActionTrigger.PowerKeys, inputText);
					AppState.Lista4qx2wK().CountPowerKey();
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public bool ProcessKeyUp(System.Windows.Forms.KeyEventArgs e, out bool ignoringPrimaryKey)
	{
		int num = 7;
		while (true)
		{
			IL_02b7:
			ignoringPrimaryKey = false;
			int num2 = 6;
			if (!a1jHasQKRs8sZM040OMc())
			{
				goto IL_00af;
			}
			goto IL_0290;
			IL_0290:
			while (true)
			{
				switch (num2)
				{
				case 6:
					fSXtZ8HgFLY("KeyUp " + e.KeyCode.ToString() + $" 主：{(VirtualKeyCode?)nLVtZeho1NE}  临时：{(VirtualKeyCode?)qTJtZHxA0BK}");
					goto case 5;
				case 5:
					iVTtZyMa7EI();
					num2 = 2;
					if (E5AoBUQK8yZlv4jmUgPE != null)
					{
						continue;
					}
					break;
				case 3:
					break;
				default:
					goto IL_026b;
				case 7:
					goto IL_02b7;
				case 2:
					fSXtZ8HgFLY("抬起了控制键后的第一个临时键。");
					if (!MIytZ0yNjTu(nLVtZeho1NE.Value, qTJtZHxA0BK.Value))
					{
						fSXtZ8HgFLY("未触发动作");
					}
					else
					{
						fSXtZ8HgFLY("成功触发动作了");
					}
					qTJtZHxA0BK = null;
					CLmtZsYUuc7 = true;
					return true;
				case 4:
					goto IL_0327;
				case 1:
					goto IL_03aa;
				}
				break;
				IL_0327:
				if (AppHelper.fLiLTj0x4QY() - njntZIhULBq <= iFOtZZ4guf3.CpItmVISR7P().PowerKeys_CancelLongPressKeyDelayMs)
				{
					goto IL_0353;
				}
				fSXtZ8HgFLY("按下时间太长了，可能是误按的情况，不执行操作。");
				goto IL_0364;
				IL_0353:
				AppHelper.RunAndIgnoreException(vpMtZ7itKXK);
				goto IL_0364;
				IL_026b:
				if (iFOtZZ4guf3.CpItmVISR7P().PowerKeys_CancelLongPressKeyDelayMs > 0)
				{
					num2 = 4;
					if (E5AoBUQK8yZlv4jmUgPE == null)
					{
						continue;
					}
					goto IL_0265;
				}
				goto IL_0353;
				IL_0364:
				H8btZWpoAG1 = AppHelper.fLiLTj0x4QY();
				goto IL_03cd;
			}
			goto IL_00af;
			IL_00af:
			if (nLVtZeho1NE.HasValue)
			{
				if (nLVtZeho1NE == e.KeyValue || Wm7tZ1fQFTc.IsKeyDown(e.KeyValue) || qTJtZHxA0BK == e.KeyValue)
				{
					if (!qTJtZHxA0BK.HasValue)
					{
						goto IL_01dd;
					}
					if (e.KeyValue == nLVtZeho1NE)
					{
						fSXtZ8HgFLY("抬起了控制键。" + e.KeyValue);
						AppHelper.RunAndIgnoreException(Cr7tZa9tc17);
						nLVtZeho1NE = null;
						WgrtZYHBqgh = null;
						num2 = 1;
						if (!a1jHasQKRs8sZM040OMc())
						{
							goto IL_03aa;
						}
					}
					else
					{
						if (e.KeyValue != qTJtZHxA0BK)
						{
							goto IL_01dd;
						}
						num2 = 2;
						if (!a1jHasQKRs8sZM040OMc())
						{
							goto IL_0265;
						}
					}
					goto IL_0290;
				}
				fSXtZ8HgFLY($"忽略处理按键{e.KeyCode}。当前Holding:{WgrtZYHBqgh}。如果键是在按下控制键之前按下的，则还原原有按键功能。");
				return false;
			}
			qTJtZHxA0BK = null;
			CLmtZsYUuc7 = false;
			return false;
			IL_0265:
			num2 = num;
			goto IL_0290;
			IL_03cd:
			int valueOrDefault = nLVtZeho1NE.GetValueOrDefault();
			if (valueOrDefault > 0 && RxKtZqABPpy().ContainsKey(valueOrDefault))
			{
				IList<PowerKeyActionItem> list = RxKtZqABPpy()[valueOrDefault].KeyActions?.Where(_003C_003Ec.BQQvKHl5NGT ?? (_003C_003Ec.BQQvKHl5NGT = _003C_003Ec.JJ6vKIoIZYg.N5HvKqlOjSC)).ToList();
				if (list.HasData())
				{
					PowerKeyActionItem powerKeyActionItem = list?.FirstOrDefault(_003C_003Ec.kjUvK1Eixm3 ?? (_003C_003Ec.kjUvK1Eixm3 = _003C_003Ec.JJ6vKIoIZYg.Ju7vKcfWosk));
					if (powerKeyActionItem == null)
					{
						powerKeyActionItem = list?.FirstOrDefault(_003C_003Ec.KkWvKbqCiLy ?? (_003C_003Ec.KkWvKbqCiLy = _003C_003Ec.JJ6vKIoIZYg.XNFvKVb2Vhq));
					}
					if (powerKeyActionItem != null)
					{
						QuickActionRunner.RunQuickActionAsync(this, powerKeyActionItem, vEWtZ9iBR1H, emitZhfdFBr, false, ActionTrigger.PowerKeys, "");
					}
				}
			}
			if (nLVtZeho1NE.HasValue)
			{
				mX7qQhjtCi2Je746unO.SSQtGP00VJO((Keys)nLVtZeho1NE.Value);
			}
			goto IL_04f3;
			IL_04f3:
			CLmtZsYUuc7 = false;
			nLVtZeho1NE = null;
			WgrtZYHBqgh = null;
			Reset();
			return true;
			IL_01dd:
			Wm7tZ1fQFTc.KeyUp(e.KeyValue);
			if (e.KeyValue != nLVtZeho1NE)
			{
				break;
			}
			fSXtZ8HgFLY("抬起了控制键。");
			if (!qTJtZHxA0BK.HasValue && !CLmtZsYUuc7)
			{
				if (RxKtZqABPpy()[nLVtZeho1NE.GetValueOrDefault()].KeepOriginKeyFunc)
				{
					num2 = 0;
					if (!a1jHasQKRs8sZM040OMc())
					{
						goto IL_0265;
					}
					goto IL_0290;
				}
				ignoringPrimaryKey = true;
				goto IL_03cd;
			}
			goto IL_04f3;
			IL_03aa:
			qTJtZHxA0BK = null;
			CLmtZsYUuc7 = false;
			fSXtZ8HgFLY("先抬起了控制键。取消热键输入。");
			return true;
		}
		return true;
	}

	private void SRItZCqifYy(int int_0)
	{
		i9QtZP0DFnM();
		if (iFOtZZ4guf3.CpItmVISR7P().PowerKeys_HintWindowDelay > 0)
		{
			AHitZkBVT3X = new System.Threading.Timer(FEftZEG41ef, int_0, iFOtZZ4guf3.CpItmVISR7P().PowerKeys_HintWindowDelay, 0);
		}
	}

	private void i9QtZP0DFnM()
	{
		if (AHitZkBVT3X != null)
		{
			AHitZkBVT3X.Dispose();
			AHitZkBVT3X = null;
		}
	}

	private void FEftZEG41ef(object object_0)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.OukvK4rC9RE = this;
		_003C_003Ec__DisplayClass35_.HrBvK5awoL3 = (int)object_0;
		if (_003C_003Ec__DisplayClass35_.HrBvK5awoL3 == nLVtZeho1NE)
		{
			System.Windows.Application.Current.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass35_.Q68vKnuaXI3);
			i9QtZP0DFnM();
		}
	}

	private void iVTtZyMa7EI()
	{
		if (BUYtZGRSU4S != null)
		{
			AppHelper.RunOnUiThread(false, adctZRUNiNF);
		}
		i9QtZP0DFnM();
	}

	private void fSXtZ8HgFLY(string string_0)
	{
		if (AppState.EnableDetailedLogging)
		{
			O4MtZVUyyNA.Info(string_0);
		}
	}

	public void Reset()
	{
		nLVtZeho1NE = null;
		WgrtZYHBqgh = null;
		qTJtZHxA0BK = null;
	}

	public void OnMouseLeftButtonDown()
	{
		if (WgrtZYHBqgh != null && WgrtZYHBqgh.KeepOriginKeyFunc)
		{
			i9QtZP0DFnM();
			try
			{
				InputSimulator.Instance.Keyboard.KeyDownForRestore((VirtualKeyCode)nLVtZeho1NE.Value);
			}
			catch (Exception ex)
			{
				O4MtZVUyyNA.Warn(ex.Message, ex);
				AppHelper.ShowWarning(ex.Message);
			}
			WgrtZYHBqgh = null;
		}
	}

	static PowerKeysService()
	{
		O4MtZVUyyNA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void Cr7tZa9tc17()
	{
		InputSimulator.Instance.Keyboard.KeyPressForRestore((VirtualKeyCode)nLVtZeho1NE.Value);
		InputSimulator.Instance.Keyboard.KeyPressForRestore((VirtualKeyCode)qTJtZHxA0BK.Value);
	}

	[CompilerGenerated]
	private void vpMtZ7itKXK()
	{
		if (nLVtZeho1NE.HasValue)
		{
			InputSimulator.Instance.Keyboard.KeyPressForRestore((VirtualKeyCode)nLVtZeho1NE.Value);
		}
	}

	[CompilerGenerated]
	private void adctZRUNiNF()
	{
		if (BUYtZGRSU4S != null)
		{
			BUYtZGRSU4S.Close();
			BUYtZGRSU4S = null;
		}
	}

	internal static void Fh85OqQKPQMOMq6Qv536()
	{
	}

	internal static bool a1jHasQKRs8sZM040OMc()
	{
		return E5AoBUQK8yZlv4jmUgPE == null;
	}
}
