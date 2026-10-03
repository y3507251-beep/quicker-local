using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Services.Trans;

public enum CommonLanguage
{
	[Display(Name = "自动")]
	Auto,
	[Display(Name = "简体中文")]
	ZhCn,
	[Display(Name = "英文")]
	En,
	[Display(Name = "日文")]
	Ja,
	[Display(Name = "韩文")]
	Ko
}
