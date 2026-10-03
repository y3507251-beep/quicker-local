using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM7uO15TjrhU8SKJpZU;
using MTvu7H59xFIE4dJJH9K;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using Quicker.ScreenSelectLib.Tools;
using Quicker.Utilities;
using tnhyg357Ch4jKrVvHlZ;
using WindowsInput.Native;
using zfrwyH5n8fOaq0LjOSZ;

namespace w9WmeW5KF9OKbQcdqve;

internal class eeqm7S5SjgeJhryNF6g : SbsWDA50sjcoRjOpZZB
{
	private enum JLdL0Ju9jQu3cyv7tfT
	{

	}

	[Flags]
	private enum BpTPnjuPUJ9ACPjGYW5
	{
		Center = 0,
		Left = 1,
		Top = 2,
		Right = 4,
		Bottom = 8
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public eeqm7S5SjgeJhryNF6g YkXvcRP6tfw;

		public IntPtr g0FvcqirM3Q;

		internal static _003C_003Ec__DisplayClass17_0 G73LMfcrZelhWuEKvV2t;

		internal void NrDvc77JPqK()
		{
			YkXvcRP6tfw.H9spDNd1Hr = new wB6Dmm5N492vi1ojMYh(new ScreenProperties(), g0FvcqirM3Q);
			YkXvcRP6tfw.pGGp56kWXL = true;
			YkXvcRP6tfw.ui1pxUm29r();
			if (CiXO6Tcr5LAwyOfQjB2I())
			{
				switch (0)
				{
				}
			}
			SelectOptions wEhpQTFX1U = YkXvcRP6tfw.wEhpQTFX1U;
			if (wEhpQTFX1U != null && wEhpQTFX1U.PreSelectArea.HasValue)
			{
				YkXvcRP6tfw.wE4pMkhQ5t = YkXvcRP6tfw.wEhpQTFX1U.PreSelectArea.Value;
				YkXvcRP6tfw.dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)2;
				YkXvcRP6tfw.LGCpWHkk5A();
			}
		}

		internal static bool CiXO6Tcr5LAwyOfQjB2I()
		{
			return G73LMfcrZelhWuEKvV2t == null;
		}
	}

	private readonly SelectOptions wEhpQTFX1U;

	private BpTPnjuPUJ9ACPjGYW5 qMfpjgD9HU;

	private JLdL0Ju9jQu3cyv7tfT dSZpnnymNV;

	private bool wIap4Ck7ED;

	private bool pGGp56kWXL;

	private wB6Dmm5N492vi1ojMYh H9spDNd1Hr;

	private Point MsBpdRfbqe = Point.Empty;

	private long iG9poJgBj2;

	private Point uSMpTGVsMW = Point.Empty;

	private Rectangle wE4pMkhQ5t = Rectangle.Empty;

	private Size DywpAjDZuw;

	private bool a70pOwGX0w;

	private Timer g59pFaWcZy;

	private IntPtr IeJpULwtdv = IntPtr.Zero;

	private IntPtr j6Kpl0XZEu = IntPtr.Zero;

	private Rectangle lE4pilIDxr;

	private bool cMEp3mxTtj;

	private static eeqm7S5SjgeJhryNF6g K98KNx6qXFMMiTetFQG;

	public eeqm7S5SjgeJhryNF6g(N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G_1, SelectOptions selectOptions_1)
		: base(n4PkhP56DLuHvaMdN6G_1)
	{
		wEhpQTFX1U = selectOptions_1;
		wIap4Ck7ED = selectOptions_1?.IncludeWindowInvisibleBorder ?? false;
		g59pFaWcZy = new Timer();
		g59pFaWcZy.Interval = 1000;
		g59pFaWcZy.Tick += FFMpYuThSv;
	}

	private void FFMpYuThSv(object sender, EventArgs e)
	{
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)1)
		{
			LGCpWHkk5A();
			g59pFaWcZy.Stop();
		}
	}

	public override void N0cM2dogpyW()
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.YkXvcRP6tfw = this;
		base.N0cM2dogpyW();
		CQgp9GGtfu().Wq5K2KW8C6(true);
		CQgp9GGtfu().CMwKJLIHpv(true);
		CQgp9GGtfu().labm3Eaj95();
		CQgp9GGtfu().BghKPk4k25(AreaHighlightMode.SpotLight);
		CQgp9GGtfu().U3xK82V7oy(3);
		CQgp9GGtfu().r5pKRCm9ZH(false);
		_003C_003Ec__DisplayClass17_.g0FvcqirM3Q = CQgp9GGtfu().Handle;
		Task.Run((Action)_003C_003Ec__DisplayClass17_.NrDvc77JPqK);
	}

	public override bool OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (keyEventArgs_0.KeyCode == Keys.Return || keyEventArgs_0.KeyCode == Keys.Space)
		{
			wcipBA8fEJ();
		}
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)2 && !YkApmmB3a9(MouseButtons.Left))
		{
			switch (keyEventArgs_0.KeyCode)
			{
			case Keys.Left:
			case Keys.S:
				dNSpKcjVI9(-1, 0);
				return true;
			case Keys.Up:
			case Keys.E:
			{
				dNSpKcjVI9(0, -1);
				int num = 0;
				if (!fOcqrV6ig94Zt5MCitt())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => true, 
				};
			}
			case Keys.Right:
			case Keys.F:
				dNSpKcjVI9(1, 0);
				return true;
			case Keys.Down:
			case Keys.D:
				dNSpKcjVI9(0, 1);
				return true;
			}
		}
		return base.OnKeyDown(keyEventArgs_0);
	}

	private bool sZgpIqfJhU(MouseButtons mouseButtons_0)
	{
		if (mouseButtons_0 != MouseButtons.Middle && mouseButtons_0 != MouseButtons.XButton1)
		{
			return mouseButtons_0 == MouseButtons.XButton2;
		}
		return true;
	}

	public override bool OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		int num;
		if (mouseEventArgs_0.Button == MouseButtons.Right && dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)0)
		{
			MsBpdRfbqe = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
			dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)1;
			cMEp3mxTtj = true;
			num = 0;
			if (!fOcqrV6ig94Zt5MCitt())
			{
				goto IL_00e2;
			}
			goto IL_00ef;
		}
		if (sZgpIqfJhU(mouseEventArgs_0.Button))
		{
			LGCpWHkk5A();
			if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)0)
			{
				MsBpdRfbqe = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
				dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)1;
				cMEp3mxTtj = true;
			}
			return false;
		}
		if (mouseEventArgs_0.Button != MouseButtons.Left)
		{
			return false;
		}
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)0)
		{
			MsBpdRfbqe = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
			dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)1;
			iG9poJgBj2 = AppHelper.fLiLTj0x4QY();
			CQgp9GGtfu().O6nKYsFp2q("点中/侧键调整选区");
			if (!a70pOwGX0w)
			{
				g59pFaWcZy.Start();
				num = 1;
				if (K98KNx6qXFMMiTetFQG != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00e2;
			}
		}
		else if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)2)
		{
			JaopGkSLEo();
		}
		goto IL_0106;
		IL_00ef:
		LGCpWHkk5A();
		return true;
		IL_0106:
		return false;
		IL_00e2:
		switch (num)
		{
		case 1:
			goto IL_0106;
		}
		goto IL_00ef;
	}

	private void LGCpWHkk5A()
	{
		a70pOwGX0w = true;
		CQgp9GGtfu().r5pKRCm9ZH(true);
		xtvpbboSlb();
	}

	private Point TplpkfZMDu(Point point_1)
	{
		int num = point_1.X - MsBpdRfbqe.X;
		int num2 = point_1.Y - MsBpdRfbqe.Y;
		int num3 = 0;
		if (K98KNx6qXFMMiTetFQG != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
		{
			int num5 = Math.Max(Math.Abs(num), Math.Abs(num2));
			num = ((num > 0) ? 1 : (-1)) * num5;
			num2 = ((num2 > 0) ? 1 : (-1)) * num5;
			return new Point(MsBpdRfbqe.X + num, MsBpdRfbqe.Y + num2);
		}
		}
	}

	public override bool OnMouseMove(MouseEventArgs mouseEventArgs_0)
	{
		int num;
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)0)
		{
			ui1pxUm29r();
			CQgp9GGtfu().O6nKYsFp2q("左键:选取\n长按:选取并调整");
		}
		else if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)1)
		{
			CQgp9GGtfu().PointToScreen(mouseEventArgs_0.Location);
			if (AppHelper.fLiLTj0x4QY() > iG9poJgBj2 + 100L)
			{
				if (KeyboardHelper.IsKeyDown(VirtualKeyCode.SHIFT))
				{
					num = 1;
					if (!fOcqrV6ig94Zt5MCitt())
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_00d6;
				}
				uSMpTGVsMW = CQgp9GGtfu().PointToScreen(mouseEventArgs_0.Location);
				goto IL_008e;
			}
		}
		else if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)2)
		{
			if (!YkApmmB3a9(MouseButtons.Left))
			{
				ihfpXPtluN();
			}
			else
			{
				nKFpHyoKdj();
			}
		}
		goto IL_013d;
		IL_008e:
		wE4pMkhQ5t = Udep6V7vkm(MsBpdRfbqe, uSMpTGVsMW);
		num = 0;
		if (fOcqrV6ig94Zt5MCitt())
		{
			goto IL_00d6;
		}
		goto IL_00e6;
		IL_00d6:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00e6;
		}
		Point point_ = CQgp9GGtfu().PointToScreen(mouseEventArgs_0.Location);
		uSMpTGVsMW = TplpkfZMDu(point_);
		goto IL_008e;
		IL_00e6:
		xtvpbboSlb();
		g59pFaWcZy.Stop();
		if (!a70pOwGX0w && !CQgp9GGtfu().lBnK1aivO8())
		{
			g59pFaWcZy.Start();
		}
		goto IL_013d;
		IL_013d:
		return false;
	}

	public override bool OnMouseUp(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button == MouseButtons.Right)
		{
			if (MsBpdRfbqe == lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov())
			{
				CQgp9GGtfu().Cancel();
				return true;
			}
			dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)2;
			CQgp9GGtfu().O6nKYsFp2q("双击左键确认选区");
			return true;
		}
		if (mouseEventArgs_0.Button == MouseButtons.Left && dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)1)
		{
			if (a70pOwGX0w)
			{
				dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)2;
				CQgp9GGtfu().O6nKYsFp2q("双击左键确认选区");
				return true;
			}
			wcipBA8fEJ();
			return true;
		}
		if (sZgpIqfJhU(mouseEventArgs_0.Button) && cMEp3mxTtj)
		{
			lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
			dSZpnnymNV = (JLdL0Ju9jQu3cyv7tfT)2;
			int num = 0;
			if (K98KNx6qXFMMiTetFQG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => true, 
			};
		}
		return false;
	}

	public override bool OnMouseWheel(MouseEventArgs mouseEventArgs_0)
	{
		int num;
		int num2;
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)2)
		{
			num = ((mouseEventArgs_0.Delta > 0) ? 1 : (-1));
			if (qMfpjgD9HU == BpTPnjuPUJ9ACPjGYW5.Center)
			{
				wE4pMkhQ5t.X -= num;
				wE4pMkhQ5t.Y -= num;
				wE4pMkhQ5t.Width += num * 2;
				num2 = 1;
				if (fOcqrV6ig94Zt5MCitt())
				{
					goto IL_015f;
				}
			}
			else
			{
				if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Left))
				{
					wE4pMkhQ5t.X -= num;
					wE4pMkhQ5t.Width += num;
				}
				if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Top))
				{
					wE4pMkhQ5t.Y -= num;
					wE4pMkhQ5t.Height += num;
				}
				if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Right))
				{
					wE4pMkhQ5t.Width += num;
				}
				if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Bottom))
				{
					wE4pMkhQ5t.Height += num;
					num2 = 0;
					if (!fOcqrV6ig94Zt5MCitt())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_015f;
				}
			}
			goto IL_0184;
		}
		goto IL_018a;
		IL_018a:
		return base.OnMouseWheel(mouseEventArgs_0);
		IL_015f:
		switch (num2)
		{
		case 1:
			wE4pMkhQ5t.Height += num * 2;
			break;
		}
		goto IL_0184;
		IL_0184:
		xtvpbboSlb();
		goto IL_018a;
	}

	public override bool OnMouseDoubleClick(MouseEventArgs mouseEventArgs_0)
	{
		if (dSZpnnymNV == (JLdL0Ju9jQu3cyv7tfT)2)
		{
			wcipBA8fEJ();
		}
		return base.OnMouseDoubleClick(mouseEventArgs_0);
	}

	public override void KSnM20EuG43()
	{
		g59pFaWcZy?.Stop();
		g59pFaWcZy = null;
	}

	private void JaopGkSLEo()
	{
		Point point = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
		lE4pilIDxr = wE4pMkhQ5t;
		MsBpdRfbqe = point;
		DywpAjDZuw = new Size(point.X - wE4pMkhQ5t.Left, point.Y - wE4pMkhQ5t.Top);
		if (qMfpjgD9HU != BpTPnjuPUJ9ACPjGYW5.Center)
		{
			Gesps5TDpk(point);
			xtvpbboSlb();
		}
	}

	private void Gesps5TDpk(Point point_1)
	{
		int num = 3;
		while (true)
		{
			if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Left))
			{
				num = 2;
				goto IL_0083;
			}
			goto IL_01ad;
			IL_00d8:
			int num2;
			switch (num2)
			{
			case 2:
				break;
			case 1:
				goto IL_01ad;
			case 3:
				continue;
			default:
				goto end_IL_01db;
			}
			goto IL_0083;
			IL_01ad:
			if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Top))
			{
				if (point_1.Y > lE4pilIDxr.Bottom)
				{
					wE4pMkhQ5t.Y = lE4pilIDxr.Bottom;
					wE4pMkhQ5t.Height = point_1.Y - lE4pilIDxr.Bottom;
				}
				else
				{
					wE4pMkhQ5t.Y = point_1.Y;
					wE4pMkhQ5t.Height = lE4pilIDxr.Bottom - point_1.Y;
				}
			}
			if (!qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Right))
			{
				break;
			}
			if (point_1.X >= lE4pilIDxr.Left)
			{
				wE4pMkhQ5t.X = lE4pilIDxr.X;
				wE4pMkhQ5t.Width = point_1.X - lE4pilIDxr.X;
				num2 = 0;
				if (K98KNx6qXFMMiTetFQG != null)
				{
					goto IL_00d4;
				}
				goto IL_00d8;
			}
			wE4pMkhQ5t.X = point_1.X;
			wE4pMkhQ5t.Width = point_1.X - lE4pilIDxr.X;
			break;
			IL_0083:
			if (point_1.X <= lE4pilIDxr.Right)
			{
				wE4pMkhQ5t.X = point_1.X;
				wE4pMkhQ5t.Width = lE4pilIDxr.Right - point_1.X;
				num2 = 1;
				if (K98KNx6qXFMMiTetFQG != null)
				{
					goto IL_00d4;
				}
				goto IL_00d8;
			}
			wE4pMkhQ5t.X = lE4pilIDxr.Right;
			wE4pMkhQ5t.Width = point_1.X - lE4pilIDxr.Right;
			goto IL_01ad;
			IL_00d4:
			num2 = num;
			goto IL_00d8;
			continue;
			end_IL_01db:
			break;
		}
		if (qMfpjgD9HU.HasFlag(BpTPnjuPUJ9ACPjGYW5.Bottom))
		{
			if (point_1.Y < lE4pilIDxr.Top)
			{
				wE4pMkhQ5t.Y = point_1.Y;
				wE4pMkhQ5t.Height = lE4pilIDxr.Y - point_1.Y;
			}
			else
			{
				wE4pMkhQ5t.Y = lE4pilIDxr.Y;
				wE4pMkhQ5t.Height = point_1.Y - lE4pilIDxr.Y;
			}
		}
	}

	private void nKFpHyoKdj()
	{
		Point point_ = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
		if (qMfpjgD9HU == BpTPnjuPUJ9ACPjGYW5.Center)
		{
			wE4pMkhQ5t.X = point_.X - DywpAjDZuw.Width;
			wE4pMkhQ5t.Y = point_.Y - DywpAjDZuw.Height;
		}
		else
		{
			Gesps5TDpk(point_);
			H8Mp12iSco(wE4pMkhQ5t);
			int num = 0;
			if (K98KNx6qXFMMiTetFQG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (wE4pMkhQ5t.Width < 0)
			{
				wE4pMkhQ5t.Width = -wE4pMkhQ5t.Width;
			}
		}
		xtvpbboSlb();
	}

	private void H8Mp12iSco(Rectangle rectangle_2)
	{
		if (rectangle_2.Left > rectangle_2.Right)
		{
			int right = rectangle_2.Right;
			int width = Math.Abs(rectangle_2.Width);
			rectangle_2.X = right;
			rectangle_2.Width = width;
		}
		if (rectangle_2.Top > rectangle_2.Bottom)
		{
			int bottom = rectangle_2.Bottom;
			int height = Math.Abs(rectangle_2.Height);
			rectangle_2.Y = bottom;
			int num = 0;
			if (!fOcqrV6ig94Zt5MCitt())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			rectangle_2.Height = height;
		}
	}

	private void xtvpbboSlb()
	{
		CQgp9GGtfu().amGKgGBeHh(wE4pMkhQ5t, string.Empty);
	}

	private static Rectangle Udep6V7vkm(Point point_1, Point point_2)
	{
		return new Rectangle(Math.Min(point_1.X, point_2.X), Math.Min(point_1.Y, point_2.Y), Math.Abs(point_1.X - point_2.X) + 1, Math.Abs(point_1.Y - point_2.Y) + 1);
	}

	private void ihfpXPtluN()
	{
		Point pt = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
		int num = 0;
		Cursor cursor = default(Cursor);
		while (true)
		{
			bool flag = wE4pMkhQ5t.Contains(pt);
			while (true)
			{
				if (wE4pMkhQ5t.Width > 40 && wE4pMkhQ5t.Height > 40)
				{
					if (!fOcqrV6ig94Zt5MCitt())
					{
						switch (1)
						{
						case 4:
							break;
						case 3:
							goto end_IL_0043;
						case 1:
							goto IL_0065;
						default:
							goto IL_00df;
						case 2:
							goto IL_01c8;
						}
						continue;
					}
					goto IL_0065;
				}
				goto IL_0084;
				IL_01c8:
				Cursor cursor_ = cursor;
				CQgp9GGtfu().CXBmfuANg6(cursor_);
				return;
				IL_00e3:
				int num2;
				BpTPnjuPUJ9ACPjGYW5 bpTPnjuPUJ9ACPjGYW = (BpTPnjuPUJ9ACPjGYW5)num2;
				BpTPnjuPUJ9ACPjGYW5 bpTPnjuPUJ9ACPjGYW2 = ((pt.Y <= wE4pMkhQ5t.Y + num) ? BpTPnjuPUJ9ACPjGYW5.Top : ((pt.Y >= wE4pMkhQ5t.Y + wE4pMkhQ5t.Height - num) ? BpTPnjuPUJ9ACPjGYW5.Bottom : BpTPnjuPUJ9ACPjGYW5.Center));
				qMfpjgD9HU = bpTPnjuPUJ9ACPjGYW | bpTPnjuPUJ9ACPjGYW2;
				CQgp9GGtfu().O6nKYsFp2q("滚轮 = 微调选区");
				goto IL_0141;
				IL_0141:
				cursor = qMfpjgD9HU switch
				{
					BpTPnjuPUJ9ACPjGYW5.Left => Cursors.SizeWE, 
					BpTPnjuPUJ9ACPjGYW5.Top => Cursors.SizeNS, 
					BpTPnjuPUJ9ACPjGYW5.Left | BpTPnjuPUJ9ACPjGYW5.Top => Cursors.SizeNWSE, 
					BpTPnjuPUJ9ACPjGYW5.Right => Cursors.SizeWE, 
					BpTPnjuPUJ9ACPjGYW5.Top | BpTPnjuPUJ9ACPjGYW5.Right => Cursors.SizeNESW, 
					BpTPnjuPUJ9ACPjGYW5.Bottom => Cursors.SizeNS, 
					BpTPnjuPUJ9ACPjGYW5.Left | BpTPnjuPUJ9ACPjGYW5.Bottom => Cursors.SizeNESW, 
					BpTPnjuPUJ9ACPjGYW5.Right | BpTPnjuPUJ9ACPjGYW5.Bottom => Cursors.SizeNWSE, 
					_ => Cursors.SizeAll, 
				};
				goto IL_01c8;
				IL_0065:
				num = 7;
				Rectangle rectangle = wE4pMkhQ5t;
				rectangle.Inflate(-7, -7);
				flag = rectangle.Contains(pt);
				goto IL_0084;
				IL_0084:
				if (flag)
				{
					qMfpjgD9HU = BpTPnjuPUJ9ACPjGYW5.Center;
					CQgp9GGtfu().O6nKYsFp2q("双击确认选区");
					goto IL_0141;
				}
				if (pt.X > wE4pMkhQ5t.X + num)
				{
					if (pt.X >= wE4pMkhQ5t.X + wE4pMkhQ5t.Width - num)
					{
						goto IL_00df;
					}
					num2 = 0;
				}
				else
				{
					num2 = 1;
				}
				goto IL_00e3;
				IL_00df:
				num2 = 4;
				goto IL_00e3;
				continue;
				end_IL_0043:
				break;
			}
		}
	}

	private bool YkApmmB3a9(MouseButtons mouseButtons_0)
	{
		return (Control.MouseButtons & mouseButtons_0) != 0;
	}

	private void dNSpKcjVI9(int int_0, int int_1)
	{
		wE4pMkhQ5t.Offset(int_0, int_1);
		xtvpbboSlb();
	}

	private void ui1pxUm29r()
	{
		if (pGGp56kWXL)
		{
			Point point = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
			IntPtr intPtr = H9spDNd1Hr.qamrz1CwQc(point.X, point.Y);
			if (intPtr != IeJpULwtdv)
			{
				IeJpULwtdv = intPtr;
				IntPtr intptr_ = intPtr;
				Hdppr77s8w(intptr_);
			}
		}
	}

	private void Hdppr77s8w(IntPtr intptr_2)
	{
		if (j6Kpl0XZEu == intptr_2)
		{
			return;
		}
		j6Kpl0XZEu = intptr_2;
		Rectangle rectangle;
		if (wIap4Ck7ED)
		{
			lTX1EJ5crAHPVuUbPH8.lYSxQ8pSV1(intptr_2, out var uqwBGEdQOmobi3k3BTZ_);
			rectangle = new Rectangle(uqwBGEdQOmobi3k3BTZ_.crGvqbYWVF6, uqwBGEdQOmobi3k3BTZ_.mP6vq6MOjic, uqwBGEdQOmobi3k3BTZ_.width, uqwBGEdQOmobi3k3BTZ_.height);
		}
		else
		{
			rectangle = lTX1EJ5crAHPVuUbPH8.rLgx4ZZ8Fh(intptr_2);
		}
		wE4pMkhQ5t = rectangle;
		xtvpbboSlb();
		if (K98KNx6qXFMMiTetFQG != null)
		{
			switch (0)
			{
			}
		}
	}

	private static IntPtr wihppkcpgY(IntPtr intptr_2, bool bool_4)
	{
		IntPtr intPtr = lTX1EJ5crAHPVuUbPH8.oKIr1vTS4o(intptr_2);
		if (intptr_2 != intPtr)
		{
			lTX1EJ5crAHPVuUbPH8.vAxrCyFr2m(intptr_2, out var uint_);
			lTX1EJ5crAHPVuUbPH8.vAxrCyFr2m(intPtr, out var uint_2);
			if (uint_2 == uint_ || !bool_4)
			{
				return intPtr;
			}
		}
		return intptr_2;
	}

	private void wcipBA8fEJ()
	{
		g59pFaWcZy?.Stop();
		g59pFaWcZy = null;
		qsQtMm5MtHtoYi1dcdV qsQtMm5MtHtoYi1dcdV = new qsQtMm5MtHtoYi1dcdV
		{
			IsSuccess = true
		};
		qsQtMm5MtHtoYi1dcdV.JKumqaGnfy(wE4pMkhQ5t);
		qsQtMm5MtHtoYi1dcdV.FAfmsObuGE(j6Kpl0XZEu);
		CQgp9GGtfu().zsvmz1FjZj(qsQtMm5MtHtoYi1dcdV, true);
	}

	internal static bool fOcqrV6ig94Zt5MCitt()
	{
		return K98KNx6qXFMMiTetFQG == null;
	}
}
