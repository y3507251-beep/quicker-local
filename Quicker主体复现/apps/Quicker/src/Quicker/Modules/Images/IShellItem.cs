using System;
using System.Runtime.InteropServices;
using K3vXKW2s7JXyvDERJZ3;

namespace Quicker.Modules.Images;

[ComImport]
[Guid("43826d1e-e718-42ee-bc55-a1e261c37bfe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IShellItem
{
	void BindToHandler(IntPtr pbc, [MarshalAs(UnmanagedType.LPStruct)] Guid bhid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

	void GetParent(out IShellItem ppsi);

	void GetDisplayName(qcqc4b2OPckAjb5FIAh sigdnName, out IntPtr ppszName);

	void GetAttributes(uint sfgaoMask, out uint psfgaoAttribs);

	void Compare(IShellItem psi, uint hint, out int piOrder);
}
