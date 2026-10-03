using System.IO;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Audio;

public interface ITextToSpeechEndpoint
{
	TextToSpeechRequest DefaultTTSRequestArgs { get; set; }

	Task<Stream> GetSpeechAsStreamAsync(TextToSpeechRequest request);

	Task<Stream> GetSpeechAsStreamAsync(string input, string voice = null, double? speed = null, string responseFormat = null, Model model = null);

	Task<FileInfo> SaveSpeechToFileAsync(TextToSpeechRequest request, string localPath);

	Task<FileInfo> SaveSpeechToFileAsync(string input, string localPath, string voice = null, double? speed = null, string responseFormat = null, Model model = null);
}
