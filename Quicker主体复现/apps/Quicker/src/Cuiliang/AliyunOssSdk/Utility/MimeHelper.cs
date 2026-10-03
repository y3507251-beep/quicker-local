using MimeMapping;

namespace Cuiliang.AliyunOssSdk.Utility;

public static class MimeHelper
{
	public static string GetMime(string filename)
	{
		return MimeUtility.GetMimeMapping(filename);
	}
}
