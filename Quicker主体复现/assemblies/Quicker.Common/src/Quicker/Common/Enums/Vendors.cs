using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Enums;

public enum Vendors
{
	Na,
	[Display(Name = "百度")]
	Baidu,
	[Display(Name = "腾讯")]
	Tencent,
	[Display(Name = "有道")]
	Youdao,
	[Display(Name = "阿里云")]
	Aliyun,
	[Display(Name = "谷歌")]
	Google,
	[Display(Name = "必应")]
	Bing,
	[Display(Name = "彩云")]
	Caiyun,
	[Display(Name = "腾讯优图")]
	Youtu,
	[Display(Name = "讯飞")]
	Xunfei,
	[Display(Name = "讯飞(niutrans)")]
	XunfeiNiutrans,
	[Display(Name = "Mathpix图片识别")]
	Mathpix,
	[Display(Name = "Mathpix手写轨迹识别")]
	MathpixStrokes,
	[Display(Name = "Quicker服务")]
	Quicker
}
