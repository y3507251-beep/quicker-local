using System;
using System.Collections.Generic;
using qdET65OxfuSfXTNffp;

namespace Cuiliang.AliyunOssSdk.Entites;

public class ObjectMetadata
{
	private readonly IDictionary<string, string> cpwugO0ZZG = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	private readonly IDictionary<string, object> KK6uL4lWgP = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

	public const string Aes256ServerSideEncryption = "AES256";

	private static ObjectMetadata Flto6UeYbvdhwnGL77o;

	public IDictionary<string, string> UserMetadata => cpwugO0ZZG;

	public DateTime LastModified
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Last-Modified"))
			{
				return DateTime.MinValue;
			}
			return (DateTime)KK6uL4lWgP["Last-Modified"];
		}
		internal set
		{
			KK6uL4lWgP["Last-Modified"] = value;
		}
	}

	public DateTime ExpirationTime
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Expires"))
			{
				return DateTime.MinValue;
			}
			return zh4GdKnxb7gfeU5oTf.cf4ST5pSMC((string)KK6uL4lWgP["Expires"]);
		}
		set
		{
			KK6uL4lWgP["Expires"] = zh4GdKnxb7gfeU5oTf.YoHSowUI1T(value);
		}
	}

	public long ContentLength
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Content-Length"))
			{
				return 0L;
			}
			return (long)KK6uL4lWgP["Content-Length"];
		}
		set
		{
			if (value > 5368709120L)
			{
				throw new ArgumentException("content length not allow to exceed 5GB.");
			}
			KK6uL4lWgP["Content-Length"] = value;
		}
	}

	public string ContentType
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Content-Type"))
			{
				return null;
			}
			return KK6uL4lWgP["Content-Type"] as string;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				KK6uL4lWgP["Content-Type"] = value;
			}
		}
	}

	public string ContentEncoding
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Content-Encoding"))
			{
				return null;
			}
			return KK6uL4lWgP["Content-Encoding"] as string;
		}
		set
		{
			if (value != null)
			{
				KK6uL4lWgP["Content-Encoding"] = value;
			}
		}
	}

	public string CacheControl
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Cache-Control"))
			{
				return null;
			}
			return KK6uL4lWgP["Cache-Control"] as string;
		}
		set
		{
			if (value != null)
			{
				KK6uL4lWgP["Cache-Control"] = value;
			}
		}
	}

	public string ContentDisposition
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Content-Disposition"))
			{
				return null;
			}
			return KK6uL4lWgP["Content-Disposition"] as string;
		}
		set
		{
			if (value != null)
			{
				KK6uL4lWgP["Content-Disposition"] = value;
			}
		}
	}

	public string ETag
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("ETag"))
			{
				return null;
			}
			return KK6uL4lWgP["ETag"] as string;
		}
		set
		{
			if (value != null)
			{
				KK6uL4lWgP["ETag"] = value;
			}
		}
	}

	public string ContentMd5
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("Content-MD5"))
			{
				return null;
			}
			return KK6uL4lWgP["Content-MD5"] as string;
		}
		set
		{
			if (value != null)
			{
				KK6uL4lWgP["Content-MD5"] = value;
			}
		}
	}

	public string ServerSideEncryption
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("x-oss-server-side-encryption"))
			{
				return null;
			}
			return KK6uL4lWgP["x-oss-server-side-encryption"] as string;
		}
		set
		{
			if ("AES256" != value)
			{
				throw new ArgumentException("Unsupported server side encryption");
			}
			KK6uL4lWgP["x-oss-server-side-encryption"] = value;
		}
	}

	public string ObjectType
	{
		get
		{
			if (!KK6uL4lWgP.ContainsKey("x-oss-object-type"))
			{
				return null;
			}
			return KK6uL4lWgP["x-oss-object-type"] as string;
		}
	}

	public ObjectMetadata()
	{
		ContentLength = -1L;
	}

	public void AddHeader(string key, object value)
	{
		KK6uL4lWgP.Add(key, value);
	}

	internal void Qikuwm7sBm(IDictionary<string, string> idictionary_2)
	{
		foreach (KeyValuePair<string, object> item in KK6uL4lWgP)
		{
			idictionary_2.Add(item.Key, item.Value.ToString());
		}
		if (!idictionary_2.ContainsKey("Content-Type"))
		{
			idictionary_2.Add("Content-Type", "application/octet-stream");
		}
		foreach (KeyValuePair<string, string> item2 in cpwugO0ZZG)
		{
			idictionary_2.Add("x-oss-meta-" + item2.Key, item2.Value);
		}
	}

	internal static bool eKgYise8bbdB7MKh23b()
	{
		return Flto6UeYbvdhwnGL77o == null;
	}
}
