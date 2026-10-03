using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Images;

public class ImageResult : ApiResultBase
{
	[CompilerGenerated]
	private List<Data> LwWccBQKYy;

	internal static ImageResult W4MV7skIjve96A4TZh0;

	[JsonProperty("data")]
	public List<Data> Data
	{
		[CompilerGenerated]
		get
		{
			return LwWccBQKYy;
		}
		[CompilerGenerated]
		set
		{
			LwWccBQKYy = value;
		}
	}

	public override string ToString()
	{
		List<Data> data = Data;
		if (data != null && data.Count > 0)
		{
			return Data[0].Url ?? Data[0].Base64Data;
		}
		return null;
	}

	internal static bool vKivvXk6IlpQAtVpXpe()
	{
		return W4MV7skIjve96A4TZh0 == null;
	}
}
