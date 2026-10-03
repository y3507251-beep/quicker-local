using System;

namespace Quicker.Utilities._3rd;

public sealed class TinyMessageSubscriptionToken : IDisposable
{
	private readonly WeakReference yhALzkWrVON;

	private readonly Type jI9LzG3cPMb;

	private static TinyMessageSubscriptionToken F7HsMMFTsZfrXajmt1Q8;

	public TinyMessageSubscriptionToken(ITinyMessengerHub hub, Type messageType)
	{
		if (hub == null)
		{
			throw new ArgumentNullException("hub");
		}
		if (!typeof(ITinyMessage).IsAssignableFrom(messageType))
		{
			throw new ArgumentOutOfRangeException("messageType");
		}
		yhALzkWrVON = new WeakReference(hub);
		jI9LzG3cPMb = messageType;
	}

	public void Dispose()
	{
		if (yhALzkWrVON.IsAlive && yhALzkWrVON.Target is ITinyMessengerHub obj)
		{
			typeof(ITinyMessengerHub).GetMethod("Unsubscribe", new Type[1] { typeof(TinyMessageSubscriptionToken) }).MakeGenericMethod(jI9LzG3cPMb).Invoke(obj, new object[1] { this });
		}
		GC.SuppressFinalize(this);
	}

	internal static bool C9yqMmFTCwNe2F8tdrIy()
	{
		return F7HsMMFTsZfrXajmt1Q8 == null;
	}
}
