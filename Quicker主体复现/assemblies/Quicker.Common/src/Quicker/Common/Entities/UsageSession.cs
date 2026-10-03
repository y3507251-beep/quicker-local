using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Quicker.Common.Entities;

public class UsageSession
{
	public Guid SessionId { get; set; } = Guid.NewGuid();

	public DateTime SessionStartTimeUtc { get; set; } = DateTime.UtcNow;

	public DateTime LastUpdateTimeUtc { get; set; }

	public DateTime? LocalTime { get; set; }

	public IDictionary<string, int> ActionClickCounts { get; set; } = new ConcurrentDictionary<string, int>();

	public IDictionary<string, string> Names { get; set; } = new ConcurrentDictionary<string, string>();

	public IDictionary<string, int> ProfileClickCounts { get; set; } = new ConcurrentDictionary<string, int>();

	public int PopupCount { get; set; }

	public IDictionary<int, int> MobileMessageCounts { get; set; } = new ConcurrentDictionary<int, int>();
}
