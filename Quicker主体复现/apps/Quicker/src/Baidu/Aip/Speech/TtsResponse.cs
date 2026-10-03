using System.Runtime.CompilerServices;

namespace Baidu.Aip.Speech;

public class TtsResponse
{
	[CompilerGenerated]
	private int ceISXHqTWD;

	[CompilerGenerated]
	private string VXESmgNKv4;

	[CompilerGenerated]
	private string oinSKy1eiC;

	[CompilerGenerated]
	private int nKDSx0Wcuh;

	[CompilerGenerated]
	private byte[] pkBSrQeJlm;

	private static TtsResponse eIH7WZA2lkmBp9XdLRr;

	public int ErrorCode
	{
		[CompilerGenerated]
		get
		{
			return ceISXHqTWD;
		}
		[CompilerGenerated]
		set
		{
			ceISXHqTWD = value;
		}
	}

	public string ErrorMsg
	{
		[CompilerGenerated]
		get
		{
			return VXESmgNKv4;
		}
		[CompilerGenerated]
		set
		{
			VXESmgNKv4 = value;
		}
	}

	public string Sn
	{
		[CompilerGenerated]
		get
		{
			return oinSKy1eiC;
		}
		[CompilerGenerated]
		set
		{
			oinSKy1eiC = value;
		}
	}

	public int Idx
	{
		[CompilerGenerated]
		get
		{
			return nKDSx0Wcuh;
		}
		[CompilerGenerated]
		set
		{
			nKDSx0Wcuh = value;
		}
	}

	public byte[] Data
	{
		[CompilerGenerated]
		get
		{
			return pkBSrQeJlm;
		}
		[CompilerGenerated]
		set
		{
			pkBSrQeJlm = value;
		}
	}

	public bool Success => ErrorCode == 0;

	internal static bool GBduy1AAauWiGAFGcnm()
	{
		return eIH7WZA2lkmBp9XdLRr == null;
	}
}
