using System.Runtime.CompilerServices;
using KN1lrKqGejXc8uE67VR;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputKeyboardData : RawInputData
{
	[CompilerGenerated]
	private readonly RawKeyboard q09Gp3NVhe;

	internal static RawInputKeyboardData d4TvHUiafAYegFRJjld;

	public RawKeyboard Keyboard
	{
		[CompilerGenerated]
		get
		{
			return q09Gp3NVhe;
		}
	}

	public RawInputKeyboardData(RawInputHeader header, RawKeyboard keyboard)
		: base(header)
	{
		q09Gp3NVhe = keyboard;
	}

	public unsafe override byte[] ToStructure()
	{
		int num = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		int num2 = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawKeyboard>();
		byte[] array = new byte[num + num2];
		fixed (byte* ptr = array)
		{
			*(RawInputHeader*)ptr = base.Header;
			*(RawKeyboard*)(ptr + num) = Keyboard;
		}
		return array;
	}

	public override string ToString()
	{
		return $"{{{base.Header}, {Keyboard}}}";
	}

	internal static bool HSnc84irFIPn7NpUwIK()
	{
		return d4TvHUiafAYegFRJjld == null;
	}
}
