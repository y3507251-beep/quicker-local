using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Completions;

public interface ICompletionEndpoint
{
	CompletionRequest DefaultCompletionRequestArgs { get; set; }

	Task<CompletionResult> CreateCompletionAsync(CompletionRequest request);

	Task<CompletionResult> CreateCompletionAsync(string prompt, Model model = null, int? max_tokens = null, double? temperature = null, double? top_p = null, int? numOutputs = null, double? presencePenalty = null, double? frequencyPenalty = null, int? logProbs = null, bool? echo = null, params string[] stopSequences);

	Task<CompletionResult> CreateCompletionAsync(params string[] prompts);

	Task<CompletionResult> CreateCompletionsAsync(CompletionRequest request, int numOutputs = 5);

	Task StreamCompletionAsync(CompletionRequest request, Action<int, CompletionResult> resultHandler);

	Task StreamCompletionAsync(CompletionRequest request, Action<CompletionResult> resultHandler);

	IAsyncEnumerable<CompletionResult> StreamCompletionEnumerableAsync(CompletionRequest request);

	IAsyncEnumerable<CompletionResult> StreamCompletionEnumerableAsync(string prompt, Model model = null, int? max_tokens = null, double? temperature = null, double? top_p = null, int? numOutputs = null, double? presencePenalty = null, double? frequencyPenalty = null, int? logProbs = null, bool? echo = null, params string[] stopSequences);

	Task<string> CreateAndFormatCompletion(CompletionRequest request);

	Task<string> GetCompletion(string prompt);
}
