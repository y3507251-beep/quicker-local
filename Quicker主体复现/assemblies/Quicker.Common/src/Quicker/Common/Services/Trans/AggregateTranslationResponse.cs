using System;
using System.Collections.Generic;

namespace Quicker.Common.Services.Trans;

public class AggregateTranslationResponse
{
	public Guid RequestId { get; set; }

	public IDictionary<string, string> VendorResults { get; set; }

	public IDictionary<string, object> VendorOriginData { get; set; }

	public int CostPoints { get; set; }
}
