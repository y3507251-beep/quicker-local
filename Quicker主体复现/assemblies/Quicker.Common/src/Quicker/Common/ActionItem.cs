using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Quicker.Common.Entities;

namespace Quicker.Common;

[Serializable]
[JsonObject]
public class ActionItem
{
	public int Row { get; set; }

	public int Col { get; set; }

	public ActionType ActionType { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string Icon { get; set; }

	public string Path { get; set; }

	public int DelayMs { get; set; }

	public string Data { get; set; }

	public string Data2 { get; set; }

	public string Data3 { get; set; }

	public IList<ActionItem> Children { get; set; }

	public string Id { get; set; }

	public string TemplateId { get; set; }

	public int TemplateRevision { get; set; }

	public bool UseTemplate { get; set; }

	public DateTime? LastEditTimeUtc { get; set; }

	public string SharedActionId { get; set; }

	public DateTime? ShareTimeUtc { get; set; }

	public DateTime? CreateTimeUtc { get; set; }

	public bool AsSubProgram { get; set; }

	public bool SkipWhenStopRunningActions { get; set; }

	// 保留用户对手动动作更新的忽略设置；后台检查由主程序独立禁用。
	public bool SkipCheckUpdate { get; set; }

	// 动作仅在用户主动导入或手动更新时替换；不接受后台自动更新开关。
	public bool AutoUpdate
	{
		get => false;
		set { }
	}

	public bool KeepInfoWhenUpdate { get; set; }

	public string MinQuickerVersion { get; set; }

	public string ContextMenuData { get; set; }

	public bool AllowScrollTrigger { get; set; }

	public bool EnableEvaluateVariable { get; set; } = true;

	[Obsolete]
	public bool IsTextProcessor { get; set; }

	[Obsolete]
	public bool IsImageProcessor { get; set; }

	public ActionAssociation Association { get; set; }

	public bool? DoNotClosePanel { get; set; }

	public ActionUserLimitation? UserLimitation { get; set; }

	public void EnsureAssociation()
	{
		if (Association == null)
		{
			Association = new ActionAssociation();
		}
	}

	public ActionItem()
	{
		Id = Guid.NewGuid().ToString();
	}
}
