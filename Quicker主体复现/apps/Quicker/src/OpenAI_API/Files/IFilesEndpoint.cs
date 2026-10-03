using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenAI_API.Files;

public interface IFilesEndpoint
{
	Task<List<File>> GetFilesAsync();

	Task<File> GetFileAsync(string fileId);

	Task<string> GetFileContentAsStringAsync(string fileId);

	Task<File> DeleteFileAsync(string fileId);

	Task<File> UploadFileAsync(string filePath, string purpose = "fine-tune");
}
