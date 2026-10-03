using System;
using Newtonsoft.Json;

namespace Quicker.Common.Vm;

public class SharedActionListDto
{
	public Guid Id { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string ExeFile { get; set; }

	public ActionType ActionType { get; set; }

	public string Icon { get; set; }

	public string Tags { get; set; }

	public string Note { get; set; }

	public bool IsOfficial { get; set; }

	public int Revision { get; set; }

	public bool HasDetail { get; set; }

	public DateTime? LastUpdateTimeUtc { get; set; }

	public int UseCount { get; set; }

	public int SuccessCount { get; set; }

	public int FailCount { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public string UserNickName { get; set; }

	public int UserSerial { get; set; }

	public int VoteCount { get; set; }

	[JsonIgnore]
	public int TotalVerify => SuccessCount + FailCount;

	[JsonIgnore]
	public string VerifyData => $"{SuccessCount}/{SuccessCount + FailCount}";

	[JsonIgnore]
	public string Tooltip => "适用于：" + ExeFile + "\n分类：" + Tags + "\n说明：" + Description + "\n备注：" + Note;

	public int DataSize { get; set; }

	public int AvgDayUseCount { get; set; }

	public int TotalUseCount { get; set; }
}
