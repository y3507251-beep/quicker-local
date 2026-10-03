using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm;

public class SharedActionDto
{
	public Guid Id { get; set; }

	public string Title { get; set; }

	public string InternalId { get; set; }

	public string SourceSharedActionId { get; set; }

	public int? SourceSharedActionRevision { get; set; }

	public ActionUserLimitation UserLimitation { get; set; }

	public string SourceActionId { get; set; }

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

	public Guid? SharedProfileId { get; set; }

	public string Tags { get; set; }

	public int DataHash { get; set; }

	public string Note { get; set; }

	public string InstallAlert { get; set; }

	public bool NeedVerify { get; set; }

	public bool IsPublic { get; set; } = true;

	public bool IsOfficial { get; set; }

	public bool ShowInToolbox { get; set; }

	public bool RequireAdj { get; set; }

	public string AdminComment { get; set; }

	public bool IsBest { get; set; }

	public bool HasShow { get; set; }

	public int Completeness { get; set; }

	public int Complexity { get; set; }

	public int Revision { get; set; }

	public string ChangeLog { get; set; }

	public DateTime? LastUpdateTimeUtc { get; set; }

	public string SoftVersion { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string UserId { get; set; }

	public string UserNickName { get; set; }

	public bool CanceledByUser { get; set; }

	public DateTime? CancelTimeUtc { get; set; }

	public bool IsDeleted { get; set; }

	public int UseCount { get; set; }

	public int ClickCount { get; set; }

	public int ReviewCount { get; set; }

	public int TotalScore { get; set; }

	public int VoteCount { get; set; }

	public int ViewCount { get; set; }

	public int DownVoteCount { get; set; }

	public int CommentCount { get; set; }

	public DateTime? LastCommentTimeUtc { get; set; }

	public int SuccessCount { get; set; }

	public int FailCount { get; set; }

	public int UserSerial { get; set; }

	public ActionReviewState ReviewState { get; set; }

	[JsonIgnore]
	public int TotalVerify => SuccessCount + FailCount;

	[JsonIgnore]
	public string VerifyData => $"{SuccessCount}/{SuccessCount + FailCount}";

	public bool HasDetail { get; set; }

	public bool AsSubProgram { get; set; }

	public string Url { get; set; }

	public string MinQuickerVersion { get; set; }

	public string ContextMenuData { get; set; }

	public bool AllowScrollTrigger { get; set; }

	[Obsolete]
	public bool IsImageProcessor { get; set; }

	[Obsolete]
	public bool IsTextProcessor { get; set; }

	public ActionAssociation Association { get; set; }

	public bool EnableEvaluateVariable { get; set; } = true;

	public bool DoNotClosePanel { get; set; }

	public string ExtraActionOptions { get; set; }

	public int WarningLevel { get; set; }

	public string WarningMessage { get; set; }

	public string Keywords { get; set; }

	public ActionItem CreateActionItem(bool useLocalSharedAction)
	{
		return new ActionItem
		{
			ActionType = ActionType,
			Title = Title,
			Description = Description,
			Icon = Icon,
			TemplateId = Id.ToString(),
			TemplateRevision = Revision,
			UseTemplate = useLocalSharedAction,
			MinQuickerVersion = MinQuickerVersion,
			ContextMenuData = ContextMenuData,
			EnableEvaluateVariable = EnableEvaluateVariable,
			DoNotClosePanel = DoNotClosePanel,
			AllowScrollTrigger = AllowScrollTrigger,
			Association = Association,
			Children = (useLocalSharedAction ? null : Children),
			Data = (useLocalSharedAction ? null : Data),
			Data2 = (useLocalSharedAction ? null : Data2),
			Data3 = (useLocalSharedAction ? null : Data3),
			LastEditTimeUtc = null,
			AsSubProgram = AsSubProgram,
			UserLimitation = UserLimitation
		};
	}
}
