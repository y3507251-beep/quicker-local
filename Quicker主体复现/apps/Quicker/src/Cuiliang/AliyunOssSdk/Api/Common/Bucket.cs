using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Cuiliang.AliyunOssSdk.Api.Common;

public class Bucket
{
	[CompilerGenerated]
	private string WbINJPsxjI;

	[CompilerGenerated]
	private string I0cN09Gwrn;

	[CompilerGenerated]
	private Owner uaWNCj3vru;

	[CompilerGenerated]
	private DateTime lq9NP4XHRl;

	internal static Bucket Sfb5k5DJ2k70n7h0DFw;

	public string Location
	{
		[CompilerGenerated]
		get
		{
			return WbINJPsxjI;
		}
		[CompilerGenerated]
		set
		{
			WbINJPsxjI = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return I0cN09Gwrn;
		}
		[CompilerGenerated]
		set
		{
			I0cN09Gwrn = value;
		}
	}

	public Owner Owner
	{
		[CompilerGenerated]
		get
		{
			return uaWNCj3vru;
		}
		[CompilerGenerated]
		set
		{
			uaWNCj3vru = value;
		}
	}

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return lq9NP4XHRl;
		}
		[CompilerGenerated]
		set
		{
			lq9NP4XHRl = value;
		}
	}

	public Bucket()
	{
	}

	public Bucket(string name)
	{
		Name = name;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "OSS Bucket [Name={0}], [Location={1}] [Owner={2}], [CreationTime={3}]", Name, Location, Owner, CreationDate);
	}

	internal static bool gg6a9WDkGJv894rDrFs()
	{
		return Sfb5k5DJ2k70n7h0DFw == null;
	}
}
