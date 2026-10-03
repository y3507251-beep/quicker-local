using System;

namespace Quicker.Common.Services.Trans;

public class TranslationResponse
{
	public Guid RequestId { get; set; }

	public string Result { get; set; }

	public string RawData { get; set; }
}
