using System;

namespace Quicker.Utilities._3rd;

public interface ITinyMessengerHub
{
	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, bool useStrongReferences) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, bool useStrongReferences, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, bool useStrongReferences) where TMessage : class, ITinyMessage;

	TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, bool useStrongReferences, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage;

	void Unsubscribe<TMessage>(TinyMessageSubscriptionToken subscriptionToken) where TMessage : class, ITinyMessage;

	void Unsubscribe(TinyMessageSubscriptionToken subscriptionToken);

	void Publish<TMessage>(TMessage message) where TMessage : class, ITinyMessage;

	void PublishAsync<TMessage>(TMessage message) where TMessage : class, ITinyMessage;

	void PublishAsync<TMessage>(TMessage message, AsyncCallback callback) where TMessage : class, ITinyMessage;
}
