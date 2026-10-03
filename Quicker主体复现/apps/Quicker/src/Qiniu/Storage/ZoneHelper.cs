using System;
using System.Collections.Generic;
using System.Text;
using GFy17Dq3Ka8YBV2L15c;
using If06OJqSrRdLw2lVguE;
using Newtonsoft.Json;
using Qiniu.Http;

namespace Qiniu.Storage;

public class ZoneHelper
{
	private static Dictionary<string, Zone> cV2WwA8nXL;

	private static object GLtWtXdSZt;

	internal static ZoneHelper D6aMjefbWtw0d6YDs1G;

	public static Zone QueryZone(string accessKey, string bucket)
	{
		Zone zone = null;
		string key = $"{accessKey}:{bucket}";
		lock (GLtWtXdSZt)
		{
			if (cV2WwA8nXL.ContainsKey(key))
			{
				zone = cV2WwA8nXL[key];
			}
		}
		if (zone != null)
		{
			return zone;
		}
		HttpResult httpResult = null;
		try
		{
			string url = $"https://uc.qbox.me/v2/query?ak={accessKey}&bucket={bucket}";
			httpResult = new HttpManager(false).Get(url, null);
			int num;
			if (httpResult.Code == 200)
			{
				num = 4;
				if (!cXuaBKfqon3n6Fs6FP4())
				{
					goto IL_00a8;
				}
				goto IL_0183;
			}
			throw new Exception("code: " + httpResult.Code + ", text: " + httpResult.Text + ", ref-text:" + httpResult.RefText);
			IL_02c5:
			lock (GLtWtXdSZt)
			{
				cV2WwA8nXL[key] = zone;
				return zone;
			}
			IL_02f4:
			throw new Exception("JSON Deserialize failed: " + httpResult.Text);
			IL_00a8:
			KlB1agqTSo1GlZQR1Uo klB1agqTSo1GlZQR1Uo = default(KlB1agqTSo1GlZQR1Uo);
			if (klB1agqTSo1GlZQR1Uo != null)
			{
				zone = new Zone();
				zone.SrcUpHosts = klB1agqTSo1GlZQR1Uo.I9fWNJv99v().OfdWIwXQdk().Main;
				zone.CdnUpHosts = klB1agqTSo1GlZQR1Uo.I9fWNJv99v().xnjWVnjW2t().Main;
				zone.IovipHost = klB1agqTSo1GlZQR1Uo.KrYWS2RDJy().w9jWyN2oAr().Main[0];
				if (zone.IovipHost.Contains("z1"))
				{
					num = 3;
					if (!cXuaBKfqon3n6Fs6FP4())
					{
						goto IL_017f;
					}
					goto IL_0183;
				}
				if (!zone.IovipHost.Contains("z2"))
				{
					if (zone.IovipHost.Contains("na0"))
					{
						zone.ApiHost = "api-na0.qiniuapi.com";
						zone.RsHost = "rs-na0.qiniu.com";
						zone.RsfHost = "rsf-na0.qiniu.com";
						num = 1;
						if (!cXuaBKfqon3n6Fs6FP4())
						{
							goto IL_017f;
						}
						goto IL_0183;
					}
					if (zone.IovipHost.Contains("as0"))
					{
						zone.ApiHost = "api-as0.qiniuapi.com";
						zone.RsHost = "rs-as0.qiniu.com";
						zone.RsfHost = "rsf-as0.qiniu.com";
					}
					else if (zone.IovipHost.Contains("cn-east-2"))
					{
						zone.ApiHost = "api-cn-east-2.qiniuapi.com";
						zone.RsHost = "rs-cn-east-2.qiniuapi.com";
						zone.RsfHost = "rsf-cn-east-2.qiniuapi.com";
					}
					else if (zone.IovipHost.Contains("ap-northeast-1"))
					{
						zone.ApiHost = "api-ap-northeast-1.qiniuapi.com";
						zone.RsHost = "rs-ap-northeast-1.qiniuapi.com";
						zone.RsfHost = "rsf-ap-northeast-1.qiniuapi.com";
					}
					else
					{
						zone.ApiHost = "api.qiniuapi.com";
						zone.RsHost = "rs.qiniu.com";
						zone.RsfHost = "rsf.qiniu.com";
					}
				}
				else
				{
					zone.ApiHost = "api-z2.qiniuapi.com";
					zone.RsHost = "rs-z2.qiniu.com";
					zone.RsfHost = "rsf-z2.qiniu.com";
				}
				goto IL_02c5;
			}
			goto IL_02f4;
			IL_017f:
			int num2 = default(int);
			num = num2;
			goto IL_0183;
			IL_0183:
			switch (num)
			{
			case 4:
				klB1agqTSo1GlZQR1Uo = JsonConvert.DeserializeObject<KlB1agqTSo1GlZQR1Uo>(httpResult.Text);
				break;
			case 2:
				break;
			case 3:
				zone.ApiHost = "api-z1.qiniuapi.com";
				zone.RsHost = "rs-z1.qiniu.com";
				zone.RsfHost = "rsf-z1.qiniu.com";
				goto IL_02c5;
			case 1:
				goto IL_02c5;
			default:
				goto IL_02f4;
			}
			goto IL_00a8;
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("[{0}] QueryZone Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				stringBuilder.Append(ex2.Message + " ");
			}
			stringBuilder.AppendLine();
			throw new lkv3bMqsFwsT98BDoV0(httpResult, stringBuilder.ToString());
		}
	}

	static ZoneHelper()
	{
		cV2WwA8nXL = new Dictionary<string, Zone>();
		GLtWtXdSZt = new object();
	}

	internal static bool cXuaBKfqon3n6Fs6FP4()
	{
		return D6aMjefbWtw0d6YDs1G == null;
	}
}
