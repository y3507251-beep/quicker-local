using System;

namespace Quicker.Common.Vm.Share;

public class SharedTextCommandPackageDto
{
	public Guid Id { get; set; }

	public string UserId { get; set; }

	public int UserSerial { get; set; }

	public string UserNickName { get; set; }

	public string Title { get; set; }

	public string Keywords { get; set; }

	public string Note { get; set; }

	public string ForExe { get; set; }

	public string Description { get; set; }

	public bool IsDisabled { get; set; }

	public int ViewCount { get; set; }

	public int DownloadCount { get; set; }

	public int LikeCount { get; set; }

	public int TopicCount { get; set; }

	public int CommentCount { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public int Revision { get; set; } = 1;

	public DateTime? LastUpdateTimeUtc { get; set; }

	public string LastUpdateNote { get; set; }

	public int ItemCount { get; set; }

	public string Data { get; set; }

	public bool IsDeleted { get; set; }

	public DateTime? DeleteTimeUtc { get; set; }
}
