using System.Windows.Input;

namespace Quicker.Modules.TextTools.Tools;

public static class TextToolHelper
{
	public static void SetCrossCursor()
	{
		Mouse.OverrideCursor = Cursors.Cross;
	}

	public static void RestoreCursor()
	{
		Mouse.OverrideCursor = null;
	}
}
