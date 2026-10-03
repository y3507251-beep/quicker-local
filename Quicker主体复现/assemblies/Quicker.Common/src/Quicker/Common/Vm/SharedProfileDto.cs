using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quicker.Common.Vm;

public class SharedProfileDto
{
	public Guid Id { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string UserId { get; set; }

	public bool IsDeleted { get; set; }

	public string SourceProfileId { get; set; }

	public int UseCount { get; set; }

	public int ViewCount { get; set; }

	public int VoteCount { get; set; }

	public int DownVoteCount { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Language { get; set; }

	public string ExeFile { get; set; }

	public ProfileType ProfileType { get; set; }

	public string ExeFullpath { get; set; }

	[NotMapped]
	public IList<ActionItem> ActionItems { get; set; }

	public string UserName { get; set; }

	public string UserEmail { get; set; }
}
