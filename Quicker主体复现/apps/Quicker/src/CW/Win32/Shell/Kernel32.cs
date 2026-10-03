using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32.Shell;

public static class Kernel32
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateSymbolicLinkW", SetLastError = true)]
	public static extern bool CreateSymbolicLink([In] string lpSymlinkFileName, [In] string lpTargetFileName, SymbolicLinkKind dwFlags);

	[DllImport("kernel32", CharSet = CharSet.Auto)]
	public static extern int GetShortPathName(string path, StringBuilder shortName, int bufferSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern int GetLongPathName(string path, StringBuilder longName, int bufferSize);
}
