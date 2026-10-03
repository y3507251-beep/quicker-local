using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[CompilerGenerated]
[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
[DefaultMember("Title")]
[TypeIdentifier]
public interface Folder
{
	[DispId(0)]
	string Title
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap1_3();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743812)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItems Items();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743813)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItem ParseName([In][MarshalAs(UnmanagedType.BStr)] string bName);

	void _VtblGap2_3();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743817)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetDetailsOf([In][MarshalAs(UnmanagedType.Struct)] object vItem, [In] int iColumn);
}
