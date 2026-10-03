using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cuiliang.AliyunOssSdk.Utility;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using WebSocketSharp.Net;

namespace SimpleHttp;

public static class ResponseExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ubdv8nRJ5Jq;

		public static Func<string, string> denv84ZgYOv;

		public static Func<string, bool> RQav85VYmhq;

		public static Func<string, long> K0Ev8DNKYHf;

		private static _003C_003Ec b8ruH0c0DlZFiol9Y3fS;

		static _003C_003Ec()
		{
			Ubdv8nRJ5Jq = new _003C_003Ec();
		}

		internal string oGkv8BtlOfn(string x)
		{
			return x.Trim();
		}

		internal bool muAv8QYy1Uq(string x)
		{
			return x == "Range";
		}

		internal long pOiv8jlcL0v(string x)
		{
			return long.Parse(x);
		}

		internal static bool owyWFAc03mGH8kSqO6Rt()
		{
			return b8ruH0c0DlZFiol9Y3fS == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass10_0
	{
		public HttpListenerRequest tWev8dBXhg7;

		public HttpListenerResponse WIBv8o1dhxA;
	}

	internal static object zeUO9LJOKVSUZxDUCjn;

	public static HttpListenerResponse WithCORS(this HttpListenerResponse response)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response", "Response must not be null.");
		}
		response.WithHeader("Access-Control-Allow-Origin", "*");
		response.WithHeader("Access-Control-Allow-Headers", "Cache-Control, Pragma, Accept, Origin, Authorization, Content-Type, X-Requested-With");
		response.WithHeader("Access-Control-Allow-Methods", "GET, POST");
		response.WithHeader("Access-Control-Allow-Credentials", "true");
		return response;
	}

	public static HttpListenerResponse WithContentType(this HttpListenerResponse response, string contentType)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		response.ContentType = contentType;
		return response;
	}

	public static HttpListenerResponse WithHeader(this HttpListenerResponse response, string name, string value)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name");
		}
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ArgumentNullException("name");
		}
		switch (name)
		{
		default:
			response.Headers[name] = value;
			break;
		case "transfer-encoding":
			if (value.Contains("chunked"))
			{
				throw new ArgumentException("name", "Use 'SendChunked' property instead.");
			}
			response.Headers[name] = value;
			break;
		case "keep-alive":
		{
			bool.TryParse(value, out var result2);
			response.KeepAlive = result2;
			break;
		}
		case "content-type":
			response.ContentType = value;
			break;
		case "content-length":
		{
			int.TryParse(value, out var result);
			response.ContentLength64 = result;
			break;
		}
		}
		return response;
	}

	public static HttpListenerResponse WithCode(this HttpListenerResponse response, HttpStatusCode statusCode = HttpStatusCode.OK)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		response.StatusCode = (int)statusCode;
		return response;
	}

	public static HttpListenerResponse WithCookie(this HttpListenerResponse response, string name, string value)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		response.Cookies.Add(new Cookie(name, value));
		return response;
	}

	public static HttpListenerResponse WithCookie(this HttpListenerResponse response, string name, string value, DateTime expires)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Cookie cookie = new Cookie(name, value);
		cookie.Expires = expires;
		response.Cookies.Add(cookie);
		return response;
	}

	public static HttpListenerResponse WithCookie(this HttpListenerResponse response, Cookie cookie)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		response.Cookies.Add(cookie);
		return response;
	}

	public static void AsText(this HttpListenerResponse response, string txt, string mime = "text/html")
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (txt == null)
		{
			if (zeUO9LJOKVSUZxDUCjn == null)
			{
				switch (0)
				{
				}
			}
			throw new ArgumentNullException("txt");
		}
		if (mime == null)
		{
			throw new ArgumentNullException("mime");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(txt);
		response.ContentLength64 = bytes.Length;
		response.ContentEncoding = Encoding.UTF8;
		response.ContentType = mime;
		response.OutputStream.Write(bytes, 0, bytes.Length);
	}

	public static void AsRedirect(this HttpListenerResponse response, string url)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		response.StatusCode = 302;
		response.RedirectLocation = url;
		response.Close();
	}

	internal static void gPVRXMIYBX(this HttpListenerResponse httpListenerResponse_0, HttpListenerRequest httpListenerRequest_0, string string_0, bool bool_0)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_0_ = default(_003C_003Ec__DisplayClass10_0);
		_003C_003Ec__DisplayClass10_0_.tWev8dBXhg7 = httpListenerRequest_0;
		_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA = httpListenerResponse_0;
		if (!File.Exists(string_0))
		{
			_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.WithCode(HttpStatusCode.NotFound);
			throw new FileNotFoundException("The file '" + string_0 + "' was not found.");
		}
		DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(string_0);
		_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.WithHeader("Accept-Ranges", "bytes");
		_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.Headers["ETag"] = lastWriteTimeUtc.Ticks.ToString("x");
		if (!NlWY02JJKHcxH1xLaaK())
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.Headers["Last-Modified"] = lastWriteTimeUtc.ToString("R");
		_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.WithHeader("Cache-Control", "public, max-age=10");
		if (bool_0)
		{
			_003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA.WithHeader("Content-Disposition", "attachment; filename*=UTF-8''" + Uri.EscapeDataString(Path.GetFileName(string_0)));
		}
		if (_003C_003Ec__DisplayClass10_0_.tWev8dBXhg7.Headers["Range"] == null && nVkRKiIUMq(lastWriteTimeUtc, ref _003C_003Ec__DisplayClass10_0_))
		{
			return;
		}
		string mime = MimeHelper.GetMime(string_0);
		using FileStream fileStream = File.OpenRead(string_0);
		Encoding encoding_ = null;
		if (mime.StartsWith("text/") || Path.GetExtension(string_0).ToLower().EqualsAny(true, ".txt", ".bat", ".json", ".md"))
		{
			encoding_ = TxtFileEncoder.GetEncoding(fileStream);
			fileStream.Position = 0L;
		}
		FlLRmBmODH(_003C_003Ec__DisplayClass10_0_.tWev8dBXhg7, _003C_003Ec__DisplayClass10_0_.WIBv8o1dhxA, fileStream, mime, encoding_);
	}

	public static void AsBytes(this HttpListenerResponse response, HttpListenerRequest request, byte[] data, string mime = "octet/stream")
	{
		if (data == null)
		{
			response.WithCode(HttpStatusCode.BadRequest);
			throw new ArgumentNullException("data");
		}
		MemoryStream stream_ = new MemoryStream(data);
		FlLRmBmODH(request, response, stream_, mime);
	}

	public static void AsStream(this HttpListenerResponse response, HttpListenerRequest request, Stream stream, string mime = "octet/stream")
	{
		if (stream == null)
		{
			response.WithCode(HttpStatusCode.BadRequest);
			throw new ArgumentNullException("stream");
		}
		FlLRmBmODH(request, response, stream, mime);
	}

	private static void FlLRmBmODH(HttpListenerRequest httpListenerRequest_0, HttpListenerResponse httpListenerResponse_0, Stream stream_0, string string_0, Encoding encoding_0 = null)
	{
        long num4 = default;
		long num;
		long num2;
		int num3;
		if (httpListenerRequest_0.Headers.AllKeys.Count(_003C_003Ec.RQav85VYmhq ?? (_003C_003Ec.RQav85VYmhq = _003C_003Ec.Ubdv8nRJ5Jq.muAv8QYy1Uq)) <= 1)
		{
			httpListenerResponse_0.WithContentType(string_0);
			num = 0L;
			num2 = stream_0.Length - 1L;
			string text = httpListenerRequest_0.Headers["Range"];
			if (text != null)
			{
				long[] array = (string.IsNullOrWhiteSpace(text) ? Array.Empty<long>() : text.Replace("bytes=", string.Empty).Split(new string[1] { "-" }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.K0Ev8DNKYHf ?? (_003C_003Ec.K0Ev8DNKYHf = _003C_003Ec.Ubdv8nRJ5Jq.pOiv8jlcL0v))
					.ToArray());
				num = ((array.Length != 0) ? array[0] : 0L);
				num2 = ((array.Length > 1) ? array[1] : (stream_0.Length - 1L));
				httpListenerResponse_0.WithHeader("Content-Range", "bytes " + num + "-" + num2 + "/" + stream_0.Length).WithCode(HttpStatusCode.PartialContent);
				httpListenerResponse_0.KeepAlive = true;
				num3 = 1;
				if (zeUO9LJOKVSUZxDUCjn == null)
				{
					goto IL_018a;
				}
				goto IL_01b7;
			}
			httpListenerResponse_0.StatusCode = 200;
			goto IL_0199;
		}
		throw new NotSupportedException("Multiple 'Range' headers are not supported.");
		IL_0199:
		num4 = num2 - num + 1L;
		num3 = 0;
		if (zeUO9LJOKVSUZxDUCjn == null)
		{
			goto IL_018a;
		}
		goto IL_01b7;
		IL_018a:
		switch (num3)
		{
		case 1:
			break;
		default:
		{
			httpListenerResponse_0.ContentLength64 = num4;
			httpListenerResponse_0.ContentEncoding = encoding_0;
			int num5 = 4194304;
			try
			{
				stream_0.Position = num;
				if (num == 0L && num4 == stream_0.Length)
				{
					stream_0.CopyTo(httpListenerResponse_0.OutputStream, num5);
				}
				else
				{
					byte[] buffer = new byte[num5];
					CopyStream(stream_0, httpListenerResponse_0.OutputStream, (int)num4, buffer);
				}
				httpListenerResponse_0.OutputStream.Flush();
				return;
			}
			catch (Exception ex) when (ex is HttpListenerException)
			{
				httpListenerResponse_0.StatusCode = 204;
				return;
			}
			finally
			{
				stream_0.Close();
				httpListenerResponse_0.Close();
			}
		}
		}
		goto IL_0199;
		IL_01b7:
		int num6 = default(int);
		num3 = num6;
		goto IL_018a;
	}

	public static void CopyStream(Stream input, Stream output, int bytes, byte[] buffer)
	{
		int num;
		while (bytes > 0 && (num = input.Read(buffer, 0, Math.Min(buffer.Length, bytes))) > 0)
		{
			output.Write(buffer, 0, num);
			bytes -= num;
			output.Flush();
		}
	}

	[CompilerGenerated]
	internal static bool nVkRKiIUMq(DateTime dateTime_0, ref _003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_0_0)
	{
		string text = _003C_003Ec__DisplayClass10_0_0.tWev8dBXhg7.Headers["If-None-Match"];
		if (text != null && text.Split(',').Select(_003C_003Ec.denv84ZgYOv ?? (_003C_003Ec.denv84ZgYOv = _003C_003Ec.Ubdv8nRJ5Jq.oGkv8BtlOfn)).ToArray()
			.Contains(_003C_003Ec__DisplayClass10_0_0.WIBv8o1dhxA.Headers["ETag"]))
		{
			_003C_003Ec__DisplayClass10_0_0.WIBv8o1dhxA.StatusCode = 304;
			_003C_003Ec__DisplayClass10_0_0.WIBv8o1dhxA.Close();
			if (NlWY02JJKHcxH1xLaaK())
			{
				switch (0)
				{
				}
			}
			return true;
		}
		if (DateTime.TryParse(_003C_003Ec__DisplayClass10_0_0.tWev8dBXhg7.Headers["If-Modified-Since"], out var result) && dateTime_0 <= result.ToUniversalTime())
		{
			_003C_003Ec__DisplayClass10_0_0.WIBv8o1dhxA.StatusCode = 304;
			_003C_003Ec__DisplayClass10_0_0.WIBv8o1dhxA.Close();
			return true;
		}
		return false;
	}

	static ResponseExtensions()
	{
	}

	internal static bool NlWY02JJKHcxH1xLaaK()
	{
		return zeUO9LJOKVSUZxDUCjn == null;
	}

	internal static void BeTmrVJugLIGxM4Jl5D()
	{
	}
}
