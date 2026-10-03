using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.ImageSearch;

public class ImageSearch : AipServiceBase
{
	internal static ImageSearch KGv8t2Ar9lMZcBYLypi;

	public ImageSearch(string apiKey, string secretKey)
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

	public JObject SameHqAdd(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/add");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SameHqAddUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/add");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SameHqSearch(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/search");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SameHqSearchUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/search");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SameHqUpdate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/update");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SameHqUpdateUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/update");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SameHqUpdateContSign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/update");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	public JObject SameHqDeleteByImage(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/delete");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SameHqDeleteByUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/delete");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SameHqDeleteBySign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/realtime_search/same_hq/delete");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	public JObject SimilarAdd(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/add");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SimilarAddUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/add");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SimilarSearch(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/search");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SimilarSearchUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/search");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SimilarUpdate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/update");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SimilarUpdateUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/update");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SimilarUpdateContSign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/update");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	public JObject SimilarDeleteByImage(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/delete");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject SimilarDeleteByUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/delete");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject SimilarDeleteBySign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/similar/delete");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	public JObject ProductAdd(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/add");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject ProductAddUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/add");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject ProductSearch(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/search");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject ProductSearchUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/search");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject ProductUpdate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/update");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject ProductUpdateUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/update");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject ProductUpdateContSign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/update");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	public JObject ProductDeleteByImage(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/delete");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject ProductDeleteByUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/delete");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject ProductDeleteBySign(string contSign, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/image-classify/v1/realtime_search/product/delete");
		aipHttpRequest.Bodys["cont_sign"] = contSign;
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

	internal static void fdtSNnALd2DRn62e0hk()
	{
	}

	internal static bool jUpyS7AN2g9h7n50YBF()
	{
		return KGv8t2Ar9lMZcBYLypi == null;
	}
}
