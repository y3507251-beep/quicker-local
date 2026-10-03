using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Quicker.Modules.Searching.Builtin;

public class HttpDownloader
{
	private readonly string QF9t07iTchA;

	private readonly string XhGt0R4LEqU;

	[CompilerGenerated]
	private Encoding KTWt0qFP7XU;

	[CompilerGenerated]
	private WebHeaderCollection y07t0cUUkYW;

	[CompilerGenerated]
	private Uri r25t0V5RayK;

	[CompilerGenerated]
	private int KXOt0ZqlJSu;

	[CompilerGenerated]
	private IWebProxy pnWt09wxNPs;

	private static HttpDownloader lqpAbeQnRGnRorJfTHOi;

	public Encoding Encoding
	{
		[CompilerGenerated]
		get
		{
			return KTWt0qFP7XU;
		}
		[CompilerGenerated]
		set
		{
			KTWt0qFP7XU = value;
		}
	}

	public WebHeaderCollection Headers
	{
		[CompilerGenerated]
		get
		{
			return y07t0cUUkYW;
		}
		[CompilerGenerated]
		set
		{
			y07t0cUUkYW = value;
		}
	}

	public Uri Url
	{
		[CompilerGenerated]
		get
		{
			return r25t0V5RayK;
		}
		[CompilerGenerated]
		set
		{
			r25t0V5RayK = value;
		}
	}

	public int TimeoutMs
	{
		[CompilerGenerated]
		get
		{
			return KXOt0ZqlJSu;
		}
		[CompilerGenerated]
		set
		{
			KXOt0ZqlJSu = value;
		}
	}

	public IWebProxy Proxy
	{
		[CompilerGenerated]
		get
		{
			return pnWt09wxNPs;
		}
		[CompilerGenerated]
		set
		{
			pnWt09wxNPs = value;
		}
	}

	public HttpDownloader(string url, string referer, string userAgent, int timeoutMs)
	{
		Encoding = Encoding.UTF8;
		Url = new Uri(url);
		XhGt0R4LEqU = userAgent;
		QF9t07iTchA = referer;
		TimeoutMs = timeoutMs;
	}

	public string GetPage()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
		httpWebRequest.Timeout = TimeoutMs;
		if (!string.IsNullOrEmpty(QF9t07iTchA))
		{
			httpWebRequest.Referer = QF9t07iTchA;
			if (!uxlANgQngCcAXIvfeqqB())
			{
				switch (0)
				{
				}
			}
		}
		if (!string.IsNullOrEmpty(XhGt0R4LEqU))
		{
			httpWebRequest.UserAgent = XhGt0R4LEqU;
		}
		httpWebRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
		httpWebRequest.Proxy = Proxy;
		httpWebRequest.UserAgent = XhGt0R4LEqU;
		using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Headers = httpWebResponse.Headers;
		Url = httpWebResponse.ResponseUri;
		return ck2t0yg2cKp(httpWebResponse);
	}

	private string ck2t0yg2cKp(HttpWebResponse httpWebResponse_0)
	{
		int num = 2;
		Stream stream = default(Stream);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			C0Kt08pR2Pf(httpWebResponse_0);
			int num2 = 1;
			if (!uxlANgQngCcAXIvfeqqB())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 2:
				break;
			case 1:
				stream = httpWebResponse_0.GetResponseStream();
				if (httpWebResponse_0.ContentEncoding.ToLower().Contains("gzip"))
				{
					stream = new GZipStream(stream, CompressionMode.Decompress);
				}
				else if (httpWebResponse_0.ContentEncoding.ToLower().Contains("deflate"))
				{
					stream = new DeflateStream(stream, CompressionMode.Decompress);
				}
				memoryStream = new MemoryStream();
				array = new byte[4096];
				num3 = stream.Read(array, 0, array.Length);
				goto IL_00a5;
			default:
				{
					memoryStream.Write(array, 0, num3);
					num3 = stream.Read(array, 0, array.Length);
					goto IL_00a5;
				}
				IL_00a5:
				if (num3 <= 0)
				{
					stream.Close();
					memoryStream.Position = 0L;
					using StreamReader streamReader = new StreamReader(memoryStream, Encoding);
					string string_ = streamReader.ReadToEnd().Trim();
					return OPkt0aAKPai(memoryStream, string_);
				}
				goto default;
			}
		}
	}

	private void C0Kt08pR2Pf(HttpWebResponse httpWebResponse_0)
	{
		string text = null;
		if (string.IsNullOrEmpty(httpWebResponse_0.CharacterSet))
		{
			Match match = Regex.Match(httpWebResponse_0.ContentType, ";\\s*charset\\s*=\\s*(?<charset>.*)", RegexOptions.IgnoreCase);
			int num = 0;
			if (!uxlANgQngCcAXIvfeqqB())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (match.Success)
			{
				text = match.Groups["charset"].Value.Trim('\'', '"');
			}
		}
		else
		{
			text = httpWebResponse_0.CharacterSet;
		}
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				Encoding = Encoding.GetEncoding(text);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private string OPkt0aAKPai(Stream stream_0, string string_2)
	{
		Match match = new Regex("<meta\\s+.*?charset\\s*=\\s*\"?(?<charset>[A-Za-z0-9_-]+)\"?", RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(string_2);
		string text;
		if (match.Success)
		{
			text = match.Groups["charset"].Value.ToLower() ?? "iso-8859-1";
			if (!(text == "unicode"))
			{
				if (!(text == "utf-16"))
				{
					goto IL_0084;
				}
				int num = 0;
				if (lqpAbeQnRGnRorJfTHOi != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			text = "utf-8";
			goto IL_0084;
		}
		goto IL_00c5;
		IL_0084:
		try
		{
			Encoding encoding = Encoding.GetEncoding(text);
			if (Encoding != encoding)
			{
				stream_0.Position = 0L;
				StreamReader streamReader = new StreamReader(stream_0, encoding);
				string_2 = streamReader.ReadToEnd().Trim();
				streamReader.Close();
			}
		}
		catch (ArgumentException)
		{
		}
		goto IL_00c5;
		IL_00c5:
		return string_2;
	}

	internal static bool uxlANgQngCcAXIvfeqqB()
	{
		return lqpAbeQnRGnRorJfTHOi == null;
	}
}
