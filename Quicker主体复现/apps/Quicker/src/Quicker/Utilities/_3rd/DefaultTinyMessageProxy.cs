namespace Quicker.Utilities._3rd;

public sealed class DefaultTinyMessageProxy : ITinyMessageProxy
{
	private static readonly DefaultTinyMessageProxy DAwLzsp4Rl7;

	internal static DefaultTinyMessageProxy uyj8CLFmWV5PHSS8cDnE;

	public static DefaultTinyMessageProxy Instance => DAwLzsp4Rl7;

	static DefaultTinyMessageProxy()
	{
		DAwLzsp4Rl7 = new DefaultTinyMessageProxy();
	}

	private DefaultTinyMessageProxy()
	{
	}

	public void Deliver(ITinyMessage message, ITinyMessageSubscription subscription)
	{
		subscription.Deliver(message);
	}

	internal static void RuRffQFmXKvimcxXkdiQ()
	{
	}

	internal static bool xHX1vMFmyPNxQtVqWU6k()
	{
		return uyj8CLFmWV5PHSS8cDnE == null;
	}
}
