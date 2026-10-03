using System;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

public class ShellItemArray : ComObject<IShellItemArray>
{
	private string BypELvFVml = "43826D1E-E718-42EE-BC55-A1E261C37BFE";

	private static Guid lpvEvhpB5W;

	internal static ShellItemArray BVLQkgBwSZlWd9AEXVI;

	public ShellItemArray(IShellItemArray array)
		: base(array)
	{
	}

	public static ShellItemArray FromFiles(string[] files)
	{
		files.ThrowIfNull("files");
		IntPtr[] array = new IntPtr[files.Length];
		try
		{
			int num = 0;
			int num2 = 0;
			if (!USOjXQBTRmJdtAmKRIf())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			default:
			{
				for (int i = 0; i < files.Length; i++)
				{
					Shell32.SHParseDisplayName(files[i], IntPtr.Zero, out var pidl, 0u, out var psfgaoOut);
					array[num] = pidl;
					num++;
				}
				Marshal.ThrowExceptionForHR(Shell32.SHCreateShellItemArrayFromIDLists(array.Length, array, out var ppsiItemArray));
				return new ShellItemArray(ppsiItemArray);
			}
			}
		}
		finally
		{
			IntPtr[] array2 = array;
			foreach (IntPtr intPtr in array2)
			{
				if (intPtr != IntPtr.Zero)
				{
					Shell32.ILFree(intPtr);
				}
			}
		}
	}

	static ShellItemArray()
	{
		lpvEvhpB5W = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE");
	}

	internal static bool USOjXQBTRmJdtAmKRIf()
	{
		return BVLQkgBwSZlWd9AEXVI == null;
	}

	internal static void x97okkBs8mrftNQjCiJ()
	{
	}

	internal static void hlencpBCugFLJq3vkFf()
	{
	}
}
