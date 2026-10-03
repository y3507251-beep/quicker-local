using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using log4net;
using Quicker.Domain;

namespace Ci16jh2IrdW1EGWcrNE;

internal class oweR8e2rZD7t5GSlLo4
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cFCvKoqxy9W;

		public static Func<bool, bool> rfgvKT5d2Vy;

		public static Func<bool, bool> RUDvKMQvLsb;

		internal static _003C_003Ec WJE4vRcSfH6RW37vQStU;

		static _003C_003Ec()
		{
			cFCvKoqxy9W = new _003C_003Ec();
		}

		internal bool EKfvKDXTvFm(bool flag)
		{
			return flag;
		}

		internal bool VB3vKd8fRNG(bool flag)
		{
			return flag;
		}

		internal static bool QKhA70cSbcY24c0MfuKv()
		{
			return WJE4vRcSfH6RW37vQStU == null;
		}
	}

	private static readonly ILog IbVt9O1ngPB;

	private readonly string zmct9FFrPKj;

	private readonly bool ihHt9UuICfd;

	private bool[] r9Lt9lNYwqS = new bool[5];

	private long[] kdPt9igR7cb;

	private MouseButtons? zalt93FtMjF;

	private string cOJt9fgHED8 = "";

	private static oweR8e2rZD7t5GSlLo4 vcoFPKQB2LnlhPaxBxpc;

	public oweR8e2rZD7t5GSlLo4(string string_2, bool bool_2)
	{
		zmct9FFrPKj = string_2;
		ihHt9UuICfd = bool_2;
		if (bool_2)
		{
			kdPt9igR7cb = new long[5];
		}
	}

	public void jUNt9BaxGBE(MouseButtons mouseButtons_0)
	{
		if (!naIt9jxvaxU())
		{
			zalt93FtMjF = mouseButtons_0;
		}
		Tt7t9oNmkeh(mouseButtons_0, true);
	}

	public bool s98t9QV8E0b(MouseButtons mouseButtons_0)
	{
		bool result = Tt7t9oNmkeh(mouseButtons_0, false);
		if (!naIt9jxvaxU())
		{
			zalt93FtMjF = null;
		}
		return result;
	}

	public bool naIt9jxvaxU()
	{
		return r9Lt9lNYwqS.Any(_003C_003Ec.rfgvKT5d2Vy ?? (_003C_003Ec.rfgvKT5d2Vy = _003C_003Ec.cFCvKoqxy9W.EKfvKDXTvFm));
	}

	public bool Kcpt9nPM6AT(MouseButtons mouseButtons_0)
	{
		if (mouseButtons_0 == MouseButtons.None)
		{
			return false;
		}
		return Iynt9TS97tW(mouseButtons_0);
	}

	public bool kQut94YY1XS(MouseButtons? nullable_1)
	{
		if (nullable_1.HasValue)
		{
			MouseButtons? mouseButtons = nullable_1;
			if (!((mouseButtons.GetValueOrDefault() == MouseButtons.None) & mouseButtons.HasValue))
			{
				int num = Cwjt9MUkBDr(nullable_1.Value);
				int num2 = 0;
				while (true)
				{
					if (num2 < r9Lt9lNYwqS.Length)
					{
						if (num2 != num && r9Lt9lNYwqS[num2])
						{
							break;
						}
						num2++;
						continue;
					}
					return false;
				}
				return true;
			}
		}
		return naIt9jxvaxU();
	}

	public int T9Zt95niJV9()
	{
		return r9Lt9lNYwqS.Count(_003C_003Ec.RUDvKMQvLsb ?? (_003C_003Ec.RUDvKMQvLsb = _003C_003Ec.cFCvKoqxy9W.VB3vKd8fRNG));
	}

	public MouseButtons? znBt9D21V2Z()
	{
		return zalt93FtMjF;
	}

	public void Reset()
	{
		zalt93FtMjF = null;
		if (naIt9jxvaxU())
		{
			IbVt9O1ngPB.Warn("重置鼠标状态时，有按键时按下或捕获的。" + Vlwt9dmcg4q());
		}
		for (int i = 0; i < r9Lt9lNYwqS.Length; i++)
		{
			r9Lt9lNYwqS[i] = false;
		}
	}

	private string Vlwt9dmcg4q()
	{
		return $"{r9Lt9lNYwqS[0]},{r9Lt9lNYwqS[1]},{r9Lt9lNYwqS[2]},{r9Lt9lNYwqS[3]},{r9Lt9lNYwqS[4]}";
	}

	private bool Tt7t9oNmkeh(MouseButtons mouseButtons_0, bool bool_2)
	{
		int num = Cwjt9MUkBDr(mouseButtons_0);
		if (num >= 0)
		{
			if (zA6hOcQBAI1tOqpCewR0())
			{
				switch (0)
				{
				}
			}
			if (r9Lt9lNYwqS[num] == bool_2 && mouseButtons_0 != MouseButtons.Left)
			{
				IbVt9O1ngPB.Warn($"{AppState.TickCount:N0} 重复设置鼠标按下状态:, thread:{Thread.CurrentThread.ManagedThreadId} , button:{mouseButtons_0}   flag:{bool_2}   ");
			}
			r9Lt9lNYwqS[num] = bool_2;
			if (ihHt9UuICfd && !bool_2)
			{
				long tickCount = AppState.TickCount;
				bool result = tickCount - kdPt9igR7cb[num] < 220L && cOJt9fgHED8 == AppState.CurrentProcessName;
				kdPt9igR7cb[num] = tickCount;
				cOJt9fgHED8 = AppState.CurrentProcessName;
				return result;
			}
		}
		return false;
	}

	private bool Iynt9TS97tW(MouseButtons mouseButtons_0)
	{
		int num = Cwjt9MUkBDr(mouseButtons_0);
		if (num >= 0)
		{
			return r9Lt9lNYwqS[num];
		}
		return false;
	}

	private static int Cwjt9MUkBDr(MouseButtons mouseButtons_0)
	{
		return mouseButtons_0 switch
		{
			MouseButtons.Right => 2, 
			MouseButtons.Left => 0, 
			MouseButtons.XButton2 => 4, 
			MouseButtons.XButton1 => 3, 
			MouseButtons.Middle => 1, 
			_ => -1, 
		};
	}

	private static MouseButtons T48t9Ar1WG9(int int_0)
	{
		return int_0 switch
		{
			0 => MouseButtons.Left, 
			1 => MouseButtons.Middle, 
			2 => MouseButtons.Right, 
			3 => MouseButtons.XButton1, 
			4 => MouseButtons.XButton2, 
			_ => MouseButtons.None, 
		};
	}

	static oweR8e2rZD7t5GSlLo4()
	{
		IbVt9O1ngPB = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool zA6hOcQBAI1tOqpCewR0()
	{
		return vcoFPKQB2LnlhPaxBxpc == null;
	}
}
