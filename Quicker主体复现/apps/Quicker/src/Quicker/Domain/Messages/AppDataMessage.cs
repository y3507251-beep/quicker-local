using System.Runtime.CompilerServices;
using Quicker.Domain.Network;
using Quicker.Domain.Network.Messages;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class AppDataMessage : TinyMessageBase
{
	[CompilerGenerated]
	private MessageBase hMDthTRxUyD;

	[CompilerGenerated]
	private StateObject rIkthMRIW3Q;

	internal static AppDataMessage KN4y8QQv5R9rqyIGXRHS;

	public MessageBase Message
	{
		[CompilerGenerated]
		get
		{
			return hMDthTRxUyD;
		}
		[CompilerGenerated]
		set
		{
			hMDthTRxUyD = value;
		}
	}

	public StateObject Client
	{
		[CompilerGenerated]
		get
		{
			return rIkthMRIW3Q;
		}
		[CompilerGenerated]
		set
		{
			rIkthMRIW3Q = value;
		}
	}

	public AppDataMessage(object sender, MessageBase message, StateObject client)
		: base(sender)
	{
		Message = message;
		Client = client;
	}

	static AppDataMessage()
	{
	}

	internal static bool FAjf8eQvYaFn9TvR6biN()
	{
		return KN4y8QQv5R9rqyIGXRHS == null;
	}

	internal static void yi0CthQvRVdqxdg2RyPg()
	{
	}
}
