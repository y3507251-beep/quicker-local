using System;
using System.Reflection;
using log4net;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class AppSubscriberErrorHandler : ISubscriberErrorHandler
{
	private static readonly ILog HXOthB4UPAX;

	internal static AppSubscriberErrorHandler YZEZMXQBzMKyFqjFSUNW;

	public void Handle(ITinyMessage message, Exception exception)
	{
		HXOthB4UPAX.Warn($"消息执行出错, 消息类型:{message},错误:{exception?.Message}", exception);
		AppHelper.ShowWarning($"消息执行出错, 消息类型:{message},错误:{exception?.Message}");
	}

	static AppSubscriberErrorHandler()
	{
		HXOthB4UPAX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool sydMyeQvVc83m6W4rbHt()
	{
		return YZEZMXQBzMKyFqjFSUNW == null;
	}
}
