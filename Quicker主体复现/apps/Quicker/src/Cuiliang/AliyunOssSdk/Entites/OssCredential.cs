using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Entites;

public class OssCredential
{
	[CompilerGenerated]
	private string acMuv4TJyF;

	[CompilerGenerated]
	private string LO6uSUAt7I;

	[CompilerGenerated]
	private string SD1u2950nD;

	private static OssCredential cAlaydegifSA9hXKw54;

	public string AccessKeyId
	{
		[CompilerGenerated]
		get
		{
			return acMuv4TJyF;
		}
		[CompilerGenerated]
		set
		{
			acMuv4TJyF = value;
		}
	}

	public string AccessKeySecret
	{
		[CompilerGenerated]
		get
		{
			return LO6uSUAt7I;
		}
		[CompilerGenerated]
		set
		{
			LO6uSUAt7I = value;
		}
	}

	public bool UseToken => !string.IsNullOrEmpty(SecurityToken);

	public string SecurityToken
	{
		[CompilerGenerated]
		get
		{
			return SD1u2950nD;
		}
		[CompilerGenerated]
		set
		{
			SD1u2950nD = value;
		}
	}

	public OssCredential Value => this;

	internal static bool TqNvSDePvrXHgcnTKKd()
	{
		return cAlaydegifSA9hXKw54 == null;
	}
}
