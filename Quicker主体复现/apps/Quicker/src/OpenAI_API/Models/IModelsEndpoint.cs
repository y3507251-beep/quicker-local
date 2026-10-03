using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenAI_API.Models;

public interface IModelsEndpoint
{
	Task<Model> RetrieveModelDetailsAsync(string id);

	Task<Model> RetrieveModelDetailsAsync(string id, APIAuthentication auth = null);

	Task<List<Model>> GetModelsAsync();
}
