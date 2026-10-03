using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quicker.Common.Vm.Forum;

public class TopicDto
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	public string CreateUserId { get; set; }

	public string CreateUserNickName { get; set; }

	public int? ExeFileId { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public DateTime LastUpdateTimeUtc { get; set; }

	public int TopicCategoryId { get; set; }

	public string TopicCategoryName { get; set; }

	public string Title { get; set; }

	public int VoteCount { get; set; }

	public int DissCount { get; set; }

	public string Tags { get; set; }

	public bool KeepTop { get; set; }

	public bool GlobalKeepTop { get; set; }

	public int ViewCount { get; set; }

	public int ReplyCount { get; set; }

	public bool IsValuable { get; set; }

	public string LastUserId { get; set; }

	public string LastUserNickName { get; set; }
}
