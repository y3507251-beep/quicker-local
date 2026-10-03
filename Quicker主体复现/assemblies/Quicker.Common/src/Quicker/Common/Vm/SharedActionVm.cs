using System;
using System.Collections.Generic;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm;

public class SharedActionVm
{
	public Guid? Id { get; set; }

	public string Title { get; set; }

	public string SourceSharedActionId { get; set; }

	public int? SourceSharedActionRevision { get; set; }

	public ActionUserLimitation UserLimitation { get; set; }

	public string InternalId { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string UserId { get; set; }

	public bool IsDeleted { get; set; }

	public string SourceProfileId { get; set; }

	public int UseCount { get; set; }

	public int VoteCount { get; set; }

	public int ViewCount { get; set; }

	public int DownVoteCount { get; set; }

	public string Description { get; set; }

	public string Language { get; set; }

	public string ExeFile { get; set; }

	public string ExeFullpath { get; set; }

	public ActionType ActionType { get; set; }

	public string Icon { get; set; }

	public string Path { get; set; }

	public int DelayMs { get; set; }

	public string Data { get; set; }

	public string Data2 { get; set; }

	public string Data3 { get; set; }

	public IList<ActionItem> Children { get; set; }

	public bool IsPublic { get; set; } = true;

	public Guid? SharedProfileId { get; set; }

	public string Tags { get; set; }

	public string Note { get; set; }

	public string ChangeLog { get; set; }

	public string SoftVersion { get; set; }

	public string MinQuickerVersion { get; set; }

	public bool SubmitReview { get; set; } = true;

	public bool AsSubProgram { get; set; }

	public string ContextMenuData { get; set; }

	public bool AllowScrollTrigger { get; set; }

	[Obsolete]
	public bool IsImageProcessor { get; set; }

	[Obsolete]
	public bool IsTextProcessor { get; set; }

	public ActionAssociation Association { get; set; }

	public bool EnableEvaluateVariable { get; set; }

	public bool DoNotClosePanel { get; set; }

	public string ExtraActionOptions { get; set; }

	public string Keywords { get; set; }
}
