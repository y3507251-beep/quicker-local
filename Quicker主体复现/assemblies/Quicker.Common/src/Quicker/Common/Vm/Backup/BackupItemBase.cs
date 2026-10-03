using System;
using System.ComponentModel.DataAnnotations;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm.Backup;

public class BackupItemBase
{
	public UserObjectType ObjectType { get; set; }

	[StringLength(50)]
	public string ObjectId { get; set; }

	[StringLength(50)]
	public string DisplayName { get; set; }

	[StringLength(100)]
	public string ObjectIcon { get; set; }

	[StringLength(500)]
	public string UserNote { get; set; }

	[StringLength(200)]
	public string SystemNote { get; set; }

	public bool IsManualSave { get; set; }

	[StringLength(20)]
	public string QuickerVersion { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public DateTime? ExpireTimeUtc { get; set; }

	[StringLength(50)]
	public string MachineName { get; set; }
}
