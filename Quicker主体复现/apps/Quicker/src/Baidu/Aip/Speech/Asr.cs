using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Speech;

public class Asr : Base
{
	public const string UrlAsr = "https://vop.baidu.com/server_api";

	public const string UrlAsrPro = "https://vop.baidu.com/pro_api";

	public const string UrlAsrStream = "https://vop.baidu.com/open/asr";

	internal static Asr iQxHpZ2wuNQKdHp6qu7;

	public Asr(string appId, string apiKey, string secretKey)
		: base(appId, apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json
		};
	}

	public JObject Recognize(byte[] data, string format, int rate, Dictionary<string, object> options = null)
	{
		PreAction();
		CheckNotNull(data, "data");
		CheckNotNull(format, "format");
		AipHttpRequest aipHttpRequest = DefaultRequest("https://vop.baidu.com/server_api");
		aipHttpRequest.Bodys["format"] = format;
		aipHttpRequest.Bodys["rate"] = rate;
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		if (!aipHttpRequest.Bodys.ContainsKey("cuid"))
		{
			aipHttpRequest.Bodys["cuid"] = base.Cuid;
		}
		if (!aipHttpRequest.Bodys.ContainsKey("channel"))
		{
			aipHttpRequest.Bodys["channel"] = 1;
		}
		aipHttpRequest.Bodys["len"] = data.Length;
		aipHttpRequest.Bodys["speech"] = Convert.ToBase64String(data);
		aipHttpRequest.Bodys["token"] = base.Token;
		return PostAction(aipHttpRequest);
	}

	public JObject Recognize(string url, string callback, string format, int rate, Dictionary<string, object> options = null)
	{
		PreAction();
		CheckNotNull(url, "url");
		CheckNotNull(format, "format");
		CheckNotNull(callback, "callback");
		AipHttpRequest aipHttpRequest = DefaultRequest("https://vop.baidu.com/server_api");
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		aipHttpRequest.Bodys["url"] = url;
		aipHttpRequest.Bodys["callback"] = callback;
		aipHttpRequest.Bodys["format"] = format;
		aipHttpRequest.Bodys["rate"] = rate;
		if (!aipHttpRequest.Bodys.ContainsKey("cuid"))
		{
			aipHttpRequest.Bodys["cuid"] = base.Cuid;
		}
		if (!aipHttpRequest.Bodys.ContainsKey("channel"))
		{
			aipHttpRequest.Bodys["channel"] = 1;
		}
		aipHttpRequest.Bodys["token"] = base.Token;
		return PostAction(aipHttpRequest);
	}

	public JObject RecognizePro(byte[] data, string format, int rate = 16000, int devPid = 80001, Dictionary<string, object> options = null)
	{
		PreAction();
		CheckNotNull(data, "data");
		CheckNotNull(format, "format");
		AipHttpRequest aipHttpRequest = DefaultRequest("https://vop.baidu.com/pro_api");
		aipHttpRequest.Bodys["format"] = format;
		aipHttpRequest.Bodys["rate"] = rate;
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		if (!aipHttpRequest.Bodys.ContainsKey("cuid"))
		{
			aipHttpRequest.Bodys["cuid"] = base.Cuid;
		}
		if (!aipHttpRequest.Bodys.ContainsKey("channel"))
		{
			aipHttpRequest.Bodys["channel"] = 1;
		}
		aipHttpRequest.Bodys["len"] = data.Length;
		aipHttpRequest.Bodys["speech"] = Convert.ToBase64String(data);
		aipHttpRequest.Bodys["token"] = base.Token;
		aipHttpRequest.Bodys["dev_pid"] = devPid;
		return PostAction(aipHttpRequest);
	}

	public JObject Recognize(Stream speech, string cuid, string format, int rate, int pid)
	{
		string value = JsonConvert.SerializeObject(new Dictionary<string, object>
		{
			{ "apikey", base.ApiKey },
			{ "secretkey", base.SecretKey },
			{
				"appid",
				int.Parse(base.AppId)
			},
			{ "cuid", cuid },
			{ "sample_rate", rate },
			{ "format", format },
			{ "task_id", pid }
		}, Formatting.None);
		byte[] array = new TlvPacket(TlvType.AsrBegin, value).ToBytes();
		byte[] array2 = new byte[2560];
		int num = speech.Read(array2, 0, 2560);
		if (num == 0)
		{
			throw new AipException("Speech bytes stream empty");
		}
		string text = $"{Guid.NewGuid()}{Guid.NewGuid()}".Replace("-", "");
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://vop.baidu.com/open/asr?id=" + text);
		httpWebRequest.Method = "POST";
		httpWebRequest.ReadWriteTimeout = base.Timeout;
		httpWebRequest.Timeout = base.Timeout;
		httpWebRequest.SendChunked = true;
		httpWebRequest.AllowWriteStreamBuffering = false;
		httpWebRequest.ContentType = "application/octet-stream";
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num > 0)
			{
				byte[] array3 = new TlvPacket(TlvType.AsrData, array2, num).ToBytes();
				requestStream.Write(array3, 0, array3.Length);
				num2 = 0;
				if (!BdmD212Tx81U7xmtiip())
				{
					num2 = num3;
				}
			}
			else
			{
				byte[] array4 = new TlvPacket(TlvType.AsrEnd).ToBytes();
				requestStream.Write(array4, 0, array4.Length);
				requestStream.Close();
				num2 = 2;
				if (iQxHpZ2wuNQKdHp6qu7 == null)
				{
					break;
				}
			}
			while (true)
			{
				switch (num2)
				{
				default:
					num = speech.Read(array2, 0, 2560);
					num2 = 1;
					if (!BdmD212Tx81U7xmtiip())
					{
						continue;
					}
					break;
				case 1:
					break;
				case 2:
					goto end_IL_01fc;
				}
				break;
			}
			continue;
			end_IL_01fc:
			break;
		}
		List<TlvPacket> list = TlvPacket.ParseFromBytes(Utils.StreamToBytes(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream())).ToList();
		if (list.Count == 0)
		{
			throw new AipException("Server return empty");
		}
		string text2 = "";
		try
		{
			text2 = Encoding.UTF8.GetString(list[0].V);
			return JsonConvert.DeserializeObject(text2) as JObject;
		}
		catch (Exception ex)
		{
			throw new AipException(ex.Message + text2);
		}
	}

	internal static bool BdmD212Tx81U7xmtiip()
	{
		return iQxHpZ2wuNQKdHp6qu7 == null;
	}
}
