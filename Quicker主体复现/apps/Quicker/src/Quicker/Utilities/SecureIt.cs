using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Quicker.Utilities;

public static class SecureIt
{
	private static readonly byte[] KTbLMMgnQmy;

	private static object OJcUZUFgQeDidYZD7nPJ;

	public static string EncryptString(this SecureString input)
	{
		if (input == null)
		{
			return null;
		}
		return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(input.ToInsecureString()), KTbLMMgnQmy, DataProtectionScope.CurrentUser));
	}

	public static SecureString DecryptString(this string encryptedData)
	{
		if (encryptedData == null)
		{
			return null;
		}
		try
		{
			byte[] bytes = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), KTbLMMgnQmy, DataProtectionScope.CurrentUser);
			return Encoding.Unicode.GetString(bytes).ToSecureString();
		}
		catch
		{
			return new SecureString();
		}
	}

	public static SecureString ToSecureString(this IEnumerable<char> input)
	{
		if (input == null)
		{
			return null;
		}
		SecureString secureString = new SecureString();
		foreach (char item in input)
		{
			secureString.AppendChar(item);
		}
		secureString.MakeReadOnly();
		return secureString;
	}

	public static string ToInsecureString(this SecureString input)
	{
		if (input == null)
		{
			return null;
		}
		IntPtr intPtr = Marshal.SecureStringToBSTR(input);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	static SecureIt()
	{
		KTbLMMgnQmy = Encoding.Unicode.GetBytes("Salt Is Not A Password");
	}

	internal static bool HMcpuSFgFmjKVorq1chv()
	{
		return OJcUZUFgQeDidYZD7nPJ == null;
	}
}
