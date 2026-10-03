namespace Quicker.Domain.Push;

public enum PushConnectionState
{
	NotEnabled,
	Connecting,
	ConnectedInactive,
	ConnectedActive,
	WaitingReconnect,
	Closing,
	Error
}
