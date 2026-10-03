using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("286E6F1B-7113-4355-9562-96B7E9D64C54")]
public interface IShellDispatch6 : IShellDispatch5
{
	void _VtblGap1_2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743810)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Folder NameSpace([In][MarshalAs(UnmanagedType.Struct)] object vDir);

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743812)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object Windows();
}
