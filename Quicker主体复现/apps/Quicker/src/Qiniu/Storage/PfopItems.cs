using Newtonsoft.Json;

namespace Qiniu.Storage;

public class PfopItems
{
	[JsonProperty("cmd")]
	public string Cmd;

	[JsonProperty("code")]
	public string Code;

	[JsonProperty("desc")]
	public string Desc;

	[JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
	public string Error;

	[JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
	public string[] Keys;

	[JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
	public string Key;

	[JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
	public string Hash;

	[JsonProperty("returnOld", NullValueHandling = NullValueHandling.Ignore)]
	public int? ReturnOld;

	private static PfopItems g1lB9fovTiSL2OwHmje;

	internal static bool qh1Gf7odU3Tnw1qAk0X()
	{
		return g1lB9fovTiSL2OwHmje == null;
	}
}
