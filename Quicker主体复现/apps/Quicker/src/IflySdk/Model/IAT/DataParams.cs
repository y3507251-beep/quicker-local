using System.Runtime.CompilerServices;
using IflySdk.Enum;

namespace IflySdk.Model.IAT;

public class DataParams
{
	[CompilerGenerated]
	private FrameState eiFhwSpJHR;

	[CompilerGenerated]
	private string g4chtgSQr8 = "audio/L16;rate=16000";

	[CompilerGenerated]
	private string UZ7hg4jiTr = "raw";

	[CompilerGenerated]
	private string xbThL6nDJS;

	private static DataParams ssro7TNJ895mB9sINxf;

	public FrameState status
	{
		[CompilerGenerated]
		get
		{
			return eiFhwSpJHR;
		}
		[CompilerGenerated]
		set
		{
			eiFhwSpJHR = value;
		}
	}

	public string format
	{
		[CompilerGenerated]
		get
		{
			return g4chtgSQr8;
		}
		[CompilerGenerated]
		set
		{
			g4chtgSQr8 = value;
		}
	}

	public string encoding
	{
		[CompilerGenerated]
		get
		{
			return UZ7hg4jiTr;
		}
		[CompilerGenerated]
		set
		{
			UZ7hg4jiTr = value;
		}
	}

	public string audio
	{
		[CompilerGenerated]
		get
		{
			return xbThL6nDJS;
		}
		[CompilerGenerated]
		set
		{
			xbThL6nDJS = value;
		}
	}

	internal static bool DXv9gvNkdcMwsW3Bglh()
	{
		return ssro7TNJ895mB9sINxf == null;
	}
}
