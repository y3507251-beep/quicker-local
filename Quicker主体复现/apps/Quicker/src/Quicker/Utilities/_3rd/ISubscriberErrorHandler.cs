using System;

namespace Quicker.Utilities._3rd;

public interface ISubscriberErrorHandler
{
	void Handle(ITinyMessage message, Exception exception);
}
