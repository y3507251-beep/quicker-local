using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cuiliang.AliyunOssSdk.Entites;

namespace Cuiliang.AliyunOssSdk.Request;

public class SignatureHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WjHvE9bg9OT;

		public static Func<string, bool> Kh6vEhQTbI2;

		internal static _003C_003Ec n54yNRcezj6bQ31XYW1N;

		static _003C_003Ec()
		{
			WjHvE9bg9OT = new _003C_003Ec();
		}

		internal bool yObvEZbSP6U(string k)
		{
			return eKs2xPIE59.Contains(k);
		}

		internal static bool fYIPDvcjVaGoDpSCkMBt()
		{
			return n54yNRcezj6bQ31XYW1N == null;
		}
	}

	private static readonly IList<string> eKs2xPIE59;

	internal static SignatureHelper xAcvU0edNETqbJZPoYl;

	private static string nrD2KV3qZY(string string_0, string string_1)
	{
		return Convert.ToBase64String(new HMACSHA1
		{
			Key = Encoding.UTF8.GetBytes(string_0.ToCharArray())
		}.ComputeHash(Encoding.UTF8.GetBytes(string_1.ToCharArray())));
	}

	public static string HmacSha1Sign(string accessKeySecret, string httpMethod, string contentMd5, string contentType, string date, string canonicalizedOSSHeaders, string canonicalizedResource)
	{
		string string_ = httpMethod.ToUpper() + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + canonicalizedResource;
		return nrD2KV3qZY(accessKeySecret, string_);
	}

	public static string ComputeCanonicalizedOSSHeaders(IDictionary<string, string> headers, IDictionary<string, string> queryParameters = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		IDictionary<string, string> dictionary = new Dictionary<string, string>();
		if (headers != null)
		{
			foreach (KeyValuePair<string, string> header in headers)
			{
				string text = header.Key.ToLowerInvariant();
				if (text.StartsWith("x-oss-"))
				{
					dictionary.Add(text, header.Value);
				}
			}
		}
		if (queryParameters != null)
		{
			foreach (KeyValuePair<string, string> queryParameter in queryParameters)
			{
				if (queryParameter.Key.StartsWith("x-oss-"))
				{
					dictionary.Add(queryParameter.Key.Trim(), queryParameter.Value.Trim());
				}
			}
		}
		List<string> list = new List<string>(dictionary.Keys);
		list.Sort();
		foreach (string item in list)
		{
			string value = dictionary[item];
			if (item.StartsWith("x-oss-"))
			{
				stringBuilder.Append(item).Append(':').Append(value);
			}
			else
			{
				stringBuilder.Append(value);
			}
			stringBuilder.Append("\n");
		}
		return stringBuilder.ToString();
	}

	public static string BuildCanonicalizedResource(BucketInfo bucket, string key, IDictionary<string, string> parameters)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(bucket.MakeResourcePathForSign(key));
		if (parameters != null)
		{
			List<string> list = parameters.Keys.Where(_003C_003Ec.Kh6vEhQTbI2 ?? (_003C_003Ec.Kh6vEhQTbI2 = _003C_003Ec.WjHvE9bg9OT.yObvEZbSP6U)).ToList();
			if (list.Count > 0)
			{
				list.Sort();
				char value = '?';
				foreach (string item in list)
				{
					stringBuilder.Append(value);
					stringBuilder.Append(item);
					string value2 = parameters[item];
					if (!string.IsNullOrEmpty(value2))
					{
						stringBuilder.Append("=").Append(value2);
					}
					value = '&';
				}
			}
		}
		return stringBuilder.ToString();
	}

	public static void SignRequest(ServiceRequest serviceRequest, OssCredential credential, HttpRequestMessage httpRequestMessage)
	{
		string httpMethod = serviceRequest.HttpMethod.Method.ToUpperInvariant();
		HttpContent content = httpRequestMessage.Content;
		object obj;
		if (content != null)
		{
			obj = content.Headers.ContentType?.ToString();
		}
		else
		{
			if (!McHJD0eOmbqVCLFexQm())
			{
				switch (0)
				{
				}
			}
			obj = null;
		}
		string contentType = (string)obj;
		string date = serviceRequest.Headers["Date"];
		string contentMd = ((serviceRequest.ContentMd5 == null) ? "" : Convert.ToBase64String(serviceRequest.ContentMd5));
		string canonicalizedOSSHeaders = ComputeCanonicalizedOSSHeaders(serviceRequest.Headers, serviceRequest.Parameters);
		string canonicalizedResource = BuildCanonicalizedResource(serviceRequest.Bucket, serviceRequest.ObjectKey, serviceRequest.Parameters);
		string text = HmacSha1Sign(credential.AccessKeySecret, httpMethod, contentMd, contentType, date, canonicalizedOSSHeaders, canonicalizedResource);
		httpRequestMessage.Headers.Add("Authorization", "OSS " + credential.AccessKeyId + ":" + text);
	}

	static SignatureHelper()
	{
		eKs2xPIE59 = new List<string>
		{
			"acl", "uploadId", "partNumber", "uploads", "logging", "website", "location", "lifecycle", "referer", "cors",
			"delete", "append", "position", "bucketInfo", "response-cache-control", "response-content-disposition", "response-content-encoding", "response-content-language", "response-content-type", "response-expires",
			"security-token", "objectMeta"
		};
	}

	internal static bool McHJD0eOmbqVCLFexQm()
	{
		return xAcvU0edNETqbJZPoYl == null;
	}
}
