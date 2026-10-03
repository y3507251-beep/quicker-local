using System;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm.Account;

public class AuthenticateResult2
{
	public UserInfo UserInfo { get; set; }

	public string SecretInfo { get; set; }

	[Obsolete("已经不使用此属性")]
	public UserSettings UserSettings { get; set; }

	public DateTime UserSettingsUpdateTimeUtc { get; set; }

	public string LastVersion { get; set; }

	public bool MastUpdate { get; set; }

	public string NewVersionLink { get; set; }

	public bool IsNewUser { get; set; }

	public string GuideLink { get; set; }

	public AuthenticateResult2()
	{
		UserInfo = new UserInfo();
		UserSettings = new UserSettings();
	}
}
