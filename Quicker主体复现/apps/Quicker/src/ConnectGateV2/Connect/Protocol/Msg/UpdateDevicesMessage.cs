using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConnectGateV2.Connect.Protocol.Msg;

public class UpdateDevicesMessage : MessageBase
{
	[CompilerGenerated]
	private IList<string> pPTheWMf8;

	[CompilerGenerated]
	private string pMae9oIB1;

	internal static UpdateDevicesMessage v3v0DScwq0TNX6VQmwy;

	public IList<string> DeviceList
	{
		[CompilerGenerated]
		get
		{
			return pPTheWMf8;
		}
		[CompilerGenerated]
		set
		{
			pPTheWMf8 = value;
		}
	}

	public string ActiveDevice
	{
		[CompilerGenerated]
		get
		{
			return pMae9oIB1;
		}
		[CompilerGenerated]
		set
		{
			pMae9oIB1 = value;
		}
	}

	public UpdateDevicesMessage()
	{
		base.MessageType = 104;
	}

	internal static bool IKO4ApcTAL0U2C66Ni9()
	{
		return v3v0DScwq0TNX6VQmwy == null;
	}
}
