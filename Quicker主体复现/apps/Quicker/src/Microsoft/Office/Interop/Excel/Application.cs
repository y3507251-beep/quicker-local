using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208D5-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CoClass(typeof(Object))]
[CompilerGenerated]
public interface Application : AppEvents_Event, _Application
{
}
