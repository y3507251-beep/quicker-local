using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using cF2s4eoj0xhjQv4UVon;
using Fuy7DkoWhCdS5kI9xhV;
using IHGJ4aXzANwCaRMsxRt;
using PpIbF8XpCC7OtfHsoeg;
using Qiniu.Http;
using Qiniu.Storage;
using Qiniu.Util;

namespace zYELLMoqxbWOGNUaiSw;

internal class wjVL4jolHMjGL6WrcoQ : eco6AkXLfyZjRmP4RfT
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec FobSeUqE6ie;

		public static UploadProgressHandler fjfSelLZ2or;

		internal static _003C_003Ec o5m6kVWuXWXHTiGFNZEy;

		static _003C_003Ec()
		{
			FobSeUqE6ie = new _003C_003Ec();
		}

		internal void iwcSeFWk45v(long uploaded, long total)
		{
		}

		internal static bool OLZUTSWu2vHx4iGRyAq6()
		{
			return o5m6kVWuXWXHTiGFNZEy == null;
		}
	}

	private readonly Dictionary<string, Zone> HskgWnWElUX = new Dictionary<string, Zone>
	{
		{
			"z0",
			Qiniu.Storage.Zone.ZONE_CN_East
		},
		{
			"cn-east-2",
			Qiniu.Storage.Zone.ZONE_CN_East_2
		},
		{
			"z1",
			Qiniu.Storage.Zone.ZONE_CN_North
		},
		{
			"z2",
			Qiniu.Storage.Zone.ZONE_CN_South
		},
		{
			"na0",
			Qiniu.Storage.Zone.ZONE_US_North
		},
		{
			"as0",
			Qiniu.Storage.Zone.ZONE_AS_Singapore
		},
		{
			"ap-northeast-1",
			Qiniu.Storage.Zone.ZONE_AP_Seoul
		}
	};

	[CompilerGenerated]
	private string egegW4IMrIi;

	[CompilerGenerated]
	private bool W6WgW5keJyQ = true;

	[CompilerGenerated]
	private bool LYKgWDuevyp = true;

	[CompilerGenerated]
	private string YsngWdnvg1j;

	[CompilerGenerated]
	private string Tb7gWovay39;

	[CompilerGenerated]
	private string EsMgWTkcW4A;

	[CompilerGenerated]
	private string Tg6gWMqwkqK;

	private static wjVL4jolHMjGL6WrcoQ zVVLnfQm0odGH4bFJKbh;

	public string Zone
	{
		[CompilerGenerated]
		get
		{
			return egegW4IMrIi;
		}
		[CompilerGenerated]
		set
		{
			egegW4IMrIi = value;
		}
	}

	public string AccessKey
	{
		[CompilerGenerated]
		get
		{
			return YsngWdnvg1j;
		}
		[CompilerGenerated]
		set
		{
			YsngWdnvg1j = value;
		}
	}

	public string Bucket
	{
		[CompilerGenerated]
		get
		{
			return Tb7gWovay39;
		}
		[CompilerGenerated]
		set
		{
			Tb7gWovay39 = value;
		}
	}

	public string SecretKey
	{
		[CompilerGenerated]
		get
		{
			return EsMgWTkcW4A;
		}
		[CompilerGenerated]
		set
		{
			EsMgWTkcW4A = value;
		}
	}

	public string AccessUrl
	{
		[CompilerGenerated]
		get
		{
			return Tg6gWMqwkqK;
		}
		[CompilerGenerated]
		set
		{
			Tg6gWMqwkqK = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool qN0gWslW9P6()
	{
		return W6WgW5keJyQ;
	}

	[SpecialName]
	[CompilerGenerated]
	public void pYogWHY3WtI(bool bool_2)
	{
		W6WgW5keJyQ = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool nkHgWbWmX5p()
	{
		return LYKgWDuevyp;
	}

	[SpecialName]
	[CompilerGenerated]
	public void LnxgW6uTe6P(bool bool_2)
	{
		LYKgWDuevyp = bool_2;
	}

	public void wGfMjLU4H76(IDictionary<string, string> idictionary_0)
	{
		Bucket = idictionary_0.kNjgWW5DqaP("Bucket");
		Zone = idictionary_0.kNjgWW5DqaP("Zone");
		AccessKey = idictionary_0.kNjgWW5DqaP("AccessKey");
		SecretKey = idictionary_0.kNjgWW5DqaP("SecretKey");
		AccessUrl = idictionary_0.kNjgWW5DqaP("AccessUrl");
	}

	public lKRt6fo20yPnP2ZloBB Upload(dqs3ZWowtqiy3yIfw7B request)
	{
		Mac mac = new Mac(AccessKey, SecretKey);
		PutPolicy putPolicy = new PutPolicy
		{
			Scope = Bucket
		};
		putPolicy.SetExpires(3600);
		string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
		if (!HskgWnWElUX.TryGetValue(Zone, out var value))
		{
			value = ZoneHelper.QueryZone(AccessKey, Bucket);
		}
		FormUploader formUploader = new FormUploader(new Config
		{
			Zone = value,
			UseHttps = qN0gWslW9P6(),
			UseCdnDomains = nkHgWbWmX5p(),
			ChunkSize = ChunkUnit.U512K
		});
		string text = AccessUrl.TrimEnd('/');
		HttpResult httpResult = formUploader.UploadStream(request.Hitgkh0KOlt(), request.nlTgkERQYHS(), token, new PutExtra
		{
			ProgressHandler = (_003C_003Ec.fjfSelLZ2or ?? (_003C_003Ec.fjfSelLZ2or = _003C_003Ec.FobSeUqE6ie.iwcSeFWk45v))
		});
		if (httpResult == null || httpResult.Code != 200)
		{
			throw new Exception($"Code:{httpResult?.Code},{httpResult?.Text}");
		}
		string value2 = text + "/" + request.nlTgkERQYHS();
		lKRt6fo20yPnP2ZloBB lKRt6fo20yPnP2ZloBB = new lKRt6fo20yPnP2ZloBB();
		lKRt6fo20yPnP2ZloBB.IsSuccess = true;
		lKRt6fo20yPnP2ZloBB.ErrorMessage = "";
		lKRt6fo20yPnP2ZloBB.H0JgkjiCUa2("");
		lKRt6fo20yPnP2ZloBB.sZkgkMvAYlF("");
		lKRt6fo20yPnP2ZloBB.l82gk5RYXIt(request.nlTgkERQYHS());
		lKRt6fo20yPnP2ZloBB.Url = value2;
		return lKRt6fo20yPnP2ZloBB;
	}

	internal static bool d8hCEFQm1vEIWgAQQORh()
	{
		return zVVLnfQm0odGH4bFJKbh == null;
	}
}
