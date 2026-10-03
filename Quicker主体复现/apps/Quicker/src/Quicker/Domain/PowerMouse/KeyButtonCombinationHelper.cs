using System.Windows.Forms;

namespace Quicker.Domain.PowerMouse;

public static class KeyButtonCombinationHelper
{
	internal static object UhC1uFQOSppFnNEEnuCl;

	public static MouseButtons ToMouseButtons(this KeyButtonCombination value)
	{
		return value switch
		{
			KeyButtonCombination.NA => MouseButtons.None, 
			KeyButtonCombination.Middle => MouseButtons.Middle, 
			KeyButtonCombination.Right => MouseButtons.Right, 
			KeyButtonCombination.X1 => MouseButtons.XButton1, 
			KeyButtonCombination.X2 => MouseButtons.XButton2, 
			_ => MouseButtons.None, 
		};
	}

	public static MouseButtons ToMouseButtons(this int value)
	{
		return ((KeyButtonCombination)value).ToMouseButtons();
	}

	internal static bool UKlkLbQOwjH1S1j6fr1c()
	{
		return UhC1uFQOSppFnNEEnuCl == null;
	}
}
