namespace Quicker.Common.Entities;

public class CircleMenuUiSettings
{
	public string LabelColor { get; set; } = "#000";

	public string ButtonBgColor { get; set; } = "#00000000";

	public string ButtonHoverColor { get; set; } = "#A0E0E0E0";

	public string ButtonSpaceColor { get; set; } = "#A0E0E0E0";

	public string IndicateLineColor { get; set; } = "#FF0000";

	public string DefaultIconColor { get; set; } = "#FF696969";

	public double BgOpacity { get; set; } = 0.93;

	public string BgFill { get; set; } = "#FFFFFFFF";

	public double BgOverlyOpacity { get; set; }

	public string BgOverlyFill { get; set; } = "#FFFFFFFF";

	public bool ShowShadow { get; set; }
}
