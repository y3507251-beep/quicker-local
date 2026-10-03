using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c46ca590-3c3f-11d2-bee6-0000f805ca57")]
public interface IQueryAssociations
{
	int Init(AssociationInitializeOptions options, string assoc, IntPtr hkey, IntPtr hwnd);

	int GetString(AssociationOptions options, AssociationString str, string extra, StringBuilder outStr, out int length);
}
