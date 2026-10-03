using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
[CoClass(typeof(Object))]
[CompilerGenerated]
[TypeIdentifier]
public interface InternetExplorer : DWebBrowserEvents2_Event, IWebBrowser2
{
}
