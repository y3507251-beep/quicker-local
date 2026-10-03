using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Cuiliang.AliyunOssSdk.Api.Common;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.Get;

[XmlRoot("Contents")]
public class ObjectMeta
{
	[CompilerGenerated]
	private Owner htsNDHKaOb;

	[CompilerGenerated]
	private string VyQNdMYSx8;

	[CompilerGenerated]
	private string uGQNou2neT;

	[CompilerGenerated]
	private string sVHNTUpJ53;

	[CompilerGenerated]
	private string jZxNMeTMx9;

	[CompilerGenerated]
	private string DhRNAZ40tZ;

	private static ObjectMeta OgTun5D7dPbN6UnyU8p;

	[XmlElement("Owner")]
	public Owner Owner
	{
		[CompilerGenerated]
		get
		{
			return htsNDHKaOb;
		}
		[CompilerGenerated]
		set
		{
			htsNDHKaOb = value;
		}
	}

	public string ETag
	{
		[CompilerGenerated]
		get
		{
			return VyQNdMYSx8;
		}
		[CompilerGenerated]
		set
		{
			VyQNdMYSx8 = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return uGQNou2neT;
		}
		[CompilerGenerated]
		set
		{
			uGQNou2neT = value;
		}
	}

	public string LastModified
	{
		[CompilerGenerated]
		get
		{
			return sVHNTUpJ53;
		}
		[CompilerGenerated]
		set
		{
			sVHNTUpJ53 = value;
		}
	}

	public string Size
	{
		[CompilerGenerated]
		get
		{
			return jZxNMeTMx9;
		}
		[CompilerGenerated]
		set
		{
			jZxNMeTMx9 = value;
		}
	}

	public string StorageClass
	{
		[CompilerGenerated]
		get
		{
			return DhRNAZ40tZ;
		}
		[CompilerGenerated]
		set
		{
			DhRNAZ40tZ = value;
		}
	}

	internal static bool DkfTySD4CysJdwo9TEo()
	{
		return OgTun5D7dPbN6UnyU8p == null;
	}
}
