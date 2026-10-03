using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Send;

public class LoginStateMessage : MessageBase
{
	public const int MSG_TYPE = 201;

	[CompilerGenerated]
	private bool UlltcvpAfLW;

	[CompilerGenerated]
	private int xaetcS4l6ek;

	[CompilerGenerated]
	private string dKitc2DupLf;

	private static LoginStateMessage P3B2qgQ0XABMnXG3g992;

	public bool IsLoggedIn
	{
		[CompilerGenerated]
		get
		{
			return UlltcvpAfLW;
		}
		[CompilerGenerated]
		set
		{
			UlltcvpAfLW = value;
		}
	}

	public int ErrorCode
	{
		[CompilerGenerated]
		get
		{
			return xaetcS4l6ek;
		}
		[CompilerGenerated]
		set
		{
			xaetcS4l6ek = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return dKitc2DupLf;
		}
		[CompilerGenerated]
		set
		{
			dKitc2DupLf = value;
		}
	}

	public override int MessageType => 201;

	internal static bool RUNmVDQ02gQ6sLdJpkOd()
	{
		return P3B2qgQ0XABMnXG3g992 == null;
	}
}
