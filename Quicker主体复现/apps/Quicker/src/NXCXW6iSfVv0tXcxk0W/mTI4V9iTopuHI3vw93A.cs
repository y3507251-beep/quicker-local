using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NXCXW6iSfVv0tXcxk0W;

internal static class mTI4V9iTopuHI3vw93A
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public int LJX28yfI7hx;

		public int qHd288IBcDB;

		public BitmapData LXb28aTJ0LY;

		public BitmapData gYb287ivrkg;

		public int[,] xmB28RDqNU8;

		public int VZn28qmJtZh;

		public int[,] CQh28cgJyBL;

		public ConcurrentBag<Point> P3q28VakuOv;

		public int pI928ZvBfjv;

		private static _003C_003Ec__DisplayClass0_0 rf8DyyyayMNLiWeP5God;

		internal void GAF28EuOkBv(int row)
		{
			int num2 = default(int);
			for (int i = 0; i < pI928ZvBfjv; i++)
			{
				if (LJX28yfI7hx < qHd288IBcDB)
				{
					if (c7KvNbUQ24r(LXb28aTJ0LY, gYb287ivrkg, row, i, xmB28RDqNU8, VZn28qmJtZh) && DO7vN1ilDnI(LXb28aTJ0LY, gYb287ivrkg, row, i, VZn28qmJtZh, CQh28cgJyBL))
					{
						P3q28VakuOv.Add(new Point(i, row));
						LJX28yfI7hx++;
						if (LJX28yfI7hx >= qHd288IBcDB)
						{
							break;
						}
					}
					continue;
				}
				int num = 0;
				if (rf8DyyyayMNLiWeP5God != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				break;
			}
		}

		internal static bool s3PsaiyapI8CrrarK0Vj()
		{
			return rf8DyyyayMNLiWeP5God == null;
		}
	}

	internal static object sP0UlMcQAJa8dkLDiObZ;

	internal static List<Point> s4PvNH5FhDY(Bitmap bitmap_0, Bitmap bitmap_1, BitmapData bitmapData_0, int int_0, int int_1 = 1, Color? nullable_0 = null)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.qHd288IBcDB = int_1;
		_003C_003Ec__DisplayClass0_.gYb287ivrkg = bitmapData_0;
		_003C_003Ec__DisplayClass0_.LXb28aTJ0LY = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
		_003C_003Ec__DisplayClass0_.xmB28RDqNU8 = rBnvNXDf8py(_003C_003Ec__DisplayClass0_.gYb287ivrkg, nullable_0);
		_003C_003Ec__DisplayClass0_.xmB28RDqNU8.GetLength(0);
		_003C_003Ec__DisplayClass0_.CQh28cgJyBL = null;
		if (nullable_0.HasValue)
		{
			_003C_003Ec__DisplayClass0_.CQh28cgJyBL = em1vNKpEpll(_003C_003Ec__DisplayClass0_.gYb287ivrkg, nullable_0.Value);
		}
		_003C_003Ec__DisplayClass0_.VZn28qmJtZh = int_0;
		new List<Point>();
		int toExclusive = bitmap_0.Height - bitmap_1.Height + 1;
		_003C_003Ec__DisplayClass0_.pI928ZvBfjv = bitmap_0.Width - bitmap_1.Width + 1;
		_003C_003Ec__DisplayClass0_.P3q28VakuOv = new ConcurrentBag<Point>();
		_003C_003Ec__DisplayClass0_.LJX28yfI7hx = 0;
		Parallel.For(0, toExclusive, _003C_003Ec__DisplayClass0_.GAF28EuOkBv);
		List<Point> result = _003C_003Ec__DisplayClass0_.P3q28VakuOv.ToList();
		bitmap_0.UnlockBits(_003C_003Ec__DisplayClass0_.LXb28aTJ0LY);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool DO7vN1ilDnI(BitmapData bitmapData_0, BitmapData bitmapData_1, int int_0, int int_1, int int_2, int[,] int_3)
	{
		if (int_3 == null)
		{
			int num3 = default(int);
			for (int num = 0; num < bitmapData_1.Height; num++)
			{
				int num2 = 0;
				if (!mgZyvmcQnZQNGH1TEmyw())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				for (int i = 0; i < bitmapData_1.Width; i++)
				{
					if (!qU9vN6cj3KJ(bitmapData_0, bitmapData_1, int_1 + i, int_0 + num, i, num, int_2))
					{
						return false;
					}
				}
			}
		}
		else
		{
			int length = int_3.GetLength(0);
			for (int j = 0; j < length; j++)
			{
				int num4 = int_3[j, 0];
				int num5 = int_3[j, 1];
				if (!qU9vN6cj3KJ(bitmapData_0, bitmapData_1, int_1 + num4, int_0 + num5, num4, num5, int_2))
				{
					return false;
				}
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool c7KvNbUQ24r(BitmapData bitmapData_0, BitmapData bitmapData_1, int int_0, int int_1, int[,] int_2, int int_3)
	{
		int length = int_2.GetLength(0);
		int num = 0;
		int num5 = default(int);
		while (true)
		{
			if (num < length)
			{
				int num2 = int_2[num, 0];
				int num3 = int_2[num, 1];
				int int_4 = int_1 + num2;
				int int_5 = int_0 + num3;
				if (!qU9vN6cj3KJ(bitmapData_0, bitmapData_1, int_4, int_5, num2, num3, int_3))
				{
					break;
				}
				num++;
				continue;
			}
			int num4 = 0;
			if (!mgZyvmcQnZQNGH1TEmyw())
			{
				num4 = num5;
			}
			return num4 switch
			{
				_ => true, 
			};
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool qU9vN6cj3KJ(BitmapData bitmapData_0, BitmapData bitmapData_1, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		byte* ptr = (byte*)(void*)(bitmapData_0.Scan0 + bitmapData_0.Stride * int_1 + int_0 * 3);
		byte* ptr2 = (byte*)(void*)(bitmapData_1.Scan0 + bitmapData_1.Stride * int_3 + int_2 * 3);
		if (int_4 == 0)
		{
			if (*ptr == *ptr2 && ptr[1] == ptr2[1])
			{
				return ptr[2] == ptr2[2];
			}
			return false;
		}
		if (*ptr >= *ptr2 - int_4 && *ptr <= *ptr2 + int_4 && ptr[1] >= ptr2[1] - int_4)
		{
			if (!mgZyvmcQnZQNGH1TEmyw())
			{
				switch (0)
				{
				}
			}
			if (ptr[1] <= ptr2[1] + int_4)
			{
				if (ptr[2] >= ptr2[2] - int_4)
				{
					return ptr[2] <= ptr2[2] + int_4;
				}
				return false;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int[,] rBnvNXDf8py(BitmapData bitmapData_0, Color? nullable_0)
	{
		int[,] array = new int[bitmapData_0.Width + bitmapData_0.Height + 1, 2];
		int num = 0;
		byte b;
		byte b2;
		byte b3;
		if (!nullable_0.HasValue)
		{
			(b, b2, b3) = ycbvNmkOaks(bitmapData_0, bitmapData_0.Width / 2, 0);
		}
		else
		{
			b = nullable_0.Value.R;
			b2 = nullable_0.Value.G;
			b3 = nullable_0.Value.B;
		}
		for (int i = 0; i < bitmapData_0.Height; i++)
		{
			int num2 = bitmapData_0.Width / 2;
			int num3 = i;
			var (b4, b5, b6) = ycbvNmkOaks(bitmapData_0, num2, num3);
			if ((b4 != b || b5 != b2 || b6 != b3) && (!nullable_0.HasValue || b4 != nullable_0.Value.R || b5 != nullable_0.Value.G || b6 != nullable_0.Value.B))
			{
				array[num, 0] = num2;
				array[num, 1] = num3;
				num++;
				b = b4;
				b2 = b5;
				b3 = b6;
			}
		}
		if (!nullable_0.HasValue)
		{
			(b, b2, b3) = ycbvNmkOaks(bitmapData_0, bitmapData_0.Width / 2, 0);
		}
		else
		{
			b = nullable_0.Value.R;
			b2 = nullable_0.Value.G;
			b3 = nullable_0.Value.B;
		}
		for (int j = 0; j < bitmapData_0.Width; j++)
		{
			int num4 = j;
			int num5 = bitmapData_0.Height / 2;
			var (b7, b8, b9) = ycbvNmkOaks(bitmapData_0, num4, num5);
			if ((b7 != b || b8 != b2 || b9 != b3) && (!nullable_0.HasValue || b7 != nullable_0.Value.R || b8 != nullable_0.Value.G || b9 != nullable_0.Value.B))
			{
				array[num, 0] = num4;
				array[num, 1] = num5;
				num++;
				b = b7;
				b2 = b8;
				b3 = b9;
			}
		}
		if (num == array.Length)
		{
			return array;
		}
		int[,] array2 = new int[num, 2];
		Array.Copy(array, array2, num * 2);
		return array2;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static (byte r, byte g, byte b) ycbvNmkOaks(BitmapData bitmapData_0, int int_0, int int_1)
	{
		byte* ptr = (byte*)(void*)(bitmapData_0.Scan0 + int_1 * bitmapData_0.Stride + int_0 * 3);
		return (r: ptr[2], g: ptr[1], b: *ptr);
	}

	private unsafe static int[,] em1vNKpEpll(BitmapData bitmapData_0, Color color_0)
	{
		byte b = color_0.B;
		byte g = color_0.G;
		byte r = color_0.R;
		int width = bitmapData_0.Width;
		int height = bitmapData_0.Height;
		int stride = bitmapData_0.Stride;
		IntPtr scan = bitmapData_0.Scan0;
		int num = 0;
		if (!mgZyvmcQnZQNGH1TEmyw())
		{
			int num2 = default(int);
			num = num2;
		}
		int[,] array = default(int[,]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int[,] array2;
			switch (num)
			{
			case 1:
				array[num3, 1] = num4;
				num3++;
				goto IL_0066;
			default:
				{
					array = new int[width * height, 2];
					num3 = 0;
					num4 = 0;
					goto IL_00c6;
				}
				IL_0066:
				num5++;
				goto IL_006c;
				IL_006c:
				if (num5 < width)
				{
					byte* ptr = (byte*)(void*)(scan + stride * num4 + num5 * 3);
					if ((b == *ptr) & (g == ptr[1]) & (r == ptr[2]))
					{
						goto IL_0066;
					}
					array[num3, 0] = num5;
					num = 1;
					if (mgZyvmcQnZQNGH1TEmyw())
					{
						break;
					}
					goto default;
				}
				num4++;
				goto IL_00c6;
				IL_00c6:
				if (num4 < height)
				{
					num5 = 0;
					goto IL_006c;
				}
				array2 = new int[num3, 2];
				Array.Copy(array, array2, num3 * 2);
				return array2;
			}
		}
	}

	internal static bool mgZyvmcQnZQNGH1TEmyw()
	{
		return sP0UlMcQAJa8dkLDiObZ == null;
	}
}
