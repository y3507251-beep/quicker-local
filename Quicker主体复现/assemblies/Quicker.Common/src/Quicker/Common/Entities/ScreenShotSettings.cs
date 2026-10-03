using System;

namespace Quicker.Common.Entities;

public class ScreenShotSettings
{
	public bool IsEnabled { get; set; }

	public int Trigger { get; set; }

	public int? AdornKey { get; set; } = 192;

	public bool PinImage { get; set; } = true;

	public bool AutoCopy { get; set; }

	public bool AutoSave { get; set; }

	public string AutoRunAction { get; set; }

	[Obsolete]
	public string ImageSearchUrls { get; set; } = "[fa:Brands_YandexInternational]Yandex|https://yandex.com/images/search?source=collections&rpt=imageview&url=%s\r\n[fa:Brands_Google]Google|http://www.google.com/searchbyimage?image_url=%s\r\n";

	public bool AutoShowMenu { get; set; } = true;

	public bool CloseImageAfterTriggerMenu { get; set; }
}
