using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Embedding;

public interface IEmbeddingEndpoint
{
	EmbeddingRequest DefaultEmbeddingRequestArgs { get; set; }

	Task<EmbeddingResult> CreateEmbeddingAsync(string input);

	Task<EmbeddingResult> CreateEmbeddingAsync(EmbeddingRequest request);

	Task<float[]> GetEmbeddingsAsync(string input, Model model = null, int? dimensions = null);
}
