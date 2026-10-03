using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Cuiliang.AliyunOssSdk.Api.Common;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.Get;

[XmlRoot("ListBucketResult")]
public class GetBucketResult
{
	[CompilerGenerated]
	private ObjectMeta[] GRVNKItKLV;

	[CompilerGenerated]
	private string VJ4Nx8Bhcd;

	[CompilerGenerated]
	private string QpuNrAxsvb;

	[CompilerGenerated]
	private string c3INpidlcW;

	[CompilerGenerated]
	private string Ak3NBd9uBT;

	[CompilerGenerated]
	private string dxjNQ2sBgj;

	[CompilerGenerated]
	private string D1VNjpA7eJ;

	[CompilerGenerated]
	private string oW0NnTWp60;

	[CompilerGenerated]
	private Owner qkRN4UFdqe;

	[CompilerGenerated]
	private string fiSN5Jnt01;

	internal static GetBucketResult RW6vZ6DmnF9i4Wlesam;

	[XmlElement("Contents")]
	public ObjectMeta[] Contents
	{
		[CompilerGenerated]
		get
		{
			return GRVNKItKLV;
		}
		[CompilerGenerated]
		set
		{
			GRVNKItKLV = value;
		}
	}

	public string CommonPrefixes
	{
		[CompilerGenerated]
		get
		{
			return VJ4Nx8Bhcd;
		}
		[CompilerGenerated]
		set
		{
			VJ4Nx8Bhcd = value;
		}
	}

	public string Delimiter
	{
		[CompilerGenerated]
		get
		{
			return QpuNrAxsvb;
		}
		[CompilerGenerated]
		set
		{
			QpuNrAxsvb = value;
		}
	}

	public string EncodingType
	{
		[CompilerGenerated]
		get
		{
			return c3INpidlcW;
		}
		[CompilerGenerated]
		set
		{
			c3INpidlcW = value;
		}
	}

	public string IsTruncated
	{
		[CompilerGenerated]
		get
		{
			return Ak3NBd9uBT;
		}
		[CompilerGenerated]
		set
		{
			Ak3NBd9uBT = value;
		}
	}

	public string Marker
	{
		[CompilerGenerated]
		get
		{
			return dxjNQ2sBgj;
		}
		[CompilerGenerated]
		set
		{
			dxjNQ2sBgj = value;
		}
	}

	public string MaxKeys
	{
		[CompilerGenerated]
		get
		{
			return D1VNjpA7eJ;
		}
		[CompilerGenerated]
		set
		{
			D1VNjpA7eJ = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return oW0NnTWp60;
		}
		[CompilerGenerated]
		set
		{
			oW0NnTWp60 = value;
		}
	}

	public Owner Owner
	{
		[CompilerGenerated]
		get
		{
			return qkRN4UFdqe;
		}
		[CompilerGenerated]
		set
		{
			qkRN4UFdqe = value;
		}
	}

	public string Prefix
	{
		[CompilerGenerated]
		get
		{
			return fiSN5Jnt01;
		}
		[CompilerGenerated]
		set
		{
			fiSN5Jnt01 = value;
		}
	}

	internal static bool eXXVXZDsG8fun2wbpr8()
	{
		return RW6vZ6DmnF9i4Wlesam == null;
	}
}
