using System;
using System.Collections.Generic;

namespace Quicker.Common.Vm.Depd;

public class PackageInfoDto
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public string Version { get; set; }

	public DateTime CreateTimeUtc { get; set; }

	public int UserSerial { get; set; }

	public string UserNickName { get; set; }

	public string ExistenceRule { get; set; }

	public string InstallCommand { get; set; }

	public bool RunAsAdmin { get; set; }

	public IList<string> DownloadLinks { get; set; }

	public int FileSize { get; set; }
}
