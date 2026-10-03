using System.Net.Http;
using System.Runtime.CompilerServices;
using OpenAI_API.Audio;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Embedding;
using OpenAI_API.Files;
using OpenAI_API.Images;
using OpenAI_API.Models;
using OpenAI_API.Moderation;
using TNb9frqPBKmVmJwVjlx;

namespace OpenAI_API;

public class OpenAIAPI : IOpenAIAPI
{
	[CompilerGenerated]
	private string AkpqJpsI9l = "https://api.openai.com/{0}/{1}";

	[CompilerGenerated]
	private string d0Fq0SIROK = "v1";

	[CompilerGenerated]
	private APIAuthentication bO0qCLGN8m;

	[CompilerGenerated]
	private readonly ICompletionEndpoint b9lqPJC2mI;

	[CompilerGenerated]
	private readonly IEmbeddingEndpoint aPYqEjcXwJ;

	[CompilerGenerated]
	private readonly IChatEndpoint Mg7qyIVE9e;

	[CompilerGenerated]
	private readonly IModerationEndpoint qhLq8I0dtU;

	[CompilerGenerated]
	private readonly IModelsEndpoint gAmqatkHD0;

	[CompilerGenerated]
	private readonly IFilesEndpoint XCYq7EXBiK;

	[CompilerGenerated]
	private readonly IImageGenerationEndpoint ws4qResvCc;

	[CompilerGenerated]
	private readonly ITextToSpeechEndpoint gnLqq5x7LJ;

	[CompilerGenerated]
	private readonly ITranscriptionEndpoint NB8qcArHNc;

	[CompilerGenerated]
	private readonly ITranscriptionEndpoint q8xqVwKIM6;

	[CompilerGenerated]
	private HttpClient cOgqZf5jAk;

	private static OpenAIAPI xqM8miJmaq4pAQCCecZ;

	public string ApiUrlFormat
	{
		[CompilerGenerated]
		get
		{
			return AkpqJpsI9l;
		}
		[CompilerGenerated]
		set
		{
			AkpqJpsI9l = value;
		}
	}

	public string ApiVersion
	{
		[CompilerGenerated]
		get
		{
			return d0Fq0SIROK;
		}
		[CompilerGenerated]
		set
		{
			d0Fq0SIROK = value;
		}
	}

	public APIAuthentication Auth
	{
		[CompilerGenerated]
		get
		{
			return bO0qCLGN8m;
		}
		[CompilerGenerated]
		set
		{
			bO0qCLGN8m = value;
		}
	}

	public ICompletionEndpoint Completions
	{
		[CompilerGenerated]
		get
		{
			return b9lqPJC2mI;
		}
	}

	public IEmbeddingEndpoint Embeddings
	{
		[CompilerGenerated]
		get
		{
			return aPYqEjcXwJ;
		}
	}

	public IChatEndpoint Chat
	{
		[CompilerGenerated]
		get
		{
			return Mg7qyIVE9e;
		}
	}

	public IModerationEndpoint Moderation
	{
		[CompilerGenerated]
		get
		{
			return qhLq8I0dtU;
		}
	}

	public IModelsEndpoint Models
	{
		[CompilerGenerated]
		get
		{
			return gAmqatkHD0;
		}
	}

	public IFilesEndpoint Files
	{
		[CompilerGenerated]
		get
		{
			return XCYq7EXBiK;
		}
	}

	public IImageGenerationEndpoint ImageGenerations
	{
		[CompilerGenerated]
		get
		{
			return ws4qResvCc;
		}
	}

	public ITextToSpeechEndpoint TextToSpeech
	{
		[CompilerGenerated]
		get
		{
			return gnLqq5x7LJ;
		}
	}

	public ITranscriptionEndpoint Transcriptions
	{
		[CompilerGenerated]
		get
		{
			return NB8qcArHNc;
		}
	}

	public ITranscriptionEndpoint Translations
	{
		[CompilerGenerated]
		get
		{
			return q8xqVwKIM6;
		}
	}

	public HttpClient HttpClient
	{
		[CompilerGenerated]
		get
		{
			return cOgqZf5jAk;
		}
		[CompilerGenerated]
		set
		{
			cOgqZf5jAk = value;
		}
	}

	public OpenAIAPI(APIAuthentication apiKeys, HttpClient httpClient)
	{
		Auth = apiKeys.eTrRBK4DFR();
		b9lqPJC2mI = new CompletionEndpoint(this);
		gAmqatkHD0 = new ModelsEndpoint(this);
		XCYq7EXBiK = new FilesEndpoint(this);
		aPYqEjcXwJ = new EmbeddingEndpoint(this);
		Mg7qyIVE9e = new ChatEndpoint(this);
		qhLq8I0dtU = new ModerationEndpoint(this);
		ws4qResvCc = new ImageGenerationEndpoint(this);
		gnLqq5x7LJ = new TextToSpeechEndpoint(this);
		NB8qcArHNc = new TranscriptionEndpoint(this, false);
		q8xqVwKIM6 = new TranscriptionEndpoint(this, true);
		HttpClient = httpClient;
	}

	public static OpenAIAPI ForAzure(string YourResourceName, string deploymentId, APIAuthentication apiKey, HttpClient client)
	{
		OpenAIAPI openAIAPI = new OpenAIAPI(apiKey, client);
		openAIAPI.ApiVersion = "2023-05-15";
		openAIAPI.ApiUrlFormat = "https://" + YourResourceName + ".openai.azure.com/openai/deployments/" + deploymentId + "/{1}?api-version={0}";
		return openAIAPI;
	}

	internal static bool HJlgHSJs1WEbNYdDBAu()
	{
		return xqM8miJmaq4pAQCCecZ == null;
	}
}
