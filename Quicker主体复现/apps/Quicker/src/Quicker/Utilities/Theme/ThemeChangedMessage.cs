using CommunityToolkit.Mvvm.Messaging.Messages;
using HandyControl.Data;

namespace Quicker.Utilities.Theme;

public class ThemeChangedMessage : ValueChangedMessage<SkinType>
{
	private static ThemeChangedMessage c7tnFbcVZ32X1jrwV7bR;

	public ThemeChangedMessage(SkinType theme)
		: base(theme)
	{
	}

	internal static bool VENjvrcV5vkj56gCpy9Q()
	{
		return c7tnFbcVZ32X1jrwV7bR == null;
	}
}
