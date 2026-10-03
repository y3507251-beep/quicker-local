using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Utility;

public class ResponseHeaderOverrides
{
	[CompilerGenerated]
	private string HDi2gCN1hy;

	[CompilerGenerated]
	private string afo2LiFsgF;

	[CompilerGenerated]
	private string BlN2vdWJQ2;

	[CompilerGenerated]
	private string ALS2S03ZRN;

	[CompilerGenerated]
	private string ghF22wp9Id;

	[CompilerGenerated]
	private string fld2uFMi1B;

	private static ResponseHeaderOverrides nWjEnCn6PNCIN9UfWvr;

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return HDi2gCN1hy;
		}
		[CompilerGenerated]
		set
		{
			HDi2gCN1hy = value;
		}
	}

	public string ContentLanguage
	{
		[CompilerGenerated]
		get
		{
			return afo2LiFsgF;
		}
		[CompilerGenerated]
		set
		{
			afo2LiFsgF = value;
		}
	}

	public string Expires
	{
		[CompilerGenerated]
		get
		{
			return BlN2vdWJQ2;
		}
		[CompilerGenerated]
		set
		{
			BlN2vdWJQ2 = value;
		}
	}

	public string CacheControl
	{
		[CompilerGenerated]
		get
		{
			return ALS2S03ZRN;
		}
		[CompilerGenerated]
		set
		{
			ALS2S03ZRN = value;
		}
	}

	public string ContentDisposition
	{
		[CompilerGenerated]
		get
		{
			return ghF22wp9Id;
		}
		[CompilerGenerated]
		set
		{
			ghF22wp9Id = value;
		}
	}

	public string ContentEncoding
	{
		[CompilerGenerated]
		get
		{
			return fld2uFMi1B;
		}
		[CompilerGenerated]
		set
		{
			fld2uFMi1B = value;
		}
	}

	internal void ikf2twoHHM(IDictionary<string, string> idictionary_0)
	{
		if (CacheControl != null)
		{
			idictionary_0.Add("response-cache-control", CacheControl);
		}
		if (ContentDisposition != null)
		{
			idictionary_0.Add("response-content-disposition", ContentDisposition);
		}
		if (ContentEncoding != null)
		{
			idictionary_0.Add("response-content-encoding", ContentEncoding);
		}
		if (ContentLanguage != null)
		{
			idictionary_0.Add("response-content-language", ContentLanguage);
		}
		if (ContentType != null)
		{
			idictionary_0.Add("response-content-type", ContentType);
		}
		if (Expires != null)
		{
			idictionary_0.Add("response-expires", Expires);
		}
	}

	internal static bool xDLARanttwC8Ue4em1v()
	{
		return nWjEnCn6PNCIN9UfWvr == null;
	}
}
