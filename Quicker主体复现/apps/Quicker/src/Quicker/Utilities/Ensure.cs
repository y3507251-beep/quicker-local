using System;

namespace Quicker.Utilities;

public static class Ensure
{
	internal static object wu4pafFYtVbn9muv5tRX;

	public static void NotNull(object value, string paramName)
	{
		if (value == null)
		{
			throw new ArgumentNullException(paramName);
		}
	}

	public static void Equal<T>(T value1, T value2, string message)
	{
		if (!value1.Equals(value2))
		{
			throw new ArgumentException(message);
		}
	}

	public static void IsTrue(bool value, string message)
	{
		if (!value)
		{
			throw new ArgumentException(message);
		}
	}

	internal static bool N2nGl8FYS99dl9kplZA3()
	{
		return wu4pafFYtVbn9muv5tRX == null;
	}
}
