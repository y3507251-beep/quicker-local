using System;
using System.IO;
using System.Reflection;
using CW.Win32.Shell;
using log4net;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.Win32;

public static class FileSystemHelper
{
	private static readonly ILog uJALOGpeH5G;

	private static object IW3puEFPaM5A7HIyd6Ck;

	public static string RenameFileOrFolder(string sourcePath, string newPathOrName, bool overwrite)
	{
		string text = (A5BLOWByvw9(newPathOrName) ? YtbLOkrsNpx(sourcePath, newPathOrName) : newPathOrName);
		if (File.Exists(sourcePath))
		{
			if (File.Exists(text))
			{
				if (!overwrite)
				{
					throw new Exception("目标路径已存在(" + text + ")。");
				}
				File.Delete(text);
			}
			File.Move(sourcePath, text);
		}
		else
		{
			if (!Directory.Exists(sourcePath))
			{
				throw new Exception("源路径不存在(" + sourcePath + ")。");
			}
			if (!WmNGrCFPrJTbEHQnLurZ())
			{
				switch (0)
				{
				}
			}
			Directory.Move(sourcePath, text);
		}
		return text;
	}

	public static void MoveIntoFolder(string sourcePath, string targetFolder, bool overwrite, bool autoRename)
	{
        string fileNameWithoutExtension = default;
        string extension = default;
        int num2 = default;
        string fileName = default;
        int num = default;
		sourcePath = sourcePath.TrimEnd('/', '\\');
		EnsureFolderExists(targetFolder);
		string text = default(string);
		if (File.Exists(sourcePath))
		{
			text = Path.Combine(targetFolder, Path.GetFileName(sourcePath));
			if (string.Equals(sourcePath, text))
			{
				uJALOGpeH5G.Info("源路径(" + sourcePath + ")和目标路径相同，不需要移动。");
				return;
			}
			if (File.Exists(text))
			{
				if (autoRename)
				{
					goto IL_00e0;
				}
				if (overwrite)
				{
					File.Delete(text);
				}
			}
			goto IL_0198;
		}
		fileName = default(string);
		string text2;
		num = default(int);
		if (Directory.Exists(sourcePath))
		{
			fileName = Path.GetFileName(sourcePath);
			text2 = Path.Combine(targetFolder, fileName);
			if (File.Exists(text2))
			{
				if (autoRename)
				{
					num = 1;
					text2 = Path.Combine(targetFolder, $"{fileName}({1})");
					goto IL_015e;
				}
				throw new Exception("文件夹 " + fileName + " 已在目标位置存在同名的文件。");
			}
			goto IL_01c9;
		}
		throw new Exception("复制出错。源路径不存在：" + sourcePath);
		IL_00e0:
		fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourcePath);
		extension = Path.GetExtension(sourcePath);
		num2 = 1;
		text = Path.Combine(targetFolder, $"{fileNameWithoutExtension}({1}){extension}");
		int num3 = 0;
		if (!WmNGrCFPrJTbEHQnLurZ())
		{
			goto IL_011c;
		}
		goto IL_0120;
		IL_01c9:
		DirectoryCopy(sourcePath, text2, true, overwrite);
		Directory.Delete(sourcePath, true);
		return;
		IL_0198:
		MoveFileCrossDrive(sourcePath, text);
		return;
		IL_018f:
		while (File.Exists(text))
		{
			num2++;
			text = Path.Combine(targetFolder, $"{fileNameWithoutExtension}({num2}){extension}");
		}
		goto IL_0198;
		IL_015e:
		if (Directory.Exists(text2) || File.Exists(text2))
		{
			num++;
			num3 = 1;
			if (!WmNGrCFPrJTbEHQnLurZ())
			{
				goto IL_011c;
			}
			goto IL_0120;
		}
		goto IL_01c9;
		IL_011c:
		int num4 = default(int);
		num3 = num4;
		goto IL_0120;
		IL_0133:
		text2 = Path.Combine(targetFolder, $"{fileName}({num})");
		goto IL_015e;
		IL_0120:
		switch (num3)
		{
		case 2:
			break;
		case 1:
			goto IL_0133;
		default:
			goto IL_018f;
		}
		goto IL_00e0;
	}

	public static void MoveIntoFolderWithShell(string[] sourcePathList, string targetFolder)
	{
		EnsureFolderExists(targetFolder);
		using FileOperation fileOperation = new FileOperation();
		fileOperation.Move(sourcePathList, targetFolder);
	}

	public static void MoveFileCrossDrive(string source, string dest)
	{
		if (string.Equals(source.Substring(0, 2), dest.Substring(0, 2), StringComparison.OrdinalIgnoreCase))
		{
			File.Move(source, dest);
			return;
		}
		File.Copy(source, dest);
		File.Delete(source);
	}

	private static bool A5BLOWByvw9(string string_0)
	{
		if (string_0.ContainsAny("\\", "/"))
		{
			return false;
		}
		return true;
	}

	private static string YtbLOkrsNpx(string string_0, string string_1)
	{
		return Path.Combine(Path.GetDirectoryName(string_0), string_1);
	}

	public static bool IsPathExists(this string path)
	{
		try
		{
			return !string.IsNullOrEmpty(path) && (File.Exists(path) || Directory.Exists(path));
		}
		catch
		{
			return false;
		}
	}

	public static void EnsureFileFolderExists(string path)
	{
		try
		{
			string directoryName = Path.GetDirectoryName(path);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
		}
		catch (Exception ex)
		{
			uJALOGpeH5G.Error("EnsureDir错误：" + ex.Message, ex);
		}
	}

	public static void EnsureFolderExists(string folderPath)
	{
		if (!string.IsNullOrEmpty(folderPath) && !Directory.Exists(folderPath))
		{
			Directory.CreateDirectory(folderPath);
		}
	}

	public static string CopyInto(string sourcePath, string dstFolder, bool overwrite)
	{
		EnsureFolderExists(dstFolder);
		string[] array = sourcePath.SplitToList();
		string text = string.Empty;
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			text = Path.Combine(dstFolder, Path.GetFileName(text2));
			if (IW3puEFPaM5A7HIyd6Ck == null)
			{
				switch (0)
				{
				}
			}
			CopyTo(text2, text, overwrite);
		}
		return text;
	}

	public static string CopyTo(string sourcePath, string dstFullPath, bool overwrite)
	{
		while (A5BLOWByvw9(dstFullPath))
		{
			if (!WmNGrCFPrJTbEHQnLurZ())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			dstFullPath = Path.Combine(Path.GetDirectoryName(sourcePath), dstFullPath);
			break;
		}
		EnsureFileFolderExists(dstFullPath);
		if (File.Exists(sourcePath))
		{
			if (string.Equals(sourcePath, dstFullPath, StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException("源路径和目标路径相同，无法复制。");
			}
			if (dstFullPath.IsPathExists())
			{
				if (!overwrite)
				{
					throw new InvalidOperationException("路径已存在：" + dstFullPath);
				}
				File.Delete(dstFullPath);
			}
			File.Copy(sourcePath, dstFullPath);
		}
		else
		{
			if (!Directory.Exists(sourcePath))
			{
				throw new InvalidOperationException("源路径不存在：" + sourcePath);
			}
			DirectoryCopy(sourcePath, dstFullPath, true, overwrite);
		}
		return dstFullPath;
	}

	public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool overwrite)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
		if (!directoryInfo.Exists)
		{
			throw new InvalidOperationException("源目录不存在或无法访问:" + sourceDirName);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (!Directory.Exists(destDirName))
		{
			Directory.CreateDirectory(destDirName);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		int num = 0;
		DirectoryInfo[] array = default(DirectoryInfo[]);
		while (true)
		{
			int num2;
			if (num < files.Length)
			{
				FileInfo fileInfo = files[num];
				string text = Path.Combine(destDirName, fileInfo.Name);
				if (overwrite || !File.Exists(text))
				{
					fileInfo.CopyTo(text, overwrite);
					num2 = 1;
					if (IW3puEFPaM5A7HIyd6Ck != null)
					{
						goto IL_00c8;
					}
					goto IL_00b9;
				}
				throw new InvalidOperationException("目标文件" + text + "已经存在！");
			}
			if (copySubDirs)
			{
				array = directories;
				num = 0;
				goto IL_007a;
			}
			break;
			IL_007a:
			if (num < array.Length)
			{
				DirectoryInfo directoryInfo2 = array[num];
				string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
				DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs, overwrite);
				num2 = 0;
				if (IW3puEFPaM5A7HIyd6Ck != null)
				{
					goto IL_00b3;
				}
				goto IL_00b9;
			}
			break;
			IL_00b9:
			switch (num2)
			{
			case 1:
				goto IL_00c8;
			}
			goto IL_00b3;
			IL_00c8:
			num++;
			continue;
			IL_00b3:
			num++;
			goto IL_007a;
		}
	}

	public static bool IsValidFilePath(this string path)
	{
		if (path != null && path.Length >= 7 && path.Length <= 250)
		{
			if (Uri.TryCreate(path, UriKind.Absolute, out var result) && result != null)
			{
				return result.IsLoopback;
			}
			return false;
		}
		return false;
	}

	static FileSystemHelper()
	{
		uJALOGpeH5G = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool WmNGrCFPrJTbEHQnLurZ()
	{
		return IW3puEFPaM5A7HIyd6Ck == null;
	}
}
