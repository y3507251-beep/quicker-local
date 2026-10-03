using Quicker.Domain.Network;
using Quicker.Domain.Network.Messages;

namespace Quicker.Domain.Interfaces;

public interface IMessageProcessor
{
	void ProcessMessage(MessageBase message, StateObject client);
}
