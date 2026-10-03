using System.Runtime.CompilerServices;

namespace Quicker.Domain.Services;

public class WebSocketResponse : WebSocketMessageBase
{
	[CompilerGenerated]
	private int YJ4tsOdAxpK;

	[CompilerGenerated]
	private bool uV7tsFKU5K1;

	[CompilerGenerated]
	private string IbqtsUSs42e;

	private static WebSocketResponse plSn0AQaKeZjQ1yyrFEZ;

	public int ReplyTo
	{
		[CompilerGenerated]
		get
		{
			return YJ4tsOdAxpK;
		}
		[CompilerGenerated]
		set
		{
			YJ4tsOdAxpK = value;
		}
	}

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return uV7tsFKU5K1;
		}
		[CompilerGenerated]
		set
		{
			uV7tsFKU5K1 = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return IbqtsUSs42e;
		}
		[CompilerGenerated]
		set
		{
			IbqtsUSs42e = value;
		}
	}

	internal static bool XSIBi6QaBjkP5YnaxSRM()
	{
		return plSn0AQaKeZjQ1yyrFEZ == null;
	}
}
