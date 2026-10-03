using System;
using System.Collections.Generic;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm.Account;

public class AuthenticateResult
{
	public string UserId { get; set; }

	public string UserName { get; set; }

	public string NickName { get; set; }

	public string Token { get; set; }

	public UserSettings UserSettings { get; set; }

	public DateTime UserSettingsUpdateTimeUtc { get; set; }

	public string LastVersion { get; set; }

	public bool MastUpdate { get; set; }

	public string NewVersionLink { get; set; }

	public IList<int> LockButtons { get; set; } = new List<int>();

	public int MaxButtonPanels { get; set; }

	public MemberLevel MemberLevel { get; set; }

	public DateTime? MemberExpireTimeUtc { get; set; }

	public bool LockFolderAction { get; set; }

	public ActionItem FixedButtonAction { get; set; }
}
