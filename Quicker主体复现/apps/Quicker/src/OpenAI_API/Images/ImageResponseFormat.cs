using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Images;

public class ImageResponseFormat
{
	internal class pWYgX4dPPXNb8ScayGr : JsonConverter<ImageResponseFormat>
	{
		private static pWYgX4dPPXNb8ScayGr cSUZVxc1uXtnWC9F0lwo;

		public override ImageResponseFormat ReadJson(JsonReader jsonReader_0, Type type_0, ImageResponseFormat imageResponseFormat_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new ImageResponseFormat(jsonReader_0.ReadAsString());
		}

		public override void WriteJson(JsonWriter jsonWriter_0, ImageResponseFormat imageResponseFormat_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(imageResponseFormat_0.ToString());
		}

		internal static bool E0vh1gc1oscR7cDHNfWF()
		{
			return cSUZVxc1uXtnWC9F0lwo == null;
		}
	}

	[CompilerGenerated]
	private string ctccqG75jp;

	internal static ImageResponseFormat HGkQvCkMXUbdg4ErY9L;

	private string Value
	{
		[CompilerGenerated]
		get
		{
			return ctccqG75jp;
		}
		[CompilerGenerated]
		set
		{
			ctccqG75jp = value;
		}
	}

	public static ImageResponseFormat Url => new ImageResponseFormat("url");

	public static ImageResponseFormat B64_json => new ImageResponseFormat("b64_json");

	private ImageResponseFormat(string value)
	{
		Value = value;
	}

	public override string ToString()
	{
		return Value;
	}

	public static implicit operator string(ImageResponseFormat value)
	{
		return value;
	}

	internal static bool haGY9TkUZGoXlFwQXmO()
	{
		return HGkQvCkMXUbdg4ErY9L == null;
	}
}
