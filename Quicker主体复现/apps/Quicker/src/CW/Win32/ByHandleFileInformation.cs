using System.IO;

namespace CW.Win32;

public struct ByHandleFileInformation
{
	public FileAttributes FileAttributes;

	public FileTime CreationTime;

	public FileTime LastWriteTime;

	public FileTime LastAccessTime;

	public int VolumeSerialNumber;

	public int FileSizeHigh;

	public int FileSizeLow;

	public int NumberOfLinks;

	public int FileIndexHigh;

	public int FileIndexLow;
}
