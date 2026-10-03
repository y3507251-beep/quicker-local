using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MTvu7H59xFIE4dJJH9K;
using Quicker.ScreenSelectLib.Tools;

namespace zfrwyH5n8fOaq0LjOSZ;

internal class wB6Dmm5N492vi1ojMYh
{
	private enum KQabxsuc7Dc3YShTG9g : uint
	{

	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WT4vcJI29qn;

		public static Func<IntPtr, int> DW9vc0Oupmb;

		internal static _003C_003Ec wfuHUwcrOdMCRitxpSXy;

		static _003C_003Ec()
		{
			WT4vcJI29qn = new _003C_003Ec();
		}

		internal int TLyvcNT53mj(IntPtr item)
		{
			return (int)item;
		}

		internal static bool dwc2K3crJBOWwgFGTs6b()
		{
			return wfuHUwcrOdMCRitxpSXy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public wB6Dmm5N492vi1ojMYh pbrvcP7VS44;

		public List<IntPtr> QeBvcElfmjN;

		private static _003C_003Ec__DisplayClass10_0 pkRuhIcraaWCGt5a0gm5;

		internal bool LlCvcCWBJBy(IntPtr hWnd, IntPtr lParam)
		{
			try
			{
				if (pbrvcP7VS44.YPspJEoixO(hWnd))
				{
					QeBvcElfmjN.Add(hWnd);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		internal static bool uHyGHecrrQ5fxnBDfYaY()
		{
			return pkRuhIcraaWCGt5a0gm5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public wB6Dmm5N492vi1ojMYh cvtvc80R2Z6;

		public List<IntPtr> PiVvcaD90ww;

		private static _003C_003Ec__DisplayClass11_0 xyXZlwcr961hhYfvsoyR;

		internal bool SOPvcyGsnqr(IntPtr hWnd, IntPtr lParam)
		{
			try
			{
				if (cvtvc80R2Z6.YPspJEoixO(hWnd))
				{
					PiVvcaD90ww.Add(hWnd);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		internal static bool TQ6pJucrLAuYTbCyc7xE()
		{
			return xyXZlwcr961hhYfvsoyR == null;
		}
	}

	private readonly ScreenProperties pcDpPC1OT4;

	private readonly IntPtr LJhpEMpUfy;

	private readonly List<IntPtr> kTtpy8bxWK = new List<IntPtr>();

	private readonly Dictionary<IntPtr, int> tWbp8nUFXQ = new Dictionary<IntPtr, int>();

	private readonly Dictionary<IntPtr, lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ> AZSpaSaLd6 = new Dictionary<IntPtr, lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ>();

	private readonly Dictionary<IntPtr, IntPtr> Dw2p7S53N3 = new Dictionary<IntPtr, IntPtr>();

	internal static wB6Dmm5N492vi1ojMYh T4OBQl6KEs4qha5pX0A;

	public wB6Dmm5N492vi1ojMYh(ScreenProperties screenProperties_1, IntPtr intptr_1)
	{
		pcDpPC1OT4 = screenProperties_1;
		LJhpEMpUfy = intptr_1;
		MaXpuflBXK();
	}

	public static Rectangle B0srfYXsdl()
	{
		IntPtr intPtr = lTX1EJ5crAHPVuUbPH8.heJrurlRwy();
		Rectangle result;
		if (intPtr != IntPtr.Zero)
		{
			lTX1EJ5crAHPVuUbPH8.lYSxQ8pSV1(intPtr, out var uqwBGEdQOmobi3k3BTZ_);
			result = new Rectangle(uqwBGEdQOmobi3k3BTZ_.crGvqbYWVF6, uqwBGEdQOmobi3k3BTZ_.mP6vq6MOjic, uqwBGEdQOmobi3k3BTZ_.width, uqwBGEdQOmobi3k3BTZ_.height);
		}
		else
		{
			result = new Rectangle(SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Top, SystemInformation.VirtualScreen.Right - SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Bottom - SystemInformation.VirtualScreen.Top);
		}
		return result;
	}

	public IntPtr qamrz1CwQc(int int_0, int int_1)
	{
		List<IntPtr> list = h1YpvcZBPW(kTtpy8bxWK, int_0, int_1);
		if (list != null && list.Count != 0)
		{
			IntPtr intPtr = list[0];
			int num = int.MaxValue;
			foreach (IntPtr item in list)
			{
				int value = 0;
				if (tWbp8nUFXQ.TryGetValue(item, out value) && value < num)
				{
					num = value;
					intPtr = item;
				}
			}
			if (intPtr == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr2 = lTX1EJ5crAHPVuUbPH8.RfJx11RS3O(intPtr);
			if (intPtr2 != IntPtr.Zero)
			{
				lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ_;
				int num2 = lTX1EJ5crAHPVuUbPH8.qLYrcDvrRv(intPtr2, out uqwBGEdQOmobi3k3BTZ_);
				lTX1EJ5crAHPVuUbPH8.am0xbir6T1(intPtr, out var uqwBGEdQOmobi3k3BTZ_2);
				lTX1EJ5crAHPVuUbPH8.f2arE69QQ8(intPtr, intPtr2);
				if (num2 == 2)
				{
					if (!IskSaa6BtXNZnQSN22W())
					{
						switch (0)
						{
						}
					}
					if (uqwBGEdQOmobi3k3BTZ_.crGvqbYWVF6 == uqwBGEdQOmobi3k3BTZ_2.crGvqbYWVF6 && uqwBGEdQOmobi3k3BTZ_.tRZvqXJG8BS == uqwBGEdQOmobi3k3BTZ_2.tRZvqXJG8BS && uqwBGEdQOmobi3k3BTZ_.t1ivqmCnUM7 == uqwBGEdQOmobi3k3BTZ_2.t1ivqmCnUM7 && uqwBGEdQOmobi3k3BTZ_.mP6vq6MOjic == uqwBGEdQOmobi3k3BTZ_2.mP6vq6MOjic)
					{
						IntPtr intPtr3 = LnApwtx4QO(intPtr, int_0, int_1);
						if (intPtr3 != IntPtr.Zero)
						{
							return intPtr3;
						}
					}
				}
			}
			return intPtr;
		}
		return IntPtr.Zero;
	}

	public IntPtr LnApwtx4QO(IntPtr intptr_1, int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.pbrvcP7VS44 = this;
		_003C_003Ec__DisplayClass10_.QeBvcElfmjN = new List<IntPtr>();
		try
		{
			lTX1EJ5crAHPVuUbPH8.RXDxHVMOIa(intptr_1, _003C_003Ec__DisplayClass10_.LlCvcCWBJBy, IntPtr.Zero);
		}
		catch (Exception)
		{
		}
		if (_003C_003Ec__DisplayClass10_.QeBvcElfmjN.Count > 0)
		{
			if (IskSaa6BtXNZnQSN22W())
			{
				switch (0)
				{
				}
			}
			List<IntPtr> list = h1YpvcZBPW(_003C_003Ec__DisplayClass10_.QeBvcElfmjN, int_0, int_1);
			if (list != null && list.Count > 0 && list.Count > 1)
			{
				return list[0];
			}
		}
		return intptr_1;
	}

	public IntPtr MaNptOnpR2(IntPtr intptr_1, int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.cvtvc80R2Z6 = this;
		_003C_003Ec__DisplayClass11_.PiVvcaD90ww = new List<IntPtr>();
		int num = 0;
		if (T4OBQl6KEs4qha5pX0A != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			try
			{
				lTX1EJ5crAHPVuUbPH8.RXDxHVMOIa(intptr_1, _003C_003Ec__DisplayClass11_.SOPvcyGsnqr, IntPtr.Zero);
			}
			catch (Exception)
			{
			}
			if (_003C_003Ec__DisplayClass11_.PiVvcaD90ww.Count > 0)
			{
				List<IntPtr> list = h1YpvcZBPW(_003C_003Ec__DisplayClass11_.PiVvcaD90ww, int_0, int_1);
				if (list != null && list.Count > 0)
				{
					foreach (IntPtr item in list)
					{
						lTX1EJ5crAHPVuUbPH8.lYSxQ8pSV1(item, out var uqwBGEdQOmobi3k3BTZ_);
					}
					return (IntPtr)list.Select(_003C_003Ec.DW9vc0Oupmb ?? (_003C_003Ec.DW9vc0Oupmb = _003C_003Ec.WT4vcJI29qn.TLyvcNT53mj)).ToList().Min();
				}
			}
			return intptr_1;
		}
	}

	internal lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ UAlpg91lhv(IntPtr intptr_1)
	{
		if (AZSpaSaLd6.ContainsKey(intptr_1) && AZSpaSaLd6.TryGetValue(intptr_1, out var value))
		{
			return value;
		}
		lTX1EJ5crAHPVuUbPH8.lYSxQ8pSV1(intptr_1, out value);
		AZSpaSaLd6.Add(intptr_1, value);
		return value;
	}

	internal IntPtr wnxpLD9ANm(IntPtr intptr_1)
	{
		IntPtr value = IntPtr.Zero;
		if (Dw2p7S53N3.ContainsKey(intptr_1) && Dw2p7S53N3.TryGetValue(intptr_1, out value))
		{
			return value;
		}
		value = lTX1EJ5crAHPVuUbPH8.cyRxXyMddA(intptr_1, 2);
		Dw2p7S53N3.Add(intptr_1, value);
		return value;
	}

	private List<IntPtr> h1YpvcZBPW(List<IntPtr> list_1, double double_0, double double_1)
	{
		List<IntPtr> list = new List<IntPtr>();
		if (list_1 != null && list_1.Count > 0)
		{
			foreach (IntPtr item in list_1)
			{
				if (y8FpSMN067(item, double_0, double_1))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public bool y8FpSMN067(IntPtr intptr_1, double double_0, double double_1)
	{
		try
		{
			lTX1EJ5crAHPVuUbPH8.UqwBGEdQOmobi3k3BTZ uqwBGEdQOmobi3k3BTZ = UAlpg91lhv(intptr_1);
			if (uqwBGEdQOmobi3k3BTZ.width == 0 || uqwBGEdQOmobi3k3BTZ.height == 0)
			{
				return false;
			}
			double num = 1.0;
			IntPtr intPtr = wnxpLD9ANm(intptr_1);
			int num2 = 0;
			if (!IskSaa6BtXNZnQSN22W())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			default:
				if (intPtr != IntPtr.Zero)
				{
					double scalingFactor = pcDpPC1OT4.GetMonitorInformation(intPtr).scalingFactor;
					double scalingFactor2 = pcDpPC1OT4.GetMonitorInformation(IntPtr.Zero).scalingFactor;
					num = scalingFactor / scalingFactor2;
				}
				if ((double)uqwBGEdQOmobi3k3BTZ.crGvqbYWVF6 * num <= double_0 && double_0 <= (double)uqwBGEdQOmobi3k3BTZ.tRZvqXJG8BS * num && (double)uqwBGEdQOmobi3k3BTZ.mP6vq6MOjic * num <= double_1 && double_1 < (double)uqwBGEdQOmobi3k3BTZ.t1ivqmCnUM7 * num)
				{
					return true;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	protected bool ulvp2NYAx2(IntPtr intptr_1, IntPtr intptr_2)
	{
		try
		{
			if (intptr_1 != LJhpEMpUfy && YPspJEoixO(intptr_1))
			{
				kTtpy8bxWK.Add(intptr_1);
				int value = E1npNv8sQB(intptr_1);
				if (!tWbp8nUFXQ.ContainsKey(intptr_1))
				{
					tWbp8nUFXQ.Add(intptr_1, value);
				}
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void MaXpuflBXK()
	{
		try
		{
			lTX1EJ5crAHPVuUbPH8.Qg4xsxUxe4(ulvp2NYAx2, IntPtr.Zero);
		}
		catch (Exception)
		{
		}
	}

	private int E1npNv8sQB(IntPtr intptr_1)
	{
		int num = 0;
		IntPtr intPtr = intptr_1;
		while (intPtr != IntPtr.Zero)
		{
			num++;
			intPtr = lTX1EJ5crAHPVuUbPH8.Hnir0yyf2i(intPtr, 3);
		}
		return num;
	}

	private bool YPspJEoixO(IntPtr intptr_1)
	{
		if (lTX1EJ5crAHPVuUbPH8.vTMrJycNWS(intptr_1))
		{
			if (F5BpCNvuI0(intptr_1))
			{
				return false;
			}
			if ((lTX1EJ5crAHPVuUbPH8.dQbrSGJulu(intptr_1, -20) & 0x20) != 32)
			{
				return true;
			}
		}
		return false;
	}

	[DllImport("DwmApi.dll", EntryPoint = "DwmGetWindowAttribute")]
	private static extern int rUYp09wQwH(IntPtr intptr_1, KQabxsuc7Dc3YShTG9g kqabxsuc7Dc3YShTG9g_0, out bool bool_0, int int_0);

	private static bool F5BpCNvuI0(IntPtr intptr_1)
	{
		bool bool_ = false;
		rUYp09wQwH(intptr_1, (KQabxsuc7Dc3YShTG9g)14u, out bool_, Marshal.SizeOf(bool_));
		return bool_;
	}

	internal static bool IskSaa6BtXNZnQSN22W()
	{
		return T4OBQl6KEs4qha5pX0A == null;
	}
}
