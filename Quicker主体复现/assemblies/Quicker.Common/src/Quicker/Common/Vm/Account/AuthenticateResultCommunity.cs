using System;

namespace Quicker.Common.Vm.Account;

public class AuthenticateResultCommunity
{
	public DateTime TokenExpireTimeUtc { get; set; }

	public string Token { get; set; }
}
