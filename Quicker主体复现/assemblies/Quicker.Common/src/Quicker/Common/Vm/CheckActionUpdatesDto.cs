using System;
using System.Collections.Generic;
using Quicker.Common.Entities;

namespace Quicker.Common.Vm;

public class CheckActionUpdatesDto
{
	public class SharedActionInfo
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Icon { get; set; }

		public string Description { get; set; }

		public int Revision { get; set; }

		public DateTime? LastUpdateTimeUtc { get; set; }

		public string LastUpdateNote { get; set; }

		public string MinQuickerVersion { get; set; }

		public ActionUserLimitation? UserLimitation { get; set; }

		public string ContextMenuData { get; set; }
	}

	public IList<SharedActionInfo> SharedActions { get; set; } = new List<SharedActionInfo>();
}
