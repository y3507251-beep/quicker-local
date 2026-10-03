using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class ShareProfileVm
{
	public string Name { get; set; }

	public string ProfileId { get; set; }

	public ProfileType ProfileType { get; set; }

	public string ExeFile { get; set; } = "";

	public string ExeFullpath { get; set; }

	public IList<ActionItem> ActionItems { get; set; } = new List<ActionItem>();

	public string Description { get; set; }

	public ShareProfileVm()
	{
	}

	public ShareProfileVm(ActionProfile profile)
	{
		Name = profile.Name;
		ProfileId = profile.Id;
		ProfileType = ProfileType.Application;
		ExeFile = profile.ExeFile;
		ExeFullpath = profile.ExeFullpath;
	}
}
