namespace Quicker.Common.Entities;

public class ContextMenuSettings
{
	public bool EnableControlLongCTrigger { get; set; }

	public int TriggerIntervalMs { get; set; } = 350;

	public string ImageSearchUrls { get; set; } = "[fa:Brands_YandexInternational]Yandex|https://yandex.com/images/search?source=collections&rpt=imageview&url=%s\r\n[fa:Brands_Google]Google|https://lens.google.com/uploadbyurl?url=%s\r\n";

	public string TextSearchUrls { get; set; } = "[fa:Brands_Google]Google|https://www.google.com/search?q=%s\r\n百度|https://www.baidu.com/s?wd=%s\r\n必应|https://cn.bing.com/search?q=%s";

	public string FileMoveTargets { get; set; }

	public bool UseWindowsShellMoveInto { get; set; }
}
