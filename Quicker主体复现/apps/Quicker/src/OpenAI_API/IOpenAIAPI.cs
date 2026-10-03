using System.Net.Http;
using OpenAI_API.Audio;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Embedding;
using OpenAI_API.Files;
using OpenAI_API.Images;
using OpenAI_API.Models;
using OpenAI_API.Moderation;

namespace OpenAI_API;

public interface IOpenAIAPI
{
	string ApiUrlFormat { get; set; }

	string ApiVersion { get; set; }

	APIAuthentication Auth { get; set; }

	IChatEndpoint Chat { get; }

	IModerationEndpoint Moderation { get; }

	ICompletionEndpoint Completions { get; }

	IEmbeddingEndpoint Embeddings { get; }

	IModelsEndpoint Models { get; }

	IFilesEndpoint Files { get; }

	IImageGenerationEndpoint ImageGenerations { get; }

	ITextToSpeechEndpoint TextToSpeech { get; }

	ITranscriptionEndpoint Transcriptions { get; }

	ITranscriptionEndpoint Translations { get; }

	HttpClient HttpClient { get; set; }
}
