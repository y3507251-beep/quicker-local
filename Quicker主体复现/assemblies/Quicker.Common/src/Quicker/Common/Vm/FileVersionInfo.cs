using System.Diagnostics;

namespace Quicker.Common.Vm;

public class FileVersionInfo
{
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

	public FileVersionInfo()
	{
	}

	public FileVersionInfo(System.Diagnostics.FileVersionInfo source)
	{
		Comments = source.Comments;
		CompanyName = source.CompanyName;
		FileBuildPart = source.FileBuildPart;
		FileDescription = source.FileDescription;
		FileMajorPart = source.FileMajorPart;
		FileMinorPart = source.FileMinorPart;
		FileName = source.FileName;
		FilePrivatePart = source.FilePrivatePart;
		FileVersion = source.FileVersion;
		InternalName = source.InternalName;
		IsDebug = source.IsDebug;
		IsPatched = source.IsPatched;
		IsPreRelease = source.IsPreRelease;
		IsPrivateBuild = source.IsPrivateBuild;
		IsSpecialBuild = source.IsSpecialBuild;
		Language = source.Language;
		LegalCopyright = source.LegalCopyright;
		LegalTrademarks = source.LegalTrademarks;
		OriginalFilename = source.OriginalFilename;
		PrivateBuild = source.PrivateBuild;
		ProductBuildPart = source.ProductBuildPart;
		ProductMajorPart = source.ProductMajorPart;
		ProductMinorPart = source.ProductMinorPart;
		ProductName = source.ProductName;
		ProductPrivatePart = source.ProductPrivatePart;
		ProductVersion = source.ProductVersion;
		SpecialBuild = source.SpecialBuild;
	}
}
