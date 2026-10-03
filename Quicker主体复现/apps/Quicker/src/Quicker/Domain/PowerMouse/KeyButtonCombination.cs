using System.ComponentModel.DataAnnotations;

namespace Quicker.Domain.PowerMouse;

public enum KeyButtonCombination
{
	[Display(Name = "-无-")]
	NA = 0,
	[Display(Name = "中键")]
	Middle = 2,
	[Display(Name = "右键")]
	Right = 4,
	[Display(Name = "X1键")]
	X1 = 5,
	[Display(Name = "X2键")]
	X2 = 6
}
