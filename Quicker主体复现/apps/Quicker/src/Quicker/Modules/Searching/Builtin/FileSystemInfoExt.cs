using System;
using System.IO;

namespace Quicker.Modules.Searching.Builtin;

public static class FileSystemInfoExt
{
	private static object bYBWnSQeBi6Cmjm0nZIG;

	public static DateTime SafeGetCreationTimeUtc(this FileSystemInfo item)
	{
		try
		{
			return item.CreationTimeUtc;
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static DateTime SafeGetLastWriteTimeUtc(this FileSystemInfo item)
	{
		try
		{
			return item.LastWriteTimeUtc;
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static DateTime SafeGetLastAccessTimeUtc(this FileSystemInfo item)
	{
		try
		{
			return item.LastAccessTimeUtc;
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	internal static bool DJyQrtQevkjOlu1tpUbo()
	{
		return bYBWnSQeBi6Cmjm0nZIG == null;
	}
}
