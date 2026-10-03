using Quicker.Common.Entities;

namespace Quicker.Common.Vm;

public class TokenMessage
{
	public string UserId { get; set; }

	public string Token { get; set; }

	public UserSettings UserSettings { get; set; }

	public bool HasNewVersion { get; set; }

	public bool MastUpdate { get; set; }

	public string NewVersionLink { get; set; }

	public TokenMessage(string token, string userId, UserSettings settings)
	{
		Token = token;
		UserId = userId;
		UserSettings = settings;
	}
}
