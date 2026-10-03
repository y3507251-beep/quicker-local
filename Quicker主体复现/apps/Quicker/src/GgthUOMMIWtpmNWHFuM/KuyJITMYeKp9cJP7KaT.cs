using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Forms;
using bcybYUMWiG3W9kCqUoJ;
using NXCXW6iSfVv0tXcxk0W;
using Quicker.Domain.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;

namespace GgthUOMMIWtpmNWHFuM;

internal class KuyJITMYeKp9cJP7KaT
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec QlBSz3sCcs9;

		public static Func<System.Drawing.Point, int> bm3Szfqioo6;

		public static Func<System.Drawing.Point, int> R28SzzAHHrT;

		public static Func<System.Drawing.Point, int> Xli2wwCslkh;

		public static Func<System.Drawing.Point, int> K8o2wtElkFp;

		internal static _003C_003Ec lspcgPyn9yJFkvm1kbr5;

		static _003C_003Ec()
		{
			QlBSz3sCcs9 = new _003C_003Ec();
		}

		internal int nYdSzFgx8GI(System.Drawing.Point pt)
		{
			return pt.Y;
		}

		internal int AQASzUVx2U6(System.Drawing.Point pt)
		{
			return pt.X;
		}

		internal int K2mSzljqHY1(System.Drawing.Point pt)
		{
			return pt.Y;
		}

		internal int KT2SzivwdEL(System.Drawing.Point pt)
		{
			return pt.X;
		}

		internal static bool FtGLXEynLOMkQFaI6g8f()
		{
			return lspcgPyn9yJFkvm1kbr5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public Bitmap GqJ2wLNcRKt;

		public BitmapData N7S2wvkJv07;

		public int Aa72wSqePN6;

		public int r3F2w2fNjqp;

		public int fRL2wu9VOug;

		public BitmapLocatePosition DUZ2wNhQu6T;

		public int N5G2wJxHElQ;

		public Color? Oyc2w03Tf0w;

		public ConcurrentBag<System.Drawing.Point> Dqb2wCUxXrx;

		internal static _003C_003Ec__DisplayClass0_0 QyycYBynollKC5wuT4Qb;

		internal void cU92wgu1oGp(Screen screen)
		{
			foreach (System.Drawing.Point item in QotLoKF2FSs(GqJ2wLNcRKt, N7S2wvkJv07, Aa72wSqePN6, r3F2w2fNjqp, fRL2wu9VOug, DUZ2wNhQu6T, N5G2wJxHElQ, screen.Bounds, Oyc2w03Tf0w))
			{
				Dqb2wCUxXrx.Add(item);
			}
		}

		internal static bool iNwLWpynfDpCETR4L63Y()
		{
			return QyycYBynollKC5wuT4Qb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public Color osH2wEL6jPk;

		public int aGs2wyM769f;

		public BitmapData cmX2w8MJN0l;

		public bool Lw52wagb3WN;

		public System.Drawing.Point? z5e2w7WTRpU;

		public int RBF2wRYuMe9;

		internal static _003C_003Ec__DisplayClass2_0 SxBhfpynq5cbFOor0LCT;

		internal void geT2wPOxysl(int row)
		{
			for (int i = 0; i < RBF2wRYuMe9; i++)
			{
				if (Lw52wagb3WN)
				{
					break;
				}
				if (j3SLorLiIrg(cmX2w8MJN0l, i, row, osH2wEL6jPk, aGs2wyM769f))
				{
					Lw52wagb3WN = true;
					z5e2w7WTRpU = new System.Drawing.Point(i, row);
				}
			}
		}

		internal static bool zAbQQDyni5KL2kIf94L3()
		{
			return SxBhfpynq5cbFOor0LCT == null;
		}
	}

	internal static KuyJITMYeKp9cJP7KaT EDa7lKF54A7Ntdu8PHR8;

	internal static IList<System.Drawing.Point> IfmLomYdH25(Bitmap bitmap_0, int int_0, int int_1, maP9bQMwejOq3FEOUur maP9bQMwejOq3FEOUur_0, Rectangle rectangle_0, ActionExecuteContext actionExecuteContext_0, int int_2, BitmapLocatePosition bitmapLocatePosition_0, int int_3, bool bool_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.GqJ2wLNcRKt = bitmap_0;
		_003C_003Ec__DisplayClass0_.Aa72wSqePN6 = int_0;
		_003C_003Ec__DisplayClass0_.r3F2w2fNjqp = int_1;
		_003C_003Ec__DisplayClass0_.fRL2wu9VOug = int_2;
		_003C_003Ec__DisplayClass0_.DUZ2wNhQu6T = bitmapLocatePosition_0;
		_003C_003Ec__DisplayClass0_.N5G2wJxHElQ = int_3;
		_003C_003Ec__DisplayClass0_.Oyc2w03Tf0w = null;
		if (bool_0)
		{
			int num = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.GetPixel(0, 0).ToArgb();
			int num2 = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.GetPixel(_003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Width - 1, 0).ToArgb();
			int num3 = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.GetPixel(0, _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Height - 1).ToArgb();
			int num4 = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.GetPixel(_003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Width - 1, _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Height - 1).ToArgb();
			if (num == num2 && num == num3 && num == num4)
			{
				_003C_003Ec__DisplayClass0_.Oyc2w03Tf0w = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.GetPixel(0, 0);
			}
		}
		_003C_003Ec__DisplayClass0_.N7S2wvkJv07 = _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.LockBits(new Rectangle(0, 0, _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Width, _003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
		try
		{
			if (maP9bQMwejOq3FEOUur_0 == maP9bQMwejOq3FEOUur.AllScreens)
			{
				if (Screen.AllScreens.Length > 1)
				{
					_003C_003Ec__DisplayClass0_.Dqb2wCUxXrx = new ConcurrentBag<System.Drawing.Point>();
					Parallel.ForEach(Screen.AllScreens, _003C_003Ec__DisplayClass0_.cU92wgu1oGp);
					return _003C_003Ec__DisplayClass0_.Dqb2wCUxXrx.OrderBy(_003C_003Ec.bm3Szfqioo6 ?? (_003C_003Ec.bm3Szfqioo6 = _003C_003Ec.QlBSz3sCcs9.nYdSzFgx8GI)).ThenBy(_003C_003Ec.R28SzzAHHrT ?? (_003C_003Ec.R28SzzAHHrT = _003C_003Ec.QlBSz3sCcs9.AQASzUVx2U6)).ToList();
				}
				maP9bQMwejOq3FEOUur_0 = maP9bQMwejOq3FEOUur.MainScreen;
			}
			Rectangle rectangle_1 = Screen.PrimaryScreen.Bounds;
			switch (maP9bQMwejOq3FEOUur_0)
			{
			case maP9bQMwejOq3FEOUur.CurrentWindow:
			{
				IntPtr intPtr = actionExecuteContext_0.ActiveWindowHwnd;
				if (intPtr == IntPtr.Zero)
				{
					intPtr = NativeMethods.GetForegroundWindow();
				}
				NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
				rectangle_1 = new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top);
				break;
			}
			case maP9bQMwejOq3FEOUur.Rect:
				rectangle_1 = rectangle_0;
				break;
			default:
				throw new InvalidOperationException("不支持的目标类型：" + maP9bQMwejOq3FEOUur_0);
			case maP9bQMwejOq3FEOUur.MainScreen:
				break;
			}
			return QotLoKF2FSs(_003C_003Ec__DisplayClass0_.GqJ2wLNcRKt, _003C_003Ec__DisplayClass0_.N7S2wvkJv07, _003C_003Ec__DisplayClass0_.Aa72wSqePN6, _003C_003Ec__DisplayClass0_.r3F2w2fNjqp, _003C_003Ec__DisplayClass0_.fRL2wu9VOug, _003C_003Ec__DisplayClass0_.DUZ2wNhQu6T, _003C_003Ec__DisplayClass0_.N5G2wJxHElQ, rectangle_1, _003C_003Ec__DisplayClass0_.Oyc2w03Tf0w);
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			_003C_003Ec__DisplayClass0_.GqJ2wLNcRKt.UnlockBits(_003C_003Ec__DisplayClass0_.N7S2wvkJv07);
		}
	}

	private static IList<System.Drawing.Point> QotLoKF2FSs(Bitmap bitmap_0, BitmapData bitmapData_0, int int_0, int int_1, int int_2, BitmapLocatePosition bitmapLocatePosition_0, int int_3, Rectangle rectangle_0, Color? nullable_0)
	{
		using Bitmap bitmap_1 = BmpFinder.CopyScreen(rectangle_0);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Reset();
		stopwatch.Start();
		List<System.Drawing.Point> list = mTI4V9iTopuHI3vw93A.s4PvNH5FhDY(bitmap_1, bitmap_0, bitmapData_0, int_2, int_3, nullable_0);
		stopwatch.Stop();
		if (list.Count == 0)
		{
			return list;
		}
		List<System.Drawing.Point> list2 = new List<System.Drawing.Point>();
		for (int i = 0; i < list.Count && i < int_3; i++)
		{
			System.Drawing.Point item = list[i];
			item.X = item.X + rectangle_0.X + int_0;
			item.Y = item.Y + rectangle_0.Y + int_1;
			switch (bitmapLocatePosition_0)
			{
			case BitmapLocatePosition.Center:
				item.X += bitmap_0.Width / 2;
				item.Y += bitmap_0.Height / 2;
				break;
			case BitmapLocatePosition.TopRight:
				item.X += bitmap_0.Width;
				break;
			case BitmapLocatePosition.BottomLeft:
				item.Y += bitmap_0.Height;
				break;
			case BitmapLocatePosition.BottomRight:
				item.X += bitmap_0.Width;
				item.Y += bitmap_0.Height;
				break;
			}
			list2.Add(item);
		}
		return list2.OrderBy(_003C_003Ec.Xli2wwCslkh ?? (_003C_003Ec.Xli2wwCslkh = _003C_003Ec.QlBSz3sCcs9.K2mSzljqHY1)).ThenBy(_003C_003Ec.K8o2wtElkFp ?? (_003C_003Ec.K8o2wtElkFp = _003C_003Ec.QlBSz3sCcs9.KT2SzivwdEL)).ToList();
	}

	internal static System.Drawing.Point? QoZLox88Dnk(Color color_0, maP9bQMwejOq3FEOUur maP9bQMwejOq3FEOUur_0, Rectangle rectangle_0, ActionExecuteContext actionExecuteContext_0, int int_0, int int_1, int int_2)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.osH2wEL6jPk = color_0;
		_003C_003Ec__DisplayClass2_.aGs2wyM769f = int_0;
		if (maP9bQMwejOq3FEOUur_0 == maP9bQMwejOq3FEOUur.AllScreens)
		{
			Screen[] allScreens = Screen.AllScreens;
			int num = 0;
			System.Drawing.Point? result;
			while (true)
			{
				if (num < allScreens.Length)
				{
					Screen screen = allScreens[num];
					result = QoZLox88Dnk(_003C_003Ec__DisplayClass2_.osH2wEL6jPk, maP9bQMwejOq3FEOUur.Rect, screen.Bounds, actionExecuteContext_0, _003C_003Ec__DisplayClass2_.aGs2wyM769f, int_1, int_2);
					if (result.HasValue)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return result;
		}
		Rectangle rect = Screen.PrimaryScreen.Bounds;
		switch (maP9bQMwejOq3FEOUur_0)
		{
		case maP9bQMwejOq3FEOUur.CurrentWindow:
		{
			IntPtr intPtr = actionExecuteContext_0.ActiveWindowHwnd;
			if (intPtr == IntPtr.Zero)
			{
				intPtr = NativeMethods.GetForegroundWindow();
			}
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
			rect = new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top);
			break;
		}
		case maP9bQMwejOq3FEOUur.Rect:
			rect = rectangle_0;
			break;
		}
		using Bitmap bitmap = BmpFinder.CopyScreen(rect);
		_003C_003Ec__DisplayClass2_.cmX2w8MJN0l = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
		try
		{
			_003C_003Ec__DisplayClass2_.Lw52wagb3WN = false;
			_003C_003Ec__DisplayClass2_.z5e2w7WTRpU = null;
			_003C_003Ec__DisplayClass2_.RBF2wRYuMe9 = bitmap.Width;
			int height = rect.Height;
			Parallel.For(0, height, _003C_003Ec__DisplayClass2_.geT2wPOxysl);
			if (_003C_003Ec__DisplayClass2_.z5e2w7WTRpU.HasValue)
			{
				return new System.Drawing.Point(_003C_003Ec__DisplayClass2_.z5e2w7WTRpU.Value.X + rect.Left + int_1, _003C_003Ec__DisplayClass2_.z5e2w7WTRpU.Value.Y + rect.Top + int_2);
			}
			return null;
		}
		finally
		{
			bitmap.UnlockBits(_003C_003Ec__DisplayClass2_.cmX2w8MJN0l);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool j3SLorLiIrg(BitmapData bitmapData_0, int int_0, int int_1, Color color_0, int int_2)
	{
		byte* ptr = (byte*)(void*)(bitmapData_0.Scan0 + bitmapData_0.Stride * int_1 + int_0 * 3);
		if (int_2 == 0)
		{
			if (*ptr == color_0.B && ptr[1] == color_0.G)
			{
				return ptr[2] == color_0.R;
			}
			return false;
		}
		if (*ptr >= color_0.B - int_2 && *ptr <= color_0.B + int_2 && ptr[1] >= color_0.G - int_2 && ptr[1] <= color_0.G + int_2)
		{
			if (ptr[2] >= color_0.R - int_2)
			{
				if (EDa7lKF54A7Ntdu8PHR8 == null)
				{
					switch (0)
					{
					}
				}
				return ptr[2] <= color_0.R + int_2;
			}
			return false;
		}
		return false;
	}

	private static System.Drawing.Point? SeHLop7h3Iy(Rectangle rectangle_0, string string_0)
	{
		AutomationElement automationElement = null;
		IList<AutomationElement> list = new List<AutomationElement>();
		for (int i = rectangle_0.Top + 5; i < rectangle_0.Bottom; i += 15)
		{
			for (int j = rectangle_0.Left; j < rectangle_0.Right; j += 20)
			{
				AutomationElement automationElement2 = AutomationElement.FromPoint(new System.Windows.Point(j, i));
				if (automationElement2 != null)
				{
					if (automationElement != automationElement2 && !list.Contains(automationElement2) && DoELoBw9MHC(automationElement2).IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						return new System.Drawing.Point((int)(automationElement2.Current.BoundingRectangle.Left + automationElement2.Current.BoundingRectangle.Width / 2.0), (int)(automationElement2.Current.BoundingRectangle.Top + automationElement2.Current.BoundingRectangle.Height / 2.0));
					}
					list.Add(automationElement2);
					automationElement = automationElement2;
				}
			}
		}
		return null;
	}

	[CompilerGenerated]
	internal static string DoELoBw9MHC(AutomationElement automationElement_0)
	{
		if (automationElement_0.TryGetCurrentPattern(ValuePattern.Pattern, out var patternObject))
		{
			return ((ValuePattern)patternObject).Current.Value;
		}
		if (automationElement_0.TryGetCurrentPattern(TextPattern.Pattern, out patternObject))
		{
			return ((TextPattern)patternObject).DocumentRange.GetText(-1).TrimEnd('\r');
		}
		return automationElement_0.Current.Name;
	}

	internal static bool mQAm1lF5hTp2EBecL12L()
	{
		return EDa7lKF54A7Ntdu8PHR8 == null;
	}
}
