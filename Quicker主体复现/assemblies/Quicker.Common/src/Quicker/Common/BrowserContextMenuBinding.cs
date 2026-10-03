using System;
using Newtonsoft.Json;

namespace Quicker.Common;

[Serializable]
[JsonObject]
public class BrowserContextMenuBinding
{
	public string Contexts { get; set; }

	public string Title { get; set; }

	public string DocumentUrlPatterns { get; set; }

	public string TargetUrlPatterns { get; set; }

	public string ActionParam { get; set; }
}
