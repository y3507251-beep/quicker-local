using System.Runtime.CompilerServices;

namespace Qiniu.Storage;

public class Zone
{
	[CompilerGenerated]
	private string cIeIUirDZX;

	[CompilerGenerated]
	private string UsfIlxXXMX;

	[CompilerGenerated]
	private string jj8IihdeEc;

	[CompilerGenerated]
	private string eSoI305DKZ;

	[CompilerGenerated]
	private string[] h7HIf9Y0hU;

	[CompilerGenerated]
	private string[] MS8IzqSCQS;

	public static Zone ZONE_CN_East;

	public static Zone ZONE_CN_East_2;

	public static Zone ZONE_CN_North;

	public static Zone ZONE_CN_South;

	public static Zone ZONE_US_North;

	public static Zone ZONE_AS_Singapore;

	public static Zone ZONE_AP_Seoul;

	private static Zone DFL5jUfNMWuUYt0HIVG;

	public string RsHost
	{
		[CompilerGenerated]
		get
		{
			return cIeIUirDZX;
		}
		[CompilerGenerated]
		set
		{
			cIeIUirDZX = value;
		}
	}

	public string RsfHost
	{
		[CompilerGenerated]
		get
		{
			return UsfIlxXXMX;
		}
		[CompilerGenerated]
		set
		{
			UsfIlxXXMX = value;
		}
	}

	public string ApiHost
	{
		[CompilerGenerated]
		get
		{
			return jj8IihdeEc;
		}
		[CompilerGenerated]
		set
		{
			jj8IihdeEc = value;
		}
	}

	public string IovipHost
	{
		[CompilerGenerated]
		get
		{
			return eSoI305DKZ;
		}
		[CompilerGenerated]
		set
		{
			eSoI305DKZ = value;
		}
	}

	public string[] SrcUpHosts
	{
		[CompilerGenerated]
		get
		{
			return h7HIf9Y0hU;
		}
		[CompilerGenerated]
		set
		{
			h7HIf9Y0hU = value;
		}
	}

	public string[] CdnUpHosts
	{
		[CompilerGenerated]
		get
		{
			return MS8IzqSCQS;
		}
		[CompilerGenerated]
		set
		{
			MS8IzqSCQS = value;
		}
	}

	static Zone()
	{
		ZONE_CN_East = new Zone
		{
			RsHost = "rs.qbox.me",
			RsfHost = "rsf.qbox.me",
			ApiHost = "api.qiniuapi.com",
			IovipHost = "iovip.qbox.me",
			SrcUpHosts = new string[1] { "up.qiniup.com" },
			CdnUpHosts = new string[1] { "upload.qiniup.com" }
		};
		ZONE_CN_East_2 = new Zone
		{
			RsHost = "rs-cn-east-2.qiniuapi.com",
			RsfHost = "rsf-cn-east-2.qiniuapi.com",
			ApiHost = "api-cn-east-2.qiniuapi.com",
			IovipHost = "iovip-cn-east-2.qiniuio.com",
			SrcUpHosts = new string[1] { "up-cn-east-2.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-cn-east-2.qiniup.com" }
		};
		ZONE_CN_North = new Zone
		{
			RsHost = "rs-z1.qbox.me",
			RsfHost = "rsf-z1.qbox.me",
			ApiHost = "api-z1.qiniuapi.com",
			IovipHost = "iovip-z1.qbox.me",
			SrcUpHosts = new string[1] { "up-z1.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-z1.qiniup.com" }
		};
		ZONE_CN_South = new Zone
		{
			RsHost = "rs-z2.qbox.me",
			RsfHost = "rsf-z2.qbox.me",
			ApiHost = "api-z2.qiniuapi.com",
			IovipHost = "iovip-z2.qbox.me",
			SrcUpHosts = new string[1] { "up-z2.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-z2.qiniup.com" }
		};
		ZONE_US_North = new Zone
		{
			RsHost = "rs-na0.qbox.me",
			RsfHost = "rsf-na0.qbox.me",
			ApiHost = "api-na0.qiniuapi.com",
			IovipHost = "iovip-na0.qbox.me",
			SrcUpHosts = new string[1] { "up-na0.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-na0.qiniup.com" }
		};
		ZONE_AS_Singapore = new Zone
		{
			RsHost = "rs-as0.qbox.me",
			RsfHost = "rsf-as0.qbox.me",
			ApiHost = "api-as0.qiniuapi.com",
			IovipHost = "iovip-as0.qbox.me",
			SrcUpHosts = new string[1] { "up-as0.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-as0.qiniup.com" }
		};
		ZONE_AP_Seoul = new Zone
		{
			RsHost = "rs-ap-northeast-1.qiniuapi.com",
			RsfHost = "rsf-ap-northeast-1.qiniuapi.com",
			ApiHost = "api-ap-northeast-1.qiniuapi.com",
			IovipHost = "iovip-ap-northeast-1.qiniuio.com",
			SrcUpHosts = new string[1] { "up-ap-northeast-1.qiniup.com" },
			CdnUpHosts = new string[1] { "upload-ap-northeast-1.qiniup.com" }
		};
	}

	internal static bool UbHhXaf9Q9SSNpgpKo8()
	{
		return DFL5jUfNMWuUYt0HIVG == null;
	}

	internal static void xj7joofugGsWLNUXqHw()
	{
	}
}
