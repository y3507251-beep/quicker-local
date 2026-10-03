using System;
using t8SGKhhgLWTgeqjGcrq;

namespace CW.Win32.Shell;

public class ShellItem : ComObject<IShellItem>
{
	private static Guid K2fEgFMPlK;

	internal static ShellItem B63MvFBRxc5Unyryc7v;

	public ShellItem(IShellItem item)
		: base(item)
	{
	}

	public static ShellItem FromPath(string path)
	{
		return new ShellItem((IShellItem)Shell32.SHCreateItemFromParsingName(path, null, ref K2fEgFMPlK));
	}

	static ShellItem()
	{
		K2fEgFMPlK = typeof(global::CW.Win32.Shell.IShellItem).GUID;
	}

	internal static bool JP2qkvBgOmWbvV0Maea()
	{
		return B63MvFBRxc5Unyryc7v == null;
	}
}
