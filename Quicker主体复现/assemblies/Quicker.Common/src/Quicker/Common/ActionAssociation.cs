using System;
using Newtonsoft.Json;

namespace Quicker.Common;

[Serializable]
[JsonObject]
public class ActionAssociation
{
	public string MatchProcess { get; set; }

	public bool IsImageProcessor { get; set; }

	public bool ReturnImageFromFirstScreenShotStep { get; set; } = true;

	public bool IsTextProcessor { get; set; }

	public bool ReturnTextFromGetSelectedTextStep { get; set; } = true;

	public string TextMatchExpression { get; set; }

	public int TextMinLength { get; set; }

	public int TextMaxLength { get; set; }

	public bool IsHtmlProcessor { get; set; }

	public bool IsFileProcessor { get; set; }

	public int FileMinCount { get; set; }

	public int FileMaxCount { get; set; }

	public string AllowedFileExtensions { get; set; }

	public bool RequireAllFileMatchExt { get; set; }

	public string SearchBoxPlaceholder { get; set; }

	public bool IsWindowProcessor { get; set; }

	public bool EnableRealtimeSearch { get; set; }

	public BrowserContextMenuBinding BrowserContextMenu { get; set; }

	public string UrlPattern { get; set; }
}
