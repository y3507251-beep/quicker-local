using System.ComponentModel.DataAnnotations;

namespace Quicker.Utilities;

public enum ProxyMode
{
	[Display(Name = "禁用代理")]
	Disable,
	[Display(Name = "使用系统代理")]
	System,
	[Display(Name = "自定义代理设置")]
	Custom
}
