using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Entites;

namespace Cuiliang.AliyunOssSdk.Api.Object.Get;

public class GetObjectResult
{
	[CompilerGenerated]
	private HttpResponseHeaders O36uQi5pBR;

	[CompilerGenerated]
	private HttpContent YRFuj9T2LH;

	[CompilerGenerated]
	private ObjectMetadata uE9unNbidT;

	private static GetObjectResult XEBioHjbP19EQC1nG9p;

	public HttpResponseHeaders Headers
	{
		[CompilerGenerated]
		get
		{
			return O36uQi5pBR;
		}
		[CompilerGenerated]
		set
		{
			O36uQi5pBR = value;
		}
	}

	public HttpContent Content
	{
		[CompilerGenerated]
		get
		{
			return YRFuj9T2LH;
		}
		[CompilerGenerated]
		set
		{
			YRFuj9T2LH = value;
		}
	}

	public ObjectMetadata Metadata
	{
		[CompilerGenerated]
		get
		{
			return uE9unNbidT;
		}
		[CompilerGenerated]
		set
		{
			uE9unNbidT = value;
		}
	}

	internal static bool t4Hv5Hjqltc956Sh14P()
	{
		return XEBioHjbP19EQC1nG9p == null;
	}
}
