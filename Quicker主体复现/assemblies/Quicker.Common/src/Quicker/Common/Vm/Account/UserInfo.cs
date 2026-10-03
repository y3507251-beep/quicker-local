using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Account;

public class UserInfo
{
	public string UserId { get; set; }

	public int UserSerial { get; set; }

	public string UserName { get; set; }

	public string NickName { get; set; }

	public string Email { get; set; }

	public string Token { get; set; }

	public DateTime TokenCreateTimeUtc { get; set; }

	public DateTime TokenExpireTimeUtc { get; set; }

	public IList<int> LockButtons { get; set; } = new List<int>();

	public MemberLevel MemberLevel { get; set; }

	public DateTime? MemberExpireTimeUtc { get; set; }

	public DateTime? RegTimeUtc { get; set; }

	public ActionItem FixedButtonAction { get; set; }

	public UserLimitation UserLimitation { get; set; }

	public int ReportInterval { get; set; } = 1800;

	public string TxBaffetId { get; set; }

	public string Avatar { get; set; }

	public string IscTicket { get; set; }
}
