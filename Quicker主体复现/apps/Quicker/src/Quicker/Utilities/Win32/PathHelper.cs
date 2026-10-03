using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using PPX3CDMJHNv8RxgxHm3;

namespace Quicker.Utilities.Win32;

public static class PathHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public char[] U6k2SHBDbpD;

		private static _003C_003Ec__DisplayClass0_0 J74DMVyEqwPMhERMgJNH;

		internal bool zEO2SGy473w(char ch)
		{
			return U6k2SHBDbpD.Contains(ch);
		}

		internal bool fv72SsFpPwE(char ch)
		{
			return U6k2SHBDbpD.Contains(ch);
		}

		internal static bool MuOQjcyEi4GS5uAhyAj3()
		{
			return J74DMVyEqwPMhERMgJNH == null;
		}
	}

	private static object JcuEKxFM1fcr0NQUoUbD;

	public static (bool isSuccess, char ch) ValidatePath(string path)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.U6k2SHBDbpD = Path.GetInvalidPathChars();
		char c = path.FirstOrDefault(_003C_003Ec__DisplayClass0_.zEO2SGy473w);
		if (c != 0)
		{
			return (isSuccess: false, ch: c);
		}
		_003C_003Ec__DisplayClass0_.U6k2SHBDbpD = Path.GetInvalidFileNameChars();
		c = Path.GetFileName(path).FirstOrDefault(_003C_003Ec__DisplayClass0_.fv72SsFpPwE);
		if (c != 0)
		{
			return (isSuccess: false, ch: c);
		}
		return (isSuccess: true, ch: '\0');
	}

	public static string RemoveZeroWidthChar(string path)
	{
		return path?.Trim().TrimStart('\u200b', '\u202a', '\ufeff');
	}

	public static string RemoveInvalidCharsFromFileName(string filename)
	{
		if (string.IsNullOrEmpty(filename))
		{
			return filename;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c in invalidFileNameChars)
		{
			filename = filename.Replace(c.ToString(), "");
		}
		return filename;
	}

	public static string GetSpecialFolderDisplayName(Environment.SpecialFolder folder)
	{
		return dZnrTDMKnfykVqF8Pjr.A9xLF7T2CPg(folder);
	}

	public static string PreProcessPath(this string path, bool removeZeroWidthChar, bool expandEnvironmentVariables, bool replaceInvalidCharInFileName)
	{
		if (removeZeroWidthChar)
		{
			path = RemoveZeroWidthChar(path);
		}
		if (expandEnvironmentVariables)
		{
			if (WZJWEjFMK6RSiB6ISM6x())
			{
				switch (0)
				{
				}
			}
			path = Environment.ExpandEnvironmentVariables(path);
		}
		if (replaceInvalidCharInFileName)
		{
			string fileName = Path.GetFileName(path);
			string directoryName = Path.GetDirectoryName(path);
			path = ((!string.IsNullOrEmpty(directoryName)) ? Path.Combine(directoryName, RemoveInvalidCharsFromFileName(fileName)) : RemoveInvalidCharsFromFileName(fileName));
		}
		return path;
	}

	internal static bool WZJWEjFMK6RSiB6ISM6x()
	{
		return JcuEKxFM1fcr0NQUoUbD == null;
	}
}
