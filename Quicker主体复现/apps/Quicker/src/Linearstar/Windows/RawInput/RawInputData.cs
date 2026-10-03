using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using fe4pCrqrCLiZTDgDjpN;
using KN1lrKqGejXc8uE67VR;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public abstract class RawInputData
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ypev7mkimsF;

		public static Func<RawInputData, IEnumerable<byte>> PZ7v7KsFBm8;

		internal static _003C_003Ec g20uemcd7sm9EVJYOwFD;

		static _003C_003Ec()
		{
			ypev7mkimsF = new _003C_003Ec();
		}

		internal IEnumerable<byte> FZbv7XyGOaT(RawInputData i)
		{
			return i.ToStructure();
		}

		internal static bool I5BtFmcd44sVSWRjmqrP()
		{
			return g20uemcd7sm9EVJYOwFD == null;
		}

		internal static void wAJt1hcdHDcIwaIlMwUg()
		{
		}
	}

	private RawInputDevice HmnGv8u2fn;

	[CompilerGenerated]
	private readonly RawInputHeader XqRGS1cnGL;

	internal static RawInputData lnID3EqUbPtVhcO7mqN;

	public RawInputHeader Header
	{
		[CompilerGenerated]
		get
		{
			return XqRGS1cnGL;
		}
	}

	public RawInputDevice Device => HmnGv8u2fn ?? (HmnGv8u2fn = ((Header.DeviceHandle != RawInputDeviceHandle.Zero) ? RawInputDevice.FromHandle(Header.DeviceHandle) : null));

	protected RawInputData(RawInputHeader header)
	{
		XqRGS1cnGL = header;
	}

	public static RawInputData FromHandle(IntPtr lParam)
	{
		return FromHandle((RawInputHandle)lParam);
	}

	public static RawInputData FromHandle(RawInputHandle rawInput)
	{
		RawInputHeader rawInputDataHeader = User32.GetRawInputDataHeader(rawInput);
		RawInputHeader header;
		return rawInputDataHeader.Type switch
		{
			RawInputDeviceType.Mouse => new RawInputMouseData(rawInputDataHeader, User32.GetRawInputMouseData(rawInput, out header)), 
			RawInputDeviceType.Keyboard => new RawInputKeyboardData(rawInputDataHeader, User32.GetRawInputKeyboardData(rawInput, out header)), 
			RawInputDeviceType.Hid => RawInputHidData.Create(rawInputDataHeader, User32.GetRawInputHidData(rawInput, out header)), 
			_ => throw new ArgumentException(), 
		};
	}

	private unsafe static RawInputData KK5GLTZ118(byte* pByte_0)
	{
		RawInputHeader header = *(RawInputHeader*)pByte_0;
		int num = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		byte* ptr = pByte_0 + num;
		if (DtyjkOqCC43HCIovMjk.QmPkY4vqT2() && DtyjkOqCC43HCIovMjk.YQ0khECp9u())
		{
			ptr += 8;
		}
		RawInputDeviceType type = header.Type;
		int num2 = 0;
		if (lnID3EqUbPtVhcO7mqN != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		return num2 switch
		{
			_ => type switch
			{
				RawInputDeviceType.Mouse => new RawInputMouseData(header, *(RawMouse*)ptr), 
				RawInputDeviceType.Keyboard => new RawInputKeyboardData(header, *(RawKeyboard*)ptr), 
				RawInputDeviceType.Hid => RawInputHidData.Create(header, RawHid.FromPointer(ptr)), 
				_ => throw new ArgumentException(), 
			}, 
		};
	}

	public unsafe static RawInputData[] GetBufferedData(int bufferSize = 8)
	{
		//The blocks IL_000b, IL_000f, IL_003f, IL_0052, IL_0068, IL_007a, IL_0090, IL_0097, IL_00a8, IL_00db, IL_00e3 are reachable both inside and outside the pinned region starting at IL_0020. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 1;
		uint rawInputBufferSize;
		int num2;
		int num4;
		byte[] array = default(byte[]);
		byte* ptr = default(byte*);
		while (true)
		{
			rawInputBufferSize = User32.GetRawInputBufferSize();
			num2 = 0;
			if (k8QeBBqxF4OZIOD2O4H())
			{
				break;
			}
			switch (num2)
			{
			case 1:
				continue;
			case 2:
			{
				uint rawInputBuffer = User32.GetRawInputBuffer((IntPtr)ptr, (uint)array.Length);
				if (rawInputBuffer == 0)
				{
					return new RawInputData[0];
				}
				RawInputData[] array2 = new RawInputData[rawInputBuffer];
				int i = 0;
				int num3 = 0;
				for (; i < array2.Length; i++)
				{
					RawInputData rawInputData = (array2[i] = KK5GLTZ118(ptr + num3));
					num4 = num3;
					num3 = Align(num4 + rawInputData.Header.Size);
				}
				return array2;
			}
			}
			break;
		}
		if (rawInputBufferSize != 0)
		{
			array = new byte[rawInputBufferSize * bufferSize];
			byte[] array3 = array;
			while (true)
			{
				fixed (byte* pinned_array4 = array3)
				{
				    byte[] array4 = array3;
					if (array3 == null || array4.Length == 0)
					{
						ptr = null;
						num2 = 2;
						if (lnID3EqUbPtVhcO7mqN != null)
						{
							num2 = num;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								if (rawInputBufferSize != 0)
								{
									array = new byte[rawInputBufferSize * bufferSize];
									array3 = array;
									goto end_IL_003f;
								}
								return new RawInputData[0];
							case 1:
								rawInputBufferSize = User32.GetRawInputBufferSize();
								num2 = 0;
								if (!k8QeBBqxF4OZIOD2O4H())
								{
									continue;
								}
								goto default;
							case 2:
								break;
							}
							goto IL_007a;
							continue;
							end_IL_003f:
							break;
						}
						continue;
					}
					ptr = pinned_array4;
					goto IL_007a;
					IL_007a:
					uint rawInputBuffer = User32.GetRawInputBuffer((IntPtr)ptr, (uint)array.Length);
					if (rawInputBuffer == 0)
					{
						return new RawInputData[0];
					}
					RawInputData[] array2 = new RawInputData[rawInputBuffer];
					int i = 0;
					int num3 = 0;
					for (; i < array2.Length; i++)
					{
						RawInputData rawInputData = (array2[i] = KK5GLTZ118(ptr + num3));
						num4 = num3;
						num3 = Align(num4 + rawInputData.Header.Size);
					}
					return array2;
				}
			}
		}
		return new RawInputData[0];
	}

	protected static int Align(int x)
	{
		return (x + IntPtr.Size - 1) & ~(IntPtr.Size - 1);
	}

	public static void DefRawInputProc(RawInputData[] data)
	{
		User32.DefRawInputProc(data.SelectMany(_003C_003Ec.PZ7v7KsFBm8 ?? (_003C_003Ec.PZ7v7KsFBm8 = _003C_003Ec.ypev7mkimsF.FZbv7XyGOaT)).ToArray());
	}

	public abstract byte[] ToStructure();

	internal static bool k8QeBBqxF4OZIOD2O4H()
	{
		return lnID3EqUbPtVhcO7mqN == null;
	}
}
