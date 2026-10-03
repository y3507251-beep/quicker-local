using System.Runtime.CompilerServices;
using IflySdk.Enum;

namespace IflySdk.Model.Common;

public class ResultModel<T> where T : class
{
	[CompilerGenerated]
	private ResultCode d4nhQZ2lsW;

	[CompilerGenerated]
	private string EyxhjGoxMU;

	[CompilerGenerated]
	private T jV5hnjVHtR;

	internal static object aOyQDYNH80Qfjk9IgdY;

	public ResultCode Code
	{
		[CompilerGenerated]
		get
		{
			return d4nhQZ2lsW;
		}
		[CompilerGenerated]
		set
		{
			d4nhQZ2lsW = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return EyxhjGoxMU;
		}
		[CompilerGenerated]
		set
		{
			EyxhjGoxMU = value;
		}
	}

	public T Data
	{
		[CompilerGenerated]
		get
		{
			return jV5hnjVHtR;
		}
		[CompilerGenerated]
		set
		{
			jV5hnjVHtR = value;
		}
	}

	internal static bool BctptPNzKMTptxtGGC0()
	{
		return aOyQDYNH80Qfjk9IgdY == null;
	}
}
