using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Quicker.Domain;
using Quicker.Domain.PowerKeys;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Hooks;

namespace rWLkMnX3Bc6H4OlaITp;

internal class OjxmG1XsQxaJxHk41nk
{
	[CompilerGenerated]
	private IList<Keys> Tiig9f37xSy;

	[CompilerGenerated]
	private bool BYKg9zl2Vpn;

	[CompilerGenerated]
	private bool bJhghwP27Cl;

	[CompilerGenerated]
	private bool p6Cghtm5ZiT;

	[CompilerGenerated]
	private bool cOnghgy2f28;

	[CompilerGenerated]
	private EventHandler HKeghLuShrY;

	[CompilerGenerated]
	private int lQCghvpulfq;

	private long gEUghSyqVpc;

	[CompilerGenerated]
	private bool Aw0gh2cqgW5;

	private bool QOLghugI09g;

	[CompilerGenerated]
	private bool qnvghNXDMSY;

	[CompilerGenerated]
	private bool hTDghJ1loYm;

	[CompilerGenerated]
	private bool UXbgh0GmvPx;

	[CompilerGenerated]
	private Keys fmHghCAQITh;

	[CompilerGenerated]
	private int v2nghPEFEJ2;

	private static OjxmG1XsQxaJxHk41nk USCVlYQwWLUIGDP5OpZp;

	public IList<Keys> Keys
	{
		[CompilerGenerated]
		get
		{
			return Tiig9f37xSy;
		}
		[CompilerGenerated]
		set
		{
			Tiig9f37xSy = value;
		}
	}

	public bool Alt
	{
		[CompilerGenerated]
		get
		{
			return BYKg9zl2Vpn;
		}
		[CompilerGenerated]
		set
		{
			BYKg9zl2Vpn = value;
		}
	}

	public bool Shift
	{
		[CompilerGenerated]
		get
		{
			return bJhghwP27Cl;
		}
		[CompilerGenerated]
		set
		{
			bJhghwP27Cl = value;
		}
	}

	public bool Ctrl
	{
		[CompilerGenerated]
		get
		{
			return p6Cghtm5ZiT;
		}
		[CompilerGenerated]
		set
		{
			p6Cghtm5ZiT = value;
		}
	}

	public bool Win
	{
		[CompilerGenerated]
		get
		{
			return cOnghgy2f28;
		}
		[CompilerGenerated]
		set
		{
			cOnghgy2f28 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void GDog9lFutu6(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = HKeghLuShrY;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref HKeghLuShrY, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void mflg9iNlNWJ(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = HKeghLuShrY;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref HKeghLuShrY, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public int fUMg9XlnlcL()
	{
		return lQCghvpulfq;
	}

	[SpecialName]
	[CompilerGenerated]
	public void DuAg9m1dUYa(int int_2)
	{
		lQCghvpulfq = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool N5Qg9x557wi()
	{
		return Aw0gh2cqgW5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void vOMg9r5ashP(bool bool_9)
	{
		Aw0gh2cqgW5 = bool_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool WCUg9B2uPiZ()
	{
		return qnvghNXDMSY;
	}

	[SpecialName]
	[CompilerGenerated]
	public void oUbg9QZJlfx(bool bool_9)
	{
		qnvghNXDMSY = bool_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool XfUg9nBFOrS()
	{
		return hTDghJ1loYm;
	}

	[SpecialName]
	[CompilerGenerated]
	public void kugg94ymTkB(bool bool_9)
	{
		hTDghJ1loYm = bool_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool hUNg9DvG5KE()
	{
		return UXbgh0GmvPx;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i8Tg9d1ARiT(bool bool_9)
	{
		UXbgh0GmvPx = bool_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public Keys chyg9TTOZAN()
	{
		return fmHghCAQITh;
	}

	[SpecialName]
	[CompilerGenerated]
	public void vPTg9M2jtPO(Keys keys_1)
	{
		fmHghCAQITh = keys_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int SXFg9OPWGY2()
	{
		return v2nghPEFEJ2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void MuUg9F4iUQC(int int_2)
	{
		v2nghPEFEJ2 = int_2;
	}

	public bool DYOg9hf59KT(HookKeyEventArgs hookKeyEventArgs_0, out bool bool_9)
	{
		Keys keyCode = hookKeyEventArgs_0.KeyCode;
		int keyValue = hookKeyEventArgs_0.KeyValue;
		bool_9 = false;
		if (QOLghugI09g)
		{
			if (keyCode == chyg9TTOZAN())
			{
				hookKeyEventArgs_0.Handled = true;
				return true;
			}
			return false;
		}
		if (XfUg9nBFOrS() && hookKeyEventArgs_0.IsInjected)
		{
			goto IL_0164;
		}
		KeyboardState realKeyState = AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState;
		if (Alt && !realKeyState.IsAltDown())
		{
			return false;
		}
		if (Ctrl && !realKeyState.IsCtrlDown())
		{
			return false;
		}
		if (Shift && !realKeyState.IsShiftDown())
		{
			return false;
		}
		if (Win && !realKeyState.IsWinDown())
		{
			return false;
		}
		if (Keys.HasData())
		{
			if (Keys.Contains(keyCode))
			{
				i8Tg9d1ARiT(true);
			}
		}
		else
		{
			i8Tg9d1ARiT(true);
		}
		int num;
		if (hUNg9DvG5KE())
		{
			vPTg9M2jtPO(keyCode);
			num = 1;
			if (djk04NQwyZkOWeaWAKGG())
			{
				goto IL_00ec;
			}
			goto IL_0105;
		}
		goto IL_0166;
		IL_0164:
		return false;
		IL_011a:
		if (WCUg9B2uPiZ())
		{
			hookKeyEventArgs_0.Handled = true;
		}
		if (N5Qg9x557wi())
		{
			bool_9 = false;
			QOLghugI09g = true;
			gEUghSyqVpc = AppHelper.fLiLTj0x4QY();
		}
		else
		{
			bool_9 = true;
			HKeghLuShrY?.Invoke(this, EventArgs.Empty);
		}
		goto IL_0166;
		IL_00ec:
		MuUg9F4iUQC(keyValue);
		num = 0;
		if (!djk04NQwyZkOWeaWAKGG())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0105;
		IL_0105:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_011a;
		case 3:
			goto IL_0164;
		case 2:
			goto IL_0166;
		}
		goto IL_00ec;
		IL_0166:
		return hUNg9DvG5KE();
	}

	public bool Uyhg9eMqVRU(HookKeyEventArgs hookKeyEventArgs_0)
	{
		Keys keyCode = hookKeyEventArgs_0.KeyCode;
		int keyValue = hookKeyEventArgs_0.KeyValue;
		if (N5Qg9x557wi() && QOLghugI09g && keyCode == chyg9TTOZAN())
		{
			DuAg9m1dUYa((int)(AppHelper.fLiLTj0x4QY() - gEUghSyqVpc));
			HKeghLuShrY?.Invoke(this, EventArgs.Empty);
			return true;
		}
		return false;
	}

	internal static bool djk04NQwyZkOWeaWAKGG()
	{
		return USCVlYQwWLUIGDP5OpZp == null;
	}
}
