using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Cuiliang.AliyunOssSdk.Api.Common;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.List;

[XmlRoot("ListAllMyBucketsResult")]
public class ListBucketsResult
{
	[CompilerGenerated]
	private string bBMNcCEnQy;

	[CompilerGenerated]
	private string PWLNVR03wb;

	[CompilerGenerated]
	private int? jwmNZalWUM;

	[CompilerGenerated]
	private bool? QjKN9Iw2Ab;

	[CompilerGenerated]
	private string IgrNhnAewc;

	[CompilerGenerated]
	private Owner uIVNeDifTY;

	[CompilerGenerated]
	private List<Cuiliang.AliyunOssSdk.Api.Common.Bucket> FSLNYZlC1E;

	internal static ListBucketsResult aVvGacDM1QUDmYOPIa0;

	public string Prefix
	{
		[CompilerGenerated]
		get
		{
			return bBMNcCEnQy;
		}
		[CompilerGenerated]
		set
		{
			bBMNcCEnQy = value;
		}
	}

	public string Marker
	{
		[CompilerGenerated]
		get
		{
			return PWLNVR03wb;
		}
		[CompilerGenerated]
		set
		{
			PWLNVR03wb = value;
		}
	}

	public int? MaxKeys
	{
		[CompilerGenerated]
		get
		{
			return jwmNZalWUM;
		}
		[CompilerGenerated]
		set
		{
			jwmNZalWUM = value;
		}
	}

	public bool? IsTruncated
	{
		[CompilerGenerated]
		get
		{
			return QjKN9Iw2Ab;
		}
		[CompilerGenerated]
		set
		{
			QjKN9Iw2Ab = value;
		}
	}

	public string NextMaker
	{
		[CompilerGenerated]
		get
		{
			return IgrNhnAewc;
		}
		[CompilerGenerated]
		set
		{
			IgrNhnAewc = value;
		}
	}

	[XmlElement("Owner")]
	public Owner Owner
	{
		[CompilerGenerated]
		get
		{
			return uIVNeDifTY;
		}
		[CompilerGenerated]
		set
		{
			uIVNeDifTY = value;
		}
	}

	[XmlArrayItem("Bucket")]
	public List<Cuiliang.AliyunOssSdk.Api.Common.Bucket> Buckets
	{
		[CompilerGenerated]
		get
		{
			return FSLNYZlC1E;
		}
		[CompilerGenerated]
		set
		{
			FSLNYZlC1E = value;
		}
	}

	internal static bool khNyfFDU08mOQyEO5st()
	{
		return aVvGacDM1QUDmYOPIa0 == null;
	}
}
