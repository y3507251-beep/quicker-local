using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Images;

public interface IImageGenerationEndpoint
{
	Task<ImageResult> CreateImageAsync(ImageGenerationRequest request);

	Task<ImageResult> CreateImageAsync(string input, Model model = null);
}
