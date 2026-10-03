namespace Quicker.Common.Entities;

public class UiSettings
{
	public string BackgroundColor { get; set; } = "#99B0B0B0";

	public string ToolbarColor { get; set; } = "#00999999";

	public string ToolbarBtnColor { get; set; } = "#FF666666";

	public double ButtonSize { get; set; } = 77.0;

	public double ButtonCornerRadius { get; set; }

	public double ButtonSpace { get; set; } = 1.0;

	public double FrameBorderWidth { get; set; } = 2.0;

	public bool HideLabelIfHasIcon { get; set; }

	public string ButtonBgColor { get; set; } = "#FFFFFFFF";

	public string InvalidButtonBgColor { get; set; } = "#32c8c8c8";

	public int BlurMode { get; set; } = 3;

	public int RoundCornerMode { get; set; }

	public uint BlurOpacity { get; set; }

	public string HoverColor { get; set; } = "#FFB2F2FF";

	public string EmptyHoverColor { get; set; } = "#05000000";

	public string LabelColor { get; set; } = "#FF000000";

	public string DefaultIconColor { get; set; } = "#FF696969";

	public string DefaultIconColorForOtherUi { get; set; } = "#FF666666";

	public string KeyTipColor { get; set; } = "#D0ff8c00";

	public bool EnableZoomEffect { get; set; } = true;

	public string FontFamily1 { get; set; }

	public string FontFamily2 { get; set; }

	public double FontSize { get; set; } = 12.0;

	public int FontWeight { get; set; } = 400;

	public string BackgroundImage { get; set; }

	public double BackgroundImageOpacity { get; set; } = 1.0;

	public bool EnableShadow { get; set; }

	public bool EnableResizeFont { get; set; } = true;

	public CircleMenuUiSettings CircleMenu { get; private set; } = new CircleMenuUiSettings();

	public void ResetCircleMenuUiSettings(CircleMenuUiSettings settings)
	{
		settings = settings ?? new CircleMenuUiSettings();
		CircleMenu = settings;
	}

	public void RestoreCircleMenuSettings(CircleMenuUiSettings circleMenu)
	{
		CircleMenu = circleMenu;
	}
}
