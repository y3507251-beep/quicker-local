using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

public struct RawHid
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public byte[] FivvRa8fl2l;

		public int HZ2vR7g4Jd3;

		private static _003C_003Ec__DisplayClass10_0 kXUCr9cO8cJapBnX4E3Y;

		internal ArraySegment<byte> h1cvR8j1gFe(int x)
		{
			return new ArraySegment<byte>(FivvRa8fl2l, HZ2vR7g4Jd3 * x, HZ2vR7g4Jd3);
		}

		internal static bool yDxBuNcORK6lNH93FAkx()
		{
			return kXUCr9cO8cJapBnX4E3Y == null;
		}
	}

	private int rnRsVJ2dll;

	private int ehGsZDt2EK;

	private byte[] wNTs9mDS8l;

	private static object YP23kylODOkkgTHel4Y;

	public int ElementSize => rnRsVJ2dll;

	public int Count => ehGsZDt2EK;

	public byte[] RawData => wNTs9mDS8l;

	public unsafe static RawHid FromPointer(void* ptr)
	{
		RawHid result = default(RawHid);
		result.rnRsVJ2dll = *(int*)ptr;
		result.ehGsZDt2EK = ((int*)ptr)[1];
		result.wNTs9mDS8l = new byte[result.ElementSize * result.Count];
		Marshal.Copy(new IntPtr((byte*)ptr + (nint)2 * (nint)4), result.wNTs9mDS8l, 0, result.wNTs9mDS8l.Length);
		return result;
	}

	public ArraySegment<byte>[] ToHidReports()
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.HZ2vR7g4Jd3 = ElementSize;
		_003C_003Ec__DisplayClass10_.FivvRa8fl2l = RawData;
		return Enumerable.Range(0, Count).Select(_003C_003Ec__DisplayClass10_.h1cvR8j1gFe).ToArray();
	}

	public unsafe byte[] ToStructure()
	{
		byte[] array = new byte[rnRsVJ2dll * ehGsZDt2EK + 8];
		fixed (byte* pinned_array2 = array)
		{
		    byte[] array2 = array;
			byte* ptr;
			if (array != null && array2.Length != 0)
			{
				ptr = pinned_array2;
			}
			else
			{
				ptr = null;
				if (YP23kylODOkkgTHel4Y != null)
				{
					switch (0)
					{
					}
				}
			}
			int* ptr2 = (int*)ptr;
			*ptr2 = rnRsVJ2dll;
			ptr2[1] = ehGsZDt2EK;
		}
		wNTs9mDS8l.CopyTo(array, 8);
		return array;
	}

	public override string ToString()
	{
		return string.Format("{{Count: {0}, Size: {1}, Content: {2}}}", Count, ElementSize, BitConverter.ToString(RawData).Replace("-", " "));
	}

	internal static bool pM7PbAlJ4GBfwfFnks5()
	{
		return YP23kylODOkkgTHel4Y == null;
	}
}
