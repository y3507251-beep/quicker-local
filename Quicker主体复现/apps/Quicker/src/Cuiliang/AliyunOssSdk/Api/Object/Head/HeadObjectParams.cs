using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Request;
using qdET65OxfuSfXTNffp;

namespace Cuiliang.AliyunOssSdk.Api.Object.Head;

public class HeadObjectParams
{
	[CompilerGenerated]
	private DateTime? HHnuk9W9NK;

	[CompilerGenerated]
	private DateTime? FVxuGAQy2n;

	[CompilerGenerated]
	private string Y8Sus8GOb7;

	[CompilerGenerated]
	private string RxyuH8MOxw;

	internal static HeadObjectParams r7A76DjEtn9JnicgpAp;

	public DateTime? IfModifiedSince
	{
		[CompilerGenerated]
		get
		{
			return HHnuk9W9NK;
		}
		[CompilerGenerated]
		set
		{
			HHnuk9W9NK = value;
		}
	}

	public DateTime? IfUnmodifiedSince
	{
		[CompilerGenerated]
		get
		{
			return FVxuGAQy2n;
		}
		[CompilerGenerated]
		set
		{
			FVxuGAQy2n = value;
		}
	}

	public string IfEtagMatch
	{
		[CompilerGenerated]
		get
		{
			return Y8Sus8GOb7;
		}
		[CompilerGenerated]
		set
		{
			Y8Sus8GOb7 = value;
		}
	}

	public string IfEtagNoneMatch
	{
		[CompilerGenerated]
		get
		{
			return RxyuH8MOxw;
		}
		[CompilerGenerated]
		set
		{
			RxyuH8MOxw = value;
		}
	}

	public HeadObjectParams()
	{
	}

	public HeadObjectParams(DateTime? ifModifiedSinceUtc = null, DateTime? ifUnmodifiedSinceUtc = null, string ifEtagMatch = "", string ifEtagNoneMatch = "")
	{
		IfModifiedSince = ifModifiedSinceUtc;
		IfUnmodifiedSince = IfUnmodifiedSince;
		IfEtagMatch = ifEtagMatch;
		IfEtagNoneMatch = ifEtagNoneMatch;
	}

	public void SetupRequest(ServiceRequest req)
	{
		if (IfModifiedSince.HasValue)
		{
			LLquWlLQuO("If-Modified-Since", zh4GdKnxb7gfeU5oTf.YoHSowUI1T(IfModifiedSince.Value), req.Headers);
		}
		if (IfUnmodifiedSince.HasValue)
		{
			LLquWlLQuO("If-Unmodified-Since", zh4GdKnxb7gfeU5oTf.YoHSowUI1T(IfUnmodifiedSince.Value), req.Headers);
		}
		LLquWlLQuO("If-Match", IfEtagMatch, req.Headers);
		LLquWlLQuO("If-None-Match", IfEtagNoneMatch, req.Headers);
	}

	private void LLquWlLQuO(string string_2, string string_3, IDictionary<string, string> idictionary_0)
	{
		if (!string.IsNullOrEmpty(string_3))
		{
			idictionary_0.Add(string_2, string_3);
		}
	}

	internal static bool u0BguhjGiFhXowWyPAR()
	{
		return r7A76DjEtn9JnicgpAp == null;
	}
}
