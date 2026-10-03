using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Chat;

public interface IChatEndpoint
{
	ChatRequest DefaultChatRequestArgs { get; set; }

	Conversation CreateConversation(ChatRequest defaultChatRequestArgs = null);

	Task<ChatResult> CreateChatCompletionAsync(ChatRequest request, IDictionary<string, object> extraProps);

	Task<ChatResult> CreateChatCompletionAsync(ChatRequest request, int numOutputs = 5);

	Task<ChatResult> CreateChatCompletionAsync(IList<ChatMessage> messages, Model model = null, double? temperature = null, double? top_p = null, int? numOutputs = null, int? max_tokens = null, double? frequencyPenalty = null, double? presencePenalty = null, IReadOnlyDictionary<string, float> logitBias = null, params string[] stopSequences);

	Task<ChatResult> CreateChatCompletionAsync(params ChatMessage[] messages);

	Task<ChatResult> CreateChatCompletionAsync(params string[] userMessages);

	Task<ChatResult> CreateChatCompletionAsync(string userMessage, params ChatMessage.ImageInput[] images);

	Task StreamChatAsync(ChatRequest request, Action<ChatResult> resultHandler, IDictionary<string, object> extraProps);

	IAsyncEnumerable<ChatResult> StreamChatEnumerableAsync(ChatRequest request, IDictionary<string, object> extraProps);

	IAsyncEnumerable<ChatResult> StreamChatEnumerableAsync(IList<ChatMessage> messages, Model model = null, double? temperature = null, double? top_p = null, int? numOutputs = null, int? max_tokens = null, double? frequencyPenalty = null, double? presencePenalty = null, IReadOnlyDictionary<string, float> logitBias = null, params string[] stopSequences);

	Task StreamCompletionAsync(ChatRequest request, Action<int, ChatResult> resultHandler, IDictionary<string, object> extraProps);
}
