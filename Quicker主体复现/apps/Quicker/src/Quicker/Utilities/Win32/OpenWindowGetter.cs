using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using PInvoke;

namespace Quicker.Utilities.Win32;

public static class OpenWindowGetter
{
	private delegate bool koYQ1sD1Nc41Od6v3Me(IntPtr hWnd, int lParam);

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public IntPtr YBS22axyqWR;

		public bool Y3A227eEhb5;

		public bool b1Y22RXtixH;

		public Dictionary<IntPtr, string> ik722qltHVj;

		internal static _003C_003Ec__DisplayClass0_0 ITPy0TyGLcPg03MbWf8S;

		internal bool yN0228WYim9(IntPtr hWnd, int lParam)
		{
			if (hWnd == YBS22axyqWR)
			{
				return true;
			}
			if (Y3A227eEhb5 && !IsWindowVisible(hWnd))
			{
				return true;
			}
			int windowTextLength = NativeMethods.GetWindowTextLength(hWnd);
			string empty = string.Empty;
			if (windowTextLength == 0)
			{
				if (b1Y22RXtixH)
				{
					return true;
				}
				empty = string.Empty;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder(windowTextLength);
				int num = 0;
				if (!QPCtoRyGuvSGrd5iCF2o())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				NativeMethods.GetWindowText(hWnd, stringBuilder, windowTextLength + 1);
				empty = stringBuilder.ToString();
			}
			ik722qltHVj[hWnd] = empty;
			return true;
		}

		internal static bool QPCtoRyGuvSGrd5iCF2o()
		{
			return ITPy0TyGLcPg03MbWf8S == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public IntPtr zK722Vjyb3g;

		public string KvK22Z1V2OR;

		public StringComparison XYn229GuM1i;

		public IList<IntPtr> Gvu22hF2CuN;

		private static _003C_003Ec__DisplayClass1_0 cV8dJByGfxCo1RDVe4MY;

		internal bool Bq122ch3NmR(IntPtr hWnd, int lParam)
		{
			if (hWnd == zK722Vjyb3g)
			{
				return true;
			}
			if (!IsWindowVisible(hWnd))
			{
				return true;
			}
			string windowClass = NativeMethods.GetWindowClass(hWnd);
			if (string.Equals(KvK22Z1V2OR, windowClass, XYn229GuM1i))
			{
				Gvu22hF2CuN.Add(hWnd);
			}
			return true;
		}

		internal static bool odmZ48yGbFs3CwbwEswD()
		{
			return cV8dJByGfxCo1RDVe4MY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public Dictionary<IntPtr, string> ssZ22YR8ccB;

		internal static _003C_003Ec__DisplayClass2_0 XMR01kyGiouX9a3Y5ySY;

		internal bool zcp22eKhpFy(IntPtr hWnd, int lParam)
		{
			if (!IsWindowVisible(hWnd))
			{
				return true;
			}
			int windowTextLength = NativeMethods.GetWindowTextLength(hWnd);
			if (windowTextLength == 0)
			{
				ssZ22YR8ccB[hWnd] = "";
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder(windowTextLength);
				NativeMethods.GetWindowText(hWnd, stringBuilder, windowTextLength + 1);
				ssZ22YR8ccB[hWnd] = stringBuilder.ToString();
			}
			return true;
		}

		internal static bool oXoEhhyGl6ppSngxgIe3()
		{
			return XMR01kyGiouX9a3Y5ySY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string LgU22WMLPux;

		public string yfn22kKhGFr;

		public IntPtr nCK22G6ZDyu;

		private static _003C_003Ec__DisplayClass3_0 FP03WxyG5y1b0xv6aktF;

		internal bool xgi22IdBIn1(IntPtr hWnd, int lParam)
		{
			if (!WindowHelper.HP9LFBj7trn(hWnd, LgU22WMLPux, yfn22kKhGFr, null, false))
			{
				return true;
			}
			nCK22G6ZDyu = hWnd;
			return false;
		}

		internal static bool Ye2bjwyGYlnuBQIhQZQt()
		{
			return FP03WxyG5y1b0xv6aktF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public string HBA22Hb64ri;

		public string Beu2211fwVc;

		public bool WyH22bK0OTG;

		public Dictionary<IntPtr, string> mQQ226U3QKb;

		internal static _003C_003Ec__DisplayClass4_0 p9jWgayGRBwHeBHFPOOe;

		internal bool Ejy22sV0ktI(IntPtr hWnd, int lParam)
		{
			if (WindowHelper.HP9LFBj7trn(hWnd, HBA22Hb64ri, Beu2211fwVc, null, WyH22bK0OTG))
			{
				int windowTextLength = NativeMethods.GetWindowTextLength(hWnd);
				string empty = string.Empty;
				if (windowTextLength == 0)
				{
					empty = string.Empty;
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder(windowTextLength);
					NativeMethods.GetWindowText(hWnd, stringBuilder, windowTextLength + 1);
					empty = stringBuilder.ToString();
				}
				mQQ226U3QKb[hWnd] = empty;
				int num = 0;
				if (!wandPGyGgK9hw1yEIOTw())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return true;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}

		internal static bool wandPGyGgK9hw1yEIOTw()
		{
			return p9jWgayGRBwHeBHFPOOe == null;
		}

		internal static void i5fkmDyGMdBJRToT8tIX()
		{
		}
	}

	private static object eRf2ArFUphMHkfRaHCLa;

	public static IDictionary<IntPtr, string> GetOpenWindows(bool onlyVisible, bool requireTitle = true)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.Y3A227eEhb5 = onlyVisible;
		_003C_003Ec__DisplayClass0_.b1Y22RXtixH = requireTitle;
		_003C_003Ec__DisplayClass0_.YBS22axyqWR = axOLFiUoMLj();
		_003C_003Ec__DisplayClass0_.ik722qltHVj = new Dictionary<IntPtr, string>();
		oZxLFlj8TSr(_003C_003Ec__DisplayClass0_.yN0228WYim9, 0);
		return _003C_003Ec__DisplayClass0_.ik722qltHVj;
	}

	public static IList<IntPtr> FindAllWindowsWithClassName(string className, StringComparison comparison)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.KvK22Z1V2OR = className;
		_003C_003Ec__DisplayClass1_.XYn229GuM1i = comparison;
		_003C_003Ec__DisplayClass1_.zK722Vjyb3g = axOLFiUoMLj();
		_003C_003Ec__DisplayClass1_.Gvu22hF2CuN = new List<IntPtr>();
		oZxLFlj8TSr(_003C_003Ec__DisplayClass1_.Bq122ch3NmR, 0);
		return _003C_003Ec__DisplayClass1_.Gvu22hF2CuN;
	}

	public static IDictionary<IntPtr, string> GetAllChildHandles(IntPtr parentHandle)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.ssZ22YR8ccB = new Dictionary<IntPtr, string>();
		P8kLF3SY57Z(parentHandle, _003C_003Ec__DisplayClass2_.zcp22eKhpFy, IntPtr.Zero);
		return _003C_003Ec__DisplayClass2_.ssZ22YR8ccB;
	}

	public static IntPtr FindChildWindow(IntPtr parentHandle, string className, string windowName)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.LgU22WMLPux = className;
		_003C_003Ec__DisplayClass3_.yfn22kKhGFr = windowName;
		_003C_003Ec__DisplayClass3_.nCK22G6ZDyu = User32.FindWindowEx(parentHandle, IntPtr.Zero, _003C_003Ec__DisplayClass3_.LgU22WMLPux, _003C_003Ec__DisplayClass3_.yfn22kKhGFr);
		if (_003C_003Ec__DisplayClass3_.nCK22G6ZDyu != IntPtr.Zero)
		{
			return _003C_003Ec__DisplayClass3_.nCK22G6ZDyu;
		}
		P8kLF3SY57Z(parentHandle, _003C_003Ec__DisplayClass3_.xgi22IdBIn1, IntPtr.Zero);
		return _003C_003Ec__DisplayClass3_.nCK22G6ZDyu;
	}

	public static IDictionary<IntPtr, string> FindChildWindows(IntPtr parentHandle, string className, string windowName, bool useRegex)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.HBA22Hb64ri = className;
		_003C_003Ec__DisplayClass4_.Beu2211fwVc = windowName;
		_003C_003Ec__DisplayClass4_.WyH22bK0OTG = useRegex;
		User32.FindWindowEx(parentHandle, IntPtr.Zero, _003C_003Ec__DisplayClass4_.HBA22Hb64ri, _003C_003Ec__DisplayClass4_.Beu2211fwVc);
		_003C_003Ec__DisplayClass4_.mQQ226U3QKb = new Dictionary<IntPtr, string>();
		P8kLF3SY57Z(parentHandle, _003C_003Ec__DisplayClass4_.Ejy22sV0ktI, IntPtr.Zero);
		return _003C_003Ec__DisplayClass4_.mQQ226U3QKb;
	}

	[DllImport("user32.dll", EntryPoint = "EnumWindows")]
	private static extern bool oZxLFlj8TSr(koYQ1sD1Nc41Od6v3Me koYQ1sD1Nc41Od6v3Me_0, int int_0);

	[DllImport("user32.dll")]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", EntryPoint = "GetShellWindow")]
	private static extern IntPtr axOLFiUoMLj();

	[DllImport("user32", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool P8kLF3SY57Z(IntPtr intptr_0, koYQ1sD1Nc41Od6v3Me koYQ1sD1Nc41Od6v3Me_0, IntPtr intptr_1);

	internal static bool RS30vfFUXObp7eiQ8BgA()
	{
		return eRf2ArFUphMHkfRaHCLa == null;
	}
}
