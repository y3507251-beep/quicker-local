using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using jeaU1l2eVVj4W2gaVc;
using Quicker.Utilities.Win32;

namespace SnipInsight.ImageCapture;

public class SmartBoundaryDetection
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public SmartBoundaryDetection j9svPQJycKo;

		public List<IntPtr> aoLvPjjZ5UC;

		internal static _003C_003Ec__DisplayClass9_0 foYxAocnKfeYjuE1cAtY;

		internal bool u3TvPBeFwTP(IntPtr hWnd, IntPtr lParam)
		{
			try
			{
				if (j9svPQJycKo.ASNLmhnn8L(hWnd))
				{
					aoLvPjjZ5UC.Add(hWnd);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		internal static bool bdAJ0jcnBpp9aBBxK617()
		{
			return foYxAocnKfeYjuE1cAtY == null;
		}
	}

	private readonly ScreenProperties SevLK8cKLT;

	private readonly List<IntPtr> CkwLxeVC6q = new List<IntPtr>();

	private readonly Dictionary<IntPtr, int> JSSLrSsxg9 = new Dictionary<IntPtr, int>();

	private readonly Dictionary<IntPtr, OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS> wHtLpaxanu = new Dictionary<IntPtr, OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS>();

	private readonly Dictionary<IntPtr, IntPtr> BoQLBlakdt = new Dictionary<IntPtr, IntPtr>();

	internal static SmartBoundaryDetection K2CqIvpXao2SgbglE1s;

	public SmartBoundaryDetection(ScreenProperties screenProps)
	{
		SevLK8cKLT = screenProps;
		mTGL6x7w6A();
	}

	public static Rectangle GetDesktopBounds()
	{
		IntPtr intPtr = OO77uFW4jgnwuPwqBc.vfmtpHd1gM();
		Rectangle result;
		if (intPtr != IntPtr.Zero)
		{
			OO77uFW4jgnwuPwqBc.NYMtR1k04U(intPtr, out var sx5yqVmkWqZQKeT9UhS_);
			result = new Rectangle(sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE, sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS, sx5yqVmkWqZQKeT9UhS_.width, sx5yqVmkWqZQKeT9UhS_.height);
		}
		else
		{
			result = new Rectangle(SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Top, SystemInformation.VirtualScreen.Right - SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Bottom - SystemInformation.VirtualScreen.Top);
		}
		return result;
	}

	public IntPtr GetTopElement(int x, int y)
	{
		List<IntPtr> list = loOLbagmNB(CkwLxeVC6q, x, y);
		IntPtr intPtr;
		int num;
		IntPtr intPtr2 = default(IntPtr);
		if (list != null && list.Count != 0)
		{
			intPtr = NativeMethods.WindowFromPoint(new Point(x, y));
			if (list.Contains(intPtr))
			{
				num = 1;
				if (K2CqIvpXao2SgbglE1s != null)
				{
					goto IL_00c4;
				}
				goto IL_00c8;
			}
			intPtr2 = list[0];
			int num2 = int.MaxValue;
			foreach (IntPtr item in list)
			{
				int value = 0;
				if (JSSLrSsxg9.TryGetValue(item, out value) && value < num2)
				{
					num2 = value;
					intPtr2 = item;
				}
			}
			goto IL_00db;
		}
		return IntPtr.Zero;
		IL_00c8:
		IntPtr intPtr3 = default(IntPtr);
		switch (num)
		{
		case 1:
			break;
		default:
			if (intPtr3 != IntPtr.Zero)
			{
				OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_;
				int num3 = OO77uFW4jgnwuPwqBc.YghtOJ4cZA(intPtr3, out sx5yqVmkWqZQKeT9UhS_);
				OO77uFW4jgnwuPwqBc.dhktEuIdPr(intPtr2, out var sx5yqVmkWqZQKeT9UhS_2);
				OO77uFW4jgnwuPwqBc.TZXt5jYrmP(intPtr2, intPtr3);
				if (num3 == 2 && sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE == sx5yqVmkWqZQKeT9UhS_2.XD7vPLOJ5hE && sx5yqVmkWqZQKeT9UhS_.DhUvPSLdZXQ == sx5yqVmkWqZQKeT9UhS_2.DhUvPSLdZXQ && sx5yqVmkWqZQKeT9UhS_.dPwvP2kZV1u == sx5yqVmkWqZQKeT9UhS_2.dPwvP2kZV1u && sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS == sx5yqVmkWqZQKeT9UhS_2.wTivPvfjMFS)
				{
					IntPtr topElement = GetTopElement(intPtr2, x, y);
					if (topElement != IntPtr.Zero)
					{
						return topElement;
					}
				}
			}
			return intPtr2;
		}
		intPtr2 = intPtr;
		goto IL_00db;
		IL_00db:
		if (!(intPtr2 == IntPtr.Zero))
		{
			intPtr3 = OO77uFW4jgnwuPwqBc.CuMtPghyV8(intPtr2);
			num = 0;
			if (!wCgZ03p2NVWOw7YYb1k())
			{
				goto IL_00c4;
			}
			goto IL_00c8;
		}
		return IntPtr.Zero;
		IL_00c4:
		int num4 = default(int);
		num = num4;
		goto IL_00c8;
	}

	public IntPtr GetTopElement(IntPtr eHnd, int x, int y)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.j9svPQJycKo = this;
		_003C_003Ec__DisplayClass9_.aoLvPjjZ5UC = new List<IntPtr>();
		try
		{
			OO77uFW4jgnwuPwqBc.YIQtC6E1LT(eHnd, _003C_003Ec__DisplayClass9_.u3TvPBeFwTP, IntPtr.Zero);
		}
		catch (Exception)
		{
		}
		if (_003C_003Ec__DisplayClass9_.aoLvPjjZ5UC.Count > 0)
		{
			List<IntPtr> list = loOLbagmNB(_003C_003Ec__DisplayClass9_.aoLvPjjZ5UC, x, y);
			int num = 0;
			if (!wCgZ03p2NVWOw7YYb1k())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (list != null && list.Count > 0 && list.Count > 1)
			{
				return list[0];
			}
		}
		return eHnd;
	}

	internal OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS qMwLHK8lBi(IntPtr intptr_0)
	{
		if (wHtLpaxanu.ContainsKey(intptr_0) && wHtLpaxanu.TryGetValue(intptr_0, out var value))
		{
			return value;
		}
		OO77uFW4jgnwuPwqBc.NYMtR1k04U(intptr_0, out value);
		wHtLpaxanu.Add(intptr_0, value);
		return value;
	}

	internal IntPtr UusL1BGewe(IntPtr intptr_0)
	{
		IntPtr value = IntPtr.Zero;
		if (BoQLBlakdt.ContainsKey(intptr_0) && BoQLBlakdt.TryGetValue(intptr_0, out value))
		{
			return value;
		}
		value = OO77uFW4jgnwuPwqBc.Ajct8eA8UC(intptr_0, 2);
		BoQLBlakdt.Add(intptr_0, value);
		return value;
	}

	private List<IntPtr> loOLbagmNB(List<IntPtr> list_1, double double_0, double double_1)
	{
		List<IntPtr> list = new List<IntPtr>();
		if (list_1 != null && list_1.Count > 0)
		{
			foreach (IntPtr item in list_1)
			{
				if (InRange(item, double_0, double_1))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public bool InRange(IntPtr hWnd, double x, double y)
	{
		try
		{
			OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sX5yqVmkWqZQKeT9UhS = qMwLHK8lBi(hWnd);
			if (sX5yqVmkWqZQKeT9UhS.width == 0 || sX5yqVmkWqZQKeT9UhS.height == 0)
			{
				return false;
			}
			double num = 1.0;
			IntPtr intPtr = UusL1BGewe(hWnd);
			if (intPtr != IntPtr.Zero)
			{
				double scalingFactor = SevLK8cKLT.GetMonitorInformation(intPtr).scalingFactor;
				double scalingFactor2 = SevLK8cKLT.GetMonitorInformation(IntPtr.Zero).scalingFactor;
				num = scalingFactor / scalingFactor2;
			}
			if ((double)sX5yqVmkWqZQKeT9UhS.XD7vPLOJ5hE * num <= x && x <= (double)sX5yqVmkWqZQKeT9UhS.DhUvPSLdZXQ * num)
			{
				if (K2CqIvpXao2SgbglE1s == null)
				{
					switch (0)
					{
					}
				}
				if ((double)sX5yqVmkWqZQKeT9UhS.wTivPvfjMFS * num <= y && y < (double)sX5yqVmkWqZQKeT9UhS.dPwvP2kZV1u * num)
				{
					return true;
				}
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	protected bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam)
	{
		try
		{
			int id = Process.GetCurrentProcess().Id;
			int num = 0;
			if (K2CqIvpXao2SgbglE1s != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				OO77uFW4jgnwuPwqBc.zwWtn6n1Bo(hWnd, out var uint_);
				if (uint_ != id && ASNLmhnn8L(hWnd))
				{
					CkwLxeVC6q.Add(hWnd);
					int value = P4oLXRccH2(hWnd);
					if (!JSSLrSsxg9.ContainsKey(hWnd))
					{
						JSSLrSsxg9.Add(hWnd, value);
					}
				}
				return true;
			}
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void mTGL6x7w6A()
	{
		try
		{
			OO77uFW4jgnwuPwqBc.HTKt0aXUCH(EnumWindowsProc, IntPtr.Zero);
		}
		catch (Exception)
		{
		}
	}

	private int P4oLXRccH2(IntPtr intptr_0)
	{
		int num = 0;
		IntPtr intPtr = intptr_0;
		while (intPtr != IntPtr.Zero)
		{
			num++;
			intPtr = OO77uFW4jgnwuPwqBc.cEgtj7g8PZ(intPtr, 3);
		}
		return num;
	}

	private bool ASNLmhnn8L(IntPtr intptr_0)
	{
		if (OO77uFW4jgnwuPwqBc.WJDtQQLbdw(intptr_0) && (OO77uFW4jgnwuPwqBc.uDbtxeaINX(intptr_0, -20) & 0x20) != 32)
		{
			return true;
		}
		return false;
	}

	internal static bool wCgZ03p2NVWOw7YYb1k()
	{
		return K2CqIvpXao2SgbglE1s == null;
	}
}
