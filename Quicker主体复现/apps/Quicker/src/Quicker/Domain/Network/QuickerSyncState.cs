using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.Network;

public enum QuickerSyncState
{
	[Display(Name = "空闲")]
	Idle,
	[Display(Name = "等待同步")]
	Pending,
	[Display(Name = "同步中...")]
	Syncing,
	[Display(Name = "同步出错")]
	Warning
}
