using System.ComponentModel.DataAnnotations;

namespace Quicker.Common.Vm;

public class ExeFileVersionVm
{
	[MaxLength(1024)]
	public string ExeFileName { get; set; }

	public int FileSize { get; set; }

	[MaxLength(100)]
	public string Platform { get; set; }

	public string FilePath { get; set; }

	public string Sha1Hash { get; set; }

	public string FileIconUrl { get; set; }

	public FileVersionInfo FileVersionInfo { get; set; }
}
