using System;
using System.IO;
using Newtonsoft.Json;
using Qiniu.Util;

namespace Qiniu.Storage;

public class ResumeHelper
{
	private static ResumeHelper HTPLbNfnErb8RvBt80W;

	public static string GetDefaultRecordKey(string localFile, string key)
	{
		string tempPath = Path.GetTempPath();
		System.IO.FileInfo fileInfo = new System.IO.FileInfo(localFile);
		string str = $"{localFile}:{key}:{fileInfo.LastWriteTime.ToFileTime()}";
		return Path.Combine(tempPath, "QiniuResume_" + Hashing.CalcMD5X(str));
	}

	public static ResumeInfo Load(string recordFile)
	{
		ResumeInfo result = null;
		try
		{
			using FileStream stream = new FileStream(recordFile, FileMode.Open);
			using StreamReader streamReader = new StreamReader(stream);
			result = JsonConvert.DeserializeObject<ResumeInfo>(streamReader.ReadToEnd());
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	public static void Save(ResumeInfo resumeInfo, string recordFile)
	{
		string value = resumeInfo.ToJsonStr();
		using FileStream stream = new FileStream(recordFile, FileMode.Create);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(value);
	}

	internal static bool Lg39CIfegxZWGd3anQd()
	{
		return HTPLbNfnErb8RvBt80W == null;
	}

	internal static void cmEIwWf3eh1LCAC39WT()
	{
	}
}
