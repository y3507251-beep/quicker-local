using System;
using System.Collections.Generic;

namespace Quicker.Common.QuickActions;

public class PowerKey
{
	public Guid Id { get; set; }

	public int Key { get; set; }

	public bool KeepOriginKeyFunc { get; set; }

	public bool IsEnabled { get; set; }

	public string BlackList { get; set; }

	public IList<PowerKeyActionItem> KeyActions { get; set; }
}
