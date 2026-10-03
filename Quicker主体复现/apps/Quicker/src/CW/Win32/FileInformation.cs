using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CW.Win32;

[StructLayout(LayoutKind.Sequential)]
public class FileInformation
{
	[CompilerGenerated]
	private DateTime Yn8C7tttnB;

	[CompilerGenerated]
	private DateTime HtECRiXbQu;

	[CompilerGenerated]
	private DateTime RM1CqO894F;

	[CompilerGenerated]
	private int sWMCcoCIDZ;

	[CompilerGenerated]
	private long WAyCVhGxvF;

	[CompilerGenerated]
	private int XdJCZHA19s;

	[CompilerGenerated]
	private long dHMC9WXypV;

	internal static FileInformation EC1llD0l0mdv6OoiFVA;

	public DateTime CreationTime
	{
		[CompilerGenerated]
		get
		{
			return Yn8C7tttnB;
		}
		[CompilerGenerated]
		private set
		{
			Yn8C7tttnB = value;
		}
	}

	public DateTime LastWriteTime
	{
		[CompilerGenerated]
		get
		{
			return HtECRiXbQu;
		}
		[CompilerGenerated]
		private set
		{
			HtECRiXbQu = value;
		}
	}

	public DateTime LastAccessTime
	{
		[CompilerGenerated]
		get
		{
			return RM1CqO894F;
		}
		[CompilerGenerated]
		private set
		{
			RM1CqO894F = value;
		}
	}

	public int VolumeSerialNumber
	{
		[CompilerGenerated]
		get
		{
			return sWMCcoCIDZ;
		}
		[CompilerGenerated]
		private set
		{
			sWMCcoCIDZ = value;
		}
	}

	public long Length
	{
		[CompilerGenerated]
		get
		{
			return WAyCVhGxvF;
		}
		[CompilerGenerated]
		private set
		{
			WAyCVhGxvF = value;
		}
	}

	public int LinkCount
	{
		[CompilerGenerated]
		get
		{
			return XdJCZHA19s;
		}
		[CompilerGenerated]
		private set
		{
			XdJCZHA19s = value;
		}
	}

	public long FileIndex
	{
		[CompilerGenerated]
		get
		{
			return dHMC9WXypV;
		}
		[CompilerGenerated]
		private set
		{
			dHMC9WXypV = value;
		}
	}

	public FileInformation(string file)
	{
		file = Path.GetFullPath(file);
		using SafeFileHandle file2 = OpenFile(file);
		ByHandleFileInformation fileInformation = default(ByHandleFileInformation);
		if (!Kernel32.GetFileInformationByHandle(file2, out fileInformation))
		{
			throw new FileLoadException("GetFileInformationByHandle faild", new Win32Exception(Marshal.GetLastWin32Error()));
		}
		CreationTime = eX7CN4KGFL(fileInformation.CreationTime);
		LastWriteTime = eX7CN4KGFL(fileInformation.LastWriteTime);
		LastAccessTime = eX7CN4KGFL(fileInformation.LastAccessTime);
		VolumeSerialNumber = fileInformation.VolumeSerialNumber;
		Length = U4bCJqJOf6(fileInformation.FileSizeHigh, fileInformation.FileSizeLow);
		FileIndex = U4bCJqJOf6(fileInformation.FileIndexHigh, fileInformation.FileIndexLow);
	}

	private static SafeFileHandle OpenFile(string file)
	{
		SafeFileHandle safeFileHandle = Kernel32.CreateFileW(file, (FileAccess)0, FileShare.Read | FileShare.Delete, IntPtr.Zero, FileMode.Open, FileOptions.None, IntPtr.Zero);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (safeFileHandle == null || safeFileHandle.IsInvalid)
		{
			throw new FileLoadException("CreateFileW failed", new Win32Exception(lastWin32Error));
		}
		return safeFileHandle;
	}

	private static DateTime eX7CN4KGFL(FileTime fileTime_0)
	{
		return new DateTime(U4bCJqJOf6(fileTime_0.HighDateTime, fileTime_0.LowDateTime)).AddYears(1600);
	}

	private static long U4bCJqJOf6(int int_2, int int_3)
	{
		return ((long)int_2 << 32) + int_3;
	}

	internal static bool ad83Nx0ZIfiVM4EHJ1K()
	{
		return EC1llD0l0mdv6OoiFVA == null;
	}
}
