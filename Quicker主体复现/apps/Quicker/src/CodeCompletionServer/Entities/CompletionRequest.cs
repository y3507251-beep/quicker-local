using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CodeCompletionServer.Entities;

public class CompletionRequest
{
	[CompilerGenerated]
	private Guid cJ8v05LImlr;

	[CompilerGenerated]
	private Guid Cs9v0Dac0B3;

	[CompilerGenerated]
	private string HlDv0daZIV6;

	[CompilerGenerated]
	private int yJMv0oTaBR7;

	[CompilerGenerated]
	private TriggerMode Yqev0Tmp1a7;

	[CompilerGenerated]
	private char? V0fv0Msr3Cn;

	[CompilerGenerated]
	private IDictionary<string, string> u1Nv0Awj6Uk;

	[CompilerGenerated]
	private bool MKlv0O9vnkQ;

	private static CompletionRequest T7JFLTcc03omBMwwhx93;

	public Guid SessionId
	{
		[CompilerGenerated]
		get
		{
			return cJ8v05LImlr;
		}
		[CompilerGenerated]
		set
		{
			cJ8v05LImlr = value;
		}
	}

	public Guid RequestId
	{
		[CompilerGenerated]
		get
		{
			return Cs9v0Dac0B3;
		}
		[CompilerGenerated]
		set
		{
			Cs9v0Dac0B3 = value;
		}
	}

	public string OriginCode
	{
		[CompilerGenerated]
		get
		{
			return HlDv0daZIV6;
		}
		[CompilerGenerated]
		set
		{
			HlDv0daZIV6 = value;
		}
	}

	public int Position
	{
		[CompilerGenerated]
		get
		{
			return yJMv0oTaBR7;
		}
		[CompilerGenerated]
		set
		{
			yJMv0oTaBR7 = value;
		}
	}

	public TriggerMode TriggerMode
	{
		[CompilerGenerated]
		get
		{
			return Yqev0Tmp1a7;
		}
		[CompilerGenerated]
		set
		{
			Yqev0Tmp1a7 = value;
		}
	}

	public char? TriggerChar
	{
		[CompilerGenerated]
		get
		{
			return V0fv0Msr3Cn;
		}
		[CompilerGenerated]
		set
		{
			V0fv0Msr3Cn = value;
		}
	}

	public IDictionary<string, string> Variables
	{
		[CompilerGenerated]
		get
		{
			return u1Nv0Awj6Uk;
		}
		[CompilerGenerated]
		set
		{
			u1Nv0Awj6Uk = value;
		}
	}

	public bool GetErrors
	{
		[CompilerGenerated]
		get
		{
			return MKlv0O9vnkQ;
		}
		[CompilerGenerated]
		set
		{
			MKlv0O9vnkQ = value;
		}
	}

	internal static bool gNvZThcc1LeAw6r2QbN1()
	{
		return T7JFLTcc03omBMwwhx93 == null;
	}
}
