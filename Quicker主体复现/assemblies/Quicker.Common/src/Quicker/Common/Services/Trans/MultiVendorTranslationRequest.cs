using System;

namespace Quicker.Common.Services.Trans;

public class MultiVendorTranslationRequest : TranslateRequestBase
{
	public Guid RequestId { get; set; }

	public string VendorList { get; set; }
}
