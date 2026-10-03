using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Quicker.Utilities;
using WindowsInput.Native;

namespace Quicker.Domain.PowerKeys;

public class KeyboardState
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GK0vKEBHpwJ;

		public static Func<long, bool> GtrvKyOUUVU;

		private static _003C_003Ec teJ1eycSDA7WRyJlKi4E;

		static _003C_003Ec()
		{
			GK0vKEBHpwJ = new _003C_003Ec();
		}

		internal bool pobvKP9B8b8(long x)
		{
			return (ulong)x > 0uL;
		}

		internal static bool gTExx9cS3emDuesyhE0W()
		{
			return teJ1eycSDA7WRyJlKi4E == null;
		}
	}

	private readonly long[] mX6tVMu9TaI = new long[256];

	internal static KeyboardState cPf1hqQKumnZsOXmVgFj;

	public void Reset()
	{
		Array.Clear(mX6tVMu9TaI, 0, 256);
	}

	public void KeyDown(int key)
	{
		mX6tVMu9TaI[key] = AppHelper.fLiLTj0x4QY();
	}

	public void KeyUp(int key)
	{
		mX6tVMu9TaI[key] = 0L;
	}

	public bool IsKeyDown(int key)
	{
		if (key != 17 && key != 131072)
		{
			if (key != 16)
			{
				int num = 0;
				if (!yGerulQKoCeYdpJMSEYd())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				switch (key)
				{
				case 18:
					if (mX6tVMu9TaI[164] <= 0L)
					{
						return mX6tVMu9TaI[165] > 0L;
					}
					return true;
				default:
					if (key < mX6tVMu9TaI.Length && key >= 0)
					{
						return mX6tVMu9TaI[key] > 0L;
					}
					return false;
				case 65536:
					break;
				}
			}
			if (mX6tVMu9TaI[160] > 0L)
			{
				return true;
			}
			return mX6tVMu9TaI[161] > 0L;
		}
		if (mX6tVMu9TaI[162] <= 0L)
		{
			return mX6tVMu9TaI[163] > 0L;
		}
		return true;
	}

	public bool IsKeyRecentlyDown(int key)
	{
		switch (key)
		{
		case 18:
		{
			int num = 0;
			if (cPf1hqQKumnZsOXmVgFj != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (mX6tVMu9TaI[164] <= 0L)
				{
					return mX6tVMu9TaI[165] > 0L;
				}
				return true;
			}
		}
		default:
			if (key < mX6tVMu9TaI.Length && key >= 0)
			{
				if (mX6tVMu9TaI[key] <= 0L)
				{
					return false;
				}
				return AppHelper.fLiLTj0x4QY() - mX6tVMu9TaI[key] < 10000L;
			}
			return false;
		case 16:
		case 65536:
			if (mX6tVMu9TaI[160] <= 0L)
			{
				return mX6tVMu9TaI[161] > 0L;
			}
			return true;
		case 17:
		case 131072:
			if (mX6tVMu9TaI[162] <= 0L)
			{
				return mX6tVMu9TaI[163] > 0L;
			}
			return true;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("KeyboardState:");
		for (int i = 0; i < mX6tVMu9TaI.Length; i++)
		{
			if (mX6tVMu9TaI[i] > 0L)
			{
				stringBuilder.Append($"{i}:{mX6tVMu9TaI[i]} ");
			}
		}
		return stringBuilder.ToString();
	}

	public bool IsCtrlDown()
	{
		if (!IsKeyDown(17) && !IsKeyDown(162))
		{
			return IsKeyDown(163);
		}
		return true;
	}

	public bool IsShiftDown()
	{
		if (!IsKeyDown(16) && !IsKeyDown(160))
		{
			return IsKeyDown(161);
		}
		return true;
	}

	public bool IsAltDown()
	{
		if (!IsKeyDown(18) && !IsKeyDown(164))
		{
			return IsKeyDown(165);
		}
		return true;
	}

	public bool IsWinDown()
	{
		if (!IsKeyDown(91))
		{
			return IsKeyDown(92);
		}
		return true;
	}

	public bool IsAnyKeyDown()
	{
		return mX6tVMu9TaI.Any(_003C_003Ec.GtrvKyOUUVU ?? (_003C_003Ec.GtrvKyOUUVU = _003C_003Ec.GK0vKEBHpwJ.pobvKP9B8b8));
	}

	public bool IsAnyOtherKeyDown(params int[] expectKeys)
	{
		int num = 0;
		while (true)
		{
			if (num < mX6tVMu9TaI.Length)
			{
				if (mX6tVMu9TaI[num] > 0L && !expectKeys.Contains(num))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool IsTheOnlyDownKey(int key)
	{
		if (key < mX6tVMu9TaI.Length && key >= 0)
		{
			if (!IsKeyDown(key))
			{
				return false;
			}
			return key switch
			{
				160 => !IsAnyOtherKeyDown(16, 160), 
				161 => !IsAnyOtherKeyDown(16, 161), 
				162 => !IsAnyOtherKeyDown(17, 162), 
				163 => !IsAnyOtherKeyDown(17, 163), 
				164 => !IsAnyOtherKeyDown(18, 164), 
				165 => !IsAnyOtherKeyDown(18, 165), 
				16 => !IsAnyOtherKeyDown(16, 160, 161), 
				17 => !IsAnyOtherKeyDown(17, 162, 163), 
				18 => !IsAnyOtherKeyDown(18, 164, 165), 
				_ => !IsAnyOtherKeyDown(key), 
			};
		}
		return false;
	}

	public bool IsModifierKeyDown()
	{
		if (!IsCtrlDown() && !IsAltDown() && !IsShiftDown())
		{
			return IsWinDown();
		}
		return true;
	}

	public bool IsModifierKeyDown(int expectKey)
	{
		int[] array = new int[11]
		{
			17, 162, 163, 16, 160, 161, 18, 164, 165, 91,
			92
		};
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				int num2 = array[num];
				if (num2 != expectKey && IsKeyDown(num2))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void SyncKeyStates()
	{
		for (int i = 8; i < mX6tVMu9TaI.Length; i++)
		{
			if (mX6tVMu9TaI[i] > 0L && !KeyboardHelper.IsKeyDown((VirtualKeyCode)i))
			{
				mX6tVMu9TaI[i] = 0L;
			}
		}
	}

	internal static bool yGerulQKoCeYdpJMSEYd()
	{
		return cPf1hqQKumnZsOXmVgFj == null;
	}
}
