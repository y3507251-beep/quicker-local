using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Request;

public class MyProxy : IWebProxy
{
	[CompilerGenerated]
	private Uri v0m2JCqD12;

	[CompilerGenerated]
	private ICredentials PwE2072Ujl;

	private static MyProxy dYS9FSeVW3dkQYIBdLP;

	public Uri ProxyUri
	{
		[CompilerGenerated]
		get
		{
			return v0m2JCqD12;
		}
		[CompilerGenerated]
		set
		{
			v0m2JCqD12 = value;
		}
	}

	public ICredentials Credentials
	{
		[CompilerGenerated]
		get
		{
			return PwE2072Ujl;
		}
		[CompilerGenerated]
		set
		{
			PwE2072Ujl = value;
		}
	}

	public MyProxy(string proxyUri)
		: this(new Uri(proxyUri))
	{
	}

	public MyProxy(Uri proxyUri)
	{
		ProxyUri = proxyUri;
	}

	public Uri GetProxy(Uri destination)
	{
		return ProxyUri;
	}

	public bool IsBypassed(Uri host)
	{
		return false;
	}

	static MyProxy()
	{
	}

	internal static bool B7b5IweQsZFdHD1rLg2()
	{
		return dYS9FSeVW3dkQYIBdLP == null;
	}

	internal static void tDeZntecGoQsnRyMoog()
	{
	}
}
