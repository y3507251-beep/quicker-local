namespace Quicker.Utilities._3rd;

public interface ITinyMessageSubscription
{
	TinyMessageSubscriptionToken SubscriptionToken { get; }

	bool ShouldAttemptDelivery(ITinyMessage message);

	void Deliver(ITinyMessage message);
}
