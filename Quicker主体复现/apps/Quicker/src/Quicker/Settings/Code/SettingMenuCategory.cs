using System.ComponentModel.DataAnnotations;

namespace Quicker.Settings.Code;

public enum SettingMenuCategory
{
	[Display(Name = "基础设置")]
	Basic,
	[Display(Name = "辅助功能")]
	Features,
	[Display(Name = "工具")]
	Others
}
