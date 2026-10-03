using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Public.Extensions;

namespace OpenAI_API.Chat;

public class ChatMessage
{
	public class ContentItem
	{
		private string mUavaWBaIHH;

		private ImageInput HvPvakAy2FY;

		private ImageInput IBAvaGTwX6v;

		[CompilerGenerated]
		private string rrrvasqxsXt = "text";

		private static ContentItem uJBpY4cKfu8aOmZbQCOD;

		[JsonProperty("type")]
		public string Type
		{
			[CompilerGenerated]
			get
			{
				return rrrvasqxsXt;
			}
			[CompilerGenerated]
			set
			{
				rrrvasqxsXt = value;
			}
		}

		[JsonProperty("text")]
		public string Text
		{
			get
			{
				if (Type == "text")
				{
					return mUavaWBaIHH;
				}
				return null;
			}
			set
			{
				mUavaWBaIHH = value;
				HvPvakAy2FY = null;
				Type = "text";
			}
		}

		[JsonProperty("image_url")]
		public ImageInput Image
		{
			get
			{
				if (Type == "image_url")
				{
					return HvPvakAy2FY;
				}
				return null;
			}
			set
			{
				if (value != null)
				{
					HvPvakAy2FY = value;
					mUavaWBaIHH = null;
					Type = "image_url";
				}
			}
		}

		[JsonProperty("file_url")]
		public ImageInput File
		{
			get
			{
				if (Type == "file_url")
				{
					return IBAvaGTwX6v;
				}
				return null;
			}
			set
			{
				if (value != null)
				{
					IBAvaGTwX6v = value;
					mUavaWBaIHH = null;
					Type = "file_url";
				}
			}
		}

		public ContentItem()
		{
		}

		public ContentItem(string text)
		{
			Text = text;
			Type = "text";
		}

		public ContentItem(ImageInput image)
		{
			Image = image;
			Type = "image_url";
		}

		internal static bool pp7W02cKb8VEg4cHfaYb()
		{
			return uJBpY4cKfu8aOmZbQCOD == null;
		}

		internal static void TQko1UcKlgsImIYRh9ku()
		{
		}
	}

	public class ImageInput
	{
		[CompilerGenerated]
		private string FauvaHKpwfb;

		[CompilerGenerated]
		private string WSbva1enH4U = "auto";

		public const string DetailAuto = "auto";

		public const string DetailLow = "low";

		public const string DetailHigh = "high";

		private static ImageInput v1rC0dcKZ82heEOAVsES;

		[JsonProperty("url")]
		public string Url
		{
			[CompilerGenerated]
			get
			{
				return FauvaHKpwfb;
			}
			[CompilerGenerated]
			set
			{
				FauvaHKpwfb = value;
			}
		}

		[JsonProperty("detail")]
		public string Detail
		{
			[CompilerGenerated]
			get
			{
				return WSbva1enH4U;
			}
			[CompilerGenerated]
			set
			{
				WSbva1enH4U = value;
			}
		}

		public ImageInput()
		{
		}

		public ImageInput(string url, string detail = "auto")
		{
			Url = url;
			Detail = detail;
		}

		public ImageInput(byte[] imageData, string detail = "auto")
		{
			Url = "data:image/jpeg;base64," + Convert.ToBase64String(imageData);
			Detail = detail;
		}

		public static ImageInput FromFile(string filePath, string detail = "auto")
		{
			return new ImageInput(File.ReadAllBytes(filePath), detail);
		}

		public static ImageInput FromImageBytes(byte[] imageData, string detail = "auto")
		{
			return new ImageInput(imageData, detail);
		}

		public static ImageInput FromImageUrl(string url, string detail = "auto")
		{
			return new ImageInput(url, detail);
		}

		static ImageInput()
		{
		}

		internal static bool Q3vAElcK5cOu2yvYj5AB()
		{
			return v1rC0dcKZ82heEOAVsES == null;
		}

		internal static void z3JNhrcK8iUWNcZ333qs()
		{
		}
	}

	internal class dMru30dVoZ05qJVyy8k : JsonConverter
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec aQe28TZqKkc;

			public static Func<ContentItem, bool> ToA28MOGg4M;

			public static Func<ContentItem, bool> I8y28AMsQIX;

			private static _003C_003Ec sM81Why9oYlnuVhhVcAB;

			static _003C_003Ec()
			{
				aQe28TZqKkc = new _003C_003Ec();
			}

			internal bool A0o28dfd8fU(ContentItem x)
			{
				if (x.Text == null)
				{
					return x.Image != null;
				}
				return true;
			}

			internal bool Qw928oN10fD(ContentItem x)
			{
				if (x.Text == null)
				{
					return x.Image != null;
				}
				return true;
			}

			internal static bool rPFirFy9ffbZ0AHDMfRY()
			{
				return sM81Why9oYlnuVhhVcAB == null;
			}
		}

		private static dMru30dVoZ05qJVyy8k aMaUa5cKRdHnwqcar0d6;

		public override bool CanConvert(Type type_0)
		{
			return true;
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken jToken = JToken.Load(jsonReader_0);
			if (jToken.Type == JTokenType.Object)
			{
				IList<ContentItem> list = jToken.ToObject<IList<ContentItem>>();
				if (list.HasData() && list.All(_003C_003Ec.ToA28MOGg4M ?? (_003C_003Ec.ToA28MOGg4M = _003C_003Ec.aQe28TZqKkc.A0o28dfd8fU)))
				{
					return list;
				}
			}
			else if (jToken.Type == JTokenType.Array)
			{
				List<ContentItem> list2 = jToken.ToObject<List<ContentItem>>();
				int num = 0;
				if (aMaUa5cKRdHnwqcar0d6 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (list2.HasData() && list2.All(_003C_003Ec.I8y28AMsQIX ?? (_003C_003Ec.I8y28AMsQIX = _003C_003Ec.aQe28TZqKkc.Qw928oN10fD)))
				{
					return list2;
				}
			}
			else if (jToken.Type == JTokenType.String)
			{
				return jToken.ToObject<string>();
			}
			return jToken;
		}

		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			jsonSerializer_0.Serialize(jsonWriter_0, object_0);
		}

		internal static bool CwimTHcKgwonV3SGJm4E()
		{
			return aMaUa5cKRdHnwqcar0d6 == null;
		}
	}

	private string Cn2V8HI5n4;

	[CompilerGenerated]
	private string nSWVaLlJ7n;

	[CompilerGenerated]
	private string URdV7K4jeK;

	[CompilerGenerated]
	private IList<ContentItem> B3sVRg016o;

	[CompilerGenerated]
	private object mtoVqbTqkC;

	[CompilerGenerated]
	private string WNBVcpsWHg;

	internal static ChatMessage T5ITGeaP3NTubbggMnC;

	[JsonProperty("role")]
	internal string CutVy5B7qm
	{
		[CompilerGenerated]
		get
		{
			return nSWVaLlJ7n;
		}
		[CompilerGenerated]
		set
		{
			nSWVaLlJ7n = value;
		}
	}

	[JsonIgnore]
	public ChatMessageRole Role
	{
		get
		{
			return ChatMessageRole.FromString(CutVy5B7qm);
		}
		set
		{
			CutVy5B7qm = value.ToString();
		}
	}

	[Obsolete("This property has been renamed to TextContent.")]
	[JsonIgnore]
	public string Content
	{
		get
		{
			return TextContent;
		}
		set
		{
			TextContent = value;
		}
	}

	[JsonIgnore]
	public string TextContent
	{
		[CompilerGenerated]
		get
		{
			return URdV7K4jeK;
		}
		[CompilerGenerated]
		set
		{
			URdV7K4jeK = value;
		}
	}

	[JsonIgnore]
	public IList<ContentItem> ListContent
	{
		[CompilerGenerated]
		get
		{
			return B3sVRg016o;
		}
		[CompilerGenerated]
		set
		{
			B3sVRg016o = value;
		}
	}

	[JsonIgnore]
	public object ObjectContent
	{
		[CompilerGenerated]
		get
		{
			return mtoVqbTqkC;
		}
		[CompilerGenerated]
		set
		{
			mtoVqbTqkC = value;
		}
	}

	[JsonProperty("content")]
	[JsonConverter(typeof(dMru30dVoZ05qJVyy8k))]
	public object ContentCalculated
	{
		get
		{
			if (ListContent.HasData())
			{
				return ListContent;
			}
			if (ObjectContent != null)
			{
				return ObjectContent;
			}
			return TextContent;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "未能正常解析消息。");
			}
			if (value is string)
			{
				TextContent = value as string;
			}
			else if (value is IList<ContentItem>)
			{
				ListContent = value as IList<ContentItem>;
			}
			else
			{
				ObjectContent = value;
			}
		}
	}

	[JsonProperty("reasoning_content")]
	public string ReasoningContent
	{
		get
		{
			return Cn2V8HI5n4;
		}
		set
		{
			Cn2V8HI5n4 = value;
		}
	}

	[JsonProperty("reasoning")]
	public string Reasoning
	{
		get
		{
			return Cn2V8HI5n4;
		}
		set
		{
			Cn2V8HI5n4 = value;
		}
	}

	[JsonProperty("name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return WNBVcpsWHg;
		}
		[CompilerGenerated]
		set
		{
			WNBVcpsWHg = value;
		}
	}

	public ChatMessage()
	{
		Role = ChatMessageRole.User;
	}

	public ChatMessage(ChatMessageRole role, string text)
	{
		Role = role;
		TextContent = text;
	}

	public ChatMessage(ChatMessageRole role, string text, params ImageInput[] imageInputs)
	{
		Role = role;
		TextContent = text;
		if (imageInputs.HasData())
		{
			ListContent = new List<ContentItem>();
			foreach (ImageInput image in imageInputs)
			{
				ListContent.Add(new ContentItem(image));
			}
		}
	}

	static ChatMessage()
	{
	}

	internal static bool asTCK9aMdosRYEduoTH()
	{
		return T5ITGeaP3NTubbggMnC == null;
	}

	internal static void gfYAhhaxFQRavr86X0G()
	{
	}
}
