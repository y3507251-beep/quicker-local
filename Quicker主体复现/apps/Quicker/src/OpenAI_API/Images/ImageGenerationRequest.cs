using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using OpenAI_API.Models;

namespace OpenAI_API.Images;

public class ImageGenerationRequest
{
	private int? QDhc07WSXx = 1;

	private ImageSize t5mcCn26Lq = ImageSize._1024;

	private string BwEcP4Qkwo = "standard";

	[CompilerGenerated]
	private string z9WcEqNJDI;

	[CompilerGenerated]
	private string j2ocyNGAXo = OpenAI_API.Models.Model.DALLE2;

	[CompilerGenerated]
	private string oS2c8Dg0Np;

	[CompilerGenerated]
	private ImageResponseFormat pAOca6PmsM;

	internal static ImageGenerationRequest ppnrgNk8mVodW8tFjZf;

	[JsonProperty("prompt")]
	public string Prompt
	{
		[CompilerGenerated]
		get
		{
			return z9WcEqNJDI;
		}
		[CompilerGenerated]
		set
		{
			z9WcEqNJDI = value;
		}
	}

	[JsonProperty("n")]
	public int? NumOfImages
	{
		get
		{
			if (Model == OpenAI_API.Models.Model.DALLE3 && QDhc07WSXx != 1)
			{
				throw new ArgumentException("For DALL-E 3, only 1 NumOfImages is allowed.");
			}
			return QDhc07WSXx;
		}
		set
		{
			QDhc07WSXx = value;
		}
	}

	[JsonProperty("model")]
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return j2ocyNGAXo;
		}
		[CompilerGenerated]
		set
		{
			j2ocyNGAXo = value;
		}
	}

	[JsonProperty("user")]
	public string User
	{
		[CompilerGenerated]
		get
		{
			return oS2c8Dg0Np;
		}
		[CompilerGenerated]
		set
		{
			oS2c8Dg0Np = value;
		}
	}

	[JsonProperty("size")]
	[JsonConverter(typeof(ImageSize.eiiKiGdyfuHGsyMQbjm))]
	public ImageSize Size
	{
		get
		{
			if (Model == OpenAI_API.Models.Model.DALLE3 && (t5mcCn26Lq == ImageSize._256 || t5mcCn26Lq == ImageSize._512))
			{
				throw new ArgumentException("For DALL-E 3, only 1024x1024, 1024x1792, or 1792x1024 is allowed.");
			}
			if (Model == OpenAI_API.Models.Model.DALLE2 && (t5mcCn26Lq == ImageSize._1792x1024 || t5mcCn26Lq == ImageSize._1024x1792))
			{
				throw new ArgumentException("For DALL-E 2, only 256x256, 512x512, or 1024x1024 is allowed.");
			}
			return t5mcCn26Lq;
		}
		set
		{
			t5mcCn26Lq = value;
		}
	}

	[JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
	public string Quality
	{
		get
		{
			if (Model == OpenAI_API.Models.Model.DALLE2 && BwEcP4Qkwo == "hd")
			{
				throw new ArgumentException("For DALL-E 2, hd quality is not available.");
			}
			if (Model == OpenAI_API.Models.Model.DALLE3 && BwEcP4Qkwo == "standard")
			{
				return null;
			}
			return BwEcP4Qkwo;
		}
		set
		{
			string text = value.ToLower().Trim();
			if (!(text == "standard"))
			{
				if (!(text == "hd"))
				{
					throw new ArgumentException("Quality must be either 'standard' or 'hd'.");
				}
				BwEcP4Qkwo = "hd";
			}
			else
			{
				BwEcP4Qkwo = "standard";
			}
		}
	}

	[JsonProperty("response_format")]
	[JsonConverter(typeof(ImageResponseFormat.pWYgX4dPPXNb8ScayGr))]
	public ImageResponseFormat ResponseFormat
	{
		[CompilerGenerated]
		get
		{
			return pAOca6PmsM;
		}
		[CompilerGenerated]
		set
		{
			pAOca6PmsM = value;
		}
	}

	public ImageGenerationRequest()
	{
	}

	public ImageGenerationRequest(string prompt, Model model, ImageSize size = null, string quality = "standard", string user = null, ImageResponseFormat responseFormat = null)
	{
		Prompt = prompt;
		Model = model ?? OpenAI_API.Models.Model.DALLE2;
		Quality = quality ?? "standard";
		User = user;
		Size = size ?? ImageSize._1024;
		ResponseFormat = responseFormat ?? ImageResponseFormat.Url;
		if (Model == OpenAI_API.Models.Model.DALLE3)
		{
			if (Size == ImageSize._256 || Size == ImageSize._512)
			{
				throw new ArgumentException("For DALL-E 3, only sizes 1024x1024, 1024x1792, or 1792x1024 are allowed.");
			}
			if (BwEcP4Qkwo != "standard" && BwEcP4Qkwo != "hd")
			{
				throw new ArgumentException("Quality must be one of 'standard' or 'hd'");
			}
		}
		else
		{
			if (Size == ImageSize._1792x1024 || Size == ImageSize._1024x1792)
			{
				throw new ArgumentException("For DALL-E 2, only sizes 256x256, 512x512, or 1024x1024 are allowed.");
			}
			if (BwEcP4Qkwo != "standard")
			{
				throw new ArgumentException("For DALL-E 2, only 'standard' quality is available");
			}
		}
	}

	public ImageGenerationRequest(string prompt, int? numOfImages = 1, ImageSize size = null, string user = null, ImageResponseFormat responseFormat = null)
	{
		Prompt = prompt;
		NumOfImages = numOfImages;
		User = user;
		Size = size ?? ImageSize._1024;
		ResponseFormat = responseFormat ?? ImageResponseFormat.Url;
	}

	internal static bool Oi4L7DkRoSalLkIOZTX()
	{
		return ppnrgNk8mVodW8tFjZf == null;
	}
}
