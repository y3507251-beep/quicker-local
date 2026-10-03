using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Qiniu.Storage;

public class ListInfo
{
	[CompilerGenerated]
	private string JMhY2VaEoE;

	[CompilerGenerated]
	private List<ListItem> waYYuScmUI;

	[CompilerGenerated]
	private List<string> oeKYN8MKuB;

	internal static ListInfo t80Y7IuzbkKimr4MOdW;

	[JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
	public string Marker
	{
		[CompilerGenerated]
		get
		{
			return JMhY2VaEoE;
		}
		[CompilerGenerated]
		set
		{
			JMhY2VaEoE = value;
		}
	}

	[JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
	public List<ListItem> Items
	{
		[CompilerGenerated]
		get
		{
			return waYYuScmUI;
		}
		[CompilerGenerated]
		set
		{
			waYYuScmUI = value;
		}
	}

	[JsonProperty("commonPrefixes", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> CommonPrefixes
	{
		[CompilerGenerated]
		get
		{
			return oeKYN8MKuB;
		}
		[CompilerGenerated]
		set
		{
			oeKYN8MKuB = value;
		}
	}

	internal static bool UvJCb2oV3JXtnQj1o9A()
	{
		return t80Y7IuzbkKimr4MOdW == null;
	}
}
