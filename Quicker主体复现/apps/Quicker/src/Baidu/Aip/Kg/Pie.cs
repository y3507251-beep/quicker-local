using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Kg;

public class Pie : AipServiceBase
{
	internal static Pie vo3Q6lAdyxEvRpwMkYo;

	public Pie(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed,
			ContentEncoding = Encoding.UTF8
		};
	}

	public JObject CreateTask(string name, string templateContent, string inputMappingFile, string outputFile, string urlPattern, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_create");
		aipHttpRequest.Bodys["name"] = name;
		aipHttpRequest.Bodys["template_content"] = templateContent;
		aipHttpRequest.Bodys["input_mapping_file"] = inputMappingFile;
		aipHttpRequest.Bodys["output_file"] = outputFile;
		aipHttpRequest.Bodys["url_pattern"] = urlPattern;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject UpdateTask(int id, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_update");
		aipHttpRequest.Bodys["id"] = id;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject TaskInfo(int id, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_info");
		aipHttpRequest.Bodys["id"] = id;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject TaskQuery(Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_query");
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject TaskStart(int id, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_start");
		aipHttpRequest.Bodys["id"] = id;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject TaskStatus(int id, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/kg/v1/pie/task_status");
		aipHttpRequest.Bodys["id"] = id;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	internal static void ecZLTRAkMoUrdOVWOwK()
	{
	}

	internal static bool sJqKO4AOuHDmicyeqNq()
	{
		return vo3Q6lAdyxEvRpwMkYo == null;
	}
}
