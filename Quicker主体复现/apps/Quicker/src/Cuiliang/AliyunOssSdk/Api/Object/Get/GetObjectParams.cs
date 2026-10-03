using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;
using qdET65OxfuSfXTNffp;

namespace Cuiliang.AliyunOssSdk.Api.Object.Get;

public class GetObjectParams
{
	[CompilerGenerated]
	private ResponseHeaderOverrides yktumxd0Eu;

	[CompilerGenerated]
	private ObjectRange QFhuKqCxYj;

	[CompilerGenerated]
	private DateTime? SO7uxnnqfq;

	[CompilerGenerated]
	private DateTime? ys4urwy7yE;

	[CompilerGenerated]
	private string lVjupnUU53;

	[CompilerGenerated]
	private string QN1uBCgpEY;

	private static GetObjectParams GQTLdqjLSj0AJtmgMLP;

	public ResponseHeaderOverrides OverrideResponseHeaders
	{
		[CompilerGenerated]
		get
		{
			return yktumxd0Eu;
		}
		[CompilerGenerated]
		set
		{
			yktumxd0Eu = value;
		}
	}

	public ObjectRange Range
	{
		[CompilerGenerated]
		get
		{
			return QFhuKqCxYj;
		}
		[CompilerGenerated]
		set
		{
			QFhuKqCxYj = value;
		}
	}

	public DateTime? IfModifiedSince
	{
		[CompilerGenerated]
		get
		{
			return SO7uxnnqfq;
		}
		[CompilerGenerated]
		set
		{
			SO7uxnnqfq = value;
		}
	}

	public DateTime? IfUnmodifiedSince
	{
		[CompilerGenerated]
		get
		{
			return ys4urwy7yE;
		}
		[CompilerGenerated]
		set
		{
			ys4urwy7yE = value;
		}
	}

	public string IfEtagMatch
	{
		[CompilerGenerated]
		get
		{
			return lVjupnUU53;
		}
		[CompilerGenerated]
		set
		{
			lVjupnUU53 = value;
		}
	}

	public string IfEtagNoneMatch
	{
		[CompilerGenerated]
		get
		{
			return QN1uBCgpEY;
		}
		[CompilerGenerated]
		set
		{
			QN1uBCgpEY = value;
		}
	}

	public GetObjectParams()
	{
	}

	public GetObjectParams(ResponseHeaderOverrides overrideHeaders = null, ObjectRange range = null, DateTime? ifModifiedSinceUtc = null, DateTime? ifUnmodifiedSinceUtc = null, string ifEtagMatch = "", string ifEtagNoneMatch = "")
	{
		OverrideResponseHeaders = OverrideResponseHeaders;
		Range = range;
		IfModifiedSince = ifModifiedSinceUtc;
		IfUnmodifiedSince = IfUnmodifiedSince;
		IfEtagMatch = ifEtagMatch;
		IfEtagNoneMatch = ifEtagNoneMatch;
	}

	public void SetupRequest(ServiceRequest req)
	{
		int num = 1;
		while (OverrideResponseHeaders != null)
		{
			int num2 = 0;
			if (!JUSVIcjuncTnG6HXDQh())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			OverrideResponseHeaders.ikf2twoHHM(req.Parameters);
			break;
		}
		Range?.AddToHeader(req.Headers);
		if (IfModifiedSince.HasValue)
		{
			g9kuXkOhuF("If-Modified-Since", zh4GdKnxb7gfeU5oTf.YoHSowUI1T(IfModifiedSince.Value), req.Headers);
		}
		if (IfUnmodifiedSince.HasValue)
		{
			g9kuXkOhuF("If-Unmodified-Since", zh4GdKnxb7gfeU5oTf.YoHSowUI1T(IfUnmodifiedSince.Value), req.Headers);
		}
		g9kuXkOhuF("If-Match", IfEtagMatch, req.Headers);
		g9kuXkOhuF("If-None-Match", IfEtagNoneMatch, req.Headers);
	}

	private void g9kuXkOhuF(string string_2, string string_3, IDictionary<string, string> idictionary_0)
	{
		if (!string.IsNullOrEmpty(string_3))
		{
			idictionary_0.Add(string_2, string_3);
		}
	}

	internal static bool JUSVIcjuncTnG6HXDQh()
	{
		return GQTLdqjLSj0AJtmgMLP == null;
	}
}
