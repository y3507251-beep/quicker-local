using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NETWORKLIST;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("DCB00001-570F-4A9B-8D69-199FDBA5723B")]
[InterfaceType(1)]
public interface INetworkListManagerEvents
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void ConnectivityChanged([In] NLM_CONNECTIVITY newConnectivity);
}
