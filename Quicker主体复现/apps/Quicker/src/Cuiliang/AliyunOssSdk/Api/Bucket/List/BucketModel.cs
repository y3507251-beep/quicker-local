using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Cuiliang.AliyunOssSdk.Api.Bucket.List;

[XmlRoot("Bucket")]
public class BucketModel
{
	[CompilerGenerated]
	private string basNIB8bhf;

	[CompilerGenerated]
	private string oJHNWLjVff;

	[CompilerGenerated]
	private DateTime USUNkoaT3j;

	[CompilerGenerated]
	private string YI2NGksWY0;

	[CompilerGenerated]
	private string rfaNsmrbAr;

	private static BucketModel iYcNF2DIJOBAaNI0Zgv;

	[XmlElement("Location")]
	public string Location
	{
		[CompilerGenerated]
		get
		{
			return basNIB8bhf;
		}
		[CompilerGenerated]
		set
		{
			basNIB8bhf = value;
		}
	}

	[XmlElement("Name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return oJHNWLjVff;
		}
		[CompilerGenerated]
		set
		{
			oJHNWLjVff = value;
		}
	}

	[XmlElement("CreationDate")]
	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return USUNkoaT3j;
		}
		[CompilerGenerated]
		set
		{
			USUNkoaT3j = value;
		}
	}

	public string ExtranetEndpoint
	{
		[CompilerGenerated]
		get
		{
			return YI2NGksWY0;
		}
		[CompilerGenerated]
		set
		{
			YI2NGksWY0 = value;
		}
	}

	public string IntranetEndpoint
	{
		[CompilerGenerated]
		get
		{
			return rfaNsmrbAr;
		}
		[CompilerGenerated]
		set
		{
			rfaNsmrbAr = value;
		}
	}

	internal static bool pdVrSID6B6hWlKfwB11()
	{
		return iYcNF2DIJOBAaNI0Zgv == null;
	}
}
