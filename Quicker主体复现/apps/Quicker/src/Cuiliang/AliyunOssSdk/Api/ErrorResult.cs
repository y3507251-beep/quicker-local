using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Cuiliang.AliyunOssSdk.Api;

[XmlRoot("Error")]
public class ErrorResult
{
	[CompilerGenerated]
	private string yiiuywJYiy;

	[CompilerGenerated]
	private string koru8rcN8I;

	[CompilerGenerated]
	private string iWNuaDdAwd;

	[CompilerGenerated]
	private string DPdu7EhFNv;

	private static ErrorResult T4W3GAeTmKiqQEplNSe;

	[XmlElement("Code")]
	public string Code
	{
		[CompilerGenerated]
		get
		{
			return yiiuywJYiy;
		}
		[CompilerGenerated]
		set
		{
			yiiuywJYiy = value;
		}
	}

	[XmlElement("Message")]
	public string Message
	{
		[CompilerGenerated]
		get
		{
			return koru8rcN8I;
		}
		[CompilerGenerated]
		set
		{
			koru8rcN8I = value;
		}
	}

	[XmlElement("RequestId")]
	public string RequestId
	{
		[CompilerGenerated]
		get
		{
			return iWNuaDdAwd;
		}
		[CompilerGenerated]
		set
		{
			iWNuaDdAwd = value;
		}
	}

	[XmlElement("HostId")]
	public string HostId
	{
		[CompilerGenerated]
		get
		{
			return DPdu7EhFNv;
		}
		[CompilerGenerated]
		set
		{
			DPdu7EhFNv = value;
		}
	}

	internal static bool wqXuT1emGUulT15lZBu()
	{
		return T4W3GAeTmKiqQEplNSe == null;
	}
}
