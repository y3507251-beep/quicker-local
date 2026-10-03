using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[TypeIdentifier]
[Guid("31C147B6-0ADE-4A3C-B514-DDF932EF6D17")]
[CompilerGenerated]
public interface IShellFolderViewDual2 : IShellFolderViewDual
{
	void _VtblGap1_2();

	[DispId(1610743810)]
	Folder Folder
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743810)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	FolderItems SelectedItems();

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610743813)]
	void SelectItem([In][MarshalAs(UnmanagedType.Struct)] ref object pvfi, [In] int dwFlags);
}
