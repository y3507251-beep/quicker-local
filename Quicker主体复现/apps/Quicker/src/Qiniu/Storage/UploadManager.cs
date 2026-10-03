using System.IO;
using Qiniu.Http;

namespace Qiniu.Storage;

public class UploadManager
{
	private Config LuaIFSvQ8U;

	private static UploadManager Q9P3uofkOeaSBP315gC;

	public UploadManager(Config config)
	{
		LuaIFSvQ8U = config;
	}

	public HttpResult UploadData(byte[] data, string key, string token, PutExtra extra)
	{
		return new FormUploader(LuaIFSvQ8U).UploadData(data, key, token, extra);
	}

	public HttpResult UploadFile(string localFile, string key, string token, PutExtra extra)
	{
		HttpResult httpResult = new HttpResult();
		if (new System.IO.FileInfo(localFile).Length > LuaIFSvQ8U.PutThreshold)
		{
			return new ResumableUploader(LuaIFSvQ8U).UploadFile(localFile, key, token, extra);
		}
		return new FormUploader(LuaIFSvQ8U).UploadFile(localFile, key, token, extra);
	}

	public HttpResult UploadStream(Stream stream, string key, string token, PutExtra extra)
	{
		HttpResult httpResult = new HttpResult();
		if (stream.Length > LuaIFSvQ8U.PutThreshold)
		{
			return new ResumableUploader(LuaIFSvQ8U).UploadStream(stream, key, token, extra);
		}
		return new FormUploader(LuaIFSvQ8U).UploadStream(stream, key, token, extra);
	}

	internal static bool jJCnCafavnRs83PuLem()
	{
		return Q9P3uofkOeaSBP315gC == null;
	}
}
