using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace cuhTiBoSiWa4cURQRNv;

internal class XZvMcsoT6pbwjnidHD4
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct UU1sQjuTnm1nOP41BdQ
	{
		public int JYbS15CvNIk;

		public long w9US1Dy99qv;

		public uint NtSS1d04BCD;

		public bool l2oS1oqGXlL;

		public bool GPfS1TRTLki;

		public bool oVJS1MswwGp;

		public OTFKSyuKRpYswFx7Df1 YcXS1APiqpb;

		public OTFKSyuKRpYswFx7Df1 eWcS1Opv8iZ;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 248)]
		public string DxBS1FwFx0X;
	}

	public struct Bkt9IXuSbR8d4G15TaK
	{
		public int UXfS1UiUYSi;

		public int xUCS1lBuhej;

		public int SD7S1iqPDJJ;

		public int pWFS13vLKUD;

		public int ExwS1f0fB53;

		public int KG1S1zpKKsK;

		public ushort FoFSbwVX0bZ;

		public IntPtr QuTSbtRLDN3;
	}

	public struct OTFKSyuKRpYswFx7Df1
	{
		public ushort LarSbgLvdIb;

		public ushort JP9SbLuS220;

		public ushort euWSbv5xqox;

		public ushort zcgSbS8C8dV;

		public ushort WfnSb2Tyuu6;

		public ushort up2Sbu9M4Ar;

		public ushort gN5SbNGwry1;

		public ushort RMISbJrapej;
	}

	private static XZvMcsoT6pbwjnidHD4 z6XLoMQh8sucJ0sEoCmD;

	public static bool QgfgpKDdaOO(IList<string> ilist_0, bool bool_0)
	{
		UU1sQjuTnm1nOP41BdQ uu1sQjuTnm1nOP41BdQ_ = default(UU1sQjuTnm1nOP41BdQ);
		uu1sQjuTnm1nOP41BdQ_.JYbS15CvNIk = Marshal.SizeOf(uu1sQjuTnm1nOP41BdQ_);
		Bkt9IXuSbR8d4G15TaK bkt9IXuSbR8d4G15TaK_ = default(Bkt9IXuSbR8d4G15TaK);
		bkt9IXuSbR8d4G15TaK_.UXfS1UiUYSi = Marshal.SizeOf(bkt9IXuSbR8d4G15TaK_);
		bkt9IXuSbR8d4G15TaK_.xUCS1lBuhej = 1;
		IntPtr intPtr = uUpgpx7dJHR(ref bkt9IXuSbR8d4G15TaK_, ref uu1sQjuTnm1nOP41BdQ_);
		if (intPtr == IntPtr.Zero)
		{
			throw new Exception("未找到蓝牙设备！");
		}
		try
		{
			do
			{
				string dxBS1FwFx0X = uu1sQjuTnm1nOP41BdQ_.DxBS1FwFx0X;
				if (ilist_0.Contains(dxBS1FwFx0X))
				{
					Guid guid_ = new Guid("{0000111e-0000-1000-8000-00805f9b34fb}");
					Guid guid_2 = new Guid("{0000110b-0000-1000-8000-00805f9b34fb}");
					int int_ = (bool_0 ? 1 : 0);
					if (bool_0)
					{
						abFgppvWfgq(IntPtr.Zero, ref uu1sQjuTnm1nOP41BdQ_, ref guid_, 0);
						abFgppvWfgq(IntPtr.Zero, ref uu1sQjuTnm1nOP41BdQ_, ref guid_2, 0);
					}
					int num = abFgppvWfgq(IntPtr.Zero, ref uu1sQjuTnm1nOP41BdQ_, ref guid_, int_);
					int num2 = abFgppvWfgq(IntPtr.Zero, ref uu1sQjuTnm1nOP41BdQ_, ref guid_2, int_);
					if (num != 0 || num2 != 0)
					{
						throw new Exception("操作未成功！");
					}
					return true;
				}
			}
			while (UXygpr9aNVZ(intPtr, ref uu1sQjuTnm1nOP41BdQ_));
			throw new Exception("未找到蓝牙设备。");
		}
		finally
		{
			JBYgpBUV0ms(intPtr);
		}
	}

	[DllImport("Bthprops.cpl", CharSet = CharSet.Auto, EntryPoint = "BluetoothFindFirstDevice", SetLastError = true)]
	private static extern IntPtr uUpgpx7dJHR(ref Bkt9IXuSbR8d4G15TaK bkt9IXuSbR8d4G15TaK_0, ref UU1sQjuTnm1nOP41BdQ uu1sQjuTnm1nOP41BdQ_0);

	[DllImport("Bthprops.cpl", CharSet = CharSet.Auto, EntryPoint = "BluetoothFindNextDevice", SetLastError = true)]
	private static extern bool UXygpr9aNVZ(IntPtr intptr_0, ref UU1sQjuTnm1nOP41BdQ uu1sQjuTnm1nOP41BdQ_0);

	[DllImport("Bthprops.cpl", EntryPoint = "BluetoothSetServiceState", SetLastError = true)]
	private static extern int abFgppvWfgq(IntPtr intptr_0, ref UU1sQjuTnm1nOP41BdQ uu1sQjuTnm1nOP41BdQ_0, ref Guid guid_0, int int_0);

	[DllImport("Bthprops.cpl", EntryPoint = "BluetoothFindDeviceClose", SetLastError = true)]
	private static extern bool JBYgpBUV0ms(IntPtr intptr_0);

	internal static bool jivK41QhRIekyFE7iSV8()
	{
		return z6XLoMQh8sucJ0sEoCmD == null;
	}
}
