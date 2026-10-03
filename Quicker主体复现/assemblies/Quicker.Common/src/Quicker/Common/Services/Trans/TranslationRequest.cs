using System;
using Quicker.Common.Enums;

namespace Quicker.Common.Services.Trans;

public class TranslationRequest : TranslateRequestBase
{
	public Guid RequestId { get; set; }

	public Vendors Vendor { get; set; }
}
