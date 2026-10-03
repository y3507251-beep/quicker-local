using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Services;

public enum ServiceVendor
{
	Na,
	[Display(Name = "有道")]
	Youdao,
	[Display(Name = "百度云")]
	Baidu,
	[Display(Name = "腾讯云")]
	Tencent,
	[Display(Name = "彩云")]
	Caiyun,
	[Display(Name = "微软必应")]
	Bing,
	[Display(Name = "腾讯优图")]
	Youtu,
	[Display(Name = "阿里云")]
	Aliyun,
	[Display(Name = "讯飞")]
	Xunfei
}
