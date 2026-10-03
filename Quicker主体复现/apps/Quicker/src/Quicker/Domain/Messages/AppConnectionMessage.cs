using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class AppConnectionMessage : TinyMessageBase
{
	[CompilerGenerated]
	private bool vELthoUvyvO;

	private static AppConnectionMessage yZcabLQviKiq0Ssjg23O;

	public bool IsConnected
	{
		[CompilerGenerated]
		get
		{
			return vELthoUvyvO;
		}
		[CompilerGenerated]
		set
		{
			vELthoUvyvO = value;
		}
	}

	public AppConnectionMessage(object sender, bool connected)
		: base(sender)
	{
		IsConnected = connected;
	}

	internal static bool VcD6guQvl3Z548WYQuKP()
	{
		return yZcabLQviKiq0Ssjg23O == null;
	}
}
