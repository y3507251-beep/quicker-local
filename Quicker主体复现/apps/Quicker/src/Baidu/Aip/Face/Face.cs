using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Face;

public class Face : AipServiceBase
{
	internal static Face fRmDUKAl9RnA1saQkPP;

	public Face(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json,
			ContentEncoding = Encoding.UTF8
		};
	}

	public JObject Match(JArray faces)
	{
		CheckNotNull(faces, "faces");
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/match");
		aipHttpRequest.BodyType = AipHttpRequest.BodyFormat.JsonRaw;
		PreAction();
		aipHttpRequest.Bodys["RAw"] = faces;
		return PostAction(aipHttpRequest);
	}

	public JObject Faceverify(JArray faces)
	{
		CheckNotNull(faces, "faces");
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceverify");
		aipHttpRequest.BodyType = AipHttpRequest.BodyFormat.JsonRaw;
		PreAction();
		aipHttpRequest.Bodys["RAw"] = faces;
		return PostAction(aipHttpRequest);
	}

	public JObject Detect(string image, string imageType, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/detect");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
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

	public JObject Search(string image, string imageType, string groupIdList, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/search");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
		aipHttpRequest.Bodys["group_id_list"] = groupIdList;
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

	public JObject MultiSearch(string image, string imageType, string groupIdList, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/multi-search");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
		aipHttpRequest.Bodys["group_id_list"] = groupIdList;
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

	public JObject UserAdd(string image, string imageType, string groupId, string userId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/add");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
		aipHttpRequest.Bodys["group_id"] = groupId;
		aipHttpRequest.Bodys["user_id"] = userId;
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

	public JObject UserUpdate(string image, string imageType, string groupId, string userId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/update");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
		aipHttpRequest.Bodys["group_id"] = groupId;
		aipHttpRequest.Bodys["user_id"] = userId;
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

	public JObject FaceDelete(string userId, string groupId, string faceToken, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/face/delete");
		aipHttpRequest.Bodys["user_id"] = userId;
		aipHttpRequest.Bodys["group_id"] = groupId;
		aipHttpRequest.Bodys["face_token"] = faceToken;
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

	public JObject UserGet(string userId, string groupId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/get");
		aipHttpRequest.Bodys["user_id"] = userId;
		aipHttpRequest.Bodys["group_id"] = groupId;
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

	public JObject FaceGetlist(string userId, string groupId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/face/getlist");
		aipHttpRequest.Bodys["user_id"] = userId;
		aipHttpRequest.Bodys["group_id"] = groupId;
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

	public JObject GroupGetusers(string groupId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/group/getusers");
		aipHttpRequest.Bodys["group_id"] = groupId;
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

	public JObject UserCopy(string userId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/copy");
		aipHttpRequest.Bodys["user_id"] = userId;
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

	public JObject UserDelete(string groupId, string userId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/delete");
		aipHttpRequest.Bodys["group_id"] = groupId;
		aipHttpRequest.Bodys["user_id"] = userId;
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

	public JObject GroupAdd(string groupId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/group/add");
		aipHttpRequest.Bodys["group_id"] = groupId;
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

	public JObject GroupDelete(string groupId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/group/delete");
		aipHttpRequest.Bodys["group_id"] = groupId;
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

	public JObject GroupGetlist(Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/faceset/group/getlist");
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

	public JObject PersonVerify(string image, string imageType, string idCardNumber, string name, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v3/person/verify");
		aipHttpRequest.Bodys["image"] = image;
		aipHttpRequest.Bodys["image_type"] = imageType;
		aipHttpRequest.Bodys["id_card_number"] = idCardNumber;
		aipHttpRequest.Bodys["name"] = name;
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

	public JObject VideoSessioncode(Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/face/v1/faceliveness/sessioncode");
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

	internal static bool J9vSPMAZc6lxyHKVU5q()
	{
		return fRmDUKAl9RnA1saQkPP == null;
	}
}
