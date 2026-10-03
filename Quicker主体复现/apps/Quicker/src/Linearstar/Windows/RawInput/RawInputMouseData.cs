using System.Runtime.CompilerServices;
using KN1lrKqGejXc8uE67VR;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputMouseData : RawInputData
{
	[CompilerGenerated]
	private readonly RawMouse es1GBbBSAH;

	internal static RawInputMouseData ctY5uuibS40AZ2QOdB6;

	public RawMouse Mouse
	{
		[CompilerGenerated]
		get
		{
			return es1GBbBSAH;
		}
	}

	public RawInputMouseData(RawInputHeader header, RawMouse mouse)
		: base(header)
	{
		es1GBbBSAH = mouse;
	}

	public unsafe override byte[] ToStructure()
	{
		int num = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawInputHeader>();
		int num2 = inV36nqIWtsyBYBDM6i.uUmGgfbI3N<RawMouse>();
		byte[] array = new byte[num + num2];
		fixed (byte* ptr = array)
		{
			*(RawInputHeader*)ptr = base.Header;
			*(RawMouse*)(ptr + num) = Mouse;
		}
		return array;
	}

	public override string ToString()
	{
		return $"{{{base.Header}, {Mouse}}}";
	}

	internal static bool iaPHaXiqeU0y2trWUaf()
	{
		return ctY5uuibS40AZ2QOdB6 == null;
	}
}
