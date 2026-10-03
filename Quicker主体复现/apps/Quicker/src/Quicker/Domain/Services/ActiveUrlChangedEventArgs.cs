using System;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Services;

public class ActiveUrlChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private string o6MtstGf39i;

	[CompilerGenerated]
	private int oHFtsgtJcl5;

	[CompilerGenerated]
	private int sEFtsLSGQCg;

	[CompilerGenerated]
	private string io3tsvsDwIe;

	[CompilerGenerated]
	private bool? awDtsS3QR4u;

	[CompilerGenerated]
	private int? yOuts2bgc4k;

	internal static ActiveUrlChangedEventArgs A7vaUjQk8lKdjpyVjyxu;

	public string Browser
	{
		[CompilerGenerated]
		get
		{
			return o6MtstGf39i;
		}
		[CompilerGenerated]
		set
		{
			o6MtstGf39i = value;
		}
	}

	public int ProcessId
	{
		[CompilerGenerated]
		get
		{
			return oHFtsgtJcl5;
		}
		[CompilerGenerated]
		set
		{
			oHFtsgtJcl5 = value;
		}
	}

	public int TabId
	{
		[CompilerGenerated]
		get
		{
			return sEFtsLSGQCg;
		}
		[CompilerGenerated]
		set
		{
			sEFtsLSGQCg = value;
		}
	}

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return io3tsvsDwIe;
		}
		[CompilerGenerated]
		set
		{
			io3tsvsDwIe = value;
		}
	}

	public bool? IsActive
	{
		[CompilerGenerated]
		get
		{
			return awDtsS3QR4u;
		}
		[CompilerGenerated]
		set
		{
			awDtsS3QR4u = value;
		}
	}

	public int? EventType
	{
		[CompilerGenerated]
		get
		{
			return yOuts2bgc4k;
		}
		[CompilerGenerated]
		set
		{
			yOuts2bgc4k = value;
		}
	}

	internal static bool itfMlaQkR8itpCgWxb5t()
	{
		return A7vaUjQk8lKdjpyVjyxu == null;
	}
}
