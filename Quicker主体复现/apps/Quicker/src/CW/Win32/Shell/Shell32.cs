using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CW.Win32.Shell;

public static class Shell32
{
	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	public static extern OLEError SHEmptyRecycleBin(IntPtr hwnd, string drive, SHEmptyRecycleBinOptions options);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	public static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string file, int index, out IntPtr largeIconHandle, out IntPtr smallIconHandle, int icons);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SHGetFileInfo(string pszPath, FileAttributes attr, ref SHFileInfo psfi, int cbSizeFileInfo, SHGetFileInfoOptions uFlags);

	[DllImport("Shell32.dll", EntryPoint = "#727")]
	public static extern int SHGetImageList(ImageListSize iImageList, ref Guid riid, out IImageList ppv);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShellExecuteEx(ref ShellExecuteInfo shinfo);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	public static extern int SHGetDesktopFolder(out IntPtr ppshf);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	public static extern uint SHGetSpecialFolderLocation(IntPtr hwnd, int CSIDL, out IntPtr pidl);

	[DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
	public static extern int PathCommonPrefix(string path1, string path2, StringBuilder commonPrefix);

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode, EntryPoint = "CommandLineToArgvW")]
	internal static extern IntPtr J6NPTpofjE([MarshalAs(UnmanagedType.LPWStr)] string string_0, out int int_0);

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode, PreserveSig = false, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public static extern object SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string pszPath, IBindCtx pbc, ref Guid riid);

	[DllImport("shell32")]
	public static extern int SHCreateShellItemArray(IntPtr pidlParent, IShellFolder psf, uint cidl, IntPtr[] ppidl, out IShellItemArray ppsiItemArray);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "SHCreateItemFromParsingName", SetLastError = true)]
	internal static extern int O83PMFKbJ8([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out IShellItem ishellItem_0);

	[DllImport("shell32")]
	public static extern int SHCreateShellItemArrayFromIDLists(int cidl, IntPtr[] rgpidl, out IShellItemArray ppsiItemArray);

	[DllImport("shell32")]
	public static extern IntPtr ILCreateFromPath(string path);

	[DllImport("shell32")]
	public static extern void ILFree(IntPtr pidl);

	[DllImport("Shell32.dll")]
	public static extern void SHParseDisplayName([MarshalAs(UnmanagedType.LPWStr)] string name, IntPtr bindingContext, out IntPtr pidl, uint sfgaoIn, out uint psfgaoOut);
}
