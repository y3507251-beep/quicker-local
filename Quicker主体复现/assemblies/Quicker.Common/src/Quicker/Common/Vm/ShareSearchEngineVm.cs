using System;

namespace Quicker.Common.Vm;

public class ShareSearchEngineVm
{
	public string Name { get; set; }

	public string QueryUrl { get; set; }

	public string TriggerWords { get; set; }

	public string CompletionUrl { get; set; }

	public string CompletionXPath { get; set; }

	public string Icon { get; set; }

	public Guid CategoryId { get; set; }
}
