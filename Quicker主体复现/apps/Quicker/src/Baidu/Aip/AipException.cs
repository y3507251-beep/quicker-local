using System;
using System.Runtime.CompilerServices;

namespace Baidu.Aip;

[Serializable]
public class AipException : Exception
{
	[CompilerGenerated]
	private int i3ASqCvYq5;

	private static AipException DTSaXM2JUmM3uFtFYZV;

	public int Code
	{
		[CompilerGenerated]
		get
		{
			return i3ASqCvYq5;
		}
		[CompilerGenerated]
		set
		{
			i3ASqCvYq5 = value;
		}
	}

	public AipException()
	{
		Code = -1;
	}

	public AipException(string message)
		: base(message)
	{
	}

	public AipException(int code, string message)
		: base(message)
	{
		Code = code;
	}

	public static AipException TokenException(string message)
	{
		return new AipException("Token request failed! " + message);
	}

	internal static bool DHdtlt2kRowmcUCL5oU()
	{
		return DTSaXM2JUmM3uFtFYZV == null;
	}
}
