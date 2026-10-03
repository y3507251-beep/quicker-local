using System;
using System.Globalization;

namespace Quicker.Utilities._3rd;

public class TinyMessengerSubscriptionException : Exception
{
	internal static TinyMessengerSubscriptionException tZGuAEFm2VLBZ71V8aNx;

	public TinyMessengerSubscriptionException(Type messageType, string reason)
		: base(string.Format(CultureInfo.InvariantCulture, "Unable to add subscription for {0} : {1}", messageType, reason))
	{
	}

	public TinyMessengerSubscriptionException(Type messageType, string reason, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "Unable to add subscription for {0} : {1}", messageType, reason), innerException)
	{
	}

	internal static bool IS4xyeFmA9IvJ7SXBHbJ()
	{
		return tZGuAEFm2VLBZ71V8aNx == null;
	}
}
