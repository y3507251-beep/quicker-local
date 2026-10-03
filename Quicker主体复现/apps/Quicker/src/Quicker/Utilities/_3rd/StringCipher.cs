using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Quicker.Utilities._3rd;

public static class StringCipher
{
	internal static object z9We7jFTnjX29sJ2cCpN;

	public static string Encrypt(string plainText, string passPhrase)
	{
		byte[] array = zQ7Lz7LC27M();
		byte[] array2 = zQ7Lz7LC27M();
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, array, 1000);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(32);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes2, array2);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = array.Concat(array2).ToArray().Concat(memoryStream.ToArray())
			.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	public static string Decrypt(string cipherText, string passPhrase)
	{
		byte[] array = Convert.FromBase64String(cipherText);
		byte[] salt = array.Take(32).ToArray();
		byte[] rgbIV = array.Skip(32).Take(32).ToArray();
		byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray();
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 1000);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, rgbIV);
		using MemoryStream memoryStream = new MemoryStream(array2);
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array3 = new byte[array2.Length];
		int count = cryptoStream.Read(array3, 0, array3.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array3, 0, count);
	}

	private static byte[] zQ7Lz7LC27M()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	internal static byte[] Zip(string str)
	{
		using MemoryStream stream_ = new MemoryStream(Encoding.UTF8.GetBytes(str));
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream stream_2 = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			mFnLzRIdvBE(stream_, stream_2);
		}
		return memoryStream.ToArray();
	}

	internal static string Unzip(byte[] bytes, int length = 0)
	{
		if (length == 0)
		{
			length = bytes.Length;
		}
		using MemoryStream stream = new MemoryStream(bytes, 0, length);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream stream_ = new GZipStream(stream, CompressionMode.Decompress))
		{
			mFnLzRIdvBE(stream_, memoryStream);
		}
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}

	internal static void mFnLzRIdvBE(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	internal static string LE6Lzq5VXZP(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
		{
			gZipStream.Write(bytes, 0, bytes.Length);
		}
		memoryStream.Position = 0L;
		byte[] array = new byte[memoryStream.Length];
		int num = 0;
		if (z9We7jFTnjX29sJ2cCpN != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			memoryStream.Read(array, 0, array.Length);
			byte[] array2 = new byte[array.Length + 4];
			Buffer.BlockCopy(array, 0, array2, 4, array.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
			return Convert.ToBase64String(array2);
		}
		}
	}

	internal static string XGJLzc7weUI(string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		using MemoryStream memoryStream = new MemoryStream();
		int num = BitConverter.ToInt32(array, 0);
		memoryStream.Write(array, 4, array.Length - 4);
		byte[] array2 = new byte[num];
		memoryStream.Position = 0L;
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
		{
			gZipStream.Read(array2, 0, array2.Length);
		}
		return Encoding.UTF8.GetString(array2);
	}

	public static string EncryptWithGzip(string plainText, string passPhrase)
	{
		byte[] array = zQ7Lz7LC27M();
		byte[] array2 = zQ7Lz7LC27M();
		byte[] array3 = Zip(plainText);
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, array, 1000);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, array2);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(array3, 0, array3.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = array.Concat(array2).ToArray().Concat(memoryStream.ToArray())
			.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptWithGzip(string cipherText, string passPhrase)
	{
		byte[] array = Convert.FromBase64String(cipherText);
		byte[] salt = array.Take(32).ToArray();
		byte[] rgbIV = array.Skip(32).Take(32).ToArray();
		byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray();
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 1000);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, rgbIV);
		using MemoryStream memoryStream = new MemoryStream(array2);
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array3 = new byte[array2.Length];
		int length = cryptoStream.Read(array3, 0, array3.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Unzip(array3, length);
	}

	internal static bool m9QWjaFTeOP7tkVT4o51()
	{
		return z9We7jFTnjX29sJ2cCpN == null;
	}
}
