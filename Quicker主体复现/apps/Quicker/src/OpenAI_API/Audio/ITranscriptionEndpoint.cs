using System.IO;
using System.Threading.Tasks;

namespace OpenAI_API.Audio;

public interface ITranscriptionEndpoint
{
	AudioRequest DefaultRequestArgs { get; set; }

	Task<string> GetAsFormatAsync(Stream audioStream, string filename, string responseFormat, string language = null, string prompt = null, double? temperature = null);

	Task<string> GetAsFormatAsync(string audioFilePath, string responseFormat, string language = null, string prompt = null, double? temperature = null);

	Task<AudioResultVerbose> GetWithDetailsAsync(Stream audioStream, string filename, string language = null, string prompt = null, double? temperature = null);

	Task<AudioResultVerbose> GetWithDetailsAsync(string audioFilePath, string language = null, string prompt = null, double? temperature = null);

	Task<string> GetTextAsync(Stream audioStream, string filename, string language = null, string prompt = null, double? temperature = null);

	Task<string> GetTextAsync(string audioFilePath, string language = null, string prompt = null, double? temperature = null);
}
