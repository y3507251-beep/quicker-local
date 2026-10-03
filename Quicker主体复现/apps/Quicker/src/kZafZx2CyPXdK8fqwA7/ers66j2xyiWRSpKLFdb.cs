using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using Ci16jh2IrdW1EGWcrNE;
using log4net;
using Quicker.Domain.Extensions;
using Quicker.Domain.Mouse;
using Quicker.Domain.PowerMouse;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using WindowsInput.Native;

namespace kZafZx2CyPXdK8fqwA7;

internal class ers66j2xyiWRSpKLFdb
{
	private static readonly ILog HW0t9h3npXF;

	private readonly oweR8e2rZD7t5GSlLo4 BHxt9e66AaM = new oweR8e2rZD7t5GSlLo4("Session", false);

	private long gk2t9YPmAZ6;

	[CompilerGenerated]
	private MouseAction xQCt9IH3ed8;

	[CompilerGenerated]
	private bool nBLt9WQoAWP;

	[CompilerGenerated]
	private bool ruXt9kuKM35;

	[CompilerGenerated]
	private PointTargetInfo H3Kt9Gdo8nB;

	[CompilerGenerated]
	private Screen biZt9sQ6YhZ;

	[CompilerGenerated]
	private readonly PointArray qlSt9HTtQyv = new PointArray(500);

	private object p4Mt91njyv9 = new object();

	[CompilerGenerated]
	private System.Drawing.Point J1Nt9bSvO0j;

	[CompilerGenerated]
	private VirtualKeyCode? PcVt96NspKE;

	[CompilerGenerated]
	private MouseButtons? D0rt9XOecEk;

	[CompilerGenerated]
	private bool NwXt9mUIn74;

	[CompilerGenerated]
	private MouseButtons? KkOt9Kk2ORj;

	[CompilerGenerated]
	private bool yPTt9xaIpgO;

	private static ers66j2xyiWRSpKLFdb PwjB3fQBVOPb1DUKKcTq;

	public MouseAction MouseAction
	{
		[CompilerGenerated]
		get
		{
			return xQCt9IH3ed8;
		}
		[CompilerGenerated]
		set
		{
			xQCt9IH3ed8 = value;
		}
	}

	public PointArray Points
	{
		[CompilerGenerated]
		get
		{
			return qlSt9HTtQyv;
		}
	}

	public System.Drawing.Point StartPoint
	{
		[CompilerGenerated]
		get
		{
			return J1Nt9bSvO0j;
		}
		[CompilerGenerated]
		private set
		{
			J1Nt9bSvO0j = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool PGptZUwoapr()
	{
		return nBLt9WQoAWP;
	}

	[SpecialName]
	[CompilerGenerated]
	public void gEftZllp5ei(bool bool_4)
	{
		nBLt9WQoAWP = bool_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool egCtZ3dlevS()
	{
		return ruXt9kuKM35;
	}

	[SpecialName]
	[CompilerGenerated]
	public void HTptZffK9K5(bool bool_4)
	{
		ruXt9kuKM35 = bool_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public PointTargetInfo nNvt9wrNn9A()
	{
		return H3Kt9Gdo8nB;
	}

	[SpecialName]
	[CompilerGenerated]
	private void aAvt9tYhA2j(PointTargetInfo pointTargetInfo_1)
	{
		H3Kt9Gdo8nB = pointTargetInfo_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Screen D4Kt9L8hbBH()
	{
		return biZt9sQ6YhZ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void TtGt9vAyLu4(Screen screen_1)
	{
		biZt9sQ6YhZ = screen_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public VirtualKeyCode? EvVt9JuygnX()
	{
		return PcVt96NspKE;
	}

	[SpecialName]
	[CompilerGenerated]
	public void aJvt90Nj9ZH(VirtualKeyCode? nullable_3)
	{
		PcVt96NspKE = nullable_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public MouseButtons? SqUt9PBisZY()
	{
		return D0rt9XOecEk;
	}

	[SpecialName]
	[CompilerGenerated]
	private void LQYt9EVNmRc(MouseButtons? nullable_3)
	{
		D0rt9XOecEk = nullable_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool CyRt98YnNFS()
	{
		return NwXt9mUIn74;
	}

	[SpecialName]
	[CompilerGenerated]
	public void kdZt9aGlViN(bool bool_4)
	{
		NwXt9mUIn74 = bool_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public MouseButtons? yKut9RdyCvZ()
	{
		return KkOt9Kk2ORj;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b85t9qRpcbb(MouseButtons? nullable_3)
	{
		KkOt9Kk2ORj = nullable_3;
	}

	public void LrEtZ6gkukf(PointTargetInfo pointTargetInfo_1, Screen screen_1)
	{
		if (KIQtZjjGceP())
		{
			HW0t9h3npXF.Warn("MouseSession还没有结束的时候开始了新Session");
			KPhtZmUAjus();
		}
		HyotZQw6Ggs();
		gk2t9YPmAZ6 = AppHelper.fLiLTj0x4QY();
		aAvt9tYhA2j(pointTargetInfo_1);
		TtGt9vAyLu4(screen_1);
		StartPoint = pointTargetInfo_1.Point;
		int num = 0;
		if (!EG0VddQBQ62nbDw6s9mU())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ap5t9ZXjW29(false);
		LQYt9EVNmRc(null);
		HTptZffK9K5(false);
	}

	public void WXstZXfeNVh(PointTargetInfo pointTargetInfo_1, Screen screen_1, VirtualKeyCode virtualKeyCode_0, MouseAction mouseAction_1)
	{
		LrEtZ6gkukf(pointTargetInfo_1, screen_1);
		aJvt90Nj9ZH(virtualKeyCode_0);
		MouseAction = mouseAction_1;
	}

	public void KPhtZmUAjus()
	{
		BHxt9e66AaM.Reset();
		aJvt90Nj9ZH(null);
		ap5t9ZXjW29(false);
		tCZtZK8xtTr();
	}

	public void tCZtZK8xtTr()
	{
		gk2t9YPmAZ6 = 0L;
		MouseAction = null;
		aAvt9tYhA2j(null);
		TtGt9vAyLu4(null);
		gEftZllp5ei(false);
		HTptZffK9K5(false);
		LQYt9EVNmRc(null);
		HyotZQw6Ggs();
	}

	public void p11tZxdVPnd()
	{
		MouseAction = new MouseAction();
	}

	public bool mOctZrLyE5i()
	{
		return MouseAction != null;
	}

	public void VC6tZptEHJM()
	{
		if (mOctZrLyE5i())
		{
			tCZtZK8xtTr();
		}
		else
		{
			KPhtZmUAjus();
		}
	}

	public long SNdtZBa5DJP()
	{
		if (gk2t9YPmAZ6 == 0L)
		{
			return -1L;
		}
		return AppHelper.fLiLTj0x4QY() - gk2t9YPmAZ6;
	}

	public void HyotZQw6Ggs()
	{
		Points.Reset();
	}

	public bool KIQtZjjGceP()
	{
		if (!BHxt9e66AaM.naIt9jxvaxU())
		{
			return EvVt9JuygnX().HasValue;
		}
		return true;
	}

	public bool qjetZnem4NC(System.Drawing.Point point_1)
	{
		lock (p4Mt91njyv9)
		{
			if (Points.Count == 0)
			{
				goto IL_0090;
			}
			if (PwjB3fQBVOPb1DUKKcTq == null)
			{
				switch (0)
				{
				}
			}
			if (Math.Abs(Points.Last().X - (double)point_1.X) > 2.0 || !(Math.Abs(Points.Last().Y - (double)point_1.Y) <= 2.0))
			{
				goto IL_0090;
			}
			goto end_IL_0009;
			IL_0090:
			Points.Add(point_1.ToWindowsPoint());
			return true;
			end_IL_0009:;
		}
		return false;
	}

	public IList<System.Windows.Point> HM2tZ4X1XVi()
	{
		lock (p4Mt91njyv9)
		{
			return Points.GetCurrent();
		}
	}

	public int BWKtZ5W0fAU()
	{
		return BHxt9e66AaM.T9Zt95niJV9();
	}

	public MouseButtons? tNotZDBTnmu()
	{
		return BHxt9e66AaM.znBt9D21V2Z();
	}

	public void G5ltZd9HBRS(MouseButtons mouseButtons_0)
	{
		BHxt9e66AaM.jUNt9BaxGBE(mouseButtons_0);
		if (BWKtZ5W0fAU() > 1)
		{
			ap5t9ZXjW29(true);
		}
		else
		{
			LQYt9EVNmRc(mouseButtons_0);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool phmt9VwqKjJ()
	{
		return yPTt9xaIpgO;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ap5t9ZXjW29(bool bool_4)
	{
		yPTt9xaIpgO = bool_4;
	}

	public bool v1FtZoD4OuB(MouseButtons mouseButtons_0)
	{
		return BHxt9e66AaM.Kcpt9nPM6AT(mouseButtons_0);
	}

	public bool syNtZTClr27(MouseButtons mouseButtons_0)
	{
		if (BHxt9e66AaM.Kcpt9nPM6AT(mouseButtons_0) && !BHxt9e66AaM.kQut94YY1XS(mouseButtons_0))
		{
			return Control.MouseButtons == MouseButtons.None;
		}
		return false;
	}

	public void OSrtZMXZ2c0(MouseButtons mouseButtons_0)
	{
		BHxt9e66AaM.s98t9QV8E0b(mouseButtons_0);
	}

	public bool PG5tZA0N5nh(MouseButtons? nullable_3)
	{
		return BHxt9e66AaM.kQut94YY1XS(nullable_3);
	}

	static ers66j2xyiWRSpKLFdb()
	{
		HW0t9h3npXF = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool EG0VddQBQ62nbDw6s9mU()
	{
		return PwjB3fQBVOPb1DUKKcTq == null;
	}

	internal static void UfiyVWQBWUdEoogFDS6r()
	{
	}
}
