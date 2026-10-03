using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Entities;

public enum FeedbackType
{
	[Display(Name = "异常")]
	ExceptionReport = 1,
	[Display(Name = "用户反馈")]
	UserFeedback,
	[Display(Name = "已过滤的异常")]
	FilteredException,
	[Display(Name = "捕获的异常")]
	CaughtException
}
