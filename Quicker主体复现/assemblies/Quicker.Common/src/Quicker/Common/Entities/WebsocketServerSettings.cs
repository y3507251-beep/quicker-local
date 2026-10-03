namespace Quicker.Common.Entities;

public class WebsocketServerSettings
{
	public bool IsEnabled { get; set; }

	public int Port { get; set; } = 668;

	public string Password { get; set; }

	public bool EnableSecure { get; set; } = true;
}
