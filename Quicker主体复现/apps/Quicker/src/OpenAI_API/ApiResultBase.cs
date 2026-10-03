using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;
using Quicker.Annotations;

namespace OpenAI_API;

public abstract class ApiResultBase
{
	[CompilerGenerated]
	private long? sqXRdOVBu3;

	[CompilerGenerated]
	private Model LXZRog7m3d;

	[CompilerGenerated]
	private string NZxRTYESPO;

	[CompilerGenerated]
	private string vGBRMkjBsX;

	[CompilerGenerated]
	private TimeSpan ToERACuiT0;

	[CompilerGenerated]
	private string dKvROM3uLS;

	[CompilerGenerated]
	private string OSJRFkFyxY;

	[CompilerGenerated]
	private string v7YRUFKCwO;

	[CompilerGenerated]
	private Error wp7RlgTwXM;

	private static ApiResultBase MS64N5JYOvHLImIB7Y9;

	[JsonIgnore]
	public DateTime? Created
	{
		get
		{
			if (!CreatedUnixTime.HasValue)
			{
				return null;
			}
			return DateTimeOffset.FromUnixTimeSeconds(CreatedUnixTime.Value).DateTime;
		}
	}

	[JsonProperty("created")]
	public long? CreatedUnixTime
	{
		[CompilerGenerated]
		get
		{
			return sqXRdOVBu3;
		}
		[CompilerGenerated]
		set
		{
			sqXRdOVBu3 = value;
		}
	}

	[JsonProperty("model")]
	public Model Model
	{
		[CompilerGenerated]
		get
		{
			return LXZRog7m3d;
		}
		[CompilerGenerated]
		set
		{
			LXZRog7m3d = value;
		}
	}

	[JsonProperty("object")]
	public string Object
	{
		[CompilerGenerated]
		get
		{
			return NZxRTYESPO;
		}
		[CompilerGenerated]
		set
		{
			NZxRTYESPO = value;
		}
	}

	[JsonIgnore]
	public string Organization
	{
		[CompilerGenerated]
		get
		{
			return vGBRMkjBsX;
		}
		[CompilerGenerated]
		internal set
		{
			vGBRMkjBsX = value;
		}
	}

	[JsonIgnore]
	public TimeSpan ProcessingTime
	{
		[CompilerGenerated]
		get
		{
			return ToERACuiT0;
		}
		[CompilerGenerated]
		internal set
		{
			ToERACuiT0 = value;
		}
	}

	[JsonIgnore]
	public string RequestId
	{
		[CompilerGenerated]
		get
		{
			return dKvROM3uLS;
		}
		[CompilerGenerated]
		internal set
		{
			dKvROM3uLS = value;
		}
	}

	[JsonIgnore]
	public string OpenaiVersion
	{
		[CompilerGenerated]
		get
		{
			return OSJRFkFyxY;
		}
		[CompilerGenerated]
		internal set
		{
			OSJRFkFyxY = value;
		}
	}

	[JsonIgnore]
	public string RawResponse
	{
		[CompilerGenerated]
		get
		{
			return v7YRUFKCwO;
		}
		[CompilerGenerated]
		internal set
		{
			v7YRUFKCwO = value;
		}
	}

	[CanBeNull]
	[JsonProperty("error")]
	public Error Error
	{
		[CompilerGenerated]
		get
		{
			return wp7RlgTwXM;
		}
		[CompilerGenerated]
		internal set
		{
			wp7RlgTwXM = value;
		}
	}

	public bool Successful => Error == null;

	internal static bool EW3RZiJ8eTx83AJpJ9J()
	{
		return MS64N5JYOvHLImIB7Y9 == null;
	}
}
