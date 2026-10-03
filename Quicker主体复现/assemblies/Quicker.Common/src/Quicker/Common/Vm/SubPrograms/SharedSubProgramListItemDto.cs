using System;
using Newtonsoft.Json;

namespace Quicker.Common.Vm.SubPrograms;

public class SharedSubProgramListItemDto
{
	public Guid Id { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string Icon { get; set; }

	public string Tags { get; set; }

	public string Note { get; set; }

	public int Revision { get; set; }

	public DateTime? LastUpdateTimeUtc { get; set; }

	public int UseCount { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string UserNickName { get; set; }

	public int UserSerial { get; set; }

	public int VoteCount { get; set; }

	public bool IsPublic { get; set; }

	[JsonIgnore]
	public string UserId { get; set; }
}
