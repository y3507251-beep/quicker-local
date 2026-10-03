using System.IO;
using System.Runtime.CompilerServices;
using Cuiliang.AliyunOssSdk.Request;

namespace Cuiliang.AliyunOssSdk.Entites;

public class RequestContent
{
	[CompilerGenerated]
	private string fNHuNmDBSH;

	[CompilerGenerated]
	private RequestContentType RFSuJkqNOO;

	[CompilerGenerated]
	private string fyyu0f6dwt;

	[CompilerGenerated]
	private Stream Ls5uCjQMYk;

	[CompilerGenerated]
	private ObjectMetadata VljuPJPNxI;

	[CompilerGenerated]
	private byte[] e8duEoL562;

	private static RequestContent INvIZweteRdkhp3pGWK;

	public string MimeType
	{
		[CompilerGenerated]
		get
		{
			return fNHuNmDBSH;
		}
		[CompilerGenerated]
		set
		{
			fNHuNmDBSH = value;
		}
	}

	public RequestContentType ContentType
	{
		[CompilerGenerated]
		get
		{
			return RFSuJkqNOO;
		}
		[CompilerGenerated]
		set
		{
			RFSuJkqNOO = value;
		}
	}

	public string StringContent
	{
		[CompilerGenerated]
		get
		{
			return fyyu0f6dwt;
		}
		[CompilerGenerated]
		set
		{
			fyyu0f6dwt = value;
		}
	}

	public Stream StreamContent
	{
		[CompilerGenerated]
		get
		{
			return Ls5uCjQMYk;
		}
		[CompilerGenerated]
		set
		{
			Ls5uCjQMYk = value;
		}
	}

	public ObjectMetadata Metadata
	{
		[CompilerGenerated]
		get
		{
			return VljuPJPNxI;
		}
		[CompilerGenerated]
		set
		{
			VljuPJPNxI = value;
		}
	}

	public byte[] ContentMd5
	{
		[CompilerGenerated]
		get
		{
			return e8duEoL562;
		}
		[CompilerGenerated]
		internal set
		{
			e8duEoL562 = value;
		}
	}

	internal static bool H9UUcveSofwiwfctA75()
	{
		return INvIZweteRdkhp3pGWK == null;
	}
}
