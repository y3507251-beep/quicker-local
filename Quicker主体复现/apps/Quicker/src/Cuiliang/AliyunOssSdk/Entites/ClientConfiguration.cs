using System;
using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Entites;

public class ClientConfiguration
{
	private static readonly string R6s2M1U9O5;

	public const int ConnectionLimit = 512;

	[CompilerGenerated]
	private bool bby2Axx525;

	[CompilerGenerated]
	private string GkT2OJjCB5;

	[CompilerGenerated]
	private int mtM2FpqZPl = -1;

	[CompilerGenerated]
	private string rd62ULFyac;

	[CompilerGenerated]
	private string r3Y2lrwsU6;

	[CompilerGenerated]
	private string L0y2ijr8ZY;

	[CompilerGenerated]
	private int RRt23E2dAp = -1;

	[CompilerGenerated]
	private int X6O2fXsHCF = 3;

	[CompilerGenerated]
	private long ioV2z4Z2VH;

	private static ClientConfiguration vaeoeaeiBHK53sqCqMP;

	public bool UseHttps
	{
		[CompilerGenerated]
		get
		{
			return bby2Axx525;
		}
		[CompilerGenerated]
		set
		{
			bby2Axx525 = value;
		}
	}

	public string UserAgent => R6s2M1U9O5;

	public string ProxyHost
	{
		[CompilerGenerated]
		get
		{
			return GkT2OJjCB5;
		}
		[CompilerGenerated]
		set
		{
			GkT2OJjCB5 = value;
		}
	}

	public int ProxyPort
	{
		[CompilerGenerated]
		get
		{
			return mtM2FpqZPl;
		}
		[CompilerGenerated]
		set
		{
			mtM2FpqZPl = value;
		}
	}

	public string ProxyUserName
	{
		[CompilerGenerated]
		get
		{
			return rd62ULFyac;
		}
		[CompilerGenerated]
		set
		{
			rd62ULFyac = value;
		}
	}

	public string ProxyPassword
	{
		[CompilerGenerated]
		get
		{
			return r3Y2lrwsU6;
		}
		[CompilerGenerated]
		set
		{
			r3Y2lrwsU6 = value;
		}
	}

	public string ProxyDomain
	{
		[CompilerGenerated]
		get
		{
			return L0y2ijr8ZY;
		}
		[CompilerGenerated]
		set
		{
			L0y2ijr8ZY = value;
		}
	}

	public int ConnectionTimeout
	{
		[CompilerGenerated]
		get
		{
			return RRt23E2dAp;
		}
		[CompilerGenerated]
		set
		{
			RRt23E2dAp = value;
		}
	}

	public int MaxErrorRetry
	{
		[CompilerGenerated]
		get
		{
			return X6O2fXsHCF;
		}
		[CompilerGenerated]
		set
		{
			X6O2fXsHCF = value;
		}
	}

	public long TickOffset
	{
		[CompilerGenerated]
		get
		{
			return ioV2z4Z2VH;
		}
		[CompilerGenerated]
		internal set
		{
			ioV2z4Z2VH = value;
		}
	}

	public static ClientConfiguration Default => new ClientConfiguration();

	public void SetCustomEpochTicks(long epochTicks)
	{
		DateTime value = new DateTime(1970, 1, 1);
		long num = (long)DateTime.UtcNow.Subtract(value).TotalSeconds;
		TickOffset = epochTicks - num;
	}

	private static string WSk2o0aic5()
	{
		return "aliyun-sdk-dotnet/" + typeof(ClientConfiguration).AssemblyQualifiedName;
	}

	static ClientConfiguration()
	{
		R6s2M1U9O5 = WSk2o0aic5();
	}

	internal static bool tWqSDcel4CBTG3XfIo2()
	{
		return vaeoeaeiBHK53sqCqMP == null;
	}
}
