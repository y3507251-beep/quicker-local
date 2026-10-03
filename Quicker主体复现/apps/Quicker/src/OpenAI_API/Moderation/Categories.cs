using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Moderation;

public class Categories
{
	[CompilerGenerated]
	private bool qhYqbl4sXg;

	[CompilerGenerated]
	private bool nNqq6sSxId;

	[CompilerGenerated]
	private bool rgMqX8LUm7;

	[CompilerGenerated]
	private bool Q7sqmXn39e;

	[CompilerGenerated]
	private bool xeCqKFM7sc;

	[CompilerGenerated]
	private bool FJ1qxxViPn;

	[CompilerGenerated]
	private bool BW8qrtFiSE;

	internal static Categories lKN2RPkGhBw9aE24BHT;

	[JsonProperty("hate")]
	public bool Hate
	{
		[CompilerGenerated]
		get
		{
			return qhYqbl4sXg;
		}
		[CompilerGenerated]
		set
		{
			qhYqbl4sXg = value;
		}
	}

	[JsonProperty("hate/threatening")]
	public bool HateThreatening
	{
		[CompilerGenerated]
		get
		{
			return nNqq6sSxId;
		}
		[CompilerGenerated]
		set
		{
			nNqq6sSxId = value;
		}
	}

	[JsonProperty("self-harm")]
	public bool SelfHarm
	{
		[CompilerGenerated]
		get
		{
			return rgMqX8LUm7;
		}
		[CompilerGenerated]
		set
		{
			rgMqX8LUm7 = value;
		}
	}

	[JsonProperty("sexual")]
	public bool Sexual
	{
		[CompilerGenerated]
		get
		{
			return Q7sqmXn39e;
		}
		[CompilerGenerated]
		set
		{
			Q7sqmXn39e = value;
		}
	}

	[JsonProperty("sexual/minors")]
	public bool SexualMinors
	{
		[CompilerGenerated]
		get
		{
			return xeCqKFM7sc;
		}
		[CompilerGenerated]
		set
		{
			xeCqKFM7sc = value;
		}
	}

	[JsonProperty("violence")]
	public bool Violence
	{
		[CompilerGenerated]
		get
		{
			return FJ1qxxViPn;
		}
		[CompilerGenerated]
		set
		{
			FJ1qxxViPn = value;
		}
	}

	[JsonProperty("violence/graphic")]
	public bool ViolenceGraphic
	{
		[CompilerGenerated]
		get
		{
			return BW8qrtFiSE;
		}
		[CompilerGenerated]
		set
		{
			BW8qrtFiSE = value;
		}
	}

	internal static bool RbPortk01R8qdkNpitG()
	{
		return lKN2RPkGhBw9aE24BHT == null;
	}
}
