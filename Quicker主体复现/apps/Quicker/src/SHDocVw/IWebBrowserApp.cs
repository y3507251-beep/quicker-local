using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("0002DF05-0000-0000-C000-000000000046")]
[CompilerGenerated]
[DefaultMember("Name")]
[TypeIdentifier]
public interface IWebBrowserApp : IWebBrowser
{
	void _VtblGap1_29();

	[DispId(0)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
