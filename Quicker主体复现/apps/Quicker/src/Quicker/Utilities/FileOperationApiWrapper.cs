using System;
using System.Runtime.InteropServices;

namespace Quicker.Utilities;

public static class FileOperationApiWrapper
{
	[Flags]
	public enum FileOperationFlags : ushort
	{
		FOF_SILENT = 4,
		FOF_NOCONFIRMATION = 0x10,
		FOF_ALLOWUNDO = 0x40,
		FOF_SIMPLEPROGRESS = 0x100,
		FOF_NOERRORUI = 0x400,
		FOF_WANTNUKEWARNING = 0x4000
	}

	public enum FileOperationType : uint
	{
		FO_MOVE = 1u,
		FO_COPY,
		FO_DELETE,
		FO_RENAME
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct rQ0nGGDj0N7gv43GyFq
	{
		public readonly IntPtr lJ42w5CA57f;

		[MarshalAs(UnmanagedType.U4)]
		public FileOperationType hk42wDRTgKu;

		public string Bok2wdQkmn5;

		public readonly string gnq2worukpO;

		public FileOperationFlags vMx2wThe3JL;

		[MarshalAs(UnmanagedType.Bool)]
		public readonly bool usX2wMR9AhU;

		public readonly IntPtr dm12wAEiC35;

		public readonly string teh2wOpxHbG;
	}

	private static object ijxluBFYTgLJdr3G9D4o;

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "SHFileOperation")]
	private static extern int AmoLTtRiLeZ(ref rQ0nGGDj0N7gv43GyFq rQ0nGGDj0N7gv43GyFq_0);

	public static bool Send(string path, FileOperationFlags flags)
	{
		try
		{
			rQ0nGGDj0N7gv43GyFq rQ0nGGDj0N7gv43GyFq_ = new rQ0nGGDj0N7gv43GyFq
			{
				hk42wDRTgKu = FileOperationType.FO_DELETE,
				Bok2wdQkmn5 = path + "\0\0",
				vMx2wThe3JL = (FileOperationFlags.FOF_ALLOWUNDO | flags)
			};
			return AmoLTtRiLeZ(ref rQ0nGGDj0N7gv43GyFq_) == 0;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool Send(string path)
	{
		return Send(path, FileOperationFlags.FOF_NOCONFIRMATION | FileOperationFlags.FOF_WANTNUKEWARNING);
	}

	public static bool MoveToRecycleBin(string path, bool noUi)
	{
		if (noUi)
		{
			return Send(path, FileOperationFlags.FOF_SILENT | FileOperationFlags.FOF_NOCONFIRMATION | FileOperationFlags.FOF_NOERRORUI);
		}
		return Send(path, FileOperationFlags.FOF_ALLOWUNDO);
	}

	private static bool deleteFile(string path, FileOperationFlags flags)
	{
		bool result;
		try
		{
			rQ0nGGDj0N7gv43GyFq rQ0nGGDj0N7gv43GyFq_ = new rQ0nGGDj0N7gv43GyFq
			{
				hk42wDRTgKu = FileOperationType.FO_DELETE,
				Bok2wdQkmn5 = path + "\0\0",
				vMx2wThe3JL = flags
			};
			if (AmoLTtRiLeZ(ref rQ0nGGDj0N7gv43GyFq_) == 0)
			{
				result = true;
			}
			else
			{
				result = false;
				int num = 0;
				if (!r1SsApFYm9k2ROv6gNar())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	public static bool DeleteCompletelySilent(string path)
	{
		return deleteFile(path, FileOperationFlags.FOF_SILENT | FileOperationFlags.FOF_NOCONFIRMATION | FileOperationFlags.FOF_NOERRORUI);
	}

	internal static bool r1SsApFYm9k2ROv6gNar()
	{
		return ijxluBFYTgLJdr3G9D4o == null;
	}
}
