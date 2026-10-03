using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using IflySdk.Enum;
using IflySdk.Model.Common;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.Services.Speech;
using Quicker.Common.Vm;

namespace IflySdk.Common;

public class ApiAuthorization
{
	private static ApiAuthorization uiQdoY9GvO6gt3jwCB3;

	private static string yJ7h4K0D5W(string string_0, string string_1)
	{
		using HMACSHA256 hMACSHA = new HMACSHA256(Encoding.UTF8.GetBytes(string_0));
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = hMACSHA.ComputeHash(bytes);
		hMACSHA.Clear();
		return Convert.ToBase64String(bytes);
	}

	public static string BuildAuthUrl(AppSettings _settings)
	{
		int num = 2;
		Uri uri;
		string text;
		string s;
		while (true)
		{
			uri = null;
			int num2 = 1;
			if (!wWWvAA90KJOTljbLBmK())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 2:
				continue;
			case 1:
			{
				if (_settings.ApiType == ApiType.ASR)
				{
					uri = new Uri(_settings.ASRUrl);
				}
				else
				{
					if (_settings.ApiType != ApiType.TTS)
					{
						goto default;
					}
					uri = new Uri(_settings.TTSUrl);
				}
				if (!string.IsNullOrEmpty(_settings.QuickerAuthSign))
				{
					text = _settings.QuickerAuthTime?.ToString("r");
					s = _settings.QuickerAuthSign;
					break;
				}
				text = DateTime.UtcNow.ToString("r");
				string string_ = "host: " + uri.Host + "\ndate: " + text + "\nGET " + uri.LocalPath + " HTTP/1.1";
				string text2 = yJ7h4K0D5W(_settings.ApiSecret, string_);
				s = "api_key=\"" + _settings.ApiKey + "\", algorithm=\"hmac-sha256\", headers=\"host date request-line\", signature=\"" + text2 + "\"";
				break;
			}
			default:
				throw new Exception("Unknow Api type.");
			}
			break;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(uri.ToString());
		stringBuilder.Append("?");
		stringBuilder.Append("authorization=");
		stringBuilder.Append(Convert.ToBase64String(Encoding.UTF8.GetBytes(s)));
		stringBuilder.Append("&");
		stringBuilder.Append("date=");
		stringBuilder.Append(HttpUtility.UrlEncode(text).Replace("+", "%20"));
		stringBuilder.Append("&");
		stringBuilder.Append("host=");
		stringBuilder.Append(uri.Host);
		return stringBuilder.ToString();
	}

	public static string BuildAuthUrlForQuicker(AppSettings _settings)
	{
		if (_settings.ApiType != ApiType.ASR)
		{
			throw new Exception("Quicker账号只支持ASR语音识别.");
		}
		Uri uri = null;
		if (_settings.ApiType == ApiType.ASR)
		{
			uri = new Uri(_settings.ASRUrl);
		}
		else
		{
			if (_settings.ApiType != ApiType.TTS)
			{
				throw new Exception("Unknow Api type.");
			}
			uri = new Uri(_settings.TTSUrl);
		}
		ApiResult<SpeechAuthDto> result = aFIptTXYsUoTUF4v33R.lDstbmARhdW().GetAwaiter().GetResult();
		if (!result.IsSuccess)
		{
			throw new Exception(result.Message);
		}
		SpeechAuthDto data = result.Data;
		string str = data.Now.ToString("r");
		string authorization = data.Authorization;
		if (!wWWvAA90KJOTljbLBmK())
		{
			switch (0)
			{
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(uri.ToString());
		stringBuilder.Append("?");
		stringBuilder.Append("authorization=");
		stringBuilder.Append(Convert.ToBase64String(Encoding.UTF8.GetBytes(authorization)));
		stringBuilder.Append("&");
		stringBuilder.Append("date=");
		stringBuilder.Append(HttpUtility.UrlEncode(str).Replace("+", "%20"));
		stringBuilder.Append("&");
		stringBuilder.Append("host=");
		stringBuilder.Append(uri.Host);
		return stringBuilder.ToString();
	}

	static ApiAuthorization()
	{
	}

	internal static bool wWWvAA90KJOTljbLBmK()
	{
		return uiQdoY9GvO6gt3jwCB3 == null;
	}

	internal static void N4WYK29dUZrMGksbDBr()
	{
	}
}
