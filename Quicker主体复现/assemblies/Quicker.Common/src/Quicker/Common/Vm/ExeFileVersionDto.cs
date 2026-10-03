using System;

namespace Quicker.Common.Vm;

public class ExeFileVersionDto
{
	public int Id { get; set; }

	public string ExeFileName { get; set; }

	public int FileSize { get; set; }

	public string Platform { get; set; }

	public string FilePath { get; set; }

	public string Sha1Hash { get; set; }

	public string FileIconUrl { get; set; }

	public DateTime CreateTimeUtc { get; set; } = DateTime.UtcNow;

	public string Comments { get; set; }

	public string CompanyName { get; set; }

	public int FileBuildPart { get; set; }

	public string FileDescription { get; set; }

	public int FileMajorPart { get; set; }

	public int FileMinorPart { get; set; }

	public string FileName { get; set; }

	public int FilePrivatePart { get; set; }

	public string FileVersion { get; set; }

	public string InternalName { get; set; }

	public bool IsDebug { get; set; }

	public bool IsPatched { get; set; }

	public bool IsPreRelease { get; set; }

	public bool IsPrivateBuild { get; set; }

	public bool IsSpecialBuild { get; set; }

	public string Language { get; set; }

	public string LegalCopyright { get; set; }

	public string LegalTrademarks { get; set; }

	public string OriginalFilename { get; set; }

	public string PrivateBuild { get; set; }

	public int ProductBuildPart { get; set; }

	public int ProductMajorPart { get; set; }

	public int ProductMinorPart { get; set; }

	public string ProductName { get; set; }

	public int ProductPrivatePart { get; set; }

	public string ProductVersion { get; set; }

	public string SpecialBuild { get; set; }
}
