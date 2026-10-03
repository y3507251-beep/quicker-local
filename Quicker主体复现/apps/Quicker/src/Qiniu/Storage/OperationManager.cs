using System;
using System.IO;
using System.Text;
using GFy17Dq3Ka8YBV2L15c;
using Qiniu.Http;
using Qiniu.Util;

namespace Qiniu.Storage;

public class OperationManager
{
	private Auth G7CYaNAE9s;

	private Mac ynTY7TC9rn;

	private Config fsoYRKRJMO;

	private HttpManager zOWYqJNpEJ;

	private static OperationManager UhS7FGoACS9gbqNTtTo;

	public OperationManager(Mac mac, Config config)
	{
		ynTY7TC9rn = mac;
		G7CYaNAE9s = new Auth(mac);
		fsoYRKRJMO = config;
		zOWYqJNpEJ = new HttpManager(false);
	}

	public PfopResult Pfop(string bucket, string key, string fops, string pipeline, string notifyUrl, bool force)
	{
		PfopResult pfopResult = new PfopResult();
		try
		{
			string url = $"{fsoYRKRJMO.ApiHost(ynTY7TC9rn.AccessKey, bucket)}/pfop/";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("bucket={0}&key={1}&fops={2}", StringHelper.UrlEncode(bucket), StringHelper.UrlEncode(key), StringHelper.UrlEncode(fops));
			if (!string.IsNullOrEmpty(notifyUrl))
			{
				stringBuilder.AppendFormat("&notifyURL={0}", StringHelper.UrlEncode(notifyUrl));
			}
			if (force)
			{
				stringBuilder.Append("&force=1");
			}
			if (!string.IsNullOrEmpty(pipeline))
			{
				stringBuilder.AppendFormat("&pipeline={0}", pipeline);
			}
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			string token = G7CYaNAE9s.CreateManageToken(url, bytes);
			HttpResult hr = zOWYqJNpEJ.PostForm(url, bytes, token);
			pfopResult.Shadow(hr);
			if (dCdjFXonLXGgQNC5R3B())
			{
				switch (0)
				{
				}
			}
		}
		catch (lkv3bMqsFwsT98BDoV0 lkv3bMqsFwsT98BDoV)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendFormat("[{0}] [pfop] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			int num2 = default(int);
			for (Exception ex = lkv3bMqsFwsT98BDoV; ex != null; ex = ex.InnerException)
			{
				stringBuilder2.Append(ex.Message + " ");
				int num = 0;
				if (UhS7FGoACS9gbqNTtTo != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
			stringBuilder2.AppendLine();
			pfopResult.Code = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			pfopResult.RefCode = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Code;
			pfopResult.Text = lkv3bMqsFwsT98BDoV.iAMYoeWVgS.Text;
			pfopResult.RefText += stringBuilder2.ToString();
		}
		return pfopResult;
	}

	public PfopResult Pfop(string bucket, string key, string[] fops, string pipeline, string notifyUrl, bool force)
	{
		string fops2 = string.Join(";", fops);
		return Pfop(bucket, key, fops2, pipeline, notifyUrl, force);
	}

	public PrefopResult Prefop(string persistentId)
	{
		PrefopResult prefopResult = new PrefopResult();
		string arg = (fsoYRKRJMO.UseHttps ? "https://" : "http://");
		string url = $"{arg}{Config.DefaultApiHost}/status/get/prefop?id={persistentId}";
		HttpResult hr = new HttpManager(false).Get(url, null);
		prefopResult.Shadow(hr);
		return prefopResult;
	}

	public HttpResult Dfop(string fop, string uri)
	{
		if (Qiniu.Util.UrlHelper.IsValidUrl(uri))
		{
			return DfopUrl(fop, uri);
		}
		return DfopData(fop, uri);
	}

	public HttpResult DfopText(string fop, string text)
	{
		new HttpResult();
		string arg = (fsoYRKRJMO.UseHttps ? "https://" : "http://");
		string url = $"{arg}{Config.DefaultApiHost}/dfop?fop={fop}";
		string token = G7CYaNAE9s.CreateManageToken(url);
		string text2 = HttpManager.CreateFormDataBoundary();
		string text3 = "--" + text2;
		StringBuilder stringBuilder = new StringBuilder();
		if (UhS7FGoACS9gbqNTtTo != null)
		{
			switch (0)
			{
			}
		}
		stringBuilder.AppendLine(text3);
		stringBuilder.AppendFormat("Content-Type: {0}", ContentType.TEXT_PLAIN);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("Content-Disposition: form-data; name=data; filename=text");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(text);
		stringBuilder.AppendLine(text3 + "--");
		byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
		return zOWYqJNpEJ.PostMultipart(url, bytes, text2, token, true);
	}

	public HttpResult DfopTextFile(string fop, string textFile)
	{
		HttpResult httpResult = new HttpResult();
		if (File.Exists(textFile))
		{
			httpResult = DfopText(fop, File.ReadAllText(textFile));
		}
		else
		{
			httpResult.RefCode = -3;
			httpResult.RefText = "[dfop-error] File not found: " + textFile;
		}
		return httpResult;
	}

	public HttpResult DfopUrl(string fop, string url)
	{
		new HttpResult();
		string text = (fsoYRKRJMO.UseHttps ? "https://" : "http://");
		string text2 = StringHelper.UrlEncode(url);
		string url2 = $"{text}{Config.DefaultApiHost}/dfop?fop={fop}&url={text2}";
		string token = G7CYaNAE9s.CreateManageToken(url2);
		return zOWYqJNpEJ.Post(url2, token, true);
	}

	public HttpResult DfopData(string fop, string localFile)
	{
		HttpResult httpResult = new HttpResult();
		try
		{
			string arg = (fsoYRKRJMO.UseHttps ? "https://" : "http://");
			string url = $"{arg}{Config.DefaultApiHost}/dfop?fop={fop}";
			string token = G7CYaNAE9s.CreateManageToken(url);
			string text = HttpManager.CreateFormDataBoundary();
			string text2 = "--" + text;
			int num = 0;
			if (dCdjFXonLXGgQNC5R3B())
			{
				goto IL_006a;
			}
			goto IL_0125;
			IL_0125:
			MemoryStream memoryStream = default(MemoryStream);
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			byte[] bytes2 = default(byte[]);
			switch (num)
			{
			case 1:
				break;
			default:
				memoryStream.Write(bytes, 0, bytes.Length);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(bytes2, 0, bytes2.Length);
				httpResult = zOWYqJNpEJ.PostMultipart(url, memoryStream.ToArray(), text, token, true);
				goto end_IL_0007;
			}
			goto IL_006a;
			IL_006a:
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(text2);
			string fileName = Path.GetFileName(localFile);
			stringBuilder.AppendFormat("Content-Type: {0}", ContentType.APPLICATION_OCTET_STREAM);
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("Content-Disposition: form-data; name=\"data\"; filename={0}", fileName);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.AppendLine();
			stringBuilder2.AppendLine(text2 + "--");
			bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			array = File.ReadAllBytes(localFile);
			bytes2 = Encoding.UTF8.GetBytes(stringBuilder2.ToString());
			memoryStream = new MemoryStream();
			num = 0;
			if (UhS7FGoACS9gbqNTtTo != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0125;
			end_IL_0007:;
		}
		catch (Exception ex)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.AppendFormat("[{0}] [dfop] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				stringBuilder3.Append(ex2.Message + " ");
			}
			stringBuilder3.AppendLine();
			httpResult.RefCode = 0;
			httpResult.RefText += stringBuilder3.ToString();
		}
		return httpResult;
	}

	internal static bool dCdjFXonLXGgQNC5R3B()
	{
		return UhS7FGoACS9gbqNTtTo == null;
	}
}
