using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(Object))]
[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
[CompilerGenerated]
[TypeIdentifier]
public interface ShellWindows : DShellWindowsEvents_Event, IShellWindows
{
}
