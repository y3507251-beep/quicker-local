using System.Runtime.CompilerServices;

namespace LPAgent.Domain;

public class Response
{
	[CompilerGenerated]
	private int Kgqku24dl5;

	[CompilerGenerated]
	private bool Bk6kN9c2ES;

	[CompilerGenerated]
	private string uqYkJ3ii3X;

	[CompilerGenerated]
	private string x0Hk045WSI;

	[CompilerGenerated]
	private string TKtkCMSifF;

	internal static Response k1Lldobmash5mY13FWc;

	public int Serial
	{
		[CompilerGenerated]
		get
		{
			return Kgqku24dl5;
		}
		[CompilerGenerated]
		set
		{
			Kgqku24dl5 = value;
		}
	}

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return Bk6kN9c2ES;
		}
		[CompilerGenerated]
		set
		{
			Bk6kN9c2ES = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return uqYkJ3ii3X;
		}
		[CompilerGenerated]
		set
		{
			uqYkJ3ii3X = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return x0Hk045WSI;
		}
		[CompilerGenerated]
		set
		{
			x0Hk045WSI = value;
		}
	}

	public string StackTrace
	{
		[CompilerGenerated]
		get
		{
			return TKtkCMSifF;
		}
		[CompilerGenerated]
		set
		{
			TKtkCMSifF = value;
		}
	}

	public static Response Success(string data = null)
	{
		return new Response
		{
			IsSuccess = true,
			Data = data
		};
	}

	internal static bool qtFM8ybsImRuFy4e94U()
	{
		return k1Lldobmash5mY13FWc == null;
	}
}
