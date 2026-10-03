using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using bEVZu13wruQIEh71Lv;
using Cuiliang.AliyunOssSdk.Entites;

namespace Cuiliang.AliyunOssSdk.Request;

public class ServiceRequest
{
	[CompilerGenerated]
	private HttpMethod qN92WsYdE5;

	[CompilerGenerated]
	private BucketInfo xB52kAaCNY;

	[CompilerGenerated]
	private string Drv2G4rxFy;

	[CompilerGenerated]
	private readonly IDictionary<string, string> RTy2sxjU3M = new Dictionary<string, string>();

	[CompilerGenerated]
	private readonly IDictionary<string, string> IOe2H5xjks = new Dictionary<string, string>();

	[CompilerGenerated]
	private byte[] gvk2150KVy;

	[CompilerGenerated]
	private string lpu2beoY3J;

	[CompilerGenerated]
	private RequestContentType tlj26Ibgld;

	[CompilerGenerated]
	private Stream X8h2XZDPhI;

	[CompilerGenerated]
	private string f3D2mo7f4s;

	internal static ServiceRequest fgcTlEe1ySRHP9QBVIv;

	public HttpMethod HttpMethod
	{
		[CompilerGenerated]
		get
		{
			return qN92WsYdE5;
		}
		[CompilerGenerated]
		set
		{
			qN92WsYdE5 = value;
		}
	}

	public BucketInfo Bucket
	{
		[CompilerGenerated]
		get
		{
			return xB52kAaCNY;
		}
		[CompilerGenerated]
		set
		{
			xB52kAaCNY = value;
		}
	}

	public string ObjectKey
	{
		[CompilerGenerated]
		get
		{
			return Drv2G4rxFy;
		}
		[CompilerGenerated]
		set
		{
			Drv2G4rxFy = value;
		}
	}

	public IDictionary<string, string> Headers
	{
		[CompilerGenerated]
		get
		{
			return RTy2sxjU3M;
		}
	}

	public IDictionary<string, string> Parameters
	{
		[CompilerGenerated]
		get
		{
			return IOe2H5xjks;
		}
	}

	public byte[] ContentMd5
	{
		[CompilerGenerated]
		get
		{
			return gvk2150KVy;
		}
		[CompilerGenerated]
		set
		{
			gvk2150KVy = value;
		}
	}

	public string ContentMimeType
	{
		[CompilerGenerated]
		get
		{
			return lpu2beoY3J;
		}
		[CompilerGenerated]
		private set
		{
			lpu2beoY3J = value;
		}
	}

	public RequestContentType RequestContentType
	{
		[CompilerGenerated]
		get
		{
			return tlj26Ibgld;
		}
		[CompilerGenerated]
		private set
		{
			tlj26Ibgld = value;
		}
	}

	public Stream StreamContent
	{
		[CompilerGenerated]
		get
		{
			return X8h2XZDPhI;
		}
		[CompilerGenerated]
		private set
		{
			X8h2XZDPhI = value;
		}
	}

	public string StringContent
	{
		[CompilerGenerated]
		get
		{
			return f3D2mo7f4s;
		}
		[CompilerGenerated]
		private set
		{
			f3D2mo7f4s = value;
		}
	}

	public ServiceRequest(BucketInfo bucket, string key, HttpMethod httpMethod)
	{
		Bucket = bucket;
		HttpMethod = httpMethod;
		ObjectKey = key;
	}

	public ServiceRequest AddParameter(string key, string value, bool skipIfEmpty = true)
	{
		if (skipIfEmpty && string.IsNullOrEmpty(value))
		{
			return this;
		}
		Parameters[key] = value;
		return this;
	}

	public void SetContent(Stream stream, string contentType)
	{
		RequestContentType = RequestContentType.Stream;
		StreamContent = stream;
		ContentMimeType = contentType;
	}

	public void SetContent(string body, string contentType)
	{
		RequestContentType = RequestContentType.String;
		StringContent = body;
		ContentMimeType = contentType;
	}

	public string BuildRequestUri(RequestContext context)
	{
		string text = Bucket.GetObjectUrl(ObjectKey);
		if (LCm29HccdI())
		{
			string text2 = bThfW9sYygwxKofgvb.gYvSAdEbM1(Parameters);
			if (!string.IsNullOrEmpty(text2))
			{
				text = text + "?" + text2;
			}
		}
		return text;
	}

	private bool LCm29HccdI()
	{
		bool flag = RequestContentType != RequestContentType.None;
		return !(HttpMethod == HttpMethod.Post) || flag;
	}

	internal static bool YELynxeKC71ZcTa0O8T()
	{
		return fgcTlEe1ySRHP9QBVIv == null;
	}
}
