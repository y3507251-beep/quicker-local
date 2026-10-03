using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Images;

public class ImageSize
{
	internal class eiiKiGdyfuHGsyMQbjm : JsonConverter<ImageSize>
	{
		internal static eiiKiGdyfuHGsyMQbjm bpYNJhc1b8HZbPbOE7xD;

		public override void WriteJson(JsonWriter jsonWriter_0, ImageSize imageSize_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(imageSize_0.ToString());
		}

		public override ImageSize ReadJson(JsonReader jsonReader_0, Type type_0, ImageSize imageSize_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new ImageSize(jsonReader_0.ReadAsString());
		}

		internal static bool A1nm00c1qoLw0j4ZlawY()
		{
			return bpYNJhc1b8HZbPbOE7xD == null;
		}
	}

	[CompilerGenerated]
	private string AFpcYdgEQW;

	internal static ImageSize eAN0EMkm1BiSm7GbDaB;

	private string Value
	{
		[CompilerGenerated]
		get
		{
			return AFpcYdgEQW;
		}
		[CompilerGenerated]
		set
		{
			AFpcYdgEQW = value;
		}
	}

	public static ImageSize _256 => new ImageSize("256x256");

	public static ImageSize _512 => new ImageSize("512x512");

	public static ImageSize _1024 => new ImageSize("1024x1024");

	public static ImageSize _1024x1792 => new ImageSize("1024x1792");

	public static ImageSize _1792x1024 => new ImageSize("1792x1024");

	internal ImageSize(string value)
	{
		Value = value;
	}

	public override string ToString()
	{
		return Value;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is ImageSize)
		{
			return Value.Equals(((ImageSize)obj).Value);
		}
		if (obj is string)
		{
			return Value.Equals((string)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public static bool operator ==(ImageSize a, ImageSize b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(ImageSize a, ImageSize b)
	{
		return !a.Equals(b);
	}

	public static implicit operator string(ImageSize value)
	{
		return value;
	}

	internal static bool qNpsARks2Km7cTpojby()
	{
		return (object)eAN0EMkm1BiSm7GbDaB == null;
	}
}
