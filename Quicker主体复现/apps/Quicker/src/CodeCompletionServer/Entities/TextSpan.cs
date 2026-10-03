using System.Runtime.CompilerServices;

namespace CodeCompletionServer.Entities;

public class TextSpan
{
	[CompilerGenerated]
	private int LgZvCpOeUwb;

	[CompilerGenerated]
	private int lsrvCB2CZoM;

	internal static TextSpan EE9yGYcWWo1ykwLP2OOW;

	public int Start
	{
		[CompilerGenerated]
		get
		{
			return LgZvCpOeUwb;
		}
		[CompilerGenerated]
		set
		{
			LgZvCpOeUwb = value;
		}
	}

	public int End => Start + Length;

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return lsrvCB2CZoM;
		}
		[CompilerGenerated]
		set
		{
			lsrvCB2CZoM = value;
		}
	}

	internal static bool w7Cr8gcWyRRrbp3qN8rY()
	{
		return EE9yGYcWWo1ykwLP2OOW == null;
	}
}
