using System;
using System.Security.Cryptography;
using System.Text;

namespace Cuiliang.AliyunOssSdk.Utility.Authentication;

public class HmacSHA1Signature : ServiceSignature
{
	private readonly Encoding pSY2NEyZEB = Encoding.UTF8;

	private static HmacSHA1Signature thKbVknsb159hVdMDv0;

	public override string SignatureMethod => "HmacSHA1";

	public override string SignatureVersion => "1";

	protected override string ComputeSignatureCore(string key, string data)
	{
		pSY2NEyZEB.GetBytes(key);
		using HMACSHA1 hMACSHA = new HMACSHA1(pSY2NEyZEB.GetBytes(key));
		return Convert.ToBase64String(hMACSHA.ComputeHash(pSY2NEyZEB.GetBytes(data.ToCharArray())));
	}

	internal static bool jQ5eNbnCRcVvMXpB32B()
	{
		return thKbVknsb159hVdMDv0 == null;
	}
}
