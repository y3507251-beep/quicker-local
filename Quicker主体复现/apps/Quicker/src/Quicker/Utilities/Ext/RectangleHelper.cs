using System;
using System.Drawing;

namespace Quicker.Utilities.Ext;

public static class RectangleHelper
{
	private static object QyXueOFISNPLg05kXN58;

	public static string ToValue(this Rectangle rect)
	{
		return $"{rect.Left},{rect.Top},{rect.Right},{rect.Bottom}";
	}

	public static bool TryParseRectangleData(string area, out Rectangle rectangle, bool includeRightBottomBorder)
	{
		rectangle = Rectangle.Empty;
		if (string.IsNullOrEmpty(area))
		{
			return false;
		}
		int num = (includeRightBottomBorder ? 1 : 0);
		string[] array = area.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 4)
		{
			return false;
		}
		if (int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2))
		{
			int num2 = 0;
			if (QyXueOFISNPLg05kXN58 != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (int.TryParse(array[2], out var result3) && int.TryParse(array[3], out var result4))
			{
				rectangle = new Rectangle(result, result2, result3 - result + num, result4 - result2 + num);
				return true;
			}
		}
		return false;
	}

	static RectangleHelper()
	{
	}

	internal static bool d5djKLFIwO2eRkbIculp()
	{
		return QyXueOFISNPLg05kXN58 == null;
	}

	internal static void zpr0WNFIm69TM8JTFhZq()
	{
	}
}
