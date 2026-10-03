using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using WebSocketSharp.Net;

namespace SimpleHttp;

public static class RequestExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec JcKv8rVhEhL;

		public static OnFile dybv8pfKyQ2;

		private static _003C_003Ec A0hqW9c0ntBbjmwT5tSm;

		static _003C_003Ec()
		{
			JcKv8rVhEhL = new _003C_003Ec();
		}

		internal Stream Stsv8xJbNtN(string n, string fn, string ct)
		{
			return new MemoryStream();
		}

		internal static bool zyrlHwc0eTWcmU6c9tDQ()
		{
			return A0hqW9c0ntBbjmwT5tSm == null;
		}
	}

	internal static object WZd8HIJ3JCIaHutQpif;

	public static IList<HttpFile> ParseBody(this WebSocketSharp.Net.HttpListenerRequest request, Dictionary<string, string> args)
	{
		return request.ParseBody(args, _003C_003Ec.dybv8pfKyQ2 ?? (_003C_003Ec.dybv8pfKyQ2 = _003C_003Ec.JcKv8rVhEhL.Stsv8xJbNtN));
	}

	public static IList<HttpFile> ParseBody(this WebSocketSharp.Net.HttpListenerRequest request, Dictionary<string, string> args, OnFile onFile)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		if (onFile == null)
		{
			throw new ArgumentNullException("onFile");
		}
		IList<HttpFile> result = new List<HttpFile>();
		if (request.ContentType.StartsWith("application/x-www-form-urlencoded"))
		{
			oyKRc9lUgb(request, args);
		}
		else
		{
			if (!request.ContentType.StartsWith("multipart/form-data"))
			{
				throw new NotSupportedException("The body content-type is not supported.");
			}
			result = OHxRVtlvW2(request, args, onFile);
		}
		return result;
	}

	private static bool oyKRc9lUgb(WebSocketSharp.Net.HttpListenerRequest httpListenerRequest_0, Dictionary<string, string> dictionary_0)
	{
		if (httpListenerRequest_0.ContentType != "application/x-www-form-urlencoded")
		{
			return false;
		}
		string text = httpListenerRequest_0.BodyAsString();
		if (text == null)
		{
			return false;
		}
		string[] array = text.Split('&');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			if (array2.Length == 2)
			{
				dictionary_0.Add(array2[0], WebUtility.UrlDecode(array2[1]));
			}
		}
		return true;
	}

	public static string BodyAsString(this WebSocketSharp.Net.HttpListenerRequest request)
	{
		if (request.HasEntityBody)
		{
			string text = null;
			using StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding);
			return streamReader.ReadToEnd();
		}
		return null;
	}

	private static IList<HttpFile> OHxRVtlvW2(WebSocketSharp.Net.HttpListenerRequest httpListenerRequest_0, Dictionary<string, string> dictionary_0, OnFile onFile_0)
	{
		if (!httpListenerRequest_0.ContentType.StartsWith("multipart/form-data"))
		{
			throw new InvalidDataException("不是'multipart/form-data'类型。");
		}
		Match match = Regex.Match(httpListenerRequest_0.ContentType, "boundary=(?<boundary>.+?)($|;|\\s)");
		if (!match.Success)
		{
			throw new InvalidDataException("无法提取表单边界。");
		}
		string text = match.Groups["boundary"].Value;
		if (text.StartsWith("\"") && text.EndsWith("\""))
		{
			text = text.Substring(1, text.Length - 2);
		}
		byte[] bytes = httpListenerRequest_0.ContentEncoding.GetBytes("--" + text);
		byte[] bytes2 = httpListenerRequest_0.ContentEncoding.GetBytes("--" + text + "--");
		httpListenerRequest_0.ContentEncoding.GetBytes("\r\n");
		List<HttpFile> list = new List<HttpFile>();
		using (BufferedStream stream_ = new BufferedStream(httpListenerRequest_0.InputStream, 8192))
		{
			iq2RZB2GTq(stream_, bytes);
			while (true)
			{
				Dictionary<string, string> dictionary = Ke9R9FVQYJ(stream_, httpListenerRequest_0.ContentEncoding);
				if (dictionary == null || dictionary.Count == 0)
				{
					break;
				}
				string text2 = (dictionary.ContainsKey("Content-Disposition") ? dictionary["Content-Disposition"] : string.Empty);
				if (string.IsNullOrEmpty(text2))
				{
					break;
				}
				Match match2 = Regex.Match(text2, "name=\"?(?<name>[^\";\\r\\n]*)\"?");
				if (!match2.Success)
				{
					continue;
				}
				string value = match2.Groups["name"].Value;
				Match match3 = Regex.Match(text2, "filename\\*?=\"?(?<filename>[^\";\\r\\n]*)\"?");
				string text3 = (match3.Success ? match3.Groups["filename"].Value : null);
				if (!string.IsNullOrEmpty(text3) && text3.StartsWith("utf-8''"))
				{
					text3 = Uri.UnescapeDataString(text3.Substring(7));
				}
				string contentType = (dictionary.ContainsKey("Content-Type") ? dictionary["Content-Type"] : string.Empty);
				Stream stream;
				if (!string.IsNullOrEmpty(text3) && onFile_0 != null)
				{
					stream = onFile_0(value, text3, contentType);
					if (stream == null)
					{
						throw new ArgumentException("onFile回调必须返回一个流。", "onFile");
					}
				}
				else
				{
					stream = new MemoryStream();
				}
				bool num = kv3Rev0iQL(stream_, stream, bytes, bytes2);
				stream.Position = 0L;
				if (!string.IsNullOrEmpty(text3))
				{
					list.Add(new HttpFile(text3, stream, contentType, value));
				}
				else
				{
					dictionary_0[value] = Y8iRYDlfTm(stream, httpListenerRequest_0.ContentEncoding);
					stream.Dispose();
				}
				if (num)
				{
					break;
				}
			}
		}
		return list;
	}

	private static void iq2RZB2GTq(Stream stream_0, byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		if (stream_0.Read(array, 0, array.Length) != byte_0.Length || !r8iRIYFkfE(array, byte_0))
		{
			int num = 0;
			int num2;
			while ((num2 = stream_0.ReadByte()) != -1)
			{
				if (num2 == byte_0[num])
				{
					num++;
					if (num == byte_0.Length)
					{
						break;
					}
				}
				else
				{
					num = 0;
				}
			}
		}
		stream_0.ReadByte();
		int num3 = 0;
		if (WZd8HIJ3JCIaHutQpif != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		}
		stream_0.ReadByte();
	}

	private static Dictionary<string, string> Ke9R9FVQYJ(Stream stream_0, Encoding encoding_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		string text;
		while (!string.IsNullOrEmpty(text = gJdRhgM3vs(stream_0, encoding_0)))
		{
			int num = text.IndexOf(':');
			if (num > 0)
			{
				string key = text.Substring(0, num).Trim();
				string value = text.Substring(num + 1).Trim();
				dictionary[key] = value;
			}
		}
		return dictionary;
	}

	private static string gJdRhgM3vs(Stream stream_0, Encoding encoding_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		bool flag = false;
		int num;
		while ((num = stream_0.ReadByte()) != -1)
		{
			if (num == 13)
			{
				flag = true;
				continue;
			}
			if (num == 10 && flag)
			{
				break;
			}
			if (flag)
			{
				memoryStream.WriteByte(13);
				flag = false;
			}
			memoryStream.WriteByte((byte)num);
		}
		if (memoryStream.Length != 0L)
		{
			if (WZd8HIJ3JCIaHutQpif == null)
			{
				switch (0)
				{
				}
			}
		}
		else if (num == -1)
		{
			return null;
		}
		return encoding_0.GetString(memoryStream.ToArray());
	}

	private static bool kv3Rev0iQL(Stream stream_0, Stream stream_1, byte[] byte_0, byte[] byte_1)
	{
		int num = 0;
		bool result = false;
		int num2;
		int num4 = default(int);
		int num5 = default(int);
		while ((num2 = stream_0.ReadByte()) != -1)
		{
			byte b = (byte)num2;
			int num3;
			if (b == byte_0[num])
			{
				num++;
				num3 = 2;
				if (!g2IK1WJElP6WlfYZ0u6())
				{
					goto IL_0067;
				}
				goto IL_006b;
			}
			if (num > 0)
			{
				num4 = 0;
				goto IL_0054;
			}
			goto IL_0081;
			IL_008f:
			if (num == byte_0.Length)
			{
				if (stream_0.ReadByte() == 45 && stream_0.ReadByte() == 45)
				{
					result = true;
				}
				if (stream_0.ReadByte() == 13)
				{
					stream_0.ReadByte();
				}
				break;
			}
			continue;
			IL_008a:
			num = 1;
			continue;
			IL_0054:
			if (num4 < num)
			{
				num3 = 0;
				if (!g2IK1WJElP6WlfYZ0u6())
				{
					goto IL_0067;
				}
				goto IL_006b;
			}
			num = 0;
			goto IL_0081;
			IL_0067:
			num3 = num5;
			goto IL_006b;
			IL_0081:
			if (b == byte_0[0])
			{
				num3 = 1;
				if (!g2IK1WJElP6WlfYZ0u6())
				{
					goto IL_0044;
				}
				goto IL_006b;
			}
			stream_1.WriteByte(b);
			continue;
			IL_0044:
			stream_1.WriteByte(byte_0[num4]);
			num4++;
			goto IL_0054;
			IL_006b:
			switch (num3)
			{
			case 1:
				goto IL_008a;
			case 2:
				goto IL_008f;
			}
			goto IL_0044;
		}
		return result;
	}

	private static string Y8iRYDlfTm(Stream stream_0, Encoding encoding_0)
	{
		using StreamReader streamReader = new StreamReader(stream_0, encoding_0, true, 8192, true);
		return streamReader.ReadToEnd();
	}

	private static bool r8iRIYFkfE(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (byte_0[num] != byte_1[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal static bool g2IK1WJElP6WlfYZ0u6()
	{
		return WZd8HIJ3JCIaHutQpif == null;
	}
}
