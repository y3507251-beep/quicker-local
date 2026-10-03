using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Utilities;
using WindowsInput.Native;

namespace f5fV1EMjxQYCEGaKlWD;

internal class CiNTbyM2WDubHspat0P
{
	internal static VirtualKeyCode[] w1ILd8bNW7n;

	private static CiNTbyM2WDubHspat0P F3NLda5keEj;

	private bool EmILd7i1qXP;

	private long ArZLdRjEvrp;

	private long z7YLdqQB0DA;

	internal static CiNTbyM2WDubHspat0P zdHVKkFZxFmPEDJYCKfX;

	internal static bool Km7LdJNNIgS(VirtualKeyCode virtualKeyCode_1)
	{
		return w1ILd8bNW7n.Contains(virtualKeyCode_1);
	}

	[SpecialName]
	public static CiNTbyM2WDubHspat0P iBBLdEolQUM()
	{
		return F3NLda5keEj ?? (F3NLda5keEj = new CiNTbyM2WDubHspat0P());
	}

	private CiNTbyM2WDubHspat0P()
	{
	}

	public void FlBLd0y6eX8(VirtualKeyCode virtualKeyCode_1, int int_0)
	{
		if (virtualKeyCode_1 == VirtualKeyCode.APP_V1)
		{
			EmILd7i1qXP = true;
			ArZLdRjEvrp = AppHelper.fLiLTj0x4QY();
			z7YLdqQB0DA = ArZLdRjEvrp + int_0;
		}
	}

	public void XvVLdCvqF9q(VirtualKeyCode virtualKeyCode_1)
	{
		if (virtualKeyCode_1 == VirtualKeyCode.APP_V1)
		{
			EmILd7i1qXP = false;
			ArZLdRjEvrp = 0L;
			z7YLdqQB0DA = 0L;
		}
	}

	public bool k1DLdPoqbpG(VirtualKeyCode virtualKeyCode_1)
	{
		switch (virtualKeyCode_1)
		{
		default:
			return false;
		case VirtualKeyCode.APP_V1:
			if (EmILd7i1qXP)
			{
				return z7YLdqQB0DA > AppHelper.fLiLTj0x4QY();
			}
			return false;
		case VirtualKeyCode.APP_CAPS_LOCKED:
			return KeyboardHelper.IsKeyLocked(VirtualKeyCode.CAPITAL);
		case VirtualKeyCode.APP_NUM_LOCKED:
			return KeyboardHelper.IsKeyLocked(VirtualKeyCode.NUMLOCK);
		case VirtualKeyCode.APP_SCROLL_LOCKED:
			return KeyboardHelper.IsKeyLocked(VirtualKeyCode.SCROLL);
		}
	}

	public void Reset()
	{
		EmILd7i1qXP = false;
		ArZLdRjEvrp = 0L;
		z7YLdqQB0DA = 0L;
	}

	static CiNTbyM2WDubHspat0P()
	{
		w1ILd8bNW7n = new VirtualKeyCode[4]
		{
			VirtualKeyCode.APP_V1,
			VirtualKeyCode.APP_CAPS_LOCKED,
			VirtualKeyCode.APP_NUM_LOCKED,
			VirtualKeyCode.APP_SCROLL_LOCKED
		};
	}

	internal static bool Y0V8rhFZIZNB5RWnKyaU()
	{
		return zdHVKkFZxFmPEDJYCKfX == null;
	}
}
