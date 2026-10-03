using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using gqB4IvX4JlYCSBb9knj;
using Newtonsoft.Json;
using Quicker.Common.Vm.Account;

namespace Buax0Q2tBANN3iv8TIl;

internal static class t3Rcng2Qla8ThDgZgya
{
	private static object bNeLVFQ1vwyDDRLN2hUi;

	public static bool g0Ttcz7UIVD(this hiU6uvXya1n871DUbUU hiU6uvXya1n871DUbUU_0)
	{
		return string.IsNullOrWhiteSpace(hiU6uvXya1n871DUbUU_0?.mV2tBZbEDIQ());
	}

	public static bool dT3tVwT8gUV(this hiU6uvXya1n871DUbUU hiU6uvXya1n871DUbUU_0)
	{
		return string.Equals(hiU6uvXya1n871DUbUU_0.mV2tBZbEDIQ(), "demo@getquicker.net", StringComparison.OrdinalIgnoreCase);
	}

	internal static UserInfo JJCtVt442Ip(this string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new InvalidDataException("用户信息字符串为空。");
		}
		string[] array = string_0.Split(new string[1] { "#" }, 2, StringSplitOptions.None);
		if (qx0tVg669Ue(array[0], array[1]))
		{
			return JsonConvert.DeserializeObject<UserInfo>(Nv4tVLrOX9H(array[1], "543F093E61D8D54252CE26A3D35C7CA2"));
		}
		return null;
	}

	private static bool qx0tVg669Ue(string string_0, string string_1)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>wVjvcSFQivqWahQonKGMSmdP/CW+CGtvDR01dI5gMR6UHRZDDyuFehX1GVndYXFGxLiBFXRCHxiFNdUoaWjHSt6x0IQ25pJh0xfpES4W1wfMM047883rE3MPsM0VJSPFDeFFvRYF4vcwQV1rbW7QqZ0iE1jM/rfPCOLpqDnmtlk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		byte[] signature = Convert.FromBase64String(string_0);
		return rSACryptoServiceProvider.VerifyData(bytes, new SHA256CryptoServiceProvider(), signature);
	}

	private static string Nv4tVLrOX9H(string string_0, string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_1.Substring(0, 16));
		byte[] bytes2 = Encoding.UTF8.GetBytes(string_1.Substring(16, 16));
		using Aes aes = Aes.Create();
		aes.Key = bytes;
		aes.IV = bytes2;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_0));
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}

	public static hiU6uvXya1n871DUbUU HhstVv0OiUU(this string string_0)
	{
		return string_0.JJCtVt442Ip().lGEtVStVQEK();
	}

	[Obsolete]
	public static hiU6uvXya1n871DUbUU lGEtVStVQEK(this UserInfo userInfo_0)
	{
		hiU6uvXya1n871DUbUU hiU6uvXya1n871DUbUU = new hiU6uvXya1n871DUbUU();
		hiU6uvXya1n871DUbUU.jJJtB7KadWE(userInfo_0.UserId);
		hiU6uvXya1n871DUbUU.Mk5tBc3A5cN(userInfo_0.UserSerial);
		hiU6uvXya1n871DUbUU.UqstB9fTBGf(userInfo_0.UserName);
		hiU6uvXya1n871DUbUU.dmrtBYeiyou(userInfo_0.NickName);
		hiU6uvXya1n871DUbUU.Email = userInfo_0.Email;
		hiU6uvXya1n871DUbUU.ITGtBspyJLR(userInfo_0.TokenCreateTimeUtc);
		hiU6uvXya1n871DUbUU.MKdtBb6WOuL(userInfo_0.TokenExpireTimeUtc);
		hiU6uvXya1n871DUbUU.IbltBml6UJG(userInfo_0.LockButtons);
		hiU6uvXya1n871DUbUU.VXAtBr6Z0aC(userInfo_0.MemberLevel);
		hiU6uvXya1n871DUbUU.eSktBQ8VgIT(userInfo_0.MemberExpireTimeUtc);
		hiU6uvXya1n871DUbUU.XC5tB4ZHxS0(userInfo_0.RegTimeUtc);
		hiU6uvXya1n871DUbUU.f6gtBdFpx9o(userInfo_0.FixedButtonAction);
		hiU6uvXya1n871DUbUU.r7rtBMdO7oy(userInfo_0.UserLimitation);
		hiU6uvXya1n871DUbUU.o6UtBUGamDp = userInfo_0.ReportInterval;
		hiU6uvXya1n871DUbUU.dOBtBivM7O7(userInfo_0.TxBaffetId);
		hiU6uvXya1n871DUbUU.YgAtBzJq7T6(userInfo_0.Avatar);
		return hiU6uvXya1n871DUbUU;
	}

	internal static bool rt1RqwQ1dEoA0Vad0o3v()
	{
		return bNeLVFQ1vwyDDRLN2hUi == null;
	}
}
