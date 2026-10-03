using System.Runtime.InteropServices;

namespace CW.Win32;

[ComImport]
[Guid("1f76a169-f994-40ac-8fc8-0959e8874710")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IApplicationAssociationRegistrationUI
{
	int LaunchAdvancedAssociationUI(string appRegisterName);
}
