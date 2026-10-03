namespace Qiniu.Storage;

public class Config
{
	public static string DefaultRsHost;

	public static string DefaultApiHost;

	public Zone Zone;

	public bool UseHttps;

	public bool UseCdnDomains;

	public ChunkUnit ChunkSize = ChunkUnit.U4096K;

	public int PutThreshold = ResumeChunk.GetChunkSize(ChunkUnit.U1024K) * 10;

	public int MaxRetryTimes = 3;

	private static Config KtnFFouuqXaAoM6MPoR;

	public string RsHost(string ak, string bucket)
	{
		string arg = (UseHttps ? "https://" : "http://");
		Zone zone = Zone;
		if (zone == null)
		{
			zone = ZoneHelper.QueryZone(ak, bucket);
		}
		return $"{arg}{zone.RsHost}";
	}

	public string RsfHost(string ak, string bucket)
	{
		string arg = (UseHttps ? "https://" : "http://");
		Zone zone = Zone;
		if (zone == null)
		{
			zone = ZoneHelper.QueryZone(ak, bucket);
		}
		return $"{arg}{zone.RsfHost}";
	}

	public string ApiHost(string ak, string bucket)
	{
		string arg = (UseHttps ? "https://" : "http://");
		Zone zone = Zone;
		if (zone == null)
		{
			zone = ZoneHelper.QueryZone(ak, bucket);
		}
		return $"{arg}{zone.ApiHost}";
	}

	public string IovipHost(string ak, string bucket)
	{
		string arg = (UseHttps ? "https://" : "http://");
		Zone zone = Zone;
		if (zone == null)
		{
			zone = ZoneHelper.QueryZone(ak, bucket);
		}
		return $"{arg}{zone.IovipHost}";
	}

	public string UpHost(string ak, string bucket)
	{
		string arg = (UseHttps ? "https://" : "http://");
		Zone zone = Zone;
		if (zone == null)
		{
			zone = ZoneHelper.QueryZone(ak, bucket);
			int num = 0;
			if (!aj4lD1uoMdCO2WKSjW9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		string arg2 = zone.SrcUpHosts[0];
		if (UseCdnDomains)
		{
			arg2 = zone.CdnUpHosts[0];
		}
		return $"{arg}{arg2}";
	}

	static Config()
	{
		DefaultRsHost = "rs.qiniu.com";
		DefaultApiHost = "api.qiniuapi.com";
	}

	internal static bool aj4lD1uoMdCO2WKSjW9()
	{
		return KtnFFouuqXaAoM6MPoR == null;
	}
}
