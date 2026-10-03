using System;
using System.Collections.Generic;

namespace Quicker.Common.Services.Trans;

public class MultiVendorTranslationResponse
{
	public Guid RequestId { get; set; }

	public IDictionary<string, string> Result { get; set; }

	public IDictionary<string, string> RawData { get; set; }
}
