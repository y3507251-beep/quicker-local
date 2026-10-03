using System;
using System.Runtime.CompilerServices;

namespace QCloud.COS;

public class RequestFailureException : Exception
{
	[CompilerGenerated]
	private string bmBevKSwT9;

	[CompilerGenerated]
	private int HXyeSYvMG0;

	[CompilerGenerated]
	private string B5Ue28RogS;

	[CompilerGenerated]
	private string A26eupfWk5;

	[CompilerGenerated]
	private string uw6eNGYTFE;

	[CompilerGenerated]
	private string jB4eJbMHv4;

	internal static RequestFailureException bXY1a99x23M6ul0dTa7;

	public string HttpMethod
	{
		[CompilerGenerated]
		get
		{
			return bmBevKSwT9;
		}
		[CompilerGenerated]
		set
		{
			bmBevKSwT9 = value;
		}
	}

	public int HttpStatusCode
	{
		[CompilerGenerated]
		get
		{
			return HXyeSYvMG0;
		}
		[CompilerGenerated]
		set
		{
			HXyeSYvMG0 = value;
		}
	}

	public string ErrorCode
	{
		[CompilerGenerated]
		get
		{
			return B5Ue28RogS;
		}
		[CompilerGenerated]
		set
		{
			B5Ue28RogS = value;
		}
	}

	public string ResourceURL
	{
		[CompilerGenerated]
		get
		{
			return A26eupfWk5;
		}
		[CompilerGenerated]
		set
		{
			A26eupfWk5 = value;
		}
	}

	public string RequestId
	{
		[CompilerGenerated]
		get
		{
			return uw6eNGYTFE;
		}
		[CompilerGenerated]
		set
		{
			uw6eNGYTFE = value;
		}
	}

	public string TraceId
	{
		[CompilerGenerated]
		get
		{
			return jB4eJbMHv4;
		}
		[CompilerGenerated]
		set
		{
			jB4eJbMHv4 = value;
		}
	}

	public RequestFailureException(string method, string message)
		: base(message)
	{
		HttpMethod = method;
	}

	public override string ToString()
	{
		return $"{HttpMethod} {ResourceURL} - {HttpStatusCode}[{ErrorCode}]";
	}

	internal static bool GcLt3K9IhqA8S9QGJwQ()
	{
		return bXY1a99x23M6ul0dTa7 == null;
	}
}
