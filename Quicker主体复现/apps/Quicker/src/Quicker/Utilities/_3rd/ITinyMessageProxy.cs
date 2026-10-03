namespace Quicker.Utilities._3rd;

public interface ITinyMessageProxy
{
	void Deliver(ITinyMessage message, ITinyMessageSubscription subscription);
}
