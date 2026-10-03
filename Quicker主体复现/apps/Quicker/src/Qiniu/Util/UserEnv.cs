using System.IO;

namespace Qiniu.Util;

public class UserEnv
{
	internal static UserEnv RyILnfLMm8J1E0hS1hf;

	public static string GetHomeFolder()
	{
		string fullPath = Path.GetFullPath("./QHome");
		if (!Directory.Exists(fullPath))
		{
			Directory.CreateDirectory(fullPath);
		}
		return fullPath;
	}

	internal static bool ieLpJiLU79M2vZqCgtw()
	{
		return RyILnfLMm8J1E0hS1hf == null;
	}
}
