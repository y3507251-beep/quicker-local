using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quicker.Public;

public interface ICustomWindowContext
{
	Task<IDictionary<string, object>> RunSpAsync(string spName, IDictionary<string, object> inputParams);

	Task<IDictionary<string, object>> RunSpAsync(string spName, object inputParams);

	IDictionary<string, object> RunSp(string spName, IDictionary<string, object> inputParams);

	IDictionary<string, object> RunSp(string spName, object inputParams);
}
