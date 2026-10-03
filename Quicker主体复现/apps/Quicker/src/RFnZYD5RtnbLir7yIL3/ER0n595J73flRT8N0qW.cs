using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM7uO15TjrhU8SKJpZU;
using MTvu7H59xFIE4dJJH9K;
using nVJdY15fbnHJJyC6ngN;
using Quicker.ScreenSelectLib;
using Quicker.ScreenSelectLib.Processors;
using Quicker.ScreenSelectLib.Tools;
using tnhyg357Ch4jKrVvHlZ;
using zfrwyH5n8fOaq0LjOSZ;

namespace RFnZYD5RtnbLir7yIL3;

internal class ER0n595J73flRT8N0qW : SbsWDA50sjcoRjOpZZB
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public List<IntPtr> Q8lvcVE2qaZ;

		internal static _003C_003Ec__DisplayClass15_0 LEHK1Icr8jHTXNeJuZSG;

		internal bool pYfvccdPZND(IntPtr hWnd, IntPtr lParam)
		{
			try
			{
				Q8lvcVE2qaZ.Add(hWnd);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		internal static bool FZVankcrR6k28DNAk7Qa()
		{
			return LEHK1Icr8jHTXNeJuZSG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ER0n595J73flRT8N0qW i45vc9hnYXU;

		public IntPtr Y6fvchbC3j2;

		internal static _003C_003Ec__DisplayClass5_0 G1PasjcrPMgYArI65mMv;

		internal void luBvcZYDeJN()
		{
			i45vc9hnYXU.rkXB25eyY4 = new wB6Dmm5N492vi1ojMYh(new ScreenProperties(), Y6fvchbC3j2);
			i45vc9hnYXU.zQXBS7ZBR4 = true;
			i45vc9hnYXU.r7rpf7DxwT();
		}

		internal static bool hFWNVUcrM9RUKTIQw5X5()
		{
			return G1PasjcrPMgYArI65mMv == null;
		}
	}

	private readonly WindowDetectLevel lLbBLXPHdY;

	private bool RPaBvH3jD2;

	private bool zQXBS7ZBR4;

	private wB6Dmm5N492vi1ojMYh rkXB25eyY4;

	private IntPtr fKiBuurGTf = IntPtr.Zero;

	private Rectangle eSnBNwTa8v = Rectangle.Empty;

	private IntPtr LwqBJ1t9YF = IntPtr.Zero;

	internal static ER0n595J73flRT8N0qW Mju9pG6w9AwSGVX2AMO;

	public ER0n595J73flRT8N0qW(N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G_1, SelectOptions selectOptions_0, WindowDetectLevel windowDetectLevel_1)
		: base(n4PkhP56DLuHvaMdN6G_1)
	{
		lLbBLXPHdY = windowDetectLevel_1;
		RPaBvH3jD2 = selectOptions_0?.IncludeWindowInvisibleBorder ?? false;
	}

	public override void N0cM2dogpyW()
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.i45vc9hnYXU = this;
		base.N0cM2dogpyW();
		CQgp9GGtfu().Wq5K2KW8C6(false);
		CQgp9GGtfu().CMwKJLIHpv(true);
		CQgp9GGtfu().CXBmfuANg6(Cursors.Hand);
		_003C_003Ec__DisplayClass5_.Y6fvchbC3j2 = CQgp9GGtfu().Handle;
		Task.Run((Action)_003C_003Ec__DisplayClass5_.luBvcZYDeJN);
	}

	public override bool OnMouseMove(MouseEventArgs mouseEventArgs_0)
	{
		r7rpf7DxwT();
		return false;
	}

	public override bool OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button == MouseButtons.Left)
		{
			JsuBglK89P();
		}
		return base.OnMouseDown(mouseEventArgs_0);
	}

	public override bool OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (keyEventArgs_0.KeyCode == Keys.Return || keyEventArgs_0.KeyCode == Keys.Space)
		{
			JsuBglK89P();
		}
		return base.OnKeyDown(keyEventArgs_0);
	}

	private void r7rpf7DxwT()
	{
		if (!zQXBS7ZBR4)
		{
			return;
		}
		Point point_ = lTX1EJ5crAHPVuUbPH8.jYMrbg80Ov();
		IntPtr intPtr = rkXB25eyY4.qamrz1CwQc(point_.X, point_.Y);
		IntPtr intptr_ = default(IntPtr);
		WindowDetectLevel windowDetectLevel = default(WindowDetectLevel);
		int num;
		if (intPtr != fKiBuurGTf)
		{
			fKiBuurGTf = intPtr;
			intptr_ = intPtr;
			windowDetectLevel = lLbBLXPHdY;
			num = 0;
			if (Mju9pG6w9AwSGVX2AMO != null)
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			if (lLbBLXPHdY != WindowDetectLevel.Control)
			{
				return;
			}
			IntPtr intPtr2 = td3BteaMqY(intPtr, point_);
			if (!(intPtr2 != LwqBJ1t9YF))
			{
				return;
			}
			F3vpzeWt6I(intPtr2);
			num = 1;
			if (!Pj4I7l6TRsspL6HNA3o())
			{
				goto IL_00ac;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_00ac;
		IL_00ac:
		switch (windowDetectLevel)
		{
		case WindowDetectLevel.RootWindowOfSameProcess:
			intptr_ = cEyBwPXlwe(intPtr, true);
			break;
		case WindowDetectLevel.RootWindow:
			intptr_ = cEyBwPXlwe(intPtr, false);
			break;
		case WindowDetectLevel.Control:
			intptr_ = td3BteaMqY(intPtr, point_);
			break;
		}
		F3vpzeWt6I(intptr_);
	}

	private void F3vpzeWt6I(IntPtr intptr_2)
	{
		if (LwqBJ1t9YF == intptr_2)
		{
			return;
		}
		LwqBJ1t9YF = intptr_2;
		Rectangle rectangle_;
		if (RPaBvH3jD2)
		{
			lTX1EJ5crAHPVuUbPH8.lYSxQ8pSV1(intptr_2, out var uqwBGEdQOmobi3k3BTZ_);
			rectangle_ = new Rectangle(uqwBGEdQOmobi3k3BTZ_.crGvqbYWVF6, uqwBGEdQOmobi3k3BTZ_.mP6vq6MOjic, uqwBGEdQOmobi3k3BTZ_.width, uqwBGEdQOmobi3k3BTZ_.height);
		}
		else
		{
			rectangle_ = lTX1EJ5crAHPVuUbPH8.rLgx4ZZ8Fh(intptr_2);
		}
		eSnBNwTa8v = rectangle_;
		lTX1EJ5crAHPVuUbPH8.vAxrCyFr2m(intptr_2, out var uint_);
		string text = "-";
		if (uint_ != 0)
		{
			text = lTX1EJ5crAHPVuUbPH8.CSDrKFqUBI(uint_);
			int num = 0;
			if (!Pj4I7l6TRsspL6HNA3o())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		CQgp9GGtfu().amGKgGBeHh(rectangle_, text ?? "");
	}

	private static IntPtr cEyBwPXlwe(IntPtr intptr_2, bool bool_2)
	{
		IntPtr intPtr = lTX1EJ5crAHPVuUbPH8.oKIr1vTS4o(intptr_2);
		if (intptr_2 != intPtr)
		{
			lTX1EJ5crAHPVuUbPH8.vAxrCyFr2m(intptr_2, out var uint_);
			lTX1EJ5crAHPVuUbPH8.vAxrCyFr2m(intPtr, out var uint_2);
			if (uint_2 == uint_ || !bool_2)
			{
				return intPtr;
			}
		}
		return intptr_2;
	}

	private IntPtr td3BteaMqY(IntPtr intptr_2, Point point_0)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.Q8lvcVE2qaZ = new List<IntPtr>();
		try
		{
			lTX1EJ5crAHPVuUbPH8.RXDxHVMOIa(intptr_2, _003C_003Ec__DisplayClass15_.pYfvccdPZND, IntPtr.Zero);
		}
		catch (Exception)
		{
		}
		foreach (IntPtr item in _003C_003Ec__DisplayClass15_.Q8lvcVE2qaZ)
		{
			if (rkXB25eyY4.y8FpSMN067(item, point_0.X, point_0.Y))
			{
				return item;
			}
		}
		return intptr_2;
	}

	private void JsuBglK89P()
	{
		N4PkhP56DLuHvaMdN6G n4PkhP56DLuHvaMdN6G = CQgp9GGtfu();
		qsQtMm5MtHtoYi1dcdV qsQtMm5MtHtoYi1dcdV = new qsQtMm5MtHtoYi1dcdV();
		qsQtMm5MtHtoYi1dcdV.IsSuccess = fKiBuurGTf != IntPtr.Zero;
		qsQtMm5MtHtoYi1dcdV.FAfmsObuGE(fKiBuurGTf);
		qsQtMm5MtHtoYi1dcdV.JKumqaGnfy(eSnBNwTa8v);
		n4PkhP56DLuHvaMdN6G.zsvmz1FjZj(qsQtMm5MtHtoYi1dcdV, true);
	}

	internal static bool Pj4I7l6TRsspL6HNA3o()
	{
		return Mju9pG6w9AwSGVX2AMO == null;
	}
}
