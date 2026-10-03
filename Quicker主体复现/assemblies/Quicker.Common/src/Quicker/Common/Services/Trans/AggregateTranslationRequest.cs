using System;

namespace Quicker.Common.Services.Trans;

public class AggregateTranslationRequest
{
	public Guid RequestId { get; set; }

	public string Text { get; set; }

	public string SrcLang { get; set; }

	public string DstLang { get; set; }

	public string Vendors { get; set; }
}
