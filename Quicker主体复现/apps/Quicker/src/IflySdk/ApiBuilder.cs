using System;
using IflySdk.Enum;
using IflySdk.Model.Common;
using IflySdk.Model.IAT;
using IflySdk.Model.TTS;

namespace IflySdk;

public class ApiBuilder
{
	private AppSettings sxxZcOCN05;

	private string iIEZVXGK2a = "";

	private string qjkZZEvCSQ = "zh_cn";

	private string keBZ9pGek7 = "iat";

	private string OHyZhTr3WM = "mandarin";

	private string sxiZemLB45 = "audio/L16;rate=16000";

	private string BXuZYbshZM = "raw";

	private int ytyZIrd272 = 3000;

	private EventHandler<ErrorEventArgs> rGOZWS05lb;

	private EventHandler<string> N6gZkfZpcE;

	private string mJ6ZGITIXT = "intp65";

	private string vJDZspjOSD = "raw";

	private string m7AZHbBMf0 = "audio/L16;rate=16000";

	private string m2AZ1RjgOI = "xiaoyan";

	private int W15Zbqnna7 = 50;

	private int jeDZ62vZpI = 50;

	private string ktYZXH6gSE = "UTF8";

	private string scZZm0r3Lv = "result.wav";

	internal static ApiBuilder IFe4EsruO5GAoP4jXFA;

	public ApiBuilder WithVadEos(int time)
	{
		if (time < 0 || time > 30000)
		{
			ytyZIrd272 = 3000;
		}
		else
		{
			ytyZIrd272 = time;
		}
		return this;
	}

	public ApiBuilder WithUid(string uid)
	{
		if (!string.IsNullOrEmpty(uid))
		{
			iIEZVXGK2a = uid;
		}
		else
		{
			iIEZVXGK2a = "";
		}
		return this;
	}

	public ApiBuilder WithLanguage(string language)
	{
		if (!string.IsNullOrEmpty(language))
		{
			qjkZZEvCSQ = language;
		}
		else
		{
			qjkZZEvCSQ = "zh_cn";
		}
		return this;
	}

	public ApiBuilder WithDomain(string domain)
	{
		if (!string.IsNullOrEmpty(domain))
		{
			keBZ9pGek7 = domain;
		}
		else
		{
			keBZ9pGek7 = "iat";
		}
		return this;
	}

	public ApiBuilder WithAccent(string accent)
	{
		if (!string.IsNullOrEmpty(accent))
		{
			OHyZhTr3WM = accent;
		}
		else
		{
			OHyZhTr3WM = "mandarin";
		}
		return this;
	}

	public ApiBuilder WithFormat(string format)
	{
		if (!string.IsNullOrEmpty(format))
		{
			sxiZemLB45 = format;
		}
		else
		{
			sxiZemLB45 = "audio/L16;rate=16000";
		}
		return this;
	}

	public ApiBuilder WithEncoding(string encoding)
	{
		if (!string.IsNullOrEmpty(encoding))
		{
			BXuZYbshZM = encoding;
		}
		else
		{
			BXuZYbshZM = "raw";
		}
		return this;
	}

	public ASRApi BuildASR()
	{
		if (sxxZcOCN05 == null)
		{
			throw new Exception("App setting can not null.");
		}
		if (string.IsNullOrEmpty(qjkZZEvCSQ))
		{
			throw new Exception("Language set can not null.");
		}
		IflySdk.Model.IAT.CommonParams common = new IflySdk.Model.IAT.CommonParams
		{
			app_id = sxxZcOCN05.AppID,
			uid = iIEZVXGK2a
		};
		IflySdk.Model.IAT.DataParams data = new IflySdk.Model.IAT.DataParams
		{
			format = sxiZemLB45,
			encoding = BXuZYbshZM
		};
		IflySdk.Model.IAT.BusinessParams business = new IflySdk.Model.IAT.BusinessParams
		{
			language = qjkZZEvCSQ,
			domain = keBZ9pGek7,
			accent = OHyZhTr3WM,
			vad_eos = ytyZIrd272
		};
		sxxZcOCN05.ApiType = ApiType.ASR;
		ASRApi aSRApi = new ASRApi(sxxZcOCN05, common, data, business);
		aSRApi.OnError += rGOZWS05lb;
		aSRApi.OnMessage += N6gZkfZpcE;
		return aSRApi;
	}

	public ApiBuilder WithBusinessParams(IflySdk.Model.TTS.BusinessParams business)
	{
		if (business != null)
		{
			mJ6ZGITIXT = business.ent;
			vJDZspjOSD = business.aue;
			m7AZHbBMf0 = business.auf;
			m2AZ1RjgOI = business.vcn;
			W15Zbqnna7 = business.speed;
			jeDZ62vZpI = business.volume;
			ktYZXH6gSE = business.tte;
		}
		return this;
	}

	public ApiBuilder WithEnt(string ent)
	{
		if (!string.IsNullOrEmpty(ent))
		{
			mJ6ZGITIXT = ent;
		}
		else
		{
			mJ6ZGITIXT = "raw";
		}
		return this;
	}

	public ApiBuilder WithAue(string aue)
	{
		if (!string.IsNullOrEmpty(aue))
		{
			vJDZspjOSD = aue;
		}
		else
		{
			vJDZspjOSD = "raw";
		}
		return this;
	}

	public ApiBuilder WithAuf(string auf)
	{
		if (!string.IsNullOrEmpty(auf))
		{
			m7AZHbBMf0 = auf;
		}
		else
		{
			m7AZHbBMf0 = "audio/L16;rate=16000";
		}
		return this;
	}

	public ApiBuilder WithVcn(string vcn)
	{
		if (!string.IsNullOrEmpty(vcn))
		{
			m2AZ1RjgOI = vcn;
		}
		else
		{
			m2AZ1RjgOI = "xiaoyan";
		}
		return this;
	}

	public ApiBuilder WithSpeed(int speed)
	{
		if (speed >= 0 && speed <= 100)
		{
			W15Zbqnna7 = speed;
		}
		else
		{
			W15Zbqnna7 = 50;
		}
		return this;
	}

	public ApiBuilder WithVolume(int volume)
	{
		if (volume >= 0 && volume <= 100)
		{
			jeDZ62vZpI = volume;
		}
		else
		{
			jeDZ62vZpI = 50;
		}
		return this;
	}

	public ApiBuilder WithTte(string tte)
	{
		if (!string.IsNullOrEmpty(tte))
		{
			ktYZXH6gSE = tte;
		}
		else
		{
			ktYZXH6gSE = "UTF8";
		}
		return this;
	}

	public ApiBuilder WithSavePath(string savePath)
	{
		if (!string.IsNullOrEmpty(savePath))
		{
			scZZm0r3Lv = savePath;
		}
		else
		{
			scZZm0r3Lv = "result.wav";
		}
		return this;
	}

	public TTSApi BuildTTS()
	{
		if (sxxZcOCN05 == null)
		{
			throw new Exception("App setting can not null.");
		}
		IflySdk.Model.TTS.CommonParams common = new IflySdk.Model.TTS.CommonParams
		{
			app_id = sxxZcOCN05.AppID,
			uid = iIEZVXGK2a
		};
		IflySdk.Model.TTS.DataParams data = new IflySdk.Model.TTS.DataParams
		{
			text = ""
		};
		IflySdk.Model.TTS.BusinessParams business = new IflySdk.Model.TTS.BusinessParams
		{
			ent = mJ6ZGITIXT,
			aue = vJDZspjOSD,
			auf = m7AZHbBMf0,
			vcn = m2AZ1RjgOI,
			speed = W15Zbqnna7,
			volume = jeDZ62vZpI,
			tte = ktYZXH6gSE
		};
		sxxZcOCN05.ApiType = ApiType.TTS;
		TTSApi tTSApi = new TTSApi(sxxZcOCN05, common, data, business);
		tTSApi.OnError += rGOZWS05lb;
		tTSApi.OnMessage += N6gZkfZpcE;
		return tTSApi;
	}

	public ApiBuilder UseError(EventHandler<ErrorEventArgs> onError)
	{
		rGOZWS05lb = onError;
		return this;
	}

	public ApiBuilder UseMessage(EventHandler<string> onMessage)
	{
		N6gZkfZpcE = onMessage;
		return this;
	}

	public ApiBuilder WithAppSettings(AppSettings settings)
	{
		sxxZcOCN05 = settings;
		if (sxxZcOCN05 == null || string.IsNullOrEmpty(sxxZcOCN05.AppID))
		{
			throw new Exception("App setting cannot null.");
		}
		return this;
	}

	static ApiBuilder()
	{
	}

	internal static bool WoOLLXrokIUEsXkkart()
	{
		return IFe4EsruO5GAoP4jXFA == null;
	}

	internal static void jIU8tbrZdw7vmYv2fPP()
	{
	}
}
