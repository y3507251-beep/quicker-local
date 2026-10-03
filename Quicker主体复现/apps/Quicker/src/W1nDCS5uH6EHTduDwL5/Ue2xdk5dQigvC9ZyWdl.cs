using System.Drawing;

namespace W1nDCS5uH6EHTduDwL5;

internal class Ue2xdk5dQigvC9ZyWdl
{
	private static Ue2xdk5dQigvC9ZyWdl fcCfJeINdSqTmCVCWqU;

	public static string eDOxtWNPgt(Color color_0, bool bool_0)
	{
		if (bool_0)
		{
			return $"#{color_0.R:X2}{color_0.G:X2}{color_0.B:X2}";
		}
		return color_0.R.ToString().PadLeft(3, ' ') + ", " + color_0.G.ToString().PadLeft(3, ' ') + ", " + color_0.B.ToString().PadLeft(3, ' ');
	}

	internal static bool DFGVdxI9RR6uJ2XvrIE()
	{
		return fcCfJeINdSqTmCVCWqU == null;
	}
}
