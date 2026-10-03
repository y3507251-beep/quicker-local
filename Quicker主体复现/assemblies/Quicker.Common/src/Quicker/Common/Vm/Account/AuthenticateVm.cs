namespace Quicker.Common.Vm.Account;

public class AuthenticateVm
{
	public string UserName { get; set; }

	public string Password { get; set; }

	public string Token { get; set; }

	public string SoftVersion { get; set; }

	public string Platform { get; set; }

	public string MachineName { get; set; }

	public string OsVersion { get; set; }

	public bool Is64Bit { get; set; }

	public string Channel { get; set; }

	public string EncPairId { get; set; }
}
