using System;
using System.Collections.Generic;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Sync.V3;

namespace Quicker.Common.Vm.Sync.V4;

public class SyncResult4 : ISyncPc2ServerResult
{
	public UserInfo UserInfo { get; set; }

	public string SecretInfo { get; set; }

	public string PcSlowVersion { get; set; }

	public string PcFastVersion { get; set; }

	public string ConnectionServer { get; set; }

	public ICollection<SyncItemResult4> Pc2ServerResults { get; set; } = new List<SyncItemResult4>();

	public IList<SyncItem4> Server2PcItems { get; set; } = new List<SyncItem4>();

	public ICollection<SyncItem4> ConflictItems { get; set; } = new List<SyncItem4>();

	public IList<RequestResendItem> RequestResendItems { get; set; } = new List<RequestResendItem>();

	public IList<Server2UserMessage> Messages { get; set; }

	public bool StopOnThisDevice { get; set; }

	public string StopReason { get; set; }

	public int NewNotificationCount { get; set; }

	public int NewMessageCount { get; set; }

	public DateTime? LastSuccessSyncTimeUtc { get; set; }

	public IDictionary<string, string> Configurations { get; set; }
}
