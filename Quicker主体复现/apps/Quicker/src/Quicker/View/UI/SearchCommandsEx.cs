using System.Windows.Input;

namespace Quicker.View.UI;

public static class SearchCommandsEx
{
	public static readonly RoutedCommand ReplaceNext;

	public static readonly RoutedCommand ReplaceAll;

	public static readonly RoutedCommand ToggleMatchCase;

	public static readonly RoutedCommand ToggleWholeWords;

	public static readonly RoutedCommand ToggleUseRegex;

	internal static object TdLshVFG547STQo0OQ93;

	static SearchCommandsEx()
	{
		ReplaceNext = new RoutedCommand("ReplaceNext", typeof(SearchReplacePanel), new InputGestureCollection
		{
			new KeyGesture(Key.N, ModifierKeys.Alt)
		});
		ReplaceAll = new RoutedCommand("ReplaceAll", typeof(SearchReplacePanel), new InputGestureCollection
		{
			new KeyGesture(Key.Return, ModifierKeys.Alt)
		});
		ToggleMatchCase = new RoutedCommand("ToggleMatchCase", typeof(SearchReplacePanel), new InputGestureCollection
		{
			new KeyGesture(Key.C, ModifierKeys.Alt)
		});
		ToggleWholeWords = new RoutedCommand("ToggleWholeWords", typeof(SearchReplacePanel), new InputGestureCollection
		{
			new KeyGesture(Key.W, ModifierKeys.Alt)
		});
		ToggleUseRegex = new RoutedCommand("ToggleUseRegex", typeof(SearchReplacePanel), new InputGestureCollection
		{
			new KeyGesture(Key.R, ModifierKeys.Alt)
		});
	}

	internal static bool F5YgXHFGYn3YHGvlKHay()
	{
		return TdLshVFG547STQo0OQ93 == null;
	}
}
