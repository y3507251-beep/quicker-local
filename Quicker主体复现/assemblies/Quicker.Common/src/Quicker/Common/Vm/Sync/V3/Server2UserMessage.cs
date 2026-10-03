using System;

namespace Quicker.Common.Vm.Sync.V3;

public class Server2UserMessage
{
	public string Id { get; set; }

	public MessageType MessageType { get; set; }

	public string Message { get; set; }

	public DateTime? CreateTimeUtc { get; set; }

	public string Link { get; set; }
}
