using Newtonsoft.Json;

namespace Qiniu.Storage;

public class PfopInfo
{
	[JsonProperty("id")]
	public string Id;

	[JsonProperty("code")]
	public int Code;

	[JsonProperty("desc")]
	public string Desc;

	[JsonProperty("inputKey")]
	public string InputKey;

	[JsonProperty("inputBucket")]
	public string InputBucket;

	[JsonProperty("pipeline")]
	public string Pipeline;

	[JsonProperty("reqid")]
	public string Reqid;

	[JsonProperty("items")]
	public PfopItems[] Items;

	internal static PfopInfo cvVGnoo1ATTlw541Hdc;

	internal static bool pRF5qdoK5jn4ePnQuC9()
	{
		return cvVGnoo1ATTlw541Hdc == null;
	}
}
