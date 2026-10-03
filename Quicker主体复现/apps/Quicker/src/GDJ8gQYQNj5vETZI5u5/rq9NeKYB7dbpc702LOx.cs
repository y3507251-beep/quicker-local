using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GDJ8gQYQNj5vETZI5u5;

internal class rq9NeKYB7dbpc702LOx
{
	private readonly byte[] OKAL5oWHOyI;

	private readonly byte[] KWvL5TaTc7M;

	private static rq9NeKYB7dbpc702LOx vQiGXoFlBpeQcd4OykXx;

	public rq9NeKYB7dbpc702LOx(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException("iv");
		}
		OKAL5oWHOyI = Encoding.UTF8.GetBytes(string_0);
		KWvL5TaTc7M = Encoding.UTF8.GetBytes(string_1);
		if (OKAL5oWHOyI.Length != 32)
		{
			throw new ArgumentException("Key length must be 32 bytes (256 bits).");
		}
		if (KWvL5TaTc7M.Length != 16)
		{
			throw new ArgumentException("IV length must be 16 bytes (128 bits).");
		}
	}

	public string knBL551eJpR(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("plainText");
		}
		using Aes aes = Aes.Create();
		aes.Key = OKAL5oWHOyI;
		aes.IV = KWvL5TaTc7M;
		ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(string_0);
		}
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public string aiWL5D2yNYB(string string_0)
	{
		if (string_0 != null)
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = OKAL5oWHOyI;
				aes.IV = KWvL5TaTc7M;
				ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
				using MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_0));
				using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				using StreamReader streamReader = new StreamReader(stream2);
				return streamReader.ReadToEnd();
			}
		}
		throw new ArgumentNullException("cipherText");
	}

	public static rq9NeKYB7dbpc702LOx Eo5L5dwn62U()
	{
		string string_ = "0123456780912345";
		return new rq9NeKYB7dbpc702LOx("01234567809123456789012345678901", string_);
	}

	internal static bool DWtwefFlvqGfrUMcE5hc()
	{
		return vQiGXoFlBpeQcd4OykXx == null;
	}
}
