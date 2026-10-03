using System;
using System.Collections.Generic;
using Quicker.Common.Vm.Account;

namespace Quicker.Common.Vm.Sync.V3;

public class SyncResult3
{
	public UserInfo UpdatedUserInfo { get; set; }

	public string LastPcVersion { get; set; }

	public string LastPcFastVersion { get; set; }

	public string InstantPcVersion { get; set; }

	public string ConnectionServer { get; set; }

	public IList<SyncItemResult> SyncItemResults { get; set; } = new List<SyncItemResult>();

	public IList<SyncItem> UpdatedDataItems { get; set; } = new List<SyncItem>();

	public IList<RequestResendItem> RequestResendItems { get; set; } = new List<RequestResendItem>();

	public IList<Server2UserMessage> Messages { get; set; }

	[Obsolete]
	public bool ForceSignOut { get; set; }

	public bool StopOnThisDevice { get; set; }

	public IDictionary<string, string> Configurations { get; set; }
}
